using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : Singleton<ShopManager>
{
    public ShopITem[] items;

    public BallItem[] itemsBall;

    //private PlayerData playerData;


    private void Awake()
    {
       
    }


    private void Start()
    {
        if (items == null || items.Length <= 0) return;

        for (int i = 0; i < items.Length; i++)
        {
            var item = items[i];
            if (item != null)
            {
                if (i == 0)
                {
                    Pref.SetBool(PrefConst.PLAYER_PEFIX + i, true);//player_0
                }
                else
                {
                    //player_1, player_2 .....
                    if (!PlayerPrefs.HasKey(PrefConst.PLAYER_PEFIX + i))
                    {
                        Pref.SetBool(PrefConst.PLAYER_PEFIX + i, false);
                    }
                }
            }
        }



        if (itemsBall == null || itemsBall.Length <= 0) return;

        for (int i = 0; i < itemsBall.Length; i++)
        {
            var item =  itemsBall[i];
            if (item != null)
            {
                if (i == 0)
                {
                    //Pref.SetBool(PrefConst.BALL_PEFIX + i, true);
                    Pref.SetBool(PrefConst.BALL_PEFIX + i, true);//map_0
                }
                else
                {
                    //player_1, player_2 .....
                    if (!PlayerPrefs.HasKey(PrefConst.BALL_PEFIX + i))
                    {
                        Pref.SetBool(PrefConst.BALL_PEFIX + i, false);
                    }
                }
            }
        }
    }
}

[System.Serializable]
public class ShopITem
{
    public int price;
    public Sprite hub;
    public Player playerPb;
}


[System.Serializable]

public class BallItem
{
    public int priceBall;
    public Sprite hubBall;
    public GameObject BallPb;
}
