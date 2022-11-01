using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    public GameObject Hammer;

    public bool haveBall;
    private Vector3 direction;
    Vector3 motion;
    Vector3 StartPos;
    Vector3 EndPos;
    Vector2 delta;
    Vector3 gravity = Vector3.zero;

    Animator m_animator;

    private GameObject countObstacleEnemy;

    public GameObject partialVictory;
    private float time;

    public bool isVictory;

    private int counter = 0;

    private GameObject ballTohammer;

    public GameObject g_direction;

    GameObject m_ball;

    Vector3 winGamePosition;

    public AbsShootingAndThrowBall shootingAndThrowBall;

    public Slider slider;
    public GameObject dirBallRender;

    private void Awake()
    {
        haveBall = true;
        inputs = new TouchInput();
        m_animator = gameObject.GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        m_animator.SetBool("isRunning", false);
        PosBall.transform.GetComponent<ColliderBall>().tag = "Player";

        shootingAndThrowBall = GetComponent<AbsShootingAndThrowBall>();
        //activeBall();
    }
    private void Start()
    {
        
    }
    private void OnEnable()
    {
        inputs.touch.touchpos.performed += MovePlayer;
        inputs.touch.touchhold.started += StartThrow;
        inputs.touch.touchhold.canceled += EndThrow;
        UIManager.Ins.OnPlayerLose.AddListener(playerLose);
        AbsShootingAndThrowBall.OnChupBanh += combo;
        inputs.Enable();

    }
    

    private void combo(Transform shooter)
    {
        int count = 1;
        counter = !shooter.Equals(transform) ? 0 : counter + 1;

        if (counter == count)
        {
            PosBall.GetComponent<Ball>().changeWeapon(Hammer);
            Debug.Log("Combo di ban ei");
        } else if (counter > count)
        {
            PosBall.GetComponent<Ball>().changeWeapon(Ball);
            counter = 0;
        }

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
        //obstacleEnemy();

        directionBall();
    }

    private void directionBall()
    {
        if (m_ball)
        {
            Vector3 dirBall = g_direction.transform.position - m_ball.transform.position;
            dirBall.y = 0;
            g_direction.transform.rotation = Quaternion.LookRotation(dirBall.normalized);
        }
        
    }

    public void obstacleEnemy()
    {
       /* if (countObstacleEnemy.transform.childCount == 0 && !isVictory)
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
        }*/
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
        StartPos = PosBall.transform.position;
        m_animator.SetBool("isRunning", true);
    }

    private void EndThrow(InputAction.CallbackContext obj)
    {
        EndPos = transform.position;
        direction = (EndPos - StartPos).normalized;
        shootingAndThrowBall.nem(direction);
    }

    private void MovePlayer(InputAction.CallbackContext obj)
    {
        delta = obj.ReadValue<Vector2>();
        motion = new Vector3(delta.x, 0, delta.y);
        controller.Move(motion * 0.01f * playerSpeed);
        if (haveBall)
        {
            dirBallRender.SetActive(true);
        }
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
        /*if(collision.gameObject.tag == "Ball")
        {
            Debug.Log("abc");
            haveBall = true;
        }
        Debug.Log("abc");*/
       /* if (collision.gameObject.tag == "Cube")
        {
            if (collision.gameObject.GetComponent<ColliderBall>().tag == "Player")
            {
                ballTohammer = Ball;
                count += 1;
                if (count == 3)
                {
                    ballTohammer = Hammer;
                }
                slider.value = count;
            }
            else
            {
                //neu cham khac enemy thi reset xuong 1
                count = 0;
                ballTohammer = Ball;
                slider.value = count;
            }

            m_animator.SetBool("isRunning", false);
            Destroy(collision.gameObject);
            haveBall = true;
            //spawnBall();
        }

        if (collision.gameObject.tag == "Hammer")
        {
            count = 0;
            slider.value = count;
            ballTohammer = Ball;
            m_animator.SetBool("isRunning", false);
            Destroy(collision.gameObject);
            haveBall = true;
            //spawnBall();
        }*/
    }



    //lấy quả bóng được lưu trong máy tính ra
   /* void activeBall()
    {
        if (m_ball)
            Destroy(m_ball.gameObject);

        GameObject newBallerPrefab = ShopManager.Ins.itemsBall[Pref.CurBallId].BallPb;

        if (newBallerPrefab)
        {
            m_ball = Instantiate(newBallerPrefab, new Vector3(1.0f, 1.0f, -30.0f), Quaternion.Euler(new Vector3(0.0f, 210.0f, 0.0f)));
        }
    }*/
}
