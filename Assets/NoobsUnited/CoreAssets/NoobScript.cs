using UnityEngine;
using UnityEditor;
using System.Collections;
using NoobsUnited;

public class NoobScript : MonoBehaviour 
{
	public bool DebugTextInfo = false;
	public bool DebugPhysicsGizmos = false;
	
	public GameObject self 
	{
		get { return gameObject;}
	}
	
	public static GameObject Clone(GameObject gameObj, Vector2 position)
	{
		return Instantiate (gameObj, position, Quaternion.identity) as GameObject;
	}

	public static GameObject Clone(GameObject gameObj, Vector2 position, Quaternion rotation)
	{
		return Instantiate (gameObj, position, rotation) as GameObject;
	}
	
	void OnGUI()
	{
		Vector3 offsetPositionWorldSpace = transform.position;//- (Vector3.down * (transform.localScale.y / 2f));
		offsetPositionWorldSpace.y *= -1f;
		Vector3 positionInScreenSpace = Camera.main.WorldToScreenPoint (offsetPositionWorldSpace);
		GUI.Label(	new Rect(	positionInScreenSpace.x, positionInScreenSpace.y, 150, 30),
		          				gameObject.name + "( " + transform.position.x + " , " + transform.position.y + " )" );
	}

	void OnDrawGizmos()
	{
		Gizmos.DrawWireSphere (transform.position, transform.localScale.x);
	}
}
