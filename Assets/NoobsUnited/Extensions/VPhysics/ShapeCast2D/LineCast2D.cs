using UnityEngine;
using System.Collections;
using NoobsUnited;
using NoobsUnited.Swizzle;

namespace UnityEngine
{
	public partial class VPhysics2D : MonoBehaviour
	{
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end)
		{
			GenerateRenderer();
			RaycastHit2D hit = Physics2D.Linecast(start, end);
			
			LineGeometry linecastGeometry = new LineGeometry(start, end);
			linecastGeometry.color.a = .4f;
			
			if(hit)
			{
				linecastGeometry.end = hit.point;
				linecastGeometry.contactPoints.Add (hit.point);
			}
			
			SphereGeometry startGeometry = new SphereGeometry(linecastGeometry.start, .125f, Vector3.zero);
			startGeometry.color = Color.blue;
			
			_geometry.Add (startGeometry);
			_geometry.Add (linecastGeometry);
			
			return hit;
		}
	}
}