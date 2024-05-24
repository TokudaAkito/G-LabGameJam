using System;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    public static float currentTime = 180f;

    void Update()
    {
        //�@���Ԃ��v��
        if (!gameManager.IsFinished())
        {
            currentTime -= Time.deltaTime;
            Debug.Log(currentTime);
        }
        if (currentTime < 0)
        {
            gameManager.Goal();
        }

    }
}
