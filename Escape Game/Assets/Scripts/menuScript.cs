using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuScript : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("levelsScene");
        PlayerPrefs.DeleteAll();
    }
    public void InformationButton()
    {
        SceneManager.LoadScene("informationScene");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void L1()
    {
        SceneManager.LoadScene("1");
    }
    public void L2()
    {
        SceneManager.LoadScene("2");
    }
    public void L3()
    {
        SceneManager.LoadScene("3");
    }
    public void L4()
    {
        SceneManager.LoadScene("4");
    }
    public void L5()
    {
        SceneManager.LoadScene("5");
    }
    public void L6()
    {
        SceneManager.LoadScene("6");
    }
    public void L7()
    {
        SceneManager.LoadScene("7");
    }
    public void L8()
    {
        SceneManager.LoadScene("8");
    }
    public void L9()
    {
        SceneManager.LoadScene("9");
    }
    public void L10()
    {
        SceneManager.LoadScene("10");
    }
    public void L11()
    {
        SceneManager.LoadScene("11");
    }
    public void L12()
    {
        SceneManager.LoadScene("12");
    }
    public void L13()
    {
        SceneManager.LoadScene("13");
    }
    public void L14()
    {
        SceneManager.LoadScene("14");
    }
    public void L15()
    {
        SceneManager.LoadScene("15");
    }
    public void L16()
    {
        SceneManager.LoadScene("16");
    }
    public void L17()
    {
        SceneManager.LoadScene("17");
    }
    public void L18()
    {
        SceneManager.LoadScene("18");
    }
    public void L19()
    {
        SceneManager.LoadScene("19");
    }
    public void L20()
    {
        SceneManager.LoadScene("20");
    }
}
