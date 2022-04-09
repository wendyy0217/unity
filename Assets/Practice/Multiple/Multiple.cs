using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiple : MonoBehaviour
{
    public InputField input;
    public Text show;
    //取得2的倍數不包含4的倍數
    public int excludeMulitple = 4;
    public int targetMulitple = 2;

    public void comeOut()
    {
        string outPut = "";
        int totalNum = 0;
        int num = int.Parse(this.input.text);//字串轉數字
        for (int startNum = 0; startNum <= num / targetMulitple; startNum++)
        {
            totalNum = startNum * targetMulitple;
            if (totalNum % excludeMulitple == 0)
            {
                continue;
            }
            outPut += totalNum + " ";
        }
        this.show.text = outPut;
    }
}