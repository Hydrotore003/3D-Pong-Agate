using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUISpawnerScript : MonoBehaviour
{
    public void Spawn()
    {
        transform.position = new Vector3(0, 10f, 30f);
    }
}
