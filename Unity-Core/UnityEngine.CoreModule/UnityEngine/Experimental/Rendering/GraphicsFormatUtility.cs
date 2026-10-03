using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200027F RID: 639
	public class GraphicsFormatUtility : Object
	{
		// Token: 0x06002B54 RID: 11092 RVA: 0x000A8AEC File Offset: 0x000A6CEC
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsFormatUtility()
		{
			Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "GraphicsFormatUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr);
			GraphicsFormatUtility.NativeFieldInfoPtr_tableNoStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, "tableNoStencil");
			GraphicsFormatUtility.NativeFieldInfoPtr_tableStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, "tableStencil");
			GraphicsFormatUtility.NativeMethodInfoPtr_GetFormat_Internal_Static_GraphicsFormat_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667964);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667965);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667966);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667967);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667968);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667969);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormatFromBitsLegacy_Native_Private_Static_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667970);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormat_Internal_Static_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667971);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthBits_Public_Static_Int32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667972);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667973);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667974);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetSRGBFormat_Public_Static_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667975);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetLinearFormat_Public_Static_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667976);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetRenderTextureFormat_Public_Static_RenderTextureFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667977);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetComponentCount_Public_Static_UInt32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667978);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetFormatString_Public_Static_String_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667979);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsCompressedFormat_Native_TextureFormat_Private_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667980);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsCompressedFormat_Public_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667981);
			GraphicsFormatUtility.NativeMethodInfoPtr_CanDecompressFormat_Private_Static_Boolean_GraphicsFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667982);
			GraphicsFormatUtility.NativeMethodInfoPtr_CanDecompressFormat_Internal_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667983);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsAlphaOnlyFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667984);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsDepthStencilFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667985);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsPVRTCFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667986);
			GraphicsFormatUtility.NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667987);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleR_Public_Static_FormatSwizzle_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667988);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleG_Public_Static_FormatSwizzle_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667989);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleB_Public_Static_FormatSwizzle_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667990);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleA_Public_Static_FormatSwizzle_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667991);
			GraphicsFormatUtility.NativeMethodInfoPtr_GetBlockSize_Public_Static_UInt32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100667992);
			GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetTextureFormat_Native_GraphicsFormat");
			GraphicsFormatUtility.IsSwizzleFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSwizzleFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSwizzleFormat");
			GraphicsFormatUtility.GetColorComponentCountDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetColorComponentCountDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetColorComponentCount");
			GraphicsFormatUtility.GetAlphaComponentCountDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetAlphaComponentCountDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetAlphaComponentCount");
			GraphicsFormatUtility.GetFormatString_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetFormatString_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetFormatString_Native_TextureFormat");
			GraphicsFormatUtility.IsCompressedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsCompressedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsCompressedFormat");
			GraphicsFormatUtility.IsPackedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsPackedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsPackedFormat");
			GraphicsFormatUtility.Is16BitPackedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.Is16BitPackedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::Is16BitPackedFormat");
			GraphicsFormatUtility.ConvertToAlphaFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ConvertToAlphaFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ConvertToAlphaFormat");
			GraphicsFormatUtility.ConvertToAlphaFormat_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ConvertToAlphaFormat_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ConvertToAlphaFormat_Native_TextureFormat");
			GraphicsFormatUtility.IsAlphaOnlyFormat_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsAlphaOnlyFormat_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsAlphaOnlyFormat_Native_TextureFormat");
			GraphicsFormatUtility.IsAlphaTestFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsAlphaTestFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsAlphaTestFormat");
			GraphicsFormatUtility.HasAlphaChannelDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.HasAlphaChannelDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::HasAlphaChannel");
			GraphicsFormatUtility.HasAlphaChannel_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.HasAlphaChannel_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::HasAlphaChannel_Native_TextureFormat");
			GraphicsFormatUtility.IsDepthFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsDepthFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsDepthFormat");
			GraphicsFormatUtility.IsStencilFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsStencilFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsStencilFormat");
			GraphicsFormatUtility.IsIEEE754FormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsIEEE754FormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsIEEE754Format");
			GraphicsFormatUtility.IsFloatFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsFloatFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsFloatFormat");
			GraphicsFormatUtility.IsHalfFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsHalfFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsHalfFormat");
			GraphicsFormatUtility.IsUnsignedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsUnsignedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUnsignedFormat");
			GraphicsFormatUtility.IsSignedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSignedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSignedFormat");
			GraphicsFormatUtility.IsNormFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsNormFormat");
			GraphicsFormatUtility.IsUNormFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsUNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUNormFormat");
			GraphicsFormatUtility.IsSNormFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSNormFormat");
			GraphicsFormatUtility.IsIntegerFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsIntegerFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsIntegerFormat");
			GraphicsFormatUtility.IsUIntFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsUIntFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUIntFormat");
			GraphicsFormatUtility.IsSIntFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSIntFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSIntFormat");
			GraphicsFormatUtility.IsXRFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsXRFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsXRFormat");
			GraphicsFormatUtility.IsDXTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsDXTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsDXTCFormat");
			GraphicsFormatUtility.IsRGTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsRGTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsRGTCFormat");
			GraphicsFormatUtility.IsBPTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsBPTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsBPTCFormat");
			GraphicsFormatUtility.IsBCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsBCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsBCFormat");
			GraphicsFormatUtility.IsETCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsETCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsETCFormat");
			GraphicsFormatUtility.IsEACFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsEACFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsEACFormat");
			GraphicsFormatUtility.IsASTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsASTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsASTCFormat");
			GraphicsFormatUtility.IsHDRFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsHDRFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsHDRFormat");
			GraphicsFormatUtility.IsHDRFormat_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsHDRFormat_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsHDRFormat_Native_TextureFormat");
			GraphicsFormatUtility.GetBlockWidthDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetBlockWidthDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetBlockWidth");
			GraphicsFormatUtility.GetBlockHeightDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetBlockHeightDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetBlockHeight");
			GraphicsFormatUtility.ComputeMipChainSize_Native_2DDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ComputeMipChainSize_Native_2DDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ComputeMipChainSize_Native_2D");
			GraphicsFormatUtility.ComputeMipChainSize_Native_3DDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ComputeMipChainSize_Native_3DDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ComputeMipChainSize_Native_3D");
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x000A8FF0 File Offset: 0x000A71F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1294394, RefRangeEnd = 1294398, XrefRangeStart = 1294392, XrefRangeEnd = 1294394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetFormat(Texture texture)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetFormat_Internal_Static_GraphicsFormat_Texture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x000A9034 File Offset: 0x000A7234
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1294403, RefRangeEnd = 1294410, XrefRangeStart = 1294398, XrefRangeEnd = 1294403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x000A9080 File Offset: 0x000A7280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294410, XrefRangeEnd = 1294412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x000A90CC File Offset: 0x000A72CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1294417, RefRangeEnd = 1294418, XrefRangeStart = 1294412, XrefRangeEnd = 1294417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x000A9118 File Offset: 0x000A7318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294418, XrefRangeEnd = 1294420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x000A9164 File Offset: 0x000A7364
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294430, RefRangeEnd = 1294432, XrefRangeStart = 1294420, XrefRangeEnd = 1294430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readWrite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x000A91B0 File Offset: 0x000A73B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294432, XrefRangeEnd = 1294434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minimumDepthBits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormatFromBitsLegacy_Native_Private_Static_GraphicsFormat_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x000A91F0 File Offset: 0x000A73F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294434, XrefRangeEnd = 1294439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minimumDepthBits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormat_Internal_Static_GraphicsFormat_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x000A9230 File Offset: 0x000A7430
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294441, RefRangeEnd = 1294443, XrefRangeStart = 1294439, XrefRangeEnd = 1294441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDepthBits(GraphicsFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthBits_Public_Static_Int32_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x000A9270 File Offset: 0x000A7470
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1294462, RefRangeEnd = 1294465, XrefRangeStart = 1294443, XrefRangeEnd = 1294462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minimumDepthBits;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimumStencilBits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x000A92BC File Offset: 0x000A74BC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1294485, RefRangeEnd = 1294500, XrefRangeStart = 1294465, XrefRangeEnd = 1294485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSRGBFormat(GraphicsFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x000A92FC File Offset: 0x000A74FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1294502, RefRangeEnd = 1294503, XrefRangeStart = 1294500, XrefRangeEnd = 1294502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetSRGBFormat(GraphicsFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetSRGBFormat_Public_Static_GraphicsFormat_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x000A933C File Offset: 0x000A753C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294505, RefRangeEnd = 1294507, XrefRangeStart = 1294503, XrefRangeEnd = 1294505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetLinearFormat(GraphicsFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetLinearFormat_Public_Static_GraphicsFormat_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x000A937C File Offset: 0x000A757C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294507, XrefRangeEnd = 1294509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetRenderTextureFormat_Public_Static_RenderTextureFormat_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x000A93BC File Offset: 0x000A75BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1294511, RefRangeEnd = 1294515, XrefRangeStart = 1294509, XrefRangeEnd = 1294511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetComponentCount(GraphicsFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetComponentCount_Public_Static_UInt32_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x000A93FC File Offset: 0x000A75FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1294517, RefRangeEnd = 1294518, XrefRangeStart = 1294515, XrefRangeEnd = 1294517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFormatString(GraphicsFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetFormatString_Public_Static_String_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x000A9434 File Offset: 0x000A7634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294518, XrefRangeEnd = 1294520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCompressedFormat_Native_TextureFormat(TextureFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsCompressedFormat_Native_TextureFormat_Private_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x000A9474 File Offset: 0x000A7674
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1294525, RefRangeEnd = 1294526, XrefRangeStart = 1294520, XrefRangeEnd = 1294525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCompressedFormat(TextureFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsCompressedFormat_Public_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x000A94B4 File Offset: 0x000A76B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294526, XrefRangeEnd = 1294528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wholeImage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_CanDecompressFormat_Private_Static_Boolean_GraphicsFormat_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x000A9500 File Offset: 0x000A7700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1294533, RefRangeEnd = 1294534, XrefRangeStart = 1294528, XrefRangeEnd = 1294533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanDecompressFormat(GraphicsFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_CanDecompressFormat_Internal_Static_Boolean_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x000A9540 File Offset: 0x000A7740
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294536, RefRangeEnd = 1294538, XrefRangeStart = 1294534, XrefRangeEnd = 1294536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAlphaOnlyFormat(GraphicsFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsAlphaOnlyFormat_Public_Static_Boolean_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x000A9580 File Offset: 0x000A7780
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294540, RefRangeEnd = 1294542, XrefRangeStart = 1294538, XrefRangeEnd = 1294540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDepthStencilFormat(GraphicsFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsDepthStencilFormat_Public_Static_Boolean_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x000A95C0 File Offset: 0x000A77C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1294544, RefRangeEnd = 1294549, XrefRangeStart = 1294542, XrefRangeEnd = 1294544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPVRTCFormat(GraphicsFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsPVRTCFormat_Public_Static_Boolean_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x000A9600 File Offset: 0x000A7800
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1294551, RefRangeEnd = 1294560, XrefRangeStart = 1294549, XrefRangeEnd = 1294551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCrunchFormat(TextureFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x000A9640 File Offset: 0x000A7840
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1294562, RefRangeEnd = 1294566, XrefRangeStart = 1294560, XrefRangeEnd = 1294562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.FormatSwizzle GetSwizzleR(GraphicsFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleR_Public_Static_FormatSwizzle_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x000A9680 File Offset: 0x000A7880
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294568, RefRangeEnd = 1294570, XrefRangeStart = 1294566, XrefRangeEnd = 1294568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.FormatSwizzle GetSwizzleG(GraphicsFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleG_Public_Static_FormatSwizzle_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x000A96C0 File Offset: 0x000A78C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294572, RefRangeEnd = 1294574, XrefRangeStart = 1294570, XrefRangeEnd = 1294572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.FormatSwizzle GetSwizzleB(GraphicsFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleB_Public_Static_FormatSwizzle_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x000A9700 File Offset: 0x000A7900
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294576, RefRangeEnd = 1294578, XrefRangeStart = 1294574, XrefRangeEnd = 1294576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.FormatSwizzle GetSwizzleA(GraphicsFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleA_Public_Static_FormatSwizzle_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x000A9740 File Offset: 0x000A7940
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1294580, RefRangeEnd = 1294583, XrefRangeStart = 1294578, XrefRangeEnd = 1294580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetBlockSize(GraphicsFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetBlockSize_Public_Static_UInt32_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x00013092 File Offset: 0x00011292
		public GraphicsFormatUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06002B73 RID: 11123 RVA: 0x000A9780 File Offset: 0x000A7980
		// (set) Token: 0x06002B74 RID: 11124 RVA: 0x0001309B File Offset: 0x0001129B
		public unsafe static Il2CppStructArray<GraphicsFormat> tableNoStencil
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraphicsFormatUtility.NativeFieldInfoPtr_tableNoStencil, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsFormat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicsFormatUtility.NativeFieldInfoPtr_tableNoStencil, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06002B75 RID: 11125 RVA: 0x000A97A8 File Offset: 0x000A79A8
		// (set) Token: 0x06002B76 RID: 11126 RVA: 0x000130AD File Offset: 0x000112AD
		public unsafe static Il2CppStructArray<GraphicsFormat> tableStencil
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraphicsFormatUtility.NativeFieldInfoPtr_tableStencil, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsFormat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicsFormatUtility.NativeFieldInfoPtr_tableStencil, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x000A97D0 File Offset: 0x000A79D0
		public static TextureFormat GetTextureFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormat(format);
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x000130BF File Offset: 0x000112BF
		public static TextureFormat GetTextureFormat_Native_GraphicsFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegateField(format);
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x000130CC File Offset: 0x000112CC
		public static bool IsSwizzleFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsSwizzleFormatDelegateField(format);
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x000A97E8 File Offset: 0x000A79E8
		public static bool IsSwizzleFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsSwizzleFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x000130D9 File Offset: 0x000112D9
		public static uint GetColorComponentCount(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetColorComponentCountDelegateField(format);
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x000A9808 File Offset: 0x000A7A08
		public static uint GetColorComponentCount(TextureFormat format)
		{
			return GraphicsFormatUtility.GetColorComponentCount(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x000130E6 File Offset: 0x000112E6
		public static uint GetAlphaComponentCount(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetAlphaComponentCountDelegateField(format);
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x000A9828 File Offset: 0x000A7A28
		public static uint GetAlphaComponentCount(TextureFormat format)
		{
			return GraphicsFormatUtility.GetAlphaComponentCount(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x000A9848 File Offset: 0x000A7A48
		public static uint GetComponentCount(TextureFormat format)
		{
			return GraphicsFormatUtility.GetComponentCount(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x000A9868 File Offset: 0x000A7A68
		public static string GetFormatString_Native_TextureFormat(TextureFormat format)
		{
			IntPtr intPtr = GraphicsFormatUtility.GetFormatString_Native_TextureFormatDelegateField(format);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x000A9888 File Offset: 0x000A7A88
		public static string GetFormatString(TextureFormat format)
		{
			return GraphicsFormatUtility.GetFormatString_Native_TextureFormat(format);
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x000130F3 File Offset: 0x000112F3
		public static bool IsCompressedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsCompressedFormatDelegateField(format);
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x000A98A0 File Offset: 0x000A7AA0
		public static bool IsCompressedTextureFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsCompressedFormat(format);
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x00013100 File Offset: 0x00011300
		public static bool IsPackedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsPackedFormatDelegateField(format);
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x000A98B8 File Offset: 0x000A7AB8
		public static bool IsPackedFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsPackedFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x0001310D File Offset: 0x0001130D
		public static bool Is16BitPackedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.Is16BitPackedFormatDelegateField(format);
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x000A98D8 File Offset: 0x000A7AD8
		public static bool Is16BitPackedFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.Is16BitPackedFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x0001311A File Offset: 0x0001131A
		public static GraphicsFormat ConvertToAlphaFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.ConvertToAlphaFormatDelegateField(format);
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x00013127 File Offset: 0x00011327
		public static TextureFormat ConvertToAlphaFormat_Native_TextureFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.ConvertToAlphaFormat_Native_TextureFormatDelegateField(format);
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x000A98F8 File Offset: 0x000A7AF8
		public static TextureFormat ConvertToAlphaFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.ConvertToAlphaFormat_Native_TextureFormat(format);
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x00013134 File Offset: 0x00011334
		public static bool IsAlphaOnlyFormat_Native_TextureFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsAlphaOnlyFormat_Native_TextureFormatDelegateField(format);
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x000A9910 File Offset: 0x000A7B10
		public static bool IsAlphaOnlyFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsAlphaOnlyFormat_Native_TextureFormat(format);
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x00013141 File Offset: 0x00011341
		public static bool IsAlphaTestFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsAlphaTestFormatDelegateField(format);
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x000A9928 File Offset: 0x000A7B28
		public static bool IsAlphaTestFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsAlphaTestFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x0001314E File Offset: 0x0001134E
		public static bool HasAlphaChannel(GraphicsFormat format)
		{
			return GraphicsFormatUtility.HasAlphaChannelDelegateField(format);
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x0001315B File Offset: 0x0001135B
		public static bool HasAlphaChannel_Native_TextureFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.HasAlphaChannel_Native_TextureFormatDelegateField(format);
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x000A9948 File Offset: 0x000A7B48
		public static bool HasAlphaChannel(TextureFormat format)
		{
			return GraphicsFormatUtility.HasAlphaChannel_Native_TextureFormat(format);
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x00013168 File Offset: 0x00011368
		public static bool IsDepthFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsDepthFormatDelegateField(format);
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x00013175 File Offset: 0x00011375
		public static bool IsStencilFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsStencilFormatDelegateField(format);
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x00013182 File Offset: 0x00011382
		public static bool IsIEEE754Format(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsIEEE754FormatDelegateField(format);
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x0001318F File Offset: 0x0001138F
		public static bool IsFloatFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsFloatFormatDelegateField(format);
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x0001319C File Offset: 0x0001139C
		public static bool IsHalfFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsHalfFormatDelegateField(format);
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x000131A9 File Offset: 0x000113A9
		public static bool IsUnsignedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsUnsignedFormatDelegateField(format);
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x000A9960 File Offset: 0x000A7B60
		public static bool IsUnsignedFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsUnsignedFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x000131B6 File Offset: 0x000113B6
		public static bool IsSignedFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsSignedFormatDelegateField(format);
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x000A9980 File Offset: 0x000A7B80
		public static bool IsSignedFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsSignedFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x000131C3 File Offset: 0x000113C3
		public static bool IsNormFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsNormFormatDelegateField(format);
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x000131D0 File Offset: 0x000113D0
		public static bool IsUNormFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsUNormFormatDelegateField(format);
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x000131DD File Offset: 0x000113DD
		public static bool IsSNormFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsSNormFormatDelegateField(format);
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x000131EA File Offset: 0x000113EA
		public static bool IsIntegerFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsIntegerFormatDelegateField(format);
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x000131F7 File Offset: 0x000113F7
		public static bool IsUIntFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsUIntFormatDelegateField(format);
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x00013204 File Offset: 0x00011404
		public static bool IsSIntFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsSIntFormatDelegateField(format);
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x00013211 File Offset: 0x00011411
		public static bool IsXRFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsXRFormatDelegateField(format);
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x0001321E File Offset: 0x0001141E
		public static bool IsDXTCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsDXTCFormatDelegateField(format);
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x000A99A0 File Offset: 0x000A7BA0
		public static bool IsDXTCFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsDXTCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x0001322B File Offset: 0x0001142B
		public static bool IsRGTCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsRGTCFormatDelegateField(format);
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x000A99C0 File Offset: 0x000A7BC0
		public static bool IsRGTCFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsRGTCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x00013238 File Offset: 0x00011438
		public static bool IsBPTCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsBPTCFormatDelegateField(format);
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x000A99E0 File Offset: 0x000A7BE0
		public static bool IsBPTCFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsBPTCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x00013245 File Offset: 0x00011445
		public static bool IsBCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsBCFormatDelegateField(format);
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x000A9A00 File Offset: 0x000A7C00
		public static bool IsBCFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsBCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x000A9A20 File Offset: 0x000A7C20
		public static bool IsPVRTCFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsPVRTCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x00013252 File Offset: 0x00011452
		public static bool IsETCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsETCFormatDelegateField(format);
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x000A9A40 File Offset: 0x000A7C40
		public static bool IsETCFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsETCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x0001325F File Offset: 0x0001145F
		public static bool IsEACFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsEACFormatDelegateField(format);
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x000A9A60 File Offset: 0x000A7C60
		public static bool IsEACFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsEACFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x0001326C File Offset: 0x0001146C
		public static bool IsASTCFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsASTCFormatDelegateField(format);
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x000A9A80 File Offset: 0x000A7C80
		public static bool IsASTCFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsASTCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x00013279 File Offset: 0x00011479
		public static bool IsHDRFormat(GraphicsFormat format)
		{
			return GraphicsFormatUtility.IsHDRFormatDelegateField(format);
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x00013286 File Offset: 0x00011486
		public static bool IsHDRFormat_Native_TextureFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsHDRFormat_Native_TextureFormatDelegateField(format);
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x000A9AA0 File Offset: 0x000A7CA0
		public static bool IsHDRFormat(TextureFormat format)
		{
			return GraphicsFormatUtility.IsHDRFormat_Native_TextureFormat(format);
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x000A9AB8 File Offset: 0x000A7CB8
		public static UnityEngine.Rendering.FormatSwizzle GetSwizzleR(TextureFormat format)
		{
			return GraphicsFormatUtility.GetSwizzleR(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x000A9AD8 File Offset: 0x000A7CD8
		public static UnityEngine.Rendering.FormatSwizzle GetSwizzleG(TextureFormat format)
		{
			return GraphicsFormatUtility.GetSwizzleG(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x000A9AF8 File Offset: 0x000A7CF8
		public static UnityEngine.Rendering.FormatSwizzle GetSwizzleB(TextureFormat format)
		{
			return GraphicsFormatUtility.GetSwizzleB(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x000A9B18 File Offset: 0x000A7D18
		public static UnityEngine.Rendering.FormatSwizzle GetSwizzleA(TextureFormat format)
		{
			return GraphicsFormatUtility.GetSwizzleA(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x000A9B38 File Offset: 0x000A7D38
		public static uint GetBlockSize(TextureFormat format)
		{
			return GraphicsFormatUtility.GetBlockSize(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x00013293 File Offset: 0x00011493
		public static uint GetBlockWidth(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetBlockWidthDelegateField(format);
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x000A9B58 File Offset: 0x000A7D58
		public static uint GetBlockWidth(TextureFormat format)
		{
			return GraphicsFormatUtility.GetBlockWidth(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x000132A0 File Offset: 0x000114A0
		public static uint GetBlockHeight(GraphicsFormat format)
		{
			return GraphicsFormatUtility.GetBlockHeightDelegateField(format);
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x000A9B78 File Offset: 0x000A7D78
		public static uint GetBlockHeight(TextureFormat format)
		{
			return GraphicsFormatUtility.GetBlockHeight(GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x000A9B98 File Offset: 0x000A7D98
		public static uint ComputeMipmapSize(int width, int height, GraphicsFormat format)
		{
			return GraphicsFormatUtility.ComputeMipChainSize_Native_2D(width, height, format, 1);
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x000A9BB4 File Offset: 0x000A7DB4
		public static uint ComputeMipmapSize(int width, int height, TextureFormat format)
		{
			return GraphicsFormatUtility.ComputeMipmapSize(width, height, GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x000132AD File Offset: 0x000114AD
		public static uint ComputeMipChainSize_Native_2D(int width, int height, GraphicsFormat format, int mipCount)
		{
			return GraphicsFormatUtility.ComputeMipChainSize_Native_2DDelegateField(width, height, format, mipCount);
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x000A9BD4 File Offset: 0x000A7DD4
		public static uint ComputeMipChainSize(int width, int height, GraphicsFormat format, [Optional] int mipCount)
		{
			return GraphicsFormatUtility.ComputeMipChainSize_Native_2D(width, height, format, mipCount);
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x000A9BF0 File Offset: 0x000A7DF0
		public static uint ComputeMipChainSize(int width, int height, TextureFormat format, [Optional] int mipCount)
		{
			return GraphicsFormatUtility.ComputeMipChainSize_Native_2D(width, height, GraphicsFormatUtility.GetGraphicsFormat(format, false), mipCount);
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x000A9C14 File Offset: 0x000A7E14
		public static uint ComputeMipmapSize(int width, int height, int depth, GraphicsFormat format)
		{
			return GraphicsFormatUtility.ComputeMipChainSize_Native_3D(width, height, depth, format, 1);
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x000A9C30 File Offset: 0x000A7E30
		public static uint ComputeMipmapSize(int width, int height, int depth, TextureFormat format)
		{
			return GraphicsFormatUtility.ComputeMipmapSize(width, height, depth, GraphicsFormatUtility.GetGraphicsFormat(format, false));
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x000132BD File Offset: 0x000114BD
		public static uint ComputeMipChainSize_Native_3D(int width, int height, int depth, GraphicsFormat format, int mipCount)
		{
			return GraphicsFormatUtility.ComputeMipChainSize_Native_3DDelegateField(width, height, depth, format, mipCount);
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x000A9C54 File Offset: 0x000A7E54
		public static uint ComputeMipChainSize(int width, int height, int depth, GraphicsFormat format, [Optional] int mipCount)
		{
			return GraphicsFormatUtility.ComputeMipChainSize_Native_3D(width, height, depth, format, mipCount);
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x000A9C74 File Offset: 0x000A7E74
		public static uint ComputeMipChainSize(int width, int height, int depth, TextureFormat format, [Optional] int mipCount)
		{
			return GraphicsFormatUtility.ComputeMipChainSize_Native_3D(width, height, depth, GraphicsFormatUtility.GetGraphicsFormat(format, false), mipCount);
		}

		// Token: 0x040025EF RID: 9711
		private static readonly IntPtr NativeFieldInfoPtr_tableNoStencil;

		// Token: 0x040025F0 RID: 9712
		private static readonly IntPtr NativeFieldInfoPtr_tableStencil;

		// Token: 0x040025F1 RID: 9713
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Internal_Static_GraphicsFormat_Texture_0;

		// Token: 0x040025F2 RID: 9714
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0;

		// Token: 0x040025F3 RID: 9715
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0;

		// Token: 0x040025F4 RID: 9716
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0;

		// Token: 0x040025F5 RID: 9717
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0;

		// Token: 0x040025F6 RID: 9718
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0;

		// Token: 0x040025F7 RID: 9719
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthStencilFormatFromBitsLegacy_Native_Private_Static_GraphicsFormat_Int32_0;

		// Token: 0x040025F8 RID: 9720
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthStencilFormat_Internal_Static_GraphicsFormat_Int32_0;

		// Token: 0x040025F9 RID: 9721
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthBits_Public_Static_Int32_GraphicsFormat_0;

		// Token: 0x040025FA RID: 9722
		private static readonly IntPtr NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_Int32_0;

		// Token: 0x040025FB RID: 9723
		private static readonly IntPtr NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0;

		// Token: 0x040025FC RID: 9724
		private static readonly IntPtr NativeMethodInfoPtr_GetSRGBFormat_Public_Static_GraphicsFormat_GraphicsFormat_0;

		// Token: 0x040025FD RID: 9725
		private static readonly IntPtr NativeMethodInfoPtr_GetLinearFormat_Public_Static_GraphicsFormat_GraphicsFormat_0;

		// Token: 0x040025FE RID: 9726
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderTextureFormat_Public_Static_RenderTextureFormat_GraphicsFormat_0;

		// Token: 0x040025FF RID: 9727
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentCount_Public_Static_UInt32_GraphicsFormat_0;

		// Token: 0x04002600 RID: 9728
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatString_Public_Static_String_GraphicsFormat_0;

		// Token: 0x04002601 RID: 9729
		private static readonly IntPtr NativeMethodInfoPtr_IsCompressedFormat_Native_TextureFormat_Private_Static_Boolean_TextureFormat_0;

		// Token: 0x04002602 RID: 9730
		private static readonly IntPtr NativeMethodInfoPtr_IsCompressedFormat_Public_Static_Boolean_TextureFormat_0;

		// Token: 0x04002603 RID: 9731
		private static readonly IntPtr NativeMethodInfoPtr_CanDecompressFormat_Private_Static_Boolean_GraphicsFormat_Boolean_0;

		// Token: 0x04002604 RID: 9732
		private static readonly IntPtr NativeMethodInfoPtr_CanDecompressFormat_Internal_Static_Boolean_GraphicsFormat_0;

		// Token: 0x04002605 RID: 9733
		private static readonly IntPtr NativeMethodInfoPtr_IsAlphaOnlyFormat_Public_Static_Boolean_GraphicsFormat_0;

		// Token: 0x04002606 RID: 9734
		private static readonly IntPtr NativeMethodInfoPtr_IsDepthStencilFormat_Public_Static_Boolean_GraphicsFormat_0;

		// Token: 0x04002607 RID: 9735
		private static readonly IntPtr NativeMethodInfoPtr_IsPVRTCFormat_Public_Static_Boolean_GraphicsFormat_0;

		// Token: 0x04002608 RID: 9736
		private static readonly IntPtr NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0;

		// Token: 0x04002609 RID: 9737
		private static readonly IntPtr NativeMethodInfoPtr_GetSwizzleR_Public_Static_FormatSwizzle_GraphicsFormat_0;

		// Token: 0x0400260A RID: 9738
		private static readonly IntPtr NativeMethodInfoPtr_GetSwizzleG_Public_Static_FormatSwizzle_GraphicsFormat_0;

		// Token: 0x0400260B RID: 9739
		private static readonly IntPtr NativeMethodInfoPtr_GetSwizzleB_Public_Static_FormatSwizzle_GraphicsFormat_0;

		// Token: 0x0400260C RID: 9740
		private static readonly IntPtr NativeMethodInfoPtr_GetSwizzleA_Public_Static_FormatSwizzle_GraphicsFormat_0;

		// Token: 0x0400260D RID: 9741
		private static readonly IntPtr NativeMethodInfoPtr_GetBlockSize_Public_Static_UInt32_GraphicsFormat_0;

		// Token: 0x0400260E RID: 9742
		private static readonly GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegate GetTextureFormat_Native_GraphicsFormatDelegateField;

		// Token: 0x0400260F RID: 9743
		private static readonly GraphicsFormatUtility.IsSwizzleFormatDelegate IsSwizzleFormatDelegateField;

		// Token: 0x04002610 RID: 9744
		private static readonly GraphicsFormatUtility.GetColorComponentCountDelegate GetColorComponentCountDelegateField;

		// Token: 0x04002611 RID: 9745
		private static readonly GraphicsFormatUtility.GetAlphaComponentCountDelegate GetAlphaComponentCountDelegateField;

		// Token: 0x04002612 RID: 9746
		private static readonly GraphicsFormatUtility.GetFormatString_Native_TextureFormatDelegate GetFormatString_Native_TextureFormatDelegateField;

		// Token: 0x04002613 RID: 9747
		private static readonly GraphicsFormatUtility.IsCompressedFormatDelegate IsCompressedFormatDelegateField;

		// Token: 0x04002614 RID: 9748
		private static readonly GraphicsFormatUtility.IsPackedFormatDelegate IsPackedFormatDelegateField;

		// Token: 0x04002615 RID: 9749
		private static readonly GraphicsFormatUtility.Is16BitPackedFormatDelegate Is16BitPackedFormatDelegateField;

		// Token: 0x04002616 RID: 9750
		private static readonly GraphicsFormatUtility.ConvertToAlphaFormatDelegate ConvertToAlphaFormatDelegateField;

		// Token: 0x04002617 RID: 9751
		private static readonly GraphicsFormatUtility.ConvertToAlphaFormat_Native_TextureFormatDelegate ConvertToAlphaFormat_Native_TextureFormatDelegateField;

		// Token: 0x04002618 RID: 9752
		private static readonly GraphicsFormatUtility.IsAlphaOnlyFormat_Native_TextureFormatDelegate IsAlphaOnlyFormat_Native_TextureFormatDelegateField;

		// Token: 0x04002619 RID: 9753
		private static readonly GraphicsFormatUtility.IsAlphaTestFormatDelegate IsAlphaTestFormatDelegateField;

		// Token: 0x0400261A RID: 9754
		private static readonly GraphicsFormatUtility.HasAlphaChannelDelegate HasAlphaChannelDelegateField;

		// Token: 0x0400261B RID: 9755
		private static readonly GraphicsFormatUtility.HasAlphaChannel_Native_TextureFormatDelegate HasAlphaChannel_Native_TextureFormatDelegateField;

		// Token: 0x0400261C RID: 9756
		private static readonly GraphicsFormatUtility.IsDepthFormatDelegate IsDepthFormatDelegateField;

		// Token: 0x0400261D RID: 9757
		private static readonly GraphicsFormatUtility.IsStencilFormatDelegate IsStencilFormatDelegateField;

		// Token: 0x0400261E RID: 9758
		private static readonly GraphicsFormatUtility.IsIEEE754FormatDelegate IsIEEE754FormatDelegateField;

		// Token: 0x0400261F RID: 9759
		private static readonly GraphicsFormatUtility.IsFloatFormatDelegate IsFloatFormatDelegateField;

		// Token: 0x04002620 RID: 9760
		private static readonly GraphicsFormatUtility.IsHalfFormatDelegate IsHalfFormatDelegateField;

		// Token: 0x04002621 RID: 9761
		private static readonly GraphicsFormatUtility.IsUnsignedFormatDelegate IsUnsignedFormatDelegateField;

		// Token: 0x04002622 RID: 9762
		private static readonly GraphicsFormatUtility.IsSignedFormatDelegate IsSignedFormatDelegateField;

		// Token: 0x04002623 RID: 9763
		private static readonly GraphicsFormatUtility.IsNormFormatDelegate IsNormFormatDelegateField;

		// Token: 0x04002624 RID: 9764
		private static readonly GraphicsFormatUtility.IsUNormFormatDelegate IsUNormFormatDelegateField;

		// Token: 0x04002625 RID: 9765
		private static readonly GraphicsFormatUtility.IsSNormFormatDelegate IsSNormFormatDelegateField;

		// Token: 0x04002626 RID: 9766
		private static readonly GraphicsFormatUtility.IsIntegerFormatDelegate IsIntegerFormatDelegateField;

		// Token: 0x04002627 RID: 9767
		private static readonly GraphicsFormatUtility.IsUIntFormatDelegate IsUIntFormatDelegateField;

		// Token: 0x04002628 RID: 9768
		private static readonly GraphicsFormatUtility.IsSIntFormatDelegate IsSIntFormatDelegateField;

		// Token: 0x04002629 RID: 9769
		private static readonly GraphicsFormatUtility.IsXRFormatDelegate IsXRFormatDelegateField;

		// Token: 0x0400262A RID: 9770
		private static readonly GraphicsFormatUtility.IsDXTCFormatDelegate IsDXTCFormatDelegateField;

		// Token: 0x0400262B RID: 9771
		private static readonly GraphicsFormatUtility.IsRGTCFormatDelegate IsRGTCFormatDelegateField;

		// Token: 0x0400262C RID: 9772
		private static readonly GraphicsFormatUtility.IsBPTCFormatDelegate IsBPTCFormatDelegateField;

		// Token: 0x0400262D RID: 9773
		private static readonly GraphicsFormatUtility.IsBCFormatDelegate IsBCFormatDelegateField;

		// Token: 0x0400262E RID: 9774
		private static readonly GraphicsFormatUtility.IsETCFormatDelegate IsETCFormatDelegateField;

		// Token: 0x0400262F RID: 9775
		private static readonly GraphicsFormatUtility.IsEACFormatDelegate IsEACFormatDelegateField;

		// Token: 0x04002630 RID: 9776
		private static readonly GraphicsFormatUtility.IsASTCFormatDelegate IsASTCFormatDelegateField;

		// Token: 0x04002631 RID: 9777
		private static readonly GraphicsFormatUtility.IsHDRFormatDelegate IsHDRFormatDelegateField;

		// Token: 0x04002632 RID: 9778
		private static readonly GraphicsFormatUtility.IsHDRFormat_Native_TextureFormatDelegate IsHDRFormat_Native_TextureFormatDelegateField;

		// Token: 0x04002633 RID: 9779
		private static readonly GraphicsFormatUtility.GetBlockWidthDelegate GetBlockWidthDelegateField;

		// Token: 0x04002634 RID: 9780
		private static readonly GraphicsFormatUtility.GetBlockHeightDelegate GetBlockHeightDelegateField;

		// Token: 0x04002635 RID: 9781
		private static readonly GraphicsFormatUtility.ComputeMipChainSize_Native_2DDelegate ComputeMipChainSize_Native_2DDelegateField;

		// Token: 0x04002636 RID: 9782
		private static readonly GraphicsFormatUtility.ComputeMipChainSize_Native_3DDelegate ComputeMipChainSize_Native_3DDelegateField;

		// Token: 0x02000BF8 RID: 3064
		// (Invoke) Token: 0x060040BC RID: 16572
		private delegate TextureFormat GetTextureFormat_Native_GraphicsFormatDelegate(GraphicsFormat format);

		// Token: 0x02000BF9 RID: 3065
		// (Invoke) Token: 0x060040BE RID: 16574
		private delegate bool IsSwizzleFormatDelegate(GraphicsFormat format);

		// Token: 0x02000BFA RID: 3066
		// (Invoke) Token: 0x060040C0 RID: 16576
		private delegate uint GetColorComponentCountDelegate(GraphicsFormat format);

		// Token: 0x02000BFB RID: 3067
		// (Invoke) Token: 0x060040C2 RID: 16578
		private delegate uint GetAlphaComponentCountDelegate(GraphicsFormat format);

		// Token: 0x02000BFC RID: 3068
		// (Invoke) Token: 0x060040C4 RID: 16580
		private delegate IntPtr GetFormatString_Native_TextureFormatDelegate(TextureFormat format);

		// Token: 0x02000BFD RID: 3069
		// (Invoke) Token: 0x060040C6 RID: 16582
		private delegate bool IsCompressedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000BFE RID: 3070
		// (Invoke) Token: 0x060040C8 RID: 16584
		private delegate bool IsPackedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000BFF RID: 3071
		// (Invoke) Token: 0x060040CA RID: 16586
		private delegate bool Is16BitPackedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C00 RID: 3072
		// (Invoke) Token: 0x060040CC RID: 16588
		private delegate GraphicsFormat ConvertToAlphaFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C01 RID: 3073
		// (Invoke) Token: 0x060040CE RID: 16590
		private delegate TextureFormat ConvertToAlphaFormat_Native_TextureFormatDelegate(TextureFormat format);

		// Token: 0x02000C02 RID: 3074
		// (Invoke) Token: 0x060040D0 RID: 16592
		private delegate bool IsAlphaOnlyFormat_Native_TextureFormatDelegate(TextureFormat format);

		// Token: 0x02000C03 RID: 3075
		// (Invoke) Token: 0x060040D2 RID: 16594
		private delegate bool IsAlphaTestFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C04 RID: 3076
		// (Invoke) Token: 0x060040D4 RID: 16596
		private delegate bool HasAlphaChannelDelegate(GraphicsFormat format);

		// Token: 0x02000C05 RID: 3077
		// (Invoke) Token: 0x060040D6 RID: 16598
		private delegate bool HasAlphaChannel_Native_TextureFormatDelegate(TextureFormat format);

		// Token: 0x02000C06 RID: 3078
		// (Invoke) Token: 0x060040D8 RID: 16600
		private delegate bool IsDepthFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C07 RID: 3079
		// (Invoke) Token: 0x060040DA RID: 16602
		private delegate bool IsStencilFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C08 RID: 3080
		// (Invoke) Token: 0x060040DC RID: 16604
		private delegate bool IsIEEE754FormatDelegate(GraphicsFormat format);

		// Token: 0x02000C09 RID: 3081
		// (Invoke) Token: 0x060040DE RID: 16606
		private delegate bool IsFloatFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C0A RID: 3082
		// (Invoke) Token: 0x060040E0 RID: 16608
		private delegate bool IsHalfFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C0B RID: 3083
		// (Invoke) Token: 0x060040E2 RID: 16610
		private delegate bool IsUnsignedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C0C RID: 3084
		// (Invoke) Token: 0x060040E4 RID: 16612
		private delegate bool IsSignedFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C0D RID: 3085
		// (Invoke) Token: 0x060040E6 RID: 16614
		private delegate bool IsNormFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C0E RID: 3086
		// (Invoke) Token: 0x060040E8 RID: 16616
		private delegate bool IsUNormFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C0F RID: 3087
		// (Invoke) Token: 0x060040EA RID: 16618
		private delegate bool IsSNormFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C10 RID: 3088
		// (Invoke) Token: 0x060040EC RID: 16620
		private delegate bool IsIntegerFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C11 RID: 3089
		// (Invoke) Token: 0x060040EE RID: 16622
		private delegate bool IsUIntFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C12 RID: 3090
		// (Invoke) Token: 0x060040F0 RID: 16624
		private delegate bool IsSIntFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C13 RID: 3091
		// (Invoke) Token: 0x060040F2 RID: 16626
		private delegate bool IsXRFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C14 RID: 3092
		// (Invoke) Token: 0x060040F4 RID: 16628
		private delegate bool IsDXTCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C15 RID: 3093
		// (Invoke) Token: 0x060040F6 RID: 16630
		private delegate bool IsRGTCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C16 RID: 3094
		// (Invoke) Token: 0x060040F8 RID: 16632
		private delegate bool IsBPTCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C17 RID: 3095
		// (Invoke) Token: 0x060040FA RID: 16634
		private delegate bool IsBCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C18 RID: 3096
		// (Invoke) Token: 0x060040FC RID: 16636
		private delegate bool IsETCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C19 RID: 3097
		// (Invoke) Token: 0x060040FE RID: 16638
		private delegate bool IsEACFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C1A RID: 3098
		// (Invoke) Token: 0x06004100 RID: 16640
		private delegate bool IsASTCFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C1B RID: 3099
		// (Invoke) Token: 0x06004102 RID: 16642
		private delegate bool IsHDRFormatDelegate(GraphicsFormat format);

		// Token: 0x02000C1C RID: 3100
		// (Invoke) Token: 0x06004104 RID: 16644
		private delegate bool IsHDRFormat_Native_TextureFormatDelegate(TextureFormat format);

		// Token: 0x02000C1D RID: 3101
		// (Invoke) Token: 0x06004106 RID: 16646
		private delegate uint GetBlockWidthDelegate(GraphicsFormat format);

		// Token: 0x02000C1E RID: 3102
		// (Invoke) Token: 0x06004108 RID: 16648
		private delegate uint GetBlockHeightDelegate(GraphicsFormat format);

		// Token: 0x02000C1F RID: 3103
		// (Invoke) Token: 0x0600410A RID: 16650
		private delegate uint ComputeMipChainSize_Native_2DDelegate(int width, int height, GraphicsFormat format, int mipCount);

		// Token: 0x02000C20 RID: 3104
		// (Invoke) Token: 0x0600410C RID: 16652
		private delegate uint ComputeMipChainSize_Native_3DDelegate(int width, int height, int depth, GraphicsFormat format, int mipCount);
	}
}
