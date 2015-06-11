using UnityEngine;
using System.Collections;
using NoobsUnited;
using NoobsUnited.Swizzle;

namespace UnityEngine
{
	public partial class VPhysics2D : MonoBehaviour
	{
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance = Mathf.Infinity, int layerMask = Physics2D.DefaultRaycastLayers, float minDepth = -Mathf.Infinity, float maxDepth = Mathf.Infinity)
		{
			GenerateRenderer();
			RaycastHit2D hit = Physics2D.Raycast (origin, direction, distance, layerMask, minDepth, maxDepth);
			
			LineGeometry raycastGeometry = new LineGeometry(origin, origin + (direction * distance));
			raycastGeometry.color.a = .4f;
			
			if(hit)
			{
				raycastGeometry.end = hit.point;
				raycastGeometry.contactPoints.Add (hit.point);
			}
			SphereGeometry startGeometry = new SphereGeometry(raycastGeometry.start, .125f, Vector3.zero);
			startGeometry.color = Color.blue;
			
			_geometry.Add (startGeometry);
			_geometry.Add (raycastGeometry);
			
			return hit;
		}
	}
}