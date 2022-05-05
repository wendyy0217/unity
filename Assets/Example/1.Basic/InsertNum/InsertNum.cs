using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsertNum : MonoBehaviour
{
    public void maxNumber(int num)
    {
        int Num = UnityEngine.Random.Range(-1000, 1000);
        int original = Mathf.Abs(Num); //Mathf.Abs(num)-->取randomNum絕對值
        string strO = original.ToString(); //數字不能成為陣列，所以要先轉成字串
        string insertNum = "5";

        /*三個數字會變四個字串，所以字串長度要+1。
        ex.字串123每個字元前插入5-->addAns字串變[5123,1523,1253,1235]。*/
        int[] addAns = new int[strO.Length + 1];

        for (int i = 0; i <= strO.Length; i++)
        {
            string anser = strO.Insert(i, insertNum); //Insert(i, insertNum)-->插入insertNum在第i個字元
            addAns[i] = int.Parse(anser); //addAns陣列第i個字元(字元可以是一串字)＝anser字串轉數字

            //如果小於0加負號
            if (Num < 0)
            {
                anser = "-" + anser;
            }
            addAns[i] = int.Parse(anser); //陣列轉數字
        }
        System.Array.Sort (addAns); //addAns陣列做升冪排列

        //跑for迴圈印出addAns陣列
        for (int i = 0; i <= addAns.Length - 1; i++)
        {
            int add = addAns[i];
            Debug.Log("插入後數為：" + add + " ");
        }
        Debug.Log("隨機數為：" + Num);
        Debug.Log("最大數為" + addAns[addAns.Length - 1]); //顯示addAns陣列第addAns長度(4)-1個字元
    }
}
