using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    static SceneLoader _instance;
    public static SceneLoader Instance => _instance;

    [SerializeField] private Image _image = null;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        StartCoroutine(WaitAndFadeOut(0, 2f));
    }
    private IEnumerator AlphaZeroToOne(float d, Action on_completed, bool isReversing = false)
    {
        _image.enabled = true;

        var elapsedTime = 0.0f;
        var color = _image.color;

        while (elapsedTime < d)
        {
            var elapsedRate = Mathf.Min(elapsedTime / d, 1f);
            color.a = isReversing ? elapsedRate : 1.0f - elapsedRate;
            yield return null;
            elapsedTime += Time.deltaTime;
            _image.color = color;
        }
        _image.enabled = false;
        if (on_completed != null) on_completed();
    }

    private void FadeIn(float d, Action on_complete = null)
    {
        StartCoroutine(AlphaZeroToOne(d, on_complete, true));
    }
    private void FadeOut(float d, Action on_complete = null)
    {
        StartCoroutine(AlphaZeroToOne(d, on_complete));
    }
    public IEnumerator WaitAndFadeIn(float seconds, float fadingTime, string name)
    {
        yield return new WaitForSeconds(seconds);
        FadeIn(fadingTime, () => SceneManager.LoadScene(name));
    }

    public IEnumerator WaitAndFadeOut(float seconds, float fadingTime)
    {
        yield return new WaitForSeconds(seconds);
        FadeOut(fadingTime);
    }

    public void MoveToOtherScene(string sceneName)
    {
        StartCoroutine(WaitAndFadeIn(0.3f, 1.5f, sceneName));
        //SceneLoader.Instance.MoveToOtherScene(シーン名)で、フェードインしたのちシーンの移動を行う。
    }

}
