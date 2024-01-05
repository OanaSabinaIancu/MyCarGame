using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed = 2.5f; //turning speed value
    public float horizontalInput; //we used this variable for receive the input from the keyboard
    public float forwardInput; //we used this variable for receive the input from the keyboard


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //the car runs forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); //car is moving forward and backward
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); //car is moving on press A, D, left, right 
    }
}
