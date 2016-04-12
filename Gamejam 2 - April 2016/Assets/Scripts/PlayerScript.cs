using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    //movement variables
    public Vector3 movement = new Vector3(0, 0, 0);
    public float movementSpeed = 12f;
    public float jumpHeight = 10f;
    public float gravityMultiplier = 2;
    public float movementDistance = 10;
    public bool grounded = true;

    public Rigidbody rb;
    public int lives;
    public int score;

    // Use this for initialization
    void Start()
    {
        tag = "Player";
        rb = GetComponent<Rigidbody>();
    }

    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
        //reset velocity and movement vector
        rb.velocity = new Vector3(0, rb.velocity.y, 0);
        movement.Set(0, 0, 0);

        //get controller for InControl input
        //InputDevice device = InputManager.ActiveDevice;

        //get analog stick input
        float x = Input.GetAxis("Horizontal");

        //If you want to use InControl input this is how I did movement, just need to make x equal zero every frame
        //level is backwards so x axis is reverse
        //move right
        //if (device.Direction.Left == true)
        //  x = -movementDistance;
        ////move left
        //if (device.Direction.Right == true)
        //  x = movementDistance;

        //if inputting A then jump
        //For InControl input use device.Action1.IsPressed
        if (Input.GetButton("Fire1") && grounded)
        {
            rb.velocity += new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
            grounded = false;
        }

        if (!grounded)
        {
            //increase gravity if falling
            Vector3 extraGravityForce = (Physics.gravity * gravityMultiplier) - Physics.gravity;
            rb.AddForce(extraGravityForce);
        }
        //set movement variable to input variables
        movement.Set(x, 0, 0);

        //calculate final movement vector and apply force to player
        movement = movement.normalized * movementSpeed * Time.fixedDeltaTime * 100;
        rb.AddForce(movement * 10);
    }

    void OnCollisionEnter()
    {
        grounded = true;
    }

    void OnCollisionExit()
    {
        //Increase gravity when falling
        Vector3 extraGravityForce = (Physics.gravity * gravityMultiplier) - Physics.gravity;
        rb.AddForce(extraGravityForce);
    }
}

