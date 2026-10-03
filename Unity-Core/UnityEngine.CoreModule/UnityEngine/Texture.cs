using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000DC RID: 220
	public class Texture : Object
	{
		// Token: 0x0600105E RID: 4190 RVA: 0x00048A00 File Offset: 0x00046C00
		// Note: this type is marked as 'beforefieldinit'.
		static Texture()
		{
			Il2CppClassPointerStore<Texture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Texture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture>.NativeClassPtr);
			Texture.NativeFieldInfoPtr_GenerateAllMips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture>.NativeClassPtr, "GenerateAllMips");
			Texture.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664810);
			Texture.NativeMethodInfoPtr_get_mipmapCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664811);
			Texture.NativeMethodInfoPtr_get_graphicsFormat_Public_Virtual_New_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664812);
			Texture.NativeMethodInfoPtr_GetDataWidth_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664813);
			Texture.NativeMethodInfoPtr_GetDataHeight_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664814);
			Texture.NativeMethodInfoPtr_GetDimension_Private_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664815);
			Texture.NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664816);
			Texture.NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664817);
			Texture.NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664818);
			Texture.NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664819);
			Texture.NativeMethodInfoPtr_get_dimension_Public_Virtual_New_get_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664820);
			Texture.NativeMethodInfoPtr_set_dimension_Public_Virtual_New_set_Void_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664821);
			Texture.NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664822);
			Texture.NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664823);
			Texture.NativeMethodInfoPtr_set_wrapMode_Public_set_Void_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664824);
			Texture.NativeMethodInfoPtr_set_wrapModeU_Public_set_Void_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664825);
			Texture.NativeMethodInfoPtr_set_wrapModeV_Public_set_Void_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664826);
			Texture.NativeMethodInfoPtr_set_wrapModeW_Public_set_Void_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664827);
			Texture.NativeMethodInfoPtr_get_filterMode_Public_get_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664828);
			Texture.NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664829);
			Texture.NativeMethodInfoPtr_get_anisoLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664830);
			Texture.NativeMethodInfoPtr_set_anisoLevel_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664831);
			Texture.NativeMethodInfoPtr_get_mipMapBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664832);
			Texture.NativeMethodInfoPtr_set_mipMapBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664833);
			Texture.NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664834);
			Texture.NativeMethodInfoPtr_get_updateCount_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664835);
			Texture.NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664836);
			Texture.NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664837);
			Texture.NativeMethodInfoPtr_GetPixelDataSize_Internal_UInt64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664838);
			Texture.NativeMethodInfoPtr_GetPixelDataOffset_Internal_UInt64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664839);
			Texture.NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664840);
			Texture.NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664841);
			Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664842);
			Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_FormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664843);
			Texture.NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664844);
			Texture.NativeMethodInfoPtr_CreateNativeArrayLengthOverflowException_Internal_UnityException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664845);
			Texture.NativeMethodInfoPtr_get_texelSize_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture>.NativeClassPtr, 100664847);
			Texture.get_masterTextureLimitDelegateField = IL2CPP.ResolveICall<Texture.get_masterTextureLimitDelegate>("UnityEngine.Texture::get_masterTextureLimit");
			Texture.set_masterTextureLimitDelegateField = IL2CPP.ResolveICall<Texture.set_masterTextureLimitDelegate>("UnityEngine.Texture::set_masterTextureLimit");
			Texture.get_globalMipmapLimitDelegateField = IL2CPP.ResolveICall<Texture.get_globalMipmapLimitDelegate>("UnityEngine.Texture::get_globalMipmapLimit");
			Texture.set_globalMipmapLimitDelegateField = IL2CPP.ResolveICall<Texture.set_globalMipmapLimitDelegate>("UnityEngine.Texture::set_globalMipmapLimit");
			Texture.get_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<Texture.get_anisotropicFilteringDelegate>("UnityEngine.Texture::get_anisotropicFiltering");
			Texture.set_anisotropicFilteringDelegateField = IL2CPP.ResolveICall<Texture.set_anisotropicFilteringDelegate>("UnityEngine.Texture::set_anisotropicFiltering");
			Texture.SetGlobalAnisotropicFilteringLimitsDelegateField = IL2CPP.ResolveICall<Texture.SetGlobalAnisotropicFilteringLimitsDelegate>("UnityEngine.Texture::SetGlobalAnisotropicFilteringLimits");
			Texture.get_isNativeTextureDelegateField = IL2CPP.ResolveICall<Texture.get_isNativeTextureDelegate>("UnityEngine.Texture::get_isNativeTexture");
			Texture.get_wrapModeUDelegateField = IL2CPP.ResolveICall<Texture.get_wrapModeUDelegate>("UnityEngine.Texture::get_wrapModeU");
			Texture.get_wrapModeVDelegateField = IL2CPP.ResolveICall<Texture.get_wrapModeVDelegate>("UnityEngine.Texture::get_wrapModeV");
			Texture.get_wrapModeWDelegateField = IL2CPP.ResolveICall<Texture.get_wrapModeWDelegate>("UnityEngine.Texture::get_wrapModeW");
			Texture.GetNativeTexturePtrDelegateField = IL2CPP.ResolveICall<Texture.GetNativeTexturePtrDelegate>("UnityEngine.Texture::GetNativeTexturePtr");
			Texture.IncrementUpdateCountDelegateField = IL2CPP.ResolveICall<Texture.IncrementUpdateCountDelegate>("UnityEngine.Texture::IncrementUpdateCount");
			Texture.Internal_GetStoredColorSpaceDelegateField = IL2CPP.ResolveICall<Texture.Internal_GetStoredColorSpaceDelegate>("UnityEngine.Texture::Internal_GetStoredColorSpace");
			Texture.get_totalTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_totalTextureMemoryDelegate>("UnityEngine.Texture::get_totalTextureMemory");
			Texture.get_desiredTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_desiredTextureMemoryDelegate>("UnityEngine.Texture::get_desiredTextureMemory");
			Texture.get_targetTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_targetTextureMemoryDelegate>("UnityEngine.Texture::get_targetTextureMemory");
			Texture.get_currentTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_currentTextureMemoryDelegate>("UnityEngine.Texture::get_currentTextureMemory");
			Texture.get_nonStreamingTextureMemoryDelegateField = IL2CPP.ResolveICall<Texture.get_nonStreamingTextureMemoryDelegate>("UnityEngine.Texture::get_nonStreamingTextureMemory");
			Texture.get_streamingMipmapUploadCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingMipmapUploadCountDelegate>("UnityEngine.Texture::get_streamingMipmapUploadCount");
			Texture.get_streamingRendererCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingRendererCountDelegate>("UnityEngine.Texture::get_streamingRendererCount");
			Texture.get_streamingTextureCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureCountDelegate>("UnityEngine.Texture::get_streamingTextureCount");
			Texture.get_nonStreamingTextureCountDelegateField = IL2CPP.ResolveICall<Texture.get_nonStreamingTextureCountDelegate>("UnityEngine.Texture::get_nonStreamingTextureCount");
			Texture.get_streamingTexturePendingLoadCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTexturePendingLoadCountDelegate>("UnityEngine.Texture::get_streamingTexturePendingLoadCount");
			Texture.get_streamingTextureLoadingCountDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureLoadingCountDelegate>("UnityEngine.Texture::get_streamingTextureLoadingCount");
			Texture.SetStreamingTextureMaterialDebugPropertiesDelegateField = IL2CPP.ResolveICall<Texture.SetStreamingTextureMaterialDebugPropertiesDelegate>("UnityEngine.Texture::SetStreamingTextureMaterialDebugProperties");
			Texture.get_streamingTextureForceLoadAllDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureForceLoadAllDelegate>("UnityEngine.Texture::get_streamingTextureForceLoadAll");
			Texture.set_streamingTextureForceLoadAllDelegateField = IL2CPP.ResolveICall<Texture.set_streamingTextureForceLoadAllDelegate>("UnityEngine.Texture::set_streamingTextureForceLoadAll");
			Texture.get_streamingTextureDiscardUnusedMipsDelegateField = IL2CPP.ResolveICall<Texture.get_streamingTextureDiscardUnusedMipsDelegate>("UnityEngine.Texture::get_streamingTextureDiscardUnusedMips");
			Texture.set_streamingTextureDiscardUnusedMipsDelegateField = IL2CPP.ResolveICall<Texture.set_streamingTextureDiscardUnusedMipsDelegate>("UnityEngine.Texture::set_streamingTextureDiscardUnusedMips");
			Texture.get_allowThreadedTextureCreationDelegateField = IL2CPP.ResolveICall<Texture.get_allowThreadedTextureCreationDelegate>("UnityEngine.Texture::get_allowThreadedTextureCreation");
			Texture.set_allowThreadedTextureCreationDelegateField = IL2CPP.ResolveICall<Texture.set_allowThreadedTextureCreationDelegate>("UnityEngine.Texture::set_allowThreadedTextureCreation");
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00048F08 File Offset: 0x00047108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239557, XrefRangeEnd = 1239561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x00048F44 File Offset: 0x00047144
		public unsafe int mipmapCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1239563, RefRangeEnd = 1239566, XrefRangeStart = 1239561, XrefRangeEnd = 1239563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_mipmapCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x00048F80 File Offset: 0x00047180
		public unsafe virtual UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239566, XrefRangeEnd = 1239570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_get_graphicsFormat_Public_Virtual_New_get_GraphicsFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00048FC8 File Offset: 0x000471C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239570, XrefRangeEnd = 1239572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDataWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetDataWidth_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00049004 File Offset: 0x00047204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239572, XrefRangeEnd = 1239574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDataHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetDataHeight_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00049040 File Offset: 0x00047240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239574, XrefRangeEnd = 1239576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Rendering.TextureDimension GetDimension()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetDimension_Private_TextureDimension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001065 RID: 4197 RVA: 0x0004907C File Offset: 0x0004727C
		// (set) Token: 0x06001066 RID: 4198 RVA: 0x000490C4 File Offset: 0x000472C4
		public unsafe virtual int width
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239576, XrefRangeEnd = 1239581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x00049110 File Offset: 0x00047310
		// (set) Token: 0x06001068 RID: 4200 RVA: 0x00049158 File Offset: 0x00047358
		public unsafe virtual int height
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239581, XrefRangeEnd = 1239586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x000491A4 File Offset: 0x000473A4
		// (set) Token: 0x0600106A RID: 4202 RVA: 0x000491EC File Offset: 0x000473EC
		public unsafe virtual UnityEngine.Rendering.TextureDimension dimension
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_get_dimension_Public_Virtual_New_get_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239586, XrefRangeEnd = 1239591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_set_dimension_Public_Virtual_New_set_Void_TextureDimension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x00049238 File Offset: 0x00047438
		public unsafe virtual bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239591, XrefRangeEnd = 1239593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Texture.NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x00049280 File Offset: 0x00047480
		// (set) Token: 0x0600106D RID: 4205 RVA: 0x000492BC File Offset: 0x000474BC
		public unsafe TextureWrapMode wrapMode
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1239595, RefRangeEnd = 1239603, XrefRangeStart = 1239593, XrefRangeEnd = 1239595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1239605, RefRangeEnd = 1239618, XrefRangeStart = 1239603, XrefRangeEnd = 1239605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_wrapMode_Public_set_Void_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x000099AE File Offset: 0x00007BAE
		// (set) Token: 0x0600106E RID: 4206 RVA: 0x000492FC File Offset: 0x000474FC
		public unsafe TextureWrapMode wrapModeU
		{
			get
			{
				return Texture.get_wrapModeUDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1239620, RefRangeEnd = 1239622, XrefRangeStart = 1239618, XrefRangeEnd = 1239620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_wrapModeU_Public_set_Void_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x000099C0 File Offset: 0x00007BC0
		// (set) Token: 0x0600106F RID: 4207 RVA: 0x0004933C File Offset: 0x0004753C
		public unsafe TextureWrapMode wrapModeV
		{
			get
			{
				return Texture.get_wrapModeVDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1239624, RefRangeEnd = 1239626, XrefRangeStart = 1239622, XrefRangeEnd = 1239624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_wrapModeV_Public_set_Void_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x000099D2 File Offset: 0x00007BD2
		// (set) Token: 0x06001070 RID: 4208 RVA: 0x0004937C File Offset: 0x0004757C
		public unsafe TextureWrapMode wrapModeW
		{
			get
			{
				return Texture.get_wrapModeWDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1239628, RefRangeEnd = 1239630, XrefRangeStart = 1239626, XrefRangeEnd = 1239628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_wrapModeW_Public_set_Void_TextureWrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x000493BC File Offset: 0x000475BC
		// (set) Token: 0x06001072 RID: 4210 RVA: 0x000493F8 File Offset: 0x000475F8
		public unsafe FilterMode filterMode
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1239632, RefRangeEnd = 1239647, XrefRangeStart = 1239630, XrefRangeEnd = 1239632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_filterMode_Public_get_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 1239649, RefRangeEnd = 1239673, XrefRangeStart = 1239647, XrefRangeEnd = 1239649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x00049438 File Offset: 0x00047638
		// (set) Token: 0x06001074 RID: 4212 RVA: 0x00049474 File Offset: 0x00047674
		public unsafe int anisoLevel
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1239675, RefRangeEnd = 1239680, XrefRangeStart = 1239673, XrefRangeEnd = 1239675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_anisoLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1239682, RefRangeEnd = 1239687, XrefRangeStart = 1239680, XrefRangeEnd = 1239682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_anisoLevel_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x000494B4 File Offset: 0x000476B4
		// (set) Token: 0x06001076 RID: 4214 RVA: 0x000494F0 File Offset: 0x000476F0
		public unsafe float mipMapBias
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1239689, RefRangeEnd = 1239693, XrefRangeStart = 1239687, XrefRangeEnd = 1239689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_mipMapBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1239695, RefRangeEnd = 1239699, XrefRangeStart = 1239693, XrefRangeEnd = 1239695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_set_mipMapBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x00049530 File Offset: 0x00047730
		public unsafe Vector2 texelSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1239701, RefRangeEnd = 1239703, XrefRangeStart = 1239699, XrefRangeEnd = 1239701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x0004956C File Offset: 0x0004776C
		public unsafe uint updateCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1239705, RefRangeEnd = 1239708, XrefRangeStart = 1239703, XrefRangeEnd = 1239705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_updateCount_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x000495A8 File Offset: 0x000477A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239708, XrefRangeEnd = 1239710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Internal_GetActiveTextureColorSpace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x000495E4 File Offset: 0x000477E4
		public unsafe ColorSpace activeTextureColorSpace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1239712, RefRangeEnd = 1239713, XrefRangeStart = 1239710, XrefRangeEnd = 1239712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00049620 File Offset: 0x00047820
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239715, RefRangeEnd = 1239717, XrefRangeStart = 1239713, XrefRangeEnd = 1239715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong GetPixelDataSize(int mipLevel, int element = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref element;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetPixelDataSize_Internal_UInt64_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00049678 File Offset: 0x00047878
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239719, RefRangeEnd = 1239721, XrefRangeStart = 1239717, XrefRangeEnd = 1239719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong GetPixelDataOffset(int mipLevel, int element = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref element;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetPixelDataOffset_Internal_UInt64_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x000496D0 File Offset: 0x000478D0
		[CallerCount(0)]
		public unsafe TextureColorSpace GetTextureColorSpace(bool linear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref linear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0004971C File Offset: 0x0004791C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239721, XrefRangeEnd = 1239725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureColorSpace GetTextureColorSpace(UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x00049768 File Offset: 0x00047968
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1239745, RefRangeEnd = 1239753, XrefRangeStart = 1239725, XrefRangeEnd = 1239745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(TextureFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x000497B4 File Offset: 0x000479B4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1239765, RefRangeEnd = 1239775, XrefRangeStart = 1239753, XrefRangeEnd = 1239765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_FormatUsage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0004980C File Offset: 0x00047A0C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1239783, RefRangeEnd = 1239793, XrefRangeStart = 1239775, XrefRangeEnd = 1239783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityException CreateNonReadableException(Texture t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityException>(intPtr3) : null;
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x0004985C File Offset: 0x00047A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239793, XrefRangeEnd = 1239799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityException CreateNativeArrayLengthOverflowException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_CreateNativeArrayLengthOverflowException_Internal_UnityException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityException>(intPtr3) : null;
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x0004989C File Offset: 0x00047A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239799, XrefRangeEnd = 1239801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_texelSize_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture.NativeMethodInfoPtr_get_texelSize_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x0000992C File Offset: 0x00007B2C
		public Texture(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x000498DC File Offset: 0x00047ADC
		// (set) Token: 0x06001086 RID: 4230 RVA: 0x00009935 File Offset: 0x00007B35
		public unsafe static int GenerateAllMips
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Texture.NativeFieldInfoPtr_GenerateAllMips, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Texture.NativeFieldInfoPtr_GenerateAllMips, (void*)(&value));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x00009943 File Offset: 0x00007B43
		// (set) Token: 0x06001088 RID: 4232 RVA: 0x0000994F File Offset: 0x00007B4F
		public static int masterTextureLimit
		{
			get
			{
				return Texture.get_masterTextureLimitDelegateField();
			}
			set
			{
				Texture.set_masterTextureLimitDelegateField(value);
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x0000995C File Offset: 0x00007B5C
		// (set) Token: 0x0600108A RID: 4234 RVA: 0x00009968 File Offset: 0x00007B68
		public static int globalMipmapLimit
		{
			get
			{
				return Texture.get_globalMipmapLimitDelegateField();
			}
			set
			{
				Texture.set_globalMipmapLimitDelegateField(value);
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x00009975 File Offset: 0x00007B75
		// (set) Token: 0x0600108C RID: 4236 RVA: 0x00009981 File Offset: 0x00007B81
		public static AnisotropicFiltering anisotropicFiltering
		{
			get
			{
				return Texture.get_anisotropicFilteringDelegateField();
			}
			set
			{
				Texture.set_anisotropicFilteringDelegateField(value);
			}
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0000998E File Offset: 0x00007B8E
		public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax)
		{
			Texture.SetGlobalAnisotropicFilteringLimitsDelegateField(forcedMin, globalMax);
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x0000999C File Offset: 0x00007B9C
		public bool isNativeTexture
		{
			get
			{
				return Texture.get_isNativeTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x000099E4 File Offset: 0x00007BE4
		public IntPtr GetNativeTexturePtr()
		{
			return Texture.GetNativeTexturePtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x000498F8 File Offset: 0x00047AF8
		public int GetNativeTextureID()
		{
			return (int)this.GetNativeTexturePtr();
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x000099F6 File Offset: 0x00007BF6
		public void IncrementUpdateCount()
		{
			Texture.IncrementUpdateCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00009A08 File Offset: 0x00007C08
		public TextureColorSpace Internal_GetStoredColorSpace()
		{
			return Texture.Internal_GetStoredColorSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x00049918 File Offset: 0x00047B18
		public bool isDataSRGB
		{
			get
			{
				return this.Internal_GetStoredColorSpace() == TextureColorSpace.sRGB;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x00009A1A File Offset: 0x00007C1A
		public static ulong totalTextureMemory
		{
			get
			{
				return Texture.get_totalTextureMemoryDelegateField();
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x00009A26 File Offset: 0x00007C26
		public static ulong desiredTextureMemory
		{
			get
			{
				return Texture.get_desiredTextureMemoryDelegateField();
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x00009A32 File Offset: 0x00007C32
		public static ulong targetTextureMemory
		{
			get
			{
				return Texture.get_targetTextureMemoryDelegateField();
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x00009A3E File Offset: 0x00007C3E
		public static ulong currentTextureMemory
		{
			get
			{
				return Texture.get_currentTextureMemoryDelegateField();
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x00009A4A File Offset: 0x00007C4A
		public static ulong nonStreamingTextureMemory
		{
			get
			{
				return Texture.get_nonStreamingTextureMemoryDelegateField();
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x00009A56 File Offset: 0x00007C56
		public static ulong streamingMipmapUploadCount
		{
			get
			{
				return Texture.get_streamingMipmapUploadCountDelegateField();
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x00009A62 File Offset: 0x00007C62
		public static ulong streamingRendererCount
		{
			get
			{
				return Texture.get_streamingRendererCountDelegateField();
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x00009A6E File Offset: 0x00007C6E
		public static ulong streamingTextureCount
		{
			get
			{
				return Texture.get_streamingTextureCountDelegateField();
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x00009A7A File Offset: 0x00007C7A
		public static ulong nonStreamingTextureCount
		{
			get
			{
				return Texture.get_nonStreamingTextureCountDelegateField();
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x00009A86 File Offset: 0x00007C86
		public static ulong streamingTexturePendingLoadCount
		{
			get
			{
				return Texture.get_streamingTexturePendingLoadCountDelegateField();
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x00009A92 File Offset: 0x00007C92
		public static ulong streamingTextureLoadingCount
		{
			get
			{
				return Texture.get_streamingTextureLoadingCountDelegateField();
			}
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00009A9E File Offset: 0x00007C9E
		public static void SetStreamingTextureMaterialDebugProperties()
		{
			Texture.SetStreamingTextureMaterialDebugPropertiesDelegateField();
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x00009AAA File Offset: 0x00007CAA
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x00009AB6 File Offset: 0x00007CB6
		public static bool streamingTextureForceLoadAll
		{
			get
			{
				return Texture.get_streamingTextureForceLoadAllDelegateField();
			}
			set
			{
				Texture.set_streamingTextureForceLoadAllDelegateField(value);
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x00009AC3 File Offset: 0x00007CC3
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x00009ACF File Offset: 0x00007CCF
		public static bool streamingTextureDiscardUnusedMips
		{
			get
			{
				return Texture.get_streamingTextureDiscardUnusedMipsDelegateField();
			}
			set
			{
				Texture.set_streamingTextureDiscardUnusedMipsDelegateField(value);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x00009ADC File Offset: 0x00007CDC
		// (set) Token: 0x060010A8 RID: 4264 RVA: 0x00009AE8 File Offset: 0x00007CE8
		public static bool allowThreadedTextureCreation
		{
			get
			{
				return Texture.get_allowThreadedTextureCreationDelegateField();
			}
			set
			{
				Texture.set_allowThreadedTextureCreationDelegateField(value);
			}
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00049934 File Offset: 0x00047B34
		public bool ValidateFormat(RenderTextureFormat format)
		{
			bool flag = SystemInfo.SupportsRenderTextureFormat(format);
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				Debug.LogError(String.Format("RenderTexture creation failed. '{0}' is not supported on this platform. Use 'SystemInfo.SupportsRenderTextureFormat' C# API to check format support.", format.ToString()), this);
				result = false;
			}
			return result;
		}

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeFieldInfoPtr_GenerateAllMips;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr_get_mipmapCount_Public_get_Int32_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsFormat_Public_Virtual_New_get_GraphicsFormat_0;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr_GetDataWidth_Private_Int32_0;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeMethodInfoPtr_GetDataHeight_Private_Int32_0;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_GetDimension_Private_TextureDimension_0;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeMethodInfoPtr_get_dimension_Public_Virtual_New_get_TextureDimension_0;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeMethodInfoPtr_set_dimension_Public_Virtual_New_set_Void_TextureDimension_0;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_get_wrapMode_Public_get_TextureWrapMode_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr_set_wrapMode_Public_set_Void_TextureWrapMode_0;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr_set_wrapModeU_Public_set_Void_TextureWrapMode_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_set_wrapModeV_Public_set_Void_TextureWrapMode_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_set_wrapModeW_Public_set_Void_TextureWrapMode_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr_get_filterMode_Public_get_FilterMode_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_set_filterMode_Public_set_Void_FilterMode_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_get_anisoLevel_Public_get_Int32_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_set_anisoLevel_Public_set_Void_Int32_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_get_mipMapBias_Public_get_Single_0;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_set_mipMapBias_Public_set_Void_Single_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_get_texelSize_Public_get_Vector2_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_get_updateCount_Public_get_UInt32_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetActiveTextureColorSpace_Private_Int32_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_get_activeTextureColorSpace_Internal_get_ColorSpace_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelDataSize_Internal_UInt64_Int32_Int32_0;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelDataOffset_Internal_UInt64_Int32_Int32_0;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_Boolean_0;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureColorSpace_Internal_TextureColorSpace_GraphicsFormat_0;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_FormatUsage_0;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr_CreateNonReadableException_Internal_UnityException_Texture_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr_CreateNativeArrayLengthOverflowException_Internal_UnityException_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr_get_texelSize_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000D40 RID: 3392
		private static readonly Texture.get_masterTextureLimitDelegate get_masterTextureLimitDelegateField;

		// Token: 0x04000D41 RID: 3393
		private static readonly Texture.set_masterTextureLimitDelegate set_masterTextureLimitDelegateField;

		// Token: 0x04000D42 RID: 3394
		private static readonly Texture.get_globalMipmapLimitDelegate get_globalMipmapLimitDelegateField;

		// Token: 0x04000D43 RID: 3395
		private static readonly Texture.set_globalMipmapLimitDelegate set_globalMipmapLimitDelegateField;

		// Token: 0x04000D44 RID: 3396
		private static readonly Texture.get_anisotropicFilteringDelegate get_anisotropicFilteringDelegateField;

		// Token: 0x04000D45 RID: 3397
		private static readonly Texture.set_anisotropicFilteringDelegate set_anisotropicFilteringDelegateField;

		// Token: 0x04000D46 RID: 3398
		private static readonly Texture.SetGlobalAnisotropicFilteringLimitsDelegate SetGlobalAnisotropicFilteringLimitsDelegateField;

		// Token: 0x04000D47 RID: 3399
		private static readonly Texture.get_isNativeTextureDelegate get_isNativeTextureDelegateField;

		// Token: 0x04000D48 RID: 3400
		private static readonly Texture.get_wrapModeUDelegate get_wrapModeUDelegateField;

		// Token: 0x04000D49 RID: 3401
		private static readonly Texture.get_wrapModeVDelegate get_wrapModeVDelegateField;

		// Token: 0x04000D4A RID: 3402
		private static readonly Texture.get_wrapModeWDelegate get_wrapModeWDelegateField;

		// Token: 0x04000D4B RID: 3403
		private static readonly Texture.GetNativeTexturePtrDelegate GetNativeTexturePtrDelegateField;

		// Token: 0x04000D4C RID: 3404
		private static readonly Texture.IncrementUpdateCountDelegate IncrementUpdateCountDelegateField;

		// Token: 0x04000D4D RID: 3405
		private static readonly Texture.Internal_GetStoredColorSpaceDelegate Internal_GetStoredColorSpaceDelegateField;

		// Token: 0x04000D4E RID: 3406
		private static readonly Texture.get_totalTextureMemoryDelegate get_totalTextureMemoryDelegateField;

		// Token: 0x04000D4F RID: 3407
		private static readonly Texture.get_desiredTextureMemoryDelegate get_desiredTextureMemoryDelegateField;

		// Token: 0x04000D50 RID: 3408
		private static readonly Texture.get_targetTextureMemoryDelegate get_targetTextureMemoryDelegateField;

		// Token: 0x04000D51 RID: 3409
		private static readonly Texture.get_currentTextureMemoryDelegate get_currentTextureMemoryDelegateField;

		// Token: 0x04000D52 RID: 3410
		private static readonly Texture.get_nonStreamingTextureMemoryDelegate get_nonStreamingTextureMemoryDelegateField;

		// Token: 0x04000D53 RID: 3411
		private static readonly Texture.get_streamingMipmapUploadCountDelegate get_streamingMipmapUploadCountDelegateField;

		// Token: 0x04000D54 RID: 3412
		private static readonly Texture.get_streamingRendererCountDelegate get_streamingRendererCountDelegateField;

		// Token: 0x04000D55 RID: 3413
		private static readonly Texture.get_streamingTextureCountDelegate get_streamingTextureCountDelegateField;

		// Token: 0x04000D56 RID: 3414
		private static readonly Texture.get_nonStreamingTextureCountDelegate get_nonStreamingTextureCountDelegateField;

		// Token: 0x04000D57 RID: 3415
		private static readonly Texture.get_streamingTexturePendingLoadCountDelegate get_streamingTexturePendingLoadCountDelegateField;

		// Token: 0x04000D58 RID: 3416
		private static readonly Texture.get_streamingTextureLoadingCountDelegate get_streamingTextureLoadingCountDelegateField;

		// Token: 0x04000D59 RID: 3417
		private static readonly Texture.SetStreamingTextureMaterialDebugPropertiesDelegate SetStreamingTextureMaterialDebugPropertiesDelegateField;

		// Token: 0x04000D5A RID: 3418
		private static readonly Texture.get_streamingTextureForceLoadAllDelegate get_streamingTextureForceLoadAllDelegateField;

		// Token: 0x04000D5B RID: 3419
		private static readonly Texture.set_streamingTextureForceLoadAllDelegate set_streamingTextureForceLoadAllDelegateField;

		// Token: 0x04000D5C RID: 3420
		private static readonly Texture.get_streamingTextureDiscardUnusedMipsDelegate get_streamingTextureDiscardUnusedMipsDelegateField;

		// Token: 0x04000D5D RID: 3421
		private static readonly Texture.set_streamingTextureDiscardUnusedMipsDelegate set_streamingTextureDiscardUnusedMipsDelegateField;

		// Token: 0x04000D5E RID: 3422
		private static readonly Texture.get_allowThreadedTextureCreationDelegate get_allowThreadedTextureCreationDelegateField;

		// Token: 0x04000D5F RID: 3423
		private static readonly Texture.set_allowThreadedTextureCreationDelegate set_allowThreadedTextureCreationDelegateField;

		// Token: 0x020007C8 RID: 1992
		// (Invoke) Token: 0x06003829 RID: 14377
		private delegate int get_masterTextureLimitDelegate();

		// Token: 0x020007C9 RID: 1993
		// (Invoke) Token: 0x0600382B RID: 14379
		private delegate void set_masterTextureLimitDelegate(int value);

		// Token: 0x020007CA RID: 1994
		// (Invoke) Token: 0x0600382D RID: 14381
		private delegate int get_globalMipmapLimitDelegate();

		// Token: 0x020007CB RID: 1995
		// (Invoke) Token: 0x0600382F RID: 14383
		private delegate void set_globalMipmapLimitDelegate(int value);

		// Token: 0x020007CC RID: 1996
		// (Invoke) Token: 0x06003831 RID: 14385
		private delegate AnisotropicFiltering get_anisotropicFilteringDelegate();

		// Token: 0x020007CD RID: 1997
		// (Invoke) Token: 0x06003833 RID: 14387
		private delegate void set_anisotropicFilteringDelegate(AnisotropicFiltering value);

		// Token: 0x020007CE RID: 1998
		// (Invoke) Token: 0x06003835 RID: 14389
		private delegate void SetGlobalAnisotropicFilteringLimitsDelegate(int forcedMin, int globalMax);

		// Token: 0x020007CF RID: 1999
		// (Invoke) Token: 0x06003837 RID: 14391
		private delegate bool get_isNativeTextureDelegate(IntPtr @this);

		// Token: 0x020007D0 RID: 2000
		// (Invoke) Token: 0x06003839 RID: 14393
		private delegate TextureWrapMode get_wrapModeUDelegate(IntPtr @this);

		// Token: 0x020007D1 RID: 2001
		// (Invoke) Token: 0x0600383B RID: 14395
		private delegate TextureWrapMode get_wrapModeVDelegate(IntPtr @this);

		// Token: 0x020007D2 RID: 2002
		// (Invoke) Token: 0x0600383D RID: 14397
		private delegate TextureWrapMode get_wrapModeWDelegate(IntPtr @this);

		// Token: 0x020007D3 RID: 2003
		// (Invoke) Token: 0x0600383F RID: 14399
		private delegate IntPtr GetNativeTexturePtrDelegate(IntPtr @this);

		// Token: 0x020007D4 RID: 2004
		// (Invoke) Token: 0x06003841 RID: 14401
		private delegate void IncrementUpdateCountDelegate(IntPtr @this);

		// Token: 0x020007D5 RID: 2005
		// (Invoke) Token: 0x06003843 RID: 14403
		private delegate TextureColorSpace Internal_GetStoredColorSpaceDelegate(IntPtr @this);

		// Token: 0x020007D6 RID: 2006
		// (Invoke) Token: 0x06003845 RID: 14405
		private delegate ulong get_totalTextureMemoryDelegate();

		// Token: 0x020007D7 RID: 2007
		// (Invoke) Token: 0x06003847 RID: 14407
		private delegate ulong get_desiredTextureMemoryDelegate();

		// Token: 0x020007D8 RID: 2008
		// (Invoke) Token: 0x06003849 RID: 14409
		private delegate ulong get_targetTextureMemoryDelegate();

		// Token: 0x020007D9 RID: 2009
		// (Invoke) Token: 0x0600384B RID: 14411
		private delegate ulong get_currentTextureMemoryDelegate();

		// Token: 0x020007DA RID: 2010
		// (Invoke) Token: 0x0600384D RID: 14413
		private delegate ulong get_nonStreamingTextureMemoryDelegate();

		// Token: 0x020007DB RID: 2011
		// (Invoke) Token: 0x0600384F RID: 14415
		private delegate ulong get_streamingMipmapUploadCountDelegate();

		// Token: 0x020007DC RID: 2012
		// (Invoke) Token: 0x06003851 RID: 14417
		private delegate ulong get_streamingRendererCountDelegate();

		// Token: 0x020007DD RID: 2013
		// (Invoke) Token: 0x06003853 RID: 14419
		private delegate ulong get_streamingTextureCountDelegate();

		// Token: 0x020007DE RID: 2014
		// (Invoke) Token: 0x06003855 RID: 14421
		private delegate ulong get_nonStreamingTextureCountDelegate();

		// Token: 0x020007DF RID: 2015
		// (Invoke) Token: 0x06003857 RID: 14423
		private delegate ulong get_streamingTexturePendingLoadCountDelegate();

		// Token: 0x020007E0 RID: 2016
		// (Invoke) Token: 0x06003859 RID: 14425
		private delegate ulong get_streamingTextureLoadingCountDelegate();

		// Token: 0x020007E1 RID: 2017
		// (Invoke) Token: 0x0600385B RID: 14427
		private delegate void SetStreamingTextureMaterialDebugPropertiesDelegate();

		// Token: 0x020007E2 RID: 2018
		// (Invoke) Token: 0x0600385D RID: 14429
		private delegate bool get_streamingTextureForceLoadAllDelegate();

		// Token: 0x020007E3 RID: 2019
		// (Invoke) Token: 0x0600385F RID: 14431
		private delegate void set_streamingTextureForceLoadAllDelegate(bool value);

		// Token: 0x020007E4 RID: 2020
		// (Invoke) Token: 0x06003861 RID: 14433
		private delegate bool get_streamingTextureDiscardUnusedMipsDelegate();

		// Token: 0x020007E5 RID: 2021
		// (Invoke) Token: 0x06003863 RID: 14435
		private delegate void set_streamingTextureDiscardUnusedMipsDelegate(bool value);

		// Token: 0x020007E6 RID: 2022
		// (Invoke) Token: 0x06003865 RID: 14437
		private delegate bool get_allowThreadedTextureCreationDelegate();

		// Token: 0x020007E7 RID: 2023
		// (Invoke) Token: 0x06003867 RID: 14439
		private delegate void set_allowThreadedTextureCreationDelegate(bool value);
	}
}
