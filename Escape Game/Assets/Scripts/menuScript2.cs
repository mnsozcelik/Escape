using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript2 : MonoBehaviour 
{
    public GameObject pauseMenu;
    public GameObject pauseButton;
    public GameObject playButton;
    public GameObject Controller;
    public Animator pAnim;
    
    void Start()
    { 
        pauseButton.SetActive(true);
    }

    public void gamepause()
    {
        Controller.SetActive(false);
        pAnim.Play("pIn");
        playButton.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void gameplay()
    {
        Controller.SetActive(true);
        pAnim.Play("pOut");
        playButton.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void replay()
    {
        Time.timeScale = 1.0f;
        string activescene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activescene);
    }
    public void mainMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("menu");
    }
}
