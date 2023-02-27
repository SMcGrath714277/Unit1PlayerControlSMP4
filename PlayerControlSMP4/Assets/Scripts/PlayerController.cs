using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;

    void Start()
    {
        
    }

    void Update()
    {
        // Fetches player inputs.
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Moves the vehicle fowward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Rotates the vehicle. 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
