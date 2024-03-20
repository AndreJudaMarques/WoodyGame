using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;

public class Botaoplay : MonoBehaviour
{
    

    void Start() 
    {
    
    }

void Update() 
    {
        if(UnityEngine.Input.GetKeyDown(KeyCode.Space))
        {
            Carregarcena();
        }
    }


    public void Carregarcena()
    {
        //Debug.Log("Botao foi apertado"); teste2
        SceneManager.LoadSceneAsync("cenalevel1");
        
    }
   
}
