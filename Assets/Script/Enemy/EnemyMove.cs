using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    //check have ball
    public bool haveBall;
    public GameObject enemyPrefab;

    //move random enemy
    public NavMeshAgent agent;

    //set position go to
    public Vector3 position;
    public float xPos;
    public float yPos;
    public float zPos;


    public Transform PosBall;
    public GameObject Ball;

    private GameObject countObstaclePlayer;

    Animator m_animator;

    private NavMeshAgent navMeshAgent;
    public AbsShootingAndThrowBall shootingAndThrowBall;

    private Transform target;

    public bool isRot;

    private Animator animator;
    private int hashVelocity;

    void Start()
    {
        haveBall = false;
        countObstaclePlayer = GameObject.Find("ObstaclePlayer");
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        hashVelocity = Animator.StringToHash("Velocity");

    }

    private void OnEnable()
    {
        AbsShootingAndThrowBall.OnChupBanh += OnChupBanh;
        UIManager.Ins.OnEnemyVictory.AddListener(enemyVictory);
        UIManager.Ins.OnEnemyLose.AddListener(enemyLose);
    }

    private void enemyLose()
    {   
        //Debug.Log("Enemy lose");
        animator.SetFloat(hashVelocity, 0);
        animator.SetBool("isLose", true);
        //GameObject.FindGameObjectWithTag("Enemy").SetActive(false);
    }

    void enemyVictory()
    {
        //Debug.Log("enemyVictory");
        //PosBall.gameObject.SetActive(false);
    }

    
    private void Awake()
    {
        m_animator = gameObject.GetComponent<Animator>();
        shootingAndThrowBall = GetComponent<AbsShootingAndThrowBall>();
    }

    private void Update()
    {
        float v = agent.velocity.magnitude / agent.speed;
        animator.SetFloat(hashVelocity, v);
        obstaclePlayer();
        nem();
    }

    public void nem()
    {
        if (isRot)
        {
            Quaternion rotLockAt = Quaternion.LookRotation(target.position - transform.position);
            transform.rotation = Quaternion.SlerpUnclamped(transform.rotation, rotLockAt, 5f * Time.deltaTime);
            if (Quaternion.Angle(rotLockAt, transform.rotation) <= 1f)
            {
                shootingAndThrowBall.nem(transform.forward);
                navMeshAgent.SetDestination(transform.position);
                isRot = false;
            }
        }
    }

    public void obstaclePlayer()
    {
        if(countObstaclePlayer.transform.childCount == 0)
        {
            navMeshAgent.ResetPath();
            UIManager.Ins.playerLose();
            UIManager.Ins.enemyVictory();
            PosBall.gameObject.SetActive(false);
        }
    }

    public void OnChupBanh(Transform shooter)
    {
        if(shooter.Equals(transform))
        {
            int index = UnityEngine.Random.Range(0, countObstaclePlayer.transform.childCount);
            target = countObstaclePlayer.transform.GetChild(index);
            isRot = true;
            navMeshAgent.ResetPath();
        }
    }

    IEnumerator MoveEnemyOne(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        xPos = UnityEngine.Random.Range(-10.0f, 10.0f);
        zPos = UnityEngine.Random.Range(8.0f, 25.0f);
        position = new Vector3(xPos, 0f, zPos);
        if(!isRot)
        {
            agent.SetDestination(position);
        }
        StartCoroutine(MoveEnemyOne(1.5f));
    }

    private void OnDisable()
    {
        AbsShootingAndThrowBall.OnChupBanh -= OnChupBanh;
        UIManager.Ins.OnEnemyVictory.RemoveListener(enemyVictory);
        UIManager.Ins.OnEnemyLose.RemoveListener(enemyLose);
    }
}
