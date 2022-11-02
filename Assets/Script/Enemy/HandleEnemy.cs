using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleEnemy : AbsShootingAndThrowBall
{
    private void Awake()
    {
        isHaveBall = false;
    }
    protected override void chupbanh()
    {
        isHaveBall = true;
        RbBall.velocity = Vector3.zero;
        RbBall.GetComponent<ColliderBall>().tag = "Enemy";
    }

    protected override void nembanh(Vector3 direction)
    {
        float force = 2000f;
        if (isHaveBall)
        {
            RbBall.AddForce(direction.normalized * force);
            isHaveBall = false;
        }
    }


}
