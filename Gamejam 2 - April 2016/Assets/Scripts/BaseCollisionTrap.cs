using UnityEngine;
using System.Collections;

public class BaseCollisionTrap : MonoBehaviour {

	public enum TrapKey { Z,X,C,V };

	public TrapKey trapKey;

	private KeyCode activateKey;

	private enum ActiveState {  NotActive, Activating, Active, OnCooldown, Dead };

	private ActiveState activeState;

	public ParticleSystem[] ActiveTrapParticleSystem;

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
				//SendMessage("OnPlayerCollision");
                //todo add points to dungeon master
			}
		}
		
		
	}

	IEnumerator DeactivateTrap()
	{
		Debug.Log("Deactivating");
		activeState = ActiveState.OnCooldown;
		foreach (var particleSystem in ActiveTrapParticleSystem)
		{
			particleSystem.Stop();
			particleSystem.gameObject.SetActive(false);
		}
		yield return new WaitForSeconds(cooldown);
		activeState = ActiveState.NotActive;
		Debug.Log("readytouse");
	}

	IEnumerator DoActivateCoroutine()
	{
		activeState = ActiveState.Activating;
		yield return new WaitForSeconds(delay);
		activeState = ActiveState.Active;
		foreach(var particleSystem in ActiveTrapParticleSystem)
		{
			particleSystem.gameObject.SetActive(true);
			particleSystem.Play();
			Debug.Log("particles on");
		}
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
