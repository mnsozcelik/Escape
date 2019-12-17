using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverTrigger : MonoBehaviour
{
    public Text gameOverText;
    void Start()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Character")
        {
            gameOverText.text = ".";
            Debug.Log("Yandın!!");
        }
    }
}
