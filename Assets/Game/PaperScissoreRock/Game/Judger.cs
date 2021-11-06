using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Judger : MonoBehaviour
{
    public Text aiPlayer = null;
    public Text p1Player = null;
    public void init()
    {
        this.aiPlayer.text = "";
        this.p1Player.text = "";
    }
    public void checkWin(int p1, int c2)
    {
        //1剪刀 2石頭 3布
        string output = "玩家A:" + (PSS.GuessingType)p1 + "," + "玩家B:" + (PSS.GuessingType)c2;//(GuessingType)p1＝顯示該(p1)數字代表的意義
        string result = " ";
        //只計算玩家Ａ出剪刀，石頭，布的情況
        if (p1 - c2 == -2 || p1 - c2 == 1)
        {
            result = "=>玩家Ａ獲勝";
        }
        else if (p1 == c2)
        {
            result = "=>平局";
        }
        else
        {
            result = "玩家Ａ失敗";
        }
        Debug.Log(output + result);
        Debug.Log("玩家A:" + (PSS.GuessingType)p1);
        Debug.Log("玩家B:" + (PSS.GuessingType)c2);
        Debug.Log(result);
        this.aiPlayer.text = "電腦:" + (PSS.GuessingType)c2;
        this.p1Player.text = "玩家:" + (PSS.GuessingType)p1;
    }
}
