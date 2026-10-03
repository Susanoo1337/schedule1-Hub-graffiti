using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000165 RID: 357
	public class SystemClock : Object
	{
		// Token: 0x06001B35 RID: 6965 RVA: 0x00071A84 File Offset: 0x0006FC84
		// Note: this type is marked as 'beforefieldinit'.
		static SystemClock()
		{
			Il2CppClassPointerStore<SystemClock>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SystemClock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemClock>.NativeClassPtr);
			SystemClock.NativeFieldInfoPtr_s_Epoch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemClock>.NativeClassPtr, "s_Epoch");
			SystemClock.NativeMethodInfoPtr_get_now_Public_Static_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemClock>.NativeClassPtr, 100666200);
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x00071ADC File Offset: 0x0006FCDC
		public unsafe static DateTime now
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1272160, RefRangeEnd = 1272163, XrefRangeStart = 1272156, XrefRangeEnd = 1272160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemClock.NativeMethodInfoPtr_get_now_Public_Static_get_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x0000D099 File Offset: 0x0000B299
		public SystemClock(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x00071B0C File Offset: 0x0006FD0C
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x0000D0A2 File Offset: 0x0000B2A2
		public unsafe static DateTime s_Epoch
		{
			get
			{
				DateTime result;
				IL2CPP.il2cpp_field_static_get_value(SystemClock.NativeFieldInfoPtr_s_Epoch, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemClock.NativeFieldInfoPtr_s_Epoch, (void*)(&value));
			}
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x00071B28 File Offset: 0x0006FD28
		public static long ToUnixTimeMilliseconds(DateTime date)
		{
			return Convert.ToInt64((date.ToUniversalTime() - SystemClock.s_Epoch).TotalMilliseconds);
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00071B58 File Offset: 0x0006FD58
		public static long ToUnixTimeSeconds(DateTime date)
		{
			return Convert.ToInt64((date.ToUniversalTime() - SystemClock.s_Epoch).TotalSeconds);
		}

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeFieldInfoPtr_s_Epoch;

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeMethodInfoPtr_get_now_Public_Static_get_DateTime_0;
	}
}
