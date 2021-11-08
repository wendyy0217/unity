using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject btnGroup = null;
    public GameObject gameTitle = null;
    public GameObject playButton = null;
    public GameObject gameOver = null;
    public GameObject restartButton = null;
    public GameObject leaveButton = null;
    public GameObject button0 = null;
    public GameObject button2 = null;
    public GameObject button5 = null;
    public Image targetImage = null;
    public Sprite[] sprites = null;
    public void init()
    {
        this.gameOver.SetActive(false);
        this.restartButton.SetActive(false);
        this.leaveButton.SetActive(false);
        this.btnGroup.SetActive(false);
        this.gameTitle.SetActive(true);
        this.playButton.SetActive(true);//.SetActive控制整個物件(包含功能)
        this.targetImage.enabled = false;//.enabled控制影像ex. Image
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
        this.targetImage.enabled = true;
    }
    public void restart()
    {
        this.btnGroup.SetActive(true);
        this.gameOver.SetActive(false);
        this.leaveButton.SetActive(false);
        this.restartButton.SetActive(false);
        this.targetImage.enabled = false;
    }
    public void setPlayerImage(int type)
    {
        this.targetImage.sprite = this.sprites[type - 1];
    }
}
