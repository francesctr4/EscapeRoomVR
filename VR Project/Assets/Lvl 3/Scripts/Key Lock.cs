using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyLock : MonoBehaviour
{
    public ParticleSystem smoke;
    public bool open;
    public int sceneNumber;
    public AudioSource keySound;
    private bool firstLoad = false;

    public FadetoBlack fadetoBlack;

    public bool masterBool = false;

    void Start()
    {
        sceneNumber = 0;
    }

    void Update()
    {
        if (open || masterBool)
        {
            //Sonido puerta 
            keySound.Play();
            //Sistema de particulas
            smoke.Play();

            StartCoroutine(ExecuteAfterTime(10.0f));
            
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        // Cambiar de escena
        //if (sceneNumber < 3)
        //{
        //    sceneNumber++;
        //}
        //else
        //{
        //    sceneNumber = 0;
        //}

        //SceneManager.LoadScene(sceneNumber);

        if (!firstLoad)
        {
            fadetoBlack.ChangeScene();
            firstLoad = true;
        }
        //SceneManager.LoadScene(0);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Key")
        {
            open = true;
        }
        else
        {
            open = false;
        }
    }
}
