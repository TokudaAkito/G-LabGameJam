using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class ItemGet : MonoBehaviour
{
    [SerializeField] float _speedUpTime;
    [SerializeField] float _speedUpTimer;

    PlayerMove playerMove;
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        playerMove = GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_speedUpTime < _speedUpTimer)
        {
            playerMove.SpeedReset();
            _speedUpTimer = 0;
        }
        else if (playerMove._isSpeedUp)
        {
            _speedUpTimer += Time.deltaTime;
        }
        

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "speedup")
        {
            GetSpeedUp();
           _speedUpTimer = 0;
          

        }
        if (collision.gameObject.tag == "powerup")
        {
            GetPowerUp();
        }
        if (collision.gameObject.tag == "bullet")
        {
            GetBullet();
        }

        void GetSpeedUp()
        {
            Debug.Log("speedup");
            playerMove.SpeedUp();

        }
        void GetPowerUp()
        {
            Debug.Log("powerup");
        }
        void GetBullet()
        {
            Debug.Log("bulletget");
            count++;
        }

    }
  
}
