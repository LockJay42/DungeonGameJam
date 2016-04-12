using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadRandomLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void loadRandomLevel()
	{
		LevelManager.LoadPlayableLevelRandomly();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
