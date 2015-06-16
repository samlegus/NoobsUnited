using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using NoobsUnited.Noob2D;

public class Bullet : MonoBehaviour
{
	#region Properties

	Rigidbody2D rigidbody2d{ get { return gameObject.GetComponent<Rigidbody2D>(); } }
	/*	This is the equivelant of the "gameObject" property, it's included for easy access and unwanted auto-completion.*/
	private GameObject self { get { return gameObject;} }

	#endregion

	#region Inspector Variables

	public float speed = 10f;
	public float lifetime = 10f;

	#endregion

	#region Unity Events

	/*	Start is called right before the first frame. Useful for initialization logic. */
	void Start()
	{
		Vector2 direction = self.transform.up * speed;
		rigidbody2d.SetVelocity(direction.x, direction.y);
		//Destroy(self, lifetime);
	}

	/*	OnCollisionEnter2D is called when this object touches another Collider2D.
		- It will not be called if the collider is marked as a trigger.
		- For moving collision to occur, this object must have a Collider2D AND a Rigidbody2D.
		- You can access information about what this object hit by using the "other" argument. */
	void OnCollisionEnter2D(Collision2D other)
	{
		Destroy (self);
	}

	#endregion
}
