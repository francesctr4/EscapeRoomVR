using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket4 : MonoBehaviour
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
            puzzleManager.Socket4 = true;
        }
        else
        {
            incorrectSound.Play();
            puzzleManager.Socket4 = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Dragon")
        {
            correct = true;
        }
        else
        {
            correct = false;
        }
    }
}
