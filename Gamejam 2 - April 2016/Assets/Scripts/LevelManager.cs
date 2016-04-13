using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager{

	public static void LoadPlayableLevelRandomly()
	{
		SceneManager.LoadScene(Random.Range(1, SceneManager.sceneCount));
	}

    public static void LoadNextLevel()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
            SceneManager.LoadScene("Level2");

        if (SceneManager.GetActiveScene().name == "Level2")
            SceneManager.LoadScene("Level3");

        if (SceneManager.GetActiveScene().name == "Level3")
            SceneManager.LoadScene("Level4");

        if (SceneManager.GetActiveScene().name == "Level4")
            SceneManager.LoadScene("Level5");

        if (SceneManager.GetActiveScene().name == "Level5")
            SceneManager.LoadScene("Level6");

        //instead of this last one we might want to make a 'win' scene

        if (SceneManager.GetActiveScene().name == "Level6")
            SceneManager.LoadScene("Level1");
    }
}
