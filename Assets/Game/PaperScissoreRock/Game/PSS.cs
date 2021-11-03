using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace PSS //用一個大資料夾將此script包起來，可以取與之前重複之命名
{
    public class PSS : MonoBehaviour
    {
        public Text aiPlayer = null;
        public Text p1Player = null;
        private Computer c2 = new Computer();
        private Player player = new Player();
        private Judge judge = new Judge();
        public Judger judger = null;
        void Start()
        {
            ///this.judge.pss = this;//judge裡的pss有PSS權限
            this.judge.aiPlayer = this.aiPlayer;
            this.judge.p1Player = this.p1Player;
        }
        public void playerInput(int type)
        {
            this.judge.checkWin(type, this.c2.action());
            //this.judger.checkWin(type,this.c2.action());
        }

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
        public int type { get; private set; }//只能用此type不能改內容
        public void setType(int type)
        {
            this.type = type;
        }
    }
    public class Judge
    {
        ///public PSS pss = null;
        public Text aiPlayer = null;
        public Text p1Player = null;
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
            //Debug.Log(output + result);
            //Debug.Log("玩家A:" + (GuessingType)p1);
            //Debug.Log("玩家B:" + (GuessingType)p2);
            //Debug.Log(result);
            this.aiPlayer.text = "玩家A:" + (GuessingType)p1;
            this.p1Player.text = "玩家B:" + (GuessingType)p2;
        }
    }
    public enum GuessingType //數字代表的意義
    {
        Siccors = 1,
        Rock = 2,
        Paper = 3
    }
}
