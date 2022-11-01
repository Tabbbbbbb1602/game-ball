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
    }
    protected override void chupbanh(Transform ball, Rigidbody rigidbody)
    {
        _ball = ball;
        isHaveBall = true;
        RbBall = rigidbody;
        rigidbody.velocity = Vector3.zero;
        m_animator.SetBool("isRunning", false);
        RbBall.GetComponent<ColliderBall>().tag = "Player";
    }

    protected override void nembanh(Vector3 direction)
    {
        float force = 4000f;
        if(isHaveBall)
        {
            RbBall.AddForce(direction.normalized * force);
            isHaveBall = false;
        }
    }
}
