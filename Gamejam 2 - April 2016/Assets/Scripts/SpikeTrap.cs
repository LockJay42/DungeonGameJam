using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BaseCollisionTrap))]
public class SpikeTrap : MonoBehaviour {

	// Use this for initialization
	[Range(0, 10)]
	public float maxDuration;
	private float duration;
	private Animator anim;

	bool isActive = false;

	void Start () {
		anim = transform.GetComponent<Animator>();
		GetComponent<Collider>().enabled = false;
	}

	void OnActivate()
	{
		anim.SetBool("AnimateSpikes", true);
		duration = maxDuration;
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
				anim.SetBool("AnimateSpikes", false);
				SendMessage("DeactivateTrap");
				GetComponent<Collider>().enabled = false;
				isActive = false;
			}
		}
	}
}