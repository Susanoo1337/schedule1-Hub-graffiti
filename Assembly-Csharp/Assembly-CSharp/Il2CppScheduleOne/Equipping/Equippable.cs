using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x02000579 RID: 1401
	public class Equippable : MonoBehaviour
	{
		// Token: 0x06007FBE RID: 32702 RVA: 0x0023228C File Offset: 0x0023048C
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable()
		{
			Il2CppClassPointerStore<Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable>.NativeClassPtr);
			Equippable.NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable>.NativeClassPtr, "itemInstance");
			Equippable.NativeFieldInfoPtr_CanInteractWhenEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable>.NativeClassPtr, "CanInteractWhenEquipped");
			Equippable.NativeFieldInfoPtr_CanPickUpWhenEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable>.NativeClassPtr, "CanPickUpWhenEquipped");
			Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable>.NativeClassPtr, 100679752);
			Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable>.NativeClassPtr, 100679753);
			Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable>.NativeClassPtr, 100679754);
			Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable>.NativeClassPtr, 100679755);
		}

		// Token: 0x06007FBF RID: 32703 RVA: 0x00232348 File Offset: 0x00230548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243459, XrefRangeEnd = 243470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FC0 RID: 32704 RVA: 0x00232398 File Offset: 0x00230598
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 243485, RefRangeEnd = 243492, XrefRangeStart = 243470, XrefRangeEnd = 243485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FC1 RID: 32705 RVA: 0x002323D4 File Offset: 0x002305D4
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FC2 RID: 32706 RVA: 0x00232410 File Offset: 0x00230610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243492, XrefRangeEnd = 243493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FC3 RID: 32707 RVA: 0x0003CAEB File Offset: 0x0003ACEB
		public Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002775 RID: 10101
		// (get) Token: 0x06007FC4 RID: 32708 RVA: 0x0023244C File Offset: 0x0023064C
		// (set) Token: 0x06007FC5 RID: 32709 RVA: 0x0003CAF4 File Offset: 0x0003ACF4
		public unsafe ItemInstance itemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_itemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_itemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002776 RID: 10102
		// (get) Token: 0x06007FC6 RID: 32710 RVA: 0x0023247C File Offset: 0x0023067C
		// (set) Token: 0x06007FC7 RID: 32711 RVA: 0x0003CB13 File Offset: 0x0003AD13
		public unsafe bool CanInteractWhenEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_CanInteractWhenEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_CanInteractWhenEquipped)) = value;
			}
		}

		// Token: 0x17002777 RID: 10103
		// (get) Token: 0x06007FC8 RID: 32712 RVA: 0x002324A4 File Offset: 0x002306A4
		// (set) Token: 0x06007FC9 RID: 32713 RVA: 0x0003CB2E File Offset: 0x0003AD2E
		public unsafe bool CanPickUpWhenEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_CanPickUpWhenEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_CanPickUpWhenEquipped)) = value;
			}
		}

		// Token: 0x0400572C RID: 22316
		private static readonly IntPtr NativeFieldInfoPtr_itemInstance;

		// Token: 0x0400572D RID: 22317
		private static readonly IntPtr NativeFieldInfoPtr_CanInteractWhenEquipped;

		// Token: 0x0400572E RID: 22318
		private static readonly IntPtr NativeFieldInfoPtr_CanPickUpWhenEquipped;

		// Token: 0x0400572F RID: 22319
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04005730 RID: 22320
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0;

		// Token: 0x04005731 RID: 22321
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04005732 RID: 22322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
