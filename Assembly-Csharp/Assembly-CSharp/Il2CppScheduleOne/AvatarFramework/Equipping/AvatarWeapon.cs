using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x020004C7 RID: 1223
	public class AvatarWeapon : AvatarEquippable
	{
		// Token: 0x06007032 RID: 28722 RVA: 0x001FCADC File Offset: 0x001FACDC
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarWeapon()
		{
			Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr);
			AvatarWeapon.NativeFieldInfoPtr_MinUseRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "MinUseRange");
			AvatarWeapon.NativeFieldInfoPtr_MaxUseRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "MaxUseRange");
			AvatarWeapon.NativeFieldInfoPtr_CooldownDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "CooldownDuration");
			AvatarWeapon.NativeFieldInfoPtr_EquipClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "EquipClips");
			AvatarWeapon.NativeFieldInfoPtr_EquipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "EquipSound");
			AvatarWeapon.NativeFieldInfoPtr_EquipDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "EquipDuration");
			AvatarWeapon.NativeFieldInfoPtr__LastUseTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "<LastUseTime>k__BackingField");
			AvatarWeapon.NativeFieldInfoPtr_onSuccessfulHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "onSuccessfulHit");
			AvatarWeapon.NativeFieldInfoPtr__timeOnEquip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "_timeOnEquip");
			AvatarWeapon.NativeMethodInfoPtr_get_LastUseTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100677818);
			AvatarWeapon.NativeMethodInfoPtr_set_LastUseTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100677819);
			AvatarWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100677820);
			AvatarWeapon.NativeMethodInfoPtr_Attack_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100677821);
			AvatarWeapon.NativeMethodInfoPtr_IsReadyToAttack_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100677822);
			AvatarWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100677823);
		}

		// Token: 0x170022B7 RID: 8887
		// (get) Token: 0x06007033 RID: 28723 RVA: 0x001FCC38 File Offset: 0x001FAE38
		// (set) Token: 0x06007034 RID: 28724 RVA: 0x001FCC74 File Offset: 0x001FAE74
		public unsafe float LastUseTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarWeapon.NativeMethodInfoPtr_get_LastUseTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarWeapon.NativeMethodInfoPtr_set_LastUseTime_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007035 RID: 28725 RVA: 0x001FCCB4 File Offset: 0x001FAEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224384, XrefRangeEnd = 224392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(Avatar _avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007036 RID: 28726 RVA: 0x001FCD04 File Offset: 0x001FAF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224392, XrefRangeEnd = 224393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Attack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarWeapon.NativeMethodInfoPtr_Attack_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007037 RID: 28727 RVA: 0x001FCD40 File Offset: 0x001FAF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224393, XrefRangeEnd = 224394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsReadyToAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarWeapon.NativeMethodInfoPtr_IsReadyToAttack_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007038 RID: 28728 RVA: 0x001FCD88 File Offset: 0x001FAF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224394, XrefRangeEnd = 224395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007039 RID: 28729 RVA: 0x000354CD File Offset: 0x000336CD
		public AvatarWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022AE RID: 8878
		// (get) Token: 0x0600703A RID: 28730 RVA: 0x001FCDC4 File Offset: 0x001FAFC4
		// (set) Token: 0x0600703B RID: 28731 RVA: 0x000354D6 File Offset: 0x000336D6
		public unsafe float MinUseRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_MinUseRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_MinUseRange)) = value;
			}
		}

		// Token: 0x170022AF RID: 8879
		// (get) Token: 0x0600703C RID: 28732 RVA: 0x001FCDEC File Offset: 0x001FAFEC
		// (set) Token: 0x0600703D RID: 28733 RVA: 0x000354F1 File Offset: 0x000336F1
		public unsafe float MaxUseRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_MaxUseRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_MaxUseRange)) = value;
			}
		}

		// Token: 0x170022B0 RID: 8880
		// (get) Token: 0x0600703E RID: 28734 RVA: 0x001FCE14 File Offset: 0x001FB014
		// (set) Token: 0x0600703F RID: 28735 RVA: 0x0003550C File Offset: 0x0003370C
		public unsafe float CooldownDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_CooldownDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_CooldownDuration)) = value;
			}
		}

		// Token: 0x170022B1 RID: 8881
		// (get) Token: 0x06007040 RID: 28736 RVA: 0x001FCE3C File Offset: 0x001FB03C
		// (set) Token: 0x06007041 RID: 28737 RVA: 0x00035527 File Offset: 0x00033727
		public unsafe Il2CppReferenceArray<AudioClip> EquipClips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipClips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B2 RID: 8882
		// (get) Token: 0x06007042 RID: 28738 RVA: 0x001FCE6C File Offset: 0x001FB06C
		// (set) Token: 0x06007043 RID: 28739 RVA: 0x00035546 File Offset: 0x00033746
		public unsafe AudioSourceController EquipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B3 RID: 8883
		// (get) Token: 0x06007044 RID: 28740 RVA: 0x001FCE9C File Offset: 0x001FB09C
		// (set) Token: 0x06007045 RID: 28741 RVA: 0x00035565 File Offset: 0x00033765
		public unsafe float EquipDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipDuration)) = value;
			}
		}

		// Token: 0x170022B4 RID: 8884
		// (get) Token: 0x06007046 RID: 28742 RVA: 0x001FCEC4 File Offset: 0x001FB0C4
		// (set) Token: 0x06007047 RID: 28743 RVA: 0x00035580 File Offset: 0x00033780
		public unsafe float _LastUseTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr__LastUseTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr__LastUseTime_k__BackingField)) = value;
			}
		}

		// Token: 0x170022B5 RID: 8885
		// (get) Token: 0x06007048 RID: 28744 RVA: 0x001FCEEC File Offset: 0x001FB0EC
		// (set) Token: 0x06007049 RID: 28745 RVA: 0x0003559B File Offset: 0x0003379B
		public unsafe UnityEvent onSuccessfulHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_onSuccessfulHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_onSuccessfulHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B6 RID: 8886
		// (get) Token: 0x0600704A RID: 28746 RVA: 0x001FCF1C File Offset: 0x001FB11C
		// (set) Token: 0x0600704B RID: 28747 RVA: 0x000355BA File Offset: 0x000337BA
		public unsafe float _timeOnEquip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr__timeOnEquip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr__timeOnEquip)) = value;
			}
		}

		// Token: 0x04004CC7 RID: 19655
		private static readonly IntPtr NativeFieldInfoPtr_MinUseRange;

		// Token: 0x04004CC8 RID: 19656
		private static readonly IntPtr NativeFieldInfoPtr_MaxUseRange;

		// Token: 0x04004CC9 RID: 19657
		private static readonly IntPtr NativeFieldInfoPtr_CooldownDuration;

		// Token: 0x04004CCA RID: 19658
		private static readonly IntPtr NativeFieldInfoPtr_EquipClips;

		// Token: 0x04004CCB RID: 19659
		private static readonly IntPtr NativeFieldInfoPtr_EquipSound;

		// Token: 0x04004CCC RID: 19660
		private static readonly IntPtr NativeFieldInfoPtr_EquipDuration;

		// Token: 0x04004CCD RID: 19661
		private static readonly IntPtr NativeFieldInfoPtr__LastUseTime_k__BackingField;

		// Token: 0x04004CCE RID: 19662
		private static readonly IntPtr NativeFieldInfoPtr_onSuccessfulHit;

		// Token: 0x04004CCF RID: 19663
		private static readonly IntPtr NativeFieldInfoPtr__timeOnEquip;

		// Token: 0x04004CD0 RID: 19664
		private static readonly IntPtr NativeMethodInfoPtr_get_LastUseTime_Public_get_Single_0;

		// Token: 0x04004CD1 RID: 19665
		private static readonly IntPtr NativeMethodInfoPtr_set_LastUseTime_Private_set_Void_Single_0;

		// Token: 0x04004CD2 RID: 19666
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0;

		// Token: 0x04004CD3 RID: 19667
		private static readonly IntPtr NativeMethodInfoPtr_Attack_Public_Virtual_New_Void_0;

		// Token: 0x04004CD4 RID: 19668
		private static readonly IntPtr NativeMethodInfoPtr_IsReadyToAttack_Public_Virtual_New_Boolean_0;

		// Token: 0x04004CD5 RID: 19669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
