using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x020000DD RID: 221
	public sealed class Texture2D : Texture
	{
		// Token: 0x060010AA RID: 4266 RVA: 0x00049978 File Offset: 0x00047B78
		// Note: this type is marked as 'beforefieldinit'.
		static Texture2D()
		{
			Il2CppClassPointerStore<Texture2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Texture2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture2D>.NativeClassPtr);
			Texture2D.NativeFieldInfoPtr_streamingMipmapsPriorityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, "streamingMipmapsPriorityMin");
			Texture2D.NativeFieldInfoPtr_streamingMipmapsPriorityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, "streamingMipmapsPriorityMax");
			Texture2D.NativeMethodInfoPtr_get_format_Public_get_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664848);
			Texture2D.NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664849);
			Texture2D.NativeMethodInfoPtr_get_blackTexture_Public_Static_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664850);
			Texture2D.NativeMethodInfoPtr_get_normalTexture_Public_Static_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664851);
			Texture2D.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664852);
			Texture2D.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664853);
			Texture2D.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664854);
			Texture2D.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664855);
			Texture2D.NativeMethodInfoPtr_ReinitializeImpl_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664856);
			Texture2D.NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664857);
			Texture2D.NativeMethodInfoPtr_GetPixelImpl_Private_Color_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664858);
			Texture2D.NativeMethodInfoPtr_GetPixelBilinearImpl_Private_Color_Int32_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664859);
			Texture2D.NativeMethodInfoPtr_ReinitializeWithTextureFormatImpl_Private_Boolean_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664860);
			Texture2D.NativeMethodInfoPtr_ReadPixelsImpl_Private_Void_Rect_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664861);
			Texture2D.NativeMethodInfoPtr_SetPixelsImpl_Private_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664862);
			Texture2D.NativeMethodInfoPtr_LoadRawTextureDataImpl_Private_Boolean_IntPtr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664863);
			Texture2D.NativeMethodInfoPtr_LoadRawTextureDataImplArray_Private_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664864);
			Texture2D.NativeMethodInfoPtr_SetPixelDataImpl_Private_Boolean_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664865);
			Texture2D.NativeMethodInfoPtr_GetWritableImageData_Private_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664866);
			Texture2D.NativeMethodInfoPtr_GetRawImageDataSize_Private_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664867);
			Texture2D.NativeMethodInfoPtr_SetAllPixels32_Private_Void_Il2CppStructArray_1_Color32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664868);
			Texture2D.NativeMethodInfoPtr_GetRawTextureData_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664869);
			Texture2D.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664870);
			Texture2D.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664871);
			Texture2D.NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664872);
			Texture2D.NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664873);
			Texture2D.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664874);
			Texture2D.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664875);
			Texture2D.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664876);
			Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664877);
			Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664878);
			Texture2D.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_TextureFormat_Int32_Boolean_IntPtr_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664879);
			Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664880);
			Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664881);
			Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664882);
			Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664883);
			Texture2D.NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664884);
			Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664885);
			Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664886);
			Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664887);
			Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664888);
			Texture2D.NativeMethodInfoPtr_GetPixel_Public_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664889);
			Texture2D.NativeMethodInfoPtr_GetPixelBilinear_Public_Color_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664890);
			Texture2D.NativeMethodInfoPtr_LoadRawTextureData_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664891);
			Texture2D.NativeMethodInfoPtr_LoadRawTextureData_Public_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664892);
			Texture2D.NativeMethodInfoPtr_SetPixelData_Public_Void_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664893);
			Texture2D.NativeMethodInfoPtr_GetPixelData_Public_NativeArray_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664894);
			Texture2D.NativeMethodInfoPtr_GetRawTextureData_Public_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664895);
			Texture2D.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664896);
			Texture2D.NativeMethodInfoPtr_Apply_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664897);
			Texture2D.NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664898);
			Texture2D.NativeMethodInfoPtr_Reinitialize_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664899);
			Texture2D.NativeMethodInfoPtr_Reinitialize_Public_Boolean_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664900);
			Texture2D.NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664901);
			Texture2D.NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664902);
			Texture2D.NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664903);
			Texture2D.NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664904);
			Texture2D.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664905);
			Texture2D.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664906);
			Texture2D.NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664907);
			Texture2D.NativeMethodInfoPtr_GetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664908);
			Texture2D.NativeMethodInfoPtr_GetPixelBilinearImpl_Injected_Private_Void_Int32_Int32_Single_Single_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664909);
			Texture2D.NativeMethodInfoPtr_ReadPixelsImpl_Injected_Private_Void_byref_Rect_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2D>.NativeClassPtr, 100664910);
			Texture2D.get_ignoreMipmapLimitDelegateField = IL2CPP.ResolveICall<Texture2D.get_ignoreMipmapLimitDelegate>("UnityEngine.Texture2D::get_ignoreMipmapLimit");
			Texture2D.set_ignoreMipmapLimitDelegateField = IL2CPP.ResolveICall<Texture2D.set_ignoreMipmapLimitDelegate>("UnityEngine.Texture2D::set_ignoreMipmapLimit");
			Texture2D.get_mipmapLimitGroupDelegateField = IL2CPP.ResolveICall<Texture2D.get_mipmapLimitGroupDelegate>("UnityEngine.Texture2D::get_mipmapLimitGroup");
			Texture2D.get_activeMipmapLimitDelegateField = IL2CPP.ResolveICall<Texture2D.get_activeMipmapLimitDelegate>("UnityEngine.Texture2D::get_activeMipmapLimit");
			Texture2D.get_redTextureDelegateField = IL2CPP.ResolveICall<Texture2D.get_redTextureDelegate>("UnityEngine.Texture2D::get_redTexture");
			Texture2D.get_grayTextureDelegateField = IL2CPP.ResolveICall<Texture2D.get_grayTextureDelegate>("UnityEngine.Texture2D::get_grayTexture");
			Texture2D.get_linearGrayTextureDelegateField = IL2CPP.ResolveICall<Texture2D.get_linearGrayTextureDelegate>("UnityEngine.Texture2D::get_linearGrayTexture");
			Texture2D.CompressDelegateField = IL2CPP.ResolveICall<Texture2D.CompressDelegate>("UnityEngine.Texture2D::Compress");
			Texture2D.get_vtOnlyDelegateField = IL2CPP.ResolveICall<Texture2D.get_vtOnlyDelegate>("UnityEngine.Texture2D::get_vtOnly");
			Texture2D.ReinitializeWithFormatImplDelegateField = IL2CPP.ResolveICall<Texture2D.ReinitializeWithFormatImplDelegate>("UnityEngine.Texture2D::ReinitializeWithFormatImpl");
			Texture2D.SetPixelDataImplArrayDelegateField = IL2CPP.ResolveICall<Texture2D.SetPixelDataImplArrayDelegate>("UnityEngine.Texture2D::SetPixelDataImplArray");
			Texture2D.GenerateAtlasImplDelegateField = IL2CPP.ResolveICall<Texture2D.GenerateAtlasImplDelegate>("UnityEngine.Texture2D::GenerateAtlasImpl");
			Texture2D.get_isPreProcessedDelegateField = IL2CPP.ResolveICall<Texture2D.get_isPreProcessedDelegate>("UnityEngine.Texture2D::get_isPreProcessed");
			Texture2D.get_streamingMipmapsDelegateField = IL2CPP.ResolveICall<Texture2D.get_streamingMipmapsDelegate>("UnityEngine.Texture2D::get_streamingMipmaps");
			Texture2D.get_streamingMipmapsPriorityDelegateField = IL2CPP.ResolveICall<Texture2D.get_streamingMipmapsPriorityDelegate>("UnityEngine.Texture2D::get_streamingMipmapsPriority");
			Texture2D.get_requestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_requestedMipmapLevelDelegate>("UnityEngine.Texture2D::get_requestedMipmapLevel");
			Texture2D.set_requestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.set_requestedMipmapLevelDelegate>("UnityEngine.Texture2D::set_requestedMipmapLevel");
			Texture2D.get_minimumMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_minimumMipmapLevelDelegate>("UnityEngine.Texture2D::get_minimumMipmapLevel");
			Texture2D.set_minimumMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.set_minimumMipmapLevelDelegate>("UnityEngine.Texture2D::set_minimumMipmapLevel");
			Texture2D.get_loadAllMipsDelegateField = IL2CPP.ResolveICall<Texture2D.get_loadAllMipsDelegate>("UnityEngine.Texture2D::get_loadAllMips");
			Texture2D.set_loadAllMipsDelegateField = IL2CPP.ResolveICall<Texture2D.set_loadAllMipsDelegate>("UnityEngine.Texture2D::set_loadAllMips");
			Texture2D.get_calculatedMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_calculatedMipmapLevelDelegate>("UnityEngine.Texture2D::get_calculatedMipmapLevel");
			Texture2D.get_desiredMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_desiredMipmapLevelDelegate>("UnityEngine.Texture2D::get_desiredMipmapLevel");
			Texture2D.get_loadingMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_loadingMipmapLevelDelegate>("UnityEngine.Texture2D::get_loadingMipmapLevel");
			Texture2D.get_loadedMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.get_loadedMipmapLevelDelegate>("UnityEngine.Texture2D::get_loadedMipmapLevel");
			Texture2D.ClearRequestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.ClearRequestedMipmapLevelDelegate>("UnityEngine.Texture2D::ClearRequestedMipmapLevel");
			Texture2D.IsRequestedMipmapLevelLoadedDelegateField = IL2CPP.ResolveICall<Texture2D.IsRequestedMipmapLevelLoadedDelegate>("UnityEngine.Texture2D::IsRequestedMipmapLevelLoaded");
			Texture2D.ClearMinimumMipmapLevelDelegateField = IL2CPP.ResolveICall<Texture2D.ClearMinimumMipmapLevelDelegate>("UnityEngine.Texture2D::ClearMinimumMipmapLevel");
			Texture2D.UpdateExternalTextureDelegateField = IL2CPP.ResolveICall<Texture2D.UpdateExternalTextureDelegate>("UnityEngine.Texture2D::UpdateExternalTexture");
			Texture2D.SetBlockOfPixels32DelegateField = IL2CPP.ResolveICall<Texture2D.SetBlockOfPixels32Delegate>("UnityEngine.Texture2D::SetBlockOfPixels32");
			Texture2D.PackTexturesDelegateField = IL2CPP.ResolveICall<Texture2D.PackTexturesDelegate>("UnityEngine.Texture2D::PackTextures");
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x0004A090 File Offset: 0x00048290
		public unsafe TextureFormat format
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1239803, RefRangeEnd = 1239813, XrefRangeStart = 1239801, XrefRangeEnd = 1239803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_get_format_Public_get_TextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060010AC RID: 4268 RVA: 0x0004A0CC File Offset: 0x000482CC
		public unsafe static Texture2D whiteTexture
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1239815, RefRangeEnd = 1239831, XrefRangeStart = 1239813, XrefRangeEnd = 1239815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x0004A100 File Offset: 0x00048300
		public unsafe static Texture2D blackTexture
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1239833, RefRangeEnd = 1239842, XrefRangeStart = 1239831, XrefRangeEnd = 1239833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_get_blackTexture_Public_Static_get_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060010AE RID: 4270 RVA: 0x0004A134 File Offset: 0x00048334
		public unsafe static Texture2D normalTexture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1239844, RefRangeEnd = 1239845, XrefRangeStart = 1239842, XrefRangeEnd = 1239844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_get_normalTexture_Public_Static_get_Texture2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0004A168 File Offset: 0x00048368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239845, XrefRangeEnd = 1239847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorSpace;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mipmapLimitGroupName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0004A220 File Offset: 0x00048420
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239849, RefRangeEnd = 1239851, XrefRangeStart = 1239847, XrefRangeEnd = 1239849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorSpace;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mipmapLimitGroupName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x0004A2CC File Offset: 0x000484CC
		public unsafe override bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239851, XrefRangeEnd = 1239853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0004A308 File Offset: 0x00048508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239853, XrefRangeEnd = 1239855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref updateMipmaps;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref makeNoLongerReadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0004A354 File Offset: 0x00048554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239855, XrefRangeEnd = 1239857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReinitializeImpl(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ReinitializeImpl_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0004A3AC File Offset: 0x000485AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239857, XrefRangeEnd = 1239859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixelImpl(int image, int mip, int x, int y, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref image;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0004A424 File Offset: 0x00048624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239859, XrefRangeEnd = 1239861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetPixelImpl(int image, int mip, int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref image;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixelImpl_Private_Color_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0004A498 File Offset: 0x00048698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239861, XrefRangeEnd = 1239863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetPixelBilinearImpl(int image, int mip, float u, float v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref image;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixelBilinearImpl_Private_Color_Int32_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0004A50C File Offset: 0x0004870C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239863, XrefRangeEnd = 1239865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasMipMap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ReinitializeWithTextureFormatImpl_Private_Boolean_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x0004A580 File Offset: 0x00048780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239865, XrefRangeEnd = 1239867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destY;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recalculateMipMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ReadPixelsImpl_Private_Void_Rect_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0004A5E8 File Offset: 0x000487E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239867, XrefRangeEnd = 1239869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixelsImpl(int x, int y, int w, int h, Il2CppStructArray<Color> pixel, int miplevel, int frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pixel);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixelsImpl_Private_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0004A680 File Offset: 0x00048880
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239871, RefRangeEnd = 1239872, XrefRangeStart = 1239869, XrefRangeEnd = 1239871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LoadRawTextureDataImpl(IntPtr data, ulong size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref data;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_LoadRawTextureDataImpl_Private_Boolean_IntPtr_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0004A6D8 File Offset: 0x000488D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239872, XrefRangeEnd = 1239874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LoadRawTextureDataImplArray(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_LoadRawTextureDataImplArray_Private_Boolean_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0004A728 File Offset: 0x00048928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239876, RefRangeEnd = 1239877, XrefRangeStart = 1239874, XrefRangeEnd = 1239876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetPixelDataImpl(IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref data;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataArraySize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceDataStartIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixelDataImpl_Private_Boolean_IntPtr_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0004A7AC File Offset: 0x000489AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1239879, RefRangeEnd = 1239884, XrefRangeStart = 1239877, XrefRangeEnd = 1239879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetWritableImageData(int frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref frame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetWritableImageData_Private_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0004A7F8 File Offset: 0x000489F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239886, RefRangeEnd = 1239887, XrefRangeStart = 1239884, XrefRangeEnd = 1239886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong GetRawImageDataSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetRawImageDataSize_Private_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0004A834 File Offset: 0x00048A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239887, XrefRangeEnd = 1239889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAllPixels32(Il2CppStructArray<Color32> colors, int miplevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetAllPixels32_Private_Void_Il2CppStructArray_1_Color32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x0004A884 File Offset: 0x00048A84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239891, RefRangeEnd = 1239892, XrefRangeStart = 1239889, XrefRangeEnd = 1239891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetRawTextureData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetRawTextureData_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0004A8C4 File Offset: 0x00048AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239892, XrefRangeEnd = 1239894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Color> GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr3) : null;
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x0004A948 File Offset: 0x00048B48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239896, RefRangeEnd = 1239897, XrefRangeStart = 1239894, XrefRangeEnd = 1239896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Color> GetPixels(int x, int y, int blockWidth, int blockHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr3) : null;
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x0004A9C0 File Offset: 0x00048BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239897, XrefRangeEnd = 1239899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Color32> GetPixels32(int miplevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref miplevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr3) : null;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x0004AA0C File Offset: 0x00048C0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1239901, RefRangeEnd = 1239904, XrefRangeStart = 1239899, XrefRangeEnd = 1239901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Color32> GetPixels32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr3) : null;
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x0004AA4C File Offset: 0x00048C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239904, XrefRangeEnd = 1239907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(TextureFormat format, int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0004AAB4 File Offset: 0x00048CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239907, XrefRangeEnd = 1239914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x0004AB1C File Offset: 0x00048D1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239935, RefRangeEnd = 1239937, XrefRangeStart = 1239914, XrefRangeEnd = 1239935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount, IntPtr nativeTex, string mipmapLimitGroupName) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mipmapLimitGroupName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_IntPtr_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0004ABBC File Offset: 0x00048DBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239943, RefRangeEnd = 1239944, XrefRangeStart = 1239937, XrefRangeEnd = 1239943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D(int width, int height, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0004AC30 File Offset: 0x00048E30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1239949, RefRangeEnd = 1239954, XrefRangeStart = 1239944, XrefRangeEnd = 1239949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0004ACA4 File Offset: 0x00048EA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1239974, RefRangeEnd = 1239978, XrefRangeStart = 1239954, XrefRangeEnd = 1239974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createUninitialized;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreMipmapLimit;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mipmapLimitGroupName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_TextureFormat_Int32_Boolean_IntPtr_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0004AD64 File Offset: 0x00048F64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239979, RefRangeEnd = 1239981, XrefRangeStart = 1239978, XrefRangeEnd = 1239979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0004ADE4 File Offset: 0x00048FE4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1239987, RefRangeEnd = 1239996, XrefRangeStart = 1239981, XrefRangeEnd = 1239987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x0004AE64 File Offset: 0x00049064
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1240002, RefRangeEnd = 1240026, XrefRangeStart = 1239996, XrefRangeEnd = 1240002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0004AED8 File Offset: 0x000490D8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1240031, RefRangeEnd = 1240041, XrefRangeStart = 1240026, XrefRangeEnd = 1240031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D(int width, int height) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2D>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0004AF30 File Offset: 0x00049130
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1240043, RefRangeEnd = 1240065, XrefRangeStart = 1240041, XrefRangeEnd = 1240043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixel(int x, int y, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0004AF8C File Offset: 0x0004918C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240065, XrefRangeEnd = 1240070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixels(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color> colors, int miplevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colors);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0004B018 File Offset: 0x00049218
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240072, RefRangeEnd = 1240074, XrefRangeStart = 1240070, XrefRangeEnd = 1240072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixels(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color> colors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x0004B094 File Offset: 0x00049294
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1240076, RefRangeEnd = 1240077, XrefRangeStart = 1240074, XrefRangeEnd = 1240076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixels(Il2CppStructArray<Color> colors, int miplevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x0004B0E4 File Offset: 0x000492E4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1240079, RefRangeEnd = 1240096, XrefRangeStart = 1240077, XrefRangeEnd = 1240079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixels(Il2CppStructArray<Color> colors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0004B128 File Offset: 0x00049328
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1240098, RefRangeEnd = 1240105, XrefRangeStart = 1240096, XrefRangeEnd = 1240098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetPixel(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixel_Public_Color_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0004B180 File Offset: 0x00049380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1240107, RefRangeEnd = 1240108, XrefRangeStart = 1240105, XrefRangeEnd = 1240107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetPixelBilinear(float u, float v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref u;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixelBilinear_Public_Color_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0004B1D8 File Offset: 0x000493D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240117, RefRangeEnd = 1240119, XrefRangeStart = 1240108, XrefRangeEnd = 1240117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadRawTextureData(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_LoadRawTextureData_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0004B21C File Offset: 0x0004941C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1240123, RefRangeEnd = 1240124, XrefRangeStart = 1240119, XrefRangeEnd = 1240123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadRawTextureData<T>(Unity.Collections.NativeArray<T> data) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.MethodInfoStoreGeneric_LoadRawTextureData_Public_Void_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0004B264 File Offset: 0x00049464
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240128, RefRangeEnd = 1240130, XrefRangeStart = 1240124, XrefRangeEnd = 1240128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, int sourceDataStartIndex = 0) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceDataStartIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.MethodInfoStoreGeneric_SetPixelData_Public_Void_NativeArray_1_T_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0004B2C8 File Offset: 0x000494C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240141, RefRangeEnd = 1240143, XrefRangeStart = 1240130, XrefRangeEnd = 1240141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mipLevel;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Texture2D.MethodInfoStoreGeneric_GetPixelData_Public_NativeArray_1_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Unity.Collections.NativeArray<T>(pointer);
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0004B30C File Offset: 0x0004950C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1240148, RefRangeEnd = 1240151, XrefRangeStart = 1240143, XrefRangeEnd = 1240148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unity.Collections.NativeArray<T> GetRawTextureData<T>() where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Texture2D.MethodInfoStoreGeneric_GetRawTextureData_Public_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Unity.Collections.NativeArray<T>(pointer);
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0004B344 File Offset: 0x00049544
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1240156, RefRangeEnd = 1240170, XrefRangeStart = 1240151, XrefRangeEnd = 1240156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(bool updateMipmaps, bool makeNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref updateMipmaps;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref makeNoLongerReadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0004B390 File Offset: 0x00049590
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240171, RefRangeEnd = 1240173, XrefRangeStart = 1240170, XrefRangeEnd = 1240171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(bool updateMipmaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref updateMipmaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Apply_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0004B3D0 File Offset: 0x000495D0
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 1240174, RefRangeEnd = 1240217, XrefRangeStart = 1240173, XrefRangeEnd = 1240174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0004B404 File Offset: 0x00049604
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1240222, RefRangeEnd = 1240231, XrefRangeStart = 1240217, XrefRangeEnd = 1240222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Reinitialize(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Reinitialize_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0004B45C File Offset: 0x0004965C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240233, RefRangeEnd = 1240235, XrefRangeStart = 1240231, XrefRangeEnd = 1240233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasMipMap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_Reinitialize_Public_Boolean_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x0004B4D0 File Offset: 0x000496D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1240237, RefRangeEnd = 1240240, XrefRangeStart = 1240235, XrefRangeEnd = 1240237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destY;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recalculateMipMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0004B538 File Offset: 0x00049738
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1240242, RefRangeEnd = 1240246, XrefRangeStart = 1240240, XrefRangeEnd = 1240242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadPixels(Rect source, int destX, int destY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0004B594 File Offset: 0x00049794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixels32(Il2CppStructArray<Color32> colors, int miplevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0004B5E4 File Offset: 0x000497E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1240248, RefRangeEnd = 1240253, XrefRangeStart = 1240246, XrefRangeEnd = 1240248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixels32(Il2CppStructArray<Color32> colors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0004B628 File Offset: 0x00049828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240253, XrefRangeEnd = 1240255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Color> GetPixels(int miplevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref miplevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr3) : null;
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0004B674 File Offset: 0x00049874
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1240257, RefRangeEnd = 1240260, XrefRangeStart = 1240255, XrefRangeEnd = 1240257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Color> GetPixels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr3) : null;
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x0004B6B4 File Offset: 0x000498B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240260, XrefRangeEnd = 1240262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref image;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x0004B72C File Offset: 0x0004992C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240262, XrefRangeEnd = 1240264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPixelImpl_Injected(int image, int mip, int x, int y, out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref image;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x0004B7A4 File Offset: 0x000499A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240264, XrefRangeEnd = 1240266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref image;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_GetPixelBilinearImpl_Injected_Private_Void_Int32_Int32_Single_Single_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x0004B81C File Offset: 0x00049A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240266, XrefRangeEnd = 1240268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &source;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destY;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recalculateMipMaps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2D.NativeMethodInfoPtr_ReadPixelsImpl_Injected_Private_Void_byref_Rect_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x00009AF5 File Offset: 0x00007CF5
		public Texture2D(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x0004B884 File Offset: 0x00049A84
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x00009AFE File Offset: 0x00007CFE
		public unsafe static int streamingMipmapsPriorityMin
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Texture2D.NativeFieldInfoPtr_streamingMipmapsPriorityMin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Texture2D.NativeFieldInfoPtr_streamingMipmapsPriorityMin, (void*)(&value));
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x0004B8A0 File Offset: 0x00049AA0
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x00009B0C File Offset: 0x00007D0C
		public unsafe static int streamingMipmapsPriorityMax
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Texture2D.NativeFieldInfoPtr_streamingMipmapsPriorityMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Texture2D.NativeFieldInfoPtr_streamingMipmapsPriorityMax, (void*)(&value));
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x00009B1A File Offset: 0x00007D1A
		// (set) Token: 0x060010F0 RID: 4336 RVA: 0x00009B2C File Offset: 0x00007D2C
		public bool ignoreMipmapLimit
		{
			get
			{
				return Texture2D.get_ignoreMipmapLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture2D.set_ignoreMipmapLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x0004B8BC File Offset: 0x00049ABC
		public string mipmapLimitGroup
		{
			get
			{
				IntPtr intPtr = Texture2D.get_mipmapLimitGroupDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x00009B3F File Offset: 0x00007D3F
		public int activeMipmapLimit
		{
			get
			{
				return Texture2D.get_activeMipmapLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x0004B8E0 File Offset: 0x00049AE0
		public static Texture2D redTexture
		{
			get
			{
				IntPtr intPtr = Texture2D.get_redTextureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x0004B908 File Offset: 0x00049B08
		public static Texture2D grayTexture
		{
			get
			{
				IntPtr intPtr = Texture2D.get_grayTextureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x0004B930 File Offset: 0x00049B30
		public static Texture2D linearGrayTexture
		{
			get
			{
				IntPtr intPtr = Texture2D.get_linearGrayTextureDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00009B51 File Offset: 0x00007D51
		public void Compress(bool highQuality)
		{
			Texture2D.CompressDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), highQuality);
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x00009B64 File Offset: 0x00007D64
		public bool vtOnly
		{
			get
			{
				return Texture2D.get_vtOnlyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00009B76 File Offset: 0x00007D76
		public bool ReinitializeWithFormatImpl(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap)
		{
			return Texture2D.ReinitializeWithFormatImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), width, height, format, hasMipMap);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00009B8D File Offset: 0x00007D8D
		public bool SetPixelDataImplArray(Array data, int mipLevel, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Texture2D.SetPixelDataImplArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), mipLevel, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00009BAB File Offset: 0x00007DAB
		public static void GenerateAtlasImpl(Il2CppStructArray<Vector2> sizes, int padding, int atlasSize, [Out] Il2CppStructArray<Rect> rect)
		{
			Texture2D.GenerateAtlasImplDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sizes), padding, atlasSize, IL2CPP.Il2CppObjectBaseToPtr(rect));
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x00009BC5 File Offset: 0x00007DC5
		public bool isPreProcessed
		{
			get
			{
				return Texture2D.get_isPreProcessedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x00009BD7 File Offset: 0x00007DD7
		public bool streamingMipmaps
		{
			get
			{
				return Texture2D.get_streamingMipmapsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x00009BE9 File Offset: 0x00007DE9
		public int streamingMipmapsPriority
		{
			get
			{
				return Texture2D.get_streamingMipmapsPriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x00009BFB File Offset: 0x00007DFB
		// (set) Token: 0x060010FF RID: 4351 RVA: 0x00009C0D File Offset: 0x00007E0D
		public int requestedMipmapLevel
		{
			get
			{
				return Texture2D.get_requestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture2D.set_requestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x00009C20 File Offset: 0x00007E20
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x00009C32 File Offset: 0x00007E32
		public int minimumMipmapLevel
		{
			get
			{
				return Texture2D.get_minimumMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture2D.set_minimumMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x00009C45 File Offset: 0x00007E45
		// (set) Token: 0x06001103 RID: 4355 RVA: 0x00009C57 File Offset: 0x00007E57
		public bool loadAllMips
		{
			get
			{
				return Texture2D.get_loadAllMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Texture2D.set_loadAllMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x00009C6A File Offset: 0x00007E6A
		public int calculatedMipmapLevel
		{
			get
			{
				return Texture2D.get_calculatedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x00009C7C File Offset: 0x00007E7C
		public int desiredMipmapLevel
		{
			get
			{
				return Texture2D.get_desiredMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x00009C8E File Offset: 0x00007E8E
		public int loadingMipmapLevel
		{
			get
			{
				return Texture2D.get_loadingMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x00009CA0 File Offset: 0x00007EA0
		public int loadedMipmapLevel
		{
			get
			{
				return Texture2D.get_loadedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00009CB2 File Offset: 0x00007EB2
		public void ClearRequestedMipmapLevel()
		{
			Texture2D.ClearRequestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00009CC4 File Offset: 0x00007EC4
		public bool IsRequestedMipmapLevelLoaded()
		{
			return Texture2D.IsRequestedMipmapLevelLoadedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00009CD6 File Offset: 0x00007ED6
		public void ClearMinimumMipmapLevel()
		{
			Texture2D.ClearMinimumMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00009CE8 File Offset: 0x00007EE8
		public void UpdateExternalTexture(IntPtr nativeTex)
		{
			Texture2D.UpdateExternalTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nativeTex);
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00009CFB File Offset: 0x00007EFB
		public void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color32> colors, int miplevel)
		{
			Texture2D.SetBlockOfPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), x, y, blockWidth, blockHeight, IL2CPP.Il2CppObjectBaseToPtr(colors), miplevel);
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x0004B958 File Offset: 0x00049B58
		public Il2CppStructArray<Rect> PackTextures(Il2CppReferenceArray<Texture2D> textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable)
		{
			IntPtr intPtr = Texture2D.PackTexturesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(textures), padding, maximumAtlasSize, makeNoLongerReadable);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Rect>>(intPtr2) : null;
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x0004B990 File Offset: 0x00049B90
		public Il2CppStructArray<Rect> PackTextures(Il2CppReferenceArray<Texture2D> textures, int padding, int maximumAtlasSize)
		{
			return this.PackTextures(textures, padding, maximumAtlasSize, false);
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x0004B9AC File Offset: 0x00049BAC
		public Il2CppStructArray<Rect> PackTextures(Il2CppReferenceArray<Texture2D> textures, int padding)
		{
			return this.PackTextures(textures, padding, 2048);
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x0004B9CC File Offset: 0x00049BCC
		public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex)
		{
			bool flag = nativeTex == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("nativeTex can not be null");
			}
			return new Texture2D(width, height, format, mipChain ? -1 : 1, linear, nativeTex, false, false, null);
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0004BA10 File Offset: 0x00049C10
		public void SetPixel(int x, int y, Color color, int mipLevel)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			this.SetPixelImpl(0, mipLevel, x, y, color);
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0004BA40 File Offset: 0x00049C40
		public Color GetPixel(int x, int y, int mipLevel)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.GetPixelImpl(0, mipLevel, x, y);
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0004BA74 File Offset: 0x00049C74
		public Color GetPixelBilinear(float u, float v, int mipLevel)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.GetPixelBilinearImpl(0, mipLevel, u, v);
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0004BAA8 File Offset: 0x00049CA8
		public void LoadRawTextureData(IntPtr data, int size)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag2 = data == IntPtr.Zero || size == 0;
			if (flag2)
			{
				Debug.LogError("No texture data provided to LoadRawTextureData", this);
			}
			else
			{
				bool flag3 = !this.LoadRawTextureDataImpl(data, (ulong)((long)size));
				if (flag3)
				{
					throw new UnityException("LoadRawTextureData: not enough data provided (will result in overread).");
				}
			}
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0004BB10 File Offset: 0x00049D10
		public void SetPixelData<T>(Il2CppArrayBase<T> data, int mipLevel, [Optional] int sourceDataStartIndex)
		{
			bool flag = sourceDataStartIndex < 0;
			if (flag)
			{
				throw new UnityException("SetPixelData: sourceDataStartIndex cannot be less than 0.");
			}
			bool flag2 = !this.isReadable;
			if (flag2)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag3 = data == null || data.Length == 0;
			if (flag3)
			{
				throw new UnityException("No texture data provided to SetPixelData.");
			}
			this.SetPixelDataImplArray(data, mipLevel, Marshal.SizeOf<T>(data[0]), data.Length, sourceDataStartIndex);
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0004BB84 File Offset: 0x00049D84
		public bool Reinitialize(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.ReinitializeWithFormatImpl(width, height, format, hasMipMap);
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x0004BBB8 File Offset: 0x00049DB8
		public bool Resize(int width, int height)
		{
			return this.Reinitialize(width, height);
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0004BBD4 File Offset: 0x00049DD4
		public bool Resize(int width, int height, TextureFormat format, bool hasMipMap)
		{
			return this.Reinitialize(width, height, format, hasMipMap);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0004BBF4 File Offset: 0x00049DF4
		public bool Resize(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap)
		{
			return this.Reinitialize(width, height, format, hasMipMap);
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0004BC14 File Offset: 0x00049E14
		public static bool GenerateAtlas(Il2CppStructArray<Vector2> sizes, int padding, int atlasSize, List<Rect> results)
		{
			bool flag = sizes == null;
			if (flag)
			{
				throw new ArgumentException("sizes array can not be null");
			}
			bool flag2 = results == null;
			if (flag2)
			{
				throw new ArgumentException("results list cannot be null");
			}
			bool flag3 = padding < 0;
			if (flag3)
			{
				throw new ArgumentException("padding can not be negative");
			}
			bool flag4 = atlasSize <= 0;
			if (flag4)
			{
				throw new ArgumentException("atlas size must be positive");
			}
			results.Clear();
			bool flag5 = sizes.Length == 0;
			bool result;
			if (flag5)
			{
				result = true;
			}
			else
			{
				NoAllocHelpers.EnsureListElemCount<Rect>(results, sizes.Length);
				Texture2D.GenerateAtlasImpl(sizes, padding, atlasSize, NoAllocHelpers.ExtractArrayFromListT<Rect>(results));
				result = (results.Count != 0);
			}
			return result;
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00009D1B File Offset: 0x00007F1B
		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color32> colors, int miplevel)
		{
			this.SetBlockOfPixels32(x, y, blockWidth, blockHeight, colors, miplevel);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00009D2E File Offset: 0x00007F2E
		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Il2CppStructArray<Color32> colors)
		{
			this.SetPixels32(x, y, blockWidth, blockHeight, colors, 0);
		}

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeFieldInfoPtr_streamingMipmapsPriorityMin;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeFieldInfoPtr_streamingMipmapsPriorityMax;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr_get_format_Public_get_TextureFormat_0;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeMethodInfoPtr_get_whiteTexture_Public_Static_get_Texture2D_0;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeMethodInfoPtr_get_blackTexture_Public_Static_get_Texture2D_0;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeMethodInfoPtr_get_normalTexture_Public_Static_get_Texture2D_0;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_String_0;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_String_0;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr_ReinitializeImpl_Private_Boolean_Int32_Int32_0;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelImpl_Private_Color_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelBilinearImpl_Private_Color_Int32_Int32_Single_Single_0;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeMethodInfoPtr_ReinitializeWithTextureFormatImpl_Private_Boolean_Int32_Int32_TextureFormat_Boolean_0;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeMethodInfoPtr_ReadPixelsImpl_Private_Void_Rect_Int32_Int32_Boolean_0;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelsImpl_Private_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_Int32_0;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeMethodInfoPtr_LoadRawTextureDataImpl_Private_Boolean_IntPtr_UInt64_0;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr_LoadRawTextureDataImplArray_Private_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelDataImpl_Private_Boolean_IntPtr_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeMethodInfoPtr_GetWritableImageData_Private_IntPtr_Int32_0;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeMethodInfoPtr_GetRawImageDataSize_Private_UInt64_0;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeMethodInfoPtr_SetAllPixels32_Private_Void_Il2CppStructArray_1_Color32_Int32_0;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr_GetRawTextureData_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_Int32_0;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeMethodInfoPtr_GetPixels32_Public_Il2CppStructArray_1_Color32_0;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0;

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_Int32_0;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_IntPtr_String_0;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_DefaultFormat_TextureCreationFlags_0;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_TextureFormat_Int32_Boolean_IntPtr_Boolean_Boolean_String_0;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Int32_Boolean_0;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_Boolean_0;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TextureFormat_Boolean_0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_SetPixel_Public_Void_Int32_Int32_Color_0;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_Int32_0;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Int32_Int32_Int32_Int32_Il2CppStructArray_1_Color_0;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr_GetPixel_Public_Color_Int32_Int32_0;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelBilinear_Public_Color_Single_Single_0;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeMethodInfoPtr_LoadRawTextureData_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeMethodInfoPtr_LoadRawTextureData_Public_Void_NativeArray_1_T_0;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelData_Public_Void_NativeArray_1_T_Int32_Int32_0;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelData_Public_NativeArray_1_T_Int32_0;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeMethodInfoPtr_GetRawTextureData_Public_NativeArray_1_T_0;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_0;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeMethodInfoPtr_Reinitialize_Public_Boolean_Int32_Int32_0;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeMethodInfoPtr_Reinitialize_Public_Boolean_Int32_Int32_TextureFormat_Boolean_0;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_Boolean_0;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeMethodInfoPtr_ReadPixels_Public_Void_Rect_Int32_Int32_0;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_Int32_0;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeMethodInfoPtr_SetPixels32_Public_Void_Il2CppStructArray_1_Color32_0;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_0;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_0;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelBilinearImpl_Injected_Private_Void_Int32_Int32_Single_Single_byref_Color_0;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeMethodInfoPtr_ReadPixelsImpl_Injected_Private_Void_byref_Rect_Int32_Int32_Boolean_0;

		// Token: 0x04000DA1 RID: 3489
		private static readonly Texture2D.get_ignoreMipmapLimitDelegate get_ignoreMipmapLimitDelegateField;

		// Token: 0x04000DA2 RID: 3490
		private static readonly Texture2D.set_ignoreMipmapLimitDelegate set_ignoreMipmapLimitDelegateField;

		// Token: 0x04000DA3 RID: 3491
		private static readonly Texture2D.get_mipmapLimitGroupDelegate get_mipmapLimitGroupDelegateField;

		// Token: 0x04000DA4 RID: 3492
		private static readonly Texture2D.get_activeMipmapLimitDelegate get_activeMipmapLimitDelegateField;

		// Token: 0x04000DA5 RID: 3493
		private static readonly Texture2D.get_redTextureDelegate get_redTextureDelegateField;

		// Token: 0x04000DA6 RID: 3494
		private static readonly Texture2D.get_grayTextureDelegate get_grayTextureDelegateField;

		// Token: 0x04000DA7 RID: 3495
		private static readonly Texture2D.get_linearGrayTextureDelegate get_linearGrayTextureDelegateField;

		// Token: 0x04000DA8 RID: 3496
		private static readonly Texture2D.CompressDelegate CompressDelegateField;

		// Token: 0x04000DA9 RID: 3497
		private static readonly Texture2D.get_vtOnlyDelegate get_vtOnlyDelegateField;

		// Token: 0x04000DAA RID: 3498
		private static readonly Texture2D.ReinitializeWithFormatImplDelegate ReinitializeWithFormatImplDelegateField;

		// Token: 0x04000DAB RID: 3499
		private static readonly Texture2D.SetPixelDataImplArrayDelegate SetPixelDataImplArrayDelegateField;

		// Token: 0x04000DAC RID: 3500
		private static readonly Texture2D.GenerateAtlasImplDelegate GenerateAtlasImplDelegateField;

		// Token: 0x04000DAD RID: 3501
		private static readonly Texture2D.get_isPreProcessedDelegate get_isPreProcessedDelegateField;

		// Token: 0x04000DAE RID: 3502
		private static readonly Texture2D.get_streamingMipmapsDelegate get_streamingMipmapsDelegateField;

		// Token: 0x04000DAF RID: 3503
		private static readonly Texture2D.get_streamingMipmapsPriorityDelegate get_streamingMipmapsPriorityDelegateField;

		// Token: 0x04000DB0 RID: 3504
		private static readonly Texture2D.get_requestedMipmapLevelDelegate get_requestedMipmapLevelDelegateField;

		// Token: 0x04000DB1 RID: 3505
		private static readonly Texture2D.set_requestedMipmapLevelDelegate set_requestedMipmapLevelDelegateField;

		// Token: 0x04000DB2 RID: 3506
		private static readonly Texture2D.get_minimumMipmapLevelDelegate get_minimumMipmapLevelDelegateField;

		// Token: 0x04000DB3 RID: 3507
		private static readonly Texture2D.set_minimumMipmapLevelDelegate set_minimumMipmapLevelDelegateField;

		// Token: 0x04000DB4 RID: 3508
		private static readonly Texture2D.get_loadAllMipsDelegate get_loadAllMipsDelegateField;

		// Token: 0x04000DB5 RID: 3509
		private static readonly Texture2D.set_loadAllMipsDelegate set_loadAllMipsDelegateField;

		// Token: 0x04000DB6 RID: 3510
		private static readonly Texture2D.get_calculatedMipmapLevelDelegate get_calculatedMipmapLevelDelegateField;

		// Token: 0x04000DB7 RID: 3511
		private static readonly Texture2D.get_desiredMipmapLevelDelegate get_desiredMipmapLevelDelegateField;

		// Token: 0x04000DB8 RID: 3512
		private static readonly Texture2D.get_loadingMipmapLevelDelegate get_loadingMipmapLevelDelegateField;

		// Token: 0x04000DB9 RID: 3513
		private static readonly Texture2D.get_loadedMipmapLevelDelegate get_loadedMipmapLevelDelegateField;

		// Token: 0x04000DBA RID: 3514
		private static readonly Texture2D.ClearRequestedMipmapLevelDelegate ClearRequestedMipmapLevelDelegateField;

		// Token: 0x04000DBB RID: 3515
		private static readonly Texture2D.IsRequestedMipmapLevelLoadedDelegate IsRequestedMipmapLevelLoadedDelegateField;

		// Token: 0x04000DBC RID: 3516
		private static readonly Texture2D.ClearMinimumMipmapLevelDelegate ClearMinimumMipmapLevelDelegateField;

		// Token: 0x04000DBD RID: 3517
		private static readonly Texture2D.UpdateExternalTextureDelegate UpdateExternalTextureDelegateField;

		// Token: 0x04000DBE RID: 3518
		private static readonly Texture2D.SetBlockOfPixels32Delegate SetBlockOfPixels32DelegateField;

		// Token: 0x04000DBF RID: 3519
		private static readonly Texture2D.PackTexturesDelegate PackTexturesDelegateField;

		// Token: 0x020007E8 RID: 2024
		private sealed class MethodInfoStoreGeneric_LoadRawTextureData_Public_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x04002ACA RID: 10954
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Texture2D.NativeMethodInfoPtr_LoadRawTextureData_Public_Void_NativeArray_1_T_0, Il2CppClassPointerStore<Texture2D>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020007E9 RID: 2025
		private sealed class MethodInfoStoreGeneric_SetPixelData_Public_Void_NativeArray_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04002ACB RID: 10955
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Texture2D.NativeMethodInfoPtr_SetPixelData_Public_Void_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<Texture2D>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020007EA RID: 2026
		private sealed class MethodInfoStoreGeneric_GetPixelData_Public_NativeArray_1_T_Int32_0<T>
		{
			// Token: 0x04002ACC RID: 10956
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Texture2D.NativeMethodInfoPtr_GetPixelData_Public_NativeArray_1_T_Int32_0, Il2CppClassPointerStore<Texture2D>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020007EB RID: 2027
		private sealed class MethodInfoStoreGeneric_GetRawTextureData_Public_NativeArray_1_T_0<T>
		{
			// Token: 0x04002ACD RID: 10957
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Texture2D.NativeMethodInfoPtr_GetRawTextureData_Public_NativeArray_1_T_0, Il2CppClassPointerStore<Texture2D>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020007EC RID: 2028
		public enum EXRFlags
		{
			// Token: 0x04002ACF RID: 10959
			None,
			// Token: 0x04002AD0 RID: 10960
			OutputAsFloat,
			// Token: 0x04002AD1 RID: 10961
			CompressZIP,
			// Token: 0x04002AD2 RID: 10962
			CompressRLE = 4,
			// Token: 0x04002AD3 RID: 10963
			CompressPIZ = 8
		}

		// Token: 0x020007ED RID: 2029
		// (Invoke) Token: 0x0600386D RID: 14445
		private delegate bool get_ignoreMipmapLimitDelegate(IntPtr @this);

		// Token: 0x020007EE RID: 2030
		// (Invoke) Token: 0x0600386F RID: 14447
		private delegate void set_ignoreMipmapLimitDelegate(IntPtr @this, bool value);

		// Token: 0x020007EF RID: 2031
		// (Invoke) Token: 0x06003871 RID: 14449
		private delegate IntPtr get_mipmapLimitGroupDelegate(IntPtr @this);

		// Token: 0x020007F0 RID: 2032
		// (Invoke) Token: 0x06003873 RID: 14451
		private delegate int get_activeMipmapLimitDelegate(IntPtr @this);

		// Token: 0x020007F1 RID: 2033
		// (Invoke) Token: 0x06003875 RID: 14453
		private delegate IntPtr get_redTextureDelegate();

		// Token: 0x020007F2 RID: 2034
		// (Invoke) Token: 0x06003877 RID: 14455
		private delegate IntPtr get_grayTextureDelegate();

		// Token: 0x020007F3 RID: 2035
		// (Invoke) Token: 0x06003879 RID: 14457
		private delegate IntPtr get_linearGrayTextureDelegate();

		// Token: 0x020007F4 RID: 2036
		// (Invoke) Token: 0x0600387B RID: 14459
		private delegate void CompressDelegate(IntPtr @this, bool highQuality);

		// Token: 0x020007F5 RID: 2037
		// (Invoke) Token: 0x0600387D RID: 14461
		private delegate bool get_vtOnlyDelegate(IntPtr @this);

		// Token: 0x020007F6 RID: 2038
		// (Invoke) Token: 0x0600387F RID: 14463
		private delegate bool ReinitializeWithFormatImplDelegate(IntPtr @this, int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap);

		// Token: 0x020007F7 RID: 2039
		// (Invoke) Token: 0x06003881 RID: 14465
		private delegate bool SetPixelDataImplArrayDelegate(IntPtr @this, IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x020007F8 RID: 2040
		// (Invoke) Token: 0x06003883 RID: 14467
		private delegate void GenerateAtlasImplDelegate(IntPtr sizes, int padding, int atlasSize, [Out] IntPtr rect);

		// Token: 0x020007F9 RID: 2041
		// (Invoke) Token: 0x06003885 RID: 14469
		private delegate bool get_isPreProcessedDelegate(IntPtr @this);

		// Token: 0x020007FA RID: 2042
		// (Invoke) Token: 0x06003887 RID: 14471
		private delegate bool get_streamingMipmapsDelegate(IntPtr @this);

		// Token: 0x020007FB RID: 2043
		// (Invoke) Token: 0x06003889 RID: 14473
		private delegate int get_streamingMipmapsPriorityDelegate(IntPtr @this);

		// Token: 0x020007FC RID: 2044
		// (Invoke) Token: 0x0600388B RID: 14475
		private delegate int get_requestedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020007FD RID: 2045
		// (Invoke) Token: 0x0600388D RID: 14477
		private delegate void set_requestedMipmapLevelDelegate(IntPtr @this, int value);

		// Token: 0x020007FE RID: 2046
		// (Invoke) Token: 0x0600388F RID: 14479
		private delegate int get_minimumMipmapLevelDelegate(IntPtr @this);

		// Token: 0x020007FF RID: 2047
		// (Invoke) Token: 0x06003891 RID: 14481
		private delegate void set_minimumMipmapLevelDelegate(IntPtr @this, int value);

		// Token: 0x02000800 RID: 2048
		// (Invoke) Token: 0x06003893 RID: 14483
		private delegate bool get_loadAllMipsDelegate(IntPtr @this);

		// Token: 0x02000801 RID: 2049
		// (Invoke) Token: 0x06003895 RID: 14485
		private delegate void set_loadAllMipsDelegate(IntPtr @this, bool value);

		// Token: 0x02000802 RID: 2050
		// (Invoke) Token: 0x06003897 RID: 14487
		private delegate int get_calculatedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x02000803 RID: 2051
		// (Invoke) Token: 0x06003899 RID: 14489
		private delegate int get_desiredMipmapLevelDelegate(IntPtr @this);

		// Token: 0x02000804 RID: 2052
		// (Invoke) Token: 0x0600389B RID: 14491
		private delegate int get_loadingMipmapLevelDelegate(IntPtr @this);

		// Token: 0x02000805 RID: 2053
		// (Invoke) Token: 0x0600389D RID: 14493
		private delegate int get_loadedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x02000806 RID: 2054
		// (Invoke) Token: 0x0600389F RID: 14495
		private delegate void ClearRequestedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x02000807 RID: 2055
		// (Invoke) Token: 0x060038A1 RID: 14497
		private delegate bool IsRequestedMipmapLevelLoadedDelegate(IntPtr @this);

		// Token: 0x02000808 RID: 2056
		// (Invoke) Token: 0x060038A3 RID: 14499
		private delegate void ClearMinimumMipmapLevelDelegate(IntPtr @this);

		// Token: 0x02000809 RID: 2057
		// (Invoke) Token: 0x060038A5 RID: 14501
		private delegate void UpdateExternalTextureDelegate(IntPtr @this, IntPtr nativeTex);

		// Token: 0x0200080A RID: 2058
		// (Invoke) Token: 0x060038A7 RID: 14503
		private delegate void SetBlockOfPixels32Delegate(IntPtr @this, int x, int y, int blockWidth, int blockHeight, IntPtr colors, int miplevel);

		// Token: 0x0200080B RID: 2059
		// (Invoke) Token: 0x060038A9 RID: 14505
		private delegate IntPtr PackTexturesDelegate(IntPtr @this, IntPtr textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable);
	}
}
