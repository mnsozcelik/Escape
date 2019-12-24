using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{
    public void mainmenu()
    {
        SceneManager.LoadScene("menu");
    }
    public void shareFacebook()
    {
        Application.OpenURL("https://www.facebook.com/mnsozcelik");
        Debug.Log("facebook");
    }

    public void shareTwitter()
    {
        Application.OpenURL("https://www.twitter.com/hawkyshun");
        Debug.Log("twitter");
    }

    public void shareInstagram()
    {
        Application.OpenURL("https://www.instagram.com/emreeskili3");
        Debug.Log("instagram");
    }
}
