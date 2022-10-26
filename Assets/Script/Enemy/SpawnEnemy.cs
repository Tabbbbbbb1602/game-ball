using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] enemy;

    public Transform[] spawnPoints;

    public int index = 0;
    public int InitEnemy;

    List<GameObject> EnemiesList = new List<GameObject>();


    private void Start()
    {
        for(int i = 0; i < InitEnemy; i++) {
            EnemySpawner();
        }
    }

    private void OnEnable()
    {
        EnemyMove.OnEnemyDead += EnemySpawner;
    }

    void EnemySpawner()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        GameObject InstanceEnemies = Instantiate(enemy[index], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation) as GameObject;
        EnemiesList.Add(InstanceEnemies);
}

    private void OnDisable()
    {
        EnemyMove.OnEnemyDead -= EnemySpawner;
    }
}
