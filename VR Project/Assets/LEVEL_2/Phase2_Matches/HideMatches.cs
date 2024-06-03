using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMatches : MonoBehaviour
{
    void Start()
    {
        // Find all game objects in the scene
        GameObject[] allObjects = FindObjectsOfType<GameObject>();

        // Iterate through each object and disable those with "match" in their name
        foreach (GameObject obj in allObjects)
        {
            if (obj.name.Contains("Match"))
            {
                obj.SetActive(false);
            }
        }
    }
}
