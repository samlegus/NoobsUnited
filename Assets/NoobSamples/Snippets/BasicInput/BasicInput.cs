using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using NoobsUnited.Noob2D;

public class BasicInput : MonoBehaviour
{

	#region Public Variables
	
	public KeyCode upKey;
	public KeyCode downKey;
	public KeyCode leftKey;
	public KeyCode rightKey;
	
	public float speed;

	#endregion
	
	#region Unity Events

	/*	Update is called once EVERY frame. Most update logic goes here. */
	void Update()
	{
		//Input.GetKey() is a function that returns a bool. It returns true if the key is held, false if it is not.
		//We can store the value of Input.GetKey() in a boolean variable and give that variable a name that makes sense.
		
		bool moveLeft = Input.GetKey(leftKey);
		bool moveRight = Input.GetKey (rightKey);
		bool moveUp = Input.GetKey (upKey);
		bool moveDown = Input.GetKey (downKey);
		
		if(moveLeft == true)
		{
			self.transform.Move (-speed, 0f);
		}
		if(moveRight == true)
		{
			self.transform.Move (speed, 0f);
		}
		if(moveUp == true)
		{
			self.transform.Move (0f, speed);
		}
		if(moveDown == true)
		{
			self.transform.Move (0f, -speed);
		}
		
		//Input.GetMouseButtonDown() works the same way as GetKey except it takes an int. 0 = left mb, 1 = right mb, 2 = middle mb
		bool rotateClockwise = Input.GetMouseButton (0);
		
		if(rotateClockwise == true)
		{
			transform.Rotate2D (5f);
		}
		
		
	}

	#endregion
	
	#region Properties
	
	/*	This is the equivelant of the "gameObject" property, it's included for easy access and unwanted auto-completion.*/
	private GameObject self { get { return gameObject;} }
	
	#endregion
}
