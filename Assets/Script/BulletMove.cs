using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float lifeTime;
    [SerializeField] private GameObject bulletPrefab;
    private GameObject bullet;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { bullet = Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);//出現させたbulletPrefabをbulletに代入
            rb = bullet.GetComponent<Rigidbody>(); //bulletのrigidbodyを取得
            rb.AddForce(transform.forward * bulletSpeed);  //前面に向かって力を加える。
            Destroy(bullet,lifeTime); //BulletをlifeTime秒後に壊す。
        }
    }
}
