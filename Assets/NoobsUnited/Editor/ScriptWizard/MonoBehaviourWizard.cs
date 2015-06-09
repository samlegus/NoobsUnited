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
	static bool enableCodeRegions = false;

	static Dictionary<StreamWritableMethod, bool> potentialFunctions = new Dictionary<StreamWritableMethod, bool>();
	static Dictionary<StreamWritableComponent, bool> potentialComponentReferences = new Dictionary<StreamWritableComponent, bool>();
	static Dictionary<StreamWritableProperty, bool> potentialProperties = new Dictionary<StreamWritableProperty, bool>();

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
		window.title = "Script Wizard";
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
		window.name = "Script Wizard";
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
		if(potentialFunctions.Count == 0)
		{
			RefreshWrittenContent();
		}

		GUILayout.Label ("Script Mode: ");
		{
			noobScriptMode = EditorGUILayout.Toggle("* NoobScript", !monoBehaviourMode);
			monoBehaviourMode = EditorGUILayout.Toggle("* MonoBehaviour", !noobScriptMode);
		}

		GUILayout.Label ("");
		{
			scriptName = EditorGUILayout.TextField ("Script name:", scriptName);
			GUILayout.Label ("* Name may have letters only.");
		}

		
		GUILayout.Label("");
		GUILayout.Label("Generate empty definitions for these events: ");
		{
			StreamWritableMethod[] methods = new StreamWritableMethod[potentialFunctions.Count];
			potentialFunctions.Keys.CopyTo (methods, 0);
			foreach( StreamWritableMethod func in methods)
			{
				potentialFunctions[func] = EditorGUILayout.Toggle ("* " +func.name, potentialFunctions[func]);
			}
		}

		GUILayout.Label("");
		GUILayout.Label("Generate properties for: ");
		{
			StreamWritableComponent[] components = new StreamWritableComponent[potentialComponentReferences.Count];
			potentialComponentReferences.Keys.CopyTo (components, 0);
			foreach( StreamWritableComponent comp in components)
			{
				potentialComponentReferences[comp] = EditorGUILayout.Toggle ("* " + comp.typeName, potentialComponentReferences[comp]);
			}
			
			StreamWritableProperty[] properties = new StreamWritableProperty[potentialProperties.Count];
			potentialProperties.Keys.CopyTo (properties, 0);
			foreach( StreamWritableProperty property in properties)
			{
				potentialProperties[property] = EditorGUILayout.Toggle ("* " + property.typeName, potentialProperties[property]);
			}
		}

		GUILayout.Label("");
		GUILayout.Label("Other Options:");
		enableCodeRegions = EditorGUILayout.Toggle ("* Generate code regions", enableCodeRegions);
		openScriptAfterCreation = EditorGUILayout.Toggle ("* Open after creation", openScriptAfterCreation);
		
		
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
			RefreshWrittenContent();
		}


		
	}

	static void RefreshWrittenContent()
	{
		potentialFunctions.Clear ();
	
		potentialFunctions.Add (new StreamWritableMethod("void", "Awake") , false);
		potentialFunctions.Add (new StreamWritableMethod("void", "Start") , true);
		potentialFunctions.Add (new StreamWritableMethod("void", "Update"), true);
		potentialFunctions.Add (new StreamWritableMethod("void", "FixedUpdate"), false);
		potentialFunctions.Add (new StreamWritableMethod("void", "OnCollisionEnter2D", "Collision2D other"), false);
		potentialFunctions.Add (new StreamWritableMethod("void", "OnTriggerEnter2D", "Collider2D other"), false);	

		potentialComponentReferences.Clear ();

		potentialComponentReferences.Add (new StreamWritableComponent("Rigidbody2D" , "rigidbody2D"), false);
		potentialComponentReferences.Add (new StreamWritableComponent("SpriteRenderer", "spriteRenderer"), false);
		potentialComponentReferences.Add (new StreamWritableComponent("Collider2D", "collider2D"), false);

		potentialProperties.Clear ();
		potentialProperties.Add (new StreamWritableProperty("GameObject", "self", "gameObject", true), true);
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
		
		if(enableCodeRegions)
		{
			sw.WriteLine ("\t#region Properties");
			sw.WriteLine ();
		}
		else
		{
			sw.WriteLine ();
		}

		foreach(StreamWritableComponent comp in potentialComponentReferences.Keys)
		{
			if(potentialComponentReferences[comp])
			{
				comp.OnStreamWrite(sw);
			}
		}

		foreach(StreamWritableProperty prop in potentialProperties.Keys)
		{
			if(potentialProperties[prop])
			{
				prop.OnStreamWrite(sw);
			}
		}

		if(enableCodeRegions)
		{
			sw.WriteLine ();
			sw.WriteLine ("\t#endregion");
		}

		if(enableCodeRegions)
		{
			sw.WriteLine ();
			sw.WriteLine ("\t#region Unity Events");
		}

		foreach(StreamWritableMethod func in potentialFunctions.Keys)
		{
			if(potentialFunctions[func])
			{
				sw.WriteLine ();
				func.OnStreamWrite(sw);
			}
		}
		if(enableCodeRegions)
		{
			sw.WriteLine ();
			sw.WriteLine ("\t#endregion");
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






