using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameStarted;
    public int score;
    public Text ScoreText;
    public Text HightScoreText;

    private void Awake()
    {
        HightScoreText.text = "Best: " + GetHightScore().ToString();
    }

    public void StartGame()
    {
        gameStarted = true;
        FindObjectOfType<Road>().StartBuilding();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }
    }

    public void EndGame()
    {
        SceneManager.LoadScene(0);
    }

    public void IncreaseScore()
    {
        score++;
        ScoreText.text = score.ToString();
        if (score > GetHightScore())
        {
          PlayerPrefs.SetInt("Highscore",score);
          HightScoreText.text = "Best: " +  score.ToString();
        }
    }

    public int GetHightScore()
    {
        int i = PlayerPrefs.GetInt("Highscore");
        return i;
    }
}
