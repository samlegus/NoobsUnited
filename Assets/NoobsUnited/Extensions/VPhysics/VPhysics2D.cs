using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NoobsUnited.Swizzle;

namespace UnityEngine
{
	public class CircleGeometry
	{
		public CircleGeometry(Vector2 origin, float radius, Vector2 direction) //, float distance = Mathf.Infinity)
		{
			this.origin = origin;
			this.radius = radius;
			this.direction = direction;
			//this.distance = distance;
			this.contactPoints = new List<Vector2>();
		}
		
		public Vector2 origin { get; set;}
		public float radius {get; set;}
		public Vector2 direction {get; set;}
		//public float distance {get; set;}
		public List<Vector2> contactPoints;
	}
	
	public class VPhysics2D : MonoBehaviour
	{
		#region Geometry Rendering classes
		
		public static int _maxShapeDrawsPerCast = 40;
		public static bool _renderGeometry = true;
		public static float _contactPointRenderScale = .25f;
		
		#endregion
		
		#region Inspector
		
		#endregion
		
		#region Private Variables
		
		private static List<CircleGeometry> _circleGeometry = new List<CircleGeometry>();
		private static bool _renderingCycleStarted = false;
		private static Color _shapeCastColor = Color.white;
		private static Color _hitPointColor = Color.yellow;
		private static Color _shapeCastDirectionColor = Color.blue;
		
		#endregion
		
		#region Unity Events
		
		void OnGUI()
		{
			
		}
		
		void OnDrawGizmos()
		{
			if(!_renderingCycleStarted)
			{
				StartCoroutine(DestroyGeometry());
			}
			
			if(_renderGeometry)
			{
				foreach(CircleGeometry circ in _circleGeometry)
				{
					//Draw CircleCasts
					Gizmos.color = _shapeCastColor;
					Gizmos.DrawWireSphere (circ.origin, circ.radius);
					
					//Draw the contact points for each valid RaycastHit2D
					Gizmos.color = _hitPointColor;
					foreach(Vector3 point in circ.contactPoints)
					{
						Gizmos.DrawWireSphere(point, circ.radius * _contactPointRenderScale );
					}
					
					//Draw CircleCast direction indicators
					Gizmos.color = _shapeCastDirectionColor;
					Gizmos.DrawLine(circ.origin, circ.origin + (circ.direction * circ.radius / 2f));
					Gizmos.DrawCube(circ.origin, Vector3.one * circ.radius * (_contactPointRenderScale / 2f));
				}
			}
		}
		
		#endregion
		
		#region Behaviour Methods
		
		IEnumerator DestroyGeometry()
		{
			_renderingCycleStarted = true;
			yield return new WaitForEndOfFrame();
			_circleGeometry.Clear ();
			_renderingCycleStarted = false;
		}
		
		#endregion
		
		#region Shapecast Methods
		
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance = Mathf.Infinity)
		{
			RaycastHit2D hit = Physics2D.CircleCast (origin, radius, direction, distance);
			CircleGeometry originGeometry = new CircleGeometry(origin, radius, direction);
			_circleGeometry.Add (originGeometry);
			
			if(hit)
			{
				CircleGeometry endGeometry = new CircleGeometry(hit.point + (-direction * radius), radius, direction);
				endGeometry.contactPoints.Add (hit.point);
				_circleGeometry.Add (endGeometry);
			}
			
//			if(distance > 0)
//			{	
//				if(distance == Mathf.Infinity)
//				{
//					Vector3 nextSphereOrigin = origin;
//					int drawCount = 0;
//					for(drawCount = 0; drawCount < _maxShapeDrawsPerCast ; drawCount++)
//					{
//						Vector3 directionXYZ = direction;
//						nextSphereOrigin = nextSphereOrigin + (directionXYZ * radius);
//						CircleGeometry nextGeometry = new CircleGeometry(nextSphereOrigin, radius, direction);
//						_circleGeometry.Add(nextGeometry);
//					}
//				}
//				else if(distance < Mathf.Infinity)
//				{
//					Vector3 nextSphereOrigin = origin;
//					int drawCount = 0;
//					int shapeDrawsThisCast = Mathf.RoundToInt (distance);
//					for(drawCount = 0; drawCount < shapeDrawsThisCast ; drawCount++)
//					{
//						Vector3 directionXYZ = direction;
//						nextSphereOrigin = nextSphereOrigin + (directionXYZ * radius);
//						CircleGeometry nextGeometry = new CircleGeometry(nextSphereOrigin, radius, direction);
//						_circleGeometry.Add(nextGeometry);
//					}
//				}
//				
//			}
			return hit;
		}
		
		#endregion
		
				
	}
}