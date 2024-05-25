using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    public float currentTime = 180f;
    [SerializeField] private Text timertext;

    void Update()
    {
        //@ŠÔ‚ğŒv‘ª
        if (!gameManager.IsFinished())
        {
            currentTime -= Time.deltaTime;
            timertext.text =currentTime.ToString("0.0");
        }
        if (currentTime < 0 && !gameManager.GameOvered())
        {
            gameManager.Goal();
            //SceneManager.LoadScene("ClearScene");
            SceneLoader.Instance.MoveToOtherScene("ClearScene");
        }

    }
}
