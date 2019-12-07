using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    public float idealTime;
    public GameObject Timer;
    public Image TimerImage;
    public bool isOver=false;
    public Color orange;
    public float percentIdealTiming;
    void Start()
    {
        startTime = Time.time;
        idealTime = 4.0f;
        TimerImage = Timer.GetComponent<Image>();
        TimerImage.color = UnityEngine.Color.green;
        orange=new Color(1f, 0.6f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

        float t = idealTime + (startTime - Time.time);
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");
        timerText.text = minutes + ":" + seconds;
        percentIdealTiming = (Time.time - startTime) / idealTime;
        //Debug.Log(percentIdealTiming);
        
        if (percentIdealTiming > 0.25)
        {
            TimerImage.color = UnityEngine.Color.yellow;
        }
        if (percentIdealTiming > 0.50)
        {
            TimerImage.color = orange;
        }
        if (percentIdealTiming > 0.75)
        {
            TimerImage.color = UnityEngine.Color.red;
        }
        if(timerText.text=="0:0")
        {
            isOver = true;
            Time.timeScale = 0.0f;
        }
    }
}
