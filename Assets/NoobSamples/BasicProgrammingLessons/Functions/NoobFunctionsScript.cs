using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using NoobsUnited;
using NoobsUnited.Noob2D;

public class NoobFunctionsScript : MonoBehaviour
{
	#region Public Variables
	
	public Transform boundary;

	#endregion

	#region Private Variables

	#endregion

	#region Unity Events

	/*	Start is called right before the first frame. Useful for initialization logic. */
	void Start()
	{
		int n = Add (5, 4);
		Debug.Log (n);
	}

	/*	Update is called once EVERY frame. Most update logic goes here. */
	void Update()
	{
		//Move ();
	}

	#endregion

	#region My Functions
	
	void Move()
	{
		self.transform.Move (0,1f);
		if( IsPassedBoundary() == false)
		{
			Destroy (self);
		}
	}
	
	int Add(int a, int b)
	{
		int c = a + b;
		return c;
	}
	
	bool IsPassedBoundary()
	{
		if(self.transform.position.y > boundary.position.y)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	
	#endregion

	#region Properties

	/*	This is the equivelant of the "gameObject" property, it's included for easy access and unwanted auto-completion.*/
	private GameObject self { get { return gameObject;} }

	#endregion
}
