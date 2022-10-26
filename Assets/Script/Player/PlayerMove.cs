using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour
{
    private TouchInput inputs;
    [SerializeField]
    private float playerSpeed;
    [SerializeField]
    private float rotationSpeed = 3f;
    [SerializeField]
    private float ballSpeed = 3f;
    private CharacterController controller;

    public Transform PosBall;
    public GameObject Ball;
    private GameObject copyBall;
    public GameObject Hammer;

    private bool haveBall;
    private Vector3 direction;
    Vector3 motion;
    Vector3 StartPos;
    Vector3 EndPos;
    Vector2 delta;
    Vector3 gravity = Vector3.zero;


    Animator m_animator;

    public GameObject countObstacleEnemy;

    public GameObject partialVictory;
    private float time;

    public bool isVictory;

    private int count = 0;

    private GameObject ballTohammer;



    GameObject m_ball;


    Vector3 winGamePosition;

    private void Start()
    {
        //copyBall = Instantiate(Ball, Vector3.zero + new Vector3(1.0f, 1.0f, -30.0f), Quaternion.identity);
        m_ball.transform.GetComponent<ColliderBall>().tag = "Player";
        //copyBall.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        countObstacleEnemy = GameObject.Find("ObstacleEnemy");
        haveBall = true;
    }

    private void Awake()
    {
        inputs = new TouchInput();
        m_animator = gameObject.GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        m_animator.SetBool("isRunning", false);
        activeBall();
    }
    private void OnEnable()
    {
        inputs.touch.touchpos.performed += MovePlayer;
        inputs.touch.touchhold.started += StartThrow;
        inputs.touch.touchhold.canceled += EndThrow;
        UIManager.Ins.OnPlayerLose.AddListener(playerLose);
        inputs.Enable();
    }

    private void Update()
    {
        if (!controller.isGrounded)
        {
            gravity.y -= 9.8f;
            controller.Move(gravity * Time.deltaTime);
        } else
        {
            gravity.y = -9.8f;
        }
        obstacleEnemy();
    }

    public void obstacleEnemy()
    {
        if (countObstacleEnemy.transform.childCount == 4 && !isVictory)
        {
            int activeScene = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("LevelSaved", activeScene);
            GameObject gameObjCube = GameObject.FindGameObjectWithTag("Cube");
            GameObject gameObjHammer = GameObject.FindGameObjectWithTag("Hammer");
            Destroy(gameObjHammer);
            Destroy(gameObjCube);
            Instantiate(partialVictory, transform.position, transform.rotation);
            isVictory = true;
            m_animator.SetBool("isRunning", false);
            m_animator.SetBool("IsVictory", true);

            UIManager.Ins.winGame();
            UIManager.Ins.enemyLose();

            winGamePosition = new Vector3(0, 180, 0);
            transform.eulerAngles = winGamePosition;
        }
    }

    private void playerLose()
    {
        winGamePosition = new Vector3(0, 180, 0);
        transform.eulerAngles = winGamePosition;
        m_animator.SetBool("isRunning", false);
        m_animator.SetBool("IsLose", true);
    }

    private void StartThrow(InputAction.CallbackContext obj)
    {
        if (haveBall)
        {
            StartPos = m_ball.transform.position;
            m_animator.SetBool("isRunning", true);
        }
    }

    private void EndThrow(InputAction.CallbackContext obj)
    {
        if (haveBall)
        {
            m_ball.GetComponent<Rigidbody>().isKinematic = false;
            EndPos = transform.position;
            Throw();
        }
    }

    private void MovePlayer(InputAction.CallbackContext obj)
    {
        delta = obj.ReadValue<Vector2>();
        motion = new Vector3(delta.x, 0, delta.y);
        controller.Move(motion * 0.01f * playerSpeed);
    }

    private void OnDisable()
    {
        inputs.touch.touchpos.performed -= MovePlayer;
        inputs.touch.touchhold.started -= StartThrow;
        inputs.touch.touchhold.canceled -= EndThrow;
        UIManager.Ins.OnPlayerLose.AddListener(playerLose);
        inputs.Disable();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            if (collision.gameObject.GetComponent<ColliderBall>().tag == "Player")
            {
                count += 1;
                Debug.Log(count);
                if (count == 3)
                {
                    ballTohammer = Hammer;
                    count = 0;
                }
                else
                {
                    ballTohammer = Ball;
                }
            }
            else
            {
                //neu cham khac enemy thi reset xuong 1
                count = 1; 
                ballTohammer = Ball;
            }

            m_animator.SetBool("isRunning", false);
            Destroy(collision.gameObject);
            haveBall = true;
            spawnBall();
        }

        if(collision.gameObject.tag == "Hammer")
        {
            ballTohammer = Ball;
            m_animator.SetBool("isRunning", false);
            Destroy(collision.gameObject);
            haveBall = true;
            spawnBall();
        }
    }

    void spawnBall()
    {
        m_ball = Instantiate(ballTohammer, gameObject.transform.position + new Vector3(1.0f, 1.5f, 1.0f), Quaternion.identity);
        m_ball.transform.GetComponent<ColliderBall>().tag = "Player";
        m_ball.GetComponent<Renderer>().material.SetColor("_Color", Color.red);   
        m_ball.GetComponent<Rigidbody>().isKinematic = true;
    }



    void Throw()
    {
        if (haveBall)
        {
            direction = ((EndPos - StartPos) + new Vector3(2, 0, 10)).normalized;
            m_ball.GetComponent<Rigidbody>().AddForce(direction * ballSpeed, ForceMode.Impulse);
            m_animator.SetBool("isRunning", true);
            haveBall = false;
            FindObjectOfType<AudioManager>().Play("throw");
        }
    }

    //lấy quả bóng được lưu trong máy tính ra
    void activeBall()
    {
        if (m_ball)
            Destroy(m_ball.gameObject);

        GameObject newBallerPrefab = ShopManager.Ins.itemsBall[Pref.CurBallId].BallPb;

        if (newBallerPrefab)
        {
            m_ball = Instantiate(newBallerPrefab, new Vector3(1.0f, 1.0f, -30.0f), Quaternion.Euler(new Vector3(0.0f, 210.0f, 0.0f)));
        }
    }
}
