using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLoseEast : MonoBehaviour
{
    public ScoreManagerScript manager;

    public void Lose()
    {
        GetComponent<Collider>().isTrigger = false;
         
    }

}
