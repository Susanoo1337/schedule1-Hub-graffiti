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
	// Token: 0x020000AA RID: 170
	public class Material : Object
	{
		// Token: 0x06000CF2 RID: 3314 RVA: 0x0003D2D0 File Offset: 0x0003B4D0
		// Note: this type is marked as 'beforefieldinit'.
		static Material()
		{
			Il2CppClassPointerStore<Material>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Material");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Material>.NativeClassPtr);
			Material.NativeMethodInfoPtr_CreateWithShader_Private_Static_Void_Material_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664475);
			Material.NativeMethodInfoPtr_CreateWithMaterial_Private_Static_Void_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664476);
			Material.NativeMethodInfoPtr_CreateWithString_Private_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664477);
			Material.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664478);
			Material.NativeMethodInfoPtr__ctor_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664479);
			Material.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664480);
			Material.NativeMethodInfoPtr_get_shader_Public_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664481);
			Material.NativeMethodInfoPtr_set_shader_Public_set_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664482);
			Material.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664483);
			Material.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664484);
			Material.NativeMethodInfoPtr_get_mainTexture_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664485);
			Material.NativeMethodInfoPtr_set_mainTexture_Public_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664486);
			Material.NativeMethodInfoPtr_GetFirstPropertyNameIdByAttribute_Private_Int32_ShaderPropertyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664487);
			Material.NativeMethodInfoPtr_HasProperty_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664488);
			Material.NativeMethodInfoPtr_HasProperty_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664489);
			Material.NativeMethodInfoPtr_get_renderQueue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664490);
			Material.NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664491);
			Material.NativeMethodInfoPtr_get_rawRenderQueue_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664492);
			Material.NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664493);
			Material.NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664494);
			Material.NativeMethodInfoPtr_IsKeywordEnabled_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664495);
			Material.NativeMethodInfoPtr_SetEnabledKeywords_Private_Void_Il2CppReferenceArray_1_LocalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664496);
			Material.NativeMethodInfoPtr_set_enabledKeywords_Public_set_Void_Il2CppReferenceArray_1_LocalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664497);
			Material.NativeMethodInfoPtr_get_enableInstancing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664498);
			Material.NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664499);
			Material.NativeMethodInfoPtr_get_passCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664500);
			Material.NativeMethodInfoPtr_SetShaderPassEnabled_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664501);
			Material.NativeMethodInfoPtr_FindPass_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664502);
			Material.NativeMethodInfoPtr_GetTagImpl_Private_String_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664503);
			Material.NativeMethodInfoPtr_GetTag_Public_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664504);
			Material.NativeMethodInfoPtr_SetPass_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664505);
			Material.NativeMethodInfoPtr_CopyPropertiesFromMaterial_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664506);
			Material.NativeMethodInfoPtr_GetShaderKeywords_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664507);
			Material.NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664508);
			Material.NativeMethodInfoPtr_get_shaderKeywords_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664509);
			Material.NativeMethodInfoPtr_set_shaderKeywords_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664510);
			Material.NativeMethodInfoPtr_ComputeCRC_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664511);
			Material.NativeMethodInfoPtr_SetIntImpl_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664512);
			Material.NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664513);
			Material.NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664514);
			Material.NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664515);
			Material.NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664516);
			Material.NativeMethodInfoPtr_SetBufferImpl_Private_Void_Int32_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664517);
			Material.NativeMethodInfoPtr_SetGraphicsBufferImpl_Private_Void_Int32_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664518);
			Material.NativeMethodInfoPtr_SetConstantBufferImpl_Private_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664519);
			Material.NativeMethodInfoPtr_GetFloatImpl_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664520);
			Material.NativeMethodInfoPtr_GetColorImpl_Private_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664521);
			Material.NativeMethodInfoPtr_GetTextureImpl_Private_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664522);
			Material.NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664523);
			Material.NativeMethodInfoPtr_SetVectorArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664524);
			Material.NativeMethodInfoPtr_SetMatrixArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664525);
			Material.NativeMethodInfoPtr_GetTextureScaleAndOffsetImpl_Private_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664526);
			Material.NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664527);
			Material.NativeMethodInfoPtr_SetVectorArray_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664528);
			Material.NativeMethodInfoPtr_SetMatrixArray_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664529);
			Material.NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664530);
			Material.NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664531);
			Material.NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664532);
			Material.NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664533);
			Material.NativeMethodInfoPtr_SetInteger_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664534);
			Material.NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664535);
			Material.NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664536);
			Material.NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664537);
			Material.NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664538);
			Material.NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664539);
			Material.NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664540);
			Material.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664541);
			Material.NativeMethodInfoPtr_SetBuffer_Public_Void_String_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664542);
			Material.NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664543);
			Material.NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664544);
			Material.NativeMethodInfoPtr_SetFloatArray_Public_Void_Int32_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664545);
			Material.NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664546);
			Material.NativeMethodInfoPtr_SetMatrixArray_Public_Void_Int32_Il2CppStructArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664547);
			Material.NativeMethodInfoPtr_GetInt_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664548);
			Material.NativeMethodInfoPtr_GetInt_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664549);
			Material.NativeMethodInfoPtr_GetFloat_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664550);
			Material.NativeMethodInfoPtr_GetFloat_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664551);
			Material.NativeMethodInfoPtr_GetColor_Public_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664552);
			Material.NativeMethodInfoPtr_GetColor_Public_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664553);
			Material.NativeMethodInfoPtr_GetVector_Public_Vector4_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664554);
			Material.NativeMethodInfoPtr_GetVector_Public_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664555);
			Material.NativeMethodInfoPtr_GetTexture_Public_Texture_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664556);
			Material.NativeMethodInfoPtr_GetTexture_Public_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664557);
			Material.NativeMethodInfoPtr_GetTextureOffset_Public_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664558);
			Material.NativeMethodInfoPtr_GetTextureScale_Public_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664559);
			Material.NativeMethodInfoPtr_SetColorImpl_Injected_Private_Void_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664560);
			Material.NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664561);
			Material.NativeMethodInfoPtr_GetColorImpl_Injected_Private_Void_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664562);
			Material.NativeMethodInfoPtr_GetTextureScaleAndOffsetImpl_Injected_Private_Void_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664563);
			Material.GetDefaultMaterialDelegateField = IL2CPP.ResolveICall<Material.GetDefaultMaterialDelegate>("UnityEngine.Material::GetDefaultMaterial");
			Material.GetDefaultParticleMaterialDelegateField = IL2CPP.ResolveICall<Material.GetDefaultParticleMaterialDelegate>("UnityEngine.Material::GetDefaultParticleMaterial");
			Material.GetDefaultLineMaterialDelegateField = IL2CPP.ResolveICall<Material.GetDefaultLineMaterialDelegate>("UnityEngine.Material::GetDefaultLineMaterial");
			Material.HasFloatImplDelegateField = IL2CPP.ResolveICall<Material.HasFloatImplDelegate>("UnityEngine.Material::HasFloatImpl");
			Material.HasIntImplDelegateField = IL2CPP.ResolveICall<Material.HasIntImplDelegate>("UnityEngine.Material::HasIntImpl");
			Material.HasTextureImplDelegateField = IL2CPP.ResolveICall<Material.HasTextureImplDelegate>("UnityEngine.Material::HasTextureImpl");
			Material.HasMatrixImplDelegateField = IL2CPP.ResolveICall<Material.HasMatrixImplDelegate>("UnityEngine.Material::HasMatrixImpl");
			Material.HasVectorImplDelegateField = IL2CPP.ResolveICall<Material.HasVectorImplDelegate>("UnityEngine.Material::HasVectorImpl");
			Material.HasBufferImplDelegateField = IL2CPP.ResolveICall<Material.HasBufferImplDelegate>("UnityEngine.Material::HasBufferImpl");
			Material.HasConstantBufferImplDelegateField = IL2CPP.ResolveICall<Material.HasConstantBufferImplDelegate>("UnityEngine.Material::HasConstantBufferImpl");
			Material.GetEnabledKeywordsDelegateField = IL2CPP.ResolveICall<Material.GetEnabledKeywordsDelegate>("UnityEngine.Material::GetEnabledKeywords");
			Material.get_globalIlluminationFlagsDelegateField = IL2CPP.ResolveICall<Material.get_globalIlluminationFlagsDelegate>("UnityEngine.Material::get_globalIlluminationFlags");
			Material.set_globalIlluminationFlagsDelegateField = IL2CPP.ResolveICall<Material.set_globalIlluminationFlagsDelegate>("UnityEngine.Material::set_globalIlluminationFlags");
			Material.get_doubleSidedGIDelegateField = IL2CPP.ResolveICall<Material.get_doubleSidedGIDelegate>("UnityEngine.Material::get_doubleSidedGI");
			Material.set_doubleSidedGIDelegateField = IL2CPP.ResolveICall<Material.set_doubleSidedGIDelegate>("UnityEngine.Material::set_doubleSidedGI");
			Material.GetShaderPassEnabledDelegateField = IL2CPP.ResolveICall<Material.GetShaderPassEnabledDelegate>("UnityEngine.Material::GetShaderPassEnabled");
			Material.GetPassNameDelegateField = IL2CPP.ResolveICall<Material.GetPassNameDelegate>("UnityEngine.Material::GetPassName");
			Material.SetOverrideTagDelegateField = IL2CPP.ResolveICall<Material.SetOverrideTagDelegate>("UnityEngine.Material::SetOverrideTag");
			Material.LerpDelegateField = IL2CPP.ResolveICall<Material.LerpDelegate>("UnityEngine.Material::Lerp");
			Material.CopyMatchingPropertiesFromMaterialDelegateField = IL2CPP.ResolveICall<Material.CopyMatchingPropertiesFromMaterialDelegate>("UnityEngine.Material::CopyMatchingPropertiesFromMaterial");
			Material.GetPropertyNamesImplDelegateField = IL2CPP.ResolveICall<Material.GetPropertyNamesImplDelegate>("UnityEngine.Material::GetPropertyNamesImpl");
			Material.GetTexturePropertyNamesDelegateField = IL2CPP.ResolveICall<Material.GetTexturePropertyNamesDelegate>("UnityEngine.Material::GetTexturePropertyNames");
			Material.GetTexturePropertyNameIDsDelegateField = IL2CPP.ResolveICall<Material.GetTexturePropertyNameIDsDelegate>("UnityEngine.Material::GetTexturePropertyNameIDs");
			Material.GetTexturePropertyNamesInternalDelegateField = IL2CPP.ResolveICall<Material.GetTexturePropertyNamesInternalDelegate>("UnityEngine.Material::GetTexturePropertyNamesInternal");
			Material.GetTexturePropertyNameIDsInternalDelegateField = IL2CPP.ResolveICall<Material.GetTexturePropertyNameIDsInternalDelegate>("UnityEngine.Material::GetTexturePropertyNameIDsInternal");
			Material.SetRenderTextureImplDelegateField = IL2CPP.ResolveICall<Material.SetRenderTextureImplDelegate>("UnityEngine.Material::SetRenderTextureImpl");
			Material.SetConstantGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<Material.SetConstantGraphicsBufferImplDelegate>("UnityEngine.Material::SetConstantGraphicsBufferImpl");
			Material.GetIntImplDelegateField = IL2CPP.ResolveICall<Material.GetIntImplDelegate>("UnityEngine.Material::GetIntImpl");
			Material.SetColorArrayImplDelegateField = IL2CPP.ResolveICall<Material.SetColorArrayImplDelegate>("UnityEngine.Material::SetColorArrayImpl");
			Material.GetFloatArrayImplDelegateField = IL2CPP.ResolveICall<Material.GetFloatArrayImplDelegate>("UnityEngine.Material::GetFloatArrayImpl");
			Material.GetVectorArrayImplDelegateField = IL2CPP.ResolveICall<Material.GetVectorArrayImplDelegate>("UnityEngine.Material::GetVectorArrayImpl");
			Material.GetColorArrayImplDelegateField = IL2CPP.ResolveICall<Material.GetColorArrayImplDelegate>("UnityEngine.Material::GetColorArrayImpl");
			Material.GetMatrixArrayImplDelegateField = IL2CPP.ResolveICall<Material.GetMatrixArrayImplDelegate>("UnityEngine.Material::GetMatrixArrayImpl");
			Material.GetFloatArrayCountImplDelegateField = IL2CPP.ResolveICall<Material.GetFloatArrayCountImplDelegate>("UnityEngine.Material::GetFloatArrayCountImpl");
			Material.GetVectorArrayCountImplDelegateField = IL2CPP.ResolveICall<Material.GetVectorArrayCountImplDelegate>("UnityEngine.Material::GetVectorArrayCountImpl");
			Material.GetColorArrayCountImplDelegateField = IL2CPP.ResolveICall<Material.GetColorArrayCountImplDelegate>("UnityEngine.Material::GetColorArrayCountImpl");
			Material.GetMatrixArrayCountImplDelegateField = IL2CPP.ResolveICall<Material.GetMatrixArrayCountImplDelegate>("UnityEngine.Material::GetMatrixArrayCountImpl");
			Material.ExtractFloatArrayImplDelegateField = IL2CPP.ResolveICall<Material.ExtractFloatArrayImplDelegate>("UnityEngine.Material::ExtractFloatArrayImpl");
			Material.ExtractVectorArrayImplDelegateField = IL2CPP.ResolveICall<Material.ExtractVectorArrayImplDelegate>("UnityEngine.Material::ExtractVectorArrayImpl");
			Material.ExtractColorArrayImplDelegateField = IL2CPP.ResolveICall<Material.ExtractColorArrayImplDelegate>("UnityEngine.Material::ExtractColorArrayImpl");
			Material.ExtractMatrixArrayImplDelegateField = IL2CPP.ResolveICall<Material.ExtractMatrixArrayImplDelegate>("UnityEngine.Material::ExtractMatrixArrayImpl");
			Material.EnableLocalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<Material.EnableLocalKeyword_InjectedDelegate>("UnityEngine.Material::EnableLocalKeyword_Injected");
			Material.DisableLocalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<Material.DisableLocalKeyword_InjectedDelegate>("UnityEngine.Material::DisableLocalKeyword_Injected");
			Material.SetLocalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<Material.SetLocalKeyword_InjectedDelegate>("UnityEngine.Material::SetLocalKeyword_Injected");
			Material.IsLocalKeywordEnabled_InjectedDelegateField = IL2CPP.ResolveICall<Material.IsLocalKeywordEnabled_InjectedDelegate>("UnityEngine.Material::IsLocalKeywordEnabled_Injected");
			Material.GetMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<Material.GetMatrixImpl_InjectedDelegate>("UnityEngine.Material::GetMatrixImpl_Injected");
			Material.SetTextureOffsetImpl_InjectedDelegateField = IL2CPP.ResolveICall<Material.SetTextureOffsetImpl_InjectedDelegate>("UnityEngine.Material::SetTextureOffsetImpl_Injected");
			Material.SetTextureScaleImpl_InjectedDelegateField = IL2CPP.ResolveICall<Material.SetTextureScaleImpl_InjectedDelegate>("UnityEngine.Material::SetTextureScaleImpl_Injected");
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0003DCC4 File Offset: 0x0003BEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236171, XrefRangeEnd = 1236173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateWithShader(Material self, Shader shader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_CreateWithShader_Private_Static_Void_Material_Shader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0003DD0C File Offset: 0x0003BF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236173, XrefRangeEnd = 1236175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateWithMaterial(Material self, Material source)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_CreateWithMaterial_Private_Static_Void_Material_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0003DD54 File Offset: 0x0003BF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236175, XrefRangeEnd = 1236177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateWithString(Material self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_CreateWithString_Private_Static_Void_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0003DD8C File Offset: 0x0003BF8C
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 1236183, RefRangeEnd = 1236218, XrefRangeStart = 1236177, XrefRangeEnd = 1236183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material(Shader shader) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Material>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0003DDD8 File Offset: 0x0003BFD8
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 1236224, RefRangeEnd = 1236254, XrefRangeStart = 1236218, XrefRangeEnd = 1236224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material(Material source) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Material>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr__ctor_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0003DE24 File Offset: 0x0003C024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236254, XrefRangeEnd = 1236260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material(string contents) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Material>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x0003DE70 File Offset: 0x0003C070
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x0003DEB0 File Offset: 0x0003C0B0
		public unsafe Shader shader
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 1236262, RefRangeEnd = 1236285, XrefRangeStart = 1236260, XrefRangeEnd = 1236262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_shader_Public_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1236297, RefRangeEnd = 1236300, XrefRangeStart = 1236285, XrefRangeEnd = 1236297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_shader_Public_set_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x0003DEF4 File Offset: 0x0003C0F4
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x0003DF30 File Offset: 0x0003C130
		public unsafe Color color
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1236309, RefRangeEnd = 1236313, XrefRangeStart = 1236300, XrefRangeEnd = 1236309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 1236321, RefRangeEnd = 1236359, XrefRangeStart = 1236313, XrefRangeEnd = 1236321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0003DF70 File Offset: 0x0003C170
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x0003DFB0 File Offset: 0x0003C1B0
		public unsafe Texture mainTexture
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1236367, RefRangeEnd = 1236374, XrefRangeStart = 1236359, XrefRangeEnd = 1236367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_mainTexture_Public_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1236382, RefRangeEnd = 1236384, XrefRangeStart = 1236374, XrefRangeEnd = 1236382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_mainTexture_Public_set_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0003DFF4 File Offset: 0x0003C1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236384, XrefRangeEnd = 1236386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags attributeFlag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref attributeFlag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetFirstPropertyNameIdByAttribute_Private_Int32_ShaderPropertyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x0003E040 File Offset: 0x0003C240
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 1236388, RefRangeEnd = 1236451, XrefRangeStart = 1236386, XrefRangeEnd = 1236388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasProperty(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_HasProperty_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x0003E08C File Offset: 0x0003C28C
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 1236455, RefRangeEnd = 1236563, XrefRangeStart = 1236451, XrefRangeEnd = 1236455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasProperty(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_HasProperty_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x0003E0DC File Offset: 0x0003C2DC
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x0003E118 File Offset: 0x0003C318
		public unsafe int renderQueue
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1236565, RefRangeEnd = 1236567, XrefRangeStart = 1236563, XrefRangeEnd = 1236565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_renderQueue_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1236569, RefRangeEnd = 1236577, XrefRangeStart = 1236567, XrefRangeEnd = 1236569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x0003E158 File Offset: 0x0003C358
		public unsafe int rawRenderQueue
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1236579, RefRangeEnd = 1236581, XrefRangeStart = 1236577, XrefRangeEnd = 1236579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_rawRenderQueue_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0003E194 File Offset: 0x0003C394
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 1236583, RefRangeEnd = 1236626, XrefRangeStart = 1236581, XrefRangeEnd = 1236583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableKeyword(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0003E1D8 File Offset: 0x0003C3D8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1236628, RefRangeEnd = 1236648, XrefRangeStart = 1236626, XrefRangeEnd = 1236628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableKeyword(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0003E21C File Offset: 0x0003C41C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1236650, RefRangeEnd = 1236659, XrefRangeStart = 1236648, XrefRangeEnd = 1236650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsKeywordEnabled(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_IsKeywordEnabled_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0003E26C File Offset: 0x0003C46C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1236661, RefRangeEnd = 1236665, XrefRangeStart = 1236659, XrefRangeEnd = 1236661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnabledKeywords(Il2CppReferenceArray<UnityEngine.Rendering.LocalKeyword> keywords)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(keywords);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetEnabledKeywords_Private_Void_Il2CppReferenceArray_1_LocalKeyword_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x0003FB54 File Offset: 0x0003DD54
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x0003E2B0 File Offset: 0x0003C4B0
		public unsafe Il2CppReferenceArray<UnityEngine.Rendering.LocalKeyword> enabledKeywords
		{
			get
			{
				return this.GetEnabledKeywords();
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1236661, RefRangeEnd = 1236665, XrefRangeStart = 1236661, XrefRangeEnd = 1236665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_enabledKeywords_Public_set_Void_Il2CppReferenceArray_1_LocalKeyword_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x0003E2F4 File Offset: 0x0003C4F4
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x0003E330 File Offset: 0x0003C530
		public unsafe bool enableInstancing
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1236667, RefRangeEnd = 1236672, XrefRangeStart = 1236665, XrefRangeEnd = 1236667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_enableInstancing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1236674, RefRangeEnd = 1236680, XrefRangeStart = 1236672, XrefRangeEnd = 1236674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x0003E370 File Offset: 0x0003C570
		public unsafe int passCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1236682, RefRangeEnd = 1236685, XrefRangeStart = 1236680, XrefRangeEnd = 1236682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_passCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0003E3AC File Offset: 0x0003C5AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1236687, RefRangeEnd = 1236692, XrefRangeStart = 1236685, XrefRangeEnd = 1236687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShaderPassEnabled(string passName, bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(passName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetShaderPassEnabled_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x0003E3FC File Offset: 0x0003C5FC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1236694, RefRangeEnd = 1236709, XrefRangeStart = 1236692, XrefRangeEnd = 1236694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindPass(string passName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(passName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_FindPass_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x0003E44C File Offset: 0x0003C64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236709, XrefRangeEnd = 1236711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentSubShaderOnly;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTagImpl_Private_String_String_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0003E4B4 File Offset: 0x0003C6B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1236715, RefRangeEnd = 1236718, XrefRangeStart = 1236711, XrefRangeEnd = 1236715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTag(string tag, bool searchFallbacks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchFallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTag_Public_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x0003E50C File Offset: 0x0003C70C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1236720, RefRangeEnd = 1236729, XrefRangeStart = 1236718, XrefRangeEnd = 1236720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetPass(int pass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetPass_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x0003E558 File Offset: 0x0003C758
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1236731, RefRangeEnd = 1236734, XrefRangeStart = 1236729, XrefRangeEnd = 1236731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyPropertiesFromMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_CopyPropertiesFromMaterial_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x0003E59C File Offset: 0x0003C79C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1236736, RefRangeEnd = 1236754, XrefRangeStart = 1236734, XrefRangeEnd = 1236736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetShaderKeywords()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetShaderKeywords_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x0003E5DC File Offset: 0x0003C7DC
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1236756, RefRangeEnd = 1236780, XrefRangeStart = 1236754, XrefRangeEnd = 1236756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShaderKeywords(Il2CppStringArray names)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(names);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x0003E620 File Offset: 0x0003C820
		// (set) Token: 0x06000D16 RID: 3350 RVA: 0x0003E660 File Offset: 0x0003C860
		public unsafe Il2CppStringArray shaderKeywords
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 1236736, RefRangeEnd = 1236754, XrefRangeStart = 1236736, XrefRangeEnd = 1236754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_get_shaderKeywords_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 1236756, RefRangeEnd = 1236780, XrefRangeStart = 1236756, XrefRangeEnd = 1236780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_set_shaderKeywords_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0003E6A4 File Offset: 0x0003C8A4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1236782, RefRangeEnd = 1236788, XrefRangeStart = 1236780, XrefRangeEnd = 1236782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ComputeCRC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_ComputeCRC_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x0003E6E0 File Offset: 0x0003C8E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1236790, RefRangeEnd = 1236793, XrefRangeStart = 1236788, XrefRangeEnd = 1236790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIntImpl(int name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetIntImpl_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x0003E72C File Offset: 0x0003C92C
		[CallerCount(152)]
		[CachedScanResults(RefRangeStart = 1236795, RefRangeEnd = 1236947, XrefRangeStart = 1236793, XrefRangeEnd = 1236795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatImpl(int name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x0003E778 File Offset: 0x0003C978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236947, XrefRangeEnd = 1236949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColorImpl(int name, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x0003E7C4 File Offset: 0x0003C9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236949, XrefRangeEnd = 1236951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixImpl(int name, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0003E810 File Offset: 0x0003CA10
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 1236953, RefRangeEnd = 1237016, XrefRangeStart = 1236951, XrefRangeEnd = 1236953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextureImpl(int name, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x0003E860 File Offset: 0x0003CA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237016, XrefRangeEnd = 1237018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBufferImpl(int name, ComputeBuffer value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetBufferImpl_Private_Void_Int32_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x0003E8B0 File Offset: 0x0003CAB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1237020, RefRangeEnd = 1237022, XrefRangeStart = 1237018, XrefRangeEnd = 1237020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGraphicsBufferImpl(int name, GraphicsBuffer value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetGraphicsBufferImpl_Private_Void_Int32_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x0003E900 File Offset: 0x0003CB00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237024, RefRangeEnd = 1237025, XrefRangeStart = 1237022, XrefRangeEnd = 1237024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetConstantBufferImpl_Private_Void_Int32_ComputeBuffer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x0003E96C File Offset: 0x0003CB6C
		[CallerCount(102)]
		[CachedScanResults(RefRangeStart = 1237027, RefRangeEnd = 1237129, XrefRangeStart = 1237025, XrefRangeEnd = 1237027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetFloatImpl(int name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetFloatImpl_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0003E9B8 File Offset: 0x0003CBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237129, XrefRangeEnd = 1237131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetColorImpl(int name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetColorImpl_Private_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0003EA04 File Offset: 0x0003CC04
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1237133, RefRangeEnd = 1237159, XrefRangeStart = 1237131, XrefRangeEnd = 1237133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture GetTextureImpl(int name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTextureImpl_Private_Texture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0003EA50 File Offset: 0x0003CC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237159, XrefRangeEnd = 1237161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatArrayImpl(int name, Il2CppStructArray<float> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x0003EAB0 File Offset: 0x0003CCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237161, XrefRangeEnd = 1237163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorArrayImpl(int name, Il2CppStructArray<Vector4> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetVectorArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x0003EB10 File Offset: 0x0003CD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237163, XrefRangeEnd = 1237165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixArrayImpl(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetMatrixArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x0003EB70 File Offset: 0x0003CD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237165, XrefRangeEnd = 1237167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetTextureScaleAndOffsetImpl(int name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTextureScaleAndOffsetImpl_Private_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x0003EBBC File Offset: 0x0003CDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237167, XrefRangeEnd = 1237187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatArray(int name, Il2CppStructArray<float> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0003EC1C File Offset: 0x0003CE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237187, XrefRangeEnd = 1237207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorArray(int name, Il2CppStructArray<Vector4> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetVectorArray_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0003EC7C File Offset: 0x0003CE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237207, XrefRangeEnd = 1237227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixArray(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetMatrixArray_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x0003ECDC File Offset: 0x0003CEDC
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1237231, RefRangeEnd = 1237249, XrefRangeStart = 1237227, XrefRangeEnd = 1237231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInt(string name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x0003ED2C File Offset: 0x0003CF2C
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 1237251, RefRangeEnd = 1237282, XrefRangeStart = 1237249, XrefRangeEnd = 1237251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInt(int nameID, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x0003ED78 File Offset: 0x0003CF78
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 1237286, RefRangeEnd = 1237343, XrefRangeStart = 1237282, XrefRangeEnd = 1237286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloat(string name, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x0003EDC8 File Offset: 0x0003CFC8
		[CallerCount(152)]
		[CachedScanResults(RefRangeStart = 1236795, RefRangeEnd = 1236947, XrefRangeStart = 1236795, XrefRangeEnd = 1236947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloat(int nameID, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x0003EE14 File Offset: 0x0003D014
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1236790, RefRangeEnd = 1236793, XrefRangeStart = 1236790, XrefRangeEnd = 1236793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteger(int nameID, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetInteger_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x0003EE60 File Offset: 0x0003D060
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 1237347, RefRangeEnd = 1237379, XrefRangeStart = 1237343, XrefRangeEnd = 1237347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(string name, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0003EEB0 File Offset: 0x0003D0B0
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1237381, RefRangeEnd = 1237417, XrefRangeStart = 1237379, XrefRangeEnd = 1237381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(int nameID, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x0003EEFC File Offset: 0x0003D0FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237421, RefRangeEnd = 1237422, XrefRangeStart = 1237417, XrefRangeEnd = 1237421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVector(string name, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x0003EF4C File Offset: 0x0003D14C
		[CallerCount(121)]
		[CachedScanResults(RefRangeStart = 1237424, RefRangeEnd = 1237545, XrefRangeStart = 1237422, XrefRangeEnd = 1237424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVector(int nameID, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x0003EF98 File Offset: 0x0003D198
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1237547, RefRangeEnd = 1237551, XrefRangeStart = 1237545, XrefRangeEnd = 1237547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrix(int nameID, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x0003EFE4 File Offset: 0x0003D1E4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1237555, RefRangeEnd = 1237572, XrefRangeStart = 1237551, XrefRangeEnd = 1237555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(string name, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0003F038 File Offset: 0x0003D238
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 1236953, RefRangeEnd = 1237016, XrefRangeStart = 1236953, XrefRangeEnd = 1237016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(int nameID, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x0003F088 File Offset: 0x0003D288
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1237576, RefRangeEnd = 1237578, XrefRangeStart = 1237572, XrefRangeEnd = 1237576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBuffer(string name, ComputeBuffer value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetBuffer_Public_Void_String_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0003F0DC File Offset: 0x0003D2DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1237020, RefRangeEnd = 1237022, XrefRangeStart = 1237020, XrefRangeEnd = 1237022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBuffer(int nameID, GraphicsBuffer value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0003F12C File Offset: 0x0003D32C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237024, RefRangeEnd = 1237025, XrefRangeStart = 1237024, XrefRangeEnd = 1237025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0003F198 File Offset: 0x0003D398
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1237587, RefRangeEnd = 1237589, XrefRangeStart = 1237578, XrefRangeEnd = 1237587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetFloatArray_Public_Void_Int32_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0003F1E8 File Offset: 0x0003D3E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1237598, RefRangeEnd = 1237602, XrefRangeStart = 1237589, XrefRangeEnd = 1237598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x0003F238 File Offset: 0x0003D438
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1237611, RefRangeEnd = 1237614, XrefRangeStart = 1237602, XrefRangeEnd = 1237611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetMatrixArray_Public_Void_Int32_Il2CppStructArray_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x0003F288 File Offset: 0x0003D488
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1237618, RefRangeEnd = 1237624, XrefRangeStart = 1237614, XrefRangeEnd = 1237618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInt(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetInt_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x0003F2D8 File Offset: 0x0003D4D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1237626, RefRangeEnd = 1237629, XrefRangeStart = 1237624, XrefRangeEnd = 1237626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInt(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetInt_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x0003F324 File Offset: 0x0003D524
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 1237633, RefRangeEnd = 1237691, XrefRangeStart = 1237629, XrefRangeEnd = 1237633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetFloat(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetFloat_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x0003F374 File Offset: 0x0003D574
		[CallerCount(102)]
		[CachedScanResults(RefRangeStart = 1237027, RefRangeEnd = 1237129, XrefRangeStart = 1237027, XrefRangeEnd = 1237129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetFloat(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetFloat_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x0003F3C0 File Offset: 0x0003D5C0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1237695, RefRangeEnd = 1237710, XrefRangeStart = 1237691, XrefRangeEnd = 1237695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetColor(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetColor_Public_Color_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x0003F410 File Offset: 0x0003D610
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1237712, RefRangeEnd = 1237727, XrefRangeStart = 1237710, XrefRangeEnd = 1237712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetColor(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetColor_Public_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x0003F45C File Offset: 0x0003D65C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1237695, RefRangeEnd = 1237710, XrefRangeStart = 1237695, XrefRangeEnd = 1237710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetVector(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetVector_Public_Vector4_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x0003F4AC File Offset: 0x0003D6AC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1237712, RefRangeEnd = 1237727, XrefRangeStart = 1237712, XrefRangeEnd = 1237727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetVector(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetVector_Public_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x0003F4F8 File Offset: 0x0003D6F8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1237731, RefRangeEnd = 1237745, XrefRangeStart = 1237727, XrefRangeEnd = 1237731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture GetTexture(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTexture_Public_Texture_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x0003F548 File Offset: 0x0003D748
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1237133, RefRangeEnd = 1237159, XrefRangeStart = 1237133, XrefRangeEnd = 1237159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture GetTexture(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTexture_Public_Texture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x0003F594 File Offset: 0x0003D794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237747, RefRangeEnd = 1237748, XrefRangeStart = 1237745, XrefRangeEnd = 1237747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetTextureOffset(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTextureOffset_Public_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x0003F5E0 File Offset: 0x0003D7E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237750, RefRangeEnd = 1237751, XrefRangeStart = 1237748, XrefRangeEnd = 1237750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetTextureScale(int nameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTextureScale_Public_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x0003F62C File Offset: 0x0003D82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237751, XrefRangeEnd = 1237753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColorImpl_Injected(int name, ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetColorImpl_Injected_Private_Void_Int32_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0003F678 File Offset: 0x0003D878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237753, XrefRangeEnd = 1237755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMatrixImpl_Injected(int name, ref Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0003F6C4 File Offset: 0x0003D8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237755, XrefRangeEnd = 1237757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetColorImpl_Injected(int name, out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetColorImpl_Injected_Private_Void_Int32_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x0003F710 File Offset: 0x0003D910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237757, XrefRangeEnd = 1237759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTextureScaleAndOffsetImpl_Injected(int name, out Vector4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Material.NativeMethodInfoPtr_GetTextureScaleAndOffsetImpl_Injected_Private_Void_Int32_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x0000803B File Offset: 0x0000623B
		public Material(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x0003F75C File Offset: 0x0003D95C
		public static Material Create(string scriptContents)
		{
			return new Material(scriptContents);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x0003F774 File Offset: 0x0003D974
		public static Material GetDefaultMaterial()
		{
			IntPtr intPtr = Material.GetDefaultMaterialDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0003F79C File Offset: 0x0003D99C
		public static Material GetDefaultParticleMaterial()
		{
			IntPtr intPtr = Material.GetDefaultParticleMaterialDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0003F7C4 File Offset: 0x0003D9C4
		public static Material GetDefaultLineMaterial()
		{
			IntPtr intPtr = Material.GetDefaultLineMaterialDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x0003F7EC File Offset: 0x0003D9EC
		// (set) Token: 0x06000D52 RID: 3410 RVA: 0x0003F82C File Offset: 0x0003DA2C
		public Vector2 mainTextureOffset
		{
			get
			{
				int firstPropertyNameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags.MainTexture);
				bool flag = firstPropertyNameIdByAttribute >= 0;
				Vector2 textureOffset;
				if (flag)
				{
					textureOffset = this.GetTextureOffset(firstPropertyNameIdByAttribute);
				}
				else
				{
					textureOffset = this.GetTextureOffset("_MainTex");
				}
				return textureOffset;
			}
			set
			{
				int firstPropertyNameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags.MainTexture);
				bool flag = firstPropertyNameIdByAttribute >= 0;
				if (flag)
				{
					this.SetTextureOffset(firstPropertyNameIdByAttribute, value);
				}
				else
				{
					this.SetTextureOffset("_MainTex", value);
				}
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x0003F86C File Offset: 0x0003DA6C
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x0003F8AC File Offset: 0x0003DAAC
		public Vector2 mainTextureScale
		{
			get
			{
				int firstPropertyNameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags.MainTexture);
				bool flag = firstPropertyNameIdByAttribute >= 0;
				Vector2 textureScale;
				if (flag)
				{
					textureScale = this.GetTextureScale(firstPropertyNameIdByAttribute);
				}
				else
				{
					textureScale = this.GetTextureScale("_MainTex");
				}
				return textureScale;
			}
			set
			{
				int firstPropertyNameIdByAttribute = this.GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags.MainTexture);
				bool flag = firstPropertyNameIdByAttribute >= 0;
				if (flag)
				{
					this.SetTextureScale(firstPropertyNameIdByAttribute, value);
				}
				else
				{
					this.SetTextureScale("_MainTex", value);
				}
			}
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00008044 File Offset: 0x00006244
		public bool HasFloatImpl(int name)
		{
			return Material.HasFloatImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0003F8EC File Offset: 0x0003DAEC
		public bool HasFloat(string name)
		{
			return this.HasFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0003F90C File Offset: 0x0003DB0C
		public bool HasFloat(int nameID)
		{
			return this.HasFloatImpl(nameID);
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0003F928 File Offset: 0x0003DB28
		public bool HasInt(string name)
		{
			return this.HasFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0003F948 File Offset: 0x0003DB48
		public bool HasInt(int nameID)
		{
			return this.HasFloatImpl(nameID);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00008057 File Offset: 0x00006257
		public bool HasIntImpl(int name)
		{
			return Material.HasIntImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0003F964 File Offset: 0x0003DB64
		public bool HasInteger(string name)
		{
			return this.HasIntImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0003F984 File Offset: 0x0003DB84
		public bool HasInteger(int nameID)
		{
			return this.HasIntImpl(nameID);
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x0000806A File Offset: 0x0000626A
		public bool HasTextureImpl(int name)
		{
			return Material.HasTextureImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0003F9A0 File Offset: 0x0003DBA0
		public bool HasTexture(string name)
		{
			return this.HasTextureImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x0003F9C0 File Offset: 0x0003DBC0
		public bool HasTexture(int nameID)
		{
			return this.HasTextureImpl(nameID);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0000807D File Offset: 0x0000627D
		public bool HasMatrixImpl(int name)
		{
			return Material.HasMatrixImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0003F9DC File Offset: 0x0003DBDC
		public bool HasMatrix(string name)
		{
			return this.HasMatrixImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0003F9FC File Offset: 0x0003DBFC
		public bool HasMatrix(int nameID)
		{
			return this.HasMatrixImpl(nameID);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00008090 File Offset: 0x00006290
		public bool HasVectorImpl(int name)
		{
			return Material.HasVectorImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0003FA18 File Offset: 0x0003DC18
		public bool HasVector(string name)
		{
			return this.HasVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0003FA38 File Offset: 0x0003DC38
		public bool HasVector(int nameID)
		{
			return this.HasVectorImpl(nameID);
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0003FA54 File Offset: 0x0003DC54
		public bool HasColor(string name)
		{
			return this.HasVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0003FA74 File Offset: 0x0003DC74
		public bool HasColor(int nameID)
		{
			return this.HasVectorImpl(nameID);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x000080A3 File Offset: 0x000062A3
		public bool HasBufferImpl(int name)
		{
			return Material.HasBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0003FA90 File Offset: 0x0003DC90
		public bool HasBuffer(string name)
		{
			return this.HasBufferImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0003FAB0 File Offset: 0x0003DCB0
		public bool HasBuffer(int nameID)
		{
			return this.HasBufferImpl(nameID);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x000080B6 File Offset: 0x000062B6
		public bool HasConstantBufferImpl(int name)
		{
			return Material.HasConstantBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x0003FACC File Offset: 0x0003DCCC
		public bool HasConstantBuffer(string name)
		{
			return this.HasConstantBufferImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x0003FAEC File Offset: 0x0003DCEC
		public bool HasConstantBuffer(int nameID)
		{
			return this.HasConstantBufferImpl(nameID);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x000080C9 File Offset: 0x000062C9
		public void EnableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword)
		{
			this.EnableLocalKeyword_Injected(ref keyword);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x000080D3 File Offset: 0x000062D3
		public void DisableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword)
		{
			this.DisableLocalKeyword_Injected(ref keyword);
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x000080DD File Offset: 0x000062DD
		public void SetLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword, bool value)
		{
			this.SetLocalKeyword_Injected(ref keyword, value);
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x000080E8 File Offset: 0x000062E8
		public bool IsLocalKeywordEnabled(UnityEngine.Rendering.LocalKeyword keyword)
		{
			return this.IsLocalKeywordEnabled_Injected(ref keyword);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x000080F2 File Offset: 0x000062F2
		public void EnableKeyword([In] ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			this.EnableLocalKeyword(keyword);
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00008102 File Offset: 0x00006302
		public void DisableKeyword([In] ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			this.DisableLocalKeyword(keyword);
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00008112 File Offset: 0x00006312
		public void SetKeyword([In] ref UnityEngine.Rendering.LocalKeyword keyword, bool value)
		{
			this.SetLocalKeyword(keyword, value);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0003FB08 File Offset: 0x0003DD08
		public bool IsKeywordEnabled([In] ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			return this.IsLocalKeywordEnabled(keyword);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0003FB28 File Offset: 0x0003DD28
		public Il2CppReferenceArray<UnityEngine.Rendering.LocalKeyword> GetEnabledKeywords()
		{
			IntPtr intPtr = Material.GetEnabledKeywordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.Rendering.LocalKeyword>>(intPtr2) : null;
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x00008123 File Offset: 0x00006323
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x00008135 File Offset: 0x00006335
		public MaterialGlobalIlluminationFlags globalIlluminationFlags
		{
			get
			{
				return Material.get_globalIlluminationFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Material.set_globalIlluminationFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x00008148 File Offset: 0x00006348
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x0000815A File Offset: 0x0000635A
		public bool doubleSidedGI
		{
			get
			{
				return Material.get_doubleSidedGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Material.set_doubleSidedGIDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0000816D File Offset: 0x0000636D
		public bool GetShaderPassEnabled(string passName)
		{
			return Material.GetShaderPassEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(passName));
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0003FB6C File Offset: 0x0003DD6C
		public string GetPassName(int pass)
		{
			IntPtr intPtr = Material.GetPassNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), pass);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00008185 File Offset: 0x00006385
		public void SetOverrideTag(string tag, string val)
		{
			Material.SetOverrideTagDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(tag), IL2CPP.ManagedStringToIl2Cpp(val));
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x0003FB94 File Offset: 0x0003DD94
		public string GetTag(string tag, bool searchFallbacks, string defaultValue)
		{
			return this.GetTagImpl(tag, !searchFallbacks, defaultValue);
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x000081A3 File Offset: 0x000063A3
		public void Lerp(Material start, Material end, float t)
		{
			Material.LerpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(start), IL2CPP.Il2CppObjectBaseToPtr(end), t);
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x000081C2 File Offset: 0x000063C2
		public void CopyMatchingPropertiesFromMaterial(Material mat)
		{
			Material.CopyMatchingPropertiesFromMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mat));
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0003FBB4 File Offset: 0x0003DDB4
		public Il2CppStringArray GetPropertyNamesImpl(int propertyType)
		{
			IntPtr intPtr = Material.GetPropertyNamesImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), propertyType);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0003FBE4 File Offset: 0x0003DDE4
		public Il2CppStringArray GetTexturePropertyNames()
		{
			IntPtr intPtr = Material.GetTexturePropertyNamesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0003FC10 File Offset: 0x0003DE10
		public Il2CppStructArray<int> GetTexturePropertyNameIDs()
		{
			IntPtr intPtr = Material.GetTexturePropertyNameIDsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x000081DA File Offset: 0x000063DA
		public void GetTexturePropertyNamesInternal(Object outNames)
		{
			Material.GetTexturePropertyNamesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(outNames));
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x000081F2 File Offset: 0x000063F2
		public void GetTexturePropertyNameIDsInternal(Object outNames)
		{
			Material.GetTexturePropertyNameIDsInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(outNames));
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0003FC3C File Offset: 0x0003DE3C
		public void GetTexturePropertyNames(List<string> outNames)
		{
			bool flag = outNames == null;
			if (flag)
			{
				throw new ArgumentNullException("outNames");
			}
			this.GetTexturePropertyNamesInternal(outNames);
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0003FC68 File Offset: 0x0003DE68
		public void GetTexturePropertyNameIDs(List<int> outNames)
		{
			bool flag = outNames == null;
			if (flag)
			{
				throw new ArgumentNullException("outNames");
			}
			this.GetTexturePropertyNameIDsInternal(outNames);
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0000820A File Offset: 0x0000640A
		public void SetRenderTextureImpl(int name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			Material.SetRenderTextureImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), element);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00008224 File Offset: 0x00006424
		public void SetConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size)
		{
			Material.SetConstantGraphicsBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00008240 File Offset: 0x00006440
		public int GetIntImpl(int name)
		{
			return Material.GetIntImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0003FC94 File Offset: 0x0003DE94
		public Matrix4x4 GetMatrixImpl(int name)
		{
			Matrix4x4 result;
			this.GetMatrixImpl_Injected(name, out result);
			return result;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00008253 File Offset: 0x00006453
		public void SetColorArrayImpl(int name, Il2CppStructArray<Color> values, int count)
		{
			Material.SetColorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0003FCAC File Offset: 0x0003DEAC
		public Il2CppStructArray<float> GetFloatArrayImpl(int name)
		{
			IntPtr intPtr = Material.GetFloatArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0003FCDC File Offset: 0x0003DEDC
		public Il2CppStructArray<Vector4> GetVectorArrayImpl(int name)
		{
			IntPtr intPtr = Material.GetVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0003FD0C File Offset: 0x0003DF0C
		public Il2CppStructArray<Color> GetColorArrayImpl(int name)
		{
			IntPtr intPtr = Material.GetColorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0003FD3C File Offset: 0x0003DF3C
		public Il2CppStructArray<Matrix4x4> GetMatrixArrayImpl(int name)
		{
			IntPtr intPtr = Material.GetMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0000826D File Offset: 0x0000646D
		public int GetFloatArrayCountImpl(int name)
		{
			return Material.GetFloatArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00008280 File Offset: 0x00006480
		public int GetVectorArrayCountImpl(int name)
		{
			return Material.GetVectorArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00008293 File Offset: 0x00006493
		public int GetColorArrayCountImpl(int name)
		{
			return Material.GetColorArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x000082A6 File Offset: 0x000064A6
		public int GetMatrixArrayCountImpl(int name)
		{
			return Material.GetMatrixArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x000082B9 File Offset: 0x000064B9
		public void ExtractFloatArrayImpl(int name, [Out] Il2CppStructArray<float> val)
		{
			Material.ExtractFloatArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x000082D2 File Offset: 0x000064D2
		public void ExtractVectorArrayImpl(int name, [Out] Il2CppStructArray<Vector4> val)
		{
			Material.ExtractVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x000082EB File Offset: 0x000064EB
		public void ExtractColorArrayImpl(int name, [Out] Il2CppStructArray<Color> val)
		{
			Material.ExtractColorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00008304 File Offset: 0x00006504
		public void ExtractMatrixArrayImpl(int name, [Out] Il2CppStructArray<Matrix4x4> val)
		{
			Material.ExtractMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0000831D File Offset: 0x0000651D
		public void SetTextureOffsetImpl(int name, Vector2 offset)
		{
			this.SetTextureOffsetImpl_Injected(name, ref offset);
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00008328 File Offset: 0x00006528
		public void SetTextureScaleImpl(int name, Vector2 scale)
		{
			this.SetTextureScaleImpl_Injected(name, ref scale);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x0003FD6C File Offset: 0x0003DF6C
		public void SetColorArray(int name, Il2CppStructArray<Color> values, int count)
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
			this.SetColorArrayImpl(name, values, count);
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x0003FDC8 File Offset: 0x0003DFC8
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

		// Token: 0x06000D9E RID: 3486 RVA: 0x0003FE20 File Offset: 0x0003E020
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

		// Token: 0x06000D9F RID: 3487 RVA: 0x0003FE78 File Offset: 0x0003E078
		public void ExtractColorArray(int name, List<Color> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int colorArrayCountImpl = this.GetColorArrayCountImpl(name);
			bool flag2 = colorArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Color>(values, colorArrayCountImpl);
				this.ExtractColorArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Color>>());
			}
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0003FED0 File Offset: 0x0003E0D0
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

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00008333 File Offset: 0x00006533
		public void SetInteger(string name, int value)
		{
			this.SetIntImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00008344 File Offset: 0x00006544
		public void SetMatrix(string name, Matrix4x4 value)
		{
			this.SetMatrixImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00008355 File Offset: 0x00006555
		public void SetTexture(string name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTextureImpl(Shader.PropertyToID(name), value, element);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00008367 File Offset: 0x00006567
		public void SetTexture(int nameID, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTextureImpl(nameID, value, element);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00008374 File Offset: 0x00006574
		public void SetBuffer(int nameID, ComputeBuffer value)
		{
			this.SetBufferImpl(nameID, value);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00008380 File Offset: 0x00006580
		public void SetBuffer(string name, GraphicsBuffer value)
		{
			this.SetGraphicsBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00008391 File Offset: 0x00006591
		public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size)
		{
			this.SetConstantBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x000083A5 File Offset: 0x000065A5
		public void SetConstantBuffer(string name, GraphicsBuffer value, int offset, int size)
		{
			this.SetConstantGraphicsBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x000083B9 File Offset: 0x000065B9
		public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size)
		{
			this.SetConstantGraphicsBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x000083C8 File Offset: 0x000065C8
		public void SetFloatArray(string name, List<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x000083E4 File Offset: 0x000065E4
		public void SetFloatArray(int nameID, List<float> values)
		{
			this.SetFloatArray(nameID, NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x000083FB File Offset: 0x000065FB
		public void SetFloatArray(string name, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00008413 File Offset: 0x00006613
		public void SetColorArray(string name, List<Color> values)
		{
			this.SetColorArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Color>(values), values.Count);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0000842F File Offset: 0x0000662F
		public void SetColorArray(int nameID, List<Color> values)
		{
			this.SetColorArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Color>(values), values.Count);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00008446 File Offset: 0x00006646
		public void SetColorArray(string name, Il2CppStructArray<Color> values)
		{
			this.SetColorArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0000845E File Offset: 0x0000665E
		public void SetColorArray(int nameID, Il2CppStructArray<Color> values)
		{
			this.SetColorArray(nameID, values, values.Length);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00008471 File Offset: 0x00006671
		public void SetVectorArray(string name, List<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0000848D File Offset: 0x0000668D
		public void SetVectorArray(int nameID, List<Vector4> values)
		{
			this.SetVectorArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x000084A4 File Offset: 0x000066A4
		public void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x000084BC File Offset: 0x000066BC
		public void SetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x000084D8 File Offset: 0x000066D8
		public void SetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			this.SetMatrixArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x000084EF File Offset: 0x000066EF
		public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0003FF28 File Offset: 0x0003E128
		public int GetInteger(string name)
		{
			return this.GetIntImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0003FF48 File Offset: 0x0003E148
		public int GetInteger(int nameID)
		{
			return this.GetIntImpl(nameID);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0003FF64 File Offset: 0x0003E164
		public Matrix4x4 GetMatrix(string name)
		{
			return this.GetMatrixImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0003FF84 File Offset: 0x0003E184
		public Matrix4x4 GetMatrix(int nameID)
		{
			return this.GetMatrixImpl(nameID);
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0003FFA0 File Offset: 0x0003E1A0
		public Il2CppStructArray<float> GetFloatArray(string name)
		{
			return this.GetFloatArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0003FFC0 File Offset: 0x0003E1C0
		public Il2CppStructArray<float> GetFloatArray(int nameID)
		{
			return (this.GetFloatArrayCountImpl(nameID) != 0) ? this.GetFloatArrayImpl(nameID) : null;
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0003FFE8 File Offset: 0x0003E1E8
		public Il2CppStructArray<Color> GetColorArray(string name)
		{
			return this.GetColorArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00040008 File Offset: 0x0003E208
		public Il2CppStructArray<Color> GetColorArray(int nameID)
		{
			return (this.GetColorArrayCountImpl(nameID) != 0) ? this.GetColorArrayImpl(nameID) : null;
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00040030 File Offset: 0x0003E230
		public Il2CppStructArray<Vector4> GetVectorArray(string name)
		{
			return this.GetVectorArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00040050 File Offset: 0x0003E250
		public Il2CppStructArray<Vector4> GetVectorArray(int nameID)
		{
			return (this.GetVectorArrayCountImpl(nameID) != 0) ? this.GetVectorArrayImpl(nameID) : null;
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00040078 File Offset: 0x0003E278
		public Il2CppStructArray<Matrix4x4> GetMatrixArray(string name)
		{
			return this.GetMatrixArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00040098 File Offset: 0x0003E298
		public Il2CppStructArray<Matrix4x4> GetMatrixArray(int nameID)
		{
			return (this.GetMatrixArrayCountImpl(nameID) != 0) ? this.GetMatrixArrayImpl(nameID) : null;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00008507 File Offset: 0x00006707
		public void GetFloatArray(string name, List<float> values)
		{
			this.ExtractFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00008518 File Offset: 0x00006718
		public void GetFloatArray(int nameID, List<float> values)
		{
			this.ExtractFloatArray(nameID, values);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00008524 File Offset: 0x00006724
		public void GetColorArray(string name, List<Color> values)
		{
			this.ExtractColorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00008535 File Offset: 0x00006735
		public void GetColorArray(int nameID, List<Color> values)
		{
			this.ExtractColorArray(nameID, values);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00008541 File Offset: 0x00006741
		public void GetVectorArray(string name, List<Vector4> values)
		{
			this.ExtractVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00008552 File Offset: 0x00006752
		public void GetVectorArray(int nameID, List<Vector4> values)
		{
			this.ExtractVectorArray(nameID, values);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0000855E File Offset: 0x0000675E
		public void GetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.ExtractMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0000856F File Offset: 0x0000676F
		public void GetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			this.ExtractMatrixArray(nameID, values);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0000857B File Offset: 0x0000677B
		public void SetTextureOffset(string name, Vector2 value)
		{
			this.SetTextureOffsetImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0000858C File Offset: 0x0000678C
		public void SetTextureOffset(int nameID, Vector2 value)
		{
			this.SetTextureOffsetImpl(nameID, value);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00008598 File Offset: 0x00006798
		public void SetTextureScale(string name, Vector2 value)
		{
			this.SetTextureScaleImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x000085A9 File Offset: 0x000067A9
		public void SetTextureScale(int nameID, Vector2 value)
		{
			this.SetTextureScaleImpl(nameID, value);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x000400C0 File Offset: 0x0003E2C0
		public Vector2 GetTextureOffset(string name)
		{
			return this.GetTextureOffset(Shader.PropertyToID(name));
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x000400E0 File Offset: 0x0003E2E0
		public Vector2 GetTextureScale(string name)
		{
			return this.GetTextureScale(Shader.PropertyToID(name));
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00040100 File Offset: 0x0003E300
		public Il2CppStringArray GetPropertyNames(MaterialPropertyType type)
		{
			return this.GetPropertyNamesImpl((int)type);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0004011C File Offset: 0x0003E31C
		public unsafe void EnableLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			Material.EnableLocalKeyword_InjectedDelegate enableLocalKeyword_InjectedDelegateField = Material.EnableLocalKeyword_InjectedDelegateField;
			IntPtr @this = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(keyword);
			enableLocalKeyword_InjectedDelegateField(@this, &intPtr);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00040144 File Offset: 0x0003E344
		public unsafe void DisableLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			Material.DisableLocalKeyword_InjectedDelegate disableLocalKeyword_InjectedDelegateField = Material.DisableLocalKeyword_InjectedDelegateField;
			IntPtr @this = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(keyword);
			disableLocalKeyword_InjectedDelegateField(@this, &intPtr);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0004016C File Offset: 0x0003E36C
		public unsafe void SetLocalKeyword_Injected(ref UnityEngine.Rendering.LocalKeyword keyword, bool value)
		{
			Material.SetLocalKeyword_InjectedDelegate setLocalKeyword_InjectedDelegateField = Material.SetLocalKeyword_InjectedDelegateField;
			IntPtr @this = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(keyword);
			setLocalKeyword_InjectedDelegateField(@this, &intPtr, value);
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00040198 File Offset: 0x0003E398
		public unsafe bool IsLocalKeywordEnabled_Injected(ref UnityEngine.Rendering.LocalKeyword keyword)
		{
			Material.IsLocalKeywordEnabled_InjectedDelegate isLocalKeywordEnabled_InjectedDelegateField = Material.IsLocalKeywordEnabled_InjectedDelegateField;
			IntPtr @this = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(keyword);
			return isLocalKeywordEnabled_InjectedDelegateField(@this, &intPtr);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x000085B5 File Offset: 0x000067B5
		public void GetMatrixImpl_Injected(int name, out Matrix4x4 ret)
		{
			Material.GetMatrixImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, out ret);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x000085C9 File Offset: 0x000067C9
		public void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset)
		{
			Material.SetTextureOffsetImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, ref offset);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x000085DD File Offset: 0x000067DD
		public void SetTextureScaleImpl_Injected(int name, ref Vector2 scale)
		{
			Material.SetTextureScaleImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, ref scale);
		}

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_CreateWithShader_Private_Static_Void_Material_Shader_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_CreateWithMaterial_Private_Static_Void_Material_Material_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr_CreateWithString_Private_Static_Void_Material_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Material_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr_get_shader_Public_get_Shader_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr_set_shader_Public_set_Void_Shader_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_get_mainTexture_Public_get_Texture_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr_set_mainTexture_Public_set_Void_Texture_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstPropertyNameIdByAttribute_Private_Int32_ShaderPropertyFlags_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr_HasProperty_Public_Boolean_Int32_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_HasProperty_Public_Boolean_String_0;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_get_renderQueue_Public_get_Int32_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr_get_rawRenderQueue_Internal_get_Int32_0;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_IsKeywordEnabled_Public_Boolean_String_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabledKeywords_Private_Void_Il2CppReferenceArray_1_LocalKeyword_0;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr_set_enabledKeywords_Public_set_Void_Il2CppReferenceArray_1_LocalKeyword_0;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeMethodInfoPtr_get_enableInstancing_Public_get_Boolean_0;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_get_passCount_Public_get_Int32_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderPassEnabled_Public_Void_String_Boolean_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_FindPass_Public_Int32_String_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_GetTagImpl_Private_String_String_Boolean_String_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr_GetTag_Public_String_String_Boolean_0;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr_SetPass_Public_Boolean_Int32_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_CopyPropertiesFromMaterial_Public_Void_Material_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderKeywords_Private_Il2CppStringArray_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr_get_shaderKeywords_Public_get_Il2CppStringArray_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr_set_shaderKeywords_Public_set_Void_Il2CppStringArray_0;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_ComputeCRC_Public_Int32_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr_SetIntImpl_Private_Void_Int32_Int32_0;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeMethodInfoPtr_SetBufferImpl_Private_Void_Int32_ComputeBuffer_0;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeMethodInfoPtr_SetGraphicsBufferImpl_Private_Void_Int32_GraphicsBuffer_0;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_SetConstantBufferImpl_Private_Void_Int32_ComputeBuffer_Int32_Int32_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_GetFloatImpl_Private_Single_Int32_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_GetColorImpl_Private_Color_Int32_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureImpl_Private_Texture_Int32_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureScaleAndOffsetImpl_Private_Vector4_Int32_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorArray_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixArray_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_SetInteger_Public_Void_Int32_Int32_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_SetBuffer_Public_Void_String_ComputeBuffer_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_GraphicsBuffer_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_SetFloatArray_Public_Void_Int32_Il2CppStructArray_1_Single_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixArray_Public_Void_Int32_Il2CppStructArray_1_Matrix4x4_0;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Int32_String_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Int32_Int32_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_String_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_Int32_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Color_String_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Color_Int32_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_GetVector_Public_Vector4_String_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_GetVector_Public_Vector4_Int32_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture_String_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture_Int32_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureOffset_Public_Vector2_Int32_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureScale_Public_Vector2_Int32_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_SetColorImpl_Injected_Private_Void_Int32_byref_Color_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Void_Int32_byref_Matrix4x4_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_GetColorImpl_Injected_Private_Void_Int32_byref_Color_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureScaleAndOffsetImpl_Injected_Private_Void_Int32_byref_Vector4_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly Material.GetDefaultMaterialDelegate GetDefaultMaterialDelegateField;

		// Token: 0x04000A05 RID: 2565
		private static readonly Material.GetDefaultParticleMaterialDelegate GetDefaultParticleMaterialDelegateField;

		// Token: 0x04000A06 RID: 2566
		private static readonly Material.GetDefaultLineMaterialDelegate GetDefaultLineMaterialDelegateField;

		// Token: 0x04000A07 RID: 2567
		private static readonly Material.HasFloatImplDelegate HasFloatImplDelegateField;

		// Token: 0x04000A08 RID: 2568
		private static readonly Material.HasIntImplDelegate HasIntImplDelegateField;

		// Token: 0x04000A09 RID: 2569
		private static readonly Material.HasTextureImplDelegate HasTextureImplDelegateField;

		// Token: 0x04000A0A RID: 2570
		private static readonly Material.HasMatrixImplDelegate HasMatrixImplDelegateField;

		// Token: 0x04000A0B RID: 2571
		private static readonly Material.HasVectorImplDelegate HasVectorImplDelegateField;

		// Token: 0x04000A0C RID: 2572
		private static readonly Material.HasBufferImplDelegate HasBufferImplDelegateField;

		// Token: 0x04000A0D RID: 2573
		private static readonly Material.HasConstantBufferImplDelegate HasConstantBufferImplDelegateField;

		// Token: 0x04000A0E RID: 2574
		private static readonly Material.GetEnabledKeywordsDelegate GetEnabledKeywordsDelegateField;

		// Token: 0x04000A0F RID: 2575
		private static readonly Material.get_globalIlluminationFlagsDelegate get_globalIlluminationFlagsDelegateField;

		// Token: 0x04000A10 RID: 2576
		private static readonly Material.set_globalIlluminationFlagsDelegate set_globalIlluminationFlagsDelegateField;

		// Token: 0x04000A11 RID: 2577
		private static readonly Material.get_doubleSidedGIDelegate get_doubleSidedGIDelegateField;

		// Token: 0x04000A12 RID: 2578
		private static readonly Material.set_doubleSidedGIDelegate set_doubleSidedGIDelegateField;

		// Token: 0x04000A13 RID: 2579
		private static readonly Material.GetShaderPassEnabledDelegate GetShaderPassEnabledDelegateField;

		// Token: 0x04000A14 RID: 2580
		private static readonly Material.GetPassNameDelegate GetPassNameDelegateField;

		// Token: 0x04000A15 RID: 2581
		private static readonly Material.SetOverrideTagDelegate SetOverrideTagDelegateField;

		// Token: 0x04000A16 RID: 2582
		private static readonly Material.LerpDelegate LerpDelegateField;

		// Token: 0x04000A17 RID: 2583
		private static readonly Material.CopyMatchingPropertiesFromMaterialDelegate CopyMatchingPropertiesFromMaterialDelegateField;

		// Token: 0x04000A18 RID: 2584
		private static readonly Material.GetPropertyNamesImplDelegate GetPropertyNamesImplDelegateField;

		// Token: 0x04000A19 RID: 2585
		private static readonly Material.GetTexturePropertyNamesDelegate GetTexturePropertyNamesDelegateField;

		// Token: 0x04000A1A RID: 2586
		private static readonly Material.GetTexturePropertyNameIDsDelegate GetTexturePropertyNameIDsDelegateField;

		// Token: 0x04000A1B RID: 2587
		private static readonly Material.GetTexturePropertyNamesInternalDelegate GetTexturePropertyNamesInternalDelegateField;

		// Token: 0x04000A1C RID: 2588
		private static readonly Material.GetTexturePropertyNameIDsInternalDelegate GetTexturePropertyNameIDsInternalDelegateField;

		// Token: 0x04000A1D RID: 2589
		private static readonly Material.SetRenderTextureImplDelegate SetRenderTextureImplDelegateField;

		// Token: 0x04000A1E RID: 2590
		private static readonly Material.SetConstantGraphicsBufferImplDelegate SetConstantGraphicsBufferImplDelegateField;

		// Token: 0x04000A1F RID: 2591
		private static readonly Material.GetIntImplDelegate GetIntImplDelegateField;

		// Token: 0x04000A20 RID: 2592
		private static readonly Material.SetColorArrayImplDelegate SetColorArrayImplDelegateField;

		// Token: 0x04000A21 RID: 2593
		private static readonly Material.GetFloatArrayImplDelegate GetFloatArrayImplDelegateField;

		// Token: 0x04000A22 RID: 2594
		private static readonly Material.GetVectorArrayImplDelegate GetVectorArrayImplDelegateField;

		// Token: 0x04000A23 RID: 2595
		private static readonly Material.GetColorArrayImplDelegate GetColorArrayImplDelegateField;

		// Token: 0x04000A24 RID: 2596
		private static readonly Material.GetMatrixArrayImplDelegate GetMatrixArrayImplDelegateField;

		// Token: 0x04000A25 RID: 2597
		private static readonly Material.GetFloatArrayCountImplDelegate GetFloatArrayCountImplDelegateField;

		// Token: 0x04000A26 RID: 2598
		private static readonly Material.GetVectorArrayCountImplDelegate GetVectorArrayCountImplDelegateField;

		// Token: 0x04000A27 RID: 2599
		private static readonly Material.GetColorArrayCountImplDelegate GetColorArrayCountImplDelegateField;

		// Token: 0x04000A28 RID: 2600
		private static readonly Material.GetMatrixArrayCountImplDelegate GetMatrixArrayCountImplDelegateField;

		// Token: 0x04000A29 RID: 2601
		private static readonly Material.ExtractFloatArrayImplDelegate ExtractFloatArrayImplDelegateField;

		// Token: 0x04000A2A RID: 2602
		private static readonly Material.ExtractVectorArrayImplDelegate ExtractVectorArrayImplDelegateField;

		// Token: 0x04000A2B RID: 2603
		private static readonly Material.ExtractColorArrayImplDelegate ExtractColorArrayImplDelegateField;

		// Token: 0x04000A2C RID: 2604
		private static readonly Material.ExtractMatrixArrayImplDelegate ExtractMatrixArrayImplDelegateField;

		// Token: 0x04000A2D RID: 2605
		private static readonly Material.EnableLocalKeyword_InjectedDelegate EnableLocalKeyword_InjectedDelegateField;

		// Token: 0x04000A2E RID: 2606
		private static readonly Material.DisableLocalKeyword_InjectedDelegate DisableLocalKeyword_InjectedDelegateField;

		// Token: 0x04000A2F RID: 2607
		private static readonly Material.SetLocalKeyword_InjectedDelegate SetLocalKeyword_InjectedDelegateField;

		// Token: 0x04000A30 RID: 2608
		private static readonly Material.IsLocalKeywordEnabled_InjectedDelegate IsLocalKeywordEnabled_InjectedDelegateField;

		// Token: 0x04000A31 RID: 2609
		private static readonly Material.GetMatrixImpl_InjectedDelegate GetMatrixImpl_InjectedDelegateField;

		// Token: 0x04000A32 RID: 2610
		private static readonly Material.SetTextureOffsetImpl_InjectedDelegate SetTextureOffsetImpl_InjectedDelegateField;

		// Token: 0x04000A33 RID: 2611
		private static readonly Material.SetTextureScaleImpl_InjectedDelegate SetTextureScaleImpl_InjectedDelegateField;

		// Token: 0x020006C4 RID: 1732
		// (Invoke) Token: 0x06003642 RID: 13890
		private delegate IntPtr GetDefaultMaterialDelegate();

		// Token: 0x020006C5 RID: 1733
		// (Invoke) Token: 0x06003644 RID: 13892
		private delegate IntPtr GetDefaultParticleMaterialDelegate();

		// Token: 0x020006C6 RID: 1734
		// (Invoke) Token: 0x06003646 RID: 13894
		private delegate IntPtr GetDefaultLineMaterialDelegate();

		// Token: 0x020006C7 RID: 1735
		// (Invoke) Token: 0x06003648 RID: 13896
		private delegate bool HasFloatImplDelegate(IntPtr @this, int name);

		// Token: 0x020006C8 RID: 1736
		// (Invoke) Token: 0x0600364A RID: 13898
		private delegate bool HasIntImplDelegate(IntPtr @this, int name);

		// Token: 0x020006C9 RID: 1737
		// (Invoke) Token: 0x0600364C RID: 13900
		private delegate bool HasTextureImplDelegate(IntPtr @this, int name);

		// Token: 0x020006CA RID: 1738
		// (Invoke) Token: 0x0600364E RID: 13902
		private delegate bool HasMatrixImplDelegate(IntPtr @this, int name);

		// Token: 0x020006CB RID: 1739
		// (Invoke) Token: 0x06003650 RID: 13904
		private delegate bool HasVectorImplDelegate(IntPtr @this, int name);

		// Token: 0x020006CC RID: 1740
		// (Invoke) Token: 0x06003652 RID: 13906
		private delegate bool HasBufferImplDelegate(IntPtr @this, int name);

		// Token: 0x020006CD RID: 1741
		// (Invoke) Token: 0x06003654 RID: 13908
		private delegate bool HasConstantBufferImplDelegate(IntPtr @this, int name);

		// Token: 0x020006CE RID: 1742
		// (Invoke) Token: 0x06003656 RID: 13910
		private delegate IntPtr GetEnabledKeywordsDelegate(IntPtr @this);

		// Token: 0x020006CF RID: 1743
		// (Invoke) Token: 0x06003658 RID: 13912
		private delegate MaterialGlobalIlluminationFlags get_globalIlluminationFlagsDelegate(IntPtr @this);

		// Token: 0x020006D0 RID: 1744
		// (Invoke) Token: 0x0600365A RID: 13914
		private delegate void set_globalIlluminationFlagsDelegate(IntPtr @this, MaterialGlobalIlluminationFlags value);

		// Token: 0x020006D1 RID: 1745
		// (Invoke) Token: 0x0600365C RID: 13916
		private delegate bool get_doubleSidedGIDelegate(IntPtr @this);

		// Token: 0x020006D2 RID: 1746
		// (Invoke) Token: 0x0600365E RID: 13918
		private delegate void set_doubleSidedGIDelegate(IntPtr @this, bool value);

		// Token: 0x020006D3 RID: 1747
		// (Invoke) Token: 0x06003660 RID: 13920
		private delegate bool GetShaderPassEnabledDelegate(IntPtr @this, IntPtr passName);

		// Token: 0x020006D4 RID: 1748
		// (Invoke) Token: 0x06003662 RID: 13922
		private delegate IntPtr GetPassNameDelegate(IntPtr @this, int pass);

		// Token: 0x020006D5 RID: 1749
		// (Invoke) Token: 0x06003664 RID: 13924
		private delegate void SetOverrideTagDelegate(IntPtr @this, IntPtr tag, IntPtr val);

		// Token: 0x020006D6 RID: 1750
		// (Invoke) Token: 0x06003666 RID: 13926
		private delegate void LerpDelegate(IntPtr @this, IntPtr start, IntPtr end, float t);

		// Token: 0x020006D7 RID: 1751
		// (Invoke) Token: 0x06003668 RID: 13928
		private delegate void CopyMatchingPropertiesFromMaterialDelegate(IntPtr @this, IntPtr mat);

		// Token: 0x020006D8 RID: 1752
		// (Invoke) Token: 0x0600366A RID: 13930
		private delegate IntPtr GetPropertyNamesImplDelegate(IntPtr @this, int propertyType);

		// Token: 0x020006D9 RID: 1753
		// (Invoke) Token: 0x0600366C RID: 13932
		private delegate IntPtr GetTexturePropertyNamesDelegate(IntPtr @this);

		// Token: 0x020006DA RID: 1754
		// (Invoke) Token: 0x0600366E RID: 13934
		private delegate IntPtr GetTexturePropertyNameIDsDelegate(IntPtr @this);

		// Token: 0x020006DB RID: 1755
		// (Invoke) Token: 0x06003670 RID: 13936
		private delegate void GetTexturePropertyNamesInternalDelegate(IntPtr @this, IntPtr outNames);

		// Token: 0x020006DC RID: 1756
		// (Invoke) Token: 0x06003672 RID: 13938
		private delegate void GetTexturePropertyNameIDsInternalDelegate(IntPtr @this, IntPtr outNames);

		// Token: 0x020006DD RID: 1757
		// (Invoke) Token: 0x06003674 RID: 13940
		private delegate void SetRenderTextureImplDelegate(IntPtr @this, int name, IntPtr value, UnityEngine.Rendering.RenderTextureSubElement element);

		// Token: 0x020006DE RID: 1758
		// (Invoke) Token: 0x06003676 RID: 13942
		private delegate void SetConstantGraphicsBufferImplDelegate(IntPtr @this, int name, IntPtr value, int offset, int size);

		// Token: 0x020006DF RID: 1759
		// (Invoke) Token: 0x06003678 RID: 13944
		private delegate int GetIntImplDelegate(IntPtr @this, int name);

		// Token: 0x020006E0 RID: 1760
		// (Invoke) Token: 0x0600367A RID: 13946
		private delegate void SetColorArrayImplDelegate(IntPtr @this, int name, IntPtr values, int count);

		// Token: 0x020006E1 RID: 1761
		// (Invoke) Token: 0x0600367C RID: 13948
		private delegate IntPtr GetFloatArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x020006E2 RID: 1762
		// (Invoke) Token: 0x0600367E RID: 13950
		private delegate IntPtr GetVectorArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x020006E3 RID: 1763
		// (Invoke) Token: 0x06003680 RID: 13952
		private delegate IntPtr GetColorArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x020006E4 RID: 1764
		// (Invoke) Token: 0x06003682 RID: 13954
		private delegate IntPtr GetMatrixArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x020006E5 RID: 1765
		// (Invoke) Token: 0x06003684 RID: 13956
		private delegate int GetFloatArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x020006E6 RID: 1766
		// (Invoke) Token: 0x06003686 RID: 13958
		private delegate int GetVectorArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x020006E7 RID: 1767
		// (Invoke) Token: 0x06003688 RID: 13960
		private delegate int GetColorArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x020006E8 RID: 1768
		// (Invoke) Token: 0x0600368A RID: 13962
		private delegate int GetMatrixArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x020006E9 RID: 1769
		// (Invoke) Token: 0x0600368C RID: 13964
		private delegate void ExtractFloatArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x020006EA RID: 1770
		// (Invoke) Token: 0x0600368E RID: 13966
		private delegate void ExtractVectorArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x020006EB RID: 1771
		// (Invoke) Token: 0x06003690 RID: 13968
		private delegate void ExtractColorArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x020006EC RID: 1772
		// (Invoke) Token: 0x06003692 RID: 13970
		private delegate void ExtractMatrixArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x020006ED RID: 1773
		// (Invoke) Token: 0x06003694 RID: 13972
		private delegate void EnableLocalKeyword_InjectedDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x020006EE RID: 1774
		// (Invoke) Token: 0x06003696 RID: 13974
		private delegate void DisableLocalKeyword_InjectedDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x020006EF RID: 1775
		// (Invoke) Token: 0x06003698 RID: 13976
		private delegate void SetLocalKeyword_InjectedDelegate(IntPtr @this, IntPtr keyword, bool value);

		// Token: 0x020006F0 RID: 1776
		// (Invoke) Token: 0x0600369A RID: 13978
		private delegate bool IsLocalKeywordEnabled_InjectedDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x020006F1 RID: 1777
		// (Invoke) Token: 0x0600369C RID: 13980
		private delegate void GetMatrixImpl_InjectedDelegate(IntPtr @this, int name, [Out] IntPtr ret);

		// Token: 0x020006F2 RID: 1778
		// (Invoke) Token: 0x0600369E RID: 13982
		private delegate void SetTextureOffsetImpl_InjectedDelegate(IntPtr @this, int name, IntPtr offset);

		// Token: 0x020006F3 RID: 1779
		// (Invoke) Token: 0x060036A0 RID: 13984
		private delegate void SetTextureScaleImpl_InjectedDelegate(IntPtr @this, int name, IntPtr scale);
	}
}
