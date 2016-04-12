using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    //movement variables
    public Vector3 movement = new Vector3(0, 0, 0);
    public float movementSpeed = 12f;
    public float jumpHeight = 40f;
    public bool grounded = true;
    public int score;

    public Rigidbody rb;

	// Use this for initialization
	void Start()
    {
        tag = "Player";
        rb = GetComponent<Rigidbody>();
        Physics.gravity.Set(0, 100, 0);
	}

    //Update is called once per frame
    void Update()
    {
       if (rb.position.y <= 0)
       {
           grounded = true;
       }
    }

    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
        //reset velocity and movement vector
        rb.velocity = Vector3.zero;
        movement.Set(0, 0, 0);

        //get analog stick input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //if inputting A then jump
        if (Input.GetButtonDown("A") && grounded)
        {
            rb.velocity = new Vector3(0, jumpHeight, 0);
            grounded = false;
        }

        //set movement variable to input variables
        movement.Set(x, 0, z);

        //calculate final movement vector and apply force to player
        movement = movement.normalized * movementSpeed * Time.fixedDeltaTime * 100;
        rb.AddForce(movement * 10);
    }
}

