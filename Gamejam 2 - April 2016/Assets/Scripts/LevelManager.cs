using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager{

	public static void LoadPlayableLevelRandomly()
	{
		SceneManager.LoadScene(Random.Range(1, SceneManager.sceneCount));
	}
}
