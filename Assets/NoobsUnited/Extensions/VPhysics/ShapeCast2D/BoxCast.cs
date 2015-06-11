using UnityEngine;
using System.Collections;
using NoobsUnited;
using NoobsUnited.Swizzle;

namespace UnityEngine
{
	public partial class VPhysics2D : MonoBehaviour
	{
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance = Mathf.Infinity, int layerMask = Physics.DefaultRaycastLayers, float minDepth = -Mathf.Infinity, float maxDepth = Mathf.Infinity)
		{
			RaycastHit2D hit = Physics2D.BoxCast (origin, size, angle, direction, distance, layerMask, minDepth, maxDepth);
			return hit; 
		}
	}
}