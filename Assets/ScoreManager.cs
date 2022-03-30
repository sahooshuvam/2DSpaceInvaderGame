using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public int life = 3;
    public Text scoreText;
    public Text lifeText;
    public GameObject gameOverPanel;

    public void ScoreCalcutor(int scoreValue)
    {
        score = score + scoreValue;
        scoreText.text = score.ToString();
        Debug.Log("Score :"+score);
    }

    public void LifeCalculator(int lifeValue)
    {
        life = life - lifeValue;
        lifeText.text = life.ToString();
        if (life == 0)
        {
            gameOverPanel.SetActive(true);
        }
    }
}
