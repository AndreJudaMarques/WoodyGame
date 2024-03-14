using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 5f; // velocidade de mov do player
    public float JumpForce;

    void Update()
    {
        move();
    }

    void move()
    {
        //
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Speed * Time.deltaTime);
            // Garanta que a escala do objeto está correta
            transform.localScale = new Vector3(1, 1, 1);
        }

         // Movimento para a esquerda
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Speed * Time.deltaTime);
            // inverte a escala do objeto horizontalmente
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
