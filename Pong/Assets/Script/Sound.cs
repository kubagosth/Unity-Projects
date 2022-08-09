using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource RacketSound;
    public AudioSource WallSound;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "RacketPlayer1" || other.gameObject.name == "RacketPlayer2")
        {
            this.RacketSound.Play();
        }
        else
        {
            this.WallSound.Play();
        }
    }
}
