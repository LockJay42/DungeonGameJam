using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BaseCollisionTrap))]
public class FlameTrap : MonoBehaviour {

	// Use this for initialization
	[Range(0, 10)]
	public float maxHeight;
	[Range(0, 10)]
	public float maxDuration;
	float duration;
	bool active = false;

	void Start()
	{

	}

	void OnActivate()
	{
		active = true;
		duration = maxDuration;
	}

	void OnPlayerCollision()
	{
		//todo Kill player
	}

	// Update is called once per frame
	void Update()
	{

		if (active == true)
		{
			duration -= Time.deltaTime;
			if (duration <= 0)
			{
				SendMessage("DeactivateTrap");
				active = false;
			}
		}
	}
}

