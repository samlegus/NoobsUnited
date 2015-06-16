using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using NoobsUnited.Noob2D;

public class ShootingControls : MonoBehaviour
{
	#region Properties

	/*	This is the equivelant of the "gameObject" property, it's included for easy access and unwanted auto-completion.*/
	private GameObject self { get { return gameObject;} }

	#endregion

	#region Public Variables

	public GameObject bulletPrefab;

	#endregion

	#region Unity Events

	/*	Update is called once EVERY frame. Most update logic goes here. */
	void Update()
	{
		bool shouldShoot = Input.GetButtonDown ("Fire1");

		if(shouldShoot == true)
		{

		}
	}


	#endregion
}
