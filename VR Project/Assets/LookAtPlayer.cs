using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform player; // Referencia al transform del jugador
    public Vector3 rotationOffset; // Para ajustar la orientación final

    void Start()
    {
        // Si no se ha asignado un jugador en el Inspector, buscar el objeto con el tag "Player"
        if (player == null)
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            if (playerObj != null)
            {
                player = playerObj.transform;
            }
            else
            {
                Debug.LogError("No se encontró ningún objeto con el tag 'Player'.");
            }
        }
    }

    void Update()
    {
        if (player != null)
        {
            // Hace que el objeto mire hacia el jugador
            Vector3 direction = player.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);

            // Aplicar el offset de rotación
            rotation *= Quaternion.Euler(rotationOffset);

            // Aplicar la rotación suavemente
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * 5f);
        }
    }
}