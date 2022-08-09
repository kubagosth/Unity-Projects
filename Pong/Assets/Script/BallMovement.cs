using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public BallScript BallScript;
    public Score Score;

    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHight = c.collider.bounds.size.y;

        float x;
        if (c.gameObject.name == "RacketPlayer1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / racketHight;

        this.BallScript.IncreaseHitCounter();
        this.BallScript.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "RacketPlayer1" || other.gameObject.name == "RacketPlayer2")
        {
            this.BounceFromRacket(other);
        }
        else if (other.gameObject.name == "LeftWall")
        {
            this.Score.GoalPlayer2();
            StartCoroutine(this.BallScript.StarBall(true));
        }
        else if (other.gameObject.name == "RightWall")
        {
            this.Score.GoalPlayer1();
            StartCoroutine(this.BallScript.StarBall(false));
        }
    }
}
