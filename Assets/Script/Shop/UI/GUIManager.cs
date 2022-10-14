using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GUIManager : Singleton<GUIManager>
{
    public Text coinCountingText;
    public GameObject backLevel;

    public override void Awake()
    {
        MakeSingleton(false);
    }

    private void Start()
    {
        coinCountingText.text = "" + Pref.Coins;
    }

    public void UpdateCoins()
    {
        if (coinCountingText)
            coinCountingText.text = "" + Pref.Coins;
    }

    public void backGame()
    {
        SceneManager.LoadScene("Scenes/Game");
    }

}
