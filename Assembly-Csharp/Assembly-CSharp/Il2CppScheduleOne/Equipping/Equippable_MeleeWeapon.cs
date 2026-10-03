using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x0200057E RID: 1406
	public class Equippable_MeleeWeapon : Equippable_AvatarViewmodel
	{
		// Token: 0x06007FF6 RID: 32758 RVA: 0x00232D14 File Offset: 0x00230F14
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_MeleeWeapon()
		{
			Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_MeleeWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr);
			Equippable_MeleeWeapon.NativeFieldInfoPtr__IsAttacking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "<IsAttacking>k__BackingField");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "ImpactType");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "Range");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_HitRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "HitRadius");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxLoadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxLoadTime");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinCooldown");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxCooldown");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinHitDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinHitDelay");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxHitDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxHitDelay");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinDamage");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxDamage");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinForce");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxForce");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinStaminaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinStaminaCost");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxStaminaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxStaminaCost");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "WhooshSound");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSoundPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "WhooshSoundPitch");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "ImpactSound");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_SwingAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "SwingAnimationTrigger");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_load = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "load");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_remainingCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "remainingCooldown");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_hitRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "hitRoutine");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_loadQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "loadQueued");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_clickReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "clickReleased");
			Equippable_MeleeWeapon.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679770);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_get_IsAttacking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679771);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_set_IsAttacking_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679772);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679773);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679774);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679775);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_UpdateCooldown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679776);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679777);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679778);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_StartLoad_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679779);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679780);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Hit_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679781);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679782);
			Equippable_MeleeWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679783);
		}

		// Token: 0x1700279C RID: 10140
		// (get) Token: 0x06007FF7 RID: 32759 RVA: 0x0023303C File Offset: 0x0023123C
		public unsafe bool IsLoading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700279D RID: 10141
		// (get) Token: 0x06007FF8 RID: 32760 RVA: 0x00233078 File Offset: 0x00231278
		// (set) Token: 0x06007FF9 RID: 32761 RVA: 0x002330B4 File Offset: 0x002312B4
		public unsafe bool IsAttacking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_get_IsAttacking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_set_IsAttacking_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007FFA RID: 32762 RVA: 0x002330F4 File Offset: 0x002312F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243618, XrefRangeEnd = 243625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_MeleeWeapon.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FFB RID: 32763 RVA: 0x00233130 File Offset: 0x00231330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243625, XrefRangeEnd = 243626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_MeleeWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FFC RID: 32764 RVA: 0x00233180 File Offset: 0x00231380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243626, XrefRangeEnd = 243635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_MeleeWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FFD RID: 32765 RVA: 0x002331BC File Offset: 0x002313BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243635, XrefRangeEnd = 243636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCooldown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_UpdateCooldown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FFE RID: 32766 RVA: 0x002331F0 File Offset: 0x002313F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243644, RefRangeEnd = 243645, XrefRangeStart = 243636, XrefRangeEnd = 243644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FFF RID: 32767 RVA: 0x00233224 File Offset: 0x00231424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243645, XrefRangeEnd = 243649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStartLoading()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008000 RID: 32768 RVA: 0x00233260 File Offset: 0x00231460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243649, XrefRangeEnd = 243668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_StartLoad_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008001 RID: 32769 RVA: 0x00233294 File Offset: 0x00231494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243668, XrefRangeEnd = 243715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008002 RID: 32770 RVA: 0x002332C8 File Offset: 0x002314C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243732, RefRangeEnd = 243733, XrefRangeStart = 243715, XrefRangeEnd = 243732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hit(float power)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_Hit_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008003 RID: 32771 RVA: 0x00233308 File Offset: 0x00231508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243733, XrefRangeEnd = 243812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteHit(float power)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008004 RID: 32772 RVA: 0x00233348 File Offset: 0x00231548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243812, XrefRangeEnd = 243813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_MeleeWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008005 RID: 32773 RVA: 0x0003CCAA File Offset: 0x0003AEAA
		public Equippable_MeleeWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002784 RID: 10116
		// (get) Token: 0x06008006 RID: 32774 RVA: 0x00233384 File Offset: 0x00231584
		// (set) Token: 0x06008007 RID: 32775 RVA: 0x0003CCB3 File Offset: 0x0003AEB3
		public unsafe bool _IsAttacking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr__IsAttacking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr__IsAttacking_k__BackingField)) = value;
			}
		}

		// Token: 0x17002785 RID: 10117
		// (get) Token: 0x06008008 RID: 32776 RVA: 0x002333AC File Offset: 0x002315AC
		// (set) Token: 0x06008009 RID: 32777 RVA: 0x0003CCCE File Offset: 0x0003AECE
		public unsafe EImpactType ImpactType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactType)) = value;
			}
		}

		// Token: 0x17002786 RID: 10118
		// (get) Token: 0x0600800A RID: 32778 RVA: 0x002333D4 File Offset: 0x002315D4
		// (set) Token: 0x0600800B RID: 32779 RVA: 0x0003CCE9 File Offset: 0x0003AEE9
		public unsafe float Range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_Range)) = value;
			}
		}

		// Token: 0x17002787 RID: 10119
		// (get) Token: 0x0600800C RID: 32780 RVA: 0x002333FC File Offset: 0x002315FC
		// (set) Token: 0x0600800D RID: 32781 RVA: 0x0003CD04 File Offset: 0x0003AF04
		public unsafe float HitRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_HitRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_HitRadius)) = value;
			}
		}

		// Token: 0x17002788 RID: 10120
		// (get) Token: 0x0600800E RID: 32782 RVA: 0x00233424 File Offset: 0x00231624
		// (set) Token: 0x0600800F RID: 32783 RVA: 0x0003CD1F File Offset: 0x0003AF1F
		public unsafe float MaxLoadTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxLoadTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxLoadTime)) = value;
			}
		}

		// Token: 0x17002789 RID: 10121
		// (get) Token: 0x06008010 RID: 32784 RVA: 0x0023344C File Offset: 0x0023164C
		// (set) Token: 0x06008011 RID: 32785 RVA: 0x0003CD3A File Offset: 0x0003AF3A
		public unsafe float MinCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinCooldown)) = value;
			}
		}

		// Token: 0x1700278A RID: 10122
		// (get) Token: 0x06008012 RID: 32786 RVA: 0x00233474 File Offset: 0x00231674
		// (set) Token: 0x06008013 RID: 32787 RVA: 0x0003CD55 File Offset: 0x0003AF55
		public unsafe float MaxCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxCooldown)) = value;
			}
		}

		// Token: 0x1700278B RID: 10123
		// (get) Token: 0x06008014 RID: 32788 RVA: 0x0023349C File Offset: 0x0023169C
		// (set) Token: 0x06008015 RID: 32789 RVA: 0x0003CD70 File Offset: 0x0003AF70
		public unsafe float MinHitDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinHitDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinHitDelay)) = value;
			}
		}

		// Token: 0x1700278C RID: 10124
		// (get) Token: 0x06008016 RID: 32790 RVA: 0x002334C4 File Offset: 0x002316C4
		// (set) Token: 0x06008017 RID: 32791 RVA: 0x0003CD8B File Offset: 0x0003AF8B
		public unsafe float MaxHitDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxHitDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxHitDelay)) = value;
			}
		}

		// Token: 0x1700278D RID: 10125
		// (get) Token: 0x06008018 RID: 32792 RVA: 0x002334EC File Offset: 0x002316EC
		// (set) Token: 0x06008019 RID: 32793 RVA: 0x0003CDA6 File Offset: 0x0003AFA6
		public unsafe float MinDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinDamage)) = value;
			}
		}

		// Token: 0x1700278E RID: 10126
		// (get) Token: 0x0600801A RID: 32794 RVA: 0x00233514 File Offset: 0x00231714
		// (set) Token: 0x0600801B RID: 32795 RVA: 0x0003CDC1 File Offset: 0x0003AFC1
		public unsafe float MaxDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxDamage)) = value;
			}
		}

		// Token: 0x1700278F RID: 10127
		// (get) Token: 0x0600801C RID: 32796 RVA: 0x0023353C File Offset: 0x0023173C
		// (set) Token: 0x0600801D RID: 32797 RVA: 0x0003CDDC File Offset: 0x0003AFDC
		public unsafe float MinForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinForce)) = value;
			}
		}

		// Token: 0x17002790 RID: 10128
		// (get) Token: 0x0600801E RID: 32798 RVA: 0x00233564 File Offset: 0x00231764
		// (set) Token: 0x0600801F RID: 32799 RVA: 0x0003CDF7 File Offset: 0x0003AFF7
		public unsafe float MaxForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxForce)) = value;
			}
		}

		// Token: 0x17002791 RID: 10129
		// (get) Token: 0x06008020 RID: 32800 RVA: 0x0023358C File Offset: 0x0023178C
		// (set) Token: 0x06008021 RID: 32801 RVA: 0x0003CE12 File Offset: 0x0003B012
		public unsafe float MinStaminaCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinStaminaCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinStaminaCost)) = value;
			}
		}

		// Token: 0x17002792 RID: 10130
		// (get) Token: 0x06008022 RID: 32802 RVA: 0x002335B4 File Offset: 0x002317B4
		// (set) Token: 0x06008023 RID: 32803 RVA: 0x0003CE2D File Offset: 0x0003B02D
		public unsafe float MaxStaminaCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxStaminaCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxStaminaCost)) = value;
			}
		}

		// Token: 0x17002793 RID: 10131
		// (get) Token: 0x06008024 RID: 32804 RVA: 0x002335DC File Offset: 0x002317DC
		// (set) Token: 0x06008025 RID: 32805 RVA: 0x0003CE48 File Offset: 0x0003B048
		public unsafe AudioSourceController WhooshSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002794 RID: 10132
		// (get) Token: 0x06008026 RID: 32806 RVA: 0x0023360C File Offset: 0x0023180C
		// (set) Token: 0x06008027 RID: 32807 RVA: 0x0003CE67 File Offset: 0x0003B067
		public unsafe float WhooshSoundPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSoundPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSoundPitch)) = value;
			}
		}

		// Token: 0x17002795 RID: 10133
		// (get) Token: 0x06008028 RID: 32808 RVA: 0x00233634 File Offset: 0x00231834
		// (set) Token: 0x06008029 RID: 32809 RVA: 0x0003CE82 File Offset: 0x0003B082
		public unsafe AudioSourceController ImpactSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002796 RID: 10134
		// (get) Token: 0x0600802A RID: 32810 RVA: 0x00233664 File Offset: 0x00231864
		// (set) Token: 0x0600802B RID: 32811 RVA: 0x0003CEA1 File Offset: 0x0003B0A1
		public unsafe string SwingAnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_SwingAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_SwingAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002797 RID: 10135
		// (get) Token: 0x0600802C RID: 32812 RVA: 0x0023368C File Offset: 0x0023188C
		// (set) Token: 0x0600802D RID: 32813 RVA: 0x0003CEC0 File Offset: 0x0003B0C0
		public unsafe float load
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_load);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_load)) = value;
			}
		}

		// Token: 0x17002798 RID: 10136
		// (get) Token: 0x0600802E RID: 32814 RVA: 0x002336B4 File Offset: 0x002318B4
		// (set) Token: 0x0600802F RID: 32815 RVA: 0x0003CEDB File Offset: 0x0003B0DB
		public unsafe float remainingCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_remainingCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_remainingCooldown)) = value;
			}
		}

		// Token: 0x17002799 RID: 10137
		// (get) Token: 0x06008030 RID: 32816 RVA: 0x002336DC File Offset: 0x002318DC
		// (set) Token: 0x06008031 RID: 32817 RVA: 0x0003CEF6 File Offset: 0x0003B0F6
		public unsafe Coroutine hitRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_hitRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_hitRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700279A RID: 10138
		// (get) Token: 0x06008032 RID: 32818 RVA: 0x0023370C File Offset: 0x0023190C
		// (set) Token: 0x06008033 RID: 32819 RVA: 0x0003CF15 File Offset: 0x0003B115
		public unsafe bool loadQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_loadQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_loadQueued)) = value;
			}
		}

		// Token: 0x1700279B RID: 10139
		// (get) Token: 0x06008034 RID: 32820 RVA: 0x00233734 File Offset: 0x00231934
		// (set) Token: 0x06008035 RID: 32821 RVA: 0x0003CF30 File Offset: 0x0003B130
		public unsafe bool clickReleased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_clickReleased);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_clickReleased)) = value;
			}
		}

		// Token: 0x0400574C RID: 22348
		private static readonly IntPtr NativeFieldInfoPtr__IsAttacking_k__BackingField;

		// Token: 0x0400574D RID: 22349
		private static readonly IntPtr NativeFieldInfoPtr_ImpactType;

		// Token: 0x0400574E RID: 22350
		private static readonly IntPtr NativeFieldInfoPtr_Range;

		// Token: 0x0400574F RID: 22351
		private static readonly IntPtr NativeFieldInfoPtr_HitRadius;

		// Token: 0x04005750 RID: 22352
		private static readonly IntPtr NativeFieldInfoPtr_MaxLoadTime;

		// Token: 0x04005751 RID: 22353
		private static readonly IntPtr NativeFieldInfoPtr_MinCooldown;

		// Token: 0x04005752 RID: 22354
		private static readonly IntPtr NativeFieldInfoPtr_MaxCooldown;

		// Token: 0x04005753 RID: 22355
		private static readonly IntPtr NativeFieldInfoPtr_MinHitDelay;

		// Token: 0x04005754 RID: 22356
		private static readonly IntPtr NativeFieldInfoPtr_MaxHitDelay;

		// Token: 0x04005755 RID: 22357
		private static readonly IntPtr NativeFieldInfoPtr_MinDamage;

		// Token: 0x04005756 RID: 22358
		private static readonly IntPtr NativeFieldInfoPtr_MaxDamage;

		// Token: 0x04005757 RID: 22359
		private static readonly IntPtr NativeFieldInfoPtr_MinForce;

		// Token: 0x04005758 RID: 22360
		private static readonly IntPtr NativeFieldInfoPtr_MaxForce;

		// Token: 0x04005759 RID: 22361
		private static readonly IntPtr NativeFieldInfoPtr_MinStaminaCost;

		// Token: 0x0400575A RID: 22362
		private static readonly IntPtr NativeFieldInfoPtr_MaxStaminaCost;

		// Token: 0x0400575B RID: 22363
		private static readonly IntPtr NativeFieldInfoPtr_WhooshSound;

		// Token: 0x0400575C RID: 22364
		private static readonly IntPtr NativeFieldInfoPtr_WhooshSoundPitch;

		// Token: 0x0400575D RID: 22365
		private static readonly IntPtr NativeFieldInfoPtr_ImpactSound;

		// Token: 0x0400575E RID: 22366
		private static readonly IntPtr NativeFieldInfoPtr_SwingAnimationTrigger;

		// Token: 0x0400575F RID: 22367
		private static readonly IntPtr NativeFieldInfoPtr_load;

		// Token: 0x04005760 RID: 22368
		private static readonly IntPtr NativeFieldInfoPtr_remainingCooldown;

		// Token: 0x04005761 RID: 22369
		private static readonly IntPtr NativeFieldInfoPtr_hitRoutine;

		// Token: 0x04005762 RID: 22370
		private static readonly IntPtr NativeFieldInfoPtr_loadQueued;

		// Token: 0x04005763 RID: 22371
		private static readonly IntPtr NativeFieldInfoPtr_clickReleased;

		// Token: 0x04005764 RID: 22372
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0;

		// Token: 0x04005765 RID: 22373
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAttacking_Public_get_Boolean_0;

		// Token: 0x04005766 RID: 22374
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAttacking_Private_set_Void_Boolean_0;

		// Token: 0x04005767 RID: 22375
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005768 RID: 22376
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005769 RID: 22377
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x0400576A RID: 22378
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCooldown_Private_Void_0;

		// Token: 0x0400576B RID: 22379
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x0400576C RID: 22380
		private static readonly IntPtr NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0;

		// Token: 0x0400576D RID: 22381
		private static readonly IntPtr NativeMethodInfoPtr_StartLoad_Private_Void_0;

		// Token: 0x0400576E RID: 22382
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x0400576F RID: 22383
		private static readonly IntPtr NativeMethodInfoPtr_Hit_Private_Void_Single_0;

		// Token: 0x04005770 RID: 22384
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0;

		// Token: 0x04005771 RID: 22385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BE7 RID: 3047
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_MeleeWeapon+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ECA0 RID: 60576 RVA: 0x003958E0 File Offset: 0x00393AE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr);
				Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, "<>4__this");
				Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr_power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, "power");
				Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, 100679784);
				Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, 100679785);
			}

			// Token: 0x0600ECA1 RID: 60577 RVA: 0x0039595C File Offset: 0x00393B5C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ECA2 RID: 60578 RVA: 0x00395998 File Offset: 0x00393B98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243613, XrefRangeEnd = 243618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600ECA3 RID: 60579 RVA: 0x0006FA28 File Offset: 0x0006DC28
			public __c__DisplayClass37_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047BE RID: 18366
			// (get) Token: 0x0600ECA4 RID: 60580 RVA: 0x003959D8 File Offset: 0x00393BD8
			// (set) Token: 0x0600ECA5 RID: 60581 RVA: 0x0006FA31 File Offset: 0x0006DC31
			public unsafe Equippable_MeleeWeapon __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_MeleeWeapon>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047BF RID: 18367
			// (get) Token: 0x0600ECA6 RID: 60582 RVA: 0x00395A08 File Offset: 0x00393C08
			// (set) Token: 0x0600ECA7 RID: 60583 RVA: 0x0006FA50 File Offset: 0x0006DC50
			public unsafe float power
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr_power);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr_power)) = value;
				}
			}

			// Token: 0x0400A030 RID: 41008
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A031 RID: 41009
			private static readonly IntPtr NativeFieldInfoPtr_power;

			// Token: 0x0400A032 RID: 41010
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A033 RID: 41011
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DEC RID: 3564
			[ObfuscatedName("ScheduleOne.Equipping.Equippable_MeleeWeapon+<>c__DisplayClass37_0+<<Hit>g__HitRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06010108 RID: 65800 RVA: 0x003D0AD8 File Offset: 0x003CECD8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, "<<Hit>g__HitRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679786);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679787);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679788);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679789);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679790);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679791);
				}

				// Token: 0x06010109 RID: 65801 RVA: 0x003D0BB8 File Offset: 0x003CEDB8
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601010A RID: 65802 RVA: 0x003D0C00 File Offset: 0x003CEE00
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601010B RID: 65803 RVA: 0x003D0C34 File Offset: 0x003CEE34
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243595, XrefRangeEnd = 243608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E5E RID: 20062
				// (get) Token: 0x0601010C RID: 65804 RVA: 0x003D0C70 File Offset: 0x003CEE70
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601010D RID: 65805 RVA: 0x003D0CB0 File Offset: 0x003CEEB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243608, XrefRangeEnd = 243613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E5F RID: 20063
				// (get) Token: 0x0601010E RID: 65806 RVA: 0x003D0CE4 File Offset: 0x003CEEE4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601010F RID: 65807 RVA: 0x00079D31 File Offset: 0x00077F31
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E5B RID: 20059
				// (get) Token: 0x06010110 RID: 65808 RVA: 0x003D0D24 File Offset: 0x003CEF24
				// (set) Token: 0x06010111 RID: 65809 RVA: 0x00079D3A File Offset: 0x00077F3A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004E5C RID: 20060
				// (get) Token: 0x06010112 RID: 65810 RVA: 0x003D0D4C File Offset: 0x003CEF4C
				// (set) Token: 0x06010113 RID: 65811 RVA: 0x00079D55 File Offset: 0x00077F55
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E5D RID: 20061
				// (get) Token: 0x06010114 RID: 65812 RVA: 0x003D0D7C File Offset: 0x003CEF7C
				// (set) Token: 0x06010115 RID: 65813 RVA: 0x00079D74 File Offset: 0x00077F74
				public unsafe Equippable_MeleeWeapon.__c__DisplayClass37_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_MeleeWeapon.__c__DisplayClass37_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AD19 RID: 44313
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AD1A RID: 44314
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AD1B RID: 44315
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AD1C RID: 44316
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AD1D RID: 44317
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AD1E RID: 44318
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AD1F RID: 44319
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AD20 RID: 44320
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AD21 RID: 44321
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
