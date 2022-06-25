using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBallResetterScript : MonoBehaviour
{
    public Collider Ball1, Ball2, Ball3, Ball4, Ball5, Trail1, Trail2, Trail3, Trail4, Trail5;
    public BallControlScript manager1, manager2, manager3, manager4, manager5;
    public TrailDespawnScript managerT1, managerT2, managerT3, managerT4, managerT5;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision == Ball1)
        {
            manager1.DisableRender();

            manager1.TeleportBallWait();
        }
        if (collision == Ball2)
        {
            manager2.DisableRender();

            manager2.TeleportBallWait();
        }
        if (collision == Ball3)
        {
            manager3.DisableRender();

            manager3.TeleportBallWait();
        }
        if (collision == Ball4)
        {
            manager4.DisableRender();

            manager4.TeleportBallWait();
        }
        if (collision == Ball5)
        {
            manager5.DisableRender();

            manager5.TeleportBallWait();
        }

        if (collision == Trail1)
        {
            managerT1.Despawn();
        }
        if (collision == Trail2)
        {
            managerT2.Despawn();
        }
        if (collision == Trail3)
        {
            managerT3.Despawn();
        }
        if (collision == Trail4)
        {
            managerT4.Despawn();
        }
        if (collision == Trail5)
        {
            managerT5.Despawn();
        }
    }

}