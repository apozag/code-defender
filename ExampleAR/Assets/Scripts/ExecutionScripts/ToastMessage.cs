//Guendeli Omar, ToastMessage.cs, (2016), GitHub repository https://gist.github.com/Guendeli/b3248108e82cf32444eea7061bd4554d

using UnityEngine;

public class ToastMessage : MonoBehaviour
{
    static string toastString;
    static AndroidJavaObject currentActivity;
    static AndroidJavaClass UnityPlayer;
    static AndroidJavaObject context;

    static void Start()
    {

    }


    public static void showToastOnUiThread(string str)
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            UnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            currentActivity = UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            context = currentActivity.Call<AndroidJavaObject>("getApplicationContext");
        }
        toastString = str;
        currentActivity.Call("runOnUiThread", new AndroidJavaRunnable(showToast));
    }

    static void showToast()
    {
        Debug.Log(": Running on UI thread");

        AndroidJavaClass Toast = new AndroidJavaClass("android.widget.Toast");
        AndroidJavaObject javaString = new AndroidJavaObject("java.lang.String", toastString);
        AndroidJavaObject toast = Toast.CallStatic<AndroidJavaObject>("makeText", context, javaString, Toast.GetStatic<int>("LENGTH_LONG"));
        toast.Call("show");
    }
}