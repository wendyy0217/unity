using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Gamefuntion : MonoBehaviour
{
    public GameObject meteorite;
    public float time;
    public Text ScoreText;
    public int Score = 0;
    public static Gamefuntion Instance;
    public GameObject GameTitle;
    public GameObject GameOver;
    public GameObject PlayButton;
    public bool IsPlaying = false;
    public GameObject RestartButton;
    public GameObject QuitButton;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        // 遊戲開始時不顯示此文字字串
        GameOver.SetActive(false);
        RestartButton.SetActive(false);
    }

    // 飛鏢出現時間差
    void Update()
    {
        this.createMeteorite();
    }
    void createMeteorite()
    {
        time += Time.deltaTime;
        // 增加隕石生成條件
        if (time > 1f&&IsPlaying==true)
        {
            //飛鏢從右邊(-2.5f,3.5f)出來跑出距離10f
            Vector3 pos = new Vector3(20f, Random.Range(-2.5f, 3.5f), 0);
            Instantiate(meteorite, pos, transform.rotation);
            time = 0;
        }
    }
    public void AddScore()
    {
        Score += 3;
        ScoreText.text = "Score:" + Score;
    }
    public void GameStart()
    {
        IsPlaying = true;
        GameTitle.SetActive(false);
        PlayButton.SetActive(false);
        QuitButton.SetActive(false);

    }

    public void GameEnd()
    {
        IsPlaying = false;
        GameOver.SetActive(true);
        RestartButton.SetActive(true);
        QuitButton.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Debug.Log("ok");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}


