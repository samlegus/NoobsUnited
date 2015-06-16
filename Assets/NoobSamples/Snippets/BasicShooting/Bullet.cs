using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using NoobsUnited.Noob2D;

public class Bullet : MonoBehaviour
{
	#region Public Variables

	public float speed = 10f;
	public float lifetime = 10f;

	#endregion

	#region Unity Events
	
	void Start()
	{
		Vector2 direction = self.transform.up * speed;
		rigidbody2d.SetVelocity(direction.x, direction.y);
		Destroy(self, lifetime); 
	}
	
	void OnCollisionEnter2D(Collision2D other)
	{
		Destroy (self);
	}

	#endregion

	#region Properties
	
	Rigidbody2D rigidbody2d{ get { return gameObject.GetComponent<Rigidbody2D>(); } }
	/*	This is the equivelant of the "gameObject" property, it's included for easy access and unwanted auto-completion.*/
	private GameObject self { get { return gameObject;} }
	
	#endregion
}
