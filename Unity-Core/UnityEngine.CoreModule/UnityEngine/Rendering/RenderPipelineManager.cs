using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000232 RID: 562
	public static class RenderPipelineManager : Object
	{
		// Token: 0x0600260D RID: 9741 RVA: 0x00097AF0 File Offset: 0x00095CF0
		// Note: this type is marked as 'beforefieldinit'.
		static RenderPipelineManager()
		{
			Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderPipelineManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr);
			RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "s_CurrentPipelineAsset");
			RenderPipelineManager.NativeFieldInfoPtr_s_Cameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "s_Cameras");
			RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "s_CurrentPipelineType");
			RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "s_CurrentPipeline");
			RenderPipelineManager.NativeFieldInfoPtr_beginFrameRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "beginFrameRendering");
			RenderPipelineManager.NativeFieldInfoPtr_endFrameRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "endFrameRendering");
			RenderPipelineManager.NativeFieldInfoPtr_beginContextRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "beginContextRendering");
			RenderPipelineManager.NativeFieldInfoPtr_endContextRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "endContextRendering");
			RenderPipelineManager.NativeFieldInfoPtr_beginCameraRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "beginCameraRendering");
			RenderPipelineManager.NativeFieldInfoPtr_endCameraRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "endCameraRendering");
			RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineTypeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "activeRenderPipelineTypeChanged");
			RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineAssetChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "activeRenderPipelineAssetChanged");
			RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "activeRenderPipelineCreated");
			RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "activeRenderPipelineDisposed");
			RenderPipelineManager.NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667386);
			RenderPipelineManager.NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667387);
			RenderPipelineManager.NativeMethodInfoPtr_add_beginCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667388);
			RenderPipelineManager.NativeMethodInfoPtr_remove_beginCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667389);
			RenderPipelineManager.NativeMethodInfoPtr_add_endCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667390);
			RenderPipelineManager.NativeMethodInfoPtr_remove_endCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667391);
			RenderPipelineManager.NativeMethodInfoPtr_BeginContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667392);
			RenderPipelineManager.NativeMethodInfoPtr_BeginCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667393);
			RenderPipelineManager.NativeMethodInfoPtr_EndContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667394);
			RenderPipelineManager.NativeMethodInfoPtr_EndCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667395);
			RenderPipelineManager.NativeMethodInfoPtr_OnActiveRenderPipelineTypeChanged_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667396);
			RenderPipelineManager.NativeMethodInfoPtr_OnActiveRenderPipelineAssetChanged_Internal_Static_Void_ScriptableObject_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667397);
			RenderPipelineManager.NativeMethodInfoPtr_HandleRenderPipelineChange_Internal_Static_Void_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667398);
			RenderPipelineManager.NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667399);
			RenderPipelineManager.NativeMethodInfoPtr_GetCurrentPipelineAssetType_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667400);
			RenderPipelineManager.NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667401);
			RenderPipelineManager.NativeMethodInfoPtr_PrepareRenderPipeline_Internal_Static_Void_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667402);
			RenderPipelineManager.NativeMethodInfoPtr_IsPipelineRequireCreation_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100667403);
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x00097DA0 File Offset: 0x00095FA0
		// (set) Token: 0x0600260F RID: 9743 RVA: 0x00097DD4 File Offset: 0x00095FD4
		public unsafe static RenderPipeline currentPipeline
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290811, XrefRangeEnd = 1290815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1290829, RefRangeEnd = 1290830, XrefRangeStart = 1290815, XrefRangeEnd = 1290829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x00097E0C File Offset: 0x0009600C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1290843, RefRangeEnd = 1290847, XrefRangeStart = 1290830, XrefRangeEnd = 1290843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_beginCameraRendering(Action<ScriptableRenderContext, Camera> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_add_beginCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x00097E44 File Offset: 0x00096044
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1290860, RefRangeEnd = 1290865, XrefRangeStart = 1290847, XrefRangeEnd = 1290860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_beginCameraRendering(Action<ScriptableRenderContext, Camera> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_remove_beginCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x00097E7C File Offset: 0x0009607C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290878, RefRangeEnd = 1290879, XrefRangeStart = 1290865, XrefRangeEnd = 1290878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_endCameraRendering(Action<ScriptableRenderContext, Camera> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_add_endCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x00097EB4 File Offset: 0x000960B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290892, RefRangeEnd = 1290893, XrefRangeStart = 1290879, XrefRangeEnd = 1290892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_endCameraRendering(Action<ScriptableRenderContext, Camera> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_remove_endCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x00097EEC File Offset: 0x000960EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290893, XrefRangeEnd = 1290903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_BeginContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x00097F30 File Offset: 0x00096130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290903, XrefRangeEnd = 1290907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_BeginCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x00097F74 File Offset: 0x00096174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290907, XrefRangeEnd = 1290917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_EndContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x00097FB8 File Offset: 0x000961B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290917, XrefRangeEnd = 1290921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_EndCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x00097FFC File Offset: 0x000961FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290921, XrefRangeEnd = 1290925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnActiveRenderPipelineTypeChanged()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_OnActiveRenderPipelineTypeChanged_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x00098024 File Offset: 0x00096224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290925, XrefRangeEnd = 1290932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_OnActiveRenderPipelineAssetChanged_Internal_Static_Void_ScriptableObject_ScriptableObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x0009806C File Offset: 0x0009626C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290932, XrefRangeEnd = 1290941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pipelineAsset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_HandleRenderPipelineChange_Internal_Static_Void_RenderPipelineAsset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x000980A4 File Offset: 0x000962A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1290986, RefRangeEnd = 1290990, XrefRangeStart = 1290941, XrefRangeEnd = 1290986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupRenderPipeline()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x000980CC File Offset: 0x000962CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290990, XrefRangeEnd = 1290994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCurrentPipelineAssetType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_GetCurrentPipelineAssetType_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x000980F8 File Offset: 0x000962F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290994, XrefRangeEnd = 1291042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, Object renderRequest)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loopPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderRequest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x00098150 File Offset: 0x00096350
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1291080, RefRangeEnd = 1291082, XrefRangeStart = 1291042, XrefRangeEnd = 1291080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pipelineAsset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_PrepareRenderPipeline_Internal_Static_Void_RenderPipelineAsset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x00098188 File Offset: 0x00096388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291082, XrefRangeEnd = 1291090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPipelineRequireCreation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_IsPipelineRequireCreation_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x00011574 File Offset: 0x0000F774
		public RenderPipelineManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06002621 RID: 9761 RVA: 0x000981B8 File Offset: 0x000963B8
		// (set) Token: 0x06002622 RID: 9762 RVA: 0x0001157D File Offset: 0x0000F77D
		public unsafe static RenderPipelineAsset s_CurrentPipelineAsset
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineAsset, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderPipelineAsset>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineAsset, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06002623 RID: 9763 RVA: 0x000981E0 File Offset: 0x000963E0
		// (set) Token: 0x06002624 RID: 9764 RVA: 0x0001158F File Offset: 0x0000F78F
		public unsafe static List<Camera> s_Cameras
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_s_Cameras, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Camera>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_s_Cameras, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06002625 RID: 9765 RVA: 0x00098208 File Offset: 0x00096408
		// (set) Token: 0x06002626 RID: 9766 RVA: 0x000115A1 File Offset: 0x0000F7A1
		public unsafe static string s_CurrentPipelineType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06002627 RID: 9767 RVA: 0x00098228 File Offset: 0x00096428
		// (set) Token: 0x06002628 RID: 9768 RVA: 0x000115B3 File Offset: 0x0000F7B3
		public unsafe static RenderPipeline s_CurrentPipeline
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipeline, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipeline, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06002629 RID: 9769 RVA: 0x00098250 File Offset: 0x00096450
		// (set) Token: 0x0600262A RID: 9770 RVA: 0x000115C5 File Offset: 0x0000F7C5
		public unsafe static Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> beginFrameRendering
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_beginFrameRendering, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_beginFrameRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x0600262B RID: 9771 RVA: 0x00098278 File Offset: 0x00096478
		// (set) Token: 0x0600262C RID: 9772 RVA: 0x000115D7 File Offset: 0x0000F7D7
		public unsafe static Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> endFrameRendering
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_endFrameRendering, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_endFrameRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x0600262D RID: 9773 RVA: 0x000982A0 File Offset: 0x000964A0
		// (set) Token: 0x0600262E RID: 9774 RVA: 0x000115E9 File Offset: 0x0000F7E9
		public unsafe static Action<ScriptableRenderContext, List<Camera>> beginContextRendering
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_beginContextRendering, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ScriptableRenderContext, List<Camera>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_beginContextRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x0600262F RID: 9775 RVA: 0x000982C8 File Offset: 0x000964C8
		// (set) Token: 0x06002630 RID: 9776 RVA: 0x000115FB File Offset: 0x0000F7FB
		public unsafe static Action<ScriptableRenderContext, List<Camera>> endContextRendering
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_endContextRendering, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ScriptableRenderContext, List<Camera>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_endContextRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06002631 RID: 9777 RVA: 0x000982F0 File Offset: 0x000964F0
		// (set) Token: 0x06002632 RID: 9778 RVA: 0x0001160D File Offset: 0x0000F80D
		public unsafe static Action<ScriptableRenderContext, Camera> beginCameraRendering
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_beginCameraRendering, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ScriptableRenderContext, Camera>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_beginCameraRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06002633 RID: 9779 RVA: 0x00098318 File Offset: 0x00096518
		// (set) Token: 0x06002634 RID: 9780 RVA: 0x0001161F File Offset: 0x0000F81F
		public unsafe static Action<ScriptableRenderContext, Camera> endCameraRendering
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_endCameraRendering, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ScriptableRenderContext, Camera>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_endCameraRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06002635 RID: 9781 RVA: 0x00098340 File Offset: 0x00096540
		// (set) Token: 0x06002636 RID: 9782 RVA: 0x00011631 File Offset: 0x0000F831
		public unsafe static Action activeRenderPipelineTypeChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineTypeChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineTypeChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06002637 RID: 9783 RVA: 0x00098368 File Offset: 0x00096568
		// (set) Token: 0x06002638 RID: 9784 RVA: 0x00011643 File Offset: 0x0000F843
		public unsafe static Action<RenderPipelineAsset, RenderPipelineAsset> activeRenderPipelineAssetChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineAssetChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RenderPipelineAsset, RenderPipelineAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineAssetChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06002639 RID: 9785 RVA: 0x00098390 File Offset: 0x00096590
		// (set) Token: 0x0600263A RID: 9786 RVA: 0x00011655 File Offset: 0x0000F855
		public unsafe static Action activeRenderPipelineCreated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineCreated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineCreated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x0600263B RID: 9787 RVA: 0x000983B8 File Offset: 0x000965B8
		// (set) Token: 0x0600263C RID: 9788 RVA: 0x00011667 File Offset: 0x0000F867
		public unsafe static Action activeRenderPipelineDisposed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineDisposed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineDisposed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x00011679 File Offset: 0x0000F879
		public static void add_beginFrameRendering(Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x00011686 File Offset: 0x0000F886
		public static void remove_beginFrameRendering(Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x00011693 File Offset: 0x0000F893
		public static void add_endFrameRendering(Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x000116A0 File Offset: 0x0000F8A0
		public static void remove_endFrameRendering(Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x000116AD File Offset: 0x0000F8AD
		public static void add_beginContextRendering(Action<ScriptableRenderContext, List<Camera>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x000116BA File Offset: 0x0000F8BA
		public static void remove_beginContextRendering(Action<ScriptableRenderContext, List<Camera>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x000116C7 File Offset: 0x0000F8C7
		public static void add_endContextRendering(Action<ScriptableRenderContext, List<Camera>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x000116D4 File Offset: 0x0000F8D4
		public static void remove_endContextRendering(Action<ScriptableRenderContext, List<Camera>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x000116E1 File Offset: 0x0000F8E1
		public static void add_activeRenderPipelineTypeChanged(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x000116EE File Offset: 0x0000F8EE
		public static void remove_activeRenderPipelineTypeChanged(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x000116FB File Offset: 0x0000F8FB
		public static void add_activeRenderPipelineAssetChanged(Action<RenderPipelineAsset, RenderPipelineAsset> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x00011708 File Offset: 0x0000F908
		public static void remove_activeRenderPipelineAssetChanged(Action<RenderPipelineAsset, RenderPipelineAsset> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x00011715 File Offset: 0x0000F915
		public static void add_activeRenderPipelineCreated(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x00011722 File Offset: 0x0000F922
		public static void remove_activeRenderPipelineCreated(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x0001172F File Offset: 0x0000F92F
		public static void add_activeRenderPipelineDisposed(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x0001173C File Offset: 0x0000F93C
		public static void remove_activeRenderPipelineDisposed(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x0600264D RID: 9805 RVA: 0x00011749 File Offset: 0x0000F949
		public static bool pipelineSwitchCompleted
		{
			get
			{
				return RenderPipelineManager.s_CurrentPipelineAsset == GraphicsSettings.currentRenderPipeline && !RenderPipelineManager.IsPipelineRequireCreation();
			}
		}

		// Token: 0x04002098 RID: 8344
		private static readonly IntPtr NativeFieldInfoPtr_s_CurrentPipelineAsset;

		// Token: 0x04002099 RID: 8345
		private static readonly IntPtr NativeFieldInfoPtr_s_Cameras;

		// Token: 0x0400209A RID: 8346
		private static readonly IntPtr NativeFieldInfoPtr_s_CurrentPipelineType;

		// Token: 0x0400209B RID: 8347
		private static readonly IntPtr NativeFieldInfoPtr_s_CurrentPipeline;

		// Token: 0x0400209C RID: 8348
		private static readonly IntPtr NativeFieldInfoPtr_beginFrameRendering;

		// Token: 0x0400209D RID: 8349
		private static readonly IntPtr NativeFieldInfoPtr_endFrameRendering;

		// Token: 0x0400209E RID: 8350
		private static readonly IntPtr NativeFieldInfoPtr_beginContextRendering;

		// Token: 0x0400209F RID: 8351
		private static readonly IntPtr NativeFieldInfoPtr_endContextRendering;

		// Token: 0x040020A0 RID: 8352
		private static readonly IntPtr NativeFieldInfoPtr_beginCameraRendering;

		// Token: 0x040020A1 RID: 8353
		private static readonly IntPtr NativeFieldInfoPtr_endCameraRendering;

		// Token: 0x040020A2 RID: 8354
		private static readonly IntPtr NativeFieldInfoPtr_activeRenderPipelineTypeChanged;

		// Token: 0x040020A3 RID: 8355
		private static readonly IntPtr NativeFieldInfoPtr_activeRenderPipelineAssetChanged;

		// Token: 0x040020A4 RID: 8356
		private static readonly IntPtr NativeFieldInfoPtr_activeRenderPipelineCreated;

		// Token: 0x040020A5 RID: 8357
		private static readonly IntPtr NativeFieldInfoPtr_activeRenderPipelineDisposed;

		// Token: 0x040020A6 RID: 8358
		private static readonly IntPtr NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0;

		// Token: 0x040020A7 RID: 8359
		private static readonly IntPtr NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0;

		// Token: 0x040020A8 RID: 8360
		private static readonly IntPtr NativeMethodInfoPtr_add_beginCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0;

		// Token: 0x040020A9 RID: 8361
		private static readonly IntPtr NativeMethodInfoPtr_remove_beginCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0;

		// Token: 0x040020AA RID: 8362
		private static readonly IntPtr NativeMethodInfoPtr_add_endCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0;

		// Token: 0x040020AB RID: 8363
		private static readonly IntPtr NativeMethodInfoPtr_remove_endCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0;

		// Token: 0x040020AC RID: 8364
		private static readonly IntPtr NativeMethodInfoPtr_BeginContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0;

		// Token: 0x040020AD RID: 8365
		private static readonly IntPtr NativeMethodInfoPtr_BeginCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x040020AE RID: 8366
		private static readonly IntPtr NativeMethodInfoPtr_EndContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0;

		// Token: 0x040020AF RID: 8367
		private static readonly IntPtr NativeMethodInfoPtr_EndCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x040020B0 RID: 8368
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveRenderPipelineTypeChanged_Internal_Static_Void_0;

		// Token: 0x040020B1 RID: 8369
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveRenderPipelineAssetChanged_Internal_Static_Void_ScriptableObject_ScriptableObject_0;

		// Token: 0x040020B2 RID: 8370
		private static readonly IntPtr NativeMethodInfoPtr_HandleRenderPipelineChange_Internal_Static_Void_RenderPipelineAsset_0;

		// Token: 0x040020B3 RID: 8371
		private static readonly IntPtr NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0;

		// Token: 0x040020B4 RID: 8372
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentPipelineAssetType_Private_Static_String_0;

		// Token: 0x040020B5 RID: 8373
		private static readonly IntPtr NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_Object_0;

		// Token: 0x040020B6 RID: 8374
		private static readonly IntPtr NativeMethodInfoPtr_PrepareRenderPipeline_Internal_Static_Void_RenderPipelineAsset_0;

		// Token: 0x040020B7 RID: 8375
		private static readonly IntPtr NativeMethodInfoPtr_IsPipelineRequireCreation_Private_Static_Boolean_0;

		// Token: 0x040020B8 RID: 8376
		public const string k_BuiltinPipelineName = "Built-in Pipeline";
	}
}
