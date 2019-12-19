using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuScript2 : MonoBehaviour 
{
    public GameObject pauseMenu;
    public GameObject pauseButton;
    public GameObject playButton;
    public GameObject Controller;
    public Text timerText;
    public Animator pAnim;
    public Animator gAnim;
    private bool isOver = false;
    public Text gameOverText;
    
    void Start()
    {
        gameOverText.text = "";
        pauseButton.SetActive(true);
    }
    void Update()
    {
        Debug.Log(timerText.text);
        Debug.Log(gameOverText.text);
        if ((timerText.text == "0:0" || gameOverText.text==".") && isOver==false)
        {
            isOver = true;
            gameOver();
        }
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
    public void levelsScene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("levelsScene");
    }
    public void mainMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("menu");
    }
    public void gameOver()
    {
        Controller.SetActive(false);
        gAnim.Play("gIn");
        playButton.SetActive(false);
        pauseButton.SetActive(false);
        Time.timeScale = 0.0f;
    }
}
