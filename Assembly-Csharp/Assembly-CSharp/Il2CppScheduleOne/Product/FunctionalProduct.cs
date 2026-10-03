using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000552 RID: 1362
	public class FunctionalProduct : Draggable
	{
		// Token: 0x06007BF1 RID: 31729 RVA: 0x0022382C File Offset: 0x00221A2C
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalProduct()
		{
			Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "FunctionalProduct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr);
			FunctionalProduct.NativeFieldInfoPtr_ClampZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "ClampZ");
			FunctionalProduct.NativeFieldInfoPtr_AlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "AlignmentPoint");
			FunctionalProduct.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "Visuals");
			FunctionalProduct.NativeFieldInfoPtr_startLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "startLocalPos");
			FunctionalProduct.NativeFieldInfoPtr_lowestMaxZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "lowestMaxZ");
			FunctionalProduct.NativeFieldInfoPtr__VelocityCalculator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, "<VelocityCalculator>k__BackingField");
			FunctionalProduct.NativeMethodInfoPtr_get_VelocityCalculator_Public_get_SmoothedVelocityCalculator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100679215);
			FunctionalProduct.NativeMethodInfoPtr_set_VelocityCalculator_Private_set_Void_SmoothedVelocityCalculator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100679216);
			FunctionalProduct.NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100679217);
			FunctionalProduct.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100679218);
			FunctionalProduct.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_ItemInstance_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100679219);
			FunctionalProduct.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100679220);
			FunctionalProduct.NativeMethodInfoPtr_InitializeVisuals_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100679221);
			FunctionalProduct.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100679222);
			FunctionalProduct.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100679223);
			FunctionalProduct.NativeMethodInfoPtr_Clamp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100679224);
			FunctionalProduct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr, 100679225);
		}

		// Token: 0x17002661 RID: 9825
		// (get) Token: 0x06007BF2 RID: 31730 RVA: 0x002239B0 File Offset: 0x00221BB0
		// (set) Token: 0x06007BF3 RID: 31731 RVA: 0x002239F0 File Offset: 0x00221BF0
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr_get_VelocityCalculator_Public_get_SmoothedVelocityCalculator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr_set_VelocityCalculator_Private_set_Void_SmoothedVelocityCalculator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002662 RID: 9826
		// (get) Token: 0x06007BF4 RID: 31732 RVA: 0x00223A34 File Offset: 0x00221C34
		public unsafe override bool RegisterDefaultLureWhenEmpty
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007BF5 RID: 31733 RVA: 0x00223A7C File Offset: 0x00221C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236140, XrefRangeEnd = 236141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BF6 RID: 31734 RVA: 0x00223AB8 File Offset: 0x00221CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236141, XrefRangeEnd = 236160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(PackagingStation station, ItemInstance item, Transform alignment, bool align = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref align;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_ItemInstance_Transform_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BF7 RID: 31735 RVA: 0x00223B38 File Offset: 0x00221D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236160, XrefRangeEnd = 236178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BF8 RID: 31736 RVA: 0x00223B88 File Offset: 0x00221D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236178, XrefRangeEnd = 236188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeVisuals(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_InitializeVisuals_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BF9 RID: 31737 RVA: 0x00223BD8 File Offset: 0x00221DD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236223, RefRangeEnd = 236224, XrefRangeStart = 236188, XrefRangeEnd = 236223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignTo(Transform alignment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BFA RID: 31738 RVA: 0x00223C1C File Offset: 0x00221E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236224, XrefRangeEnd = 236236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalProduct.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BFB RID: 31739 RVA: 0x00223C58 File Offset: 0x00221E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236236, XrefRangeEnd = 236247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clamp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr_Clamp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BFC RID: 31740 RVA: 0x00223C8C File Offset: 0x00221E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236247, XrefRangeEnd = 236248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalProduct() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalProduct>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalProduct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BFD RID: 31741 RVA: 0x0003B058 File Offset: 0x00039258
		public FunctionalProduct(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700265B RID: 9819
		// (get) Token: 0x06007BFE RID: 31742 RVA: 0x00223CC8 File Offset: 0x00221EC8
		// (set) Token: 0x06007BFF RID: 31743 RVA: 0x0003B061 File Offset: 0x00039261
		public unsafe bool ClampZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_ClampZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_ClampZ)) = value;
			}
		}

		// Token: 0x1700265C RID: 9820
		// (get) Token: 0x06007C00 RID: 31744 RVA: 0x00223CF0 File Offset: 0x00221EF0
		// (set) Token: 0x06007C01 RID: 31745 RVA: 0x0003B07C File Offset: 0x0003927C
		public unsafe Transform AlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_AlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_AlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700265D RID: 9821
		// (get) Token: 0x06007C02 RID: 31746 RVA: 0x00223D20 File Offset: 0x00221F20
		// (set) Token: 0x06007C03 RID: 31747 RVA: 0x0003B09B File Offset: 0x0003929B
		public unsafe ProductVisualsSetter Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductVisualsSetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700265E RID: 9822
		// (get) Token: 0x06007C04 RID: 31748 RVA: 0x00223D50 File Offset: 0x00221F50
		// (set) Token: 0x06007C05 RID: 31749 RVA: 0x0003B0BA File Offset: 0x000392BA
		public unsafe Vector3 startLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_startLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_startLocalPos)) = value;
			}
		}

		// Token: 0x1700265F RID: 9823
		// (get) Token: 0x06007C06 RID: 31750 RVA: 0x00223D78 File Offset: 0x00221F78
		// (set) Token: 0x06007C07 RID: 31751 RVA: 0x0003B0D5 File Offset: 0x000392D5
		public unsafe float lowestMaxZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_lowestMaxZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr_lowestMaxZ)) = value;
			}
		}

		// Token: 0x17002660 RID: 9824
		// (get) Token: 0x06007C08 RID: 31752 RVA: 0x00223DA0 File Offset: 0x00221FA0
		// (set) Token: 0x06007C09 RID: 31753 RVA: 0x0003B0F0 File Offset: 0x000392F0
		public unsafe SmoothedVelocityCalculator _VelocityCalculator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr__VelocityCalculator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalProduct.NativeFieldInfoPtr__VelocityCalculator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005488 RID: 21640
		private static readonly IntPtr NativeFieldInfoPtr_ClampZ;

		// Token: 0x04005489 RID: 21641
		private static readonly IntPtr NativeFieldInfoPtr_AlignmentPoint;

		// Token: 0x0400548A RID: 21642
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x0400548B RID: 21643
		private static readonly IntPtr NativeFieldInfoPtr_startLocalPos;

		// Token: 0x0400548C RID: 21644
		private static readonly IntPtr NativeFieldInfoPtr_lowestMaxZ;

		// Token: 0x0400548D RID: 21645
		private static readonly IntPtr NativeFieldInfoPtr__VelocityCalculator_k__BackingField;

		// Token: 0x0400548E RID: 21646
		private static readonly IntPtr NativeMethodInfoPtr_get_VelocityCalculator_Public_get_SmoothedVelocityCalculator_0;

		// Token: 0x0400548F RID: 21647
		private static readonly IntPtr NativeMethodInfoPtr_set_VelocityCalculator_Private_set_Void_SmoothedVelocityCalculator_0;

		// Token: 0x04005490 RID: 21648
		private static readonly IntPtr NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_get_Boolean_0;

		// Token: 0x04005491 RID: 21649
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005492 RID: 21650
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_PackagingStation_ItemInstance_Transform_Boolean_0;

		// Token: 0x04005493 RID: 21651
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04005494 RID: 21652
		private static readonly IntPtr NativeMethodInfoPtr_InitializeVisuals_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04005495 RID: 21653
		private static readonly IntPtr NativeMethodInfoPtr_AlignTo_Public_Void_Transform_0;

		// Token: 0x04005496 RID: 21654
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x04005497 RID: 21655
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Private_Void_0;

		// Token: 0x04005498 RID: 21656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
