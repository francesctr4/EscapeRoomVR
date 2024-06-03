using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket2 : MonoBehaviour
{
    public SymbolsPuzzleManager puzzleManager;
    private bool correct = false;

    void Start()
    {

    }

    void Update()
    {
        if (correct)
        {
            puzzleManager.Socket2 = true;
        }
        else
        {
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
