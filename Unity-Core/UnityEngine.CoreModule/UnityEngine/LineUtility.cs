using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x020002F1 RID: 753
	public sealed class LineUtility
	{
		// Token: 0x06002D16 RID: 11542 RVA: 0x000ABE70 File Offset: 0x000AA070
		public static void Simplify(List<Vector3> points, float tolerance, List<int> pointsToKeep)
		{
			bool flag = points == null;
			if (flag)
			{
				throw new ArgumentNullException("points");
			}
			bool flag2 = pointsToKeep == null;
			if (flag2)
			{
				throw new ArgumentNullException("pointsToKeep");
			}
			LineUtility.GeneratePointsToKeep3D(points, tolerance, pointsToKeep);
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x000ABEB0 File Offset: 0x000AA0B0
		public static void Simplify(List<Vector3> points, float tolerance, List<Vector3> simplifiedPoints)
		{
			bool flag = points == null;
			if (flag)
			{
				throw new ArgumentNullException("points");
			}
			bool flag2 = simplifiedPoints == null;
			if (flag2)
			{
				throw new ArgumentNullException("simplifiedPoints");
			}
			LineUtility.GenerateSimplifiedPoints3D(points, tolerance, simplifiedPoints);
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x000ABEF0 File Offset: 0x000AA0F0
		public static void Simplify(List<Vector2> points, float tolerance, List<int> pointsToKeep)
		{
			bool flag = points == null;
			if (flag)
			{
				throw new ArgumentNullException("points");
			}
			bool flag2 = pointsToKeep == null;
			if (flag2)
			{
				throw new ArgumentNullException("pointsToKeep");
			}
			LineUtility.GeneratePointsToKeep2D(points, tolerance, pointsToKeep);
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x000ABF30 File Offset: 0x000AA130
		public static void Simplify(List<Vector2> points, float tolerance, List<Vector2> simplifiedPoints)
		{
			bool flag = points == null;
			if (flag)
			{
				throw new ArgumentNullException("points");
			}
			bool flag2 = simplifiedPoints == null;
			if (flag2)
			{
				throw new ArgumentNullException("simplifiedPoints");
			}
			LineUtility.GenerateSimplifiedPoints2D(points, tolerance, simplifiedPoints);
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x00013E42 File Offset: 0x00012042
		public static void GeneratePointsToKeep3D(Object pointsList, float tolerance, Object pointsToKeepList)
		{
			LineUtility.GeneratePointsToKeep3DDelegateField(IL2CPP.Il2CppObjectBaseToPtr(pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr(pointsToKeepList));
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x00013E5B File Offset: 0x0001205B
		public static void GeneratePointsToKeep2D(Object pointsList, float tolerance, Object pointsToKeepList)
		{
			LineUtility.GeneratePointsToKeep2DDelegateField(IL2CPP.Il2CppObjectBaseToPtr(pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr(pointsToKeepList));
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x00013E74 File Offset: 0x00012074
		public static void GenerateSimplifiedPoints3D(Object pointsList, float tolerance, Object simplifiedPoints)
		{
			LineUtility.GenerateSimplifiedPoints3DDelegateField(IL2CPP.Il2CppObjectBaseToPtr(pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr(simplifiedPoints));
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x00013E8D File Offset: 0x0001208D
		public static void GenerateSimplifiedPoints2D(Object pointsList, float tolerance, Object simplifiedPoints)
		{
			LineUtility.GenerateSimplifiedPoints2DDelegateField(IL2CPP.Il2CppObjectBaseToPtr(pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr(simplifiedPoints));
		}

		// Token: 0x040027CF RID: 10191
		private static readonly LineUtility.GeneratePointsToKeep3DDelegate GeneratePointsToKeep3DDelegateField = IL2CPP.ResolveICall<LineUtility.GeneratePointsToKeep3DDelegate>("UnityEngine.LineUtility::GeneratePointsToKeep3D");

		// Token: 0x040027D0 RID: 10192
		private static readonly LineUtility.GeneratePointsToKeep2DDelegate GeneratePointsToKeep2DDelegateField = IL2CPP.ResolveICall<LineUtility.GeneratePointsToKeep2DDelegate>("UnityEngine.LineUtility::GeneratePointsToKeep2D");

		// Token: 0x040027D1 RID: 10193
		private static readonly LineUtility.GenerateSimplifiedPoints3DDelegate GenerateSimplifiedPoints3DDelegateField = IL2CPP.ResolveICall<LineUtility.GenerateSimplifiedPoints3DDelegate>("UnityEngine.LineUtility::GenerateSimplifiedPoints3D");

		// Token: 0x040027D2 RID: 10194
		private static readonly LineUtility.GenerateSimplifiedPoints2DDelegate GenerateSimplifiedPoints2DDelegateField = IL2CPP.ResolveICall<LineUtility.GenerateSimplifiedPoints2DDelegate>("UnityEngine.LineUtility::GenerateSimplifiedPoints2D");

		// Token: 0x02000CB0 RID: 3248
		// (Invoke) Token: 0x060041FD RID: 16893
		private delegate void GeneratePointsToKeep3DDelegate(IntPtr pointsList, float tolerance, IntPtr pointsToKeepList);

		// Token: 0x02000CB1 RID: 3249
		// (Invoke) Token: 0x060041FF RID: 16895
		private delegate void GeneratePointsToKeep2DDelegate(IntPtr pointsList, float tolerance, IntPtr pointsToKeepList);

		// Token: 0x02000CB2 RID: 3250
		// (Invoke) Token: 0x06004201 RID: 16897
		private delegate void GenerateSimplifiedPoints3DDelegate(IntPtr pointsList, float tolerance, IntPtr simplifiedPoints);

		// Token: 0x02000CB3 RID: 3251
		// (Invoke) Token: 0x06004203 RID: 16899
		private delegate void GenerateSimplifiedPoints2DDelegate(IntPtr pointsList, float tolerance, IntPtr simplifiedPoints);
	}
}
