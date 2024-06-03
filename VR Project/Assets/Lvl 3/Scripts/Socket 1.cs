using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Socket1 : MonoBehaviour
{
    public SymbolsPuzzleManager puzzleManager;
    private bool correct = false;

    public AudioSource correctSound;
    public AudioSource incorrectSound;


    void Start()
    {
        
    }

    void Update()
    {
        if (correct)
        {
            // Sonido correcto
            correctSound.Play();
            puzzleManager.Socket1 = true;
        }
        else
        {
            // Sonido incorrecto
            incorrectSound.Play();
            puzzleManager.Socket1 = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Fish")
        {
            correct = true;
        }
        else
        {
            correct = false;
        }
    }
}
