using UnityEngine;
using System.Collections;
using NoobsUnited;

public class WinLose : NoobScript
{
	//Put variables that you want to set from the inspector inside this region
	#region Inspector Variables

	public GameObject logic;

	#endregion
	
	//Put variables that you do not want to set from the inspector inside this region
	#region Private Variables

	private LevelSwitcher levelSwitcher;

	#endregion
	
	//All functions inside this region are automatically called by Unity
	#region Unity Events
	
	//Any code written inside of Start will be called once when the object is created.
	void Start()
	{
		//Both ways to use GetComponent
		levelSwitcher = logic.GetComponent("LevelSwitcher") as LevelSwitcher;
		//levelSwitcher = logic.GetComponent<LevelSwitcher>();
	}
	
	//Any code written instead of Update will be called every time the application updates
	void Update()
	{
		float h = Input.GetAxisRaw ("Horizontal") * 15f;
		self.Move (h, 0);

		if(self.GetPositionX () <= -10f)
		{
			levelSwitcher.LoadMainGame ();
		}
		if(self.GetPositionX () >= 10f)
		{
			levelSwitcher.LoadGameOverMenu ();
		}
	}
	#endregion
}
