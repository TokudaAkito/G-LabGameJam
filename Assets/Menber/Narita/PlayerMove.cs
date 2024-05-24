using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _speed = 1f;
    [SerializeField] float _maxrange;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && this.transform.position.x > -_maxrange  )
        {
            transform.position += transform.right * -_speed;
        }
        if (Input.GetKey(KeyCode.D) && this.transform.position.x < _maxrange) 
        {
            transform .position += transform.right * _speed;
        }
    }
}
