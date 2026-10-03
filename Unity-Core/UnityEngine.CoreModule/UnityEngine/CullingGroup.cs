using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000079 RID: 121
	public class CullingGroup : Object
	{
		// Token: 0x0600053A RID: 1338 RVA: 0x000278D0 File Offset: 0x00025AD0
		// Note: this type is marked as 'beforefieldinit'.
		static CullingGroup()
		{
			Il2CppClassPointerStore<CullingGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CullingGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr);
			CullingGroup.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, "m_Ptr");
			CullingGroup.NativeFieldInfoPtr_m_OnStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, "m_OnStateChanged");
			CullingGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663839);
			CullingGroup.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663840);
			CullingGroup.NativeMethodInfoPtr_DisposeInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663841);
			CullingGroup.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663842);
			CullingGroup.NativeMethodInfoPtr_set_targetCamera_Public_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663843);
			CullingGroup.NativeMethodInfoPtr_SetBoundingSpheres_Public_Void_Il2CppStructArray_1_BoundingSphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663844);
			CullingGroup.NativeMethodInfoPtr_SetBoundingSphereCount_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663845);
			CullingGroup.NativeMethodInfoPtr_QueryIndices_Public_Int32_Boolean_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663846);
			CullingGroup.NativeMethodInfoPtr_QueryIndices_Private_Int32_Boolean_Int32_CullingQueryOptions_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663847);
			CullingGroup.NativeMethodInfoPtr_SetBoundingDistances_Public_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663848);
			CullingGroup.NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663849);
			CullingGroup.NativeMethodInfoPtr_SetDistanceReferencePoint_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663850);
			CullingGroup.NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663851);
			CullingGroup.NativeMethodInfoPtr_Init_Private_Static_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663852);
			CullingGroup.NativeMethodInfoPtr_FinalizerFailure_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663853);
			CullingGroup.NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100663854);
			CullingGroup.get_enabledDelegateField = IL2CPP.ResolveICall<CullingGroup.get_enabledDelegate>("UnityEngine.CullingGroup::get_enabled");
			CullingGroup.set_enabledDelegateField = IL2CPP.ResolveICall<CullingGroup.set_enabledDelegate>("UnityEngine.CullingGroup::set_enabled");
			CullingGroup.get_targetCameraDelegateField = IL2CPP.ResolveICall<CullingGroup.get_targetCameraDelegate>("UnityEngine.CullingGroup::get_targetCamera");
			CullingGroup.EraseSwapBackDelegateField = IL2CPP.ResolveICall<CullingGroup.EraseSwapBackDelegate>("UnityEngine.CullingGroup::EraseSwapBack");
			CullingGroup.IsVisibleDelegateField = IL2CPP.ResolveICall<CullingGroup.IsVisibleDelegate>("UnityEngine.CullingGroup::IsVisible");
			CullingGroup.GetDistanceDelegateField = IL2CPP.ResolveICall<CullingGroup.GetDistanceDelegate>("UnityEngine.CullingGroup::GetDistance");
			CullingGroup.SetDistanceReferencePoint_InternalTransformDelegateField = IL2CPP.ResolveICall<CullingGroup.SetDistanceReferencePoint_InternalTransformDelegate>("UnityEngine.CullingGroup::SetDistanceReferencePoint_InternalTransform");
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00027AD4 File Offset: 0x00025CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1229252, RefRangeEnd = 1229253, XrefRangeStart = 1229248, XrefRangeEnd = 1229252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CullingGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00027B10 File Offset: 0x00025D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229253, XrefRangeEnd = 1229259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CullingGroup.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00027B4C File Offset: 0x00025D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229259, XrefRangeEnd = 1229261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_DisposeInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00027B80 File Offset: 0x00025D80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1229263, RefRangeEnd = 1229264, XrefRangeStart = 1229261, XrefRangeEnd = 1229263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00027FB0 File Offset: 0x000261B0
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00027BB4 File Offset: 0x00025DB4
		public unsafe Camera targetCamera
		{
			get
			{
				IntPtr intPtr = CullingGroup.get_targetCameraDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1229266, RefRangeEnd = 1229268, XrefRangeStart = 1229264, XrefRangeEnd = 1229266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_set_targetCamera_Public_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00027BF8 File Offset: 0x00025DF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229270, RefRangeEnd = 1229272, XrefRangeStart = 1229268, XrefRangeEnd = 1229270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoundingSpheres(Il2CppStructArray<BoundingSphere> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_SetBoundingSpheres_Public_Void_Il2CppStructArray_1_BoundingSphere_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00027C3C File Offset: 0x00025E3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229274, RefRangeEnd = 1229276, XrefRangeStart = 1229272, XrefRangeEnd = 1229274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoundingSphereCount(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_SetBoundingSphereCount_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00027C7C File Offset: 0x00025E7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229278, RefRangeEnd = 1229280, XrefRangeStart = 1229276, XrefRangeEnd = 1229278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int QueryIndices(bool visible, Il2CppStructArray<int> result, int firstIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_QueryIndices_Public_Int32_Boolean_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00027CE8 File Offset: 0x00025EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229280, XrefRangeEnd = 1229282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int QueryIndices(bool visible, int distanceIndex, CullingQueryOptions options, Il2CppStructArray<int> result, int firstIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_QueryIndices_Private_Int32_Boolean_Int32_CullingQueryOptions_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00027D70 File Offset: 0x00025F70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229284, RefRangeEnd = 1229286, XrefRangeStart = 1229282, XrefRangeEnd = 1229284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoundingDistances(Il2CppStructArray<float> distances)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(distances);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_SetBoundingDistances_Public_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00027DB4 File Offset: 0x00025FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229286, XrefRangeEnd = 1229288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDistanceReferencePoint_InternalVector3(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00027DF4 File Offset: 0x00025FF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229290, RefRangeEnd = 1229292, XrefRangeStart = 1229288, XrefRangeEnd = 1229290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDistanceReferencePoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_SetDistanceReferencePoint_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00027E34 File Offset: 0x00026034
		[CallerCount(0)]
		public unsafe static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cullingGroup);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventsPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00027E88 File Offset: 0x00026088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229292, XrefRangeEnd = 1229294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Init(Object scripting)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(scripting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_Init_Private_Static_IntPtr_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00027ECC File Offset: 0x000260CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229294, XrefRangeEnd = 1229296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizerFailure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_FinalizerFailure_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00027F00 File Offset: 0x00026100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229296, XrefRangeEnd = 1229298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDistanceReferencePoint_InternalVector3_Injected(ref Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00004727 File Offset: 0x00002927
		public CullingGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00027F40 File Offset: 0x00026140
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x00004730 File Offset: 0x00002930
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00027F68 File Offset: 0x00026168
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x0000474B File Offset: 0x0000294B
		public unsafe CullingGroup.StateChanged m_OnStateChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_OnStateChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CullingGroup.StateChanged>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CullingGroup.NativeFieldInfoPtr_m_OnStateChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00027F98 File Offset: 0x00026198
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x0000476A File Offset: 0x0000296A
		public CullingGroup.StateChanged onStateChanged
		{
			get
			{
				return this.m_OnStateChanged;
			}
			set
			{
				this.m_OnStateChanged = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00004774 File Offset: 0x00002974
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x00004786 File Offset: 0x00002986
		public bool enabled
		{
			get
			{
				return CullingGroup.get_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CullingGroup.set_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00004799 File Offset: 0x00002999
		public void EraseSwapBack(int index)
		{
			CullingGroup.EraseSwapBackDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x000047AC File Offset: 0x000029AC
		public static void EraseSwapBack<T>(int index, Il2CppArrayBase<T> myArray, ref int size)
		{
			size--;
			myArray[index] = myArray[size];
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00027FDC File Offset: 0x000261DC
		public int QueryIndices(int distanceIndex, Il2CppStructArray<int> result, int firstIndex)
		{
			return this.QueryIndices(false, distanceIndex, CullingQueryOptions.IgnoreVisibility, result, firstIndex);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00027FFC File Offset: 0x000261FC
		public int QueryIndices(bool visible, int distanceIndex, Il2CppStructArray<int> result, int firstIndex)
		{
			return this.QueryIndices(visible, distanceIndex, CullingQueryOptions.Normal, result, firstIndex);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000047C4 File Offset: 0x000029C4
		public bool IsVisible(int index)
		{
			return CullingGroup.IsVisibleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000047D7 File Offset: 0x000029D7
		public int GetDistance(int index)
		{
			return CullingGroup.GetDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000047EA File Offset: 0x000029EA
		public void SetDistanceReferencePoint_InternalTransform(Transform transform)
		{
			CullingGroup.SetDistanceReferencePoint_InternalTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(transform));
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00004802 File Offset: 0x00002A02
		public void SetDistanceReferencePoint(Transform transform)
		{
			this.SetDistanceReferencePoint_InternalTransform(transform);
		}

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeFieldInfoPtr_m_OnStateChanged;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_DisposeInternal_Private_Void_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_set_targetCamera_Public_set_Void_Camera_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_SetBoundingSpheres_Public_Void_Il2CppStructArray_1_BoundingSphere_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_SetBoundingSphereCount_Public_Void_Int32_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_QueryIndices_Public_Int32_Boolean_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_QueryIndices_Private_Int32_Boolean_Int32_CullingQueryOptions_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_SetBoundingDistances_Public_Void_Il2CppStructArray_1_Single_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Private_Void_Vector3_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_SetDistanceReferencePoint_Public_Void_Vector3_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_IntPtr_Object_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr_FinalizerFailure_Private_Void_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x0400049F RID: 1183
		private static readonly CullingGroup.get_enabledDelegate get_enabledDelegateField;

		// Token: 0x040004A0 RID: 1184
		private static readonly CullingGroup.set_enabledDelegate set_enabledDelegateField;

		// Token: 0x040004A1 RID: 1185
		private static readonly CullingGroup.get_targetCameraDelegate get_targetCameraDelegateField;

		// Token: 0x040004A2 RID: 1186
		private static readonly CullingGroup.EraseSwapBackDelegate EraseSwapBackDelegateField;

		// Token: 0x040004A3 RID: 1187
		private static readonly CullingGroup.IsVisibleDelegate IsVisibleDelegateField;

		// Token: 0x040004A4 RID: 1188
		private static readonly CullingGroup.GetDistanceDelegate GetDistanceDelegateField;

		// Token: 0x040004A5 RID: 1189
		private static readonly CullingGroup.SetDistanceReferencePoint_InternalTransformDelegate SetDistanceReferencePoint_InternalTransformDelegateField;

		// Token: 0x0200048F RID: 1167
		public sealed class StateChanged : MulticastDelegate
		{
			// Token: 0x060031BE RID: 12734 RVA: 0x00015AD1 File Offset: 0x00013CD1
			// Note: this type is marked as 'beforefieldinit'.
			static StateChanged()
			{
				Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, "StateChanged");
				CullingGroup.StateChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr, 100663855);
				CullingGroup.StateChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr, 100663856);
			}

			// Token: 0x060031BF RID: 12735 RVA: 0x000B008C File Offset: 0x000AE28C
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 1229217, RefRangeEnd = 1229248, XrefRangeStart = 1229214, XrefRangeEnd = 1229217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StateChanged(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CullingGroup.StateChanged>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.StateChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031C0 RID: 12736 RVA: 0x000B00E8 File Offset: 0x000AE2E8
			[CallerCount(0)]
			public unsafe void Invoke(CullingGroupEvent sphere)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref sphere;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingGroup.StateChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031C1 RID: 12737 RVA: 0x00015B0F File Offset: 0x00013D0F
			public StateChanged(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060031C2 RID: 12738 RVA: 0x00015B18 File Offset: 0x00013D18
			public static implicit operator CullingGroup.StateChanged(Action<CullingGroupEvent> A_0)
			{
				return DelegateSupport.ConvertDelegate<CullingGroup.StateChanged>(A_0);
			}

			// Token: 0x060031C3 RID: 12739 RVA: 0x00015B20 File Offset: 0x00013D20
			public static CullingGroup.StateChanged operator +(CullingGroup.StateChanged A_0, CullingGroup.StateChanged A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<CullingGroup.StateChanged>();
			}

			// Token: 0x060031C4 RID: 12740 RVA: 0x00015B2E File Offset: 0x00013D2E
			public static CullingGroup.StateChanged operator -(CullingGroup.StateChanged A_0, CullingGroup.StateChanged A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<CullingGroup.StateChanged>();
				}
				return result;
			}

			// Token: 0x04002A5C RID: 10844
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002A5D RID: 10845
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0;
		}

		// Token: 0x02000490 RID: 1168
		// (Invoke) Token: 0x060031C6 RID: 12742
		private delegate bool get_enabledDelegate(IntPtr @this);

		// Token: 0x02000491 RID: 1169
		// (Invoke) Token: 0x060031C8 RID: 12744
		private delegate void set_enabledDelegate(IntPtr @this, bool value);

		// Token: 0x02000492 RID: 1170
		// (Invoke) Token: 0x060031CA RID: 12746
		private delegate IntPtr get_targetCameraDelegate(IntPtr @this);

		// Token: 0x02000493 RID: 1171
		// (Invoke) Token: 0x060031CC RID: 12748
		private delegate void EraseSwapBackDelegate(IntPtr @this, int index);

		// Token: 0x02000494 RID: 1172
		// (Invoke) Token: 0x060031CE RID: 12750
		private delegate bool IsVisibleDelegate(IntPtr @this, int index);

		// Token: 0x02000495 RID: 1173
		// (Invoke) Token: 0x060031D0 RID: 12752
		private delegate int GetDistanceDelegate(IntPtr @this, int index);

		// Token: 0x02000496 RID: 1174
		// (Invoke) Token: 0x060031D2 RID: 12754
		private delegate void SetDistanceReferencePoint_InternalTransformDelegate(IntPtr @this, IntPtr transform);
	}
}
