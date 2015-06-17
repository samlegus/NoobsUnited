using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using NoobsUnited;
using NoobsUnited.Noob2D;

public class ShipController : MonoBehaviour
{
	#region Public Variables

	public float speed = 5f;
	public float laserDamage = 1f;
	public float laserDistance = 3f;
	public GameObject bulletPrefab;
	public Transform firingPoint;

	#endregion

	#region Unity Events

	/*	Update is called once EVERY frame. Most update logic goes here. */
	void Update()
	{
		//Projectile shooting
		bool shouldShootBullet = Input.GetButtonDown ("Fire1");
		
		if(shouldShootBullet == true)
		{
			this.Clone(bulletPrefab, self.transform.position, self.transform.rotation, true);
		}
		
		//Laser shooting aka "Hitscan" weapon
		//Make sure gizmos are turned on in the editor
		
		bool shouldShootLaser = Input.GetButton ("Fire2");
		
		if(shouldShootLaser == true)
		{
			RaycastHit2D laserHit;
			Vector2 laserStart = firingPoint.position;
			Vector2 laserEnd = firingPoint.position + (self.transform.up * laserDistance);
			
			laserHit = VPhysics2D.Linecast (laserStart, laserEnd);
			
			if(laserHit.collider != null) //Collider will be == null if the laser doesn't hit anything
			{
				//laserEnd = laserHit.point;
				laserHit.collider.gameObject.SendMessage ("OnDamage", laserDamage );
			}
			
			//Only works with gizmos on!
			Debug.DrawLine (laserStart, laserEnd);
		}
		
		//Movement
		float horizontalMovement = Input.GetAxisRaw ("Horizontal") * speed;
		float verticalMovement = Input.GetAxisRaw ("Vertical") * speed;

		self.transform.Move (horizontalMovement, verticalMovement);
	}

	#endregion
	
	#region Properties
	
	Rigidbody2D rigidbody2d { get { return gameObject.GetComponent<Rigidbody2D>(); } }
	/*	This is the equivelant of the "gameObject" property, it's included for easy access and unwanted auto-completion.*/
	private GameObject self { get { return gameObject;} }
	
	#endregion


}
