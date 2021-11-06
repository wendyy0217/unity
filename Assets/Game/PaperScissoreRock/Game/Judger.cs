using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Judger : MonoBehaviour
{
    [SerializeField]//可以顯示在inspector裡但是不會被別人存取
    private Text aiPlayer = null;
    [SerializeField]
    private Text p1Player = null;
    [SerializeField]
    private Text result = null;
    public UIManager uiManager = null;//讓Judger知道UIManager也可以用UIManager
    public void init()
    {
        this.aiPlayer.text = "";
        this.p1Player.text = "";
        this.result.text = "";
    }
    public void checkWin(int p1, int c2)
    {
        //1剪刀 2石頭 3布
        string output = "玩家A:" + (PSS.GuessingType)p1 + "," + "玩家B:" + (PSS.GuessingType)c2;//(GuessingType)p1＝顯示該(p1)數字代表的意義
        string result = " ";
        //只計算玩家Ａ出剪刀，石頭，布的情況
        if (p1 - c2 == -2 || p1 - c2 == 1)
        {
            result = "=>玩家獲勝";
        }
        else if (p1 == c2)
        {
            result = "=>平局";
        }
        else
        {
            result = "電腦獲勝";
        }
        this.aiPlayer.text = "電腦:" + (PSS.GuessingType)c2;
        this.p1Player.text = "玩家:" + (PSS.GuessingType)p1;
        this.result.text = result;
        this.uiManager.onGameOver();
    }
}
