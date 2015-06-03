﻿using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
using System;

/// <summary>
///	* This adds "New Noob Script" to the project window context (right click) menu
/// * Could probably use some more testing and commenting, but for now it's functional
/// * This requires that all the ProjectAwesome stuff is in the right place
/// * KNOWN ISSUES:
/// 	* 	In two column layout mode, if you right click on a folder in the left hand column
/// 		Selection.activeObject is null even though it appears that a folder is selected?
/// </summary>
/// 
/// Author: Sam Legus
/// Last Update: 6/2/2015

public class NoobScriptCreationWindow : EditorWindow
{
	string scriptName = "";
	bool autoFormatScript;
	
	[MenuItem("Assets/Create/New Noob Script")]
	private static void CreateNewNoobScript()
	{
		var window = EditorWindow.GetWindow<NoobScriptCreationWindow>();
		window.position = new Rect(Screen.width / 2,Screen.height / 2, 450, 80);
		window.ShowPopup ();
	}

	//To fix the two column layout issue
	[MenuItem("Assets/Create/New Noob Script", true)]
	private static bool ValidateNewNoobScript()
	{
		return Selection.activeObject != null;
	}
	
	void OnGUI()
	{
		GUILayout.Label ("* Name should have LETTERS ONLY. No spaces, numbers or symbols.");
		GUILayout.Label ("* It is recommended to camel case your script name, ex : playerHealth ");

		scriptName = EditorGUILayout.TextField ("Script name:", scriptName);
		autoFormatScript = EditorGUILayout.Toggle("Auto-Formmated", autoFormatScript);

		if(GUILayout.Button ("Create"))			
		{
			bool scriptNameIsValid = true;
			foreach(char c in scriptName)
			{
				if(!Char.IsLetter (c))
				{
					scriptNameIsValid = false;
				}
			}
			if(!scriptNameIsValid)
			{
				EditorUtility.DisplayDialog (	"Invalid name",
				                             	"Invalid script name! Please use lower and uppercase letters only!",
				                             	"Okay");
				return;
			}
			else
			{
				//The highlighted or selected folder/file in the project window
				var selectedObject = Selection.activeObject;
				
				//Path to assets minus the "/assets"
				string trimmedAppDataPath = Application.dataPath.Substring ( 0, Application.dataPath.LastIndexOf ("/")) + "/"; 
				string selectedObjectFilePath = "";

				if(selectedObject != null)
				{
					selectedObjectFilePath = trimmedAppDataPath + AssetDatabase.GetAssetPath(selectedObject.GetInstanceID());
				}

				string sourceFilePath = "";

				if(autoFormatScript)
				{
					sourceFilePath = Application.dataPath + "/NoobsUnited/CoreAssets/NoobScriptTemplate.cs";
				}
				if(!autoFormatScript)
				{
					sourceFilePath = Application.dataPath + "/NoobsUnited/CoreAssets/NoobScriptTemplateMinimal.cs";
				}

				string newFilePath = "";
				
				if(selectedObjectFilePath.Length > 0)
				{
					if(Directory.Exists (selectedObjectFilePath)) 	//It's a folder
					{
						newFilePath = selectedObjectFilePath + "/" + scriptName + ".cs";
					}
					else if( AssetDatabase.Contains (selectedObject))											//It's a file
					{
						//If we've selected an object, remove the old file name from the file path
						//and replace it with the new script name
						string trimmedFilePath = selectedObjectFilePath.Substring (0, selectedObjectFilePath.LastIndexOf ("/") + 1);
						newFilePath = trimmedFilePath + scriptName + ".cs";
					}
					else
					{
						newFilePath = Application.dataPath;
					}
				}
				
				File.Copy (sourceFilePath, newFilePath);
				
				//Creating a temporary file to write to while the source is open for reading
				string tempFilePath = Application.dataPath + "/NoobsUnited/CoreAssets/NoobTempFile.cs";
				
				StreamReader sr = new StreamReader(newFilePath);
				StreamWriter sw = new StreamWriter(tempFilePath);
				
				string line;
				while((line = sr.ReadLine()) != null)
				{
					if(line.Contains ("public class NoobScriptTemplate"))
					{
						//	All of this just to replace the class name haha
						string newClassName = Path.GetFileNameWithoutExtension (newFilePath);
						sw.WriteLine("public class " + newClassName + " : NoobScript");
					}
					else
					{
						sw.WriteLine (line);
					}
				}
				
				sw.Close ();
				sr.Close ();
				
				File.Copy (tempFilePath, newFilePath, true);	//	Write new file using temp file
				File.Delete (tempFilePath);						//	Don't need the temp file anymore
				
				EditorWindow window = EditorWindow.GetWindow<NoobScriptCreationWindow>();
				window.Close ();
				
				scriptName = "";
				AssetDatabase.Refresh ();
			}
		}

	}
	
}

public class NoobsUnitedFolderSetup
{
	//Move this later
	[MenuItem("Noobs United/Setup Folders")]
	private static void ValidProjectAwesomeFolders()
	{
		bool scriptsFolderCreated = Directory.Exists (Application.dataPath + "/MyScripts");
		bool prefabsFolderCreated = Directory.Exists (Application.dataPath + "/MyPrefabs");
		bool artAssetsFolderCreated = Directory.Exists (Application.dataPath + "/MyArtAssets");
		bool scenesFolderCreated = Directory.Exists (Application.dataPath + "/MyScenes");
		
		if(!scriptsFolderCreated)
		{
			AssetDatabase.CreateFolder ("Assets", "MyScripts");
		}
		if(!prefabsFolderCreated)
		{
			AssetDatabase.CreateFolder ("Assets", "MyPrefabs");
		}
		if(!artAssetsFolderCreated)
		{
			AssetDatabase.CreateFolder ("Assets", "MyArtAssets");
		}
		if(!scenesFolderCreated)
		{
			AssetDatabase.CreateFolder ("Assets", "MyScenes");
		}
		
		AssetDatabase.Refresh ();
	}

	[MenuItem("Noobs United/Setup Folders", true)]
	private static bool ValidateProjectAwesomeFolders()
	{
		bool scriptsFolderCreated = Directory.Exists (Application.dataPath + "/My Scripts");
		bool prefabsFolderCreated = Directory.Exists (Application.dataPath + "/My Prefabs");
		bool artAssetsFolderCreated = Directory.Exists (Application.dataPath + "/My Art Assets");
		bool scenesFolderCreated = Directory.Exists (Application.dataPath + "/My Scenes");
		
		return !scriptsFolderCreated || !prefabsFolderCreated || !artAssetsFolderCreated || !scenesFolderCreated;
		//AssetDatabase.Refresh ();
	}
}





