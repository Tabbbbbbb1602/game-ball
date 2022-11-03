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
    public UnityEvent OnEnemyVictory = new UnityEvent();
    public UnityEvent OnChangeTextCoins = new UnityEvent();

    // Start is called before the first frame update

    public void playerLose()
    {
        OnPlayerLose?.Invoke();
    }

    public void playerVictory()
    {
        OnPlayerVictory?.Invoke();
    }

    public void enemyLose()
    {
        OnEnemyLose?.Invoke();
    }

    public void enemyVictory()
    {
        OnEnemyVictory?.Invoke();
    }

    public void changeTextCoins()
    {
        OnChangeTextCoins?.Invoke();
    }
}
