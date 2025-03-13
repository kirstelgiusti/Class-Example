using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // we put information at the start
    // of a class
    public float speed = 4.5f;
    public float jumpForce = 5;
    public string hero = "Void";

    // xyz co ordinates
    public Vector3 direction;
    public Rigidbody playerRB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("My name is " + hero);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // the dot is there to access
        // a functionality of "transform"
        // transform.Translate(direction * Time.deltaTime * speed);

        Vector3 velocity = direction * speed;
        velocity.y = playerRB.linearVelocity.y; 
        
        playerRB.linearVelocity = velocity;
    }
    private void OnMove(InputValue value) //this is like a new class
    {
        //asks the input system what keys are being pressed
        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(inputValue.x, 0, inputValue.y);

    }

    private void OnJump(InputValue value)
    {
        //Physics.Raycast will cast a line that can hit other colliders. if it hits a collider (true) if it doesnt (false)
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.6f);
        if (isGrounded)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        
    }
}