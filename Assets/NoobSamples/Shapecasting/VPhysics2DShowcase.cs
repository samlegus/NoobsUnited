using UnityEngine;
using System;
using System.Collections;
using NoobsUnited.Swizzle;


public class VPhysics2DShowcase : MonoBehaviour 
{
	Action shapeCastMethod;
	Vector2 dir = Vector2.right;
	
	// Use this for initialization
	void Start () 
	{
		shapeCastMethod = () => {VPhysics2D.CircleCast (transform.position, 1f, dir);};
	}
	
	// Update is called once per frame
	void Update () 
	{
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		
		transform.Translate ( new Vector2(h,v) * Time.deltaTime * 5f);
		
		DetermineDirection();
		DetermineFunctionToUse();
		
		if(Input.GetButton ("Fire1"))
		{
			shapeCastMethod();
		}
	}
	
	void FixedUpdate()
	{
	
	}
	
	void OnGUI()
	{
		GUI.TextArea ( new Rect(25, 25, 200, 50), "WSAD to Move");
		GUI.TextArea ( new Rect(25, 75, 200, 50), "Hold left click to ShapeCast");
		GUI.TextArea ( new Rect(25, 125, 200, 50), "Arrows to change ShapeCast direction");
		GUI.TextArea ( new Rect(25, 175, 200, 150), "Press Number Hotkey to change physics function Type:\n 1 = CircleCast\n 2 = CircleCastAll\n 3 = Raycast\n 4 = RaycastAll");
	}
	
	void DetermineDirection()
	{
		if(Input.GetKeyDown (KeyCode.LeftArrow))
		{
			dir = Vector2.right * -1f;
		}
		if(Input.GetKeyDown (KeyCode.RightArrow))
		{
			dir = Vector2.right;
		}
		if(Input.GetKeyDown (KeyCode.UpArrow))
		{
			dir = Vector2.up;
		}
		if(Input.GetKeyDown (KeyCode.DownArrow))
		{
			dir = Vector2.up * -1f;
		}
	}
	
	void DetermineFunctionToUse()
	{
		if(Input.GetKeyDown (KeyCode.Alpha1))
		{
			shapeCastMethod = () => {VPhysics2D.CircleCast(transform.position, 1f, dir, 10f);};
		}
		if(Input.GetKeyDown (KeyCode.Alpha2))
		{
			shapeCastMethod = () => {VPhysics2D.CircleCastAll(transform.position, 1f, dir, 10f);};
		}
		if(Input.GetKeyDown (KeyCode.Alpha3))
		{
			shapeCastMethod = () => {VPhysics2D.Raycast (transform.position.xy() + dir * (transform.localScale.y * .51f), dir, 10f);};
		}
		if(Input.GetKeyDown (KeyCode.Alpha4))
		{
			shapeCastMethod = () => {VPhysics2D.RaycastAll (transform.position.xy() + dir * (transform.localScale.y * .51f), dir, 10f);};
		}
	}
	
}
