using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomTrigger : MonoBehaviour
{
    public GameObject effect;

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "ObsPlayer")
        {
            Destroy(other.gameObject);
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject, 1.0f);
        }
    }
}
