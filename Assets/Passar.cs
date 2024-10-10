using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passar : MonoBehaviour
{
    public Vector3 targetScale = new Vector3(1.5f, 1.5f, 1.5f); // Escala alvo ao passar o mouse
    public float easingSpeed = 5f; // Velocidade do easing
    private Vector3 originalScale; // Escala original do objeto
    private bool isMouseOver = false; // Verifica se o mouse está sobre o objeto

    void Start()
    {
        // Salva a escala original do objeto no início
        originalScale = transform.localScale;
    }

    void Update()
    {
        // Se o mouse estiver sobre o objeto, faz o easing para a escala alvo
        if (isMouseOver)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * easingSpeed);
        }
        else
        {
            // Quando o mouse sair, retorna para a escala original com easing
            transform.localScale = Vector3.Lerp(transform.localScale, originalScale, Time.deltaTime * easingSpeed);
        }
    }

    void OnMouseOver()
    {
        // Quando o mouse estiver sobre o objeto, ativa o easing
        isMouseOver = true;
    }

    void OnMouseExit()
    {
        // Quando o mouse sair do objeto, desativa o easing
        isMouseOver = false;
    }
}
