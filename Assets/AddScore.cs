using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{

    public int highScore = 0;
    public Text highscoretext;
    public Text scoreText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        UpdateScore();
    }

    public void UpdateScore()
    {
        Score.score = Score.score + 1;
        scoreText.text = "S:" + Score.score;

        int highScore = PlayerPrefs.GetInt("HIGHSCORE");
        if (Score.score > highScore)
        {
            PlayerPrefs.SetInt("HIGHSCORE", Score.score);

            highscoretext.text = "HS:" + Score.score;
        }
        else
        {
            highscoretext.text = "HS:" + highScore;
        }



    }
}
