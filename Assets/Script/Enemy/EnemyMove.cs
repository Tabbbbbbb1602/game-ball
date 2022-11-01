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

    void Start()
    {
        //StartCoroutine(MoveEnemy(2.0f));
        haveBall = false;
        countObstaclePlayer = GameObject.Find("ObstaclePlayer");
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void OnEnable()
    {
        UIManager.Ins.OnEnemyLose.AddListener(enemyLose);
        AbsShootingAndThrowBall.OnChupBanh += OnChupBanh;
    }

    private void enemyLose()
    {
        navMeshAgent.enabled = false;
        m_animator.SetBool("isRunning", false);
        m_animator.SetBool("isLose", true);
    }

    private void OnDisable()
    {
        UIManager.Ins.OnEnemyLose.AddListener(enemyLose);
        AbsShootingAndThrowBall.OnChupBanh -= OnChupBanh;
    }
    private void Awake()
    {
        m_animator = gameObject.GetComponent<Animator>();
        m_animator.SetBool("isRunning", true);
        shootingAndThrowBall = GetComponent<AbsShootingAndThrowBall>();
    }

    private void Update()
    {
        obstaclePlayer();
    }

    public void obstaclePlayer()
    {
        if(countObstaclePlayer.transform.childCount == 0)
        {
            UIManager.Ins.loseGame();
            navMeshAgent.enabled = false;
            m_animator.SetBool("isRunning", false);
            m_animator.SetBool("isVictory", true);
            UIManager.Ins.playerLose();
        }
    }

    private void OnChupBanh(Transform shooter)
    {
        if(shooter.Equals(transform))
        {
            StartCoroutine(NemBanh());
            navMeshAgent.enabled = false;
            m_animator.SetBool("isRunning", false);
        }
    }

    IEnumerator NemBanh()
    {
        int index = UnityEngine.Random.Range(0, countObstaclePlayer.transform.childCount);
        Transform target = countObstaclePlayer.transform.GetChild(index);
        Vector3 directionEnemy = target.position - PosBall.transform.position;
        directionEnemy.x = UnityEngine.Random.Range(directionEnemy.x - 10f, directionEnemy.x + 10f);
        directionEnemy.z = UnityEngine.Random.Range(directionEnemy.z - 10f, directionEnemy.z + 10f);
        yield return new WaitForSeconds(0.5f);
        shootingAndThrowBall.nem(directionEnemy);
        navMeshAgent.enabled = true;
        m_animator.SetBool("isRunning", true);
        transform.LookAt(target);
    }

    //gọi event khi object bị hủy
    private void OnDestroy()
    {
        OnEnemyDead?.Invoke();
    }

    

}
