using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] GameObject magic;//�I�u�W�F�N�g�w��p�̓��ꕨ
    [SerializeField] GameObject hassya;//�I�u�W�F�N�g�w��p�̓��ꕨ
    [SerializeField] GameObject PL;//�I�u�W�F�N�g�w��p�̓��ꕨ

    // Start is called before the first frame update
    void Start()
    {
        var pos = this.transform;//���g��transform(���W�Ƃ��H)���擾
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
