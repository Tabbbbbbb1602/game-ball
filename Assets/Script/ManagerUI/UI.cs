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

    public GameObject btnContinue;
    public GameObject btnDoubleReward;
    public GameObject btnLose;

    private TouchInput inputs;

    private GameObject obsEnemyCount;

    public Text coinCountingText;

    public static event Action<bool> pauseGame;
    public static event Action resumeGame;
    public static event Action countdownTime;

    private int countObsEnemy;
    private int currentSceneIndex;

    private bool isShowSetting;
    private bool isShowGameLoad;
    public void Awake()
    {
        initGame();
    }

    private void Start()
    {
        countObsEnemy = obsEnemyCount.transform.childCount;
    }

    public void initGame()
    {
        mainMenu.SetActive(true);
        game.SetActive(false);
        gameLoad.SetActive(false);
        settings.SetActive(false);
        obsEnemyCount = GameObject.FindGameObjectWithTag("ObsEnemy");
        inputs = new TouchInput();
    }

    private void OnEnable()
    {
        inputs.touch.touchpos.performed += StartThrow;
        UIManager.Ins.OnPlayerVictory.AddListener(victoryGame);
        UIManager.Ins.OnPlayerLose.AddListener(loseGames);
        UIManager.Ins.OnChangeTextCoins.AddListener(changeTextCoins);
        RewardedAds.doubleReward += doubleReward;
        inputs.Enable();
    }

    private void StartThrow(InputAction.CallbackContext obj)
    {
       if(!isShowSetting)
        {
            mainMenu.SetActive(false);
            gameLoad.SetActive(true);
        }

        if(isShowGameLoad == true)
        {
            gameLoad.SetActive(false);
        }
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
        isShowSetting = true;
    }

    public void closeSettings()
    {
        settings.SetActive(false);
        mainMenu.SetActive(true);
        pauseGame?.Invoke(false);
        Time.timeScale = 1;
        isShowSetting = false;
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
        currentSceneIndex = PlayerPrefs.GetInt("LevelSaved");
        if (PlayerPrefs.HasKey("BACKLEVEL"))
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            SceneManager.LoadScene("Scenes/Level_1");
        }
    }

    public void resume()
    {
        game.SetActive(false);
        gameLoad.SetActive(true);
        Time.timeScale = 1;
    }

    public void showMap()
    {
        SceneManager.LoadScene("Scenes/Map_forest");
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
        GameObject character = GameObject.FindGameObjectWithTag("Player");
        character.GetComponent<PlayerMove>().enabled = false;
        isShowGameLoad = true;
    }                                                                                                                                                                                                                                                                                                                                                                                                                                      

    public void loseGames()
    {
        gameLoad.SetActive(false);
        loseGameObj.SetActive(true);
        GameObject character = GameObject.FindGameObjectWithTag("Player");
        character.GetComponent<PlayerMove>().enabled = false;
        isShowGameLoad = true;
    }

    public void changeTextCoins()
    {
        Pref.Coins += 1;
        if (coinCountingText)
            coinCountingText.text = "" + Pref.Coins;
    }

    public void doubleReward()
    {
        Pref.Coins += countObsEnemy;
        countObsEnemy = 0;
        if (coinCountingText)
            coinCountingText.text = "" + Pref.Coins;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void btnContinueGame()
    {
        countObsEnemy = 0;
    }

    private void OnDisable()
    {
        inputs.touch.touchpos.performed -= StartThrow;
        RewardedAds.showAdsFailed -= showAdsFailed;
        UIManager.Ins.OnPlayerVictory.RemoveListener(victoryGame);
        UIManager.Ins.OnPlayerLose.RemoveListener(loseGames);
        UIManager.Ins.OnChangeTextCoins.RemoveListener(changeTextCoins);
        inputs.Disable();
    }
    
    private void showAdsCompleted()
    {
        StartCoroutine(btnDoubleDelay());
        StartCoroutine(btnContinueDelay());
    }

    private void showAdsFailed()
    {
        StartCoroutine(btnContinueDelay());
    }

    public void BacktoGame()
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



    IEnumerator btnDoubleDelay()
    {
        yield return new WaitForSeconds(0.5f);
        btnDoubleReward.gameObject.SetActive(true);
    }

    IEnumerator btnContinueDelay()
    {
        yield return new WaitForSeconds(10.0f);
        btnContinue.gameObject.SetActive(true);
    }

    IEnumerator btnLoseDelay()
    {
        yield return new WaitForSeconds(0.5f);
        btnLose.gameObject.SetActive(true);
    }


}
