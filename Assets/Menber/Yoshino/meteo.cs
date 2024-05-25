using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteo : MonoBehaviour
{
    [SerializeField] float posy=-10;
    [SerializeField] HealthSystem healthSystem;
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (this.transform.position.y < posy) 
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            healthSystem.life--;
        }
        this.transform.position = Vector3.zero;
    }
}
