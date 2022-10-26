using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMapManager : MonoBehaviour
{
    private int currentSceneIndex;
    /*rivate int count = 0;
    public Transform itemGift;*/
    // Start is called before the first frame update
    void Start()
    {
       /* count = PlayerPrefs.GetInt("Map02");
        //layerPrefs.GetInt("Map");
        //set true object actived
        for (var i = 0; i < count; i++)
        {
            itemGift.GetChild(i).gameObject.SetActive(true);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMap01()
    {
        SceneManager.LoadScene("Scenes/Map");
    }

    public void LoadMap02()
    {
        SceneManager.LoadScene("Scenes/Map 1");
    }

    public void backToMain()
    {
        currentSceneIndex = PlayerPrefs.GetInt("LevelSaved");

        if (PlayerPrefs.HasKey("LevelSaved"))
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            SceneManager.LoadScene("Scenes/Game");
        }
    }

    public void backToMainMapOne()
    {
        currentSceneIndex = PlayerPrefs.GetInt("LevelSaved");

        if (PlayerPrefs.HasKey("LevelSaved"))
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            SceneManager.LoadScene("Scenes/Game_Map_2");
        }
    }

}
