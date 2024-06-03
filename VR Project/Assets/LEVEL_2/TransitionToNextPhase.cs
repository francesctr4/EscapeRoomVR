using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionToNextPhase : MonoBehaviour
{
    public PuzzlePhaseManager phaseManager;
    public int transitionPhase;
    public float waitTime = 2.0f;  // Time to wait before transitioning

    public void StartTransition()
    {
        // Start the coroutine to transition to the next phase
        StartCoroutine(GoToPhaseAfterDelay());
    }

    private IEnumerator GoToPhaseAfterDelay()
    {
        yield return new WaitForSeconds(waitTime);

        switch (transitionPhase)
        {
            case 1:
                phaseManager.EnablePhase1();
                break;
            case 2:
                phaseManager.EnablePhase2();
                break;
            case 3:
                phaseManager.EnablePhase3();
                break;
            default:
                break;
        }

    }
}
