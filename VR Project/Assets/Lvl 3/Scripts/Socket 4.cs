using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket4 : MonoBehaviour
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
            puzzleManager.Socket4 = true;
        }
        else
        {
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
