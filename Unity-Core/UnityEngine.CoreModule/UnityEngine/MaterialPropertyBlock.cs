using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000A6 RID: 166
	public sealed class MaterialPropertyBlock : Object
	{
		// Token: 0x06000AED RID: 2797 RVA: 0x00037DA4 File Offset: 0x00035FA4
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialPropertyBlock()
		{
			Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MaterialPropertyBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr);
			MaterialPropertyBlock.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, "m_Ptr");
			MaterialPropertyBlock.NativeMethodInfoPtr_SetIntImpl_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664317);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664318);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorImpl_Private_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664319);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664320);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664321);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664322);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetRenderTextureImpl_Private_Void_Int32_RenderTexture_RenderTextureSubElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664323);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664324);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664325);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664326);
			MaterialPropertyBlock.NativeMethodInfoPtr_CreateImpl_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664327);
			MaterialPropertyBlock.NativeMethodInfoPtr_DestroyImpl_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664328);
			MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664329);
			MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664330);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664331);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664332);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixArray_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664333);
			MaterialPropertyBlock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664334);
			MaterialPropertyBlock.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664335);
			MaterialPropertyBlock.NativeMethodInfoPtr_Dispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664336);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664337);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664338);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664339);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664340);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetInteger_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664341);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664342);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664343);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664344);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664345);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrix_Public_Void_String_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664346);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664347);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664348);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_RenderTexture_RenderTextureSubElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664349);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArray_Public_Void_String_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664350);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Public_Void_String_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664351);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664352);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixArray_Public_Void_String_Il2CppStructArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664353);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorImpl_Injected_Private_Void_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664354);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetColorImpl_Injected_Private_Void_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664355);
			MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664356);
			MaterialPropertyBlock.GetIntImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetIntImplDelegate>("UnityEngine.MaterialPropertyBlock::GetIntImpl");
			MaterialPropertyBlock.GetFloatImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetFloatImplDelegate>("UnityEngine.MaterialPropertyBlock::GetFloatImpl");
			MaterialPropertyBlock.GetTextureImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetTextureImplDelegate>("UnityEngine.MaterialPropertyBlock::GetTextureImpl");
			MaterialPropertyBlock.HasPropertyImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasPropertyImplDelegate>("UnityEngine.MaterialPropertyBlock::HasPropertyImpl");
			MaterialPropertyBlock.HasFloatImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasFloatImplDelegate>("UnityEngine.MaterialPropertyBlock::HasFloatImpl");
			MaterialPropertyBlock.HasIntImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasIntImplDelegate>("UnityEngine.MaterialPropertyBlock::HasIntImpl");
			MaterialPropertyBlock.HasTextureImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasTextureImplDelegate>("UnityEngine.MaterialPropertyBlock::HasTextureImpl");
			MaterialPropertyBlock.HasMatrixImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasMatrixImplDelegate>("UnityEngine.MaterialPropertyBlock::HasMatrixImpl");
			MaterialPropertyBlock.HasVectorImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasVectorImplDelegate>("UnityEngine.MaterialPropertyBlock::HasVectorImpl");
			MaterialPropertyBlock.HasBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::HasBufferImpl");
			MaterialPropertyBlock.HasConstantBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasConstantBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::HasConstantBufferImpl");
			MaterialPropertyBlock.SetBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::SetBufferImpl");
			MaterialPropertyBlock.SetGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetGraphicsBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::SetGraphicsBufferImpl");
			MaterialPropertyBlock.SetConstantBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetConstantBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::SetConstantBufferImpl");
			MaterialPropertyBlock.SetConstantGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetConstantGraphicsBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::SetConstantGraphicsBufferImpl");
			MaterialPropertyBlock.GetFloatArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetFloatArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::GetFloatArrayImpl");
			MaterialPropertyBlock.GetVectorArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetVectorArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::GetVectorArrayImpl");
			MaterialPropertyBlock.GetMatrixArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetMatrixArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixArrayImpl");
			MaterialPropertyBlock.GetFloatArrayCountImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetFloatArrayCountImplDelegate>("UnityEngine.MaterialPropertyBlock::GetFloatArrayCountImpl");
			MaterialPropertyBlock.GetVectorArrayCountImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetVectorArrayCountImplDelegate>("UnityEngine.MaterialPropertyBlock::GetVectorArrayCountImpl");
			MaterialPropertyBlock.GetMatrixArrayCountImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetMatrixArrayCountImplDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixArrayCountImpl");
			MaterialPropertyBlock.ExtractFloatArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.ExtractFloatArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::ExtractFloatArrayImpl");
			MaterialPropertyBlock.ExtractVectorArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.ExtractVectorArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::ExtractVectorArrayImpl");
			MaterialPropertyBlock.ExtractMatrixArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.ExtractMatrixArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::ExtractMatrixArrayImpl");
			MaterialPropertyBlock.Internal_CopySHCoefficientArraysFromDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.Internal_CopySHCoefficientArraysFromDelegate>("UnityEngine.MaterialPropertyBlock::Internal_CopySHCoefficientArraysFrom");
			MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFromDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFromDelegate>("UnityEngine.MaterialPropertyBlock::Internal_CopyProbeOcclusionArrayFrom");
			MaterialPropertyBlock.get_isEmptyDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.get_isEmptyDelegate>("UnityEngine.MaterialPropertyBlock::get_isEmpty");
			MaterialPropertyBlock.GetVectorImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetVectorImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetVectorImpl_Injected");
			MaterialPropertyBlock.GetColorImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetColorImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetColorImpl_Injected");
			MaterialPropertyBlock.GetMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetMatrixImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixImpl_Injected");
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x000382CC File Offset: 0x000364CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1234666, RefRangeEnd = 1234669, XrefRangeStart = 1234664, XrefRangeEnd = 1234666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIntImpl(int name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetIntImpl_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00038318 File Offset: 0x00036518
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 1234671, RefRangeEnd = 1234700, XrefRangeStart = 1234669, XrefRangeEnd = 1234671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatImpl(int name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00038364 File Offset: 0x00036564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234700, XrefRangeEnd = 1234702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorImpl(int name, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorImpl_Private_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x000383B0 File Offset: 0x000365B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234702, XrefRangeEnd = 1234704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColorImpl(int name, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x000383FC File Offset: 0x000365FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234704, XrefRangeEnd = 1234706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixImpl(int name, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00038448 File Offset: 0x00036648
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1234708, RefRangeEnd = 1234727, XrefRangeStart = 1234706, XrefRangeEnd = 1234708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextureImpl(int name, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00038498 File Offset: 0x00036698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234729, RefRangeEnd = 1234730, XrefRangeStart = 1234727, XrefRangeEnd = 1234729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderTextureImpl(int name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref element;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetRenderTextureImpl_Private_Void_Int32_RenderTexture_RenderTextureSubElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x000384F8 File Offset: 0x000366F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234730, XrefRangeEnd = 1234732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatArrayImpl(int name, Il2CppStructArray<float> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00038558 File Offset: 0x00036758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234732, XrefRangeEnd = 1234734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorArrayImpl(int name, Il2CppStructArray<Vector4> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x000385B8 File Offset: 0x000367B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234734, XrefRangeEnd = 1234736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixArrayImpl(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00038618 File Offset: 0x00036818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234736, XrefRangeEnd = 1234738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateImpl()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_CreateImpl_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00038648 File Offset: 0x00036848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234738, XrefRangeEnd = 1234740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyImpl(IntPtr mpb)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mpb;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_DestroyImpl_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0003867C File Offset: 0x0003687C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234740, XrefRangeEnd = 1234742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(bool keepMemory)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref keepMemory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x000386BC File Offset: 0x000368BC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1234744, RefRangeEnd = 1234753, XrefRangeStart = 1234742, XrefRangeEnd = 1234744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x000386F0 File Offset: 0x000368F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234753, XrefRangeEnd = 1234773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatArray(int name, Il2CppStructArray<float> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00038750 File Offset: 0x00036950
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1234793, RefRangeEnd = 1234795, XrefRangeStart = 1234773, XrefRangeEnd = 1234793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorArray(int name, Il2CppStructArray<Vector4> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x000387B0 File Offset: 0x000369B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234795, XrefRangeEnd = 1234815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixArray(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixArray_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00038810 File Offset: 0x00036A10
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1234818, RefRangeEnd = 1234839, XrefRangeStart = 1234815, XrefRangeEnd = 1234818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialPropertyBlock() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0003884C File Offset: 0x00036A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234839, XrefRangeEnd = 1234849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00038880 File Offset: 0x00036A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234849, XrefRangeEnd = 1234856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_Dispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x000388B4 File Offset: 0x00036AB4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1234860, RefRangeEnd = 1234867, XrefRangeStart = 1234856, XrefRangeEnd = 1234860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInt(string name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00038904 File Offset: 0x00036B04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1234869, RefRangeEnd = 1234874, XrefRangeStart = 1234867, XrefRangeEnd = 1234869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInt(int nameID, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00038950 File Offset: 0x00036B50
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1234878, RefRangeEnd = 1234895, XrefRangeStart = 1234874, XrefRangeEnd = 1234878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloat(string name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x000389A0 File Offset: 0x00036BA0
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 1234671, RefRangeEnd = 1234700, XrefRangeStart = 1234671, XrefRangeEnd = 1234700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloat(int nameID, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x000389EC File Offset: 0x00036BEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1234666, RefRangeEnd = 1234669, XrefRangeStart = 1234666, XrefRangeEnd = 1234669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteger(int nameID, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetInteger_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00038A38 File Offset: 0x00036C38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1234899, RefRangeEnd = 1234903, XrefRangeStart = 1234895, XrefRangeEnd = 1234899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVector(string name, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00038A88 File Offset: 0x00036C88
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 1234905, RefRangeEnd = 1234942, XrefRangeStart = 1234903, XrefRangeEnd = 1234905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVector(int nameID, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00038AD4 File Offset: 0x00036CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234946, RefRangeEnd = 1234947, XrefRangeStart = 1234942, XrefRangeEnd = 1234946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(string name, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00038B24 File Offset: 0x00036D24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1234949, RefRangeEnd = 1234954, XrefRangeStart = 1234947, XrefRangeEnd = 1234949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(int nameID, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00038B70 File Offset: 0x00036D70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1234958, RefRangeEnd = 1234960, XrefRangeStart = 1234954, XrefRangeEnd = 1234958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrix(string name, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrix_Public_Void_String_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00038BC0 File Offset: 0x00036DC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1234962, RefRangeEnd = 1234965, XrefRangeStart = 1234960, XrefRangeEnd = 1234962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrix(int nameID, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00038C0C File Offset: 0x00036E0C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1234708, RefRangeEnd = 1234727, XrefRangeStart = 1234708, XrefRangeEnd = 1234727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(int nameID, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00038C5C File Offset: 0x00036E5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234729, RefRangeEnd = 1234730, XrefRangeStart = 1234729, XrefRangeEnd = 1234730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(int nameID, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref element;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_RenderTexture_RenderTextureSubElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00038CBC File Offset: 0x00036EBC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1234976, RefRangeEnd = 1234981, XrefRangeStart = 1234965, XrefRangeEnd = 1234976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatArray(string name, Il2CppStructArray<float> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArray_Public_Void_String_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00038D10 File Offset: 0x00036F10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1234984, RefRangeEnd = 1234986, XrefRangeStart = 1234981, XrefRangeEnd = 1234984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Public_Void_String_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00038D64 File Offset: 0x00036F64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234987, RefRangeEnd = 1234988, XrefRangeStart = 1234986, XrefRangeEnd = 1234987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00038DB4 File Offset: 0x00036FB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1234999, RefRangeEnd = 1235001, XrefRangeStart = 1234988, XrefRangeEnd = 1234999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixArray_Public_Void_String_Il2CppStructArray_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00038E08 File Offset: 0x00037008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235001, XrefRangeEnd = 1235003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorImpl_Injected(int name, ref Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorImpl_Injected_Private_Void_Int32_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00038E54 File Offset: 0x00037054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235003, XrefRangeEnd = 1235005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColorImpl_Injected(int name, ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetColorImpl_Injected_Private_Void_Int32_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00038EA0 File Offset: 0x000370A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235005, XrefRangeEnd = 1235007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixImpl_Injected(int name, ref Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00007172 File Offset: 0x00005372
		public MaterialPropertyBlock(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00038EEC File Offset: 0x000370EC
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x0000717B File Offset: 0x0000537B
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPropertyBlock.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialPropertyBlock.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00007196 File Offset: 0x00005396
		public void AddFloat(string name, float value)
		{
			this.SetFloat(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x000071A7 File Offset: 0x000053A7
		public void AddFloat(int nameID, float value)
		{
			this.SetFloat(nameID, value);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x000071B3 File Offset: 0x000053B3
		public void AddVector(string name, Vector4 value)
		{
			this.SetVector(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x000071C4 File Offset: 0x000053C4
		public void AddVector(int nameID, Vector4 value)
		{
			this.SetVector(nameID, value);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x000071D0 File Offset: 0x000053D0
		public void AddColor(string name, Color value)
		{
			this.SetColor(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x000071E1 File Offset: 0x000053E1
		public void AddColor(int nameID, Color value)
		{
			this.SetColor(nameID, value);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x000071ED File Offset: 0x000053ED
		public void AddMatrix(string name, Matrix4x4 value)
		{
			this.SetMatrix(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x000071FE File Offset: 0x000053FE
		public void AddMatrix(int nameID, Matrix4x4 value)
		{
			this.SetMatrix(nameID, value);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0000720A File Offset: 0x0000540A
		public void AddTexture(string name, Texture value)
		{
			this.SetTexture(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0000721B File Offset: 0x0000541B
		public void AddTexture(int nameID, Texture value)
		{
			this.SetTexture(nameID, value);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00007227 File Offset: 0x00005427
		public int GetIntImpl(int name)
		{
			return MaterialPropertyBlock.GetIntImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0000723A File Offset: 0x0000543A
		public float GetFloatImpl(int name)
		{
			return MaterialPropertyBlock.GetFloatImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00038F14 File Offset: 0x00037114
		public Vector4 GetVectorImpl(int name)
		{
			Vector4 result;
			this.GetVectorImpl_Injected(name, out result);
			return result;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00038F2C File Offset: 0x0003712C
		public Color GetColorImpl(int name)
		{
			Color result;
			this.GetColorImpl_Injected(name, out result);
			return result;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00038F44 File Offset: 0x00037144
		public Matrix4x4 GetMatrixImpl(int name)
		{
			Matrix4x4 result;
			this.GetMatrixImpl_Injected(name, out result);
			return result;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00038F5C File Offset: 0x0003715C
		public Texture GetTextureImpl(int name)
		{
			IntPtr intPtr = MaterialPropertyBlock.GetTextureImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0000724D File Offset: 0x0000544D
		public bool HasPropertyImpl(int name)
		{
			return MaterialPropertyBlock.HasPropertyImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00007260 File Offset: 0x00005460
		public bool HasFloatImpl(int name)
		{
			return MaterialPropertyBlock.HasFloatImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00007273 File Offset: 0x00005473
		public bool HasIntImpl(int name)
		{
			return MaterialPropertyBlock.HasIntImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00007286 File Offset: 0x00005486
		public bool HasTextureImpl(int name)
		{
			return MaterialPropertyBlock.HasTextureImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00007299 File Offset: 0x00005499
		public bool HasMatrixImpl(int name)
		{
			return MaterialPropertyBlock.HasMatrixImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x000072AC File Offset: 0x000054AC
		public bool HasVectorImpl(int name)
		{
			return MaterialPropertyBlock.HasVectorImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x000072BF File Offset: 0x000054BF
		public bool HasBufferImpl(int name)
		{
			return MaterialPropertyBlock.HasBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x000072D2 File Offset: 0x000054D2
		public bool HasConstantBufferImpl(int name)
		{
			return MaterialPropertyBlock.HasConstantBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x000072E5 File Offset: 0x000054E5
		public void SetBufferImpl(int name, ComputeBuffer value)
		{
			MaterialPropertyBlock.SetBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x000072FE File Offset: 0x000054FE
		public void SetGraphicsBufferImpl(int name, GraphicsBuffer value)
		{
			MaterialPropertyBlock.SetGraphicsBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00007317 File Offset: 0x00005517
		public void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
		{
			MaterialPropertyBlock.SetConstantBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00007333 File Offset: 0x00005533
		public void SetConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size)
		{
			MaterialPropertyBlock.SetConstantGraphicsBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00038F8C File Offset: 0x0003718C
		public Il2CppStructArray<float> GetFloatArrayImpl(int name)
		{
			IntPtr intPtr = MaterialPropertyBlock.GetFloatArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00038FBC File Offset: 0x000371BC
		public Il2CppStructArray<Vector4> GetVectorArrayImpl(int name)
		{
			IntPtr intPtr = MaterialPropertyBlock.GetVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00038FEC File Offset: 0x000371EC
		public Il2CppStructArray<Matrix4x4> GetMatrixArrayImpl(int name)
		{
			IntPtr intPtr = MaterialPropertyBlock.GetMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0000734F File Offset: 0x0000554F
		public int GetFloatArrayCountImpl(int name)
		{
			return MaterialPropertyBlock.GetFloatArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00007362 File Offset: 0x00005562
		public int GetVectorArrayCountImpl(int name)
		{
			return MaterialPropertyBlock.GetVectorArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00007375 File Offset: 0x00005575
		public int GetMatrixArrayCountImpl(int name)
		{
			return MaterialPropertyBlock.GetMatrixArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00007388 File Offset: 0x00005588
		public void ExtractFloatArrayImpl(int name, [Out] Il2CppStructArray<float> val)
		{
			MaterialPropertyBlock.ExtractFloatArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x000073A1 File Offset: 0x000055A1
		public void ExtractVectorArrayImpl(int name, [Out] Il2CppStructArray<Vector4> val)
		{
			MaterialPropertyBlock.ExtractVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x000073BA File Offset: 0x000055BA
		public void ExtractMatrixArrayImpl(int name, [Out] Il2CppStructArray<Matrix4x4> val)
		{
			MaterialPropertyBlock.ExtractMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x000073D3 File Offset: 0x000055D3
		public static void Internal_CopySHCoefficientArraysFrom(MaterialPropertyBlock properties, Il2CppStructArray<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, int sourceStart, int destStart, int count)
		{
			MaterialPropertyBlock.Internal_CopySHCoefficientArraysFromDelegateField(IL2CPP.Il2CppObjectBaseToPtr(properties), IL2CPP.Il2CppObjectBaseToPtr(lightProbes), sourceStart, destStart, count);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x000073EF File Offset: 0x000055EF
		public static void Internal_CopyProbeOcclusionArrayFrom(MaterialPropertyBlock properties, Il2CppStructArray<Vector4> occlusionProbes, int sourceStart, int destStart, int count)
		{
			MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFromDelegateField(IL2CPP.Il2CppObjectBaseToPtr(properties), IL2CPP.Il2CppObjectBaseToPtr(occlusionProbes), sourceStart, destStart, count);
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x0000740B File Offset: 0x0000560B
		public bool isEmpty
		{
			get
			{
				return MaterialPropertyBlock.get_isEmptyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0003901C File Offset: 0x0003721C
		public void ExtractFloatArray(int name, List<float> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int floatArrayCountImpl = this.GetFloatArrayCountImpl(name);
			bool flag2 = floatArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<float>(values, floatArrayCountImpl);
				this.ExtractFloatArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<float>>());
			}
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00039074 File Offset: 0x00037274
		public void ExtractVectorArray(int name, List<Vector4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int vectorArrayCountImpl = this.GetVectorArrayCountImpl(name);
			bool flag2 = vectorArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Vector4>(values, vectorArrayCountImpl);
				this.ExtractVectorArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Vector4>>());
			}
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x000390CC File Offset: 0x000372CC
		public void ExtractMatrixArray(int name, List<Matrix4x4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int matrixArrayCountImpl = this.GetMatrixArrayCountImpl(name);
			bool flag2 = matrixArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Matrix4x4>(values, matrixArrayCountImpl);
				this.ExtractMatrixArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Matrix4x4>>());
			}
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0000741D File Offset: 0x0000561D
		public void SetInteger(string name, int value)
		{
			this.SetIntImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0000742E File Offset: 0x0000562E
		public void SetBuffer(string name, ComputeBuffer value)
		{
			this.SetBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0000743F File Offset: 0x0000563F
		public void SetBuffer(int nameID, ComputeBuffer value)
		{
			this.SetBufferImpl(nameID, value);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0000744B File Offset: 0x0000564B
		public void SetBuffer(string name, GraphicsBuffer value)
		{
			this.SetGraphicsBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0000745C File Offset: 0x0000565C
		public void SetBuffer(int nameID, GraphicsBuffer value)
		{
			this.SetGraphicsBufferImpl(nameID, value);
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00007468 File Offset: 0x00005668
		public void SetTexture(string name, Texture value)
		{
			this.SetTextureImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00007479 File Offset: 0x00005679
		public void SetTexture(string name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTextureImpl(Shader.PropertyToID(name), value, element);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0000748B File Offset: 0x0000568B
		public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size)
		{
			this.SetConstantBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0000749F File Offset: 0x0000569F
		public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
		{
			this.SetConstantBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x000074AE File Offset: 0x000056AE
		public void SetConstantBuffer(string name, GraphicsBuffer value, int offset, int size)
		{
			this.SetConstantGraphicsBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x000074C2 File Offset: 0x000056C2
		public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size)
		{
			this.SetConstantGraphicsBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x000074D1 File Offset: 0x000056D1
		public void SetFloatArray(string name, List<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x000074ED File Offset: 0x000056ED
		public void SetFloatArray(int nameID, List<float> values)
		{
			this.SetFloatArray(nameID, NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00007504 File Offset: 0x00005704
		public void SetFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(nameID, values, values.Length);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00007517 File Offset: 0x00005717
		public void SetVectorArray(string name, List<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00007533 File Offset: 0x00005733
		public void SetVectorArray(int nameID, List<Vector4> values)
		{
			this.SetVectorArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0000754A File Offset: 0x0000574A
		public void SetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00007566 File Offset: 0x00005766
		public void SetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			this.SetMatrixArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0000757D File Offset: 0x0000577D
		public void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(nameID, values, values.Length);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00039124 File Offset: 0x00037324
		public bool HasProperty(string name)
		{
			return this.HasPropertyImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00039144 File Offset: 0x00037344
		public bool HasProperty(int nameID)
		{
			return this.HasPropertyImpl(nameID);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00039160 File Offset: 0x00037360
		public bool HasInt(string name)
		{
			return this.HasFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00039180 File Offset: 0x00037380
		public bool HasInt(int nameID)
		{
			return this.HasFloatImpl(nameID);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0003919C File Offset: 0x0003739C
		public bool HasFloat(string name)
		{
			return this.HasFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x000391BC File Offset: 0x000373BC
		public bool HasFloat(int nameID)
		{
			return this.HasFloatImpl(nameID);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x000391D8 File Offset: 0x000373D8
		public bool HasInteger(string name)
		{
			return this.HasIntImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x000391F8 File Offset: 0x000373F8
		public bool HasInteger(int nameID)
		{
			return this.HasIntImpl(nameID);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00039214 File Offset: 0x00037414
		public bool HasTexture(string name)
		{
			return this.HasTextureImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00039234 File Offset: 0x00037434
		public bool HasTexture(int nameID)
		{
			return this.HasTextureImpl(nameID);
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00039250 File Offset: 0x00037450
		public bool HasMatrix(string name)
		{
			return this.HasMatrixImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00039270 File Offset: 0x00037470
		public bool HasMatrix(int nameID)
		{
			return this.HasMatrixImpl(nameID);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0003928C File Offset: 0x0003748C
		public bool HasVector(string name)
		{
			return this.HasVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x000392AC File Offset: 0x000374AC
		public bool HasVector(int nameID)
		{
			return this.HasVectorImpl(nameID);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x000392C8 File Offset: 0x000374C8
		public bool HasColor(string name)
		{
			return this.HasVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x000392E8 File Offset: 0x000374E8
		public bool HasColor(int nameID)
		{
			return this.HasVectorImpl(nameID);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00039304 File Offset: 0x00037504
		public bool HasBuffer(string name)
		{
			return this.HasBufferImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00039324 File Offset: 0x00037524
		public bool HasBuffer(int nameID)
		{
			return this.HasBufferImpl(nameID);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00039340 File Offset: 0x00037540
		public bool HasConstantBuffer(string name)
		{
			return this.HasConstantBufferImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00039360 File Offset: 0x00037560
		public bool HasConstantBuffer(int nameID)
		{
			return this.HasConstantBufferImpl(nameID);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0003937C File Offset: 0x0003757C
		public float GetFloat(string name)
		{
			return this.GetFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0003939C File Offset: 0x0003759C
		public float GetFloat(int nameID)
		{
			return this.GetFloatImpl(nameID);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x000393B8 File Offset: 0x000375B8
		public int GetInt(string name)
		{
			return (int)this.GetFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x000393D8 File Offset: 0x000375D8
		public int GetInt(int nameID)
		{
			return (int)this.GetFloatImpl(nameID);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x000393F4 File Offset: 0x000375F4
		public int GetInteger(string name)
		{
			return this.GetIntImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00039414 File Offset: 0x00037614
		public int GetInteger(int nameID)
		{
			return this.GetIntImpl(nameID);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00039430 File Offset: 0x00037630
		public Vector4 GetVector(string name)
		{
			return this.GetVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00039450 File Offset: 0x00037650
		public Vector4 GetVector(int nameID)
		{
			return this.GetVectorImpl(nameID);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0003946C File Offset: 0x0003766C
		public Color GetColor(string name)
		{
			return this.GetColorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0003948C File Offset: 0x0003768C
		public Color GetColor(int nameID)
		{
			return this.GetColorImpl(nameID);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x000394A8 File Offset: 0x000376A8
		public Matrix4x4 GetMatrix(string name)
		{
			return this.GetMatrixImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x000394C8 File Offset: 0x000376C8
		public Matrix4x4 GetMatrix(int nameID)
		{
			return this.GetMatrixImpl(nameID);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x000394E4 File Offset: 0x000376E4
		public Texture GetTexture(string name)
		{
			return this.GetTextureImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00039504 File Offset: 0x00037704
		public Texture GetTexture(int nameID)
		{
			return this.GetTextureImpl(nameID);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00039520 File Offset: 0x00037720
		public Il2CppStructArray<float> GetFloatArray(string name)
		{
			return this.GetFloatArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00039540 File Offset: 0x00037740
		public Il2CppStructArray<float> GetFloatArray(int nameID)
		{
			return (this.GetFloatArrayCountImpl(nameID) != 0) ? this.GetFloatArrayImpl(nameID) : null;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00039568 File Offset: 0x00037768
		public Il2CppStructArray<Vector4> GetVectorArray(string name)
		{
			return this.GetVectorArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00039588 File Offset: 0x00037788
		public Il2CppStructArray<Vector4> GetVectorArray(int nameID)
		{
			return (this.GetVectorArrayCountImpl(nameID) != 0) ? this.GetVectorArrayImpl(nameID) : null;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x000395B0 File Offset: 0x000377B0
		public Il2CppStructArray<Matrix4x4> GetMatrixArray(string name)
		{
			return this.GetMatrixArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x000395D0 File Offset: 0x000377D0
		public Il2CppStructArray<Matrix4x4> GetMatrixArray(int nameID)
		{
			return (this.GetMatrixArrayCountImpl(nameID) != 0) ? this.GetMatrixArrayImpl(nameID) : null;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00007590 File Offset: 0x00005790
		public void GetFloatArray(string name, List<float> values)
		{
			this.ExtractFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x000075A1 File Offset: 0x000057A1
		public void GetFloatArray(int nameID, List<float> values)
		{
			this.ExtractFloatArray(nameID, values);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x000075AD File Offset: 0x000057AD
		public void GetVectorArray(string name, List<Vector4> values)
		{
			this.ExtractVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x000075BE File Offset: 0x000057BE
		public void GetVectorArray(int nameID, List<Vector4> values)
		{
			this.ExtractVectorArray(nameID, values);
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x000075CA File Offset: 0x000057CA
		public void GetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.ExtractMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x000075DB File Offset: 0x000057DB
		public void GetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			this.ExtractMatrixArray(nameID, values);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x000395F8 File Offset: 0x000377F8
		public void CopySHCoefficientArraysFrom(List<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes)
		{
			bool flag = lightProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("lightProbes");
			}
			this.CopySHCoefficientArraysFrom(NoAllocHelpers.ExtractArrayFromListT<UnityEngine.Rendering.SphericalHarmonicsL2>(lightProbes), 0, 0, lightProbes.Count);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00039630 File Offset: 0x00037830
		public void CopySHCoefficientArraysFrom(Il2CppStructArray<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes)
		{
			bool flag = lightProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("lightProbes");
			}
			this.CopySHCoefficientArraysFrom(lightProbes, 0, 0, lightProbes.Length);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x000075E7 File Offset: 0x000057E7
		public void CopySHCoefficientArraysFrom(List<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, int sourceStart, int destStart, int count)
		{
			this.CopySHCoefficientArraysFrom(NoAllocHelpers.ExtractArrayFromListT<UnityEngine.Rendering.SphericalHarmonicsL2>(lightProbes), sourceStart, destStart, count);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00039664 File Offset: 0x00037864
		public void CopySHCoefficientArraysFrom(Il2CppStructArray<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, int sourceStart, int destStart, int count)
		{
			bool flag = lightProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("lightProbes");
			}
			bool flag2 = sourceStart < 0;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("sourceStart", "Argument sourceStart must not be negative.");
			}
			bool flag3 = destStart < 0;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("sourceStart", "Argument destStart must not be negative.");
			}
			bool flag4 = count < 0;
			if (flag4)
			{
				throw new ArgumentOutOfRangeException("count", "Argument count must not be negative.");
			}
			bool flag5 = lightProbes.Length < sourceStart + count;
			if (flag5)
			{
				throw new ArgumentOutOfRangeException("The specified source start index or count is out of the range.");
			}
			MaterialPropertyBlock.Internal_CopySHCoefficientArraysFrom(this, lightProbes, sourceStart, destStart, count);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x000396F8 File Offset: 0x000378F8
		public void CopyProbeOcclusionArrayFrom(List<Vector4> occlusionProbes)
		{
			bool flag = occlusionProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("occlusionProbes");
			}
			this.CopyProbeOcclusionArrayFrom(NoAllocHelpers.ExtractArrayFromListT<Vector4>(occlusionProbes), 0, 0, occlusionProbes.Count);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00039730 File Offset: 0x00037930
		public void CopyProbeOcclusionArrayFrom(Il2CppStructArray<Vector4> occlusionProbes)
		{
			bool flag = occlusionProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("occlusionProbes");
			}
			this.CopyProbeOcclusionArrayFrom(occlusionProbes, 0, 0, occlusionProbes.Length);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x000075FB File Offset: 0x000057FB
		public void CopyProbeOcclusionArrayFrom(List<Vector4> occlusionProbes, int sourceStart, int destStart, int count)
		{
			this.CopyProbeOcclusionArrayFrom(NoAllocHelpers.ExtractArrayFromListT<Vector4>(occlusionProbes), sourceStart, destStart, count);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00039764 File Offset: 0x00037964
		public void CopyProbeOcclusionArrayFrom(Il2CppStructArray<Vector4> occlusionProbes, int sourceStart, int destStart, int count)
		{
			bool flag = occlusionProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("occlusionProbes");
			}
			bool flag2 = sourceStart < 0;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("sourceStart", "Argument sourceStart must not be negative.");
			}
			bool flag3 = destStart < 0;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("sourceStart", "Argument destStart must not be negative.");
			}
			bool flag4 = count < 0;
			if (flag4)
			{
				throw new ArgumentOutOfRangeException("count", "Argument count must not be negative.");
			}
			bool flag5 = occlusionProbes.Length < sourceStart + count;
			if (flag5)
			{
				throw new ArgumentOutOfRangeException("The specified source start index or count is out of the range.");
			}
			MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFrom(this, occlusionProbes, sourceStart, destStart, count);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0000760F File Offset: 0x0000580F
		public void GetVectorImpl_Injected(int name, out Vector4 ret)
		{
			MaterialPropertyBlock.GetVectorImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, out ret);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00007623 File Offset: 0x00005823
		public void GetColorImpl_Injected(int name, out Color ret)
		{
			MaterialPropertyBlock.GetColorImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, out ret);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00007637 File Offset: 0x00005837
		public void GetMatrixImpl_Injected(int name, out Matrix4x4 ret)
		{
			MaterialPropertyBlock.GetMatrixImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, out ret);
		}

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_SetIntImpl_Private_Void_Int32_Int32_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorImpl_Private_Void_Int32_Vector4_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderTextureImpl_Private_Void_Int32_RenderTexture_RenderTextureSubElement_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_CreateImpl_Private_Static_IntPtr_0;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr_DestroyImpl_Private_Static_Void_IntPtr_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_Boolean_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorArray_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixArray_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_SetInteger_Public_Void_Int32_Int32_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrix_Public_Void_String_Matrix4x4_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Int32_RenderTexture_RenderTextureSubElement_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatArray_Public_Void_String_Il2CppStructArray_1_Single_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorArray_Public_Void_String_Il2CppStructArray_1_Vector4_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixArray_Public_Void_String_Il2CppStructArray_1_Matrix4x4_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorImpl_Injected_Private_Void_Int32_byref_Vector4_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_SetColorImpl_Injected_Private_Void_Int32_byref_Color_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0;

		// Token: 0x04000899 RID: 2201
		private static readonly MaterialPropertyBlock.GetIntImplDelegate GetIntImplDelegateField;

		// Token: 0x0400089A RID: 2202
		private static readonly MaterialPropertyBlock.GetFloatImplDelegate GetFloatImplDelegateField;

		// Token: 0x0400089B RID: 2203
		private static readonly MaterialPropertyBlock.GetTextureImplDelegate GetTextureImplDelegateField;

		// Token: 0x0400089C RID: 2204
		private static readonly MaterialPropertyBlock.HasPropertyImplDelegate HasPropertyImplDelegateField;

		// Token: 0x0400089D RID: 2205
		private static readonly MaterialPropertyBlock.HasFloatImplDelegate HasFloatImplDelegateField;

		// Token: 0x0400089E RID: 2206
		private static readonly MaterialPropertyBlock.HasIntImplDelegate HasIntImplDelegateField;

		// Token: 0x0400089F RID: 2207
		private static readonly MaterialPropertyBlock.HasTextureImplDelegate HasTextureImplDelegateField;

		// Token: 0x040008A0 RID: 2208
		private static readonly MaterialPropertyBlock.HasMatrixImplDelegate HasMatrixImplDelegateField;

		// Token: 0x040008A1 RID: 2209
		private static readonly MaterialPropertyBlock.HasVectorImplDelegate HasVectorImplDelegateField;

		// Token: 0x040008A2 RID: 2210
		private static readonly MaterialPropertyBlock.HasBufferImplDelegate HasBufferImplDelegateField;

		// Token: 0x040008A3 RID: 2211
		private static readonly MaterialPropertyBlock.HasConstantBufferImplDelegate HasConstantBufferImplDelegateField;

		// Token: 0x040008A4 RID: 2212
		private static readonly MaterialPropertyBlock.SetBufferImplDelegate SetBufferImplDelegateField;

		// Token: 0x040008A5 RID: 2213
		private static readonly MaterialPropertyBlock.SetGraphicsBufferImplDelegate SetGraphicsBufferImplDelegateField;

		// Token: 0x040008A6 RID: 2214
		private static readonly MaterialPropertyBlock.SetConstantBufferImplDelegate SetConstantBufferImplDelegateField;

		// Token: 0x040008A7 RID: 2215
		private static readonly MaterialPropertyBlock.SetConstantGraphicsBufferImplDelegate SetConstantGraphicsBufferImplDelegateField;

		// Token: 0x040008A8 RID: 2216
		private static readonly MaterialPropertyBlock.GetFloatArrayImplDelegate GetFloatArrayImplDelegateField;

		// Token: 0x040008A9 RID: 2217
		private static readonly MaterialPropertyBlock.GetVectorArrayImplDelegate GetVectorArrayImplDelegateField;

		// Token: 0x040008AA RID: 2218
		private static readonly MaterialPropertyBlock.GetMatrixArrayImplDelegate GetMatrixArrayImplDelegateField;

		// Token: 0x040008AB RID: 2219
		private static readonly MaterialPropertyBlock.GetFloatArrayCountImplDelegate GetFloatArrayCountImplDelegateField;

		// Token: 0x040008AC RID: 2220
		private static readonly MaterialPropertyBlock.GetVectorArrayCountImplDelegate GetVectorArrayCountImplDelegateField;

		// Token: 0x040008AD RID: 2221
		private static readonly MaterialPropertyBlock.GetMatrixArrayCountImplDelegate GetMatrixArrayCountImplDelegateField;

		// Token: 0x040008AE RID: 2222
		private static readonly MaterialPropertyBlock.ExtractFloatArrayImplDelegate ExtractFloatArrayImplDelegateField;

		// Token: 0x040008AF RID: 2223
		private static readonly MaterialPropertyBlock.ExtractVectorArrayImplDelegate ExtractVectorArrayImplDelegateField;

		// Token: 0x040008B0 RID: 2224
		private static readonly MaterialPropertyBlock.ExtractMatrixArrayImplDelegate ExtractMatrixArrayImplDelegateField;

		// Token: 0x040008B1 RID: 2225
		private static readonly MaterialPropertyBlock.Internal_CopySHCoefficientArraysFromDelegate Internal_CopySHCoefficientArraysFromDelegateField;

		// Token: 0x040008B2 RID: 2226
		private static readonly MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFromDelegate Internal_CopyProbeOcclusionArrayFromDelegateField;

		// Token: 0x040008B3 RID: 2227
		private static readonly MaterialPropertyBlock.get_isEmptyDelegate get_isEmptyDelegateField;

		// Token: 0x040008B4 RID: 2228
		private static readonly MaterialPropertyBlock.GetVectorImpl_InjectedDelegate GetVectorImpl_InjectedDelegateField;

		// Token: 0x040008B5 RID: 2229
		private static readonly MaterialPropertyBlock.GetColorImpl_InjectedDelegate GetColorImpl_InjectedDelegateField;

		// Token: 0x040008B6 RID: 2230
		private static readonly MaterialPropertyBlock.GetMatrixImpl_InjectedDelegate GetMatrixImpl_InjectedDelegateField;

		// Token: 0x02000628 RID: 1576
		// (Invoke) Token: 0x0600350A RID: 13578
		private delegate int GetIntImplDelegate(IntPtr @this, int name);

		// Token: 0x02000629 RID: 1577
		// (Invoke) Token: 0x0600350C RID: 13580
		private delegate float GetFloatImplDelegate(IntPtr @this, int name);

		// Token: 0x0200062A RID: 1578
		// (Invoke) Token: 0x0600350E RID: 13582
		private delegate IntPtr GetTextureImplDelegate(IntPtr @this, int name);

		// Token: 0x0200062B RID: 1579
		// (Invoke) Token: 0x06003510 RID: 13584
		private delegate bool HasPropertyImplDelegate(IntPtr @this, int name);

		// Token: 0x0200062C RID: 1580
		// (Invoke) Token: 0x06003512 RID: 13586
		private delegate bool HasFloatImplDelegate(IntPtr @this, int name);

		// Token: 0x0200062D RID: 1581
		// (Invoke) Token: 0x06003514 RID: 13588
		private delegate bool HasIntImplDelegate(IntPtr @this, int name);

		// Token: 0x0200062E RID: 1582
		// (Invoke) Token: 0x06003516 RID: 13590
		private delegate bool HasTextureImplDelegate(IntPtr @this, int name);

		// Token: 0x0200062F RID: 1583
		// (Invoke) Token: 0x06003518 RID: 13592
		private delegate bool HasMatrixImplDelegate(IntPtr @this, int name);

		// Token: 0x02000630 RID: 1584
		// (Invoke) Token: 0x0600351A RID: 13594
		private delegate bool HasVectorImplDelegate(IntPtr @this, int name);

		// Token: 0x02000631 RID: 1585
		// (Invoke) Token: 0x0600351C RID: 13596
		private delegate bool HasBufferImplDelegate(IntPtr @this, int name);

		// Token: 0x02000632 RID: 1586
		// (Invoke) Token: 0x0600351E RID: 13598
		private delegate bool HasConstantBufferImplDelegate(IntPtr @this, int name);

		// Token: 0x02000633 RID: 1587
		// (Invoke) Token: 0x06003520 RID: 13600
		private delegate void SetBufferImplDelegate(IntPtr @this, int name, IntPtr value);

		// Token: 0x02000634 RID: 1588
		// (Invoke) Token: 0x06003522 RID: 13602
		private delegate void SetGraphicsBufferImplDelegate(IntPtr @this, int name, IntPtr value);

		// Token: 0x02000635 RID: 1589
		// (Invoke) Token: 0x06003524 RID: 13604
		private delegate void SetConstantBufferImplDelegate(IntPtr @this, int name, IntPtr value, int offset, int size);

		// Token: 0x02000636 RID: 1590
		// (Invoke) Token: 0x06003526 RID: 13606
		private delegate void SetConstantGraphicsBufferImplDelegate(IntPtr @this, int name, IntPtr value, int offset, int size);

		// Token: 0x02000637 RID: 1591
		// (Invoke) Token: 0x06003528 RID: 13608
		private delegate IntPtr GetFloatArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x02000638 RID: 1592
		// (Invoke) Token: 0x0600352A RID: 13610
		private delegate IntPtr GetVectorArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x02000639 RID: 1593
		// (Invoke) Token: 0x0600352C RID: 13612
		private delegate IntPtr GetMatrixArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x0200063A RID: 1594
		// (Invoke) Token: 0x0600352E RID: 13614
		private delegate int GetFloatArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x0200063B RID: 1595
		// (Invoke) Token: 0x06003530 RID: 13616
		private delegate int GetVectorArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x0200063C RID: 1596
		// (Invoke) Token: 0x06003532 RID: 13618
		private delegate int GetMatrixArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x0200063D RID: 1597
		// (Invoke) Token: 0x06003534 RID: 13620
		private delegate void ExtractFloatArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x0200063E RID: 1598
		// (Invoke) Token: 0x06003536 RID: 13622
		private delegate void ExtractVectorArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x0200063F RID: 1599
		// (Invoke) Token: 0x06003538 RID: 13624
		private delegate void ExtractMatrixArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x02000640 RID: 1600
		// (Invoke) Token: 0x0600353A RID: 13626
		private delegate void Internal_CopySHCoefficientArraysFromDelegate(IntPtr properties, IntPtr lightProbes, int sourceStart, int destStart, int count);

		// Token: 0x02000641 RID: 1601
		// (Invoke) Token: 0x0600353C RID: 13628
		private delegate void Internal_CopyProbeOcclusionArrayFromDelegate(IntPtr properties, IntPtr occlusionProbes, int sourceStart, int destStart, int count);

		// Token: 0x02000642 RID: 1602
		// (Invoke) Token: 0x0600353E RID: 13630
		private delegate bool get_isEmptyDelegate(IntPtr @this);

		// Token: 0x02000643 RID: 1603
		// (Invoke) Token: 0x06003540 RID: 13632
		private delegate void GetVectorImpl_InjectedDelegate(IntPtr @this, int name, [Out] IntPtr ret);

		// Token: 0x02000644 RID: 1604
		// (Invoke) Token: 0x06003542 RID: 13634
		private delegate void GetColorImpl_InjectedDelegate(IntPtr @this, int name, [Out] IntPtr ret);

		// Token: 0x02000645 RID: 1605
		// (Invoke) Token: 0x06003544 RID: 13636
		private delegate void GetMatrixImpl_InjectedDelegate(IntPtr @this, int name, [Out] IntPtr ret);
	}
}
