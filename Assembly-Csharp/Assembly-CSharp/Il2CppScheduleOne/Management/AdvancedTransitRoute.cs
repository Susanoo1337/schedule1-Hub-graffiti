using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002D0 RID: 720
	public class AdvancedTransitRoute : TransitRoute
	{
		// Token: 0x06003879 RID: 14457 RVA: 0x001370F4 File Offset: 0x001352F4
		// Note: this type is marked as 'beforefieldinit'.
		static AdvancedTransitRoute()
		{
			Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "AdvancedTransitRoute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr);
			AdvancedTransitRoute.NativeFieldInfoPtr__Filter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, "<Filter>k__BackingField");
			AdvancedTransitRoute.NativeMethodInfoPtr_get_Filter_Public_get_ManagementItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100670444);
			AdvancedTransitRoute.NativeMethodInfoPtr_set_Filter_Private_set_Void_ManagementItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100670445);
			AdvancedTransitRoute.NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100670446);
			AdvancedTransitRoute.NativeMethodInfoPtr__ctor_Public_Void_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100670447);
			AdvancedTransitRoute.NativeMethodInfoPtr_GetItemReadyToMove_Public_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100670448);
			AdvancedTransitRoute.NativeMethodInfoPtr_GetData_Public_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100670449);
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x0600387A RID: 14458 RVA: 0x001371B0 File Offset: 0x001353B0
		// (set) Token: 0x0600387B RID: 14459 RVA: 0x001371F0 File Offset: 0x001353F0
		public unsafe ManagementItemFilter Filter
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr_get_Filter_Public_get_ManagementItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ManagementItemFilter>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr_set_Filter_Private_set_Void_ManagementItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x00137234 File Offset: 0x00135434
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 144874, RefRangeEnd = 144876, XrefRangeStart = 144868, XrefRangeEnd = 144874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRoute(ITransitEntity source, ITransitEntity destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x00137294 File Offset: 0x00135494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 144910, RefRangeEnd = 144911, XrefRangeStart = 144876, XrefRangeEnd = 144910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRoute(AdvancedTransitRouteData data) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr__ctor_Public_Void_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600387E RID: 14462 RVA: 0x001372E0 File Offset: 0x001354E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 144927, RefRangeEnd = 144928, XrefRangeStart = 144911, XrefRangeEnd = 144927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetItemReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr_GetItemReadyToMove_Public_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x00137320 File Offset: 0x00135520
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 144968, RefRangeEnd = 144970, XrefRangeStart = 144928, XrefRangeEnd = 144968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRouteData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr_GetData_Public_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRouteData>(intPtr3) : null;
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x0001CA29 File Offset: 0x0001AC29
		public AdvancedTransitRoute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x06003881 RID: 14465 RVA: 0x00137360 File Offset: 0x00135560
		// (set) Token: 0x06003882 RID: 14466 RVA: 0x0001CA32 File Offset: 0x0001AC32
		public unsafe ManagementItemFilter _Filter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRoute.NativeFieldInfoPtr__Filter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementItemFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRoute.NativeFieldInfoPtr__Filter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040025D2 RID: 9682
		private static readonly IntPtr NativeFieldInfoPtr__Filter_k__BackingField;

		// Token: 0x040025D3 RID: 9683
		private static readonly IntPtr NativeMethodInfoPtr_get_Filter_Public_get_ManagementItemFilter_0;

		// Token: 0x040025D4 RID: 9684
		private static readonly IntPtr NativeMethodInfoPtr_set_Filter_Private_set_Void_ManagementItemFilter_0;

		// Token: 0x040025D5 RID: 9685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0;

		// Token: 0x040025D6 RID: 9686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AdvancedTransitRouteData_0;

		// Token: 0x040025D7 RID: 9687
		private static readonly IntPtr NativeMethodInfoPtr_GetItemReadyToMove_Public_ItemInstance_0;

		// Token: 0x040025D8 RID: 9688
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_AdvancedTransitRouteData_0;
	}
}
