using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalControllerWestEastScript : MonoBehaviour
{
    public Collider Ball1, Ball2, Ball3, Ball4, Ball5;
    public bool West;
    public ScoreManagerScript manager;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision == Ball1 | Ball2 | Ball3 | Ball4 | Ball5)
        {
            if (West)
            {
                manager.AddWestScore(0.5);
            }
            else
            {
                manager.AddEastScore(0.5);
            }
        }
    }
}
