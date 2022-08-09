using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{

        public float speed = 200f;
        
        private void FixedUpdate()
        {
            float v = Input.GetAxisRaw("Vertical2");

            GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
        }
}
