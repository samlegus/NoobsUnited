using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using NoobsUnited.Noob2D;

public class StandardMovement : MonoBehaviour
{
	#region Properties

	/*	This is the equivelant of the "gameObject" property, it's included for easy access and unwanted auto-completion.*/
	private GameObject self { get { return gameObject;} }

	#endregion

	#region Inspector

	public float speed = 10f;

	#endregion

	#region Unity Events

	/*	Update is called once EVERY frame. Most update logic goes here. */
	void Update()
	{
		float horizontalMovement = Input.GetAxisRaw ("Horizontal") * speed;
		float verticalMovement = Input.GetAxisRaw ("Vertical") * speed;
		
		self.transform.Move (horizontalMovement, verticalMovement);
	}

	#endregion
}
