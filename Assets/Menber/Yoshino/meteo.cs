using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Player;
    [SerializeField] PlayerScript pl;
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            
            pl.HP--;
        }
        this.transform.position = Vector3.zero;
    }
}
