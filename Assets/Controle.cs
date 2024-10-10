using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour
{
    public float velocidade = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Recebe o input do jogador
        float horizontal = Input.GetAxis("Horizontal"); // A e D (esquerda e direita)
        float vertical = Input.GetAxis("Vertical"); // W e S (frente e trás)

        // Movimenta o personagem com base no input
        Vector3 movimento = new Vector3(horizontal, 0, vertical) * velocidade * Time.deltaTime;

        // Aplica o movimento
        transform.Translate(movimento);
    }
}