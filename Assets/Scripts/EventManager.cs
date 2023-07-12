using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static EventManager instance;

    public UnityEvent obstaclePassedEvent;
    public UnityEvent bossDefeatedEvent;

    private int obstaclesPassed;
    private int levelsBeaten;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void IncrementObstaclesPassed()
    {
        obstaclesPassed += 10;
        obstaclePassedEvent.Invoke();
    }

    public void IncrementLevels()
    {
        levelsBeaten += 1;
        bossDefeatedEvent.Invoke();
    }

    public int GetObstaclesPassed()
    {
        return obstaclesPassed;
    }

    public int GetLevelsBeaten()
    {
        return levelsBeaten;
    }
}