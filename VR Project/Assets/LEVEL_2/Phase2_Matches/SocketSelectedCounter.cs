using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketSelectedCounter : MonoBehaviour
{
    public SocketSelected[] socketSelecteds = null;
    public AudioSource audioSource = null;
    private TransitionToNextPhase transitionToNextPhase = null;
    private bool doOnce = false;

    void Start()
    {
        transitionToNextPhase = GetComponent<TransitionToNextPhase>();
    }

    // Update is called once per frame
    void Update()
    {
        if (AreAllSocketsSelected() && !doOnce)
        {
            // All sockets are selected
            audioSource.Play();
            transitionToNextPhase.StartTransition();

            doOnce = true;
        }
    }

    bool AreAllSocketsSelected()
    {
        if (socketSelecteds == null || socketSelecteds.Length == 0)
        {
            return false; // or true, depending on how you want to handle empty or null arrays
        }

        for (int i = 0; i < socketSelecteds.Length; i++)
        {
            if (!socketSelecteds[i].selected)
            {
                return false;
            }
        }
        return true;
    }

}
