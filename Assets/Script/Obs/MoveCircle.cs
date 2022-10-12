using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCircle : MonoBehaviour
{
    public float _radian;
    public float _speed;
    private float time;

    private Vector3 pivot;

    private void Start()
    {
        pivot = transform.position;
    }

    private void Update()
    {
        move();
    }

    void move()
    {
        Vector3 nextPos = transform.position;
        nextPos.y = pivot.y;
        float x = Mathf.Cos(Time.time * _speed) * _radian;
        float y = pivot.y;
        float z = Mathf.Sin(Time.time * _speed) * _radian;
        transform.position = new Vector3(x, y, z);
    }


    private IEnumerator moveToCircle(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        move();
    }
}
