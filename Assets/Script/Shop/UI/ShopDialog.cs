using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ShopDialog : Dialog
{
    public Transform gridRoot;
    public ShopItemUI itemUIPrefab;

    public Transform GridBall;

    public ShopItemUIBall ItemBallPrefab;

    public static event Action showPopupNotEnoughCoins;

    private void Start()
    {
        UpdateUI();
        UpdateUIBall();
    }   

    private void UpdateUI()
    {
        var items = ShopManager.Ins.items;

        if (items == null || items.Length <= 0 || !gridRoot || !itemUIPrefab) return;

        //xoa cac phan tu con truoc khi ve lai shop
        ClearChilds(gridRoot);

        for (int i = 0; i < items.Length; i++)
        {
            int index = i;
            var item = items[i];

            if (item != null)
            {
                var itemUIClone = Instantiate(itemUIPrefab, Vector3.zero, Quaternion.identity);

                itemUIClone.transform.SetParent(gridRoot);

                itemUIClone.transform.localPosition = Vector3.zero;

                itemUIClone.transform.localScale = Vector3.one;

                itemUIClone.UpdateUI(item, index);

                if (itemUIClone.btn)
                {
                    itemUIClone.btn.onClick.RemoveAllListeners();
                    itemUIClone.btn.onClick.AddListener(() => PlayerItemEvent(item, index));
                }
            }
        }
    }

    private void UpdateUIBall()
    {
        var itemsBall = ShopManager.Ins.itemsBall;
        if (itemsBall == null || itemsBall.Length <= 0 || !GridBall || !ItemBallPrefab) return;

        //xoa ca phan tu khi quay ve shop
        ClearChilds(GridBall);

        for (int i = 0; i < itemsBall.Length; i++)
        {
            int indexBall = i;
            var itemBall = itemsBall[i];

            if (itemsBall != null)
            {
                var itemBallClone = Instantiate(ItemBallPrefab, Vector3.zero, Quaternion.identity);
                itemBallClone.transform.SetParent(GridBall);

                itemBallClone.transform.localPosition = Vector3.zero;
                itemBallClone.transform.localScale = Vector3.one;

                itemBallClone.UpdateUIBall(itemBall, indexBall);

                if (itemBallClone.btn)
                {
                    itemBallClone.btn.onClick.RemoveAllListeners();
                    itemBallClone.btn.onClick.AddListener(() => BallItemEvent(itemBall, indexBall));
                }
            }
        }
    }

    void PlayerItemEvent(ShopITem item, int shopItemId)
    {
        if (item == null) return;

        bool isUnlocked = Pref.GetBool(PrefConst.PLAYER_PEFIX + shopItemId);


        if (isUnlocked)
        {
            if (shopItemId == Pref.CurPlayerId) return;

            Pref.CurPlayerId = shopItemId;

            GameManager.Ins.ActivePlayer();

            UpdateUI();
        }
        else
        {
            if (Pref.Coins >= item.price)
            {
                Pref.Coins -= item.price;

                Pref.SetBool(PrefConst.PLAYER_PEFIX + shopItemId, true);

                Pref.CurPlayerId = shopItemId;

                GUIManager.Ins.UpdateCoins();

                GameManager.Ins.ActivePlayer();
                UpdateUI();
            }
            else
            {
                showPopupNotEnoughCoins?.Invoke();
            }
        }
    }

    
    void BallItemEvent(BallItem item, int ballItemId)
    {
        if (item == null) return;
        bool isUnlocked = Pref.GetBool(PrefConst.BALL_PEFIX + ballItemId);


        if (isUnlocked)
        {
            if (ballItemId == Pref.CurBallId) return;

            Pref.CurBallId = ballItemId;


            //Active Ball
            GameManager.Ins.ActiveBall();
            UpdateUIBall();
        }
        else
        {
            if(Pref.Coins >= item.priceBall)
            {
                Pref.Coins -= item.priceBall;
                Pref.SetBool(PrefConst.BALL_PEFIX + ballItemId, true);
                Pref.CurBallId = ballItemId;

                GUIManager.Ins.UpdateCoins();
                GameManager.Ins.ActiveBall();
                UpdateUIBall();
            }
            else
            {
                showPopupNotEnoughCoins?.Invoke();
            }
        }
    }

    public void ClearChilds(Transform grid)
    {
        if (!grid || grid.childCount <= 0) return;

        for (int i = 0; i < grid.childCount; i++)
        {
            var child = grid.GetChild(i);

            if (child)
            {
                Destroy(child.gameObject);
            }
        }
    }
}
