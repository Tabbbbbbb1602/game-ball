using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;

public class GameManager : Singleton<GameManager>
{
    Player m_player;
    GameObject m_baller;

    public override void Awake()
    {
        MakeSingleton(false);
    }

    public override void Start()
    {
        base.Start();

        if (!PlayerPrefs.HasKey(PrefConst.COIN_KEY))
            Pref.Coins = 30000;

        ActivePlayer();
        ActiveBall();
        GUIManager.Ins.UpdateCoins();

        //xoa qua bong do co script trong unity
        GameObject gameObjCube = GameObject.Find("Ball(Clone)");
        Destroy(gameObjCube);
    }

    public void ActivePlayer()
    {
        if (m_player)
            Destroy(m_player.gameObject);

        var newPlayerPrefab = ShopManager.Ins.items[Pref.CurPlayerId].playerPb;

        if (newPlayerPrefab)
        {
            m_player = Instantiate(newPlayerPrefab, new Vector3(0.0f, 13.0f, 60.0f), Quaternion.Euler(new Vector3(0.0f, 180.0f, 0.0f)));
            m_player.GetComponent<CharacterController>().enabled = false;
            m_player.GetComponent<PlayerMove>().enabled = false;
            m_player.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }

    }

    public void ActiveBall()
    {
        if (m_baller)
            Destroy(m_baller.gameObject);

        GameObject newBallerPrefab = ShopManager.Ins.itemsBall[Pref.CurBallId].BallPb;

        if (newBallerPrefab)
        {
            m_baller = Instantiate(newBallerPrefab, new Vector3(-1.46f, 14.23f, 60.0f), Quaternion.Euler(new Vector3(0.0f, 210.0f, 0.0f)));
            m_baller.transform.localScale  = new Vector3(0.5f, 0.5f, 0.5f);
            //m_baller.transform.position = new Vector3(-1.46f, 13.60f, 60.0f);
        }
    }
}
