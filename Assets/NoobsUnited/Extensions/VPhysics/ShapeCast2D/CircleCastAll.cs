using UnityEngine;
using System.Collections;
using NoobsUnited;

namespace UnityEngine
{
	public partial class VPhysics2D
	{
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction)
		{
			float distance = Mathf.Infinity;
			RaycastHit2D[] hits = Physics2D.CircleCastAll (origin, radius, direction, distance);
			SphereGeometry originGeometry = new SphereGeometry(origin, radius, direction);
			Debug.Log (hits.Length);
			if(hits.Length > 0)
			{
				foreach(RaycastHit2D hit in hits)
				{
					originGeometry.contactPoints.Add (hit.point);
				}
				_geometry.Add (new LineGeometry(origin, hits[hits.Length -1].point));
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
			return hits;
		}
		
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance)
		{
			RaycastHit2D[] hits = Physics2D.CircleCastAll (origin, radius, direction, distance);
			SphereGeometry originGeometry = new SphereGeometry(origin, radius, direction);
			Debug.Log (hits.Length);
			if(hits.Length > 0)
			{
				foreach(RaycastHit2D hit in hits)
				{
					originGeometry.contactPoints.Add (hit.point);
				}
				_geometry.Add (new LineGeometry(origin, hits[hits.Length -1].point));
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
			return hits;
		}
		
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask)
		{
			RaycastHit2D[] hits = Physics2D.CircleCastAll (origin, radius, direction, distance);
			SphereGeometry originGeometry = new SphereGeometry(origin, radius, direction);
			
			if(hits.Length > 0)
			{
				foreach(RaycastHit2D hit in hits)
				{
					originGeometry.contactPoints.Add (hit.point);
				}
				_geometry.Add (new LineGeometry(origin, hits[hits.Length -1].point));
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
			return hits;
		}
		
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			RaycastHit2D[] hits = Physics2D.CircleCastAll (origin, radius, direction, distance);
			SphereGeometry originGeometry = new SphereGeometry(origin, radius, direction);
			
			if(hits.Length > 0)
			{
				foreach(RaycastHit2D hit in hits)
				{
					originGeometry.contactPoints.Add (hit.point);
				}
				_geometry.Add (new LineGeometry(origin, hits[hits.Length -1].point));
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
			return hits;
		}
	}
}