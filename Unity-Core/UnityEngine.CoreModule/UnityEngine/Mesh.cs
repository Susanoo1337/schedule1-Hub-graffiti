using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000D9 RID: 217
	public sealed class Mesh : Object
	{
		// Token: 0x06000EFF RID: 3839 RVA: 0x00042B78 File Offset: 0x00040D78
		// Note: this type is marked as 'beforefieldinit'.
		static Mesh()
		{
			Il2CppClassPointerStore<Mesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Mesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mesh>.NativeClassPtr);
			Mesh.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664631);
			Mesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664632);
			Mesh.NativeMethodInfoPtr_get_indexFormat_Public_get_IndexFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664633);
			Mesh.NativeMethodInfoPtr_set_indexFormat_Public_set_Void_IndexFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664634);
			Mesh.NativeMethodInfoPtr_SetIndexBufferParams_Public_Void_Int32_IndexFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664635);
			Mesh.NativeMethodInfoPtr_InternalSetIndexBufferDataFromArray_Private_Void_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664636);
			Mesh.NativeMethodInfoPtr_SetVertexBufferParamsFromArray_Private_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664637);
			Mesh.NativeMethodInfoPtr_InternalSetVertexBufferData_Private_Void_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664638);
			Mesh.NativeMethodInfoPtr_InternalSetVertexBufferDataFromArray_Private_Void_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664639);
			Mesh.NativeMethodInfoPtr_GetIndexStartImpl_Private_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664640);
			Mesh.NativeMethodInfoPtr_GetIndexCountImpl_Private_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664641);
			Mesh.NativeMethodInfoPtr_GetBaseVertexImpl_Private_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664642);
			Mesh.NativeMethodInfoPtr_GetTrianglesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664643);
			Mesh.NativeMethodInfoPtr_GetIndicesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664644);
			Mesh.NativeMethodInfoPtr_SetIndicesImpl_Private_Void_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664645);
			Mesh.NativeMethodInfoPtr_SetIndicesNativeArrayImpl_Private_Void_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664646);
			Mesh.NativeMethodInfoPtr_PrintErrorCantAccessChannel_Private_Void_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664647);
			Mesh.NativeMethodInfoPtr_HasVertexAttribute_Public_Boolean_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664648);
			Mesh.NativeMethodInfoPtr_GetVertexAttributeFormat_Public_VertexAttributeFormat_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664649);
			Mesh.NativeMethodInfoPtr_GetVertexAttributeStream_Public_Int32_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664650);
			Mesh.NativeMethodInfoPtr_GetVertexAttributeOffset_Public_Int32_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664651);
			Mesh.NativeMethodInfoPtr_SetArrayForChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664652);
			Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannelImpl_Private_Array_VertexAttribute_VertexAttributeFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664653);
			Mesh.NativeMethodInfoPtr_GetArrayFromChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664654);
			Mesh.NativeMethodInfoPtr_GetVertexBufferImpl_Private_GraphicsBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664655);
			Mesh.NativeMethodInfoPtr_GetIndexBufferImpl_Private_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664656);
			Mesh.NativeMethodInfoPtr_get_vertexBufferTarget_Public_get_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664657);
			Mesh.NativeMethodInfoPtr_set_vertexBufferTarget_Public_set_Void_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664658);
			Mesh.NativeMethodInfoPtr_get_indexBufferTarget_Public_get_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664659);
			Mesh.NativeMethodInfoPtr_set_indexBufferTarget_Public_set_Void_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664660);
			Mesh.NativeMethodInfoPtr_get_blendShapeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664661);
			Mesh.NativeMethodInfoPtr_get_isReadable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664662);
			Mesh.NativeMethodInfoPtr_get_canAccess_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664663);
			Mesh.NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664664);
			Mesh.NativeMethodInfoPtr_get_subMeshCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664665);
			Mesh.NativeMethodInfoPtr_set_subMeshCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664666);
			Mesh.NativeMethodInfoPtr_SetSubMesh_Public_Void_Int32_SubMeshDescriptor_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664667);
			Mesh.NativeMethodInfoPtr_GetSubMesh_Public_SubMeshDescriptor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664668);
			Mesh.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664669);
			Mesh.NativeMethodInfoPtr_set_bounds_Public_set_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664670);
			Mesh.NativeMethodInfoPtr_ClearImpl_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664671);
			Mesh.NativeMethodInfoPtr_RecalculateBoundsImpl_Private_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664672);
			Mesh.NativeMethodInfoPtr_RecalculateNormalsImpl_Private_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664673);
			Mesh.NativeMethodInfoPtr_RecalculateTangentsImpl_Private_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664674);
			Mesh.NativeMethodInfoPtr_MarkDynamicImpl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664675);
			Mesh.NativeMethodInfoPtr_UploadMeshDataImpl_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664676);
			Mesh.NativeMethodInfoPtr_GetTopologyImpl_Private_MeshTopology_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664677);
			Mesh.NativeMethodInfoPtr_CombineMeshesImpl_Private_Void_Il2CppStructArray_1_CombineInstance_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664678);
			Mesh.NativeMethodInfoPtr_OptimizeImpl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664679);
			Mesh.NativeMethodInfoPtr_GetUVChannel_Internal_Static_VertexAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664680);
			Mesh.NativeMethodInfoPtr_DefaultDimensionForChannel_Internal_Static_Int32_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664681);
			Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664682);
			Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664683);
			Mesh.NativeMethodInfoPtr_SetSizedArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664684);
			Mesh.NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664685);
			Mesh.NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664686);
			Mesh.NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664687);
			Mesh.NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664688);
			Mesh.NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664689);
			Mesh.NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664690);
			Mesh.NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664691);
			Mesh.NativeMethodInfoPtr_set_vertices_Public_set_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664692);
			Mesh.NativeMethodInfoPtr_get_normals_Public_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664693);
			Mesh.NativeMethodInfoPtr_set_normals_Public_set_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664694);
			Mesh.NativeMethodInfoPtr_get_tangents_Public_get_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664695);
			Mesh.NativeMethodInfoPtr_set_tangents_Public_set_Void_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664696);
			Mesh.NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664697);
			Mesh.NativeMethodInfoPtr_set_uv_Public_set_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664698);
			Mesh.NativeMethodInfoPtr_get_uv2_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664699);
			Mesh.NativeMethodInfoPtr_set_uv2_Public_set_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664700);
			Mesh.NativeMethodInfoPtr_set_colors_Public_set_Void_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664701);
			Mesh.NativeMethodInfoPtr_get_colors32_Public_get_Il2CppStructArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664702);
			Mesh.NativeMethodInfoPtr_set_colors32_Public_set_Void_Il2CppStructArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664703);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664704);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664705);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664706);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664707);
			Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664708);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664709);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664710);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664711);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664712);
			Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664713);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664714);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664715);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664716);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_Il2CppStructArray_1_Vector4_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664717);
			Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_Il2CppStructArray_1_Vector4_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664718);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664719);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664720);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664721);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664722);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664723);
			Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664724);
			Mesh.NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664725);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664726);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664727);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664728);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664729);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664730);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664731);
			Mesh.NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664732);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664733);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664734);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664735);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664736);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664737);
			Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664738);
			Mesh.NativeMethodInfoPtr_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664739);
			Mesh.NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664740);
			Mesh.NativeMethodInfoPtr_SetVertexBufferParams_Public_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664741);
			Mesh.NativeMethodInfoPtr_SetVertexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664742);
			Mesh.NativeMethodInfoPtr_SetVertexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664743);
			Mesh.NativeMethodInfoPtr_GetVertexBuffer_Public_GraphicsBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664744);
			Mesh.NativeMethodInfoPtr_GetIndexBuffer_Public_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664745);
			Mesh.NativeMethodInfoPtr_PrintErrorCantAccessIndices_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664746);
			Mesh.NativeMethodInfoPtr_CheckCanAccessSubmesh_Private_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664747);
			Mesh.NativeMethodInfoPtr_CheckCanAccessSubmeshTriangles_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664748);
			Mesh.NativeMethodInfoPtr_CheckCanAccessSubmeshIndices_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664749);
			Mesh.NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664750);
			Mesh.NativeMethodInfoPtr_set_triangles_Public_set_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664751);
			Mesh.NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664752);
			Mesh.NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664753);
			Mesh.NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664754);
			Mesh.NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664755);
			Mesh.NativeMethodInfoPtr_SetIndexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664756);
			Mesh.NativeMethodInfoPtr_GetIndexStart_Public_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664757);
			Mesh.NativeMethodInfoPtr_GetIndexCount_Public_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664758);
			Mesh.NativeMethodInfoPtr_GetBaseVertex_Public_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664759);
			Mesh.NativeMethodInfoPtr_CheckIndicesArrayRange_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664760);
			Mesh.NativeMethodInfoPtr_SetTrianglesImpl_Private_Void_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664761);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664762);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664763);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664764);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664765);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664766);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664767);
			Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664768);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664769);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664770);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664771);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_UInt16_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664772);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_UInt16_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664773);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_NativeArray_1_T_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664774);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_NativeArray_1_T_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664775);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_List_1_Int32_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664776);
			Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_List_1_Int32_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664777);
			Mesh.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664778);
			Mesh.NativeMethodInfoPtr_RecalculateBounds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664779);
			Mesh.NativeMethodInfoPtr_RecalculateNormals_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664780);
			Mesh.NativeMethodInfoPtr_RecalculateTangents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664781);
			Mesh.NativeMethodInfoPtr_RecalculateBounds_Public_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664782);
			Mesh.NativeMethodInfoPtr_RecalculateNormals_Public_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664783);
			Mesh.NativeMethodInfoPtr_RecalculateTangents_Public_Void_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664784);
			Mesh.NativeMethodInfoPtr_MarkDynamic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664785);
			Mesh.NativeMethodInfoPtr_UploadMeshData_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664786);
			Mesh.NativeMethodInfoPtr_Optimize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664787);
			Mesh.NativeMethodInfoPtr_GetTopology_Public_MeshTopology_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664788);
			Mesh.NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664789);
			Mesh.NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664790);
			Mesh.NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664791);
			Mesh.NativeMethodInfoPtr_SetSubMesh_Injected_Private_Void_Int32_byref_SubMeshDescriptor_MeshUpdateFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664792);
			Mesh.NativeMethodInfoPtr_GetSubMesh_Injected_Private_Void_Int32_byref_SubMeshDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664793);
			Mesh.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664794);
			Mesh.NativeMethodInfoPtr_set_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100664795);
			Mesh.FromInstanceIDDelegateField = IL2CPP.ResolveICall<Mesh.FromInstanceIDDelegate>("UnityEngine.Mesh::FromInstanceID");
			Mesh.GetTotalIndexCountDelegateField = IL2CPP.ResolveICall<Mesh.GetTotalIndexCountDelegate>("UnityEngine.Mesh::GetTotalIndexCount");
			Mesh.InternalSetIndexBufferDataDelegateField = IL2CPP.ResolveICall<Mesh.InternalSetIndexBufferDataDelegate>("UnityEngine.Mesh::InternalSetIndexBufferData");
			Mesh.SetVertexBufferParamsFromPtrDelegateField = IL2CPP.ResolveICall<Mesh.SetVertexBufferParamsFromPtrDelegate>("UnityEngine.Mesh::SetVertexBufferParamsFromPtr");
			Mesh.GetVertexAttributesAllocDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexAttributesAllocDelegate>("UnityEngine.Mesh::GetVertexAttributesAlloc");
			Mesh.GetVertexAttributesArrayDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexAttributesArrayDelegate>("UnityEngine.Mesh::GetVertexAttributesArray");
			Mesh.GetVertexAttributesListDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexAttributesListDelegate>("UnityEngine.Mesh::GetVertexAttributesList");
			Mesh.GetVertexAttributeCountImplDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexAttributeCountImplDelegate>("UnityEngine.Mesh::GetVertexAttributeCountImpl");
			Mesh.GetTrianglesCountImplDelegateField = IL2CPP.ResolveICall<Mesh.GetTrianglesCountImplDelegate>("UnityEngine.Mesh::GetTrianglesCountImpl");
			Mesh.GetTrianglesNonAllocImplDelegateField = IL2CPP.ResolveICall<Mesh.GetTrianglesNonAllocImplDelegate>("UnityEngine.Mesh::GetTrianglesNonAllocImpl");
			Mesh.GetTrianglesNonAllocImpl16DelegateField = IL2CPP.ResolveICall<Mesh.GetTrianglesNonAllocImpl16Delegate>("UnityEngine.Mesh::GetTrianglesNonAllocImpl16");
			Mesh.GetIndicesNonAllocImplDelegateField = IL2CPP.ResolveICall<Mesh.GetIndicesNonAllocImplDelegate>("UnityEngine.Mesh::GetIndicesNonAllocImpl");
			Mesh.GetIndicesNonAllocImpl16DelegateField = IL2CPP.ResolveICall<Mesh.GetIndicesNonAllocImpl16Delegate>("UnityEngine.Mesh::GetIndicesNonAllocImpl16");
			Mesh.GetVertexAttributeDimensionDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexAttributeDimensionDelegate>("UnityEngine.Mesh::GetVertexAttributeDimension");
			Mesh.SetNativeArrayForChannelImplDelegateField = IL2CPP.ResolveICall<Mesh.SetNativeArrayForChannelImplDelegate>("UnityEngine.Mesh::SetNativeArrayForChannelImpl");
			Mesh.get_vertexBufferCountDelegateField = IL2CPP.ResolveICall<Mesh.get_vertexBufferCountDelegate>("UnityEngine.Mesh::get_vertexBufferCount");
			Mesh.GetVertexBufferStrideDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexBufferStrideDelegate>("UnityEngine.Mesh::GetVertexBufferStride");
			Mesh.GetNativeVertexBufferPtrDelegateField = IL2CPP.ResolveICall<Mesh.GetNativeVertexBufferPtrDelegate>("UnityEngine.Mesh::GetNativeVertexBufferPtr");
			Mesh.GetNativeIndexBufferPtrDelegateField = IL2CPP.ResolveICall<Mesh.GetNativeIndexBufferPtrDelegate>("UnityEngine.Mesh::GetNativeIndexBufferPtr");
			Mesh.GetBoneWeightBufferImplDelegateField = IL2CPP.ResolveICall<Mesh.GetBoneWeightBufferImplDelegate>("UnityEngine.Mesh::GetBoneWeightBufferImpl");
			Mesh.GetBlendShapeBufferImplDelegateField = IL2CPP.ResolveICall<Mesh.GetBlendShapeBufferImplDelegate>("UnityEngine.Mesh::GetBlendShapeBufferImpl");
			Mesh.ClearBlendShapesDelegateField = IL2CPP.ResolveICall<Mesh.ClearBlendShapesDelegate>("UnityEngine.Mesh::ClearBlendShapes");
			Mesh.GetBlendShapeNameDelegateField = IL2CPP.ResolveICall<Mesh.GetBlendShapeNameDelegate>("UnityEngine.Mesh::GetBlendShapeName");
			Mesh.GetBlendShapeIndexDelegateField = IL2CPP.ResolveICall<Mesh.GetBlendShapeIndexDelegate>("UnityEngine.Mesh::GetBlendShapeIndex");
			Mesh.GetBlendShapeFrameCountDelegateField = IL2CPP.ResolveICall<Mesh.GetBlendShapeFrameCountDelegate>("UnityEngine.Mesh::GetBlendShapeFrameCount");
			Mesh.GetBlendShapeFrameWeightDelegateField = IL2CPP.ResolveICall<Mesh.GetBlendShapeFrameWeightDelegate>("UnityEngine.Mesh::GetBlendShapeFrameWeight");
			Mesh.GetBlendShapeFrameVerticesDelegateField = IL2CPP.ResolveICall<Mesh.GetBlendShapeFrameVerticesDelegate>("UnityEngine.Mesh::GetBlendShapeFrameVertices");
			Mesh.AddBlendShapeFrameDelegateField = IL2CPP.ResolveICall<Mesh.AddBlendShapeFrameDelegate>("UnityEngine.Mesh::AddBlendShapeFrame");
			Mesh.HasBoneWeightsDelegateField = IL2CPP.ResolveICall<Mesh.HasBoneWeightsDelegate>("UnityEngine.Mesh::HasBoneWeights");
			Mesh.GetBoneWeightsImplDelegateField = IL2CPP.ResolveICall<Mesh.GetBoneWeightsImplDelegate>("UnityEngine.Mesh::GetBoneWeightsImpl");
			Mesh.SetBoneWeightsImplDelegateField = IL2CPP.ResolveICall<Mesh.SetBoneWeightsImplDelegate>("UnityEngine.Mesh::SetBoneWeightsImpl");
			Mesh.InternalSetBoneWeightsDelegateField = IL2CPP.ResolveICall<Mesh.InternalSetBoneWeightsDelegate>("UnityEngine.Mesh::InternalSetBoneWeights");
			Mesh.GetAllBoneWeightsArraySizeDelegateField = IL2CPP.ResolveICall<Mesh.GetAllBoneWeightsArraySizeDelegate>("UnityEngine.Mesh::GetAllBoneWeightsArraySize");
			Mesh.GetBoneWeightBufferLayoutInternalDelegateField = IL2CPP.ResolveICall<Mesh.GetBoneWeightBufferLayoutInternalDelegate>("UnityEngine.Mesh::GetBoneWeightBufferLayoutInternal");
			Mesh.GetAllBoneWeightsArrayDelegateField = IL2CPP.ResolveICall<Mesh.GetAllBoneWeightsArrayDelegate>("UnityEngine.Mesh::GetAllBoneWeightsArray");
			Mesh.GetBonesPerVertexArrayDelegateField = IL2CPP.ResolveICall<Mesh.GetBonesPerVertexArrayDelegate>("UnityEngine.Mesh::GetBonesPerVertexArray");
			Mesh.get_bindposeCountDelegateField = IL2CPP.ResolveICall<Mesh.get_bindposeCountDelegate>("UnityEngine.Mesh::get_bindposeCount");
			Mesh.get_bindposesDelegateField = IL2CPP.ResolveICall<Mesh.get_bindposesDelegate>("UnityEngine.Mesh::get_bindposes");
			Mesh.set_bindposesDelegateField = IL2CPP.ResolveICall<Mesh.set_bindposesDelegate>("UnityEngine.Mesh::set_bindposes");
			Mesh.GetBindposesArrayDelegateField = IL2CPP.ResolveICall<Mesh.GetBindposesArrayDelegate>("UnityEngine.Mesh::GetBindposesArray");
			Mesh.GetBoneWeightsNonAllocImplDelegateField = IL2CPP.ResolveICall<Mesh.GetBoneWeightsNonAllocImplDelegate>("UnityEngine.Mesh::GetBoneWeightsNonAllocImpl");
			Mesh.GetBindposesNonAllocImplDelegateField = IL2CPP.ResolveICall<Mesh.GetBindposesNonAllocImplDelegate>("UnityEngine.Mesh::GetBindposesNonAllocImpl");
			Mesh.SetAllSubMeshesAtOnceFromArrayDelegateField = IL2CPP.ResolveICall<Mesh.SetAllSubMeshesAtOnceFromArrayDelegate>("UnityEngine.Mesh::SetAllSubMeshesAtOnceFromArray");
			Mesh.SetAllSubMeshesAtOnceFromNativeArrayDelegateField = IL2CPP.ResolveICall<Mesh.SetAllSubMeshesAtOnceFromNativeArrayDelegate>("UnityEngine.Mesh::SetAllSubMeshesAtOnceFromNativeArray");
			Mesh.MarkModifiedDelegateField = IL2CPP.ResolveICall<Mesh.MarkModifiedDelegate>("UnityEngine.Mesh::MarkModified");
			Mesh.RecalculateUVDistributionMetricImplDelegateField = IL2CPP.ResolveICall<Mesh.RecalculateUVDistributionMetricImplDelegate>("UnityEngine.Mesh::RecalculateUVDistributionMetricImpl");
			Mesh.RecalculateUVDistributionMetricsImplDelegateField = IL2CPP.ResolveICall<Mesh.RecalculateUVDistributionMetricsImplDelegate>("UnityEngine.Mesh::RecalculateUVDistributionMetricsImpl");
			Mesh.GetUVDistributionMetricDelegateField = IL2CPP.ResolveICall<Mesh.GetUVDistributionMetricDelegate>("UnityEngine.Mesh::GetUVDistributionMetric");
			Mesh.OptimizeIndexBuffersImplDelegateField = IL2CPP.ResolveICall<Mesh.OptimizeIndexBuffersImplDelegate>("UnityEngine.Mesh::OptimizeIndexBuffersImpl");
			Mesh.OptimizeReorderVertexBufferImplDelegateField = IL2CPP.ResolveICall<Mesh.OptimizeReorderVertexBufferImplDelegate>("UnityEngine.Mesh::OptimizeReorderVertexBufferImpl");
			Mesh.GetVertexAttribute_InjectedDelegateField = IL2CPP.ResolveICall<Mesh.GetVertexAttribute_InjectedDelegate>("UnityEngine.Mesh::GetVertexAttribute_Injected");
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00043B8C File Offset: 0x00041D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238273, XrefRangeEnd = 1238275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Create(Mesh mono)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mono);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Mesh_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00043BC4 File Offset: 0x00041DC4
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 1238281, RefRangeEnd = 1238331, XrefRangeStart = 1238275, XrefRangeEnd = 1238281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mesh() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mesh>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x00043C00 File Offset: 0x00041E00
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x00043C3C File Offset: 0x00041E3C
		public unsafe UnityEngine.Rendering.IndexFormat indexFormat
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238333, RefRangeEnd = 1238334, XrefRangeStart = 1238331, XrefRangeEnd = 1238333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_indexFormat_Public_get_IndexFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1238336, RefRangeEnd = 1238351, XrefRangeStart = 1238334, XrefRangeEnd = 1238336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_indexFormat_Public_set_Void_IndexFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00043C7C File Offset: 0x00041E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238353, RefRangeEnd = 1238354, XrefRangeStart = 1238351, XrefRangeEnd = 1238353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndexBufferParams(int indexCount, UnityEngine.Rendering.IndexFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref indexCount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndexBufferParams_Public_Void_Int32_IndexFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00043CC8 File Offset: 0x00041EC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238356, RefRangeEnd = 1238357, XrefRangeStart = 1238354, XrefRangeEnd = 1238356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elemSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_InternalSetIndexBufferDataFromArray_Private_Void_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00043D50 File Offset: 0x00041F50
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1238359, RefRangeEnd = 1238364, XrefRangeStart = 1238357, XrefRangeEnd = 1238359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexBufferParamsFromArray(int vertexCount, [Optional] Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			if (attributes == null)
			{
				attributes = new Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vertexCount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertexBufferParamsFromArray_Private_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00043DB0 File Offset: 0x00041FB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238366, RefRangeEnd = 1238367, XrefRangeStart = 1238364, XrefRangeEnd = 1238366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetVertexBufferData(int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stream;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elemSize;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_InternalSetVertexBufferData_Private_Void_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00043E44 File Offset: 0x00042044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238369, RefRangeEnd = 1238370, XrefRangeStart = 1238367, XrefRangeEnd = 1238369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stream;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elemSize;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_InternalSetVertexBufferDataFromArray_Private_Void_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00043EDC File Offset: 0x000420DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238370, XrefRangeEnd = 1238372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetIndexStartImpl(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndexStartImpl_Private_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00043F28 File Offset: 0x00042128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238372, XrefRangeEnd = 1238374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetIndexCountImpl(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndexCountImpl_Private_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00043F74 File Offset: 0x00042174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238374, XrefRangeEnd = 1238376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetBaseVertexImpl(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBaseVertexImpl_Private_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00043FC0 File Offset: 0x000421C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238376, XrefRangeEnd = 1238378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetTrianglesImpl(int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTrianglesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0004401C File Offset: 0x0004221C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238378, XrefRangeEnd = 1238380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetIndicesImpl(int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndicesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00044078 File Offset: 0x00042278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238380, XrefRangeEnd = 1238382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndicesImpl(int submesh, MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayStart;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arraySize;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndicesImpl_Private_Void_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00044120 File Offset: 0x00042320
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238384, RefRangeEnd = 1238386, XrefRangeStart = 1238382, XrefRangeEnd = 1238384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndicesNativeArrayImpl(int submesh, MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesFormat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indices;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayStart;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arraySize;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndicesNativeArrayImpl_Private_Void_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x000441C0 File Offset: 0x000423C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238388, RefRangeEnd = 1238390, XrefRangeStart = 1238386, XrefRangeEnd = 1238388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintErrorCantAccessChannel(UnityEngine.Rendering.VertexAttribute ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_PrintErrorCantAccessChannel_Private_Void_VertexAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00044200 File Offset: 0x00042400
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1238392, RefRangeEnd = 1238397, XrefRangeStart = 1238390, XrefRangeEnd = 1238392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasVertexAttribute(UnityEngine.Rendering.VertexAttribute attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref attr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_HasVertexAttribute_Public_Boolean_VertexAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0004424C File Offset: 0x0004244C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238399, RefRangeEnd = 1238400, XrefRangeStart = 1238397, XrefRangeEnd = 1238399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat(UnityEngine.Rendering.VertexAttribute attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref attr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexAttributeFormat_Public_VertexAttributeFormat_VertexAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00044298 File Offset: 0x00042498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238402, RefRangeEnd = 1238403, XrefRangeStart = 1238400, XrefRangeEnd = 1238402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetVertexAttributeStream(UnityEngine.Rendering.VertexAttribute attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref attr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexAttributeStream_Public_Int32_VertexAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x000442E4 File Offset: 0x000424E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238405, RefRangeEnd = 1238406, XrefRangeStart = 1238403, XrefRangeEnd = 1238405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetVertexAttributeOffset(UnityEngine.Rendering.VertexAttribute attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref attr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexAttributeOffset_Public_Int32_VertexAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00044330 File Offset: 0x00042530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238406, XrefRangeEnd = 1238408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arraySize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetArrayForChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x000443D8 File Offset: 0x000425D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238408, XrefRangeEnd = 1238410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Array GetAllocArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannelImpl_Private_Array_VertexAttribute_VertexAttributeFormat_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00044440 File Offset: 0x00042640
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1238412, RefRangeEnd = 1238415, XrefRangeStart = 1238410, XrefRangeEnd = 1238412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, Array values)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetArrayFromChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x000444B0 File Offset: 0x000426B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238415, XrefRangeEnd = 1238417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer GetVertexBufferImpl(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexBufferImpl_Private_GraphicsBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr3) : null;
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x000444FC File Offset: 0x000426FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238417, XrefRangeEnd = 1238419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer GetIndexBufferImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndexBufferImpl_Private_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr3) : null;
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x0004453C File Offset: 0x0004273C
		// (set) Token: 0x06000F1B RID: 3867 RVA: 0x00044578 File Offset: 0x00042778
		public unsafe GraphicsBuffer.Target vertexBufferTarget
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238421, RefRangeEnd = 1238422, XrefRangeStart = 1238419, XrefRangeEnd = 1238421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_vertexBufferTarget_Public_get_Target_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238424, RefRangeEnd = 1238425, XrefRangeStart = 1238422, XrefRangeEnd = 1238424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_vertexBufferTarget_Public_set_Void_Target_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x000445B8 File Offset: 0x000427B8
		// (set) Token: 0x06000F1D RID: 3869 RVA: 0x000445F4 File Offset: 0x000427F4
		public unsafe GraphicsBuffer.Target indexBufferTarget
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238427, RefRangeEnd = 1238428, XrefRangeStart = 1238425, XrefRangeEnd = 1238427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_indexBufferTarget_Public_get_Target_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238430, RefRangeEnd = 1238431, XrefRangeStart = 1238428, XrefRangeEnd = 1238430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_indexBufferTarget_Public_set_Void_Target_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x00044634 File Offset: 0x00042834
		public unsafe int blendShapeCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1238433, RefRangeEnd = 1238436, XrefRangeStart = 1238431, XrefRangeEnd = 1238433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_blendShapeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x00044670 File Offset: 0x00042870
		public unsafe bool isReadable
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1238438, RefRangeEnd = 1238440, XrefRangeStart = 1238436, XrefRangeEnd = 1238438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_isReadable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x000446AC File Offset: 0x000428AC
		public unsafe bool canAccess
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1238442, RefRangeEnd = 1238450, XrefRangeStart = 1238440, XrefRangeEnd = 1238442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_canAccess_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x000446E8 File Offset: 0x000428E8
		public unsafe int vertexCount
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1238452, RefRangeEnd = 1238460, XrefRangeStart = 1238450, XrefRangeEnd = 1238452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x00044724 File Offset: 0x00042924
		// (set) Token: 0x06000F23 RID: 3875 RVA: 0x00044760 File Offset: 0x00042960
		public unsafe int subMeshCount
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 1238462, RefRangeEnd = 1238481, XrefRangeStart = 1238460, XrefRangeEnd = 1238462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_subMeshCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1238483, RefRangeEnd = 1238487, XrefRangeStart = 1238481, XrefRangeEnd = 1238483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_subMeshCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x000447A0 File Offset: 0x000429A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238489, RefRangeEnd = 1238490, XrefRangeStart = 1238487, XrefRangeEnd = 1238489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSubMesh(int index, UnityEngine.Rendering.SubMeshDescriptor desc, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desc;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetSubMesh_Public_Void_Int32_SubMeshDescriptor_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x000447FC File Offset: 0x000429FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1238492, RefRangeEnd = 1238497, XrefRangeStart = 1238490, XrefRangeEnd = 1238492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetSubMesh_Public_SubMeshDescriptor_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x00044848 File Offset: 0x00042A48
		// (set) Token: 0x06000F27 RID: 3879 RVA: 0x00044884 File Offset: 0x00042A84
		public unsafe Bounds bounds
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 1238499, RefRangeEnd = 1238535, XrefRangeStart = 1238497, XrefRangeEnd = 1238499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1238537, RefRangeEnd = 1238547, XrefRangeStart = 1238535, XrefRangeEnd = 1238537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_bounds_Public_set_Void_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x000448C4 File Offset: 0x00042AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238547, XrefRangeEnd = 1238549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearImpl(bool keepVertexLayout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref keepVertexLayout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_ClearImpl_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00044904 File Offset: 0x00042B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238549, XrefRangeEnd = 1238551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateBoundsImpl(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateBoundsImpl_Private_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00044944 File Offset: 0x00042B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238551, XrefRangeEnd = 1238553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateNormalsImpl(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateNormalsImpl_Private_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00044984 File Offset: 0x00042B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238553, XrefRangeEnd = 1238555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateTangentsImpl(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateTangentsImpl_Private_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x000449C4 File Offset: 0x00042BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238555, XrefRangeEnd = 1238557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDynamicImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_MarkDynamicImpl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x000449F8 File Offset: 0x00042BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238557, XrefRangeEnd = 1238559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UploadMeshDataImpl(bool markNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref markNoLongerReadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_UploadMeshDataImpl_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00044A38 File Offset: 0x00042C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238559, XrefRangeEnd = 1238561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshTopology GetTopologyImpl(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTopologyImpl_Private_MeshTopology_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00044A84 File Offset: 0x00042C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238561, XrefRangeEnd = 1238563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CombineMeshesImpl(Il2CppStructArray<CombineInstance> combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(combine);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mergeSubMeshes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMatrices;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasLightmapData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CombineMeshesImpl_Private_Void_Il2CppStructArray_1_CombineInstance_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00044AF0 File Offset: 0x00042CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238563, XrefRangeEnd = 1238565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptimizeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_OptimizeImpl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00044B24 File Offset: 0x00042D24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238565, RefRangeEnd = 1238567, XrefRangeStart = 1238565, XrefRangeEnd = 1238565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.Rendering.VertexAttribute GetUVChannel(int uvIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref uvIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetUVChannel_Internal_Static_VertexAttribute_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00044B64 File Offset: 0x00042D64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1238567, RefRangeEnd = 1238570, XrefRangeStart = 1238567, XrefRangeEnd = 1238567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute channel)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_DefaultDimensionForChannel_Internal_Static_Int32_VertexAttribute_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00044BA4 File Offset: 0x00042DA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238577, RefRangeEnd = 1238578, XrefRangeStart = 1238570, XrefRangeEnd = 1238577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00044C04 File Offset: 0x00042E04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1238587, RefRangeEnd = 1238592, XrefRangeStart = 1238578, XrefRangeEnd = 1238587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x00044C48 File Offset: 0x00042E48
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1238598, RefRangeEnd = 1238610, XrefRangeStart = 1238592, XrefRangeEnd = 1238598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesArrayLength;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesStart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valuesCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetSizedArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00044CF0 File Offset: 0x00042EF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238612, RefRangeEnd = 1238613, XrefRangeStart = 1238610, XrefRangeEnd = 1238612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, Il2CppArrayBase<T> values, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00044D6C File Offset: 0x00042F6C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1238616, RefRangeEnd = 1238622, XrefRangeStart = 1238613, XrefRangeEnd = 1238616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, Il2CppArrayBase<T> values, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x00044DCC File Offset: 0x00042FCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1238626, RefRangeEnd = 1238629, XrefRangeStart = 1238622, XrefRangeEnd = 1238626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00044E64 File Offset: 0x00043064
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1238634, RefRangeEnd = 1238646, XrefRangeStart = 1238629, XrefRangeEnd = 1238634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00044EE0 File Offset: 0x000430E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238646, XrefRangeEnd = 1238653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetListForChannel<T>(List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00044F4C File Offset: 0x0004314C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238653, XrefRangeEnd = 1238659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetListForChannel<T>(List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim, UnityEngine.Rendering.VertexAttributeFormat channelType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00044FC8 File Offset: 0x000431C8
		// (set) Token: 0x06000F3D RID: 3901 RVA: 0x00045008 File Offset: 0x00043208
		public unsafe Il2CppStructArray<Vector3> vertices
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1238662, RefRangeEnd = 1238677, XrefRangeStart = 1238659, XrefRangeEnd = 1238662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 1238680, RefRangeEnd = 1238717, XrefRangeStart = 1238677, XrefRangeEnd = 1238680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_vertices_Public_set_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x0004504C File Offset: 0x0004324C
		// (set) Token: 0x06000F3F RID: 3903 RVA: 0x0004508C File Offset: 0x0004328C
		public unsafe Il2CppStructArray<Vector3> normals
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1238720, RefRangeEnd = 1238724, XrefRangeStart = 1238717, XrefRangeEnd = 1238720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_normals_Public_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1238727, RefRangeEnd = 1238736, XrefRangeStart = 1238724, XrefRangeEnd = 1238727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_normals_Public_set_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x000450D0 File Offset: 0x000432D0
		// (set) Token: 0x06000F41 RID: 3905 RVA: 0x00045110 File Offset: 0x00043310
		public unsafe Il2CppStructArray<Vector4> tangents
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1238739, RefRangeEnd = 1238742, XrefRangeStart = 1238736, XrefRangeEnd = 1238739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_tangents_Public_get_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1238745, RefRangeEnd = 1238751, XrefRangeStart = 1238742, XrefRangeEnd = 1238745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_tangents_Public_set_Void_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x00045154 File Offset: 0x00043354
		// (set) Token: 0x06000F43 RID: 3907 RVA: 0x00045194 File Offset: 0x00043394
		public unsafe Il2CppStructArray<Vector2> uv
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1238754, RefRangeEnd = 1238756, XrefRangeStart = 1238751, XrefRangeEnd = 1238754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1238759, RefRangeEnd = 1238768, XrefRangeStart = 1238756, XrefRangeEnd = 1238759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_uv_Public_set_Void_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x000451D8 File Offset: 0x000433D8
		// (set) Token: 0x06000F45 RID: 3909 RVA: 0x00045218 File Offset: 0x00043418
		public unsafe Il2CppStructArray<Vector2> uv2
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238771, RefRangeEnd = 1238772, XrefRangeStart = 1238768, XrefRangeEnd = 1238771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_uv2_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1238775, RefRangeEnd = 1238783, XrefRangeStart = 1238772, XrefRangeEnd = 1238775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_uv2_Public_set_Void_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x00047884 File Offset: 0x00045A84
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x0004525C File Offset: 0x0004345C
		public unsafe Il2CppStructArray<Color> colors
		{
			get
			{
				return this.GetAllocArrayFromChannel<Color>(UnityEngine.Rendering.VertexAttribute.Color);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1238786, RefRangeEnd = 1238791, XrefRangeStart = 1238783, XrefRangeEnd = 1238786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_colors_Public_set_Void_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x000452A0 File Offset: 0x000434A0
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x000452E0 File Offset: 0x000434E0
		public unsafe Il2CppStructArray<Color32> colors32
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238794, RefRangeEnd = 1238795, XrefRangeStart = 1238791, XrefRangeEnd = 1238794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_colors32_Public_get_Il2CppStructArray_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1238798, RefRangeEnd = 1238806, XrefRangeStart = 1238795, XrefRangeEnd = 1238798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_colors32_Public_set_Void_Il2CppStructArray_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00045324 File Offset: 0x00043524
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1238812, RefRangeEnd = 1238821, XrefRangeStart = 1238806, XrefRangeEnd = 1238812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices(List<Vector3> inVertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00045368 File Offset: 0x00043568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238821, XrefRangeEnd = 1238824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices(List<Vector3> inVertices, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x000453C8 File Offset: 0x000435C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238827, RefRangeEnd = 1238828, XrefRangeStart = 1238824, XrefRangeEnd = 1238827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices(List<Vector3> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00045434 File Offset: 0x00043634
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1238830, RefRangeEnd = 1238833, XrefRangeStart = 1238828, XrefRangeEnd = 1238830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices(Il2CppStructArray<Vector3> inVertices, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00045494 File Offset: 0x00043694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238835, RefRangeEnd = 1238836, XrefRangeStart = 1238833, XrefRangeEnd = 1238835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertices(Il2CppStructArray<Vector3> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertices_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00045500 File Offset: 0x00043700
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1238842, RefRangeEnd = 1238845, XrefRangeStart = 1238836, XrefRangeEnd = 1238842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals(List<Vector3> inNormals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inNormals);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00045544 File Offset: 0x00043744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238845, XrefRangeEnd = 1238848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals(List<Vector3> inNormals, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inNormals);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x000455A4 File Offset: 0x000437A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238851, RefRangeEnd = 1238852, XrefRangeStart = 1238848, XrefRangeEnd = 1238851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals(List<Vector3> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inNormals);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00045610 File Offset: 0x00043810
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238854, RefRangeEnd = 1238856, XrefRangeStart = 1238852, XrefRangeEnd = 1238854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals(Il2CppStructArray<Vector3> inNormals, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inNormals);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00045670 File Offset: 0x00043870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238856, XrefRangeEnd = 1238858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormals(Il2CppStructArray<Vector3> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inNormals);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetNormals_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x000456DC File Offset: 0x000438DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238864, RefRangeEnd = 1238866, XrefRangeStart = 1238858, XrefRangeEnd = 1238864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents(List<Vector4> inTangents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inTangents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00045720 File Offset: 0x00043920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238866, XrefRangeEnd = 1238869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents(List<Vector4> inTangents, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inTangents);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00045780 File Offset: 0x00043980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238872, RefRangeEnd = 1238873, XrefRangeStart = 1238869, XrefRangeEnd = 1238872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents(List<Vector4> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inTangents);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x000457EC File Offset: 0x000439EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238875, RefRangeEnd = 1238877, XrefRangeStart = 1238873, XrefRangeEnd = 1238875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents(Il2CppStructArray<Vector4> inTangents, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inTangents);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_Il2CppStructArray_1_Vector4_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0004584C File Offset: 0x00043A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238877, XrefRangeEnd = 1238879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTangents(Il2CppStructArray<Vector4> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inTangents);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTangents_Public_Void_Il2CppStructArray_1_Vector4_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x000458B8 File Offset: 0x00043AB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238885, RefRangeEnd = 1238887, XrefRangeStart = 1238879, XrefRangeEnd = 1238885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color> inColors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x000458FC File Offset: 0x00043AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238887, XrefRangeEnd = 1238890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color> inColors, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x0004595C File Offset: 0x00043B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238890, XrefRangeEnd = 1238893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x000459C8 File Offset: 0x00043BC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1238899, RefRangeEnd = 1238902, XrefRangeStart = 1238893, XrefRangeEnd = 1238899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color32> inColors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00045A0C File Offset: 0x00043C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238902, XrefRangeEnd = 1238905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color32> inColors, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00045A6C File Offset: 0x00043C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238905, XrefRangeEnd = 1238908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColors(List<Color32> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inColors);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00045AD8 File Offset: 0x00043CD8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1238921, RefRangeEnd = 1238927, XrefRangeStart = 1238908, XrefRangeEnd = 1238921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref uvIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00045B60 File Offset: 0x00043D60
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1238933, RefRangeEnd = 1238940, XrefRangeStart = 1238927, XrefRangeEnd = 1238933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector2> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00045BB0 File Offset: 0x00043DB0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1238946, RefRangeEnd = 1238954, XrefRangeStart = 1238940, XrefRangeEnd = 1238946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector4> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00045C00 File Offset: 0x00043E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238954, XrefRangeEnd = 1238957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector2> uvs, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00045C6C File Offset: 0x00043E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238957, XrefRangeEnd = 1238960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector2> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00045CE8 File Offset: 0x00043EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238960, XrefRangeEnd = 1238963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector4> uvs, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00045D54 File Offset: 0x00043F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238963, XrefRangeEnd = 1238966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, List<Vector4> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00045DD0 File Offset: 0x00043FD0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1238968, RefRangeEnd = 1238974, XrefRangeStart = 1238966, XrefRangeEnd = 1238968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref uvIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arraySize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00045E58 File Offset: 0x00044058
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238976, RefRangeEnd = 1238978, XrefRangeStart = 1238974, XrefRangeEnd = 1238976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, Il2CppStructArray<Vector2> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00045EA8 File Offset: 0x000440A8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1238980, RefRangeEnd = 1238992, XrefRangeStart = 1238978, XrefRangeEnd = 1238980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, Il2CppStructArray<Vector4> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00045EF8 File Offset: 0x000440F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1238993, RefRangeEnd = 1238997, XrefRangeStart = 1238992, XrefRangeEnd = 1238993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, Il2CppStructArray<Vector2> uvs, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00045F64 File Offset: 0x00044164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238997, XrefRangeEnd = 1238998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, Il2CppStructArray<Vector2> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00045FE0 File Offset: 0x000441E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238998, XrefRangeEnd = 1238999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, Il2CppStructArray<Vector4> uvs, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x0004604C File Offset: 0x0004424C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238999, XrefRangeEnd = 1239000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUVs(int channel, Il2CppStructArray<Vector4> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_Int32_Int32_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x000460C8 File Offset: 0x000442C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239010, RefRangeEnd = 1239011, XrefRangeStart = 1239000, XrefRangeEnd = 1239010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref uvIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00046128 File Offset: 0x00044328
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1239014, RefRangeEnd = 1239018, XrefRangeStart = 1239011, XrefRangeEnd = 1239014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUVs(int channel, List<Vector4> uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uvs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00046178 File Offset: 0x00044378
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1238359, RefRangeEnd = 1238364, XrefRangeStart = 1238359, XrefRangeEnd = 1238364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexBufferParams(int vertexCount, [Optional] Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			if (attributes == null)
			{
				attributes = new Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vertexCount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetVertexBufferParams_Public_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x000461D8 File Offset: 0x000443D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239018, XrefRangeEnd = 1239022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexBufferData<T>(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stream;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetVertexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00046268 File Offset: 0x00044468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239022, XrefRangeEnd = 1239026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexBufferData<T>(Il2CppArrayBase<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stream;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetVertexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x000462F0 File Offset: 0x000444F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239037, RefRangeEnd = 1239038, XrefRangeStart = 1239026, XrefRangeEnd = 1239037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer GetVertexBuffer(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetVertexBuffer_Public_GraphicsBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr3) : null;
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0004633C File Offset: 0x0004453C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239049, RefRangeEnd = 1239050, XrefRangeStart = 1239038, XrefRangeEnd = 1239049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer GetIndexBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndexBuffer_Public_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr3) : null;
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x0004637C File Offset: 0x0004457C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239058, RefRangeEnd = 1239060, XrefRangeStart = 1239050, XrefRangeEnd = 1239058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintErrorCantAccessIndices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_PrintErrorCantAccessIndices_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x000463B0 File Offset: 0x000445B0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1239068, RefRangeEnd = 1239086, XrefRangeStart = 1239060, XrefRangeEnd = 1239068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorAboutTriangles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CheckCanAccessSubmesh_Private_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00046408 File Offset: 0x00044608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239086, XrefRangeEnd = 1239087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCanAccessSubmeshTriangles(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CheckCanAccessSubmeshTriangles_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00046454 File Offset: 0x00044654
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239088, RefRangeEnd = 1239090, XrefRangeStart = 1239087, XrefRangeEnd = 1239088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCanAccessSubmeshIndices(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CheckCanAccessSubmeshIndices_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x000464A0 File Offset: 0x000446A0
		// (set) Token: 0x06000F78 RID: 3960 RVA: 0x000464E0 File Offset: 0x000446E0
		public unsafe Il2CppStructArray<int> triangles
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1239098, RefRangeEnd = 1239106, XrefRangeStart = 1239090, XrefRangeEnd = 1239098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 1239114, RefRangeEnd = 1239133, XrefRangeStart = 1239106, XrefRangeEnd = 1239114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_triangles_Public_set_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00046524 File Offset: 0x00044724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239137, RefRangeEnd = 1239138, XrefRangeStart = 1239133, XrefRangeEnd = 1239137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetTriangles(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00046570 File Offset: 0x00044770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239138, XrefRangeEnd = 1239142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetTriangles(int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x000465CC File Offset: 0x000447CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239146, RefRangeEnd = 1239148, XrefRangeStart = 1239142, XrefRangeEnd = 1239146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetIndices(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00046618 File Offset: 0x00044818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239148, XrefRangeEnd = 1239152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<int> GetIndices(int submesh, bool applyBaseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyBaseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00046674 File Offset: 0x00044874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239156, RefRangeEnd = 1239157, XrefRangeStart = 1239152, XrefRangeEnd = 1239156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndexBufferData<T>(Il2CppArrayBase<T> data, int dataStart, int meshBufferStart, int count, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshBufferStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetIndexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_MeshUpdateFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x000466F0 File Offset: 0x000448F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239167, RefRangeEnd = 1239168, XrefRangeStart = 1239157, XrefRangeEnd = 1239167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetIndexStart(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndexStart_Public_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x0004673C File Offset: 0x0004493C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239178, RefRangeEnd = 1239180, XrefRangeStart = 1239168, XrefRangeEnd = 1239178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetIndexCount(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetIndexCount_Public_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00046788 File Offset: 0x00044988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239190, RefRangeEnd = 1239191, XrefRangeStart = 1239180, XrefRangeEnd = 1239190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetBaseVertex(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetBaseVertex_Public_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x000467D4 File Offset: 0x000449D4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1239191, RefRangeEnd = 1239202, XrefRangeStart = 1239191, XrefRangeEnd = 1239191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckIndicesArrayRange(int valuesLength, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref valuesLength;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CheckIndicesArrayRange_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00046830 File Offset: 0x00044A30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1239205, RefRangeEnd = 1239210, XrefRangeStart = 1239202, XrefRangeEnd = 1239205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrianglesImpl(int submesh, UnityEngine.Rendering.IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesFormat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesArrayLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTrianglesImpl_Private_Void_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x000468D4 File Offset: 0x00044AD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239214, RefRangeEnd = 1239215, XrefRangeStart = 1239210, XrefRangeEnd = 1239214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(Il2CppStructArray<int> triangles, int submesh, bool calculateBounds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00046934 File Offset: 0x00044B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239215, XrefRangeEnd = 1239219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(Il2CppStructArray<int> triangles, int submesh, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x000469A0 File Offset: 0x00044BA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239222, RefRangeEnd = 1239224, XrefRangeStart = 1239219, XrefRangeEnd = 1239222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(Il2CppStructArray<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00046A28 File Offset: 0x00044C28
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1239225, RefRangeEnd = 1239230, XrefRangeStart = 1239224, XrefRangeEnd = 1239225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(List<int> triangles, int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00046A78 File Offset: 0x00044C78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239231, RefRangeEnd = 1239232, XrefRangeStart = 1239230, XrefRangeEnd = 1239231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(List<int> triangles, int submesh, bool calculateBounds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00046AD8 File Offset: 0x00044CD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239241, RefRangeEnd = 1239243, XrefRangeStart = 1239232, XrefRangeEnd = 1239241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00046B44 File Offset: 0x00044D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239243, XrefRangeEnd = 1239249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trianglesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00046BCC File Offset: 0x00044DCC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1239255, RefRangeEnd = 1239259, XrefRangeStart = 1239249, XrefRangeEnd = 1239255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(Il2CppStructArray<int> indices, MeshTopology topology, int submesh, bool calculateBounds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00046C38 File Offset: 0x00044E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239259, XrefRangeEnd = 1239265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(Il2CppStructArray<int> indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00046CB4 File Offset: 0x00044EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239265, XrefRangeEnd = 1239270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(Il2CppStructArray<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00046D4C File Offset: 0x00044F4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239276, RefRangeEnd = 1239277, XrefRangeStart = 1239270, XrefRangeEnd = 1239276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(Il2CppStructArray<ushort> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_UInt16_MeshTopology_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00046DC8 File Offset: 0x00044FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239277, XrefRangeEnd = 1239282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(Il2CppStructArray<ushort> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_UInt16_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00046E60 File Offset: 0x00045060
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239289, RefRangeEnd = 1239291, XrefRangeStart = 1239282, XrefRangeEnd = 1239289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices<T>(Unity.Collections.NativeArray<T> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(indices));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetIndices_Public_Void_NativeArray_1_T_MeshTopology_Int32_Boolean_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00046EE0 File Offset: 0x000450E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239297, RefRangeEnd = 1239299, XrefRangeStart = 1239291, XrefRangeEnd = 1239297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices<T>(Unity.Collections.NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(indices));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.MethodInfoStoreGeneric_SetIndices_Public_Void_NativeArray_1_T_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00046F7C File Offset: 0x0004517C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239310, RefRangeEnd = 1239312, XrefRangeStart = 1239299, XrefRangeEnd = 1239310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(List<int> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_List_1_Int32_MeshTopology_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00046FF8 File Offset: 0x000451F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239312, XrefRangeEnd = 1239320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndices(List<int> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indicesLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref submesh;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calculateBounds;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseVertex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_List_1_Int32_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00047090 File Offset: 0x00045290
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1239322, RefRangeEnd = 1239338, XrefRangeStart = 1239320, XrefRangeEnd = 1239322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x000470C4 File Offset: 0x000452C4
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1239350, RefRangeEnd = 1239372, XrefRangeStart = 1239338, XrefRangeEnd = 1239350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateBounds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x000470F8 File Offset: 0x000452F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1239384, RefRangeEnd = 1239389, XrefRangeStart = 1239372, XrefRangeEnd = 1239384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateNormals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateNormals_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x0004712C File Offset: 0x0004532C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239401, RefRangeEnd = 1239403, XrefRangeStart = 1239389, XrefRangeEnd = 1239401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateTangents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateTangents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00047160 File Offset: 0x00045360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239403, XrefRangeEnd = 1239415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateBounds(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateBounds_Public_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x000471A0 File Offset: 0x000453A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239415, XrefRangeEnd = 1239427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateNormals(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateNormals_Public_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x000471E0 File Offset: 0x000453E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239427, XrefRangeEnd = 1239439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateTangents(UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_RecalculateTangents_Public_Void_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00047220 File Offset: 0x00045420
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1239443, RefRangeEnd = 1239450, XrefRangeStart = 1239439, XrefRangeEnd = 1239443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDynamic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_MarkDynamic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00047254 File Offset: 0x00045454
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1239454, RefRangeEnd = 1239461, XrefRangeStart = 1239450, XrefRangeEnd = 1239454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UploadMeshData(bool markNoLongerReadable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref markNoLongerReadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_UploadMeshData_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00047294 File Offset: 0x00045494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239473, RefRangeEnd = 1239474, XrefRangeStart = 1239461, XrefRangeEnd = 1239473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Optimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_Optimize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x000472C8 File Offset: 0x000454C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239484, RefRangeEnd = 1239485, XrefRangeStart = 1239474, XrefRangeEnd = 1239484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshTopology GetTopology(int submesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetTopology_Public_MeshTopology_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00047314 File Offset: 0x00045514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239487, RefRangeEnd = 1239488, XrefRangeStart = 1239485, XrefRangeEnd = 1239487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CombineMeshes(Il2CppStructArray<CombineInstance> combine, bool mergeSubMeshes, bool useMatrices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(combine);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mergeSubMeshes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMatrices;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00047374 File Offset: 0x00045574
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239490, RefRangeEnd = 1239492, XrefRangeStart = 1239488, XrefRangeEnd = 1239490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CombineMeshes(Il2CppStructArray<CombineInstance> combine, bool mergeSubMeshes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(combine);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mergeSubMeshes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x000473C4 File Offset: 0x000455C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1239494, RefRangeEnd = 1239495, XrefRangeStart = 1239492, XrefRangeEnd = 1239494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CombineMeshes(Il2CppStructArray<CombineInstance> combine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(combine);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00047408 File Offset: 0x00045608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239495, XrefRangeEnd = 1239497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSubMesh_Injected(int index, ref UnityEngine.Rendering.SubMeshDescriptor desc, UnityEngine.Rendering.MeshUpdateFlags flags = UnityEngine.Rendering.MeshUpdateFlags.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &desc;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SetSubMesh_Injected_Private_Void_Int32_byref_SubMeshDescriptor_MeshUpdateFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00047464 File Offset: 0x00045664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239497, XrefRangeEnd = 1239499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSubMesh_Injected(int index, out UnityEngine.Rendering.SubMeshDescriptor ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_GetSubMesh_Injected_Private_Void_Int32_byref_SubMeshDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x000474B0 File Offset: 0x000456B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239499, XrefRangeEnd = 1239501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bounds_Injected(out Bounds ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x000474F0 File Offset: 0x000456F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239501, XrefRangeEnd = 1239503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_bounds_Injected(ref Bounds value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_set_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x000091A3 File Offset: 0x000073A3
		public void SetVertexBufferParamsFromArray(int vertexCount, params UnityEngine.Rendering.VertexAttributeDescriptor[] attributes)
		{
			this.SetVertexBufferParamsFromArray(vertexCount, new Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor>(attributes));
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x000091B2 File Offset: 0x000073B2
		public void SetVertexBufferParams(int vertexCount, params UnityEngine.Rendering.VertexAttributeDescriptor[] attributes)
		{
			this.SetVertexBufferParams(vertexCount, new Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor>(attributes));
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x000091C1 File Offset: 0x000073C1
		public Mesh(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00047530 File Offset: 0x00045730
		public static Mesh FromInstanceID(int id)
		{
			IntPtr intPtr = Mesh.FromInstanceIDDelegateField(id);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x000091CA File Offset: 0x000073CA
		public uint GetTotalIndexCount()
		{
			return Mesh.GetTotalIndexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x000091DC File Offset: 0x000073DC
		public void InternalSetIndexBufferData(IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.InternalSetIndexBufferDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, dataStart, meshBufferStart, count, elemSize, flags);
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x000091F7 File Offset: 0x000073F7
		public void SetVertexBufferParamsFromPtr(int vertexCount, IntPtr attributesPtr, int attributesCount)
		{
			Mesh.SetVertexBufferParamsFromPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), vertexCount, attributesPtr, attributesCount);
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00047558 File Offset: 0x00045758
		public Array GetVertexAttributesAlloc()
		{
			IntPtr intPtr = Mesh.GetVertexAttributesAllocDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x0000920C File Offset: 0x0000740C
		public int GetVertexAttributesArray(Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			return Mesh.GetVertexAttributesArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(attributes));
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00009224 File Offset: 0x00007424
		public int GetVertexAttributesList(List<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			return Mesh.GetVertexAttributesListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(attributes));
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x0000923C File Offset: 0x0000743C
		public int GetVertexAttributeCountImpl()
		{
			return Mesh.GetVertexAttributeCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00047584 File Offset: 0x00045784
		public UnityEngine.Rendering.VertexAttributeDescriptor GetVertexAttribute(int index)
		{
			UnityEngine.Rendering.VertexAttributeDescriptor result;
			this.GetVertexAttribute_Injected(index, out result);
			return result;
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x0000924E File Offset: 0x0000744E
		public uint GetTrianglesCountImpl(int submesh)
		{
			return Mesh.GetTrianglesCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), submesh);
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00009261 File Offset: 0x00007461
		public void GetTrianglesNonAllocImpl([Out] Il2CppStructArray<int> values, int submesh, bool applyBaseVertex)
		{
			Mesh.GetTrianglesNonAllocImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(values), submesh, applyBaseVertex);
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0000927B File Offset: 0x0000747B
		public void GetTrianglesNonAllocImpl16([Out] Il2CppStructArray<ushort> values, int submesh, bool applyBaseVertex)
		{
			Mesh.GetTrianglesNonAllocImpl16DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(values), submesh, applyBaseVertex);
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00009295 File Offset: 0x00007495
		public void GetIndicesNonAllocImpl([Out] Il2CppStructArray<int> values, int submesh, bool applyBaseVertex)
		{
			Mesh.GetIndicesNonAllocImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(values), submesh, applyBaseVertex);
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x000092AF File Offset: 0x000074AF
		public void GetIndicesNonAllocImpl16([Out] Il2CppStructArray<ushort> values, int submesh, bool applyBaseVertex)
		{
			Mesh.GetIndicesNonAllocImpl16DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(values), submesh, applyBaseVertex);
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x000092C9 File Offset: 0x000074C9
		public int GetVertexAttributeDimension(UnityEngine.Rendering.VertexAttribute attr)
		{
			return Mesh.GetVertexAttributeDimensionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), attr);
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0004759C File Offset: 0x0004579C
		public void SetNativeArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.SetNativeArrayForChannelImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), channel, format, dim, values, arraySize, valuesStart, valuesCount, flags);
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x000092DC File Offset: 0x000074DC
		public int vertexBufferCount
		{
			get
			{
				return Mesh.get_vertexBufferCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x000092EE File Offset: 0x000074EE
		public int GetVertexBufferStride(int stream)
		{
			return Mesh.GetVertexBufferStrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), stream);
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00009301 File Offset: 0x00007501
		public IntPtr GetNativeVertexBufferPtr(int index)
		{
			return Mesh.GetNativeVertexBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00009314 File Offset: 0x00007514
		public IntPtr GetNativeIndexBufferPtr()
		{
			return Mesh.GetNativeIndexBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x000475C8 File Offset: 0x000457C8
		public GraphicsBuffer GetBoneWeightBufferImpl(int bonesPerVertex)
		{
			IntPtr intPtr = Mesh.GetBoneWeightBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), bonesPerVertex);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x000475F8 File Offset: 0x000457F8
		public GraphicsBuffer GetBlendShapeBufferImpl(int layout)
		{
			IntPtr intPtr = Mesh.GetBlendShapeBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), layout);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00009326 File Offset: 0x00007526
		public void ClearBlendShapes()
		{
			Mesh.ClearBlendShapesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00047628 File Offset: 0x00045828
		public string GetBlendShapeName(int shapeIndex)
		{
			IntPtr intPtr = Mesh.GetBlendShapeNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapeIndex);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00009338 File Offset: 0x00007538
		public int GetBlendShapeIndex(string blendShapeName)
		{
			return Mesh.GetBlendShapeIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(blendShapeName));
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00009350 File Offset: 0x00007550
		public int GetBlendShapeFrameCount(int shapeIndex)
		{
			return Mesh.GetBlendShapeFrameCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapeIndex);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00009363 File Offset: 0x00007563
		public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex)
		{
			return Mesh.GetBlendShapeFrameWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapeIndex, frameIndex);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00009377 File Offset: 0x00007577
		public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Il2CppStructArray<Vector3> deltaVertices, Il2CppStructArray<Vector3> deltaNormals, Il2CppStructArray<Vector3> deltaTangents)
		{
			Mesh.GetBlendShapeFrameVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapeIndex, frameIndex, IL2CPP.Il2CppObjectBaseToPtr(deltaVertices), IL2CPP.Il2CppObjectBaseToPtr(deltaNormals), IL2CPP.Il2CppObjectBaseToPtr(deltaTangents));
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x0000939F File Offset: 0x0000759F
		public void AddBlendShapeFrame(string shapeName, float frameWeight, Il2CppStructArray<Vector3> deltaVertices, Il2CppStructArray<Vector3> deltaNormals, Il2CppStructArray<Vector3> deltaTangents)
		{
			Mesh.AddBlendShapeFrameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(shapeName), frameWeight, IL2CPP.Il2CppObjectBaseToPtr(deltaVertices), IL2CPP.Il2CppObjectBaseToPtr(deltaNormals), IL2CPP.Il2CppObjectBaseToPtr(deltaTangents));
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x000093CC File Offset: 0x000075CC
		public bool HasBoneWeights()
		{
			return Mesh.HasBoneWeightsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00047650 File Offset: 0x00045850
		public Il2CppStructArray<BoneWeight> GetBoneWeightsImpl()
		{
			IntPtr intPtr = Mesh.GetBoneWeightsImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BoneWeight>>(intPtr2) : null;
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x000093DE File Offset: 0x000075DE
		public void SetBoneWeightsImpl(Il2CppStructArray<BoneWeight> weights)
		{
			Mesh.SetBoneWeightsImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(weights));
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x000093F6 File Offset: 0x000075F6
		public void InternalSetBoneWeights(IntPtr bonesPerVertex, int bonesPerVertexSize, IntPtr weights, int weightsSize)
		{
			Mesh.InternalSetBoneWeightsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), bonesPerVertex, bonesPerVertexSize, weights, weightsSize);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0004767C File Offset: 0x0004587C
		public unsafe Unity.Collections.NativeArray<byte> GetBonesPerVertex()
		{
			int length = this.HasBoneWeights() ? this.vertexCount : 0;
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>((void*)this.GetBonesPerVertexArray(), length, Unity.Collections.Allocator.None);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0000940D File Offset: 0x0000760D
		public int GetAllBoneWeightsArraySize()
		{
			return Mesh.GetAllBoneWeightsArraySizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0000941F File Offset: 0x0000761F
		public int GetBoneWeightBufferLayoutInternal()
		{
			return Mesh.GetBoneWeightBufferLayoutInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00009431 File Offset: 0x00007631
		public IntPtr GetAllBoneWeightsArray()
		{
			return Mesh.GetAllBoneWeightsArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00009443 File Offset: 0x00007643
		public IntPtr GetBonesPerVertexArray()
		{
			return Mesh.GetBonesPerVertexArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00009455 File Offset: 0x00007655
		public int bindposeCount
		{
			get
			{
				return Mesh.get_bindposeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x000476B4 File Offset: 0x000458B4
		// (set) Token: 0x06000FD0 RID: 4048 RVA: 0x00009467 File Offset: 0x00007667
		public Il2CppStructArray<Matrix4x4> bindposes
		{
			get
			{
				IntPtr intPtr = Mesh.get_bindposesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				Mesh.set_bindposesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x000476E0 File Offset: 0x000458E0
		public unsafe Unity.Collections.NativeArray<Matrix4x4> GetBindposes()
		{
			return Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Matrix4x4>((void*)this.GetBindposesArray(), this.bindposeCount, Unity.Collections.Allocator.None);
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0000947F File Offset: 0x0000767F
		public IntPtr GetBindposesArray()
		{
			return Mesh.GetBindposesArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00009491 File Offset: 0x00007691
		public void GetBoneWeightsNonAllocImpl([Out] Il2CppStructArray<BoneWeight> values)
		{
			Mesh.GetBoneWeightsNonAllocImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x000094A9 File Offset: 0x000076A9
		public void GetBindposesNonAllocImpl([Out] Il2CppStructArray<Matrix4x4> values)
		{
			Mesh.GetBindposesNonAllocImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x000094C1 File Offset: 0x000076C1
		public void SetAllSubMeshesAtOnceFromArray(Il2CppStructArray<UnityEngine.Rendering.SubMeshDescriptor> desc, int start, int count, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.SetAllSubMeshesAtOnceFromArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(desc), start, count, flags);
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x000094DD File Offset: 0x000076DD
		public void SetAllSubMeshesAtOnceFromNativeArray(IntPtr desc, int start, int count, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			Mesh.SetAllSubMeshesAtOnceFromNativeArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), desc, start, count, flags);
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x000094F4 File Offset: 0x000076F4
		public void MarkModified()
		{
			Mesh.MarkModifiedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00009506 File Offset: 0x00007706
		public void RecalculateUVDistributionMetricImpl(int uvSetIndex, float uvAreaThreshold)
		{
			Mesh.RecalculateUVDistributionMetricImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), uvSetIndex, uvAreaThreshold);
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x0000951A File Offset: 0x0000771A
		public void RecalculateUVDistributionMetricsImpl(float uvAreaThreshold)
		{
			Mesh.RecalculateUVDistributionMetricsImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), uvAreaThreshold);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x0000952D File Offset: 0x0000772D
		public float GetUVDistributionMetric(int uvSetIndex)
		{
			return Mesh.GetUVDistributionMetricDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), uvSetIndex);
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00009540 File Offset: 0x00007740
		public void OptimizeIndexBuffersImpl()
		{
			Mesh.OptimizeIndexBuffersImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00009552 File Offset: 0x00007752
		public void OptimizeReorderVertexBufferImpl()
		{
			Mesh.OptimizeReorderVertexBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x0004770C File Offset: 0x0004590C
		public void SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, IntPtr values, int valuesArrayLength, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				bool flag = valuesStart < 0;
				if (flag)
				{
					throw new ArgumentOutOfRangeException("valuesStart", valuesStart, "Mesh data array start index can't be negative.");
				}
				bool flag2 = valuesCount < 0;
				if (flag2)
				{
					throw new ArgumentOutOfRangeException("valuesCount", valuesCount, "Mesh data array length can't be negative.");
				}
				bool flag3 = valuesStart >= valuesArrayLength && valuesCount != 0;
				if (flag3)
				{
					throw new ArgumentOutOfRangeException("valuesStart", valuesStart, "Mesh data array start is outside of array size.");
				}
				bool flag4 = valuesStart + valuesCount > valuesArrayLength;
				if (flag4)
				{
					throw new ArgumentOutOfRangeException("valuesCount", valuesStart + valuesCount, "Mesh data array start+count is outside of array size.");
				}
				this.SetNativeArrayForChannelImpl(channel, format, dim, values, valuesArrayLength, valuesStart, valuesCount, flags);
			}
			else
			{
				this.PrintErrorCantAccessChannel(channel);
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x000477DC File Offset: 0x000459DC
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x00009564 File Offset: 0x00007764
		public Il2CppStructArray<Vector2> uv3
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord2);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord2, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x000477F8 File Offset: 0x000459F8
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x00009571 File Offset: 0x00007771
		public Il2CppStructArray<Vector2> uv4
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord3);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord3, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00047814 File Offset: 0x00045A14
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x0000957E File Offset: 0x0000777E
		public Il2CppStructArray<Vector2> uv5
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord4);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord4, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00047830 File Offset: 0x00045A30
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x0000958B File Offset: 0x0000778B
		public Il2CppStructArray<Vector2> uv6
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord5);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord5, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x0004784C File Offset: 0x00045A4C
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x00009599 File Offset: 0x00007799
		public Il2CppStructArray<Vector2> uv7
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord6);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord6, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x00047868 File Offset: 0x00045A68
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x000095A7 File Offset: 0x000077A7
		public Il2CppStructArray<Vector2> uv8
		{
			get
			{
				return this.GetAllocArrayFromChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord7);
			}
			set
			{
				this.SetArrayForChannel<Vector2>(UnityEngine.Rendering.VertexAttribute.TexCoord7, value, UnityEngine.Rendering.MeshUpdateFlags.Default);
			}
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x000478A0 File Offset: 0x00045AA0
		public void GetVertices(List<Vector3> vertices)
		{
			bool flag = vertices == null;
			if (flag)
			{
				throw new ArgumentNullException("vertices", "The result vertices list cannot be null.");
			}
			this.GetListForChannel<Vector3>(vertices, this.vertexCount, UnityEngine.Rendering.VertexAttribute.Position, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Position));
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x000095B5 File Offset: 0x000077B5
		public void SetVertices(Il2CppStructArray<Vector3> inVertices)
		{
			this.SetVertices(inVertices, 0, NoAllocHelpers.SafeLength(inVertices));
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x000095C7 File Offset: 0x000077C7
		public void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices) where T : struct
		{
			this.SetVertices<T>(inVertices, 0, inVertices.Length);
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x000095DA File Offset: 0x000077DA
		public void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices, int start, int length) where T : struct
		{
			this.SetVertices<T>(inVertices, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x000478DC File Offset: 0x00045ADC
		public void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() != 12;
			if (flag)
			{
				throw new ArgumentException("SetVertices with NativeArray should use struct type that is 12 bytes (3x float) in size");
			}
			this.SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute.Position, UnityEngine.Rendering.VertexAttributeFormat.Float32, 3, (IntPtr)inVertices.GetUnsafeReadOnlyPtr<T>(), inVertices.Length, start, length, flags);
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00047928 File Offset: 0x00045B28
		public void GetNormals(List<Vector3> normals)
		{
			bool flag = normals == null;
			if (flag)
			{
				throw new ArgumentNullException("normals", "The result normals list cannot be null.");
			}
			this.GetListForChannel<Vector3>(normals, this.vertexCount, UnityEngine.Rendering.VertexAttribute.Normal, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Normal));
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x000095E8 File Offset: 0x000077E8
		public void SetNormals(Il2CppStructArray<Vector3> inNormals)
		{
			this.SetNormals(inNormals, 0, NoAllocHelpers.SafeLength(inNormals));
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x000095FA File Offset: 0x000077FA
		public void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals) where T : struct
		{
			this.SetNormals<T>(inNormals, 0, inNormals.Length);
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0000960D File Offset: 0x0000780D
		public void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals, int start, int length) where T : struct
		{
			this.SetNormals<T>(inNormals, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00047964 File Offset: 0x00045B64
		public void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() != 12;
			if (flag)
			{
				throw new ArgumentException("SetNormals with NativeArray should use struct type that is 12 bytes (3x float) in size");
			}
			this.SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute.Normal, UnityEngine.Rendering.VertexAttributeFormat.Float32, 3, (IntPtr)inNormals.GetUnsafeReadOnlyPtr<T>(), inNormals.Length, start, length, flags);
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x000479B0 File Offset: 0x00045BB0
		public void GetTangents(List<Vector4> tangents)
		{
			bool flag = tangents == null;
			if (flag)
			{
				throw new ArgumentNullException("tangents", "The result tangents list cannot be null.");
			}
			this.GetListForChannel<Vector4>(tangents, this.vertexCount, UnityEngine.Rendering.VertexAttribute.Tangent, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Tangent));
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0000961B File Offset: 0x0000781B
		public void SetTangents(Il2CppStructArray<Vector4> inTangents)
		{
			this.SetTangents(inTangents, 0, NoAllocHelpers.SafeLength(inTangents));
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0000962D File Offset: 0x0000782D
		public void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents) where T : struct
		{
			this.SetTangents<T>(inTangents, 0, inTangents.Length);
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00009640 File Offset: 0x00007840
		public void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents, int start, int length) where T : struct
		{
			this.SetTangents<T>(inTangents, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x000479EC File Offset: 0x00045BEC
		public void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() != 16;
			if (flag)
			{
				throw new ArgumentException("SetTangents with NativeArray should use struct type that is 16 bytes (4x float) in size");
			}
			this.SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute.Tangent, UnityEngine.Rendering.VertexAttributeFormat.Float32, 4, (IntPtr)inTangents.GetUnsafeReadOnlyPtr<T>(), inTangents.Length, start, length, flags);
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00047A38 File Offset: 0x00045C38
		public void GetColors(List<Color> colors)
		{
			bool flag = colors == null;
			if (flag)
			{
				throw new ArgumentNullException("colors", "The result colors list cannot be null.");
			}
			this.GetListForChannel<Color>(colors, this.vertexCount, UnityEngine.Rendering.VertexAttribute.Color, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Color));
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0000964E File Offset: 0x0000784E
		public void SetColors(Il2CppStructArray<Color> inColors)
		{
			this.SetColors(inColors, 0, NoAllocHelpers.SafeLength(inColors));
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00009660 File Offset: 0x00007860
		public void SetColors(Il2CppStructArray<Color> inColors, int start, int length)
		{
			this.SetColors(inColors, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00047A74 File Offset: 0x00045C74
		public void SetColors(Il2CppStructArray<Color> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute.Color, UnityEngine.Rendering.VertexAttributeFormat.Float32, Mesh.DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute.Color), inColors, NoAllocHelpers.SafeLength(inColors), start, length, flags);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00047A9C File Offset: 0x00045C9C
		public void GetColors(List<Color32> colors)
		{
			bool flag = colors == null;
			if (flag)
			{
				throw new ArgumentNullException("colors", "The result colors list cannot be null.");
			}
			this.GetListForChannel<Color32>(colors, this.vertexCount, UnityEngine.Rendering.VertexAttribute.Color, 4, UnityEngine.Rendering.VertexAttributeFormat.UNorm8);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0000966E File Offset: 0x0000786E
		public void SetColors(Il2CppStructArray<Color32> inColors)
		{
			this.SetColors(inColors, 0, NoAllocHelpers.SafeLength(inColors));
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00009680 File Offset: 0x00007880
		public void SetColors(Il2CppStructArray<Color32> inColors, int start, int length)
		{
			this.SetColors(inColors, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00047AD4 File Offset: 0x00045CD4
		public void SetColors(Il2CppStructArray<Color32> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute.Color, UnityEngine.Rendering.VertexAttributeFormat.UNorm8, 4, inColors, NoAllocHelpers.SafeLength(inColors), start, length, flags);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0000968E File Offset: 0x0000788E
		public void SetColors<T>(Unity.Collections.NativeArray<T> inColors) where T : struct
		{
			this.SetColors<T>(inColors, 0, inColors.Length);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x000096A1 File Offset: 0x000078A1
		public void SetColors<T>(Unity.Collections.NativeArray<T> inColors, int start, int length) where T : struct
		{
			this.SetColors<T>(inColors, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00047AF8 File Offset: 0x00045CF8
		public void SetColors<T>(Unity.Collections.NativeArray<T> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			bool flag = num != 16 && num != 4;
			if (flag)
			{
				throw new ArgumentException("SetColors with NativeArray should use struct type that is 16 bytes (4x float) or 4 bytes (4x unorm) in size");
			}
			this.SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute.Color, (num == 4) ? UnityEngine.Rendering.VertexAttributeFormat.UNorm8 : UnityEngine.Rendering.VertexAttributeFormat.Float32, 4, (IntPtr)inColors.GetUnsafeReadOnlyPtr<T>(), inColors.Length, start, length, flags);
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x000096AF File Offset: 0x000078AF
		public void SetUVs(int channel, List<Vector3> uvs)
		{
			this.SetUVs(channel, uvs, 0, NoAllocHelpers.SafeLength<Vector3>(uvs));
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x000096C2 File Offset: 0x000078C2
		public void SetUVs(int channel, List<Vector3> uvs, int start, int length)
		{
			this.SetUVs(channel, uvs, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x000096D2 File Offset: 0x000078D2
		public void SetUVs(int channel, List<Vector3> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetUvsImpl<Vector3>(channel, 3, uvs, start, length, flags);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x000096E4 File Offset: 0x000078E4
		public void SetUVs(int channel, Il2CppStructArray<Vector3> uvs)
		{
			this.SetUVs(channel, uvs, 0, NoAllocHelpers.SafeLength(uvs));
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x000096F7 File Offset: 0x000078F7
		public void SetUVs(int channel, Il2CppStructArray<Vector3> uvs, int start, int length)
		{
			this.SetUVs(channel, uvs, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00009707 File Offset: 0x00007907
		public void SetUVs(int channel, Il2CppStructArray<Vector3> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetUvsImpl(channel, 3, uvs, start, length, flags);
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00009719 File Offset: 0x00007919
		public void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs) where T : struct
		{
			this.SetUVs<T>(channel, uvs, 0, uvs.Length);
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0000972D File Offset: 0x0000792D
		public void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs, int start, int length) where T : struct
		{
			this.SetUVs<T>(channel, uvs, start, length, UnityEngine.Rendering.MeshUpdateFlags.Default);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00047B54 File Offset: 0x00045D54
		public void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = channel < 0 || channel > 7;
			if (flag)
			{
				throw new ArgumentOutOfRangeException("channel", channel, "The uv index is invalid. Must be in the range 0 to 7.");
			}
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			bool flag2 = (num & 3) != 0;
			if (flag2)
			{
				throw new ArgumentException("SetUVs with NativeArray should use struct type that is multiple of 4 bytes in size");
			}
			int num2 = num / 4;
			bool flag3 = num2 < 1 || num2 > 4;
			if (flag3)
			{
				throw new ArgumentException("SetUVs with NativeArray should use struct type that is 1..4 floats in size");
			}
			this.SetSizedNativeArrayForChannel(Mesh.GetUVChannel(channel), UnityEngine.Rendering.VertexAttributeFormat.Float32, num2, (IntPtr)uvs.GetUnsafeReadOnlyPtr<T>(), uvs.Length, start, length, flags);
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0000973D File Offset: 0x0000793D
		public void GetUVs(int channel, List<Vector2> uvs)
		{
			this.GetUVsImpl<Vector2>(channel, uvs, 2);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0000974A File Offset: 0x0000794A
		public void GetUVs(int channel, List<Vector3> uvs)
		{
			this.GetUVsImpl<Vector3>(channel, uvs, 3);
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x00047BE8 File Offset: 0x00045DE8
		public int vertexAttributeCount
		{
			get
			{
				return this.GetVertexAttributeCountImpl();
			}
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00047C00 File Offset: 0x00045E00
		public Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor> GetVertexAttributes()
		{
			return this.GetVertexAttributesAlloc().Cast<Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor>>();
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00047C20 File Offset: 0x00045E20
		public int GetVertexAttributes(Il2CppStructArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			return this.GetVertexAttributesArray(attributes);
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x00047C3C File Offset: 0x00045E3C
		public int GetVertexAttributes(List<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			return this.GetVertexAttributesList(attributes);
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00009757 File Offset: 0x00007957
		public void SetVertexBufferParams(int vertexCount, Unity.Collections.NativeArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes)
		{
			this.SetVertexBufferParamsFromPtr(vertexCount, (IntPtr)attributes.GetUnsafeReadOnlyPtr<UnityEngine.Rendering.VertexAttributeDescriptor>(), attributes.Length);
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00047C58 File Offset: 0x00045E58
		public void SetVertexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, [Optional] int stream, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = !this.canAccess;
			if (flag)
			{
				throw new InvalidOperationException(String.Concat("Not allowed to access vertex data on mesh '", base.name, "' (isReadable is false; Read/Write must be enabled in import settings)"));
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "SetVertexBufferData", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag3 = dataStart < 0 || meshBufferStart < 0 || count < 0 || dataStart + count > data.Count;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (dataStart:{0} meshBufferStart:{1} count:{2})", dataStart, meshBufferStart, count));
			}
			this.InternalSetVertexBufferDataFromArray(stream, NoAllocHelpers.ExtractArrayFromList(data), dataStart, meshBufferStart, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), flags);
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00009776 File Offset: 0x00007976
		public GraphicsBuffer GetBoneWeightBuffer(SkinWeights layout)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00047D1C File Offset: 0x00045F1C
		public GraphicsBuffer GetBlendShapeBuffer(UnityEngine.Rendering.BlendShapeBufferLayout layout)
		{
			bool flag = this == null;
			if (flag)
			{
				throw new NullReferenceException();
			}
			bool flag2 = !SystemInfo.supportsComputeShaders;
			GraphicsBuffer result;
			if (flag2)
			{
				Debug.LogError("Only possible to access Blend Shape buffer on platforms that supports compute shaders.");
				result = null;
			}
			else
			{
				GraphicsBuffer blendShapeBufferImpl = this.GetBlendShapeBufferImpl((int)layout);
				result = blendShapeBufferImpl;
			}
			return result;
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00047D64 File Offset: 0x00045F64
		public GraphicsBuffer GetBlendShapeBuffer()
		{
			bool flag = this == null;
			if (flag)
			{
				throw new NullReferenceException();
			}
			bool flag2 = !SystemInfo.supportsComputeShaders;
			GraphicsBuffer result;
			if (flag2)
			{
				Debug.LogError("Only possible to access Blend Shape buffer on platforms that supports compute shaders.");
				result = null;
			}
			else
			{
				GraphicsBuffer blendShapeBufferImpl = this.GetBlendShapeBufferImpl(0);
				result = blendShapeBufferImpl;
			}
			return result;
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00009783 File Offset: 0x00007983
		public void GetTriangles(List<int> triangles, int submesh)
		{
			this.GetTriangles(triangles, submesh, true);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00047DAC File Offset: 0x00045FAC
		public void GetTriangles(List<int> triangles, int submesh, bool applyBaseVertex)
		{
			bool flag = triangles == null;
			if (flag)
			{
				throw new ArgumentNullException("triangles", "The result triangles list cannot be null.");
			}
			bool flag2 = submesh < 0 || submesh >= this.subMeshCount;
			if (flag2)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			NoAllocHelpers.EnsureListElemCount<int>(triangles, (int)(3U * this.GetTrianglesCountImpl(submesh)));
			this.GetTrianglesNonAllocImpl(NoAllocHelpers.ExtractArrayFromListT<int>(triangles), submesh, applyBaseVertex);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00047E14 File Offset: 0x00046014
		public void GetTriangles(List<ushort> triangles, int submesh, [Optional] bool applyBaseVertex)
		{
			bool flag = triangles == null;
			if (flag)
			{
				throw new ArgumentNullException("triangles", "The result triangles list cannot be null.");
			}
			bool flag2 = submesh < 0 || submesh >= this.subMeshCount;
			if (flag2)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			NoAllocHelpers.EnsureListElemCount<ushort>(triangles, (int)(3U * this.GetTrianglesCountImpl(submesh)));
			this.GetTrianglesNonAllocImpl16(NoAllocHelpers.ExtractArrayFromListT<ushort>(triangles), submesh, applyBaseVertex);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00009790 File Offset: 0x00007990
		public void GetIndices(List<int> indices, int submesh)
		{
			this.GetIndices(indices, submesh, true);
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00047E7C File Offset: 0x0004607C
		public void GetIndices(List<int> indices, int submesh, bool applyBaseVertex)
		{
			bool flag = indices == null;
			if (flag)
			{
				throw new ArgumentNullException("indices", "The result indices list cannot be null.");
			}
			bool flag2 = submesh < 0 || submesh >= this.subMeshCount;
			if (flag2)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			NoAllocHelpers.EnsureListElemCount<int>(indices, (int)this.GetIndexCount(submesh));
			this.GetIndicesNonAllocImpl(NoAllocHelpers.ExtractArrayFromListT<int>(indices), submesh, applyBaseVertex);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00047EE4 File Offset: 0x000460E4
		public void GetIndices(List<ushort> indices, int submesh, [Optional] bool applyBaseVertex)
		{
			bool flag = indices == null;
			if (flag)
			{
				throw new ArgumentNullException("indices", "The result indices list cannot be null.");
			}
			bool flag2 = submesh < 0 || submesh >= this.subMeshCount;
			if (flag2)
			{
				throw new IndexOutOfRangeException("Specified sub mesh is out of range. Must be greater or equal to 0 and less than subMeshCount.");
			}
			NoAllocHelpers.EnsureListElemCount<ushort>(indices, (int)this.GetIndexCount(submesh));
			this.GetIndicesNonAllocImpl16(NoAllocHelpers.ExtractArrayFromListT<ushort>(indices), submesh, applyBaseVertex);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x00047F4C File Offset: 0x0004614C
		public void SetIndexBufferData<T>(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = !this.canAccess;
			if (flag)
			{
				this.PrintErrorCantAccessIndices();
			}
			else
			{
				bool flag2 = dataStart < 0 || meshBufferStart < 0 || count < 0 || dataStart + count > data.Length;
				if (flag2)
				{
					throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (dataStart:{0} meshBufferStart:{1} count:{2})", dataStart, meshBufferStart, count));
				}
				this.InternalSetIndexBufferData((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), dataStart, meshBufferStart, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), flags);
			}
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00047FD4 File Offset: 0x000461D4
		public void SetIndexBufferData<T>(List<T> data, int dataStart, int meshBufferStart, int count, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = !this.canAccess;
			if (flag)
			{
				this.PrintErrorCantAccessIndices();
			}
			else
			{
				bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
				if (flag2)
				{
					throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "SetIndexBufferData", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
				}
				bool flag3 = dataStart < 0 || meshBufferStart < 0 || count < 0 || dataStart + count > data.Count;
				if (flag3)
				{
					throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (dataStart:{0} meshBufferStart:{1} count:{2})", dataStart, meshBufferStart, count));
				}
				this.InternalSetIndexBufferDataFromArray(NoAllocHelpers.ExtractArrayFromList(data), dataStart, meshBufferStart, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), flags);
			}
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0000979D File Offset: 0x0000799D
		public void SetTriangles(Il2CppStructArray<int> triangles, int submesh)
		{
			this.SetTriangles(triangles, submesh, true, 0);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x000097AB File Offset: 0x000079AB
		public void SetTriangles(Il2CppStructArray<ushort> triangles, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			this.SetTriangles(triangles, 0, NoAllocHelpers.SafeLength(triangles), submesh, calculateBounds, baseVertex);
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00048088 File Offset: 0x00046288
		public void SetTriangles(Il2CppStructArray<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			bool flag = this.CheckCanAccessSubmeshTriangles(submesh);
			if (flag)
			{
				this.SetTrianglesImpl(submesh, UnityEngine.Rendering.IndexFormat.UInt16, triangles, NoAllocHelpers.SafeLength(triangles), trianglesStart, trianglesLength, calculateBounds, baseVertex);
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x000097C1 File Offset: 0x000079C1
		public void SetTriangles(List<ushort> triangles, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			this.SetTriangles(triangles, 0, NoAllocHelpers.SafeLength<ushort>(triangles), submesh, calculateBounds, baseVertex);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x000480BC File Offset: 0x000462BC
		public void SetTriangles(List<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			bool flag = this.CheckCanAccessSubmeshTriangles(submesh);
			if (flag)
			{
				this.SetTrianglesImpl(submesh, UnityEngine.Rendering.IndexFormat.UInt16, NoAllocHelpers.ExtractArrayFromList(triangles), NoAllocHelpers.SafeLength<ushort>(triangles), trianglesStart, trianglesLength, calculateBounds, baseVertex);
			}
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x000097D7 File Offset: 0x000079D7
		public void SetIndices(Il2CppStructArray<int> indices, MeshTopology topology, int submesh)
		{
			this.SetIndices(indices, topology, submesh, true, 0);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x000097E6 File Offset: 0x000079E6
		public void SetIndices(List<ushort> indices, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			this.SetIndices(indices, 0, NoAllocHelpers.SafeLength<ushort>(indices), topology, submesh, calculateBounds, baseVertex);
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x000480F4 File Offset: 0x000462F4
		public void SetIndices(List<ushort> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, [Optional] bool calculateBounds, [Optional] int baseVertex)
		{
			bool flag = this.CheckCanAccessSubmeshIndices(submesh);
			if (flag)
			{
				Array indices2 = NoAllocHelpers.ExtractArrayFromList(indices);
				this.CheckIndicesArrayRange(NoAllocHelpers.SafeLength<ushort>(indices), indicesStart, indicesLength);
				this.SetIndicesImpl(submesh, topology, UnityEngine.Rendering.IndexFormat.UInt16, indices2, indicesStart, indicesLength, calculateBounds, baseVertex);
			}
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x000097FE File Offset: 0x000079FE
		public void SetSubMeshes(Il2CppStructArray<UnityEngine.Rendering.SubMeshDescriptor> desc, int start, int count, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0000980B File Offset: 0x00007A0B
		public void SetSubMeshes(Il2CppStructArray<UnityEngine.Rendering.SubMeshDescriptor> desc, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetSubMeshes(desc, 0, (desc != null) ? desc.Length : 0, flags);
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00009825 File Offset: 0x00007A25
		public void SetSubMeshes(List<UnityEngine.Rendering.SubMeshDescriptor> desc, int start, int count, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetSubMeshes(NoAllocHelpers.ExtractArrayFromListT<UnityEngine.Rendering.SubMeshDescriptor>(desc), start, count, flags);
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00009839 File Offset: 0x00007A39
		public void SetSubMeshes(List<UnityEngine.Rendering.SubMeshDescriptor> desc, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags)
		{
			this.SetSubMeshes(NoAllocHelpers.ExtractArrayFromListT<UnityEngine.Rendering.SubMeshDescriptor>(desc), 0, (desc != null) ? desc.Count : 0, flags);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0004813C File Offset: 0x0004633C
		public void SetSubMeshes<T>(Unity.Collections.NativeArray<T> desc, int start, int count, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			bool flag = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>() != Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<UnityEngine.Rendering.SubMeshDescriptor>();
			if (flag)
			{
				throw new ArgumentException(String.Format("{0} with NativeArray should use struct type that is {1} bytes in size", "SetSubMeshes", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<UnityEngine.Rendering.SubMeshDescriptor>()));
			}
			bool flag2 = start < 0 || count < 0 || start + count > desc.Length;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1} desc.Length:{2})", start, count, desc.Length));
			}
			this.SetAllSubMeshesAtOnceFromNativeArray((IntPtr)desc.GetUnsafeReadOnlyPtr<T>(), start, count, flags);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00009857 File Offset: 0x00007A57
		public void SetSubMeshes<T>(Unity.Collections.NativeArray<T> desc, [Optional] UnityEngine.Rendering.MeshUpdateFlags flags) where T : struct
		{
			this.SetSubMeshes<T>(desc, 0, desc.Length, flags);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x000481D8 File Offset: 0x000463D8
		public void GetBindposes(List<Matrix4x4> bindposes)
		{
			bool flag = bindposes == null;
			if (flag)
			{
				throw new ArgumentNullException("bindposes", "The result bindposes list cannot be null.");
			}
			NoAllocHelpers.EnsureListElemCount<Matrix4x4>(bindposes, this.bindposeCount);
			this.GetBindposesNonAllocImpl(NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(bindposes));
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00048218 File Offset: 0x00046418
		public void GetBoneWeights(List<BoneWeight> boneWeights)
		{
			bool flag = boneWeights == null;
			if (flag)
			{
				throw new ArgumentNullException("boneWeights", "The result boneWeights list cannot be null.");
			}
			bool flag2 = this.HasBoneWeights();
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<BoneWeight>(boneWeights, this.vertexCount);
			}
			this.GetBoneWeightsNonAllocImpl(NoAllocHelpers.ExtractArrayFromListT<BoneWeight>(boneWeights));
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x00048264 File Offset: 0x00046464
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x0000986B File Offset: 0x00007A6B
		public Il2CppStructArray<BoneWeight> boneWeights
		{
			get
			{
				return this.GetBoneWeightsImpl();
			}
			set
			{
				this.SetBoneWeightsImpl(value);
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x0004827C File Offset: 0x0004647C
		public SkinWeights skinWeightBufferLayout
		{
			get
			{
				return (SkinWeights)this.GetBoneWeightBufferLayoutInternal();
			}
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x00009876 File Offset: 0x00007A76
		public void Clear(bool keepVertexLayout)
		{
			this.ClearImpl(keepVertexLayout);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00048294 File Offset: 0x00046494
		public void RecalculateUVDistributionMetric(int uvSetIndex, [Optional] float uvAreaThreshold)
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.RecalculateUVDistributionMetricImpl(uvSetIndex, uvAreaThreshold);
			}
			else
			{
				Debug.LogError(String.Format("Not allowed to call RecalculateUVDistributionMetric() on mesh '{0}'", base.name));
			}
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x000482D0 File Offset: 0x000464D0
		public void RecalculateUVDistributionMetrics([Optional] float uvAreaThreshold)
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.RecalculateUVDistributionMetricsImpl(uvAreaThreshold);
			}
			else
			{
				Debug.LogError(String.Format("Not allowed to call RecalculateUVDistributionMetrics() on mesh '{0}'", base.name));
			}
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00048308 File Offset: 0x00046508
		public void OptimizeIndexBuffers()
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.OptimizeIndexBuffersImpl();
			}
			else
			{
				Debug.LogError(String.Format("Not allowed to call OptimizeIndexBuffers() on mesh '{0}'", base.name));
			}
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00048340 File Offset: 0x00046540
		public void OptimizeReorderVertexBuffer()
		{
			bool canAccess = this.canAccess;
			if (canAccess)
			{
				this.OptimizeReorderVertexBufferImpl();
			}
			else
			{
				Debug.LogError(String.Format("Not allowed to call OptimizeReorderVertexBuffer() on mesh '{0}'", base.name));
			}
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00009881 File Offset: 0x00007A81
		public void CombineMeshes(Il2CppStructArray<CombineInstance> combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData)
		{
			this.CombineMeshesImpl(combine, mergeSubMeshes, useMatrices, hasLightmapData);
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00009890 File Offset: 0x00007A90
		public void GetVertexAttribute_Injected(int index, out UnityEngine.Rendering.VertexAttributeDescriptor ret)
		{
			Mesh.GetVertexAttribute_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out ret);
		}

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_Mesh_0;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr_get_indexFormat_Public_get_IndexFormat_0;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr_set_indexFormat_Public_set_Void_IndexFormat_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr_SetIndexBufferParams_Public_Void_Int32_IndexFormat_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetIndexBufferDataFromArray_Private_Void_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexBufferParamsFromArray_Private_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetVertexBufferData_Private_Void_Int32_IntPtr_Int32_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetVertexBufferDataFromArray_Private_Void_Int32_Array_Int32_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexStartImpl_Private_UInt32_Int32_0;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexCountImpl_Private_UInt32_Int32_0;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseVertexImpl_Private_UInt32_Int32_0;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr_GetTrianglesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr_GetIndicesImpl_Private_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr_SetIndicesImpl_Private_Void_Int32_MeshTopology_IndexFormat_Array_Int32_Int32_Boolean_Int32_0;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeMethodInfoPtr_SetIndicesNativeArrayImpl_Private_Void_Int32_MeshTopology_IndexFormat_IntPtr_Int32_Int32_Boolean_Int32_0;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeMethodInfoPtr_PrintErrorCantAccessChannel_Private_Void_VertexAttribute_0;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeMethodInfoPtr_HasVertexAttribute_Public_Boolean_VertexAttribute_0;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttributeFormat_Public_VertexAttributeFormat_VertexAttribute_0;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttributeStream_Public_Int32_VertexAttribute_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexAttributeOffset_Public_Int32_VertexAttribute_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_SetArrayForChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_GetAllocArrayFromChannelImpl_Private_Array_VertexAttribute_VertexAttributeFormat_Int32_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayFromChannelImpl_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_0;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexBufferImpl_Private_GraphicsBuffer_Int32_0;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexBufferImpl_Private_GraphicsBuffer_0;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexBufferTarget_Public_get_Target_0;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr_set_vertexBufferTarget_Public_set_Void_Target_0;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr_get_indexBufferTarget_Public_get_Target_0;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr_set_indexBufferTarget_Public_set_Void_Target_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr_get_blendShapeCount_Public_get_Int32_0;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeMethodInfoPtr_get_isReadable_Public_get_Boolean_0;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_get_canAccess_Internal_get_Boolean_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_get_subMeshCount_Public_get_Int32_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_set_subMeshCount_Public_set_Void_Int32_0;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_SetSubMesh_Public_Void_Int32_SubMeshDescriptor_MeshUpdateFlags_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_GetSubMesh_Public_SubMeshDescriptor_Int32_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr_set_bounds_Public_set_Void_Bounds_0;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr_ClearImpl_Private_Void_Boolean_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateBoundsImpl_Private_Void_MeshUpdateFlags_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateNormalsImpl_Private_Void_MeshUpdateFlags_0;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateTangentsImpl_Private_Void_MeshUpdateFlags_0;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr_MarkDynamicImpl_Private_Void_0;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr_UploadMeshDataImpl_Private_Void_Boolean_0;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeMethodInfoPtr_GetTopologyImpl_Private_MeshTopology_Int32_0;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeMethodInfoPtr_CombineMeshesImpl_Private_Void_Il2CppStructArray_1_CombineInstance_Boolean_Boolean_Boolean_0;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeMethodInfoPtr_OptimizeImpl_Private_Void_0;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeMethodInfoPtr_GetUVChannel_Internal_Static_VertexAttribute_Int32_0;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeMethodInfoPtr_DefaultDimensionForChannel_Internal_Static_Int32_VertexAttribute_0;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeMethodInfoPtr_SetSizedArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Array_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeMethodInfoPtr_set_vertices_Public_set_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr_get_normals_Public_get_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeMethodInfoPtr_set_normals_Public_set_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr_get_tangents_Public_get_Il2CppStructArray_1_Vector4_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr_set_tangents_Public_set_Void_Il2CppStructArray_1_Vector4_0;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr_set_uv_Public_set_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr_get_uv2_Public_get_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr_set_uv2_Public_set_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr_set_colors_Public_set_Void_Il2CppStructArray_1_Color_0;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeMethodInfoPtr_get_colors32_Public_get_Il2CppStructArray_1_Color32_0;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeMethodInfoPtr_set_colors32_Public_set_Void_Il2CppStructArray_1_Color32_0;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_0;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_0;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_0;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeMethodInfoPtr_SetVertices_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_List_1_Vector3_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_SetNormals_Public_Void_Il2CppStructArray_1_Vector3_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_Il2CppStructArray_1_Vector4_Int32_Int32_0;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeMethodInfoPtr_SetTangents_Public_Void_Il2CppStructArray_1_Vector4_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_0;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_Int32_Int32_0;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_0;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_0;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_List_1_Color32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_0;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_0;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_Int32_Int32_0;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector2_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_0;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_List_1_Vector4_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_Array_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_0;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_Int32_Int32_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector2_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_Int32_Int32_0;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeMethodInfoPtr_SetUVs_Public_Void_Int32_Il2CppStructArray_1_Vector4_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr_GetUVs_Public_Void_Int32_List_1_Vector4_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexBufferParams_Public_Void_Int32_Il2CppStructArray_1_VertexAttributeDescriptor_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexBuffer_Public_GraphicsBuffer_Int32_0;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexBuffer_Public_GraphicsBuffer_0;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr_PrintErrorCantAccessIndices_Private_Void_0;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanAccessSubmesh_Private_Boolean_Int32_Boolean_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanAccessSubmeshTriangles_Private_Boolean_Int32_0;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanAccessSubmeshIndices_Private_Boolean_Int32_0;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_set_triangles_Public_set_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_GetTriangles_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr_GetIndices_Public_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr_SetIndexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_MeshUpdateFlags_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexStart_Public_UInt32_Int32_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexCount_Public_UInt32_Int32_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseVertex_Public_UInt32_Int32_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_CheckIndicesArrayRange_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_SetTrianglesImpl_Private_Void_Int32_IndexFormat_Array_Int32_Int32_Int32_Boolean_Int32_0;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Boolean_0;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Boolean_Int32_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Boolean_Int32_0;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_0;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_0;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Boolean_Int32_0;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr_SetTriangles_Public_Void_List_1_Int32_Int32_Int32_Int32_Boolean_Int32_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_Int32_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_UInt16_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_Il2CppStructArray_1_UInt16_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_NativeArray_1_T_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_NativeArray_1_T_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_List_1_Int32_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_SetIndices_Public_Void_List_1_Int32_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateBounds_Public_Void_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateNormals_Public_Void_0;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateTangents_Public_Void_0;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateBounds_Public_Void_MeshUpdateFlags_0;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateNormals_Public_Void_MeshUpdateFlags_0;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateTangents_Public_Void_MeshUpdateFlags_0;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr_MarkDynamic_Public_Void_0;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_UploadMeshData_Public_Void_Boolean_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr_Optimize_Public_Void_0;

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr_GetTopology_Public_MeshTopology_Int32_0;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_Boolean_Boolean_0;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_Boolean_0;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeMethodInfoPtr_CombineMeshes_Public_Void_Il2CppStructArray_1_CombineInstance_0;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeMethodInfoPtr_SetSubMesh_Injected_Private_Void_Int32_byref_SubMeshDescriptor_MeshUpdateFlags_0;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeMethodInfoPtr_GetSubMesh_Injected_Private_Void_Int32_byref_SubMeshDescriptor_0;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr_set_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x04000CBF RID: 3263
		private static readonly Mesh.FromInstanceIDDelegate FromInstanceIDDelegateField;

		// Token: 0x04000CC0 RID: 3264
		private static readonly Mesh.GetTotalIndexCountDelegate GetTotalIndexCountDelegateField;

		// Token: 0x04000CC1 RID: 3265
		private static readonly Mesh.InternalSetIndexBufferDataDelegate InternalSetIndexBufferDataDelegateField;

		// Token: 0x04000CC2 RID: 3266
		private static readonly Mesh.SetVertexBufferParamsFromPtrDelegate SetVertexBufferParamsFromPtrDelegateField;

		// Token: 0x04000CC3 RID: 3267
		private static readonly Mesh.GetVertexAttributesAllocDelegate GetVertexAttributesAllocDelegateField;

		// Token: 0x04000CC4 RID: 3268
		private static readonly Mesh.GetVertexAttributesArrayDelegate GetVertexAttributesArrayDelegateField;

		// Token: 0x04000CC5 RID: 3269
		private static readonly Mesh.GetVertexAttributesListDelegate GetVertexAttributesListDelegateField;

		// Token: 0x04000CC6 RID: 3270
		private static readonly Mesh.GetVertexAttributeCountImplDelegate GetVertexAttributeCountImplDelegateField;

		// Token: 0x04000CC7 RID: 3271
		private static readonly Mesh.GetTrianglesCountImplDelegate GetTrianglesCountImplDelegateField;

		// Token: 0x04000CC8 RID: 3272
		private static readonly Mesh.GetTrianglesNonAllocImplDelegate GetTrianglesNonAllocImplDelegateField;

		// Token: 0x04000CC9 RID: 3273
		private static readonly Mesh.GetTrianglesNonAllocImpl16Delegate GetTrianglesNonAllocImpl16DelegateField;

		// Token: 0x04000CCA RID: 3274
		private static readonly Mesh.GetIndicesNonAllocImplDelegate GetIndicesNonAllocImplDelegateField;

		// Token: 0x04000CCB RID: 3275
		private static readonly Mesh.GetIndicesNonAllocImpl16Delegate GetIndicesNonAllocImpl16DelegateField;

		// Token: 0x04000CCC RID: 3276
		private static readonly Mesh.GetVertexAttributeDimensionDelegate GetVertexAttributeDimensionDelegateField;

		// Token: 0x04000CCD RID: 3277
		private static readonly Mesh.SetNativeArrayForChannelImplDelegate SetNativeArrayForChannelImplDelegateField;

		// Token: 0x04000CCE RID: 3278
		private static readonly Mesh.get_vertexBufferCountDelegate get_vertexBufferCountDelegateField;

		// Token: 0x04000CCF RID: 3279
		private static readonly Mesh.GetVertexBufferStrideDelegate GetVertexBufferStrideDelegateField;

		// Token: 0x04000CD0 RID: 3280
		private static readonly Mesh.GetNativeVertexBufferPtrDelegate GetNativeVertexBufferPtrDelegateField;

		// Token: 0x04000CD1 RID: 3281
		private static readonly Mesh.GetNativeIndexBufferPtrDelegate GetNativeIndexBufferPtrDelegateField;

		// Token: 0x04000CD2 RID: 3282
		private static readonly Mesh.GetBoneWeightBufferImplDelegate GetBoneWeightBufferImplDelegateField;

		// Token: 0x04000CD3 RID: 3283
		private static readonly Mesh.GetBlendShapeBufferImplDelegate GetBlendShapeBufferImplDelegateField;

		// Token: 0x04000CD4 RID: 3284
		private static readonly Mesh.ClearBlendShapesDelegate ClearBlendShapesDelegateField;

		// Token: 0x04000CD5 RID: 3285
		private static readonly Mesh.GetBlendShapeNameDelegate GetBlendShapeNameDelegateField;

		// Token: 0x04000CD6 RID: 3286
		private static readonly Mesh.GetBlendShapeIndexDelegate GetBlendShapeIndexDelegateField;

		// Token: 0x04000CD7 RID: 3287
		private static readonly Mesh.GetBlendShapeFrameCountDelegate GetBlendShapeFrameCountDelegateField;

		// Token: 0x04000CD8 RID: 3288
		private static readonly Mesh.GetBlendShapeFrameWeightDelegate GetBlendShapeFrameWeightDelegateField;

		// Token: 0x04000CD9 RID: 3289
		private static readonly Mesh.GetBlendShapeFrameVerticesDelegate GetBlendShapeFrameVerticesDelegateField;

		// Token: 0x04000CDA RID: 3290
		private static readonly Mesh.AddBlendShapeFrameDelegate AddBlendShapeFrameDelegateField;

		// Token: 0x04000CDB RID: 3291
		private static readonly Mesh.HasBoneWeightsDelegate HasBoneWeightsDelegateField;

		// Token: 0x04000CDC RID: 3292
		private static readonly Mesh.GetBoneWeightsImplDelegate GetBoneWeightsImplDelegateField;

		// Token: 0x04000CDD RID: 3293
		private static readonly Mesh.SetBoneWeightsImplDelegate SetBoneWeightsImplDelegateField;

		// Token: 0x04000CDE RID: 3294
		private static readonly Mesh.InternalSetBoneWeightsDelegate InternalSetBoneWeightsDelegateField;

		// Token: 0x04000CDF RID: 3295
		private static readonly Mesh.GetAllBoneWeightsArraySizeDelegate GetAllBoneWeightsArraySizeDelegateField;

		// Token: 0x04000CE0 RID: 3296
		private static readonly Mesh.GetBoneWeightBufferLayoutInternalDelegate GetBoneWeightBufferLayoutInternalDelegateField;

		// Token: 0x04000CE1 RID: 3297
		private static readonly Mesh.GetAllBoneWeightsArrayDelegate GetAllBoneWeightsArrayDelegateField;

		// Token: 0x04000CE2 RID: 3298
		private static readonly Mesh.GetBonesPerVertexArrayDelegate GetBonesPerVertexArrayDelegateField;

		// Token: 0x04000CE3 RID: 3299
		private static readonly Mesh.get_bindposeCountDelegate get_bindposeCountDelegateField;

		// Token: 0x04000CE4 RID: 3300
		private static readonly Mesh.get_bindposesDelegate get_bindposesDelegateField;

		// Token: 0x04000CE5 RID: 3301
		private static readonly Mesh.set_bindposesDelegate set_bindposesDelegateField;

		// Token: 0x04000CE6 RID: 3302
		private static readonly Mesh.GetBindposesArrayDelegate GetBindposesArrayDelegateField;

		// Token: 0x04000CE7 RID: 3303
		private static readonly Mesh.GetBoneWeightsNonAllocImplDelegate GetBoneWeightsNonAllocImplDelegateField;

		// Token: 0x04000CE8 RID: 3304
		private static readonly Mesh.GetBindposesNonAllocImplDelegate GetBindposesNonAllocImplDelegateField;

		// Token: 0x04000CE9 RID: 3305
		private static readonly Mesh.SetAllSubMeshesAtOnceFromArrayDelegate SetAllSubMeshesAtOnceFromArrayDelegateField;

		// Token: 0x04000CEA RID: 3306
		private static readonly Mesh.SetAllSubMeshesAtOnceFromNativeArrayDelegate SetAllSubMeshesAtOnceFromNativeArrayDelegateField;

		// Token: 0x04000CEB RID: 3307
		private static readonly Mesh.MarkModifiedDelegate MarkModifiedDelegateField;

		// Token: 0x04000CEC RID: 3308
		private static readonly Mesh.RecalculateUVDistributionMetricImplDelegate RecalculateUVDistributionMetricImplDelegateField;

		// Token: 0x04000CED RID: 3309
		private static readonly Mesh.RecalculateUVDistributionMetricsImplDelegate RecalculateUVDistributionMetricsImplDelegateField;

		// Token: 0x04000CEE RID: 3310
		private static readonly Mesh.GetUVDistributionMetricDelegate GetUVDistributionMetricDelegateField;

		// Token: 0x04000CEF RID: 3311
		private static readonly Mesh.OptimizeIndexBuffersImplDelegate OptimizeIndexBuffersImplDelegateField;

		// Token: 0x04000CF0 RID: 3312
		private static readonly Mesh.OptimizeReorderVertexBufferImplDelegate OptimizeReorderVertexBufferImplDelegateField;

		// Token: 0x04000CF1 RID: 3313
		private static readonly Mesh.GetVertexAttribute_InjectedDelegate GetVertexAttribute_InjectedDelegateField;

		// Token: 0x02000785 RID: 1925
		[StructLayout(2)]
		public struct MeshData
		{
			// Token: 0x060037B1 RID: 14257 RVA: 0x00015CF9 File Offset: 0x00013EF9
			// Note: this type is marked as 'beforefieldinit'.
			static MeshData()
			{
				Il2CppClassPointerStore<Mesh.MeshData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Mesh>.NativeClassPtr, "MeshData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mesh.MeshData>.NativeClassPtr);
				Mesh.MeshData.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mesh.MeshData>.NativeClassPtr, "m_Ptr");
			}

			// Token: 0x060037B2 RID: 14258 RVA: 0x00015D2D File Offset: 0x00013F2D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Mesh.MeshData>.NativeClassPtr, ref this));
			}

			// Token: 0x04002AB9 RID: 10937
			private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

			// Token: 0x04002ABA RID: 10938
			[FieldOffset(0)]
			public IntPtr m_Ptr;
		}

		// Token: 0x02000786 RID: 1926
		private sealed class MethodInfoStoreGeneric_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0<T>
		{
			// Token: 0x04002ABB RID: 10939
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_VertexAttributeFormat_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000787 RID: 1927
		private sealed class MethodInfoStoreGeneric_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0<T>
		{
			// Token: 0x04002ABC RID: 10940
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetAllocArrayFromChannel_Private_Il2CppArrayBase_1_T_VertexAttribute_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000788 RID: 1928
		private sealed class MethodInfoStoreGeneric_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002ABD RID: 10941
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_Il2CppArrayBase_1_T_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000789 RID: 1929
		private sealed class MethodInfoStoreGeneric_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002ABE RID: 10942
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetArrayForChannel_Private_Void_VertexAttribute_Il2CppArrayBase_1_T_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200078A RID: 1930
		private sealed class MethodInfoStoreGeneric_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002ABF RID: 10943
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_VertexAttributeFormat_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200078B RID: 1931
		private sealed class MethodInfoStoreGeneric_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002AC0 RID: 10944
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetListForChannel_Private_Void_VertexAttribute_List_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200078C RID: 1932
		private sealed class MethodInfoStoreGeneric_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0<T>
		{
			// Token: 0x04002AC1 RID: 10945
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200078D RID: 1933
		private sealed class MethodInfoStoreGeneric_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0<T>
		{
			// Token: 0x04002AC2 RID: 10946
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetListForChannel_Private_Void_List_1_T_Int32_VertexAttribute_Int32_VertexAttributeFormat_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200078E RID: 1934
		private sealed class MethodInfoStoreGeneric_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002AC3 RID: 10947
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetUvsImpl_Private_Void_Int32_Int32_List_1_T_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200078F RID: 1935
		private sealed class MethodInfoStoreGeneric_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0<T>
		{
			// Token: 0x04002AC4 RID: 10948
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_GetUVsImpl_Private_Void_Int32_List_1_T_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000790 RID: 1936
		private sealed class MethodInfoStoreGeneric_SetVertexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002AC5 RID: 10949
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetVertexBufferData_Public_Void_NativeArray_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000791 RID: 1937
		private sealed class MethodInfoStoreGeneric_SetVertexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002AC6 RID: 10950
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetVertexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000792 RID: 1938
		private sealed class MethodInfoStoreGeneric_SetIndexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_MeshUpdateFlags_0<T>
		{
			// Token: 0x04002AC7 RID: 10951
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetIndexBufferData_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_MeshUpdateFlags_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000793 RID: 1939
		private sealed class MethodInfoStoreGeneric_SetIndices_Public_Void_NativeArray_1_T_MeshTopology_Int32_Boolean_Int32_0<T>
		{
			// Token: 0x04002AC8 RID: 10952
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_NativeArray_1_T_MeshTopology_Int32_Boolean_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000794 RID: 1940
		private sealed class MethodInfoStoreGeneric_SetIndices_Public_Void_NativeArray_1_T_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0<T>
		{
			// Token: 0x04002AC9 RID: 10953
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Mesh.NativeMethodInfoPtr_SetIndices_Public_Void_NativeArray_1_T_Int32_Int32_MeshTopology_Int32_Boolean_Int32_0, Il2CppClassPointerStore<Mesh>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000795 RID: 1941
		// (Invoke) Token: 0x060037C3 RID: 14275
		private delegate IntPtr FromInstanceIDDelegate(int id);

		// Token: 0x02000796 RID: 1942
		// (Invoke) Token: 0x060037C5 RID: 14277
		private delegate uint GetTotalIndexCountDelegate(IntPtr @this);

		// Token: 0x02000797 RID: 1943
		// (Invoke) Token: 0x060037C7 RID: 14279
		private delegate void InternalSetIndexBufferDataDelegate(IntPtr @this, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x02000798 RID: 1944
		// (Invoke) Token: 0x060037C9 RID: 14281
		private delegate void SetVertexBufferParamsFromPtrDelegate(IntPtr @this, int vertexCount, IntPtr attributesPtr, int attributesCount);

		// Token: 0x02000799 RID: 1945
		// (Invoke) Token: 0x060037CB RID: 14283
		private delegate IntPtr GetVertexAttributesAllocDelegate(IntPtr @this);

		// Token: 0x0200079A RID: 1946
		// (Invoke) Token: 0x060037CD RID: 14285
		private delegate int GetVertexAttributesArrayDelegate(IntPtr @this, IntPtr attributes);

		// Token: 0x0200079B RID: 1947
		// (Invoke) Token: 0x060037CF RID: 14287
		private delegate int GetVertexAttributesListDelegate(IntPtr @this, IntPtr attributes);

		// Token: 0x0200079C RID: 1948
		// (Invoke) Token: 0x060037D1 RID: 14289
		private delegate int GetVertexAttributeCountImplDelegate(IntPtr @this);

		// Token: 0x0200079D RID: 1949
		// (Invoke) Token: 0x060037D3 RID: 14291
		private delegate uint GetTrianglesCountImplDelegate(IntPtr @this, int submesh);

		// Token: 0x0200079E RID: 1950
		// (Invoke) Token: 0x060037D5 RID: 14293
		private delegate void GetTrianglesNonAllocImplDelegate(IntPtr @this, [Out] IntPtr values, int submesh, bool applyBaseVertex);

		// Token: 0x0200079F RID: 1951
		// (Invoke) Token: 0x060037D7 RID: 14295
		private delegate void GetTrianglesNonAllocImpl16Delegate(IntPtr @this, [Out] IntPtr values, int submesh, bool applyBaseVertex);

		// Token: 0x020007A0 RID: 1952
		// (Invoke) Token: 0x060037D9 RID: 14297
		private delegate void GetIndicesNonAllocImplDelegate(IntPtr @this, [Out] IntPtr values, int submesh, bool applyBaseVertex);

		// Token: 0x020007A1 RID: 1953
		// (Invoke) Token: 0x060037DB RID: 14299
		private delegate void GetIndicesNonAllocImpl16Delegate(IntPtr @this, [Out] IntPtr values, int submesh, bool applyBaseVertex);

		// Token: 0x020007A2 RID: 1954
		// (Invoke) Token: 0x060037DD RID: 14301
		private delegate int GetVertexAttributeDimensionDelegate(IntPtr @this, UnityEngine.Rendering.VertexAttribute attr);

		// Token: 0x020007A3 RID: 1955
		// (Invoke) Token: 0x060037DF RID: 14303
		private delegate void SetNativeArrayForChannelImplDelegate(IntPtr @this, UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x020007A4 RID: 1956
		// (Invoke) Token: 0x060037E1 RID: 14305
		private delegate int get_vertexBufferCountDelegate(IntPtr @this);

		// Token: 0x020007A5 RID: 1957
		// (Invoke) Token: 0x060037E3 RID: 14307
		private delegate int GetVertexBufferStrideDelegate(IntPtr @this, int stream);

		// Token: 0x020007A6 RID: 1958
		// (Invoke) Token: 0x060037E5 RID: 14309
		private delegate IntPtr GetNativeVertexBufferPtrDelegate(IntPtr @this, int index);

		// Token: 0x020007A7 RID: 1959
		// (Invoke) Token: 0x060037E7 RID: 14311
		private delegate IntPtr GetNativeIndexBufferPtrDelegate(IntPtr @this);

		// Token: 0x020007A8 RID: 1960
		// (Invoke) Token: 0x060037E9 RID: 14313
		private delegate IntPtr GetBoneWeightBufferImplDelegate(IntPtr @this, int bonesPerVertex);

		// Token: 0x020007A9 RID: 1961
		// (Invoke) Token: 0x060037EB RID: 14315
		private delegate IntPtr GetBlendShapeBufferImplDelegate(IntPtr @this, int layout);

		// Token: 0x020007AA RID: 1962
		// (Invoke) Token: 0x060037ED RID: 14317
		private delegate void ClearBlendShapesDelegate(IntPtr @this);

		// Token: 0x020007AB RID: 1963
		// (Invoke) Token: 0x060037EF RID: 14319
		private delegate IntPtr GetBlendShapeNameDelegate(IntPtr @this, int shapeIndex);

		// Token: 0x020007AC RID: 1964
		// (Invoke) Token: 0x060037F1 RID: 14321
		private delegate int GetBlendShapeIndexDelegate(IntPtr @this, IntPtr blendShapeName);

		// Token: 0x020007AD RID: 1965
		// (Invoke) Token: 0x060037F3 RID: 14323
		private delegate int GetBlendShapeFrameCountDelegate(IntPtr @this, int shapeIndex);

		// Token: 0x020007AE RID: 1966
		// (Invoke) Token: 0x060037F5 RID: 14325
		private delegate float GetBlendShapeFrameWeightDelegate(IntPtr @this, int shapeIndex, int frameIndex);

		// Token: 0x020007AF RID: 1967
		// (Invoke) Token: 0x060037F7 RID: 14327
		private delegate void GetBlendShapeFrameVerticesDelegate(IntPtr @this, int shapeIndex, int frameIndex, IntPtr deltaVertices, IntPtr deltaNormals, IntPtr deltaTangents);

		// Token: 0x020007B0 RID: 1968
		// (Invoke) Token: 0x060037F9 RID: 14329
		private delegate void AddBlendShapeFrameDelegate(IntPtr @this, IntPtr shapeName, float frameWeight, IntPtr deltaVertices, IntPtr deltaNormals, IntPtr deltaTangents);

		// Token: 0x020007B1 RID: 1969
		// (Invoke) Token: 0x060037FB RID: 14331
		private delegate bool HasBoneWeightsDelegate(IntPtr @this);

		// Token: 0x020007B2 RID: 1970
		// (Invoke) Token: 0x060037FD RID: 14333
		private delegate IntPtr GetBoneWeightsImplDelegate(IntPtr @this);

		// Token: 0x020007B3 RID: 1971
		// (Invoke) Token: 0x060037FF RID: 14335
		private delegate void SetBoneWeightsImplDelegate(IntPtr @this, IntPtr weights);

		// Token: 0x020007B4 RID: 1972
		// (Invoke) Token: 0x06003801 RID: 14337
		private delegate void InternalSetBoneWeightsDelegate(IntPtr @this, IntPtr bonesPerVertex, int bonesPerVertexSize, IntPtr weights, int weightsSize);

		// Token: 0x020007B5 RID: 1973
		// (Invoke) Token: 0x06003803 RID: 14339
		private delegate int GetAllBoneWeightsArraySizeDelegate(IntPtr @this);

		// Token: 0x020007B6 RID: 1974
		// (Invoke) Token: 0x06003805 RID: 14341
		private delegate int GetBoneWeightBufferLayoutInternalDelegate(IntPtr @this);

		// Token: 0x020007B7 RID: 1975
		// (Invoke) Token: 0x06003807 RID: 14343
		private delegate IntPtr GetAllBoneWeightsArrayDelegate(IntPtr @this);

		// Token: 0x020007B8 RID: 1976
		// (Invoke) Token: 0x06003809 RID: 14345
		private delegate IntPtr GetBonesPerVertexArrayDelegate(IntPtr @this);

		// Token: 0x020007B9 RID: 1977
		// (Invoke) Token: 0x0600380B RID: 14347
		private delegate int get_bindposeCountDelegate(IntPtr @this);

		// Token: 0x020007BA RID: 1978
		// (Invoke) Token: 0x0600380D RID: 14349
		private delegate IntPtr get_bindposesDelegate(IntPtr @this);

		// Token: 0x020007BB RID: 1979
		// (Invoke) Token: 0x0600380F RID: 14351
		private delegate void set_bindposesDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020007BC RID: 1980
		// (Invoke) Token: 0x06003811 RID: 14353
		private delegate IntPtr GetBindposesArrayDelegate(IntPtr @this);

		// Token: 0x020007BD RID: 1981
		// (Invoke) Token: 0x06003813 RID: 14355
		private delegate void GetBoneWeightsNonAllocImplDelegate(IntPtr @this, [Out] IntPtr values);

		// Token: 0x020007BE RID: 1982
		// (Invoke) Token: 0x06003815 RID: 14357
		private delegate void GetBindposesNonAllocImplDelegate(IntPtr @this, [Out] IntPtr values);

		// Token: 0x020007BF RID: 1983
		// (Invoke) Token: 0x06003817 RID: 14359
		private delegate void SetAllSubMeshesAtOnceFromArrayDelegate(IntPtr @this, IntPtr desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x020007C0 RID: 1984
		// (Invoke) Token: 0x06003819 RID: 14361
		private delegate void SetAllSubMeshesAtOnceFromNativeArrayDelegate(IntPtr @this, IntPtr desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);

		// Token: 0x020007C1 RID: 1985
		// (Invoke) Token: 0x0600381B RID: 14363
		private delegate void MarkModifiedDelegate(IntPtr @this);

		// Token: 0x020007C2 RID: 1986
		// (Invoke) Token: 0x0600381D RID: 14365
		private delegate void RecalculateUVDistributionMetricImplDelegate(IntPtr @this, int uvSetIndex, float uvAreaThreshold);

		// Token: 0x020007C3 RID: 1987
		// (Invoke) Token: 0x0600381F RID: 14367
		private delegate void RecalculateUVDistributionMetricsImplDelegate(IntPtr @this, float uvAreaThreshold);

		// Token: 0x020007C4 RID: 1988
		// (Invoke) Token: 0x06003821 RID: 14369
		private delegate float GetUVDistributionMetricDelegate(IntPtr @this, int uvSetIndex);

		// Token: 0x020007C5 RID: 1989
		// (Invoke) Token: 0x06003823 RID: 14371
		private delegate void OptimizeIndexBuffersImplDelegate(IntPtr @this);

		// Token: 0x020007C6 RID: 1990
		// (Invoke) Token: 0x06003825 RID: 14373
		private delegate void OptimizeReorderVertexBufferImplDelegate(IntPtr @this);

		// Token: 0x020007C7 RID: 1991
		// (Invoke) Token: 0x06003827 RID: 14375
		private delegate void GetVertexAttribute_InjectedDelegate(IntPtr @this, int index, [Out] IntPtr ret);
	}
}
