using System;
using UnityEngine;

public abstract class Strigger : MonoBehaviour
{ 
    public LayerMask ignoreLayer;
    public Rigidbody rigidbodyParent;
    public int preLayer = 31;

    private void OnTriggerEnter(Collider other)
    {
        Vacham(other);
    }

    protected abstract void Vacham(Collider other); 

}
