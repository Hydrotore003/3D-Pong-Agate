using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreWriterScript : MonoBehaviour
{
    public Text NorthScoreText;
    public Text SouthScoreText;
    public Text WestScoreText;
    public Text EastScoreText;

    public ScoreManagerScript manager;

    public void Update()
    {
        NorthScoreText.text = manager.NorthScore.ToString();
        SouthScoreText.text = manager.SouthScore.ToString();
        WestScoreText.text = manager.WestScore.ToString();
        EastScoreText.text = manager.EastScore.ToString();
    }
}
