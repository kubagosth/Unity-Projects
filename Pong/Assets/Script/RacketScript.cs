using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketScript : MonoBehaviour
{
    public BallScript BallScript;
    public void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.name =="Ball")
        {
            BallScript.IncreaseHitCounter();

        }
    }
}
