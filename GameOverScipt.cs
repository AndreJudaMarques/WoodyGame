using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScipt : MonoBehaviour
{
    public GameObject gameOver;
    public static GameOverScipt instance;

    void Start()
    {
        instance = this;
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }
    
}
