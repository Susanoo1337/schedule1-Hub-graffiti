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
	// Token: 0x020004C8 RID: 1224
	public class Taser : AvatarRangedWeapon
	{
		// Token: 0x0600704C RID: 28748 RVA: 0x001FCF44 File Offset: 0x001FB144
		// Note: this type is marked as 'beforefieldinit'.
		static Taser()
		{
			Il2CppClassPointerStore<Taser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "Taser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Taser>.NativeClassPtr);
			Taser.NativeFieldInfoPtr_TaseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "TaseDuration");
			Taser.NativeFieldInfoPtr_TaseMoveSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "TaseMoveSpeedMultiplier");
			Taser.NativeFieldInfoPtr_FlashObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "FlashObject");
			Taser.NativeFieldInfoPtr_ChargeSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "ChargeSound");
			Taser.NativeFieldInfoPtr_RayPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "RayPrefab");
			Taser.NativeFieldInfoPtr_flashRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "flashRoutine");
			Taser.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100677824);
			Taser.NativeMethodInfoPtr_Shoot_Protected_Virtual_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100677825);
			Taser.NativeMethodInfoPtr_ApplyHitToDamageable_Public_Virtual_Void_IDamageable_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100677826);
			Taser.NativeMethodInfoPtr_SetIsRaised_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100677827);
			Taser.NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100677828);
			Taser.NativeMethodInfoPtr_GetIdealUseRange_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100677829);
			Taser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100677830);
		}

		// Token: 0x0600704D RID: 28749 RVA: 0x001FD078 File Offset: 0x001FB278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224436, XrefRangeEnd = 224448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(Avatar _avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Taser.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600704E RID: 28750 RVA: 0x001FD0C8 File Offset: 0x001FB2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224448, XrefRangeEnd = 224459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Shoot(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Taser.NativeMethodInfoPtr_Shoot_Protected_Virtual_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600704F RID: 28751 RVA: 0x001FD114 File Offset: 0x001FB314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224459, XrefRangeEnd = 224462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyHitToDamageable(IDamageable damageable, Vector3 hitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(damageable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Taser.NativeMethodInfoPtr_ApplyHitToDamageable_Public_Virtual_Void_IDamageable_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007050 RID: 28752 RVA: 0x001FD170 File Offset: 0x001FB370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224462, XrefRangeEnd = 224468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetIsRaised(bool raised)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref raised;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Taser.NativeMethodInfoPtr_SetIsRaised_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007051 RID: 28753 RVA: 0x001FD1BC File Offset: 0x001FB3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224468, XrefRangeEnd = 224473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Flash(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser.NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007052 RID: 28754 RVA: 0x001FD208 File Offset: 0x001FB408
		[CallerCount(0)]
		public unsafe override float GetIdealUseRange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Taser.NativeMethodInfoPtr_GetIdealUseRange_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007053 RID: 28755 RVA: 0x001FD250 File Offset: 0x001FB450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Taser() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Taser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007054 RID: 28756 RVA: 0x000355D5 File Offset: 0x000337D5
		public Taser(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022B8 RID: 8888
		// (get) Token: 0x06007055 RID: 28757 RVA: 0x001FD28C File Offset: 0x001FB48C
		// (set) Token: 0x06007056 RID: 28758 RVA: 0x000355DE File Offset: 0x000337DE
		public unsafe static float TaseDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Taser.NativeFieldInfoPtr_TaseDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Taser.NativeFieldInfoPtr_TaseDuration, (void*)(&value));
			}
		}

		// Token: 0x170022B9 RID: 8889
		// (get) Token: 0x06007057 RID: 28759 RVA: 0x001FD2A8 File Offset: 0x001FB4A8
		// (set) Token: 0x06007058 RID: 28760 RVA: 0x000355EC File Offset: 0x000337EC
		public unsafe static float TaseMoveSpeedMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Taser.NativeFieldInfoPtr_TaseMoveSpeedMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Taser.NativeFieldInfoPtr_TaseMoveSpeedMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170022BA RID: 8890
		// (get) Token: 0x06007059 RID: 28761 RVA: 0x001FD2C4 File Offset: 0x001FB4C4
		// (set) Token: 0x0600705A RID: 28762 RVA: 0x000355FA File Offset: 0x000337FA
		public unsafe GameObject FlashObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_FlashObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_FlashObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BB RID: 8891
		// (get) Token: 0x0600705B RID: 28763 RVA: 0x001FD2F4 File Offset: 0x001FB4F4
		// (set) Token: 0x0600705C RID: 28764 RVA: 0x00035619 File Offset: 0x00033819
		public unsafe AudioSourceController ChargeSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_ChargeSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_ChargeSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BC RID: 8892
		// (get) Token: 0x0600705D RID: 28765 RVA: 0x001FD324 File Offset: 0x001FB524
		// (set) Token: 0x0600705E RID: 28766 RVA: 0x00035638 File Offset: 0x00033838
		public unsafe GameObject RayPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_RayPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_RayPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BD RID: 8893
		// (get) Token: 0x0600705F RID: 28767 RVA: 0x001FD354 File Offset: 0x001FB554
		// (set) Token: 0x06007060 RID: 28768 RVA: 0x00035657 File Offset: 0x00033857
		public unsafe Coroutine flashRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_flashRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_flashRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004CD6 RID: 19670
		private static readonly IntPtr NativeFieldInfoPtr_TaseDuration;

		// Token: 0x04004CD7 RID: 19671
		private static readonly IntPtr NativeFieldInfoPtr_TaseMoveSpeedMultiplier;

		// Token: 0x04004CD8 RID: 19672
		private static readonly IntPtr NativeFieldInfoPtr_FlashObject;

		// Token: 0x04004CD9 RID: 19673
		private static readonly IntPtr NativeFieldInfoPtr_ChargeSound;

		// Token: 0x04004CDA RID: 19674
		private static readonly IntPtr NativeFieldInfoPtr_RayPrefab;

		// Token: 0x04004CDB RID: 19675
		private static readonly IntPtr NativeFieldInfoPtr_flashRoutine;

		// Token: 0x04004CDC RID: 19676
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0;

		// Token: 0x04004CDD RID: 19677
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Protected_Virtual_Void_Vector3_0;

		// Token: 0x04004CDE RID: 19678
		private static readonly IntPtr NativeMethodInfoPtr_ApplyHitToDamageable_Public_Virtual_Void_IDamageable_Vector3_0;

		// Token: 0x04004CDF RID: 19679
		private static readonly IntPtr NativeMethodInfoPtr_SetIsRaised_Public_Virtual_Void_Boolean_0;

		// Token: 0x04004CE0 RID: 19680
		private static readonly IntPtr NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0;

		// Token: 0x04004CE1 RID: 19681
		private static readonly IntPtr NativeMethodInfoPtr_GetIdealUseRange_Public_Virtual_Single_0;

		// Token: 0x04004CE2 RID: 19682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B85 RID: 2949
		[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.Taser+<Flash>d__10")]
		public sealed class _Flash_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600E944 RID: 59716 RVA: 0x0038BDB8 File Offset: 0x00389FB8
			// Note: this type is marked as 'beforefieldinit'.
			static _Flash_d__10()
			{
				Il2CppClassPointerStore<Taser._Flash_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Taser>.NativeClassPtr, "<Flash>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Taser._Flash_d__10>.NativeClassPtr);
				Taser._Flash_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser._Flash_d__10>.NativeClassPtr, "<>1__state");
				Taser._Flash_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser._Flash_d__10>.NativeClassPtr, "<>2__current");
				Taser._Flash_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser._Flash_d__10>.NativeClassPtr, "<>4__this");
				Taser._Flash_d__10.NativeFieldInfoPtr_endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser._Flash_d__10>.NativeClassPtr, "endPoint");
				Taser._Flash_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__10>.NativeClassPtr, 100677831);
				Taser._Flash_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__10>.NativeClassPtr, 100677832);
				Taser._Flash_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__10>.NativeClassPtr, 100677833);
				Taser._Flash_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__10>.NativeClassPtr, 100677834);
				Taser._Flash_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__10>.NativeClassPtr, 100677835);
				Taser._Flash_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__10>.NativeClassPtr, 100677836);
			}

			// Token: 0x0600E945 RID: 59717 RVA: 0x0038BEAC File Offset: 0x0038A0AC
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Flash_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Taser._Flash_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E946 RID: 59718 RVA: 0x0038BEF4 File Offset: 0x0038A0F4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E947 RID: 59719 RVA: 0x0038BF28 File Offset: 0x0038A128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224395, XrefRangeEnd = 224431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170046C7 RID: 18119
			// (get) Token: 0x0600E948 RID: 59720 RVA: 0x0038BF64 File Offset: 0x0038A164
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E949 RID: 59721 RVA: 0x0038BFA4 File Offset: 0x0038A1A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224431, XrefRangeEnd = 224436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170046C8 RID: 18120
			// (get) Token: 0x0600E94A RID: 59722 RVA: 0x0038BFD8 File Offset: 0x0038A1D8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E94B RID: 59723 RVA: 0x0006E0E3 File Offset: 0x0006C2E3
			public _Flash_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046C3 RID: 18115
			// (get) Token: 0x0600E94C RID: 59724 RVA: 0x0038C018 File Offset: 0x0038A218
			// (set) Token: 0x0600E94D RID: 59725 RVA: 0x0006E0EC File Offset: 0x0006C2EC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046C4 RID: 18116
			// (get) Token: 0x0600E94E RID: 59726 RVA: 0x0038C040 File Offset: 0x0038A240
			// (set) Token: 0x0600E94F RID: 59727 RVA: 0x0006E107 File Offset: 0x0006C307
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046C5 RID: 18117
			// (get) Token: 0x0600E950 RID: 59728 RVA: 0x0038C070 File Offset: 0x0038A270
			// (set) Token: 0x0600E951 RID: 59729 RVA: 0x0006E126 File Offset: 0x0006C326
			public unsafe Taser __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Taser>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046C6 RID: 18118
			// (get) Token: 0x0600E952 RID: 59730 RVA: 0x0038C0A0 File Offset: 0x0038A2A0
			// (set) Token: 0x0600E953 RID: 59731 RVA: 0x0006E145 File Offset: 0x0006C345
			public unsafe Vector3 endPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__10.NativeFieldInfoPtr_endPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__10.NativeFieldInfoPtr_endPoint)) = value;
				}
			}

			// Token: 0x04009E35 RID: 40501
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009E36 RID: 40502
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009E37 RID: 40503
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009E38 RID: 40504
			private static readonly IntPtr NativeFieldInfoPtr_endPoint;

			// Token: 0x04009E39 RID: 40505
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009E3A RID: 40506
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009E3B RID: 40507
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009E3C RID: 40508
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009E3D RID: 40509
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009E3E RID: 40510
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
