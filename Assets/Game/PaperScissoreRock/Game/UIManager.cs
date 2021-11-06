using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject gameTitle;
    public GameObject playButton;
    public GameObject gameOver;
    public GameObject restartButton;
    public GameObject leaveButton;
    public GameObject button0;
    public GameObject button2;
    public GameObject Button5;
    public void init()
    {
        gameOver.SetActive(false);
        restartButton.SetActive(false);
        leaveButton.SetActive(false);
        button0.SetActive(false);
        button2.SetActive(false);
        Button5.SetActive(false);
    }
    public void GameStart()
    {
        gameTitle.SetActive(false);
        playButton.SetActive(false);
        button0.SetActive(true);
        button2.SetActive(true);
        Button5.SetActive(true);
    }
    void Update()
    {

    }
}
