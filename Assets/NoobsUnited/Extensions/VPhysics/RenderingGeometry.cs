using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace NoobsUnited
{
	public abstract class ShapecastGeometry
	{
		public static Color contactPointColor = Color.yellow;
		public float contactPointSphereRadius = 1f;
		public Color color = Color.white;
		public List<Vector3> contactPoints = new List<Vector3>();
		public abstract void Render();
	}
	
	public class SphereGeometry : ShapecastGeometry
	{
		public SphereGeometry(Vector3 origin, float radius, Vector3 direction) //, float distance = Mathf.Infinity)
		{
			this.origin = origin;
			this.radius = radius;
			this.direction = direction;
			this.contactPointSphereRadius = radius * .25f;
		}
	
		public Vector3 origin { get; set;}
		public float radius {get; set;}
		public Vector3 direction {get; set;}
		
		public override void Render()
		{
			Color prevColor = Gizmos.color;
			Gizmos.color = color;
			Gizmos.DrawWireSphere (origin, radius);
			
			foreach(Vector3 point in contactPoints)
			{
				Gizmos.color = contactPointColor;
				Gizmos.DrawWireSphere (point, radius / 4f);
			}
			Gizmos.color = prevColor;
		}
	}
	
	public class LineGeometry : ShapecastGeometry
	{
		public LineGeometry(Vector3 start, Vector3 end)
		{
			this.start = start;
			this.end = end;
			this.contactPointSphereRadius = Vector3.Magnitude ((start + end).normalized) * .25f;
		}
		
		public Vector3 start {get;set;}
		public Vector3 end {get;set;}
	
		public override void Render()
		{
			Color prevColor = Gizmos.color;
			Gizmos.color = color;
			Gizmos.DrawLine (start, end);
			Gizmos.color = prevColor;
			
			foreach(Vector3 point in contactPoints)
			{
				Gizmos.color = contactPointColor;
				Gizmos.DrawWireSphere (point, contactPointSphereRadius);
			}
			Gizmos.color = prevColor;
		}
	}
	
	public class CubeGeometry : ShapecastGeometry
	{
		public CubeGeometry(Vector3 origin, Vector3 size)
		{
			this.origin = origin;
			this.size = size;
			this.contactPointSphereRadius = Vector3.Magnitude (size.normalized) * .25f;
		}
		
		public Vector3 origin {get;set;}
		public Vector3 size {get;set;}
		
		public override void Render()
		{
			Color prevColor = Gizmos.color;
			Gizmos.color = color;
			Gizmos.DrawWireCube(origin, size);
			
			foreach(Vector3 point in contactPoints)
			{
				Gizmos.color = contactPointColor;
				Gizmos.DrawWireSphere (point, contactPointSphereRadius);
			}
			Gizmos.color = prevColor;
		}
	}
	
}