using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalControllerNorthSouthScript : MonoBehaviour
{
    public Collider Ball1, Ball2, Ball3, Ball4, Ball5;
    public bool North;
    public ScoreManagerScript manager;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision == Ball1 | Ball2 | Ball3 | Ball4 | Ball5)
        {
            if (North)
            {
                manager.AddNorthScore(0.5);
            }
            else
            {
                manager.AddSouthScore(0.5);
            }
        }
    }
}
