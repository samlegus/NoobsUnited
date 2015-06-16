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
	
	static bool monoBehaviourMode = true;
	static bool openScriptAfterCreation = true;
	static bool enableCodeRegions = true;
	static bool enableNoobComments = true;

	static Dictionary<StreamWritableMethod, bool> potentialFunctions = new Dictionary<StreamWritableMethod, bool>();
	static Dictionary<StreamWritableComponent, bool> potentialComponentReferences = new Dictionary<StreamWritableComponent, bool>();
	static Dictionary<StreamWritableProperty, bool> potentialProperties = new Dictionary<StreamWritableProperty, bool>();
	static Dictionary<StreamWritableScriptObject, string> potentialComments = new Dictionary<StreamWritableScriptObject, string>();
	//static Dictionary<string, bool> potentialCodeRegions = new Dictionary<string, bool>();

	static UnityEngine.Object selectedObject;
	static string defaultScriptDirectory = "Assets/MyGame/Scripts";

	private static MonoBehaviourCreationWizard window
	{
		get { return EditorWindow.GetWindow<MonoBehaviourCreationWizard>();}
	}

	[MenuItem("Assets/Create/C# Script Creation Wizard")]
	private static void OpenMonoWizardFromContextMenu()
	{
		window.position = new Rect(100, 100, 450, 550);
		window.title = "Script Wizard";
		window.ShowPopup ();
		selectedObject = Selection.activeObject;
		RefreshWrittenContent();
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
		RefreshWrittenContent();
		SetFilePathFromMenuBar();
	}

	[MenuItem("Noobs United/C# Script Creation Wizard", true)]
	private static bool ValidateMonoWizardFromMenuBar()
	{
		return Directory.Exists (defaultScriptDirectory);
	}

	
	void OnGUI()
	{
		GUIStyle headerStyle = new GUIStyle();
		headerStyle.fontStyle = FontStyle.Bold;

		GUILayout.Label ("");
		GUILayout.Label (" Script Mode: ", headerStyle);
		{
			monoBehaviourMode = EditorGUILayout.Toggle("* MonoBehaviour", monoBehaviourMode);
		}

		GUILayout.Label ("");
		{
			GUILayout.Label (" Script Name: ", headerStyle);
			scriptName = EditorGUILayout.TextField (scriptName);
			GUILayout.Label ("* Name may have letters only.");
		}

		
		GUILayout.Label("");
		GUILayout.Label(" Generate empty function definitions for these events: ", headerStyle);
		{
			StreamWritableMethod[] methods = new StreamWritableMethod[potentialFunctions.Count];
			potentialFunctions.Keys.CopyTo (methods, 0);
			foreach( StreamWritableMethod func in methods)
			{
				potentialFunctions[func] = EditorGUILayout.Toggle ("* " +func.name, potentialFunctions[func]);
			}
		}

		GUILayout.Label("");
		GUILayout.Label(" Generate properties for: ", headerStyle);
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
		GUILayout.Label(" Other Options:", headerStyle);
		enableCodeRegions = EditorGUILayout.Toggle ("* Code regions", enableCodeRegions);
		enableNoobComments = EditorGUILayout.Toggle ("* Noob comments", enableNoobComments); 
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

			if(System.String.IsNullOrEmpty(scriptName))
			{
				EditorUtility.DisplayDialog ("Invalid name",
				                             "Please enter a valid name your script!",
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

		GUILayout.Label ("");
		GUILayout.Label ("Script being saved to: " + scriptFullFilePath);
	}


	static void RefreshWrittenContent()
	{
		potentialFunctions.Clear ();

		StreamWritableMethod awake = new StreamWritableMethod("void", "Awake");
		potentialFunctions.Add (awake , false);
		potentialComments.Add (awake, "/*\tAwake is called first! It is commonly use to cache component references. */");

		StreamWritableMethod start = new StreamWritableMethod("void", "Start");
		potentialFunctions.Add (start , true);
		potentialComments.Add(start, "/*\tStart is called right before the first frame. Useful for initialization logic. */");

		StreamWritableMethod update = new StreamWritableMethod("void", "Update");
		potentialFunctions.Add (update, true);
		potentialComments.Add (update, "/*\tUpdate is called once EVERY frame. Most update logic goes here. */");

		StreamWritableMethod fixedUpdate = new StreamWritableMethod("void", "FixedUpdate");
		potentialFunctions.Add (fixedUpdate, false);
		potentialComments.Add (fixedUpdate, "/*\tFixedUpdate is called every x seconds, where x is your project's Fixed Time Step." +
		                       				System.Environment.NewLine + "\t\t- Any code that messes with Rigidbodies should go in here. */");

		StreamWritableMethod onCollisionEnter2D = new StreamWritableMethod("void", "OnCollisionEnter2D", "Collision2D other");
		potentialFunctions.Add (onCollisionEnter2D, false);
		potentialComments.Add (onCollisionEnter2D, "/*\tOnCollisionEnter2D is called when this object touches another Collider2D." +
		                        System.Environment.NewLine + "\t\t- It will not be called if the collider is marked as a trigger." +
		                        System.Environment.NewLine + "\t\t- For moving collision to occur, this object must have a Collider2D AND a Rigidbody2D." +
		                        System.Environment.NewLine + "\t\t- You can access information about what this object hit by using the \"other\" argument. */");

		StreamWritableMethod onTriggerEnter2D = new StreamWritableMethod("void", "OnTriggerEnter2D", "Collider2D other");
		potentialFunctions.Add (onTriggerEnter2D, false);	
		potentialComments.Add (onTriggerEnter2D, "/*\tOnTriggerEnter2D is called when this object touches another Collider2D that is marked as a trigger." +
		                       System.Environment.NewLine + "\t\t- It will not be called if the collider is NOT marked as a trigger." +
		                       System.Environment.NewLine + "\t\t- For moving collision to occur, this object must have a Collider2D AND a Rigidbody2D." +
		                       System.Environment.NewLine + "\t\t- You can access the collider this object touched by using the \"other\" argument. */");

		potentialComponentReferences.Clear ();
		StreamWritableComponent rb2D = new StreamWritableComponent("Rigidbody2D" , "rigidbody2d");
		potentialComments.Add (rb2D, "/*\tRigidbody2D allows and controls 2D Physics simulation.*/");
		potentialComponentReferences.Add (rb2D, false);

		StreamWritableComponent sr = new StreamWritableComponent("SpriteRenderer", "spriteRenderer");
		potentialComments.Add (sr, "/*\tSpriteRenderer allows and controls typical image(jpg, png etc) representation.*/");
		potentialComponentReferences.Add (sr, false);

		StreamWritableComponent collider = new StreamWritableComponent("Collider2D", "collider2d");
		potentialComments.Add (collider, "/*\tCollider2D allows other objects to collide with this object.*/");
		potentialComponentReferences.Add (collider, false);

		potentialProperties.Clear ();
		StreamWritableProperty self = new StreamWritableProperty("GameObject", "self", "gameObject", true);
		potentialProperties.Add (self, true);
		potentialComments.Add (self, "/*\tThis is the equivelant of the \"gameObject\" property, it's included for easy access and unwanted auto-completion.*/");
	}



	static void SetFilePathFromMenuBar()
	{
		if(Directory.Exists (defaultScriptDirectory))
		{
			scriptDirectoryPath = defaultScriptDirectory;
			return;
		}

		scriptDirectoryPath = Application.dataPath;
	}

	static void SetFilePathFromContextMenu()
	{
		//The highlighted or selected folder/file in the project window
		if(Directory.Exists (AssetDatabase.GetAssetPath (selectedObject )))
		{
			scriptDirectoryPath = AssetDatabase.GetAssetPath (selectedObject);
			return;
		}
		if(AssetDatabase.GetAssetPath (selectedObject) != null && !Directory.Exists (AssetDatabase.GetAssetPath (selectedObject )))
		{
			scriptDirectoryPath = AssetDatabase.GetAssetPath (selectedObject);
			//scriptDirectoryPath = scriptDirectoryPath.Substring (0, scriptDirectoryPath.LastIndexOf ("/") + 1);
			return;
		}
		if(Directory.Exists (defaultScriptDirectory))
		{
			scriptDirectoryPath = defaultScriptDirectory;
			return;
		}

		scriptDirectoryPath = Application.dataPath;

	}



	static void WriteScript()
	{
		AssetDatabase.Refresh ();

		StreamWriter sw = new StreamWriter(scriptFullFilePath);
		
		sw.WriteLine ("using UnityEngine;");
		sw.WriteLine ("using UnityEngine.UI;");
		sw.WriteLine ("using System.Collections;");
		sw.WriteLine ("using NoobsUnited;");
		sw.WriteLine ("using NoobsUnited.Noob2D;");

		sw.WriteLine ();
		sw.WriteLine ("public class " + scriptName + " : MonoBehaviour");
		sw.WriteLine ("{");
		
		if(enableCodeRegions)
		{
			sw.WriteLine ("\t#region Public Variables");
			sw.WriteLine ();
			sw.WriteLine ("\t#endregion");
			sw.WriteLine ();
			sw.WriteLine ("\t#region Private Variables");
			sw.WriteLine ();
			sw.WriteLine ("\t#endregion");
			sw.WriteLine ();
			sw.WriteLine ("\t#region Unity Events");
		}

		foreach(StreamWritableMethod func in potentialFunctions.Keys)
		{
			if(potentialFunctions[func])
			{
				sw.WriteLine ();
				if(enableNoobComments && potentialFunctions.ContainsKey(func))
				{
					sw.WriteLine ("\t" + potentialComments[func]);
				}
				func.OnStreamWrite(sw);
			}
		}

		if(enableCodeRegions)
		{
			if(potentialFunctions.Keys.Count > 0)
			{
				sw.WriteLine ();
			}

			sw.WriteLine ("\t#endregion");
			sw.WriteLine ();
			sw.WriteLine ("\t#region Properties");
			if(potentialComponentReferences.Keys.Count > 0)
			{
				sw.WriteLine ();
			}
		}

		foreach(StreamWritableComponent comp in potentialComponentReferences.Keys)
		{
			if(potentialComponentReferences[comp])
			{
				if(enableNoobComments && potentialComments.ContainsKey (comp))
				{
					sw.WriteLine ("\t" + potentialComments [comp]);
				}
				comp.OnStreamWrite(sw);
			}
		}
		
		foreach(StreamWritableProperty prop in potentialProperties.Keys)
		{
			if(potentialProperties[prop])
			{
				if(enableNoobComments && potentialComments.ContainsKey (prop))
				{
					sw.WriteLine ("\t" + potentialComments[prop]);
				}
				prop.OnStreamWrite(sw);
			}
		}
		
		if(enableCodeRegions)
		{
			if(potentialComponentReferences.Keys.Count > 0 || potentialProperties.Keys.Count > 0)
			{
				sw.WriteLine ();
			}
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
		if(openScriptAfterCreation)
		{
			AssetDatabase.OpenAsset (script);
		}
	}
	
}






