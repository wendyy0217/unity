using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
namespace PSS //用一個大資料夾將此script包起來，可以取與之前重複之命名
{
    public class PSS : MonoBehaviour
    {
        private Computer c2 = new Computer();
        public Judger judger = null;
        public UIManager uiManager = null;
            public Transform DoTweenSprite=null;
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
Tween myTween =this.DoTweenSprite.transform.DOLocalRotate(new Vector3(0,90,0),1);//使物件1秒內翻轉90度
            this.uiManager.setPlayerImage(type);
            int c_type = this.c2.action();
            this.judger.checkWin(type,c_type);
            //Debug.Log("PSS type"+type);
            //Debug.Log("PSS c2"+c2);
            this.uiManager.setAIImage(c_type);

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
