using UnityEngine;
using System.Collections;

namespace NoobsUnited
{
	namespace Noob3D
	{
		public static partial class UnityExtensions
		{
			public static void Translate(this Transform t, float x, float y, float z)
			{
				t.Translate(x,y,z);
			}
			
			public static void SetPosition(this Transform t, float x, float y, float z)
			{
				t.position = new Vector3(x,y,z);
			}
			
			public static void SetPositionZ(this Transform t, float x, float y, float z)
			{
				Vector3 oldPos = t.position;
				t.position = new Vector3(oldPos.x, oldPos.y, z);
			}
		}
	}
}

