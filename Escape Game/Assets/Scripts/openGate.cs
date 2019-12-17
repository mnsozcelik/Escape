using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openGate : MonoBehaviour
{
    public Animation anim;
    public GameObject gate;
    void Start()
    {
        gate = GameObject.Find("gate");
        anim = gate.GetComponent<Animation>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name== "Character")
        { 
            anim.Play("openGate");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Character")
        {
            anim.Play("closeGate");
        }   
    }
}
