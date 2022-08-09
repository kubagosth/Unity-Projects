using System;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    public float speed = 200f;


    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
    }
}