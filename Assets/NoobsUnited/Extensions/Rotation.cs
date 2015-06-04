using UnityEngine;
using System.Collections;

/// <summary>
/// * 	NoobExtensions class is spread across multiple files
/// * 	This part of the class simplifies rotations and implements a LookAt2D function
///		because Unity2D does not currently implement a LookAt function for transforms
/// 	that functions in your typical 2D XY coordinate system
/// </summary>

//Author : Sam Legus
//Last Updated: 5/21/2015

//Vector2 class Documentation : http://docs.unity3d.com/ScriptReference/Vector2.html
//GameObject class Documentation: http://docs.unity3d.com/ScriptReference/GameObject.html
//Unity Extension Methods Tutorial: https://unity3d.com/learn/tutorials/modules/intermediate/scripting/extension-methods

//TODO: Common Quaternion rotation functions
namespace NoobsUnited
{
	public static partial class NoobExtensions
	{
		//Solution from: http://answers.unity3d.com/questions/585035/lookat-2d-equivalent-.html
		//Wouldn't wanna use this in combination with the scale facing functions.
		//Still, this is here for future use.
		
		//TODO: Find that other more awesome solution to avoid the Atan2 function call.
		
		//Makes an object face another
		public static void LookAt2D(this GameObject gameObj, GameObject target)
		{
			Vector2 ourPosition = gameObj.transform.position;
			Vector2 lookPosition = target.transform.position;
			Vector2 difference = lookPosition - ourPosition;
			
			difference.Normalize();
			
			float zRotation = Mathf.Atan2(difference.y, difference.x);
			float zRotationDegrees = zRotation * Mathf.Rad2Deg;
			
			gameObj.transform.rotation = Quaternion.Euler(0f, 0f, zRotationDegrees - 90);
		}
		
		//Makes an object face another
		public static void LookAt2D(this GameObject gameObj, float x, float y)
		{
			Vector2 ourPosition = gameObj.transform.position;
			Vector2 lookPosition = new Vector2(x, y);
			Vector2 difference = lookPosition - ourPosition;
			
			difference.Normalize();
			
			float zRotation = Mathf.Atan2(difference.y, difference.x);
			float zRotationDegrees = zRotation * Mathf.Rad2Deg;
			
			gameObj.transform.rotation = Quaternion.Euler(0f, 0f, zRotationDegrees - 90);
		}
		
		//Overloaded LookAt2D that takes a Vector2 instead of a GameObject
		public static void LookAt2D(this GameObject gameObj, Vector2 lookPosition)
		{
			Vector2 ourPosition = gameObj.transform.position;
			Vector2 difference = lookPosition - ourPosition;
			
			difference.Normalize();
			
			float zRotation = Mathf.Atan2(difference.y, difference.x);
			float zRotationDegrees = zRotation * Mathf.Rad2Deg;
			
			gameObj.transform.rotation = Quaternion.Euler(0f, 0f, zRotationDegrees - 90);
		}
		
		// For later maybe. Keep as much crap as possible in gameObject
		/*
	
	//Makes an object's transform face a gameObject
	public static void LookAt2D(this Transform trans, GameObject target)
	{
		Vector2 ourPosition = trans.position;
		Vector2 lookPosition = target.transform.position;
		Vector2 difference = lookPosition - ourPosition;
		
		difference.Normalize();
		
		float zRotation = Mathf.Atan2(difference.y, difference.x);
		float zRotationDegrees = zRotation * Mathf.Rad2Deg;
		
		trans.rotation = Quaternion.Euler(0f, 0f, zRotationDegrees - 90);
	}
	
	//Makes an object's transform look at position, takes two floats
	public static void LookAt2D(this Transform trans, float x, float y)
	{
		Vector2 ourPosition = trans.position;
		Vector2 lookPosition = new Vector2(x, y);
		Vector2 difference = lookPosition - ourPosition;
		
		difference.Normalize();
		
		float zRotation = Mathf.Atan2(difference.y, difference.x);
		float zRotationDegrees = zRotation * Mathf.Rad2Deg;
		
		trans.rotation = Quaternion.Euler(0f, 0f, zRotationDegrees - 90);
	}
	
	//Overloaded LookAt2D, takes a Vector2 instead
	public static void LookAt2D(this Transform trans, Vector2 lookPosition)
	{
		Vector2 ourPosition = trans.position;
		Vector2 difference = lookPosition - ourPosition;
		
		difference.Normalize();
		
		float zRotation = Mathf.Atan2(difference.y, difference.x);
		float zRotationDegrees = zRotation * Mathf.Rad2Deg;
		
		trans.rotation = Quaternion.Euler(0f, 0f, zRotationDegrees - 90);
	}
	
	*/
		
	}
	
}


