using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000E2 RID: 226
	public class RenderTexture : Texture
	{
		// Token: 0x060011D0 RID: 4560 RVA: 0x0004F9D4 File Offset: 0x0004DBD4
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTexture()
		{
			Il2CppClassPointerStore<RenderTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr);
			RenderTexture.NativeMethodInfoPtr_get_width_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665003);
			RenderTexture.NativeMethodInfoPtr_set_width_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665004);
			RenderTexture.NativeMethodInfoPtr_get_height_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665005);
			RenderTexture.NativeMethodInfoPtr_set_height_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665006);
			RenderTexture.NativeMethodInfoPtr_get_dimension_Public_Virtual_get_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665007);
			RenderTexture.NativeMethodInfoPtr_set_dimension_Public_Virtual_set_Void_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665008);
			RenderTexture.NativeMethodInfoPtr_GetColorFormat_Private_GraphicsFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665009);
			RenderTexture.NativeMethodInfoPtr_SetColorFormat_Private_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665010);
			RenderTexture.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665011);
			RenderTexture.NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665012);
			RenderTexture.NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665013);
			RenderTexture.NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665014);
			RenderTexture.NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665015);
			RenderTexture.NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665016);
			RenderTexture.NativeMethodInfoPtr_set_memorylessMode_Public_set_Void_RenderTextureMemoryless_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665017);
			RenderTexture.NativeMethodInfoPtr_get_format_Public_get_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665018);
			RenderTexture.NativeMethodInfoPtr_set_stencilFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665019);
			RenderTexture.NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665020);
			RenderTexture.NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665021);
			RenderTexture.NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665022);
			RenderTexture.NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665023);
			RenderTexture.NativeMethodInfoPtr_get_antiAliasing_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665024);
			RenderTexture.NativeMethodInfoPtr_set_antiAliasing_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665025);
			RenderTexture.NativeMethodInfoPtr_set_bindTextureMS_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665026);
			RenderTexture.NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665027);
			RenderTexture.NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665028);
			RenderTexture.NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665029);
			RenderTexture.NativeMethodInfoPtr_GetActive_Private_Static_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665030);
			RenderTexture.NativeMethodInfoPtr_SetActive_Private_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665031);
			RenderTexture.NativeMethodInfoPtr_get_active_Public_Static_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665032);
			RenderTexture.NativeMethodInfoPtr_set_active_Public_Static_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665033);
			RenderTexture.NativeMethodInfoPtr_GetColorBuffer_Private_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665034);
			RenderTexture.NativeMethodInfoPtr_GetDepthBuffer_Private_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665035);
			RenderTexture.NativeMethodInfoPtr_SetMipMapCount_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665036);
			RenderTexture.NativeMethodInfoPtr_get_colorBuffer_Public_get_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665037);
			RenderTexture.NativeMethodInfoPtr_get_depthBuffer_Public_get_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665038);
			RenderTexture.NativeMethodInfoPtr_DiscardContents_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665039);
			RenderTexture.NativeMethodInfoPtr_DiscardContents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665040);
			RenderTexture.NativeMethodInfoPtr_Create_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665041);
			RenderTexture.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665042);
			RenderTexture.NativeMethodInfoPtr_SetSRGBReadWrite_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665043);
			RenderTexture.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665044);
			RenderTexture.NativeMethodInfoPtr_SetRenderTextureDescriptor_Private_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665045);
			RenderTexture.NativeMethodInfoPtr_GetDescriptor_Private_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665046);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Internal_Private_Static_RenderTexture_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665047);
			RenderTexture.NativeMethodInfoPtr_ReleaseTemporary_Public_Static_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665048);
			RenderTexture.NativeMethodInfoPtr_get_depth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665049);
			RenderTexture.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665050);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665051);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665052);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665053);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665054);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665055);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665056);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665057);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665058);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665059);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665060);
			RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665061);
			RenderTexture.NativeMethodInfoPtr_Initialize_Private_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665062);
			RenderTexture.NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665063);
			RenderTexture.NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665064);
			RenderTexture.NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_DefaultFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665065);
			RenderTexture.NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665066);
			RenderTexture.NativeMethodInfoPtr_get_descriptor_Public_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665067);
			RenderTexture.NativeMethodInfoPtr_ValidateRenderTextureDesc_Private_Static_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665068);
			RenderTexture.NativeMethodInfoPtr_GetDefaultColorFormat_Internal_Static_GraphicsFormat_DefaultFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665069);
			RenderTexture.NativeMethodInfoPtr_GetDefaultDepthStencilFormat_Internal_Static_GraphicsFormat_DefaultFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665070);
			RenderTexture.NativeMethodInfoPtr_GetCompatibleFormat_Internal_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665071);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665072);
			RenderTexture.NativeMethodInfoPtr_GetTemporaryImpl_Private_Static_RenderTexture_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665073);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665074);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665075);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665076);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665077);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665078);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665079);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665080);
			RenderTexture.NativeMethodInfoPtr_GetColorBuffer_Injected_Private_Void_byref_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665081);
			RenderTexture.NativeMethodInfoPtr_GetDepthBuffer_Injected_Private_Void_byref_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665082);
			RenderTexture.NativeMethodInfoPtr_SetRenderTextureDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665083);
			RenderTexture.NativeMethodInfoPtr_GetDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665084);
			RenderTexture.NativeMethodInfoPtr_GetTemporary_Internal_Injected_Private_Static_RenderTexture_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr, 100665085);
			RenderTexture.get_vrUsageDelegateField = IL2CPP.ResolveICall<RenderTexture.get_vrUsageDelegate>("UnityEngine.RenderTexture::get_vrUsage");
			RenderTexture.get_memorylessModeDelegateField = IL2CPP.ResolveICall<RenderTexture.get_memorylessModeDelegate>("UnityEngine.RenderTexture::get_memorylessMode");
			RenderTexture.get_stencilFormatDelegateField = IL2CPP.ResolveICall<RenderTexture.get_stencilFormatDelegate>("UnityEngine.RenderTexture::get_stencilFormat");
			RenderTexture.get_depthStencilFormatDelegateField = IL2CPP.ResolveICall<RenderTexture.get_depthStencilFormatDelegate>("UnityEngine.RenderTexture::get_depthStencilFormat");
			RenderTexture.get_autoGenerateMipsDelegateField = IL2CPP.ResolveICall<RenderTexture.get_autoGenerateMipsDelegate>("UnityEngine.RenderTexture::get_autoGenerateMips");
			RenderTexture.get_bindTextureMSDelegateField = IL2CPP.ResolveICall<RenderTexture.get_bindTextureMSDelegate>("UnityEngine.RenderTexture::get_bindTextureMS");
			RenderTexture.get_enableRandomWriteDelegateField = IL2CPP.ResolveICall<RenderTexture.get_enableRandomWriteDelegate>("UnityEngine.RenderTexture::get_enableRandomWrite");
			RenderTexture.GetIsPowerOfTwoDelegateField = IL2CPP.ResolveICall<RenderTexture.GetIsPowerOfTwoDelegate>("UnityEngine.RenderTexture::GetIsPowerOfTwo");
			RenderTexture.SetShadowSamplingModeDelegateField = IL2CPP.ResolveICall<RenderTexture.SetShadowSamplingModeDelegate>("UnityEngine.RenderTexture::SetShadowSamplingMode");
			RenderTexture.GetNativeDepthBufferPtrDelegateField = IL2CPP.ResolveICall<RenderTexture.GetNativeDepthBufferPtrDelegate>("UnityEngine.RenderTexture::GetNativeDepthBufferPtr");
			RenderTexture.MarkRestoreExpectedDelegateField = IL2CPP.ResolveICall<RenderTexture.MarkRestoreExpectedDelegate>("UnityEngine.RenderTexture::MarkRestoreExpected");
			RenderTexture.ResolveAADelegateField = IL2CPP.ResolveICall<RenderTexture.ResolveAADelegate>("UnityEngine.RenderTexture::ResolveAA");
			RenderTexture.ResolveAAToDelegateField = IL2CPP.ResolveICall<RenderTexture.ResolveAAToDelegate>("UnityEngine.RenderTexture::ResolveAATo");
			RenderTexture.SetGlobalShaderPropertyDelegateField = IL2CPP.ResolveICall<RenderTexture.SetGlobalShaderPropertyDelegate>("UnityEngine.RenderTexture::SetGlobalShaderProperty");
			RenderTexture.IsCreatedDelegateField = IL2CPP.ResolveICall<RenderTexture.IsCreatedDelegate>("UnityEngine.RenderTexture::IsCreated");
			RenderTexture.GenerateMipsDelegateField = IL2CPP.ResolveICall<RenderTexture.GenerateMipsDelegate>("UnityEngine.RenderTexture::GenerateMips");
			RenderTexture.ConvertToEquirectDelegateField = IL2CPP.ResolveICall<RenderTexture.ConvertToEquirectDelegate>("UnityEngine.RenderTexture::ConvertToEquirect");
			RenderTexture.SupportsStencilDelegateField = IL2CPP.ResolveICall<RenderTexture.SupportsStencilDelegate>("UnityEngine.RenderTexture::SupportsStencil");
			RenderTexture.set_depthDelegateField = IL2CPP.ResolveICall<RenderTexture.set_depthDelegate>("UnityEngine.RenderTexture::set_depth");
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x000501A0 File Offset: 0x0004E3A0
		// (set) Token: 0x060011D2 RID: 4562 RVA: 0x000501E8 File Offset: 0x0004E3E8
		public unsafe override int width
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240789, XrefRangeEnd = 1240791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_get_width_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240791, XrefRangeEnd = 1240793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_set_width_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x00050234 File Offset: 0x0004E434
		// (set) Token: 0x060011D4 RID: 4564 RVA: 0x0005027C File Offset: 0x0004E47C
		public unsafe override int height
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240793, XrefRangeEnd = 1240795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_get_height_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240795, XrefRangeEnd = 1240797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_set_height_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x000502C8 File Offset: 0x0004E4C8
		// (set) Token: 0x060011D6 RID: 4566 RVA: 0x00050310 File Offset: 0x0004E510
		public unsafe override UnityEngine.Rendering.TextureDimension dimension
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240797, XrefRangeEnd = 1240799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_get_dimension_Public_Virtual_get_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240799, XrefRangeEnd = 1240801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderTexture.NativeMethodInfoPtr_set_dimension_Public_Virtual_set_Void_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0005035C File Offset: 0x0004E55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240801, XrefRangeEnd = 1240803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Experimental.Rendering.GraphicsFormat GetColorFormat(bool suppressWarnings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref suppressWarnings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetColorFormat_Private_GraphicsFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x000503A8 File Offset: 0x0004E5A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1240805, RefRangeEnd = 1240806, XrefRangeStart = 1240803, XrefRangeEnd = 1240805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColorFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetColorFormat_Private_Void_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x000503E8 File Offset: 0x0004E5E8
		// (set) Token: 0x060011DA RID: 4570 RVA: 0x00050424 File Offset: 0x0004E624
		public new unsafe UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1240808, RefRangeEnd = 1240824, XrefRangeStart = 1240806, XrefRangeEnd = 1240808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1240805, RefRangeEnd = 1240806, XrefRangeStart = 1240805, XrefRangeEnd = 1240806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x00050464 File Offset: 0x0004E664
		// (set) Token: 0x060011DC RID: 4572 RVA: 0x000504A0 File Offset: 0x0004E6A0
		public unsafe bool useMipMap
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1240826, RefRangeEnd = 1240829, XrefRangeStart = 1240824, XrefRangeEnd = 1240826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1240831, RefRangeEnd = 1240838, XrefRangeStart = 1240829, XrefRangeEnd = 1240831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x000504E0 File Offset: 0x0004E6E0
		public unsafe bool sRGB
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1240840, RefRangeEnd = 1240841, XrefRangeStart = 1240838, XrefRangeEnd = 1240840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x0000A0C7 File Offset: 0x000082C7
		// (set) Token: 0x060011DE RID: 4574 RVA: 0x0005051C File Offset: 0x0004E71C
		public unsafe VRTextureUsage vrUsage
		{
			get
			{
				return RenderTexture.get_vrUsageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1240843, RefRangeEnd = 1240847, XrefRangeStart = 1240841, XrefRangeEnd = 1240843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x0000A0D9 File Offset: 0x000082D9
		// (set) Token: 0x060011DF RID: 4575 RVA: 0x0005055C File Offset: 0x0004E75C
		public unsafe RenderTextureMemoryless memorylessMode
		{
			get
			{
				return RenderTexture.get_memorylessModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1240849, RefRangeEnd = 1240853, XrefRangeStart = 1240847, XrefRangeEnd = 1240849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_memorylessMode_Public_set_Void_RenderTextureMemoryless_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x0005059C File Offset: 0x0004E79C
		// (set) Token: 0x06001227 RID: 4647 RVA: 0x0000A0EB File Offset: 0x000082EB
		public unsafe RenderTextureFormat format
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1240858, RefRangeEnd = 1240864, XrefRangeStart = 1240853, XrefRangeEnd = 1240858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_format_Public_get_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.graphicsFormat = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(value, this.sRGB);
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x0000A101 File Offset: 0x00008301
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x000505D8 File Offset: 0x0004E7D8
		public unsafe UnityEngine.Experimental.Rendering.GraphicsFormat stencilFormat
		{
			get
			{
				return RenderTexture.get_stencilFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1240866, RefRangeEnd = 1240868, XrefRangeStart = 1240864, XrefRangeEnd = 1240866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_stencilFormat_Public_set_Void_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x0000A113 File Offset: 0x00008313
		// (set) Token: 0x060011E2 RID: 4578 RVA: 0x00050618 File Offset: 0x0004E818
		public unsafe UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat
		{
			get
			{
				return RenderTexture.get_depthStencilFormatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240868, XrefRangeEnd = 1240870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x0000A125 File Offset: 0x00008325
		// (set) Token: 0x060011E3 RID: 4579 RVA: 0x00050658 File Offset: 0x0004E858
		public unsafe bool autoGenerateMips
		{
			get
			{
				return RenderTexture.get_autoGenerateMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1240872, RefRangeEnd = 1240879, XrefRangeStart = 1240870, XrefRangeEnd = 1240872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x00050698 File Offset: 0x0004E898
		// (set) Token: 0x060011E5 RID: 4581 RVA: 0x000506D4 File Offset: 0x0004E8D4
		public unsafe int volumeDepth
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1240881, RefRangeEnd = 1240884, XrefRangeStart = 1240879, XrefRangeEnd = 1240881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1240886, RefRangeEnd = 1240894, XrefRangeStart = 1240884, XrefRangeEnd = 1240886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x00050714 File Offset: 0x0004E914
		// (set) Token: 0x060011E7 RID: 4583 RVA: 0x00050750 File Offset: 0x0004E950
		public unsafe int antiAliasing
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1240896, RefRangeEnd = 1240900, XrefRangeStart = 1240894, XrefRangeEnd = 1240896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_antiAliasing_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1240902, RefRangeEnd = 1240907, XrefRangeStart = 1240900, XrefRangeEnd = 1240902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_antiAliasing_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x0000A137 File Offset: 0x00008337
		// (set) Token: 0x060011E8 RID: 4584 RVA: 0x00050790 File Offset: 0x0004E990
		public unsafe bool bindTextureMS
		{
			get
			{
				return RenderTexture.get_bindTextureMSDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1240909, RefRangeEnd = 1240913, XrefRangeStart = 1240907, XrefRangeEnd = 1240909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_bindTextureMS_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x0000A149 File Offset: 0x00008349
		// (set) Token: 0x060011E9 RID: 4585 RVA: 0x000507D0 File Offset: 0x0004E9D0
		public unsafe bool enableRandomWrite
		{
			get
			{
				return RenderTexture.get_enableRandomWriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 1240915, RefRangeEnd = 1240929, XrefRangeStart = 1240913, XrefRangeEnd = 1240915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x00050810 File Offset: 0x0004EA10
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x0005084C File Offset: 0x0004EA4C
		public unsafe bool useDynamicScale
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1240931, RefRangeEnd = 1240933, XrefRangeStart = 1240929, XrefRangeEnd = 1240931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1240935, RefRangeEnd = 1240941, XrefRangeStart = 1240933, XrefRangeEnd = 1240935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x0005088C File Offset: 0x0004EA8C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1240943, RefRangeEnd = 1240953, XrefRangeStart = 1240941, XrefRangeEnd = 1240943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetActive()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetActive_Private_Static_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x000508C0 File Offset: 0x0004EAC0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1240955, RefRangeEnd = 1240976, XrefRangeStart = 1240953, XrefRangeEnd = 1240955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetActive(RenderTexture rt)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetActive_Private_Static_Void_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x000508F8 File Offset: 0x0004EAF8
		// (set) Token: 0x060011EF RID: 4591 RVA: 0x0005092C File Offset: 0x0004EB2C
		public unsafe static RenderTexture active
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1240943, RefRangeEnd = 1240953, XrefRangeStart = 1240943, XrefRangeEnd = 1240953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_active_Public_Static_get_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 1240955, RefRangeEnd = 1240976, XrefRangeStart = 1240955, XrefRangeEnd = 1240976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_set_active_Public_Static_set_Void_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00050964 File Offset: 0x0004EB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240976, XrefRangeEnd = 1240978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderBuffer GetColorBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetColorBuffer_Private_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x000509A0 File Offset: 0x0004EBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240978, XrefRangeEnd = 1240980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderBuffer GetDepthBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDepthBuffer_Private_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x000509DC File Offset: 0x0004EBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240980, XrefRangeEnd = 1240982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMipMapCount(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetMipMapCount_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x00050A1C File Offset: 0x0004EC1C
		public unsafe RenderBuffer colorBuffer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240982, XrefRangeEnd = 1240984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_colorBuffer_Public_get_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x00050A58 File Offset: 0x0004EC58
		public unsafe RenderBuffer depthBuffer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1240986, RefRangeEnd = 1240987, XrefRangeStart = 1240984, XrefRangeEnd = 1240986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_depthBuffer_Public_get_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00050A94 File Offset: 0x0004EC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240987, XrefRangeEnd = 1240989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DiscardContents(bool discardColor, bool discardDepth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref discardColor;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref discardDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_DiscardContents_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00050AE0 File Offset: 0x0004ECE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240991, RefRangeEnd = 1240993, XrefRangeStart = 1240989, XrefRangeEnd = 1240991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DiscardContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_DiscardContents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00050B14 File Offset: 0x0004ED14
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 1240995, RefRangeEnd = 1241026, XrefRangeStart = 1240993, XrefRangeEnd = 1240995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_Create_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00050B50 File Offset: 0x0004ED50
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1241028, RefRangeEnd = 1241055, XrefRangeStart = 1241026, XrefRangeEnd = 1241028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00050B84 File Offset: 0x0004ED84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241055, XrefRangeEnd = 1241057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSRGBReadWrite(bool srgb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref srgb;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetSRGBReadWrite_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00050BC4 File Offset: 0x0004EDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241057, XrefRangeEnd = 1241059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(RenderTexture rt)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00050BFC File Offset: 0x0004EDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241059, XrefRangeEnd = 1241061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTextureDescriptor(RenderTextureDescriptor desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref desc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetRenderTextureDescriptor_Private_Void_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00050C3C File Offset: 0x0004EE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241061, XrefRangeEnd = 1241063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor GetDescriptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDescriptor_Private_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00050C78 File Offset: 0x0004EE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241063, XrefRangeEnd = 1241065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref desc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Internal_Private_Static_RenderTexture_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00050CB8 File Offset: 0x0004EEB8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1241067, RefRangeEnd = 1241075, XrefRangeStart = 1241065, XrefRangeEnd = 1241067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseTemporary(RenderTexture temp)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(temp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_ReleaseTemporary_Public_Static_Void_RenderTexture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x00050CF0 File Offset: 0x0004EEF0
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x0000A24D File Offset: 0x0000844D
		public unsafe int depth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1241077, RefRangeEnd = 1241078, XrefRangeStart = 1241075, XrefRangeEnd = 1241077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_depth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				RenderTexture.set_depthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00050D2C File Offset: 0x0004EF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241078, XrefRangeEnd = 1241085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00050D68 File Offset: 0x0004EF68
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1241097, RefRangeEnd = 1241107, XrefRangeStart = 1241085, XrefRangeEnd = 1241097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(RenderTextureDescriptor desc) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref desc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00050DB0 File Offset: 0x0004EFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241107, XrefRangeEnd = 1241127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(RenderTexture textureToCopy) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(textureToCopy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00050DFC File Offset: 0x0004EFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241127, XrefRangeEnd = 1241140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00050E70 File Offset: 0x0004F070
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1241145, RefRangeEnd = 1241155, XrefRangeStart = 1241140, XrefRangeEnd = 1241145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00050EE4 File Offset: 0x0004F0E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1241182, RefRangeEnd = 1241183, XrefRangeStart = 1241155, XrefRangeEnd = 1241182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00050F64 File Offset: 0x0004F164
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1241209, RefRangeEnd = 1241211, XrefRangeStart = 1241183, XrefRangeEnd = 1241209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStencilFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00050FE4 File Offset: 0x0004F1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241211, XrefRangeEnd = 1241216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStencilFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00051058 File Offset: 0x0004F258
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1241225, RefRangeEnd = 1241228, XrefRangeStart = 1241216, XrefRangeEnd = 1241225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x000510D8 File Offset: 0x0004F2D8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1241240, RefRangeEnd = 1241253, XrefRangeStart = 1241228, XrefRangeEnd = 1241240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, RenderTextureFormat format) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0005114C File Offset: 0x0004F34C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1241265, RefRangeEnd = 1241268, XrefRangeStart = 1241253, XrefRangeEnd = 1241265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x000511B0 File Offset: 0x0004F3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241268, XrefRangeEnd = 1241276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTexture>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00051230 File Offset: 0x0004F430
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1241293, RefRangeEnd = 1241297, XrefRangeStart = 1241276, XrefRangeEnd = 1241293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_Initialize_Private_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x000512B4 File Offset: 0x0004F4B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1241301, RefRangeEnd = 1241306, XrefRangeStart = 1241297, XrefRangeEnd = 1241301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref depthBits;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x00051300 File Offset: 0x0004F500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241306, XrefRangeEnd = 1241307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref depthBits;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0005134C File Offset: 0x0004F54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.Experimental.Rendering.DefaultFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref depthBits;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_DefaultFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x00051398 File Offset: 0x0004F598
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1241311, RefRangeEnd = 1241324, XrefRangeStart = 1241307, XrefRangeEnd = 1241311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref depthBits;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestedShadowMap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x000513E4 File Offset: 0x0004F5E4
		// (set) Token: 0x0600123D RID: 4669 RVA: 0x0000A260 File Offset: 0x00008460
		public unsafe RenderTextureDescriptor descriptor
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 1241326, RefRangeEnd = 1241355, XrefRangeStart = 1241324, XrefRangeEnd = 1241326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_get_descriptor_Public_get_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				RenderTexture.ValidateRenderTextureDesc(value);
				this.SetRenderTextureDescriptor(value);
			}
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00051420 File Offset: 0x0004F620
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1241364, RefRangeEnd = 1241375, XrefRangeStart = 1241355, XrefRangeEnd = 1241364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateRenderTextureDesc(RenderTextureDescriptor desc)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref desc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_ValidateRenderTextureDesc_Private_Static_Void_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x00051454 File Offset: 0x0004F654
		[CallerCount(0)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultColorFormat(UnityEngine.Experimental.Rendering.DefaultFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDefaultColorFormat_Internal_Static_GraphicsFormat_DefaultFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00051494 File Offset: 0x0004F694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241375, XrefRangeEnd = 1241377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultDepthStencilFormat(UnityEngine.Experimental.Rendering.DefaultFormat format, int depth)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDefaultDepthStencilFormat_Internal_Static_GraphicsFormat_DefaultFormat_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x000514E0 File Offset: 0x0004F6E0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1241394, RefRangeEnd = 1241402, XrefRangeStart = 1241377, XrefRangeEnd = 1241394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref renderTextureFormat;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetCompatibleFormat_Internal_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0005152C File Offset: 0x0004F72C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1241405, RefRangeEnd = 1241412, XrefRangeStart = 1241402, XrefRangeEnd = 1241405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(RenderTextureDescriptor desc)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref desc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x0005156C File Offset: 0x0004F76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241412, XrefRangeEnd = 1241417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporaryImpl(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, bool useDynamicScale = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStencilFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memorylessMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vrUsage;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDynamicScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporaryImpl_Private_Static_RenderTexture_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00051610 File Offset: 0x0004F810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241417, XrefRangeEnd = 1241424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memorylessMode;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vrUsage;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDynamicScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x000516C4 File Offset: 0x0004F8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241424, XrefRangeEnd = 1241430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memorylessMode;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vrUsage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00051768 File Offset: 0x0004F968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241430, XrefRangeEnd = 1241436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memorylessMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x000517FC File Offset: 0x0004F9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241436, XrefRangeEnd = 1241442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antiAliasing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x00051884 File Offset: 0x0004FA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241442, XrefRangeEnd = 1241448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x000518FC File Offset: 0x0004FAFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1241454, RefRangeEnd = 1241455, XrefRangeStart = 1241448, XrefRangeEnd = 1241454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00051968 File Offset: 0x0004FB68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1241461, RefRangeEnd = 1241463, XrefRangeStart = 1241455, XrefRangeEnd = 1241461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary(int width, int height, int depthBuffer)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x000519C4 File Offset: 0x0004FBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241463, XrefRangeEnd = 1241465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetColorBuffer_Injected(out RenderBuffer ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetColorBuffer_Injected_Private_Void_byref_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x00051A04 File Offset: 0x0004FC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241465, XrefRangeEnd = 1241467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDepthBuffer_Injected(out RenderBuffer ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDepthBuffer_Injected_Private_Void_byref_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00051A44 File Offset: 0x0004FC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241467, XrefRangeEnd = 1241469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &desc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_SetRenderTextureDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00051A84 File Offset: 0x0004FC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241469, XrefRangeEnd = 1241471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDescriptor_Injected(out RenderTextureDescriptor ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00051AC4 File Offset: 0x0004FCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241471, XrefRangeEnd = 1241473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &desc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTexture.NativeMethodInfoPtr_GetTemporary_Internal_Injected_Private_Static_RenderTexture_byref_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x0000A0BE File Offset: 0x000082BE
		public RenderTexture(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0000A15B File Offset: 0x0000835B
		public bool GetIsPowerOfTwo()
		{
			return RenderTexture.GetIsPowerOfTwoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00051B04 File Offset: 0x0004FD04
		// (set) Token: 0x0600122F RID: 4655 RVA: 0x0000A16D File Offset: 0x0000836D
		public bool isPowerOfTwo
		{
			get
			{
				return this.GetIsPowerOfTwo();
			}
			set
			{
			}
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0000A170 File Offset: 0x00008370
		public void SetShadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode samplingMode)
		{
			RenderTexture.SetShadowSamplingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), samplingMode);
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0000A183 File Offset: 0x00008383
		public IntPtr GetNativeDepthBufferPtr()
		{
			return RenderTexture.GetNativeDepthBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0000A195 File Offset: 0x00008395
		public void MarkRestoreExpected()
		{
			RenderTexture.MarkRestoreExpectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0000A1A7 File Offset: 0x000083A7
		public void ResolveAA()
		{
			RenderTexture.ResolveAADelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0000A1B9 File Offset: 0x000083B9
		public void ResolveAATo(RenderTexture rt)
		{
			RenderTexture.ResolveAAToDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(rt));
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0000A1D1 File Offset: 0x000083D1
		public void ResolveAntiAliasedSurface()
		{
			this.ResolveAA();
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0000A1DB File Offset: 0x000083DB
		public void ResolveAntiAliasedSurface(RenderTexture target)
		{
			this.ResolveAATo(target);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0000A1E6 File Offset: 0x000083E6
		public void SetGlobalShaderProperty(string propertyName)
		{
			RenderTexture.SetGlobalShaderPropertyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(propertyName));
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0000A1FE File Offset: 0x000083FE
		public bool IsCreated()
		{
			return RenderTexture.IsCreatedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0000A210 File Offset: 0x00008410
		public void GenerateMips()
		{
			RenderTexture.GenerateMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0000A222 File Offset: 0x00008422
		public void ConvertToEquirect(RenderTexture equirect, [Optional] Camera.MonoOrStereoscopicEye eye)
		{
			RenderTexture.ConvertToEquirectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(equirect), eye);
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0000A23B File Offset: 0x0000843B
		public static bool SupportsStencil(RenderTexture rt)
		{
			return RenderTexture.SupportsStencilDelegateField(IL2CPP.Il2CppObjectBaseToPtr(rt));
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00051B1C File Offset: 0x0004FD1C
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale)
		{
			return RenderTexture.GetTemporaryImpl(width, height, RenderTexture.GetDepthStencilFormatLegacy(depthBuffer, format), format, antiAliasing, memorylessMode, vrUsage, useDynamicScale);
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00051B48 File Offset: 0x0004FD48
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, antiAliasing, memorylessMode, vrUsage, false);
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00051B6C File Offset: 0x0004FD6C
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, antiAliasing, memorylessMode, VRTextureUsage.None);
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00051B8C File Offset: 0x0004FD8C
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, antiAliasing, RenderTextureMemoryless.None);
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00051BAC File Offset: 0x0004FDAC
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, 1);
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00051BC8 File Offset: 0x0004FDC8
		public static RenderTexture GetTemporary(int width, int height)
		{
			return RenderTexture.GetTemporary(width, height, 0);
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x00051BE4 File Offset: 0x0004FDE4
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x0000A272 File Offset: 0x00008472
		public bool isCubemap
		{
			get
			{
				return this.dimension == UnityEngine.Rendering.TextureDimension.Cube;
			}
			set
			{
				this.dimension = (value ? UnityEngine.Rendering.TextureDimension.Cube : UnityEngine.Rendering.TextureDimension.Tex2D);
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x00051C00 File Offset: 0x0004FE00
		// (set) Token: 0x06001247 RID: 4679 RVA: 0x0000A283 File Offset: 0x00008483
		public bool isVolume
		{
			get
			{
				return this.dimension == UnityEngine.Rendering.TextureDimension.Tex3D;
			}
			set
			{
				this.dimension = (value ? UnityEngine.Rendering.TextureDimension.Tex3D : UnityEngine.Rendering.TextureDimension.Tex2D);
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x00051C1C File Offset: 0x0004FE1C
		// (set) Token: 0x06001249 RID: 4681 RVA: 0x0000A294 File Offset: 0x00008494
		public static bool enabled
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00051C30 File Offset: 0x0004FE30
		public Vector2 GetTexelOffset()
		{
			return Vector2.zero;
		}

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_Virtual_get_Int32_0;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_Virtual_get_Int32_0;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_Virtual_set_Void_Int32_0;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeMethodInfoPtr_get_dimension_Public_Virtual_get_TextureDimension_0;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeMethodInfoPtr_set_dimension_Public_Virtual_set_Void_TextureDimension_0;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeMethodInfoPtr_GetColorFormat_Private_GraphicsFormat_Boolean_0;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeMethodInfoPtr_SetColorFormat_Private_Void_GraphicsFormat_0;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeMethodInfoPtr_set_memorylessMode_Public_set_Void_RenderTextureMemoryless_0;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeMethodInfoPtr_get_format_Public_get_RenderTextureFormat_0;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeMethodInfoPtr_set_stencilFormat_Public_set_Void_GraphicsFormat_0;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr_get_antiAliasing_Public_get_Int32_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_set_antiAliasing_Public_set_Void_Int32_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr_set_bindTextureMS_Public_set_Void_Boolean_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr_GetActive_Private_Static_RenderTexture_0;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Private_Static_Void_RenderTexture_0;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Static_get_RenderTexture_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Public_Static_set_Void_RenderTexture_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_GetColorBuffer_Private_RenderBuffer_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthBuffer_Private_RenderBuffer_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr_SetMipMapCount_Private_Void_Int32_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_get_colorBuffer_Public_get_RenderBuffer_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_get_depthBuffer_Public_get_RenderBuffer_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr_DiscardContents_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr_DiscardContents_Public_Void_0;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Boolean_0;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeMethodInfoPtr_SetSRGBReadWrite_Internal_Void_Boolean_0;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RenderTexture_0;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTextureDescriptor_Private_Void_RenderTextureDescriptor_0;

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptor_Private_RenderTextureDescriptor_0;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Internal_Private_Static_RenderTexture_RenderTextureDescriptor_0;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseTemporary_Public_Static_Void_RenderTexture_0;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeMethodInfoPtr_get_depth_Public_get_Int32_0;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTextureDescriptor_0;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTexture_0;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_0;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_0;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_Int32_0;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_0;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_RenderTextureFormat_Int32_0;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_GraphicsFormat_0;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_RenderTextureFormat_0;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_DefaultFormat_0;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthStencilFormatLegacy_Internal_Static_GraphicsFormat_Int32_Boolean_0;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeMethodInfoPtr_get_descriptor_Public_get_RenderTextureDescriptor_0;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeMethodInfoPtr_ValidateRenderTextureDesc_Private_Static_Void_RenderTextureDescriptor_0;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultColorFormat_Internal_Static_GraphicsFormat_DefaultFormat_0;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultDepthStencilFormat_Internal_Static_GraphicsFormat_DefaultFormat_Int32_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr_GetCompatibleFormat_Internal_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_RenderTextureDescriptor_0;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporaryImpl_Private_Static_RenderTexture_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0;

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean_0;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_0;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_0;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_0;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_RenderTextureFormat_0;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Public_Static_RenderTexture_Int32_Int32_Int32_0;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeMethodInfoPtr_GetColorBuffer_Injected_Private_Void_byref_RenderBuffer_0;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthBuffer_Injected_Private_Void_byref_RenderBuffer_0;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTextureDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptor_Injected_Private_Void_byref_RenderTextureDescriptor_0;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporary_Internal_Injected_Private_Static_RenderTexture_byref_RenderTextureDescriptor_0;

		// Token: 0x04000E9A RID: 3738
		private static readonly RenderTexture.get_vrUsageDelegate get_vrUsageDelegateField;

		// Token: 0x04000E9B RID: 3739
		private static readonly RenderTexture.get_memorylessModeDelegate get_memorylessModeDelegateField;

		// Token: 0x04000E9C RID: 3740
		private static readonly RenderTexture.get_stencilFormatDelegate get_stencilFormatDelegateField;

		// Token: 0x04000E9D RID: 3741
		private static readonly RenderTexture.get_depthStencilFormatDelegate get_depthStencilFormatDelegateField;

		// Token: 0x04000E9E RID: 3742
		private static readonly RenderTexture.get_autoGenerateMipsDelegate get_autoGenerateMipsDelegateField;

		// Token: 0x04000E9F RID: 3743
		private static readonly RenderTexture.get_bindTextureMSDelegate get_bindTextureMSDelegateField;

		// Token: 0x04000EA0 RID: 3744
		private static readonly RenderTexture.get_enableRandomWriteDelegate get_enableRandomWriteDelegateField;

		// Token: 0x04000EA1 RID: 3745
		private static readonly RenderTexture.GetIsPowerOfTwoDelegate GetIsPowerOfTwoDelegateField;

		// Token: 0x04000EA2 RID: 3746
		private static readonly RenderTexture.SetShadowSamplingModeDelegate SetShadowSamplingModeDelegateField;

		// Token: 0x04000EA3 RID: 3747
		private static readonly RenderTexture.GetNativeDepthBufferPtrDelegate GetNativeDepthBufferPtrDelegateField;

		// Token: 0x04000EA4 RID: 3748
		private static readonly RenderTexture.MarkRestoreExpectedDelegate MarkRestoreExpectedDelegateField;

		// Token: 0x04000EA5 RID: 3749
		private static readonly RenderTexture.ResolveAADelegate ResolveAADelegateField;

		// Token: 0x04000EA6 RID: 3750
		private static readonly RenderTexture.ResolveAAToDelegate ResolveAAToDelegateField;

		// Token: 0x04000EA7 RID: 3751
		private static readonly RenderTexture.SetGlobalShaderPropertyDelegate SetGlobalShaderPropertyDelegateField;

		// Token: 0x04000EA8 RID: 3752
		private static readonly RenderTexture.IsCreatedDelegate IsCreatedDelegateField;

		// Token: 0x04000EA9 RID: 3753
		private static readonly RenderTexture.GenerateMipsDelegate GenerateMipsDelegateField;

		// Token: 0x04000EAA RID: 3754
		private static readonly RenderTexture.ConvertToEquirectDelegate ConvertToEquirectDelegateField;

		// Token: 0x04000EAB RID: 3755
		private static readonly RenderTexture.SupportsStencilDelegate SupportsStencilDelegateField;

		// Token: 0x04000EAC RID: 3756
		private static readonly RenderTexture.set_depthDelegate set_depthDelegateField;

		// Token: 0x02000838 RID: 2104
		// (Invoke) Token: 0x06003902 RID: 14594
		private delegate VRTextureUsage get_vrUsageDelegate(IntPtr @this);

		// Token: 0x02000839 RID: 2105
		// (Invoke) Token: 0x06003904 RID: 14596
		private delegate RenderTextureMemoryless get_memorylessModeDelegate(IntPtr @this);

		// Token: 0x0200083A RID: 2106
		// (Invoke) Token: 0x06003906 RID: 14598
		private delegate UnityEngine.Experimental.Rendering.GraphicsFormat get_stencilFormatDelegate(IntPtr @this);

		// Token: 0x0200083B RID: 2107
		// (Invoke) Token: 0x06003908 RID: 14600
		private delegate UnityEngine.Experimental.Rendering.GraphicsFormat get_depthStencilFormatDelegate(IntPtr @this);

		// Token: 0x0200083C RID: 2108
		// (Invoke) Token: 0x0600390A RID: 14602
		private delegate bool get_autoGenerateMipsDelegate(IntPtr @this);

		// Token: 0x0200083D RID: 2109
		// (Invoke) Token: 0x0600390C RID: 14604
		private delegate bool get_bindTextureMSDelegate(IntPtr @this);

		// Token: 0x0200083E RID: 2110
		// (Invoke) Token: 0x0600390E RID: 14606
		private delegate bool get_enableRandomWriteDelegate(IntPtr @this);

		// Token: 0x0200083F RID: 2111
		// (Invoke) Token: 0x06003910 RID: 14608
		private delegate bool GetIsPowerOfTwoDelegate(IntPtr @this);

		// Token: 0x02000840 RID: 2112
		// (Invoke) Token: 0x06003912 RID: 14610
		private delegate void SetShadowSamplingModeDelegate(IntPtr @this, UnityEngine.Rendering.ShadowSamplingMode samplingMode);

		// Token: 0x02000841 RID: 2113
		// (Invoke) Token: 0x06003914 RID: 14612
		private delegate IntPtr GetNativeDepthBufferPtrDelegate(IntPtr @this);

		// Token: 0x02000842 RID: 2114
		// (Invoke) Token: 0x06003916 RID: 14614
		private delegate void MarkRestoreExpectedDelegate(IntPtr @this);

		// Token: 0x02000843 RID: 2115
		// (Invoke) Token: 0x06003918 RID: 14616
		private delegate void ResolveAADelegate(IntPtr @this);

		// Token: 0x02000844 RID: 2116
		// (Invoke) Token: 0x0600391A RID: 14618
		private delegate void ResolveAAToDelegate(IntPtr @this, IntPtr rt);

		// Token: 0x02000845 RID: 2117
		// (Invoke) Token: 0x0600391C RID: 14620
		private delegate void SetGlobalShaderPropertyDelegate(IntPtr @this, IntPtr propertyName);

		// Token: 0x02000846 RID: 2118
		// (Invoke) Token: 0x0600391E RID: 14622
		private delegate bool IsCreatedDelegate(IntPtr @this);

		// Token: 0x02000847 RID: 2119
		// (Invoke) Token: 0x06003920 RID: 14624
		private delegate void GenerateMipsDelegate(IntPtr @this);

		// Token: 0x02000848 RID: 2120
		// (Invoke) Token: 0x06003922 RID: 14626
		private delegate void ConvertToEquirectDelegate(IntPtr @this, IntPtr equirect, Camera.MonoOrStereoscopicEye eye);

		// Token: 0x02000849 RID: 2121
		// (Invoke) Token: 0x06003924 RID: 14628
		private delegate bool SupportsStencilDelegate(IntPtr rt);

		// Token: 0x0200084A RID: 2122
		// (Invoke) Token: 0x06003926 RID: 14630
		private delegate void set_depthDelegate(IntPtr @this, int value);
	}
}
