using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public float score;
    public float HP;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject); //Scene���ς���Ă�Score���c��
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
