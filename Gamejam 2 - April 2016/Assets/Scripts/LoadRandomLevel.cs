using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadRandomLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void loadRandomLevel()
	{
		SceneManager.LoadScene(Random.Range(2,SceneManager.sceneCount));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
