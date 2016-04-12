using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BaseCollisionTrap))]
public class SpikeTrap : MonoBehaviour {

	// Use this for initialization
	[Range(0, 10)]
	public float maxDuration;
	private float duration;

	bool isActive = false;

	void Start () {
		GetComponent<Collider>().enabled = false;
	}

	void OnActivate()
	{
		duration = maxDuration;
		isActive = true;
		//run animation
		GetComponent<Collider>().enabled = true;
	}

	void OnPlayerCollision()
	{
		GameObject.FindGameObjectWithTag("player").GetComponent<PlayerScript>().lives -= 1;
		LevelManager.LoadPlayableLevelRandomly();
	}

	// Update is called once per frame
	void Update () {
		if (isActive)
		{
			duration -= Time.deltaTime;
			if(duration <= 0)
			{
				SendMessage("DeactivateTrap");
				GetComponent<Collider>().enabled = false;
				isActive = false;
			}
		}
	}
}