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
            puzzleManager.Socket1 = true;
        }
        else
        {
            puzzleManager.Socket1 = false;
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
