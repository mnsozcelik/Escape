using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishGate : MonoBehaviour
{
    public Animation anim;
    public GameObject gate;
    // Start is called before the first frame update
    void Start()
    {
        gate = GameObject.Find("finishGate");
        anim = gate.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Character")
        {
            //gatetrans.position = gatetrans.position + new Vector3(x, 0, 0);
            //Destroy(gate);
            anim.Play("openGate");
        }
    }
}
