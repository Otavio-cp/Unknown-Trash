using System.Collections.Generic;
using UnityEngine;

public class FieldOfView2D : MonoBehaviour
{
    [Header("Visão")]
    public float viewRadius = 6f;
    [Range(0, 360)] public float viewAngle = 90f;

    [Tooltip("Para onde o objeto olha. 90 = olha para cima (transform.up). Use 0 se o sprite olha para a direita (transform.right).")]
    public float facingOffset = 90f;

    [Header("Layers")]
    public LayerMask targetMask;    // quem pode ser visto (player, inimigos...)
    public LayerMask obstacleMask;  // o que bloqueia a visão (paredes, caixas...)

    [Header("Detecção")]
    public float detectionInterval = 0.1f;

    [Header("Malha visual (opcional)")]
    public MeshFilter viewMeshFilter;      // objeto filho com MeshFilter + MeshRenderer
    public float meshResolution = 1f;      // raios por grau
    public int edgeResolveIterations = 4;  // precisão da borda nas quinas
    public float edgeDstThreshold = 0.5f;

    [HideInInspector] public List<Transform> visibleTargets = new List<Transform>();

    Mesh viewMesh;

    // Ângulo (em graus) para onde o objeto está olhando
    float FacingAngle => transform.eulerAngles.z + facingOffset;

    // Direção "frente" do objeto
    public Vector2 Forward => DirFromAngle(FacingAngle);

    void Start()
    {
        if (viewMeshFilter != null)
        {
            viewMesh = new Mesh { name = "View Mesh 2D" };
            viewMeshFilter.mesh = viewMesh;
        }

        InvokeRepeating(nameof(FindVisibleTargets), 0f, detectionInterval);
    }

    void LateUpdate()
    {
        if (viewMesh != null) DrawFieldOfView();
    }

    // ---------------------------------------------------------------
    // Detecção de alvos
    // ---------------------------------------------------------------
    void FindVisibleTargets()
    {
        visibleTargets.Clear();

        Vector2 origin = transform.position;
        Collider2D[] targetsInRadius = Physics2D.OverlapCircleAll(origin, viewRadius, targetMask);

        foreach (Collider2D col in targetsInRadius)
        {
            Transform target = col.transform;
            Vector2 toTarget = (Vector2)target.position - origin;
            float dstToTarget = toTarget.magnitude;
            Vector2 dirToTarget = toTarget / dstToTarget;

            // Está dentro do ângulo do cone?
            if (Vector2.Angle(Forward, dirToTarget) < viewAngle / 2f)
            {
                // Se o raio NÃO bater em barreira, o alvo é visível
                if (!Physics2D.Raycast(origin, dirToTarget, dstToTarget, obstacleMask))
                {
                    visibleTargets.Add(target);
                }
            }
        }
    }

    // ---------------------------------------------------------------
    // Malha do cone (para na barreira)
    // ---------------------------------------------------------------
    void DrawFieldOfView()
    {
        int stepCount = Mathf.Max(1, Mathf.RoundToInt(viewAngle * meshResolution));
        float stepAngleSize = viewAngle / stepCount;

        List<Vector2> viewPoints = new List<Vector2>();
        ViewCastInfo oldViewCast = new ViewCastInfo();

        for (int i = 0; i <= stepCount; i++)
        {
            float angle = FacingAngle - viewAngle / 2f + stepAngleSize * i;
            ViewCastInfo newViewCast = ViewCast(angle);

            if (i > 0)
            {
                bool edgeDstExceeded = Mathf.Abs(oldViewCast.dst - newViewCast.dst) > edgeDstThreshold;

                // Mudou de "bateu" para "não bateu" (quina da parede): refina a borda
                if (oldViewCast.hit != newViewCast.hit || (oldViewCast.hit && newViewCast.hit && edgeDstExceeded))
                {
                    EdgeInfo edge = FindEdge(oldViewCast, newViewCast);
                    viewPoints.Add(edge.pointA);
                    viewPoints.Add(edge.pointB);
                }
            }

            viewPoints.Add(newViewCast.point);
            oldViewCast = newViewCast;
        }

        Transform meshT = viewMeshFilter.transform;
        float z = transform.position.z;

        int vertexCount = viewPoints.Count + 1;
        Vector3[] vertices = new Vector3[vertexCount];
        int[] triangles = new int[(vertexCount - 2) * 3];

        vertices[0] = meshT.InverseTransformPoint(transform.position);
        for (int i = 0; i < vertexCount - 1; i++)
        {
            Vector3 worldPoint = new Vector3(viewPoints[i].x, viewPoints[i].y, z);
            vertices[i + 1] = meshT.InverseTransformPoint(worldPoint);

            if (i < vertexCount - 2)
            {
                // Ordem horária (visto pela câmera 2D) para a face aparecer
                triangles[i * 3] = 0;
                triangles[i * 3 + 1] = i + 2;
                triangles[i * 3 + 2] = i + 1;
            }
        }

        viewMesh.Clear();
        viewMesh.vertices = vertices;
        viewMesh.triangles = triangles;
        viewMesh.RecalculateNormals();
    }

    // Lança um raio em um ângulo; se bater em barreira, o ponto final é o ponto de impacto
    ViewCastInfo ViewCast(float globalAngle)
    {
        Vector2 origin = transform.position;
        Vector2 dir = DirFromAngle(globalAngle);

        RaycastHit2D hit = Physics2D.Raycast(origin, dir, viewRadius, obstacleMask);
        if (hit)
            return new ViewCastInfo(true, hit.point, hit.distance, globalAngle);

        return new ViewCastInfo(false, origin + dir * viewRadius, viewRadius, globalAngle);
    }

    // Busca binária entre dois raios para achar a quina exata da barreira
    EdgeInfo FindEdge(ViewCastInfo minViewCast, ViewCastInfo maxViewCast)
    {
        float minAngle = minViewCast.angle;
        float maxAngle = maxViewCast.angle;
        Vector2 minPoint = minViewCast.point;
        Vector2 maxPoint = maxViewCast.point;

        for (int i = 0; i < edgeResolveIterations; i++)
        {
            float angle = (minAngle + maxAngle) / 2f;
            ViewCastInfo newViewCast = ViewCast(angle);

            bool edgeDstExceeded = Mathf.Abs(minViewCast.dst - newViewCast.dst) > edgeDstThreshold;
            if (newViewCast.hit == minViewCast.hit && !edgeDstExceeded)
            {
                minAngle = angle;
                minPoint = newViewCast.point;
            }
            else
            {
                maxAngle = angle;
                maxPoint = newViewCast.point;
            }
        }

        return new EdgeInfo(minPoint, maxPoint);
    }

    // Ângulo em graus (anti-horário a partir do eixo X) -> vetor direção
    public Vector2 DirFromAngle(float angleInDegrees)
    {
        float rad = angleInDegrees * Mathf.Deg2Rad;
        return new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
    }

    public struct ViewCastInfo
    {
        public bool hit;
        public Vector2 point;
        public float dst;
        public float angle;

        public ViewCastInfo(bool hit, Vector2 point, float dst, float angle)
        {
            this.hit = hit;
            this.point = point;
            this.dst = dst;
            this.angle = angle;
        }
    }

    public struct EdgeInfo
    {
        public Vector2 pointA;
        public Vector2 pointB;

        public EdgeInfo(Vector2 pointA, Vector2 pointB)
        {
            this.pointA = pointA;
            this.pointB = pointB;
        }
    }

    // Gizmos para visualizar no Scene View
    void OnDrawGizmosSelected()
    {
        Vector3 pos = transform.position;

        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(pos, viewRadius);

        Vector2 a = DirFromAngle(FacingAngle - viewAngle / 2f) * viewRadius;
        Vector2 b = DirFromAngle(FacingAngle + viewAngle / 2f) * viewRadius;
        Gizmos.DrawLine(pos, pos + (Vector3)a);
        Gizmos.DrawLine(pos, pos + (Vector3)b);

        Gizmos.color = Color.red;
        foreach (Transform t in visibleTargets)
            if (t != null) Gizmos.DrawLine(pos, t.position);
    }
}
