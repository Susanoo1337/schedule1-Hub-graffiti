using System;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Weather;
using Il2CppSystem;

namespace Il2CppScheduleOne.Weather
{
	// Token: 0x020006DF RID: 1759
	public static class WeatherProfileNetworkSerializer : Object
	{
		// Token: 0x0600A9B4 RID: 43444 RVA: 0x002CDA94 File Offset: 0x002CBC94
		// Note: this type is marked as 'beforefieldinit'.
		static WeatherProfileNetworkSerializer()
		{
			Il2CppClassPointerStore<WeatherProfileNetworkSerializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Weather", "WeatherProfileNetworkSerializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherProfileNetworkSerializer>.NativeClassPtr);
			WeatherProfileNetworkSerializer.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherProfileNetworkSerializer>.NativeClassPtr, "Null");
			WeatherProfileNetworkSerializer.NativeMethodInfoPtr_WriteWeatherProfile_Public_Static_Void_Writer_WeatherProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherProfileNetworkSerializer>.NativeClassPtr, 100685818);
			WeatherProfileNetworkSerializer.NativeMethodInfoPtr_ReadWeatherProfile_Public_Static_WeatherProfile_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherProfileNetworkSerializer>.NativeClassPtr, 100685819);
		}

		// Token: 0x0600A9B5 RID: 43445 RVA: 0x002CDB00 File Offset: 0x002CBD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293801, XrefRangeEnd = 293810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteWeatherProfile(this Writer writer, WeatherProfile value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherProfileNetworkSerializer.NativeMethodInfoPtr_WriteWeatherProfile_Public_Static_Void_Writer_WeatherProfile_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A9B6 RID: 43446 RVA: 0x002CDB48 File Offset: 0x002CBD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293810, XrefRangeEnd = 293819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WeatherProfile ReadWeatherProfile(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherProfileNetworkSerializer.NativeMethodInfoPtr_ReadWeatherProfile_Public_Static_WeatherProfile_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeatherProfile>(intPtr3) : null;
		}

		// Token: 0x0600A9B7 RID: 43447 RVA: 0x0004D549 File Offset: 0x0004B749
		public WeatherProfileNetworkSerializer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032B0 RID: 12976
		// (get) Token: 0x0600A9B8 RID: 43448 RVA: 0x002CDB8C File Offset: 0x002CBD8C
		// (set) Token: 0x0600A9B9 RID: 43449 RVA: 0x0004D552 File Offset: 0x0004B752
		public unsafe static string Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WeatherProfileNetworkSerializer.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WeatherProfileNetworkSerializer.NativeFieldInfoPtr_Null, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400754D RID: 30029
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x0400754E RID: 30030
		private static readonly IntPtr NativeMethodInfoPtr_WriteWeatherProfile_Public_Static_Void_Writer_WeatherProfile_0;

		// Token: 0x0400754F RID: 30031
		private static readonly IntPtr NativeMethodInfoPtr_ReadWeatherProfile_Public_Static_WeatherProfile_Reader_0;
	}
}
