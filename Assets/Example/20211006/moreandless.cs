using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moreandless : MonoBehaviour
{
    public InputField input;
    private int[] number = new int[7];
    private int index = 0;
    private string outputNum;
    public int z = 0;
    public void inputNum()
    {
        string output = "";
        number[index] = int.Parse(this.input.text);//一個一個存陣列的數(字串轉換成數值)
        index++;//每按一次按鈕存入下一個陣列
        for (int i = 0; i < 7; i++)
        {
            output += number[i] + " ";
        }
        Debug.Log(output);//一個一個列出來

    }
    public void more()
    {
        for (z = 0; z < 6; z++)
        {
            if (number[z] > number[z + 1])
            {
                int a = number[z+1];
                number[z+1]=number[z];
                number[z]=a;
                Debug.Log(number[z]);
                Debug.Log(number[z+1]);
            }
        }

    }
}
