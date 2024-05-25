using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteo : MonoBehaviour
{
    [SerializeField] float posy=-10;
    // Start is called before the first frame update
    [SerializeField] GameObject Player;
    [SerializeField] PlayerScript pl;
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
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.gameObject);
            //pl.HP--;
        }
        //this.transform.position = Vector3.zero;
    }
}
