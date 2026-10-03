using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.NPCs.Relation;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000150 RID: 336
	public class Quest_GrowShrooms : Quest
	{
		// Token: 0x060021C9 RID: 8649 RVA: 0x000EAB64 File Offset: 0x000E8D64
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_GrowShrooms()
		{
			Il2CppClassPointerStore<Quest_GrowShrooms>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_GrowShrooms");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_GrowShrooms>.NativeClassPtr);
			Quest_GrowShrooms.NativeFieldInfoPtr_ShroomSupplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GrowShrooms>.NativeClassPtr, "ShroomSupplier");
			Quest_GrowShrooms.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GrowShrooms>.NativeClassPtr, 100667672);
			Quest_GrowShrooms.NativeMethodInfoPtr_SupplierUnlocked_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GrowShrooms>.NativeClassPtr, 100667673);
			Quest_GrowShrooms.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GrowShrooms>.NativeClassPtr, 100667674);
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x000EABE4 File Offset: 0x000E8DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110966, XrefRangeEnd = 110975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_GrowShrooms.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x000EAC20 File Offset: 0x000E8E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110975, XrefRangeEnd = 110976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SupplierUnlocked(NPCRelationData.EUnlockType unlockType, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref unlockType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GrowShrooms.NativeMethodInfoPtr_SupplierUnlocked_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x000EAC6C File Offset: 0x000E8E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110976, XrefRangeEnd = 110980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_GrowShrooms() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_GrowShrooms>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GrowShrooms.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x00012070 File Offset: 0x00010270
		public Quest_GrowShrooms(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x000EACA8 File Offset: 0x000E8EA8
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x00012079 File Offset: 0x00010279
		public unsafe Supplier ShroomSupplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GrowShrooms.NativeFieldInfoPtr_ShroomSupplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GrowShrooms.NativeFieldInfoPtr_ShroomSupplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001764 RID: 5988
		private static readonly IntPtr NativeFieldInfoPtr_ShroomSupplier;

		// Token: 0x04001765 RID: 5989
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001766 RID: 5990
		private static readonly IntPtr NativeMethodInfoPtr_SupplierUnlocked_Private_Void_EUnlockType_Boolean_0;

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
