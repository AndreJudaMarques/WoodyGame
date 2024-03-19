using UnityEngine;
using UnityEngine.UI;

public class Removepainerscript : MonoBehaviour
{
    public GameObject canvasPanel; // Referência ao GameObject do canvas panel que você deseja remover
    public Timer timerScript; // Referência ao script do Timer

    void Update()
    {
        // Verifica se a tecla Espaço foi pressionada
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Verifica se o canvasPanel não é nulo e está ativo
            if (canvasPanel != null && canvasPanel.activeSelf)
            {
                // Desativa o canvasPanel
                canvasPanel.SetActive(false);

                // Inicia o timer chamando o método IniciarTimer do script Timer
                timerScript.IniciarTimer();
            }
        }
    }
}