using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderItem : MonoBehaviour
{
    public Transform targetTele;
    private void Start()
    {
        //TeleTwo = GameObject.Find("TeleTow");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Cube")
        {

            other.gameObject.SetActive(false);
            other.gameObject.GetComponent<TrailRenderer>().time = 0.0f;
            other.gameObject.transform.position = new Vector3(targetTele.position.x, 1.0f, targetTele.position.z);
            other.gameObject.SetActive(true);
            other.gameObject.GetComponent<TrailRenderer>().time = 0.2f;
        }

        if(other.gameObject.tag == "Hammer")
        {
            other.gameObject.SetActive(false);
            other.gameObject.GetComponent<TrailRenderer>().time = 0.0f;
            other.gameObject.transform.position = new Vector3(targetTele.position.x, 1.0f, targetTele.position.z);
            other.gameObject.SetActive(true);
            other.gameObject.GetComponent<TrailRenderer>().time = 0.2f;
        }
    }
}
  