using UnityEngine;
using System.Collections;

namespace NoobsUnited
{
	namespace Noob2D
	{
		public static partial class UnityExtensions
		{
			public static Vector2 GetVelocity(this Rigidbody2D rb)
			{
				return new Vector2(rb.velocity.x, rb.velocity.y);
			}
			
			public static float GetVelocityX(this Rigidbody2D rb)
			{
				return rb.velocity.x;
			}
			
			public static float GetVelocityY(this Rigidbody2D rb)
			{
				return rb.velocity.y;
			}
			
			public static Vector2 GetDirection(this Rigidbody2D rb)
			{
				return rb.velocity.normalized;
			}
			
			public static float GetDirectionX(this Rigidbody2D rb)
			{
				Vector2 dir = rb.velocity.normalized;
				return dir.x;
			}
			
			public static float GetDirectionY(this Rigidbody2D rb)
			{
				Vector2 dir =  rb.velocity.normalized;
				return dir.y;
			}
			
			public static void SetVelocity(this Rigidbody2D rb, float x, float y)
			{
				rb.velocity = new Vector2(x,y);
			}
			
			public static void SetVelocityX(this Rigidbody2D rb, float x)
			{
				Vector2 oldPos = rb.velocity;
				rb.velocity = new Vector2(x, oldPos.y);
			}
			
			public static void SetVelocityY(this Rigidbody2D rb, float y)
			{
				Vector2 oldPos = rb.velocity;
				rb.velocity = new Vector2(oldPos.x, y);
			}
		}
	}
}