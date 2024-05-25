using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] GameObject _bulletImage;
    [SerializeField] GameObject PL;

    //[SerializeField] itemGet ItemGet;
    // Start is called before the first frame update
    int x = 0;
    int y = 0;   //弾が発射される位置xy　適宜調整

    [Header("弾の初期保持数")]
    public int count2;
    ItemGet ItemGet;
    Vector3 pos;

    void Start()
    {
        ItemGet count = GetComponent<ItemGet>();


    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))  //左クリックでBulletを射出
        {
            if (count2 <= 0)
            {
                return;
            }


                Instantiate(_bulletImage, PL.transform.position, transform.rotation);
            count2--;


        }

    }
    public void AddBullet(int add)
    {
        count2 += add;
    }

}




