using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuTirgger : MonoBehaviour
{
    public FadetoBlack fadetoBlack;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            fadetoBlack.ChangeScene();
        }
    }
}
