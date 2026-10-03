using System;
using Il2CppSystem;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections
{
	// Token: 0x0200029D RID: 669
	public static class NativeLeakDetection
	{
		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06002C86 RID: 11398 RVA: 0x000AB634 File Offset: 0x000A9834
		// (set) Token: 0x06002C87 RID: 11399 RVA: 0x000AB64C File Offset: 0x000A984C
		public static NativeLeakDetectionMode Mode
		{
			get
			{
				return Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetLeakDetectionMode();
			}
			set
			{
				bool flag = value < NativeLeakDetectionMode.Disabled || value > NativeLeakDetectionMode.EnabledWithStackTrace;
				if (flag)
				{
					throw new ArgumentException("NativeLeakDetectionMode out of range");
				}
				Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SetLeakDetectionMode(value);
			}
		}
	}
}
