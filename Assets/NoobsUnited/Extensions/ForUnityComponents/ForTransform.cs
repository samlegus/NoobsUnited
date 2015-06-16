using UnityEngine;
using System.Collections;

namespace NoobsUnited
{
	namespace Noob2D
	{
		public static partial class UnityExtensions
		{
			public static void Translate(this Transform t, float x, float y)
			{
				t.Translate(x,y,0);
			}

			public static void Move(this Transform t, float x, float y)
			{
				t.Translate ( new Vector2(x, y) * Time.deltaTime);
			}

			public static void Move(this Transform t, Vector2 translation)
			{
				t.Translate ( translation * Time.deltaTime);
			}

			public static void Rotate2D(this Transform t, float degrees)
			{
				t.Rotate( Vector3.forward, degrees);
			}

			public static void Rotate2D(this Transform t, float degrees, bool clockwise)
			{
				if(clockwise)
				{
					t.Rotate( Vector3.forward, degrees);
				}
				else
				{
					t.Rotate( -Vector3.forward, degrees);
				}
			}

			public static void RotateAround2D(this Transform t, float posX, float posY, float degrees)
			{
				float posZ = t.position.z;
				Vector3 point = new Vector3(posX, posY, posZ);
				t.RotateAround( point, Vector3.forward, degrees);
			}
			
			//C++ Style Getters and Setters
			public static Vector2 GetPosition(this Transform t)
			{
				return new Vector2(t.position.x, t.position.y);
			}
			
			public static float GetPositionX(this Transform t)
			{
				return t.position.x;
			}
			
			public static float GetPositionY(this Transform t)
			{
				return t.position.y;
			}
			
			public static void SetPosition(this Transform t, float x, float y)
			{
				t.position = new Vector3(x,y, t.position.z);
			}
			
			public static void SetPositionX(this Transform t, float x)
			{
				Vector3 oldPos = t.position;
				t.position = new Vector3(x, oldPos.y, oldPos.z);
			}
			
			public static void SetPositionY(this Transform t, float y)
			{
				Vector3 oldPos = t.position;
				t.position = new Vector3(oldPos.x, y, oldPos.z);
			}
			
			public static void SetLocalScale(this Transform t, float x, float y)
			{
				t.localScale = new Vector3(x,y, t.localScale.z);
			}
			
			public static void SetLocalScaleX(this Transform t, float x)
			{
				Vector3 oldLocalScale = t.localScale;
				t.localScale = new Vector3(x, oldLocalScale.y, oldLocalScale.z);
			}
			
			public static void SetLocalScaleY(this Transform t, float y)
			{
				Vector3 oldLocalScale = t.localScale;
				t.localScale = new Vector3(oldLocalScale.x, y, oldLocalScale.z);
			}
			
			public static Vector2 GetLocalScale(this Transform t)
			{
				return new Vector2(t.localScale.x, t.localScale.y);
			}
			
			public static float GetLocalScaleX(this Transform t)
			{
				return t.localScale.x;
			}
			
			public static float GetLocalScaleY(this Transform t)
			{
				return t.localScale.y;
			}
		}	
	}
}

