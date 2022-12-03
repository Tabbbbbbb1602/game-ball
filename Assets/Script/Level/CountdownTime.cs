using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTime : MonoBehaviour
{
    public float timeRemaining;
    public bool timerIsRunning = false;
    public Text timeText;
    private UIManager uIManager;

    private bool endGame;

    private void Awake()
    {
        uIManager = UIManager.Ins;
    }

    private void OnEnable()
    {
        uIManager.OnPlayerVictory.AddListener(StopTime);
        uIManager.OnPlayerLose.AddListener(StopTime);
    }

    public void StopTime()
    {
        endGame = true;
    }

    private void Start()
    {
        timerIsRunning = true; 
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (!endGame)
            {
                timeRemaining -= Time.deltaTime;
            }

            if(timeRemaining <= 0)
            {
                timeRemaining = 0;
                endGame = true;
                UIManager.Ins.playerLose();
            }
            DisplayTime(timeRemaining);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    private void OnDisable()
    {
        uIManager.OnPlayerVictory.RemoveListener(StopTime);
        uIManager.OnPlayerLose.RemoveListener(StopTime);
    }
}
