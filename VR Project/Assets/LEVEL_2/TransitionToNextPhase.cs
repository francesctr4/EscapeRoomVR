using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionToNextPhase : MonoBehaviour
{
    public PuzzlePhaseManager phaseManager;
    public int transitionPhase;
    public Material fadeMaterial;  // The material applied to the full-screen quad
    public float fadeDuration = 1.0f;  // Duration of the fade
    public float waitTime = 2.0f;  // Time to wait before transitioning

    public void StartTransition()
    {
        // Start the coroutine to transition to the next phase
        StartCoroutine(GoToPhaseAfterDelay());
    }

    private IEnumerator GoToPhaseAfterDelay()
    {
        yield return new WaitForSeconds(waitTime);
        yield return StartCoroutine(FadeToBlack());

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
        
        yield return StartCoroutine(FadeFromBlack());
    }

    private IEnumerator FadeToBlack()
    {
        float elapsedTime = 0.0f;
        Color color = fadeMaterial.color;

        while (elapsedTime < fadeDuration)
        {
            color.a = Mathf.Clamp01(elapsedTime / fadeDuration);
            fadeMaterial.color = color;
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        color.a = 1.0f;
        fadeMaterial.color = color;
    }

    private IEnumerator FadeFromBlack()
    {
        float elapsedTime = 0.0f;
        Color color = fadeMaterial.color;

        while (elapsedTime < fadeDuration)
        {
            color.a = 1.0f - Mathf.Clamp01(elapsedTime / fadeDuration);
            fadeMaterial.color = color;
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        color.a = 0.0f;
        fadeMaterial.color = color;
    }
}
