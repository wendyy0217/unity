using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//這是一個方法
public class Multiplicationtable 
{
    //宣告一個showVertical『直式九九乘法表』方法
    public string showVertical()
    {
        string str = "";
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                str += j + "x" + i + "=" + j * i + "\t";
            }
            str += "\r\n";
        }
        return str;
    }
    //宣告一個showHorizontal『橫式九九乘法表』方法
    public string showHorizontal()
    {
         string str = "";
         //巢狀for迴圈 從外誆for迴圈執行到內圈for迴圈後，內for迴圈1~9都執行完後才會再從外面for迴圈開始執行
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                //\t\t空兩個小空格
                str += i + "x" + j + "=" + i * j + "\t\t";
            }
            //\r\n換行
            str += "\r\n";
        }
        return str;
    }
}
