using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//thuc hien viec sinh ra player va ball o moi man choi
public class LevelManager : Singleton<LevelManager>
{
    Player m_player;

    GameObject m_ball;

    [SerializeField] private GameObject enemyPrefab;

    public int countEnemySpawn;
    private int countEnemyDefault = 0;
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
        GUIManager.Ins.UpdateCoins();
        StartCoroutine(SpawnEnemy(0.5f));
    }

    private void OnEnable()
    {
        EnemyMove.OnEnemyDead += StartSpawnEnemy;
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

    private void OnDisable()
    {
        EnemyMove.OnEnemyDead -= StartSpawnEnemy;
    }

    private void StartSpawnEnemy()
    {
        countEnemyDefault--;
        StartCoroutine(SpawnEnemy(0.5f));
    }

    IEnumerator SpawnEnemy(float waitTime)
    {
       
        while(countEnemyDefault <= countEnemySpawn)
        {
            Instantiate(enemyPrefab, new Vector3(8.0f, 0f, 25.0f), Quaternion.identity);

            //bug
            Instantiate(enemyPrefab, new Vector3(8.0f, 0f, 25.0f), Quaternion.identity);
            countEnemyDefault++;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
