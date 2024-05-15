using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnball : MonoBehaviour
{

    public GameObject collision;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "Hands")
        {
            collision.gameObject.SetActive(false);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (gameObject.tag == "Hands")
        {
            collision.gameObject.SetActive(true);
        }
    }
}
