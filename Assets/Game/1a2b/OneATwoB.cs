using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneATwoB : MonoBehaviour
{
    private List<int> numberList = new List<int>();
    private List<int> questionList = new List<int>();

    public InputField input;

    // Start is called before the first frame update
    void Start()
    {
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

        string str = "";
        foreach (int point in this.questionList)
        {
            str += point + ",";
        }
        Debug.Log(str);
    }

    public void checkAnswer()
    {
        string ans = this.input.text;

        if (ans.Length != 4)
        {
            Debug.Log("必須4個數字");
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
        Debug.Log(a + "A" + b + "B");
    }
}
