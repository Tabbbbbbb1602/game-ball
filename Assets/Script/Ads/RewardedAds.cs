using System;
using System.Threading.Tasks;
using Unity.Services.Core;
using Unity.Services.Mediation;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class RewardedAds : MonoBehaviour
{
    public Transform itemGift;
    private int count = 0;
    public Text error;

    /*public Transform obsEnemy;
    public Text coinCountingText;*/


    IRewardedAd ad;
    string adUnitId = "Rewarded_Android";
    string gameId = "5031735";

    public static event Action doubleReward;
    public static event Action showAdsCompleted;
    public static event Action showAdsFailed;

    public GameObject btnx2Reward;
    public GameObject btnContinue;
    private void Awake()
    {
        _ = InitServices();
    }

    public async Task InitServices()
    {
        try
        {
            InitializationOptions initializationOptions = new InitializationOptions();
            initializationOptions.SetGameId(gameId);
            await UnityServices.InitializeAsync(initializationOptions);

            InitializationComplete();
        }
        catch (Exception e)
        {
            InitializationFailed(e);
        }
    }

    public void SetupAd()
    {
        //Create
        ad = MediationService.Instance.CreateRewardedAd(adUnitId);

        //Subscribe to events
        ad.OnClosed += AdClosed;
        ad.OnClicked += AdClicked;
        ad.OnLoaded += AdLoaded;
        ad.OnFailedLoad += AdFailedLoad;
        ad.OnUserRewarded += UserRewarded;

        // Impression Event
        MediationService.Instance.ImpressionEventPublisher.OnImpression += ImpressionEvent;
        /*StartCoroutine(btnDoubleDelay());
        StartCoroutine(btnContinueDelay());*/
    }

    public void Dispose() => ad?.Dispose();


    public async void ShowAd()
    {
        if (ad.AdState == AdState.Loaded)
        {
            try
            {
                RewardedAdShowOptions showOptions = new RewardedAdShowOptions();
                showOptions.AutoReload = true;
                await ad.ShowAsync(showOptions);
                AdShown();
            }
            catch (ShowFailedException e)
            {
                AdFailedShow(e);
            }
        }
    }

    void InitializationComplete()
    {
        SetupAd();
        _ = LoadAd();
        /*StartCoroutine(btnDoubleDelay());
        StartCoroutine(btnContinueDelay());*/
    }

    async Task LoadAd()
    {
        try
        {
            await ad.LoadAsync();
            StartCoroutine(btnDoubleDelay());
            StartCoroutine(btnContinueDelay());
            showAdsCompleted?.Invoke();
        }
        catch (LoadFailedException e)
        {
            // We will handle the failure in the OnFailedLoad callback
            //error.text = e.Message;
        }
    }

    void InitializationFailed(Exception e)
    {
        Debug.Log("Initialization Failed: " + e.Message);
        //error.text = "Initialization Failed:" +  e.Message;
        StartCoroutine(btnContinueDelay());
        //showAdsFailed?.Invoke();
    }

    void AdLoaded(object sender, EventArgs e)
    {
        //Debug.Log("Ad loaded");
    }

    void AdFailedLoad(object sender, LoadErrorEventArgs e)
    {
        Debug.Log("Failed to load ad");
        //error.text = "AdFailedLoad" + e.Message;
        StartCoroutine(btnContinueDelay());
        //showAdsFailed?.Invoke();
    }

    void AdShown()
    {
        Debug.Log("Ad shown!");
    }

    void AdClosed(object sender, EventArgs e)
    {
        //doubleReward();
        doubleReward?.Invoke();
    }

    void AdClicked(object sender, EventArgs e)
    {
        Debug.Log("Ad has been clicked");
        // Execute logic after an ad has been clicked.
        Debug.Log("Da click quang cao");
    }

    void AdFailedShow(ShowFailedException e)
    {
        Debug.Log(e.Message);
    }

    void ImpressionEvent(object sender, ImpressionEventArgs args)
    {
        var impressionData = args.ImpressionData != null ? JsonUtility.ToJson(args.ImpressionData, true) : "null";
        Debug.Log("Impression event from ad unit id " + args.AdUnitId + " " + impressionData);
    }

    void UserRewarded(object sender, RewardEventArgs e)
    {
        Debug.Log($"Received reward: type:{e.Type}; amount:{e.Amount}");
    }


    void upgradeMap()
    {
        int child = itemGift.childCount;
        count = count >= child ? child : count + 1;
        PlayerPrefs.SetInt("Items", count);

        for (var i = 0; i < count; i++)
        {
            itemGift.GetChild(i).gameObject.SetActive(true);
        }

        PlayerPrefs.SetInt("Map01", count);
    }

    IEnumerator btnDoubleDelay()
    {
        yield return new WaitForSeconds(0.5f);
        btnx2Reward.gameObject.SetActive(true);
    }

    IEnumerator btnContinueDelay()
    {
        yield return new WaitForSeconds(10.0f);
        btnContinue.gameObject.SetActive(true);
    }

    
}
