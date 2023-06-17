using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float MoveSpeed; //Unity���ŃX�s�[�h�������o����悤�ɂȂ�
    //private�c���̃X�N���v�g���ł����ς����Ȃ�
    //public...�ǂ�����ł�������������
    // [SerializeField] private�cunity��ł͕ς����邯�Ǒ��̃X�N���v�g����͕ς����Ȃ��B
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
        if (Input.GetKey(KeyCode.D) && this.transform.position.x < xMax) //D����������@���@�I�u�W�F�N�g��x���W��xMax�ȉ��̒l�Ȃ�ȉ��̃v���O�������쓮����
            transform.Translate(new Vector3(MoveSpeed, 0, 0) * Time.deltaTime);   //�ړ����邽�߂̊֐��i�x�N�g�����������t���[���Ԃɂ����鎞�ԁH�j
        //MoveSpeed�Ə����ꂽ����Unity���ŕς�����
        if (Input.GetKey(KeyCode.W) && this.transform.position.z < zMax)
            transform.Translate(new Vector3(0, 0, MoveSpeed) * Time.deltaTime);
        if (Input.GetKey(KeyCode.A) && this.transform.position.x > -xMax)
            transform.Translate(new Vector3(-MoveSpeed, 0, 0) * Time.deltaTime);
        if (Input.GetKey(KeyCode.S) && this.transform.position.z > -zMax)
            transform.Translate(new Vector3(0, 0, -MoveSpeed) * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")) //�Ԃ������I�u�W�F�N�g��Enemy��������
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
