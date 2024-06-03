using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket2 : MonoBehaviour
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
            correctSound.Play();
            puzzleManager.Socket2 = true;
        }
        else
        {
            incorrectSound.Play();
            puzzleManager.Socket2 = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Reptile")
        {
            correct = true;
        }
        else
        {
            correct = false;
        }
    }
}
