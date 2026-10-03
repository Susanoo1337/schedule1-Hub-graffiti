using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Rendering
{
	// Token: 0x0200034C RID: 844
	public class ObjectIdResult
	{
		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06002DE2 RID: 11746 RVA: 0x000146D7 File Offset: 0x000128D7
		public Il2CppReferenceArray<Object> idToObjectMapping
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x000AD054 File Offset: 0x000AB254
		public static int DecodeIdFromColor(Color color)
		{
			return (int)(color.r * 255f) + ((int)(color.g * 255f) << 8) + ((int)(color.b * 255f) << 16) + ((int)(color.a * 255f) << 24);
		}
	}
}
