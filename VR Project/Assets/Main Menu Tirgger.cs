using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuTirgger : MonoBehaviour
{
    private FadetoBlack fadetoBlack;
    private GameObject fade;

    public bool masterbool;
    void Start()
    {
        fade = GameObject.Find("Fader");
        fadetoBlack = fade.GetComponent<FadetoBlack>();
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
