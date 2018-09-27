using UnityEngine;
using System.Collections;
using System.IO;
 
public class NativeShareScript : MonoBehaviour {
    public GameObject CanvasShareObj;
 
    private bool isProcessing = false;
    private bool isFocus = false;
 
    public void ShareBtnPress()
    {
        if (!isProcessing)
        {
            CanvasShareObj.SetActive(true);
            StartCoroutine(ShareScreenshot());
        }
    }
 
    IEnumerator ShareScreenshot()
    {
        isProcessing = true;
 
        yield return new WaitForEndOfFrame();
 
        Application.CaptureScreenshot("screenshot.png", 2);
        string destination = Path.Combine(Application.persistentDataPath, "screenshot.png");
 
        yield return new WaitForSecondsRealtime(0.3f);
 
        if (!Application.isEditor)
        {
            AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
            AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
            intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
            AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
            AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("parse", "file://" + destination);
            intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_STREAM"),
                uriObject);
            intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"),
                "Hey.. Look at my score.. Can you beat it?.. Do you have character like it?.. Come on let play this game.. Get it on playstore https://play.google.com/store/apps/details?id=com.WaraiStudio.JumpRope");
            intentObject.Call<AndroidJavaObject>("setType", "image/jpeg");
            AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");
            AndroidJavaObject chooser = intentClass.CallStatic<AndroidJavaObject>("createChooser",
                intentObject, "Share your Character and Tier");
            currentActivity.Call("startActivity", chooser);
 
            yield return new WaitForSecondsRealtime(1);
        }
 
        yield return new WaitUntil(() => isFocus);
        CanvasShareObj.SetActive(true);
        isProcessing = false;
    }
 
    private void OnApplicationFocus(bool focus)
    {
        isFocus = focus;
    }
}