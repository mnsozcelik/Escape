using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript2 : MonoBehaviour 
{
    public GameObject pauseMenu;
    public GameObject pauseButton;
    public GameObject playButton;
    public GameObject handle;
    public GameObject fixedJoystick;
    public GameObject panel;
    bool isplay = false;

    void Start()
    {
        pauseButton.SetActive(true);
        playButton.SetActive(false);
        pauseMenu.SetActive(false);
        
    }

    void Update()
    {
        
    }

    public void gamepause()
    {
        isplay = false;
        if (isplay == false)
        {
            playButton.SetActive(true);
            pauseMenu.SetActive(true);
            pauseButton.SetActive(false);
            Time.timeScale = 0.0f;
            handle.SetActive(false);
            panel.SetActive(false);
            fixedJoystick.SetActive(false);
        }
    }
    public void gameplay()
    {
        isplay = true;
        if (isplay == true)
        {
            playButton.SetActive(false);
            pauseMenu.SetActive(false);
            pauseButton.SetActive(true);
            Time.timeScale = 1.0f;
            handle.SetActive(true);
            panel.SetActive(true);
            fixedJoystick.SetActive(true);
        }
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
