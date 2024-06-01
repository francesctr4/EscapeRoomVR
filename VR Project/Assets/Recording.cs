using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recording : MonoBehaviour
{
    // Intervalo de tiempo en segundos entre los cambios de estado
    public float blinkInterval = 0.5f;

    // Tiempo acumulado
    private float timeElapsed;

    // Referencia al componente MeshRenderer
    private MeshRenderer meshRenderer;

    // Método de inicialización
    void Start()
    {
        // Inicializar el tiempo acumulado
        timeElapsed = 0f;

        // Obtener el componente MeshRenderer del objeto
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Método que se llama una vez por frame
    void Update()
    {
        // Incrementar el tiempo acumulado
        timeElapsed += Time.deltaTime;

        // Si el tiempo acumulado es mayor que el intervalo de parpadeo
        if (timeElapsed >= blinkInterval)
        {
            // Alternar el estado del MeshRenderer
            meshRenderer.enabled = !meshRenderer.enabled;

            // Reiniciar el tiempo acumulado
            timeElapsed = 0f;
        }
    }
}
