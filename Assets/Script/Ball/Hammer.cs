using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : Strigger
{
    public LayerMask target;


   
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
