using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnToOff : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject On;
    public GameObject Off;

    private void Start()
    {
        LoadMusicStart();
    }

    private void Update()
    {
        LoadMusicStart();
    }

    public void OnMusic()
    {
        On.SetActive(false);
        Off.SetActive(true);
    }

    public void OffMusic()
    {
        On.SetActive(true);
        Off.SetActive(false);
    }

    public void LoadMusicStart()
    {
        if (PlayerPrefs.HasKey(PrefConst.MUTEMUSIC))
        {
            Debug.Log(PlayerPrefs.GetFloat(PrefConst.MUTEMUSIC));
            if (PlayerPrefs.GetFloat(PrefConst.MUTEMUSIC) == 1)
            {
                On.SetActive(false);
                Off.SetActive(true);
            }
            else if (PlayerPrefs.GetFloat(PrefConst.MUTEMUSIC) == 0)
            {
                On.SetActive(true);
                Off.SetActive(false);
            }
        }
    }
}
