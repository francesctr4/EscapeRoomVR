using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class puzzle1_complete : MonoBehaviour
{
    private bool audio_played = false;
    public int final = 0;

    public AudioSource win;

    public GameObject puzzle3;

    public Collision_entrefiguras triangulo;
    public Collision_entrefiguras circulo;
    public Collision_entrefiguras rectangulo;
    public Collision_entrefiguras cuadrado;

    private void Update()
    {
        if (triangulo.collision && circulo.collision && rectangulo.collision && cuadrado.collision && !audio_played)
        {
            // Reproducir el sonido 'win' solo si no se ha reproducido antes
            win.Play();
            audio_played = true;
            puzzle3.SetActive(true);
        }
    }

}