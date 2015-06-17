using UnityEngine;
using System.Collections;
using NoobsUnited;

namespace NoobsUnited
{
	public static partial class UnityExtensions
	{	
		public static GameObject Clone(this MonoBehaviour script, GameObject obj, Vector2 position)
		{
			return GameObject.Instantiate(obj, position, Quaternion.identity) as GameObject;
		}
		
		public static GameObject Clone(this MonoBehaviour script, GameObject obj, Vector2 position, Quaternion rotation)
		{
			return GameObject.Instantiate(obj, position, rotation) as GameObject;
		}
		
		public static GameObject Clone(this MonoBehaviour script, GameObject obj, Vector2 position, bool ignoreOwnCollider)
		{
			GameObject clone = GameObject.Instantiate(obj, position, Quaternion.identity) as GameObject;
			if(ignoreOwnCollider)
			{
				Physics2D.IgnoreCollision (script.gameObject.GetComponent<Collider2D>(), clone.GetComponent<Collider2D>());
			}
			return clone;
		}
		
		public static GameObject Clone(this MonoBehaviour script, GameObject obj, Vector2 position, Quaternion rotation, bool ignoreOwnCollider)
		{
			GameObject clone = GameObject.Instantiate(obj, position, Quaternion.identity) as GameObject;
			if(ignoreOwnCollider)
			{
				Physics2D.IgnoreCollision (script.gameObject.GetComponent<Collider2D>(), clone.GetComponent<Collider2D>());
			}
			return clone;
		}
	}
}
