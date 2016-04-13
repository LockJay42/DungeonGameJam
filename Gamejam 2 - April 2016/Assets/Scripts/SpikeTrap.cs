using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BaseCollisionTrap))]
public class SpikeTrap : MonoBehaviour {

	// Use this for initialization
	//[Range(0, 10)]
	private float maxDuration = 2;
	private float duration;
	private Animator[] animators;

	bool isActive = false;

	void Start () {
		animators = transform.GetComponentsInChildren<Animator>();
		GetComponentInChildren<Collider>().enabled = true;
	}

	void OnActivate()
	{
		foreach (var anim in animators)
		{
			anim.SetBool("AnimateSpikes", true);
		}
		duration = maxDuration;
		isActive = true;
		//run animation
		GetComponentInChildren<BoxCollider>().center = new Vector3(0,1,0);
		Debug.Log("colOn");
	}

	void OnPlayerCollision()
	{
		GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>().lives -= 1;
		LevelManager.LoadPlayableLevelRandomly();
	}

	// Update is called once per frame
	void Update () {
		if (isActive)
		{
			duration -= Time.deltaTime;
			if(duration <= 0)
			{
				foreach (var anim in animators)
				{
					anim.SetBool("AnimateSpikes", false);
				}
				SendMessage("DeactivateTrap");
				//GetComponent<Collider>().enabled = false;
				isActive = false;
			}
		}
	}
}