using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Combat;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x020004C6 RID: 1222
	public class AvatarRangedWeapon : AvatarWeapon
	{
		// Token: 0x06006FEE RID: 28654 RVA: 0x001FBF8C File Offset: 0x001FA18C
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarRangedWeapon()
		{
			Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarRangedWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr);
			AvatarRangedWeapon.NativeFieldInfoPtr_MagazineSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "MagazineSize");
			AvatarRangedWeapon.NativeFieldInfoPtr_ReloadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "ReloadTime");
			AvatarRangedWeapon.NativeFieldInfoPtr_MaxFireRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "MaxFireRate");
			AvatarRangedWeapon.NativeFieldInfoPtr_EquipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "EquipTime");
			AvatarRangedWeapon.NativeFieldInfoPtr_RaiseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "RaiseTime");
			AvatarRangedWeapon.NativeFieldInfoPtr_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "Damage");
			AvatarRangedWeapon.NativeFieldInfoPtr_ImpactForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "ImpactForce");
			AvatarRangedWeapon.NativeFieldInfoPtr_CanShootWhileMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "CanShootWhileMoving");
			AvatarRangedWeapon.NativeFieldInfoPtr_MaxMovingShotsBeforeReposition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "MaxMovingShotsBeforeReposition");
			AvatarRangedWeapon.NativeFieldInfoPtr_MaxStationaryShotsBeforeReposition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "MaxStationaryShotsBeforeReposition");
			AvatarRangedWeapon.NativeFieldInfoPtr_RepositionAfterHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "RepositionAfterHit");
			AvatarRangedWeapon.NativeFieldInfoPtr_HitChance_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "HitChance_MinRange");
			AvatarRangedWeapon.NativeFieldInfoPtr_HitChance_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "HitChance_MaxRange");
			AvatarRangedWeapon.NativeFieldInfoPtr_AimTime_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "AimTime_Min");
			AvatarRangedWeapon.NativeFieldInfoPtr_AimTime_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "AimTime_Max");
			AvatarRangedWeapon.NativeFieldInfoPtr_MuzzlePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "MuzzlePoint");
			AvatarRangedWeapon.NativeFieldInfoPtr_FireSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "FireSound");
			AvatarRangedWeapon.NativeFieldInfoPtr_LoweredAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "LoweredAnimationTrigger");
			AvatarRangedWeapon.NativeFieldInfoPtr_RaisedAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "RaisedAnimationTrigger");
			AvatarRangedWeapon.NativeFieldInfoPtr_RecoilAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "RecoilAnimationTrigger");
			AvatarRangedWeapon.NativeFieldInfoPtr__IsRaised_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "<IsRaised>k__BackingField");
			AvatarRangedWeapon.NativeFieldInfoPtr_isReloading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "isReloading");
			AvatarRangedWeapon.NativeFieldInfoPtr_timeEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "timeEquipped");
			AvatarRangedWeapon.NativeFieldInfoPtr_timeRaised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "timeRaised");
			AvatarRangedWeapon.NativeFieldInfoPtr_timeSinceLastShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "timeSinceLastShot");
			AvatarRangedWeapon.NativeFieldInfoPtr_currentAmmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "currentAmmo");
			AvatarRangedWeapon.NativeMethodInfoPtr_get_IsRaised_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100677798);
			AvatarRangedWeapon.NativeMethodInfoPtr_set_IsRaised_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100677799);
			AvatarRangedWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100677800);
			AvatarRangedWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100677801);
			AvatarRangedWeapon.NativeMethodInfoPtr_SetIsRaised_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100677802);
			AvatarRangedWeapon.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100677803);
			AvatarRangedWeapon.NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100677804);
			AvatarRangedWeapon.NativeMethodInfoPtr_CanShoot_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100677805);
			AvatarRangedWeapon.NativeMethodInfoPtr_Shoot_Protected_Virtual_New_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100677806);
			AvatarRangedWeapon.NativeMethodInfoPtr_ApplyHitToDamageable_Public_Virtual_New_Void_IDamageable_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100677807);
			AvatarRangedWeapon.NativeMethodInfoPtr_Reload_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100677808);
			AvatarRangedWeapon.NativeMethodInfoPtr_IsTargetInLoS_Public_Boolean_ICombatTargetable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100677809);
			AvatarRangedWeapon.NativeMethodInfoPtr_GetIdealUseRange_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100677810);
			AvatarRangedWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100677811);
		}

		// Token: 0x170022AD RID: 8877
		// (get) Token: 0x06006FEF RID: 28655 RVA: 0x001FC2DC File Offset: 0x001FA4DC
		// (set) Token: 0x06006FF0 RID: 28656 RVA: 0x001FC318 File Offset: 0x001FA518
		public unsafe bool IsRaised
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_get_IsRaised_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_set_IsRaised_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006FF1 RID: 28657 RVA: 0x001FC358 File Offset: 0x001FA558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224276, XrefRangeEnd = 224284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(Avatar _avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FF2 RID: 28658 RVA: 0x001FC3A8 File Offset: 0x001FA5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224284, XrefRangeEnd = 224285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FF3 RID: 28659 RVA: 0x001FC3E4 File Offset: 0x001FA5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224285, XrefRangeEnd = 224289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsRaised(bool raised)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref raised;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_SetIsRaised_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FF4 RID: 28660 RVA: 0x001FC430 File Offset: 0x001FA630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224289, XrefRangeEnd = 224292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FF5 RID: 28661 RVA: 0x001FC464 File Offset: 0x001FA664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224292, XrefRangeEnd = 224304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReceiveMessage(string message, Il2CppSystem.Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FF6 RID: 28662 RVA: 0x001FC4C4 File Offset: 0x001FA6C4
		[CallerCount(0)]
		public unsafe bool CanShoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_CanShoot_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006FF7 RID: 28663 RVA: 0x001FC500 File Offset: 0x001FA700
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224325, RefRangeEnd = 224327, XrefRangeStart = 224304, XrefRangeEnd = 224325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Shoot(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_Shoot_Protected_Virtual_New_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FF8 RID: 28664 RVA: 0x001FC54C File Offset: 0x001FA74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224327, XrefRangeEnd = 224343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyHitToDamageable(IDamageable damageable, Vector3 hitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(damageable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_ApplyHitToDamageable_Public_Virtual_New_Void_IDamageable_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FF9 RID: 28665 RVA: 0x001FC5A8 File Offset: 0x001FA7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224343, XrefRangeEnd = 224348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Reload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_Reload_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006FFA RID: 28666 RVA: 0x001FC5E8 File Offset: 0x001FA7E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224380, RefRangeEnd = 224381, XrefRangeStart = 224348, XrefRangeEnd = 224380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetInLoS(ICombatTargetable target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_IsTargetInLoS_Public_Boolean_ICombatTargetable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006FFB RID: 28667 RVA: 0x001FC638 File Offset: 0x001FA838
		[CallerCount(0)]
		public unsafe virtual float GetIdealUseRange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_GetIdealUseRange_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006FFC RID: 28668 RVA: 0x001FC680 File Offset: 0x001FA880
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224382, RefRangeEnd = 224384, XrefRangeStart = 224381, XrefRangeEnd = 224382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarRangedWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FFD RID: 28669 RVA: 0x000351F2 File Offset: 0x000333F2
		public AvatarRangedWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002293 RID: 8851
		// (get) Token: 0x06006FFE RID: 28670 RVA: 0x001FC6BC File Offset: 0x001FA8BC
		// (set) Token: 0x06006FFF RID: 28671 RVA: 0x000351FB File Offset: 0x000333FB
		public unsafe int MagazineSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MagazineSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MagazineSize)) = value;
			}
		}

		// Token: 0x17002294 RID: 8852
		// (get) Token: 0x06007000 RID: 28672 RVA: 0x001FC6E4 File Offset: 0x001FA8E4
		// (set) Token: 0x06007001 RID: 28673 RVA: 0x00035216 File Offset: 0x00033416
		public unsafe float ReloadTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_ReloadTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_ReloadTime)) = value;
			}
		}

		// Token: 0x17002295 RID: 8853
		// (get) Token: 0x06007002 RID: 28674 RVA: 0x001FC70C File Offset: 0x001FA90C
		// (set) Token: 0x06007003 RID: 28675 RVA: 0x00035231 File Offset: 0x00033431
		public unsafe float MaxFireRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MaxFireRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MaxFireRate)) = value;
			}
		}

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x06007004 RID: 28676 RVA: 0x001FC734 File Offset: 0x001FA934
		// (set) Token: 0x06007005 RID: 28677 RVA: 0x0003524C File Offset: 0x0003344C
		public unsafe float EquipTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_EquipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_EquipTime)) = value;
			}
		}

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x06007006 RID: 28678 RVA: 0x001FC75C File Offset: 0x001FA95C
		// (set) Token: 0x06007007 RID: 28679 RVA: 0x00035267 File Offset: 0x00033467
		public unsafe float RaiseTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RaiseTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RaiseTime)) = value;
			}
		}

		// Token: 0x17002298 RID: 8856
		// (get) Token: 0x06007008 RID: 28680 RVA: 0x001FC784 File Offset: 0x001FA984
		// (set) Token: 0x06007009 RID: 28681 RVA: 0x00035282 File Offset: 0x00033482
		public unsafe float Damage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_Damage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_Damage)) = value;
			}
		}

		// Token: 0x17002299 RID: 8857
		// (get) Token: 0x0600700A RID: 28682 RVA: 0x001FC7AC File Offset: 0x001FA9AC
		// (set) Token: 0x0600700B RID: 28683 RVA: 0x0003529D File Offset: 0x0003349D
		public unsafe float ImpactForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_ImpactForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_ImpactForce)) = value;
			}
		}

		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x0600700C RID: 28684 RVA: 0x001FC7D4 File Offset: 0x001FA9D4
		// (set) Token: 0x0600700D RID: 28685 RVA: 0x000352B8 File Offset: 0x000334B8
		public unsafe bool CanShootWhileMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_CanShootWhileMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_CanShootWhileMoving)) = value;
			}
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x0600700E RID: 28686 RVA: 0x001FC7FC File Offset: 0x001FA9FC
		// (set) Token: 0x0600700F RID: 28687 RVA: 0x000352D3 File Offset: 0x000334D3
		public unsafe int MaxMovingShotsBeforeReposition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MaxMovingShotsBeforeReposition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MaxMovingShotsBeforeReposition)) = value;
			}
		}

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x06007010 RID: 28688 RVA: 0x001FC824 File Offset: 0x001FAA24
		// (set) Token: 0x06007011 RID: 28689 RVA: 0x000352EE File Offset: 0x000334EE
		public unsafe int MaxStationaryShotsBeforeReposition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MaxStationaryShotsBeforeReposition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MaxStationaryShotsBeforeReposition)) = value;
			}
		}

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x06007012 RID: 28690 RVA: 0x001FC84C File Offset: 0x001FAA4C
		// (set) Token: 0x06007013 RID: 28691 RVA: 0x00035309 File Offset: 0x00033509
		public unsafe bool RepositionAfterHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RepositionAfterHit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RepositionAfterHit)) = value;
			}
		}

		// Token: 0x1700229E RID: 8862
		// (get) Token: 0x06007014 RID: 28692 RVA: 0x001FC874 File Offset: 0x001FAA74
		// (set) Token: 0x06007015 RID: 28693 RVA: 0x00035324 File Offset: 0x00033524
		public unsafe float HitChance_MinRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_HitChance_MinRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_HitChance_MinRange)) = value;
			}
		}

		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x06007016 RID: 28694 RVA: 0x001FC89C File Offset: 0x001FAA9C
		// (set) Token: 0x06007017 RID: 28695 RVA: 0x0003533F File Offset: 0x0003353F
		public unsafe float HitChance_MaxRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_HitChance_MaxRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_HitChance_MaxRange)) = value;
			}
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x06007018 RID: 28696 RVA: 0x001FC8C4 File Offset: 0x001FAAC4
		// (set) Token: 0x06007019 RID: 28697 RVA: 0x0003535A File Offset: 0x0003355A
		public unsafe float AimTime_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_AimTime_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_AimTime_Min)) = value;
			}
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x0600701A RID: 28698 RVA: 0x001FC8EC File Offset: 0x001FAAEC
		// (set) Token: 0x0600701B RID: 28699 RVA: 0x00035375 File Offset: 0x00033575
		public unsafe float AimTime_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_AimTime_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_AimTime_Max)) = value;
			}
		}

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x0600701C RID: 28700 RVA: 0x001FC914 File Offset: 0x001FAB14
		// (set) Token: 0x0600701D RID: 28701 RVA: 0x00035390 File Offset: 0x00033590
		public unsafe Transform MuzzlePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MuzzlePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MuzzlePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022A3 RID: 8867
		// (get) Token: 0x0600701E RID: 28702 RVA: 0x001FC944 File Offset: 0x001FAB44
		// (set) Token: 0x0600701F RID: 28703 RVA: 0x000353AF File Offset: 0x000335AF
		public unsafe AudioSourceController FireSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_FireSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_FireSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022A4 RID: 8868
		// (get) Token: 0x06007020 RID: 28704 RVA: 0x001FC974 File Offset: 0x001FAB74
		// (set) Token: 0x06007021 RID: 28705 RVA: 0x000353CE File Offset: 0x000335CE
		public unsafe string LoweredAnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_LoweredAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_LoweredAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170022A5 RID: 8869
		// (get) Token: 0x06007022 RID: 28706 RVA: 0x001FC99C File Offset: 0x001FAB9C
		// (set) Token: 0x06007023 RID: 28707 RVA: 0x000353ED File Offset: 0x000335ED
		public unsafe string RaisedAnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RaisedAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RaisedAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x06007024 RID: 28708 RVA: 0x001FC9C4 File Offset: 0x001FABC4
		// (set) Token: 0x06007025 RID: 28709 RVA: 0x0003540C File Offset: 0x0003360C
		public unsafe string RecoilAnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RecoilAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RecoilAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x06007026 RID: 28710 RVA: 0x001FC9EC File Offset: 0x001FABEC
		// (set) Token: 0x06007027 RID: 28711 RVA: 0x0003542B File Offset: 0x0003362B
		public unsafe bool _IsRaised_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr__IsRaised_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr__IsRaised_k__BackingField)) = value;
			}
		}

		// Token: 0x170022A8 RID: 8872
		// (get) Token: 0x06007028 RID: 28712 RVA: 0x001FCA14 File Offset: 0x001FAC14
		// (set) Token: 0x06007029 RID: 28713 RVA: 0x00035446 File Offset: 0x00033646
		public unsafe bool isReloading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_isReloading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_isReloading)) = value;
			}
		}

		// Token: 0x170022A9 RID: 8873
		// (get) Token: 0x0600702A RID: 28714 RVA: 0x001FCA3C File Offset: 0x001FAC3C
		// (set) Token: 0x0600702B RID: 28715 RVA: 0x00035461 File Offset: 0x00033661
		public unsafe float timeEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeEquipped)) = value;
			}
		}

		// Token: 0x170022AA RID: 8874
		// (get) Token: 0x0600702C RID: 28716 RVA: 0x001FCA64 File Offset: 0x001FAC64
		// (set) Token: 0x0600702D RID: 28717 RVA: 0x0003547C File Offset: 0x0003367C
		public unsafe float timeRaised
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeRaised);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeRaised)) = value;
			}
		}

		// Token: 0x170022AB RID: 8875
		// (get) Token: 0x0600702E RID: 28718 RVA: 0x001FCA8C File Offset: 0x001FAC8C
		// (set) Token: 0x0600702F RID: 28719 RVA: 0x00035497 File Offset: 0x00033697
		public unsafe float timeSinceLastShot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeSinceLastShot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeSinceLastShot)) = value;
			}
		}

		// Token: 0x170022AC RID: 8876
		// (get) Token: 0x06007030 RID: 28720 RVA: 0x001FCAB4 File Offset: 0x001FACB4
		// (set) Token: 0x06007031 RID: 28721 RVA: 0x000354B2 File Offset: 0x000336B2
		public unsafe int currentAmmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_currentAmmo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_currentAmmo)) = value;
			}
		}

		// Token: 0x04004C9F RID: 19615
		private static readonly IntPtr NativeFieldInfoPtr_MagazineSize;

		// Token: 0x04004CA0 RID: 19616
		private static readonly IntPtr NativeFieldInfoPtr_ReloadTime;

		// Token: 0x04004CA1 RID: 19617
		private static readonly IntPtr NativeFieldInfoPtr_MaxFireRate;

		// Token: 0x04004CA2 RID: 19618
		private static readonly IntPtr NativeFieldInfoPtr_EquipTime;

		// Token: 0x04004CA3 RID: 19619
		private static readonly IntPtr NativeFieldInfoPtr_RaiseTime;

		// Token: 0x04004CA4 RID: 19620
		private static readonly IntPtr NativeFieldInfoPtr_Damage;

		// Token: 0x04004CA5 RID: 19621
		private static readonly IntPtr NativeFieldInfoPtr_ImpactForce;

		// Token: 0x04004CA6 RID: 19622
		private static readonly IntPtr NativeFieldInfoPtr_CanShootWhileMoving;

		// Token: 0x04004CA7 RID: 19623
		private static readonly IntPtr NativeFieldInfoPtr_MaxMovingShotsBeforeReposition;

		// Token: 0x04004CA8 RID: 19624
		private static readonly IntPtr NativeFieldInfoPtr_MaxStationaryShotsBeforeReposition;

		// Token: 0x04004CA9 RID: 19625
		private static readonly IntPtr NativeFieldInfoPtr_RepositionAfterHit;

		// Token: 0x04004CAA RID: 19626
		private static readonly IntPtr NativeFieldInfoPtr_HitChance_MinRange;

		// Token: 0x04004CAB RID: 19627
		private static readonly IntPtr NativeFieldInfoPtr_HitChance_MaxRange;

		// Token: 0x04004CAC RID: 19628
		private static readonly IntPtr NativeFieldInfoPtr_AimTime_Min;

		// Token: 0x04004CAD RID: 19629
		private static readonly IntPtr NativeFieldInfoPtr_AimTime_Max;

		// Token: 0x04004CAE RID: 19630
		private static readonly IntPtr NativeFieldInfoPtr_MuzzlePoint;

		// Token: 0x04004CAF RID: 19631
		private static readonly IntPtr NativeFieldInfoPtr_FireSound;

		// Token: 0x04004CB0 RID: 19632
		private static readonly IntPtr NativeFieldInfoPtr_LoweredAnimationTrigger;

		// Token: 0x04004CB1 RID: 19633
		private static readonly IntPtr NativeFieldInfoPtr_RaisedAnimationTrigger;

		// Token: 0x04004CB2 RID: 19634
		private static readonly IntPtr NativeFieldInfoPtr_RecoilAnimationTrigger;

		// Token: 0x04004CB3 RID: 19635
		private static readonly IntPtr NativeFieldInfoPtr__IsRaised_k__BackingField;

		// Token: 0x04004CB4 RID: 19636
		private static readonly IntPtr NativeFieldInfoPtr_isReloading;

		// Token: 0x04004CB5 RID: 19637
		private static readonly IntPtr NativeFieldInfoPtr_timeEquipped;

		// Token: 0x04004CB6 RID: 19638
		private static readonly IntPtr NativeFieldInfoPtr_timeRaised;

		// Token: 0x04004CB7 RID: 19639
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastShot;

		// Token: 0x04004CB8 RID: 19640
		private static readonly IntPtr NativeFieldInfoPtr_currentAmmo;

		// Token: 0x04004CB9 RID: 19641
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRaised_Public_get_Boolean_0;

		// Token: 0x04004CBA RID: 19642
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRaised_Protected_set_Void_Boolean_0;

		// Token: 0x04004CBB RID: 19643
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0;

		// Token: 0x04004CBC RID: 19644
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04004CBD RID: 19645
		private static readonly IntPtr NativeMethodInfoPtr_SetIsRaised_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04004CBE RID: 19646
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004CBF RID: 19647
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Void_String_Object_0;

		// Token: 0x04004CC0 RID: 19648
		private static readonly IntPtr NativeMethodInfoPtr_CanShoot_Public_Boolean_0;

		// Token: 0x04004CC1 RID: 19649
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Protected_Virtual_New_Void_Vector3_0;

		// Token: 0x04004CC2 RID: 19650
		private static readonly IntPtr NativeMethodInfoPtr_ApplyHitToDamageable_Public_Virtual_New_Void_IDamageable_Vector3_0;

		// Token: 0x04004CC3 RID: 19651
		private static readonly IntPtr NativeMethodInfoPtr_Reload_Private_IEnumerator_0;

		// Token: 0x04004CC4 RID: 19652
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetInLoS_Public_Boolean_ICombatTargetable_0;

		// Token: 0x04004CC5 RID: 19653
		private static readonly IntPtr NativeMethodInfoPtr_GetIdealUseRange_Public_Virtual_New_Single_0;

		// Token: 0x04004CC6 RID: 19654
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B84 RID: 2948
		[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.AvatarRangedWeapon+<Reload>d__37")]
		public sealed class _Reload_d__37 : Il2CppSystem.Object
		{
			// Token: 0x0600E936 RID: 59702 RVA: 0x0038BAE4 File Offset: 0x00389CE4
			// Note: this type is marked as 'beforefieldinit'.
			static _Reload_d__37()
			{
				Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "<Reload>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__37>.NativeClassPtr);
				AvatarRangedWeapon._Reload_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__37>.NativeClassPtr, "<>1__state");
				AvatarRangedWeapon._Reload_d__37.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__37>.NativeClassPtr, "<>2__current");
				AvatarRangedWeapon._Reload_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__37>.NativeClassPtr, "<>4__this");
				AvatarRangedWeapon._Reload_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__37>.NativeClassPtr, 100677812);
				AvatarRangedWeapon._Reload_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__37>.NativeClassPtr, 100677813);
				AvatarRangedWeapon._Reload_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__37>.NativeClassPtr, 100677814);
				AvatarRangedWeapon._Reload_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__37>.NativeClassPtr, 100677815);
				AvatarRangedWeapon._Reload_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__37>.NativeClassPtr, 100677816);
				AvatarRangedWeapon._Reload_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__37>.NativeClassPtr, 100677817);
			}

			// Token: 0x0600E937 RID: 59703 RVA: 0x0038BBC4 File Offset: 0x00389DC4
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Reload_d__37(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__37>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E938 RID: 59704 RVA: 0x0038BC0C File Offset: 0x00389E0C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E939 RID: 59705 RVA: 0x0038BC40 File Offset: 0x00389E40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224266, XrefRangeEnd = 224271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170046C1 RID: 18113
			// (get) Token: 0x0600E93A RID: 59706 RVA: 0x0038BC7C File Offset: 0x00389E7C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E93B RID: 59707 RVA: 0x0038BCBC File Offset: 0x00389EBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224271, XrefRangeEnd = 224276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170046C2 RID: 18114
			// (get) Token: 0x0600E93C RID: 59708 RVA: 0x0038BCF0 File Offset: 0x00389EF0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E93D RID: 59709 RVA: 0x0006E081 File Offset: 0x0006C281
			public _Reload_d__37(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046BE RID: 18110
			// (get) Token: 0x0600E93E RID: 59710 RVA: 0x0038BD30 File Offset: 0x00389F30
			// (set) Token: 0x0600E93F RID: 59711 RVA: 0x0006E08A File Offset: 0x0006C28A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046BF RID: 18111
			// (get) Token: 0x0600E940 RID: 59712 RVA: 0x0038BD58 File Offset: 0x00389F58
			// (set) Token: 0x0600E941 RID: 59713 RVA: 0x0006E0A5 File Offset: 0x0006C2A5
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__37.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__37.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046C0 RID: 18112
			// (get) Token: 0x0600E942 RID: 59714 RVA: 0x0038BD88 File Offset: 0x00389F88
			// (set) Token: 0x0600E943 RID: 59715 RVA: 0x0006E0C4 File Offset: 0x0006C2C4
			public unsafe AvatarRangedWeapon __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarRangedWeapon>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009E2C RID: 40492
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009E2D RID: 40493
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009E2E RID: 40494
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009E2F RID: 40495
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009E30 RID: 40496
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009E31 RID: 40497
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009E32 RID: 40498
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009E33 RID: 40499
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009E34 RID: 40500
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
