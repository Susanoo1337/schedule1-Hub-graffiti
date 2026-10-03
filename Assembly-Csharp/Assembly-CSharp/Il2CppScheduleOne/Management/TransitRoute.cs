using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002F4 RID: 756
	public class TransitRoute : Object
	{
		// Token: 0x06003BE3 RID: 15331 RVA: 0x00145228 File Offset: 0x00143428
		// Note: this type is marked as 'beforefieldinit'.
		static TransitRoute()
		{
			Il2CppClassPointerStore<TransitRoute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "TransitRoute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr);
			TransitRoute.NativeFieldInfoPtr__Source_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "<Source>k__BackingField");
			TransitRoute.NativeFieldInfoPtr__Destination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "<Destination>k__BackingField");
			TransitRoute.NativeFieldInfoPtr_visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "visuals");
			TransitRoute.NativeFieldInfoPtr_onSourceChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "onSourceChange");
			TransitRoute.NativeFieldInfoPtr_onDestinationChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "onDestinationChange");
			TransitRoute.NativeMethodInfoPtr_get_Source_Public_get_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100670975);
			TransitRoute.NativeMethodInfoPtr_set_Source_Protected_set_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100670976);
			TransitRoute.NativeMethodInfoPtr_get_Destination_Public_get_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100670977);
			TransitRoute.NativeMethodInfoPtr_set_Destination_Protected_set_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100670978);
			TransitRoute.NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100670979);
			TransitRoute.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100670980);
			TransitRoute.NativeMethodInfoPtr_SetVisualsActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100670981);
			TransitRoute.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100670982);
			TransitRoute.NativeMethodInfoPtr_SetSource_Public_Virtual_New_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100670983);
			TransitRoute.NativeMethodInfoPtr_AreEntitiesNonNull_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100670984);
			TransitRoute.NativeMethodInfoPtr_SetDestination_Public_Virtual_New_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100670985);
			TransitRoute.NativeMethodInfoPtr_ValidateEntities_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100670986);
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06003BE4 RID: 15332 RVA: 0x001453AC File Offset: 0x001435AC
		// (set) Token: 0x06003BE5 RID: 15333 RVA: 0x001453EC File Offset: 0x001435EC
		public unsafe ITransitEntity Source
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 3712, RefRangeEnd = 3724, XrefRangeStart = 3712, XrefRangeEnd = 3724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_get_Source_Public_get_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29107, RefRangeEnd = 29109, XrefRangeStart = 29107, XrefRangeEnd = 29109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_set_Source_Protected_set_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06003BE6 RID: 15334 RVA: 0x00145430 File Offset: 0x00143630
		// (set) Token: 0x06003BE7 RID: 15335 RVA: 0x00145470 File Offset: 0x00143670
		public unsafe ITransitEntity Destination
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_get_Destination_Public_get_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_set_Destination_Protected_set_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x001454B4 File Offset: 0x001436B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 150663, RefRangeEnd = 150669, XrefRangeStart = 150642, XrefRangeEnd = 150663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitRoute(ITransitEntity source, ITransitEntity destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x00145514 File Offset: 0x00143714
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 150692, RefRangeEnd = 150712, XrefRangeStart = 150669, XrefRangeEnd = 150692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x00145548 File Offset: 0x00143748
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 150737, RefRangeEnd = 150757, XrefRangeStart = 150712, XrefRangeEnd = 150737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisualsActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_SetVisualsActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x00145588 File Offset: 0x00143788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150780, RefRangeEnd = 150781, XrefRangeStart = 150757, XrefRangeEnd = 150780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BEC RID: 15340 RVA: 0x001455BC File Offset: 0x001437BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150781, XrefRangeEnd = 150782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSource(ITransitEntity source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransitRoute.NativeMethodInfoPtr_SetSource_Public_Virtual_New_Void_ITransitEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BED RID: 15341 RVA: 0x0014560C File Offset: 0x0014380C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 150783, RefRangeEnd = 150786, XrefRangeStart = 150782, XrefRangeEnd = 150783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreEntitiesNonNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_AreEntitiesNonNull_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003BEE RID: 15342 RVA: 0x00145648 File Offset: 0x00143848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150786, XrefRangeEnd = 150787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetDestination(ITransitEntity destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransitRoute.NativeMethodInfoPtr_SetDestination_Public_Virtual_New_Void_ITransitEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BEF RID: 15343 RVA: 0x00145698 File Offset: 0x00143898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150792, RefRangeEnd = 150794, XrefRangeStart = 150787, XrefRangeEnd = 150792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEntities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_ValidateEntities_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BF0 RID: 15344 RVA: 0x0001DE0E File Offset: 0x0001C00E
		public TransitRoute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x001456CC File Offset: 0x001438CC
		// (set) Token: 0x06003BF2 RID: 15346 RVA: 0x0001DE17 File Offset: 0x0001C017
		public unsafe ITransitEntity _Source_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr__Source_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr__Source_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x06003BF3 RID: 15347 RVA: 0x001456FC File Offset: 0x001438FC
		// (set) Token: 0x06003BF4 RID: 15348 RVA: 0x0001DE36 File Offset: 0x0001C036
		public unsafe ITransitEntity _Destination_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr__Destination_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr__Destination_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x06003BF5 RID: 15349 RVA: 0x0014572C File Offset: 0x0014392C
		// (set) Token: 0x06003BF6 RID: 15350 RVA: 0x0001DE55 File Offset: 0x0001C055
		public unsafe TransitLineVisuals visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitLineVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x06003BF7 RID: 15351 RVA: 0x0014575C File Offset: 0x0014395C
		// (set) Token: 0x06003BF8 RID: 15352 RVA: 0x0001DE74 File Offset: 0x0001C074
		public unsafe Action<ITransitEntity> onSourceChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_onSourceChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ITransitEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_onSourceChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x06003BF9 RID: 15353 RVA: 0x0014578C File Offset: 0x0014398C
		// (set) Token: 0x06003BFA RID: 15354 RVA: 0x0001DE93 File Offset: 0x0001C093
		public unsafe Action<ITransitEntity> onDestinationChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_onDestinationChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ITransitEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_onDestinationChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400286A RID: 10346
		private static readonly IntPtr NativeFieldInfoPtr__Source_k__BackingField;

		// Token: 0x0400286B RID: 10347
		private static readonly IntPtr NativeFieldInfoPtr__Destination_k__BackingField;

		// Token: 0x0400286C RID: 10348
		private static readonly IntPtr NativeFieldInfoPtr_visuals;

		// Token: 0x0400286D RID: 10349
		private static readonly IntPtr NativeFieldInfoPtr_onSourceChange;

		// Token: 0x0400286E RID: 10350
		private static readonly IntPtr NativeFieldInfoPtr_onDestinationChange;

		// Token: 0x0400286F RID: 10351
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Public_get_ITransitEntity_0;

		// Token: 0x04002870 RID: 10352
		private static readonly IntPtr NativeMethodInfoPtr_set_Source_Protected_set_Void_ITransitEntity_0;

		// Token: 0x04002871 RID: 10353
		private static readonly IntPtr NativeMethodInfoPtr_get_Destination_Public_get_ITransitEntity_0;

		// Token: 0x04002872 RID: 10354
		private static readonly IntPtr NativeMethodInfoPtr_set_Destination_Protected_set_Void_ITransitEntity_0;

		// Token: 0x04002873 RID: 10355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0;

		// Token: 0x04002874 RID: 10356
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04002875 RID: 10357
		private static readonly IntPtr NativeMethodInfoPtr_SetVisualsActive_Public_Void_Boolean_0;

		// Token: 0x04002876 RID: 10358
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002877 RID: 10359
		private static readonly IntPtr NativeMethodInfoPtr_SetSource_Public_Virtual_New_Void_ITransitEntity_0;

		// Token: 0x04002878 RID: 10360
		private static readonly IntPtr NativeMethodInfoPtr_AreEntitiesNonNull_Public_Boolean_0;

		// Token: 0x04002879 RID: 10361
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Public_Virtual_New_Void_ITransitEntity_0;

		// Token: 0x0400287A RID: 10362
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEntities_Private_Void_0;
	}
}
