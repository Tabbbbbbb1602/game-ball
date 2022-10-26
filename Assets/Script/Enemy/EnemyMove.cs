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
    private bool haveBall;
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

    private GameObject copyBall;


    private GameObject countObstaclePlayer;
    private Vector3 directionEnemy;

    Animator m_animator;

    public GameObject loseGame;
    public GameObject gameLoad;

    //event
    public static event Action OnEnemyDead;

    private NavMeshAgent navMeshAgent;

    void Start()
    {
        StartCoroutine(MoveEnemy(2.0f));
        haveBall = false;
        countObstaclePlayer = GameObject.Find("ObstaclePlayer");
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void OnEnable()
    {
        UIManager.Ins.OnEnemyLose.AddListener(enemyLose);
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
    }

    private void Update()
    {
        obstaclePlayer();
    }
    private void Awake()
    {
        m_animator = gameObject.GetComponent<Animator>();
        m_animator.SetBool("isRunning", true);
        //handleEnemy();
    }

    public void obstaclePlayer()
    {
        if(countObstaclePlayer.transform.childCount == 2)
        {
            GameObject gameObjCube = GameObject.FindGameObjectWithTag("Cube");
            Destroy(gameObjCube);
            UIManager.Ins.loseGame();
            navMeshAgent.enabled = false;
            m_animator.SetBool("isRunning", false);
            m_animator.SetBool("isVictory", true);
            UIManager.Ins.playerLose();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "Hammer")
        {
            //thuc hien gi do
        }
        if (collision.gameObject.tag == "Cube")
        {
            m_animator.SetBool("isRunning", false);
            Destroy(collision.gameObject);
            gameObject.GetComponent<BoxCollider>().isTrigger = true;
            haveBall = true;
            navMeshAgent.enabled = false;
            spawnBall();
            StartCoroutine(ThrowEnemy(2.0f));
        }
    }

    void spawnBall()
    {
        copyBall = Instantiate(Ball, gameObject.transform.position + new Vector3(1.0f, 1.5f, 3.0f), Quaternion.identity);
        copyBall.transform.GetComponent<ColliderBall>().tag = "Enemy";
        copyBall.GetComponent<Rigidbody>().isKinematic = true;
        copyBall.GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
    }

    IEnumerator ThrowEnemy(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        if (haveBall)
        {
            //random hướng ném giữa các vật thể
            int index = UnityEngine.Random.Range(0, countObstaclePlayer.transform.childCount);
            Transform target = countObstaclePlayer.transform.GetChild(index);
            directionEnemy = target.position - copyBall.transform.position;
            directionEnemy.x = UnityEngine.Random.Range(directionEnemy.x - 10f, directionEnemy.x + 10f);
            directionEnemy.z = UnityEngine.Random.Range(directionEnemy.z - 10f, directionEnemy.z + 10f);
            copyBall.GetComponent<Rigidbody>().isKinematic = false;

            //thực hiện ném
            copyBall.GetComponent<Rigidbody>().AddForce(directionEnemy.normalized * PowEnemy, ForceMode.VelocityChange);
            StartCoroutine(SetIsTrigger(0.5f));
            m_animator.SetBool("isRunning", true);
            haveBall = false;

            navMeshAgent.enabled = true;
        }
    }

    IEnumerator SetIsTrigger(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        gameObject.GetComponent<BoxCollider>().isTrigger = false;
    }

    IEnumerator MoveEnemy(float waitTime)
    {
        
        yield return new WaitForSeconds(waitTime);

        xPos = UnityEngine.Random.Range(-15.0f, 14.5f);
        zPos = UnityEngine.Random.Range(8.0f, 25.0f);
        position = new Vector3(xPos, 0.5f, zPos);
        if (haveBall)
        {
            agent.SetDestination(gameObject.transform.position);
        }
        else
        {
            agent.SetDestination(position);
        }
        StartCoroutine(MoveEnemy(2.0f));
    }

    //gọi event khi object bị hủy
    private void OnDestroy()
    {
        OnEnemyDead?.Invoke();
    }

    

}
