using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Spawn : MonoBehaviour
{
    public Ball Ball;
    public Rigidbody rbBall;
    private Player m_player;

    public CinemachineVirtualCamera cinemachineVirtualCamera;

    private void Start()
    {
        activeBall();
        ActivePlayer();
    }

    void activeBall()
    {

       /* if (Ball)
            Destroy(Ball.gameObject);*/

        GameObject newBallerPrefab = ShopManager.Ins.itemsBall[Pref.CurBallId].BallPb;


        if (newBallerPrefab)
        {
            Ball.changeWeapon(newBallerPrefab);
            Ball.GetComponent<ColliderBall>().tag = "Player";
        }
    }

    public void ActivePlayer()
    {
        if (m_player)
            Destroy(m_player.gameObject);

        var newPlayerPrefab = ShopManager.Ins.items[Pref.CurPlayerId].playerPb;



        if (newPlayerPrefab)
        {
            m_player = Instantiate(newPlayerPrefab, new Vector3(0f, 0f, -10f), Quaternion.identity);
            m_player.transform.localScale = new Vector3(1, 1, 1);
            m_player.GetComponent<AbsShootingAndThrowBall>()._ball = Ball.transform;
            m_player.GetComponent<AbsShootingAndThrowBall>().RbBall = rbBall;

            /*cinemachineVirtualCamera.Follow = m_player.transform;
            cinemachineVirtualCamera.LookAt = m_player.transform;*/
        }

    }
}
