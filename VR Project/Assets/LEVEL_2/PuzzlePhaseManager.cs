using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePhaseManager : MonoBehaviour
{
    public GameObject phase1Object;
    public bool enablePhase1;

    public GameObject phase2Object;
    public bool enablePhase2;

    public GameObject phase3Object;
    public bool enablePhase3;

    // Start is called before the first frame update
    void Start()
    {
        EnablePhase2();
    }

    // Update is called once per frame
    void Update()
    {
        phase1Object.SetActive(enablePhase1);
        phase2Object.SetActive(enablePhase2);
        phase3Object.SetActive(enablePhase3);
    }

    public void EnablePhase1()
    {
        ResetPuzzles();
        enablePhase1 = true;
    }

    public void EnablePhase2()
    {
        ResetPuzzles();
        enablePhase2 = true;
    }

    public void EnablePhase3()
    {
        ResetPuzzles();
        enablePhase3 = true;
    }

    public void ResetPuzzles()
    {
        enablePhase1 = false;
        enablePhase2 = false;
        enablePhase3 = false;
    }
}
