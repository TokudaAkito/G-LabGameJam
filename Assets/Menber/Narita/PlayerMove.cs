using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _startSpeed = 1f;
    float _speed = 1f;
    [SerializeField] float _maxrange;
    [SerializeField] float _speedup = 1f;

    public bool _isSpeedUp;
    // Start is called before the first frame update
    void Start()
    {
        _speed = _startSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && this.transform.position.x > -_maxrange  )
        {
            transform.position += transform.right * -_speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) && this.transform.position.x < _maxrange) 
        {
            transform .position += transform.right * _speed * Time.deltaTime;
        }
    }

    public void SpeedUp()
    {
        _speed += _speedup;
        _isSpeedUp = true;
    }

    public void SpeedReset()
    {
        _speed = _startSpeed;
        _isSpeedUp = false;
    }
}
