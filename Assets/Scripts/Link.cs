using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour
{

//    public void OpenLinkJSPlugin()
//    {
//#if !UNITY_EDITOR
//		openWindow(Field.text);
//#endif
//    }

    public void OpenMiaamDemo()
    {
        Application.OpenURL("https://miaam-demo.netlify.app/");
        //#if !UNITY_EDITOR
        //		openWindow("https://miaam-demo.netlify.app/");
        //#endif
    }

    public void WatchCaptainPlanet()
    {
        Application.OpenURL("https://youtu.be/i8xFrvewtS0");
//#if !UNITY_EDITOR
//		openWindow("https://youtu.be/i8xFrvewtS0");
//#endif
    }

    public void WatchWoop()
    {
        Application.OpenURL("https://youtu.be/m8Dm1gAaizI");
//#if !UNITY_EDITOR
//		openWindow("https://youtu.be/m8Dm1gAaizI");
//#endif
    }

    public void PlayBounceTo()
    {
        Application.OpenURL("https://feelsoclean.itch.io/ping-pong-ding-dong");
//#if !UNITY_EDITOR
//		openWindow("https://feelsoclean.itch.io/ping-pong-ding-dong");
//#endif
    }

    public void PlayBadre()
    {
        Application.OpenURL("https://feelsoclean.itch.io/badrenaline");
//#if !UNITY_EDITOR
//		openWindow("https://feelsoclean.itch.io/badrenaline");
//#endif
    }

    public void GoResume()
    {
        Application.OpenURL("https://www.dropbox.com/s/aefucxrk87u2gjr/Abdullah%20Al%20Muti.pdf?dl=0");
//#if !UNITY_EDITOR
//		openWindow("https://github.com/DrinkingWater64");
//#endif
    }

    public void GoGit()
    {
        Application.OpenURL("https://github.com/DrinkingWater64");
//#if !UNITY_EDITOR
//		openWindow("https://github.com/DrinkingWater64");
//#endif
    }

    public void GoLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/abdullah-al-muti-26104b1b9/");
//#if !UNITY_EDITOR
//		openWindow("https://www.linkedin.com/in/abdullah-al-muti-26104b1b9/");
//#endif
    }

    public void GoHBTSB()
    {
        Application.OpenURL("https://feelsoclean.itch.io/hard-being-the-smartest-being-alive");
        //#if !UNITY_EDITOR
        //		openWindow("https://feelsoclean.itch.io/hard-being-the-smartest-being-alive");
        //#endif
    }

    public void Test()
    {
        Debug.Log("Tesla");
    }

    public void Test2()
    {
        Debug.Log("Wagon");
    }

    [DllImport("__Internal")]
    private static extern void openWindow(string url);

}