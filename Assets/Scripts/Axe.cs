using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    private MiniGameScript game;

    public void Awake()
    {
        GameObject minigameObject = GameObject.FindGameObjectWithTag("GameController");
        game = minigameObject.GetComponent<MiniGameScript>();
        Debug.Log(minigameObject.name);
    }

    public float OnAsteroidDestroyed()
    {
        // calculate angular speed
        // multiply by score multiplier
        return game.UpdateScore(game.GetScore() + game.ScoreMultiplier);
    }

    public float CalculateAngluarSpeed();
}
