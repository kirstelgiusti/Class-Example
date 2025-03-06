using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // we put information at the start
    // of a class
    public int health = 100;
    public float speed = 4.5f;
    public string hero = "Void";
    public bool isAlive = true;

    // xyz co ordinates
    public Vector3 direction;
    public Rigidbody playerRB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("My name is " + hero);
    }

    // Update is called once per frame
    void Update()
    {

        // the dot is there to access
        // a functionality of "transform"
        // transform.Translate(direction * Time.deltaTime * speed);

        playerRB.linearVelocity = direction * speed; 

    }

    private void OnMove(InputValue value) //this is like a new class
    {
        //asks the input system what keys are being pressed
        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(inputValue.x, 0, inputValue.y);

    }
}