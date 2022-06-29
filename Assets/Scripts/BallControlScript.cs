using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControlScript : MonoBehaviour
{
    public Vector2 speed;
    public Rigidbody rig;
    public int VelX;
    public int VelY;
    public int TimePoint;

    public ScoreManagerScript manager;
    public TrailDespawnScript managerT;

    public void Start()
    {
        rig = GetComponent<Rigidbody>();

        StartCoroutine(TeleportBallWaitWait());
    }

    public void Update()
    {
        
    }

    public void DisableRender()
    {
        GetComponent<Renderer>().enabled = false;
    }

    IEnumerator TeleportBallWaitWait()
    {
        yield return new WaitForSeconds(TimePoint);

        TeleportBallWait();
    }

    public void TeleportBallWait()
    {
        StartCoroutine(TeleportBall());
    }

    IEnumerator TeleportBall()
    {
        yield return new WaitForSeconds(5);

        if (manager.isWin == false)
        {
            if (Random.value < 0.5f)
            {
                if (Random.value < 0.5f)
                {
                    transform.position = new Vector3(-49, 25, 48);
                    VelX = Random.Range(10, 80);
                    VelY = Random.Range(10, 80);
                    rig.velocity = new Vector2(VelX, VelY);

                    GetComponent<Renderer>().enabled = true;
                    managerT.SpawnAgain();
                }
                else
                {
                    transform.position = new Vector3(47, 25, 48);
                    VelX = Random.Range(-10, -80);
                    VelY = Random.Range(10, 80);
                    rig.velocity = new Vector2(VelX, VelY);

                    GetComponent<Renderer>().enabled = true;
                    managerT.SpawnAgain();
                }
            }
            else
            {
                if (Random.value < 0.5f)
                {
                    transform.position = new Vector3(-49, 123, 48);
                    VelX = Random.Range(10, 80);
                    VelY = Random.Range(-10, -80);
                    rig.velocity = new Vector2(VelX, VelY);

                    GetComponent<Renderer>().enabled = true;
                    managerT.SpawnAgain();
                }
                else
                {
                    transform.position = new Vector3(47, 123, 48);
                    VelX = Random.Range(-10, -80);
                    VelY = Random.Range(-10, -80);
                    rig.velocity = new Vector2(VelX, VelY);

                    GetComponent<Renderer>().enabled = true;
                    managerT.SpawnAgain();
                }
            }
        }
        
    }

}
