using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Dialog : MonoBehaviour
{
    public Text titleText;
    public Text contentText;
    private int currentSceneIndex;

    public void backMenuMain()
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


    public virtual void UpdateDialog(string title, string content)
    {
        if (titleText)
            titleText.text = title;

        if (contentText)
            contentText.text = content;
    }

    public virtual void UpdateDialog()
    {

    }

    public virtual void Close()
    {
        gameObject.SetActive(false);
    }
}
