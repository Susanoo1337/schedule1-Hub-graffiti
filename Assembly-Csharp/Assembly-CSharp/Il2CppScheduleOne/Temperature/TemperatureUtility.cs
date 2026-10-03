using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Temperature
{
	// Token: 0x02000122 RID: 290
	public static class TemperatureUtility : Object
	{
		// Token: 0x06001BE4 RID: 7140 RVA: 0x000D72D8 File Offset: 0x000D54D8
		// Note: this type is marked as 'beforefieldinit'.
		static TemperatureUtility()
		{
			Il2CppClassPointerStore<TemperatureUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Temperature", "TemperatureUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemperatureUtility>.NativeClassPtr);
			TemperatureUtility.NativeMethodInfoPtr_get_TemperatureSystemEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureUtility>.NativeClassPtr, 100666987);
			TemperatureUtility.NativeMethodInfoPtr_ToFahrenheit_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureUtility>.NativeClassPtr, 100666988);
			TemperatureUtility.NativeMethodInfoPtr_FormatCelsiusTemperature_Public_Static_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureUtility>.NativeClassPtr, 100666989);
			TemperatureUtility.NativeMethodInfoPtr_FormatFahrenheitTemperature_Public_Static_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureUtility>.NativeClassPtr, 100666990);
			TemperatureUtility.NativeMethodInfoPtr_FormatTemperatureWithAppropriateUnit_Public_Static_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureUtility>.NativeClassPtr, 100666991);
			TemperatureUtility.NativeMethodInfoPtr_NormalizeTemperature_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureUtility>.NativeClassPtr, 100666992);
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x000D7380 File Offset: 0x000D5580
		public unsafe static bool TemperatureSystemEnabled
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 102427, RefRangeEnd = 102435, XrefRangeStart = 102421, XrefRangeEnd = 102427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureUtility.NativeMethodInfoPtr_get_TemperatureSystemEnabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x000D73B0 File Offset: 0x000D55B0
		[CallerCount(0)]
		public unsafe static float ToFahrenheit(float celsius)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref celsius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureUtility.NativeMethodInfoPtr_ToFahrenheit_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x000D73F0 File Offset: 0x000D55F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102435, XrefRangeEnd = 102442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatCelsiusTemperature(float celsius, int decimalPoints)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref celsius;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimalPoints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureUtility.NativeMethodInfoPtr_FormatCelsiusTemperature_Public_Static_String_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x000D7438 File Offset: 0x000D5638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102442, XrefRangeEnd = 102449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatFahrenheitTemperature(float fahrenheit, int decimalPoints)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fahrenheit;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimalPoints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureUtility.NativeMethodInfoPtr_FormatFahrenheitTemperature_Public_Static_String_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x000D7480 File Offset: 0x000D5680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102470, RefRangeEnd = 102471, XrefRangeStart = 102449, XrefRangeEnd = 102470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatTemperatureWithAppropriateUnit(float celsius, int decimalPoints = 1)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref celsius;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimalPoints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureUtility.NativeMethodInfoPtr_FormatTemperatureWithAppropriateUnit_Public_Static_String_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x000D74C8 File Offset: 0x000D56C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102471, RefRangeEnd = 102472, XrefRangeStart = 102471, XrefRangeEnd = 102471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float NormalizeTemperature(float celsius)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref celsius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureUtility.NativeMethodInfoPtr_NormalizeTemperature_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x0000F215 File Offset: 0x0000D415
		public TemperatureUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr_get_TemperatureSystemEnabled_Public_Static_get_Boolean_0;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeMethodInfoPtr_ToFahrenheit_Public_Static_Single_Single_0;

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeMethodInfoPtr_FormatCelsiusTemperature_Public_Static_String_Single_Int32_0;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeMethodInfoPtr_FormatFahrenheitTemperature_Public_Static_String_Single_Int32_0;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeMethodInfoPtr_FormatTemperatureWithAppropriateUnit_Public_Static_String_Single_Int32_0;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeTemperature_Public_Static_Single_Single_0;
	}
}
