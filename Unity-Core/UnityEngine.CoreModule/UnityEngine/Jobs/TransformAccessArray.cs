using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Jobs
{
	// Token: 0x02000185 RID: 389
	[StructLayout(2)]
	public struct TransformAccessArray
	{
		// Token: 0x06001E00 RID: 7680 RVA: 0x0007A6F8 File Offset: 0x000788F8
		// Note: this type is marked as 'beforefieldinit'.
		static TransformAccessArray()
		{
			Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Jobs", "TransformAccessArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr);
			TransformAccessArray.NativeFieldInfoPtr_m_TransformArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, "m_TransformArray");
			TransformAccessArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100666491);
			TransformAccessArray.NativeMethodInfoPtr_Allocate_Public_Static_Void_Int32_Int32_byref_TransformAccessArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100666492);
			TransformAccessArray.NativeMethodInfoPtr_get_isCreated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100666493);
			TransformAccessArray.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100666494);
			TransformAccessArray.NativeMethodInfoPtr_GetTransformAccessArrayForSchedule_Internal_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100666495);
			TransformAccessArray.NativeMethodInfoPtr_get_Item_Public_get_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100666496);
			TransformAccessArray.NativeMethodInfoPtr_get_length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100666497);
			TransformAccessArray.NativeMethodInfoPtr_Add_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100666498);
			TransformAccessArray.NativeMethodInfoPtr_RemoveAtSwapBack_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100666499);
			TransformAccessArray.NativeMethodInfoPtr_Create_Private_Static_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100666500);
			TransformAccessArray.NativeMethodInfoPtr_DestroyTransformAccessArray_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100666501);
			TransformAccessArray.NativeMethodInfoPtr_Add_Private_Static_Void_IntPtr_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100666502);
			TransformAccessArray.NativeMethodInfoPtr_RemoveAtSwapBack_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100666503);
			TransformAccessArray.NativeMethodInfoPtr_GetSortedTransformAccess_Internal_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100666504);
			TransformAccessArray.NativeMethodInfoPtr_GetSortedToUserIndex_Internal_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100666505);
			TransformAccessArray.NativeMethodInfoPtr_GetLength_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100666506);
			TransformAccessArray.NativeMethodInfoPtr_GetTransform_Internal_Static_Transform_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100666507);
			TransformAccessArray.SetTransformsDelegateField = IL2CPP.ResolveICall<TransformAccessArray.SetTransformsDelegate>("UnityEngine.Jobs.TransformAccessArray::SetTransforms");
			TransformAccessArray.AddInstanceIdDelegateField = IL2CPP.ResolveICall<TransformAccessArray.AddInstanceIdDelegate>("UnityEngine.Jobs.TransformAccessArray::AddInstanceId");
			TransformAccessArray.GetCapacityDelegateField = IL2CPP.ResolveICall<TransformAccessArray.GetCapacityDelegate>("UnityEngine.Jobs.TransformAccessArray::GetCapacity");
			TransformAccessArray.SetCapacityDelegateField = IL2CPP.ResolveICall<TransformAccessArray.SetCapacityDelegate>("UnityEngine.Jobs.TransformAccessArray::SetCapacity");
			TransformAccessArray.SetTransformDelegateField = IL2CPP.ResolveICall<TransformAccessArray.SetTransformDelegate>("UnityEngine.Jobs.TransformAccessArray::SetTransform");
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x0007A8DC File Offset: 0x00078ADC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1282503, RefRangeEnd = 1282506, XrefRangeStart = 1282500, XrefRangeEnd = 1282503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransformAccessArray(int capacity, int desiredJobCount = -1)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capacity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredJobCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x0007A91C File Offset: 0x00078B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282506, XrefRangeEnd = 1282509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Allocate(int capacity, int desiredJobCount, out TransformAccessArray array)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capacity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredJobCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &array;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_Allocate_Public_Static_Void_Int32_Int32_byref_TransformAccessArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x0007A96C File Offset: 0x00078B6C
		public unsafe bool isCreated
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1282510, RefRangeEnd = 1282513, XrefRangeStart = 1282509, XrefRangeEnd = 1282510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_get_isCreated_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x0007A99C File Offset: 0x00078B9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1282516, RefRangeEnd = 1282520, XrefRangeStart = 1282513, XrefRangeEnd = 1282516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x0007A9C4 File Offset: 0x00078BC4
		[CallerCount(163)]
		[CachedScanResults(RefRangeStart = 532930, RefRangeEnd = 533093, XrefRangeStart = 532930, XrefRangeEnd = 533093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetTransformAccessArrayForSchedule()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_GetTransformAccessArrayForSchedule_Internal_IntPtr_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700065B RID: 1627
		public unsafe Transform this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1282522, RefRangeEnd = 1282523, XrefRangeStart = 1282520, XrefRangeEnd = 1282522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_get_Item_Public_get_Transform_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			set
			{
				TransformAccessArray.SetTransform(this.m_TransformArray, index, value);
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x0007AA34 File Offset: 0x00078C34
		public unsafe int length
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1282525, RefRangeEnd = 1282531, XrefRangeStart = 1282523, XrefRangeEnd = 1282525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_get_length_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x0007AA64 File Offset: 0x00078C64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1282533, RefRangeEnd = 1282537, XrefRangeStart = 1282531, XrefRangeEnd = 1282533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Transform transform)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_Add_Public_Void_Transform_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x0007AA9C File Offset: 0x00078C9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1282539, RefRangeEnd = 1282540, XrefRangeStart = 1282537, XrefRangeEnd = 1282539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAtSwapBack(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_RemoveAtSwapBack_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x0007AAD0 File Offset: 0x00078CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282540, XrefRangeEnd = 1282542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Create(int capacity, int desiredJobCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capacity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredJobCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_Create_Private_Static_IntPtr_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x0007AB1C File Offset: 0x00078D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282542, XrefRangeEnd = 1282544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyTransformAccessArray(IntPtr transformArray)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref transformArray;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_DestroyTransformAccessArray_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x0007AB50 File Offset: 0x00078D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282544, XrefRangeEnd = 1282546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Add(IntPtr transformArrayIntPtr, Transform transform)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref transformArrayIntPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_Add_Private_Static_Void_IntPtr_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x0007AB94 File Offset: 0x00078D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282546, XrefRangeEnd = 1282548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveAtSwapBack(IntPtr transformArrayIntPtr, int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref transformArrayIntPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_RemoveAtSwapBack_Private_Static_Void_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x0007ABD4 File Offset: 0x00078DD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1282550, RefRangeEnd = 1282551, XrefRangeStart = 1282548, XrefRangeEnd = 1282550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSortedTransformAccess(IntPtr transformArrayIntPtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref transformArrayIntPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_GetSortedTransformAccess_Internal_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x0007AC14 File Offset: 0x00078E14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1282553, RefRangeEnd = 1282554, XrefRangeStart = 1282551, XrefRangeEnd = 1282553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSortedToUserIndex(IntPtr transformArrayIntPtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref transformArrayIntPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_GetSortedToUserIndex_Internal_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x0007AC54 File Offset: 0x00078E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282554, XrefRangeEnd = 1282556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLength(IntPtr transformArrayIntPtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref transformArrayIntPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_GetLength_Internal_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x0007AC94 File Offset: 0x00078E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282556, XrefRangeEnd = 1282558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform GetTransform(IntPtr transformArrayIntPtr, int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref transformArrayIntPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_GetTransform_Internal_Static_Transform_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x0000E203 File Offset: 0x0000C403
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, ref this));
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x0007ACE4 File Offset: 0x00078EE4
		// (set) Token: 0x06001E15 RID: 7701 RVA: 0x0000E226 File Offset: 0x0000C426
		public int capacity
		{
			get
			{
				return TransformAccessArray.GetCapacity(this.m_TransformArray);
			}
			set
			{
				TransformAccessArray.SetCapacity(this.m_TransformArray, value);
			}
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x0000E236 File Offset: 0x0000C436
		public void Add(int instanceId)
		{
			TransformAccessArray.AddInstanceId(this.m_TransformArray, instanceId);
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x0000E246 File Offset: 0x0000C446
		public void SetTransforms(Il2CppReferenceArray<Transform> transforms)
		{
			TransformAccessArray.SetTransforms(this.m_TransformArray, transforms);
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x0000E256 File Offset: 0x0000C456
		public static void SetTransforms(IntPtr transformArrayIntPtr, Il2CppReferenceArray<Transform> transforms)
		{
			TransformAccessArray.SetTransformsDelegateField(transformArrayIntPtr, IL2CPP.Il2CppObjectBaseToPtr(transforms));
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x0000E269 File Offset: 0x0000C469
		public static void AddInstanceId(IntPtr transformArrayIntPtr, int instanceId)
		{
			TransformAccessArray.AddInstanceIdDelegateField(transformArrayIntPtr, instanceId);
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x0000E277 File Offset: 0x0000C477
		public static int GetCapacity(IntPtr transformArrayIntPtr)
		{
			return TransformAccessArray.GetCapacityDelegateField(transformArrayIntPtr);
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x0000E284 File Offset: 0x0000C484
		public static void SetCapacity(IntPtr transformArrayIntPtr, int capacity)
		{
			TransformAccessArray.SetCapacityDelegateField(transformArrayIntPtr, capacity);
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x0000E292 File Offset: 0x0000C492
		public static void SetTransform(IntPtr transformArrayIntPtr, int index, Transform transform)
		{
			TransformAccessArray.SetTransformDelegateField(transformArrayIntPtr, index, IL2CPP.Il2CppObjectBaseToPtr(transform));
		}

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeFieldInfoPtr_m_TransformArray;

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Public_Static_Void_Int32_Int32_byref_TransformAccessArray_0;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeMethodInfoPtr_get_isCreated_Public_get_Boolean_0;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001874 RID: 6260
		private static readonly IntPtr NativeMethodInfoPtr_GetTransformAccessArrayForSchedule_Internal_IntPtr_0;

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Transform_Int32_0;

		// Token: 0x04001876 RID: 6262
		private static readonly IntPtr NativeMethodInfoPtr_get_length_Public_get_Int32_0;

		// Token: 0x04001877 RID: 6263
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Transform_0;

		// Token: 0x04001878 RID: 6264
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAtSwapBack_Public_Void_Int32_0;

		// Token: 0x04001879 RID: 6265
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_IntPtr_Int32_Int32_0;

		// Token: 0x0400187A RID: 6266
		private static readonly IntPtr NativeMethodInfoPtr_DestroyTransformAccessArray_Private_Static_Void_IntPtr_0;

		// Token: 0x0400187B RID: 6267
		private static readonly IntPtr NativeMethodInfoPtr_Add_Private_Static_Void_IntPtr_Transform_0;

		// Token: 0x0400187C RID: 6268
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAtSwapBack_Private_Static_Void_IntPtr_Int32_0;

		// Token: 0x0400187D RID: 6269
		private static readonly IntPtr NativeMethodInfoPtr_GetSortedTransformAccess_Internal_Static_IntPtr_IntPtr_0;

		// Token: 0x0400187E RID: 6270
		private static readonly IntPtr NativeMethodInfoPtr_GetSortedToUserIndex_Internal_Static_IntPtr_IntPtr_0;

		// Token: 0x0400187F RID: 6271
		private static readonly IntPtr NativeMethodInfoPtr_GetLength_Internal_Static_Int32_IntPtr_0;

		// Token: 0x04001880 RID: 6272
		private static readonly IntPtr NativeMethodInfoPtr_GetTransform_Internal_Static_Transform_IntPtr_Int32_0;

		// Token: 0x04001881 RID: 6273
		[FieldOffset(0)]
		public IntPtr m_TransformArray;

		// Token: 0x04001882 RID: 6274
		private static readonly TransformAccessArray.SetTransformsDelegate SetTransformsDelegateField;

		// Token: 0x04001883 RID: 6275
		private static readonly TransformAccessArray.AddInstanceIdDelegate AddInstanceIdDelegateField;

		// Token: 0x04001884 RID: 6276
		private static readonly TransformAccessArray.GetCapacityDelegate GetCapacityDelegateField;

		// Token: 0x04001885 RID: 6277
		private static readonly TransformAccessArray.SetCapacityDelegate SetCapacityDelegateField;

		// Token: 0x04001886 RID: 6278
		private static readonly TransformAccessArray.SetTransformDelegate SetTransformDelegateField;

		// Token: 0x020009FF RID: 2559
		// (Invoke) Token: 0x06003C7F RID: 15487
		private delegate void SetTransformsDelegate(IntPtr transformArrayIntPtr, IntPtr transforms);

		// Token: 0x02000A00 RID: 2560
		// (Invoke) Token: 0x06003C81 RID: 15489
		private delegate void AddInstanceIdDelegate(IntPtr transformArrayIntPtr, int instanceId);

		// Token: 0x02000A01 RID: 2561
		// (Invoke) Token: 0x06003C83 RID: 15491
		private delegate int GetCapacityDelegate(IntPtr transformArrayIntPtr);

		// Token: 0x02000A02 RID: 2562
		// (Invoke) Token: 0x06003C85 RID: 15493
		private delegate void SetCapacityDelegate(IntPtr transformArrayIntPtr, int capacity);

		// Token: 0x02000A03 RID: 2563
		// (Invoke) Token: 0x06003C87 RID: 15495
		private delegate void SetTransformDelegate(IntPtr transformArrayIntPtr, int index, IntPtr transform);
	}
}
