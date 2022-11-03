using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private int currentSceneIndex;
    public bool isLoadLevelCurrent;

    private void Start()
    {
        if (isLoadLevelCurrent == true)
        {
            LoadGameContinue();
        }
    }


    public void LoadGameContinue()
    {
        currentSceneIndex = PlayerPrefs.GetInt("LevelSaved");

        if (PlayerPrefs.HasKey("LevelSaved"))
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            SceneManager.LoadScene("Scenes/New Scene");
        }
    }
}
