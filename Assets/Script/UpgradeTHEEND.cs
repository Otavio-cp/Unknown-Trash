using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpgradeTHEEND : MonoBehaviour
{
    static int preço = 4500;
    [SerializeField] TMP_Text _preço;

    private void Awake()
    {
        _preço.text = $"Score value: {preço}";
    }

    public void updateFinal()
    {
        if (Player.itensPegos >= preço)
        {
            SceneManager.LoadScene("Vitoria");
        }
    }
}
