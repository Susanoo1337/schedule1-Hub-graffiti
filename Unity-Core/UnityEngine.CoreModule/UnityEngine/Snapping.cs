using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	// Token: 0x0200030D RID: 781
	public static class Snapping
	{
		// Token: 0x06002D7A RID: 11642 RVA: 0x000AC914 File Offset: 0x000AAB14
		public static bool IsCardinalDirection(Vector3 direction)
		{
			return (Mathf.Abs(direction.x) > 0f && Mathf.Approximately(direction.y, 0f) && Mathf.Approximately(direction.z, 0f)) || (Mathf.Abs(direction.y) > 0f && Mathf.Approximately(direction.x, 0f) && Mathf.Approximately(direction.z, 0f)) || (Mathf.Abs(direction.z) > 0f && Mathf.Approximately(direction.x, 0f) && Mathf.Approximately(direction.y, 0f));
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x000AC9CC File Offset: 0x000AABCC
		public static float Snap(float val, float snap)
		{
			bool flag = snap == 0f;
			float result;
			if (flag)
			{
				result = val;
			}
			else
			{
				result = snap * Mathf.Round(val / snap);
			}
			return result;
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x000AC9F8 File Offset: 0x000AABF8
		public static Vector2 Snap(Vector2 val, Vector2 snap)
		{
			return new Vector3((Mathf.Abs(snap.x) < Mathf.Epsilon) ? val.x : (snap.x * Mathf.Round(val.x / snap.x)), (Mathf.Abs(snap.y) < Mathf.Epsilon) ? val.y : (snap.y * Mathf.Round(val.y / snap.y)));
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x000ACA7C File Offset: 0x000AAC7C
		public static Vector3 Snap(Vector3 val, Vector3 snap, [Optional] SnapAxis axis)
		{
			return new Vector3(((axis & SnapAxis.X) == SnapAxis.X) ? Snapping.Snap(val.x, snap.x) : val.x, ((axis & SnapAxis.Y) == SnapAxis.Y) ? Snapping.Snap(val.y, snap.y) : val.y, ((axis & SnapAxis.Z) == SnapAxis.Z) ? Snapping.Snap(val.z, snap.z) : val.z);
		}
	}
}
