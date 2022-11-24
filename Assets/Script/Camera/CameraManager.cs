using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    public GameObject CameraMain;
    public GameObject cinemachineVirtualCamera;
    // Start is called before the first frame update
    void Start()
    {
        CameraMain.SetActive(true);
        cinemachineVirtualCamera.SetActive(false);
    }

    private void OnEnable()
    {
        UIManager.Ins.OnPlayerVictory.AddListener(victoryGameCamera);
        UIManager.Ins.OnPlayerLose.AddListener(loseGameCamera);
        UI.countdownTime += countdownTimeLoseGame;
    }

    private void loseGameCamera()
    {
        CameraMain.SetActive(false);
        cinemachineVirtualCamera.SetActive(true);
    }

    private void victoryGameCamera()
    {
        CameraMain.SetActive(false);
        cinemachineVirtualCamera.SetActive(true);
    }

    public void countdownTimeLoseGame()
    {
        CameraMain.SetActive(false);
        cinemachineVirtualCamera.SetActive(true);
    }

    private void OnDisable()
    {
        UIManager.Ins.OnPlayerVictory.RemoveListener(victoryGameCamera);
        UIManager.Ins.OnPlayerLose.RemoveListener(loseGameCamera);
        UI.countdownTime += countdownTimeLoseGame;
    }
}
