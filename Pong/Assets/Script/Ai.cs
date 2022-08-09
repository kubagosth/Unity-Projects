using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour
{

    public float speed = 200f;
    public GameObject ball;

    private void FixedUpdate()
    {
        if (Math.Abs(this.transform.position.y - ball.transform.position.y) > 50)
        {
            if (transform.position.y < ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0,1) * speed;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0,-1) * speed;
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        }

        ;
    }
}
