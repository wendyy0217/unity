using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace PSS //用一個大資料夾將此script包起來，可以取與之前重複之命名
{
    public class PSS : MonoBehaviour
    {
        private Computer c2 = new Computer();
        public Judger judger = null;
        public UIManager uiManager = null;
        void Start()
        {
            this.init();
        }
        private void init()
        {
            this.judger.init();
            this.uiManager.init();
        }
        public void playerInput(int type)
        {
            this.judger.checkWin(type, this.c2.action());
        }
        public void quitGame()
        {
            Application.Quit();
        }
        public void restart()
        {
            this.uiManager.restart();
            this.judger.init();
        }
    }
    public class Computer
    {
        public int action()
        {
            return Random.Range(1, 4);
        }
    }
    public enum GuessingType //數字代表的意義
    {
        Siccors = 1,
        Rock = 2,
        Paper = 3
    }

}
