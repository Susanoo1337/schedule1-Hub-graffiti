using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	// Token: 0x02000217 RID: 535
	public sealed class BatchCullingContext : ValueType
	{
		// Token: 0x06002446 RID: 9286 RVA: 0x00091D30 File Offset: 0x0008FF30
		// Note: this type is marked as 'beforefieldinit'.
		static BatchCullingContext()
		{
			Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchCullingContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr);
			BatchCullingContext.NativeFieldInfoPtr_cullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "cullingPlanes");
			BatchCullingContext.NativeFieldInfoPtr_cullingSplits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "cullingSplits");
			BatchCullingContext.NativeFieldInfoPtr_lodParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "lodParameters");
			BatchCullingContext.NativeFieldInfoPtr_localToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "localToWorldMatrix");
			BatchCullingContext.NativeFieldInfoPtr_viewType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "viewType");
			BatchCullingContext.NativeFieldInfoPtr_projectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "projectionType");
			BatchCullingContext.NativeFieldInfoPtr_cullingFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "cullingFlags");
			BatchCullingContext.NativeFieldInfoPtr_viewID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "viewID");
			BatchCullingContext.NativeFieldInfoPtr_cullingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "cullingLayerMask");
			BatchCullingContext.NativeFieldInfoPtr_sceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "sceneCullingMask");
			BatchCullingContext.NativeFieldInfoPtr_isOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "isOrthographic");
			BatchCullingContext.NativeFieldInfoPtr_receiverPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "receiverPlaneOffset");
			BatchCullingContext.NativeFieldInfoPtr_receiverPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, "receiverPlaneCount");
			BatchCullingContext.NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_CullingSplit_LODParameters_Matrix4x4_BatchCullingViewType_BatchCullingProjectionType_BatchCullingFlags_UInt64_UInt32_UInt64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr, 100667209);
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x00091E78 File Offset: 0x00090078
		[CallerCount(0)]
		public unsafe BatchCullingContext(Unity.Collections.NativeArray<Plane> inCullingPlanes, Unity.Collections.NativeArray<CullingSplit> inCullingSplits, LODParameters inLodParameters, Matrix4x4 inLocalToWorldMatrix, BatchCullingViewType inViewType, BatchCullingProjectionType inProjectionType, BatchCullingFlags inBatchCullingFlags, ulong inViewID, uint inCullingLayerMask, ulong inSceneCullingMask, int inReceiverPlaneOffset, int inReceiverPlaneCount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inCullingPlanes));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inCullingSplits));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inLodParameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inLocalToWorldMatrix;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inViewType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inProjectionType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inBatchCullingFlags;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inViewID;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inCullingLayerMask;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inSceneCullingMask;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inReceiverPlaneOffset;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inReceiverPlaneCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchCullingContext.NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_CullingSplit_LODParameters_Matrix4x4_BatchCullingViewType_BatchCullingProjectionType_BatchCullingFlags_UInt64_UInt32_UInt64_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x00010B9E File Offset: 0x0000ED9E
		public BatchCullingContext(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x00010BA7 File Offset: 0x0000EDA7
		public BatchCullingContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchCullingContext>.NativeClassPtr))
		{
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x00091F74 File Offset: 0x00090174
		// (set) Token: 0x0600244B RID: 9291 RVA: 0x00010BB9 File Offset: 0x0000EDB9
		public Unity.Collections.NativeArray<Plane> cullingPlanes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingPlanes);
				return new Unity.Collections.NativeArray<Plane>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<Plane>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingPlanes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<Plane>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x00091FA4 File Offset: 0x000901A4
		// (set) Token: 0x0600244D RID: 9293 RVA: 0x00010BE7 File Offset: 0x0000EDE7
		public Unity.Collections.NativeArray<CullingSplit> cullingSplits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingSplits);
				return new Unity.Collections.NativeArray<CullingSplit>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<CullingSplit>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingSplits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<CullingSplit>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x0600244E RID: 9294 RVA: 0x00091FD4 File Offset: 0x000901D4
		// (set) Token: 0x0600244F RID: 9295 RVA: 0x00010C15 File Offset: 0x0000EE15
		public unsafe LODParameters lodParameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_lodParameters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_lodParameters)) = value;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06002450 RID: 9296 RVA: 0x00091FFC File Offset: 0x000901FC
		// (set) Token: 0x06002451 RID: 9297 RVA: 0x00010C30 File Offset: 0x0000EE30
		public unsafe Matrix4x4 localToWorldMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_localToWorldMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_localToWorldMatrix)) = value;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06002452 RID: 9298 RVA: 0x00092024 File Offset: 0x00090224
		// (set) Token: 0x06002453 RID: 9299 RVA: 0x00010C4B File Offset: 0x0000EE4B
		public unsafe BatchCullingViewType viewType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_viewType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_viewType)) = value;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06002454 RID: 9300 RVA: 0x0009204C File Offset: 0x0009024C
		// (set) Token: 0x06002455 RID: 9301 RVA: 0x00010C66 File Offset: 0x0000EE66
		public unsafe BatchCullingProjectionType projectionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_projectionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_projectionType)) = value;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06002456 RID: 9302 RVA: 0x00092074 File Offset: 0x00090274
		// (set) Token: 0x06002457 RID: 9303 RVA: 0x00010C81 File Offset: 0x0000EE81
		public unsafe BatchCullingFlags cullingFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingFlags)) = value;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06002458 RID: 9304 RVA: 0x0009209C File Offset: 0x0009029C
		// (set) Token: 0x06002459 RID: 9305 RVA: 0x00010C9C File Offset: 0x0000EE9C
		public unsafe BatchPackedCullingViewID viewID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_viewID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_viewID)) = value;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600245A RID: 9306 RVA: 0x000920C4 File Offset: 0x000902C4
		// (set) Token: 0x0600245B RID: 9307 RVA: 0x00010CB7 File Offset: 0x0000EEB7
		public unsafe uint cullingLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_cullingLayerMask)) = value;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x0600245C RID: 9308 RVA: 0x000920EC File Offset: 0x000902EC
		// (set) Token: 0x0600245D RID: 9309 RVA: 0x00010CD2 File Offset: 0x0000EED2
		public unsafe ulong sceneCullingMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_sceneCullingMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_sceneCullingMask)) = value;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x0600245E RID: 9310 RVA: 0x00092114 File Offset: 0x00090314
		// (set) Token: 0x0600245F RID: 9311 RVA: 0x00010CED File Offset: 0x0000EEED
		public unsafe byte isOrthographic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_isOrthographic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_isOrthographic)) = value;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x0009213C File Offset: 0x0009033C
		// (set) Token: 0x06002461 RID: 9313 RVA: 0x00010D08 File Offset: 0x0000EF08
		public unsafe int receiverPlaneOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_receiverPlaneOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_receiverPlaneOffset)) = value;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06002462 RID: 9314 RVA: 0x00092164 File Offset: 0x00090364
		// (set) Token: 0x06002463 RID: 9315 RVA: 0x00010D23 File Offset: 0x0000EF23
		public unsafe int receiverPlaneCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_receiverPlaneCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchCullingContext.NativeFieldInfoPtr_receiverPlaneCount)) = value;
			}
		}

		// Token: 0x04001E7D RID: 7805
		private static readonly IntPtr NativeFieldInfoPtr_cullingPlanes;

		// Token: 0x04001E7E RID: 7806
		private static readonly IntPtr NativeFieldInfoPtr_cullingSplits;

		// Token: 0x04001E7F RID: 7807
		private static readonly IntPtr NativeFieldInfoPtr_lodParameters;

		// Token: 0x04001E80 RID: 7808
		private static readonly IntPtr NativeFieldInfoPtr_localToWorldMatrix;

		// Token: 0x04001E81 RID: 7809
		private static readonly IntPtr NativeFieldInfoPtr_viewType;

		// Token: 0x04001E82 RID: 7810
		private static readonly IntPtr NativeFieldInfoPtr_projectionType;

		// Token: 0x04001E83 RID: 7811
		private static readonly IntPtr NativeFieldInfoPtr_cullingFlags;

		// Token: 0x04001E84 RID: 7812
		private static readonly IntPtr NativeFieldInfoPtr_viewID;

		// Token: 0x04001E85 RID: 7813
		private static readonly IntPtr NativeFieldInfoPtr_cullingLayerMask;

		// Token: 0x04001E86 RID: 7814
		private static readonly IntPtr NativeFieldInfoPtr_sceneCullingMask;

		// Token: 0x04001E87 RID: 7815
		private static readonly IntPtr NativeFieldInfoPtr_isOrthographic;

		// Token: 0x04001E88 RID: 7816
		private static readonly IntPtr NativeFieldInfoPtr_receiverPlaneOffset;

		// Token: 0x04001E89 RID: 7817
		private static readonly IntPtr NativeFieldInfoPtr_receiverPlaneCount;

		// Token: 0x04001E8A RID: 7818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_NativeArray_1_Plane_NativeArray_1_CullingSplit_LODParameters_Matrix4x4_BatchCullingViewType_BatchCullingProjectionType_BatchCullingFlags_UInt64_UInt32_UInt64_Int32_Int32_0;
	}
}
