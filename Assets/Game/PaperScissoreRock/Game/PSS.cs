using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace PSS //用一個大資料夾將此script包起來，可以取與之前重複之命名
{
    public class PSS : MonoBehaviour
    {
        // private Computer c1 = new Computer();
        private Computer c2 = new Computer();
        private Player player = new Player();
        private Judge judge = new Judge();
        void Start()//用for迴圈自動檢查10次
        {
            ///this.player.name="屁屁豬";
            // for (int i = 0; i < 10; i++)
            // {
            //     int p1 = c1.action();
            //     int p2 = c2.action();
            //this.judge.checkWin(p1, p2);
            // }
        }
        public void playerInput(int type)
        {
            ///this.player.setType(type);
            this.judge.checkWin(type, this.c2.action());
        }
        // public void checkWin()//點確定裁判輸贏
        // {
        //     this.judge.checkWin(this.player.type, this.c2.action());
        //    /// Debug.Log(this.player.name);
        // }
    }
    public class Computer
    {
        public int action()
        {
            return Random.Range(1, 4);
        }
    }
    public class Player
    {
        ///public string name="";
        public int type { get; private set; }//只能用此type不能改內容
        public void setType(int type)
        {
            this.type = type;
        }
    }
    public class Judge
    {
        public void checkWin(int p1, int p2)
        {
            //1剪刀 2石頭 3布
            string output = "玩家A:" + (GuessingType)p1 + "," + "玩家B:" + (GuessingType)p2;//(GuessingType)p1＝顯示該(p1)數字代表的意義
            string result = " ";
            //只計算玩家Ａ出剪刀，石頭，布的情況
            if (p1 - p2 == -2 || p1 - p2 == 1)
            {
                result = "=>玩家Ａ獲勝";
            }
            else if (p1 == p2)
            {
                result = "=>平局";
            }
            else
            {
                result = "玩家Ａ失敗";
            }
            Debug.Log(output + result);
        }
    }
    enum GuessingType //數字代表的意義
    {
        Siccors = 1,
        Rock = 2,
        Paper = 3
    }
}
