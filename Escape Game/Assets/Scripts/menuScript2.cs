using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject pauseMenu;
    GameObject pauseButton;
    GameObject playButton;
    void Start()
    {
        pauseButton = GameObject.Find("PauseButton");
        playButton = GameObject.Find("PlayButton");
        pauseMenu = GameObject.Find("PauseMenu");
        pauseButton.SetActive(true);
        playButton.SetActive(false);
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gamepause()
    {
        playButton.SetActive(true);
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
    }
    public void gameplay()
    {
        playButton.SetActive(false);
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
    }
}
