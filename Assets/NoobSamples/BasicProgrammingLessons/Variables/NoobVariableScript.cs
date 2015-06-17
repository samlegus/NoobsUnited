using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using NoobsUnited;
using NoobsUnited.Noob2D;

public class NoobVariableScript : MonoBehaviour
{
	#region Public Variables

	public bool alive = true;
	
	#endregion

	#region Private Variables
	
	int a = 5;
	int b = 3;

	#endregion

	#region Unity Events

	void Start()
	{
		int c = a + b;
		Debug.Log (c);
		
		string myName = self.name;
		Debug.Log (myName);
		
		string greetings = "Hello!";
		Debug.Log (greetings);
		
		Debug.Log ("Hello World!");
	}
	
	void Update()
	{
		if(alive == false)
		{
			Destroy (self);
		}
	}

	#endregion

	#region My Functions

	#endregion

	#region Properties
	
	/*	This is the equivelant of the "gameObject" property, it's included for easy access and unwanted auto-completion.*/
	private GameObject self { get { return gameObject;} }
	
	#endregion
}
