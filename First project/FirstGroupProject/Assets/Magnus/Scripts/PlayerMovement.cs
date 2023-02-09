using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;

    [Range(0f, 50f)]
    public int moveSpeed = 1;

    [Range(0, 100f)]
    public int rotationSpeed = 1;

    [Range(0, 100f)]
    public int jumpForce = 1;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementY, 0f, 0f);
        Vector3 rotation = new Vector3(0f, movementX, 0f);

        if (rb != null)
        {
            rb.AddRelativeForce(movement * moveSpeed);
            rb.AddTorque(rotation * rotationSpeed, ForceMode.Force);
        }
    }
    private void OnMove(InputValue movementValue)
    {
        /* Get direction provided by user */
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;

        Debug.Log($"OnMove: {movementValue.Get()}");
    }

    private void OnJump(InputValue jumpValue) 
    {
        Debug.Log($"OnJump: {jumpValue.Get()}");
        Vector3 jumpVector = new Vector3(0f, jumpValue.Get<float>() * jumpForce, 0f);
        rb.AddRelativeForce(jumpVector, ForceMode.Impulse);
    }
}
