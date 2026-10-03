using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppVLB
{
	// Token: 0x02000073 RID: 115
	public static class SRPHelper : Il2CppSystem.Object
	{
		// Token: 0x06000872 RID: 2162 RVA: 0x00096390 File Offset: 0x00094590
		// Note: this type is marked as 'beforefieldinit'.
		static SRPHelper()
		{
			Il2CppClassPointerStore<SRPHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "SRPHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr);
			SRPHelper.NativeFieldInfoPtr_m_IsRenderPipelineCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr, "m_IsRenderPipelineCached");
			SRPHelper.NativeFieldInfoPtr_m_RenderPipelineCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr, "m_RenderPipelineCached");
			SRPHelper.NativeMethodInfoPtr_get_renderPipelineScriptingDefineSymbolAsString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr, 100664366);
			SRPHelper.NativeMethodInfoPtr_get_projectRenderPipeline_Public_Static_get_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr, 100664367);
			SRPHelper.NativeMethodInfoPtr_ComputeRenderPipeline_Private_Static_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr, 100664368);
			SRPHelper.NativeMethodInfoPtr_IsUsingCustomRenderPipeline_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr, 100664369);
			SRPHelper.NativeMethodInfoPtr_RegisterOnBeginCameraRendering_Public_Static_Void_Action_2_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr, 100664370);
			SRPHelper.NativeMethodInfoPtr_UnregisterOnBeginCameraRendering_Public_Static_Void_Action_2_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SRPHelper>.NativeClassPtr, 100664371);
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00096460 File Offset: 0x00094660
		public unsafe static string renderPipelineScriptingDefineSymbolAsString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73768, XrefRangeEnd = 73770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPHelper.NativeMethodInfoPtr_get_renderPipelineScriptingDefineSymbolAsString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x0009648C File Offset: 0x0009468C
		public unsafe static RenderPipeline projectRenderPipeline
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 73792, RefRangeEnd = 73805, XrefRangeStart = 73770, XrefRangeEnd = 73792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPHelper.NativeMethodInfoPtr_get_projectRenderPipeline_Public_Static_get_RenderPipeline_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x000964BC File Offset: 0x000946BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73805, XrefRangeEnd = 73820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderPipeline ComputeRenderPipeline()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPHelper.NativeMethodInfoPtr_ComputeRenderPipeline_Private_Static_RenderPipeline_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x000964EC File Offset: 0x000946EC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 73828, RefRangeEnd = 73836, XrefRangeStart = 73820, XrefRangeEnd = 73828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUsingCustomRenderPipeline()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPHelper.NativeMethodInfoPtr_IsUsingCustomRenderPipeline_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0009651C File Offset: 0x0009471C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73842, RefRangeEnd = 73844, XrefRangeStart = 73836, XrefRangeEnd = 73842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPHelper.NativeMethodInfoPtr_RegisterOnBeginCameraRendering_Public_Static_Void_Action_2_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00096554 File Offset: 0x00094754
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73849, RefRangeEnd = 73851, XrefRangeStart = 73844, XrefRangeEnd = 73849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SRPHelper.NativeMethodInfoPtr_UnregisterOnBeginCameraRendering_Public_Static_Void_Action_2_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00006037 File Offset: 0x00004237
		public SRPHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x0009658C File Offset: 0x0009478C
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x00006040 File Offset: 0x00004240
		public unsafe static bool m_IsRenderPipelineCached
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(SRPHelper.NativeFieldInfoPtr_m_IsRenderPipelineCached, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SRPHelper.NativeFieldInfoPtr_m_IsRenderPipelineCached, (void*)(&value));
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x000965A8 File Offset: 0x000947A8
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x0000604E File Offset: 0x0000424E
		public unsafe static RenderPipeline m_RenderPipelineCached
		{
			get
			{
				RenderPipeline result;
				IL2CPP.il2cpp_field_static_get_value(SRPHelper.NativeFieldInfoPtr_m_RenderPipelineCached, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SRPHelper.NativeFieldInfoPtr_m_RenderPipelineCached, (void*)(&value));
			}
		}

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeFieldInfoPtr_m_IsRenderPipelineCached;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderPipelineCached;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_get_renderPipelineScriptingDefineSymbolAsString_Public_Static_get_String_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_get_projectRenderPipeline_Public_Static_get_RenderPipeline_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_ComputeRenderPipeline_Private_Static_RenderPipeline_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_IsUsingCustomRenderPipeline_Public_Static_Boolean_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOnBeginCameraRendering_Public_Static_Void_Action_2_ScriptableRenderContext_Camera_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterOnBeginCameraRendering_Public_Static_Void_Action_2_ScriptableRenderContext_Camera_0;
	}
}
