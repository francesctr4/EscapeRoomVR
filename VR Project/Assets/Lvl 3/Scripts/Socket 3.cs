using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket3 : MonoBehaviour
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
            puzzleManager.Socket3 = true;
        }
        else
        {
            incorrectSound.Play();
            puzzleManager.Socket3 = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Bird")
        {
            correct = true;
        }
        else
        {
            correct = false;
        }
    }
}
