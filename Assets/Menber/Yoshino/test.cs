using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] GameObject magic;//オブジェクト指定用の入れ物
    [SerializeField] GameObject hassya;//オブジェクト指定用の入れ物
    [SerializeField] GameObject PL;//オブジェクト指定用の入れ物

    // Start is called before the first frame update
    void Start()
    {
        var pos = this.transform;//自身のtransform(座標とか？)を取得
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = hassya.transform.position;
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(magic, pos, PL.transform.rotation);
        }
    }
}
