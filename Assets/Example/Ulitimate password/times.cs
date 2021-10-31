using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class times : MonoBehaviour
{
    public Text scoreText;
    public int Score = 0;
    public static times Instance;
    int a = 5;
    public GameObject GameOver;
    //重新開始按鈕
    public Button restartButton;
//輸入答案
    public InputField playerAnswerUI;
    //提示訊息
    public Text hintMessage;
    public Text lastText;


    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            a = a - 1;
            GetComponent<Text>().text = "" + a;
        }
        if (a ==0)
        {
            GameOver.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            playerAnswerUI.gameObject.SetActive(false);
            hintMessage.gameObject.SetActive(false);
            lastText.gameObject.SetActive(false);
            scoreText.gameObject.SetActive(false);
        }
    }
}


