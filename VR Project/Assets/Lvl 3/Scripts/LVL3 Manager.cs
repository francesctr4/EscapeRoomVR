using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVL3Manager : MonoBehaviour
{
    public GameObject Puzzle1Prefab;
    public GameObject Puzzle2Prefab;
    public GameObject Puzzle3Prefab;

    void Start()
    {
        ActivatePuzzle1();
    }

    void Update()
    {

    }

    public void ActivatePuzzle1()
    {
        Puzzle1Prefab.SetActive(true);
    }

    public void ActivatePuzzle2()
    {
        Puzzle1Prefab.SetActive(false);
        Puzzle2Prefab.SetActive(true);
    }

    public void ActivatePuzzle3()
    {
        Puzzle2Prefab.SetActive(false);
        Puzzle3Prefab.SetActive(true);
    }
}
