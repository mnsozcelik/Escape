using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
    public string activescene;
    void Start()
    {
        activescene = SceneManager.GetActiveScene().name.ToString();
        if (activescene == "1")
        {
            idealTime = 75.0f;
        }else if (activescene == "2")
        {
            idealTime = 45.0f;
        }else if (activescene == "3")
        {
            idealTime = 85.0f;
        }else if (activescene == "4")
        {
            idealTime = 50.0f;
        }
        startTime = Time.time;
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
            timerText.text = "0:0";
            isOver = true;
        }
    }
}
