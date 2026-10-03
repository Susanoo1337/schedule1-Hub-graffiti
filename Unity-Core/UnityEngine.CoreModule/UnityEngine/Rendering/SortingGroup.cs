using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000249 RID: 585
	public sealed class SortingGroup : Behaviour
	{
		// Token: 0x060028A8 RID: 10408 RVA: 0x0009F268 File Offset: 0x0009D468
		// Note: this type is marked as 'beforefieldinit'.
		static SortingGroup()
		{
			Il2CppClassPointerStore<SortingGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SortingGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr);
			SortingGroup.NativeMethodInfoPtr_get_invalidSortingGroupID_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100667641);
			SortingGroup.NativeMethodInfoPtr_GetSortingGroupByIndex_Internal_Static_SortingGroup_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100667642);
			SortingGroup.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100667643);
			SortingGroup.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100667644);
			SortingGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr, 100667645);
			SortingGroup.UpdateAllSortingGroupsDelegateField = IL2CPP.ResolveICall<SortingGroup.UpdateAllSortingGroupsDelegate>("UnityEngine.Rendering.SortingGroup::UpdateAllSortingGroups");
			SortingGroup.get_sortingLayerNameDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortingLayerNameDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingLayerName");
			SortingGroup.set_sortingLayerNameDelegateField = IL2CPP.ResolveICall<SortingGroup.set_sortingLayerNameDelegate>("UnityEngine.Rendering.SortingGroup::set_sortingLayerName");
			SortingGroup.set_sortingLayerIDDelegateField = IL2CPP.ResolveICall<SortingGroup.set_sortingLayerIDDelegate>("UnityEngine.Rendering.SortingGroup::set_sortingLayerID");
			SortingGroup.set_sortingOrderDelegateField = IL2CPP.ResolveICall<SortingGroup.set_sortingOrderDelegate>("UnityEngine.Rendering.SortingGroup::set_sortingOrder");
			SortingGroup.get_sortAtRootDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortAtRootDelegate>("UnityEngine.Rendering.SortingGroup::get_sortAtRoot");
			SortingGroup.set_sortAtRootDelegateField = IL2CPP.ResolveICall<SortingGroup.set_sortAtRootDelegate>("UnityEngine.Rendering.SortingGroup::set_sortAtRoot");
			SortingGroup.get_sortingGroupIDDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortingGroupIDDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingGroupID");
			SortingGroup.get_sortingGroupOrderDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortingGroupOrderDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingGroupOrder");
			SortingGroup.get_indexDelegateField = IL2CPP.ResolveICall<SortingGroup.get_indexDelegate>("UnityEngine.Rendering.SortingGroup::get_index");
			SortingGroup.get_sortingKeyDelegateField = IL2CPP.ResolveICall<SortingGroup.get_sortingKeyDelegate>("UnityEngine.Rendering.SortingGroup::get_sortingKey");
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060028A9 RID: 10409 RVA: 0x0009F3A4 File Offset: 0x0009D5A4
		public unsafe static int invalidSortingGroupID
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1292449, RefRangeEnd = 1292453, XrefRangeStart = 1292447, XrefRangeEnd = 1292449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_invalidSortingGroupID_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x0009F3D4 File Offset: 0x0009D5D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1292455, RefRangeEnd = 1292456, XrefRangeStart = 1292453, XrefRangeEnd = 1292455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SortingGroup GetSortingGroupByIndex(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_GetSortingGroupByIndex_Internal_Static_SortingGroup_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortingGroup>(intPtr3) : null;
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x0009F414 File Offset: 0x0009D614
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x00012373 File Offset: 0x00010573
		public unsafe int sortingLayerID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1292458, RefRangeEnd = 1292459, XrefRangeStart = 1292456, XrefRangeEnd = 1292458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				SortingGroup.set_sortingLayerIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x060028AC RID: 10412 RVA: 0x0009F450 File Offset: 0x0009D650
		// (set) Token: 0x060028B3 RID: 10419 RVA: 0x00012386 File Offset: 0x00010586
		public unsafe int sortingOrder
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1292461, RefRangeEnd = 1292462, XrefRangeStart = 1292459, XrefRangeEnd = 1292461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				SortingGroup.set_sortingOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x0009F48C File Offset: 0x0009D68C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortingGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortingGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortingGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x00012346 File Offset: 0x00010546
		public SortingGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x0001234F File Offset: 0x0001054F
		public static void UpdateAllSortingGroups()
		{
			SortingGroup.UpdateAllSortingGroupsDelegateField();
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x060028B0 RID: 10416 RVA: 0x0009F4C8 File Offset: 0x0009D6C8
		// (set) Token: 0x060028B1 RID: 10417 RVA: 0x0001235B File Offset: 0x0001055B
		public string sortingLayerName
		{
			get
			{
				IntPtr intPtr = SortingGroup.get_sortingLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				SortingGroup.set_sortingLayerNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x060028B4 RID: 10420 RVA: 0x00012399 File Offset: 0x00010599
		// (set) Token: 0x060028B5 RID: 10421 RVA: 0x000123AB File Offset: 0x000105AB
		public bool sortAtRoot
		{
			get
			{
				return SortingGroup.get_sortAtRootDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SortingGroup.set_sortAtRootDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x060028B6 RID: 10422 RVA: 0x000123BE File Offset: 0x000105BE
		public int sortingGroupID
		{
			get
			{
				return SortingGroup.get_sortingGroupIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x060028B7 RID: 10423 RVA: 0x000123D0 File Offset: 0x000105D0
		public int sortingGroupOrder
		{
			get
			{
				return SortingGroup.get_sortingGroupOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x060028B8 RID: 10424 RVA: 0x000123E2 File Offset: 0x000105E2
		public int index
		{
			get
			{
				return SortingGroup.get_indexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x000123F4 File Offset: 0x000105F4
		public uint sortingKey
		{
			get
			{
				return SortingGroup.get_sortingKeyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0400229D RID: 8861
		private static readonly IntPtr NativeMethodInfoPtr_get_invalidSortingGroupID_Internal_Static_get_Int32_0;

		// Token: 0x0400229E RID: 8862
		private static readonly IntPtr NativeMethodInfoPtr_GetSortingGroupByIndex_Internal_Static_SortingGroup_Int32_0;

		// Token: 0x0400229F RID: 8863
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x040022A0 RID: 8864
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x040022A1 RID: 8865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040022A2 RID: 8866
		private static readonly SortingGroup.UpdateAllSortingGroupsDelegate UpdateAllSortingGroupsDelegateField;

		// Token: 0x040022A3 RID: 8867
		private static readonly SortingGroup.get_sortingLayerNameDelegate get_sortingLayerNameDelegateField;

		// Token: 0x040022A4 RID: 8868
		private static readonly SortingGroup.set_sortingLayerNameDelegate set_sortingLayerNameDelegateField;

		// Token: 0x040022A5 RID: 8869
		private static readonly SortingGroup.set_sortingLayerIDDelegate set_sortingLayerIDDelegateField;

		// Token: 0x040022A6 RID: 8870
		private static readonly SortingGroup.set_sortingOrderDelegate set_sortingOrderDelegateField;

		// Token: 0x040022A7 RID: 8871
		private static readonly SortingGroup.get_sortAtRootDelegate get_sortAtRootDelegateField;

		// Token: 0x040022A8 RID: 8872
		private static readonly SortingGroup.set_sortAtRootDelegate set_sortAtRootDelegateField;

		// Token: 0x040022A9 RID: 8873
		private static readonly SortingGroup.get_sortingGroupIDDelegate get_sortingGroupIDDelegateField;

		// Token: 0x040022AA RID: 8874
		private static readonly SortingGroup.get_sortingGroupOrderDelegate get_sortingGroupOrderDelegateField;

		// Token: 0x040022AB RID: 8875
		private static readonly SortingGroup.get_indexDelegate get_indexDelegateField;

		// Token: 0x040022AC RID: 8876
		private static readonly SortingGroup.get_sortingKeyDelegate get_sortingKeyDelegateField;

		// Token: 0x02000B8B RID: 2955
		// (Invoke) Token: 0x06003FFF RID: 16383
		private delegate void UpdateAllSortingGroupsDelegate();

		// Token: 0x02000B8C RID: 2956
		// (Invoke) Token: 0x06004001 RID: 16385
		private delegate IntPtr get_sortingLayerNameDelegate(IntPtr @this);

		// Token: 0x02000B8D RID: 2957
		// (Invoke) Token: 0x06004003 RID: 16387
		private delegate void set_sortingLayerNameDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000B8E RID: 2958
		// (Invoke) Token: 0x06004005 RID: 16389
		private delegate void set_sortingLayerIDDelegate(IntPtr @this, int value);

		// Token: 0x02000B8F RID: 2959
		// (Invoke) Token: 0x06004007 RID: 16391
		private delegate void set_sortingOrderDelegate(IntPtr @this, int value);

		// Token: 0x02000B90 RID: 2960
		// (Invoke) Token: 0x06004009 RID: 16393
		private delegate bool get_sortAtRootDelegate(IntPtr @this);

		// Token: 0x02000B91 RID: 2961
		// (Invoke) Token: 0x0600400B RID: 16395
		private delegate void set_sortAtRootDelegate(IntPtr @this, bool value);

		// Token: 0x02000B92 RID: 2962
		// (Invoke) Token: 0x0600400D RID: 16397
		private delegate int get_sortingGroupIDDelegate(IntPtr @this);

		// Token: 0x02000B93 RID: 2963
		// (Invoke) Token: 0x0600400F RID: 16399
		private delegate int get_sortingGroupOrderDelegate(IntPtr @this);

		// Token: 0x02000B94 RID: 2964
		// (Invoke) Token: 0x06004011 RID: 16401
		private delegate int get_indexDelegate(IntPtr @this);

		// Token: 0x02000B95 RID: 2965
		// (Invoke) Token: 0x06004013 RID: 16403
		private delegate uint get_sortingKeyDelegate(IntPtr @this);
	}
}
