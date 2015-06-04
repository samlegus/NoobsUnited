using UnityEngine;
using System.Collections;
using NoobsUnited;

public class Racket : NoobScript
{
	//Put variables that you want to set from the inspector inside this region
	#region Inspector Variables

	public float speed = 10f;
	public string movementAxisName;  

	#endregion
	
	//Put variables that you do not want to set from the inspector inside this region
	#region Private Variables
	
	#endregion
	
	//All functions inside this region are automatically called by Unity
	#region Unity Events
	
	//Any code written inside of Start will be called once when the object is created.
	void Start()
	{

	}
	
	//Any code written instead of Update will be called every time the application updates
	void Update()
	{
		float verticalMovement = Input.GetAxisRaw (movementAxisName) * speed;
		self.Move (0, verticalMovement);
	}
	
	//Any code written inside of OnCollisionEnter2D will be called when this 2D object collides with another
	void OnCollisionEnter2D(Collision2D other)
	{

	}
	
	#endregion
	
	//Put any functions that you write yourself inside this region
	#region My Functions
	
	#endregion
}
