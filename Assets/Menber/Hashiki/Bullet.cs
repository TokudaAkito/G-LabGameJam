using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    int x = 0;
    int y = 0;   //�e�����˂����ʒuxy�@�K�X����
    public int count;
    public float destroyDelay = 1f;   //�e�����ł��鎞��
    void Start()
    {
        var tank = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        tank.transform.localPosition = new Vector3(0, 0, 0);
        tank.transform.localScale = new Vector3(1, 1, 1);   //���̃V�����_�[���tank�@�K�X����
        count = 0;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)|| Input.GetKeyDown(KeyCode.Space) )  //���N���b�N��Bullet���ˏo
        {
            if (count > 0)
            {
                var Bullet = GameObject.CreatePrimitive(PrimitiveType.Cylinder);   //�ˏo�����V�����_�[�eBullet
                Bullet.transform.localScale = new Vector3(0.1F, 0.1F, 0.1F);
                Bullet.transform.position = new Vector3(x, y, 0);

                var rigidbody = Bullet.AddComponent<Rigidbody>();
                rigidbody.useGravity = false;

                rigidbody.velocity = new Vector3(0, 25, 0);   //y�����ɔ��ł������x�H25

                Destroy(Bullet, destroyDelay);   //�e���w�莞�Ԃŏ���
                count--;
            }
        }
        if (Input.GetMouseButtonDown(1)) //�E�N���b�N
        {
            count ++; //�e��+1
        }
    }

}




