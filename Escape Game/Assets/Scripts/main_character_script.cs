using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class main_character_script : MonoBehaviour
{
    public FixedJoystick MoveJoystick;
    public FixedButton JumpButton;
    public FixedTouchField TouchField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var fps = GetComponent<RigidbodyFirstPersonController>();

        fps.RunAxis = MoveJoystick.inputVector;
        fps.JumpAxis = JumpButton.Pressed;
        fps.mouseLook.LookAxis = TouchField.TouchDist;
    }
}
