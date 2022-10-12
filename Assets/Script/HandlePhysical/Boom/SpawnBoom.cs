using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoom : MonoBehaviour
{
    public float delay = 3.0f;
    public GameObject BoomCollider;
    public GameObject BoomTrigger;

    float countdown;

    private void Start()
    {
        countdown = delay;
    }

    private void Update()
    {
        countdown -= Time.deltaTime;
        Debug.Log(countdown);
        if (countdown <= 0)
        {
            SpawnBooms();
        }
    }

    void SpawnBooms()
    {
        BoomCollider.SetActive(true);
    }
}
