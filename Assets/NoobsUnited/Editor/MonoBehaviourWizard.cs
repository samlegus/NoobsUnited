using UnityEngine;
using System.Collections.Generic;
using UnityEditor;
using System.IO;
using System;


public partial class MonoBehaviourCreationWizard : EditorWindow
{
	static string scriptName = "";
	static string scriptDirectoryPath = "";
	static string scriptFullFilePath = "";
	
	static bool noobScriptMode = false;
	static bool monoBehaviourMode = true;
	static bool openScriptAfterCreation = true;
	
	static Dictionary<string, bool> includedFunctions = new Dictionary<string, bool>();
	static Dictionary<string, string[]> functionDefinitions = new Dictionary<string, string[]>();
	
	static UnityEngine.Object selectedObject;
	static string defaultScriptDirectory = "Assets/MyGame/Scripts";

	private static MonoBehaviourCreationWizard window
	{
		get { return EditorWindow.GetWindow<MonoBehaviourCreationWizard>();}
	}

	[MenuItem("Assets/Create/C# Script Creation Wizard")]
	private static void OpenMonoWizardFromContextMenu()
	{

		window.position = new Rect(100, 100, 450, 450);
		window.ShowPopup ();
		selectedObject = Selection.activeObject;
		SetFilePathFromContextMenu();
	}

	[MenuItem("Assets/Create/C# Script Creation Wizard", true)]
	private static bool ValidateMonoWizardFromContextMenu()
	{
		return Selection.activeObject != null;
	}

	[MenuItem("Noobs United/C# Script Creation Wizard")]
	private static void CreateNewMonoBehaviourFromMenuBar()
	{
		var window = EditorWindow.GetWindow<MonoBehaviourCreationWizard>();
		window.position = new Rect(100, 100, 450, 450);
		window.ShowPopup ();
		AssetDatabase.Refresh ();
		SetFilePathFromMenuBar();
	}

	[MenuItem("Noobs United/C# Script Creation Wizard", true)]
	private static bool ValidateMonoWizardFromMenuBar()
	{
		return Directory.Exists (defaultScriptDirectory);
	}
	
	void OnGUI()
	{
		InitializeFunctionEntryTable();
		InitializeFunctionDefinitionTable();
		
		GUILayout.Label ("Script Mode: ");
		
		noobScriptMode = EditorGUILayout.Toggle("* NoobScript", !monoBehaviourMode);
		monoBehaviourMode = EditorGUILayout.Toggle("* MonoBehaviour", !noobScriptMode);
		
		scriptName = EditorGUILayout.TextField ("Script name:", scriptName);
		
		GUILayout.Label ("* Name may have letters only.");
		
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
				EditorUtility.DisplayDialog ("Invalid name",
				                             "Invalid script name! Please use lower and uppercase letters only!",
				                             "Okay");
				return;
			}

			scriptFullFilePath = scriptDirectoryPath + "/" + scriptName + ".cs";

			if(File.Exists (scriptFullFilePath))
			{
				EditorUtility.DisplayDialog ("Script already exists",
				                             scriptName + ".cs" + " already exists, please choose a different script name.",
				                             "Okay");
				return;
			}

			WriteScript ();
			OpenScript ();
			FinishScriptCreation ();

		}
		
		GUILayout.Label("* Generate empty definitions for these events: ");
		includedFunctions["Awake"] = EditorGUILayout.Toggle ("Awake", includedFunctions["Awake"]);
		includedFunctions["FixedUpdate"] = EditorGUILayout.Toggle ("FixedUpdate", includedFunctions["Start"]);	
		includedFunctions["Start"] = EditorGUILayout.Toggle ("Start", includedFunctions["Start"]);	
		includedFunctions["Update"] = EditorGUILayout.Toggle ("Update", includedFunctions["Update"]);
		includedFunctions["OnCollisionEnter2D"] = EditorGUILayout.Toggle ("OnCollisionEnter2D", includedFunctions["OnCollisionEnter2D"]);
		includedFunctions["OnTriggerEnter2D"] = EditorGUILayout.Toggle ("OnTriggerEnter2D", includedFunctions["OnTriggerEnter2D"]);
		GUILayout.Label("* Other Options");
		EditorGUILayout.Toggle ("Open script after creation", openScriptAfterCreation);

	}
	
	static void InitializeFunctionEntryTable()
	{
		if(includedFunctions.Count > 0)
		{
			return;
		}
		
		//includedFunctions.Clear();
		includedFunctions.Add ("Awake", false);
		includedFunctions.Add ("FixedUpdate", false);
		includedFunctions.Add ("Start", true);
		includedFunctions.Add ("Update", true);
		includedFunctions.Add ("OnCollisionEnter2D", false);
		includedFunctions.Add ("OnTriggerEnter2D", false);
	}
	
	static void InitializeFunctionDefinitionTable()
	{
		if(functionDefinitions.Count > 0)
		{
			return;
		}
		
		functionDefinitions.Add ("Awake", 	new string[]	{"\tvoid Awake()",	"\t{",	"", "\t}"	});
		functionDefinitions.Add ("Start", 	new string[]	{"\tvoid Start()",	"\t{", 	"",	"\t}"	});
		functionDefinitions.Add ("FixedUpdate", new string[]	{"\tvoid FixedUpdate()",	"\t{", 	"",	"\t}"	});
		functionDefinitions.Add ("Update", 	new string[]	{"\tvoid Update()", "\t{", 	"",	"\t}"	});
		functionDefinitions.Add ("OnCollisionEnter2D", new String[] {"\tvoid OnCollisionEnter2D(Collision2D other)", "\t{",	"", "\t}"});
		functionDefinitions.Add ("OnTriggerEnter2D", new String[] {"\tvoid OnTriggerEnter2D(Collider2D other)", "\t{",	"", "\t}"});
		
	}

	static void SetFilePathFromMenuBar()
	{

		scriptDirectoryPath = defaultScriptDirectory;
	}

	static void SetFilePathFromContextMenu()
	{
		//The highlighted or selected folder/file in the project window
		if(Directory.Exists (AssetDatabase.GetAssetPath (selectedObject )))
		{
			scriptDirectoryPath = AssetDatabase.GetAssetPath (selectedObject);
		}
		else if(AssetDatabase.GetAssetPath (selectedObject) != null && !Directory.Exists (AssetDatabase.GetAssetPath (selectedObject )))
		{
			scriptDirectoryPath = AssetDatabase.GetAssetPath (selectedObject);
			scriptDirectoryPath = scriptDirectoryPath.Substring (0, scriptDirectoryPath.LastIndexOf ("/") + 1);
		}
	}
	
	static void WriteScript()
	{
		StreamWriter sw = new StreamWriter(scriptFullFilePath);
		
		sw.WriteLine ("using UnityEngine;");
		sw.WriteLine ("using UnityEngine.UI;");
		sw.WriteLine ("using System.Collections;");
		
		if(noobScriptMode)
		{
			sw.WriteLine("using NoobsUnited;");
		}
		
		sw.WriteLine ("");
		
		if(noobScriptMode)
		{
			sw.WriteLine ("public class " + scriptName + " : NoobScript");
		}
		else
		{
			sw.WriteLine ("public class " + scriptName + " : MonoBehaviour");
		}
		
		sw.WriteLine ("{");
		sw.WriteLine();
		
		foreach(KeyValuePair <string, bool> kp in includedFunctions)
		{
			if(kp.Value)
			{
				foreach(string line in functionDefinitions[kp.Key])
				{
					sw.WriteLine(line);	
				}
				sw.WriteLine ();
			}
		}
		
		sw.WriteLine ("}");
		sw.Close();
	}
	
	static void FinishScriptCreation()
	{
		scriptName = "";
		scriptDirectoryPath = "";
		scriptFullFilePath = "";

		if(selectedObject != null)
		{
			selectedObject = null;
		}

		window.Close ();
	}
	
	static void OpenScript()
	{
		AssetDatabase.Refresh ();
		MonoScript script = AssetDatabase.LoadAssetAtPath (scriptFullFilePath, typeof(MonoScript)) as MonoScript;
		Selection.activeObject = script;
		AssetDatabase.OpenAsset (script);
	}
	
}






