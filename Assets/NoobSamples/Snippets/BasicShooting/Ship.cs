using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using NoobsUnited.Noob2D;

public class Ship : MonoBehaviour
{
	#region Public Variables

	public float speed = 5f;
	public GameObject bulletPrefab;

	#endregion

	#region Unity Events

	/*	Update is called once EVERY frame. Most update logic goes here. */
	void Update()
	{
		//Shooting
		bool shouldShoot = Input.GetButtonDown ("Fire1");
		if(shouldShoot == true)
		{
			this.Clone (bulletPrefab, self.transform.position, self.transform.rotation, true);
		}

		//Movement
		float horizontalMovement = Input.GetAxisRaw ("Horizontal") * speed;
		float verticalMovement = Input.GetAxisRaw ("Vertical") * speed;

		self.transform.Move (horizontalMovement, verticalMovement);
	}


	#endregion

	#region Properties
	
	/*	This is the equivelant of the "gameObject" property, it's included for easy access and unwanted auto-completion.*/
	private GameObject self { get { return gameObject;} }
	
	#endregion
}
