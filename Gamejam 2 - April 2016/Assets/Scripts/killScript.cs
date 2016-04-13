using UnityEngine;
using System.Collections;

public class killScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.CompareTag("Player"))
		{
			GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>().lives -= 1;
			LevelManager.LoadPlayableLevelRandomly();
		}
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
