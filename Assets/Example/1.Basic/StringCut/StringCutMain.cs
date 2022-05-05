using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
將每句句首組合成縮寫
*/
public class StringCutMain : MonoBehaviour
{
    public InputField input = null;

    public void buttonClick()
    {
        this.stringCut(this.input.text);
    }
    public void stringCut(string input)
    {
        string output = "";
        string[] subs = input.Split(' ');

        foreach (var sub in subs)
        {
            if (sub.Length > 0)
            {
                output += sub[0];
            }
        }
        Debug.Log(output);
    }
}
