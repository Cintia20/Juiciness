using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicar : MonoBehaviour
{
    public float fadeDuration = 1.0f;  // Duração do efeito de fade

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Detecta quando o personagem é clicado
    void OnMouseDown()
    {
        // Inicia a corrotina para fazer o fade out e desaparecer
        StartCoroutine(FadeOut());
    }

    // Corrotina que realiza o efeito de fade out
    IEnumerator FadeOut()
    {
        Renderer renderer = GetComponent<Renderer>();  // Acessa o componente Renderer do personagem
        Color originalColor = renderer.material.color;  // Salva a cor original do material
        float elapsedTime = 0.0f;

        // Enquanto o tempo decorrido for menor que a duração do fade
        while (elapsedTime < fadeDuration)
        {
            // Calcula a nova transparência com base no tempo decorrido
            float alpha = Mathf.Lerp(1.0f, 0.0f, elapsedTime / fadeDuration);

            // Aplica a nova cor com a transparência alterada
            renderer.material.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);

            // Aumenta o tempo decorrido
            elapsedTime += Time.deltaTime;

            // Espera até o próximo frame
            yield return null;
        }

        // Certifica-se de que a transparência esteja totalmente zerada
        renderer.material.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0.0f);

        // Desativa o objeto após o fade out
        gameObject.SetActive(false);
    }
}
