using UnityEngine;
using System.Collections;
using NoobsUnited;
using NoobsUnited.Swizzle;

namespace UnityEngine
{
	public partial class VPhysics2D : MonoBehaviour
	{
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction)
		{
			GenerateRenderer();
			float distance = Mathf.Infinity;
			RaycastHit2D[] hits = Physics2D.CircleCastAll (origin, radius, direction, distance);
			SphereGeometry originGeometry = new SphereGeometry(origin, radius, direction);
	
			if(hits.Length > 0)
			{
				foreach(RaycastHit2D hit in hits)
				{
					originGeometry.contactPoints.Add (hit.point);
				}
				
				SphereGeometry endSphere = new SphereGeometry(origin + direction * maxShapeCastDistance, radius, -direction);
				endSphere.color.a = .5f;
				_geometry.Add (endSphere);
				
				LineGeometry directionIndicatorAbove = new LineGeometry(origin + Vector2.up * radius, endSphere.origin.xy() + Vector2.up * radius);
				directionIndicatorAbove.color.a = .3f;
				_geometry.Add (directionIndicatorAbove);
				
				LineGeometry directionIndicatorBelow = new LineGeometry(origin - Vector2.up * radius, endSphere.origin.xy() - Vector2.up * radius);
				directionIndicatorBelow.color.a = .3f;
				_geometry.Add (directionIndicatorBelow);
			}
			else
			{
				if(distance == Mathf.Infinity)
				{
					_geometry.Add (new LineGeometry(originGeometry.origin, originGeometry.origin + (Vector3)direction.normalized * maxShapeCastDistance));
					
					SphereGeometry endSphere = new SphereGeometry(origin + direction * maxShapeCastDistance, radius, -direction);
					endSphere.color.a = .5f;
					_geometry.Add (endSphere);
					
					LineGeometry directionIndicatorAbove = new LineGeometry(origin + Vector2.up * radius, endSphere.origin.xy() + Vector2.up * radius);
					directionIndicatorAbove.color.a = .3f;
					_geometry.Add (directionIndicatorAbove);
					
					LineGeometry directionIndicatorBelow = new LineGeometry(origin - Vector2.up * radius, endSphere.origin.xy() - Vector2.up * radius);
					directionIndicatorBelow.color.a = .3f;
					_geometry.Add (directionIndicatorBelow);
				}
				else if(distance != Mathf.Infinity && distance >= 0)
				{
					SphereGeometry endSphere = new SphereGeometry(origin + direction * distance, radius, -direction);
					endSphere.color.a = .5f;
					_geometry.Add (endSphere);
					
					LineGeometry directionIndicatorAbove = new LineGeometry(origin + Vector2.up * radius, endSphere.origin.xy() + Vector2.up * radius);
					directionIndicatorAbove.color.a = .3f;
					_geometry.Add (directionIndicatorAbove);
					
					LineGeometry directionIndicatorBelow = new LineGeometry(origin - Vector2.up * radius, endSphere.origin.xy() - Vector2.up * radius);
					directionIndicatorBelow.color.a = .3f;
					_geometry.Add (directionIndicatorBelow);
				}
			}
			
			_geometry.Add(originGeometry);
			return hits;
		}
		
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance)
		{
			GenerateRenderer();
			RaycastHit2D[] hits = Physics2D.CircleCastAll (origin, radius, direction, distance);
			SphereGeometry originGeometry = new SphereGeometry(origin, radius, direction);
		
			if(hits.Length > 0)
			{
				foreach(RaycastHit2D hit in hits)
				{
					originGeometry.contactPoints.Add (hit.point);
				}
				
				SphereGeometry endSphere = new SphereGeometry(origin + direction * distance, radius, -direction);
				endSphere.color.a = .5f;
				_geometry.Add (endSphere);
				
				LineGeometry directionIndicatorAbove = new LineGeometry(origin + Vector2.up * radius, endSphere.origin.xy() + Vector2.up * radius);
				directionIndicatorAbove.color.a = .3f;
				_geometry.Add (directionIndicatorAbove);
				
				LineGeometry directionIndicatorBelow = new LineGeometry(origin - Vector2.up * radius, endSphere.origin.xy() - Vector2.up * radius);
				directionIndicatorBelow.color.a = .3f;
				_geometry.Add (directionIndicatorBelow);
			}
			else
			{
				if(distance == Mathf.Infinity)
				{
					SphereGeometry endSphere = new SphereGeometry(origin + direction * distance, radius, -direction);
					endSphere.color.a = .5f;
					_geometry.Add (endSphere);
					
					LineGeometry directionIndicatorAbove = new LineGeometry(origin + Vector2.up * radius, endSphere.origin.xy() + Vector2.up * radius);
					directionIndicatorAbove.color.a = .3f;
					_geometry.Add (directionIndicatorAbove);
					
					LineGeometry directionIndicatorBelow = new LineGeometry(origin - Vector2.up * radius, endSphere.origin.xy() - Vector2.up * radius);
					directionIndicatorBelow.color.a = .3f;
					_geometry.Add (directionIndicatorBelow);
				}
				else if(distance != Mathf.Infinity && distance >= 0)
				{
					SphereGeometry endSphere = new SphereGeometry(origin + direction * distance, radius, -direction);
					endSphere.color.a = .5f;
					_geometry.Add (endSphere);
					
					LineGeometry directionIndicatorAbove = new LineGeometry(origin + Vector2.up * radius, endSphere.origin.xy() + Vector2.up * radius);
					directionIndicatorAbove.color.a = .3f;
					_geometry.Add (directionIndicatorAbove);
					
					LineGeometry directionIndicatorBelow = new LineGeometry(origin - Vector2.up * radius, endSphere.origin.xy() - Vector2.up * radius);
					directionIndicatorBelow.color.a = .3f;
					_geometry.Add (directionIndicatorBelow);
				}
			}
			
			_geometry.Add(originGeometry);
			return hits;
		}
		
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask)
		{
			GenerateRenderer();
			RaycastHit2D[] hits = Physics2D.CircleCastAll (origin, radius, direction, distance);
			SphereGeometry originGeometry = new SphereGeometry(origin, radius, direction);
			
			if(hits.Length > 0)
			{
				foreach(RaycastHit2D hit in hits)
				{
					originGeometry.contactPoints.Add (hit.point);
				}
				
				SphereGeometry endSphere = new SphereGeometry(origin + direction * maxShapeCastDistance, radius, -direction);
				endSphere.color.a = .5f;
				_geometry.Add (endSphere);
				
				LineGeometry directionIndicatorAbove = new LineGeometry(origin + Vector2.up * radius, endSphere.origin.xy() + Vector2.up * radius);
				directionIndicatorAbove.color.a = .3f;
				_geometry.Add (directionIndicatorAbove);
				
				LineGeometry directionIndicatorBelow = new LineGeometry(origin - Vector2.up * radius, endSphere.origin.xy() - Vector2.up * radius);
				directionIndicatorBelow.color.a = .3f;
				_geometry.Add (directionIndicatorBelow);
			}
			else
			{
				if(distance == Mathf.Infinity)
				{
					SphereGeometry endSphere = new SphereGeometry(origin + direction * distance, radius, -direction);
					endSphere.color.a = .5f;
					_geometry.Add (endSphere);
					
					LineGeometry directionIndicatorAbove = new LineGeometry(origin + Vector2.up * radius, endSphere.origin.xy() + Vector2.up * radius);
					directionIndicatorAbove.color.a = .3f;
					_geometry.Add (directionIndicatorAbove);
					
					LineGeometry directionIndicatorBelow = new LineGeometry(origin - Vector2.up * radius, endSphere.origin.xy() - Vector2.up * radius);
					directionIndicatorBelow.color.a = .3f;
					_geometry.Add (directionIndicatorBelow);
				}
				else if(distance != Mathf.Infinity && distance >= 0)
				{
					SphereGeometry endSphere = new SphereGeometry(origin + direction * distance, radius, -direction);
					endSphere.color.a = .5f;
					_geometry.Add (endSphere);
					
					LineGeometry directionIndicatorAbove = new LineGeometry(origin + Vector2.up * radius, endSphere.origin.xy() + Vector2.up * radius);
					directionIndicatorAbove.color.a = .3f;
					_geometry.Add (directionIndicatorAbove);
					
					LineGeometry directionIndicatorBelow = new LineGeometry(origin - Vector2.up * radius, endSphere.origin.xy() - Vector2.up * radius);
					directionIndicatorBelow.color.a = .3f;
					_geometry.Add (directionIndicatorBelow);
				}
			}
			
			_geometry.Add(originGeometry);
			return hits;
		}
		
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			GenerateRenderer();
			RaycastHit2D[] hits = Physics2D.CircleCastAll (origin, radius, direction, distance);
			SphereGeometry originGeometry = new SphereGeometry(origin, radius, direction);
			
			if(hits.Length > 0)
			{
				foreach(RaycastHit2D hit in hits)
				{
					originGeometry.contactPoints.Add (hit.point);
				}
				
				SphereGeometry endSphere = new SphereGeometry(origin + direction * maxShapeCastDistance, radius, -direction);
				endSphere.color.a = .5f;
				_geometry.Add (endSphere);
				
				LineGeometry directionIndicatorAbove = new LineGeometry(origin + Vector2.up * radius, endSphere.origin.xy() + Vector2.up * radius);
				directionIndicatorAbove.color.a = .3f;
				_geometry.Add (directionIndicatorAbove);
				
				LineGeometry directionIndicatorBelow = new LineGeometry(origin - Vector2.up * radius, endSphere.origin.xy() - Vector2.up * radius);
				directionIndicatorBelow.color.a = .3f;
				_geometry.Add (directionIndicatorBelow);
			}
			else
			{
				if(distance == Mathf.Infinity)
				{
					SphereGeometry endSphere = new SphereGeometry(origin + direction * distance, radius, -direction);
					endSphere.color.a = .5f;
					_geometry.Add (endSphere);
					
					LineGeometry directionIndicatorAbove = new LineGeometry(origin + Vector2.up * radius, endSphere.origin.xy() + Vector2.up * radius);
					directionIndicatorAbove.color.a = .3f;
					_geometry.Add (directionIndicatorAbove);
					
					LineGeometry directionIndicatorBelow = new LineGeometry(origin - Vector2.up * radius, endSphere.origin.xy() - Vector2.up * radius);
					directionIndicatorBelow.color.a = .3f;
					_geometry.Add (directionIndicatorBelow);
				}
				else if(distance != Mathf.Infinity && distance >= 0)
				{
					SphereGeometry endSphere = new SphereGeometry(origin + direction * distance, radius, -direction);
					endSphere.color.a = .5f;
					_geometry.Add (endSphere);
					
					LineGeometry directionIndicatorAbove = new LineGeometry(origin + Vector2.up * radius, endSphere.origin.xy() + Vector2.up * radius);
					directionIndicatorAbove.color.a = .3f;
					_geometry.Add (directionIndicatorAbove);
					
					LineGeometry directionIndicatorBelow = new LineGeometry(origin - Vector2.up * radius, endSphere.origin.xy() - Vector2.up * radius);
					directionIndicatorBelow.color.a = .3f;
					_geometry.Add (directionIndicatorBelow);
				}
			}
			
			_geometry.Add(originGeometry);
			return hits;
		}
	}
}