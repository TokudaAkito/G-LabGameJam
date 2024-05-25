using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class e_hpBar : MonoBehaviour
{
    [SerializeField] public float initialenemyhp;
    Animator anim;
    public UnityEvent onDieCallback = new UnityEvent();

    public float enemylife = 1;

    public Slider hpBar;

    void Start()
    {
        anim = GetComponent<Animator>();
        enemylife = initialenemyhp;
        if (hpBar != null)
        {
            hpBar.value = enemylife / initialenemyhp;
        }
    }

    public void Damage(int damage)
    {
        if (enemylife <= 0) return;

        enemylife -= damage;
        if (hpBar != null)
        {
            hpBar.value = enemylife / initialenemyhp;
        }
    }
}