using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class levelController : MonoBehaviour
{
    public Button[] buttons;
    // Start is called before the first frame update
    void Start()
    {
        levelLock();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void levelLock()
    {
        if (PlayerPrefs.GetInt("level") == 0)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (PlayerPrefs.GetInt("level") + 1 >= int.Parse(buttons[i].name))
                {
                    buttons[i].interactable = true;
                }
                else
                {
                    buttons[i].interactable = false;
                }
            } 
        }
        else
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (PlayerPrefs.GetInt("level") >= int.Parse(buttons[i].name))
                {
                    buttons[i].interactable = true;
                }
                else
                {
                    buttons[i].interactable = false;
                }

            }

        }

    }
}
