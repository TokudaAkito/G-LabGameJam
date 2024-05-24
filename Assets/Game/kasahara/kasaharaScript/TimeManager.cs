using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    public static float currentTime = 180f;

    void Update()
    {
        //@ŠÔ‚ğŒv‘ª
        if (!gameManager.IsFinished())
        {
            currentTime -= Time.deltaTime;
            Debug.Log(currentTime);
        }
        if (currentTime < 0)
        {
            gameManager.Goal();
            SceneManager.LoadScene("");
        }

    }
}
