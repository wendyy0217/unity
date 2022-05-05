using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CapticalLetter : MonoBehaviour
{
    public InputField input;

    public void test()
    {
        char c = this.input.text[0];//取得字串第一個數ex"123"取1
        if (c >= 'a' && c <= 'z')
        {
            Debug.Log("小寫");
        }
        if (c >= 'A' && c <= 'Z')
        {
            Debug.Log("大寫");
        }

    }
}
