using UnityEngine;
using System.Collections;

public class BaseCollisionTrap : MonoBehaviour {

	public enum TrapKey { Z,X,C,V };

	public TrapKey trapKey;

	private KeyCode activateKey;

	private enum ActiveState {  NotActive, Activating, Active, OnCooldown, Dead };

	private ActiveState activeState;


	private KeyCode GetKeyCode(TrapKey key)
	{
		if (key == TrapKey.Z) {
			return KeyCode.Z;
		}
		if (key == TrapKey.X)
		{
			return KeyCode.X;
		}
		if (key == TrapKey.C)
		{
			return KeyCode.C;
		}
		if (key == TrapKey.V)
		{
			return KeyCode.V;
		}

		return KeyCode.None;
	}

	[Range(0, 1)]
	public float delay;
	// Use this for initialization

	[Range(0, 20)]
	public float cooldown;

	void Start () {
		activateKey = GetKeyCode(trapKey);
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
		activeState = ActiveState.NotActive;
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
		if(activeState == ActiveState.NotActive &&  Input.GetKey(activateKey))
		{
			StartCoroutine(DoActivateCoroutine());
		}
	}
}
