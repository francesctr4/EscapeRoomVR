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
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    Puzzle1Prefab.SetActive(true);
        //    Puzzle2Prefab.SetActive(false);
        //    Puzzle3Prefab.SetActive(false);
        //}
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    Puzzle1Prefab.SetActive(false);
        //    Puzzle2Prefab.SetActive(true);
        //    Puzzle3Prefab.SetActive(false);
        //}
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    Puzzle1Prefab.SetActive(false);
        //    Puzzle2Prefab.SetActive(false);
        //    Puzzle3Prefab.SetActive(true);
        //}
    }

    public void ActivatePuzzle1()
    {
        Puzzle1Prefab.SetActive(true);
        Puzzle2Prefab.SetActive(false);
        Puzzle3Prefab.SetActive(false);
    }

    public void ActivatePuzzle2()
    {
        Puzzle1Prefab.SetActive(false);
        Puzzle2Prefab.SetActive(true);
        Puzzle3Prefab.SetActive(false);
    }

    public void ActivatePuzzle3()
    {
        Puzzle1Prefab.SetActive(false);
        Puzzle2Prefab.SetActive(false);
        Puzzle3Prefab.SetActive(true);
    }
}
