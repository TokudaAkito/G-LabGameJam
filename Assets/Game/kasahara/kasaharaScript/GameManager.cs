
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TimeManager timeManager;

    private bool finished;

    void Start()
    {

    }

    public void Goal()
    {
        finished = true;
    }

    //�@�Q�[�����I���������ǂ���
    public bool IsFinished()
    {
        return finished;
    }

}
