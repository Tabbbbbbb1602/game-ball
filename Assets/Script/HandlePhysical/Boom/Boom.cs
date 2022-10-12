using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//qua ly viec xu ly cua qua bom

public class Boom : MonoBehaviour
{
    public float delay = 3.0f;
    public GameObject BoomCollider;
    public GameObject BoomTrigger;
    public GameObject effect;

    float countdown;

    private void Start()
    {
        countdown = delay;
        BoomTrigger.SetActive(false);
        //BoomCollider.SetActive(false);
    }

   

    void SpawnBoom()
    {
        BoomCollider.SetActive(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            BoomCollider.SetActive(false);
            BoomTrigger.SetActive(true);
            var effects = Instantiate(effect, transform.position, transform.rotation);
            FindObjectOfType<AudioManager>().Play("collider");
            Destroy(effects, 1.0f);
            Destroy(gameObject);
        }


        if(collision.gameObject.tag == "Wall")
        {
            gameObject.isStatic = true;
        }
    }
}

