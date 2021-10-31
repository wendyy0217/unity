using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiple : MonoBehaviour
{
    public InputField input;
    public Text show;

    public int excludeMulitple = 4;
    public int targetMulitple = 2;
    
    void Start()
    {
    }
    void Update()
    {
    }
    public void comeOut()
    {
        string outPut = "";
        int totalNum = 0;
        int num = int.Parse(this.input.text);
        for (int startNum = 0; startNum <= num / targetMulitple; startNum++)
        {
            totalNum = startNum * targetMulitple;
            if (totalNum % excludeMulitple == 0)
            {
                continue;
            }
            outPut += totalNum + " ";
            //Debug.Log(outPut);
        }
        this.show.text = outPut;
    }
}