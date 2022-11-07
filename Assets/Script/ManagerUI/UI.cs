using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject gameLoad;
    public GameObject game;
    public GameObject settings;
    public GameObject winGame;
    public GameObject loseGameObj;
    public GameObject map;
    public GameObject textCoins;

    private TouchInput inputs;

    public Text coinCountingText;

    public static event Action<bool> pauseGame;
    public static event Action resumeGame;

    public void Awake()
    {
        mainMenu.SetActive(true);
        game.SetActive(false);
        gameLoad.SetActive(false);
        settings.SetActive(false);
        inputs = new TouchInput();
    }


    private void OnEnable()
    {
        inputs.touch.touchpos.performed += StartThrow;
        UIManager.Ins.OnPlayerVictory.AddListener(victoryGame);
        UIManager.Ins.OnPlayerLose.AddListener(loseGames);
        UIManager.Ins.OnChangeTextCoins.AddListener(changeTextCoins);
        inputs.Enable();
    }

    private void StartThrow(InputAction.CallbackContext obj)
    {
        mainMenu.SetActive(false);
        gameLoad.SetActive(true);
    }

    public void showShop()
    {
        SceneManager.LoadScene("Scenes/ShopMain");
    }

    public void showSetting()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
        pauseGame?.Invoke(true);
        Time.timeScale = 0;
    }

    public void closeSettings()
    {
        settings.SetActive(false);
        mainMenu.SetActive(true);
        pauseGame?.Invoke(false);
        Time.timeScale = 1;
    }

    public void showPauseGame()
    {
        game.SetActive(true);
        mainMenu.SetActive(false);
        gameLoad.SetActive(false);
        Time.timeScale = 0;
    }

    public void showMainMenu()
    {
        //UIManager.Ins.changeTextCoins();

        /*if (PlayerPrefs.HasKey("BACKLEVEL"))
        {
            SceneManager.GetActiveScene().buildIndex;
        }
        else
        {
            SceneManager.LoadScene("Scenes/GameMap");
        }*/
        SceneManager.LoadScene("Scenes/GameMap");
    }

    public void resume()
    {
        game.SetActive(false);
        gameLoad.SetActive(true);
        Time.timeScale = 1;
    }

    public void showMap()
    {
        SceneManager.LoadScene("Scenes/Map");
    }


    public void loseGameUI()
    {

    }

    public void loseGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //thay doi bang lang nghe event
    public void victoryGame()
    {
        winGame.SetActive(true);
        gameLoad.SetActive(false);
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("BACKLEVEL", currentLevel);
    }                                                                                                                                                                                                                                                                                                                                                                                                                                      

    public void loseGames()
    {
        loseGameObj.SetActive(true);
        gameLoad.SetActive(false);
    }

    public void changeTextCoins()
    {
        Pref.Coins += 1;
        if (coinCountingText)
            coinCountingText.text = "" + Pref.Coins;
    }

    private void OnDisable()
    {
        inputs.touch.touchpos.performed -= StartThrow;
        UIManager.Ins.OnPlayerVictory.RemoveListener(victoryGame);
        UIManager.Ins.OnPlayerLose.RemoveListener(loseGames);
        UIManager.Ins.OnChangeTextCoins.RemoveListener(changeTextCoins);
        inputs.Disable();
    }




}
