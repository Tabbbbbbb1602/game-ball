using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;


//thuc hien viec sinh ra player va ball o moi man choi
public class LevelManager : Singleton<LevelManager>
{
    /*public CinemachineVirtualCamera cinemachineVirtualCamera;
    Player m_player;

    GameObject m_ball;*/



    public override void Awake()
    {
        MakeSingleton(false);
        Time.timeScale = 1;
    }

    
    public override void Start()
    {
        base.Start();
        if (!PlayerPrefs.HasKey(PrefConst.COIN_KEY))
            Pref.Coins = 10000;

        //ActivePlayer();
        GUIManager.Ins.UpdateCoins();
    }

   /* public void ActivePlayer()
    {
        if (m_player)
            Destroy(m_player.gameObject);

        var newPlayerPrefab = ShopManager.Ins.items[Pref.CurPlayerId].playerPb;



        if (newPlayerPrefab)
        {
            m_player = Instantiate(newPlayerPrefab, new Vector3(1.0f, 0f, -25f), Quaternion.identity);
            m_player.transform.localScale = new Vector3(2, 2, 2);

            cinemachineVirtualCamera.Follow = m_player.transform;
            cinemachineVirtualCamera.LookAt = m_player.transform;
        }

    }*/
   
}
