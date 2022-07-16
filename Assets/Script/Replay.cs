using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class Replay : MonoBehaviour
{
    public Canvas myCanvas;
    
    public void ReplayGame()
    {
        //SceneManager.LoadScene("MainGame");
        RequestInterstitial();
        
        //When you want call Interstitial show
     StartCoroutine(showInterstitial());
 
    IEnumerator showInterstitial()
     {
         while(!this.interstitial.IsLoaded())
         {
             yield return new WaitForSeconds(0.2f);
         }
         this.interstitial.Show();
         myCanvas.sortingOrder = -1;
     } 
       
        

    }
    private InterstitialAd interstitial;

    private void RequestInterstitial()
    {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-7102417026180254/5753156416";
         #elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/4411468910";
         #else
        string adUnitId = "unexpected_platform";
         #endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        // Called when the ad is closed.
        this.interstitial.OnAdClosed += HandleOnAdClosed;   
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
}

    public void HandleOnAdClosed(object sender, System.EventArgs args)
    {
        SceneManager.LoadScene("MainGame");
    }

}
