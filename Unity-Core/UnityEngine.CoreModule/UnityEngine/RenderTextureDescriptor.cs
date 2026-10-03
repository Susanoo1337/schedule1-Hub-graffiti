using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000E4 RID: 228
	[StructLayout(2)]
	public struct RenderTextureDescriptor
	{
		// Token: 0x06001273 RID: 4723 RVA: 0x00051F30 File Offset: 0x00050130
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTextureDescriptor()
		{
			Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderTextureDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr);
			RenderTextureDescriptor.NativeFieldInfoPtr__width_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<width>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__height_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<height>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__msaaSamples_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<msaaSamples>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__volumeDepth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<volumeDepth>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__mipCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<mipCount>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__graphicsFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "_graphicsFormat");
			RenderTextureDescriptor.NativeFieldInfoPtr__stencilFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<stencilFormat>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__depthStencilFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<depthStencilFormat>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__dimension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<dimension>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__shadowSamplingMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<shadowSamplingMode>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__vrUsage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<vrUsage>k__BackingField");
			RenderTextureDescriptor.NativeFieldInfoPtr__flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "_flags");
			RenderTextureDescriptor.NativeFieldInfoPtr__memoryless_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<memoryless>k__BackingField");
			RenderTextureDescriptor.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665086);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665087);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665088);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665089);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_msaaSamples_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665090);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_msaaSamples_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665091);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665092);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665093);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_mipCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665094);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_mipCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665095);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665096);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665097);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_stencilFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665098);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_depthStencilFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665099);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665100);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_colorFormat_Public_get_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665101);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_colorFormat_Public_set_Void_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665102);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665103);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_sRGB_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665104);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_depthBufferBits_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665105);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_depthBufferBits_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665106);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_dimension_Public_get_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665107);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_dimension_Public_set_Void_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665108);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_shadowSamplingMode_Public_get_ShadowSamplingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665109);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_shadowSamplingMode_Public_set_Void_ShadowSamplingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665110);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_vrUsage_Public_get_VRTextureUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665111);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665112);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_memoryless_Public_get_RenderTextureMemoryless_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665113);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_memoryless_Public_set_Void_RenderTextureMemoryless_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665114);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665115);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665116);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665117);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665118);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665119);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665120);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665121);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665122);
			RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665123);
			RenderTextureDescriptor.NativeMethodInfoPtr_SetOrClearRenderTextureCreationFlag_Private_Void_Boolean_RenderTextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665124);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665125);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665126);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_autoGenerateMips_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665127);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665128);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_enableRandomWrite_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665129);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665130);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_bindMS_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665131);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_bindMS_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665132);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_createdFromScript_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665133);
			RenderTextureDescriptor.NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665134);
			RenderTextureDescriptor.NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100665135);
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x0005244C File Offset: 0x0005064C
		// (set) Token: 0x06001275 RID: 4725 RVA: 0x0005247C File Offset: 0x0005067C
		public unsafe int width
		{
			[CallerCount(501)]
			[CachedScanResults(RefRangeStart = 40619, RefRangeEnd = 41120, XrefRangeStart = 40619, XrefRangeEnd = 41120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_width_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 54922, RefRangeEnd = 54944, XrefRangeStart = 54922, XrefRangeEnd = 54944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x000524B0 File Offset: 0x000506B0
		// (set) Token: 0x06001277 RID: 4727 RVA: 0x000524E0 File Offset: 0x000506E0
		public unsafe int height
		{
			[CallerCount(120)]
			[CachedScanResults(RefRangeStart = 54296, RefRangeEnd = 54416, XrefRangeStart = 54296, XrefRangeEnd = 54416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_height_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 54944, RefRangeEnd = 54959, XrefRangeStart = 54944, XrefRangeEnd = 54959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x00052514 File Offset: 0x00050714
		// (set) Token: 0x06001279 RID: 4729 RVA: 0x00052544 File Offset: 0x00050744
		public unsafe int msaaSamples
		{
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 29148, RefRangeEnd = 29176, XrefRangeStart = 29148, XrefRangeEnd = 29176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_msaaSamples_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29176, RefRangeEnd = 29187, XrefRangeStart = 29176, XrefRangeEnd = 29187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_msaaSamples_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x00052578 File Offset: 0x00050778
		// (set) Token: 0x0600127B RID: 4731 RVA: 0x000525A8 File Offset: 0x000507A8
		public unsafe int volumeDepth
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 29187, RefRangeEnd = 29190, XrefRangeStart = 29187, XrefRangeEnd = 29190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 29190, RefRangeEnd = 29194, XrefRangeStart = 29190, XrefRangeEnd = 29194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x000525DC File Offset: 0x000507DC
		// (set) Token: 0x0600127D RID: 4733 RVA: 0x0005260C File Offset: 0x0005080C
		public unsafe int mipCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29049, RefRangeEnd = 29051, XrefRangeStart = 29049, XrefRangeEnd = 29051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_mipCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 29051, RefRangeEnd = 29056, XrefRangeStart = 29051, XrefRangeEnd = 29056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_mipCount_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x00052640 File Offset: 0x00050840
		// (set) Token: 0x0600127F RID: 4735 RVA: 0x00052670 File Offset: 0x00050870
		public unsafe UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 1239503, RefRangeEnd = 1239526, XrefRangeStart = 1239503, XrefRangeEnd = 1239526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(59)]
			[CachedScanResults(RefRangeStart = 1241482, RefRangeEnd = 1241541, XrefRangeStart = 1241473, XrefRangeEnd = 1241482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x0000A519 File Offset: 0x00008719
		// (set) Token: 0x06001280 RID: 4736 RVA: 0x000526A4 File Offset: 0x000508A4
		public unsafe UnityEngine.Experimental.Rendering.GraphicsFormat stencilFormat
		{
			get
			{
				return this._stencilFormat_k__BackingField;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29109, RefRangeEnd = 29110, XrefRangeStart = 29109, XrefRangeEnd = 29110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_stencilFormat_Public_set_Void_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x000526D8 File Offset: 0x000508D8
		// (set) Token: 0x06001282 RID: 4738 RVA: 0x00052708 File Offset: 0x00050908
		public unsafe UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 36888, RefRangeEnd = 36892, XrefRangeStart = 36888, XrefRangeEnd = 36892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_depthStencilFormat_Public_get_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x0005273C File Offset: 0x0005093C
		// (set) Token: 0x06001284 RID: 4740 RVA: 0x0005276C File Offset: 0x0005096C
		public unsafe RenderTextureFormat colorFormat
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1241542, RefRangeEnd = 1241546, XrefRangeStart = 1241541, XrefRangeEnd = 1241542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_colorFormat_Public_get_RenderTextureFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 1241556, RefRangeEnd = 1241578, XrefRangeStart = 1241546, XrefRangeEnd = 1241556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_colorFormat_Public_set_Void_RenderTextureFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x000527A0 File Offset: 0x000509A0
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x000527D0 File Offset: 0x000509D0
		public unsafe bool sRGB
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1241582, RefRangeEnd = 1241583, XrefRangeStart = 1241578, XrefRangeEnd = 1241582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1241595, RefRangeEnd = 1241601, XrefRangeStart = 1241583, XrefRangeEnd = 1241595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_sRGB_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x00052804 File Offset: 0x00050A04
		// (set) Token: 0x06001288 RID: 4744 RVA: 0x00052834 File Offset: 0x00050A34
		public unsafe int depthBufferBits
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1241605, RefRangeEnd = 1241618, XrefRangeStart = 1241601, XrefRangeEnd = 1241605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_depthBufferBits_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(67)]
			[CachedScanResults(RefRangeStart = 1241619, RefRangeEnd = 1241686, XrefRangeStart = 1241618, XrefRangeEnd = 1241619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_depthBufferBits_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x00052868 File Offset: 0x00050A68
		// (set) Token: 0x0600128A RID: 4746 RVA: 0x00052898 File Offset: 0x00050A98
		public unsafe UnityEngine.Rendering.TextureDimension dimension
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 3894, RefRangeEnd = 3895, XrefRangeStart = 3894, XrefRangeEnd = 3895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_dimension_Public_get_TextureDimension_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29057, RefRangeEnd = 29058, XrefRangeStart = 29057, XrefRangeEnd = 29058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_dimension_Public_set_Void_TextureDimension_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x000528CC File Offset: 0x00050ACC
		// (set) Token: 0x0600128C RID: 4748 RVA: 0x000528FC File Offset: 0x00050AFC
		public unsafe UnityEngine.Rendering.ShadowSamplingMode shadowSamplingMode
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_shadowSamplingMode_Public_get_ShadowSamplingMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29041, RefRangeEnd = 29043, XrefRangeStart = 29041, XrefRangeEnd = 29043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_shadowSamplingMode_Public_set_Void_ShadowSamplingMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x00052930 File Offset: 0x00050B30
		// (set) Token: 0x0600128E RID: 4750 RVA: 0x00052960 File Offset: 0x00050B60
		public unsafe VRTextureUsage vrUsage
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 29072, RefRangeEnd = 29101, XrefRangeStart = 29072, XrefRangeEnd = 29101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_vrUsage_Public_get_VRTextureUsage_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29101, RefRangeEnd = 29102, XrefRangeStart = 29101, XrefRangeEnd = 29102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x00052994 File Offset: 0x00050B94
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x000529C4 File Offset: 0x00050BC4
		public unsafe RenderTextureMemoryless memoryless
		{
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 35494, RefRangeEnd = 35643, XrefRangeStart = 35494, XrefRangeEnd = 35643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_memoryless_Public_get_RenderTextureMemoryless_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63932, RefRangeEnd = 63933, XrefRangeStart = 63932, XrefRangeEnd = 63933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_memoryless_Public_set_Void_RenderTextureMemoryless_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x000529F8 File Offset: 0x00050BF8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1241687, RefRangeEnd = 1241697, XrefRangeStart = 1241686, XrefRangeEnd = 1241687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00052A38 File Offset: 0x00050C38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1241698, RefRangeEnd = 1241699, XrefRangeStart = 1241697, XrefRangeEnd = 1241698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00052A88 File Offset: 0x00050C88
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1241704, RefRangeEnd = 1241710, XrefRangeStart = 1241699, XrefRangeEnd = 1241704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00052AE4 File Offset: 0x00050CE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1241716, RefRangeEnd = 1241718, XrefRangeStart = 1241710, XrefRangeEnd = 1241716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00052B40 File Offset: 0x00050D40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1241719, RefRangeEnd = 1241720, XrefRangeStart = 1241718, XrefRangeEnd = 1241719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x00052BAC File Offset: 0x00050DAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1241727, RefRangeEnd = 1241729, XrefRangeStart = 1241720, XrefRangeEnd = 1241727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount, RenderTextureReadWrite readWrite)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_RenderTextureReadWrite_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00052C24 File Offset: 0x00050E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241729, XrefRangeEnd = 1241731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits, int mipCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00052C90 File Offset: 0x00050E90
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1241736, RefRangeEnd = 1241745, XrefRangeStart = 1241731, XrefRangeEnd = 1241736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStencilFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00052CEC File Offset: 0x00050EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241745, XrefRangeEnd = 1241746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStencilFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00052D58 File Offset: 0x00050F58
		[CallerCount(0)]
		public unsafe void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_SetOrClearRenderTextureCreationFlag_Private_Void_Boolean_RenderTextureCreationFlags_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x00052D98 File Offset: 0x00050F98
		// (set) Token: 0x0600129C RID: 4764 RVA: 0x00052DC8 File Offset: 0x00050FC8
		public unsafe bool useMipMap
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1241746, RefRangeEnd = 1241751, XrefRangeStart = 1241746, XrefRangeEnd = 1241746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 1241751, RefRangeEnd = 1241772, XrefRangeStart = 1241751, XrefRangeEnd = 1241751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x00052DFC File Offset: 0x00050FFC
		// (set) Token: 0x0600129E RID: 4766 RVA: 0x00052E2C File Offset: 0x0005102C
		public unsafe bool autoGenerateMips
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1241772, RefRangeEnd = 1241777, XrefRangeStart = 1241772, XrefRangeEnd = 1241772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_autoGenerateMips_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 1241777, RefRangeEnd = 1241795, XrefRangeStart = 1241777, XrefRangeEnd = 1241777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x00052E60 File Offset: 0x00051060
		// (set) Token: 0x060012A0 RID: 4768 RVA: 0x00052E90 File Offset: 0x00051090
		public unsafe bool enableRandomWrite
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1241795, RefRangeEnd = 1241800, XrefRangeStart = 1241795, XrefRangeEnd = 1241795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_enableRandomWrite_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1241800, RefRangeEnd = 1241809, XrefRangeStart = 1241800, XrefRangeEnd = 1241800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x00052EC4 File Offset: 0x000510C4
		// (set) Token: 0x060012A2 RID: 4770 RVA: 0x00052EF4 File Offset: 0x000510F4
		public unsafe bool bindMS
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1241809, RefRangeEnd = 1241817, XrefRangeStart = 1241809, XrefRangeEnd = 1241809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_bindMS_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1241817, RefRangeEnd = 1241829, XrefRangeStart = 1241817, XrefRangeEnd = 1241817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_bindMS_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x00052FD8 File Offset: 0x000511D8
		// (set) Token: 0x060012A3 RID: 4771 RVA: 0x00052F28 File Offset: 0x00051128
		public unsafe bool createdFromScript
		{
			get
			{
				return (this._flags & RenderTextureCreationFlags.CreatedFromScript) > (RenderTextureCreationFlags)0;
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_createdFromScript_Internal_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x00052F5C File Offset: 0x0005115C
		// (set) Token: 0x060012A5 RID: 4773 RVA: 0x00052F8C File Offset: 0x0005118C
		public unsafe bool useDynamicScale
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1241829, RefRangeEnd = 1241836, XrefRangeStart = 1241829, XrefRangeEnd = 1241829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1241836, RefRangeEnd = 1241842, XrefRangeStart = 1241836, XrefRangeEnd = 1241836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x0000A507 File Offset: 0x00008707
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, ref this));
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x00052FC0 File Offset: 0x000511C0
		public RenderTextureCreationFlags flags
		{
			get
			{
				return this._flags;
			}
		}

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeFieldInfoPtr__width_k__BackingField;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeFieldInfoPtr__height_k__BackingField;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeFieldInfoPtr__msaaSamples_k__BackingField;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeFieldInfoPtr__volumeDepth_k__BackingField;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeFieldInfoPtr__mipCount_k__BackingField;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeFieldInfoPtr__graphicsFormat;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeFieldInfoPtr__stencilFormat_k__BackingField;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeFieldInfoPtr__depthStencilFormat_k__BackingField;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeFieldInfoPtr__dimension_k__BackingField;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeFieldInfoPtr__shadowSamplingMode_k__BackingField;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeFieldInfoPtr__vrUsage_k__BackingField;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeFieldInfoPtr__flags;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeFieldInfoPtr__memoryless_k__BackingField;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_get_msaaSamples_Public_get_Int32_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_set_msaaSamples_Public_set_Void_Int32_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr_get_mipCount_Public_get_Int32_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_set_mipCount_Public_set_Void_Int32_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeMethodInfoPtr_set_stencilFormat_Public_set_Void_GraphicsFormat_0;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeMethodInfoPtr_get_depthStencilFormat_Public_get_GraphicsFormat_0;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr_get_colorFormat_Public_get_RenderTextureFormat_0;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeMethodInfoPtr_set_colorFormat_Public_set_Void_RenderTextureFormat_0;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeMethodInfoPtr_set_sRGB_Public_set_Void_Boolean_0;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeMethodInfoPtr_get_depthBufferBits_Public_get_Int32_0;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeMethodInfoPtr_set_depthBufferBits_Public_set_Void_Int32_0;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeMethodInfoPtr_get_dimension_Public_get_TextureDimension_0;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeMethodInfoPtr_set_dimension_Public_set_Void_TextureDimension_0;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeMethodInfoPtr_get_shadowSamplingMode_Public_get_ShadowSamplingMode_0;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowSamplingMode_Public_set_Void_ShadowSamplingMode_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr_get_vrUsage_Public_get_VRTextureUsage_0;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeMethodInfoPtr_get_memoryless_Public_get_RenderTextureMemoryless_0;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeMethodInfoPtr_set_memoryless_Public_set_Void_RenderTextureMemoryless_0;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_0;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_0;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_0;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_0;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_RenderTextureReadWrite_0;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_Int32_Int32_0;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeMethodInfoPtr_SetOrClearRenderTextureCreationFlag_Private_Void_Boolean_RenderTextureCreationFlags_0;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeMethodInfoPtr_get_autoGenerateMips_Public_get_Boolean_0;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeMethodInfoPtr_get_enableRandomWrite_Public_get_Boolean_0;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeMethodInfoPtr_get_bindMS_Public_get_Boolean_0;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeMethodInfoPtr_set_bindMS_Public_set_Void_Boolean_0;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeMethodInfoPtr_set_createdFromScript_Internal_set_Void_Boolean_0;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0;

		// Token: 0x04000F0D RID: 3853
		[FieldOffset(0)]
		public int _width_k__BackingField;

		// Token: 0x04000F0E RID: 3854
		[FieldOffset(4)]
		public int _height_k__BackingField;

		// Token: 0x04000F0F RID: 3855
		[FieldOffset(8)]
		public int _msaaSamples_k__BackingField;

		// Token: 0x04000F10 RID: 3856
		[FieldOffset(12)]
		public int _volumeDepth_k__BackingField;

		// Token: 0x04000F11 RID: 3857
		[FieldOffset(16)]
		public int _mipCount_k__BackingField;

		// Token: 0x04000F12 RID: 3858
		[FieldOffset(20)]
		public UnityEngine.Experimental.Rendering.GraphicsFormat _graphicsFormat;

		// Token: 0x04000F13 RID: 3859
		[FieldOffset(24)]
		public UnityEngine.Experimental.Rendering.GraphicsFormat _stencilFormat_k__BackingField;

		// Token: 0x04000F14 RID: 3860
		[FieldOffset(28)]
		public UnityEngine.Experimental.Rendering.GraphicsFormat _depthStencilFormat_k__BackingField;

		// Token: 0x04000F15 RID: 3861
		[FieldOffset(32)]
		public UnityEngine.Rendering.TextureDimension _dimension_k__BackingField;

		// Token: 0x04000F16 RID: 3862
		[FieldOffset(36)]
		public UnityEngine.Rendering.ShadowSamplingMode _shadowSamplingMode_k__BackingField;

		// Token: 0x04000F17 RID: 3863
		[FieldOffset(40)]
		public VRTextureUsage _vrUsage_k__BackingField;

		// Token: 0x04000F18 RID: 3864
		[FieldOffset(44)]
		public RenderTextureCreationFlags _flags;

		// Token: 0x04000F19 RID: 3865
		[FieldOffset(48)]
		public RenderTextureMemoryless _memoryless_k__BackingField;
	}
}
