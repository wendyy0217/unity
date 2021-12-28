using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StringCutMain : MonoBehaviour
{
    public string input="";
   public string output="";
    void Start()
    {
        this.stringCut(this.input);
    }

    void Update()
    {
        
    }
public void stringCut(string input)
{
string[] subs = input.Split(' ');
foreach (var sub in subs)
{
    output+=sub[0];
}
Debug.Log(output);
}

}
