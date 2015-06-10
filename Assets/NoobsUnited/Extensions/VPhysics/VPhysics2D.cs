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

		private static GameObject _gizmoRenderer;
		
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

		static void GenerateRenderer()
		{
			if(_gizmoRenderer)
			{
				return;
			}

			_gizmoRenderer = new GameObject();
			_gizmoRenderer.name = "_VPhysicsRenderer";
			_gizmoRenderer.AddComponent (typeof(VPhysics2D));
		}
		
		#endregion
			
	}
}