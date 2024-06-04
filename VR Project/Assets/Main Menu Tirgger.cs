using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuTirgger : MonoBehaviour
{
    public FadetoBlack fadetoBlack;

    public bool masterbool;
    void Start()
    {
        
    }

    void Update()
    {
        if (masterbool)
        {
            fadetoBlack.ChangeScene();
            masterbool = false; 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            fadetoBlack.ChangeScene();
        }
    }
}
