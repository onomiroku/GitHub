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
        DontDestroyOnLoad(this.gameObject); //Scene‚ª•Ï‚í‚Á‚Ä‚àScore‚ªŽc‚é
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
