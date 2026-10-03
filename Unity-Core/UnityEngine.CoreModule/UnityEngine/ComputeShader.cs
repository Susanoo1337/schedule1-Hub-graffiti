using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200015F RID: 351
	public sealed class ComputeShader : Object
	{
		// Token: 0x06001A03 RID: 6659 RVA: 0x0006EC14 File Offset: 0x0006CE14
		// Note: this type is marked as 'beforefieldinit'.
		static ComputeShader()
		{
			Il2CppClassPointerStore<ComputeShader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ComputeShader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr);
			ComputeShader.NativeMethodInfoPtr_FindKernel_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666093);
			ComputeShader.NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666094);
			ComputeShader.NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666095);
			ComputeShader.NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666096);
			ComputeShader.NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666097);
			ComputeShader.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Int32_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666098);
			ComputeShader.NativeMethodInfoPtr_Internal_SetBuffer_Private_Void_Int32_Int32_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666099);
			ComputeShader.NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_Int32_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666100);
			ComputeShader.NativeMethodInfoPtr_SetConstantComputeBuffer_Private_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666101);
			ComputeShader.NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666102);
			ComputeShader.NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666103);
			ComputeShader.NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666104);
			ComputeShader.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666105);
			ComputeShader.NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666106);
			ComputeShader.NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666107);
			ComputeShader.NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666108);
			ComputeShader.NativeMethodInfoPtr_SetVectorArray_Public_Void_String_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666109);
			ComputeShader.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_String_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666110);
			ComputeShader.NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_String_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666111);
			ComputeShader.NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666112);
			ComputeShader.NativeMethodInfoPtr_SetVector_Injected_Private_Void_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666113);
			ComputeShader.HasKernelDelegateField = IL2CPP.ResolveICall<ComputeShader.HasKernelDelegate>("UnityEngine.ComputeShader::HasKernel");
			ComputeShader.SetFloatArrayDelegateField = IL2CPP.ResolveICall<ComputeShader.SetFloatArrayDelegate>("UnityEngine.ComputeShader::SetFloatArray");
			ComputeShader.SetIntArrayDelegateField = IL2CPP.ResolveICall<ComputeShader.SetIntArrayDelegate>("UnityEngine.ComputeShader::SetIntArray");
			ComputeShader.SetMatrixArrayDelegateField = IL2CPP.ResolveICall<ComputeShader.SetMatrixArrayDelegate>("UnityEngine.ComputeShader::SetMatrixArray");
			ComputeShader.SetRenderTextureDelegateField = IL2CPP.ResolveICall<ComputeShader.SetRenderTextureDelegate>("UnityEngine.ComputeShader::SetRenderTexture");
			ComputeShader.SetTextureFromGlobalDelegateField = IL2CPP.ResolveICall<ComputeShader.SetTextureFromGlobalDelegate>("UnityEngine.ComputeShader::SetTextureFromGlobal");
			ComputeShader.Internal_SetGraphicsBufferDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_SetGraphicsBufferDelegate>("UnityEngine.ComputeShader::Internal_SetGraphicsBuffer");
			ComputeShader.SetConstantGraphicsBufferDelegateField = IL2CPP.ResolveICall<ComputeShader.SetConstantGraphicsBufferDelegate>("UnityEngine.ComputeShader::SetConstantGraphicsBuffer");
			ComputeShader.GetKernelThreadGroupSizesDelegateField = IL2CPP.ResolveICall<ComputeShader.GetKernelThreadGroupSizesDelegate>("UnityEngine.ComputeShader::GetKernelThreadGroupSizes");
			ComputeShader.Internal_DispatchIndirectDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_DispatchIndirectDelegate>("UnityEngine.ComputeShader::Internal_DispatchIndirect");
			ComputeShader.Internal_DispatchIndirectGraphicsBufferDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_DispatchIndirectGraphicsBufferDelegate>("UnityEngine.ComputeShader::Internal_DispatchIndirectGraphicsBuffer");
			ComputeShader.IsKeywordEnabledDelegateField = IL2CPP.ResolveICall<ComputeShader.IsKeywordEnabledDelegate>("UnityEngine.ComputeShader::IsKeywordEnabled");
			ComputeShader.IsSupportedDelegateField = IL2CPP.ResolveICall<ComputeShader.IsSupportedDelegate>("UnityEngine.ComputeShader::IsSupported");
			ComputeShader.GetShaderKeywordsDelegateField = IL2CPP.ResolveICall<ComputeShader.GetShaderKeywordsDelegate>("UnityEngine.ComputeShader::GetShaderKeywords");
			ComputeShader.SetShaderKeywordsDelegateField = IL2CPP.ResolveICall<ComputeShader.SetShaderKeywordsDelegate>("UnityEngine.ComputeShader::SetShaderKeywords");
			ComputeShader.GetEnabledKeywordsDelegateField = IL2CPP.ResolveICall<ComputeShader.GetEnabledKeywordsDelegate>("UnityEngine.ComputeShader::GetEnabledKeywords");
			ComputeShader.SetEnabledKeywordsDelegateField = IL2CPP.ResolveICall<ComputeShader.SetEnabledKeywordsDelegate>("UnityEngine.ComputeShader::SetEnabledKeywords");
			ComputeShader.SetMatrix_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetMatrix_InjectedDelegate>("UnityEngine.ComputeShader::SetMatrix_Injected");
			ComputeShader.get_keywordSpace_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.get_keywordSpace_InjectedDelegate>("UnityEngine.ComputeShader::get_keywordSpace_Injected");
			ComputeShader.EnableLocalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.EnableLocalKeyword_InjectedDelegate>("UnityEngine.ComputeShader::EnableLocalKeyword_Injected");
			ComputeShader.DisableLocalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.DisableLocalKeyword_InjectedDelegate>("UnityEngine.ComputeShader::DisableLocalKeyword_Injected");
			ComputeShader.SetLocalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetLocalKeyword_InjectedDelegate>("UnityEngine.ComputeShader::SetLocalKeyword_Injected");
			ComputeShader.IsLocalKeywordEnabled_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.IsLocalKeywordEnabled_InjectedDelegate>("UnityEngine.ComputeShader::IsLocalKeywordEnabled_Injected");
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x0006EF44 File Offset: 0x0006D144
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 1271647, RefRangeEnd = 1271678, XrefRangeStart = 1271645, XrefRangeEnd = 1271647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindKernel(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_FindKernel_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0006EF94 File Offset: 0x0006D194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271678, XrefRangeEnd = 1271680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloat(int nameID, float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0006EFE0 File Offset: 0x0006D1E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1271682, RefRangeEnd = 1271684, XrefRangeStart = 1271680, XrefRangeEnd = 1271682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInt(int nameID, int val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x0006F02C File Offset: 0x0006D22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271684, XrefRangeEnd = 1271686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVector(int nameID, Vector4 val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x0006F078 File Offset: 0x0006D278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271686, XrefRangeEnd = 1271688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x0006F0C8 File Offset: 0x0006D2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271688, XrefRangeEnd = 1271690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref kernelIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Int32_Texture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0006F134 File Offset: 0x0006D334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271690, XrefRangeEnd = 1271692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref kernelIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_Internal_SetBuffer_Private_Void_Int32_Int32_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x0006F194 File Offset: 0x0006D394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref kernelIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_Int32_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x0006F1F4 File Offset: 0x0006D3F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271694, RefRangeEnd = 1271695, XrefRangeStart = 1271692, XrefRangeEnd = 1271694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetConstantComputeBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetConstantComputeBuffer_Private_Void_Int32_ComputeBuffer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x0006F260 File Offset: 0x0006D460
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1271697, RefRangeEnd = 1271704, XrefRangeStart = 1271695, XrefRangeEnd = 1271697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref kernelIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threadGroupsX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threadGroupsY;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threadGroupsZ;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x0006F2C8 File Offset: 0x0006D4C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1271706, RefRangeEnd = 1271708, XrefRangeStart = 1271704, XrefRangeEnd = 1271706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableKeyword(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x0006F30C File Offset: 0x0006D50C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1271710, RefRangeEnd = 1271712, XrefRangeStart = 1271708, XrefRangeEnd = 1271710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableKeyword(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0006F350 File Offset: 0x0006D550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271712, XrefRangeEnd = 1271716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeShader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x0006F38C File Offset: 0x0006D58C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1271719, RefRangeEnd = 1271731, XrefRangeStart = 1271716, XrefRangeEnd = 1271719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloat(string name, float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x0006F3DC File Offset: 0x0006D5DC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1271734, RefRangeEnd = 1271750, XrefRangeStart = 1271731, XrefRangeEnd = 1271734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInt(string name, int val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0006F42C File Offset: 0x0006D62C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1271753, RefRangeEnd = 1271758, XrefRangeStart = 1271750, XrefRangeEnd = 1271753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVector(string name, Vector4 val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0006F47C File Offset: 0x0006D67C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271761, RefRangeEnd = 1271762, XrefRangeStart = 1271758, XrefRangeEnd = 1271761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetVectorArray_Public_Void_String_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0006F4D0 File Offset: 0x0006D6D0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1271765, RefRangeEnd = 1271775, XrefRangeStart = 1271762, XrefRangeEnd = 1271765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(int kernelIndex, string name, Texture texture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref kernelIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_String_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x0006F534 File Offset: 0x0006D734
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1271778, RefRangeEnd = 1271789, XrefRangeStart = 1271775, XrefRangeEnd = 1271778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref kernelIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_String_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0006F598 File Offset: 0x0006D798
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271694, RefRangeEnd = 1271695, XrefRangeStart = 1271694, XrefRangeEnd = 1271695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x0006F604 File Offset: 0x0006D804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271789, XrefRangeEnd = 1271791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVector_Injected(int nameID, ref Vector4 val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetVector_Injected_Private_Void_Int32_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0000C9A2 File Offset: 0x0000ABA2
		public ComputeShader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x0000C9AB File Offset: 0x0000ABAB
		public bool HasKernel(string name)
		{
			return ComputeShader.HasKernelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x0000C9C3 File Offset: 0x0000ABC3
		public void SetMatrix(int nameID, Matrix4x4 val)
		{
			this.SetMatrix_Injected(nameID, ref val);
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x0000C9CE File Offset: 0x0000ABCE
		public void SetFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			ComputeShader.SetFloatArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x0000C9E7 File Offset: 0x0000ABE7
		public void SetIntArray(int nameID, Il2CppStructArray<int> values)
		{
			ComputeShader.SetIntArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x0000CA00 File Offset: 0x0000AC00
		public void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			ComputeShader.SetMatrixArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x0000CA19 File Offset: 0x0000AC19
		public void SetRenderTexture(int kernelIndex, int nameID, RenderTexture texture, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			ComputeShader.SetRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, IL2CPP.Il2CppObjectBaseToPtr(texture), mipLevel, element);
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x0000CA37 File Offset: 0x0000AC37
		public void SetTextureFromGlobal(int kernelIndex, int nameID, int globalTextureNameID)
		{
			ComputeShader.SetTextureFromGlobalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, globalTextureNameID);
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x0000CA4C File Offset: 0x0000AC4C
		public void Internal_SetGraphicsBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
			ComputeShader.Internal_SetGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x0000CA66 File Offset: 0x0000AC66
		public void SetBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
			this.Internal_SetGraphicsBuffer(kernelIndex, nameID, buffer);
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x0000CA73 File Offset: 0x0000AC73
		public void SetConstantGraphicsBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			ComputeShader.SetConstantGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x0000CA8F File Offset: 0x0000AC8F
		public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z)
		{
			ComputeShader.GetKernelThreadGroupSizesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, out x, out y, out z);
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x0000CAA6 File Offset: 0x0000ACA6
		public void Internal_DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, uint argsOffset)
		{
			ComputeShader.Internal_DispatchIndirectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, IL2CPP.Il2CppObjectBaseToPtr(argsBuffer), argsOffset);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x0000CAC0 File Offset: 0x0000ACC0
		public void Internal_DispatchIndirectGraphicsBuffer(int kernelIndex, GraphicsBuffer argsBuffer, uint argsOffset)
		{
			ComputeShader.Internal_DispatchIndirectGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, IL2CPP.Il2CppObjectBaseToPtr(argsBuffer), argsOffset);
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x0006F650 File Offset: 0x0006D850
		public UnityEngine.Rendering.LocalKeywordSpace keywordSpace
		{
			get
			{
				UnityEngine.Rendering.LocalKeywordSpace result;
				this.get_keywordSpace_Injected(out result);
				return result;
			}
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x0000CADA File Offset: 0x0000ACDA
		public bool IsKeywordEnabled(string keyword)
		{
			return ComputeShader.IsKeywordEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x0000CAF2 File Offset: 0x0000ACF2
		public void EnableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword)
		{
			this.EnableLocalKeyword_Injected(ref keyword);
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x0000CAFC File Offset: 0x0000ACFC
		public void DisableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword)
		{
			this.DisableLocalKeyword_Injected(ref keyword);
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0000CB06 File Offset: 0x0000AD06
		public void SetLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword, bool value)
		{
			this.SetLocalKeyword_Injected(ref keyword, value);
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x0000CB11 File Offset: 0x0000AD11
		public bool IsLocalKeywordEnabled(UnityEngine.Rendering.LocalKeyword keyword)
		{
			return this.IsLocalKeywordEnabled_Injected(ref keyword);
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0000CB1B File Offset: 0x0000AD1B
		public void EnableKeyword([In] ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			this.EnableLocalKeyword(keyword);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0000CB2B File Offset: 0x0000AD2B
		public void DisableKeyword([In] ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			this.DisableLocalKeyword(keyword);
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x0000CB3B File Offset: 0x0000AD3B
		public void SetKeyword([In] ref UnityEngine.Rendering.LocalKeyword keyword, bool value)
		{
			this.SetLocalKeyword(keyword, value);
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x0006F668 File Offset: 0x0006D868
		public bool IsKeywordEnabled([In] ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			return this.IsLocalKeywordEnabled(keyword);
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x0000CB4C File Offset: 0x0000AD4C
		public bool IsSupported(int kernelIndex)
		{
			return ComputeShader.IsSupportedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex);
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x0006F688 File Offset: 0x0006D888
		public Il2CppStringArray GetShaderKeywords()
		{
			IntPtr intPtr = ComputeShader.GetShaderKeywordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x0000CB5F File Offset: 0x0000AD5F
		public void SetShaderKeywords(Il2CppStringArray names)
		{
			ComputeShader.SetShaderKeywordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(names));
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x0006F6B4 File Offset: 0x0006D8B4
		// (set) Token: 0x06001A35 RID: 6709 RVA: 0x0000CB77 File Offset: 0x0000AD77
		public Il2CppStringArray shaderKeywords
		{
			get
			{
				return this.GetShaderKeywords();
			}
			set
			{
				this.SetShaderKeywords(value);
			}
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x0006F6CC File Offset: 0x0006D8CC
		public Il2CppReferenceArray<UnityEngine.Rendering.LocalKeyword> GetEnabledKeywords()
		{
			IntPtr intPtr = ComputeShader.GetEnabledKeywordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.Rendering.LocalKeyword>>(intPtr2) : null;
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x0000CB82 File Offset: 0x0000AD82
		public void SetEnabledKeywords(Il2CppReferenceArray<UnityEngine.Rendering.LocalKeyword> keywords)
		{
			ComputeShader.SetEnabledKeywordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(keywords));
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001A38 RID: 6712 RVA: 0x0006F6F8 File Offset: 0x0006D8F8
		// (set) Token: 0x06001A39 RID: 6713 RVA: 0x0000CB9A File Offset: 0x0000AD9A
		public Il2CppReferenceArray<UnityEngine.Rendering.LocalKeyword> enabledKeywords
		{
			get
			{
				return this.GetEnabledKeywords();
			}
			set
			{
				this.SetEnabledKeywords(value);
			}
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0000CBA5 File Offset: 0x0000ADA5
		public void SetMatrix(string name, Matrix4x4 val)
		{
			this.SetMatrix(Shader.PropertyToID(name), val);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0000CBB6 File Offset: 0x0000ADB6
		public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0000CBC7 File Offset: 0x0000ADC7
		public void SetFloats(string name, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x0000CBD8 File Offset: 0x0000ADD8
		public void SetFloats(string name, params float[] values)
		{
			this.SetFloats(name, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x0000CBE7 File Offset: 0x0000ADE7
		public void SetFloats(int nameID, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(nameID, values);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0000CBF3 File Offset: 0x0000ADF3
		public void SetFloats(int nameID, params float[] values)
		{
			this.SetFloats(nameID, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0000CC02 File Offset: 0x0000AE02
		public void SetInts(string name, Il2CppStructArray<int> values)
		{
			this.SetIntArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0000CC13 File Offset: 0x0000AE13
		public void SetInts(string name, params int[] values)
		{
			this.SetInts(name, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0000CC22 File Offset: 0x0000AE22
		public void SetInts(int nameID, Il2CppStructArray<int> values)
		{
			this.SetIntArray(nameID, values);
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0000CC2E File Offset: 0x0000AE2E
		public void SetInts(int nameID, params int[] values)
		{
			this.SetInts(nameID, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0000CC3D File Offset: 0x0000AE3D
		public void SetBool(string name, bool val)
		{
			this.SetInt(Shader.PropertyToID(name), val ? 1 : 0);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0000CC54 File Offset: 0x0000AE54
		public void SetBool(int nameID, bool val)
		{
			this.SetInt(nameID, val ? 1 : 0);
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0000CC66 File Offset: 0x0000AE66
		public void SetTexture(int kernelIndex, int nameID, Texture texture)
		{
			this.SetTexture(kernelIndex, nameID, texture, 0);
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0000CC74 File Offset: 0x0000AE74
		public void SetTexture(int kernelIndex, string name, Texture texture, int mipLevel)
		{
			this.SetTexture(kernelIndex, Shader.PropertyToID(name), texture, mipLevel);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0000CC88 File Offset: 0x0000AE88
		public void SetTexture(int kernelIndex, int nameID, RenderTexture texture, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTexture(kernelIndex, nameID, texture, mipLevel, element);
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0000CC99 File Offset: 0x0000AE99
		public void SetTexture(int kernelIndex, string name, RenderTexture texture, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTexture(kernelIndex, Shader.PropertyToID(name), texture, mipLevel, element);
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x0000CCAF File Offset: 0x0000AEAF
		public void SetTextureFromGlobal(int kernelIndex, string name, string globalTextureName)
		{
			this.SetTextureFromGlobal(kernelIndex, Shader.PropertyToID(name), Shader.PropertyToID(globalTextureName));
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x0000CCC6 File Offset: 0x0000AEC6
		public void SetBuffer(int kernelIndex, string name, GraphicsBuffer buffer)
		{
			this.SetBuffer(kernelIndex, Shader.PropertyToID(name), buffer);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		public void SetConstantBuffer(string name, ComputeBuffer buffer, int offset, int size)
		{
			this.SetConstantBuffer(Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x0000CCEC File Offset: 0x0000AEEC
		public void SetConstantBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			this.SetConstantGraphicsBuffer(nameID, buffer, offset, size);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0000CCFB File Offset: 0x0000AEFB
		public void SetConstantBuffer(string name, GraphicsBuffer buffer, int offset, int size)
		{
			this.SetConstantBuffer(Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0006F710 File Offset: 0x0006D910
		public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, uint argsOffset)
		{
			bool flag = argsBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("argsBuffer");
			}
			bool flag2 = argsBuffer.m_Ptr == IntPtr.Zero;
			if (flag2)
			{
				throw new ObjectDisposedException("argsBuffer");
			}
			bool flag3 = SystemInfo.graphicsDeviceType == UnityEngine.Rendering.GraphicsDeviceType.Metal && !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag3)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			this.Internal_DispatchIndirect(kernelIndex, argsBuffer, argsOffset);
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0000CD0F File Offset: 0x0000AF0F
		public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer)
		{
			this.DispatchIndirect(kernelIndex, argsBuffer, 0U);
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0006F780 File Offset: 0x0006D980
		public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer, uint argsOffset)
		{
			bool flag = argsBuffer == null;
			if (flag)
			{
				throw new ArgumentNullException("argsBuffer");
			}
			bool flag2 = argsBuffer.m_Ptr == IntPtr.Zero;
			if (flag2)
			{
				throw new ObjectDisposedException("argsBuffer");
			}
			bool flag3 = SystemInfo.graphicsDeviceType == UnityEngine.Rendering.GraphicsDeviceType.Metal && !SystemInfo.supportsIndirectArgumentsBuffer;
			if (flag3)
			{
				throw new InvalidOperationException("Indirect argument buffers are not supported.");
			}
			this.Internal_DispatchIndirectGraphicsBuffer(kernelIndex, argsBuffer, argsOffset);
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x0000CD1C File Offset: 0x0000AF1C
		public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer)
		{
			this.DispatchIndirect(kernelIndex, argsBuffer, 0U);
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x0000CD29 File Offset: 0x0000AF29
		public void SetMatrix_Injected(int nameID, ref Matrix4x4 val)
		{
			ComputeShader.SetMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref val);
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x0000CD3D File Offset: 0x0000AF3D
		public void get_keywordSpace_Injected(out UnityEngine.Rendering.LocalKeywordSpace ret)
		{
			ComputeShader.get_keywordSpace_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x0006F7F0 File Offset: 0x0006D9F0
		public unsafe void EnableLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			ComputeShader.EnableLocalKeyword_InjectedDelegate enableLocalKeyword_InjectedDelegateField = ComputeShader.EnableLocalKeyword_InjectedDelegateField;
			IntPtr @this = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(keyword);
			enableLocalKeyword_InjectedDelegateField(@this, &intPtr);
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x0006F818 File Offset: 0x0006DA18
		public unsafe void DisableLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			ComputeShader.DisableLocalKeyword_InjectedDelegate disableLocalKeyword_InjectedDelegateField = ComputeShader.DisableLocalKeyword_InjectedDelegateField;
			IntPtr @this = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(keyword);
			disableLocalKeyword_InjectedDelegateField(@this, &intPtr);
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x0006F840 File Offset: 0x0006DA40
		public unsafe void SetLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword keyword, bool value)
		{
			ComputeShader.SetLocalKeyword_InjectedDelegate setLocalKeyword_InjectedDelegateField = ComputeShader.SetLocalKeyword_InjectedDelegateField;
			IntPtr @this = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(keyword);
			setLocalKeyword_InjectedDelegateField(@this, &intPtr, value);
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x0006F86C File Offset: 0x0006DA6C
		public unsafe bool IsLocalKeywordEnabled_Injected(ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			ComputeShader.IsLocalKeywordEnabled_InjectedDelegate isLocalKeywordEnabled_InjectedDelegateField = ComputeShader.IsLocalKeywordEnabled_InjectedDelegateField;
			IntPtr @this = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(keyword);
			return isLocalKeywordEnabled_InjectedDelegateField(@this, &intPtr);
		}

		// Token: 0x04001594 RID: 5524
		private static readonly IntPtr NativeMethodInfoPtr_FindKernel_Public_Int32_String_0;

		// Token: 0x04001595 RID: 5525
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0;

		// Token: 0x04001596 RID: 5526
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0;

		// Token: 0x04001597 RID: 5527
		private static readonly IntPtr NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0;

		// Token: 0x04001598 RID: 5528
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0;

		// Token: 0x04001599 RID: 5529
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Int32_Texture_Int32_0;

		// Token: 0x0400159A RID: 5530
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetBuffer_Private_Void_Int32_Int32_ComputeBuffer_0;

		// Token: 0x0400159B RID: 5531
		private static readonly IntPtr NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_Int32_ComputeBuffer_0;

		// Token: 0x0400159C RID: 5532
		private static readonly IntPtr NativeMethodInfoPtr_SetConstantComputeBuffer_Private_Void_Int32_ComputeBuffer_Int32_Int32_0;

		// Token: 0x0400159D RID: 5533
		private static readonly IntPtr NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400159E RID: 5534
		private static readonly IntPtr NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0;

		// Token: 0x0400159F RID: 5535
		private static readonly IntPtr NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0;

		// Token: 0x040015A0 RID: 5536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0;

		// Token: 0x040015A2 RID: 5538
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0;

		// Token: 0x040015A3 RID: 5539
		private static readonly IntPtr NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0;

		// Token: 0x040015A4 RID: 5540
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorArray_Public_Void_String_Il2CppStructArray_1_Vector4_0;

		// Token: 0x040015A5 RID: 5541
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Int32_String_Texture_0;

		// Token: 0x040015A6 RID: 5542
		private static readonly IntPtr NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_String_ComputeBuffer_0;

		// Token: 0x040015A7 RID: 5543
		private static readonly IntPtr NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0;

		// Token: 0x040015A8 RID: 5544
		private static readonly IntPtr NativeMethodInfoPtr_SetVector_Injected_Private_Void_Int32_byref_Vector4_0;

		// Token: 0x040015A9 RID: 5545
		private static readonly ComputeShader.HasKernelDelegate HasKernelDelegateField;

		// Token: 0x040015AA RID: 5546
		private static readonly ComputeShader.SetFloatArrayDelegate SetFloatArrayDelegateField;

		// Token: 0x040015AB RID: 5547
		private static readonly ComputeShader.SetIntArrayDelegate SetIntArrayDelegateField;

		// Token: 0x040015AC RID: 5548
		private static readonly ComputeShader.SetMatrixArrayDelegate SetMatrixArrayDelegateField;

		// Token: 0x040015AD RID: 5549
		private static readonly ComputeShader.SetRenderTextureDelegate SetRenderTextureDelegateField;

		// Token: 0x040015AE RID: 5550
		private static readonly ComputeShader.SetTextureFromGlobalDelegate SetTextureFromGlobalDelegateField;

		// Token: 0x040015AF RID: 5551
		private static readonly ComputeShader.Internal_SetGraphicsBufferDelegate Internal_SetGraphicsBufferDelegateField;

		// Token: 0x040015B0 RID: 5552
		private static readonly ComputeShader.SetConstantGraphicsBufferDelegate SetConstantGraphicsBufferDelegateField;

		// Token: 0x040015B1 RID: 5553
		private static readonly ComputeShader.GetKernelThreadGroupSizesDelegate GetKernelThreadGroupSizesDelegateField;

		// Token: 0x040015B2 RID: 5554
		private static readonly ComputeShader.Internal_DispatchIndirectDelegate Internal_DispatchIndirectDelegateField;

		// Token: 0x040015B3 RID: 5555
		private static readonly ComputeShader.Internal_DispatchIndirectGraphicsBufferDelegate Internal_DispatchIndirectGraphicsBufferDelegateField;

		// Token: 0x040015B4 RID: 5556
		private static readonly ComputeShader.IsKeywordEnabledDelegate IsKeywordEnabledDelegateField;

		// Token: 0x040015B5 RID: 5557
		private static readonly ComputeShader.IsSupportedDelegate IsSupportedDelegateField;

		// Token: 0x040015B6 RID: 5558
		private static readonly ComputeShader.GetShaderKeywordsDelegate GetShaderKeywordsDelegateField;

		// Token: 0x040015B7 RID: 5559
		private static readonly ComputeShader.SetShaderKeywordsDelegate SetShaderKeywordsDelegateField;

		// Token: 0x040015B8 RID: 5560
		private static readonly ComputeShader.GetEnabledKeywordsDelegate GetEnabledKeywordsDelegateField;

		// Token: 0x040015B9 RID: 5561
		private static readonly ComputeShader.SetEnabledKeywordsDelegate SetEnabledKeywordsDelegateField;

		// Token: 0x040015BA RID: 5562
		private static readonly ComputeShader.SetMatrix_InjectedDelegate SetMatrix_InjectedDelegateField;

		// Token: 0x040015BB RID: 5563
		private static readonly ComputeShader.get_keywordSpace_InjectedDelegate get_keywordSpace_InjectedDelegateField;

		// Token: 0x040015BC RID: 5564
		private static readonly ComputeShader.EnableLocalKeyword_InjectedDelegate EnableLocalKeyword_InjectedDelegateField;

		// Token: 0x040015BD RID: 5565
		private static readonly ComputeShader.DisableLocalKeyword_InjectedDelegate DisableLocalKeyword_InjectedDelegateField;

		// Token: 0x040015BE RID: 5566
		private static readonly ComputeShader.SetLocalKeyword_InjectedDelegate SetLocalKeyword_InjectedDelegateField;

		// Token: 0x040015BF RID: 5567
		private static readonly ComputeShader.IsLocalKeywordEnabled_InjectedDelegate IsLocalKeywordEnabled_InjectedDelegateField;

		// Token: 0x0200090A RID: 2314
		// (Invoke) Token: 0x06003A90 RID: 14992
		private delegate bool HasKernelDelegate(IntPtr @this, IntPtr name);

		// Token: 0x0200090B RID: 2315
		// (Invoke) Token: 0x06003A92 RID: 14994
		private delegate void SetFloatArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x0200090C RID: 2316
		// (Invoke) Token: 0x06003A94 RID: 14996
		private delegate void SetIntArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x0200090D RID: 2317
		// (Invoke) Token: 0x06003A96 RID: 14998
		private delegate void SetMatrixArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x0200090E RID: 2318
		// (Invoke) Token: 0x06003A98 RID: 15000
		private delegate void SetRenderTextureDelegate(IntPtr @this, int kernelIndex, int nameID, IntPtr texture, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);

		// Token: 0x0200090F RID: 2319
		// (Invoke) Token: 0x06003A9A RID: 15002
		private delegate void SetTextureFromGlobalDelegate(IntPtr @this, int kernelIndex, int nameID, int globalTextureNameID);

		// Token: 0x02000910 RID: 2320
		// (Invoke) Token: 0x06003A9C RID: 15004
		private delegate void Internal_SetGraphicsBufferDelegate(IntPtr @this, int kernelIndex, int nameID, IntPtr buffer);

		// Token: 0x02000911 RID: 2321
		// (Invoke) Token: 0x06003A9E RID: 15006
		private delegate void SetConstantGraphicsBufferDelegate(IntPtr @this, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000912 RID: 2322
		// (Invoke) Token: 0x06003AA0 RID: 15008
		private delegate void GetKernelThreadGroupSizesDelegate(IntPtr @this, int kernelIndex, [Out] IntPtr x, [Out] IntPtr y, [Out] IntPtr z);

		// Token: 0x02000913 RID: 2323
		// (Invoke) Token: 0x06003AA2 RID: 15010
		private delegate void Internal_DispatchIndirectDelegate(IntPtr @this, int kernelIndex, IntPtr argsBuffer, uint argsOffset);

		// Token: 0x02000914 RID: 2324
		// (Invoke) Token: 0x06003AA4 RID: 15012
		private delegate void Internal_DispatchIndirectGraphicsBufferDelegate(IntPtr @this, int kernelIndex, IntPtr argsBuffer, uint argsOffset);

		// Token: 0x02000915 RID: 2325
		// (Invoke) Token: 0x06003AA6 RID: 15014
		private delegate bool IsKeywordEnabledDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x02000916 RID: 2326
		// (Invoke) Token: 0x06003AA8 RID: 15016
		private delegate bool IsSupportedDelegate(IntPtr @this, int kernelIndex);

		// Token: 0x02000917 RID: 2327
		// (Invoke) Token: 0x06003AAA RID: 15018
		private delegate IntPtr GetShaderKeywordsDelegate(IntPtr @this);

		// Token: 0x02000918 RID: 2328
		// (Invoke) Token: 0x06003AAC RID: 15020
		private delegate void SetShaderKeywordsDelegate(IntPtr @this, IntPtr names);

		// Token: 0x02000919 RID: 2329
		// (Invoke) Token: 0x06003AAE RID: 15022
		private delegate IntPtr GetEnabledKeywordsDelegate(IntPtr @this);

		// Token: 0x0200091A RID: 2330
		// (Invoke) Token: 0x06003AB0 RID: 15024
		private delegate void SetEnabledKeywordsDelegate(IntPtr @this, IntPtr keywords);

		// Token: 0x0200091B RID: 2331
		// (Invoke) Token: 0x06003AB2 RID: 15026
		private delegate void SetMatrix_InjectedDelegate(IntPtr @this, int nameID, IntPtr val);

		// Token: 0x0200091C RID: 2332
		// (Invoke) Token: 0x06003AB4 RID: 15028
		private delegate void get_keywordSpace_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200091D RID: 2333
		// (Invoke) Token: 0x06003AB6 RID: 15030
		private delegate void EnableLocalKeyword_InjectedDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x0200091E RID: 2334
		// (Invoke) Token: 0x06003AB8 RID: 15032
		private delegate void DisableLocalKeyword_InjectedDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x0200091F RID: 2335
		// (Invoke) Token: 0x06003ABA RID: 15034
		private delegate void SetLocalKeyword_InjectedDelegate(IntPtr @this, IntPtr keyword, bool value);

		// Token: 0x02000920 RID: 2336
		// (Invoke) Token: 0x06003ABC RID: 15036
		private delegate bool IsLocalKeywordEnabled_InjectedDelegate(IntPtr @this, IntPtr keyword);
	}
}
