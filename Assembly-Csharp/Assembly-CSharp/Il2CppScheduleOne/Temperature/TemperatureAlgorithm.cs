using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Temperature
{
	// Token: 0x0200011F RID: 287
	public static class TemperatureAlgorithm : Il2CppSystem.Object
	{
		// Token: 0x06001BC3 RID: 7107 RVA: 0x000D6C3C File Offset: 0x000D4E3C
		// Note: this type is marked as 'beforefieldinit'.
		static TemperatureAlgorithm()
		{
			Il2CppClassPointerStore<TemperatureAlgorithm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Temperature", "TemperatureAlgorithm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemperatureAlgorithm>.NativeClassPtr);
			TemperatureAlgorithm.NativeFieldInfoPtr_NegligibleInfluenceThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemperatureAlgorithm>.NativeClassPtr, "NegligibleInfluenceThreshold");
			TemperatureAlgorithm.NativeMethodInfoPtr_GetTemperatureAtPoint_Public_Static_Single_Single_Vector3_Vector3_Il2CppStructArray_1_TemperatureEmitterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemperatureAlgorithm>.NativeClassPtr, 100666974);
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x000D6C94 File Offset: 0x000D4E94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 102406, RefRangeEnd = 102408, XrefRangeStart = 102403, XrefRangeEnd = 102406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetTemperatureAtPoint(float ambientTemperature, Vector3 originPoint, Vector3 point, Il2CppStructArray<TemperatureEmitterInfo> emitters)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ambientTemperature;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(emitters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TemperatureAlgorithm.NativeMethodInfoPtr_GetTemperatureAtPoint_Public_Static_Single_Single_Vector3_Vector3_Il2CppStructArray_1_TemperatureEmitterInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x0000F164 File Offset: 0x0000D364
		public TemperatureAlgorithm(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x000D6D00 File Offset: 0x000D4F00
		// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x0000F16D File Offset: 0x0000D36D
		public unsafe static float NegligibleInfluenceThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TemperatureAlgorithm.NativeFieldInfoPtr_NegligibleInfluenceThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TemperatureAlgorithm.NativeFieldInfoPtr_NegligibleInfluenceThreshold, (void*)(&value));
			}
		}

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeFieldInfoPtr_NegligibleInfluenceThreshold;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeMethodInfoPtr_GetTemperatureAtPoint_Public_Static_Single_Single_Vector3_Vector3_Il2CppStructArray_1_TemperatureEmitterInfo_0;
	}
}
