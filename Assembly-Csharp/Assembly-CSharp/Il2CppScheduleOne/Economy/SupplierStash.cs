using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.Storage;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x020003A0 RID: 928
	public class SupplierStash : MonoBehaviour
	{
		// Token: 0x0600543D RID: 21565 RVA: 0x0019EF10 File Offset: 0x0019D110
		// Note: this type is marked as 'beforefieldinit'.
		static SupplierStash()
		{
			Il2CppClassPointerStore<SupplierStash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "SupplierStash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr);
			SupplierStash.NativeFieldInfoPtr_locationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "locationDescription");
			SupplierStash.NativeFieldInfoPtr_Supplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "Supplier");
			SupplierStash.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "Storage");
			SupplierStash.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "IntObj");
			SupplierStash.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "Light");
			SupplierStash.NativeFieldInfoPtr_StashPoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "StashPoI");
			SupplierStash.NativeFieldInfoPtr__CashAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, "<CashAmount>k__BackingField");
			SupplierStash.NativeMethodInfoPtr_get_CashAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100674370);
			SupplierStash.NativeMethodInfoPtr_set_CashAmount_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100674371);
			SupplierStash.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100674372);
			SupplierStash.NativeMethodInfoPtr_SupplierUnlocked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100674373);
			SupplierStash.NativeMethodInfoPtr_RecalculateCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100674374);
			SupplierStash.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100674375);
			SupplierStash.NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100674376);
			SupplierStash.NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100674377);
			SupplierStash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100674378);
			SupplierStash.NativeMethodInfoPtr__Start_b__10_0_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr, 100674379);
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x0600543E RID: 21566 RVA: 0x0019F094 File Offset: 0x0019D294
		// (set) Token: 0x0600543F RID: 21567 RVA: 0x0019F0D0 File Offset: 0x0019D2D0
		public unsafe float CashAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_get_CashAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_set_CashAmount_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005440 RID: 21568 RVA: 0x0019F110 File Offset: 0x0019D310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187977, XrefRangeEnd = 188049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SupplierStash.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005441 RID: 21569 RVA: 0x0019F14C File Offset: 0x0019D34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188049, XrefRangeEnd = 188052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SupplierUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_SupplierUnlocked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005442 RID: 21570 RVA: 0x0019F180 File Offset: 0x0019D380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188066, RefRangeEnd = 188067, XrefRangeStart = 188052, XrefRangeEnd = 188066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_RecalculateCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x0019F1B4 File Offset: 0x0019D3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188067, XrefRangeEnd = 188091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005444 RID: 21572 RVA: 0x0019F1E8 File Offset: 0x0019D3E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188105, RefRangeEnd = 188106, XrefRangeStart = 188091, XrefRangeEnd = 188105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCash(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x0019F228 File Offset: 0x0019D428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188106, XrefRangeEnd = 188109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDeadDrop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005446 RID: 21574 RVA: 0x0019F25C File Offset: 0x0019D45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188109, XrefRangeEnd = 188114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierStash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupplierStash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005447 RID: 21575 RVA: 0x0019F298 File Offset: 0x0019D498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__10_0(NPCRelationData.EUnlockType type, bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierStash.NativeMethodInfoPtr__Start_b__10_0_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005448 RID: 21576 RVA: 0x00027CC7 File Offset: 0x00025EC7
		public SupplierStash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x06005449 RID: 21577 RVA: 0x0019F2E4 File Offset: 0x0019D4E4
		// (set) Token: 0x0600544A RID: 21578 RVA: 0x00027CD0 File Offset: 0x00025ED0
		public unsafe string locationDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_locationDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_locationDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x0600544B RID: 21579 RVA: 0x0019F30C File Offset: 0x0019D50C
		// (set) Token: 0x0600544C RID: 21580 RVA: 0x00027CEF File Offset: 0x00025EEF
		public unsafe Supplier Supplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Supplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Supplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x0600544D RID: 21581 RVA: 0x0019F33C File Offset: 0x0019D53C
		// (set) Token: 0x0600544E RID: 21582 RVA: 0x00027D0E File Offset: 0x00025F0E
		public unsafe StorageEntity Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x0600544F RID: 21583 RVA: 0x0019F36C File Offset: 0x0019D56C
		// (set) Token: 0x06005450 RID: 21584 RVA: 0x00027D2D File Offset: 0x00025F2D
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x06005451 RID: 21585 RVA: 0x0019F39C File Offset: 0x0019D59C
		// (set) Token: 0x06005452 RID: 21586 RVA: 0x00027D4C File Offset: 0x00025F4C
		public unsafe OptimizedLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x06005453 RID: 21587 RVA: 0x0019F3CC File Offset: 0x0019D5CC
		// (set) Token: 0x06005454 RID: 21588 RVA: 0x00027D6B File Offset: 0x00025F6B
		public unsafe POI StashPoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_StashPoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr_StashPoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x06005455 RID: 21589 RVA: 0x0019F3FC File Offset: 0x0019D5FC
		// (set) Token: 0x06005456 RID: 21590 RVA: 0x00027D8A File Offset: 0x00025F8A
		public unsafe float _CashAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr__CashAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierStash.NativeFieldInfoPtr__CashAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x04003A0F RID: 14863
		private static readonly IntPtr NativeFieldInfoPtr_locationDescription;

		// Token: 0x04003A10 RID: 14864
		private static readonly IntPtr NativeFieldInfoPtr_Supplier;

		// Token: 0x04003A11 RID: 14865
		private static readonly IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x04003A12 RID: 14866
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04003A13 RID: 14867
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04003A14 RID: 14868
		private static readonly IntPtr NativeFieldInfoPtr_StashPoI;

		// Token: 0x04003A15 RID: 14869
		private static readonly IntPtr NativeFieldInfoPtr__CashAmount_k__BackingField;

		// Token: 0x04003A16 RID: 14870
		private static readonly IntPtr NativeMethodInfoPtr_get_CashAmount_Public_get_Single_0;

		// Token: 0x04003A17 RID: 14871
		private static readonly IntPtr NativeMethodInfoPtr_set_CashAmount_Private_set_Void_Single_0;

		// Token: 0x04003A18 RID: 14872
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04003A19 RID: 14873
		private static readonly IntPtr NativeMethodInfoPtr_SupplierUnlocked_Private_Void_0;

		// Token: 0x04003A1A RID: 14874
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateCash_Private_Void_0;

		// Token: 0x04003A1B RID: 14875
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x04003A1C RID: 14876
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0;

		// Token: 0x04003A1D RID: 14877
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0;

		// Token: 0x04003A1E RID: 14878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003A1F RID: 14879
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__10_0_Private_Void_EUnlockType_Boolean_0;
	}
}
