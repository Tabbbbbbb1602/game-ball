using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : Singleton<ShopManager>
{
    public ShopITem[] items;

    public BallItem[] itemsBall;

    private PlayerData playerData;


    private void Awake()
    {
        //playerData = PlayerData.Load();
        //Debug.Log(playerData.a);
        //playerData.a = 2;
        //playerData.save();
        //playerData.b = 3;


        ////mua bong
        //playerData.balls.Add("ball1");
        //playerData.save();


        ////chon bong
        //playerData.indexBall = 1;
        //playerData.save();

        //GameObject ball = Resources.Load("/balls/" + playerData.balls[playerData.indexBall]) as GameObject ;
        //Instantiate(ball);


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
                    Pref.SetBool(PrefConst.BALL_PEFIX + i, true);//player_0
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


public class PlayerData
{
    public int a;
    public int b;
    public int indexBall;

    public List<int> balls;

    private static string key_data = "playerdata";

    public PlayerData()
    {
        a = 0;
        b = 0;
        indexBall = 0;
        balls = new List<int>();
    }

    public void save()
    {
        string json = JsonUtility.ToJson(this);
        PlayerPrefs.SetString(key_data,json);
    }

    public static  PlayerData Load()
    {
        string json = PlayerPrefs.GetString(key_data);
        if(string.IsNullOrEmpty(json))
        {
            return new PlayerData();
        }

        return JsonUtility.FromJson<PlayerData>(json);
    }

}
