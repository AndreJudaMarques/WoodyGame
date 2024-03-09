using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botaoplay : MonoBehaviour
{

    public void Carregarlvl1()
    {
        //Debug.Log("Botao foi apertado"); teste
        SceneManager.LoadSceneAsync("cenalevel1");
        
    }

   
}
