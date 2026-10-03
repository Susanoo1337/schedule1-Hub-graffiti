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
	// Token: 0x020000A9 RID: 169
	public sealed class Shader : Object
	{
		// Token: 0x06000C4E RID: 3150 RVA: 0x0003B9AC File Offset: 0x00039BAC
		// Note: this type is marked as 'beforefieldinit'.
		static Shader()
		{
			Il2CppClassPointerStore<Shader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Shader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shader>.NativeClassPtr);
			Shader.NativeMethodInfoPtr_Find_Public_Static_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664442);
			Shader.NativeMethodInfoPtr_get_isSupported_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664443);
			Shader.NativeMethodInfoPtr_set_globalRenderPipeline_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664444);
			Shader.NativeMethodInfoPtr_get_keywordSpace_Public_get_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664445);
			Shader.NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664446);
			Shader.NativeMethodInfoPtr_DisableKeyword_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664447);
			Shader.NativeMethodInfoPtr_TagToID_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664448);
			Shader.NativeMethodInfoPtr_PropertyToID_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664449);
			Shader.NativeMethodInfoPtr_get_passCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664450);
			Shader.NativeMethodInfoPtr_SetGlobalFloatImpl_Private_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664451);
			Shader.NativeMethodInfoPtr_SetGlobalVectorImpl_Private_Static_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664452);
			Shader.NativeMethodInfoPtr_SetGlobalTextureImpl_Private_Static_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664453);
			Shader.NativeMethodInfoPtr_SetGlobalConstantBufferImpl_Private_Static_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664454);
			Shader.NativeMethodInfoPtr_SetGlobalVectorArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664455);
			Shader.NativeMethodInfoPtr_SetGlobalMatrixArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664456);
			Shader.NativeMethodInfoPtr_SetGlobalVectorArray_Private_Static_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664457);
			Shader.NativeMethodInfoPtr_SetGlobalMatrixArray_Private_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664458);
			Shader.NativeMethodInfoPtr_SetGlobalInt_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664459);
			Shader.NativeMethodInfoPtr_SetGlobalInt_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664460);
			Shader.NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664461);
			Shader.NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664462);
			Shader.NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_String_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664463);
			Shader.NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664464);
			Shader.NativeMethodInfoPtr_SetGlobalColor_Public_Static_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664465);
			Shader.NativeMethodInfoPtr_SetGlobalColor_Public_Static_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664466);
			Shader.NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_String_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664467);
			Shader.NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664468);
			Shader.NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664469);
			Shader.NativeMethodInfoPtr_SetGlobalVectorArray_Public_Static_Void_Int32_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664470);
			Shader.NativeMethodInfoPtr_SetGlobalMatrixArray_Public_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664471);
			Shader.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664472);
			Shader.NativeMethodInfoPtr_get_keywordSpace_Injected_Private_Void_byref_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664473);
			Shader.NativeMethodInfoPtr_SetGlobalVectorImpl_Injected_Private_Static_Void_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664474);
			Shader.FindBuiltinDelegateField = IL2CPP.ResolveICall<Shader.FindBuiltinDelegate>("UnityEngine.Shader::FindBuiltin");
			Shader.get_maximumChunksOverrideDelegateField = IL2CPP.ResolveICall<Shader.get_maximumChunksOverrideDelegate>("UnityEngine.Shader::get_maximumChunksOverride");
			Shader.set_maximumChunksOverrideDelegateField = IL2CPP.ResolveICall<Shader.set_maximumChunksOverrideDelegate>("UnityEngine.Shader::set_maximumChunksOverride");
			Shader.get_maximumLODDelegateField = IL2CPP.ResolveICall<Shader.get_maximumLODDelegate>("UnityEngine.Shader::get_maximumLOD");
			Shader.set_maximumLODDelegateField = IL2CPP.ResolveICall<Shader.set_maximumLODDelegate>("UnityEngine.Shader::set_maximumLOD");
			Shader.get_globalMaximumLODDelegateField = IL2CPP.ResolveICall<Shader.get_globalMaximumLODDelegate>("UnityEngine.Shader::get_globalMaximumLOD");
			Shader.set_globalMaximumLODDelegateField = IL2CPP.ResolveICall<Shader.set_globalMaximumLODDelegate>("UnityEngine.Shader::set_globalMaximumLOD");
			Shader.get_globalRenderPipelineDelegateField = IL2CPP.ResolveICall<Shader.get_globalRenderPipelineDelegate>("UnityEngine.Shader::get_globalRenderPipeline");
			Shader.IsKeywordEnabledDelegateField = IL2CPP.ResolveICall<Shader.IsKeywordEnabledDelegate>("UnityEngine.Shader::IsKeywordEnabled");
			Shader.get_renderQueueDelegateField = IL2CPP.ResolveICall<Shader.get_renderQueueDelegate>("UnityEngine.Shader::get_renderQueue");
			Shader.get_disableBatchingDelegateField = IL2CPP.ResolveICall<Shader.get_disableBatchingDelegate>("UnityEngine.Shader::get_disableBatching");
			Shader.WarmupAllShadersDelegateField = IL2CPP.ResolveICall<Shader.WarmupAllShadersDelegate>("UnityEngine.Shader::WarmupAllShaders");
			Shader.IDToTagDelegateField = IL2CPP.ResolveICall<Shader.IDToTagDelegate>("UnityEngine.Shader::IDToTag");
			Shader.GetDependencyDelegateField = IL2CPP.ResolveICall<Shader.GetDependencyDelegate>("UnityEngine.Shader::GetDependency");
			Shader.get_subshaderCountDelegateField = IL2CPP.ResolveICall<Shader.get_subshaderCountDelegate>("UnityEngine.Shader::get_subshaderCount");
			Shader.GetPassCountInSubshaderDelegateField = IL2CPP.ResolveICall<Shader.GetPassCountInSubshaderDelegate>("UnityEngine.Shader::GetPassCountInSubshader");
			Shader.Internal_FindPassTagValueDelegateField = IL2CPP.ResolveICall<Shader.Internal_FindPassTagValueDelegate>("UnityEngine.Shader::Internal_FindPassTagValue");
			Shader.Internal_FindPassTagValueInSubShaderDelegateField = IL2CPP.ResolveICall<Shader.Internal_FindPassTagValueInSubShaderDelegate>("UnityEngine.Shader::Internal_FindPassTagValueInSubShader");
			Shader.Internal_FindSubshaderTagValueDelegateField = IL2CPP.ResolveICall<Shader.Internal_FindSubshaderTagValueDelegate>("UnityEngine.Shader::Internal_FindSubshaderTagValue");
			Shader.SetGlobalIntImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalIntImplDelegate>("UnityEngine.Shader::SetGlobalIntImpl");
			Shader.SetGlobalRenderTextureImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalRenderTextureImplDelegate>("UnityEngine.Shader::SetGlobalRenderTextureImpl");
			Shader.SetGlobalBufferImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalBufferImplDelegate>("UnityEngine.Shader::SetGlobalBufferImpl");
			Shader.SetGlobalGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalGraphicsBufferImplDelegate>("UnityEngine.Shader::SetGlobalGraphicsBufferImpl");
			Shader.SetGlobalConstantGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalConstantGraphicsBufferImplDelegate>("UnityEngine.Shader::SetGlobalConstantGraphicsBufferImpl");
			Shader.GetGlobalIntImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalIntImplDelegate>("UnityEngine.Shader::GetGlobalIntImpl");
			Shader.GetGlobalFloatImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalFloatImplDelegate>("UnityEngine.Shader::GetGlobalFloatImpl");
			Shader.GetGlobalTextureImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalTextureImplDelegate>("UnityEngine.Shader::GetGlobalTextureImpl");
			Shader.SetGlobalFloatArrayImplDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalFloatArrayImplDelegate>("UnityEngine.Shader::SetGlobalFloatArrayImpl");
			Shader.GetGlobalFloatArrayImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalFloatArrayImplDelegate>("UnityEngine.Shader::GetGlobalFloatArrayImpl");
			Shader.GetGlobalVectorArrayImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalVectorArrayImplDelegate>("UnityEngine.Shader::GetGlobalVectorArrayImpl");
			Shader.GetGlobalMatrixArrayImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalMatrixArrayImplDelegate>("UnityEngine.Shader::GetGlobalMatrixArrayImpl");
			Shader.GetGlobalFloatArrayCountImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalFloatArrayCountImplDelegate>("UnityEngine.Shader::GetGlobalFloatArrayCountImpl");
			Shader.GetGlobalVectorArrayCountImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalVectorArrayCountImplDelegate>("UnityEngine.Shader::GetGlobalVectorArrayCountImpl");
			Shader.GetGlobalMatrixArrayCountImplDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalMatrixArrayCountImplDelegate>("UnityEngine.Shader::GetGlobalMatrixArrayCountImpl");
			Shader.ExtractGlobalFloatArrayImplDelegateField = IL2CPP.ResolveICall<Shader.ExtractGlobalFloatArrayImplDelegate>("UnityEngine.Shader::ExtractGlobalFloatArrayImpl");
			Shader.ExtractGlobalVectorArrayImplDelegateField = IL2CPP.ResolveICall<Shader.ExtractGlobalVectorArrayImplDelegate>("UnityEngine.Shader::ExtractGlobalVectorArrayImpl");
			Shader.ExtractGlobalMatrixArrayImplDelegateField = IL2CPP.ResolveICall<Shader.ExtractGlobalMatrixArrayImplDelegate>("UnityEngine.Shader::ExtractGlobalMatrixArrayImpl");
			Shader.GetPropertyNameDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyNameDelegate>("UnityEngine.Shader::GetPropertyName");
			Shader.GetPropertyNameIdDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyNameIdDelegate>("UnityEngine.Shader::GetPropertyNameId");
			Shader.GetPropertyTypeDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyTypeDelegate>("UnityEngine.Shader::GetPropertyType");
			Shader.GetPropertyDescriptionDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyDescriptionDelegate>("UnityEngine.Shader::GetPropertyDescription");
			Shader.GetPropertyFlagsDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyFlagsDelegate>("UnityEngine.Shader::GetPropertyFlags");
			Shader.GetPropertyAttributesDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyAttributesDelegate>("UnityEngine.Shader::GetPropertyAttributes");
			Shader.GetPropertyDefaultIntValueDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyDefaultIntValueDelegate>("UnityEngine.Shader::GetPropertyDefaultIntValue");
			Shader.GetPropertyTextureDimensionDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyTextureDimensionDelegate>("UnityEngine.Shader::GetPropertyTextureDimension");
			Shader.GetPropertyTextureDefaultNameDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyTextureDefaultNameDelegate>("UnityEngine.Shader::GetPropertyTextureDefaultName");
			Shader.FindTextureStackImplDelegateField = IL2CPP.ResolveICall<Shader.FindTextureStackImplDelegate>("UnityEngine.Shader::FindTextureStackImpl");
			Shader.GetPropertyCountDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyCountDelegate>("UnityEngine.Shader::GetPropertyCount");
			Shader.FindPropertyIndexDelegateField = IL2CPP.ResolveICall<Shader.FindPropertyIndexDelegate>("UnityEngine.Shader::FindPropertyIndex");
			Shader.SetGlobalMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<Shader.SetGlobalMatrixImpl_InjectedDelegate>("UnityEngine.Shader::SetGlobalMatrixImpl_Injected");
			Shader.GetGlobalVectorImpl_InjectedDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalVectorImpl_InjectedDelegate>("UnityEngine.Shader::GetGlobalVectorImpl_Injected");
			Shader.GetGlobalMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<Shader.GetGlobalMatrixImpl_InjectedDelegate>("UnityEngine.Shader::GetGlobalMatrixImpl_Injected");
			Shader.GetPropertyDefaultValue_InjectedDelegateField = IL2CPP.ResolveICall<Shader.GetPropertyDefaultValue_InjectedDelegate>("UnityEngine.Shader::GetPropertyDefaultValue_Injected");
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0003BF8C File Offset: 0x0003A18C
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 1235595, RefRangeEnd = 1235641, XrefRangeStart = 1235590, XrefRangeEnd = 1235595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Shader Find(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_Find_Public_Static_Shader_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x0003BFD0 File Offset: 0x0003A1D0
		public unsafe bool isSupported
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235643, RefRangeEnd = 1235644, XrefRangeStart = 1235641, XrefRangeEnd = 1235643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_isSupported_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x0003C8AC File Offset: 0x0003AAAC
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x0003C00C File Offset: 0x0003A20C
		public unsafe static string globalRenderPipeline
		{
			get
			{
				IntPtr intPtr = Shader.get_globalRenderPipelineDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1235646, RefRangeEnd = 1235648, XrefRangeStart = 1235644, XrefRangeEnd = 1235646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_set_globalRenderPipeline_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x0003C044 File Offset: 0x0003A244
		public unsafe UnityEngine.Rendering.LocalKeywordSpace keywordSpace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235650, RefRangeEnd = 1235651, XrefRangeStart = 1235648, XrefRangeEnd = 1235650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_keywordSpace_Public_get_LocalKeywordSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0003C080 File Offset: 0x0003A280
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1235653, RefRangeEnd = 1235664, XrefRangeStart = 1235651, XrefRangeEnd = 1235653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnableKeyword(string keyword)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0003C0B8 File Offset: 0x0003A2B8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1235666, RefRangeEnd = 1235689, XrefRangeStart = 1235664, XrefRangeEnd = 1235666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableKeyword(string keyword)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_DisableKeyword_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x0003C0F0 File Offset: 0x0003A2F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235691, RefRangeEnd = 1235693, XrefRangeStart = 1235689, XrefRangeEnd = 1235691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TagToID(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_TagToID_Internal_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0003C134 File Offset: 0x0003A334
		[CallerCount(256)]
		[CachedScanResults(RefRangeStart = 1235695, RefRangeEnd = 1235951, XrefRangeStart = 1235693, XrefRangeEnd = 1235695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PropertyToID(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_PropertyToID_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x0003C178 File Offset: 0x0003A378
		public unsafe int passCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1235953, RefRangeEnd = 1235955, XrefRangeStart = 1235951, XrefRangeEnd = 1235953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_passCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0003C1B4 File Offset: 0x0003A3B4
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1235957, RefRangeEnd = 1235977, XrefRangeStart = 1235955, XrefRangeEnd = 1235957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalFloatImpl(int name, float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalFloatImpl_Private_Static_Void_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0003C1F4 File Offset: 0x0003A3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235977, XrefRangeEnd = 1235979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVectorImpl(int name, Vector4 value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVectorImpl_Private_Static_Void_Int32_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x0003C234 File Offset: 0x0003A434
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1235981, RefRangeEnd = 1235988, XrefRangeStart = 1235979, XrefRangeEnd = 1235981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalTextureImpl(int name, Texture value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalTextureImpl_Private_Static_Void_Int32_Texture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0003C278 File Offset: 0x0003A478
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1235990, RefRangeEnd = 1235993, XrefRangeStart = 1235988, XrefRangeEnd = 1235990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalConstantBufferImpl_Private_Static_Void_Int32_ComputeBuffer_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0003C2D8 File Offset: 0x0003A4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235993, XrefRangeEnd = 1235995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVectorArrayImpl(int name, Il2CppStructArray<Vector4> values, int count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVectorArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0003C32C File Offset: 0x0003A52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235995, XrefRangeEnd = 1235997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalMatrixArrayImpl(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalMatrixArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0003C380 File Offset: 0x0003A580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235997, XrefRangeEnd = 1236017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVectorArray(int name, Il2CppStructArray<Vector4> values, int count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVectorArray_Private_Static_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0003C3D4 File Offset: 0x0003A5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236017, XrefRangeEnd = 1236037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalMatrixArray(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalMatrixArray_Private_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0003C428 File Offset: 0x0003A628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1236041, RefRangeEnd = 1236042, XrefRangeStart = 1236037, XrefRangeEnd = 1236041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalInt(string name, int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalInt_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0003C46C File Offset: 0x0003A66C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1236044, RefRangeEnd = 1236051, XrefRangeStart = 1236042, XrefRangeEnd = 1236044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalInt(int nameID, int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalInt_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0003C4AC File Offset: 0x0003A6AC
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1236055, RefRangeEnd = 1236078, XrefRangeStart = 1236051, XrefRangeEnd = 1236055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalFloat(string name, float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0003C4F0 File Offset: 0x0003A6F0
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1235957, RefRangeEnd = 1235977, XrefRangeStart = 1235957, XrefRangeEnd = 1235977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalFloat(int nameID, float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0003C530 File Offset: 0x0003A730
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1236082, RefRangeEnd = 1236109, XrefRangeStart = 1236078, XrefRangeEnd = 1236082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVector(string name, Vector4 value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_String_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0003C574 File Offset: 0x0003A774
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1236111, RefRangeEnd = 1236116, XrefRangeStart = 1236109, XrefRangeEnd = 1236111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVector(int nameID, Vector4 value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_Int32_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0003C5B4 File Offset: 0x0003A7B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1236120, RefRangeEnd = 1236126, XrefRangeStart = 1236116, XrefRangeEnd = 1236120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalColor(string name, Color value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalColor_Public_Static_Void_String_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0003C5F8 File Offset: 0x0003A7F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1236128, RefRangeEnd = 1236129, XrefRangeStart = 1236126, XrefRangeEnd = 1236128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalColor(int nameID, Color value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalColor_Public_Static_Void_Int32_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0003C638 File Offset: 0x0003A838
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1236133, RefRangeEnd = 1236141, XrefRangeStart = 1236129, XrefRangeEnd = 1236133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalTexture(string name, Texture value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_String_Texture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0003C680 File Offset: 0x0003A880
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1235981, RefRangeEnd = 1235988, XrefRangeStart = 1235981, XrefRangeEnd = 1235988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalTexture(int nameID, Texture value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_Int32_Texture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0003C6C4 File Offset: 0x0003A8C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1235990, RefRangeEnd = 1235993, XrefRangeStart = 1235990, XrefRangeEnd = 1235993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_Int32_ComputeBuffer_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0003C724 File Offset: 0x0003A924
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1236150, RefRangeEnd = 1236154, XrefRangeStart = 1236141, XrefRangeEnd = 1236150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVectorArray_Public_Static_Void_Int32_Il2CppStructArray_1_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0003C768 File Offset: 0x0003A968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236154, XrefRangeEnd = 1236163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalMatrixArray_Public_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0003C7AC File Offset: 0x0003A9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236163, XrefRangeEnd = 1236167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0003C7E8 File Offset: 0x0003A9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236167, XrefRangeEnd = 1236169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_keywordSpace_Injected(out UnityEngine.Rendering.LocalKeywordSpace ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_get_keywordSpace_Injected_Private_Void_byref_LocalKeywordSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0003C828 File Offset: 0x0003AA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236169, XrefRangeEnd = 1236171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shader.NativeMethodInfoPtr_SetGlobalVectorImpl_Injected_Private_Static_Void_Int32_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00007B7C File Offset: 0x00005D7C
		public Shader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x0003C868 File Offset: 0x0003AA68
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x00007B85 File Offset: 0x00005D85
		public static UnityEngine.Rendering.ShaderHardwareTier globalShaderHardwareTier
		{
			get
			{
				return (UnityEngine.Rendering.ShaderHardwareTier)Graphics.activeTier;
			}
			set
			{
				Graphics.activeTier = (UnityEngine.Rendering.GraphicsTier)value;
			}
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0003C880 File Offset: 0x0003AA80
		public static Shader FindBuiltin(string name)
		{
			IntPtr intPtr = Shader.FindBuiltinDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x00007B8F File Offset: 0x00005D8F
		// (set) Token: 0x06000C75 RID: 3189 RVA: 0x00007B9B File Offset: 0x00005D9B
		public static int maximumChunksOverride
		{
			get
			{
				return Shader.get_maximumChunksOverrideDelegateField();
			}
			set
			{
				Shader.set_maximumChunksOverrideDelegateField(value);
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00007BA8 File Offset: 0x00005DA8
		// (set) Token: 0x06000C77 RID: 3191 RVA: 0x00007BBA File Offset: 0x00005DBA
		public int maximumLOD
		{
			get
			{
				return Shader.get_maximumLODDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Shader.set_maximumLODDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00007BCD File Offset: 0x00005DCD
		// (set) Token: 0x06000C79 RID: 3193 RVA: 0x00007BD9 File Offset: 0x00005DD9
		public static int globalMaximumLOD
		{
			get
			{
				return Shader.get_globalMaximumLODDelegateField();
			}
			set
			{
				Shader.set_globalMaximumLODDelegateField(value);
			}
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00007BE6 File Offset: 0x00005DE6
		public static bool IsKeywordEnabled(string keyword)
		{
			return Shader.IsKeywordEnabledDelegateField(IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x00007BF8 File Offset: 0x00005DF8
		public int renderQueue
		{
			get
			{
				return Shader.get_renderQueueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x00007C0A File Offset: 0x00005E0A
		public DisableBatchingType disableBatching
		{
			get
			{
				return Shader.get_disableBatchingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00007C1C File Offset: 0x00005E1C
		public static void WarmupAllShaders()
		{
			Shader.WarmupAllShadersDelegateField();
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0003C8CC File Offset: 0x0003AACC
		public static string IDToTag(int name)
		{
			IntPtr intPtr = Shader.IDToTagDelegateField(name);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0003C8EC File Offset: 0x0003AAEC
		public Shader GetDependency(string name)
		{
			IntPtr intPtr = Shader.GetDependencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x00007C28 File Offset: 0x00005E28
		public int subshaderCount
		{
			get
			{
				return Shader.get_subshaderCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00007C3A File Offset: 0x00005E3A
		public int GetPassCountInSubshader(int subshaderIndex)
		{
			return Shader.GetPassCountInSubshaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), subshaderIndex);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0003C920 File Offset: 0x0003AB20
		public UnityEngine.Rendering.ShaderTagId FindPassTagValue(int passIndex, UnityEngine.Rendering.ShaderTagId tagName)
		{
			bool flag = passIndex < 0 || passIndex >= this.passCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("passIndex");
			}
			int id = this.Internal_FindPassTagValue(passIndex, tagName.id);
			return new UnityEngine.Rendering.ShaderTagId
			{
				id = id
			};
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0003C978 File Offset: 0x0003AB78
		public UnityEngine.Rendering.ShaderTagId FindPassTagValue(int subshaderIndex, int passIndex, UnityEngine.Rendering.ShaderTagId tagName)
		{
			bool flag = subshaderIndex < 0 || subshaderIndex >= this.subshaderCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("subshaderIndex");
			}
			bool flag2 = passIndex < 0 || passIndex >= this.GetPassCountInSubshader(subshaderIndex);
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("passIndex");
			}
			int id = this.Internal_FindPassTagValueInSubShader(subshaderIndex, passIndex, tagName.id);
			return new UnityEngine.Rendering.ShaderTagId
			{
				id = id
			};
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0003C9F4 File Offset: 0x0003ABF4
		public UnityEngine.Rendering.ShaderTagId FindSubshaderTagValue(int subshaderIndex, UnityEngine.Rendering.ShaderTagId tagName)
		{
			bool flag = subshaderIndex < 0 || subshaderIndex >= this.subshaderCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Invalid subshaderIndex {0}. Value must be in the range [0, {1})", subshaderIndex, this.subshaderCount));
			}
			int id = this.Internal_FindSubshaderTagValue(subshaderIndex, tagName.id);
			return new UnityEngine.Rendering.ShaderTagId
			{
				id = id
			};
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00007C4D File Offset: 0x00005E4D
		public int Internal_FindPassTagValue(int passIndex, int tagName)
		{
			return Shader.Internal_FindPassTagValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), passIndex, tagName);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00007C61 File Offset: 0x00005E61
		public int Internal_FindPassTagValueInSubShader(int subShaderIndex, int passIndex, int tagName)
		{
			return Shader.Internal_FindPassTagValueInSubShaderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), subShaderIndex, passIndex, tagName);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00007C76 File Offset: 0x00005E76
		public int Internal_FindSubshaderTagValue(int subShaderIndex, int tagName)
		{
			return Shader.Internal_FindSubshaderTagValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), subShaderIndex, tagName);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00007C8A File Offset: 0x00005E8A
		public static void SetGlobalIntImpl(int name, int value)
		{
			Shader.SetGlobalIntImplDelegateField(name, value);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00007C98 File Offset: 0x00005E98
		public static void SetGlobalMatrixImpl(int name, Matrix4x4 value)
		{
			Shader.SetGlobalMatrixImpl_Injected(name, ref value);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00007CA2 File Offset: 0x00005EA2
		public static void SetGlobalRenderTextureImpl(int name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			Shader.SetGlobalRenderTextureImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(value), element);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00007CB6 File Offset: 0x00005EB6
		public static void SetGlobalBufferImpl(int name, ComputeBuffer value)
		{
			Shader.SetGlobalBufferImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00007CC9 File Offset: 0x00005EC9
		public static void SetGlobalGraphicsBufferImpl(int name, GraphicsBuffer value)
		{
			Shader.SetGlobalGraphicsBufferImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00007CDC File Offset: 0x00005EDC
		public static void SetGlobalConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size)
		{
			Shader.SetGlobalConstantGraphicsBufferImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00007CF1 File Offset: 0x00005EF1
		public static int GetGlobalIntImpl(int name)
		{
			return Shader.GetGlobalIntImplDelegateField(name);
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00007CFE File Offset: 0x00005EFE
		public static float GetGlobalFloatImpl(int name)
		{
			return Shader.GetGlobalFloatImplDelegateField(name);
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x0003CA60 File Offset: 0x0003AC60
		public static Vector4 GetGlobalVectorImpl(int name)
		{
			Vector4 result;
			Shader.GetGlobalVectorImpl_Injected(name, out result);
			return result;
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x0003CA78 File Offset: 0x0003AC78
		public static Matrix4x4 GetGlobalMatrixImpl(int name)
		{
			Matrix4x4 result;
			Shader.GetGlobalMatrixImpl_Injected(name, out result);
			return result;
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0003CA90 File Offset: 0x0003AC90
		public static Texture GetGlobalTextureImpl(int name)
		{
			IntPtr intPtr = Shader.GetGlobalTextureImplDelegateField(name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00007D0B File Offset: 0x00005F0B
		public static void SetGlobalFloatArrayImpl(int name, Il2CppStructArray<float> values, int count)
		{
			Shader.SetGlobalFloatArrayImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x0003CAB8 File Offset: 0x0003ACB8
		public static Il2CppStructArray<float> GetGlobalFloatArrayImpl(int name)
		{
			IntPtr intPtr = Shader.GetGlobalFloatArrayImplDelegateField(name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x0003CAE0 File Offset: 0x0003ACE0
		public static Il2CppStructArray<Vector4> GetGlobalVectorArrayImpl(int name)
		{
			IntPtr intPtr = Shader.GetGlobalVectorArrayImplDelegateField(name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x0003CB08 File Offset: 0x0003AD08
		public static Il2CppStructArray<Matrix4x4> GetGlobalMatrixArrayImpl(int name)
		{
			IntPtr intPtr = Shader.GetGlobalMatrixArrayImplDelegateField(name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00007D1F File Offset: 0x00005F1F
		public static int GetGlobalFloatArrayCountImpl(int name)
		{
			return Shader.GetGlobalFloatArrayCountImplDelegateField(name);
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00007D2C File Offset: 0x00005F2C
		public static int GetGlobalVectorArrayCountImpl(int name)
		{
			return Shader.GetGlobalVectorArrayCountImplDelegateField(name);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00007D39 File Offset: 0x00005F39
		public static int GetGlobalMatrixArrayCountImpl(int name)
		{
			return Shader.GetGlobalMatrixArrayCountImplDelegateField(name);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00007D46 File Offset: 0x00005F46
		public static void ExtractGlobalFloatArrayImpl(int name, [Out] Il2CppStructArray<float> val)
		{
			Shader.ExtractGlobalFloatArrayImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00007D59 File Offset: 0x00005F59
		public static void ExtractGlobalVectorArrayImpl(int name, [Out] Il2CppStructArray<Vector4> val)
		{
			Shader.ExtractGlobalVectorArrayImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00007D6C File Offset: 0x00005F6C
		public static void ExtractGlobalMatrixArrayImpl(int name, [Out] Il2CppStructArray<Matrix4x4> val)
		{
			Shader.ExtractGlobalMatrixArrayImplDelegateField(name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0003CB30 File Offset: 0x0003AD30
		public static void SetGlobalFloatArray(int name, Il2CppStructArray<float> values, int count)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			bool flag3 = values.Length < count;
			if (flag3)
			{
				throw new ArgumentException("array has less elements than passed count.");
			}
			Shader.SetGlobalFloatArrayImpl(name, values, count);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x0003CB8C File Offset: 0x0003AD8C
		public static void ExtractGlobalFloatArray(int name, List<float> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int globalFloatArrayCountImpl = Shader.GetGlobalFloatArrayCountImpl(name);
			bool flag2 = globalFloatArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<float>(values, globalFloatArrayCountImpl);
				Shader.ExtractGlobalFloatArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<float>>());
			}
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0003CBE0 File Offset: 0x0003ADE0
		public static void ExtractGlobalVectorArray(int name, List<Vector4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int globalVectorArrayCountImpl = Shader.GetGlobalVectorArrayCountImpl(name);
			bool flag2 = globalVectorArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Vector4>(values, globalVectorArrayCountImpl);
				Shader.ExtractGlobalVectorArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Vector4>>());
			}
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0003CC34 File Offset: 0x0003AE34
		public static void ExtractGlobalMatrixArray(int name, List<Matrix4x4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int globalMatrixArrayCountImpl = Shader.GetGlobalMatrixArrayCountImpl(name);
			bool flag2 = globalMatrixArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Matrix4x4>(values, globalMatrixArrayCountImpl);
				Shader.ExtractGlobalMatrixArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Matrix4x4>>());
			}
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00007D7F File Offset: 0x00005F7F
		public static void SetGlobalInteger(string name, int value)
		{
			Shader.SetGlobalIntImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00007D8F File Offset: 0x00005F8F
		public static void SetGlobalInteger(int nameID, int value)
		{
			Shader.SetGlobalIntImpl(nameID, value);
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00007D9A File Offset: 0x00005F9A
		public static void SetGlobalMatrix(string name, Matrix4x4 value)
		{
			Shader.SetGlobalMatrixImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00007DAA File Offset: 0x00005FAA
		public static void SetGlobalMatrix(int nameID, Matrix4x4 value)
		{
			Shader.SetGlobalMatrixImpl(nameID, value);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00007DB5 File Offset: 0x00005FB5
		public static void SetGlobalTexture(string name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			Shader.SetGlobalRenderTextureImpl(Shader.PropertyToID(name), value, element);
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00007DC6 File Offset: 0x00005FC6
		public static void SetGlobalTexture(int nameID, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			Shader.SetGlobalRenderTextureImpl(nameID, value, element);
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00007DD2 File Offset: 0x00005FD2
		public static void SetGlobalBuffer(string name, ComputeBuffer value)
		{
			Shader.SetGlobalBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00007DE2 File Offset: 0x00005FE2
		public static void SetGlobalBuffer(int nameID, ComputeBuffer value)
		{
			Shader.SetGlobalBufferImpl(nameID, value);
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00007DED File Offset: 0x00005FED
		public static void SetGlobalBuffer(string name, GraphicsBuffer value)
		{
			Shader.SetGlobalGraphicsBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00007DFD File Offset: 0x00005FFD
		public static void SetGlobalBuffer(int nameID, GraphicsBuffer value)
		{
			Shader.SetGlobalGraphicsBufferImpl(nameID, value);
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00007E08 File Offset: 0x00006008
		public static void SetGlobalConstantBuffer(string name, ComputeBuffer value, int offset, int size)
		{
			Shader.SetGlobalConstantBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00007E1A File Offset: 0x0000601A
		public static void SetGlobalConstantBuffer(string name, GraphicsBuffer value, int offset, int size)
		{
			Shader.SetGlobalConstantGraphicsBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00007E2C File Offset: 0x0000602C
		public static void SetGlobalConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size)
		{
			Shader.SetGlobalConstantGraphicsBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00007E39 File Offset: 0x00006039
		public static void SetGlobalFloatArray(string name, List<float> values)
		{
			Shader.SetGlobalFloatArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00007E54 File Offset: 0x00006054
		public static void SetGlobalFloatArray(int nameID, List<float> values)
		{
			Shader.SetGlobalFloatArray(nameID, NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00007E6A File Offset: 0x0000606A
		public static void SetGlobalFloatArray(string name, Il2CppStructArray<float> values)
		{
			Shader.SetGlobalFloatArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00007E81 File Offset: 0x00006081
		public static void SetGlobalFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			Shader.SetGlobalFloatArray(nameID, values, values.Length);
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00007E93 File Offset: 0x00006093
		public static void SetGlobalVectorArray(string name, List<Vector4> values)
		{
			Shader.SetGlobalVectorArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00007EAE File Offset: 0x000060AE
		public static void SetGlobalVectorArray(int nameID, List<Vector4> values)
		{
			Shader.SetGlobalVectorArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00007EC4 File Offset: 0x000060C4
		public static void SetGlobalVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			Shader.SetGlobalVectorArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00007EDB File Offset: 0x000060DB
		public static void SetGlobalMatrixArray(string name, List<Matrix4x4> values)
		{
			Shader.SetGlobalMatrixArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00007EF6 File Offset: 0x000060F6
		public static void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values)
		{
			Shader.SetGlobalMatrixArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00007F0C File Offset: 0x0000610C
		public static void SetGlobalMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			Shader.SetGlobalMatrixArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0003CC88 File Offset: 0x0003AE88
		public static int GetGlobalInt(string name)
		{
			return (int)Shader.GetGlobalFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0003CCA8 File Offset: 0x0003AEA8
		public static int GetGlobalInt(int nameID)
		{
			return (int)Shader.GetGlobalFloatImpl(nameID);
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x0003CCC4 File Offset: 0x0003AEC4
		public static float GetGlobalFloat(string name)
		{
			return Shader.GetGlobalFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x0003CCE4 File Offset: 0x0003AEE4
		public static float GetGlobalFloat(int nameID)
		{
			return Shader.GetGlobalFloatImpl(nameID);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x0003CCFC File Offset: 0x0003AEFC
		public static int GetGlobalInteger(string name)
		{
			return Shader.GetGlobalIntImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x0003CD1C File Offset: 0x0003AF1C
		public static int GetGlobalInteger(int nameID)
		{
			return Shader.GetGlobalIntImpl(nameID);
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x0003CD34 File Offset: 0x0003AF34
		public static Vector4 GetGlobalVector(string name)
		{
			return Shader.GetGlobalVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x0003CD54 File Offset: 0x0003AF54
		public static Vector4 GetGlobalVector(int nameID)
		{
			return Shader.GetGlobalVectorImpl(nameID);
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0003CD6C File Offset: 0x0003AF6C
		public static Color GetGlobalColor(string name)
		{
			return Shader.GetGlobalVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x0003CD90 File Offset: 0x0003AF90
		public static Color GetGlobalColor(int nameID)
		{
			return Shader.GetGlobalVectorImpl(nameID);
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0003CDB0 File Offset: 0x0003AFB0
		public static Matrix4x4 GetGlobalMatrix(string name)
		{
			return Shader.GetGlobalMatrixImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0003CDD0 File Offset: 0x0003AFD0
		public static Matrix4x4 GetGlobalMatrix(int nameID)
		{
			return Shader.GetGlobalMatrixImpl(nameID);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x0003CDE8 File Offset: 0x0003AFE8
		public static Texture GetGlobalTexture(string name)
		{
			return Shader.GetGlobalTextureImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x0003CE08 File Offset: 0x0003B008
		public static Texture GetGlobalTexture(int nameID)
		{
			return Shader.GetGlobalTextureImpl(nameID);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0003CE20 File Offset: 0x0003B020
		public static Il2CppStructArray<float> GetGlobalFloatArray(string name)
		{
			return Shader.GetGlobalFloatArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x0003CE40 File Offset: 0x0003B040
		public static Il2CppStructArray<float> GetGlobalFloatArray(int nameID)
		{
			return (Shader.GetGlobalFloatArrayCountImpl(nameID) != 0) ? Shader.GetGlobalFloatArrayImpl(nameID) : null;
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x0003CE64 File Offset: 0x0003B064
		public static Il2CppStructArray<Vector4> GetGlobalVectorArray(string name)
		{
			return Shader.GetGlobalVectorArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x0003CE84 File Offset: 0x0003B084
		public static Il2CppStructArray<Vector4> GetGlobalVectorArray(int nameID)
		{
			return (Shader.GetGlobalVectorArrayCountImpl(nameID) != 0) ? Shader.GetGlobalVectorArrayImpl(nameID) : null;
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x0003CEA8 File Offset: 0x0003B0A8
		public static Il2CppStructArray<Matrix4x4> GetGlobalMatrixArray(string name)
		{
			return Shader.GetGlobalMatrixArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x0003CEC8 File Offset: 0x0003B0C8
		public static Il2CppStructArray<Matrix4x4> GetGlobalMatrixArray(int nameID)
		{
			return (Shader.GetGlobalMatrixArrayCountImpl(nameID) != 0) ? Shader.GetGlobalMatrixArrayImpl(nameID) : null;
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x00007F23 File Offset: 0x00006123
		public static void GetGlobalFloatArray(string name, List<float> values)
		{
			Shader.ExtractGlobalFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00007F33 File Offset: 0x00006133
		public static void GetGlobalFloatArray(int nameID, List<float> values)
		{
			Shader.ExtractGlobalFloatArray(nameID, values);
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00007F3E File Offset: 0x0000613E
		public static void GetGlobalVectorArray(string name, List<Vector4> values)
		{
			Shader.ExtractGlobalVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00007F4E File Offset: 0x0000614E
		public static void GetGlobalVectorArray(int nameID, List<Vector4> values)
		{
			Shader.ExtractGlobalVectorArray(nameID, values);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00007F59 File Offset: 0x00006159
		public static void GetGlobalMatrixArray(string name, List<Matrix4x4> values)
		{
			Shader.ExtractGlobalMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00007F69 File Offset: 0x00006169
		public static void GetGlobalMatrixArray(int nameID, List<Matrix4x4> values)
		{
			Shader.ExtractGlobalMatrixArray(nameID, values);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0003CEEC File Offset: 0x0003B0EC
		public static string GetPropertyName(Shader shader, int propertyIndex)
		{
			IntPtr intPtr = Shader.GetPropertyNameDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00007F74 File Offset: 0x00006174
		public static int GetPropertyNameId(Shader shader, int propertyIndex)
		{
			return Shader.GetPropertyNameIdDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00007F87 File Offset: 0x00006187
		public static UnityEngine.Rendering.ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex)
		{
			return Shader.GetPropertyTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x0003CF14 File Offset: 0x0003B114
		public static string GetPropertyDescription(Shader shader, int propertyIndex)
		{
			IntPtr intPtr = Shader.GetPropertyDescriptionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00007F9A File Offset: 0x0000619A
		public static UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(Shader shader, int propertyIndex)
		{
			return Shader.GetPropertyFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0003CF3C File Offset: 0x0003B13C
		public static Il2CppStringArray GetPropertyAttributes(Shader shader, int propertyIndex)
		{
			IntPtr intPtr = Shader.GetPropertyAttributesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00007FAD File Offset: 0x000061AD
		public static int GetPropertyDefaultIntValue(Shader shader, int propertyIndex)
		{
			return Shader.GetPropertyDefaultIntValueDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0003CF6C File Offset: 0x0003B16C
		public static Vector4 GetPropertyDefaultValue(Shader shader, int propertyIndex)
		{
			Vector4 result;
			Shader.GetPropertyDefaultValue_Injected(shader, propertyIndex, out result);
			return result;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00007FC0 File Offset: 0x000061C0
		public static UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(Shader shader, int propertyIndex)
		{
			return Shader.GetPropertyTextureDimensionDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0003CF84 File Offset: 0x0003B184
		public static string GetPropertyTextureDefaultName(Shader shader, int propertyIndex)
		{
			IntPtr intPtr = Shader.GetPropertyTextureDefaultNameDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x0003CFAC File Offset: 0x0003B1AC
		public unsafe static bool FindTextureStackImpl(Shader s, int propertyIdx, out string stackName, out int layerIndex)
		{
			Shader.FindTextureStackImplDelegate findTextureStackImplDelegateField = Shader.FindTextureStackImplDelegateField;
			IntPtr s2 = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(stackName);
			return findTextureStackImplDelegateField(s2, propertyIdx, &intPtr, out layerIndex);
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x0003CFD8 File Offset: 0x0003B1D8
		public static void CheckPropertyIndex(Shader s, int propertyIndex)
		{
			bool flag = propertyIndex < 0 || propertyIndex >= s.GetPropertyCount();
			if (flag)
			{
				throw new ArgumentOutOfRangeException("propertyIndex");
			}
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00007FD3 File Offset: 0x000061D3
		public int GetPropertyCount()
		{
			return Shader.GetPropertyCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00007FE5 File Offset: 0x000061E5
		public int FindPropertyIndex(string propertyName)
		{
			return Shader.FindPropertyIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(propertyName));
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0003D008 File Offset: 0x0003B208
		public string GetPropertyName(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyName(this, propertyIndex);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x0003D02C File Offset: 0x0003B22C
		public int GetPropertyNameId(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyNameId(this, propertyIndex);
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0003D050 File Offset: 0x0003B250
		public UnityEngine.Rendering.ShaderPropertyType GetPropertyType(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyType(this, propertyIndex);
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x0003D074 File Offset: 0x0003B274
		public string GetPropertyDescription(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyDescription(this, propertyIndex);
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0003D098 File Offset: 0x0003B298
		public UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyFlags(this, propertyIndex);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x0003D0BC File Offset: 0x0003B2BC
		public Il2CppStringArray GetPropertyAttributes(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			return Shader.GetPropertyAttributes(this, propertyIndex);
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x0003D0E0 File Offset: 0x0003B2E0
		public float GetPropertyDefaultFloatValue(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			UnityEngine.Rendering.ShaderPropertyType propertyType = this.GetPropertyType(propertyIndex);
			bool flag = propertyType != UnityEngine.Rendering.ShaderPropertyType.Float && propertyType != UnityEngine.Rendering.ShaderPropertyType.Range;
			if (flag)
			{
				throw new ArgumentException("Property type is not Float or Range.");
			}
			return Shader.GetPropertyDefaultValue(this, propertyIndex)[0];
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0003D130 File Offset: 0x0003B330
		public Vector4 GetPropertyDefaultVectorValue(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			UnityEngine.Rendering.ShaderPropertyType propertyType = this.GetPropertyType(propertyIndex);
			bool flag = propertyType != UnityEngine.Rendering.ShaderPropertyType.Color && propertyType != UnityEngine.Rendering.ShaderPropertyType.Vector;
			if (flag)
			{
				throw new ArgumentException("Property type is not Color or Vector.");
			}
			return Shader.GetPropertyDefaultValue(this, propertyIndex);
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0003D178 File Offset: 0x0003B378
		public Vector2 GetPropertyRangeLimits(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			bool flag = this.GetPropertyType(propertyIndex) != UnityEngine.Rendering.ShaderPropertyType.Range;
			if (flag)
			{
				throw new ArgumentException("Property type is not Range.");
			}
			Vector4 propertyDefaultValue = Shader.GetPropertyDefaultValue(this, propertyIndex);
			return new Vector2(propertyDefaultValue[1], propertyDefaultValue[2]);
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x0003D1CC File Offset: 0x0003B3CC
		public int GetPropertyDefaultIntValue(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			bool flag = this.GetPropertyType(propertyIndex) != UnityEngine.Rendering.ShaderPropertyType.Int;
			if (flag)
			{
				throw new ArgumentException("Property type is not Int.");
			}
			return Shader.GetPropertyDefaultIntValue(this, propertyIndex);
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x0003D20C File Offset: 0x0003B40C
		public UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			bool flag = this.GetPropertyType(propertyIndex) != UnityEngine.Rendering.ShaderPropertyType.Texture;
			if (flag)
			{
				throw new ArgumentException("Property type is not TexEnv.");
			}
			return Shader.GetPropertyTextureDimension(this, propertyIndex);
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x0003D24C File Offset: 0x0003B44C
		public string GetPropertyTextureDefaultName(int propertyIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			UnityEngine.Rendering.ShaderPropertyType propertyType = this.GetPropertyType(propertyIndex);
			bool flag = propertyType != UnityEngine.Rendering.ShaderPropertyType.Texture;
			if (flag)
			{
				throw new ArgumentException("Property type is not Texture.");
			}
			return Shader.GetPropertyTextureDefaultName(this, propertyIndex);
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x0003D28C File Offset: 0x0003B48C
		public bool FindTextureStack(int propertyIndex, out string stackName, out int layerIndex)
		{
			Shader.CheckPropertyIndex(this, propertyIndex);
			UnityEngine.Rendering.ShaderPropertyType propertyType = this.GetPropertyType(propertyIndex);
			bool flag = propertyType != UnityEngine.Rendering.ShaderPropertyType.Texture;
			if (flag)
			{
				throw new ArgumentException("Property type is not Texture.");
			}
			return Shader.FindTextureStackImpl(this, propertyIndex, out stackName, out layerIndex);
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00007FFD File Offset: 0x000061FD
		public static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value)
		{
			Shader.SetGlobalMatrixImpl_InjectedDelegateField(name, ref value);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x0000800B File Offset: 0x0000620B
		public static void GetGlobalVectorImpl_Injected(int name, out Vector4 ret)
		{
			Shader.GetGlobalVectorImpl_InjectedDelegateField(name, out ret);
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00008019 File Offset: 0x00006219
		public static void GetGlobalMatrixImpl_Injected(int name, out Matrix4x4 ret)
		{
			Shader.GetGlobalMatrixImpl_InjectedDelegateField(name, out ret);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00008027 File Offset: 0x00006227
		public static void GetPropertyDefaultValue_Injected(Shader shader, int propertyIndex, out Vector4 ret)
		{
			Shader.GetPropertyDefaultValue_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), propertyIndex, out ret);
		}

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_Shader_String_0;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeMethodInfoPtr_get_isSupported_Public_get_Boolean_0;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeMethodInfoPtr_set_globalRenderPipeline_Public_Static_set_Void_String_0;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeMethodInfoPtr_get_keywordSpace_Public_get_LocalKeywordSpace_0;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_String_0;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_DisableKeyword_Public_Static_Void_String_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr_TagToID_Internal_Static_Int32_String_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_PropertyToID_Public_Static_Int32_String_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr_get_passCount_Public_get_Int32_0;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloatImpl_Private_Static_Void_Int32_Single_0;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVectorImpl_Private_Static_Void_Int32_Vector4_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalTextureImpl_Private_Static_Void_Int32_Texture_0;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalConstantBufferImpl_Private_Static_Void_Int32_ComputeBuffer_Int32_Int32_0;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVectorArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalMatrixArrayImpl_Private_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVectorArray_Private_Static_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalMatrixArray_Private_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalInt_Public_Static_Void_String_Int32_0;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalInt_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_String_Single_0;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_Int32_Single_0;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_String_Vector4_0;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVector_Public_Static_Void_Int32_Vector4_0;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalColor_Public_Static_Void_String_Color_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalColor_Public_Static_Void_Int32_Color_0;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_String_Texture_0;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_Int32_Texture_0;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_Int32_ComputeBuffer_Int32_Int32_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVectorArray_Public_Static_Void_Int32_Il2CppStructArray_1_Vector4_0;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalMatrixArray_Public_Static_Void_Int32_Il2CppStructArray_1_Matrix4x4_0;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeMethodInfoPtr_get_keywordSpace_Injected_Private_Void_byref_LocalKeywordSpace_0;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVectorImpl_Injected_Private_Static_Void_Int32_byref_Vector4_0;

		// Token: 0x04000976 RID: 2422
		private static readonly Shader.FindBuiltinDelegate FindBuiltinDelegateField;

		// Token: 0x04000977 RID: 2423
		private static readonly Shader.get_maximumChunksOverrideDelegate get_maximumChunksOverrideDelegateField;

		// Token: 0x04000978 RID: 2424
		private static readonly Shader.set_maximumChunksOverrideDelegate set_maximumChunksOverrideDelegateField;

		// Token: 0x04000979 RID: 2425
		private static readonly Shader.get_maximumLODDelegate get_maximumLODDelegateField;

		// Token: 0x0400097A RID: 2426
		private static readonly Shader.set_maximumLODDelegate set_maximumLODDelegateField;

		// Token: 0x0400097B RID: 2427
		private static readonly Shader.get_globalMaximumLODDelegate get_globalMaximumLODDelegateField;

		// Token: 0x0400097C RID: 2428
		private static readonly Shader.set_globalMaximumLODDelegate set_globalMaximumLODDelegateField;

		// Token: 0x0400097D RID: 2429
		private static readonly Shader.get_globalRenderPipelineDelegate get_globalRenderPipelineDelegateField;

		// Token: 0x0400097E RID: 2430
		private static readonly Shader.IsKeywordEnabledDelegate IsKeywordEnabledDelegateField;

		// Token: 0x0400097F RID: 2431
		private static readonly Shader.get_renderQueueDelegate get_renderQueueDelegateField;

		// Token: 0x04000980 RID: 2432
		private static readonly Shader.get_disableBatchingDelegate get_disableBatchingDelegateField;

		// Token: 0x04000981 RID: 2433
		private static readonly Shader.WarmupAllShadersDelegate WarmupAllShadersDelegateField;

		// Token: 0x04000982 RID: 2434
		private static readonly Shader.IDToTagDelegate IDToTagDelegateField;

		// Token: 0x04000983 RID: 2435
		private static readonly Shader.GetDependencyDelegate GetDependencyDelegateField;

		// Token: 0x04000984 RID: 2436
		private static readonly Shader.get_subshaderCountDelegate get_subshaderCountDelegateField;

		// Token: 0x04000985 RID: 2437
		private static readonly Shader.GetPassCountInSubshaderDelegate GetPassCountInSubshaderDelegateField;

		// Token: 0x04000986 RID: 2438
		private static readonly Shader.Internal_FindPassTagValueDelegate Internal_FindPassTagValueDelegateField;

		// Token: 0x04000987 RID: 2439
		private static readonly Shader.Internal_FindPassTagValueInSubShaderDelegate Internal_FindPassTagValueInSubShaderDelegateField;

		// Token: 0x04000988 RID: 2440
		private static readonly Shader.Internal_FindSubshaderTagValueDelegate Internal_FindSubshaderTagValueDelegateField;

		// Token: 0x04000989 RID: 2441
		private static readonly Shader.SetGlobalIntImplDelegate SetGlobalIntImplDelegateField;

		// Token: 0x0400098A RID: 2442
		private static readonly Shader.SetGlobalRenderTextureImplDelegate SetGlobalRenderTextureImplDelegateField;

		// Token: 0x0400098B RID: 2443
		private static readonly Shader.SetGlobalBufferImplDelegate SetGlobalBufferImplDelegateField;

		// Token: 0x0400098C RID: 2444
		private static readonly Shader.SetGlobalGraphicsBufferImplDelegate SetGlobalGraphicsBufferImplDelegateField;

		// Token: 0x0400098D RID: 2445
		private static readonly Shader.SetGlobalConstantGraphicsBufferImplDelegate SetGlobalConstantGraphicsBufferImplDelegateField;

		// Token: 0x0400098E RID: 2446
		private static readonly Shader.GetGlobalIntImplDelegate GetGlobalIntImplDelegateField;

		// Token: 0x0400098F RID: 2447
		private static readonly Shader.GetGlobalFloatImplDelegate GetGlobalFloatImplDelegateField;

		// Token: 0x04000990 RID: 2448
		private static readonly Shader.GetGlobalTextureImplDelegate GetGlobalTextureImplDelegateField;

		// Token: 0x04000991 RID: 2449
		private static readonly Shader.SetGlobalFloatArrayImplDelegate SetGlobalFloatArrayImplDelegateField;

		// Token: 0x04000992 RID: 2450
		private static readonly Shader.GetGlobalFloatArrayImplDelegate GetGlobalFloatArrayImplDelegateField;

		// Token: 0x04000993 RID: 2451
		private static readonly Shader.GetGlobalVectorArrayImplDelegate GetGlobalVectorArrayImplDelegateField;

		// Token: 0x04000994 RID: 2452
		private static readonly Shader.GetGlobalMatrixArrayImplDelegate GetGlobalMatrixArrayImplDelegateField;

		// Token: 0x04000995 RID: 2453
		private static readonly Shader.GetGlobalFloatArrayCountImplDelegate GetGlobalFloatArrayCountImplDelegateField;

		// Token: 0x04000996 RID: 2454
		private static readonly Shader.GetGlobalVectorArrayCountImplDelegate GetGlobalVectorArrayCountImplDelegateField;

		// Token: 0x04000997 RID: 2455
		private static readonly Shader.GetGlobalMatrixArrayCountImplDelegate GetGlobalMatrixArrayCountImplDelegateField;

		// Token: 0x04000998 RID: 2456
		private static readonly Shader.ExtractGlobalFloatArrayImplDelegate ExtractGlobalFloatArrayImplDelegateField;

		// Token: 0x04000999 RID: 2457
		private static readonly Shader.ExtractGlobalVectorArrayImplDelegate ExtractGlobalVectorArrayImplDelegateField;

		// Token: 0x0400099A RID: 2458
		private static readonly Shader.ExtractGlobalMatrixArrayImplDelegate ExtractGlobalMatrixArrayImplDelegateField;

		// Token: 0x0400099B RID: 2459
		private static readonly Shader.GetPropertyNameDelegate GetPropertyNameDelegateField;

		// Token: 0x0400099C RID: 2460
		private static readonly Shader.GetPropertyNameIdDelegate GetPropertyNameIdDelegateField;

		// Token: 0x0400099D RID: 2461
		private static readonly Shader.GetPropertyTypeDelegate GetPropertyTypeDelegateField;

		// Token: 0x0400099E RID: 2462
		private static readonly Shader.GetPropertyDescriptionDelegate GetPropertyDescriptionDelegateField;

		// Token: 0x0400099F RID: 2463
		private static readonly Shader.GetPropertyFlagsDelegate GetPropertyFlagsDelegateField;

		// Token: 0x040009A0 RID: 2464
		private static readonly Shader.GetPropertyAttributesDelegate GetPropertyAttributesDelegateField;

		// Token: 0x040009A1 RID: 2465
		private static readonly Shader.GetPropertyDefaultIntValueDelegate GetPropertyDefaultIntValueDelegateField;

		// Token: 0x040009A2 RID: 2466
		private static readonly Shader.GetPropertyTextureDimensionDelegate GetPropertyTextureDimensionDelegateField;

		// Token: 0x040009A3 RID: 2467
		private static readonly Shader.GetPropertyTextureDefaultNameDelegate GetPropertyTextureDefaultNameDelegateField;

		// Token: 0x040009A4 RID: 2468
		private static readonly Shader.FindTextureStackImplDelegate FindTextureStackImplDelegateField;

		// Token: 0x040009A5 RID: 2469
		private static readonly Shader.GetPropertyCountDelegate GetPropertyCountDelegateField;

		// Token: 0x040009A6 RID: 2470
		private static readonly Shader.FindPropertyIndexDelegate FindPropertyIndexDelegateField;

		// Token: 0x040009A7 RID: 2471
		private static readonly Shader.SetGlobalMatrixImpl_InjectedDelegate SetGlobalMatrixImpl_InjectedDelegateField;

		// Token: 0x040009A8 RID: 2472
		private static readonly Shader.GetGlobalVectorImpl_InjectedDelegate GetGlobalVectorImpl_InjectedDelegateField;

		// Token: 0x040009A9 RID: 2473
		private static readonly Shader.GetGlobalMatrixImpl_InjectedDelegate GetGlobalMatrixImpl_InjectedDelegateField;

		// Token: 0x040009AA RID: 2474
		private static readonly Shader.GetPropertyDefaultValue_InjectedDelegate GetPropertyDefaultValue_InjectedDelegateField;

		// Token: 0x0200068F RID: 1679
		// (Invoke) Token: 0x060035D8 RID: 13784
		private delegate IntPtr FindBuiltinDelegate(IntPtr name);

		// Token: 0x02000690 RID: 1680
		// (Invoke) Token: 0x060035DA RID: 13786
		private delegate int get_maximumChunksOverrideDelegate();

		// Token: 0x02000691 RID: 1681
		// (Invoke) Token: 0x060035DC RID: 13788
		private delegate void set_maximumChunksOverrideDelegate(int value);

		// Token: 0x02000692 RID: 1682
		// (Invoke) Token: 0x060035DE RID: 13790
		private delegate int get_maximumLODDelegate(IntPtr @this);

		// Token: 0x02000693 RID: 1683
		// (Invoke) Token: 0x060035E0 RID: 13792
		private delegate void set_maximumLODDelegate(IntPtr @this, int value);

		// Token: 0x02000694 RID: 1684
		// (Invoke) Token: 0x060035E2 RID: 13794
		private delegate int get_globalMaximumLODDelegate();

		// Token: 0x02000695 RID: 1685
		// (Invoke) Token: 0x060035E4 RID: 13796
		private delegate void set_globalMaximumLODDelegate(int value);

		// Token: 0x02000696 RID: 1686
		// (Invoke) Token: 0x060035E6 RID: 13798
		private delegate IntPtr get_globalRenderPipelineDelegate();

		// Token: 0x02000697 RID: 1687
		// (Invoke) Token: 0x060035E8 RID: 13800
		private delegate bool IsKeywordEnabledDelegate(IntPtr keyword);

		// Token: 0x02000698 RID: 1688
		// (Invoke) Token: 0x060035EA RID: 13802
		private delegate int get_renderQueueDelegate(IntPtr @this);

		// Token: 0x02000699 RID: 1689
		// (Invoke) Token: 0x060035EC RID: 13804
		private delegate DisableBatchingType get_disableBatchingDelegate(IntPtr @this);

		// Token: 0x0200069A RID: 1690
		// (Invoke) Token: 0x060035EE RID: 13806
		private delegate void WarmupAllShadersDelegate();

		// Token: 0x0200069B RID: 1691
		// (Invoke) Token: 0x060035F0 RID: 13808
		private delegate IntPtr IDToTagDelegate(int name);

		// Token: 0x0200069C RID: 1692
		// (Invoke) Token: 0x060035F2 RID: 13810
		private delegate IntPtr GetDependencyDelegate(IntPtr @this, IntPtr name);

		// Token: 0x0200069D RID: 1693
		// (Invoke) Token: 0x060035F4 RID: 13812
		private delegate int get_subshaderCountDelegate(IntPtr @this);

		// Token: 0x0200069E RID: 1694
		// (Invoke) Token: 0x060035F6 RID: 13814
		private delegate int GetPassCountInSubshaderDelegate(IntPtr @this, int subshaderIndex);

		// Token: 0x0200069F RID: 1695
		// (Invoke) Token: 0x060035F8 RID: 13816
		private delegate int Internal_FindPassTagValueDelegate(IntPtr @this, int passIndex, int tagName);

		// Token: 0x020006A0 RID: 1696
		// (Invoke) Token: 0x060035FA RID: 13818
		private delegate int Internal_FindPassTagValueInSubShaderDelegate(IntPtr @this, int subShaderIndex, int passIndex, int tagName);

		// Token: 0x020006A1 RID: 1697
		// (Invoke) Token: 0x060035FC RID: 13820
		private delegate int Internal_FindSubshaderTagValueDelegate(IntPtr @this, int subShaderIndex, int tagName);

		// Token: 0x020006A2 RID: 1698
		// (Invoke) Token: 0x060035FE RID: 13822
		private delegate void SetGlobalIntImplDelegate(int name, int value);

		// Token: 0x020006A3 RID: 1699
		// (Invoke) Token: 0x06003600 RID: 13824
		private delegate void SetGlobalRenderTextureImplDelegate(int name, IntPtr value, UnityEngine.Rendering.RenderTextureSubElement element);

		// Token: 0x020006A4 RID: 1700
		// (Invoke) Token: 0x06003602 RID: 13826
		private delegate void SetGlobalBufferImplDelegate(int name, IntPtr value);

		// Token: 0x020006A5 RID: 1701
		// (Invoke) Token: 0x06003604 RID: 13828
		private delegate void SetGlobalGraphicsBufferImplDelegate(int name, IntPtr value);

		// Token: 0x020006A6 RID: 1702
		// (Invoke) Token: 0x06003606 RID: 13830
		private delegate void SetGlobalConstantGraphicsBufferImplDelegate(int name, IntPtr value, int offset, int size);

		// Token: 0x020006A7 RID: 1703
		// (Invoke) Token: 0x06003608 RID: 13832
		private delegate int GetGlobalIntImplDelegate(int name);

		// Token: 0x020006A8 RID: 1704
		// (Invoke) Token: 0x0600360A RID: 13834
		private delegate float GetGlobalFloatImplDelegate(int name);

		// Token: 0x020006A9 RID: 1705
		// (Invoke) Token: 0x0600360C RID: 13836
		private delegate IntPtr GetGlobalTextureImplDelegate(int name);

		// Token: 0x020006AA RID: 1706
		// (Invoke) Token: 0x0600360E RID: 13838
		private delegate void SetGlobalFloatArrayImplDelegate(int name, IntPtr values, int count);

		// Token: 0x020006AB RID: 1707
		// (Invoke) Token: 0x06003610 RID: 13840
		private delegate IntPtr GetGlobalFloatArrayImplDelegate(int name);

		// Token: 0x020006AC RID: 1708
		// (Invoke) Token: 0x06003612 RID: 13842
		private delegate IntPtr GetGlobalVectorArrayImplDelegate(int name);

		// Token: 0x020006AD RID: 1709
		// (Invoke) Token: 0x06003614 RID: 13844
		private delegate IntPtr GetGlobalMatrixArrayImplDelegate(int name);

		// Token: 0x020006AE RID: 1710
		// (Invoke) Token: 0x06003616 RID: 13846
		private delegate int GetGlobalFloatArrayCountImplDelegate(int name);

		// Token: 0x020006AF RID: 1711
		// (Invoke) Token: 0x06003618 RID: 13848
		private delegate int GetGlobalVectorArrayCountImplDelegate(int name);

		// Token: 0x020006B0 RID: 1712
		// (Invoke) Token: 0x0600361A RID: 13850
		private delegate int GetGlobalMatrixArrayCountImplDelegate(int name);

		// Token: 0x020006B1 RID: 1713
		// (Invoke) Token: 0x0600361C RID: 13852
		private delegate void ExtractGlobalFloatArrayImplDelegate(int name, [Out] IntPtr val);

		// Token: 0x020006B2 RID: 1714
		// (Invoke) Token: 0x0600361E RID: 13854
		private delegate void ExtractGlobalVectorArrayImplDelegate(int name, [Out] IntPtr val);

		// Token: 0x020006B3 RID: 1715
		// (Invoke) Token: 0x06003620 RID: 13856
		private delegate void ExtractGlobalMatrixArrayImplDelegate(int name, [Out] IntPtr val);

		// Token: 0x020006B4 RID: 1716
		// (Invoke) Token: 0x06003622 RID: 13858
		private delegate IntPtr GetPropertyNameDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x020006B5 RID: 1717
		// (Invoke) Token: 0x06003624 RID: 13860
		private delegate int GetPropertyNameIdDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x020006B6 RID: 1718
		// (Invoke) Token: 0x06003626 RID: 13862
		private delegate UnityEngine.Rendering.ShaderPropertyType GetPropertyTypeDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x020006B7 RID: 1719
		// (Invoke) Token: 0x06003628 RID: 13864
		private delegate IntPtr GetPropertyDescriptionDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x020006B8 RID: 1720
		// (Invoke) Token: 0x0600362A RID: 13866
		private delegate UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlagsDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x020006B9 RID: 1721
		// (Invoke) Token: 0x0600362C RID: 13868
		private delegate IntPtr GetPropertyAttributesDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x020006BA RID: 1722
		// (Invoke) Token: 0x0600362E RID: 13870
		private delegate int GetPropertyDefaultIntValueDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x020006BB RID: 1723
		// (Invoke) Token: 0x06003630 RID: 13872
		private delegate UnityEngine.Rendering.TextureDimension GetPropertyTextureDimensionDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x020006BC RID: 1724
		// (Invoke) Token: 0x06003632 RID: 13874
		private delegate IntPtr GetPropertyTextureDefaultNameDelegate(IntPtr shader, int propertyIndex);

		// Token: 0x020006BD RID: 1725
		// (Invoke) Token: 0x06003634 RID: 13876
		private delegate bool FindTextureStackImplDelegate(IntPtr s, int propertyIdx, [Out] IntPtr stackName, [Out] IntPtr layerIndex);

		// Token: 0x020006BE RID: 1726
		// (Invoke) Token: 0x06003636 RID: 13878
		private delegate int GetPropertyCountDelegate(IntPtr @this);

		// Token: 0x020006BF RID: 1727
		// (Invoke) Token: 0x06003638 RID: 13880
		private delegate int FindPropertyIndexDelegate(IntPtr @this, IntPtr propertyName);

		// Token: 0x020006C0 RID: 1728
		// (Invoke) Token: 0x0600363A RID: 13882
		private delegate void SetGlobalMatrixImpl_InjectedDelegate(int name, IntPtr value);

		// Token: 0x020006C1 RID: 1729
		// (Invoke) Token: 0x0600363C RID: 13884
		private delegate void GetGlobalVectorImpl_InjectedDelegate(int name, [Out] IntPtr ret);

		// Token: 0x020006C2 RID: 1730
		// (Invoke) Token: 0x0600363E RID: 13886
		private delegate void GetGlobalMatrixImpl_InjectedDelegate(int name, [Out] IntPtr ret);

		// Token: 0x020006C3 RID: 1731
		// (Invoke) Token: 0x06003640 RID: 13888
		private delegate void GetPropertyDefaultValue_InjectedDelegate(IntPtr shader, int propertyIndex, [Out] IntPtr ret);
	}
}
