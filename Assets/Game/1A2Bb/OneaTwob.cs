using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneaTwob : MonoBehaviour
{
    private List<int> numberList = new List<int>();
    private List<int> questionList = new List<int>();
    public Text timesOutput;
    public InputField input;
    public Text tipsOutput;
    public int times = 5;



    // Start is called before the first frame update
    void Start()
    {
        this.questionList.Clear();

        for (int i = 0; i < 10; i++)
        {
            this.numberList.Add(i);
        }

        ///產生隨機數塞到陣列裡
        for (int i = 0; i < 4; i++)
        {
            int index = Random.Range(0, numberList.Count);
            int num = numberList[index];
            this.questionList.Add(num);
            numberList.RemoveAt(index);
        }

        string ansStr = "";
        foreach (int point in this.questionList)
        {
            ansStr += point + ",";
        }
        Debug.Log(ansStr);
    }

    public void checkAnswer()
    {
        string ans = this.input.text;

        if (ans.Length != 4 || ans.Length > 4 || ans.Length < 4)
        {
            this.tipsOutput.text = "必須為4個數字";
            return;
        }

        int a = 0;
        int b = 0;

        for (int i = 0; i < ans.Length; i++)
        {
            int num = int.Parse(ans[i].ToString());
            for (int j = 0; j < this.questionList.Count; j++)
            {
                if (j == i)
                {
                    if (num == this.questionList[j])
                    {
                        a = a + 1;
                    }
                }
                else
                {
                    if (num == this.questionList[j])
                    {
                        b = b + 1;
                    }
                }
            }
        }
        this.tipsOutput.text = a + "A" + b + "B";

    }
    public void lastTimesOutput()
    {
        string ans = this.input.text;
        {
            if (ans.Length != 4 || ans.Length > 4 || ans.Length < 4)
            {
                return;
            }
            times--;
        }
        this.timesOutput.text = "剩餘" + times + "次";
        if (times == 0)
        {
            this.timesOutput.text = "失敗";
        }

    }
    public void restartButtom()
    {
        this.tipsOutput.text = null;

        Start();
    }
}
