using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMaker : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float makeTime;
    private float waitTime;
    [SerializeField] private float enemyZ;
    [SerializeField] private float enemyX;
    private float ranX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(waitTime < makeTime) //�G�������܂ł̎��Ԃ𐔂���B
        {
            waitTime = waitTime + Time.deltaTime;�@//waitTime�Ƀt���[���Ԃ̐����𑫂����ݑ����^�C�}�[�I������S�킹��B
        }

        else
        {
            ranX = Random.Range(enemyX * -1, enemyX); //ranX�ɂ�-enemyx����enemyX�܂ł̂ǂꂩ�̒l������B
            Instantiate(enemyPrefab, new Vector3(ranX, 0, enemyZ), enemyPrefab.transform.rotation); //�I�u�W�F�N�g���o��������ienemyPrefab��vector3�̍��W�ŁAenemyPrefab��rotation�Łj
            waitTime = 0;
        } 
          //waitTime��0�ɂ��邱�ƂŁA�������
    }
}
