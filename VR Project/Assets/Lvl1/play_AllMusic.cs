using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_AllMusic : MonoBehaviour
{
    public AudioSource music;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Hands")
        {
            music.Play();
            Debug.Log("!·aSDFASDFGSA");
        }
    }
}
