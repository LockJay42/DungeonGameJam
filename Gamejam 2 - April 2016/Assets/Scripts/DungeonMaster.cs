using UnityEngine;
using System.Collections;

public class DungeonMaster : MonoBehaviour
{
    public TrapPlaceholder one;
    public TrapPlaceholder two;
    public TrapPlaceholder three;
    public TrapPlaceholder four;
    public TrapPlaceholder five;

    // Use this for initialization
    void Start ()
    {
            
	}
	
	// Update is called once per frame
	void Update ()
    {

        ActivateTraps();

        UpdateCamera();
        
    }


    void ActivateTraps()
    {
        //if (Input.GetButton("joystick 1 button 0"))
        if (Input.GetKeyDown("q"))
        {
            one.DoTheThing();
        }

        //if (Input.GetButton("joystick 1 button 1"))
        if (Input.GetKeyDown("w"))
        {
            two.DoTheThing();
        }

        //if (Input.GetButton("joystick 1 button 2"))
        if (Input.GetKeyDown("e"))
        {
            three.DoTheThing();
        }

        //if (Input.GetButton("joystick 1 button 3"))
        if (Input.GetKeyDown("r"))
        {
            four.DoTheThing();
        }

        //if (Input.GetButton("joystick 1 button 4"))
        if (Input.GetKeyDown("space"))
        {
            five.DoTheThing();
        }
    }


    void UpdateCamera()
    {
        if (Input.GetAxis("Fire3") != 0)
        {
            //transform.position = transform.position + Input.GetAxis("joystick 1 axis 5") * transform.forward;
            transform.position = transform.position + Input.GetAxis("Vertical") * transform.forward;
        }
        else
        {
            //transform.position = transform.position + Input.GetAxis("joystick 1 axis y") * transform.up;
            transform.position = transform.position + Input.GetAxis("Vertical") * transform.up;
        }

        //transform.position = transform.position + Input.GetAxis("joystick 1 axis x") * transform.right;
        transform.position = transform.position + Input.GetAxis("Horizontal") * transform.right;
    }
}