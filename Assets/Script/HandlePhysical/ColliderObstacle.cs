using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderObstacle : MonoBehaviour
{
    public enum TypeT
    {
        collide,
        collided
    }

    public TypeT type;
    public string tag;

    public GameObject ps;
    private GameObject enemyObjMap;

    //Kiểm tra va chạm ở vật thể

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.GetComponent<ColliderBall>() != null)

        {
            /*if (type == TypeT.collide)
            {
                if (collision.transform.GetComponent<ColliderBall>().tag != tag)
                {
                    Destroy(gameObject);
                    Instantiate(ps, transform.position, transform.rotation);
                }
                if (collision.transform.GetComponent<ColliderBall>().tag == tag)
                {
                   
                }

            }*/


            if (type == TypeT.collided)
            {
                if (collision.transform.GetComponent<ColliderBall>().tag != tag)
                {
                    FindObjectOfType<AudioManager>().Play("shoot");
                }
                if (collision.transform.GetComponent<ColliderBall>().tag == tag)
                {
                    Destroy(gameObject);
                    var effect = Instantiate(ps, transform.position, transform.rotation);
                    Destroy(effect, 1.0f);
                    FindObjectOfType<AudioManager>().Play("collider");
                    if(collision.transform.GetComponent<ColliderBall>().tag == "Player")
                    {
                        UIManager.Ins.changeTextCoins();
                    }

                }
            }

        }
    }
}
