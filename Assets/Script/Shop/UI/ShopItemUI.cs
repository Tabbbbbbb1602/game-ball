using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItemUI : MonoBehaviour
{
    public Text priceText;
    public Image hud;
    public Button btn;

    public void UpdateUI(ShopITem item, int shopItemId)
    {
        if (item == null) return;

        if (hud)
        {
            hud.sprite = item.hub;
        }

        bool isUnlocked = Pref.GetBool(PrefConst.PLAYER_PEFIX + shopItemId);//player_1

        //Debug.Log(Pref.GetBool(PrefConst.PLAYER_PEFIX + shopItemId));
        //Debug.Log(isUnlocked);

        if (isUnlocked)
        {
            if (shopItemId == Pref.CurPlayerId)
            {
                if (priceText)
                    priceText.text = "Active";
            }
            else
            {
                if (priceText)
                    priceText.text = "OWNED";
            }
        }
        else
        {
            if (priceText)
                priceText.text = item.price.ToString();
        }
    }
}
