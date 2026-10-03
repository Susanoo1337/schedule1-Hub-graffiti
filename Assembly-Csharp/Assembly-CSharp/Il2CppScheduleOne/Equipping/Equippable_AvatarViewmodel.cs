using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x0200057C RID: 1404
	public class Equippable_AvatarViewmodel : Equippable_Viewmodel
	{
		// Token: 0x06007FDB RID: 32731 RVA: 0x00232824 File Offset: 0x00230A24
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_AvatarViewmodel()
		{
			Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_AvatarViewmodel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr);
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_AnimatorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "AnimatorController");
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_ViewmodelAvatarOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "ViewmodelAvatarOffset");
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_ViewmodelAvatarRotationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "ViewmodelAvatarRotationOffset");
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "EquipTime");
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "EquipTrigger");
			Equippable_AvatarViewmodel.NativeFieldInfoPtr_timeEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, "timeEquipped");
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_get_equipAnimDone_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679761);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679762);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679763);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679764);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679765);
			Equippable_AvatarViewmodel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr, 100679766);
		}

		// Token: 0x17002782 RID: 10114
		// (get) Token: 0x06007FDC RID: 32732 RVA: 0x00232944 File Offset: 0x00230B44
		public unsafe bool equipAnimDone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_AvatarViewmodel.NativeMethodInfoPtr_get_equipAnimDone_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007FDD RID: 32733 RVA: 0x00232980 File Offset: 0x00230B80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 243541, RefRangeEnd = 243543, XrefRangeStart = 243513, XrefRangeEnd = 243541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_AvatarViewmodel.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FDE RID: 32734 RVA: 0x002329D0 File Offset: 0x00230BD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 243550, RefRangeEnd = 243552, XrefRangeStart = 243543, XrefRangeEnd = 243550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_AvatarViewmodel.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FDF RID: 32735 RVA: 0x00232A0C File Offset: 0x00230C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243552, XrefRangeEnd = 243569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayEquipAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_AvatarViewmodel.NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FE0 RID: 32736 RVA: 0x00232A48 File Offset: 0x00230C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243569, XrefRangeEnd = 243570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_AvatarViewmodel.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FE1 RID: 32737 RVA: 0x00232A84 File Offset: 0x00230C84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 243581, RefRangeEnd = 243583, XrefRangeStart = 243570, XrefRangeEnd = 243581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_AvatarViewmodel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_AvatarViewmodel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_AvatarViewmodel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FE2 RID: 32738 RVA: 0x0003CBD3 File Offset: 0x0003ADD3
		public Equippable_AvatarViewmodel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700277C RID: 10108
		// (get) Token: 0x06007FE3 RID: 32739 RVA: 0x00232AC0 File Offset: 0x00230CC0
		// (set) Token: 0x06007FE4 RID: 32740 RVA: 0x0003CBDC File Offset: 0x0003ADDC
		public unsafe RuntimeAnimatorController AnimatorController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_AnimatorController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_AnimatorController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700277D RID: 10109
		// (get) Token: 0x06007FE5 RID: 32741 RVA: 0x00232AF0 File Offset: 0x00230CF0
		// (set) Token: 0x06007FE6 RID: 32742 RVA: 0x0003CBFB File Offset: 0x0003ADFB
		public unsafe Vector3 ViewmodelAvatarOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_ViewmodelAvatarOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_ViewmodelAvatarOffset)) = value;
			}
		}

		// Token: 0x1700277E RID: 10110
		// (get) Token: 0x06007FE7 RID: 32743 RVA: 0x00232B18 File Offset: 0x00230D18
		// (set) Token: 0x06007FE8 RID: 32744 RVA: 0x0003CC16 File Offset: 0x0003AE16
		public unsafe Vector3 ViewmodelAvatarRotationOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_ViewmodelAvatarRotationOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_ViewmodelAvatarRotationOffset)) = value;
			}
		}

		// Token: 0x1700277F RID: 10111
		// (get) Token: 0x06007FE9 RID: 32745 RVA: 0x00232B40 File Offset: 0x00230D40
		// (set) Token: 0x06007FEA RID: 32746 RVA: 0x0003CC31 File Offset: 0x0003AE31
		public unsafe float EquipTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTime)) = value;
			}
		}

		// Token: 0x17002780 RID: 10112
		// (get) Token: 0x06007FEB RID: 32747 RVA: 0x00232B68 File Offset: 0x00230D68
		// (set) Token: 0x06007FEC RID: 32748 RVA: 0x0003CC4C File Offset: 0x0003AE4C
		public unsafe string EquipTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_EquipTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002781 RID: 10113
		// (get) Token: 0x06007FED RID: 32749 RVA: 0x00232B90 File Offset: 0x00230D90
		// (set) Token: 0x06007FEE RID: 32750 RVA: 0x0003CC6B File Offset: 0x0003AE6B
		public unsafe float timeEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_timeEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_AvatarViewmodel.NativeFieldInfoPtr_timeEquipped)) = value;
			}
		}

		// Token: 0x0400573C RID: 22332
		private static readonly IntPtr NativeFieldInfoPtr_AnimatorController;

		// Token: 0x0400573D RID: 22333
		private static readonly IntPtr NativeFieldInfoPtr_ViewmodelAvatarOffset;

		// Token: 0x0400573E RID: 22334
		private static readonly IntPtr NativeFieldInfoPtr_ViewmodelAvatarRotationOffset;

		// Token: 0x0400573F RID: 22335
		private static readonly IntPtr NativeFieldInfoPtr_EquipTime;

		// Token: 0x04005740 RID: 22336
		private static readonly IntPtr NativeFieldInfoPtr_EquipTrigger;

		// Token: 0x04005741 RID: 22337
		private static readonly IntPtr NativeFieldInfoPtr_timeEquipped;

		// Token: 0x04005742 RID: 22338
		private static readonly IntPtr NativeMethodInfoPtr_get_equipAnimDone_Protected_get_Boolean_0;

		// Token: 0x04005743 RID: 22339
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005744 RID: 22340
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005745 RID: 22341
		private static readonly IntPtr NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_Void_0;

		// Token: 0x04005746 RID: 22342
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005747 RID: 22343
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
