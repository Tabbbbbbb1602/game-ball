using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveEnemy : MonoBehaviour
{
    private float xPos;
    private float zPos;
    private Vector3 position;

    //move random enemy
    public NavMeshAgent agent;
    private Animator animator;
    private int hashVelocity;


    private void Awake()
    {
        animator = GetComponent<Animator>();
        hashVelocity = Animator.StringToHash("Velocity");
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveEnemyOne(2.0f));
    }

    // Update is called once per frame
    void Update()
    {
        float v = agent.velocity.magnitude/agent.speed;
        animator.SetFloat(hashVelocity, v);
    }

    IEnumerator MoveEnemyOne(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        xPos = Random.Range(-15.0f, 14.5f);
        zPos = Random.Range(8.0f, 25.0f);
        position = new Vector3(xPos, 0.5f, zPos);
        agent.SetDestination(position);
        StartCoroutine(MoveEnemyOne(2.0f));
    }
}
