
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text currentScoreText;
    public TMP_Text bestScoreText;

    void Update()
    {
        if (GameManager.singleton == null)
        {
            Debug.LogError("NO HAY GAME MANAGER EN LA ESCENA");
            return;
        }

        if (currentScoreText == null)
        {
            Debug.LogError("NO ASIGNASTE currentScoreText");
            return;
        }

        if (bestScoreText == null)
        {
            Debug.LogError("NO ASIGNASTE bestScoreText");
            return;
        }

        currentScoreText.text = "Score: " + GameManager.singleton.currentScore;
        bestScoreText.text = "Best: " + GameManager.singleton.bestScore;
    }
}
