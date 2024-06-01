using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Socket1 : MonoBehaviour
{
    public SymbolsPuzzleManager puzzleManager;
    private bool correct = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SolvePuzzle()
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
