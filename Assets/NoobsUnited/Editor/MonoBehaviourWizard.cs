using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using System.IO;
using System;

public class MonoBehaviourCreationWizard : EditorWindow
{
	string scriptName = "";
	string scriptFilePath = "";
	
	bool noobScriptMode = false;
	bool monoBehaviourMode = true;
	
	Dictionary<string, bool> includedFunctions = new Dictionary<string, bool>();
	Dictionary<string, string[]> functionDefinitions = new Dictionary<string, string[]>();
	
	static UnityEngine.Object selectedObject;
	
	[MenuItem("Assets/Create/C# Script Creation Wizard")]
	private static void CreateNewMonoBehaviour()
	{
		
		var window = EditorWindow.GetWindow<MonoBehaviourCreationWizard>();
		window.position = new Rect(100, 100, 450, 450);
		window.ShowPopup ();
		selectedObject = Selection.activeObject;
	}
	
	//To fix the two column layout issue
	[MenuItem("Assets/Create/C# Script Creation Wizard", true)]
	private static bool ValidateNewNoobScript()
	{
		return Selection.activeObject != null;
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
			else
			{
				
				//The highlighted or selected folder/file in the project window
				if(Directory.Exists (AssetDatabase.GetAssetPath (selectedObject )))
				{
					scriptFilePath = AssetDatabase.GetAssetPath (selectedObject);
					scriptFilePath = scriptFilePath + "/" + scriptName + ".cs";
				}
				else if(AssetDatabase.GetAssetPath (selectedObject) != null && !Directory.Exists (AssetDatabase.GetAssetPath (selectedObject )))
				{
					scriptFilePath = AssetDatabase.GetAssetPath (selectedObject);
					scriptFilePath = scriptFilePath.Substring (0, scriptFilePath.LastIndexOf ("/") + 1);
					scriptFilePath = scriptFilePath + scriptName + ".cs";
				}
				else
				{
					scriptFilePath = Application.dataPath;
				}
				
				WriteScript ();
				OpenScript ();
				FinishScriptCreation ();
			}
		}
		
		GUILayout.Label("* Generate empty definitions for these events: ");
		includedFunctions["Awake"] = EditorGUILayout.Toggle ("Awake", includedFunctions["Awake"]);
		includedFunctions["FixedUpdate"] = EditorGUILayout.Toggle ("FixedUpdate", includedFunctions["Start"]);	
		includedFunctions["Start"] = EditorGUILayout.Toggle ("Start", includedFunctions["Start"]);	
		includedFunctions["Update"] = EditorGUILayout.Toggle ("Update", includedFunctions["Update"]);
		includedFunctions["OnCollisionEnter2D"] = EditorGUILayout.Toggle ("OnCollisionEnter2D", includedFunctions["OnCollisionEnter2D"]);
		includedFunctions["OnTriggerEnter2D"] = EditorGUILayout.Toggle ("OnTriggerEnter2D", includedFunctions["OnTriggerEnter2D"]);
	}
	
	void InitializeFunctionEntryTable()
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
	
	void InitializeFunctionDefinitionTable()
	{
		if(functionDefinitions.Count > 0)
		{
			return;
		}
		
		functionDefinitions.Add ("Awake", 	new string[]	{"\tvoid Awake()",	"\t{",	"", "\t}"	});
		functionDefinitions.Add ("FixedUpdate", new string[]	{"\tvoid FixedUpdate()",	"\t{", 	"",	"\t}"	});
		functionDefinitions.Add ("Start", 	new string[]	{"\tvoid Start()",	"\t{", 	"",	"\t}"	});
		functionDefinitions.Add ("Update", 	new string[]	{"\tvoid Update()", "\t{", 	"",	"\t}"	});
		functionDefinitions.Add ("OnCollisionEnter2D", new String[] {"\tvoid OnCollisionEnter2D(Collision2D other)", "\t{",	"", "\t}"});
		functionDefinitions.Add ("OnTriggerEnter2D", new String[] {"\tvoid OnTriggerEnter2D(Collider2D other)", "\t{",	"", "\t}"});
		
	}
	
	void WriteScript()
	{
		StreamWriter sw = new StreamWriter(scriptFilePath);
		
		sw.WriteLine ("using UnityEngine;");
		sw.WriteLine ("using UnityEngine.UI;");
		sw.WriteLine ("using System.Collections;");
		
		if(noobScriptMode)
		{
			sw.WriteLine("using NoobsUnited");
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
		//sw.WriteLine ("");
		
		foreach(KeyValuePair <string, bool> kp in includedFunctions)
		{
			if(kp.Value)
			{
				foreach(string line in functionDefinitions[kp.Key])
				{
					sw.WriteLine(line);	
				}
			}
			//sw.WriteLine ("");
		}
		
		sw.WriteLine ("}");
		sw.Close();
	}
	
	void FinishScriptCreation()
	{
		scriptName = "";
		scriptFilePath = "";
		selectedObject = null;
		this.Close();
	}
	
	void OpenScript()
	{
		AssetDatabase.Refresh ();
		MonoScript script = AssetDatabase.LoadAssetAtPath (scriptFilePath, typeof(MonoScript)) as MonoScript;
		AssetDatabase.OpenAsset (script);
	}
	
}






