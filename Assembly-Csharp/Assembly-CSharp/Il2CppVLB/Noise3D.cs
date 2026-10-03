using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000066 RID: 102
	public static class Noise3D : Il2CppSystem.Object
	{
		// Token: 0x06000684 RID: 1668 RVA: 0x0008FD5C File Offset: 0x0008DF5C
		// Note: this type is marked as 'beforefieldinit'.
		static Noise3D()
		{
			Il2CppClassPointerStore<Noise3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Noise3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Noise3D>.NativeClassPtr);
			Noise3D.NativeFieldInfoPtr_ms_IsSupportedChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, "ms_IsSupportedChecked");
			Noise3D.NativeFieldInfoPtr_ms_IsSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, "ms_IsSupported");
			Noise3D.NativeFieldInfoPtr_ms_NoiseTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, "ms_NoiseTexture");
			Noise3D.NativeFieldInfoPtr_kMinShaderLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, "kMinShaderLevel");
			Noise3D.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100664091);
			Noise3D.NativeMethodInfoPtr_get_isProperlyLoaded_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100664092);
			Noise3D.NativeMethodInfoPtr_get_isNotSupportedString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100664093);
			Noise3D.NativeMethodInfoPtr_OnStartUp_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100664094);
			Noise3D.NativeMethodInfoPtr_LoadIfNeeded_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100664095);
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x0008FE40 File Offset: 0x0008E040
		public unsafe static bool isSupported
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 71984, RefRangeEnd = 71993, XrefRangeStart = 71964, XrefRangeEnd = 71984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x0008FE70 File Offset: 0x0008E070
		public unsafe static bool isProperlyLoaded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71993, XrefRangeEnd = 71999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_get_isProperlyLoaded_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x0008FEA0 File Offset: 0x0008E0A0
		public unsafe static string isNotSupportedString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71999, XrefRangeEnd = 72008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_get_isNotSupportedString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0008FECC File Offset: 0x0008E0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72008, XrefRangeEnd = 72009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnStartUp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_OnStartUp_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0008FEF4 File Offset: 0x0008E0F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 72028, RefRangeEnd = 72031, XrefRangeStart = 72009, XrefRangeEnd = 72028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadIfNeeded()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_LoadIfNeeded_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00005412 File Offset: 0x00003612
		public Noise3D(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x0008FF1C File Offset: 0x0008E11C
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x0000541B File Offset: 0x0000361B
		public unsafe static bool ms_IsSupportedChecked
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Noise3D.NativeFieldInfoPtr_ms_IsSupportedChecked, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Noise3D.NativeFieldInfoPtr_ms_IsSupportedChecked, (void*)(&value));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x0008FF38 File Offset: 0x0008E138
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00005429 File Offset: 0x00003629
		public unsafe static bool ms_IsSupported
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Noise3D.NativeFieldInfoPtr_ms_IsSupported, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Noise3D.NativeFieldInfoPtr_ms_IsSupported, (void*)(&value));
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x0008FF54 File Offset: 0x0008E154
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x00005437 File Offset: 0x00003637
		public unsafe static Texture3D ms_NoiseTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Noise3D.NativeFieldInfoPtr_ms_NoiseTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Noise3D.NativeFieldInfoPtr_ms_NoiseTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x0008FF7C File Offset: 0x0008E17C
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00005449 File Offset: 0x00003649
		public unsafe static int kMinShaderLevel
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Noise3D.NativeFieldInfoPtr_kMinShaderLevel, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Noise3D.NativeFieldInfoPtr_kMinShaderLevel, (void*)(&value));
			}
		}

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeFieldInfoPtr_ms_IsSupportedChecked;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeFieldInfoPtr_ms_IsSupported;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeFieldInfoPtr_ms_NoiseTexture;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeFieldInfoPtr_kMinShaderLevel;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_get_isProperlyLoaded_Public_Static_get_Boolean_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_get_isNotSupportedString_Public_Static_get_String_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_OnStartUp_Private_Static_Void_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_LoadIfNeeded_Public_Static_Void_0;
	}
}
