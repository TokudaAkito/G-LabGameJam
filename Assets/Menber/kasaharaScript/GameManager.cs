
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TimeManager timeManager;
    [SerializeField]
    private HealthSystem health ;
    //private Player player;

    private bool finished;
    private bool gameovered;
    void Start()
    {
        
    }

    private void Update()
    {
        if (health.life <= 0)
        {
            GameOver();
        }

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

    //@ƒQ[ƒ€‚ðI—¹‚µ‚½‚©‚Ç‚¤‚©
    public bool IsFinished()
    {
        return finished;
    }

    public bool GameOvered()
    {
        return gameovered;
    }

}
