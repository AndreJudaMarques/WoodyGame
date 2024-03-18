using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject("GameManager");
                    instance = obj.AddComponent<GameManager>();
                }
            }
            return instance;
        }
    }

    // Método GameOver para ser chamado quando o tempo acabar
    public void GameOver()
    {
        Debug.Log("Game Over!"); // Adicione sua lógica de Game Over aqui
        // Por exemplo, recarregar a cena
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
