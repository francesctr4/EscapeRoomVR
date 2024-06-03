using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class audio_manager : MonoBehaviour
{
    public AudioSource script1;
    public AudioSource script2;
    public AudioSource script3;
    public AudioSource script4;

    public bool audio_2_ready;
    public bool audio_3_ready;

    public GameObject audio1;
    public GameObject audio2;
    public GameObject audio3;

    public GameObject ball;

    private Coroutine executeAfterTimeCoroutine;

    void FunctionToExecute()
    {
        script4.Play();
        ball.active = true;
    }

    void Update()
    {
        if (script1.isPlaying)
        {
            audio_2_ready = true;
        }

        if (script1.isPlaying && audio_2_ready && audio_3_ready)
        {
            audio_3_ready = false;
            audio_2_ready = false;
        }

        if (script2.isPlaying && audio_2_ready && !audio_3_ready)
        {
            audio_3_ready = true;
        }

        if (script3.isPlaying && audio_2_ready && !audio_3_ready)
        {
            audio_3_ready = false;
            audio_2_ready = false;
        }

        if (script3.isPlaying && audio_3_ready)
        {
            if (executeAfterTimeCoroutine == null)
            {
                executeAfterTimeCoroutine = StartCoroutine(ExecuteAfterTime(3f));
            }
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        FunctionToExecute();
        executeAfterTimeCoroutine = null; // Reset the coroutine reference
    }
}
