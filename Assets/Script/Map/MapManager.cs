using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public Transform itemGift;
    private int count = 0;
    private int priceItem = 1000;
    public string mapid;

    private void Start()
    {
        //PlayerPrefs.SetInt("Map01", count);
        //PlayerPrefs.SetInt("map12", 1);
        //get map 01 
        count = PlayerPrefs.GetInt("Map01");
        //PlayerPrefs.GetInt("Map");
        //set true object actived
        for (var i = 0; i < count; i++)
        {
           itemGift.GetChild(i).gameObject.SetActive(true);
        }

    }

    public void upgradeMap()
    {
        //get coins
        int coins = Pref.Coins;

        //
        int child = itemGift.childCount;
        count = count >= child ? child : count + 1;
        coins -= priceItem;
        PlayerPrefs.SetInt("coins", coins);
        GUIManager.Ins.UpdateCoins();
        PlayerPrefs.SetInt("Items", count);
        PlayerPrefs.SetInt("Map01", count);
        for (var i = 0; i < count; i++)
        {
            if(coins > priceItem)
            {
                itemGift.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                Debug.Log("Khong du tien de mua");
            }
        }
        DontDestroyOnLoad(gameObject);
    }

}

