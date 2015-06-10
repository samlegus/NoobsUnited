using UnityEngine;
using System.Collections;
using NoobsUnited;

namespace UnityEngine
{
	public partial class VPhysics2D : MonoBehaviour
	{
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction)
		{
			GenerateRenderer();
			float distance = Mathf.Infinity;
			RaycastHit2D hit = Physics2D.CircleCast (origin, radius, direction, distance);
			SphereGeometry originGeometry = new SphereGeometry(origin, radius, direction);
			
			if(hit)
			{
				originGeometry.contactPoints.Add (hit.point);
				_geometry.Add (new LineGeometry(origin, hit.point));
			}
			else
			{
				if(distance == Mathf.Infinity)
				{
					_geometry.Add (new LineGeometry(originGeometry.origin, originGeometry.origin + (Vector3)direction.normalized * maxShapeCastDistance));
				}
				else if(distance != Mathf.Infinity && distance >= 0)
				{
					_geometry.Add (new LineGeometry(origin, originGeometry.origin + (Vector3)direction.normalized * distance));
				}
			}
			
			_geometry.Add(originGeometry);
			return hit;
		}
		
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance)
		{
			GenerateRenderer();
			RaycastHit2D hit = Physics2D.CircleCast (origin, radius, direction, distance);
			SphereGeometry originGeometry = new SphereGeometry(origin, radius, direction);
			
			if(hit)
			{
				originGeometry.contactPoints.Add (hit.point);
				_geometry.Add (new LineGeometry(origin, hit.point));
			}
			else
			{
				if(distance == Mathf.Infinity)
				{
					_geometry.Add (new LineGeometry(originGeometry.origin, originGeometry.origin + (Vector3)direction.normalized * maxShapeCastDistance));
				}
				else if(distance != Mathf.Infinity && distance >= 0)
				{
					_geometry.Add (new LineGeometry(origin, originGeometry.origin + (Vector3)direction.normalized * distance));
				}
			}
			
			_geometry.Add(originGeometry);
			return hit;
		}
		
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask)
		{
			GenerateRenderer();
			RaycastHit2D hit = Physics2D.CircleCast (origin, radius, direction, distance, layerMask);
			SphereGeometry originGeometry = new SphereGeometry(origin, radius, direction);
			
			if(hit)
			{
				originGeometry.contactPoints.Add (hit.point);
				_geometry.Add (new LineGeometry(origin, hit.point));
			}
			else
			{
				if(distance == Mathf.Infinity)
				{
					_geometry.Add (new LineGeometry(originGeometry.origin, originGeometry.origin + (Vector3)direction.normalized * maxShapeCastDistance));
				}
				else if(distance != Mathf.Infinity && distance >= 0)
				{
					_geometry.Add (new LineGeometry(origin, originGeometry.origin + (Vector3)direction.normalized * distance));
				}
			}
			
			_geometry.Add(originGeometry);
			return hit;
		}
		
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			GenerateRenderer();
			RaycastHit2D hit = Physics2D.CircleCast (origin, radius, direction, distance, layerMask, minDepth);
			SphereGeometry originGeometry = new SphereGeometry(origin, radius, direction);
			
			if(hit)
			{
				originGeometry.contactPoints.Add (hit.point);
				_geometry.Add (new LineGeometry(origin, hit.point));
			}
			else
			{
				if(distance == Mathf.Infinity)
				{
					_geometry.Add (new LineGeometry(originGeometry.origin, originGeometry.origin + (Vector3)direction.normalized * maxShapeCastDistance));
				}
				else if(distance != Mathf.Infinity && distance >= 0)
				{
					_geometry.Add (new LineGeometry(origin, originGeometry.origin + (Vector3)direction.normalized * distance));
				}
			}
			
			_geometry.Add(originGeometry);
			return hit;
		}
	}
}