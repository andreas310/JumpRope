using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdsManager : MonoBehaviour {

	public string mobileAppId = "ca-app-pub-3940256099942544~3347511713",unitBannerId="ca-app-pub-3940256099942544/6300978111";
    private BannerView banner;
    // Use this for initialization
    void Start () {
        MobileAds.Initialize (mobileAppId);
        banner = new BannerView (unitBannerId, AdSize.Banner, AdPosition.Top);
        AdRequest req = new AdRequest.Builder ().Build ();
        banner.LoadAd (req);
    }
}

