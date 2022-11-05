using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationUIMain : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMove playerMove;

    Animator animator;

    private void Awake()
    {
        playerMove = GetComponent<PlayerMove>();
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        PlayerMove.AnimationUi += AnimationUi;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimationUi()
    {
        animator.SetBool("isAnimation", true);
    }

    private void OnDisable()
    {
        PlayerMove.AnimationUi += AnimationUi;
    }
}
