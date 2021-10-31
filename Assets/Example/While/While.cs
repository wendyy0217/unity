using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class While : MonoBehaviour
{
    public InputField input1;
    public InputField input2;
    public Text totalOutput;

    void Start()
    {

    }


    void Update()
    {

    }
    public void inputTotal()
    {
        int total = 0;
        int startNum = int.Parse(this.input1.text);
        int endNum = int.Parse(this.input2.text);
        int targetCount = endNum - startNum + 1;
        int count = 0;
        while (count < targetCount)
        {
            total = total + startNum + count;
            count++;
            
        }
        this.totalOutput.text = total+" ";
    }
}
