using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadetoBlack : MonoBehaviour
{
    public bool fadeOnStart = true;
    public float fadeDuration = 2;
    public Color fadeColor;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        if(fadeOnStart)
        {
            StartCoroutine(FirstFadeRoutine(1, 0));
        }
    }

    //public void FadeIn()
    //{
    //    StartCoroutine(FadeRoutine(0, 1));

    //}

    //public void FadeOut()
    //{
    //    StartCoroutine(FadeRoutine(1, 0));
    //}

    public void ChangeScene()
    {
        StartCoroutine(FadeRoutine(0, 1));
    }

    public IEnumerator FirstFadeRoutine(float alphaIn, float alphaOut)
    {
        float timer = 0;
        while (timer <= fadeDuration)
        {
            Color newColor = fadeColor;
            newColor.a = Mathf.Lerp(alphaIn, alphaOut, timer / fadeDuration);

            rend.material.SetColor("_Color", newColor);

            timer += Time.deltaTime;
            yield return null;
        }

        Color newColor2 = fadeColor;
        newColor2.a = alphaOut;

        rend.material.SetColor("_Color", newColor2);
    }

    public IEnumerator FadeRoutine(float alphaIn, float alphaOut)
    {
        float timer = 0;
        while (timer <= fadeDuration)
        {
            Color newColor = fadeColor;
            newColor.a = Mathf.Lerp(alphaIn, alphaOut, timer / fadeDuration);

            rend.material.SetColor("_Color", newColor);

            timer += Time.deltaTime;
            yield return null;
        }

        if (alphaIn == 0)
        {
            SceneManager.LoadScene(0);

            StartCoroutine(FadeRoutine(1, 0));
        }

        Color newColor2 = fadeColor;
        newColor2.a = alphaOut;

        rend.material.SetColor("_Color", newColor2);
    }
}
