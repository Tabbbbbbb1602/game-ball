using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
 
    public float PowEnemy;

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

    public GameObject loseGame;
    public GameObject gameLoad;

    //event
    public static event Action OnEnemyDead;

    private NavMeshAgent navMeshAgent;
    public AbsShootingAndThrowBall shootingAndThrowBall;

    private Transform target;

    private bool isRot;

    private Animator animator;
    private int hashVelocity;

    void Start()
    {
        //StartCoroutine(MoveEnemy(2.0f));
        haveBall = false;
        countObstaclePlayer = GameObject.Find("ObstaclePlayer");
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        hashVelocity = Animator.StringToHash("Velocity");
        StartCoroutine(MoveEnemyOne(2.0f));

    }

    private void OnEnable()
    {
        UIManager.Ins.OnEnemyVictory.AddListener(enemyVictory);
        UIManager.Ins.OnPlayerLose.AddListener(playerLose);
        AbsShootingAndThrowBall.OnChupBanh += OnChupBanh;
    }

    private void enemyLose()
    {
        navMeshAgent.ResetPath();
        //navMeshAgent.enabled = false;
        /* m_animator.SetBool("isRunning", false);
         m_animator.SetBool("isLose", true);*/

    }

    private void OnDisable()
    {
        UIManager.Ins.OnEnemyVictory.RemoveListener(enemyVictory);
        UIManager.Ins.OnPlayerLose.RemoveListener(playerLose);
        AbsShootingAndThrowBall.OnChupBanh -= OnChupBanh;
    }

    void enemyVictory()
    {
        //Debug.Log("enemyVictory");
    }

    void playerLose()
    {
        //Debug.Log("playerLose");
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
                Vector3 directionEnemy = target.position - PosBall.transform.position;
                directionEnemy.x = UnityEngine.Random.Range(directionEnemy.x - 10f, directionEnemy.x + 10f);
                directionEnemy.z = UnityEngine.Random.Range(directionEnemy.z - 10f, directionEnemy.z + 10f);
                shootingAndThrowBall.nem(directionEnemy);
                navMeshAgent.SetDestination(transform.position);
                isRot = false;
            }
        }
    }

    public void obstaclePlayer()
    {
        if(countObstaclePlayer.transform.childCount == 2)
        {
            navMeshAgent.ResetPath();
            UIManager.Ins.playerLose();
            UIManager.Ins.enemyVictory();
            PosBall.gameObject.SetActive(false);
        }
    }

    private void OnChupBanh(Transform shooter)
    {
        if(shooter.Equals(transform))
        {
            int index = UnityEngine.Random.Range(0, countObstaclePlayer.transform.childCount);
            target = countObstaclePlayer.transform.GetChild(index);
            isRot = true;
            navMeshAgent.ResetPath();
        }
    }


    //gọi event khi object bị hủy
    private void OnDestroy()
    {
        OnEnemyDead?.Invoke();
    }


    IEnumerator MoveEnemyOne(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        xPos = UnityEngine.Random.Range(-15.0f, 14.5f);
        zPos = UnityEngine.Random.Range(8.0f, 25.0f);
        position = new Vector3(xPos, 0.5f, zPos);
        if(!isRot)
        {
            agent.SetDestination(position);
        }
        StartCoroutine(MoveEnemyOne(2.0f));
    }
}
