using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagerScript : MonoBehaviour
{
    public double NorthScore;
    public double SouthScore;
    public double WestScore;
    public double EastScore;

    public int MaxScore;
    public string Winner;
    public bool isWin;
    public bool NisLose, SisLose, WisLose, EisLose;

    public GameOverUISpawnerScript GameOverUI;

    public WallLoseEast managerWE;
    public WallLoseWest managerWW;
    public WallLoseNorth managerWN;
    public WallLoseSouth managerWS;

    public void Start()
    {
        isWin = false;
        NisLose = false;
        SisLose = false;
        WisLose = false;
        EisLose = false;
    }

    public void Update()
    {
        if (NorthScore == MaxScore - 1 && SouthScore == MaxScore && WestScore == MaxScore && EastScore == MaxScore)
        {
            isWin = true;
            Winner = "Game Over\nNorth Win";
        }
        if (SouthScore == MaxScore - 1 && NorthScore == MaxScore && WestScore == MaxScore && EastScore == MaxScore)
        {
            isWin = true;
            Winner = "Game Over\nSouth Win";
        }
        if (WestScore == MaxScore - 1 && SouthScore == MaxScore && NorthScore == MaxScore && EastScore == MaxScore)
        {
            isWin = true;
            Winner = "Game Over\nWest Win";
        }
        if (EastScore == MaxScore - 1 && SouthScore == MaxScore && WestScore == MaxScore && NorthScore == MaxScore)
        {
            isWin = true;
            Winner = "Game Over\nEast Win";
        }
        if (isWin == true)
        {
            GameOverUI.Spawn();
        }
        else
        {
            return;
        }
    }

    public void AddNorthScore(double increment)
    {
        if (NorthScore <= MaxScore - 0.5)
        {
            NorthScore += increment;

            if (NorthScore == MaxScore)
            {
                NisLose = true;
                managerWN.Lose();
            }
        }
    }

    public void AddSouthScore(double increment)
    {
        if (SouthScore <= MaxScore - 0.5)
        {
            SouthScore += increment;

            if (SouthScore == MaxScore)
            {
                SisLose = true;
                managerWS.Lose();
            }
        }
    }

    public void AddWestScore(double increment)
    {
        if (WestScore <= MaxScore - 0.5)
        {
            WestScore += increment;

            if (WestScore == MaxScore)
            {
                WisLose = true;
                managerWW.Lose();
            }
        }
    }

    public void AddEastScore(double increment)
    {
        if (EastScore <= MaxScore - 0.5)
        {
            EastScore += increment;

            if (EastScore == MaxScore)
            {
                EisLose = true;
                managerWE.Lose();
            }
        }
    }
}
