using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Fov : MonoBehaviour
{
    [Header("Movimento")]
    public float moveSpeed = 5f;

    [Header("Mira")]
    [Tooltip("Ligado: olha para o mouse. Desligado: olha para onde está andando.")]
    public bool faceMouse = true;
    public float turnSpeed = 720f; // graus por segundo

    [Header("Referências")]
    public FieldOfView2D fov;      // usado só para pegar o facingOffset
    public Camera cam;
    public float cameraSmooth = 10f;

    [Header("Objetivo")]
    public UnityEvent onReachGoal;

    Rigidbody2D rb;
    Vector2 input;
    float facingOffset = 90f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        rb.freezeRotation = true;
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        rb.interpolation = RigidbodyInterpolation2D.Interpolate;

        if (cam == null) cam = Camera.main;
        if (fov == null) fov = GetComponent<FieldOfView2D>();
        if (fov != null) facingOffset = fov.facingOffset;

        // O player fica acima da escuridão do FOV (que usa ordem 100 e 101)
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr != null) sr.sortingOrder = 102;
    }

    void Update()
    {
        input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        // Direção para onde olhar
        Vector2 lookDir = Vector2.zero;
        if (faceMouse && cam != null)
        {
            Vector2 mouseWorld = cam.ScreenToWorldPoint(Input.mousePosition);
            lookDir = mouseWorld - (Vector2)transform.position;
        }
        else
        {
            lookDir = input;
        }

        if (lookDir.sqrMagnitude > 0.001f)
        {
            float targetAngle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - facingOffset;
            float angle = Mathf.MoveTowardsAngle(transform.eulerAngles.z, targetAngle, turnSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0f, 0f, angle);
        }
    }

    void FixedUpdate()
    {
        // Unity 2022 ou anterior: troque linearVelocity por velocity
        rb.linearVelocity = input * moveSpeed;
    }

    void LateUpdate()
    {
        if (cam == null) return;

        Vector3 target = new Vector3(transform.position.x, transform.position.y, cam.transform.position.z);
        float t = 1f - Mathf.Exp(-cameraSmooth * Time.deltaTime);
        cam.transform.position = Vector3.Lerp(cam.transform.position, target, t);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Finish"))
        {
            Debug.Log("Saiu do labirinto!");
            onReachGoal?.Invoke();
        }
    }
}
