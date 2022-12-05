using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HandlePlayer : AbsShootingAndThrowBall
{
    Animator m_animator;
    private void Awake()
    {
        isHaveBall = true;
        m_animator = gameObject.GetComponent<Animator>();
        GameObject ball = GameObject.FindGameObjectWithTag("Ball");
    }
    protected override void chupbanh()
    {
        isHaveBall = true;
        RbBall.velocity = Vector3.zero;
        m_animator.SetBool("isRunning", false);
        RbBall.GetComponent<ColliderBall>().tag = "Player";
    }

    protected override void nembanh(Vector3 direction)
    {
        float force = 2000f;
        if(isHaveBall)
        {
            FindObjectOfType<AudioManager>().Play("throw");
            RbBall.AddForce(direction.normalized * force);
            isHaveBall = false;
        }
    }
}
