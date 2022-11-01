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

    public void chup(Transform ball, Rigidbody rigidbody, Transform shooter)
    {
        OnChupBanh?.Invoke(shooter);
        chupbanh( ball, rigidbody);
    }

    public void nem(Vector3 force)
    {
        OnNemBanh?.Invoke();
        nembanh(force);
    }

    protected abstract void chupbanh(Transform ball, Rigidbody rigidbody);
    protected abstract void nembanh(Vector3 force);
}
