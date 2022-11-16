using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    public Transform itemGift;
    private int count = 0;
    private int priceItem = 1000;
    public string mapid;

    private int currentSceneIndex;

    private void Start()
    {
        count = PlayerPrefs.GetInt("Map01");
        for (var i = 0; i < count; i++)
        {
           itemGift.GetChild(i).gameObject.SetActive(true);
        }

    }


    //upgradeMap
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

    //back to game scene

    public void backButton()
    {
        currentSceneIndex = PlayerPrefs.GetInt("LevelSaved");
        if (PlayerPrefs.HasKey("LevelSaved"))
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            SceneManager.LoadScene("Scenes/Level_1");
        }
    }

}

