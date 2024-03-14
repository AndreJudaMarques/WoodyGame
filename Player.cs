using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 5f; // velocidade de mov do player
    public float JumpForce;
    private bool estaNoChao; // controla se o jogador esta no chao

    void Update()
    {
        move();
        if (Input.GetKeyDown(KeyCode.UpArrow) && estaNoChao)
        {
            Jump();
        }
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

    void Jump()
    {
        // aplica força vertical para simular salto
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // verifica se o jogador esta no chao
        if (collision.gameObject.CompareTag("Chao"))
        {
            estaNoChao = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // verifica se jogador nao esta no chao
        if (collision.gameObject.CompareTag("Chao"))
        {
            estaNoChao = false;
        }
        
    }
}
