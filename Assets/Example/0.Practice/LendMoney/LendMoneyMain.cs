using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LendMoneyMain : MonoBehaviour
{
    public InputField myNameInput = null;
    public InputField friendNameInput = null;
    public Text myNameOutput = null;
    public Text friendNameOutput = null;
    public Text myMoneyOutput = null;
    public Text friendMoneyOutput = null;
    private int lendMoney = 1000;
    private int friendOriginal = 20000;
    private int myOriginal = 0;
    public Text lendButtonName = null;
    public Text payBackButtonName = null;


    void Start()
    {
        this.updateInfo();
    }
    public void friendLendButton()
    {
        if (friendOriginal >= lendMoney)
        {
            friendOriginal -= lendMoney;
            myOriginal += lendMoney;
            this.updateInfo();
        }
    }
    public void payBackButton()
    {
        if (myOriginal >= lendMoney)
        {
            friendOriginal += lendMoney;
            myOriginal -= lendMoney;
            this.updateInfo();
        }
    }
    private void updateInfo()
    {
        friendMoneyOutput.text = friendOriginal + "";
        myMoneyOutput.text = myOriginal + "";
    }
    public void enterButton()
    {
        string myName = myNameInput.text;
        string friendName = friendNameInput.text;
        this.myNameOutput.text = myName;
        this.friendNameOutput.text = friendName;
        lendButtonName.text = myName + "向" + friendName + "借" + lendMoney;
        payBackButtonName.text = myName + "還" + friendName + lendMoney;
    }
}
