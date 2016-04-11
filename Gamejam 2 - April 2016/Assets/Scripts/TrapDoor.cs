using UnityEngine;
using System.Collections;

	[RequireComponent(typeof(BaseCollisionTrap))]
	public class TrapDoor : MonoBehaviour
	{

		// Use this for initialization
		[Range(0, 30)]
		public float Duration;
	bool isActive;

		void Start()
		{
			GetComponent<Collider>().enabled = true;
		}

		void OnActivate()
		{
			//run animation
			GetComponent<Collider>().enabled = false;
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
				Duration -= Time.deltaTime;
				if(Duration <= 0)
				{
					//run close animation
					SendMessage("DeactivateTrap");
					isActive = false;
				}
			}

		}

	}
