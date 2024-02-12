using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MiniGameScript : MonoBehaviour
{
    private float Score = 0;
    public int ScoreMultiplier = 25;
    public TextMeshProUGUI scoreText;

    public void Awake()
    {
        scoreText.text = "Score: "  + Score;
        StartGame();
    }

    public void StartGame() {
        for (int i = 0; true; i++) {
            Wave(i);
        }
    }

    public void Wave(int waveNumber) {
        
    }

    public float UpdateScore(float newScore) {
        Score = newScore;
        scoreText.text = "Score: "  + Score;
        return newScore;
    }

    public float GetScore() {
        return Score;
    }
}
