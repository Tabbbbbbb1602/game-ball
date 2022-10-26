using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIManager : Singleton<UIManager>
{
    public UnityEvent OnVictory = new UnityEvent();
    public UnityEvent OnLose = new UnityEvent();
    public UnityEvent OnPlayerVictory = new UnityEvent();
    public UnityEvent OnPlayerLose = new UnityEvent();
    public UnityEvent OnEnemyLose = new UnityEvent();
    public UnityEvent OnChangeTextCoins = new UnityEvent();

    // Start is called before the first frame update

    //phat su kien win game
    public void winGame()
    {
        OnVictory?.Invoke();
    }

    //phat su kien lose game
    public void loseGame()
    {
        OnLose?.Invoke();
    }

    public void playerLose()
    {
        OnPlayerLose?.Invoke();
    }

    public void enemyLose()
    {
        OnEnemyLose?.Invoke();
    }

    public void changeTextCoins()
    {
        OnChangeTextCoins?.Invoke();
    }

}
