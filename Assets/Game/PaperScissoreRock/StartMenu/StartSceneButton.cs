using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneButton : MonoBehaviour
{
    public void BtnStartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void QuitGame()
    {
        Debug.Log("QuitGame!");
        Application.Quit();
    }
}
