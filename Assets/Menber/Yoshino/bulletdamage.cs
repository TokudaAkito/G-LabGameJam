using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdamage : MonoBehaviour
{
    [SerializeField] float posy = -10;
    //[SerializeField] E_hpBar e_hpBar; 
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (this.transform.position.y < posy)
        {
            //������x�̍��W�܂ōs������폜�ݒ�ł���
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")//�G�Ƀ^�O�t����
        {

            //e_hpBar.enemylife--;
            Destroy(this);
        }
        
    }
}
