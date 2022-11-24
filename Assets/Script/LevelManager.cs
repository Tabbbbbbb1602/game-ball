using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;


//thuc hien viec sinh ra player va ball o moi man choi
public class LevelManager : Singleton<LevelManager>
{

    public override void Awake()
    {
        MakeSingleton(false);
        Time.timeScale = 1;
    }

    
    public override void Start()
    {
        base.Start();
        if (!PlayerPrefs.HasKey(PrefConst.COIN_KEY))
            Pref.Coins = 1000;
        GUIManager.Ins.UpdateCoins();
    }
}
