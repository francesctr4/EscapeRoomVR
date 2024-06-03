using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_entrefiguras : MonoBehaviour
{
    public GameObject figura;

    public bool collision;
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == figura)
        {
            collision = true;   
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == figura)
        {
            collision = true;
        }
    }

}
