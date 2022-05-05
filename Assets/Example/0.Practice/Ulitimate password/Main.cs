using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    //輸入答案
    public InputField playerAnswerUI;
    //解析過後玩家的答案
    public int playerAnswer;
    //正確答案
    public int correctAnswer;
    //提示訊息
    public Text hintMessage;
    //重新開始按鈕
    public Button restartButton;
    //宣告背景圖
    public Image bg;
    public Sprite newBg;
    public GameObject GameOver;
    

    void Start()
    {
        //遊戲一開始出一個新的問題
        NewQuestion();
    }
    //更新顯示訊息的方法
    void UpdateHintMessage(string message)
    {
        //hintMassage這個text的ＵＩ內容顯示成message
        hintMessage.text = message;

    }
    //隨機產生一個0~99的亂數當作答案
    void NewQuestion()
    {
        //遊戲一開始的時候show出提示訊息
        UpdateHintMessage("請輸入0到99之間的數");
        //不管產生最大值都不會是100，最小值有可能是0
        correctAnswer = Random.Range(0, 100);
        //遊戲一開始，重新開始的按鈕不會跑出來。玩完才跑出來。➡️SetActive(false)把按鈕關掉
        restartButton.gameObject.SetActive(false);
        GameOver.gameObject.SetActive(false);
    }
    bool CanGetInputNumber()
    {
        /*Parse如果無法轉成功會出現錯誤訊息所以用int.TryParse
        int.TryParse會嘗試把字串變數字。如果轉的成功會丟回playerAnswer
        因為playerAnswer在 bool CanGetInputNumber()外圍所以前面要加out
        return int.TryParse(playerAnswerUI.text, out playerAnswer);➡️這整個會輸出一個true (bool)*/
        return int.TryParse(playerAnswerUI.text, out playerAnswer);
    }
    public void CompareNumbers()
    {
        /*這段因為上面增加bool CanGetInputNumber()做修改
        //比對數字
        //playerAnswerUI的text原本是一個字串➡️前面加int.Parse就是把字串變數字➡️Parse如果無法轉成功會出現錯誤訊息
        playerAnswer = int.Parse(playerAnswerUI.text);*/
        //修改後
        //如果不能把玩家輸入的字串變數字➡️！為不能
        if (!CanGetInputNumber())
        {
            //更新提示訊息
            UpdateHintMessage("只能輸入數字哦～");
            return;
        }
        if (playerAnswer == correctAnswer)
        {
            UpdateHintMessage("恭喜你答對了");
            //答對的時候重新開始的按鈕跑出來
            restartButton.gameObject.SetActive(true);
            //換另一個背景
            bg.sprite = newBg;
        }
        if (playerAnswer > correctAnswer)
        {
            UpdateHintMessage("還要再小一點");
        }
        if (playerAnswer < correctAnswer)
        {
            UpdateHintMessage("還要再大一點");
        }
        FocusPlayerAnswerUI();
    }
    public void ClearHintMessage()
    {
        UpdateHintMessage("");
    }
    public void ReloadScene()
    {
        //GetActiveScene()取得當前的場景
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    
    void FocusPlayerAnswerUI()
    {
        //聚焦在輸入框可以不用再用滑鼠點輸入框回答
        playerAnswerUI.ActivateInputField();
    }
    void Update()
    {
       
    }
}
