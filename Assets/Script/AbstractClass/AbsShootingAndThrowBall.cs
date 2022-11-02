using System;
using UnityEngine;
using UnityEngine.Events;

public abstract class AbsShootingAndThrowBall: MonoBehaviour
{
    public bool isHaveBall;
    public Transform _ball;
    public Rigidbody RbBall;
    public static event Action<Transform> OnChupBanh;
    public static event Action OnNemBanh;


    public void chup(Transform shooter)
    {
        OnChupBanh?.Invoke(shooter);
        chupbanh();
    }

    public void nem(Vector3 force)
    {
        OnNemBanh?.Invoke();
        nembanh(force);
    }

    protected abstract void chupbanh();
    protected abstract void nembanh(Vector3 force);
}
