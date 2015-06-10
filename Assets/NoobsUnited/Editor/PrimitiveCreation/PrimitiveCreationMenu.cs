using UnityEngine;
using UnityEditor;
using System.Collections;

public class PrimitiveCreationMenu
{
	[MenuItem("GameObject/2D Object/Circle")]
	private static void AddCircleToScene()
	{
		GameObject circle = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		GameObject.DestroyImmediate(circle.GetComponent<SphereCollider>());
		circle.AddComponent(typeof(CircleCollider2D));
		circle.name = "Circle";
	}

	[MenuItem("GameObject/2D Object/Square")]
	private static void AddSquareToScene()
	{
		GameObject square = GameObject.CreatePrimitive (PrimitiveType.Cube);
		GameObject.DestroyImmediate(square.GetComponent<BoxCollider>());
		square.AddComponent(typeof(BoxCollider2D));
		square.name = "Square";
	}	
}