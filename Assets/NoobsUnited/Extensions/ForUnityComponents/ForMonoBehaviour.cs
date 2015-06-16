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
	}
}
