using UnityEngine;
using System.Collections;


[RequireComponent(typeof(BaseCollisionTrap))]
public class Chandelier : MonoBehaviour
{

	// Use this for initialization
	bool active = false;

	[Range(0, 20)]
	public float timeToMaxAcceleration;

	void Start()
	{
		GetComponent<Rigidbody>().useGravity = false;
	}

	void OnActivate()
	{
		active = true;
	}

	void OnPlayerCollision()
	{
		GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>().lives -= 1;
		LevelManager.LoadPlayableLevelRandomly();
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