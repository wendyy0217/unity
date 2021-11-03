using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartAndEnd : MonoBehaviour
{
    public GameObject GameTitle;
    public GameObject PlayButton;
    public GameObject GameOver;
    public GameObject RestartButton;
    public GameObject LeaveButton;
    public GameObject Button0;
    public GameObject Button2;
    public GameObject Button5;
   // public bool IsPlaying = false;
    void Start()
    {
        GameOver.SetActive(false);
        RestartButton.SetActive(false);
         LeaveButton.SetActive(false);
         Button0.SetActive(false);
         Button2.SetActive(false);
         Button5.SetActive(false);
    }
    public void GameStart()
    {
        //IsPlaying = true;
        GameTitle.SetActive(false);
        PlayButton.SetActive(false);
        Button0.SetActive(true);
         Button2.SetActive(true);
         Button5.SetActive(true);
    }
    void Update()
    {
        
    }
}
