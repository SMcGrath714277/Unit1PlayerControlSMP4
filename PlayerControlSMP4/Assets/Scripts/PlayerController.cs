using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;

    void Start()
    {
        
    }

    void Update()
    {
        // Moves the vehcile fowward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}