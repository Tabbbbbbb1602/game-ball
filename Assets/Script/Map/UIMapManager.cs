using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMapManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMap01()
    {
        SceneManager.LoadScene("Scenes/Map");
    }

    public void LoadMap02()
    {
        SceneManager.LoadScene("Scenes/Map 1");
    }
}
