using UnityEngine;
using System.Collections;

public class TrapPlaceholder : MonoBehaviour
{

    public GameObject holderOfPlaces;

	// Use this for initialization
	void Start ()
    {
        holderOfPlaces = GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}


    public void DoTheThing()
    {
        Debug.Log("Trap activated!");
    }
}