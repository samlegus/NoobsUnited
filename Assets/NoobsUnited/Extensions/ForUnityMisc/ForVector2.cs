using UnityEngine;
using System.Collections;
using NoobsUnited;

namespace NoobsUnited
{
	public static partial class UnityExtensions
	{
		public static Vector2 GetHeading(this Vector2 v, Vector2 from, Vector2 to )
		{
			return (to - from).normalized;
		}
	}
}