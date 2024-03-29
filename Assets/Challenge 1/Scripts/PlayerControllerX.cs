﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 25.0f;
    public float horizontalInput;
    public float verticalInput;
    public float rotationSpeed = 100f;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);
        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(new Vector3(-verticalInput, 0f, 0f) * rotationSpeed);
    }

}
