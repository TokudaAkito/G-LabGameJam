using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Trap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            var status = other.GetComponent<e_hpBar>();
            status.Damage(10);
        }
    }
}
