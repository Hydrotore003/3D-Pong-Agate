using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("InGame Scene");
    }

    public void HowtoPlay()
    {
        SceneManager.LoadScene("How to Play Scene");
    }

    public void Credit()
    {
        SceneManager.LoadScene("Credit Scene");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
