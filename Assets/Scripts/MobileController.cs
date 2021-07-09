using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileController : MonoBehaviour
{
    public FixedJoystick MoveJoyStick;
    public FixedTouchField TouchField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var fps = GetComponent<PlayerMovement>();

        fps.RunAxis = MoveJoyStick.Direction;

        //mouseLook.LookAxis = TouchField.TouchDist;

        MouseLook.LookAxis = TouchField.TouchDist;
    }
}
