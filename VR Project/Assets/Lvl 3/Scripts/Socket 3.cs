using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket3 : MonoBehaviour
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
            puzzleManager.Socket3 = true;
        }
        else
        {
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
