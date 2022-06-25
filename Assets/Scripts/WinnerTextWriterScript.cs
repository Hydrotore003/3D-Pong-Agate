using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerTextWriterScript : MonoBehaviour
{
    public Text WinnerText;

    public ScoreManagerScript manager;

    public void Update()
    {
        WinnerText.text = manager.Winner.ToString();
    }
}
