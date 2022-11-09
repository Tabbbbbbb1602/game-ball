using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject orgin;
    public GameObject parent;

    void Update ()
    {
        transform.position = orgin.transform.position;
    }

    IEnumerator EnemySpawner(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        orgin.SetActive(true);
        GameObject InstanceEnemies = Instantiate(parent, parent.transform.position, parent.transform.rotation);
        Destroy(parent);
    }
    public void Dead()
    {
        orgin.SetActive(false);
        StartCoroutine(EnemySpawner(2.0f));
    }
}
