using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDonw : MonoBehaviour
{
    public float timePeriod = 2;
    public float height = 4.0f;
    private float timeSinceStart;
    private Vector3 pivot;
    private void Start()
    {
        pivot = transform.position;
        height /= 2;
        timeSinceStart = (3 * timePeriod) / 4;
    }
    void Update()
    {
        moveUptoDown();
    }

    void moveUptoDown()
    {
        Vector3 nextPos = transform.position;
        nextPos.y = pivot.y + height * Mathf.Sin(((Mathf.PI * 2) / timePeriod) * timeSinceStart);
        timeSinceStart += Time.deltaTime;
        transform.position = nextPos;
    }
}
