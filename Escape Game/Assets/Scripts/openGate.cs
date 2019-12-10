using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openGate : MonoBehaviour
{

    public Animation anim;
    public GameObject gate;
    // Start is called before the first frame update
    void Start()
    {
        gate = GameObject.Find("gate");
        anim = gate.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
