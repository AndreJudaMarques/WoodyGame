using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float tempoTotal = 60f; // Tempo total em segundos (1 minuto)
    private float tempoAtual;
    private bool timerIniciado = false;

    private void Start()
    {
        tempoAtual = tempoTotal;
    }

    private void Update()
    {
        if (timerIniciado)
        {
            tempoAtual -= Time.deltaTime;

            int minutos = Mathf.FloorToInt(tempoAtual / 60f);
            int segundos = Mathf.FloorToInt(tempoAtual % 60f);

            timerText.text = string.Format("{0:00}:{1:00}", minutos, segundos);

            if (tempoAtual <= 0f)
            {
                Debug.Log("Tempo acabou! Chamando Game Over...");
                // Chama o método GameOver do GameManager quando o tempo acabar
                
            }
        }
    }

    public void IniciarTimer()
    {
        timerIniciado = true;
    }
}
