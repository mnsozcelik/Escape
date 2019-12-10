using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishScript : MonoBehaviour
{

    public Animator fAnim;
    public GameObject finish;
    // Start is called before the first frame update
    void Start()
    {
        finish = GameObject.Find("finish");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Character")
        {
            fAnim.Play("fIn");
            Time.timeScale = 0.0f;
        }
    }
}
