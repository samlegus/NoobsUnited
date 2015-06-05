using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NoobsUnited;

namespace UnityEngine
{
	public partial class VPhysics2D : MonoBehaviour
	{
		#region Inspector
		
		//public static int maxShapeDrawsPerCast = 40;
		public static float maxShapeCastDistance = 1000f;
		public static bool renderGeometry = true;
		public static float contactPointRenderScale = .25f;
		
		#endregion
		
		#region Private Variables
		
		private static List<ShapecastGeometry> _geometry = new List<ShapecastGeometry>();
		
		private static bool _renderingCycleStarted = false;
		private static Color _shapeCastColor = Color.white;
		private static Color _hitPointColor = Color.yellow;
		private static Color _shapeCastDirectionColor = Color.blue;
		
		#endregion
		
		#region Unity Events
		
		void Test()
		{
			Debug.Log("Test!");
		}
		
		void Awake()
		{
			
		}
		
		
		void OnGUI()
		{
			
		}
		
		void OnDrawGizmos()
		{
			if(!_renderingCycleStarted)
			{
				StartCoroutine(DestroyGeometry());
			}
			
			if(renderGeometry)
			{
				foreach(ShapecastGeometry shape in _geometry)
				{
					shape.Render ();
//					//Draw CircleCasts
//					Gizmos.color = _shapeCastColor;
//					Gizmos.DrawWireSphere (circ.origin, circ.radius);
//					
//					//Draw the contact points for each valid RaycastHit2D
//					Gizmos.color = _hitPointColor;
//					foreach(Vector3 point in circ.contactPoints)
//					{
//						Gizmos.DrawWireSphere(point, circ.radius * contactPointRenderScale );
//					}
//					
//					//Draw CircleCast direction indicators
//					Gizmos.color = _shapeCastDirectionColor;
//					Gizmos.DrawLine(circ.origin, circ.origin + (circ.direction * circ.radius / 2f));
//					Gizmos.DrawWireCube(circ.origin, Vector3.one * circ.radius * (contactPointRenderScale / 2f));
//					Gizmos.DrawWireCube(circ.origin + (circ.direction * circ.radius * (contactPointRenderScale / 2f)),
//									Vector3.one * circ.radius * (contactPointRenderScale / 4f));
				}
			}
		}
		
		#endregion
		
		#region Behaviour Methods
		
		IEnumerator DestroyGeometry()
		{
			_renderingCycleStarted = true;
			yield return new WaitForEndOfFrame();
			_geometry.Clear ();
			_renderingCycleStarted = false;
		}
		
		#endregion
			
	}
}