using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailDespawnScript : MonoBehaviour
{
    public void Start()
    {
        GetComponent<Renderer>().enabled = false;
    }

    public void Despawn()
    {
        GetComponent<Renderer>().enabled = false;
    }

    public void SpawnAgain()
    {
        GetComponent<Renderer>().enabled = true;
    }
}
