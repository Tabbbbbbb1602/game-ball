using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//qua ly viec xu ly cua qua bom

public class Boom : MonoBehaviour
{
    public float delay = 3.0f;
    public GameObject effect;
    public GameObject boom;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            gameObject.GetComponent<SphereCollider>().radius = 0.1f;
            var effects = Instantiate(effect, transform.position, transform.rotation);
            FindObjectOfType<AudioManager>().Play("collider");
            Destroy(effects, 1.0f);
            Destroy(gameObject, 0.1f);
        }


        if(collision.gameObject.tag == "Wall")
        {
            gameObject.isStatic = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ObsPlayer" || other.gameObject.tag == "ObsEnemy")
        {

            Destroy(other.gameObject);
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject, 1.0f);
        }
    }
}

