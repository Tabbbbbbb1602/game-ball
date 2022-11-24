using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CountdownTime : MonoBehaviour
{
    public float Timer;
    public static event Action LoseGame;
    // Start is called before the first frame update
    void Update()
    {
        if(Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
        else
        {
            LoseGame?.Invoke();
        }
    }
}
