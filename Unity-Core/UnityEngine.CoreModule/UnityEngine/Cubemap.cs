using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x020000DE RID: 222
	public sealed class Cubemap : Texture
	{
		// Token: 0x0600111D RID: 4381 RVA: 0x0004BCB8 File Offset: 0x00049EB8
		// Note: this type is marked as 'beforefieldinit'.
		static Cubemap()
		{
			Il2CppClassPointerStore<Cubemap>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Cubemap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cubemap>.NativeClassPtr);
			Cubemap.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664911);
			Cubemap.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664912);
			Cubemap.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664913);
			Cubemap.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664914);
			Cubemap.NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664915);
			Cubemap.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664916);
			Cubemap.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664917);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664918);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664919);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664920);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664921);
			Cubemap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Int32_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664922);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664923);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664924);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664925);
			Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664926);
			Cubemap.NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664927);
			Cubemap.NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664928);
			Cubemap.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664929);
			Cubemap.NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664930);
			Cubemap.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664931);
			Cubemap.NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cubemap>.NativeClassPtr, 100664932);
			Cubemap.get_formatDelegateField = IL2CPP.ResolveICall<Cubemap.get_formatDelegate>("UnityEngine.Cubemap::get_format");
			Cubemap.UpdateExternalTextureDelegateField = IL2CPP.ResolveICall<Cubemap.UpdateExternalTextureDelegate>("UnityEngine.Cubemap::UpdateExternalTexture");
			Cubemap.SmoothEdgesDelegateField = IL2CPP.ResolveICall<Cubemap.SmoothEdgesDelegate>("UnityEngine.Cubemap::SmoothEdges");
			Cubemap.GetPixelsDelegateField = IL2CPP.ResolveICall<Cubemap.GetPixelsDelegate>("UnityEngine.Cubemap::GetPixels");
			Cubemap.SetPixelsDelegateField = IL2CPP.ResolveICall<Cubemap.SetPixelsDelegate>("UnityEngine.Cubemap::SetPixels");
			Cubemap.SetPixelDataImplArrayDelegateField = IL2CPP.ResolveICall<Cubemap.SetPixelDataImplArrayDelegate>("UnityEngine.Cubemap::SetPixelDataImplArray");
			Cubemap.SetPixelDataImplDelegateField = IL2CPP.ResolveICall<Cubemap.SetPixelDataImplDelegate>("UnityEngine.Cubemap::SetPixelDataImpl");
			Cubemap.GetWritableImageDataDelegateField = IL2CPP.ResolveICall<Cubemap.GetWritableImageDataDelegate>("UnityEngine.Cubemap::GetWritableImageData");
			Cubemap.get_isPreProcessedDelegateField = IL2CPP.ResolveICall<Cubemap.get_isPreProcessedDelegate>("UnityEngine.Cubemap::get_isPreProcessed");
			Cubemap.get_streamingMipmapsDelegateField = IL2CPP.ResolveICall<Cubemap.get_streamingMipmapsDelegate>("UnityEngine.Cubemap::get_streamingMipmaps");
			Cubemap.get_streamingMipmapsPriorityDelegateField = IL2CPP.ResolveICall<Cubemap.get_streamingMipmapsPriorityDelegate>("UnityEngine.Cubemap::get_streamingMipmapsPriority");
			Cubemap.get_requestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.get_requestedMipmapLevelDelegate>("UnityEngine.Cubemap::get_requestedMipmapLevel");
			Cubemap.set_requestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.set_requestedMipmapLevelDelegate>("UnityEngine.Cubemap::set_requestedMipmapLevel");
			Cubemap.get_loadAllMipsDelegateField = IL2CPP.ResolveICall<Cubemap.get_loadAllMipsDelegate>("UnityEngine.Cubemap::get_loadAllMips");
			Cubemap.set_loadAllMipsDelegateField = IL2CPP.ResolveICall<Cubemap.set_loadAllMipsDelegate>("UnityEngine.Cubemap::set_loadAllMips");
			Cubemap.get_desiredMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.get_desiredMipmapLevelDelegate>("UnityEngine.Cubemap::get_desiredMipmapLevel");
			Cubemap.get_loadingMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.get_loadingMipmapLevelDelegate>("UnityEngine.Cubemap::get_loadingMipmapLevel");
			Cubemap.get_loadedMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.get_loadedMipmapLevelDelegate>("UnityEngine.Cubemap::get_loadedMipmapLevel");
			Cubemap.ClearRequestedMipmapLevelDelegateField = IL2CPP.ResolveICall<Cubemap.ClearRequestedMipmapLevelDelegate>("UnityEngine.Cubemap::ClearRequestedMipmapLevel");
			Cubemap.IsRequestedMipmapLevelLoadedDelegateField = IL2CPP.ResolveICall<Cubemap.IsRequestedMipmapLevelLoadedDelegate>("UnityEngine.Cubemap::IsRequestedMipmapLevelLoaded");
			Cubemap.GetPixelImpl_InjectedDelegateField = IL2CPP.ResolveICall<Cubemap.GetPixelImpl_InjectedDelegate>("UnityEngine.Cubemap::GetPixelImpl_Injected");
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0004BFDC File Offset: 0x0004A1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240268, XrefRangeEnd = 1240270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, IntPtr nativeTex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorSpace;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0004C074 File Offset: 0x0004A274
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240272, RefRangeEnd = 1240274, XrefRangeStart = 1240270, XrefRangeEnd = 1240272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, IntPtr nativeTex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorSpace;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0004C100 File Offset: 0x0004A300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240274, XrefRangeEnd = 1240276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref updateMipmaps;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref makeNoLongerReadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x0004C14C File Offset: 0x0004A34C
		public unsafe override bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240276, XrefRangeEnd = 1240278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0004C188 File Offset: 0x0004A388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240278, XrefRangeEnd = 1240280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0004C200 File Offset: 0x0004A400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240280, XrefRangeEnd = 1240283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(TextureFormat format, int width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0004C258 File Offset: 0x0004A458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240283, XrefRangeEnd = 1240290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x0004C2B0 File Offset: 0x0004A4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240290, XrefRangeEnd = 1240296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0004C314 File Offset: 0x0004A514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240296, XrefRangeEnd = 1240298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x0004C388 File Offset: 0x0004A588
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1240303, RefRangeEnd = 1240306, XrefRangeStart = 1240298, XrefRangeEnd = 1240303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0004C3EC File Offset: 0x0004A5EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1240327, RefRangeEnd = 1240330, XrefRangeStart = 1240306, XrefRangeEnd = 1240327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x0004C460 File Offset: 0x0004A660
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1240350, RefRangeEnd = 1240354, XrefRangeStart = 1240330, XrefRangeEnd = 1240350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeTex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createUninitialized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Int32_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x0004C4E0 File Offset: 0x0004A6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240354, XrefRangeEnd = 1240360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, TextureFormat textureFormat, bool mipChain) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x0004C544 File Offset: 0x0004A744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240360, XrefRangeEnd = 1240366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, TextureFormat textureFormat, bool mipChain, bool createUninitialized) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createUninitialized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0004C5B8 File Offset: 0x0004A7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240366, XrefRangeEnd = 1240367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, TextureFormat format, int mipCount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x0004C61C File Offset: 0x0004A81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240367, XrefRangeEnd = 1240368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cubemap(int width, TextureFormat format, int mipCount, bool createUninitialized) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cubemap>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createUninitialized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0004C690 File Offset: 0x0004A890
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1240370, RefRangeEnd = 1240373, XrefRangeStart = 1240368, XrefRangeEnd = 1240370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixel(CubemapFace face, int x, int y, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref face;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0004C6F8 File Offset: 0x0004A8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240373, XrefRangeEnd = 1240375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixel(CubemapFace face, int x, int y, Color color, int mip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref face;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x0004C770 File Offset: 0x0004A970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240375, XrefRangeEnd = 1240380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(bool updateMipmaps, bool makeNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref updateMipmaps;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref makeNoLongerReadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x0004C7BC File Offset: 0x0004A9BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1240385, RefRangeEnd = 1240388, XrefRangeStart = 1240380, XrefRangeEnd = 1240385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0004C7F0 File Offset: 0x0004A9F0
		[CallerCount(0)]
		public unsafe static void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x0004C824 File Offset: 0x0004AA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240388, XrefRangeEnd = 1240390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cubemap.NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00009D40 File Offset: 0x00007F40
		public Cubemap(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x00009D49 File Offset: 0x00007F49
		public TextureFormat format
		{
			get
			{
				return Cubemap.get_formatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x00009D5B File Offset: 0x00007F5B
		public void UpdateExternalTexture(IntPtr nativeTexture)
		{
			Cubemap.UpdateExternalTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nativeTexture);
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x0004C89C File Offset: 0x0004AA9C
		public Color GetPixelImpl(int image, int mip, int x, int y)
		{
			Color result;
			this.GetPixelImpl_Injected(image, mip, x, y, out result);
			return result;
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00009D6E File Offset: 0x00007F6E
		public void SmoothEdges(int smoothRegionWidthInPixels)
		{
			Cubemap.SmoothEdgesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), smoothRegionWidthInPixels);
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x00009D81 File Offset: 0x00007F81
		public void SmoothEdges()
		{
			this.SmoothEdges(1);
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0004C8B8 File Offset: 0x0004AAB8
		public Il2CppStructArray<Color> GetPixels(CubemapFace face, int miplevel)
		{
			IntPtr intPtr = Cubemap.GetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), face, miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0004C8E8 File Offset: 0x0004AAE8
		public Il2CppStructArray<Color> GetPixels(CubemapFace face)
		{
			return this.GetPixels(face, 0);
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00009D8C File Offset: 0x00007F8C
		public void SetPixels(Il2CppStructArray<Color> colors, CubemapFace face, int miplevel)
		{
			Cubemap.SetPixelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), face, miplevel);
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00009DA6 File Offset: 0x00007FA6
		public bool SetPixelDataImplArray(Array data, int mipLevel, int face, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Cubemap.SetPixelDataImplArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), mipLevel, face, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00009DC6 File Offset: 0x00007FC6
		public bool SetPixelDataImpl(IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Cubemap.SetPixelDataImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, mipLevel, face, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00009DE1 File Offset: 0x00007FE1
		public void SetPixels(Il2CppStructArray<Color> colors, CubemapFace face)
		{
			this.SetPixels(colors, face, 0);
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x00009DEE File Offset: 0x00007FEE
		public IntPtr GetWritableImageData(int frame)
		{
			return Cubemap.GetWritableImageDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), frame);
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x00009E01 File Offset: 0x00008001
		public bool isPreProcessed
		{
			get
			{
				return Cubemap.get_isPreProcessedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x00009E13 File Offset: 0x00008013
		public bool streamingMipmaps
		{
			get
			{
				return Cubemap.get_streamingMipmapsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x00009E25 File Offset: 0x00008025
		public int streamingMipmapsPriority
		{
			get
			{
				return Cubemap.get_streamingMipmapsPriorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x00009E37 File Offset: 0x00008037
		// (set) Token: 0x06001145 RID: 4421 RVA: 0x00009E49 File Offset: 0x00008049
		public int requestedMipmapLevel
		{
			get
			{
				return Cubemap.get_requestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cubemap.set_requestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x00009E5C File Offset: 0x0000805C
		// (set) Token: 0x06001147 RID: 4423 RVA: 0x00009E6E File Offset: 0x0000806E
		public bool loadAllMips
		{
			get
			{
				return Cubemap.get_loadAllMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Cubemap.set_loadAllMipsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x00009E81 File Offset: 0x00008081
		public int desiredMipmapLevel
		{
			get
			{
				return Cubemap.get_desiredMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x00009E93 File Offset: 0x00008093
		public int loadingMipmapLevel
		{
			get
			{
				return Cubemap.get_loadingMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x00009EA5 File Offset: 0x000080A5
		public int loadedMipmapLevel
		{
			get
			{
				return Cubemap.get_loadedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00009EB7 File Offset: 0x000080B7
		public void ClearRequestedMipmapLevel()
		{
			Cubemap.ClearRequestedMipmapLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00009EC9 File Offset: 0x000080C9
		public bool IsRequestedMipmapLevelLoaded()
		{
			return Cubemap.IsRequestedMipmapLevelLoadedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0004C904 File Offset: 0x0004AB04
		public static Cubemap CreateExternalTexture(int width, TextureFormat format, bool mipmap, IntPtr nativeTex)
		{
			bool flag = nativeTex == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("nativeTex can not be null");
			}
			return new Cubemap(width, format, mipmap ? Texture.GenerateAllMips : 1, nativeTex, false);
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0004C944 File Offset: 0x0004AB44
		public void SetPixelData<T>(Il2CppArrayBase<T> data, int mipLevel, CubemapFace face, [Optional] int sourceDataStartIndex)
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
			this.SetPixelDataImplArray(data, mipLevel, (int)face, Marshal.SizeOf<T>(data[0]), data.Length, sourceDataStartIndex);
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x0004C9B8 File Offset: 0x0004ABB8
		public void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, CubemapFace face, [Optional] int sourceDataStartIndex) where T : struct
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
			bool flag3 = !data.IsCreated || data.Length == 0;
			if (flag3)
			{
				throw new UnityException("No texture data provided to SetPixelData.");
			}
			this.SetPixelDataImpl((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), mipLevel, (int)face, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), data.Length, sourceDataStartIndex);
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x0004CA38 File Offset: 0x0004AC38
		public unsafe Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel, CubemapFace face) where T : struct
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			bool flag2 = mipLevel < 0 || mipLevel >= base.mipmapCount;
			if (flag2)
			{
				throw new ArgumentException(String.Concat("The passed in miplevel ", mipLevel.ToString(), " is invalid. The valid range is 0 through ", (base.mipmapCount - 1).ToString()));
			}
			bool flag3 = face < CubemapFace.PositiveX || face >= (CubemapFace)6;
			if (flag3)
			{
				throw new ArgumentException(String.Concat("The passed in face ", face.ToString(), " is invalid. The valid range is 0 through 5."));
			}
			bool flag4 = this.GetWritableImageData(0).ToInt64() == 0L;
			if (flag4)
			{
				throw new UnityException(String.Concat("Texture '", base.name, "' has no data."));
			}
			ulong pixelDataOffset = base.GetPixelDataOffset(base.mipmapCount, (int)face);
			ulong pixelDataOffset2 = base.GetPixelDataOffset(mipLevel, (int)face);
			ulong pixelDataSize = base.GetPixelDataSize(mipLevel, (int)face);
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			ulong num2 = pixelDataSize / (ulong)((long)num);
			bool flag5 = num2 > 2147483647UL;
			if (flag5)
			{
				throw base.CreateNativeArrayLengthOverflowException();
			}
			IntPtr value;
			value..ctor((long)this.GetWritableImageData(0) + (long)(pixelDataOffset * (ulong)((long)face) + pixelDataOffset2));
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)value, (int)num2, Unity.Collections.Allocator.None);
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x0004CB88 File Offset: 0x0004AD88
		public Color GetPixel(CubemapFace face, int x, int y)
		{
			return this.GetPixel(face, x, y, 0);
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0004CBA4 File Offset: 0x0004ADA4
		public Color GetPixel(CubemapFace face, int x, int y, int mip)
		{
			bool flag = !this.isReadable;
			if (flag)
			{
				throw base.CreateNonReadableException(this);
			}
			return this.GetPixelImpl((int)face, mip, x, y);
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00009EDB File Offset: 0x000080DB
		public void Apply(bool updateMipmaps)
		{
			this.Apply(updateMipmaps, false);
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00009EE7 File Offset: 0x000080E7
		public void GetPixelImpl_Injected(int image, int mip, int x, int y, out Color ret)
		{
			Cubemap.GetPixelImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), image, mip, x, y, out ret);
		}

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Cubemap_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_IntPtr_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelImpl_Private_Void_Int32_Int32_Int32_Int32_Color_0;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_0;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_0;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_0;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_DefaultFormat_TextureCreationFlags_Int32_0;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_0;

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_GraphicsFormat_TextureCreationFlags_Int32_0;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_TextureFormat_Int32_IntPtr_Boolean_0;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_0;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Boolean_Boolean_0;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_0;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_TextureFormat_Int32_Boolean_0;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr_SetPixel_Public_Void_CubemapFace_Int32_Int32_Color_Int32_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr_SetPixelImpl_Injected_Private_Void_Int32_Int32_Int32_Int32_byref_Color_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly Cubemap.get_formatDelegate get_formatDelegateField;

		// Token: 0x04000DD7 RID: 3543
		private static readonly Cubemap.UpdateExternalTextureDelegate UpdateExternalTextureDelegateField;

		// Token: 0x04000DD8 RID: 3544
		private static readonly Cubemap.SmoothEdgesDelegate SmoothEdgesDelegateField;

		// Token: 0x04000DD9 RID: 3545
		private static readonly Cubemap.GetPixelsDelegate GetPixelsDelegateField;

		// Token: 0x04000DDA RID: 3546
		private static readonly Cubemap.SetPixelsDelegate SetPixelsDelegateField;

		// Token: 0x04000DDB RID: 3547
		private static readonly Cubemap.SetPixelDataImplArrayDelegate SetPixelDataImplArrayDelegateField;

		// Token: 0x04000DDC RID: 3548
		private static readonly Cubemap.SetPixelDataImplDelegate SetPixelDataImplDelegateField;

		// Token: 0x04000DDD RID: 3549
		private static readonly Cubemap.GetWritableImageDataDelegate GetWritableImageDataDelegateField;

		// Token: 0x04000DDE RID: 3550
		private static readonly Cubemap.get_isPreProcessedDelegate get_isPreProcessedDelegateField;

		// Token: 0x04000DDF RID: 3551
		private static readonly Cubemap.get_streamingMipmapsDelegate get_streamingMipmapsDelegateField;

		// Token: 0x04000DE0 RID: 3552
		private static readonly Cubemap.get_streamingMipmapsPriorityDelegate get_streamingMipmapsPriorityDelegateField;

		// Token: 0x04000DE1 RID: 3553
		private static readonly Cubemap.get_requestedMipmapLevelDelegate get_requestedMipmapLevelDelegateField;

		// Token: 0x04000DE2 RID: 3554
		private static readonly Cubemap.set_requestedMipmapLevelDelegate set_requestedMipmapLevelDelegateField;

		// Token: 0x04000DE3 RID: 3555
		private static readonly Cubemap.get_loadAllMipsDelegate get_loadAllMipsDelegateField;

		// Token: 0x04000DE4 RID: 3556
		private static readonly Cubemap.set_loadAllMipsDelegate set_loadAllMipsDelegateField;

		// Token: 0x04000DE5 RID: 3557
		private static readonly Cubemap.get_desiredMipmapLevelDelegate get_desiredMipmapLevelDelegateField;

		// Token: 0x04000DE6 RID: 3558
		private static readonly Cubemap.get_loadingMipmapLevelDelegate get_loadingMipmapLevelDelegateField;

		// Token: 0x04000DE7 RID: 3559
		private static readonly Cubemap.get_loadedMipmapLevelDelegate get_loadedMipmapLevelDelegateField;

		// Token: 0x04000DE8 RID: 3560
		private static readonly Cubemap.ClearRequestedMipmapLevelDelegate ClearRequestedMipmapLevelDelegateField;

		// Token: 0x04000DE9 RID: 3561
		private static readonly Cubemap.IsRequestedMipmapLevelLoadedDelegate IsRequestedMipmapLevelLoadedDelegateField;

		// Token: 0x04000DEA RID: 3562
		private static readonly Cubemap.GetPixelImpl_InjectedDelegate GetPixelImpl_InjectedDelegateField;

		// Token: 0x0200080C RID: 2060
		// (Invoke) Token: 0x060038AB RID: 14507
		private delegate TextureFormat get_formatDelegate(IntPtr @this);

		// Token: 0x0200080D RID: 2061
		// (Invoke) Token: 0x060038AD RID: 14509
		private delegate void UpdateExternalTextureDelegate(IntPtr @this, IntPtr nativeTexture);

		// Token: 0x0200080E RID: 2062
		// (Invoke) Token: 0x060038AF RID: 14511
		private delegate void SmoothEdgesDelegate(IntPtr @this, int smoothRegionWidthInPixels);

		// Token: 0x0200080F RID: 2063
		// (Invoke) Token: 0x060038B1 RID: 14513
		private delegate IntPtr GetPixelsDelegate(IntPtr @this, CubemapFace face, int miplevel);

		// Token: 0x02000810 RID: 2064
		// (Invoke) Token: 0x060038B3 RID: 14515
		private delegate void SetPixelsDelegate(IntPtr @this, IntPtr colors, CubemapFace face, int miplevel);

		// Token: 0x02000811 RID: 2065
		// (Invoke) Token: 0x060038B5 RID: 14517
		private delegate bool SetPixelDataImplArrayDelegate(IntPtr @this, IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x02000812 RID: 2066
		// (Invoke) Token: 0x060038B7 RID: 14519
		private delegate bool SetPixelDataImplDelegate(IntPtr @this, IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x02000813 RID: 2067
		// (Invoke) Token: 0x060038B9 RID: 14521
		private delegate IntPtr GetWritableImageDataDelegate(IntPtr @this, int frame);

		// Token: 0x02000814 RID: 2068
		// (Invoke) Token: 0x060038BB RID: 14523
		private delegate bool get_isPreProcessedDelegate(IntPtr @this);

		// Token: 0x02000815 RID: 2069
		// (Invoke) Token: 0x060038BD RID: 14525
		private delegate bool get_streamingMipmapsDelegate(IntPtr @this);

		// Token: 0x02000816 RID: 2070
		// (Invoke) Token: 0x060038BF RID: 14527
		private delegate int get_streamingMipmapsPriorityDelegate(IntPtr @this);

		// Token: 0x02000817 RID: 2071
		// (Invoke) Token: 0x060038C1 RID: 14529
		private delegate int get_requestedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x02000818 RID: 2072
		// (Invoke) Token: 0x060038C3 RID: 14531
		private delegate void set_requestedMipmapLevelDelegate(IntPtr @this, int value);

		// Token: 0x02000819 RID: 2073
		// (Invoke) Token: 0x060038C5 RID: 14533
		private delegate bool get_loadAllMipsDelegate(IntPtr @this);

		// Token: 0x0200081A RID: 2074
		// (Invoke) Token: 0x060038C7 RID: 14535
		private delegate void set_loadAllMipsDelegate(IntPtr @this, bool value);

		// Token: 0x0200081B RID: 2075
		// (Invoke) Token: 0x060038C9 RID: 14537
		private delegate int get_desiredMipmapLevelDelegate(IntPtr @this);

		// Token: 0x0200081C RID: 2076
		// (Invoke) Token: 0x060038CB RID: 14539
		private delegate int get_loadingMipmapLevelDelegate(IntPtr @this);

		// Token: 0x0200081D RID: 2077
		// (Invoke) Token: 0x060038CD RID: 14541
		private delegate int get_loadedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x0200081E RID: 2078
		// (Invoke) Token: 0x060038CF RID: 14543
		private delegate void ClearRequestedMipmapLevelDelegate(IntPtr @this);

		// Token: 0x0200081F RID: 2079
		// (Invoke) Token: 0x060038D1 RID: 14545
		private delegate bool IsRequestedMipmapLevelLoadedDelegate(IntPtr @this);

		// Token: 0x02000820 RID: 2080
		// (Invoke) Token: 0x060038D3 RID: 14547
		private delegate void GetPixelImpl_InjectedDelegate(IntPtr @this, int image, int mip, int x, int y, [Out] IntPtr ret);
	}
}
