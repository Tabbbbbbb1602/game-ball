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
    [SerializeField]
    private GameObject Ball;
    public GameObject Hammer;

    public bool haveBall;
    private Vector3 direction;
    Vector3 motion;
    Vector2 delta;
    Vector3 gravity = Vector3.zero;

    Animator m_animator;

    private GameObject countObstacleEnemy;

    public GameObject partialVictory;
    private float time;

    public bool isVictory;

    private int counter = 0;

    public GameObject g_direction;

    GameObject m_ball;

    Vector3 winGamePosition;

    public AbsShootingAndThrowBall shootingAndThrowBall;

    public Slider slider;
    public GameObject dirBallRender;
    private int HashVelocity;

    private GameObject newBallerPrefab;

    public GameObject cameraWin;

    private bool isChup;
    public int count = 3;

    public static event Action AnimationUi;

    private bool isAnimations;

    private bool isPause;

    public CameraShake cameraShake;
    private void Awake()
    {
        haveBall = true;
        inputs = new TouchInput();
        m_animator = gameObject.GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        HashVelocity = Animator.StringToHash("Velocity");
        shootingAndThrowBall = GetComponent<AbsShootingAndThrowBall>();
        newBallerPrefab = ShopManager.Ins.itemsBall[Pref.CurBallId].BallPb;
        isAnimations = true;
    }
    private void Start()
    {
        PosBall = GameObject.FindGameObjectWithTag("Ball").transform;
        countObstacleEnemy = GameObject.Find("ObstacleEnemy");
        //slider.maxValue = count;
        
    }
    private void OnEnable()
    {
        inputs.touch.touchhold.started += StartThrow;
        inputs.touch.touchpos.performed += MovePlayer;
        inputs.touch.touchhold.canceled += EndThrow;
        UIManager.Ins.OnPlayerVictory.AddListener(playerVictory);
        UIManager.Ins.OnPlayerLose.AddListener(playerLose);
        AbsShootingAndThrowBall.OnChupBanh += OnChupBanh;
        UI.pauseGame += pauseGame;
        inputs.Enable();
    }

    

    private void OnChupBanh (Transform shooter)
    {
        bool isShooter = shooter.Equals(transform);
        if (isShooter)
        {
            isChup = true;
        }
        counter = !isShooter ? 0 : counter + 1;

        if (counter == count)
        {
            PosBall.GetComponent<Ball>().changeWeapon(Hammer);
            StartCoroutine(cameraShake.Shake(0.15f, 1.0f));
        } else if(counter > count)
        {
            counter = 0;
            PosBall.GetComponent<Ball>().changeWeapon(newBallerPrefab);
        }
        slider.value = counter;

    }


    private void Update()
    {
        if(!isPause)
        {
            if (!controller.isGrounded)
            {
                gravity.y -= 9.8f;
            } else
            {
                gravity.y = -9.8f;
            }
            obstacleEnemy();

            directionBall();
        }
        //HandleAnimtion();
    }
    public void pauseGame(bool pause)
    {
        isPause = pause;
    }

    private void directionBall()
    {
        if(isChup)
        {
            direction = (transform.position - PosBall.position).normalized;
            direction.y = 0;
            Debug.DrawRay(transform.position, direction * 10f, Color.red);
        }   
    }

    public void obstacleEnemy()
    {
        if (countObstacleEnemy.transform.childCount == 0 && !isVictory)
        {
            int activeScene = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("LevelSaved", activeScene);
            Instantiate(partialVictory, transform.position, transform.rotation);
            isVictory = true;
            UIManager.Ins.playerVictory();
            UIManager.Ins.enemyLose();
            PosBall.gameObject.SetActive(false);
            slider.value = 0;
        }
    }

    private void playerLose()
    {
        m_animator.SetBool("isLose", true);
        winGamePosition = new Vector3(0, 0, 0);
        transform.eulerAngles = winGamePosition;
        PosBall.gameObject.SetActive(false);
    }

    private void playerVictory()
    {
        m_animator.SetBool("isVictory", true);
        winGamePosition = new Vector3(0, 90, 0);
        transform.eulerAngles = winGamePosition;
        GameObject[] enemy = GameObject.FindGameObjectsWithTag("Enemy");
        for(int i = 0; i < enemy.Length; i++)
        {
            enemy[i].SetActive(false);
        }
    }

    private void StartThrow(InputAction.CallbackContext obj)
    {
        m_animator.SetBool("isRunning", true);
        if (isAnimations)
        {
            AnimationUi?.Invoke();
        }
    }

    private void EndThrow(InputAction.CallbackContext obj)
    {
        m_animator.SetBool("isRunning", false);
        Debug.DrawRay(transform.position, direction, Color.red);
        shootingAndThrowBall.nem(direction);
        isChup = false;
    }

    private void MovePlayer(InputAction.CallbackContext obj)
    {
        if (!isPause)
        {
            delta = obj.ReadValue<Vector2>();
            motion = new Vector3(delta.x, 0, delta.y);
            controller.Move(motion * 0.01f * playerSpeed + gravity);
            Vector3 velocity = controller.velocity;
        }

        //AnimationUi?.Invoke();
        //Debug.Log(delta);
        /*if (haveBall)
        {
            dirBallRender.SetActive(true);
        }*/
    }

    private void OnDisable()
    {
        inputs.touch.touchpos.performed -= MovePlayer;
        inputs.touch.touchhold.started -= StartThrow;
        inputs.touch.touchhold.canceled -= EndThrow;
        UIManager.Ins.OnPlayerVictory.RemoveListener(playerVictory);
        UIManager.Ins.OnPlayerLose.RemoveListener(playerLose);
        AbsShootingAndThrowBall.OnChupBanh -= OnChupBanh;
        UI.pauseGame -= pauseGame;
        inputs.Disable();
    }

    private void HandleAnimtion()
    {
        Vector3 velocity = controller.velocity;
        velocity.y = 0;
        float v = velocity.magnitude;
        v = Math.Clamp(v, 0, 1);
        m_animator.SetFloat(HashVelocity, v);
    }
}
