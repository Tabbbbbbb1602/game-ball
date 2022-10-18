using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//thuc hien viec sinh ra player va ball o moi man choi
public class LevelManager : Singleton<LevelManager>
{
    Player m_player;

    GameObject m_ball;

    [SerializeField] private GameObject enemyPrefab;

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

        ActivePlayer();
        //ActiveBall();
        GUIManager.Ins.UpdateCoins();
    }

    public void ActivePlayer()
    {
        if (m_player)
            Destroy(m_player.gameObject);

        var newPlayerPrefab = ShopManager.Ins.items[Pref.CurPlayerId].playerPb;



        if (newPlayerPrefab)
        {
            m_player = Instantiate(newPlayerPrefab, new Vector3(1.0f, 0f, -25f), Quaternion.identity);
            m_player.transform.localScale = new Vector3(2, 2, 2);
        }

    }

    //active Ball
    /*public void ActiveBall()
    {
        if (m_ball)
            Destroy(m_ball.gameObject);

        GameObject newBallerPrefab = ShopManager.Ins.itemsBall[Pref.CurBallId].BallPb;

        Debug.Log(newBallerPrefab);

        if (newBallerPrefab)
        {
            m_ball = Instantiate(newBallerPrefab, new Vector3(1.0f, 1.0f, -30.0f), Quaternion.Euler(new Vector3(0.0f, 210.0f, 0.0f)));
        }
    }*/
}
