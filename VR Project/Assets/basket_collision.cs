using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket_collision : MonoBehaviour
{
    public GameObject basket;
    public GameObject door;
    public GameObject particulas;

    public AudioSource audio_win;
    // Start is called before the first frame update

    private void OnTriggerExit(Collider other)
    {
        if (basket != null)
        {
            if (other.gameObject == basket)
            {
                door.SetActive(true);
                audio_win.Play();   
            }

        }
    }

   
}
