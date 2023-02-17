using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed = 75;
    public float horizontalInput;
    public float forwardInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed  * forwardInput);

        //Rotates the car based on horizontal input
        transform.Rotate(Vector3.up,  turnSpeed * horizontalInput * Time.deltaTime);
    }
}
