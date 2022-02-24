using UnityEngine;
using UnityEngine.UI;
public class Judger : MonoBehaviour
{
    [SerializeField]//可以顯示在inspector裡但是不會被別人存取
    private Text result = null;
    public void init()
    {
        this.result.text = "";
    }
    public WinType checkWin(int type, int c2)
    {
        //1剪刀 2石頭 3布
        //string output = "玩家A:" + (PSS.GuessingType)p1 + "," + "玩家B:" + (PSS.GuessingType)c2;//(GuessingType)p1＝顯示該(p1)數字代表的意義
        string result = " ";
        WinType winType = WinType.None;
        //只計算玩家Ａ出剪刀，石頭，布的情況
        if (type - c2 == -2 || type - c2 == 1)
        {
            result = "=>玩家獲勝";
            winType = WinType.PlayerWin;
        }
        else if (type == c2)
        {
            result = "=>平局";
            winType = WinType.Draw;
        }
        else
        {
            result = "電腦獲勝";
            winType = WinType.AiWin;
        }
        this.result.text = result;
        Debug.Log("Judger c2" + c2);
        Debug.Log("Judger type" + type);
        return winType;
    }
    public enum WinType
    {
        None = -1,
        Draw = 0,
        PlayerWin = 1,
        AiWin = 2
    }
}