using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMatches : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Start the coroutine to hide matches every 3 seconds
        StartCoroutine(HideMatchesCoroutine());
    }

    // Coroutine to hide matches every 3 seconds
    IEnumerator HideMatchesCoroutine()
    {
        while (true)
        {
            // Wait for 3 seconds
            yield return new WaitForSeconds(1);

            // Find all game objects in the scene
            GameObject[] allObjects = FindObjectsOfType<GameObject>();

            // Iterate through each object and disable those with "Match" in their name
            foreach (GameObject obj in allObjects)
            {
                if (obj.name.Contains("Match"))
                {
                    obj.SetActive(false);
                }
            }
        }
    }
}
