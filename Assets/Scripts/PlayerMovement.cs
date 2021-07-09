using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController characterController;

    public float speed = 12f;

    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrouded;


    // Joystick Variables
    [HideInInspector]
    public Vector2 RunAxis;

  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        isGrouded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrouded && velocity.y < 0) 
        {
            velocity.y = -2f;
        }

        /*
         * For keyboard controls
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        */

        /*
         * For Mobile Controls
         * Joystick Controller
         */

        float x = RunAxis.x;
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        characterController.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        characterController.Move(velocity * Time.deltaTime);
    }
}
