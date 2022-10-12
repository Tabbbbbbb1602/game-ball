using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboPlayer : MonoBehaviour
{
    private int count = 0;
    private void OnCollisionEnter(Collision collision)
    {
        GameObject ball = GameObject.Find("Ball(Clone)");
        if(collision.gameObject.tag == "Cube")
        {
            
            if(ball.GetComponent<ColliderBall>().tag == "Player")
            {
                //neu cham thi tang len 1
                count += 1;
            }
            else
            {
                //neu cham khac enemy thi reset xuong 1
                count = 1;
            }

            if (count == 3)
            {
                count = 0;
                //sinh ra mot cai bua
            }
        }
    }
}
