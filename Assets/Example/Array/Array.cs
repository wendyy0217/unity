using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Array : MonoBehaviour
{
    public InputField input;
    private int[] number = new int[5];
    private int index = 0;
    private string outputNum;
    void Start()
    {
        // int num = int.Parse(this.input.text);


        // int total = 0;
        // int average = 0;
        // //number[0] = 10;
        // //number[1] = 20;
        // //number[2] = 30;
        // //number[3] = 40;
        // //number[4] = 50;

        // for (int i = 0; i < 5; i++)
        // {
        //     total += number[i];
        // }
        // average = total / 5;
        // Debug.Log(average);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void inputNum()
    {
        string output = "";
        number[index] = int.Parse(this.input.text);//一個一個存陣列的數(字串轉換成數值)
        index++;//每按一次按鈕存入下一個陣列
        for (int i = 0; i < 5; i++)
        {
            output += number[i] + " ";
        }
        Debug.Log(output);//一個一個列出來

    }
    public void averageNum()
    {
        int averageNumber = 0;
        int average = 0;
        average = number[0] + number[1] + number[2] + number[3] + number[4];
        averageNumber = average / 5;
        Debug.Log(averageNumber);

        // int total =0;
        // for(int i =0;i<5;i++){
        //     total += number[i];
        // }
        // Debug.Log(total/5);
    }

}
