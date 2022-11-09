using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTwo : MonoBehaviour
{
    private Vector3 position;
    private float xPos;
    private float yPos;
    private float zPos;

    public NavMeshAgent agent;

    public EnemyMove enemyMove;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveEnemyOne(2.0f));
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator MoveEnemyOne(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        xPos = UnityEngine.Random.Range(1.0f, 10.0f);
        zPos = UnityEngine.Random.Range(4.0f, 15.0f);
        position = new Vector3(xPos, 0f, zPos);
        if (!enemyMove.isRot)
        {
            agent.SetDestination(position);
        }
        StartCoroutine(MoveEnemyOne(1.5f));
    }
}
