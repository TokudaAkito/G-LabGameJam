using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] float initialhp;
    Animator anim;
    public UnityEvent onDieCallback = new UnityEvent();

    public float life = 1;

    public Slider hpBar;

    void Start()
    {
        anim = GetComponent<Animator>();
        life = initialhp;
        if (hpBar != null)
        {
            hpBar.value = life / initialhp;
        }
    }

    public void Damage(int damage)
    {
        if (life <= 0) return;

        life -= damage;
        if (hpBar != null)
        {
            hpBar.value = life / initialhp;
        }
        if (life <= 0)
        {

        }
    }
}
