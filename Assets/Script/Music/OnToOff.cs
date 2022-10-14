using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnToOff : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject On;
    public GameObject Off;

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
    
}
