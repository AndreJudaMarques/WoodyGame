using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        // Verifica se o objeto que entrou em contato com o collider tem a tag "Player"
        if(other.CompareTag("Player"))
        {
            ReiniciarCena();
        }
    }

    private void ReiniciarCena()
    {
        // Obtém o índice da cena atual e carrega a cena novamente
        int cenaAtual = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(cenaAtual);
    }
}
