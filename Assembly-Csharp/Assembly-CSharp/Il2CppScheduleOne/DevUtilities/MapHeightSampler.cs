using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003F7 RID: 1015
	public static class MapHeightSampler : Il2CppSystem.Object
	{
		// Token: 0x06005A14 RID: 23060 RVA: 0x001B20CC File Offset: 0x001B02CC
		// Note: this type is marked as 'beforefieldinit'.
		static MapHeightSampler()
		{
			Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "MapHeightSampler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr);
			MapHeightSampler.NativeFieldInfoPtr_SampleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, "SampleHeight");
			MapHeightSampler.NativeFieldInfoPtr_SampleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, "SampleDistance");
			MapHeightSampler.NativeMethodInfoPtr_TrySample_Public_Static_Boolean_Single_Single_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapHeightSampler>.NativeClassPtr, 100675076);
		}

		// Token: 0x06005A15 RID: 23061 RVA: 0x001B2138 File Offset: 0x001B0338
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 194780, RefRangeEnd = 194785, XrefRangeStart = 194769, XrefRangeEnd = 194780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrySample(float x, float z, out Vector3 hitPoint)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapHeightSampler.NativeMethodInfoPtr_TrySample_Public_Static_Boolean_Single_Single_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A16 RID: 23062 RVA: 0x0002ABDE File Offset: 0x00028DDE
		public MapHeightSampler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x06005A17 RID: 23063 RVA: 0x001B2194 File Offset: 0x001B0394
		// (set) Token: 0x06005A18 RID: 23064 RVA: 0x0002ABE7 File Offset: 0x00028DE7
		public unsafe static float SampleHeight
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MapHeightSampler.NativeFieldInfoPtr_SampleHeight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MapHeightSampler.NativeFieldInfoPtr_SampleHeight, (void*)(&value));
			}
		}

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x06005A19 RID: 23065 RVA: 0x001B21B0 File Offset: 0x001B03B0
		// (set) Token: 0x06005A1A RID: 23066 RVA: 0x0002ABF5 File Offset: 0x00028DF5
		public unsafe static float SampleDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MapHeightSampler.NativeFieldInfoPtr_SampleDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MapHeightSampler.NativeFieldInfoPtr_SampleDistance, (void*)(&value));
			}
		}

		// Token: 0x04003DCD RID: 15821
		private static readonly IntPtr NativeFieldInfoPtr_SampleHeight;

		// Token: 0x04003DCE RID: 15822
		private static readonly IntPtr NativeFieldInfoPtr_SampleDistance;

		// Token: 0x04003DCF RID: 15823
		private static readonly IntPtr NativeMethodInfoPtr_TrySample_Public_Static_Boolean_Single_Single_byref_Vector3_0;
	}
}
