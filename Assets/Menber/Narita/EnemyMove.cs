using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject enemy; //①動かしたいオブジェクトをインスペクターから入れる
    [SerializeField] float _enemySpeed = 1f;　//オブジェクトが自動で動くスピード調整
    [SerializeField] float _moveRange = 7f;
    Vector3 movePosition;　//②オブジェクトの目的地を保存
    // Start is called before the first frame update
    void Start()
    {
        movePosition = moveRandomPosition(); //②実行時、オブジェクトの目的地を設定
    }

    // Update is called once per frame
    void Update()
    {
        if (movePosition == enemy.transform.position)  //②playerオブジェクトが目的地に到達すると、
        {
            movePosition = moveRandomPosition();  //②目的地を再設定
        }
        this.enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, movePosition, _enemySpeed * Time.deltaTime); 
        //①②playerオブジェクトが, 目的地に移動, 移動速度
    }
    private Vector3 moveRandomPosition()  // 目的地を生成、xとyのポジションをランダムに値を取得 
    {
        Vector3 randomPosi = new Vector3(Random.Range( -_moveRange, _moveRange), enemy.transform.position.y); //()を微調整
        return randomPosi;
    }
}
