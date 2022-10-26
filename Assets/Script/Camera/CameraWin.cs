using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWin : MonoBehaviour
{
    public GameObject respawn;

    void Start()
    {
        
        respawn = GameObject.FindWithTag("Player");
        respawn = GameObject.FindWithTag("MainCamera");

    }

    void Update()
    {
        
    }
}
