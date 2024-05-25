using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    int x = 0;
    int y = 0;   //弾が発射される位置xy　適宜調整
    public int count;
    public float destroyDelay = 1f;   //弾が消滅する時間
    void Start()
    {
        var tank = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        tank.transform.localPosition = new Vector3(0, 0, 0);
        tank.transform.localScale = new Vector3(1, 1, 1);   //仮のシリンダー戦車tank　適宜調整
        count = 0;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)|| Input.GetKeyDown(KeyCode.Space) )  //左クリックでBulletを射出
        {
            if (count > 0)
            {
                var Bullet = GameObject.CreatePrimitive(PrimitiveType.Cylinder);   //射出されるシリンダー弾Bullet
                Bullet.transform.localScale = new Vector3(0.1F, 0.1F, 0.1F);
                Bullet.transform.position = new Vector3(x, y, 0);

                var rigidbody = Bullet.AddComponent<Rigidbody>();
                rigidbody.useGravity = false;

                rigidbody.velocity = new Vector3(0, 25, 0);   //y方向に飛んでいく速度？25

                Destroy(Bullet, destroyDelay);   //弾が指定時間で消滅
                count--;
            }
        }
        if (Input.GetMouseButtonDown(1)) //右クリック
        {
            count ++; //弾数+1
        }
    }

}




