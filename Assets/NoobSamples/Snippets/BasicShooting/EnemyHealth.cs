using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using NoobsUnited;
using NoobsUnited.Noob2D;

public class EnemyHealth : MonoBehaviour
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

	void OnDamage(int damage)
	{
		health -= damage;
	}

	#endregion

	#region Properties

	/*	This is the equivelant of the "gameObject" property, it's included for easy access and unwanted auto-completion.*/
	private GameObject self { get { return gameObject;} }

	#endregion
}
