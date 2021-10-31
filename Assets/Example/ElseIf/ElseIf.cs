using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElseIf : MonoBehaviour
{
    // UI Component
    public InputField input;
    public Text num;
    public Text resisdentIncome;

    float baggerPercent = 0.25f;   //賤民收入比例
    float normalPercent = 0.5f;    //庶民收入比例
    float elegantPercent = 0.75f;  //貴族收入比例
    int income = 1000000;  //國民年平均
    float baggerIncome = 0;
    float normalIncome = 0;
    float elegantIncome = 0;

    void Start()
    {
        this.init();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void init()
    {
        this.resisdentIncome.text = this.income.ToString();
        this.baggerIncome = this.income * this.baggerPercent;
        this.normalIncome = this.income * this.normalPercent;
        this.elegantIncome = this.income * this.elegantPercent;
    }

    public void inputEnd()
    {
        int num = int.Parse(this.input.text);

        if (num <= baggerIncome)
        {
            this.num.text = "你是個賤民";
        }
        else if (num > baggerIncome && num < normalIncome)
        {
            this.num.text = "你是個庶民";
        }
        else if (num >= normalIncome)
        {
            this.num.text = "你是個貴族";
        }
        else
        {
            this.num.text = "你是國王";
        }
    }
}
