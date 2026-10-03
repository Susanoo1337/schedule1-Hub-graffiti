using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000271 RID: 625
	public static class LightmapperUtils : Object
	{
		// Token: 0x06002AEC RID: 10988 RVA: 0x000A7870 File Offset: 0x000A5A70
		// Note: this type is marked as 'beforefieldinit'.
		static LightmapperUtils()
		{
			Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "LightmapperUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100667921);
			LightmapperUtils.NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100667922);
			LightmapperUtils.NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100667923);
			LightmapperUtils.NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100667924);
			LightmapperUtils.NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100667925);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100667926);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100667927);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100667928);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100667929);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100667930);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100667931);
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x000A797C File Offset: 0x000A5B7C
		[CallerCount(0)]
		public unsafe static LightMode Extract(LightmapBakeType baketype)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref baketype;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x000A79BC File Offset: 0x000A5BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294112, XrefRangeEnd = 1294116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LinearColor ExtractIndirect(Light l)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x000A7A00 File Offset: 0x000A5C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294116, XrefRangeEnd = 1294119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ExtractInnerCone(Light l)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x000A7A44 File Offset: 0x000A5C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294119, XrefRangeEnd = 1294123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color ExtractColorTemperature(Light l)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x000A7A88 File Offset: 0x000A5C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294123, XrefRangeEnd = 1294126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyColorTemperature(Color cct, ref LinearColor lightColor)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cct;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x000A7AC8 File Offset: 0x000A5CC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294150, RefRangeEnd = 1294152, XrefRangeStart = 1294126, XrefRangeEnd = 1294150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref DirectionalLight dir)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x000A7B0C File Offset: 0x000A5D0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1294177, RefRangeEnd = 1294180, XrefRangeStart = 1294152, XrefRangeEnd = 1294177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref PointLight point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x000A7B50 File Offset: 0x000A5D50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294209, RefRangeEnd = 1294211, XrefRangeStart = 1294180, XrefRangeEnd = 1294209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref SpotLight spot)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x000A7B94 File Offset: 0x000A5D94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1294236, RefRangeEnd = 1294237, XrefRangeStart = 1294211, XrefRangeEnd = 1294236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref RectangleLight rect)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x000A7BD8 File Offset: 0x000A5DD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1294177, RefRangeEnd = 1294180, XrefRangeStart = 1294177, XrefRangeEnd = 1294180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref DiscLight disc)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &disc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x000A7C1C File Offset: 0x000A5E1C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1294253, RefRangeEnd = 1294258, XrefRangeStart = 1294237, XrefRangeEnd = 1294253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, out Cookie cookie)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x00012E9E File Offset: 0x0001109E
		public LightmapperUtils(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002501 RID: 9473
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0;

		// Token: 0x04002502 RID: 9474
		private static readonly IntPtr NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0;

		// Token: 0x04002503 RID: 9475
		private static readonly IntPtr NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0;

		// Token: 0x04002504 RID: 9476
		private static readonly IntPtr NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0;

		// Token: 0x04002505 RID: 9477
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0;

		// Token: 0x04002506 RID: 9478
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0;

		// Token: 0x04002507 RID: 9479
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0;

		// Token: 0x04002508 RID: 9480
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0;

		// Token: 0x04002509 RID: 9481
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0;

		// Token: 0x0400250A RID: 9482
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0;

		// Token: 0x0400250B RID: 9483
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0;
	}
}
