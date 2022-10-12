using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHammer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Hammer")
        {
            Debug.Log("hammer");
        }
    }
}
