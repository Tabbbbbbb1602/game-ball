using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveOne : MonoBehaviour
{
    private Vector3 position;
    private float xPos;
    private float yPos;
    private float zPos;

    public float randomXPosOneVal;
    public float randomXPosTwoVal;
    public float randomZPosOneVal;
    public float randomZPosTwoVal;




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
        xPos = UnityEngine.Random.Range(randomXPosOneVal, randomXPosTwoVal);
        zPos = UnityEngine.Random.Range(randomZPosOneVal, randomZPosTwoVal);
        position = new Vector3(xPos, 0f, zPos);
        if (!enemyMove.isRot)
        {
            agent.SetDestination(position);
        }
        StartCoroutine(MoveEnemyOne(1.5f));
    }
}
