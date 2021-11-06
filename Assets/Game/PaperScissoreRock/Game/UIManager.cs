using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject btnGroup;
    public GameObject gameTitle;
    public GameObject playButton;
    public GameObject gameOver;
    public GameObject restartButton;
    public GameObject leaveButton;
    public GameObject button0;
    public GameObject button2;
    public GameObject button5;
    public void init()
    {
        this.gameOver.SetActive(false);
        this.restartButton.SetActive(false);
        this.leaveButton.SetActive(false);
        this.btnGroup.SetActive(false);
        this.gameTitle.SetActive(true);
        this.playButton.SetActive(true);
    }
    public void gameStart()
    {
        this.gameTitle.SetActive(false);
        this.playButton.SetActive(false);
        this.btnGroup.SetActive(true);
    }
    public void onGameOver()
    {
        this.gameOver.SetActive(true);
        this.restartButton.SetActive(true);
        this.leaveButton.SetActive(true);
        this.btnGroup.SetActive(false);
    }
    public void restart()
    {
        this.btnGroup.SetActive(true);
        this.gameOver.SetActive(false);
        this.leaveButton.SetActive(false);
        this.restartButton.SetActive(false);
    }

}
