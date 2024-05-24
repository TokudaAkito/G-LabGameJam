using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrap_meteor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var status = other.GetComponent<HealthSystem>();
            status.Damage(10);
        }
    }
}
