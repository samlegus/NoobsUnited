using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;

public class NoobDirectorySetup 
{
	
	[MenuItem("Noobs United/Setup Noob Directories")]
	private static void OpenMonoWizardFromContextMenu()
	{
		AssetDatabase.CreateFolder ("Assets", "MyGame");
		AssetDatabase.CreateFolder ("Assets/MyGame", "Scripts");
		AssetDatabase.CreateFolder ("Assets/MyGame", "Prefabs");
		AssetDatabase.CreateFolder ("Assets/MyGame", "ArtAssets");
		AssetDatabase.CreateFolder ("Assets/MyGame", "Scenes");

		AssetDatabase.Refresh ();
	}
	
	[MenuItem("Noobs United/Setup Noob Directories", true)]
	private static bool ValidateMonoWizardFromContextMenu()
	{
		return !(Directory.Exists (Application.dataPath + "/MyGame"));
	}

}
