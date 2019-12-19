using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishScript : MonoBehaviour
{

    public Animator fAnim;
    public GameObject finish;
    void Start()
    {
        finish = GameObject.Find("finish");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Character")
        {
            
            PlayerPrefs.SetInt("level", Application.loadedLevel);
            PlayerPrefs.GetInt("level");
            fAnim.Play("fIn");
            Time.timeScale = 0.0f;

        }
    }
}
