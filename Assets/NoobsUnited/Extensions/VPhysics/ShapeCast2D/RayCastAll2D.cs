using UnityEngine;
using System.Collections;
using NoobsUnited;
using NoobsUnited.Swizzle;


namespace UnityEngine
{
	public partial class VPhysics2D : MonoBehaviour
	{
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance = Mathf.Infinity, int layerMask = Physics2D.DefaultRaycastLayers, float minDepth = -Mathf.Infinity, float maxDepth = Mathf.Infinity)
		{
			GenerateRenderer();
			RaycastHit2D[] hits = Physics2D.RaycastAll (origin, direction, distance, layerMask, minDepth, maxDepth);
			
			LineGeometry raycastGeometry = new LineGeometry(origin, origin + (direction * distance));
			raycastGeometry.color.a = .4f;
			
			if(hits.Length > 0)
			{
				raycastGeometry.end = origin + direction * distance;
				foreach(RaycastHit2D hit in hits)
				{
					raycastGeometry.contactPoints.Add (hit.point);
				}
			}
			
			SphereGeometry startGeometry = new SphereGeometry(raycastGeometry.start, .125f, Vector3.zero);
			startGeometry.color = Color.blue;
			
			_geometry.Add (startGeometry);
			_geometry.Add (raycastGeometry);
			
			return hits;
		}
	}
}