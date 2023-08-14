using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdManager : MonoBehaviour
{
    private InterstitialAd interstitial;
    bool reklamgosterildi = false;
   public static int reklama=1;
    public GameObject bittibtn;
    void Start()
    {
        MobileAds.Initialize(InitializationStatus => { });
        PlayerPrefs.GetInt("reklam");
        this.RequestInterstitial();
    }


    void RequestInterstitial() 
    {
#if UNITY_ANDROID
        string reklamID = "ca-app-pub-2634393320206143/2614548958";
#elif UNITY_IPHONE
     string reklamID="ca-app-pub-2634393320206143/1885589514";
 
#else
  string reklamID="unexpected_platform";
#endif
        this.interstitial = new InterstitialAd(reklamID);
        AdRequest request =new AdRequest.Builder().Build();
        this.interstitial.LoadAd(request);






    }
    void Update()
    {
        
            PlayerPrefs.SetInt("reklam", reklama);
            if (PlayerPrefs.GetInt("reklam") % 3 == 0)
            {

                if (reklamgosterildi == false)
                {
                    if (this.interstitial.IsLoaded())
                    {
                        this.interstitial.Show();
                        reklamgosterildi = true;

                       
                        
                    }
                }
            }
            
        
    }
}
