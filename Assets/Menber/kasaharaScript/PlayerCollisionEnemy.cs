using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionEnemy : MonoBehaviour
{
    [SerializeField]
    private HealthSystem player;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Meteo" )
        {
            //player.life-- ;
            Debug.Log("a");
            player.Damage(1);
        }
        Debug.Log("col");

    }
}
