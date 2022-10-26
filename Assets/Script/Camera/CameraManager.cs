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

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        UIManager.Ins.OnVictory.AddListener(victoryGameCamera);
    }

    private void victoryGameCamera()
    {
        CameraMain.SetActive(false);
        cinemachineVirtualCamera.SetActive(true);
    }
}
