using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject enemy; //�@�����������I�u�W�F�N�g���C���X�y�N�^�[��������
    [SerializeField] float _enemySpeed = 1f;�@//�I�u�W�F�N�g�������œ����X�s�[�h����
    [SerializeField] float _moveRange = 7f;
    Vector3 movePosition;�@//�A�I�u�W�F�N�g�̖ړI�n��ۑ�
    // Start is called before the first frame update
    void Start()
    {
        movePosition = moveRandomPosition(); //�A���s���A�I�u�W�F�N�g�̖ړI�n��ݒ�
    }

    // Update is called once per frame
    void Update()
    {
        if (movePosition == enemy.transform.position)  //�Aplayer�I�u�W�F�N�g���ړI�n�ɓ��B����ƁA
        {
            movePosition = moveRandomPosition();  //�A�ړI�n���Đݒ�
        }
        this.enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, movePosition, _enemySpeed * Time.deltaTime); 
        //�@�Aplayer�I�u�W�F�N�g��, �ړI�n�Ɉړ�, �ړ����x
    }
    private Vector3 moveRandomPosition()  // �ړI�n�𐶐��Ax��y�̃|�W�V�����������_���ɒl���擾 
    {
        Vector3 randomPosi = new Vector3(Random.Range( -_moveRange, _moveRange), enemy.transform.position.y); //()�������
        return randomPosi;
    }
}
