using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class puzzle1_complete : MonoBehaviour
{
    public bool Triangulo;
    public bool Circulo;
    public bool Rectangulo;
    public bool Cuadrado;

    private void Start()
    {
        Triangulo = false;
        Circulo = false;
        Rectangulo = false;
        Cuadrado = false;
    }
    private void Update()
    {
        if(Triangulo && Circulo && Rectangulo && Cuadrado)
        {
            //Activar botones
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Triangulo")
        {
            Triangulo = true;
        }
        if (collision.gameObject.tag == "Cuadrado")
        {
            Circulo = true;
        }
        if (collision.gameObject.tag == "Circulo")
        {
            Rectangulo = true;
        }
        if (collision.gameObject.tag == "Rectangulo")
        {
            Cuadrado = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Triangulo")
        {
            Triangulo = false;
        }
        if (collision.gameObject.tag == "Cuadrado")
        {
            Circulo = false;
        }
        if (collision.gameObject.tag == "Circulo")
        {
            Rectangulo = false;
        }
        if (collision.gameObject.tag == "Rectangulo")
        {
            Cuadrado = false;
        }
    }
}