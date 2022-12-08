using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : Strigger
{
    public LayerMask target;

    private void Awake()
    {
        
    }
    private void Update()
    {
        if(rigidbodyParent.velocity != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(rigidbodyParent.velocity);
        }
    }

    protected override void Vacham(Collider other)
    {
        int layer = other.gameObject.layer;
        if ((ignoreLayer & (1 << layer)) == 0)
        {
            if (preLayer == layer)
            {
                return;
            }

            if ((target & (1 << layer)) != 0)
            {
                SpawnEnemy spawn = other.gameObject.GetComponentInChildren<SpawnEnemy>();
                if(spawn != null)
                {
                    spawn.Dead();
                }
                return;
            }

            if (other.gameObject.TryGetComponent(out AbsShootingAndThrowBall shootingAndThrowBall))
            {
                shootingAndThrowBall.chup(other.transform);
            }

            preLayer = other.gameObject.layer;
        }
    }


}
