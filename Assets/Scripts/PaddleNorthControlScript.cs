using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleNorthControlScript : MonoBehaviour
{
    public float speed;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public Rigidbody rig;
    public ScoreManagerScript manager;

    public void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        MoveObject(GetInput());
    }

    private Vector3 GetInput()
    {
        if (Input.GetKey(leftKey))
        {
            if (GetComponent<Rigidbody>().position.x > -39f)
            {
                return Vector3.left * speed;
            }
        }
        else if (Input.GetKey(rightKey))
        {
            if (GetComponent<Rigidbody>().position.x < 38f)
            {
                return Vector3.right * speed;
            }
        }

        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        if (manager.NisLose == false)
        {
            transform.Translate(movement * Time.deltaTime);
        }
    }
}
