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
	// Token: 0x020000E0 RID: 224
	public sealed class Texture2DArray : Texture
	{
		// Token: 0x06001187 RID: 4487 RVA: 0x0004DE34 File Offset: 0x0004C034
		// Note: this type is marked as 'beforefieldinit'.
		static Texture2DArray()
		{
			Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Texture2DArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr);
			Texture2DArray.NativeMethodInfoPtr_get_allSlices_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664962);
			Texture2DArray.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664963);
			Texture2DArray.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664964);
			Texture2DArray.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664965);
			Texture2DArray.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664966);
			Texture2DArray.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664967);
			Texture2DArray.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664968);
			Texture2DArray.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664969);
			Texture2DArray.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664970);
			Texture2DArray.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664971);
			Texture2DArray.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664972);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664973);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664974);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664975);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664976);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664977);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664978);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664979);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664980);
			Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664981);
			Texture2DArray.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664982);
			Texture2DArray.NativeMethodInfoPtr_Apply_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664983);
			Texture2DArray.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr, 100664984);
			Texture2DArray.get_depthDelegateField = IL2CPP.ResolveICall<Texture2DArray.get_depthDelegate>("UnityEngine.Texture2DArray::get_depth");
			Texture2DArray.get_formatDelegateField = IL2CPP.ResolveICall<Texture2DArray.get_formatDelegate>("UnityEngine.Texture2DArray::get_format");
			Texture2DArray.SetPixelDataImplArrayDelegateField = IL2CPP.ResolveICall<Texture2DArray.SetPixelDataImplArrayDelegate>("UnityEngine.Texture2DArray::SetPixelDataImplArray");
			Texture2DArray.SetPixelDataImplDelegateField = IL2CPP.ResolveICall<Texture2DArray.SetPixelDataImplDelegate>("UnityEngine.Texture2DArray::SetPixelDataImpl");
			Texture2DArray.GetPixels32DelegateField = IL2CPP.ResolveICall<Texture2DArray.GetPixels32Delegate>("UnityEngine.Texture2DArray::GetPixels32");
			Texture2DArray.SetPixels32DelegateField = IL2CPP.ResolveICall<Texture2DArray.SetPixels32Delegate>("UnityEngine.Texture2DArray::SetPixels32");
			Texture2DArray.GetImageDataPointerDelegateField = IL2CPP.ResolveICall<Texture2DArray.GetImageDataPointerDelegate>("UnityEngine.Texture2DArray::GetImageDataPointer");
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x0004E09C File Offset: 0x0004C29C
		public unsafe static int allSlices
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1240543, RefRangeEnd = 1240545, XrefRangeStart = 1240541, XrefRangeEnd = 1240543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_get_allSlices_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x0004E0CC File Offset: 0x0004C2CC
		public unsafe override bool isReadable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240545, XrefRangeEnd = 1240547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0004E108 File Offset: 0x0004C308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240547, XrefRangeEnd = 1240549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorSpace;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0004E1AC File Offset: 0x0004C3AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1240551, RefRangeEnd = 1240555, XrefRangeStart = 1240549, XrefRangeEnd = 1240551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorSpace;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0004E244 File Offset: 0x0004C444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240555, XrefRangeEnd = 1240557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref updateMipmaps;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref makeNoLongerReadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x0004E290 File Offset: 0x0004C490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240557, XrefRangeEnd = 1240559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Color> GetPixels(int arrayElement, int miplevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref arrayElement;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr3) : null;
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x0004E2EC File Offset: 0x0004C4EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240561, RefRangeEnd = 1240563, XrefRangeStart = 1240559, XrefRangeEnd = 1240561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Color> GetPixels(int arrayElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref arrayElement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr3) : null;
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x0004E338 File Offset: 0x0004C538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240563, XrefRangeEnd = 1240565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixels(Il2CppStructArray<Color> colors, int arrayElement, int miplevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayElement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miplevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0004E398 File Offset: 0x0004C598
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1240567, RefRangeEnd = 1240570, XrefRangeStart = 1240565, XrefRangeEnd = 1240567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPixels(Il2CppStructArray<Color> colors, int arrayElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayElement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x0004E3E8 File Offset: 0x0004C5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240570, XrefRangeEnd = 1240573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(TextureFormat format, int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0004E450 File Offset: 0x0004C650
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1240580, RefRangeEnd = 1240583, XrefRangeStart = 1240573, XrefRangeEnd = 1240580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x0004E4B8 File Offset: 0x0004C6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240583, XrefRangeEnd = 1240585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x0004E538 File Offset: 0x0004C738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240585, XrefRangeEnd = 1240597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x0004E5C8 File Offset: 0x0004C7C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240616, RefRangeEnd = 1240618, XrefRangeStart = 1240597, XrefRangeEnd = 1240616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x0004E648 File Offset: 0x0004C848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240618, XrefRangeEnd = 1240633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x0004E6D8 File Offset: 0x0004C8D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1240653, RefRangeEnd = 1240657, XrefRangeStart = 1240633, XrefRangeEnd = 1240653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createUninitialized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0004E774 File Offset: 0x0004C974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240657, XrefRangeEnd = 1240658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x0004E804 File Offset: 0x0004CA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240658, XrefRangeEnd = 1240664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createUninitialized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x0004E8A0 File Offset: 0x0004CAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240664, XrefRangeEnd = 1240670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x0004E930 File Offset: 0x0004CB30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240676, RefRangeEnd = 1240678, XrefRangeStart = 1240670, XrefRangeEnd = 1240676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2DArray(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Texture2DArray>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureFormat;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipChain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x0004E9B0 File Offset: 0x0004CBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240678, XrefRangeEnd = 1240683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply(bool updateMipmaps, bool makeNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref updateMipmaps;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref makeNoLongerReadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0004E9FC File Offset: 0x0004CBFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240688, RefRangeEnd = 1240690, XrefRangeStart = 1240683, XrefRangeEnd = 1240688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_Apply_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0004EA30 File Offset: 0x0004CC30
		[CallerCount(0)]
		public unsafe static void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Texture2DArray.NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00009F9C File Offset: 0x0000819C
		public Texture2DArray(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x00009FA5 File Offset: 0x000081A5
		public int depth
		{
			get
			{
				return Texture2DArray.get_depthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x00009FB7 File Offset: 0x000081B7
		public TextureFormat format
		{
			get
			{
				return Texture2DArray.get_formatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00009FC9 File Offset: 0x000081C9
		public bool SetPixelDataImplArray(Array data, int mipLevel, int element, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Texture2DArray.SetPixelDataImplArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), mipLevel, element, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x00009FE9 File Offset: 0x000081E9
		public bool SetPixelDataImpl(IntPtr data, int mipLevel, int element, int elementSize, int dataArraySize, [Optional] int sourceDataStartIndex)
		{
			return Texture2DArray.SetPixelDataImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, mipLevel, element, elementSize, dataArraySize, sourceDataStartIndex);
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0004EA64 File Offset: 0x0004CC64
		public Il2CppStructArray<Color32> GetPixels32(int arrayElement, int miplevel)
		{
			IntPtr intPtr = Texture2DArray.GetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), arrayElement, miplevel);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0004EA94 File Offset: 0x0004CC94
		public Il2CppStructArray<Color32> GetPixels32(int arrayElement)
		{
			return this.GetPixels32(arrayElement, 0);
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0000A004 File Offset: 0x00008204
		public void SetPixels32(Il2CppStructArray<Color32> colors, int arrayElement, int miplevel)
		{
			Texture2DArray.SetPixels32DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(colors), arrayElement, miplevel);
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0000A01E File Offset: 0x0000821E
		public void SetPixels32(Il2CppStructArray<Color32> colors, int arrayElement)
		{
			this.SetPixels32(colors, arrayElement, 0);
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0000A02B File Offset: 0x0000822B
		public IntPtr GetImageDataPointer()
		{
			return Texture2DArray.GetImageDataPointerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0000A03D File Offset: 0x0000823D
		public void Apply(bool updateMipmaps)
		{
			this.Apply(updateMipmaps, false);
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0004EAB0 File Offset: 0x0004CCB0
		public void SetPixelData<T>(Il2CppArrayBase<T> data, int mipLevel, int element, [Optional] int sourceDataStartIndex)
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
			this.SetPixelDataImplArray(data, mipLevel, element, Marshal.SizeOf<T>(data[0]), data.Length, sourceDataStartIndex);
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0004EB24 File Offset: 0x0004CD24
		public void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, int element, [Optional] int sourceDataStartIndex) where T : struct
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
			this.SetPixelDataImpl((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), mipLevel, element, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), data.Length, sourceDataStartIndex);
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0004EBA4 File Offset: 0x0004CDA4
		public unsafe Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel, int element) where T : struct
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
			bool flag3 = element < 0 || element >= this.depth;
			if (flag3)
			{
				throw new ArgumentException(String.Concat("The passed in element ", element.ToString(), " is invalid. The valid range is 0 through ", (this.depth - 1).ToString()));
			}
			ulong pixelDataOffset = base.GetPixelDataOffset(base.mipmapCount, element);
			ulong pixelDataOffset2 = base.GetPixelDataOffset(mipLevel, element);
			ulong pixelDataSize = base.GetPixelDataSize(mipLevel, element);
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			ulong num2 = pixelDataSize / (ulong)((long)num);
			bool flag4 = num2 > 2147483647UL;
			if (flag4)
			{
				throw base.CreateNativeArrayLengthOverflowException();
			}
			IntPtr value;
			value..ctor((long)this.GetImageDataPointer() + (long)(pixelDataOffset * (ulong)((long)element) + pixelDataOffset2));
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)value, (int)num2, Unity.Collections.Allocator.None);
		}

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeMethodInfoPtr_get_allSlices_Public_Static_get_Int32_0;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_Virtual_get_Boolean_0;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateImpl_Private_Static_Boolean_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Texture2DArray_Int32_Int32_Int32_Int32_GraphicsFormat_TextureColorSpace_TextureCreationFlags_0;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeMethodInfoPtr_ApplyImpl_Private_Void_Boolean_Boolean_0;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_Int32_0;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeMethodInfoPtr_GetPixels_Public_Il2CppStructArray_1_Color_Int32_0;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_Int32_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr_SetPixels_Public_Void_Il2CppStructArray_1_Color_Int32_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_TextureFormat_Int32_Int32_0;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFormat_Internal_Boolean_GraphicsFormat_Int32_Int32_0;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_0;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_DefaultFormat_TextureCreationFlags_Int32_0;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_0;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_Int32_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_Boolean_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Int32_Boolean_0;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_0;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_Boolean_0;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TextureFormat_Boolean_0;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Void_0;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr_ValidateIsNotCrunched_Private_Static_Void_TextureCreationFlags_0;

		// Token: 0x04000E26 RID: 3622
		private static readonly Texture2DArray.get_depthDelegate get_depthDelegateField;

		// Token: 0x04000E27 RID: 3623
		private static readonly Texture2DArray.get_formatDelegate get_formatDelegateField;

		// Token: 0x04000E28 RID: 3624
		private static readonly Texture2DArray.SetPixelDataImplArrayDelegate SetPixelDataImplArrayDelegateField;

		// Token: 0x04000E29 RID: 3625
		private static readonly Texture2DArray.SetPixelDataImplDelegate SetPixelDataImplDelegateField;

		// Token: 0x04000E2A RID: 3626
		private static readonly Texture2DArray.GetPixels32Delegate GetPixels32DelegateField;

		// Token: 0x04000E2B RID: 3627
		private static readonly Texture2DArray.SetPixels32Delegate SetPixels32DelegateField;

		// Token: 0x04000E2C RID: 3628
		private static readonly Texture2DArray.GetImageDataPointerDelegate GetImageDataPointerDelegateField;

		// Token: 0x02000829 RID: 2089
		// (Invoke) Token: 0x060038E4 RID: 14564
		private delegate int get_depthDelegate(IntPtr @this);

		// Token: 0x0200082A RID: 2090
		// (Invoke) Token: 0x060038E6 RID: 14566
		private delegate TextureFormat get_formatDelegate(IntPtr @this);

		// Token: 0x0200082B RID: 2091
		// (Invoke) Token: 0x060038E8 RID: 14568
		private delegate bool SetPixelDataImplArrayDelegate(IntPtr @this, IntPtr data, int mipLevel, int element, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x0200082C RID: 2092
		// (Invoke) Token: 0x060038EA RID: 14570
		private delegate bool SetPixelDataImplDelegate(IntPtr @this, IntPtr data, int mipLevel, int element, int elementSize, int dataArraySize, int sourceDataStartIndex);

		// Token: 0x0200082D RID: 2093
		// (Invoke) Token: 0x060038EC RID: 14572
		private delegate IntPtr GetPixels32Delegate(IntPtr @this, int arrayElement, int miplevel);

		// Token: 0x0200082E RID: 2094
		// (Invoke) Token: 0x060038EE RID: 14574
		private delegate void SetPixels32Delegate(IntPtr @this, IntPtr colors, int arrayElement, int miplevel);

		// Token: 0x0200082F RID: 2095
		// (Invoke) Token: 0x060038F0 RID: 14576
		private delegate IntPtr GetImageDataPointerDelegate(IntPtr @this);
	}
}
