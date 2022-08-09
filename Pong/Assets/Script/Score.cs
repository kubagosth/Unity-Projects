using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;

    public BallScript BallScript;
    
    public Text PlayerWon;
    public int goalToWin;


    private void Update()
    {
        if (this.scorePlayer1 >= this.goalToWin)
        {
            PlayerWon.text = "Player  1  Won";
            SceneManager.LoadScene(2);
            
        }

        if (this.scorePlayer2 >= this.goalToWin)
        {
            PlayerWon.text = "Player  2  Won";
            SceneManager.LoadScene(2);
        }

    }

    private void FixedUpdate()
    {
        Text uiScorePlayer1 = this.scoreTextPlayer1.GetComponent<Text>();
        uiScorePlayer1.text = this.scorePlayer1.ToString();
        Text uiScorePlayer2 = this.scoreTextPlayer2.GetComponent<Text>();
        uiScorePlayer2.text = this.scorePlayer2.ToString();
    }

    public void GoalPlayer1()
    {
        this.scorePlayer1++;
        this.BallScript.hitCounter = 0;
    }

    public void GoalPlayer2()
    {
        this.scorePlayer2++;
        this.BallScript.hitCounter = 0;
    }
}
