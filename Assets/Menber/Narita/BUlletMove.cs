using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUlletMove : MonoBehaviour
{
    [SerializeField] float Movespeed;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       rb.AddForce(Vector3.up*Movespeed,ForceMode.Force);
        
    }
}
