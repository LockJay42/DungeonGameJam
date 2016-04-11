using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BaseCollisionTrap))]
public class SpikeTrap : MonoBehaviour {

	// Use this for initialization
	[Range(0, 10)]
	float duration;

	bool isActive = false;

	void Start () {

	}

	void OnActivate()
	{
		isActive = true;
		//run animation
		GetComponent<Collider>().enabled = true;
	}

	void OnPlayerCollision()
	{
		//todo Kill player
	}

	// Update is called once per frame
	void Update () {
		if (isActive)
		{
			duration -= Time.deltaTime;
			if(duration <= 0)
			{
				SendMessage("DeactivateTrap");
			}
		}
	}
}