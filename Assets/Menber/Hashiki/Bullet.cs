using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] GameObject _bulletImage;
    [SerializeField] GameObject PL;

    //[SerializeField] itemGet ItemGet;
    // Start is called before the first frame update
    int x = 0;
    int y = 0;   //�e�����˂����ʒuxy�@�K�X����
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
        
        if (Input.GetMouseButtonDown(0)|| Input.GetKeyDown(KeyCode.Space) )  //���N���b�N��Bullet���ˏo
        {
            
            

                Instantiate(_bulletImage, PL.transform.position, transform.rotation);
              
               
            
        }
    }

}




