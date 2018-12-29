using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

	public void loadLevel()
	{
		SceneManager.LoadSceneAsync("Main", LoadSceneMode.Single);
	}

	public void loadAILevelEasy()
	{
		SceneManager.LoadSceneAsync ("EasyAI", LoadSceneMode.Single);
	}
	public void loadAILevelNormal()
	{
		SceneManager.LoadSceneAsync ("NormalAI", LoadSceneMode.Single);
	}
	public void loadAILevelHard()
	{
		SceneManager.LoadSceneAsync ("HardAI", LoadSceneMode.Single);
	}

	public void exit()
	{
		Application.Quit ();
	}

}