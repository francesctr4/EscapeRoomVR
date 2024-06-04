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

    // Variables para controlar el estado de reproducción de los audios
    private bool audio_1_played;
    private bool audio_2_played;
    public bool audio_2_ready;
    public bool audio_3_ready;

    public GameObject ball;

    private Coroutine executeAfterTimeCoroutine;
    private bool functionExecuted = false; // Bandera para controlar si la función se ha ejecutado

    // Método para ejecutar acciones después de un tiempo
    private IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        FunctionToExecute();
        executeAfterTimeCoroutine = null; // Restablecer la referencia del coroutine
    }

    // Método para ejecutar una acción cuando se completa la reproducción de los audios
    private void FunctionToExecute()
    {
        if (!functionExecuted) // Verificar si la función no se ha ejecutado antes
        {
            win.Play();
            ball.SetActive(true);
            functionExecuted = true; // Marcar la función como ejecutada
        }
    }

    void Update()
    {
        // Detener la reproducción de los otros audios si uno está reproduciéndose
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

        // Lógica para controlar el estado de reproducción de los audios
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

        // Iniciar la acción después de un tiempo cuando se complete la reproducción de script3
        if (script3.isPlaying && audio_3_ready)
        {
            if (executeAfterTimeCoroutine == null)
            {
                executeAfterTimeCoroutine = StartCoroutine(ExecuteAfterTime(7f));
            }
        }
    }
}