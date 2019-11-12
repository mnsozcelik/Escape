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
        if(other.gameObject.name== "Character")
        {
            float x = 0f;
            for(int i=0;i<1000;i++)
            {
                new WaitForSeconds(0.002f);
                x += 0.002f;
                gatetrans.position = gatetrans.position + new Vector3(x, 0, 0);
            }
            //Destroy(gate);
            //anim.Play("gateOpen");
            Debug.Log("Plane üstünde..");
        }
    }
}
