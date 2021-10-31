using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MMain : MonoBehaviour
{
    public Text display;

    // Start is called before the first frame update
    void Start()
    {
        Multiplicationtable table = new Multiplicationtable();
        //顯示直式九九乘法表
        display.text = table.showVertical();
    }

    // Update is called once per frame
    void Update()
    {



    }

}


