using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuAnim : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (Time.deltaTime * speed, Time.deltaTime * speed, Time.deltaTime * speed);
    }
    
}
