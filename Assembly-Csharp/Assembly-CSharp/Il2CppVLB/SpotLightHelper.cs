using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000072 RID: 114
	public static class SpotLightHelper : Il2CppSystem.Object
	{
		// Token: 0x0600086D RID: 2157 RVA: 0x00096258 File Offset: 0x00094458
		// Note: this type is marked as 'beforefieldinit'.
		static SpotLightHelper()
		{
			Il2CppClassPointerStore<SpotLightHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "SpotLightHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpotLightHelper>.NativeClassPtr);
			SpotLightHelper.NativeMethodInfoPtr_GetIntensity_Public_Static_Single_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotLightHelper>.NativeClassPtr, 100664363);
			SpotLightHelper.NativeMethodInfoPtr_GetSpotAngle_Public_Static_Single_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotLightHelper>.NativeClassPtr, 100664364);
			SpotLightHelper.NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpotLightHelper>.NativeClassPtr, 100664365);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000962C4 File Offset: 0x000944C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73752, RefRangeEnd = 73754, XrefRangeStart = 73747, XrefRangeEnd = 73752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetIntensity(Light light)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotLightHelper.NativeMethodInfoPtr_GetIntensity_Public_Static_Single_Light_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00096308 File Offset: 0x00094508
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73759, RefRangeEnd = 73761, XrefRangeStart = 73754, XrefRangeEnd = 73759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetSpotAngle(Light light)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotLightHelper.NativeMethodInfoPtr_GetSpotAngle_Public_Static_Single_Light_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0009634C File Offset: 0x0009454C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73766, RefRangeEnd = 73768, XrefRangeStart = 73761, XrefRangeEnd = 73766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFallOffEnd(Light light)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpotLightHelper.NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_Light_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0000602E File Offset: 0x0000422E
		public SpotLightHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_GetIntensity_Public_Static_Single_Light_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_GetSpotAngle_Public_Static_Single_Light_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_Light_0;
	}
}
