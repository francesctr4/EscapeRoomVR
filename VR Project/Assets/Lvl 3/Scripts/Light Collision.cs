using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollision : MonoBehaviour
{
    public GameObject lightBulb;
    public ParticleSystem particles;
    public LVL3Manager lVL3Manager;

    public AudioSource explosion;
    public AudioSource puzzleComplete;

    public bool masterBool = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (masterBool)
        {
            particles.Play();
            explosion.Play();
            lightBulb.SetActive(false);

            StartCoroutine(ExecuteAfterTime(2.0f));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            particles.Play();
            explosion.Play();
            lightBulb.SetActive(false);

            StartCoroutine(ExecuteAfterTime(2.0f));
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        puzzleComplete.Play();
        lVL3Manager.ActivatePuzzle2();
    }
}
