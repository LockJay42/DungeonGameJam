using UnityEngine;
using System.Collections;


[RequireComponent(typeof(BaseCollisionTrap))]
public class Chandelier : MonoBehaviour
{

	// Use this for initialization
	[Range(-10, 0)]
	public float MaxSpeed;
	Vector3 speed;
	bool active = false;

	[Range(0, 20)]
	public float timeToMaxAcceleration;

	void Start()
	{
		speed = new Vector3(0, 0, 0);
		GetComponent<Rigidbody>().useGravity = false;
	}

	void OnActivate()
	{
		active = true;
	}

	void OnPlayerCollision()
	{
		//todo Kill player
	}

	// Update is called once per frame
	void Update()
	{
		if (active)
		{
			GetComponent<Rigidbody>().useGravity = true;
		}
	}
}