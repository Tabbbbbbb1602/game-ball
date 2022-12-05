using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject orgin;
    public GameObject parent;
    public GameObject ps;
    //public GameObject coliider;
    private GameObject InstanceEnemies;
    private bool isDead;
    //public AudioClip audio;
    private AudioManager audioManager;

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
        isDead = false;
    }
    public void Dead()
    {
        if (!isDead)
        {
            isDead = true;
            var effect = Instantiate(ps, transform.position, transform.rotation);
            Destroy(effect, 1.0f);
            FindObjectOfType<AudioManager>().Play("collider");
            orgin.SetActive(false);
            StartCoroutine(EnemySpawner(4.0f));
        }
    }
}
