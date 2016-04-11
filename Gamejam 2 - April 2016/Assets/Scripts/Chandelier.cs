using UnityEngine;
using System.Collections;


[RequireComponent(typeof(BaseCollisionTrap))]
public class Chandelier : MonoBehaviour
{

	// Use this for initialization
	[Range(-10, 0)]
	public float MaxSpeed;
	Vector3 speed;

	void Start()
	{
		speed = new Vector3(0, 0, 0);
	}

	void OnActivate()
	{
		speed = new Vector3(0, MaxSpeed, 0);
	}

	void OnPlayerCollision()
	{
		//todo Kill player
	}

	// Update is called once per frame
	void Update()
	{
		transform.position += speed;
	}
}