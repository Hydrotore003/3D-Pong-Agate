using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownUIDespawnScript : MonoBehaviour
{
    public void despawnThis()
    {
        transform.position = new Vector3(0, -140, 260);

    }
}
