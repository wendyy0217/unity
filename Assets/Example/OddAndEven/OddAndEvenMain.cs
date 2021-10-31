using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OddAndEvenMain : MonoBehaviour
{
    public InputField inputNum;
    public Text numText = null;
    public Text anserText = null;
    void Start()
    {

    }
    void Update()
    {

    }
    public void judge()
    {
        this.numText.text = null;
        int a = int.Parse(this.inputNum.text);
        this.numText.text += "輸入：" + a;
        if (a % 2 == 0)//%除完取餘數
        {
            this.anserText.text = "偶數";
        }
        else
        {
            this.anserText.text = "奇數";
        }
    }
}
