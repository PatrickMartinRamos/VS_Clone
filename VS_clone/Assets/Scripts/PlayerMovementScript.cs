using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementScript : MonoBehaviour
{
    private Player_input input = null;
    private Vector2 moveVector = Vector2.zero;
    private Rigidbody2D rb = null;
    public float moveSpeed;


    private void Awake()
    {
        input = new Player_input();
        rb = GetComponent<Rigidbody2D>();
        Application.targetFrameRate = 60;
    }

    public void FixedUpdate()
    {
        rb.velocity = moveVector * moveSpeed;
    }

    private void OnEnable()
    {
        input.Enable();
        input.Player.movement.performed += onMovementPerformed;
        input.Player.movement.canceled += onMovementCancel;
    }

    private void OnDisable()
    {
        input.Disable();
        input.Player.movement.performed -= onMovementPerformed;
        input.Player.movement.canceled -= onMovementCancel;
    }

    private void onMovementPerformed(InputAction.CallbackContext value)
    {
        moveVector = value.ReadValue<Vector2>();
    }

    private void onMovementCancel(InputAction.CallbackContext value)
    {
        moveVector = Vector2.zero;
    }    
}
