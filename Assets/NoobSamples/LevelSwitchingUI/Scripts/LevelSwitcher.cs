using UnityEngine;
using System.Collections;

public class LevelSwitcher : NoobScript
{
	//Put variables that you want to set from the inspector inside this region
	#region Inspector Variables

	public string StartMenuSceneName;
	public string GameOverMenuSceneName;
	public string MainGameSceneName;
	
	#endregion

	//Put any functions that you write yourself inside this region
	#region My Functions

	public void LoadStartMenu()
	{
		Application.LoadLevel(StartMenuSceneName);
	}

	public void LoadGameOverMenu()
	{
		Application.LoadLevel(GameOverMenuSceneName);
	}

	public void LoadMainGame()
	{
		Application.LoadLevel (MainGameSceneName);
	}

	public void ExitGame()
	{
		Application.Quit();
	}
	
	#endregion
}
