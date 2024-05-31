using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollision : MonoBehaviour
{
    public GameObject lightBulb;
    public ParticleSystem particles;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            lightBulb.SetActive(false);
            particles.Play();
        }
    }
}
