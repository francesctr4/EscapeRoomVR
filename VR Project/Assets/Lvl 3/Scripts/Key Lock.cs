using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyLock : MonoBehaviour
{
    public ParticleSystem smoke;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        // Cambiar de escena
        SceneManager.LoadScene(0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Key")
        {
            //Sonido puerta 
            //Sistema de particulas
            smoke.Play();

            StartCoroutine(ExecuteAfterTime(5.0f));
        }
    }
}
