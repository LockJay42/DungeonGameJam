using UnityEngine;
using System.Collections;

public class BaseCollisionTrap : MonoBehaviour {

	public KeyCode actiaveKey;

	private enum ActiveState {  NotActive, Activating, Active, OnCooldown, Dead };

	private ActiveState activeState;



	[Range(0, 1)]
	public float delay;
	// Use this for initialization

	[Range(0, 20)]
	public int cooldown;

	void Start () {
		activeState = ActiveState.NotActive;
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.CompareTag("Player"))
		{
			if (activeState == ActiveState.Active)
			{
				SendMessage("OnPlayerCollision");
			}
		}
		
		
	}

	IEnumerator DeactivateTrap()
	{
		activeState = ActiveState.OnCooldown;
		yield return new WaitForSeconds(cooldown);
		activeState = ActiveState.Active;
	}

	IEnumerator DoActivateCoroutine()
	{
		activeState = ActiveState.Activating;
		yield return new WaitForSeconds(delay);
		activeState = ActiveState.Active;
		SendMessage("OnActivate");
	}

	// Update is called once per frame
	void Update ()
	{
		if(activeState == ActiveState.NotActive &&  Input.GetKey(actiaveKey))
		{
			StartCoroutine(DoActivateCoroutine());
		}
	}
}
