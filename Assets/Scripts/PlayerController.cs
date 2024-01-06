using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variablees declaration
    private float speed = 10.0f;
    private float turnSpeed = 25.0f; //turning speed value
    private float horizontalInput; //we used this variable for receive the input from the keyboard
    private float forwardInput; //we used this variable for receive the input from the keyboard


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //user input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //car's movements
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); //car is moving forward and backward
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput); // car is moving to the left/right
    }
}
