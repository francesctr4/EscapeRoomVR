using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SymbolsPuzzleManager : MonoBehaviour
{
    public bool Socket1 = false;
    public bool Socket2 = false;
    public bool Socket3 = false;
    public bool Socket4 = false;

    public LVL3Manager lvl3Manager;

    void Start()
    {
        
    }
    void Update()
    {
        if (Socket1 && Socket2 && Socket3 && Socket4)
        {
            lvl3Manager.ActivatePuzzle3();
        }
    }
}
