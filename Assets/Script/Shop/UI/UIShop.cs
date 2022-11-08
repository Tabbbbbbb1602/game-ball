using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShop : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject showPopUpNotification;
    public GameObject closePopUpNotification;

    void Start()
    {
        
    }

    private void OnEnable()
    {
        ShopDialog.showPopupNotEnoughCoins += showPopUpNotifications;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showPopUpNotifications()
    {
        showPopUpNotification.SetActive(true);
    }

    public void closePopUpNotifications()
    {
        showPopUpNotification.SetActive(false);
    }

    private void OnDisable()
    {
        ShopDialog.showPopupNotEnoughCoins -= showPopUpNotifications;
    }
}
