using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGameUIScript : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu Scene");
    }

    public void Replay()
    {
        SceneManager.LoadScene("InGame Scene");
    }
}
