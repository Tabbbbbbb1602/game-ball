using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderBall : MonoBehaviour
{
    public enum TypeT
    {
        collide,
        collided
    }

    public TypeT type;
    public string tag;

    /*private void Start()
    {
        gameObject.GetComponent<SphereCollider>().isTrigger = true;
    }

    IEnumerator setIsTriggerPlayer(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        if (gameObject.GetComponent<ColliderBall>().tag == "Player")
        {
            gameObject.GetComponent<SphereCollider>().isTrigger = false;
        }
    }

    IEnumerator setIsTriggerEnemy(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        if (gameObject.GetComponent<ColliderBall>().tag == "Enemy")
        {
            gameObject.GetComponent<SphereCollider>().isTrigger = false;
        }
    }


    //kiểm tra va chạm ở quả bóng => nếu trùng tag thì phá hủy vật thể

    private void OnTriggerExit(Collider other)
    {
        if (gameObject.GetComponent<ColliderBall>().tag == "Player")
        {
            gameObject.GetComponent<SphereCollider>().isTrigger = false;
        }

        if (gameObject.GetComponent<ColliderBall>().tag == "Player")
        {
            gameObject.GetComponent<SphereCollider>().isTrigger = false;
        }

    }

*/


    private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.transform.tag == "Enemy")
        {
            //Debug.Log("okkkkkkkkkkk");
            gameObject.GetComponent<SphereCollider>().isTrigger = false;
        }*/
        if (collision.transform.GetComponent<ColliderObstacle>() != null)
        {
           /* if (type == TypeT.collide)
            {
                if (collision.transform.GetComponent<Collider>().tag != tag)
                {

                }
                if (collision.transform.GetComponent<Collider>().tag == tag)
                {

                }

            }*/


            if (type == TypeT.collided)
            {
                if (collision.transform.GetComponent<ColliderBall>().tag != tag)
                {

                }
                if (collision.transform.GetComponent<ColliderBall>().tag == tag)
                {
                   
                }
            }

        }
    }
}
