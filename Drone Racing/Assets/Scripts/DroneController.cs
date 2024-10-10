using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DroneController : MonoBehaviour
{
    // Variables for movement speed and force
    public float movementSpeed = 5f;
    public float rotationSpeed = 100f;
    public float upwardForce = 10f;
    public float verticalSpeed = 5f;

    // Reference to the Rigidbody of the drone
    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component attached to the drone
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movement control
        //float moveVertical = Input.GetAxis("Vertical"); // W/S keys or Up/Down arrows
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D keys or Left/Right arrows

        // Calculate movement direction
        //Vector3 movement = transform.forward * moveVertical * movementSpeed * Time.deltaTime;
        Vector3 rotation = Vector3.up * moveHorizontal * rotationSpeed * Time.deltaTime;

        // Apply movement and rotation
        //rb.AddForce(movement);
        transform.Rotate(rotation);

        // if(Input.GetKey(KeyCode.O))
        // {
        //     Vector3 verticalMovement = Vector3.up * verticalSpeed * Time.deltaTime;
        //     rb.AddForce(verticalMovement);
        // }

        // if(Input.GetKey(KeyCode.K))
        // {
        //     Vector3 verticalMovement = -Vector3.up * verticalSpeed * Time.deltaTime;
        //     rb.AddForce(verticalMovement);
        // }


        // if(Input.GetKey(KeyCode.W))
        // {
        //     body.position += transform.forward*velocity*Time.fixedDeltaTime;
        // }


        // if(Input.GetKey(KeyCode.S))
        // {
        //     body.position -= transform.forward*velocity*Time.fixedDeltaTime;
        // }


    }
}
