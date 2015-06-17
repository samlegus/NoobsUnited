using UnityEngine;

/// <summary>
/// * GLM Style swizzle extension methods
/// * Courtesy of Elizabeth Lowry, my colleague at AIE US (2013-2015) :) 
/// </summary>

namespace NoobsUnited
{
	namespace Swizzle
	{
		public static class VectorSwizzleExtensions
		{
			#region Vector2 swizzles
			
			#region xx-yy, xxx-yyy
			
			public static Vector2 xx(this Vector2 v)
			{
				return new Vector2(v.x, v.x);
			}
			public static Vector2 xy(this Vector2 v)
			{
				return new Vector2(v.x, v.y);
			}
			public static Vector2 yx(this Vector2 v)
			{
				return new Vector2(v.y, v.x);
			}
			public static Vector2 yy(this Vector2 v)
			{
				return new Vector2(v.y, v.y);
			}
			
			public static Vector3 xxx(this Vector2 v)
			{
				return new Vector3(v.x, v.x, v.x);
			}
			public static Vector3 xxy(this Vector2 v)
			{
				return new Vector3(v.x, v.x, v.y);
			}
			public static Vector3 xyx(this Vector2 v)
			{
				return new Vector3(v.x, v.y, v.x);
			}
			public static Vector3 xyy(this Vector2 v)
			{
				return new Vector3(v.x, v.y, v.y);
			}
			
			public static Vector3 yxx(this Vector2 v)
			{
				return new Vector3(v.y, v.x, v.x);
			}
			public static Vector3 yxy(this Vector2 v)
			{
				return new Vector3(v.y, v.x, v.y);
			}
			public static Vector3 yyx(this Vector2 v)
			{
				return new Vector3(v.y, v.y, v.x);
			}
			public static Vector3 yyy(this Vector2 v)
			{
				return new Vector3(v.y, v.y, v.y);
			}
			
			#endregion
			
			#region xxxx-yyyy
			
			public static Vector4 xxxx(this Vector2 v)
			{
				return new Vector4(v.x, v.x, v.x, v.x);
			}
			public static Vector4 xxxy(this Vector2 v)
			{
				return new Vector4(v.x, v.x, v.x, v.y);
			}
			public static Vector4 xxyx(this Vector2 v)
			{
				return new Vector4(v.x, v.x, v.y, v.x);
			}
			public static Vector4 xxyy(this Vector2 v)
			{
				return new Vector4(v.x, v.x, v.y, v.y);
			}
			
			public static Vector4 xyxx(this Vector2 v)
			{
				return new Vector4(v.x, v.y, v.x, v.x);
			}
			public static Vector4 xyxy(this Vector2 v)
			{
				return new Vector4(v.x, v.y, v.x, v.y);
			}
			public static Vector4 xyyx(this Vector2 v)
			{
				return new Vector4(v.x, v.y, v.y, v.x);
			}
			public static Vector4 xyyy(this Vector2 v)
			{
				return new Vector4(v.x, v.y, v.y, v.y);
			}
			
			public static Vector4 yxxx(this Vector2 v)
			{
				return new Vector4(v.y, v.x, v.x, v.x);
			}
			public static Vector4 yxxy(this Vector2 v)
			{
				return new Vector4(v.y, v.x, v.x, v.y);
			}
			public static Vector4 yxyx(this Vector2 v)
			{
				return new Vector4(v.y, v.x, v.y, v.x);
			}
			public static Vector4 yxyy(this Vector2 v)
			{
				return new Vector4(v.y, v.x, v.y, v.y);
			}
			
			public static Vector4 yyxx(this Vector2 v)
			{
				return new Vector4(v.y, v.y, v.x, v.x);
			}
			public static Vector4 yyxy(this Vector2 v)
			{
				return new Vector4(v.y, v.y, v.x, v.y);
			}
			public static Vector4 yyyx(this Vector2 v)
			{
				return new Vector4(v.y, v.y, v.y, v.x);
			}
			public static Vector4 yyyy(this Vector2 v)
			{
				return new Vector4(v.y, v.y, v.y, v.y);
			}
			
			#endregion
			
			#endregion
			
			#region Vector3 swizzles
			
			#region xx-zz
			
			public static Vector2 xx(this Vector3 v)
			{
				return new Vector2(v.x, v.x);
			}
			public static Vector2 xy(this Vector3 v)
			{
				return new Vector2(v.x, v.y);
			}
			public static Vector2 xz(this Vector3 v)
			{
				return new Vector2(v.x, v.z);
			}
			
			public static Vector2 yx(this Vector3 v)
			{
				return new Vector2(v.y, v.x);
			}
			public static Vector2 yy(this Vector3 v)
			{
				return new Vector2(v.y, v.y);
			}
			public static Vector2 yz(this Vector3 v)
			{
				return new Vector2(v.y, v.z);
			}
			
			public static Vector2 zx(this Vector3 v)
			{
				return new Vector2(v.z, v.x);
			}
			public static Vector2 zy(this Vector3 v)
			{
				return new Vector2(v.z, v.y);
			}
			public static Vector2 zz(this Vector3 v)
			{
				return new Vector2(v.z, v.z);
			}
			
			#endregion
			
			#region xxx-zzz
			
			#region xxx-xzz
			
			public static Vector3 xxx(this Vector3 v)
			{
				return new Vector3(v.x, v.x, v.x);
			}
			public static Vector3 xxy(this Vector3 v)
			{
				return new Vector3(v.x, v.x, v.y);
			}
			public static Vector3 xxz(this Vector3 v)
			{
				return new Vector3(v.x, v.x, v.z);
			}
			
			public static Vector3 xyx(this Vector3 v)
			{
				return new Vector3(v.x, v.y, v.x);
			}
			public static Vector3 xyy(this Vector3 v)
			{
				return new Vector3(v.x, v.y, v.y);
			}
			public static Vector3 xyz(this Vector3 v)
			{
				return new Vector3(v.x, v.y, v.z);
			}
			
			public static Vector3 xzx(this Vector3 v)
			{
				return new Vector3(v.x, v.z, v.x);
			}
			public static Vector3 xzy(this Vector3 v)
			{
				return new Vector3(v.x, v.z, v.y);
			}
			public static Vector3 xzz(this Vector3 v)
			{
				return new Vector3(v.x, v.z, v.z);
			}
			
			#endregion
			
			#region yxx-yzz
			
			public static Vector3 yxx(this Vector3 v)
			{
				return new Vector3(v.y, v.x, v.x);
			}
			public static Vector3 yxy(this Vector3 v)
			{
				return new Vector3(v.y, v.x, v.y);
			}
			public static Vector3 yxz(this Vector3 v)
			{
				return new Vector3(v.y, v.x, v.z);
			}
			
			public static Vector3 yyx(this Vector3 v)
			{
				return new Vector3(v.y, v.y, v.x);
			}
			public static Vector3 yyy(this Vector3 v)
			{
				return new Vector3(v.y, v.y, v.y);
			}
			public static Vector3 yyz(this Vector3 v)
			{
				return new Vector3(v.y, v.y, v.z);
			}
			
			public static Vector3 yzx(this Vector3 v)
			{
				return new Vector3(v.y, v.z, v.x);
			}
			public static Vector3 yzy(this Vector3 v)
			{
				return new Vector3(v.y, v.z, v.y);
			}
			public static Vector3 yzz(this Vector3 v)
			{
				return new Vector3(v.y, v.z, v.z);
			}
			
			#endregion
			
			#region zxx-zzz
			
			public static Vector3 zxx(this Vector3 v)
			{
				return new Vector3(v.z, v.x, v.x);
			}
			public static Vector3 zxy(this Vector3 v)
			{
				return new Vector3(v.z, v.x, v.y);
			}
			public static Vector3 zxz(this Vector3 v)
			{
				return new Vector3(v.z, v.x, v.z);
			}
			
			public static Vector3 zyx(this Vector3 v)
			{
				return new Vector3(v.z, v.y, v.x);
			}
			public static Vector3 zyy(this Vector3 v)
			{
				return new Vector3(v.z, v.y, v.y);
			}
			public static Vector3 zyz(this Vector3 v)
			{
				return new Vector3(v.z, v.y, v.z);
			}
			
			public static Vector3 zzx(this Vector3 v)
			{
				return new Vector3(v.z, v.z, v.x);
			}
			public static Vector3 zzy(this Vector3 v)
			{
				return new Vector3(v.z, v.z, v.y);
			}
			public static Vector3 zzz(this Vector3 v)
			{
				return new Vector3(v.z, v.z, v.z);
			}
			
			#endregion
			
			#endregion
			
			#region xxxx-zzzz
			
			#region xxxx-xzzz
			
			#region xxxx-xxzz
			
			public static Vector4 xxxx(this Vector3 v)
			{
				return new Vector4(v.x, v.x, v.x, v.x);
			}
			public static Vector4 xxxy(this Vector3 v)
			{
				return new Vector4(v.x, v.x, v.x, v.y);
			}
			public static Vector4 xxxz(this Vector3 v)
			{
				return new Vector4(v.x, v.x, v.x, v.z);
			}
			
			public static Vector4 xxyx(this Vector3 v)
			{
				return new Vector4(v.x, v.x, v.y, v.x);
			}
			public static Vector4 xxyy(this Vector3 v)
			{
				return new Vector4(v.x, v.x, v.y, v.y);
			}
			public static Vector4 xxyz(this Vector3 v)
			{
				return new Vector4(v.x, v.x, v.y, v.z);
			}
			
			public static Vector4 xxzx(this Vector3 v)
			{
				return new Vector4(v.x, v.x, v.z, v.x);
			}
			public static Vector4 xxzy(this Vector3 v)
			{
				return new Vector4(v.x, v.x, v.z, v.y);
			}
			public static Vector4 xxzz(this Vector3 v)
			{
				return new Vector4(v.x, v.x, v.z, v.z);
			}
			
			#endregion
			
			#region xyxx-xyzz
			
			public static Vector4 xyxx(this Vector3 v)
			{
				return new Vector4(v.x, v.y, v.x, v.x);
			}
			public static Vector4 xyxy(this Vector3 v)
			{
				return new Vector4(v.x, v.y, v.x, v.y);
			}
			public static Vector4 xyxz(this Vector3 v)
			{
				return new Vector4(v.x, v.y, v.x, v.z);
			}
			
			public static Vector4 xyyx(this Vector3 v)
			{
				return new Vector4(v.x, v.y, v.y, v.x);
			}
			public static Vector4 xyyy(this Vector3 v)
			{
				return new Vector4(v.x, v.y, v.y, v.y);
			}
			public static Vector4 xyyz(this Vector3 v)
			{
				return new Vector4(v.x, v.y, v.y, v.z);
			}
			
			public static Vector4 xyzx(this Vector3 v)
			{
				return new Vector4(v.x, v.y, v.z, v.x);
			}
			public static Vector4 xyzy(this Vector3 v)
			{
				return new Vector4(v.x, v.y, v.z, v.y);
			}
			public static Vector4 xyzz(this Vector3 v)
			{
				return new Vector4(v.x, v.y, v.z, v.z);
			}
			
			#endregion
			
			#region xzxx-xzzz
			
			public static Vector4 xzxx(this Vector3 v)
			{
				return new Vector4(v.x, v.z, v.x, v.x);
			}
			public static Vector4 xzxy(this Vector3 v)
			{
				return new Vector4(v.x, v.z, v.x, v.y);
			}
			public static Vector4 xzxz(this Vector3 v)
			{
				return new Vector4(v.x, v.z, v.x, v.z);
			}
			
			public static Vector4 xzyx(this Vector3 v)
			{
				return new Vector4(v.x, v.z, v.y, v.x);
			}
			public static Vector4 xzyy(this Vector3 v)
			{
				return new Vector4(v.x, v.z, v.y, v.y);
			}
			public static Vector4 xzyz(this Vector3 v)
			{
				return new Vector4(v.x, v.z, v.y, v.z);
			}
			
			public static Vector4 xzzx(this Vector3 v)
			{
				return new Vector4(v.x, v.z, v.z, v.x);
			}
			public static Vector4 xzzy(this Vector3 v)
			{
				return new Vector4(v.x, v.z, v.z, v.y);
			}
			public static Vector4 xzzz(this Vector3 v)
			{
				return new Vector4(v.x, v.z, v.z, v.z);
			}
			
			#endregion
			
			#endregion
			
			#region yxxx-yzzz
			
			#region yxxx-yxzz
			
			public static Vector4 yxxx(this Vector3 v)
			{
				return new Vector4(v.y, v.x, v.x, v.x);
			}
			public static Vector4 yxxy(this Vector3 v)
			{
				return new Vector4(v.y, v.x, v.x, v.y);
			}
			public static Vector4 yxxz(this Vector3 v)
			{
				return new Vector4(v.y, v.x, v.x, v.z);
			}
			
			public static Vector4 yxyx(this Vector3 v)
			{
				return new Vector4(v.y, v.x, v.y, v.x);
			}
			public static Vector4 yxyy(this Vector3 v)
			{
				return new Vector4(v.y, v.x, v.y, v.y);
			}
			public static Vector4 yxyz(this Vector3 v)
			{
				return new Vector4(v.y, v.x, v.y, v.z);
			}
			
			public static Vector4 yxzx(this Vector3 v)
			{
				return new Vector4(v.y, v.x, v.z, v.x);
			}
			public static Vector4 yxzy(this Vector3 v)
			{
				return new Vector4(v.y, v.x, v.z, v.y);
			}
			public static Vector4 yxzz(this Vector3 v)
			{
				return new Vector4(v.y, v.x, v.z, v.z);
			}
			
			#endregion
			
			#region yyxx-yyzz
			
			public static Vector4 yyxx(this Vector3 v)
			{
				return new Vector4(v.y, v.y, v.x, v.x);
			}
			public static Vector4 yyxy(this Vector3 v)
			{
				return new Vector4(v.y, v.y, v.x, v.y);
			}
			public static Vector4 yyxz(this Vector3 v)
			{
				return new Vector4(v.y, v.y, v.x, v.z);
			}
			
			public static Vector4 yyyx(this Vector3 v)
			{
				return new Vector4(v.y, v.y, v.y, v.x);
			}
			public static Vector4 yyyy(this Vector3 v)
			{
				return new Vector4(v.y, v.y, v.y, v.y);
			}
			public static Vector4 yyyz(this Vector3 v)
			{
				return new Vector4(v.y, v.y, v.y, v.z);
			}
			
			public static Vector4 yyzx(this Vector3 v)
			{
				return new Vector4(v.y, v.y, v.z, v.x);
			}
			public static Vector4 yyzy(this Vector3 v)
			{
				return new Vector4(v.y, v.y, v.z, v.y);
			}
			public static Vector4 yyzz(this Vector3 v)
			{
				return new Vector4(v.y, v.y, v.z, v.z);
			}
			
			#endregion
			
			#region yzxx-yzzz
			
			public static Vector4 yzxx(this Vector3 v)
			{
				return new Vector4(v.y, v.z, v.x, v.x);
			}
			public static Vector4 yzxy(this Vector3 v)
			{
				return new Vector4(v.y, v.z, v.x, v.y);
			}
			public static Vector4 yzxz(this Vector3 v)
			{
				return new Vector4(v.y, v.z, v.x, v.z);
			}
			
			public static Vector4 yzyx(this Vector3 v)
			{
				return new Vector4(v.y, v.z, v.y, v.x);
			}
			public static Vector4 yzyy(this Vector3 v)
			{
				return new Vector4(v.y, v.z, v.y, v.y);
			}
			public static Vector4 yzyz(this Vector3 v)
			{
				return new Vector4(v.y, v.z, v.y, v.z);
			}
			
			public static Vector4 yzzx(this Vector3 v)
			{
				return new Vector4(v.y, v.z, v.z, v.x);
			}
			public static Vector4 yzzy(this Vector3 v)
			{
				return new Vector4(v.y, v.z, v.z, v.y);
			}
			public static Vector4 yzzz(this Vector3 v)
			{
				return new Vector4(v.y, v.z, v.z, v.z);
			}
			
			#endregion
			
			#endregion
			
			#region zxxx-zzzz
			
			#region zxxx-zxzz
			
			public static Vector4 zxxx(this Vector3 v)
			{
				return new Vector4(v.z, v.x, v.x, v.x);
			}
			public static Vector4 zxxy(this Vector3 v)
			{
				return new Vector4(v.z, v.x, v.x, v.y);
			}
			public static Vector4 zxxz(this Vector3 v)
			{
				return new Vector4(v.z, v.x, v.x, v.z);
			}
			
			public static Vector4 zxyx(this Vector3 v)
			{
				return new Vector4(v.z, v.x, v.y, v.x);
			}
			public static Vector4 zxyy(this Vector3 v)
			{
				return new Vector4(v.z, v.x, v.y, v.y);
			}
			public static Vector4 zxyz(this Vector3 v)
			{
				return new Vector4(v.z, v.x, v.y, v.z);
			}
			
			public static Vector4 zxzx(this Vector3 v)
			{
				return new Vector4(v.z, v.x, v.z, v.x);
			}
			public static Vector4 zxzy(this Vector3 v)
			{
				return new Vector4(v.z, v.x, v.z, v.y);
			}
			public static Vector4 zxzz(this Vector3 v)
			{
				return new Vector4(v.z, v.x, v.z, v.z);
			}
			
			#endregion
			
			#region zyxx-zyzz
			
			public static Vector4 zyxx(this Vector3 v)
			{
				return new Vector4(v.z, v.y, v.x, v.x);
			}
			public static Vector4 zyxy(this Vector3 v)
			{
				return new Vector4(v.z, v.y, v.x, v.y);
			}
			public static Vector4 zyxz(this Vector3 v)
			{
				return new Vector4(v.z, v.y, v.x, v.z);
			}
			
			public static Vector4 zyyx(this Vector3 v)
			{
				return new Vector4(v.z, v.y, v.y, v.x);
			}
			public static Vector4 zyyy(this Vector3 v)
			{
				return new Vector4(v.z, v.y, v.y, v.y);
			}
			public static Vector4 zyyz(this Vector3 v)
			{
				return new Vector4(v.z, v.y, v.y, v.z);
			}
			
			public static Vector4 zyzx(this Vector3 v)
			{
				return new Vector4(v.z, v.y, v.z, v.x);
			}
			public static Vector4 zyzy(this Vector3 v)
			{
				return new Vector4(v.z, v.y, v.z, v.y);
			}
			public static Vector4 zyzz(this Vector3 v)
			{
				return new Vector4(v.z, v.y, v.z, v.z);
			}
			
			#endregion
			
			#region zzxx-zzzz
			
			public static Vector4 zzxx(this Vector3 v)
			{
				return new Vector4(v.z, v.z, v.x, v.x);
			}
			public static Vector4 zzxy(this Vector3 v)
			{
				return new Vector4(v.z, v.z, v.x, v.y);
			}
			public static Vector4 zzxz(this Vector3 v)
			{
				return new Vector4(v.z, v.z, v.x, v.z);
			}
			
			public static Vector4 zzyx(this Vector3 v)
			{
				return new Vector4(v.z, v.z, v.y, v.x);
			}
			public static Vector4 zzyy(this Vector3 v)
			{
				return new Vector4(v.z, v.z, v.y, v.y);
			}
			public static Vector4 zzyz(this Vector3 v)
			{
				return new Vector4(v.z, v.z, v.y, v.z);
			}
			
			public static Vector4 zzzx(this Vector3 v)
			{
				return new Vector4(v.z, v.z, v.z, v.x);
			}
			public static Vector4 zzzy(this Vector3 v)
			{
				return new Vector4(v.z, v.z, v.z, v.y);
			}
			public static Vector4 zzzz(this Vector3 v)
			{
				return new Vector4(v.z, v.z, v.z, v.z);
			}
			
			#endregion
			
			#endregion
			
			#endregion
			
			#endregion
			
			#region Vector4 swizzles
			
			#region xx-ww
			
			public static Vector2 xx(this Vector4 v)
			{
				return new Vector2(v.x, v.x);
			}
			public static Vector2 xy(this Vector4 v)
			{
				return new Vector2(v.x, v.y);
			}
			public static Vector2 xz(this Vector4 v)
			{
				return new Vector2(v.x, v.z);
			}
			public static Vector2 xw(this Vector4 v)
			{
				return new Vector2(v.x, v.w);
			}
			
			public static Vector2 yx(this Vector4 v)
			{
				return new Vector2(v.y, v.x);
			}
			public static Vector2 yy(this Vector4 v)
			{
				return new Vector2(v.y, v.y);
			}
			public static Vector2 yz(this Vector4 v)
			{
				return new Vector2(v.y, v.z);
			}
			public static Vector2 yw(this Vector4 v)
			{
				return new Vector2(v.y, v.w);
			}
			
			public static Vector2 zx(this Vector4 v)
			{
				return new Vector2(v.z, v.x);
			}
			public static Vector2 zy(this Vector4 v)
			{
				return new Vector2(v.z, v.y);
			}
			public static Vector2 zz(this Vector4 v)
			{
				return new Vector2(v.z, v.z);
			}
			public static Vector2 zw(this Vector4 v)
			{
				return new Vector2(v.z, v.w);
			}
			
			public static Vector2 wx(this Vector4 v)
			{
				return new Vector2(v.w, v.x);
			}
			public static Vector2 wy(this Vector4 v)
			{
				return new Vector2(v.w, v.y);
			}
			public static Vector2 wz(this Vector4 v)
			{
				return new Vector2(v.w, v.z);
			}
			public static Vector2 ww(this Vector4 v)
			{
				return new Vector2(v.w, v.w);
			}
			
			#endregion
			
			#region xxx-www
			
			#region xxx-xww
			
			public static Vector3 xxx(this Vector4 v)
			{
				return new Vector3(v.x, v.x, v.x);
			}
			public static Vector3 xxy(this Vector4 v)
			{
				return new Vector3(v.x, v.x, v.y);
			}
			public static Vector3 xxz(this Vector4 v)
			{
				return new Vector3(v.x, v.x, v.z);
			}
			public static Vector3 xxw(this Vector4 v)
			{
				return new Vector3(v.x, v.x, v.w);
			}
			
			public static Vector3 xyx(this Vector4 v)
			{
				return new Vector3(v.x, v.y, v.x);
			}
			public static Vector3 xyy(this Vector4 v)
			{
				return new Vector3(v.x, v.y, v.y);
			}
			public static Vector3 xyz(this Vector4 v)
			{
				return new Vector3(v.x, v.y, v.z);
			}
			public static Vector3 xyw(this Vector4 v)
			{
				return new Vector3(v.x, v.y, v.w);
			}
			
			public static Vector3 xzx(this Vector4 v)
			{
				return new Vector3(v.x, v.z, v.x);
			}
			public static Vector3 xzy(this Vector4 v)
			{
				return new Vector3(v.x, v.z, v.y);
			}
			public static Vector3 xzz(this Vector4 v)
			{
				return new Vector3(v.x, v.z, v.z);
			}
			public static Vector3 xzw(this Vector4 v)
			{
				return new Vector3(v.x, v.z, v.w);
			}
			
			public static Vector3 xwx(this Vector4 v)
			{
				return new Vector3(v.x, v.w, v.x);
			}
			public static Vector3 xwy(this Vector4 v)
			{
				return new Vector3(v.x, v.w, v.y);
			}
			public static Vector3 xwz(this Vector4 v)
			{
				return new Vector3(v.x, v.w, v.z);
			}
			public static Vector3 xww(this Vector4 v)
			{
				return new Vector3(v.x, v.w, v.w);
			}
			
			#endregion
			
			#region yxx-yww
			
			public static Vector3 yxx(this Vector4 v)
			{
				return new Vector3(v.y, v.x, v.x);
			}
			public static Vector3 yxy(this Vector4 v)
			{
				return new Vector3(v.y, v.x, v.y);
			}
			public static Vector3 yxz(this Vector4 v)
			{
				return new Vector3(v.y, v.x, v.z);
			}
			public static Vector3 yxw(this Vector4 v)
			{
				return new Vector3(v.y, v.x, v.w);
			}
			
			public static Vector3 yyx(this Vector4 v)
			{
				return new Vector3(v.y, v.y, v.x);
			}
			public static Vector3 yyy(this Vector4 v)
			{
				return new Vector3(v.y, v.y, v.y);
			}
			public static Vector3 yyz(this Vector4 v)
			{
				return new Vector3(v.y, v.y, v.z);
			}
			public static Vector3 yyw(this Vector4 v)
			{
				return new Vector3(v.y, v.y, v.w);
			}
			
			public static Vector3 yzx(this Vector4 v)
			{
				return new Vector3(v.y, v.z, v.x);
			}
			public static Vector3 yzy(this Vector4 v)
			{
				return new Vector3(v.y, v.z, v.y);
			}
			public static Vector3 yzz(this Vector4 v)
			{
				return new Vector3(v.y, v.z, v.z);
			}
			public static Vector3 yzw(this Vector4 v)
			{
				return new Vector3(v.y, v.z, v.w);
			}
			
			public static Vector3 ywx(this Vector4 v)
			{
				return new Vector3(v.y, v.w, v.x);
			}
			public static Vector3 ywy(this Vector4 v)
			{
				return new Vector3(v.y, v.w, v.y);
			}
			public static Vector3 ywz(this Vector4 v)
			{
				return new Vector3(v.y, v.w, v.z);
			}
			public static Vector3 yww(this Vector4 v)
			{
				return new Vector3(v.y, v.w, v.w);
			}
			
			#endregion
			
			#region zxx-zww
			
			public static Vector3 zxx(this Vector4 v)
			{
				return new Vector3(v.z, v.x, v.x);
			}
			public static Vector3 zxy(this Vector4 v)
			{
				return new Vector3(v.z, v.x, v.y);
			}
			public static Vector3 zxz(this Vector4 v)
			{
				return new Vector3(v.z, v.x, v.z);
			}
			public static Vector3 zxw(this Vector4 v)
			{
				return new Vector3(v.z, v.x, v.w);
			}
			
			public static Vector3 zyx(this Vector4 v)
			{
				return new Vector3(v.z, v.y, v.x);
			}
			public static Vector3 zyy(this Vector4 v)
			{
				return new Vector3(v.z, v.y, v.y);
			}
			public static Vector3 zyz(this Vector4 v)
			{
				return new Vector3(v.z, v.y, v.z);
			}
			public static Vector3 zyw(this Vector4 v)
			{
				return new Vector3(v.z, v.y, v.w);
			}
			
			public static Vector3 zzx(this Vector4 v)
			{
				return new Vector3(v.z, v.z, v.x);
			}
			public static Vector3 zzy(this Vector4 v)
			{
				return new Vector3(v.z, v.z, v.y);
			}
			public static Vector3 zzz(this Vector4 v)
			{
				return new Vector3(v.z, v.z, v.z);
			}
			public static Vector3 zzw(this Vector4 v)
			{
				return new Vector3(v.z, v.z, v.w);
			}
			
			public static Vector3 zwx(this Vector4 v)
			{
				return new Vector3(v.z, v.w, v.x);
			}
			public static Vector3 zwy(this Vector4 v)
			{
				return new Vector3(v.z, v.w, v.y);
			}
			public static Vector3 zwz(this Vector4 v)
			{
				return new Vector3(v.z, v.w, v.z);
			}
			public static Vector3 zww(this Vector4 v)
			{
				return new Vector3(v.z, v.w, v.w);
			}
			
			#endregion
			
			#region wxx-www
			
			public static Vector3 wxx(this Vector4 v)
			{
				return new Vector3(v.w, v.x, v.x);
			}
			public static Vector3 wxy(this Vector4 v)
			{
				return new Vector3(v.w, v.x, v.y);
			}
			public static Vector3 wxz(this Vector4 v)
			{
				return new Vector3(v.w, v.x, v.z);
			}
			public static Vector3 wxw(this Vector4 v)
			{
				return new Vector3(v.w, v.x, v.w);
			}
			
			public static Vector3 wyx(this Vector4 v)
			{
				return new Vector3(v.w, v.y, v.x);
			}
			public static Vector3 wyy(this Vector4 v)
			{
				return new Vector3(v.w, v.y, v.y);
			}
			public static Vector3 wyz(this Vector4 v)
			{
				return new Vector3(v.w, v.y, v.z);
			}
			public static Vector3 wyw(this Vector4 v)
			{
				return new Vector3(v.w, v.y, v.w);
			}
			
			public static Vector3 wzx(this Vector4 v)
			{
				return new Vector3(v.w, v.z, v.x);
			}
			public static Vector3 wzy(this Vector4 v)
			{
				return new Vector3(v.w, v.z, v.y);
			}
			public static Vector3 wzz(this Vector4 v)
			{
				return new Vector3(v.w, v.z, v.z);
			}
			public static Vector3 wzw(this Vector4 v)
			{
				return new Vector3(v.w, v.z, v.w);
			}
			
			public static Vector3 wwx(this Vector4 v)
			{
				return new Vector3(v.w, v.w, v.x);
			}
			public static Vector3 wwy(this Vector4 v)
			{
				return new Vector3(v.w, v.w, v.y);
			}
			public static Vector3 wwz(this Vector4 v)
			{
				return new Vector3(v.w, v.w, v.z);
			}
			public static Vector3 www(this Vector4 v)
			{
				return new Vector3(v.w, v.w, v.w);
			}
			
			#endregion
			
			#endregion
			
			#region xxxx-wwww
			
			#region xxxx-xwww
			
			#region xxxx-xxww
			
			public static Vector4 xxxx(this Vector4 v)
			{
				return new Vector4(v.x, v.x, v.x, v.x);
			}
			public static Vector4 xxxy(this Vector4 v)
			{
				return new Vector4(v.x, v.x, v.x, v.y);
			}
			public static Vector4 xxxz(this Vector4 v)
			{
				return new Vector4(v.x, v.x, v.x, v.z);
			}
			public static Vector4 xxxw(this Vector4 v)
			{
				return new Vector4(v.x, v.x, v.x, v.w);
			}
			
			public static Vector4 xxyx(this Vector4 v)
			{
				return new Vector4(v.x, v.x, v.y, v.x);
			}
			public static Vector4 xxyy(this Vector4 v)
			{
				return new Vector4(v.x, v.x, v.y, v.y);
			}
			public static Vector4 xxyz(this Vector4 v)
			{
				return new Vector4(v.x, v.x, v.y, v.z);
			}
			public static Vector4 xxyw(this Vector4 v)
			{
				return new Vector4(v.x, v.x, v.y, v.w);
			}
			
			public static Vector4 xxzx(this Vector4 v)
			{
				return new Vector4(v.x, v.x, v.z, v.x);
			}
			public static Vector4 xxzy(this Vector4 v)
			{
				return new Vector4(v.x, v.x, v.z, v.y);
			}
			public static Vector4 xxzz(this Vector4 v)
			{
				return new Vector4(v.x, v.x, v.z, v.z);
			}
			public static Vector4 xxzw(this Vector4 v)
			{
				return new Vector4(v.x, v.x, v.z, v.w);
			}
			
			public static Vector4 xxwx(this Vector4 v)
			{
				return new Vector4(v.x, v.x, v.w, v.x);
			}
			public static Vector4 xxwy(this Vector4 v)
			{
				return new Vector4(v.x, v.x, v.w, v.y);
			}
			public static Vector4 xxwz(this Vector4 v)
			{
				return new Vector4(v.x, v.x, v.w, v.z);
			}
			public static Vector4 xxww(this Vector4 v)
			{
				return new Vector4(v.x, v.x, v.w, v.w);
			}
			
			#endregion
			
			#region xyxx-xyww
			
			public static Vector4 xyxx(this Vector4 v)
			{
				return new Vector4(v.x, v.y, v.x, v.x);
			}
			public static Vector4 xyxy(this Vector4 v)
			{
				return new Vector4(v.x, v.y, v.x, v.y);
			}
			public static Vector4 xyxz(this Vector4 v)
			{
				return new Vector4(v.x, v.y, v.x, v.z);
			}
			public static Vector4 xyxw(this Vector4 v)
			{
				return new Vector4(v.x, v.y, v.x, v.w);
			}
			
			public static Vector4 xyyx(this Vector4 v)
			{
				return new Vector4(v.x, v.y, v.y, v.x);
			}
			public static Vector4 xyyy(this Vector4 v)
			{
				return new Vector4(v.x, v.y, v.y, v.y);
			}
			public static Vector4 xyyz(this Vector4 v)
			{
				return new Vector4(v.x, v.y, v.y, v.z);
			}
			public static Vector4 xyyw(this Vector4 v)
			{
				return new Vector4(v.x, v.y, v.y, v.w);
			}
			
			public static Vector4 xyzx(this Vector4 v)
			{
				return new Vector4(v.x, v.y, v.z, v.x);
			}
			public static Vector4 xyzy(this Vector4 v)
			{
				return new Vector4(v.x, v.y, v.z, v.y);
			}
			public static Vector4 xyzz(this Vector4 v)
			{
				return new Vector4(v.x, v.y, v.z, v.z);
			}
			public static Vector4 xyzw(this Vector4 v)
			{
				return new Vector4(v.x, v.y, v.z, v.w);
			}
			
			public static Vector4 xywx(this Vector4 v)
			{
				return new Vector4(v.x, v.y, v.w, v.x);
			}
			public static Vector4 xywy(this Vector4 v)
			{
				return new Vector4(v.x, v.y, v.w, v.y);
			}
			public static Vector4 xywz(this Vector4 v)
			{
				return new Vector4(v.x, v.y, v.w, v.z);
			}
			public static Vector4 xyww(this Vector4 v)
			{
				return new Vector4(v.x, v.y, v.w, v.w);
			}
			
			#endregion
			
			#region xzxx-xzww
			
			public static Vector4 xzxx(this Vector4 v)
			{
				return new Vector4(v.x, v.z, v.x, v.x);
			}
			public static Vector4 xzxy(this Vector4 v)
			{
				return new Vector4(v.x, v.z, v.x, v.y);
			}
			public static Vector4 xzxz(this Vector4 v)
			{
				return new Vector4(v.x, v.z, v.x, v.z);
			}
			public static Vector4 xzxw(this Vector4 v)
			{
				return new Vector4(v.x, v.z, v.x, v.w);
			}
			
			public static Vector4 xzyx(this Vector4 v)
			{
				return new Vector4(v.x, v.z, v.y, v.x);
			}
			public static Vector4 xzyy(this Vector4 v)
			{
				return new Vector4(v.x, v.z, v.y, v.y);
			}
			public static Vector4 xzyz(this Vector4 v)
			{
				return new Vector4(v.x, v.z, v.y, v.z);
			}
			public static Vector4 xzyw(this Vector4 v)
			{
				return new Vector4(v.x, v.z, v.y, v.w);
			}
			
			public static Vector4 xzzx(this Vector4 v)
			{
				return new Vector4(v.x, v.z, v.z, v.x);
			}
			public static Vector4 xzzy(this Vector4 v)
			{
				return new Vector4(v.x, v.z, v.z, v.y);
			}
			public static Vector4 xzzz(this Vector4 v)
			{
				return new Vector4(v.x, v.z, v.z, v.z);
			}
			public static Vector4 xzzw(this Vector4 v)
			{
				return new Vector4(v.x, v.z, v.z, v.w);
			}
			
			public static Vector4 xzwx(this Vector4 v)
			{
				return new Vector4(v.x, v.z, v.w, v.x);
			}
			public static Vector4 xzwy(this Vector4 v)
			{
				return new Vector4(v.x, v.z, v.w, v.y);
			}
			public static Vector4 xzwz(this Vector4 v)
			{
				return new Vector4(v.x, v.z, v.w, v.z);
			}
			public static Vector4 xzww(this Vector4 v)
			{
				return new Vector4(v.x, v.z, v.w, v.w);
			}
			
			#endregion
			
			#region xwxx-xwww
			
			public static Vector4 xwxx(this Vector4 v)
			{
				return new Vector4(v.x, v.w, v.x, v.x);
			}
			public static Vector4 xwxy(this Vector4 v)
			{
				return new Vector4(v.x, v.w, v.x, v.y);
			}
			public static Vector4 xwxz(this Vector4 v)
			{
				return new Vector4(v.x, v.w, v.x, v.z);
			}
			public static Vector4 xwxw(this Vector4 v)
			{
				return new Vector4(v.x, v.w, v.x, v.w);
			}
			
			public static Vector4 xwyx(this Vector4 v)
			{
				return new Vector4(v.x, v.w, v.y, v.x);
			}
			public static Vector4 xwyy(this Vector4 v)
			{
				return new Vector4(v.x, v.w, v.y, v.y);
			}
			public static Vector4 xwyz(this Vector4 v)
			{
				return new Vector4(v.x, v.w, v.y, v.z);
			}
			public static Vector4 xwyw(this Vector4 v)
			{
				return new Vector4(v.x, v.w, v.y, v.w);
			}
			
			public static Vector4 xwzx(this Vector4 v)
			{
				return new Vector4(v.x, v.w, v.z, v.x);
			}
			public static Vector4 xwzy(this Vector4 v)
			{
				return new Vector4(v.x, v.w, v.z, v.y);
			}
			public static Vector4 xwzz(this Vector4 v)
			{
				return new Vector4(v.x, v.w, v.z, v.z);
			}
			public static Vector4 xwzw(this Vector4 v)
			{
				return new Vector4(v.x, v.w, v.z, v.w);
			}
			
			public static Vector4 xwwx(this Vector4 v)
			{
				return new Vector4(v.x, v.w, v.w, v.x);
			}
			public static Vector4 xwwy(this Vector4 v)
			{
				return new Vector4(v.x, v.w, v.w, v.y);
			}
			public static Vector4 xwwz(this Vector4 v)
			{
				return new Vector4(v.x, v.w, v.w, v.z);
			}
			public static Vector4 xwww(this Vector4 v)
			{
				return new Vector4(v.x, v.w, v.w, v.w);
			}
			
			#endregion
			
			#endregion
			
			#region yxxx-ywww
			
			#region yxxx-yxww
			
			public static Vector4 yxxx(this Vector4 v)
			{
				return new Vector4(v.y, v.x, v.x, v.x);
			}
			public static Vector4 yxxy(this Vector4 v)
			{
				return new Vector4(v.y, v.x, v.x, v.y);
			}
			public static Vector4 yxxz(this Vector4 v)
			{
				return new Vector4(v.y, v.x, v.x, v.z);
			}
			public static Vector4 yxxw(this Vector4 v)
			{
				return new Vector4(v.y, v.x, v.x, v.w);
			}
			
			public static Vector4 yxyx(this Vector4 v)
			{
				return new Vector4(v.y, v.x, v.y, v.x);
			}
			public static Vector4 yxyy(this Vector4 v)
			{
				return new Vector4(v.y, v.x, v.y, v.y);
			}
			public static Vector4 yxyz(this Vector4 v)
			{
				return new Vector4(v.y, v.x, v.y, v.z);
			}
			public static Vector4 yxyw(this Vector4 v)
			{
				return new Vector4(v.y, v.x, v.y, v.w);
			}
			
			public static Vector4 yxzx(this Vector4 v)
			{
				return new Vector4(v.y, v.x, v.z, v.x);
			}
			public static Vector4 yxzy(this Vector4 v)
			{
				return new Vector4(v.y, v.x, v.z, v.y);
			}
			public static Vector4 yxzz(this Vector4 v)
			{
				return new Vector4(v.y, v.x, v.z, v.z);
			}
			public static Vector4 yxzw(this Vector4 v)
			{
				return new Vector4(v.y, v.x, v.z, v.w);
			}
			
			public static Vector4 yxwx(this Vector4 v)
			{
				return new Vector4(v.y, v.x, v.w, v.x);
			}
			public static Vector4 yxwy(this Vector4 v)
			{
				return new Vector4(v.y, v.x, v.w, v.y);
			}
			public static Vector4 yxwz(this Vector4 v)
			{
				return new Vector4(v.y, v.x, v.w, v.z);
			}
			public static Vector4 yxww(this Vector4 v)
			{
				return new Vector4(v.y, v.x, v.w, v.w);
			}
			
			#endregion
			
			#region yyxx-yyww
			
			public static Vector4 yyxx(this Vector4 v)
			{
				return new Vector4(v.y, v.y, v.x, v.x);
			}
			public static Vector4 yyxy(this Vector4 v)
			{
				return new Vector4(v.y, v.y, v.x, v.y);
			}
			public static Vector4 yyxz(this Vector4 v)
			{
				return new Vector4(v.y, v.y, v.x, v.z);
			}
			public static Vector4 yyxw(this Vector4 v)
			{
				return new Vector4(v.y, v.y, v.x, v.w);
			}
			
			public static Vector4 yyyx(this Vector4 v)
			{
				return new Vector4(v.y, v.y, v.y, v.x);
			}
			public static Vector4 yyyy(this Vector4 v)
			{
				return new Vector4(v.y, v.y, v.y, v.y);
			}
			public static Vector4 yyyz(this Vector4 v)
			{
				return new Vector4(v.y, v.y, v.y, v.z);
			}
			public static Vector4 yyyw(this Vector4 v)
			{
				return new Vector4(v.y, v.y, v.y, v.w);
			}
			
			public static Vector4 yyzx(this Vector4 v)
			{
				return new Vector4(v.y, v.y, v.z, v.x);
			}
			public static Vector4 yyzy(this Vector4 v)
			{
				return new Vector4(v.y, v.y, v.z, v.y);
			}
			public static Vector4 yyzz(this Vector4 v)
			{
				return new Vector4(v.y, v.y, v.z, v.z);
			}
			public static Vector4 yyzw(this Vector4 v)
			{
				return new Vector4(v.y, v.y, v.z, v.w);
			}
			
			public static Vector4 yywx(this Vector4 v)
			{
				return new Vector4(v.y, v.y, v.w, v.x);
			}
			public static Vector4 yywy(this Vector4 v)
			{
				return new Vector4(v.y, v.y, v.w, v.y);
			}
			public static Vector4 yywz(this Vector4 v)
			{
				return new Vector4(v.y, v.y, v.w, v.z);
			}
			public static Vector4 yyww(this Vector4 v)
			{
				return new Vector4(v.y, v.y, v.w, v.w);
			}
			
			#endregion
			
			#region yzxx-yzww
			
			public static Vector4 yzxx(this Vector4 v)
			{
				return new Vector4(v.y, v.z, v.x, v.x);
			}
			public static Vector4 yzxy(this Vector4 v)
			{
				return new Vector4(v.y, v.z, v.x, v.y);
			}
			public static Vector4 yzxz(this Vector4 v)
			{
				return new Vector4(v.y, v.z, v.x, v.z);
			}
			public static Vector4 yzxw(this Vector4 v)
			{
				return new Vector4(v.y, v.z, v.x, v.w);
			}
			
			public static Vector4 yzyx(this Vector4 v)
			{
				return new Vector4(v.y, v.z, v.y, v.x);
			}
			public static Vector4 yzyy(this Vector4 v)
			{
				return new Vector4(v.y, v.z, v.y, v.y);
			}
			public static Vector4 yzyz(this Vector4 v)
			{
				return new Vector4(v.y, v.z, v.y, v.z);
			}
			public static Vector4 yzyw(this Vector4 v)
			{
				return new Vector4(v.y, v.z, v.y, v.w);
			}
			
			public static Vector4 yzzx(this Vector4 v)
			{
				return new Vector4(v.y, v.z, v.z, v.x);
			}
			public static Vector4 yzzy(this Vector4 v)
			{
				return new Vector4(v.y, v.z, v.z, v.y);
			}
			public static Vector4 yzzz(this Vector4 v)
			{
				return new Vector4(v.y, v.z, v.z, v.z);
			}
			public static Vector4 yzzw(this Vector4 v)
			{
				return new Vector4(v.y, v.z, v.z, v.w);
			}
			
			public static Vector4 yzwx(this Vector4 v)
			{
				return new Vector4(v.y, v.z, v.w, v.x);
			}
			public static Vector4 yzwy(this Vector4 v)
			{
				return new Vector4(v.y, v.z, v.w, v.y);
			}
			public static Vector4 yzwz(this Vector4 v)
			{
				return new Vector4(v.y, v.z, v.w, v.z);
			}
			public static Vector4 yzww(this Vector4 v)
			{
				return new Vector4(v.y, v.z, v.w, v.w);
			}
			
			#endregion
			
			#region ywxx-ywww
			
			public static Vector4 ywxx(this Vector4 v)
			{
				return new Vector4(v.y, v.w, v.x, v.x);
			}
			public static Vector4 ywxy(this Vector4 v)
			{
				return new Vector4(v.y, v.w, v.x, v.y);
			}
			public static Vector4 ywxz(this Vector4 v)
			{
				return new Vector4(v.y, v.w, v.x, v.z);
			}
			public static Vector4 ywxw(this Vector4 v)
			{
				return new Vector4(v.y, v.w, v.x, v.w);
			}
			
			public static Vector4 ywyx(this Vector4 v)
			{
				return new Vector4(v.y, v.w, v.y, v.x);
			}
			public static Vector4 ywyy(this Vector4 v)
			{
				return new Vector4(v.y, v.w, v.y, v.y);
			}
			public static Vector4 ywyz(this Vector4 v)
			{
				return new Vector4(v.y, v.w, v.y, v.z);
			}
			public static Vector4 ywyw(this Vector4 v)
			{
				return new Vector4(v.y, v.w, v.y, v.w);
			}
			
			public static Vector4 ywzx(this Vector4 v)
			{
				return new Vector4(v.y, v.w, v.z, v.x);
			}
			public static Vector4 ywzy(this Vector4 v)
			{
				return new Vector4(v.y, v.w, v.z, v.y);
			}
			public static Vector4 ywzz(this Vector4 v)
			{
				return new Vector4(v.y, v.w, v.z, v.z);
			}
			public static Vector4 ywzw(this Vector4 v)
			{
				return new Vector4(v.y, v.w, v.z, v.w);
			}
			
			public static Vector4 ywwx(this Vector4 v)
			{
				return new Vector4(v.y, v.w, v.w, v.x);
			}
			public static Vector4 ywwy(this Vector4 v)
			{
				return new Vector4(v.y, v.w, v.w, v.y);
			}
			public static Vector4 ywwz(this Vector4 v)
			{
				return new Vector4(v.y, v.w, v.w, v.z);
			}
			public static Vector4 ywww(this Vector4 v)
			{
				return new Vector4(v.y, v.w, v.w, v.w);
			}
			
			#endregion
			
			#endregion
			
			#region zxxx-zwww
			
			#region zxxx-zxww
			
			public static Vector4 zxxx(this Vector4 v)
			{
				return new Vector4(v.z, v.x, v.x, v.x);
			}
			public static Vector4 zxxy(this Vector4 v)
			{
				return new Vector4(v.z, v.x, v.x, v.y);
			}
			public static Vector4 zxxz(this Vector4 v)
			{
				return new Vector4(v.z, v.x, v.x, v.z);
			}
			public static Vector4 zxxw(this Vector4 v)
			{
				return new Vector4(v.z, v.x, v.x, v.w);
			}
			
			public static Vector4 zxyx(this Vector4 v)
			{
				return new Vector4(v.z, v.x, v.y, v.x);
			}
			public static Vector4 zxyy(this Vector4 v)
			{
				return new Vector4(v.z, v.x, v.y, v.y);
			}
			public static Vector4 zxyz(this Vector4 v)
			{
				return new Vector4(v.z, v.x, v.y, v.z);
			}
			public static Vector4 zxyw(this Vector4 v)
			{
				return new Vector4(v.z, v.x, v.y, v.w);
			}
			
			public static Vector4 zxzx(this Vector4 v)
			{
				return new Vector4(v.z, v.x, v.z, v.x);
			}
			public static Vector4 zxzy(this Vector4 v)
			{
				return new Vector4(v.z, v.x, v.z, v.y);
			}
			public static Vector4 zxzz(this Vector4 v)
			{
				return new Vector4(v.z, v.x, v.z, v.z);
			}
			public static Vector4 zxzw(this Vector4 v)
			{
				return new Vector4(v.z, v.x, v.z, v.w);
			}
			
			public static Vector4 zxwx(this Vector4 v)
			{
				return new Vector4(v.z, v.x, v.w, v.x);
			}
			public static Vector4 zxwy(this Vector4 v)
			{
				return new Vector4(v.z, v.x, v.w, v.y);
			}
			public static Vector4 zxwz(this Vector4 v)
			{
				return new Vector4(v.z, v.x, v.w, v.z);
			}
			public static Vector4 zxww(this Vector4 v)
			{
				return new Vector4(v.z, v.x, v.w, v.w);
			}
			
			#endregion
			
			#region zyxx-zyww
			
			public static Vector4 zyxx(this Vector4 v)
			{
				return new Vector4(v.z, v.y, v.x, v.x);
			}
			public static Vector4 zyxy(this Vector4 v)
			{
				return new Vector4(v.z, v.y, v.x, v.y);
			}
			public static Vector4 zyxz(this Vector4 v)
			{
				return new Vector4(v.z, v.y, v.x, v.z);
			}
			public static Vector4 zyxw(this Vector4 v)
			{
				return new Vector4(v.z, v.y, v.x, v.w);
			}
			
			public static Vector4 zyyx(this Vector4 v)
			{
				return new Vector4(v.z, v.y, v.y, v.x);
			}
			public static Vector4 zyyy(this Vector4 v)
			{
				return new Vector4(v.z, v.y, v.y, v.y);
			}
			public static Vector4 zyyz(this Vector4 v)
			{
				return new Vector4(v.z, v.y, v.y, v.z);
			}
			public static Vector4 zyyw(this Vector4 v)
			{
				return new Vector4(v.z, v.y, v.y, v.w);
			}
			
			public static Vector4 zyzx(this Vector4 v)
			{
				return new Vector4(v.z, v.y, v.z, v.x);
			}
			public static Vector4 zyzy(this Vector4 v)
			{
				return new Vector4(v.z, v.y, v.z, v.y);
			}
			public static Vector4 zyzz(this Vector4 v)
			{
				return new Vector4(v.z, v.y, v.z, v.z);
			}
			public static Vector4 zyzw(this Vector4 v)
			{
				return new Vector4(v.z, v.y, v.z, v.w);
			}
			
			public static Vector4 zywx(this Vector4 v)
			{
				return new Vector4(v.z, v.y, v.w, v.x);
			}
			public static Vector4 zywy(this Vector4 v)
			{
				return new Vector4(v.z, v.y, v.w, v.y);
			}
			public static Vector4 zywz(this Vector4 v)
			{
				return new Vector4(v.z, v.y, v.w, v.z);
			}
			public static Vector4 zyww(this Vector4 v)
			{
				return new Vector4(v.z, v.y, v.w, v.w);
			}
			
			#endregion
			
			#region xzxx-xzww
			
			public static Vector4 zzxx(this Vector4 v)
			{
				return new Vector4(v.z, v.z, v.x, v.x);
			}
			public static Vector4 zzxy(this Vector4 v)
			{
				return new Vector4(v.z, v.z, v.x, v.y);
			}
			public static Vector4 zzxz(this Vector4 v)
			{
				return new Vector4(v.z, v.z, v.x, v.z);
			}
			public static Vector4 zzxw(this Vector4 v)
			{
				return new Vector4(v.z, v.z, v.x, v.w);
			}
			
			public static Vector4 zzyx(this Vector4 v)
			{
				return new Vector4(v.z, v.z, v.y, v.x);
			}
			public static Vector4 zzyy(this Vector4 v)
			{
				return new Vector4(v.z, v.z, v.y, v.y);
			}
			public static Vector4 zzyz(this Vector4 v)
			{
				return new Vector4(v.z, v.z, v.y, v.z);
			}
			public static Vector4 zzyw(this Vector4 v)
			{
				return new Vector4(v.z, v.z, v.y, v.w);
			}
			
			public static Vector4 zzzx(this Vector4 v)
			{
				return new Vector4(v.z, v.z, v.z, v.x);
			}
			public static Vector4 zzzy(this Vector4 v)
			{
				return new Vector4(v.z, v.z, v.z, v.y);
			}
			public static Vector4 zzzz(this Vector4 v)
			{
				return new Vector4(v.z, v.z, v.z, v.z);
			}
			public static Vector4 zzzw(this Vector4 v)
			{
				return new Vector4(v.z, v.z, v.z, v.w);
			}
			
			public static Vector4 zzwx(this Vector4 v)
			{
				return new Vector4(v.z, v.z, v.w, v.x);
			}
			public static Vector4 zzwy(this Vector4 v)
			{
				return new Vector4(v.z, v.z, v.w, v.y);
			}
			public static Vector4 zzwz(this Vector4 v)
			{
				return new Vector4(v.z, v.z, v.w, v.z);
			}
			public static Vector4 zzww(this Vector4 v)
			{
				return new Vector4(v.z, v.z, v.w, v.w);
			}
			
			#endregion
			
			#region zwxx-zwww
			
			public static Vector4 zwxx(this Vector4 v)
			{
				return new Vector4(v.z, v.w, v.x, v.x);
			}
			public static Vector4 zwxy(this Vector4 v)
			{
				return new Vector4(v.z, v.w, v.x, v.y);
			}
			public static Vector4 zwxz(this Vector4 v)
			{
				return new Vector4(v.z, v.w, v.x, v.z);
			}
			public static Vector4 zwxw(this Vector4 v)
			{
				return new Vector4(v.z, v.w, v.x, v.w);
			}
			
			public static Vector4 zwyx(this Vector4 v)
			{
				return new Vector4(v.z, v.w, v.y, v.x);
			}
			public static Vector4 zwyy(this Vector4 v)
			{
				return new Vector4(v.z, v.w, v.y, v.y);
			}
			public static Vector4 zwyz(this Vector4 v)
			{
				return new Vector4(v.z, v.w, v.y, v.z);
			}
			public static Vector4 zwyw(this Vector4 v)
			{
				return new Vector4(v.z, v.w, v.y, v.w);
			}
			
			public static Vector4 zwzx(this Vector4 v)
			{
				return new Vector4(v.z, v.w, v.z, v.x);
			}
			public static Vector4 zwzy(this Vector4 v)
			{
				return new Vector4(v.z, v.w, v.z, v.y);
			}
			public static Vector4 zwzz(this Vector4 v)
			{
				return new Vector4(v.z, v.w, v.z, v.z);
			}
			public static Vector4 zwzw(this Vector4 v)
			{
				return new Vector4(v.z, v.w, v.z, v.w);
			}
			
			public static Vector4 zwwx(this Vector4 v)
			{
				return new Vector4(v.z, v.w, v.w, v.x);
			}
			public static Vector4 zwwy(this Vector4 v)
			{
				return new Vector4(v.z, v.w, v.w, v.y);
			}
			public static Vector4 zwwz(this Vector4 v)
			{
				return new Vector4(v.z, v.w, v.w, v.z);
			}
			public static Vector4 zwww(this Vector4 v)
			{
				return new Vector4(v.z, v.w, v.w, v.w);
			}
			
			#endregion
			
			#endregion
			
			#region wxxx-wwww
			
			#region wxxx-wxww
			
			public static Vector4 wxxx(this Vector4 v)
			{
				return new Vector4(v.w, v.x, v.x, v.x);
			}
			public static Vector4 wxxy(this Vector4 v)
			{
				return new Vector4(v.w, v.x, v.x, v.y);
			}
			public static Vector4 wxxz(this Vector4 v)
			{
				return new Vector4(v.w, v.x, v.x, v.z);
			}
			public static Vector4 wxxw(this Vector4 v)
			{
				return new Vector4(v.w, v.x, v.x, v.w);
			}
			
			public static Vector4 wxyx(this Vector4 v)
			{
				return new Vector4(v.w, v.x, v.y, v.x);
			}
			public static Vector4 wxyy(this Vector4 v)
			{
				return new Vector4(v.w, v.x, v.y, v.y);
			}
			public static Vector4 wxyz(this Vector4 v)
			{
				return new Vector4(v.w, v.x, v.y, v.z);
			}
			public static Vector4 wxyw(this Vector4 v)
			{
				return new Vector4(v.w, v.x, v.y, v.w);
			}
			
			public static Vector4 wxzx(this Vector4 v)
			{
				return new Vector4(v.w, v.x, v.z, v.x);
			}
			public static Vector4 wxzy(this Vector4 v)
			{
				return new Vector4(v.w, v.x, v.z, v.y);
			}
			public static Vector4 wxzz(this Vector4 v)
			{
				return new Vector4(v.w, v.x, v.z, v.z);
			}
			public static Vector4 wxzw(this Vector4 v)
			{
				return new Vector4(v.w, v.x, v.z, v.w);
			}
			
			public static Vector4 wxwx(this Vector4 v)
			{
				return new Vector4(v.w, v.x, v.w, v.x);
			}
			public static Vector4 wxwy(this Vector4 v)
			{
				return new Vector4(v.w, v.x, v.w, v.y);
			}
			public static Vector4 wxwz(this Vector4 v)
			{
				return new Vector4(v.w, v.x, v.w, v.z);
			}
			public static Vector4 wxww(this Vector4 v)
			{
				return new Vector4(v.w, v.x, v.w, v.w);
			}
			
			#endregion
			
			#region wyxx-wyww
			
			public static Vector4 wyxx(this Vector4 v)
			{
				return new Vector4(v.w, v.y, v.x, v.x);
			}
			public static Vector4 wyxy(this Vector4 v)
			{
				return new Vector4(v.w, v.y, v.x, v.y);
			}
			public static Vector4 wyxz(this Vector4 v)
			{
				return new Vector4(v.w, v.y, v.x, v.z);
			}
			public static Vector4 wyxw(this Vector4 v)
			{
				return new Vector4(v.w, v.y, v.x, v.w);
			}
			
			public static Vector4 wyyx(this Vector4 v)
			{
				return new Vector4(v.w, v.y, v.y, v.x);
			}
			public static Vector4 wyyy(this Vector4 v)
			{
				return new Vector4(v.w, v.y, v.y, v.y);
			}
			public static Vector4 wyyz(this Vector4 v)
			{
				return new Vector4(v.w, v.y, v.y, v.z);
			}
			public static Vector4 wyyw(this Vector4 v)
			{
				return new Vector4(v.w, v.y, v.y, v.w);
			}
			
			public static Vector4 wyzx(this Vector4 v)
			{
				return new Vector4(v.w, v.y, v.z, v.x);
			}
			public static Vector4 wyzy(this Vector4 v)
			{
				return new Vector4(v.w, v.y, v.z, v.y);
			}
			public static Vector4 wyzz(this Vector4 v)
			{
				return new Vector4(v.w, v.y, v.z, v.z);
			}
			public static Vector4 wyzw(this Vector4 v)
			{
				return new Vector4(v.w, v.y, v.z, v.w);
			}
			
			public static Vector4 wywx(this Vector4 v)
			{
				return new Vector4(v.w, v.y, v.w, v.x);
			}
			public static Vector4 wywy(this Vector4 v)
			{
				return new Vector4(v.w, v.y, v.w, v.y);
			}
			public static Vector4 wywz(this Vector4 v)
			{
				return new Vector4(v.w, v.y, v.w, v.z);
			}
			public static Vector4 wyww(this Vector4 v)
			{
				return new Vector4(v.w, v.y, v.w, v.w);
			}
			
			#endregion
			
			#region wzxx-wzww
			
			public static Vector4 wzxx(this Vector4 v)
			{
				return new Vector4(v.w, v.z, v.x, v.x);
			}
			public static Vector4 wzxy(this Vector4 v)
			{
				return new Vector4(v.w, v.z, v.x, v.y);
			}
			public static Vector4 wzxz(this Vector4 v)
			{
				return new Vector4(v.w, v.z, v.x, v.z);
			}
			public static Vector4 wzxw(this Vector4 v)
			{
				return new Vector4(v.w, v.z, v.x, v.w);
			}
			
			public static Vector4 wzyx(this Vector4 v)
			{
				return new Vector4(v.w, v.z, v.y, v.x);
			}
			public static Vector4 wzyy(this Vector4 v)
			{
				return new Vector4(v.w, v.z, v.y, v.y);
			}
			public static Vector4 wzyz(this Vector4 v)
			{
				return new Vector4(v.w, v.z, v.y, v.z);
			}
			public static Vector4 wzyw(this Vector4 v)
			{
				return new Vector4(v.w, v.z, v.y, v.w);
			}
			
			public static Vector4 wzzx(this Vector4 v)
			{
				return new Vector4(v.w, v.z, v.z, v.x);
			}
			public static Vector4 wzzy(this Vector4 v)
			{
				return new Vector4(v.w, v.z, v.z, v.y);
			}
			public static Vector4 wzzz(this Vector4 v)
			{
				return new Vector4(v.w, v.z, v.z, v.z);
			}
			public static Vector4 wzzw(this Vector4 v)
			{
				return new Vector4(v.w, v.z, v.z, v.w);
			}
			
			public static Vector4 wzwx(this Vector4 v)
			{
				return new Vector4(v.w, v.z, v.w, v.x);
			}
			public static Vector4 wzwy(this Vector4 v)
			{
				return new Vector4(v.w, v.z, v.w, v.y);
			}
			public static Vector4 wzwz(this Vector4 v)
			{
				return new Vector4(v.w, v.z, v.w, v.z);
			}
			public static Vector4 wzww(this Vector4 v)
			{
				return new Vector4(v.w, v.z, v.w, v.w);
			}
			
			#endregion
			
			#region wwxx-wwww
			
			public static Vector4 wwxx(this Vector4 v)
			{
				return new Vector4(v.w, v.w, v.x, v.x);
			}
			public static Vector4 wwxy(this Vector4 v)
			{
				return new Vector4(v.w, v.w, v.x, v.y);
			}
			public static Vector4 wwxz(this Vector4 v)
			{
				return new Vector4(v.w, v.w, v.x, v.z);
			}
			public static Vector4 wwxw(this Vector4 v)
			{
				return new Vector4(v.w, v.w, v.x, v.w);
			}
			
			public static Vector4 wwyx(this Vector4 v)
			{
				return new Vector4(v.w, v.w, v.y, v.x);
			}
			public static Vector4 wwyy(this Vector4 v)
			{
				return new Vector4(v.w, v.w, v.y, v.y);
			}
			public static Vector4 wwyz(this Vector4 v)
			{
				return new Vector4(v.w, v.w, v.y, v.z);
			}
			public static Vector4 wwyw(this Vector4 v)
			{
				return new Vector4(v.w, v.w, v.y, v.w);
			}
			
			public static Vector4 wwzx(this Vector4 v)
			{
				return new Vector4(v.w, v.w, v.z, v.x);
			}
			public static Vector4 wwzy(this Vector4 v)
			{
				return new Vector4(v.w, v.w, v.z, v.y);
			}
			public static Vector4 wwzz(this Vector4 v)
			{
				return new Vector4(v.w, v.w, v.z, v.z);
			}
			public static Vector4 wwzw(this Vector4 v)
			{
				return new Vector4(v.w, v.w, v.z, v.w);
			}
			
			public static Vector4 wwwx(this Vector4 v)
			{
				return new Vector4(v.w, v.w, v.w, v.x);
			}
			public static Vector4 wwwy(this Vector4 v)
			{
				return new Vector4(v.w, v.w, v.w, v.y);
			}
			public static Vector4 wwwz(this Vector4 v)
			{
				return new Vector4(v.w, v.w, v.w, v.z);
			}
			public static Vector4 wwww(this Vector4 v)
			{
				return new Vector4(v.w, v.w, v.w, v.w);
			}
			
			#endregion
			
			#endregion
			
			#endregion
			
			#endregion
			
			#region Color swizzles
			
			#region rrr-aaa
			
			#region rrr-raa
			
			public static Color rrr(this Color c)
			{
				return new Color(c.r, c.r, c.r);
			}
			public static Color rrg(this Color c)
			{
				return new Color(c.r, c.r, c.g);
			}
			public static Color rrb(this Color c)
			{
				return new Color(c.r, c.r, c.b);
			}
			public static Color rra(this Color c)
			{
				return new Color(c.r, c.r, c.a);
			}
			
			public static Color rgr(this Color c)
			{
				return new Color(c.r, c.g, c.r);
			}
			public static Color rgg(this Color c)
			{
				return new Color(c.r, c.g, c.g);
			}
			public static Color rgb(this Color c)
			{
				return new Color(c.r, c.g, c.b);
			}
			public static Color rga(this Color c)
			{
				return new Color(c.r, c.g, c.a);
			}
			
			public static Color rbr(this Color c)
			{
				return new Color(c.r, c.b, c.r);
			}
			public static Color rbg(this Color c)
			{
				return new Color(c.r, c.b, c.g);
			}
			public static Color rbb(this Color c)
			{
				return new Color(c.r, c.b, c.b);
			}
			public static Color rba(this Color c)
			{
				return new Color(c.r, c.b, c.a);
			}
			
			public static Color rar(this Color c)
			{
				return new Color(c.r, c.a, c.r);
			}
			public static Color rag(this Color c)
			{
				return new Color(c.r, c.a, c.g);
			}
			public static Color rab(this Color c)
			{
				return new Color(c.r, c.a, c.b);
			}
			public static Color raa(this Color c)
			{
				return new Color(c.r, c.a, c.a);
			}
			
			#endregion
			
			#region grr-gaa
			
			public static Color grr(this Color c)
			{
				return new Color(c.g, c.r, c.r);
			}
			public static Color grg(this Color c)
			{
				return new Color(c.g, c.r, c.g);
			}
			public static Color grb(this Color c)
			{
				return new Color(c.g, c.r, c.b);
			}
			public static Color gra(this Color c)
			{
				return new Color(c.g, c.r, c.a);
			}
			
			public static Color ggr(this Color c)
			{
				return new Color(c.g, c.g, c.r);
			}
			public static Color ggg(this Color c)
			{
				return new Color(c.g, c.g, c.g);
			}
			public static Color ggb(this Color c)
			{
				return new Color(c.g, c.g, c.b);
			}
			public static Color gga(this Color c)
			{
				return new Color(c.g, c.g, c.a);
			}
			
			public static Color gbr(this Color c)
			{
				return new Color(c.g, c.b, c.r);
			}
			public static Color gbg(this Color c)
			{
				return new Color(c.g, c.b, c.g);
			}
			public static Color gbb(this Color c)
			{
				return new Color(c.g, c.b, c.b);
			}
			public static Color gba(this Color c)
			{
				return new Color(c.g, c.b, c.a);
			}
			
			public static Color gar(this Color c)
			{
				return new Color(c.g, c.a, c.r);
			}
			public static Color gag(this Color c)
			{
				return new Color(c.g, c.a, c.g);
			}
			public static Color gab(this Color c)
			{
				return new Color(c.g, c.a, c.b);
			}
			public static Color gaa(this Color c)
			{
				return new Color(c.g, c.a, c.a);
			}
			
			#endregion
			
			#region brr-baa
			
			public static Color brr(this Color c)
			{
				return new Color(c.b, c.r, c.r);
			}
			public static Color brg(this Color c)
			{
				return new Color(c.b, c.r, c.g);
			}
			public static Color brb(this Color c)
			{
				return new Color(c.b, c.r, c.b);
			}
			public static Color bra(this Color c)
			{
				return new Color(c.b, c.r, c.a);
			}
			
			public static Color bgr(this Color c)
			{
				return new Color(c.b, c.g, c.r);
			}
			public static Color bgg(this Color c)
			{
				return new Color(c.b, c.g, c.g);
			}
			public static Color bgb(this Color c)
			{
				return new Color(c.b, c.g, c.b);
			}
			public static Color bga(this Color c)
			{
				return new Color(c.b, c.g, c.a);
			}
			
			public static Color bbr(this Color c)
			{
				return new Color(c.b, c.b, c.r);
			}
			public static Color bbg(this Color c)
			{
				return new Color(c.b, c.b, c.g);
			}
			public static Color bbb(this Color c)
			{
				return new Color(c.b, c.b, c.b);
			}
			public static Color bba(this Color c)
			{
				return new Color(c.b, c.b, c.a);
			}
			
			public static Color bar(this Color c)
			{
				return new Color(c.b, c.a, c.r);
			}
			public static Color bag(this Color c)
			{
				return new Color(c.b, c.a, c.g);
			}
			public static Color bab(this Color c)
			{
				return new Color(c.b, c.a, c.b);
			}
			public static Color baa(this Color c)
			{
				return new Color(c.b, c.a, c.a);
			}
			
			#endregion
			
			#region arr-aaa
			
			public static Color arr(this Color c)
			{
				return new Color(c.a, c.r, c.r);
			}
			public static Color arg(this Color c)
			{
				return new Color(c.a, c.r, c.g);
			}
			public static Color arb(this Color c)
			{
				return new Color(c.a, c.r, c.b);
			}
			public static Color ara(this Color c)
			{
				return new Color(c.a, c.r, c.a);
			}
			
			public static Color agr(this Color c)
			{
				return new Color(c.a, c.g, c.r);
			}
			public static Color agg(this Color c)
			{
				return new Color(c.a, c.g, c.g);
			}
			public static Color agb(this Color c)
			{
				return new Color(c.a, c.g, c.b);
			}
			public static Color aga(this Color c)
			{
				return new Color(c.a, c.g, c.a);
			}
			
			public static Color abr(this Color c)
			{
				return new Color(c.a, c.b, c.r);
			}
			public static Color abg(this Color c)
			{
				return new Color(c.a, c.b, c.g);
			}
			public static Color abb(this Color c)
			{
				return new Color(c.a, c.b, c.b);
			}
			public static Color aba(this Color c)
			{
				return new Color(c.a, c.b, c.a);
			}
			
			public static Color aar(this Color c)
			{
				return new Color(c.a, c.a, c.r);
			}
			public static Color aag(this Color c)
			{
				return new Color(c.a, c.a, c.g);
			}
			public static Color aab(this Color c)
			{
				return new Color(c.a, c.a, c.b);
			}
			public static Color aaa(this Color c)
			{
				return new Color(c.a, c.a, c.a);
			}
			
			#endregion
			
			#endregion
			
			#region rrrr-raaa
			
			#region rrrr-rraa
			
			public static Color rrrr(this Color c)
			{
				return new Color(c.r, c.r, c.r, c.r);
			}
			public static Color rrrg(this Color c)
			{
				return new Color(c.r, c.r, c.r, c.g);
			}
			public static Color rrrb(this Color c)
			{
				return new Color(c.r, c.r, c.r, c.b);
			}
			public static Color rrra(this Color c)
			{
				return new Color(c.r, c.r, c.r, c.a);
			}
			
			public static Color rrgr(this Color c)
			{
				return new Color(c.r, c.r, c.g, c.r);
			}
			public static Color rrgg(this Color c)
			{
				return new Color(c.r, c.r, c.g, c.g);
			}
			public static Color rrgb(this Color c)
			{
				return new Color(c.r, c.r, c.g, c.b);
			}
			public static Color rrga(this Color c)
			{
				return new Color(c.r, c.r, c.g, c.a);
			}
			
			public static Color rrbr(this Color c)
			{
				return new Color(c.r, c.r, c.b, c.r);
			}
			public static Color rrbg(this Color c)
			{
				return new Color(c.r, c.r, c.b, c.g);
			}
			public static Color rrbb(this Color c)
			{
				return new Color(c.r, c.r, c.b, c.b);
			}
			public static Color rrba(this Color c)
			{
				return new Color(c.r, c.r, c.b, c.a);
			}
			
			public static Color rrar(this Color c)
			{
				return new Color(c.r, c.r, c.a, c.r);
			}
			public static Color rrag(this Color c)
			{
				return new Color(c.r, c.r, c.a, c.g);
			}
			public static Color rrab(this Color c)
			{
				return new Color(c.r, c.r, c.a, c.b);
			}
			public static Color rraa(this Color c)
			{
				return new Color(c.r, c.r, c.a, c.a);
			}
			
			#endregion
			
			#region rgrr-rgaa
			
			public static Color rgrr(this Color c)
			{
				return new Color(c.r, c.g, c.r, c.r);
			}
			public static Color rgrg(this Color c)
			{
				return new Color(c.r, c.g, c.r, c.g);
			}
			public static Color rgrb(this Color c)
			{
				return new Color(c.r, c.g, c.r, c.b);
			}
			public static Color rgra(this Color c)
			{
				return new Color(c.r, c.g, c.r, c.a);
			}
			
			public static Color rggr(this Color c)
			{
				return new Color(c.r, c.g, c.g, c.r);
			}
			public static Color rggg(this Color c)
			{
				return new Color(c.r, c.g, c.g, c.g);
			}
			public static Color rggb(this Color c)
			{
				return new Color(c.r, c.g, c.g, c.b);
			}
			public static Color rgga(this Color c)
			{
				return new Color(c.r, c.g, c.g, c.a);
			}
			
			public static Color rgbr(this Color c)
			{
				return new Color(c.r, c.g, c.b, c.r);
			}
			public static Color rgbg(this Color c)
			{
				return new Color(c.r, c.g, c.b, c.g);
			}
			public static Color rgbb(this Color c)
			{
				return new Color(c.r, c.g, c.b, c.b);
			}
			public static Color rgba(this Color c)
			{
				return new Color(c.r, c.g, c.b, c.a);
			}
			
			public static Color rgar(this Color c)
			{
				return new Color(c.r, c.g, c.a, c.r);
			}
			public static Color rgag(this Color c)
			{
				return new Color(c.r, c.g, c.a, c.g);
			}
			public static Color rgab(this Color c)
			{
				return new Color(c.r, c.g, c.a, c.b);
			}
			public static Color rgaa(this Color c)
			{
				return new Color(c.r, c.g, c.a, c.a);
			}
			
			#endregion
			
			#region rbrr-rbaa
			
			public static Color rbrr(this Color c)
			{
				return new Color(c.r, c.b, c.r, c.r);
			}
			public static Color rbrg(this Color c)
			{
				return new Color(c.r, c.b, c.r, c.g);
			}
			public static Color rbrb(this Color c)
			{
				return new Color(c.r, c.b, c.r, c.b);
			}
			public static Color rbra(this Color c)
			{
				return new Color(c.r, c.b, c.r, c.a);
			}
			
			public static Color rbgr(this Color c)
			{
				return new Color(c.r, c.b, c.g, c.r);
			}
			public static Color rbgg(this Color c)
			{
				return new Color(c.r, c.b, c.g, c.g);
			}
			public static Color rbgb(this Color c)
			{
				return new Color(c.r, c.b, c.g, c.b);
			}
			public static Color rbga(this Color c)
			{
				return new Color(c.r, c.b, c.g, c.a);
			}
			
			public static Color rbbr(this Color c)
			{
				return new Color(c.r, c.b, c.b, c.r);
			}
			public static Color rbbg(this Color c)
			{
				return new Color(c.r, c.b, c.b, c.g);
			}
			public static Color rbbb(this Color c)
			{
				return new Color(c.r, c.b, c.b, c.b);
			}
			public static Color rbba(this Color c)
			{
				return new Color(c.r, c.b, c.b, c.a);
			}
			
			public static Color rbar(this Color c)
			{
				return new Color(c.r, c.b, c.a, c.r);
			}
			public static Color rbag(this Color c)
			{
				return new Color(c.r, c.b, c.a, c.g);
			}
			public static Color rbab(this Color c)
			{
				return new Color(c.r, c.b, c.a, c.b);
			}
			public static Color rbaa(this Color c)
			{
				return new Color(c.r, c.b, c.a, c.a);
			}
			
			#endregion
			
			#region rarr-raaa
			
			public static Color rarr(this Color c)
			{
				return new Color(c.r, c.a, c.r, c.r);
			}
			public static Color rarg(this Color c)
			{
				return new Color(c.r, c.a, c.r, c.g);
			}
			public static Color rarb(this Color c)
			{
				return new Color(c.r, c.a, c.r, c.b);
			}
			public static Color rara(this Color c)
			{
				return new Color(c.r, c.a, c.r, c.a);
			}
			
			public static Color ragr(this Color c)
			{
				return new Color(c.r, c.a, c.g, c.r);
			}
			public static Color ragg(this Color c)
			{
				return new Color(c.r, c.a, c.g, c.g);
			}
			public static Color ragb(this Color c)
			{
				return new Color(c.r, c.a, c.g, c.b);
			}
			public static Color raga(this Color c)
			{
				return new Color(c.r, c.a, c.g, c.a);
			}
			
			public static Color rabr(this Color c)
			{
				return new Color(c.r, c.a, c.b, c.r);
			}
			public static Color rabg(this Color c)
			{
				return new Color(c.r, c.a, c.b, c.g);
			}
			public static Color rabb(this Color c)
			{
				return new Color(c.r, c.a, c.b, c.b);
			}
			public static Color raba(this Color c)
			{
				return new Color(c.r, c.a, c.b, c.a);
			}
			
			public static Color raar(this Color c)
			{
				return new Color(c.r, c.a, c.a, c.r);
			}
			public static Color raag(this Color c)
			{
				return new Color(c.r, c.a, c.a, c.g);
			}
			public static Color raab(this Color c)
			{
				return new Color(c.r, c.a, c.a, c.b);
			}
			public static Color raaa(this Color c)
			{
				return new Color(c.r, c.a, c.a, c.a);
			}
			
			#endregion
			
			#endregion
			
			#region grrr-gaaa
			
			#region grrr-graa
			
			public static Color grrr(this Color c)
			{
				return new Color(c.g, c.r, c.r, c.r);
			}
			public static Color grrg(this Color c)
			{
				return new Color(c.g, c.r, c.r, c.g);
			}
			public static Color grrb(this Color c)
			{
				return new Color(c.g, c.r, c.r, c.b);
			}
			public static Color grra(this Color c)
			{
				return new Color(c.g, c.r, c.r, c.a);
			}
			
			public static Color grgr(this Color c)
			{
				return new Color(c.g, c.r, c.g, c.r);
			}
			public static Color grgg(this Color c)
			{
				return new Color(c.g, c.r, c.g, c.g);
			}
			public static Color grgb(this Color c)
			{
				return new Color(c.g, c.r, c.g, c.b);
			}
			public static Color grga(this Color c)
			{
				return new Color(c.g, c.r, c.g, c.a);
			}
			
			public static Color grbr(this Color c)
			{
				return new Color(c.g, c.r, c.b, c.r);
			}
			public static Color grbg(this Color c)
			{
				return new Color(c.g, c.r, c.b, c.g);
			}
			public static Color grbb(this Color c)
			{
				return new Color(c.g, c.r, c.b, c.b);
			}
			public static Color grba(this Color c)
			{
				return new Color(c.g, c.r, c.b, c.a);
			}
			
			public static Color grar(this Color c)
			{
				return new Color(c.g, c.r, c.a, c.r);
			}
			public static Color grag(this Color c)
			{
				return new Color(c.g, c.r, c.a, c.g);
			}
			public static Color grab(this Color c)
			{
				return new Color(c.g, c.r, c.a, c.b);
			}
			public static Color graa(this Color c)
			{
				return new Color(c.g, c.r, c.a, c.a);
			}
			
			#endregion
			
			#region ggrr-ggaa
			
			public static Color ggrr(this Color c)
			{
				return new Color(c.g, c.g, c.r, c.r);
			}
			public static Color ggrg(this Color c)
			{
				return new Color(c.g, c.g, c.r, c.g);
			}
			public static Color ggrb(this Color c)
			{
				return new Color(c.g, c.g, c.r, c.b);
			}
			public static Color ggra(this Color c)
			{
				return new Color(c.g, c.g, c.r, c.a);
			}
			
			public static Color gggr(this Color c)
			{
				return new Color(c.g, c.g, c.g, c.r);
			}
			public static Color gggg(this Color c)
			{
				return new Color(c.g, c.g, c.g, c.g);
			}
			public static Color gggb(this Color c)
			{
				return new Color(c.g, c.g, c.g, c.b);
			}
			public static Color ggga(this Color c)
			{
				return new Color(c.g, c.g, c.g, c.a);
			}
			
			public static Color ggbr(this Color c)
			{
				return new Color(c.g, c.g, c.b, c.r);
			}
			public static Color ggbg(this Color c)
			{
				return new Color(c.g, c.g, c.b, c.g);
			}
			public static Color ggbb(this Color c)
			{
				return new Color(c.g, c.g, c.b, c.b);
			}
			public static Color ggba(this Color c)
			{
				return new Color(c.g, c.g, c.b, c.a);
			}
			
			public static Color ggar(this Color c)
			{
				return new Color(c.g, c.g, c.a, c.r);
			}
			public static Color ggag(this Color c)
			{
				return new Color(c.g, c.g, c.a, c.g);
			}
			public static Color ggab(this Color c)
			{
				return new Color(c.g, c.g, c.a, c.b);
			}
			public static Color ggaa(this Color c)
			{
				return new Color(c.g, c.g, c.a, c.a);
			}
			
			#endregion
			
			#region gbrr-gbaa
			
			public static Color gbrr(this Color c)
			{
				return new Color(c.g, c.b, c.r, c.r);
			}
			public static Color gbrg(this Color c)
			{
				return new Color(c.g, c.b, c.r, c.g);
			}
			public static Color gbrb(this Color c)
			{
				return new Color(c.g, c.b, c.r, c.b);
			}
			public static Color gbra(this Color c)
			{
				return new Color(c.g, c.b, c.r, c.a);
			}
			
			public static Color gbgr(this Color c)
			{
				return new Color(c.g, c.b, c.g, c.r);
			}
			public static Color gbgg(this Color c)
			{
				return new Color(c.g, c.b, c.g, c.g);
			}
			public static Color gbgb(this Color c)
			{
				return new Color(c.g, c.b, c.g, c.b);
			}
			public static Color gbga(this Color c)
			{
				return new Color(c.g, c.b, c.g, c.a);
			}
			
			public static Color gbbr(this Color c)
			{
				return new Color(c.g, c.b, c.b, c.r);
			}
			public static Color gbbg(this Color c)
			{
				return new Color(c.g, c.b, c.b, c.g);
			}
			public static Color gbbb(this Color c)
			{
				return new Color(c.g, c.b, c.b, c.b);
			}
			public static Color gbba(this Color c)
			{
				return new Color(c.g, c.b, c.b, c.a);
			}
			
			public static Color gbar(this Color c)
			{
				return new Color(c.g, c.b, c.a, c.r);
			}
			public static Color gbag(this Color c)
			{
				return new Color(c.g, c.b, c.a, c.g);
			}
			public static Color gbab(this Color c)
			{
				return new Color(c.g, c.b, c.a, c.b);
			}
			public static Color gbaa(this Color c)
			{
				return new Color(c.g, c.b, c.a, c.a);
			}
			
			#endregion
			
			#region garr-gaaa
			
			public static Color garr(this Color c)
			{
				return new Color(c.g, c.a, c.r, c.r);
			}
			public static Color garg(this Color c)
			{
				return new Color(c.g, c.a, c.r, c.g);
			}
			public static Color garb(this Color c)
			{
				return new Color(c.g, c.a, c.r, c.b);
			}
			public static Color gara(this Color c)
			{
				return new Color(c.g, c.a, c.r, c.a);
			}
			
			public static Color gagr(this Color c)
			{
				return new Color(c.g, c.a, c.g, c.r);
			}
			public static Color gagg(this Color c)
			{
				return new Color(c.g, c.a, c.g, c.g);
			}
			public static Color gagb(this Color c)
			{
				return new Color(c.g, c.a, c.g, c.b);
			}
			public static Color gaga(this Color c)
			{
				return new Color(c.g, c.a, c.g, c.a);
			}
			
			public static Color gabr(this Color c)
			{
				return new Color(c.g, c.a, c.b, c.r);
			}
			public static Color gabg(this Color c)
			{
				return new Color(c.g, c.a, c.b, c.g);
			}
			public static Color gabb(this Color c)
			{
				return new Color(c.g, c.a, c.b, c.b);
			}
			public static Color gaba(this Color c)
			{
				return new Color(c.g, c.a, c.b, c.a);
			}
			
			public static Color gaar(this Color c)
			{
				return new Color(c.g, c.a, c.a, c.r);
			}
			public static Color gaag(this Color c)
			{
				return new Color(c.g, c.a, c.a, c.g);
			}
			public static Color gaab(this Color c)
			{
				return new Color(c.g, c.a, c.a, c.b);
			}
			public static Color gaaa(this Color c)
			{
				return new Color(c.g, c.a, c.a, c.a);
			}
			
			#endregion
			
			#endregion
			
			#region brrr-baaa
			
			#region brrr-braa
			
			public static Color brrr(this Color c)
			{
				return new Color(c.b, c.r, c.r, c.r);
			}
			public static Color brrg(this Color c)
			{
				return new Color(c.b, c.r, c.r, c.g);
			}
			public static Color brrb(this Color c)
			{
				return new Color(c.b, c.r, c.r, c.b);
			}
			public static Color brra(this Color c)
			{
				return new Color(c.b, c.r, c.r, c.a);
			}
			
			public static Color brgr(this Color c)
			{
				return new Color(c.b, c.r, c.g, c.r);
			}
			public static Color brgg(this Color c)
			{
				return new Color(c.b, c.r, c.g, c.g);
			}
			public static Color brgb(this Color c)
			{
				return new Color(c.b, c.r, c.g, c.b);
			}
			public static Color brga(this Color c)
			{
				return new Color(c.b, c.r, c.g, c.a);
			}
			
			public static Color brbr(this Color c)
			{
				return new Color(c.b, c.r, c.b, c.r);
			}
			public static Color brbg(this Color c)
			{
				return new Color(c.b, c.r, c.b, c.g);
			}
			public static Color brbb(this Color c)
			{
				return new Color(c.b, c.r, c.b, c.b);
			}
			public static Color brba(this Color c)
			{
				return new Color(c.b, c.r, c.b, c.a);
			}
			
			public static Color brar(this Color c)
			{
				return new Color(c.b, c.r, c.a, c.r);
			}
			public static Color brag(this Color c)
			{
				return new Color(c.b, c.r, c.a, c.g);
			}
			public static Color brab(this Color c)
			{
				return new Color(c.b, c.r, c.a, c.b);
			}
			public static Color braa(this Color c)
			{
				return new Color(c.b, c.r, c.a, c.a);
			}
			
			#endregion
			
			#region bgrr-bgaa
			
			public static Color bgrr(this Color c)
			{
				return new Color(c.b, c.g, c.r, c.r);
			}
			public static Color bgrg(this Color c)
			{
				return new Color(c.b, c.g, c.r, c.g);
			}
			public static Color bgrb(this Color c)
			{
				return new Color(c.b, c.g, c.r, c.b);
			}
			public static Color bgra(this Color c)
			{
				return new Color(c.b, c.g, c.r, c.a);
			}
			
			public static Color bggr(this Color c)
			{
				return new Color(c.b, c.g, c.g, c.r);
			}
			public static Color bggg(this Color c)
			{
				return new Color(c.b, c.g, c.g, c.g);
			}
			public static Color bggb(this Color c)
			{
				return new Color(c.b, c.g, c.g, c.b);
			}
			public static Color bgga(this Color c)
			{
				return new Color(c.b, c.g, c.g, c.a);
			}
			
			public static Color bgbr(this Color c)
			{
				return new Color(c.b, c.g, c.b, c.r);
			}
			public static Color bgbg(this Color c)
			{
				return new Color(c.b, c.g, c.b, c.g);
			}
			public static Color bgbb(this Color c)
			{
				return new Color(c.b, c.g, c.b, c.b);
			}
			public static Color bgba(this Color c)
			{
				return new Color(c.b, c.g, c.b, c.a);
			}
			
			public static Color bgar(this Color c)
			{
				return new Color(c.b, c.g, c.a, c.r);
			}
			public static Color bgag(this Color c)
			{
				return new Color(c.b, c.g, c.a, c.g);
			}
			public static Color bgab(this Color c)
			{
				return new Color(c.b, c.g, c.a, c.b);
			}
			public static Color bgaa(this Color c)
			{
				return new Color(c.b, c.g, c.a, c.a);
			}
			
			#endregion
			
			#region bbrr-bbaa
			
			public static Color bbrr(this Color c)
			{
				return new Color(c.b, c.b, c.r, c.r);
			}
			public static Color bbrg(this Color c)
			{
				return new Color(c.b, c.b, c.r, c.g);
			}
			public static Color bbrb(this Color c)
			{
				return new Color(c.b, c.b, c.r, c.b);
			}
			public static Color bbra(this Color c)
			{
				return new Color(c.b, c.b, c.r, c.a);
			}
			
			public static Color bbgr(this Color c)
			{
				return new Color(c.b, c.b, c.g, c.r);
			}
			public static Color bbgg(this Color c)
			{
				return new Color(c.b, c.b, c.g, c.g);
			}
			public static Color bbgb(this Color c)
			{
				return new Color(c.b, c.b, c.g, c.b);
			}
			public static Color bbga(this Color c)
			{
				return new Color(c.b, c.b, c.g, c.a);
			}
			
			public static Color bbbr(this Color c)
			{
				return new Color(c.b, c.b, c.b, c.r);
			}
			public static Color bbbg(this Color c)
			{
				return new Color(c.b, c.b, c.b, c.g);
			}
			public static Color bbbb(this Color c)
			{
				return new Color(c.b, c.b, c.b, c.b);
			}
			public static Color bbba(this Color c)
			{
				return new Color(c.b, c.b, c.b, c.a);
			}
			
			public static Color bbar(this Color c)
			{
				return new Color(c.b, c.b, c.a, c.r);
			}
			public static Color bbag(this Color c)
			{
				return new Color(c.b, c.b, c.a, c.g);
			}
			public static Color bbab(this Color c)
			{
				return new Color(c.b, c.b, c.a, c.b);
			}
			public static Color bbaa(this Color c)
			{
				return new Color(c.b, c.b, c.a, c.a);
			}
			
			#endregion
			
			#region barr-baaa
			
			public static Color barr(this Color c)
			{
				return new Color(c.b, c.a, c.r, c.r);
			}
			public static Color barg(this Color c)
			{
				return new Color(c.b, c.a, c.r, c.g);
			}
			public static Color barb(this Color c)
			{
				return new Color(c.b, c.a, c.r, c.b);
			}
			public static Color bara(this Color c)
			{
				return new Color(c.b, c.a, c.r, c.a);
			}
			
			public static Color bagr(this Color c)
			{
				return new Color(c.b, c.a, c.g, c.r);
			}
			public static Color bagg(this Color c)
			{
				return new Color(c.b, c.a, c.g, c.g);
			}
			public static Color bagb(this Color c)
			{
				return new Color(c.b, c.a, c.g, c.b);
			}
			public static Color baga(this Color c)
			{
				return new Color(c.b, c.a, c.g, c.a);
			}
			
			public static Color babr(this Color c)
			{
				return new Color(c.b, c.a, c.b, c.r);
			}
			public static Color babg(this Color c)
			{
				return new Color(c.b, c.a, c.b, c.g);
			}
			public static Color babb(this Color c)
			{
				return new Color(c.b, c.a, c.b, c.b);
			}
			public static Color baba(this Color c)
			{
				return new Color(c.b, c.a, c.b, c.a);
			}
			
			public static Color baar(this Color c)
			{
				return new Color(c.b, c.a, c.a, c.r);
			}
			public static Color baag(this Color c)
			{
				return new Color(c.b, c.a, c.a, c.g);
			}
			public static Color baab(this Color c)
			{
				return new Color(c.b, c.a, c.a, c.b);
			}
			public static Color baaa(this Color c)
			{
				return new Color(c.b, c.a, c.a, c.a);
			}
			
			#endregion
			
			#endregion
			
			#region arrr-aaaa
			
			#region arrr-araa
			
			public static Color arrr(this Color c)
			{
				return new Color(c.a, c.r, c.r, c.r);
			}
			public static Color arrg(this Color c)
			{
				return new Color(c.a, c.r, c.r, c.g);
			}
			public static Color arrb(this Color c)
			{
				return new Color(c.a, c.r, c.r, c.b);
			}
			public static Color arra(this Color c)
			{
				return new Color(c.a, c.r, c.r, c.a);
			}
			
			public static Color argr(this Color c)
			{
				return new Color(c.a, c.r, c.g, c.r);
			}
			public static Color argg(this Color c)
			{
				return new Color(c.a, c.r, c.g, c.g);
			}
			public static Color argb(this Color c)
			{
				return new Color(c.a, c.r, c.g, c.b);
			}
			public static Color arga(this Color c)
			{
				return new Color(c.a, c.r, c.g, c.a);
			}
			
			public static Color arbr(this Color c)
			{
				return new Color(c.a, c.r, c.b, c.r);
			}
			public static Color arbg(this Color c)
			{
				return new Color(c.a, c.r, c.b, c.g);
			}
			public static Color arbb(this Color c)
			{
				return new Color(c.a, c.r, c.b, c.b);
			}
			public static Color arba(this Color c)
			{
				return new Color(c.a, c.r, c.b, c.a);
			}
			
			public static Color arar(this Color c)
			{
				return new Color(c.a, c.r, c.a, c.r);
			}
			public static Color arag(this Color c)
			{
				return new Color(c.a, c.r, c.a, c.g);
			}
			public static Color arab(this Color c)
			{
				return new Color(c.a, c.r, c.a, c.b);
			}
			public static Color araa(this Color c)
			{
				return new Color(c.a, c.r, c.a, c.a);
			}
			
			#endregion
			
			#region agrr-agaa
			
			public static Color agrr(this Color c)
			{
				return new Color(c.a, c.g, c.r, c.r);
			}
			public static Color agrg(this Color c)
			{
				return new Color(c.a, c.g, c.r, c.g);
			}
			public static Color agrb(this Color c)
			{
				return new Color(c.a, c.g, c.r, c.b);
			}
			public static Color agra(this Color c)
			{
				return new Color(c.a, c.g, c.r, c.a);
			}
			
			public static Color aggr(this Color c)
			{
				return new Color(c.a, c.g, c.g, c.r);
			}
			public static Color aggg(this Color c)
			{
				return new Color(c.a, c.g, c.g, c.g);
			}
			public static Color aggb(this Color c)
			{
				return new Color(c.a, c.g, c.g, c.b);
			}
			public static Color agga(this Color c)
			{
				return new Color(c.a, c.g, c.g, c.a);
			}
			
			public static Color agbr(this Color c)
			{
				return new Color(c.a, c.g, c.b, c.r);
			}
			public static Color agbg(this Color c)
			{
				return new Color(c.a, c.g, c.b, c.g);
			}
			public static Color agbb(this Color c)
			{
				return new Color(c.a, c.g, c.b, c.b);
			}
			public static Color agba(this Color c)
			{
				return new Color(c.a, c.g, c.b, c.a);
			}
			
			public static Color agar(this Color c)
			{
				return new Color(c.a, c.g, c.a, c.r);
			}
			public static Color agag(this Color c)
			{
				return new Color(c.a, c.g, c.a, c.g);
			}
			public static Color agab(this Color c)
			{
				return new Color(c.a, c.g, c.a, c.b);
			}
			public static Color agaa(this Color c)
			{
				return new Color(c.a, c.g, c.a, c.a);
			}
			
			#endregion
			
			#region abrr-abaa
			
			public static Color abrr(this Color c)
			{
				return new Color(c.a, c.b, c.r, c.r);
			}
			public static Color abrg(this Color c)
			{
				return new Color(c.a, c.b, c.r, c.g);
			}
			public static Color abrb(this Color c)
			{
				return new Color(c.a, c.b, c.r, c.b);
			}
			public static Color abra(this Color c)
			{
				return new Color(c.a, c.b, c.r, c.a);
			}
			
			public static Color abgr(this Color c)
			{
				return new Color(c.a, c.b, c.g, c.r);
			}
			public static Color abgg(this Color c)
			{
				return new Color(c.a, c.b, c.g, c.g);
			}
			public static Color abgb(this Color c)
			{
				return new Color(c.a, c.b, c.g, c.b);
			}
			public static Color abga(this Color c)
			{
				return new Color(c.a, c.b, c.g, c.a);
			}
			
			public static Color abbr(this Color c)
			{
				return new Color(c.a, c.b, c.b, c.r);
			}
			public static Color abbg(this Color c)
			{
				return new Color(c.a, c.b, c.b, c.g);
			}
			public static Color abbb(this Color c)
			{
				return new Color(c.a, c.b, c.b, c.b);
			}
			public static Color abba(this Color c)
			{
				return new Color(c.a, c.b, c.b, c.a);
			}
			
			public static Color abar(this Color c)
			{
				return new Color(c.a, c.b, c.a, c.r);
			}
			public static Color abag(this Color c)
			{
				return new Color(c.a, c.b, c.a, c.g);
			}
			public static Color abab(this Color c)
			{
				return new Color(c.a, c.b, c.a, c.b);
			}
			public static Color abaa(this Color c)
			{
				return new Color(c.a, c.b, c.a, c.a);
			}
			
			#endregion
			
			#region aarr-aaaa
			
			public static Color aarr(this Color c)
			{
				return new Color(c.a, c.a, c.r, c.r);
			}
			public static Color aarg(this Color c)
			{
				return new Color(c.a, c.a, c.r, c.g);
			}
			public static Color aarb(this Color c)
			{
				return new Color(c.a, c.a, c.r, c.b);
			}
			public static Color aara(this Color c)
			{
				return new Color(c.a, c.a, c.r, c.a);
			}
			
			public static Color aagr(this Color c)
			{
				return new Color(c.a, c.a, c.g, c.r);
			}
			public static Color aagg(this Color c)
			{
				return new Color(c.a, c.a, c.g, c.g);
			}
			public static Color aagb(this Color c)
			{
				return new Color(c.a, c.a, c.g, c.b);
			}
			public static Color aaga(this Color c)
			{
				return new Color(c.a, c.a, c.g, c.a);
			}
			
			public static Color aabr(this Color c)
			{
				return new Color(c.a, c.a, c.b, c.r);
			}
			public static Color aabg(this Color c)
			{
				return new Color(c.a, c.a, c.b, c.g);
			}
			public static Color aabb(this Color c)
			{
				return new Color(c.a, c.a, c.b, c.b);
			}
			public static Color aaba(this Color c)
			{
				return new Color(c.a, c.a, c.b, c.a);
			}
			
			public static Color aaar(this Color c)
			{
				return new Color(c.a, c.a, c.a, c.r);
			}
			public static Color aaag(this Color c)
			{
				return new Color(c.a, c.a, c.a, c.g);
			}
			public static Color aaab(this Color c)
			{
				return new Color(c.a, c.a, c.a, c.b);
			}
			public static Color aaaa(this Color c)
			{
				return new Color(c.a, c.a, c.a, c.a);
			}
			
			#endregion
			
			#endregion
			
			#endregion
			
			#region Color32 swizzles
			
			#region rrr-aaa
			
			#region rrr-raa
			
			public static Color32 rrr(this Color32 c)
			{
				return new Color32(c.r, c.r, c.r, 0xFF);
			}
			public static Color32 rrg(this Color32 c)
			{
				return new Color32(c.r, c.r, c.g, 0xFF);
			}
			public static Color32 rrb(this Color32 c)
			{
				return new Color32(c.r, c.r, c.b, 0xFF);
			}
			public static Color32 rra(this Color32 c)
			{
				return new Color32(c.r, c.r, c.a, 0xFF);
			}
			
			public static Color32 rgr(this Color32 c)
			{
				return new Color32(c.r, c.g, c.r, 0xFF);
			}
			public static Color32 rgg(this Color32 c)
			{
				return new Color32(c.r, c.g, c.g, 0xFF);
			}
			public static Color32 rgb(this Color32 c)
			{
				return new Color32(c.r, c.g, c.b, 0xFF);
			}
			public static Color32 rga(this Color32 c)
			{
				return new Color32(c.r, c.g, c.a, 0xFF);
			}
			
			public static Color32 rbr(this Color32 c)
			{
				return new Color32(c.r, c.b, c.r, 0xFF);
			}
			public static Color32 rbg(this Color32 c)
			{
				return new Color32(c.r, c.b, c.g, 0xFF);
			}
			public static Color32 rbb(this Color32 c)
			{
				return new Color32(c.r, c.b, c.b, 0xFF);
			}
			public static Color32 rba(this Color32 c)
			{
				return new Color32(c.r, c.b, c.a, 0xFF);
			}
			
			public static Color32 rar(this Color32 c)
			{
				return new Color32(c.r, c.a, c.r, 0xFF);
			}
			public static Color32 rag(this Color32 c)
			{
				return new Color32(c.r, c.a, c.g, 0xFF);
			}
			public static Color32 rab(this Color32 c)
			{
				return new Color32(c.r, c.a, c.b, 0xFF);
			}
			public static Color32 raa(this Color32 c)
			{
				return new Color32(c.r, c.a, c.a, 0xFF);
			}
			
			#endregion
			
			#region grr-gaa
			
			public static Color32 grr(this Color32 c)
			{
				return new Color32(c.g, c.r, c.r, 0xFF);
			}
			public static Color32 grg(this Color32 c)
			{
				return new Color32(c.g, c.r, c.g, 0xFF);
			}
			public static Color32 grb(this Color32 c)
			{
				return new Color32(c.g, c.r, c.b, 0xFF);
			}
			public static Color32 gra(this Color32 c)
			{
				return new Color32(c.g, c.r, c.a, 0xFF);
			}
			
			public static Color32 ggr(this Color32 c)
			{
				return new Color32(c.g, c.g, c.r, 0xFF);
			}
			public static Color32 ggg(this Color32 c)
			{
				return new Color32(c.g, c.g, c.g, 0xFF);
			}
			public static Color32 ggb(this Color32 c)
			{
				return new Color32(c.g, c.g, c.b, 0xFF);
			}
			public static Color32 gga(this Color32 c)
			{
				return new Color32(c.g, c.g, c.a, 0xFF);
			}
			
			public static Color32 gbr(this Color32 c)
			{
				return new Color32(c.g, c.b, c.r, 0xFF);
			}
			public static Color32 gbg(this Color32 c)
			{
				return new Color32(c.g, c.b, c.g, 0xFF);
			}
			public static Color32 gbb(this Color32 c)
			{
				return new Color32(c.g, c.b, c.b, 0xFF);
			}
			public static Color32 gba(this Color32 c)
			{
				return new Color32(c.g, c.b, c.a, 0xFF);
			}
			
			public static Color32 gar(this Color32 c)
			{
				return new Color32(c.g, c.a, c.r, 0xFF);
			}
			public static Color32 gag(this Color32 c)
			{
				return new Color32(c.g, c.a, c.g, 0xFF);
			}
			public static Color32 gab(this Color32 c)
			{
				return new Color32(c.g, c.a, c.b, 0xFF);
			}
			public static Color32 gaa(this Color32 c)
			{
				return new Color32(c.g, c.a, c.a, 0xFF);
			}
			
			#endregion
			
			#region brr-baa
			
			public static Color32 brr(this Color32 c)
			{
				return new Color32(c.b, c.r, c.r, 0xFF);
			}
			public static Color32 brg(this Color32 c)
			{
				return new Color32(c.b, c.r, c.g, 0xFF);
			}
			public static Color32 brb(this Color32 c)
			{
				return new Color32(c.b, c.r, c.b, 0xFF);
			}
			public static Color32 bra(this Color32 c)
			{
				return new Color32(c.b, c.r, c.a, 0xFF);
			}
			
			public static Color32 bgr(this Color32 c)
			{
				return new Color32(c.b, c.g, c.r, 0xFF);
			}
			public static Color32 bgg(this Color32 c)
			{
				return new Color32(c.b, c.g, c.g, 0xFF);
			}
			public static Color32 bgb(this Color32 c)
			{
				return new Color32(c.b, c.g, c.b, 0xFF);
			}
			public static Color32 bga(this Color32 c)
			{
				return new Color32(c.b, c.g, c.a, 0xFF);
			}
			
			public static Color32 bbr(this Color32 c)
			{
				return new Color32(c.b, c.b, c.r, 0xFF);
			}
			public static Color32 bbg(this Color32 c)
			{
				return new Color32(c.b, c.b, c.g, 0xFF);
			}
			public static Color32 bbb(this Color32 c)
			{
				return new Color32(c.b, c.b, c.b, 0xFF);
			}
			public static Color32 bba(this Color32 c)
			{
				return new Color32(c.b, c.b, c.a, 0xFF);
			}
			
			public static Color32 bar(this Color32 c)
			{
				return new Color32(c.b, c.a, c.r, 0xFF);
			}
			public static Color32 bag(this Color32 c)
			{
				return new Color32(c.b, c.a, c.g, 0xFF);
			}
			public static Color32 bab(this Color32 c)
			{
				return new Color32(c.b, c.a, c.b, 0xFF);
			}
			public static Color32 baa(this Color32 c)
			{
				return new Color32(c.b, c.a, c.a, 0xFF);
			}
			
			#endregion
			
			#region arr-aaa
			
			public static Color32 arr(this Color32 c)
			{
				return new Color32(c.a, c.r, c.r, 0xFF);
			}
			public static Color32 arg(this Color32 c)
			{
				return new Color32(c.a, c.r, c.g, 0xFF);
			}
			public static Color32 arb(this Color32 c)
			{
				return new Color32(c.a, c.r, c.b, 0xFF);
			}
			public static Color32 ara(this Color32 c)
			{
				return new Color32(c.a, c.r, c.a, 0xFF);
			}
			
			public static Color32 agr(this Color32 c)
			{
				return new Color32(c.a, c.g, c.r, 0xFF);
			}
			public static Color32 agg(this Color32 c)
			{
				return new Color32(c.a, c.g, c.g, 0xFF);
			}
			public static Color32 agb(this Color32 c)
			{
				return new Color32(c.a, c.g, c.b, 0xFF);
			}
			public static Color32 aga(this Color32 c)
			{
				return new Color32(c.a, c.g, c.a, 0xFF);
			}
			
			public static Color32 abr(this Color32 c)
			{
				return new Color32(c.a, c.b, c.r, 0xFF);
			}
			public static Color32 abg(this Color32 c)
			{
				return new Color32(c.a, c.b, c.g, 0xFF);
			}
			public static Color32 abb(this Color32 c)
			{
				return new Color32(c.a, c.b, c.b, 0xFF);
			}
			public static Color32 aba(this Color32 c)
			{
				return new Color32(c.a, c.b, c.a, 0xFF);
			}
			
			public static Color32 aar(this Color32 c)
			{
				return new Color32(c.a, c.a, c.r, 0xFF);
			}
			public static Color32 aag(this Color32 c)
			{
				return new Color32(c.a, c.a, c.g, 0xFF);
			}
			public static Color32 aab(this Color32 c)
			{
				return new Color32(c.a, c.a, c.b, 0xFF);
			}
			public static Color32 aaa(this Color32 c)
			{
				return new Color32(c.a, c.a, c.a, 0xFF);
			}
			
			#endregion
			
			#endregion
			
			#region rrrr-raaa
			
			#region rrrr-rraa
			
			public static Color32 rrrr(this Color32 c)
			{
				return new Color32(c.r, c.r, c.r, c.r);
			}
			public static Color32 rrrg(this Color32 c)
			{
				return new Color32(c.r, c.r, c.r, c.g);
			}
			public static Color32 rrrb(this Color32 c)
			{
				return new Color32(c.r, c.r, c.r, c.b);
			}
			public static Color32 rrra(this Color32 c)
			{
				return new Color32(c.r, c.r, c.r, c.a);
			}
			
			public static Color32 rrgr(this Color32 c)
			{
				return new Color32(c.r, c.r, c.g, c.r);
			}
			public static Color32 rrgg(this Color32 c)
			{
				return new Color32(c.r, c.r, c.g, c.g);
			}
			public static Color32 rrgb(this Color32 c)
			{
				return new Color32(c.r, c.r, c.g, c.b);
			}
			public static Color32 rrga(this Color32 c)
			{
				return new Color32(c.r, c.r, c.g, c.a);
			}
			
			public static Color32 rrbr(this Color32 c)
			{
				return new Color32(c.r, c.r, c.b, c.r);
			}
			public static Color32 rrbg(this Color32 c)
			{
				return new Color32(c.r, c.r, c.b, c.g);
			}
			public static Color32 rrbb(this Color32 c)
			{
				return new Color32(c.r, c.r, c.b, c.b);
			}
			public static Color32 rrba(this Color32 c)
			{
				return new Color32(c.r, c.r, c.b, c.a);
			}
			
			public static Color32 rrar(this Color32 c)
			{
				return new Color32(c.r, c.r, c.a, c.r);
			}
			public static Color32 rrag(this Color32 c)
			{
				return new Color32(c.r, c.r, c.a, c.g);
			}
			public static Color32 rrab(this Color32 c)
			{
				return new Color32(c.r, c.r, c.a, c.b);
			}
			public static Color32 rraa(this Color32 c)
			{
				return new Color32(c.r, c.r, c.a, c.a);
			}
			
			#endregion
			
			#region rgrr-rgaa
			
			public static Color32 rgrr(this Color32 c)
			{
				return new Color32(c.r, c.g, c.r, c.r);
			}
			public static Color32 rgrg(this Color32 c)
			{
				return new Color32(c.r, c.g, c.r, c.g);
			}
			public static Color32 rgrb(this Color32 c)
			{
				return new Color32(c.r, c.g, c.r, c.b);
			}
			public static Color32 rgra(this Color32 c)
			{
				return new Color32(c.r, c.g, c.r, c.a);
			}
			
			public static Color32 rggr(this Color32 c)
			{
				return new Color32(c.r, c.g, c.g, c.r);
			}
			public static Color32 rggg(this Color32 c)
			{
				return new Color32(c.r, c.g, c.g, c.g);
			}
			public static Color32 rggb(this Color32 c)
			{
				return new Color32(c.r, c.g, c.g, c.b);
			}
			public static Color32 rgga(this Color32 c)
			{
				return new Color32(c.r, c.g, c.g, c.a);
			}
			
			public static Color32 rgbr(this Color32 c)
			{
				return new Color32(c.r, c.g, c.b, c.r);
			}
			public static Color32 rgbg(this Color32 c)
			{
				return new Color32(c.r, c.g, c.b, c.g);
			}
			public static Color32 rgbb(this Color32 c)
			{
				return new Color32(c.r, c.g, c.b, c.b);
			}
			public static Color32 rgba(this Color32 c)
			{
				return new Color32(c.r, c.g, c.b, c.a);
			}
			
			public static Color32 rgar(this Color32 c)
			{
				return new Color32(c.r, c.g, c.a, c.r);
			}
			public static Color32 rgag(this Color32 c)
			{
				return new Color32(c.r, c.g, c.a, c.g);
			}
			public static Color32 rgab(this Color32 c)
			{
				return new Color32(c.r, c.g, c.a, c.b);
			}
			public static Color32 rgaa(this Color32 c)
			{
				return new Color32(c.r, c.g, c.a, c.a);
			}
			
			#endregion
			
			#region rbrr-rbaa
			
			public static Color32 rbrr(this Color32 c)
			{
				return new Color32(c.r, c.b, c.r, c.r);
			}
			public static Color32 rbrg(this Color32 c)
			{
				return new Color32(c.r, c.b, c.r, c.g);
			}
			public static Color32 rbrb(this Color32 c)
			{
				return new Color32(c.r, c.b, c.r, c.b);
			}
			public static Color32 rbra(this Color32 c)
			{
				return new Color32(c.r, c.b, c.r, c.a);
			}
			
			public static Color32 rbgr(this Color32 c)
			{
				return new Color32(c.r, c.b, c.g, c.r);
			}
			public static Color32 rbgg(this Color32 c)
			{
				return new Color32(c.r, c.b, c.g, c.g);
			}
			public static Color32 rbgb(this Color32 c)
			{
				return new Color32(c.r, c.b, c.g, c.b);
			}
			public static Color32 rbga(this Color32 c)
			{
				return new Color32(c.r, c.b, c.g, c.a);
			}
			
			public static Color32 rbbr(this Color32 c)
			{
				return new Color32(c.r, c.b, c.b, c.r);
			}
			public static Color32 rbbg(this Color32 c)
			{
				return new Color32(c.r, c.b, c.b, c.g);
			}
			public static Color32 rbbb(this Color32 c)
			{
				return new Color32(c.r, c.b, c.b, c.b);
			}
			public static Color32 rbba(this Color32 c)
			{
				return new Color32(c.r, c.b, c.b, c.a);
			}
			
			public static Color32 rbar(this Color32 c)
			{
				return new Color32(c.r, c.b, c.a, c.r);
			}
			public static Color32 rbag(this Color32 c)
			{
				return new Color32(c.r, c.b, c.a, c.g);
			}
			public static Color32 rbab(this Color32 c)
			{
				return new Color32(c.r, c.b, c.a, c.b);
			}
			public static Color32 rbaa(this Color32 c)
			{
				return new Color32(c.r, c.b, c.a, c.a);
			}
			
			#endregion
			
			#region rarr-raaa
			
			public static Color32 rarr(this Color32 c)
			{
				return new Color32(c.r, c.a, c.r, c.r);
			}
			public static Color32 rarg(this Color32 c)
			{
				return new Color32(c.r, c.a, c.r, c.g);
			}
			public static Color32 rarb(this Color32 c)
			{
				return new Color32(c.r, c.a, c.r, c.b);
			}
			public static Color32 rara(this Color32 c)
			{
				return new Color32(c.r, c.a, c.r, c.a);
			}
			
			public static Color32 ragr(this Color32 c)
			{
				return new Color32(c.r, c.a, c.g, c.r);
			}
			public static Color32 ragg(this Color32 c)
			{
				return new Color32(c.r, c.a, c.g, c.g);
			}
			public static Color32 ragb(this Color32 c)
			{
				return new Color32(c.r, c.a, c.g, c.b);
			}
			public static Color32 raga(this Color32 c)
			{
				return new Color32(c.r, c.a, c.g, c.a);
			}
			
			public static Color32 rabr(this Color32 c)
			{
				return new Color32(c.r, c.a, c.b, c.r);
			}
			public static Color32 rabg(this Color32 c)
			{
				return new Color32(c.r, c.a, c.b, c.g);
			}
			public static Color32 rabb(this Color32 c)
			{
				return new Color32(c.r, c.a, c.b, c.b);
			}
			public static Color32 raba(this Color32 c)
			{
				return new Color32(c.r, c.a, c.b, c.a);
			}
			
			public static Color32 raar(this Color32 c)
			{
				return new Color32(c.r, c.a, c.a, c.r);
			}
			public static Color32 raag(this Color32 c)
			{
				return new Color32(c.r, c.a, c.a, c.g);
			}
			public static Color32 raab(this Color32 c)
			{
				return new Color32(c.r, c.a, c.a, c.b);
			}
			public static Color32 raaa(this Color32 c)
			{
				return new Color32(c.r, c.a, c.a, c.a);
			}
			
			#endregion
			
			#endregion
			
			#region grrr-gaaa
			
			#region grrr-graa
			
			public static Color32 grrr(this Color32 c)
			{
				return new Color32(c.g, c.r, c.r, c.r);
			}
			public static Color32 grrg(this Color32 c)
			{
				return new Color32(c.g, c.r, c.r, c.g);
			}
			public static Color32 grrb(this Color32 c)
			{
				return new Color32(c.g, c.r, c.r, c.b);
			}
			public static Color32 grra(this Color32 c)
			{
				return new Color32(c.g, c.r, c.r, c.a);
			}
			
			public static Color32 grgr(this Color32 c)
			{
				return new Color32(c.g, c.r, c.g, c.r);
			}
			public static Color32 grgg(this Color32 c)
			{
				return new Color32(c.g, c.r, c.g, c.g);
			}
			public static Color32 grgb(this Color32 c)
			{
				return new Color32(c.g, c.r, c.g, c.b);
			}
			public static Color32 grga(this Color32 c)
			{
				return new Color32(c.g, c.r, c.g, c.a);
			}
			
			public static Color32 grbr(this Color32 c)
			{
				return new Color32(c.g, c.r, c.b, c.r);
			}
			public static Color32 grbg(this Color32 c)
			{
				return new Color32(c.g, c.r, c.b, c.g);
			}
			public static Color32 grbb(this Color32 c)
			{
				return new Color32(c.g, c.r, c.b, c.b);
			}
			public static Color32 grba(this Color32 c)
			{
				return new Color32(c.g, c.r, c.b, c.a);
			}
			
			public static Color32 grar(this Color32 c)
			{
				return new Color32(c.g, c.r, c.a, c.r);
			}
			public static Color32 grag(this Color32 c)
			{
				return new Color32(c.g, c.r, c.a, c.g);
			}
			public static Color32 grab(this Color32 c)
			{
				return new Color32(c.g, c.r, c.a, c.b);
			}
			public static Color32 graa(this Color32 c)
			{
				return new Color32(c.g, c.r, c.a, c.a);
			}
			
			#endregion
			
			#region ggrr-ggaa
			
			public static Color32 ggrr(this Color32 c)
			{
				return new Color32(c.g, c.g, c.r, c.r);
			}
			public static Color32 ggrg(this Color32 c)
			{
				return new Color32(c.g, c.g, c.r, c.g);
			}
			public static Color32 ggrb(this Color32 c)
			{
				return new Color32(c.g, c.g, c.r, c.b);
			}
			public static Color32 ggra(this Color32 c)
			{
				return new Color32(c.g, c.g, c.r, c.a);
			}
			
			public static Color32 gggr(this Color32 c)
			{
				return new Color32(c.g, c.g, c.g, c.r);
			}
			public static Color32 gggg(this Color32 c)
			{
				return new Color32(c.g, c.g, c.g, c.g);
			}
			public static Color32 gggb(this Color32 c)
			{
				return new Color32(c.g, c.g, c.g, c.b);
			}
			public static Color32 ggga(this Color32 c)
			{
				return new Color32(c.g, c.g, c.g, c.a);
			}
			
			public static Color32 ggbr(this Color32 c)
			{
				return new Color32(c.g, c.g, c.b, c.r);
			}
			public static Color32 ggbg(this Color32 c)
			{
				return new Color32(c.g, c.g, c.b, c.g);
			}
			public static Color32 ggbb(this Color32 c)
			{
				return new Color32(c.g, c.g, c.b, c.b);
			}
			public static Color32 ggba(this Color32 c)
			{
				return new Color32(c.g, c.g, c.b, c.a);
			}
			
			public static Color32 ggar(this Color32 c)
			{
				return new Color32(c.g, c.g, c.a, c.r);
			}
			public static Color32 ggag(this Color32 c)
			{
				return new Color32(c.g, c.g, c.a, c.g);
			}
			public static Color32 ggab(this Color32 c)
			{
				return new Color32(c.g, c.g, c.a, c.b);
			}
			public static Color32 ggaa(this Color32 c)
			{
				return new Color32(c.g, c.g, c.a, c.a);
			}
			
			#endregion
			
			#region gbrr-gbaa
			
			public static Color32 gbrr(this Color32 c)
			{
				return new Color32(c.g, c.b, c.r, c.r);
			}
			public static Color32 gbrg(this Color32 c)
			{
				return new Color32(c.g, c.b, c.r, c.g);
			}
			public static Color32 gbrb(this Color32 c)
			{
				return new Color32(c.g, c.b, c.r, c.b);
			}
			public static Color32 gbra(this Color32 c)
			{
				return new Color32(c.g, c.b, c.r, c.a);
			}
			
			public static Color32 gbgr(this Color32 c)
			{
				return new Color32(c.g, c.b, c.g, c.r);
			}
			public static Color32 gbgg(this Color32 c)
			{
				return new Color32(c.g, c.b, c.g, c.g);
			}
			public static Color32 gbgb(this Color32 c)
			{
				return new Color32(c.g, c.b, c.g, c.b);
			}
			public static Color32 gbga(this Color32 c)
			{
				return new Color32(c.g, c.b, c.g, c.a);
			}
			
			public static Color32 gbbr(this Color32 c)
			{
				return new Color32(c.g, c.b, c.b, c.r);
			}
			public static Color32 gbbg(this Color32 c)
			{
				return new Color32(c.g, c.b, c.b, c.g);
			}
			public static Color32 gbbb(this Color32 c)
			{
				return new Color32(c.g, c.b, c.b, c.b);
			}
			public static Color32 gbba(this Color32 c)
			{
				return new Color32(c.g, c.b, c.b, c.a);
			}
			
			public static Color32 gbar(this Color32 c)
			{
				return new Color32(c.g, c.b, c.a, c.r);
			}
			public static Color32 gbag(this Color32 c)
			{
				return new Color32(c.g, c.b, c.a, c.g);
			}
			public static Color32 gbab(this Color32 c)
			{
				return new Color32(c.g, c.b, c.a, c.b);
			}
			public static Color32 gbaa(this Color32 c)
			{
				return new Color32(c.g, c.b, c.a, c.a);
			}
			
			#endregion
			
			#region garr-gaaa
			
			public static Color32 garr(this Color32 c)
			{
				return new Color32(c.g, c.a, c.r, c.r);
			}
			public static Color32 garg(this Color32 c)
			{
				return new Color32(c.g, c.a, c.r, c.g);
			}
			public static Color32 garb(this Color32 c)
			{
				return new Color32(c.g, c.a, c.r, c.b);
			}
			public static Color32 gara(this Color32 c)
			{
				return new Color32(c.g, c.a, c.r, c.a);
			}
			
			public static Color32 gagr(this Color32 c)
			{
				return new Color32(c.g, c.a, c.g, c.r);
			}
			public static Color32 gagg(this Color32 c)
			{
				return new Color32(c.g, c.a, c.g, c.g);
			}
			public static Color32 gagb(this Color32 c)
			{
				return new Color32(c.g, c.a, c.g, c.b);
			}
			public static Color32 gaga(this Color32 c)
			{
				return new Color32(c.g, c.a, c.g, c.a);
			}
			
			public static Color32 gabr(this Color32 c)
			{
				return new Color32(c.g, c.a, c.b, c.r);
			}
			public static Color32 gabg(this Color32 c)
			{
				return new Color32(c.g, c.a, c.b, c.g);
			}
			public static Color32 gabb(this Color32 c)
			{
				return new Color32(c.g, c.a, c.b, c.b);
			}
			public static Color32 gaba(this Color32 c)
			{
				return new Color32(c.g, c.a, c.b, c.a);
			}
			
			public static Color32 gaar(this Color32 c)
			{
				return new Color32(c.g, c.a, c.a, c.r);
			}
			public static Color32 gaag(this Color32 c)
			{
				return new Color32(c.g, c.a, c.a, c.g);
			}
			public static Color32 gaab(this Color32 c)
			{
				return new Color32(c.g, c.a, c.a, c.b);
			}
			public static Color32 gaaa(this Color32 c)
			{
				return new Color32(c.g, c.a, c.a, c.a);
			}
			
			#endregion
			
			#endregion
			
			#region brrr-baaa
			
			#region brrr-braa
			
			public static Color32 brrr(this Color32 c)
			{
				return new Color32(c.b, c.r, c.r, c.r);
			}
			public static Color32 brrg(this Color32 c)
			{
				return new Color32(c.b, c.r, c.r, c.g);
			}
			public static Color32 brrb(this Color32 c)
			{
				return new Color32(c.b, c.r, c.r, c.b);
			}
			public static Color32 brra(this Color32 c)
			{
				return new Color32(c.b, c.r, c.r, c.a);
			}
			
			public static Color32 brgr(this Color32 c)
			{
				return new Color32(c.b, c.r, c.g, c.r);
			}
			public static Color32 brgg(this Color32 c)
			{
				return new Color32(c.b, c.r, c.g, c.g);
			}
			public static Color32 brgb(this Color32 c)
			{
				return new Color32(c.b, c.r, c.g, c.b);
			}
			public static Color32 brga(this Color32 c)
			{
				return new Color32(c.b, c.r, c.g, c.a);
			}
			
			public static Color32 brbr(this Color32 c)
			{
				return new Color32(c.b, c.r, c.b, c.r);
			}
			public static Color32 brbg(this Color32 c)
			{
				return new Color32(c.b, c.r, c.b, c.g);
			}
			public static Color32 brbb(this Color32 c)
			{
				return new Color32(c.b, c.r, c.b, c.b);
			}
			public static Color32 brba(this Color32 c)
			{
				return new Color32(c.b, c.r, c.b, c.a);
			}
			
			public static Color32 brar(this Color32 c)
			{
				return new Color32(c.b, c.r, c.a, c.r);
			}
			public static Color32 brag(this Color32 c)
			{
				return new Color32(c.b, c.r, c.a, c.g);
			}
			public static Color32 brab(this Color32 c)
			{
				return new Color32(c.b, c.r, c.a, c.b);
			}
			public static Color32 braa(this Color32 c)
			{
				return new Color32(c.b, c.r, c.a, c.a);
			}
			
			#endregion
			
			#region bgrr-bgaa
			
			public static Color32 bgrr(this Color32 c)
			{
				return new Color32(c.b, c.g, c.r, c.r);
			}
			public static Color32 bgrg(this Color32 c)
			{
				return new Color32(c.b, c.g, c.r, c.g);
			}
			public static Color32 bgrb(this Color32 c)
			{
				return new Color32(c.b, c.g, c.r, c.b);
			}
			public static Color32 bgra(this Color32 c)
			{
				return new Color32(c.b, c.g, c.r, c.a);
			}
			
			public static Color32 bggr(this Color32 c)
			{
				return new Color32(c.b, c.g, c.g, c.r);
			}
			public static Color32 bggg(this Color32 c)
			{
				return new Color32(c.b, c.g, c.g, c.g);
			}
			public static Color32 bggb(this Color32 c)
			{
				return new Color32(c.b, c.g, c.g, c.b);
			}
			public static Color32 bgga(this Color32 c)
			{
				return new Color32(c.b, c.g, c.g, c.a);
			}
			
			public static Color32 bgbr(this Color32 c)
			{
				return new Color32(c.b, c.g, c.b, c.r);
			}
			public static Color32 bgbg(this Color32 c)
			{
				return new Color32(c.b, c.g, c.b, c.g);
			}
			public static Color32 bgbb(this Color32 c)
			{
				return new Color32(c.b, c.g, c.b, c.b);
			}
			public static Color32 bgba(this Color32 c)
			{
				return new Color32(c.b, c.g, c.b, c.a);
			}
			
			public static Color32 bgar(this Color32 c)
			{
				return new Color32(c.b, c.g, c.a, c.r);
			}
			public static Color32 bgag(this Color32 c)
			{
				return new Color32(c.b, c.g, c.a, c.g);
			}
			public static Color32 bgab(this Color32 c)
			{
				return new Color32(c.b, c.g, c.a, c.b);
			}
			public static Color32 bgaa(this Color32 c)
			{
				return new Color32(c.b, c.g, c.a, c.a);
			}
			
			#endregion
			
			#region bbrr-bbaa
			
			public static Color32 bbrr(this Color32 c)
			{
				return new Color32(c.b, c.b, c.r, c.r);
			}
			public static Color32 bbrg(this Color32 c)
			{
				return new Color32(c.b, c.b, c.r, c.g);
			}
			public static Color32 bbrb(this Color32 c)
			{
				return new Color32(c.b, c.b, c.r, c.b);
			}
			public static Color32 bbra(this Color32 c)
			{
				return new Color32(c.b, c.b, c.r, c.a);
			}
			
			public static Color32 bbgr(this Color32 c)
			{
				return new Color32(c.b, c.b, c.g, c.r);
			}
			public static Color32 bbgg(this Color32 c)
			{
				return new Color32(c.b, c.b, c.g, c.g);
			}
			public static Color32 bbgb(this Color32 c)
			{
				return new Color32(c.b, c.b, c.g, c.b);
			}
			public static Color32 bbga(this Color32 c)
			{
				return new Color32(c.b, c.b, c.g, c.a);
			}
			
			public static Color32 bbbr(this Color32 c)
			{
				return new Color32(c.b, c.b, c.b, c.r);
			}
			public static Color32 bbbg(this Color32 c)
			{
				return new Color32(c.b, c.b, c.b, c.g);
			}
			public static Color32 bbbb(this Color32 c)
			{
				return new Color32(c.b, c.b, c.b, c.b);
			}
			public static Color32 bbba(this Color32 c)
			{
				return new Color32(c.b, c.b, c.b, c.a);
			}
			
			public static Color32 bbar(this Color32 c)
			{
				return new Color32(c.b, c.b, c.a, c.r);
			}
			public static Color32 bbag(this Color32 c)
			{
				return new Color32(c.b, c.b, c.a, c.g);
			}
			public static Color32 bbab(this Color32 c)
			{
				return new Color32(c.b, c.b, c.a, c.b);
			}
			public static Color32 bbaa(this Color32 c)
			{
				return new Color32(c.b, c.b, c.a, c.a);
			}
			
			#endregion
			
			#region barr-baaa
			
			public static Color32 barr(this Color32 c)
			{
				return new Color32(c.b, c.a, c.r, c.r);
			}
			public static Color32 barg(this Color32 c)
			{
				return new Color32(c.b, c.a, c.r, c.g);
			}
			public static Color32 barb(this Color32 c)
			{
				return new Color32(c.b, c.a, c.r, c.b);
			}
			public static Color32 bara(this Color32 c)
			{
				return new Color32(c.b, c.a, c.r, c.a);
			}
			
			public static Color32 bagr(this Color32 c)
			{
				return new Color32(c.b, c.a, c.g, c.r);
			}
			public static Color32 bagg(this Color32 c)
			{
				return new Color32(c.b, c.a, c.g, c.g);
			}
			public static Color32 bagb(this Color32 c)
			{
				return new Color32(c.b, c.a, c.g, c.b);
			}
			public static Color32 baga(this Color32 c)
			{
				return new Color32(c.b, c.a, c.g, c.a);
			}
			
			public static Color32 babr(this Color32 c)
			{
				return new Color32(c.b, c.a, c.b, c.r);
			}
			public static Color32 babg(this Color32 c)
			{
				return new Color32(c.b, c.a, c.b, c.g);
			}
			public static Color32 babb(this Color32 c)
			{
				return new Color32(c.b, c.a, c.b, c.b);
			}
			public static Color32 baba(this Color32 c)
			{
				return new Color32(c.b, c.a, c.b, c.a);
			}
			
			public static Color32 baar(this Color32 c)
			{
				return new Color32(c.b, c.a, c.a, c.r);
			}
			public static Color32 baag(this Color32 c)
			{
				return new Color32(c.b, c.a, c.a, c.g);
			}
			public static Color32 baab(this Color32 c)
			{
				return new Color32(c.b, c.a, c.a, c.b);
			}
			public static Color32 baaa(this Color32 c)
			{
				return new Color32(c.b, c.a, c.a, c.a);
			}
			
			#endregion
			
			#endregion
			
			#region arrr-aaaa
			
			#region arrr-araa
			
			public static Color32 arrr(this Color32 c)
			{
				return new Color32(c.a, c.r, c.r, c.r);
			}
			public static Color32 arrg(this Color32 c)
			{
				return new Color32(c.a, c.r, c.r, c.g);
			}
			public static Color32 arrb(this Color32 c)
			{
				return new Color32(c.a, c.r, c.r, c.b);
			}
			public static Color32 arra(this Color32 c)
			{
				return new Color32(c.a, c.r, c.r, c.a);
			}
			
			public static Color32 argr(this Color32 c)
			{
				return new Color32(c.a, c.r, c.g, c.r);
			}
			public static Color32 argg(this Color32 c)
			{
				return new Color32(c.a, c.r, c.g, c.g);
			}
			public static Color32 argb(this Color32 c)
			{
				return new Color32(c.a, c.r, c.g, c.b);
			}
			public static Color32 arga(this Color32 c)
			{
				return new Color32(c.a, c.r, c.g, c.a);
			}
			
			public static Color32 arbr(this Color32 c)
			{
				return new Color32(c.a, c.r, c.b, c.r);
			}
			public static Color32 arbg(this Color32 c)
			{
				return new Color32(c.a, c.r, c.b, c.g);
			}
			public static Color32 arbb(this Color32 c)
			{
				return new Color32(c.a, c.r, c.b, c.b);
			}
			public static Color32 arba(this Color32 c)
			{
				return new Color32(c.a, c.r, c.b, c.a);
			}
			
			public static Color32 arar(this Color32 c)
			{
				return new Color32(c.a, c.r, c.a, c.r);
			}
			public static Color32 arag(this Color32 c)
			{
				return new Color32(c.a, c.r, c.a, c.g);
			}
			public static Color32 arab(this Color32 c)
			{
				return new Color32(c.a, c.r, c.a, c.b);
			}
			public static Color32 araa(this Color32 c)
			{
				return new Color32(c.a, c.r, c.a, c.a);
			}
			
			#endregion
			
			#region agrr-agaa
			
			public static Color32 agrr(this Color32 c)
			{
				return new Color32(c.a, c.g, c.r, c.r);
			}
			public static Color32 agrg(this Color32 c)
			{
				return new Color32(c.a, c.g, c.r, c.g);
			}
			public static Color32 agrb(this Color32 c)
			{
				return new Color32(c.a, c.g, c.r, c.b);
			}
			public static Color32 agra(this Color32 c)
			{
				return new Color32(c.a, c.g, c.r, c.a);
			}
			
			public static Color32 aggr(this Color32 c)
			{
				return new Color32(c.a, c.g, c.g, c.r);
			}
			public static Color32 aggg(this Color32 c)
			{
				return new Color32(c.a, c.g, c.g, c.g);
			}
			public static Color32 aggb(this Color32 c)
			{
				return new Color32(c.a, c.g, c.g, c.b);
			}
			public static Color32 agga(this Color32 c)
			{
				return new Color32(c.a, c.g, c.g, c.a);
			}
			
			public static Color32 agbr(this Color32 c)
			{
				return new Color32(c.a, c.g, c.b, c.r);
			}
			public static Color32 agbg(this Color32 c)
			{
				return new Color32(c.a, c.g, c.b, c.g);
			}
			public static Color32 agbb(this Color32 c)
			{
				return new Color32(c.a, c.g, c.b, c.b);
			}
			public static Color32 agba(this Color32 c)
			{
				return new Color32(c.a, c.g, c.b, c.a);
			}
			
			public static Color32 agar(this Color32 c)
			{
				return new Color32(c.a, c.g, c.a, c.r);
			}
			public static Color32 agag(this Color32 c)
			{
				return new Color32(c.a, c.g, c.a, c.g);
			}
			public static Color32 agab(this Color32 c)
			{
				return new Color32(c.a, c.g, c.a, c.b);
			}
			public static Color32 agaa(this Color32 c)
			{
				return new Color32(c.a, c.g, c.a, c.a);
			}
			
			#endregion
			
			#region abrr-abaa
			
			public static Color32 abrr(this Color32 c)
			{
				return new Color32(c.a, c.b, c.r, c.r);
			}
			public static Color32 abrg(this Color32 c)
			{
				return new Color32(c.a, c.b, c.r, c.g);
			}
			public static Color32 abrb(this Color32 c)
			{
				return new Color32(c.a, c.b, c.r, c.b);
			}
			public static Color32 abra(this Color32 c)
			{
				return new Color32(c.a, c.b, c.r, c.a);
			}
			
			public static Color32 abgr(this Color32 c)
			{
				return new Color32(c.a, c.b, c.g, c.r);
			}
			public static Color32 abgg(this Color32 c)
			{
				return new Color32(c.a, c.b, c.g, c.g);
			}
			public static Color32 abgb(this Color32 c)
			{
				return new Color32(c.a, c.b, c.g, c.b);
			}
			public static Color32 abga(this Color32 c)
			{
				return new Color32(c.a, c.b, c.g, c.a);
			}
			
			public static Color32 abbr(this Color32 c)
			{
				return new Color32(c.a, c.b, c.b, c.r);
			}
			public static Color32 abbg(this Color32 c)
			{
				return new Color32(c.a, c.b, c.b, c.g);
			}
			public static Color32 abbb(this Color32 c)
			{
				return new Color32(c.a, c.b, c.b, c.b);
			}
			public static Color32 abba(this Color32 c)
			{
				return new Color32(c.a, c.b, c.b, c.a);
			}
			
			public static Color32 abar(this Color32 c)
			{
				return new Color32(c.a, c.b, c.a, c.r);
			}
			public static Color32 abag(this Color32 c)
			{
				return new Color32(c.a, c.b, c.a, c.g);
			}
			public static Color32 abab(this Color32 c)
			{
				return new Color32(c.a, c.b, c.a, c.b);
			}
			public static Color32 abaa(this Color32 c)
			{
				return new Color32(c.a, c.b, c.a, c.a);
			}
			
			#endregion
			
			#region aarr-aaaa
			
			public static Color32 aarr(this Color32 c)
			{
				return new Color32(c.a, c.a, c.r, c.r);
			}
			public static Color32 aarg(this Color32 c)
			{
				return new Color32(c.a, c.a, c.r, c.g);
			}
			public static Color32 aarb(this Color32 c)
			{
				return new Color32(c.a, c.a, c.r, c.b);
			}
			public static Color32 aara(this Color32 c)
			{
				return new Color32(c.a, c.a, c.r, c.a);
			}
			
			public static Color32 aagr(this Color32 c)
			{
				return new Color32(c.a, c.a, c.g, c.r);
			}
			public static Color32 aagg(this Color32 c)
			{
				return new Color32(c.a, c.a, c.g, c.g);
			}
			public static Color32 aagb(this Color32 c)
			{
				return new Color32(c.a, c.a, c.g, c.b);
			}
			public static Color32 aaga(this Color32 c)
			{
				return new Color32(c.a, c.a, c.g, c.a);
			}
			
			public static Color32 aabr(this Color32 c)
			{
				return new Color32(c.a, c.a, c.b, c.r);
			}
			public static Color32 aabg(this Color32 c)
			{
				return new Color32(c.a, c.a, c.b, c.g);
			}
			public static Color32 aabb(this Color32 c)
			{
				return new Color32(c.a, c.a, c.b, c.b);
			}
			public static Color32 aaba(this Color32 c)
			{
				return new Color32(c.a, c.a, c.b, c.a);
			}
			
			public static Color32 aaar(this Color32 c)
			{
				return new Color32(c.a, c.a, c.a, c.r);
			}
			public static Color32 aaag(this Color32 c)
			{
				return new Color32(c.a, c.a, c.a, c.g);
			}
			public static Color32 aaab(this Color32 c)
			{
				return new Color32(c.a, c.a, c.a, c.b);
			}
			public static Color32 aaaa(this Color32 c)
			{
				return new Color32(c.a, c.a, c.a, c.a);
			}
			
			#endregion
			
			#endregion
			
			#endregion
		}
	}
}