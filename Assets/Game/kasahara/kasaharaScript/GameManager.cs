
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TimeManager timeManager;
    //private Player player;

    private bool finished;
    private bool gameovered;
    void Start()
    {

    }

    public void Goal()
    {
        finished = true;
    }
    public void GameOver()
    {
        gameovered = true;
        SceneManager.LoadScene("GameoverScene");
    }

    //Å@ÉQÅ[ÉÄÇèIóπÇµÇΩÇ©Ç«Ç§Ç©
    public bool IsFinished()
    {
        return finished;
    }

    public bool GameOvered()
    {
        return gameovered;
    }

}
