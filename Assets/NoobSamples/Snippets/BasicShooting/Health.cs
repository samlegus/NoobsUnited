using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using NoobsUnited;
using NoobsUnited.Noob2D;

public class Health : MonoBehaviour
{
	#region Public Variables

	public int health = 10;

	#endregion

	#region Private Variables

	#endregion

	#region Unity Events

	/*	Update is called once EVERY frame. Most update logic goes here. */
	void Update()
	{
		if(health <= 0)
		{
			Destroy (self);
		}
	}

	/*	OnCollisionEnter2D is called when this object touches another Collider2D.
		- It will not be called if the collider is marked as a trigger.
		- For moving collision to occur, this object must have a Collider2D AND a Rigidbody2D.
		- You can access information about what this object hit by using the "other" argument. */
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Bullet")
		{
			health--;
		}
	}

	#endregion

	#region Properties

	/*	This is the equivelant of the "gameObject" property, it's included for easy access and unwanted auto-completion.*/
	private GameObject self { get { return gameObject;} }

	#endregion
}
