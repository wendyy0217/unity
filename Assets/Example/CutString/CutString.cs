using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutString : MonoBehaviour
{
    private string content = "I am yoyoyo man."; //宣告字串

    public string str = "";

    public void cutStr()
    {
        int index = Random.Range(0, this.content.Length-1); //index是隨機產生0~字串長度的一個數
       
        //如果字串第index個字元是空格或.，str=字串的第0個字元到第index個，如果index =字串的總長度，str=字串
       if (this.content[index] == ' ' || this.content[index] == '.'||index == this.content.Length)
        {
            str = this.content.Substring(0, index);
        }
        else
        {
            for (int i = index - 1; i >= 0; i--)
            {
                if (this.content[i] == ' ' || this.content[i] == '.')
                {
                    str = this.content.Substring(0, i);
                    break;
                }
            }
        }

        Debug.Log("原字串" + content);
        Debug.Log("擷取" + index + "個字元");
        Debug.Log (str);
    }
}
