using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Development.Experimental.OcclusionCulling
{
	// Token: 0x0200070B RID: 1803
	public class OcclusionObject : MonoBehaviour
	{
		// Token: 0x0600ADE8 RID: 44520 RVA: 0x002DA764 File Offset: 0x002D8964
		// Note: this type is marked as 'beforefieldinit'.
		static OcclusionObject()
		{
			Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Development.Experimental.OcclusionCulling", "OcclusionObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr);
			OcclusionObject.NativeFieldInfoPtr_cubeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, "cubeSize");
			OcclusionObject.NativeFieldInfoPtr__includeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, "_includeLeft");
			OcclusionObject.NativeFieldInfoPtr__includeRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, "_includeRight");
			OcclusionObject.NativeFieldInfoPtr__includeTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, "_includeTop");
			OcclusionObject.NativeFieldInfoPtr__includeBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, "_includeBottom");
			OcclusionObject.NativeFieldInfoPtr__includeFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, "_includeFront");
			OcclusionObject.NativeFieldInfoPtr__includeBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, "_includeBack");
			OcclusionObject.NativeFieldInfoPtr__lodGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, "_lodGroups");
			OcclusionObject.NativeFieldInfoPtr__meshRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, "_meshRenderers");
			OcclusionObject.NativeFieldInfoPtr_subdivisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, "subdivisions");
			OcclusionObject.NativeFieldInfoPtr_gizmoSphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, "gizmoSphereRadius");
			OcclusionObject.NativeFieldInfoPtr_centerColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, "centerColor");
			OcclusionObject.NativeFieldInfoPtr_boundsColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, "boundsColor");
			OcclusionObject.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, "_isActive");
			OcclusionObject.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, 100686216);
			OcclusionObject.NativeMethodInfoPtr_get_Subdivisions_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, 100686217);
			OcclusionObject.NativeMethodInfoPtr_get_IncludeLeft_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, 100686218);
			OcclusionObject.NativeMethodInfoPtr_get_IncludeRight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, 100686219);
			OcclusionObject.NativeMethodInfoPtr_get_IncludeTop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, 100686220);
			OcclusionObject.NativeMethodInfoPtr_get_IncludeBottom_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, 100686221);
			OcclusionObject.NativeMethodInfoPtr_get_IncludeFront_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, 100686222);
			OcclusionObject.NativeMethodInfoPtr_get_IncludeBack_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, 100686223);
			OcclusionObject.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, 100686224);
			OcclusionObject.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, 100686225);
			OcclusionObject.NativeMethodInfoPtr_DrawFaceChunks_Private_Void_Vector3_Vector3_Vector3_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, 100686226);
			OcclusionObject.NativeMethodInfoPtr_GetCornerPositions_Public_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, 100686227);
			OcclusionObject.NativeMethodInfoPtr_GetNumberOfVertices_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, 100686228);
			OcclusionObject.NativeMethodInfoPtr_SetObjectOcclusion_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, 100686229);
			OcclusionObject.NativeMethodInfoPtr_SetActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, 100686230);
			OcclusionObject.NativeMethodInfoPtr_CalculateNumberOfVertices_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, 100686231);
			OcclusionObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr, 100686232);
		}

		// Token: 0x17003438 RID: 13368
		// (get) Token: 0x0600ADE9 RID: 44521 RVA: 0x002DAA00 File Offset: 0x002D8C00
		public unsafe Vector3 Size
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionObject.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003439 RID: 13369
		// (get) Token: 0x0600ADEA RID: 44522 RVA: 0x002DAA3C File Offset: 0x002D8C3C
		public unsafe int Subdivisions
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 38121, RefRangeEnd = 38127, XrefRangeStart = 38121, XrefRangeEnd = 38127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionObject.NativeMethodInfoPtr_get_Subdivisions_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700343A RID: 13370
		// (get) Token: 0x0600ADEB RID: 44523 RVA: 0x002DAA78 File Offset: 0x002D8C78
		public unsafe bool IncludeLeft
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionObject.NativeMethodInfoPtr_get_IncludeLeft_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700343B RID: 13371
		// (get) Token: 0x0600ADEC RID: 44524 RVA: 0x002DAAB4 File Offset: 0x002D8CB4
		public unsafe bool IncludeRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionObject.NativeMethodInfoPtr_get_IncludeRight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700343C RID: 13372
		// (get) Token: 0x0600ADED RID: 44525 RVA: 0x002DAAF0 File Offset: 0x002D8CF0
		public unsafe bool IncludeTop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionObject.NativeMethodInfoPtr_get_IncludeTop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700343D RID: 13373
		// (get) Token: 0x0600ADEE RID: 44526 RVA: 0x002DAB2C File Offset: 0x002D8D2C
		public unsafe bool IncludeBottom
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionObject.NativeMethodInfoPtr_get_IncludeBottom_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700343E RID: 13374
		// (get) Token: 0x0600ADEF RID: 44527 RVA: 0x002DAB68 File Offset: 0x002D8D68
		public unsafe bool IncludeFront
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionObject.NativeMethodInfoPtr_get_IncludeFront_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700343F RID: 13375
		// (get) Token: 0x0600ADF0 RID: 44528 RVA: 0x002DABA4 File Offset: 0x002D8DA4
		public unsafe bool IncludeBack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionObject.NativeMethodInfoPtr_get_IncludeBack_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600ADF1 RID: 44529 RVA: 0x002DABE0 File Offset: 0x002D8DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297619, XrefRangeEnd = 297620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionObject.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADF2 RID: 44530 RVA: 0x002DAC14 File Offset: 0x002D8E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297620, XrefRangeEnd = 297676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionObject.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADF3 RID: 44531 RVA: 0x002DAC48 File Offset: 0x002D8E48
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 297680, RefRangeEnd = 297686, XrefRangeStart = 297676, XrefRangeEnd = 297680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawFaceChunks(Vector3 localNormal, Vector3 localAxisU, Vector3 localAxisV, float sizeNormal, float sizeU, float sizeV, int N)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref localNormal;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localAxisU;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localAxisV;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeNormal;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeU;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeV;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref N;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionObject.NativeMethodInfoPtr_DrawFaceChunks_Private_Void_Vector3_Vector3_Vector3_Single_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADF4 RID: 44532 RVA: 0x002DACDC File Offset: 0x002D8EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 297729, RefRangeEnd = 297730, XrefRangeStart = 297686, XrefRangeEnd = 297729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Vector3> GetCornerPositions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionObject.NativeMethodInfoPtr_GetCornerPositions_Public_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600ADF5 RID: 44533 RVA: 0x002DAD1C File Offset: 0x002D8F1C
		[CallerCount(0)]
		public unsafe int GetNumberOfVertices(int subdivisions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref subdivisions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionObject.NativeMethodInfoPtr_GetNumberOfVertices_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ADF6 RID: 44534 RVA: 0x002DAD68 File Offset: 0x002D8F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297730, XrefRangeEnd = 297731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObjectOcclusion(bool isActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionObject.NativeMethodInfoPtr_SetObjectOcclusion_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADF7 RID: 44535 RVA: 0x002DADA8 File Offset: 0x002D8FA8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 297763, RefRangeEnd = 297768, XrefRangeStart = 297731, XrefRangeEnd = 297763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool isActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionObject.NativeMethodInfoPtr_SetActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADF8 RID: 44536 RVA: 0x002DADE8 File Offset: 0x002D8FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297768, XrefRangeEnd = 297776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateNumberOfVertices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionObject.NativeMethodInfoPtr_CalculateNumberOfVertices_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADF9 RID: 44537 RVA: 0x002DAE1C File Offset: 0x002D901C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297776, XrefRangeEnd = 297779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OcclusionObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OcclusionObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADFA RID: 44538 RVA: 0x0004F9E9 File Offset: 0x0004DBE9
		public OcclusionObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700342A RID: 13354
		// (get) Token: 0x0600ADFB RID: 44539 RVA: 0x002DAE58 File Offset: 0x002D9058
		// (set) Token: 0x0600ADFC RID: 44540 RVA: 0x0004F9F2 File Offset: 0x0004DBF2
		public unsafe Vector3 cubeSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr_cubeSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr_cubeSize)) = value;
			}
		}

		// Token: 0x1700342B RID: 13355
		// (get) Token: 0x0600ADFD RID: 44541 RVA: 0x002DAE80 File Offset: 0x002D9080
		// (set) Token: 0x0600ADFE RID: 44542 RVA: 0x0004FA0D File Offset: 0x0004DC0D
		public unsafe bool _includeLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__includeLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__includeLeft)) = value;
			}
		}

		// Token: 0x1700342C RID: 13356
		// (get) Token: 0x0600ADFF RID: 44543 RVA: 0x002DAEA8 File Offset: 0x002D90A8
		// (set) Token: 0x0600AE00 RID: 44544 RVA: 0x0004FA28 File Offset: 0x0004DC28
		public unsafe bool _includeRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__includeRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__includeRight)) = value;
			}
		}

		// Token: 0x1700342D RID: 13357
		// (get) Token: 0x0600AE01 RID: 44545 RVA: 0x002DAED0 File Offset: 0x002D90D0
		// (set) Token: 0x0600AE02 RID: 44546 RVA: 0x0004FA43 File Offset: 0x0004DC43
		public unsafe bool _includeTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__includeTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__includeTop)) = value;
			}
		}

		// Token: 0x1700342E RID: 13358
		// (get) Token: 0x0600AE03 RID: 44547 RVA: 0x002DAEF8 File Offset: 0x002D90F8
		// (set) Token: 0x0600AE04 RID: 44548 RVA: 0x0004FA5E File Offset: 0x0004DC5E
		public unsafe bool _includeBottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__includeBottom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__includeBottom)) = value;
			}
		}

		// Token: 0x1700342F RID: 13359
		// (get) Token: 0x0600AE05 RID: 44549 RVA: 0x002DAF20 File Offset: 0x002D9120
		// (set) Token: 0x0600AE06 RID: 44550 RVA: 0x0004FA79 File Offset: 0x0004DC79
		public unsafe bool _includeFront
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__includeFront);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__includeFront)) = value;
			}
		}

		// Token: 0x17003430 RID: 13360
		// (get) Token: 0x0600AE07 RID: 44551 RVA: 0x002DAF48 File Offset: 0x002D9148
		// (set) Token: 0x0600AE08 RID: 44552 RVA: 0x0004FA94 File Offset: 0x0004DC94
		public unsafe bool _includeBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__includeBack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__includeBack)) = value;
			}
		}

		// Token: 0x17003431 RID: 13361
		// (get) Token: 0x0600AE09 RID: 44553 RVA: 0x002DAF70 File Offset: 0x002D9170
		// (set) Token: 0x0600AE0A RID: 44554 RVA: 0x0004FAAF File Offset: 0x0004DCAF
		public unsafe List<LODGroup> _lodGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__lodGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LODGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__lodGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003432 RID: 13362
		// (get) Token: 0x0600AE0B RID: 44555 RVA: 0x002DAFA0 File Offset: 0x002D91A0
		// (set) Token: 0x0600AE0C RID: 44556 RVA: 0x0004FACE File Offset: 0x0004DCCE
		public unsafe List<MeshRenderer> _meshRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__meshRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__meshRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003433 RID: 13363
		// (get) Token: 0x0600AE0D RID: 44557 RVA: 0x002DAFD0 File Offset: 0x002D91D0
		// (set) Token: 0x0600AE0E RID: 44558 RVA: 0x0004FAED File Offset: 0x0004DCED
		public unsafe int subdivisions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr_subdivisions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr_subdivisions)) = value;
			}
		}

		// Token: 0x17003434 RID: 13364
		// (get) Token: 0x0600AE0F RID: 44559 RVA: 0x002DAFF8 File Offset: 0x002D91F8
		// (set) Token: 0x0600AE10 RID: 44560 RVA: 0x0004FB08 File Offset: 0x0004DD08
		public unsafe float gizmoSphereRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr_gizmoSphereRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr_gizmoSphereRadius)) = value;
			}
		}

		// Token: 0x17003435 RID: 13365
		// (get) Token: 0x0600AE11 RID: 44561 RVA: 0x002DB020 File Offset: 0x002D9220
		// (set) Token: 0x0600AE12 RID: 44562 RVA: 0x0004FB23 File Offset: 0x0004DD23
		public unsafe Color centerColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr_centerColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr_centerColor)) = value;
			}
		}

		// Token: 0x17003436 RID: 13366
		// (get) Token: 0x0600AE13 RID: 44563 RVA: 0x002DB048 File Offset: 0x002D9248
		// (set) Token: 0x0600AE14 RID: 44564 RVA: 0x0004FB3E File Offset: 0x0004DD3E
		public unsafe Color boundsColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr_boundsColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr_boundsColor)) = value;
			}
		}

		// Token: 0x17003437 RID: 13367
		// (get) Token: 0x0600AE15 RID: 44565 RVA: 0x002DB070 File Offset: 0x002D9270
		// (set) Token: 0x0600AE16 RID: 44566 RVA: 0x0004FB59 File Offset: 0x0004DD59
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionObject.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x0400780C RID: 30732
		private static readonly IntPtr NativeFieldInfoPtr_cubeSize;

		// Token: 0x0400780D RID: 30733
		private static readonly IntPtr NativeFieldInfoPtr__includeLeft;

		// Token: 0x0400780E RID: 30734
		private static readonly IntPtr NativeFieldInfoPtr__includeRight;

		// Token: 0x0400780F RID: 30735
		private static readonly IntPtr NativeFieldInfoPtr__includeTop;

		// Token: 0x04007810 RID: 30736
		private static readonly IntPtr NativeFieldInfoPtr__includeBottom;

		// Token: 0x04007811 RID: 30737
		private static readonly IntPtr NativeFieldInfoPtr__includeFront;

		// Token: 0x04007812 RID: 30738
		private static readonly IntPtr NativeFieldInfoPtr__includeBack;

		// Token: 0x04007813 RID: 30739
		private static readonly IntPtr NativeFieldInfoPtr__lodGroups;

		// Token: 0x04007814 RID: 30740
		private static readonly IntPtr NativeFieldInfoPtr__meshRenderers;

		// Token: 0x04007815 RID: 30741
		private static readonly IntPtr NativeFieldInfoPtr_subdivisions;

		// Token: 0x04007816 RID: 30742
		private static readonly IntPtr NativeFieldInfoPtr_gizmoSphereRadius;

		// Token: 0x04007817 RID: 30743
		private static readonly IntPtr NativeFieldInfoPtr_centerColor;

		// Token: 0x04007818 RID: 30744
		private static readonly IntPtr NativeFieldInfoPtr_boundsColor;

		// Token: 0x04007819 RID: 30745
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x0400781A RID: 30746
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Vector3_0;

		// Token: 0x0400781B RID: 30747
		private static readonly IntPtr NativeMethodInfoPtr_get_Subdivisions_Public_get_Int32_0;

		// Token: 0x0400781C RID: 30748
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeLeft_Public_get_Boolean_0;

		// Token: 0x0400781D RID: 30749
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeRight_Public_get_Boolean_0;

		// Token: 0x0400781E RID: 30750
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeTop_Public_get_Boolean_0;

		// Token: 0x0400781F RID: 30751
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeBottom_Public_get_Boolean_0;

		// Token: 0x04007820 RID: 30752
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeFront_Public_get_Boolean_0;

		// Token: 0x04007821 RID: 30753
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeBack_Public_get_Boolean_0;

		// Token: 0x04007822 RID: 30754
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007823 RID: 30755
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04007824 RID: 30756
		private static readonly IntPtr NativeMethodInfoPtr_DrawFaceChunks_Private_Void_Vector3_Vector3_Vector3_Single_Single_Single_Int32_0;

		// Token: 0x04007825 RID: 30757
		private static readonly IntPtr NativeMethodInfoPtr_GetCornerPositions_Public_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04007826 RID: 30758
		private static readonly IntPtr NativeMethodInfoPtr_GetNumberOfVertices_Public_Int32_Int32_0;

		// Token: 0x04007827 RID: 30759
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectOcclusion_Public_Void_Boolean_0;

		// Token: 0x04007828 RID: 30760
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Private_Void_Boolean_0;

		// Token: 0x04007829 RID: 30761
		private static readonly IntPtr NativeMethodInfoPtr_CalculateNumberOfVertices_Private_Void_0;

		// Token: 0x0400782A RID: 30762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
