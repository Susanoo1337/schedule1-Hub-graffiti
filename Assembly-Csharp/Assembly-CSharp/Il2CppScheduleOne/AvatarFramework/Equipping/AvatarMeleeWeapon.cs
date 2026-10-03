using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x020004C5 RID: 1221
	public class AvatarMeleeWeapon : AvatarWeapon
	{
		// Token: 0x06006FD4 RID: 28628 RVA: 0x001FBB98 File Offset: 0x001F9D98
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarMeleeWeapon()
		{
			Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarMeleeWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr);
			AvatarMeleeWeapon.NativeFieldInfoPtr_AttackSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "AttackSound");
			AvatarMeleeWeapon.NativeFieldInfoPtr_HitSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "HitSound");
			AvatarMeleeWeapon.NativeFieldInfoPtr_ImpactType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "ImpactType");
			AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "AttackRange");
			AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "AttackRadius");
			AvatarMeleeWeapon.NativeFieldInfoPtr_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "Damage");
			AvatarMeleeWeapon.NativeFieldInfoPtr_ImpactForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "ImpactForce");
			AvatarMeleeWeapon.NativeFieldInfoPtr_Attacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "Attacks");
			AvatarMeleeWeapon.NativeFieldInfoPtr_GruntChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "GruntChance");
			AvatarMeleeWeapon.NativeFieldInfoPtr_attackRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "attackRoutine");
			AvatarMeleeWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, 100677785);
			AvatarMeleeWeapon.NativeMethodInfoPtr_IsReadyToAttack_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, 100677786);
			AvatarMeleeWeapon.NativeMethodInfoPtr_Attack_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, 100677787);
			AvatarMeleeWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, 100677788);
		}

		// Token: 0x06006FD5 RID: 28629 RVA: 0x001FBCE0 File Offset: 0x001F9EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224233, XrefRangeEnd = 224236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarMeleeWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FD6 RID: 28630 RVA: 0x001FBD1C File Offset: 0x001F9F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224236, XrefRangeEnd = 224238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsReadyToAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarMeleeWeapon.NativeMethodInfoPtr_IsReadyToAttack_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006FD7 RID: 28631 RVA: 0x001FBD64 File Offset: 0x001F9F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224238, XrefRangeEnd = 224265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Attack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarMeleeWeapon.NativeMethodInfoPtr_Attack_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FD8 RID: 28632 RVA: 0x001FBDA0 File Offset: 0x001F9FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224265, XrefRangeEnd = 224266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarMeleeWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FD9 RID: 28633 RVA: 0x000350CB File Offset: 0x000332CB
		public AvatarMeleeWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002289 RID: 8841
		// (get) Token: 0x06006FDA RID: 28634 RVA: 0x001FBDDC File Offset: 0x001F9FDC
		// (set) Token: 0x06006FDB RID: 28635 RVA: 0x000350D4 File Offset: 0x000332D4
		public unsafe AudioSourceController AttackSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700228A RID: 8842
		// (get) Token: 0x06006FDC RID: 28636 RVA: 0x001FBE0C File Offset: 0x001FA00C
		// (set) Token: 0x06006FDD RID: 28637 RVA: 0x000350F3 File Offset: 0x000332F3
		public unsafe AudioSourceController HitSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_HitSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_HitSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700228B RID: 8843
		// (get) Token: 0x06006FDE RID: 28638 RVA: 0x001FBE3C File Offset: 0x001FA03C
		// (set) Token: 0x06006FDF RID: 28639 RVA: 0x00035112 File Offset: 0x00033312
		public unsafe EImpactType ImpactType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_ImpactType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_ImpactType)) = value;
			}
		}

		// Token: 0x1700228C RID: 8844
		// (get) Token: 0x06006FE0 RID: 28640 RVA: 0x001FBE64 File Offset: 0x001FA064
		// (set) Token: 0x06006FE1 RID: 28641 RVA: 0x0003512D File Offset: 0x0003332D
		public unsafe float AttackRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRange)) = value;
			}
		}

		// Token: 0x1700228D RID: 8845
		// (get) Token: 0x06006FE2 RID: 28642 RVA: 0x001FBE8C File Offset: 0x001FA08C
		// (set) Token: 0x06006FE3 RID: 28643 RVA: 0x00035148 File Offset: 0x00033348
		public unsafe float AttackRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRadius)) = value;
			}
		}

		// Token: 0x1700228E RID: 8846
		// (get) Token: 0x06006FE4 RID: 28644 RVA: 0x001FBEB4 File Offset: 0x001FA0B4
		// (set) Token: 0x06006FE5 RID: 28645 RVA: 0x00035163 File Offset: 0x00033363
		public unsafe float Damage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_Damage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_Damage)) = value;
			}
		}

		// Token: 0x1700228F RID: 8847
		// (get) Token: 0x06006FE6 RID: 28646 RVA: 0x001FBEDC File Offset: 0x001FA0DC
		// (set) Token: 0x06006FE7 RID: 28647 RVA: 0x0003517E File Offset: 0x0003337E
		public unsafe float ImpactForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_ImpactForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_ImpactForce)) = value;
			}
		}

		// Token: 0x17002290 RID: 8848
		// (get) Token: 0x06006FE8 RID: 28648 RVA: 0x001FBF04 File Offset: 0x001FA104
		// (set) Token: 0x06006FE9 RID: 28649 RVA: 0x00035199 File Offset: 0x00033399
		public unsafe Il2CppReferenceArray<AvatarMeleeWeapon.MeleeAttack> Attacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_Attacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarMeleeWeapon.MeleeAttack>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_Attacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002291 RID: 8849
		// (get) Token: 0x06006FEA RID: 28650 RVA: 0x001FBF34 File Offset: 0x001FA134
		// (set) Token: 0x06006FEB RID: 28651 RVA: 0x000351B8 File Offset: 0x000333B8
		public unsafe float GruntChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_GruntChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_GruntChance)) = value;
			}
		}

		// Token: 0x17002292 RID: 8850
		// (get) Token: 0x06006FEC RID: 28652 RVA: 0x001FBF5C File Offset: 0x001FA15C
		// (set) Token: 0x06006FED RID: 28653 RVA: 0x000351D3 File Offset: 0x000333D3
		public unsafe Coroutine attackRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_attackRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_attackRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C91 RID: 19601
		private static readonly IntPtr NativeFieldInfoPtr_AttackSound;

		// Token: 0x04004C92 RID: 19602
		private static readonly IntPtr NativeFieldInfoPtr_HitSound;

		// Token: 0x04004C93 RID: 19603
		private static readonly IntPtr NativeFieldInfoPtr_ImpactType;

		// Token: 0x04004C94 RID: 19604
		private static readonly IntPtr NativeFieldInfoPtr_AttackRange;

		// Token: 0x04004C95 RID: 19605
		private static readonly IntPtr NativeFieldInfoPtr_AttackRadius;

		// Token: 0x04004C96 RID: 19606
		private static readonly IntPtr NativeFieldInfoPtr_Damage;

		// Token: 0x04004C97 RID: 19607
		private static readonly IntPtr NativeFieldInfoPtr_ImpactForce;

		// Token: 0x04004C98 RID: 19608
		private static readonly IntPtr NativeFieldInfoPtr_Attacks;

		// Token: 0x04004C99 RID: 19609
		private static readonly IntPtr NativeFieldInfoPtr_GruntChance;

		// Token: 0x04004C9A RID: 19610
		private static readonly IntPtr NativeFieldInfoPtr_attackRoutine;

		// Token: 0x04004C9B RID: 19611
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04004C9C RID: 19612
		private static readonly IntPtr NativeMethodInfoPtr_IsReadyToAttack_Public_Virtual_Boolean_0;

		// Token: 0x04004C9D RID: 19613
		private static readonly IntPtr NativeMethodInfoPtr_Attack_Public_Virtual_Void_0;

		// Token: 0x04004C9E RID: 19614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B82 RID: 2946
		[Serializable]
		public class MeleeAttack : Il2CppSystem.Object
		{
			// Token: 0x0600E91B RID: 59675 RVA: 0x0038B718 File Offset: 0x00389918
			// Note: this type is marked as 'beforefieldinit'.
			static MeleeAttack()
			{
				Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "MeleeAttack");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr);
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_RangeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "RangeMultiplier");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "DamageMultiplier");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "AnimationTrigger");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "DamageDelay");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackSoundDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "AttackSoundDelay");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "AttackClips");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_HitClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "HitClips");
				AvatarMeleeWeapon.MeleeAttack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, 100677789);
			}

			// Token: 0x0600E91C RID: 59676 RVA: 0x0038B7E4 File Offset: 0x003899E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224157, XrefRangeEnd = 224161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeleeAttack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.MeleeAttack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E91D RID: 59677 RVA: 0x0006DF49 File Offset: 0x0006C149
			public MeleeAttack(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046B4 RID: 18100
			// (get) Token: 0x0600E91E RID: 59678 RVA: 0x0038B820 File Offset: 0x00389A20
			// (set) Token: 0x0600E91F RID: 59679 RVA: 0x0006DF52 File Offset: 0x0006C152
			public unsafe float RangeMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_RangeMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_RangeMultiplier)) = value;
				}
			}

			// Token: 0x170046B5 RID: 18101
			// (get) Token: 0x0600E920 RID: 59680 RVA: 0x0038B848 File Offset: 0x00389A48
			// (set) Token: 0x0600E921 RID: 59681 RVA: 0x0006DF6D File Offset: 0x0006C16D
			public unsafe float DamageMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageMultiplier)) = value;
				}
			}

			// Token: 0x170046B6 RID: 18102
			// (get) Token: 0x0600E922 RID: 59682 RVA: 0x0038B870 File Offset: 0x00389A70
			// (set) Token: 0x0600E923 RID: 59683 RVA: 0x0006DF88 File Offset: 0x0006C188
			public unsafe string AnimationTrigger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AnimationTrigger);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170046B7 RID: 18103
			// (get) Token: 0x0600E924 RID: 59684 RVA: 0x0038B898 File Offset: 0x00389A98
			// (set) Token: 0x0600E925 RID: 59685 RVA: 0x0006DFA7 File Offset: 0x0006C1A7
			public unsafe float DamageDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageDelay)) = value;
				}
			}

			// Token: 0x170046B8 RID: 18104
			// (get) Token: 0x0600E926 RID: 59686 RVA: 0x0038B8C0 File Offset: 0x00389AC0
			// (set) Token: 0x0600E927 RID: 59687 RVA: 0x0006DFC2 File Offset: 0x0006C1C2
			public unsafe float AttackSoundDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackSoundDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackSoundDelay)) = value;
				}
			}

			// Token: 0x170046B9 RID: 18105
			// (get) Token: 0x0600E928 RID: 59688 RVA: 0x0038B8E8 File Offset: 0x00389AE8
			// (set) Token: 0x0600E929 RID: 59689 RVA: 0x0006DFDD File Offset: 0x0006C1DD
			public unsafe Il2CppReferenceArray<AudioClip> AttackClips
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackClips);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackClips), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046BA RID: 18106
			// (get) Token: 0x0600E92A RID: 59690 RVA: 0x0038B918 File Offset: 0x00389B18
			// (set) Token: 0x0600E92B RID: 59691 RVA: 0x0006DFFC File Offset: 0x0006C1FC
			public unsafe Il2CppReferenceArray<AudioClip> HitClips
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_HitClips);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_HitClips), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009E1F RID: 40479
			private static readonly IntPtr NativeFieldInfoPtr_RangeMultiplier;

			// Token: 0x04009E20 RID: 40480
			private static readonly IntPtr NativeFieldInfoPtr_DamageMultiplier;

			// Token: 0x04009E21 RID: 40481
			private static readonly IntPtr NativeFieldInfoPtr_AnimationTrigger;

			// Token: 0x04009E22 RID: 40482
			private static readonly IntPtr NativeFieldInfoPtr_DamageDelay;

			// Token: 0x04009E23 RID: 40483
			private static readonly IntPtr NativeFieldInfoPtr_AttackSoundDelay;

			// Token: 0x04009E24 RID: 40484
			private static readonly IntPtr NativeFieldInfoPtr_AttackClips;

			// Token: 0x04009E25 RID: 40485
			private static readonly IntPtr NativeFieldInfoPtr_HitClips;

			// Token: 0x04009E26 RID: 40486
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B83 RID: 2947
		[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.AvatarMeleeWeapon+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E92C RID: 59692 RVA: 0x0038B948 File Offset: 0x00389B48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0>.NativeClassPtr);
				AvatarMeleeWeapon.__c__DisplayClass13_0.NativeFieldInfoPtr_attack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0>.NativeClassPtr, "attack");
				AvatarMeleeWeapon.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				AvatarMeleeWeapon.__c__DisplayClass13_0.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0>.NativeClassPtr, "npc");
				AvatarMeleeWeapon.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0>.NativeClassPtr, 100677790);
				AvatarMeleeWeapon.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0>.NativeClassPtr, 100677791);
			}

			// Token: 0x0600E92D RID: 59693 RVA: 0x0038B9D8 File Offset: 0x00389BD8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E92E RID: 59694 RVA: 0x0038BA14 File Offset: 0x00389C14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224228, XrefRangeEnd = 224233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E92F RID: 59695 RVA: 0x0006E01B File Offset: 0x0006C21B
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046BB RID: 18107
			// (get) Token: 0x0600E930 RID: 59696 RVA: 0x0038BA54 File Offset: 0x00389C54
			// (set) Token: 0x0600E931 RID: 59697 RVA: 0x0006E024 File Offset: 0x0006C224
			public unsafe AvatarMeleeWeapon.MeleeAttack attack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass13_0.NativeFieldInfoPtr_attack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarMeleeWeapon.MeleeAttack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass13_0.NativeFieldInfoPtr_attack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046BC RID: 18108
			// (get) Token: 0x0600E932 RID: 59698 RVA: 0x0038BA84 File Offset: 0x00389C84
			// (set) Token: 0x0600E933 RID: 59699 RVA: 0x0006E043 File Offset: 0x0006C243
			public unsafe AvatarMeleeWeapon __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarMeleeWeapon>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046BD RID: 18109
			// (get) Token: 0x0600E934 RID: 59700 RVA: 0x0038BAB4 File Offset: 0x00389CB4
			// (set) Token: 0x0600E935 RID: 59701 RVA: 0x0006E062 File Offset: 0x0006C262
			public unsafe NPC npc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass13_0.NativeFieldInfoPtr_npc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass13_0.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009E27 RID: 40487
			private static readonly IntPtr NativeFieldInfoPtr_attack;

			// Token: 0x04009E28 RID: 40488
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009E29 RID: 40489
			private static readonly IntPtr NativeFieldInfoPtr_npc;

			// Token: 0x04009E2A RID: 40490
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009E2B RID: 40491
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DE6 RID: 3558
			[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.AvatarMeleeWeapon+<>c__DisplayClass13_0+<<Attack>g__AttackRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060100B2 RID: 65714 RVA: 0x003CF9A4 File Offset: 0x003CDBA4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0>.NativeClassPtr, "<<Attack>g__AttackRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677792);
					AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677793);
					AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677794);
					AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677795);
					AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677796);
					AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677797);
				}

				// Token: 0x060100B3 RID: 65715 RVA: 0x003CFA84 File Offset: 0x003CDC84
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060100B4 RID: 65716 RVA: 0x003CFACC File Offset: 0x003CDCCC
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060100B5 RID: 65717 RVA: 0x003CFB00 File Offset: 0x003CDD00
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224161, XrefRangeEnd = 224223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E3F RID: 20031
				// (get) Token: 0x060100B6 RID: 65718 RVA: 0x003CFB3C File Offset: 0x003CDD3C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060100B7 RID: 65719 RVA: 0x003CFB7C File Offset: 0x003CDD7C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224223, XrefRangeEnd = 224228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E40 RID: 20032
				// (get) Token: 0x060100B8 RID: 65720 RVA: 0x003CFBB0 File Offset: 0x003CDDB0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060100B9 RID: 65721 RVA: 0x00079ACA File Offset: 0x00077CCA
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E3C RID: 20028
				// (get) Token: 0x060100BA RID: 65722 RVA: 0x003CFBF0 File Offset: 0x003CDDF0
				// (set) Token: 0x060100BB RID: 65723 RVA: 0x00079AD3 File Offset: 0x00077CD3
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004E3D RID: 20029
				// (get) Token: 0x060100BC RID: 65724 RVA: 0x003CFC18 File Offset: 0x003CDE18
				// (set) Token: 0x060100BD RID: 65725 RVA: 0x00079AEE File Offset: 0x00077CEE
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E3E RID: 20030
				// (get) Token: 0x060100BE RID: 65726 RVA: 0x003CFC48 File Offset: 0x003CDE48
				// (set) Token: 0x060100BF RID: 65727 RVA: 0x00079B0D File Offset: 0x00077D0D
				public unsafe AvatarMeleeWeapon.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarMeleeWeapon.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400ACE2 RID: 44258
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ACE3 RID: 44259
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ACE4 RID: 44260
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ACE5 RID: 44261
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ACE6 RID: 44262
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACE7 RID: 44263
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ACE8 RID: 44264
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ACE9 RID: 44265
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACEA RID: 44266
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
