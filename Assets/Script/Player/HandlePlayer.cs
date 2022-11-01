using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePlayer : AbsShootingAndThrowBall
{

    private void Awake()
    {
        isHaveBall = true;
    }
    protected override void chupbanh(Transform ball, Rigidbody rigidbody)
    {
        _ball = ball;
        isHaveBall = true;
        RbBall = rigidbody;
        rigidbody.velocity = Vector3.zero;
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
