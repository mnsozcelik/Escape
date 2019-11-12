using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openGate : MonoBehaviour
{

    private Animation anim;
    public GameObject gate;
    public Transform gatetrans;
    // Start is called before the first frame update
    void Start()
    {
        gate = GameObject.Find("gate");
        gatetrans = gate.transform;
        anim = gate.GetComponent<Animation>();
        anim["gateOpen"].layer = 123;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        while(other.gameObject.name== "Character")
        {
            //Destroy(gate);
            gatetrans.position = gatetrans.position + new Vector3(-2f,0,0);
            //anim.Play("gateOpen");
            Debug.Log("Plane üstünde..");
        }
    }
}
