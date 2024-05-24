using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject player; //�@動かしたいオブジェクトをインスペクターから入れる
    [SerializeField] float _enemySpeed = 1f;　//オブジェクトが自動で動くスピード調整
    Vector3 movePosition;　//�Aオブジェクトの目的地を保存
    // Start is called before the first frame update
    void Start()
    {
        movePosition = moveRandomPosition(); //�A実行時、オブジェクトの目的地を設定
    }

    // Update is called once per frame
    void Update()
    {
        if (movePosition == player.transform.position)  //�Aplayerオブジェクトが目的地に到達すると、
        {
            movePosition = moveRandomPosition();  //�A目的地を再設定
        }
        this.player.transform.position = Vector3.MoveTowards(player.transform.position, movePosition, _enemySpeed * Time.deltaTime); 
        //�@�Aplayerオブジェクトが, 目的地に移動, 移動速度
    }
    private Vector3 moveRandomPosition()  // 目的地を生成、xとyのポジションをランダムに値を取得 
    {
        Vector3 randomPosi = new Vector3(Random.Range(-7, 7), transform.position.y); //()を微調整
        return randomPosi;
    }
}
