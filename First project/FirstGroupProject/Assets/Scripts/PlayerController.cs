using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static Unity.VisualScripting.Metadata;

public class PlayerController : MonoBehaviour
{
    private float movementX = 0;
    private float movementY = 0;
    private Rigidbody rb;

    public float movementSpeed = 10;
    public float rotationSpeed = 5;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.AddForce(transform.forward * movementY * movementSpeed);
        transform.Rotate(0, movementX * rotationSpeed, 0);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }
}
