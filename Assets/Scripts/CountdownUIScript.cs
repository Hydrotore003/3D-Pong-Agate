using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownUIScript : MonoBehaviour
{
    public float Timer;
    public int seconds;
    public string TextGo;
    public Text CountdownText;

    public CountdownUIDespawnScript Despawner;

    public void Start()
    {

    }

    public void Update()
    {
        Timer -= Time.deltaTime;
        seconds = (int)(Timer % 60);

        CountdownText.text = seconds.ToString();

        if (seconds == 0)
        {
            CountdownText.text = TextGo.ToString();
        }

        if (Timer <= 0)
        {
            Despawner.despawnThis();
        }
    }
}
