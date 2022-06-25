using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLoseWest : MonoBehaviour
{
    public ScoreManagerScript manager;
    

    public void Lose()
    {
        GetComponent<Collider>().isTrigger = false;
         
    }

}
