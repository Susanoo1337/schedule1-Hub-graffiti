using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x02000086 RID: 134
	public class LiquidVolumeDepthPrePassRenderFeature : ScriptableRendererFeature
	{
		// Token: 0x06000B6B RID: 2923 RVA: 0x000A09D0 File Offset: 0x0009EBD0
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidVolumeDepthPrePassRenderFeature()
		{
			Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "LiquidVolumeDepthPrePassRenderFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr);
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvBackRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "lvBackRenderers");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvFrontRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "lvFrontRenderers");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "shader");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_installed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "installed");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "mat");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_backPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "backPass");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_frontPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "frontPass");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_interleavedRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "interleavedRendering");
			LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_renderPassEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "renderPassEvent");
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddLiquidToBackRenderers_Public_Static_Void_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100664724);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_RemoveLiquidFromBackRenderers_Public_Static_Void_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100664725);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddLiquidToFrontRenderers_Public_Static_Void_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100664726);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_RemoveLiquidFromFrontRenderers_Public_Static_Void_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100664727);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100664728);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100664729);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100664730);
			LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, 100664731);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x000A0B54 File Offset: 0x0009ED54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77205, XrefRangeEnd = 77222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddLiquidToBackRenderers(LiquidVolume lv)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddLiquidToBackRenderers_Public_Static_Void_LiquidVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x000A0B8C File Offset: 0x0009ED8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77239, RefRangeEnd = 77241, XrefRangeStart = 77222, XrefRangeEnd = 77239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveLiquidFromBackRenderers(LiquidVolume lv)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_RemoveLiquidFromBackRenderers_Public_Static_Void_LiquidVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x000A0BC4 File Offset: 0x0009EDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77241, XrefRangeEnd = 77258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddLiquidToFrontRenderers(LiquidVolume lv)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddLiquidToFrontRenderers_Public_Static_Void_LiquidVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x000A0BFC File Offset: 0x0009EDFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77275, RefRangeEnd = 77277, XrefRangeStart = 77258, XrefRangeEnd = 77275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveLiquidFromFrontRenderers(LiquidVolume lv)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_RemoveLiquidFromFrontRenderers_Public_Static_Void_LiquidVolume_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x000A0C34 File Offset: 0x0009EE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77277, XrefRangeEnd = 77294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x000A0C68 File Offset: 0x0009EE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77294, XrefRangeEnd = 77319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x000A0CA4 File Offset: 0x0009EEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77319, XrefRangeEnd = 77335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x000A0D0C File Offset: 0x0009EF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77335, XrefRangeEnd = 77336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidVolumeDepthPrePassRenderFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00007454 File Offset: 0x00005654
		public LiquidVolumeDepthPrePassRenderFeature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x000A0D48 File Offset: 0x0009EF48
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x0000745D File Offset: 0x0000565D
		public unsafe static List<LiquidVolume> lvBackRenderers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvBackRenderers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LiquidVolume>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvBackRenderers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x000A0D70 File Offset: 0x0009EF70
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x0000746F File Offset: 0x0000566F
		public unsafe static List<LiquidVolume> lvFrontRenderers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvFrontRenderers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LiquidVolume>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_lvFrontRenderers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x000A0D98 File Offset: 0x0009EF98
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x00007481 File Offset: 0x00005681
		public unsafe Shader shader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_shader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_shader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x000A0DC8 File Offset: 0x0009EFC8
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x000074A0 File Offset: 0x000056A0
		public unsafe static bool installed
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_installed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_installed, (void*)(&value));
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x000A0DE4 File Offset: 0x0009EFE4
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x000074AE File Offset: 0x000056AE
		public unsafe Material mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x000A0E14 File Offset: 0x0009F014
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x000074CD File Offset: 0x000056CD
		public unsafe LiquidVolumeDepthPrePassRenderFeature.DepthPass backPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_backPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolumeDepthPrePassRenderFeature.DepthPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_backPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x000A0E44 File Offset: 0x0009F044
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x000074EC File Offset: 0x000056EC
		public unsafe LiquidVolumeDepthPrePassRenderFeature.DepthPass frontPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_frontPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolumeDepthPrePassRenderFeature.DepthPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_frontPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x000A0E74 File Offset: 0x0009F074
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x0000750B File Offset: 0x0000570B
		public unsafe bool interleavedRendering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_interleavedRendering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_interleavedRendering)) = value;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x000A0E9C File Offset: 0x0009F09C
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x00007526 File Offset: 0x00005726
		public unsafe RenderPassEvent renderPassEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_renderPassEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.NativeFieldInfoPtr_renderPassEvent)) = value;
			}
		}

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeFieldInfoPtr_lvBackRenderers;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeFieldInfoPtr_lvFrontRenderers;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeFieldInfoPtr_shader;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeFieldInfoPtr_installed;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeFieldInfoPtr_mat;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeFieldInfoPtr_backPass;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeFieldInfoPtr_frontPass;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeFieldInfoPtr_interleavedRendering;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeFieldInfoPtr_renderPassEvent;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_AddLiquidToBackRenderers_Public_Static_Void_LiquidVolume_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLiquidFromBackRenderers_Public_Static_Void_LiquidVolume_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_AddLiquidToFrontRenderers_Public_Static_Void_LiquidVolume_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLiquidFromFrontRenderers_Public_Static_Void_LiquidVolume_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008A2 RID: 2210
		public static class ShaderParams : Il2CppSystem.Object
		{
			// Token: 0x0600D391 RID: 54161 RVA: 0x0034C210 File Offset: 0x0034A410
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderParams()
			{
				Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "ShaderParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr);
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBufferName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "RTBackBufferName");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "RTBackBuffer");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBufferName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "RTFrontBufferName");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "RTFrontBuffer");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_FlaskThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "FlaskThickness");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_ForcedInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "ForcedInvisible");
				LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_SKW_FP_RENDER_TEXTURE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.ShaderParams>.NativeClassPtr, "SKW_FP_RENDER_TEXTURE");
			}

			// Token: 0x0600D392 RID: 54162 RVA: 0x0006409D File Offset: 0x0006229D
			public ShaderParams(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004060 RID: 16480
			// (get) Token: 0x0600D393 RID: 54163 RVA: 0x0034C2C8 File Offset: 0x0034A4C8
			// (set) Token: 0x0600D394 RID: 54164 RVA: 0x000640A6 File Offset: 0x000622A6
			public unsafe static string RTBackBufferName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBufferName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBufferName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004061 RID: 16481
			// (get) Token: 0x0600D395 RID: 54165 RVA: 0x0034C2E8 File Offset: 0x0034A4E8
			// (set) Token: 0x0600D396 RID: 54166 RVA: 0x000640B8 File Offset: 0x000622B8
			public unsafe static int RTBackBuffer
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBuffer, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTBackBuffer, (void*)(&value));
				}
			}

			// Token: 0x17004062 RID: 16482
			// (get) Token: 0x0600D397 RID: 54167 RVA: 0x0034C304 File Offset: 0x0034A504
			// (set) Token: 0x0600D398 RID: 54168 RVA: 0x000640C6 File Offset: 0x000622C6
			public unsafe static string RTFrontBufferName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBufferName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBufferName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004063 RID: 16483
			// (get) Token: 0x0600D399 RID: 54169 RVA: 0x0034C324 File Offset: 0x0034A524
			// (set) Token: 0x0600D39A RID: 54170 RVA: 0x000640D8 File Offset: 0x000622D8
			public unsafe static int RTFrontBuffer
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBuffer, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_RTFrontBuffer, (void*)(&value));
				}
			}

			// Token: 0x17004064 RID: 16484
			// (get) Token: 0x0600D39B RID: 54171 RVA: 0x0034C340 File Offset: 0x0034A540
			// (set) Token: 0x0600D39C RID: 54172 RVA: 0x000640E6 File Offset: 0x000622E6
			public unsafe static int FlaskThickness
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_FlaskThickness, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_FlaskThickness, (void*)(&value));
				}
			}

			// Token: 0x17004065 RID: 16485
			// (get) Token: 0x0600D39D RID: 54173 RVA: 0x0034C35C File Offset: 0x0034A55C
			// (set) Token: 0x0600D39E RID: 54174 RVA: 0x000640F4 File Offset: 0x000622F4
			public unsafe static int ForcedInvisible
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_ForcedInvisible, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_ForcedInvisible, (void*)(&value));
				}
			}

			// Token: 0x17004066 RID: 16486
			// (get) Token: 0x0600D39F RID: 54175 RVA: 0x0034C378 File Offset: 0x0034A578
			// (set) Token: 0x0600D3A0 RID: 54176 RVA: 0x00064102 File Offset: 0x00062302
			public unsafe static string SKW_FP_RENDER_TEXTURE
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_SKW_FP_RENDER_TEXTURE, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.ShaderParams.NativeFieldInfoPtr_SKW_FP_RENDER_TEXTURE, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009011 RID: 36881
			private static readonly IntPtr NativeFieldInfoPtr_RTBackBufferName;

			// Token: 0x04009012 RID: 36882
			private static readonly IntPtr NativeFieldInfoPtr_RTBackBuffer;

			// Token: 0x04009013 RID: 36883
			private static readonly IntPtr NativeFieldInfoPtr_RTFrontBufferName;

			// Token: 0x04009014 RID: 36884
			private static readonly IntPtr NativeFieldInfoPtr_RTFrontBuffer;

			// Token: 0x04009015 RID: 36885
			private static readonly IntPtr NativeFieldInfoPtr_FlaskThickness;

			// Token: 0x04009016 RID: 36886
			private static readonly IntPtr NativeFieldInfoPtr_ForcedInvisible;

			// Token: 0x04009017 RID: 36887
			private static readonly IntPtr NativeFieldInfoPtr_SKW_FP_RENDER_TEXTURE;
		}

		// Token: 0x020008A3 RID: 2211
		[OriginalName("Assembly-CSharp.dll", "", "Pass")]
		public enum Pass
		{
			// Token: 0x04009019 RID: 36889
			BackBuffer,
			// Token: 0x0400901A RID: 36890
			FrontBuffer
		}

		// Token: 0x020008A4 RID: 2212
		public class DepthPass : ScriptableRenderPass
		{
			// Token: 0x0600D3A1 RID: 54177 RVA: 0x0034C398 File Offset: 0x0034A598
			// Note: this type is marked as 'beforefieldinit'.
			static DepthPass()
			{
				Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature>.NativeClassPtr, "DepthPass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_profilerTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "profilerTag");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "mat");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetNameId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "targetNameId");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "targetRT");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "passId");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_lvRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "lvRenderers");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "renderer");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_interleavedRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "interleavedRendering");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_currentCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "currentCameraPosition");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "passData");
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr__ctor_Public_Void_Material_Pass_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100664734);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Setup_Public_Void_LiquidVolumeDepthPrePassRenderFeature_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100664735);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_SortByDistanceToCamera_Private_Int32_LiquidVolume_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100664736);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100664737);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100664738);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_PassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100664739);
				LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_CleanUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, 100664740);
			}

			// Token: 0x0600D3A2 RID: 54178 RVA: 0x0034C518 File Offset: 0x0034A718
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 77106, RefRangeEnd = 77108, XrefRangeStart = 77064, XrefRangeEnd = 77106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DepthPass(Material mat, LiquidVolumeDepthPrePassRenderFeature.Pass pass, RenderPassEvent renderPassEvent) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pass;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderPassEvent;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr__ctor_Public_Void_Material_Pass_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3A3 RID: 54179 RVA: 0x0034C580 File Offset: 0x0034A780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77108, XrefRangeEnd = 77109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Setup(LiquidVolumeDepthPrePassRenderFeature feature, ScriptableRenderer renderer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(feature);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Setup_Public_Void_LiquidVolumeDepthPrePassRenderFeature_ScriptableRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3A4 RID: 54180 RVA: 0x0034C5D4 File Offset: 0x0034A7D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77109, XrefRangeEnd = 77131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int SortByDistanceToCamera(LiquidVolume lv1, LiquidVolume lv2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv1);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lv2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_SortByDistanceToCamera_Private_Int32_LiquidVolume_LiquidVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3A5 RID: 54181 RVA: 0x0034C634 File Offset: 0x0034A834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77131, XrefRangeEnd = 77139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraTextureDescriptor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3A6 RID: 54182 RVA: 0x0034C690 File Offset: 0x0034A890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77139, XrefRangeEnd = 77159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref context;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3A7 RID: 54183 RVA: 0x0034C6F4 File Offset: 0x0034A8F4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77200, RefRangeEnd = 77201, XrefRangeStart = 77159, XrefRangeEnd = 77200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ExecutePass(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData passData)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(passData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_ExecutePass_Private_Static_Void_PassData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3A8 RID: 54184 RVA: 0x0034C72C File Offset: 0x0034A92C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77201, XrefRangeEnd = 77205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CleanUp()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeMethodInfoPtr_CleanUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3A9 RID: 54185 RVA: 0x00064114 File Offset: 0x00062314
			public DepthPass(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004067 RID: 16487
			// (get) Token: 0x0600D3AA RID: 54186 RVA: 0x0034C760 File Offset: 0x0034A960
			// (set) Token: 0x0600D3AB RID: 54187 RVA: 0x0006411D File Offset: 0x0006231D
			public unsafe static string profilerTag
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_profilerTag, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_profilerTag, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004068 RID: 16488
			// (get) Token: 0x0600D3AC RID: 54188 RVA: 0x0034C780 File Offset: 0x0034A980
			// (set) Token: 0x0600D3AD RID: 54189 RVA: 0x0006412F File Offset: 0x0006232F
			public unsafe Material mat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_mat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004069 RID: 16489
			// (get) Token: 0x0600D3AE RID: 54190 RVA: 0x0034C7B0 File Offset: 0x0034A9B0
			// (set) Token: 0x0600D3AF RID: 54191 RVA: 0x0006414E File Offset: 0x0006234E
			public unsafe int targetNameId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetNameId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetNameId)) = value;
				}
			}

			// Token: 0x1700406A RID: 16490
			// (get) Token: 0x0600D3B0 RID: 54192 RVA: 0x0034C7D8 File Offset: 0x0034A9D8
			// (set) Token: 0x0600D3B1 RID: 54193 RVA: 0x00064169 File Offset: 0x00062369
			public unsafe RTHandle targetRT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetRT);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_targetRT), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700406B RID: 16491
			// (get) Token: 0x0600D3B2 RID: 54194 RVA: 0x0034C808 File Offset: 0x0034AA08
			// (set) Token: 0x0600D3B3 RID: 54195 RVA: 0x00064188 File Offset: 0x00062388
			public unsafe int passId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passId)) = value;
				}
			}

			// Token: 0x1700406C RID: 16492
			// (get) Token: 0x0600D3B4 RID: 54196 RVA: 0x0034C830 File Offset: 0x0034AA30
			// (set) Token: 0x0600D3B5 RID: 54197 RVA: 0x000641A3 File Offset: 0x000623A3
			public unsafe List<LiquidVolume> lvRenderers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_lvRenderers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LiquidVolume>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_lvRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700406D RID: 16493
			// (get) Token: 0x0600D3B6 RID: 54198 RVA: 0x0034C860 File Offset: 0x0034AA60
			// (set) Token: 0x0600D3B7 RID: 54199 RVA: 0x000641C2 File Offset: 0x000623C2
			public unsafe ScriptableRenderer renderer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_renderer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700406E RID: 16494
			// (get) Token: 0x0600D3B8 RID: 54200 RVA: 0x0034C890 File Offset: 0x0034AA90
			// (set) Token: 0x0600D3B9 RID: 54201 RVA: 0x000641E1 File Offset: 0x000623E1
			public unsafe bool interleavedRendering
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_interleavedRendering);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_interleavedRendering)) = value;
				}
			}

			// Token: 0x1700406F RID: 16495
			// (get) Token: 0x0600D3BA RID: 54202 RVA: 0x0034C8B8 File Offset: 0x0034AAB8
			// (set) Token: 0x0600D3BB RID: 54203 RVA: 0x000641FC File Offset: 0x000623FC
			public unsafe static Vector3 currentCameraPosition
			{
				get
				{
					Vector3 result;
					IL2CPP.il2cpp_field_static_get_value(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_currentCameraPosition, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_currentCameraPosition, (void*)(&value));
				}
			}

			// Token: 0x17004070 RID: 16496
			// (get) Token: 0x0600D3BC RID: 54204 RVA: 0x0034C8D4 File Offset: 0x0034AAD4
			// (set) Token: 0x0600D3BD RID: 54205 RVA: 0x0006420A File Offset: 0x0006240A
			public unsafe LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData passData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.NativeFieldInfoPtr_passData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400901B RID: 36891
			private static readonly IntPtr NativeFieldInfoPtr_profilerTag;

			// Token: 0x0400901C RID: 36892
			private static readonly IntPtr NativeFieldInfoPtr_mat;

			// Token: 0x0400901D RID: 36893
			private static readonly IntPtr NativeFieldInfoPtr_targetNameId;

			// Token: 0x0400901E RID: 36894
			private static readonly IntPtr NativeFieldInfoPtr_targetRT;

			// Token: 0x0400901F RID: 36895
			private static readonly IntPtr NativeFieldInfoPtr_passId;

			// Token: 0x04009020 RID: 36896
			private static readonly IntPtr NativeFieldInfoPtr_lvRenderers;

			// Token: 0x04009021 RID: 36897
			private static readonly IntPtr NativeFieldInfoPtr_renderer;

			// Token: 0x04009022 RID: 36898
			private static readonly IntPtr NativeFieldInfoPtr_interleavedRendering;

			// Token: 0x04009023 RID: 36899
			private static readonly IntPtr NativeFieldInfoPtr_currentCameraPosition;

			// Token: 0x04009024 RID: 36900
			private static readonly IntPtr NativeFieldInfoPtr_passData;

			// Token: 0x04009025 RID: 36901
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Material_Pass_RenderPassEvent_0;

			// Token: 0x04009026 RID: 36902
			private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_LiquidVolumeDepthPrePassRenderFeature_ScriptableRenderer_0;

			// Token: 0x04009027 RID: 36903
			private static readonly IntPtr NativeMethodInfoPtr_SortByDistanceToCamera_Private_Int32_LiquidVolume_LiquidVolume_0;

			// Token: 0x04009028 RID: 36904
			private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0;

			// Token: 0x04009029 RID: 36905
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

			// Token: 0x0400902A RID: 36906
			private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Private_Static_Void_PassData_0;

			// Token: 0x0400902B RID: 36907
			private static readonly IntPtr NativeMethodInfoPtr_CleanUp_Public_Void_0;

			// Token: 0x02000DAB RID: 3499
			public class PassData : Il2CppSystem.Object
			{
				// Token: 0x0600FD06 RID: 64774 RVA: 0x003C4878 File Offset: 0x003C2A78
				// Note: this type is marked as 'beforefieldinit'.
				static PassData()
				{
					Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass>.NativeClassPtr, "PassData");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr);
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "cam");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "cmd");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depthPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "depthPass");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "mat");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "source");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "depth");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cameraTargetDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, "cameraTargetDescriptor");
					LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr, 100664741);
				}

				// Token: 0x0600FD07 RID: 64775 RVA: 0x003C4944 File Offset: 0x003C2B44
				[CallerCount(2575)]
				[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe PassData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FD08 RID: 64776 RVA: 0x00077CB0 File Offset: 0x00075EB0
				public PassData(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004CE0 RID: 19680
				// (get) Token: 0x0600FD09 RID: 64777 RVA: 0x003C4980 File Offset: 0x003C2B80
				// (set) Token: 0x0600FD0A RID: 64778 RVA: 0x00077CB9 File Offset: 0x00075EB9
				public unsafe Camera cam
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cam);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004CE1 RID: 19681
				// (get) Token: 0x0600FD0B RID: 64779 RVA: 0x003C49B0 File Offset: 0x003C2BB0
				// (set) Token: 0x0600FD0C RID: 64780 RVA: 0x00077CD8 File Offset: 0x00075ED8
				public unsafe CommandBuffer cmd
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cmd);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cmd), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004CE2 RID: 19682
				// (get) Token: 0x0600FD0D RID: 64781 RVA: 0x003C49E0 File Offset: 0x003C2BE0
				// (set) Token: 0x0600FD0E RID: 64782 RVA: 0x00077CF7 File Offset: 0x00075EF7
				public unsafe LiquidVolumeDepthPrePassRenderFeature.DepthPass depthPass
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depthPass);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolumeDepthPrePassRenderFeature.DepthPass>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depthPass), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004CE3 RID: 19683
				// (get) Token: 0x0600FD0F RID: 64783 RVA: 0x003C4A10 File Offset: 0x003C2C10
				// (set) Token: 0x0600FD10 RID: 64784 RVA: 0x00077D16 File Offset: 0x00075F16
				public unsafe Material mat
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_mat);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004CE4 RID: 19684
				// (get) Token: 0x0600FD11 RID: 64785 RVA: 0x003C4A40 File Offset: 0x003C2C40
				// (set) Token: 0x0600FD12 RID: 64786 RVA: 0x00077D35 File Offset: 0x00075F35
				public unsafe RTHandle source
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_source);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004CE5 RID: 19685
				// (get) Token: 0x0600FD13 RID: 64787 RVA: 0x003C4A70 File Offset: 0x003C2C70
				// (set) Token: 0x0600FD14 RID: 64788 RVA: 0x00077D54 File Offset: 0x00075F54
				public unsafe RTHandle depth
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depth);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_depth), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004CE6 RID: 19686
				// (get) Token: 0x0600FD15 RID: 64789 RVA: 0x003C4AA0 File Offset: 0x003C2CA0
				// (set) Token: 0x0600FD16 RID: 64790 RVA: 0x00077D73 File Offset: 0x00075F73
				public unsafe RenderTextureDescriptor cameraTargetDescriptor
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cameraTargetDescriptor);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeDepthPrePassRenderFeature.DepthPass.PassData.NativeFieldInfoPtr_cameraTargetDescriptor)) = value;
					}
				}

				// Token: 0x0400AAA3 RID: 43683
				private static readonly IntPtr NativeFieldInfoPtr_cam;

				// Token: 0x0400AAA4 RID: 43684
				private static readonly IntPtr NativeFieldInfoPtr_cmd;

				// Token: 0x0400AAA5 RID: 43685
				private static readonly IntPtr NativeFieldInfoPtr_depthPass;

				// Token: 0x0400AAA6 RID: 43686
				private static readonly IntPtr NativeFieldInfoPtr_mat;

				// Token: 0x0400AAA7 RID: 43687
				private static readonly IntPtr NativeFieldInfoPtr_source;

				// Token: 0x0400AAA8 RID: 43688
				private static readonly IntPtr NativeFieldInfoPtr_depth;

				// Token: 0x0400AAA9 RID: 43689
				private static readonly IntPtr NativeFieldInfoPtr_cameraTargetDescriptor;

				// Token: 0x0400AAAA RID: 43690
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}
		}
	}
}
