using System;
using Il2CppSystem;

namespace UnityEngine.Assertions.Comparers
{
	// Token: 0x02000370 RID: 880
	public class FloatComparer
	{
		// Token: 0x06002F59 RID: 12121 RVA: 0x00015557 File Offset: 0x00013757
		public bool Equals(float a, float b)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x000ADA04 File Offset: 0x000ABC04
		public int GetHashCode(float obj)
		{
			return base.GetHashCode();
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x000ADA1C File Offset: 0x000ABC1C
		public static bool AreEqual(float expected, float actual, float error)
		{
			return Math.Abs(actual - expected) <= error;
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x000ADA3C File Offset: 0x000ABC3C
		public static bool AreEqualRelative(float expected, float actual, float error)
		{
			bool flag = expected == actual;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				float num = Math.Abs(expected);
				float num2 = Math.Abs(actual);
				float num3 = Math.Abs((actual - expected) / ((num > num2) ? num : num2));
				result = (num3 <= error);
			}
			return result;
		}

		// Token: 0x040029AA RID: 10666
		public const float kEpsilon = 1E-05f;
	}
}
