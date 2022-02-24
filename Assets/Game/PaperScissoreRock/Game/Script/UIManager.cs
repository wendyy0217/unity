using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


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
    public Image aiTargetImage = null;
    public Sprite[] sprites = null;
    public Sprite[] aiSprites = null;
    public Sprite pokerBack = null;
    public void init()
    {
        this.gameOver.SetActive(false);
        this.restartButton.SetActive(false);
        this.leaveButton.SetActive(false);
        this.btnGroup.SetActive(false);
        this.gameTitle.SetActive(true);
        this.playButton.SetActive(true);//.SetActive控制整個物件(包含功能)
        this.targetImage.enabled = false;//.enabled控制影像ex. Image
        this.aiTargetImage.enabled = false;
    }
    public void gameStart()
    {
        this.gameTitle.SetActive(false);
        this.playButton.SetActive(false);
        this.btnGroup.SetActive(true);
        this.targetImage.enabled = true;//.enabled控制影像ex. Image
        this.aiTargetImage.enabled = true;
        this.targetImage.sprite = this.pokerBack;
        this.aiTargetImage.sprite = this.pokerBack;
    }
    private void onGameOver()
    {
        this.gameOver.SetActive(true);
        this.restartButton.SetActive(true);
        this.leaveButton.SetActive(true);
        this.btnGroup.SetActive(false);
        this.targetImage.enabled = true;
        this.aiTargetImage.enabled = true;
    }
    public void restart()
    {
        this.btnGroup.SetActive(true);
        this.gameOver.SetActive(false);
        this.leaveButton.SetActive(false);
        this.restartButton.SetActive(false);
        this.gameStart();
    }
    private void setPlayerImage(int type)
    {
        this.targetImage.sprite = this.sprites[type - 1];
        Debug.Log("UIM type" + type);
    }
    private void setAIImage(int c2)
    {
        this.aiTargetImage.sprite = this.aiSprites[c2 - 1];
        Debug.Log("UIM c2" + c2);
    }
    public void showResult(int myType, int aiType, Judger.WinType winType)
    {
        DOTween.Sequence()
            .Append(this.targetImage.transform.DOLocalRotate(new Vector3(0, 0, 0), 0))
            .Append(this.targetImage.transform.DOLocalRotate(new Vector3(0, 90, 0), 0.5f))
            .AppendCallback(() =>
            {
                this.setPlayerImage(myType);
            })
            .Append(this.targetImage.transform.DOLocalRotate(new Vector3(0, 180, 0), 0.5f))
            .AppendCallback(() =>
            {

                this.onGameOver();
                this.setAIImage(aiType);
            });
    }
}
