using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoadLevels(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadLevels(int level)
    {
        SceneManager.LoadScene("Scenes/Game");
        SceneManager.LoadScene($"Level{level}", LoadSceneMode.Additive);
    }
}
