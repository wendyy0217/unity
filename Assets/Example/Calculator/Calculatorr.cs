using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculatorr : MonoBehaviour
{
    private string inputValue = "";

    private int maxInputLength = 9;

    private bool hasDot = false;

    public Text display = null;

    private decimal calNum = 0;

    private string op = "";

    private string initValue = "0";

    private void Start() //清空
    {
        this.init();
    }

    private void init() //初始化
    {
        this.inputValue = "";
        this.op = "";
        this.calNum = 0;
        this.hasDot = false;
        this.display.text = this.initValue;
    }

    public void input(string value) //字數判斷
    {
        if (this.inputValue.Length >= this.maxInputLength)
        {
            return;
        }
        if (value == ".")
        {
            if (this.hasDot)
            {
                return;
            }
            else
            {
                this.hasDot = true;
            }
        }
        this.inputValue += value;

        this.display.text =
            this.convertToCurrency(decimal.Parse(this.inputValue));
        //this.display.text = inputValue;
    }

    public void setOperator(string op) //呼叫符號運算
    {
        this.cal();
        this.op = op;
    }

    private void cal() //符號運算
    {
        if (this.inputValue != "")
        {
            Debug.Log (op);
            switch (this.op)
            {
                case "+":
                    this.calNum += decimal.Parse(this.inputValue);

                    break;
                case "-":
                    this.calNum -= decimal.Parse(this.inputValue);
                    break;
                case "x":
                    this.calNum *= decimal.Parse(this.inputValue);
                    break;
                case "/":
                    this.calNum /= decimal.Parse(this.inputValue);
                    break;
                default:
                    this.calNum = decimal.Parse(this.inputValue);
                    break;
            }
            this.inputValue = "";
            this.hasDot = false;

            this.display.text = this.convertToCurrency(this.calNum);
            //this.display.text = this.calNum.ToString();
        }
    }

    public void clear()//清空
    {
        this.init();
    }

    private string convertToCurrency(decimal num)//顯示金額的, -->N0是金額顯示的方法（三位一個,）
    {
        int integer = (int) num;
        decimal floatNum = num - integer;
        string output =
            integer.ToString("N0") + floatNum.ToString().Remove(0, 1);
        return integer.ToString("N0") + floatNum.ToString().Remove(0, 1);
    }
}
