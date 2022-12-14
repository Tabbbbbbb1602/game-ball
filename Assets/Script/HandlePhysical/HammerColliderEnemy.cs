using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerColliderEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            other.gameObject.SetActive(false);
            Destroy(other.gameObject, 3.0f);
        }
    }
}
