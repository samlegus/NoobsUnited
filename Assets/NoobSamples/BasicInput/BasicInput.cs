using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using NoobsUnited.Noob2D;

public class BasicInput : MonoBehaviour
{
	#region Properties

	/*	This is the equivelant of the "gameObject" property, it's included for easy access and unwanted auto-completion.*/
	private GameObject self { get { return gameObject;} }

	#endregion

	#region Unity Events

	/*	Update is called once EVERY frame. Most update logic goes here. */
	void Update()
	{
		//When we press the space bar, teleport our object to 0,0
		if(Input.GetKeyDown (KeyCode.Space))
		{
			self.transform.SetPosition (0f,0f);
		}

		//When we HOLD q, move our object forward.
		if(Input.GetKey(KeyCode.Q))
		{
			self.transform.Move (10f, 0);
		}

		//When we hold the left mouse button, rotate our object 5 degrees
		if(Input.GetMouseButton(0))
		{
			self.transform.Rotate2D (5f);
		}
	}

	#endregion
}
