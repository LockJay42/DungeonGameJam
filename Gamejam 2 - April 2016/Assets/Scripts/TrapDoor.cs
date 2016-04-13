using UnityEngine;
using System.Collections;

	[RequireComponent(typeof(BaseCollisionTrap))]
	public class TrapDoor : MonoBehaviour
	{

		// Use this for initialization
		[Range(0, 30)]
		public float maxDuration;
		float duration;
		bool isActive;
		private Animator[] animators;

	void Start()
		{
			animators = transform.GetComponentsInChildren<Animator>();
			GetComponentInChildren<Collider>().enabled = true;
		}

		void OnActivate()
		{
		GetComponentInChildren<Collider>().enabled = false;
		Debug.Log ("working");
		foreach (var anim in animators)
			{
				anim.SetBool("TrapActive", true);
			
			}
		duration = maxDuration;
			//run animation

		}

		void OnPlayerCollision()
		{
			//todo Kill player
		}

	// Update is called once per frame

	void Update()
		{
			if(isActive)
			{
				duration -= Time.deltaTime;
				if(duration <= 0)
				{
					//run close animation
					SendMessage("DeactivateTrap");
					isActive = false;
				}
			}

		}

	}
