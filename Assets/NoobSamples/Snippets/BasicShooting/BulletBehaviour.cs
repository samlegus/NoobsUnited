using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using NoobsUnited.Noob2D;

public class BulletBehaviour : MonoBehaviour
{
	#region Public Variables

	public float speed = 10f;
	public float lifetime = 10f;
	public float damage = 3f;

	#endregion

	#region Unity Events
	
	void Start()
	{
		//self.transform.up is whatever way the bullet is facing, in 2D up is forward
		Vector2 direction = self.transform.up;
		rigidbody2d.velocity = direction * speed;
		
		//Bullet will automatically die after a set amount of time
		Destroy(self, lifetime); 
	}
	
	void OnCollisionEnter2D(Collision2D other)
	{
		//When the bullet hits something, it will send a "message" to the thing that it hit
		//	If that object has any script that contains a function called OnDamage (spelling counts!)...
		//	it will take the amount of damage we pass in as the argument
		
		other.gameObject.SendMessage ("OnDamage", damage );
		
		//Bullet automatically dies when it collides with anything
		Destroy (self);
	}

	#endregion

	#region Properties
	
	Rigidbody2D rigidbody2d { get { return gameObject.GetComponent<Rigidbody2D>(); } }
	/*	This is the equivelant of the "gameObject" property, it's included for easy access and unwanted auto-completion.*/
	private GameObject self { get { return gameObject;} }
	
	#endregion
}
