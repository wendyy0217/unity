using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberCount : MonoBehaviour
{
    public Text randomNumber;
    public Text randomNum;
    // Start is called before the first frame update
    void Start()
    {
        this.creatRandomNumber();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void creatRandomNumber()
    {
        int randomNum = Random.Range(0, 10000);

        this.randomNumber.text = randomNum + "";//  將數值變字串：randomNum後面加 ＋"" 或 .ToString()

        if (randomNum < 1000)
        {
            if (randomNum < 100)
            {
                if (randomNum < 10)
                {
                    this.randomNum.text = "個位數";
                }
                else
                {
                    this.randomNum.text = "二位數";
                }
            }
            else
            {
                this.randomNum.text = "三位數";
            }
        }
        else
        {
            this.randomNum.text = "四位數";
        }
    }
}
