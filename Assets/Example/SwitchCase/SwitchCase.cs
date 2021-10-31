using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwitchCase : MonoBehaviour
{
    public InputField input;
    public Text Month;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void InputEnd()
    {
        int Month = int.Parse(this.input.text);//字串轉數值
        switch (Month)
        {
            case 1:
                this.Month.text = "January";
                break;
            case 2:
                this.Month.text = "February";
                break;
            case 3:
                this.Month.text = "March";
                break;
            case 4:
                this.Month.text = "April";
                break;
            case 5:
                this.Month.text = "May";
                break;
            case 6:
                this.Month.text = "June";
                break;
            case 7:
                this.Month.text = "July";
                break;
            case 8:
                this.Month.text = "August";
                break;
            case 9:
                this.Month.text = "September";
                break;
            case 10:
                this.Month.text = "October";
                break;
            case 11:
                this.Month.text = "November";
                break;
            case 12:
                this.Month.text = "December";
                break;
                default:
                this.Month.text = "ERROR";
                break;

        }
    }
}
