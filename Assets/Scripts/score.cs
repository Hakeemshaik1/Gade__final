using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;

    private void Start()
    {
        EventManager.instance.obstaclePassedEvent.AddListener(UpdateScore);
    }

    private void UpdateScore()
    {
        int obstaclesPassed = EventManager.instance.GetObstaclesPassed();
        scoreText.text = "Score: " + (obstaclesPassed).ToString();
    }
}

