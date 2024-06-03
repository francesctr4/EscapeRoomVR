using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class audio_manager : MonoBehaviour
{
    public AudioSource all;
    public AudioSource script1;
    public AudioSource script2;
    public AudioSource script3;
    public AudioSource win;

    // Variables para controlar el estado de reproducci�n de los audios
    private bool audio_1_played;
    private bool audio_2_played;
    public bool audio_2_ready;
    public bool audio_3_ready;
    public bool complete;

    public GameObject ball;

    private Coroutine executeAfterTimeCoroutine;

    // M�todo para ejecutar acciones despu�s de un tiempo
    private IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        FunctionToExecute();
        executeAfterTimeCoroutine = null; // Restablecer la referencia del coroutine
    }

    // M�todo para ejecutar una acci�n cuando se completa la reproducci�n de los audios
    private void FunctionToExecute()
    {
        win.Play();
        ball.SetActive(true);
    }

    void Update()
    {
        // Detener la reproducci�n de los otros audios si uno est� reproduci�ndose
        if (script1.isPlaying)
        {
            audio_1_played = true;
            script2.Stop();
            script3.Stop();
            all.Stop();
        }
        if (script2.isPlaying)
        {
            audio_2_played = true;
            script1.Stop();
            script3.Stop();
            all.Stop();
        }
        if (script3.isPlaying)
        {
            script1.Stop();
            script2.Stop();
            all.Stop();
        }

        // L�gica para controlar el estado de reproducci�n de los audios
        if (script1.isPlaying && !audio_2_ready && !audio_3_ready && audio_1_played)
        {
            audio_2_ready = true;
        }
        if (script1.isPlaying && audio_2_ready && audio_3_ready)
        {
            audio_1_played = false;
            audio_3_ready = false;
            audio_2_ready = false;
        }
        if (script2.isPlaying && audio_2_ready && !audio_3_ready && audio_1_played && audio_2_played)
        {
            audio_3_ready = true;
        }
        if (script3.isPlaying && audio_2_ready && !audio_3_ready)
        {
            audio_1_played = false;
            audio_2_played = false;
            audio_3_ready = false;
            audio_2_ready = false;
        }

        // Iniciar la acci�n despu�s de un tiempo cuando se complete la reproducci�n de script3
        if (script3.isPlaying && audio_3_ready)
        {
            if (executeAfterTimeCoroutine == null)
            {
                executeAfterTimeCoroutine = StartCoroutine(ExecuteAfterTime(3f));
            }
        }
    }
}