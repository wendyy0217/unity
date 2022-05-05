using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class more : MonoBehaviour
{
    public InputField input;
    public Text result = null;
    public Text infor = null;
    List<int> list = new List<int>();//動態陣列宣告
    public void Start()
    {
    }
    private void init() //清空
    {
        this.result.text = "";
    }
    public List<int> bubbleMore(List<int> list)//升冪排列
    {
        List<int> copy = list;//複製list陣列
        int len = copy.Count;//len 是list的長度
        for (int i = 1; i <= len - 1; i++)//執行的回數
        {
            for (int j = 1; j <= len - i; j++)//執行的次數
            {
                if (copy[j] < copy[j - 1])
                {
                    //二數交換
                    int temp = copy[j];
                    copy[j] = copy[j - 1];
                    copy[j - 1] = temp;
                }
            }
        }
        return copy;//回傳
    }
    public List<int> bubbleLess(List<int> list)//降冪排列
    {
        List<int> copy = list;//複製list陣列
        int len = list.Count;
        for (int i = 1; i <= len - 1; i++)//執行的回數
        {
            for (int j = 1; j <= len - i; j++)//執行的次數
            {
                if (list[j] > list[j - 1])
                {
                    //二數交換
                    int temp = list[j];
                    list[j] = list[j - 1];
                    list[j - 1] = temp;
                }
            }
        }
        return copy;//回傳
    }
    public void moreMain()//一個一個升冪列出來
    {
        this.init();
        List<int> a = bubbleMore(this.list);//呼叫方法
        this.infor.text = "升冪";
        string output = "";
        for (int i = 0; i < a.Count; i++)
        {
            output += a[i] + " ";
        }
        this.result.text = output;
    }
    public void lessMain()//一個一個降冪列出來
    {
        this.init();
        List<int> b = bubbleLess(this.list);
        this.infor.text = "降冪";
        string output = "";
        for (int i = 0; i < list.Count; i++)
        {
            output += list[i] + " ";
        }
        this.result.text = output;
    }
    public void inputNum()//輸入後變成動態陣列
    {
        string output = "";
        string num = this.input.text;//this是input為全域的東西才需要打的
        this.list.Add(int.Parse(num));
        this.infor.text = "已輸入";
        for (int i = 0; i < this.list.Count; i++)
        {
            output += this.list[i] + "  ";
        }
        this.result.text = output + " ".ToString();
    }
}