using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x0200050C RID: 1292
	public class FunctionalJar : FunctionalPackaging
	{
		// Token: 0x0600747E RID: 29822 RVA: 0x00209360 File Offset: 0x00207560
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalJar()
		{
			Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalJar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr);
			FunctionalJar.NativeFieldInfoPtr__HoveredCursor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "<HoveredCursor>k__BackingField");
			FunctionalJar.NativeFieldInfoPtr_Lid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "Lid");
			FunctionalJar.NativeFieldInfoPtr_LidStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "LidStartPoint");
			FunctionalJar.NativeFieldInfoPtr_LidSensor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "LidSensor");
			FunctionalJar.NativeFieldInfoPtr_LidCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "LidCollider");
			FunctionalJar.NativeFieldInfoPtr_FullyPackedBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "FullyPackedBlocker");
			FunctionalJar.NativeFieldInfoPtr_LidObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "LidObject");
			FunctionalJar.NativeFieldInfoPtr_lidPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "lidPosition");
			FunctionalJar.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678304);
			FunctionalJar.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678305);
			FunctionalJar.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_PackagingStation_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678306);
			FunctionalJar.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678307);
			FunctionalJar.NativeMethodInfoPtr_EnableSealing_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678308);
			FunctionalJar.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678309);
			FunctionalJar.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678310);
			FunctionalJar.NativeMethodInfoPtr_Seal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678311);
			FunctionalJar.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678312);
			FunctionalJar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678313);
		}

		// Token: 0x170023FC RID: 9212
		// (get) Token: 0x0600747F RID: 29823 RVA: 0x002094F8 File Offset: 0x002076F8
		// (set) Token: 0x06007480 RID: 29824 RVA: 0x00209540 File Offset: 0x00207740
		public unsafe override CursorManager.ECursorType HoveredCursor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007481 RID: 29825 RVA: 0x0020958C File Offset: 0x0020778C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228267, XrefRangeEnd = 228299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(PackagingStation _station, Transform alignment, bool align = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref align;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_PackagingStation_Transform_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007482 RID: 29826 RVA: 0x002095FC File Offset: 0x002077FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228299, XrefRangeEnd = 228308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007483 RID: 29827 RVA: 0x00209638 File Offset: 0x00207838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228308, XrefRangeEnd = 228312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EnableSealing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_EnableSealing_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007484 RID: 29828 RVA: 0x00209674 File Offset: 0x00207874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228312, XrefRangeEnd = 228313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007485 RID: 29829 RVA: 0x002096B0 File Offset: 0x002078B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228313, XrefRangeEnd = 228324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007486 RID: 29830 RVA: 0x00209700 File Offset: 0x00207900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228324, XrefRangeEnd = 228341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Seal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_Seal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007487 RID: 29831 RVA: 0x0020973C File Offset: 0x0020793C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228341, XrefRangeEnd = 228344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FullyPacked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007488 RID: 29832 RVA: 0x00209778 File Offset: 0x00207978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228344, XrefRangeEnd = 228347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalJar() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalJar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007489 RID: 29833 RVA: 0x000378FB File Offset: 0x00035AFB
		public FunctionalJar(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023F4 RID: 9204
		// (get) Token: 0x0600748A RID: 29834 RVA: 0x002097B4 File Offset: 0x002079B4
		// (set) Token: 0x0600748B RID: 29835 RVA: 0x00037904 File Offset: 0x00035B04
		public new unsafe CursorManager.ECursorType _HoveredCursor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr__HoveredCursor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr__HoveredCursor_k__BackingField)) = value;
			}
		}

		// Token: 0x170023F5 RID: 9205
		// (get) Token: 0x0600748C RID: 29836 RVA: 0x002097DC File Offset: 0x002079DC
		// (set) Token: 0x0600748D RID: 29837 RVA: 0x0003791F File Offset: 0x00035B1F
		public unsafe Draggable Lid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_Lid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_Lid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F6 RID: 9206
		// (get) Token: 0x0600748E RID: 29838 RVA: 0x0020980C File Offset: 0x00207A0C
		// (set) Token: 0x0600748F RID: 29839 RVA: 0x0003793E File Offset: 0x00035B3E
		public unsafe Transform LidStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F7 RID: 9207
		// (get) Token: 0x06007490 RID: 29840 RVA: 0x0020983C File Offset: 0x00207A3C
		// (set) Token: 0x06007491 RID: 29841 RVA: 0x0003795D File Offset: 0x00035B5D
		public unsafe Collider LidSensor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidSensor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidSensor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F8 RID: 9208
		// (get) Token: 0x06007492 RID: 29842 RVA: 0x0020986C File Offset: 0x00207A6C
		// (set) Token: 0x06007493 RID: 29843 RVA: 0x0003797C File Offset: 0x00035B7C
		public unsafe Collider LidCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F9 RID: 9209
		// (get) Token: 0x06007494 RID: 29844 RVA: 0x0020989C File Offset: 0x00207A9C
		// (set) Token: 0x06007495 RID: 29845 RVA: 0x0003799B File Offset: 0x00035B9B
		public unsafe GameObject FullyPackedBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_FullyPackedBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_FullyPackedBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023FA RID: 9210
		// (get) Token: 0x06007496 RID: 29846 RVA: 0x002098CC File Offset: 0x00207ACC
		// (set) Token: 0x06007497 RID: 29847 RVA: 0x000379BA File Offset: 0x00035BBA
		public unsafe GameObject LidObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023FB RID: 9211
		// (get) Token: 0x06007498 RID: 29848 RVA: 0x002098FC File Offset: 0x00207AFC
		// (set) Token: 0x06007499 RID: 29849 RVA: 0x000379D9 File Offset: 0x00035BD9
		public unsafe Vector3 lidPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_lidPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_lidPosition)) = value;
			}
		}

		// Token: 0x04004F5E RID: 20318
		private static readonly IntPtr NativeFieldInfoPtr__HoveredCursor_k__BackingField;

		// Token: 0x04004F5F RID: 20319
		private static readonly IntPtr NativeFieldInfoPtr_Lid;

		// Token: 0x04004F60 RID: 20320
		private static readonly IntPtr NativeFieldInfoPtr_LidStartPoint;

		// Token: 0x04004F61 RID: 20321
		private static readonly IntPtr NativeFieldInfoPtr_LidSensor;

		// Token: 0x04004F62 RID: 20322
		private static readonly IntPtr NativeFieldInfoPtr_LidCollider;

		// Token: 0x04004F63 RID: 20323
		private static readonly IntPtr NativeFieldInfoPtr_FullyPackedBlocker;

		// Token: 0x04004F64 RID: 20324
		private static readonly IntPtr NativeFieldInfoPtr_LidObject;

		// Token: 0x04004F65 RID: 20325
		private static readonly IntPtr NativeFieldInfoPtr_lidPosition;

		// Token: 0x04004F66 RID: 20326
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0;

		// Token: 0x04004F67 RID: 20327
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0;

		// Token: 0x04004F68 RID: 20328
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_PackagingStation_Transform_Boolean_0;

		// Token: 0x04004F69 RID: 20329
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x04004F6A RID: 20330
		private static readonly IntPtr NativeMethodInfoPtr_EnableSealing_Protected_Virtual_Void_0;

		// Token: 0x04004F6B RID: 20331
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x04004F6C RID: 20332
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_Void_Collider_0;

		// Token: 0x04004F6D RID: 20333
		private static readonly IntPtr NativeMethodInfoPtr_Seal_Public_Virtual_Void_0;

		// Token: 0x04004F6E RID: 20334
		private static readonly IntPtr NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0;

		// Token: 0x04004F6F RID: 20335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
