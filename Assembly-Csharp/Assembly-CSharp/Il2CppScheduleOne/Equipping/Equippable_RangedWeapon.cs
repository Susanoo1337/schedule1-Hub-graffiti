using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x02000581 RID: 1409
	public class Equippable_RangedWeapon : Equippable_AvatarViewmodel
	{
		// Token: 0x0600804B RID: 32843 RVA: 0x00233BD8 File Offset: 0x00231DD8
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_RangedWeapon()
		{
			Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_RangedWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr);
			Equippable_RangedWeapon.NativeFieldInfoPtr_NPC_AIM_DETECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "NPC_AIM_DETECTION_RANGE");
			Equippable_RangedWeapon.NativeFieldInfoPtr__Aim_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<Aim>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__Accuracy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<Accuracy>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__TimeSinceFire_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<TimeSinceFire>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__IsReloading_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<IsReloading>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<IsCocked>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<IsCocking>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MagazineSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MagazineSize");
			Equippable_RangedWeapon.NativeFieldInfoPtr_AimDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "AimDuration");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MinAimFOVReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MinAimFOVReduction");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MaxAimFOVReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MaxAimFOVReduction");
			Equippable_RangedWeapon.NativeFieldInfoPtr_FireSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "FireSound");
			Equippable_RangedWeapon.NativeFieldInfoPtr_EmptySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "EmptySound");
			Equippable_RangedWeapon.NativeFieldInfoPtr_FireCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "FireCooldown");
			Equippable_RangedWeapon.NativeFieldInfoPtr_FireAnimTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "FireAnimTriggers");
			Equippable_RangedWeapon.NativeFieldInfoPtr_AccuracyChangeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "AccuracyChangeDuration");
			Equippable_RangedWeapon.NativeFieldInfoPtr_AccuracyDropPerShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "AccuracyDropPerShot");
			Equippable_RangedWeapon.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "Range");
			Equippable_RangedWeapon.NativeFieldInfoPtr_RayRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "RayRadius");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MinSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MinSpread");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MaxSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MaxSpread");
			Equippable_RangedWeapon.NativeFieldInfoPtr_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "Damage");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ImpactForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ImpactForce");
			Equippable_RangedWeapon.NativeFieldInfoPtr_HeadshotMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "HeadshotMultiplier");
			Equippable_RangedWeapon.NativeFieldInfoPtr_CanReload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "CanReload");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadType");
			Equippable_RangedWeapon.NativeFieldInfoPtr_Magazine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "Magazine");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadStartTime");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadIndividalTime");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadEndTime");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartAnimTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadStartAnimTrigger");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividualAnimTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadIndividualAnimTrigger");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndAnimTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadEndAnimTrigger");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadTrash");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MustBeCocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MustBeCocked");
			Equippable_RangedWeapon.NativeFieldInfoPtr_CockedByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "CockedByDefault");
			Equippable_RangedWeapon.NativeFieldInfoPtr_AutoCockAfterReload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "AutoCockAfterReload");
			Equippable_RangedWeapon.NativeFieldInfoPtr_CockTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "CockTime");
			Equippable_RangedWeapon.NativeFieldInfoPtr_CockAnimTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "CockAnimTrigger");
			Equippable_RangedWeapon.NativeFieldInfoPtr_TracerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "TracerSpeed");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onFire");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onReloadStart");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadIndividual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onReloadIndividual");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onReloadEnd");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onCockStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onCockStart");
			Equippable_RangedWeapon.NativeFieldInfoPtr_weaponItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "weaponItem");
			Equippable_RangedWeapon.NativeFieldInfoPtr_aimStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "aimStarted");
			Equippable_RangedWeapon.NativeFieldInfoPtr_aimVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "aimVelocity");
			Equippable_RangedWeapon.NativeFieldInfoPtr_reloadRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "reloadRoutine");
			Equippable_RangedWeapon.NativeFieldInfoPtr_shotQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "shotQueued");
			Equippable_RangedWeapon.NativeFieldInfoPtr_reloadQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "reloadQueued");
			Equippable_RangedWeapon.NativeFieldInfoPtr_timeSincePrimaryClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "timeSincePrimaryClick");
			Equippable_RangedWeapon.NativeFieldInfoPtr_timeSinceReloadStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "timeSinceReloadStart");
			Equippable_RangedWeapon.NativeFieldInfoPtr_timeSinceAimStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "timeSinceAimStart");
			Equippable_RangedWeapon.NativeFieldInfoPtr_interruptReload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "interruptReload");
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_Aim_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679801);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_Aim_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679802);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_Accuracy_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679803);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_Accuracy_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679804);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_TimeSinceFire_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679805);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_TimeSinceFire_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679806);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsReloading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679807);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsReloading_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679808);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsCocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679809);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsCocked_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679810);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsCocking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679811);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsCocking_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679812);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_Ammo_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679813);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_fov_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679814);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679815);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679816);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679817);
			Equippable_RangedWeapon.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679818);
			Equippable_RangedWeapon.NativeMethodInfoPtr_UpdateAnim_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679819);
			Equippable_RangedWeapon.NativeMethodInfoPtr_CanAim_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679820);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Fire_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679821);
			Equippable_RangedWeapon.NativeMethodInfoPtr_GetBulletDirections_Protected_Virtual_New_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679822);
			Equippable_RangedWeapon.NativeMethodInfoPtr_SpreadDirection_Protected_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679823);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Reload_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679824);
			Equippable_RangedWeapon.NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679825);
			Equippable_RangedWeapon.NativeMethodInfoPtr_IsReloadReady_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679826);
			Equippable_RangedWeapon.NativeMethodInfoPtr_GetMagazine_Protected_Virtual_New_Boolean_byref_StorableItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679827);
			Equippable_RangedWeapon.NativeMethodInfoPtr_CanFire_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679828);
			Equippable_RangedWeapon.NativeMethodInfoPtr_CanCock_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679829);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Cock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679830);
			Equippable_RangedWeapon.NativeMethodInfoPtr_GetSpreadAngle_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679831);
			Equippable_RangedWeapon.NativeMethodInfoPtr_CheckAimingAtNPC_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679832);
			Equippable_RangedWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679833);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_Single_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679834);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679835);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679836);
		}

		// Token: 0x170027DA RID: 10202
		// (get) Token: 0x0600804C RID: 32844 RVA: 0x00234324 File Offset: 0x00232524
		// (set) Token: 0x0600804D RID: 32845 RVA: 0x00234360 File Offset: 0x00232560
		public unsafe float Aim
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_Aim_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_Aim_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170027DB RID: 10203
		// (get) Token: 0x0600804E RID: 32846 RVA: 0x002343A0 File Offset: 0x002325A0
		// (set) Token: 0x0600804F RID: 32847 RVA: 0x002343DC File Offset: 0x002325DC
		public unsafe float Accuracy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_Accuracy_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_Accuracy_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170027DC RID: 10204
		// (get) Token: 0x06008050 RID: 32848 RVA: 0x0023441C File Offset: 0x0023261C
		// (set) Token: 0x06008051 RID: 32849 RVA: 0x00234458 File Offset: 0x00232658
		public unsafe float TimeSinceFire
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_TimeSinceFire_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_TimeSinceFire_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170027DD RID: 10205
		// (get) Token: 0x06008052 RID: 32850 RVA: 0x00234498 File Offset: 0x00232698
		// (set) Token: 0x06008053 RID: 32851 RVA: 0x002344D4 File Offset: 0x002326D4
		public unsafe bool IsReloading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsReloading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsReloading_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170027DE RID: 10206
		// (get) Token: 0x06008054 RID: 32852 RVA: 0x00234514 File Offset: 0x00232714
		// (set) Token: 0x06008055 RID: 32853 RVA: 0x00234550 File Offset: 0x00232750
		public unsafe bool IsCocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsCocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsCocked_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170027DF RID: 10207
		// (get) Token: 0x06008056 RID: 32854 RVA: 0x00234590 File Offset: 0x00232790
		// (set) Token: 0x06008057 RID: 32855 RVA: 0x002345CC File Offset: 0x002327CC
		public unsafe bool IsCocking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsCocking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsCocking_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170027E0 RID: 10208
		// (get) Token: 0x06008058 RID: 32856 RVA: 0x0023460C File Offset: 0x0023280C
		public unsafe int Ammo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_Ammo_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170027E1 RID: 10209
		// (get) Token: 0x06008059 RID: 32857 RVA: 0x00234648 File Offset: 0x00232848
		public unsafe float fov
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243914, XrefRangeEnd = 243919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_fov_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600805A RID: 32858 RVA: 0x00234684 File Offset: 0x00232884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243943, RefRangeEnd = 243944, XrefRangeStart = 243919, XrefRangeEnd = 243943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600805B RID: 32859 RVA: 0x002346D4 File Offset: 0x002328D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243944, XrefRangeEnd = 243976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600805C RID: 32860 RVA: 0x00234710 File Offset: 0x00232910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243976, XrefRangeEnd = 243986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600805D RID: 32861 RVA: 0x0023474C File Offset: 0x0023294C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244077, RefRangeEnd = 244078, XrefRangeStart = 243986, XrefRangeEnd = 244077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600805E RID: 32862 RVA: 0x00234780 File Offset: 0x00232980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244099, RefRangeEnd = 244100, XrefRangeStart = 244078, XrefRangeEnd = 244099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_UpdateAnim_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600805F RID: 32863 RVA: 0x002347B4 File Offset: 0x002329B4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanAim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_CanAim_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008060 RID: 32864 RVA: 0x002347F0 File Offset: 0x002329F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244337, RefRangeEnd = 244338, XrefRangeStart = 244100, XrefRangeEnd = 244337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Fire_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008061 RID: 32865 RVA: 0x0023482C File Offset: 0x00232A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244338, XrefRangeEnd = 244349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<Vector3> GetBulletDirections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_GetBulletDirections_Protected_Virtual_New_Il2CppStructArray_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06008062 RID: 32866 RVA: 0x00234878 File Offset: 0x00232A78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 244369, RefRangeEnd = 244371, XrefRangeStart = 244349, XrefRangeEnd = 244369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SpreadDirection(Vector3 direction, float maxAngle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref direction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_SpreadDirection_Protected_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008063 RID: 32867 RVA: 0x002348C4 File Offset: 0x00232AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244371, XrefRangeEnd = 244384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Reload_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008064 RID: 32868 RVA: 0x00234900 File Offset: 0x00232B00
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyIncrementalReload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008065 RID: 32869 RVA: 0x0023493C File Offset: 0x00232B3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244384, RefRangeEnd = 244385, XrefRangeStart = 244384, XrefRangeEnd = 244384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReloadReady(bool ignoreTiming)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignoreTiming;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_IsReloadReady_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008066 RID: 32870 RVA: 0x00234988 File Offset: 0x00232B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244385, XrefRangeEnd = 244415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetMagazine(out StorableItemInstance mag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_GetMagazine_Protected_Virtual_New_Boolean_byref_StorableItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			mag = ((intPtr4 == 0) ? null : new StorableItemInstance(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008067 RID: 32871 RVA: 0x002349F4 File Offset: 0x00232BF4
		[CallerCount(0)]
		public unsafe bool CanFire(bool checkAmmo = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref checkAmmo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_CanFire_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008068 RID: 32872 RVA: 0x00234A40 File Offset: 0x00232C40
		[CallerCount(0)]
		public unsafe bool CanCock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_CanCock_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008069 RID: 32873 RVA: 0x00234A7C File Offset: 0x00232C7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244421, RefRangeEnd = 244422, XrefRangeStart = 244415, XrefRangeEnd = 244421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_Cock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600806A RID: 32874 RVA: 0x00234AB0 File Offset: 0x00232CB0
		[CallerCount(0)]
		public unsafe float GetSpreadAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_GetSpreadAngle_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600806B RID: 32875 RVA: 0x00234AEC File Offset: 0x00232CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244422, XrefRangeEnd = 244472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAimingAtNPC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_CheckAimingAtNPC_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600806C RID: 32876 RVA: 0x00234B20 File Offset: 0x00232D20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 244485, RefRangeEnd = 244487, XrefRangeStart = 244472, XrefRangeEnd = 244485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_RangedWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600806D RID: 32877 RVA: 0x00234B5C File Offset: 0x00232D5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 244492, RefRangeEnd = 244495, XrefRangeStart = 244487, XrefRangeEnd = 244492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Method_Private_Single_Collider_0(Collider collider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_Single_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600806E RID: 32878 RVA: 0x00234BAC File Offset: 0x00232DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244495, XrefRangeEnd = 244500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600806F RID: 32879 RVA: 0x00234BEC File Offset: 0x00232DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244500, XrefRangeEnd = 244505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008070 RID: 32880 RVA: 0x0003CFC4 File Offset: 0x0003B1C4
		public Equippable_RangedWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027A3 RID: 10147
		// (get) Token: 0x06008071 RID: 32881 RVA: 0x00234C2C File Offset: 0x00232E2C
		// (set) Token: 0x06008072 RID: 32882 RVA: 0x0003CFCD File Offset: 0x0003B1CD
		public unsafe static float NPC_AIM_DETECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Equippable_RangedWeapon.NativeFieldInfoPtr_NPC_AIM_DETECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Equippable_RangedWeapon.NativeFieldInfoPtr_NPC_AIM_DETECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170027A4 RID: 10148
		// (get) Token: 0x06008073 RID: 32883 RVA: 0x00234C48 File Offset: 0x00232E48
		// (set) Token: 0x06008074 RID: 32884 RVA: 0x0003CFDB File Offset: 0x0003B1DB
		public unsafe float _Aim_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__Aim_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__Aim_k__BackingField)) = value;
			}
		}

		// Token: 0x170027A5 RID: 10149
		// (get) Token: 0x06008075 RID: 32885 RVA: 0x00234C70 File Offset: 0x00232E70
		// (set) Token: 0x06008076 RID: 32886 RVA: 0x0003CFF6 File Offset: 0x0003B1F6
		public unsafe float _Accuracy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__Accuracy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__Accuracy_k__BackingField)) = value;
			}
		}

		// Token: 0x170027A6 RID: 10150
		// (get) Token: 0x06008077 RID: 32887 RVA: 0x00234C98 File Offset: 0x00232E98
		// (set) Token: 0x06008078 RID: 32888 RVA: 0x0003D011 File Offset: 0x0003B211
		public unsafe float _TimeSinceFire_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__TimeSinceFire_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__TimeSinceFire_k__BackingField)) = value;
			}
		}

		// Token: 0x170027A7 RID: 10151
		// (get) Token: 0x06008079 RID: 32889 RVA: 0x00234CC0 File Offset: 0x00232EC0
		// (set) Token: 0x0600807A RID: 32890 RVA: 0x0003D02C File Offset: 0x0003B22C
		public unsafe bool _IsReloading_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsReloading_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsReloading_k__BackingField)) = value;
			}
		}

		// Token: 0x170027A8 RID: 10152
		// (get) Token: 0x0600807B RID: 32891 RVA: 0x00234CE8 File Offset: 0x00232EE8
		// (set) Token: 0x0600807C RID: 32892 RVA: 0x0003D047 File Offset: 0x0003B247
		public unsafe bool _IsCocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocked_k__BackingField)) = value;
			}
		}

		// Token: 0x170027A9 RID: 10153
		// (get) Token: 0x0600807D RID: 32893 RVA: 0x00234D10 File Offset: 0x00232F10
		// (set) Token: 0x0600807E RID: 32894 RVA: 0x0003D062 File Offset: 0x0003B262
		public unsafe bool _IsCocking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocking_k__BackingField)) = value;
			}
		}

		// Token: 0x170027AA RID: 10154
		// (get) Token: 0x0600807F RID: 32895 RVA: 0x00234D38 File Offset: 0x00232F38
		// (set) Token: 0x06008080 RID: 32896 RVA: 0x0003D07D File Offset: 0x0003B27D
		public unsafe int MagazineSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MagazineSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MagazineSize)) = value;
			}
		}

		// Token: 0x170027AB RID: 10155
		// (get) Token: 0x06008081 RID: 32897 RVA: 0x00234D60 File Offset: 0x00232F60
		// (set) Token: 0x06008082 RID: 32898 RVA: 0x0003D098 File Offset: 0x0003B298
		public unsafe float AimDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AimDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AimDuration)) = value;
			}
		}

		// Token: 0x170027AC RID: 10156
		// (get) Token: 0x06008083 RID: 32899 RVA: 0x00234D88 File Offset: 0x00232F88
		// (set) Token: 0x06008084 RID: 32900 RVA: 0x0003D0B3 File Offset: 0x0003B2B3
		public unsafe float MinAimFOVReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MinAimFOVReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MinAimFOVReduction)) = value;
			}
		}

		// Token: 0x170027AD RID: 10157
		// (get) Token: 0x06008085 RID: 32901 RVA: 0x00234DB0 File Offset: 0x00232FB0
		// (set) Token: 0x06008086 RID: 32902 RVA: 0x0003D0CE File Offset: 0x0003B2CE
		public unsafe float MaxAimFOVReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MaxAimFOVReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MaxAimFOVReduction)) = value;
			}
		}

		// Token: 0x170027AE RID: 10158
		// (get) Token: 0x06008087 RID: 32903 RVA: 0x00234DD8 File Offset: 0x00232FD8
		// (set) Token: 0x06008088 RID: 32904 RVA: 0x0003D0E9 File Offset: 0x0003B2E9
		public unsafe AudioSourceController FireSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027AF RID: 10159
		// (get) Token: 0x06008089 RID: 32905 RVA: 0x00234E08 File Offset: 0x00233008
		// (set) Token: 0x0600808A RID: 32906 RVA: 0x0003D108 File Offset: 0x0003B308
		public unsafe AudioSourceController EmptySound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_EmptySound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_EmptySound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B0 RID: 10160
		// (get) Token: 0x0600808B RID: 32907 RVA: 0x00234E38 File Offset: 0x00233038
		// (set) Token: 0x0600808C RID: 32908 RVA: 0x0003D127 File Offset: 0x0003B327
		public unsafe float FireCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireCooldown)) = value;
			}
		}

		// Token: 0x170027B1 RID: 10161
		// (get) Token: 0x0600808D RID: 32909 RVA: 0x00234E60 File Offset: 0x00233060
		// (set) Token: 0x0600808E RID: 32910 RVA: 0x0003D142 File Offset: 0x0003B342
		public unsafe Il2CppStringArray FireAnimTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireAnimTriggers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireAnimTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B2 RID: 10162
		// (get) Token: 0x0600808F RID: 32911 RVA: 0x00234E90 File Offset: 0x00233090
		// (set) Token: 0x06008090 RID: 32912 RVA: 0x0003D161 File Offset: 0x0003B361
		public unsafe float AccuracyChangeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AccuracyChangeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AccuracyChangeDuration)) = value;
			}
		}

		// Token: 0x170027B3 RID: 10163
		// (get) Token: 0x06008091 RID: 32913 RVA: 0x00234EB8 File Offset: 0x002330B8
		// (set) Token: 0x06008092 RID: 32914 RVA: 0x0003D17C File Offset: 0x0003B37C
		public unsafe float AccuracyDropPerShot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AccuracyDropPerShot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AccuracyDropPerShot)) = value;
			}
		}

		// Token: 0x170027B4 RID: 10164
		// (get) Token: 0x06008093 RID: 32915 RVA: 0x00234EE0 File Offset: 0x002330E0
		// (set) Token: 0x06008094 RID: 32916 RVA: 0x0003D197 File Offset: 0x0003B397
		public unsafe float Range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Range)) = value;
			}
		}

		// Token: 0x170027B5 RID: 10165
		// (get) Token: 0x06008095 RID: 32917 RVA: 0x00234F08 File Offset: 0x00233108
		// (set) Token: 0x06008096 RID: 32918 RVA: 0x0003D1B2 File Offset: 0x0003B3B2
		public unsafe float RayRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_RayRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_RayRadius)) = value;
			}
		}

		// Token: 0x170027B6 RID: 10166
		// (get) Token: 0x06008097 RID: 32919 RVA: 0x00234F30 File Offset: 0x00233130
		// (set) Token: 0x06008098 RID: 32920 RVA: 0x0003D1CD File Offset: 0x0003B3CD
		public unsafe float MinSpread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MinSpread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MinSpread)) = value;
			}
		}

		// Token: 0x170027B7 RID: 10167
		// (get) Token: 0x06008099 RID: 32921 RVA: 0x00234F58 File Offset: 0x00233158
		// (set) Token: 0x0600809A RID: 32922 RVA: 0x0003D1E8 File Offset: 0x0003B3E8
		public unsafe float MaxSpread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MaxSpread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MaxSpread)) = value;
			}
		}

		// Token: 0x170027B8 RID: 10168
		// (get) Token: 0x0600809B RID: 32923 RVA: 0x00234F80 File Offset: 0x00233180
		// (set) Token: 0x0600809C RID: 32924 RVA: 0x0003D203 File Offset: 0x0003B403
		public unsafe float Damage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Damage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Damage)) = value;
			}
		}

		// Token: 0x170027B9 RID: 10169
		// (get) Token: 0x0600809D RID: 32925 RVA: 0x00234FA8 File Offset: 0x002331A8
		// (set) Token: 0x0600809E RID: 32926 RVA: 0x0003D21E File Offset: 0x0003B41E
		public unsafe float ImpactForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ImpactForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ImpactForce)) = value;
			}
		}

		// Token: 0x170027BA RID: 10170
		// (get) Token: 0x0600809F RID: 32927 RVA: 0x00234FD0 File Offset: 0x002331D0
		// (set) Token: 0x060080A0 RID: 32928 RVA: 0x0003D239 File Offset: 0x0003B439
		public unsafe float HeadshotMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_HeadshotMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_HeadshotMultiplier)) = value;
			}
		}

		// Token: 0x170027BB RID: 10171
		// (get) Token: 0x060080A1 RID: 32929 RVA: 0x00234FF8 File Offset: 0x002331F8
		// (set) Token: 0x060080A2 RID: 32930 RVA: 0x0003D254 File Offset: 0x0003B454
		public unsafe bool CanReload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CanReload);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CanReload)) = value;
			}
		}

		// Token: 0x170027BC RID: 10172
		// (get) Token: 0x060080A3 RID: 32931 RVA: 0x00235020 File Offset: 0x00233220
		// (set) Token: 0x060080A4 RID: 32932 RVA: 0x0003D26F File Offset: 0x0003B46F
		public unsafe Equippable_RangedWeapon.EReloadType ReloadType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadType)) = value;
			}
		}

		// Token: 0x170027BD RID: 10173
		// (get) Token: 0x060080A5 RID: 32933 RVA: 0x00235048 File Offset: 0x00233248
		// (set) Token: 0x060080A6 RID: 32934 RVA: 0x0003D28A File Offset: 0x0003B48A
		public unsafe StorableItemDefinition Magazine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Magazine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Magazine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027BE RID: 10174
		// (get) Token: 0x060080A7 RID: 32935 RVA: 0x00235078 File Offset: 0x00233278
		// (set) Token: 0x060080A8 RID: 32936 RVA: 0x0003D2A9 File Offset: 0x0003B4A9
		public unsafe float ReloadStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartTime)) = value;
			}
		}

		// Token: 0x170027BF RID: 10175
		// (get) Token: 0x060080A9 RID: 32937 RVA: 0x002350A0 File Offset: 0x002332A0
		// (set) Token: 0x060080AA RID: 32938 RVA: 0x0003D2C4 File Offset: 0x0003B4C4
		public unsafe float ReloadIndividalTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividalTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividalTime)) = value;
			}
		}

		// Token: 0x170027C0 RID: 10176
		// (get) Token: 0x060080AB RID: 32939 RVA: 0x002350C8 File Offset: 0x002332C8
		// (set) Token: 0x060080AC RID: 32940 RVA: 0x0003D2DF File Offset: 0x0003B4DF
		public unsafe float ReloadEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndTime)) = value;
			}
		}

		// Token: 0x170027C1 RID: 10177
		// (get) Token: 0x060080AD RID: 32941 RVA: 0x002350F0 File Offset: 0x002332F0
		// (set) Token: 0x060080AE RID: 32942 RVA: 0x0003D2FA File Offset: 0x0003B4FA
		public unsafe string ReloadStartAnimTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartAnimTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartAnimTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027C2 RID: 10178
		// (get) Token: 0x060080AF RID: 32943 RVA: 0x00235118 File Offset: 0x00233318
		// (set) Token: 0x060080B0 RID: 32944 RVA: 0x0003D319 File Offset: 0x0003B519
		public unsafe string ReloadIndividualAnimTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividualAnimTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividualAnimTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027C3 RID: 10179
		// (get) Token: 0x060080B1 RID: 32945 RVA: 0x00235140 File Offset: 0x00233340
		// (set) Token: 0x060080B2 RID: 32946 RVA: 0x0003D338 File Offset: 0x0003B538
		public unsafe string ReloadEndAnimTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndAnimTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndAnimTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027C4 RID: 10180
		// (get) Token: 0x060080B3 RID: 32947 RVA: 0x00235168 File Offset: 0x00233368
		// (set) Token: 0x060080B4 RID: 32948 RVA: 0x0003D357 File Offset: 0x0003B557
		public unsafe TrashItem ReloadTrash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadTrash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadTrash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027C5 RID: 10181
		// (get) Token: 0x060080B5 RID: 32949 RVA: 0x00235198 File Offset: 0x00233398
		// (set) Token: 0x060080B6 RID: 32950 RVA: 0x0003D376 File Offset: 0x0003B576
		public unsafe bool MustBeCocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MustBeCocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MustBeCocked)) = value;
			}
		}

		// Token: 0x170027C6 RID: 10182
		// (get) Token: 0x060080B7 RID: 32951 RVA: 0x002351C0 File Offset: 0x002333C0
		// (set) Token: 0x060080B8 RID: 32952 RVA: 0x0003D391 File Offset: 0x0003B591
		public unsafe bool CockedByDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockedByDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockedByDefault)) = value;
			}
		}

		// Token: 0x170027C7 RID: 10183
		// (get) Token: 0x060080B9 RID: 32953 RVA: 0x002351E8 File Offset: 0x002333E8
		// (set) Token: 0x060080BA RID: 32954 RVA: 0x0003D3AC File Offset: 0x0003B5AC
		public unsafe bool AutoCockAfterReload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AutoCockAfterReload);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AutoCockAfterReload)) = value;
			}
		}

		// Token: 0x170027C8 RID: 10184
		// (get) Token: 0x060080BB RID: 32955 RVA: 0x00235210 File Offset: 0x00233410
		// (set) Token: 0x060080BC RID: 32956 RVA: 0x0003D3C7 File Offset: 0x0003B5C7
		public unsafe float CockTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockTime)) = value;
			}
		}

		// Token: 0x170027C9 RID: 10185
		// (get) Token: 0x060080BD RID: 32957 RVA: 0x00235238 File Offset: 0x00233438
		// (set) Token: 0x060080BE RID: 32958 RVA: 0x0003D3E2 File Offset: 0x0003B5E2
		public unsafe string CockAnimTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockAnimTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockAnimTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027CA RID: 10186
		// (get) Token: 0x060080BF RID: 32959 RVA: 0x00235260 File Offset: 0x00233460
		// (set) Token: 0x060080C0 RID: 32960 RVA: 0x0003D401 File Offset: 0x0003B601
		public unsafe float TracerSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_TracerSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_TracerSpeed)) = value;
			}
		}

		// Token: 0x170027CB RID: 10187
		// (get) Token: 0x060080C1 RID: 32961 RVA: 0x00235288 File Offset: 0x00233488
		// (set) Token: 0x060080C2 RID: 32962 RVA: 0x0003D41C File Offset: 0x0003B61C
		public unsafe UnityEvent onFire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onFire);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onFire), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027CC RID: 10188
		// (get) Token: 0x060080C3 RID: 32963 RVA: 0x002352B8 File Offset: 0x002334B8
		// (set) Token: 0x060080C4 RID: 32964 RVA: 0x0003D43B File Offset: 0x0003B63B
		public unsafe UnityEvent onReloadStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027CD RID: 10189
		// (get) Token: 0x060080C5 RID: 32965 RVA: 0x002352E8 File Offset: 0x002334E8
		// (set) Token: 0x060080C6 RID: 32966 RVA: 0x0003D45A File Offset: 0x0003B65A
		public unsafe UnityEvent onReloadIndividual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadIndividual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadIndividual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027CE RID: 10190
		// (get) Token: 0x060080C7 RID: 32967 RVA: 0x00235318 File Offset: 0x00233518
		// (set) Token: 0x060080C8 RID: 32968 RVA: 0x0003D479 File Offset: 0x0003B679
		public unsafe UnityEvent onReloadEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027CF RID: 10191
		// (get) Token: 0x060080C9 RID: 32969 RVA: 0x00235348 File Offset: 0x00233548
		// (set) Token: 0x060080CA RID: 32970 RVA: 0x0003D498 File Offset: 0x0003B698
		public unsafe UnityEvent onCockStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onCockStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onCockStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D0 RID: 10192
		// (get) Token: 0x060080CB RID: 32971 RVA: 0x00235378 File Offset: 0x00233578
		// (set) Token: 0x060080CC RID: 32972 RVA: 0x0003D4B7 File Offset: 0x0003B6B7
		public unsafe IntegerItemInstance weaponItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_weaponItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntegerItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_weaponItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D1 RID: 10193
		// (get) Token: 0x060080CD RID: 32973 RVA: 0x002353A8 File Offset: 0x002335A8
		// (set) Token: 0x060080CE RID: 32974 RVA: 0x0003D4D6 File Offset: 0x0003B6D6
		public unsafe bool aimStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_aimStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_aimStarted)) = value;
			}
		}

		// Token: 0x170027D2 RID: 10194
		// (get) Token: 0x060080CF RID: 32975 RVA: 0x002353D0 File Offset: 0x002335D0
		// (set) Token: 0x060080D0 RID: 32976 RVA: 0x0003D4F1 File Offset: 0x0003B6F1
		public unsafe float aimVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_aimVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_aimVelocity)) = value;
			}
		}

		// Token: 0x170027D3 RID: 10195
		// (get) Token: 0x060080D1 RID: 32977 RVA: 0x002353F8 File Offset: 0x002335F8
		// (set) Token: 0x060080D2 RID: 32978 RVA: 0x0003D50C File Offset: 0x0003B70C
		public unsafe Coroutine reloadRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_reloadRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_reloadRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027D4 RID: 10196
		// (get) Token: 0x060080D3 RID: 32979 RVA: 0x00235428 File Offset: 0x00233628
		// (set) Token: 0x060080D4 RID: 32980 RVA: 0x0003D52B File Offset: 0x0003B72B
		public unsafe bool shotQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_shotQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_shotQueued)) = value;
			}
		}

		// Token: 0x170027D5 RID: 10197
		// (get) Token: 0x060080D5 RID: 32981 RVA: 0x00235450 File Offset: 0x00233650
		// (set) Token: 0x060080D6 RID: 32982 RVA: 0x0003D546 File Offset: 0x0003B746
		public unsafe bool reloadQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_reloadQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_reloadQueued)) = value;
			}
		}

		// Token: 0x170027D6 RID: 10198
		// (get) Token: 0x060080D7 RID: 32983 RVA: 0x00235478 File Offset: 0x00233678
		// (set) Token: 0x060080D8 RID: 32984 RVA: 0x0003D561 File Offset: 0x0003B761
		public unsafe float timeSincePrimaryClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_timeSincePrimaryClick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_timeSincePrimaryClick)) = value;
			}
		}

		// Token: 0x170027D7 RID: 10199
		// (get) Token: 0x060080D9 RID: 32985 RVA: 0x002354A0 File Offset: 0x002336A0
		// (set) Token: 0x060080DA RID: 32986 RVA: 0x0003D57C File Offset: 0x0003B77C
		public unsafe float timeSinceReloadStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_timeSinceReloadStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_timeSinceReloadStart)) = value;
			}
		}

		// Token: 0x170027D8 RID: 10200
		// (get) Token: 0x060080DB RID: 32987 RVA: 0x002354C8 File Offset: 0x002336C8
		// (set) Token: 0x060080DC RID: 32988 RVA: 0x0003D597 File Offset: 0x0003B797
		public unsafe float timeSinceAimStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_timeSinceAimStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_timeSinceAimStart)) = value;
			}
		}

		// Token: 0x170027D9 RID: 10201
		// (get) Token: 0x060080DD RID: 32989 RVA: 0x002354F0 File Offset: 0x002336F0
		// (set) Token: 0x060080DE RID: 32990 RVA: 0x0003D5B2 File Offset: 0x0003B7B2
		public unsafe bool interruptReload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_interruptReload);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_interruptReload)) = value;
			}
		}

		// Token: 0x0400577F RID: 22399
		private static readonly IntPtr NativeFieldInfoPtr_NPC_AIM_DETECTION_RANGE;

		// Token: 0x04005780 RID: 22400
		private static readonly IntPtr NativeFieldInfoPtr__Aim_k__BackingField;

		// Token: 0x04005781 RID: 22401
		private static readonly IntPtr NativeFieldInfoPtr__Accuracy_k__BackingField;

		// Token: 0x04005782 RID: 22402
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceFire_k__BackingField;

		// Token: 0x04005783 RID: 22403
		private static readonly IntPtr NativeFieldInfoPtr__IsReloading_k__BackingField;

		// Token: 0x04005784 RID: 22404
		private static readonly IntPtr NativeFieldInfoPtr__IsCocked_k__BackingField;

		// Token: 0x04005785 RID: 22405
		private static readonly IntPtr NativeFieldInfoPtr__IsCocking_k__BackingField;

		// Token: 0x04005786 RID: 22406
		private static readonly IntPtr NativeFieldInfoPtr_MagazineSize;

		// Token: 0x04005787 RID: 22407
		private static readonly IntPtr NativeFieldInfoPtr_AimDuration;

		// Token: 0x04005788 RID: 22408
		private static readonly IntPtr NativeFieldInfoPtr_MinAimFOVReduction;

		// Token: 0x04005789 RID: 22409
		private static readonly IntPtr NativeFieldInfoPtr_MaxAimFOVReduction;

		// Token: 0x0400578A RID: 22410
		private static readonly IntPtr NativeFieldInfoPtr_FireSound;

		// Token: 0x0400578B RID: 22411
		private static readonly IntPtr NativeFieldInfoPtr_EmptySound;

		// Token: 0x0400578C RID: 22412
		private static readonly IntPtr NativeFieldInfoPtr_FireCooldown;

		// Token: 0x0400578D RID: 22413
		private static readonly IntPtr NativeFieldInfoPtr_FireAnimTriggers;

		// Token: 0x0400578E RID: 22414
		private static readonly IntPtr NativeFieldInfoPtr_AccuracyChangeDuration;

		// Token: 0x0400578F RID: 22415
		private static readonly IntPtr NativeFieldInfoPtr_AccuracyDropPerShot;

		// Token: 0x04005790 RID: 22416
		private static readonly IntPtr NativeFieldInfoPtr_Range;

		// Token: 0x04005791 RID: 22417
		private static readonly IntPtr NativeFieldInfoPtr_RayRadius;

		// Token: 0x04005792 RID: 22418
		private static readonly IntPtr NativeFieldInfoPtr_MinSpread;

		// Token: 0x04005793 RID: 22419
		private static readonly IntPtr NativeFieldInfoPtr_MaxSpread;

		// Token: 0x04005794 RID: 22420
		private static readonly IntPtr NativeFieldInfoPtr_Damage;

		// Token: 0x04005795 RID: 22421
		private static readonly IntPtr NativeFieldInfoPtr_ImpactForce;

		// Token: 0x04005796 RID: 22422
		private static readonly IntPtr NativeFieldInfoPtr_HeadshotMultiplier;

		// Token: 0x04005797 RID: 22423
		private static readonly IntPtr NativeFieldInfoPtr_CanReload;

		// Token: 0x04005798 RID: 22424
		private static readonly IntPtr NativeFieldInfoPtr_ReloadType;

		// Token: 0x04005799 RID: 22425
		private static readonly IntPtr NativeFieldInfoPtr_Magazine;

		// Token: 0x0400579A RID: 22426
		private static readonly IntPtr NativeFieldInfoPtr_ReloadStartTime;

		// Token: 0x0400579B RID: 22427
		private static readonly IntPtr NativeFieldInfoPtr_ReloadIndividalTime;

		// Token: 0x0400579C RID: 22428
		private static readonly IntPtr NativeFieldInfoPtr_ReloadEndTime;

		// Token: 0x0400579D RID: 22429
		private static readonly IntPtr NativeFieldInfoPtr_ReloadStartAnimTrigger;

		// Token: 0x0400579E RID: 22430
		private static readonly IntPtr NativeFieldInfoPtr_ReloadIndividualAnimTrigger;

		// Token: 0x0400579F RID: 22431
		private static readonly IntPtr NativeFieldInfoPtr_ReloadEndAnimTrigger;

		// Token: 0x040057A0 RID: 22432
		private static readonly IntPtr NativeFieldInfoPtr_ReloadTrash;

		// Token: 0x040057A1 RID: 22433
		private static readonly IntPtr NativeFieldInfoPtr_MustBeCocked;

		// Token: 0x040057A2 RID: 22434
		private static readonly IntPtr NativeFieldInfoPtr_CockedByDefault;

		// Token: 0x040057A3 RID: 22435
		private static readonly IntPtr NativeFieldInfoPtr_AutoCockAfterReload;

		// Token: 0x040057A4 RID: 22436
		private static readonly IntPtr NativeFieldInfoPtr_CockTime;

		// Token: 0x040057A5 RID: 22437
		private static readonly IntPtr NativeFieldInfoPtr_CockAnimTrigger;

		// Token: 0x040057A6 RID: 22438
		private static readonly IntPtr NativeFieldInfoPtr_TracerSpeed;

		// Token: 0x040057A7 RID: 22439
		private static readonly IntPtr NativeFieldInfoPtr_onFire;

		// Token: 0x040057A8 RID: 22440
		private static readonly IntPtr NativeFieldInfoPtr_onReloadStart;

		// Token: 0x040057A9 RID: 22441
		private static readonly IntPtr NativeFieldInfoPtr_onReloadIndividual;

		// Token: 0x040057AA RID: 22442
		private static readonly IntPtr NativeFieldInfoPtr_onReloadEnd;

		// Token: 0x040057AB RID: 22443
		private static readonly IntPtr NativeFieldInfoPtr_onCockStart;

		// Token: 0x040057AC RID: 22444
		private static readonly IntPtr NativeFieldInfoPtr_weaponItem;

		// Token: 0x040057AD RID: 22445
		private static readonly IntPtr NativeFieldInfoPtr_aimStarted;

		// Token: 0x040057AE RID: 22446
		private static readonly IntPtr NativeFieldInfoPtr_aimVelocity;

		// Token: 0x040057AF RID: 22447
		private static readonly IntPtr NativeFieldInfoPtr_reloadRoutine;

		// Token: 0x040057B0 RID: 22448
		private static readonly IntPtr NativeFieldInfoPtr_shotQueued;

		// Token: 0x040057B1 RID: 22449
		private static readonly IntPtr NativeFieldInfoPtr_reloadQueued;

		// Token: 0x040057B2 RID: 22450
		private static readonly IntPtr NativeFieldInfoPtr_timeSincePrimaryClick;

		// Token: 0x040057B3 RID: 22451
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceReloadStart;

		// Token: 0x040057B4 RID: 22452
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceAimStart;

		// Token: 0x040057B5 RID: 22453
		private static readonly IntPtr NativeFieldInfoPtr_interruptReload;

		// Token: 0x040057B6 RID: 22454
		private static readonly IntPtr NativeMethodInfoPtr_get_Aim_Public_get_Single_0;

		// Token: 0x040057B7 RID: 22455
		private static readonly IntPtr NativeMethodInfoPtr_set_Aim_Private_set_Void_Single_0;

		// Token: 0x040057B8 RID: 22456
		private static readonly IntPtr NativeMethodInfoPtr_get_Accuracy_Public_get_Single_0;

		// Token: 0x040057B9 RID: 22457
		private static readonly IntPtr NativeMethodInfoPtr_set_Accuracy_Private_set_Void_Single_0;

		// Token: 0x040057BA RID: 22458
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceFire_Public_get_Single_0;

		// Token: 0x040057BB RID: 22459
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceFire_Public_set_Void_Single_0;

		// Token: 0x040057BC RID: 22460
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReloading_Public_get_Boolean_0;

		// Token: 0x040057BD RID: 22461
		private static readonly IntPtr NativeMethodInfoPtr_set_IsReloading_Private_set_Void_Boolean_0;

		// Token: 0x040057BE RID: 22462
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCocked_Public_get_Boolean_0;

		// Token: 0x040057BF RID: 22463
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCocked_Private_set_Void_Boolean_0;

		// Token: 0x040057C0 RID: 22464
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCocking_Public_get_Boolean_0;

		// Token: 0x040057C1 RID: 22465
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCocking_Private_set_Void_Boolean_0;

		// Token: 0x040057C2 RID: 22466
		private static readonly IntPtr NativeMethodInfoPtr_get_Ammo_Public_get_Int32_0;

		// Token: 0x040057C3 RID: 22467
		private static readonly IntPtr NativeMethodInfoPtr_get_fov_Private_get_Single_0;

		// Token: 0x040057C4 RID: 22468
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040057C5 RID: 22469
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040057C6 RID: 22470
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040057C7 RID: 22471
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x040057C8 RID: 22472
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAnim_Private_Void_0;

		// Token: 0x040057C9 RID: 22473
		private static readonly IntPtr NativeMethodInfoPtr_CanAim_Private_Boolean_0;

		// Token: 0x040057CA RID: 22474
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Public_Virtual_New_Void_0;

		// Token: 0x040057CB RID: 22475
		private static readonly IntPtr NativeMethodInfoPtr_GetBulletDirections_Protected_Virtual_New_Il2CppStructArray_1_Vector3_0;

		// Token: 0x040057CC RID: 22476
		private static readonly IntPtr NativeMethodInfoPtr_SpreadDirection_Protected_Static_Vector3_Vector3_Single_0;

		// Token: 0x040057CD RID: 22477
		private static readonly IntPtr NativeMethodInfoPtr_Reload_Public_Virtual_New_Void_0;

		// Token: 0x040057CE RID: 22478
		private static readonly IntPtr NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_New_Void_0;

		// Token: 0x040057CF RID: 22479
		private static readonly IntPtr NativeMethodInfoPtr_IsReloadReady_Private_Boolean_Boolean_0;

		// Token: 0x040057D0 RID: 22480
		private static readonly IntPtr NativeMethodInfoPtr_GetMagazine_Protected_Virtual_New_Boolean_byref_StorableItemInstance_0;

		// Token: 0x040057D1 RID: 22481
		private static readonly IntPtr NativeMethodInfoPtr_CanFire_Private_Boolean_Boolean_0;

		// Token: 0x040057D2 RID: 22482
		private static readonly IntPtr NativeMethodInfoPtr_CanCock_Private_Boolean_0;

		// Token: 0x040057D3 RID: 22483
		private static readonly IntPtr NativeMethodInfoPtr_Cock_Private_Void_0;

		// Token: 0x040057D4 RID: 22484
		private static readonly IntPtr NativeMethodInfoPtr_GetSpreadAngle_Protected_Single_0;

		// Token: 0x040057D5 RID: 22485
		private static readonly IntPtr NativeMethodInfoPtr_CheckAimingAtNPC_Private_Void_0;

		// Token: 0x040057D6 RID: 22486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040057D7 RID: 22487
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Single_Collider_0;

		// Token: 0x040057D8 RID: 22488
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040057D9 RID: 22489
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x02000BE8 RID: 3048
		[OriginalName("Assembly-CSharp.dll", "", "EReloadType")]
		public enum EReloadType
		{
			// Token: 0x0400A035 RID: 41013
			Magazine,
			// Token: 0x0400A036 RID: 41014
			Incremental
		}

		// Token: 0x02000BE9 RID: 3049
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_RangedWeapon+<<Cock>g__CockRoutine|93_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600ECA8 RID: 60584 RVA: 0x00395A30 File Offset: 0x00393C30
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique()
			{
				Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<<Cock>g__CockRoutine|93_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>1__state");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>2__current");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>4__this");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679837);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679838);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679839);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679840);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679841);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679842);
			}

			// Token: 0x0600ECA9 RID: 60585 RVA: 0x00395B10 File Offset: 0x00393D10
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ECAA RID: 60586 RVA: 0x00395B58 File Offset: 0x00393D58
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ECAB RID: 60587 RVA: 0x00395B8C File Offset: 0x00393D8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243874, XrefRangeEnd = 243885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170047C3 RID: 18371
			// (get) Token: 0x0600ECAC RID: 60588 RVA: 0x00395BC8 File Offset: 0x00393DC8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ECAD RID: 60589 RVA: 0x00395C08 File Offset: 0x00393E08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243885, XrefRangeEnd = 243890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170047C4 RID: 18372
			// (get) Token: 0x0600ECAE RID: 60590 RVA: 0x00395C3C File Offset: 0x00393E3C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ECAF RID: 60591 RVA: 0x0006FA6B File Offset: 0x0006DC6B
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047C0 RID: 18368
			// (get) Token: 0x0600ECB0 RID: 60592 RVA: 0x00395C7C File Offset: 0x00393E7C
			// (set) Token: 0x0600ECB1 RID: 60593 RVA: 0x0006FA74 File Offset: 0x0006DC74
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170047C1 RID: 18369
			// (get) Token: 0x0600ECB2 RID: 60594 RVA: 0x00395CA4 File Offset: 0x00393EA4
			// (set) Token: 0x0600ECB3 RID: 60595 RVA: 0x0006FA8F File Offset: 0x0006DC8F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047C2 RID: 18370
			// (get) Token: 0x0600ECB4 RID: 60596 RVA: 0x00395CD4 File Offset: 0x00393ED4
			// (set) Token: 0x0600ECB5 RID: 60597 RVA: 0x0006FAAE File Offset: 0x0006DCAE
			public unsafe Equippable_RangedWeapon __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_RangedWeapon>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A037 RID: 41015
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A038 RID: 41016
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A039 RID: 41017
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A03A RID: 41018
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A03B RID: 41019
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A03C RID: 41020
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A03D RID: 41021
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A03E RID: 41022
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A03F RID: 41023
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BEA RID: 3050
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_RangedWeapon+<<Reload>g__ReloadRoutine|87_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600ECB6 RID: 60598 RVA: 0x00395D04 File Offset: 0x00393F04
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique()
			{
				Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<<Reload>g__ReloadRoutine|87_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, "<>1__state");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, "<>2__current");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, "<>4__this");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr__mag_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, "<mag>5__2");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679843);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679844);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679845);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679846);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679847);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679848);
			}

			// Token: 0x0600ECB7 RID: 60599 RVA: 0x00395DF8 File Offset: 0x00393FF8
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ECB8 RID: 60600 RVA: 0x00395E40 File Offset: 0x00394040
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ECB9 RID: 60601 RVA: 0x00395E74 File Offset: 0x00394074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243890, XrefRangeEnd = 243908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170047C9 RID: 18377
			// (get) Token: 0x0600ECBA RID: 60602 RVA: 0x00395EB0 File Offset: 0x003940B0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ECBB RID: 60603 RVA: 0x00395EF0 File Offset: 0x003940F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243908, XrefRangeEnd = 243913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170047CA RID: 18378
			// (get) Token: 0x0600ECBC RID: 60604 RVA: 0x00395F24 File Offset: 0x00394124
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ECBD RID: 60605 RVA: 0x0006FACD File Offset: 0x0006DCCD
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047C5 RID: 18373
			// (get) Token: 0x0600ECBE RID: 60606 RVA: 0x00395F64 File Offset: 0x00394164
			// (set) Token: 0x0600ECBF RID: 60607 RVA: 0x0006FAD6 File Offset: 0x0006DCD6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170047C6 RID: 18374
			// (get) Token: 0x0600ECC0 RID: 60608 RVA: 0x00395F8C File Offset: 0x0039418C
			// (set) Token: 0x0600ECC1 RID: 60609 RVA: 0x0006FAF1 File Offset: 0x0006DCF1
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047C7 RID: 18375
			// (get) Token: 0x0600ECC2 RID: 60610 RVA: 0x00395FBC File Offset: 0x003941BC
			// (set) Token: 0x0600ECC3 RID: 60611 RVA: 0x0006FB10 File Offset: 0x0006DD10
			public unsafe Equippable_RangedWeapon __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_RangedWeapon>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047C8 RID: 18376
			// (get) Token: 0x0600ECC4 RID: 60612 RVA: 0x00395FEC File Offset: 0x003941EC
			// (set) Token: 0x0600ECC5 RID: 60613 RVA: 0x0006FB2F File Offset: 0x0006DD2F
			public unsafe StorableItemInstance _mag_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr__mag_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr__mag_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A040 RID: 41024
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A041 RID: 41025
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A042 RID: 41026
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A043 RID: 41027
			private static readonly IntPtr NativeFieldInfoPtr__mag_5__2;

			// Token: 0x0400A044 RID: 41028
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A045 RID: 41029
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A046 RID: 41030
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A047 RID: 41031
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A048 RID: 41032
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A049 RID: 41033
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BEB RID: 3051
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_RangedWeapon+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600ECC6 RID: 60614 RVA: 0x0039601C File Offset: 0x0039421C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr);
				Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr, "<>9");
				Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9__84_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr, "<>9__84_1");
				Equippable_RangedWeapon.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr, 100679850);
				Equippable_RangedWeapon.__c.NativeMethodInfoPtr__Fire_b__84_1_Internal_Int32_RaycastHit_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr, 100679851);
			}

			// Token: 0x0600ECC7 RID: 60615 RVA: 0x00396098 File Offset: 0x00394298
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ECC8 RID: 60616 RVA: 0x003960D4 File Offset: 0x003942D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Fire_b__84_1(RaycastHit a, RaycastHit b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.__c.NativeMethodInfoPtr__Fire_b__84_1_Internal_Int32_RaycastHit_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ECC9 RID: 60617 RVA: 0x0006FB4E File Offset: 0x0006DD4E
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047CB RID: 18379
			// (get) Token: 0x0600ECCA RID: 60618 RVA: 0x0039612C File Offset: 0x0039432C
			// (set) Token: 0x0600ECCB RID: 60619 RVA: 0x0006FB57 File Offset: 0x0006DD57
			public unsafe static Equippable_RangedWeapon.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_RangedWeapon.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047CC RID: 18380
			// (get) Token: 0x0600ECCC RID: 60620 RVA: 0x00396154 File Offset: 0x00394354
			// (set) Token: 0x0600ECCD RID: 60621 RVA: 0x0006FB69 File Offset: 0x0006DD69
			public unsafe static Comparison<RaycastHit> __9__84_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9__84_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<RaycastHit>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9__84_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A04A RID: 41034
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A04B RID: 41035
			private static readonly IntPtr NativeFieldInfoPtr___9__84_1;

			// Token: 0x0400A04C RID: 41036
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A04D RID: 41037
			private static readonly IntPtr NativeMethodInfoPtr__Fire_b__84_1_Internal_Int32_RaycastHit_RaycastHit_0;
		}

		// Token: 0x02000BEC RID: 3052
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_RangedWeapon+<>c__DisplayClass84_0")]
		public sealed class __c__DisplayClass84_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ECCE RID: 60622 RVA: 0x0039617C File Offset: 0x0039437C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass84_0()
			{
				Il2CppClassPointerStore<Equippable_RangedWeapon.__c__DisplayClass84_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<>c__DisplayClass84_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_RangedWeapon.__c__DisplayClass84_0>.NativeClassPtr);
				Equippable_RangedWeapon.__c__DisplayClass84_0.NativeFieldInfoPtr_hitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.__c__DisplayClass84_0>.NativeClassPtr, "hitPoint");
				Equippable_RangedWeapon.__c__DisplayClass84_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.__c__DisplayClass84_0>.NativeClassPtr, 100679852);
				Equippable_RangedWeapon.__c__DisplayClass84_0.NativeMethodInfoPtr__Fire_b__2_Internal_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.__c__DisplayClass84_0>.NativeClassPtr, 100679853);
			}

			// Token: 0x0600ECCF RID: 60623 RVA: 0x003961E4 File Offset: 0x003943E4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass84_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_RangedWeapon.__c__DisplayClass84_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.__c__DisplayClass84_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ECD0 RID: 60624 RVA: 0x00396220 File Offset: 0x00394420
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243913, XrefRangeEnd = 243914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Fire_b__2(RaycastHit hit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref hit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.__c__DisplayClass84_0.NativeMethodInfoPtr__Fire_b__2_Internal_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ECD1 RID: 60625 RVA: 0x0006FB7B File Offset: 0x0006DD7B
			public __c__DisplayClass84_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047CD RID: 18381
			// (get) Token: 0x0600ECD2 RID: 60626 RVA: 0x00396260 File Offset: 0x00394460
			// (set) Token: 0x0600ECD3 RID: 60627 RVA: 0x0006FB84 File Offset: 0x0006DD84
			public unsafe Vector3 hitPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.__c__DisplayClass84_0.NativeFieldInfoPtr_hitPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.__c__DisplayClass84_0.NativeFieldInfoPtr_hitPoint)) = value;
				}
			}

			// Token: 0x0400A04E RID: 41038
			private static readonly IntPtr NativeFieldInfoPtr_hitPoint;

			// Token: 0x0400A04F RID: 41039
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A050 RID: 41040
			private static readonly IntPtr NativeMethodInfoPtr__Fire_b__2_Internal_Void_RaycastHit_0;
		}
	}
}
