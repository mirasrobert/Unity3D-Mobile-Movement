using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;

    // Joystick Variables
    [HideInInspector]
    public static Vector2 LookAxis;

    // Start is called before the first frame update
    void Start()
    {
        // Comment this cursor lockstate to use joystick for mobile devices
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Get the X axis and Y axis of mouse
        /*
         * For Keyboard Controls
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        */

        /*
         * For Mobile users // Joystick
         */

        float mouseX = LookAxis.x * mouseSensitivity * Time.deltaTime;
        float mouseY = LookAxis.y * mouseSensitivity * Time.deltaTime;


        xRotation -= mouseY;

        // Prevent Player to Look 360deg - Look up - look down
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);



    }
}
