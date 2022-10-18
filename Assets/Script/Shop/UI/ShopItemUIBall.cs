using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItemUIBall : MonoBehaviour
{
    public Text priceText;
    public Image hub;
    public Button btn;


    public void UpdateUIBall(BallItem item, int ballItemId)
    {
        if (item == null) return;

        if (hub)
        {
            hub.sprite = item.hubBall;
            //Debug.Log(item.hubBall);
        }

        bool isUnlocked = Pref.GetBool(PrefConst.BALL_PEFIX + ballItemId);//ball_1


        if (isUnlocked)
        {
            if(ballItemId == Pref.CurBallId)
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
                priceText.text = item.priceBall.ToString();
        }
    }
}
