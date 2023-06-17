using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float MoveSpeed; //Unity側でスピード調整が出来るようになる
    //private…このスクリプト内でしか変えられない
    //public...どこからでも書き換えられる
    // [SerializeField] private…unity上では変えられるけど他のスクリプトからは変えられない。
    [SerializeField] private float xMax;
    [SerializeField] private float zMax;
    // Start is called before the first frame update
    [SerializeField] private float playerHP;
    void Start()
    {
        data = GameObject.Find("Data");
        dataCs = data.GetComponent<Data>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && this.transform.position.x < xMax) //Dを押したら　かつ　オブジェクトのx座標がxMax以下の値なら以下のプログラムが作動する
            transform.Translate(new Vector3(MoveSpeed, 0, 0) * Time.deltaTime);   //移動するための関数（ベクトルを示す＊フレーム間にかかる時間？）
        //MoveSpeedと書かれた個所をUnity側で変えられる
        if (Input.GetKey(KeyCode.W) && this.transform.position.z < zMax)
            transform.Translate(new Vector3(0, 0, MoveSpeed) * Time.deltaTime);
        if (Input.GetKey(KeyCode.A) && this.transform.position.x > -xMax)
            transform.Translate(new Vector3(-MoveSpeed, 0, 0) * Time.deltaTime);
        if (Input.GetKey(KeyCode.S) && this.transform.position.z > -zMax)
            transform.Translate(new Vector3(0, 0, -MoveSpeed) * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")) //ぶつかったオブジェクトがEnemyだったら
        {
            playerHP--;
        }

        if (playerHP == 0)
        {
            Destroy(this.gameObject);
            Debug.Log("Enemy");
        }
    }
    if (dataCs.HP == 0)
    {dataCs.HP--;}
    private void OnDestroy()
    {
        SceneManager.LoadScene("End");
    }
}
