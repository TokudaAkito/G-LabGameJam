using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BUlletMove : MonoBehaviour
{
    [SerializeField] float _bulletTime;
    [SerializeField] float _bulletTimer;
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
    //private void OnCollijonEnter(Collider collision)
    //{
    //    Debug.Log("unko");
    //   if (collision.gameObject)
    //       {
     
    //       }
    //}


    private void OnTriggerEnter(Collider other)
    {
                 Destroy(this.gameObject); 
    }

}
