using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Levelling;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x02000441 RID: 1089
	public class Ambush : CartelActivity
	{
		// Token: 0x06006275 RID: 25205 RVA: 0x001D0478 File Offset: 0x001CE678
		// Note: this type is marked as 'beforefieldinit'.
		static Ambush()
		{
			Il2CppClassPointerStore<Ambush>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "Ambush");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ambush>.NativeClassPtr);
			Ambush.NativeFieldInfoPtr_MIN_DISTANCE_TO_POLICE_OFFICER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ambush>.NativeClassPtr, "MIN_DISTANCE_TO_POLICE_OFFICER");
			Ambush.NativeFieldInfoPtr_CANCEL_AMBUSH_AFTER_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ambush>.NativeClassPtr, "CANCEL_AMBUSH_AFTER_MINS");
			Ambush.NativeFieldInfoPtr_AMBUSH_DEFEATED_INFLUENCE_CHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ambush>.NativeClassPtr, "AMBUSH_DEFEATED_INFLUENCE_CHANGE");
			Ambush.NativeFieldInfoPtr_MIN_RANK_FOR_RANGED_WEAPONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ambush>.NativeClassPtr, "MIN_RANK_FOR_RANGED_WEAPONS");
			Ambush.NativeFieldInfoPtr__regionActivities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ambush>.NativeClassPtr, "_regionActivities");
			Ambush.NativeFieldInfoPtr_RangedWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ambush>.NativeClassPtr, "RangedWeapons");
			Ambush.NativeFieldInfoPtr_MeleeWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ambush>.NativeClassPtr, "MeleeWeapons");
			Ambush.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ambush>.NativeClassPtr, "region");
			Ambush.NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_Boolean_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush>.NativeClassPtr, 100676216);
			Ambush.NativeMethodInfoPtr_Activate_Public_Virtual_Void_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush>.NativeClassPtr, 100676217);
			Ambush.NativeMethodInfoPtr_Deactivate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush>.NativeClassPtr, 100676218);
			Ambush.NativeMethodInfoPtr_MinPassed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush>.NativeClassPtr, 100676219);
			Ambush.NativeMethodInfoPtr_CanPlayerBeAmbushed_Private_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush>.NativeClassPtr, 100676220);
			Ambush.NativeMethodInfoPtr_ContractReceiptRecorded_Private_Void_ContractReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush>.NativeClassPtr, 100676221);
			Ambush.NativeMethodInfoPtr_SpawnAmbush_Private_Void_Player_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush>.NativeClassPtr, 100676222);
			Ambush.NativeMethodInfoPtr_TriggerAmbushForPlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush>.NativeClassPtr, 100676223);
			Ambush.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush>.NativeClassPtr, 100676224);
		}

		// Token: 0x06006276 RID: 25206 RVA: 0x001D05FC File Offset: 0x001CE7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207799, XrefRangeEnd = 207805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsRegionValidForActivity(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ambush.NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_Boolean_EMapRegion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006277 RID: 25207 RVA: 0x001D0650 File Offset: 0x001CE850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207805, XrefRangeEnd = 207830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ambush.NativeMethodInfoPtr_Activate_Public_Virtual_Void_EMapRegion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006278 RID: 25208 RVA: 0x001D069C File Offset: 0x001CE89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207830, XrefRangeEnd = 207849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ambush.NativeMethodInfoPtr_Deactivate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006279 RID: 25209 RVA: 0x001D06D8 File Offset: 0x001CE8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207849, XrefRangeEnd = 207914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ambush.NativeMethodInfoPtr_MinPassed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600627A RID: 25210 RVA: 0x001D0714 File Offset: 0x001CE914
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207919, RefRangeEnd = 207921, XrefRangeStart = 207914, XrefRangeEnd = 207919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPlayerBeAmbushed(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ambush.NativeMethodInfoPtr_CanPlayerBeAmbushed_Private_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600627B RID: 25211 RVA: 0x001D0764 File Offset: 0x001CE964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207921, XrefRangeEnd = 207971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContractReceiptRecorded(ContractReceipt receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ambush.NativeMethodInfoPtr_ContractReceiptRecorded_Private_Void_ContractReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600627C RID: 25212 RVA: 0x001D07A8 File Offset: 0x001CE9A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208061, RefRangeEnd = 208064, XrefRangeStart = 207971, XrefRangeEnd = 208061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnAmbush(Player target, Il2CppStructArray<Vector3> potentialSpawnPoints)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(potentialSpawnPoints);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ambush.NativeMethodInfoPtr_SpawnAmbush_Private_Void_Player_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600627D RID: 25213 RVA: 0x001D07FC File Offset: 0x001CE9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208064, XrefRangeEnd = 208120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerAmbushForPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ambush.NativeMethodInfoPtr_TriggerAmbushForPlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600627E RID: 25214 RVA: 0x001D0830 File Offset: 0x001CEA30
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ambush() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ambush>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ambush.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600627F RID: 25215 RVA: 0x0002E86C File Offset: 0x0002CA6C
		public Ambush(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x06006280 RID: 25216 RVA: 0x001D086C File Offset: 0x001CEA6C
		// (set) Token: 0x06006281 RID: 25217 RVA: 0x0002E875 File Offset: 0x0002CA75
		public unsafe static float MIN_DISTANCE_TO_POLICE_OFFICER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Ambush.NativeFieldInfoPtr_MIN_DISTANCE_TO_POLICE_OFFICER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Ambush.NativeFieldInfoPtr_MIN_DISTANCE_TO_POLICE_OFFICER, (void*)(&value));
			}
		}

		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x06006282 RID: 25218 RVA: 0x001D0888 File Offset: 0x001CEA88
		// (set) Token: 0x06006283 RID: 25219 RVA: 0x0002E883 File Offset: 0x0002CA83
		public unsafe static int CANCEL_AMBUSH_AFTER_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Ambush.NativeFieldInfoPtr_CANCEL_AMBUSH_AFTER_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Ambush.NativeFieldInfoPtr_CANCEL_AMBUSH_AFTER_MINS, (void*)(&value));
			}
		}

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x06006284 RID: 25220 RVA: 0x001D08A4 File Offset: 0x001CEAA4
		// (set) Token: 0x06006285 RID: 25221 RVA: 0x0002E891 File Offset: 0x0002CA91
		public unsafe static float AMBUSH_DEFEATED_INFLUENCE_CHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Ambush.NativeFieldInfoPtr_AMBUSH_DEFEATED_INFLUENCE_CHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Ambush.NativeFieldInfoPtr_AMBUSH_DEFEATED_INFLUENCE_CHANGE, (void*)(&value));
			}
		}

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x06006286 RID: 25222 RVA: 0x001D08C0 File Offset: 0x001CEAC0
		// (set) Token: 0x06006287 RID: 25223 RVA: 0x0002E89F File Offset: 0x0002CA9F
		public unsafe static FullRank MIN_RANK_FOR_RANGED_WEAPONS
		{
			get
			{
				FullRank result;
				IL2CPP.il2cpp_field_static_get_value(Ambush.NativeFieldInfoPtr_MIN_RANK_FOR_RANGED_WEAPONS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Ambush.NativeFieldInfoPtr_MIN_RANK_FOR_RANGED_WEAPONS, (void*)(&value));
			}
		}

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x06006288 RID: 25224 RVA: 0x001D08DC File Offset: 0x001CEADC
		// (set) Token: 0x06006289 RID: 25225 RVA: 0x0002E8AD File Offset: 0x0002CAAD
		public unsafe CartelRegionActivities _regionActivities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.NativeFieldInfoPtr__regionActivities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelRegionActivities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.NativeFieldInfoPtr__regionActivities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x0600628A RID: 25226 RVA: 0x001D090C File Offset: 0x001CEB0C
		// (set) Token: 0x0600628B RID: 25227 RVA: 0x0002E8CC File Offset: 0x0002CACC
		public unsafe Il2CppReferenceArray<AvatarWeapon> RangedWeapons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.NativeFieldInfoPtr_RangedWeapons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarWeapon>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.NativeFieldInfoPtr_RangedWeapons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x0600628C RID: 25228 RVA: 0x001D093C File Offset: 0x001CEB3C
		// (set) Token: 0x0600628D RID: 25229 RVA: 0x0002E8EB File Offset: 0x0002CAEB
		public unsafe Il2CppReferenceArray<AvatarWeapon> MeleeWeapons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.NativeFieldInfoPtr_MeleeWeapons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarWeapon>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.NativeFieldInfoPtr_MeleeWeapons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x0600628E RID: 25230 RVA: 0x001D096C File Offset: 0x001CEB6C
		// (set) Token: 0x0600628F RID: 25231 RVA: 0x0002E90A File Offset: 0x0002CB0A
		public unsafe EMapRegion region
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.NativeFieldInfoPtr_region);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.NativeFieldInfoPtr_region)) = value;
			}
		}

		// Token: 0x040043DB RID: 17371
		private static readonly IntPtr NativeFieldInfoPtr_MIN_DISTANCE_TO_POLICE_OFFICER;

		// Token: 0x040043DC RID: 17372
		private static readonly IntPtr NativeFieldInfoPtr_CANCEL_AMBUSH_AFTER_MINS;

		// Token: 0x040043DD RID: 17373
		private static readonly IntPtr NativeFieldInfoPtr_AMBUSH_DEFEATED_INFLUENCE_CHANGE;

		// Token: 0x040043DE RID: 17374
		private static readonly IntPtr NativeFieldInfoPtr_MIN_RANK_FOR_RANGED_WEAPONS;

		// Token: 0x040043DF RID: 17375
		private static readonly IntPtr NativeFieldInfoPtr__regionActivities;

		// Token: 0x040043E0 RID: 17376
		private static readonly IntPtr NativeFieldInfoPtr_RangedWeapons;

		// Token: 0x040043E1 RID: 17377
		private static readonly IntPtr NativeFieldInfoPtr_MeleeWeapons;

		// Token: 0x040043E2 RID: 17378
		private static readonly IntPtr NativeFieldInfoPtr_region;

		// Token: 0x040043E3 RID: 17379
		private static readonly IntPtr NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_Boolean_EMapRegion_0;

		// Token: 0x040043E4 RID: 17380
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_EMapRegion_0;

		// Token: 0x040043E5 RID: 17381
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Protected_Virtual_Void_0;

		// Token: 0x040043E6 RID: 17382
		private static readonly IntPtr NativeMethodInfoPtr_MinPassed_Protected_Virtual_Void_0;

		// Token: 0x040043E7 RID: 17383
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayerBeAmbushed_Private_Boolean_Player_0;

		// Token: 0x040043E8 RID: 17384
		private static readonly IntPtr NativeMethodInfoPtr_ContractReceiptRecorded_Private_Void_ContractReceipt_0;

		// Token: 0x040043E9 RID: 17385
		private static readonly IntPtr NativeMethodInfoPtr_SpawnAmbush_Private_Void_Player_Il2CppStructArray_1_Vector3_0;

		// Token: 0x040043EA RID: 17386
		private static readonly IntPtr NativeMethodInfoPtr_TriggerAmbushForPlayer_Public_Void_0;

		// Token: 0x040043EB RID: 17387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B34 RID: 2868
		[ObfuscatedName("ScheduleOne.Cartel.Ambush+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E6A3 RID: 59043 RVA: 0x00384598 File Offset: 0x00382798
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Ambush>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0>.NativeClassPtr);
				Ambush.__c__DisplayClass13_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0>.NativeClassPtr, "target");
				Ambush.__c__DisplayClass13_0.NativeFieldInfoPtr_spawnedAmbushers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0>.NativeClassPtr, "spawnedAmbushers");
				Ambush.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				Ambush.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0>.NativeClassPtr, 100676226);
				Ambush.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0>.NativeClassPtr, 100676227);
			}

			// Token: 0x0600E6A4 RID: 59044 RVA: 0x00384628 File Offset: 0x00382828
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ambush.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E6A5 RID: 59045 RVA: 0x00384664 File Offset: 0x00382864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207794, XrefRangeEnd = 207799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ambush.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E6A6 RID: 59046 RVA: 0x0006CCA2 File Offset: 0x0006AEA2
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004603 RID: 17923
			// (get) Token: 0x0600E6A7 RID: 59047 RVA: 0x003846A4 File Offset: 0x003828A4
			// (set) Token: 0x0600E6A8 RID: 59048 RVA: 0x0006CCAB File Offset: 0x0006AEAB
			public unsafe Player target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.__c__DisplayClass13_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.__c__DisplayClass13_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004604 RID: 17924
			// (get) Token: 0x0600E6A9 RID: 59049 RVA: 0x003846D4 File Offset: 0x003828D4
			// (set) Token: 0x0600E6AA RID: 59050 RVA: 0x0006CCCA File Offset: 0x0006AECA
			public unsafe List<CartelGoon> spawnedAmbushers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.__c__DisplayClass13_0.NativeFieldInfoPtr_spawnedAmbushers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CartelGoon>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.__c__DisplayClass13_0.NativeFieldInfoPtr_spawnedAmbushers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004605 RID: 17925
			// (get) Token: 0x0600E6AB RID: 59051 RVA: 0x00384704 File Offset: 0x00382904
			// (set) Token: 0x0600E6AC RID: 59052 RVA: 0x0006CCE9 File Offset: 0x0006AEE9
			public unsafe Ambush __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Ambush>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C98 RID: 40088
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04009C99 RID: 40089
			private static readonly IntPtr NativeFieldInfoPtr_spawnedAmbushers;

			// Token: 0x04009C9A RID: 40090
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C9B RID: 40091
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C9C RID: 40092
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DDC RID: 3548
			[ObfuscatedName("ScheduleOne.Cartel.Ambush+<>c__DisplayClass13_0+<<SpawnAmbush>g__MonitorAmbush|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601000C RID: 65548 RVA: 0x003CDA48 File Offset: 0x003CBC48
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0>.NativeClassPtr, "<<SpawnAmbush>g__MonitorAmbush|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676228);
					Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676229);
					Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676230);
					Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676231);
					Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676232);
					Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676233);
				}

				// Token: 0x0601000D RID: 65549 RVA: 0x003CDB28 File Offset: 0x003CBD28
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601000E RID: 65550 RVA: 0x003CDB70 File Offset: 0x003CBD70
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601000F RID: 65551 RVA: 0x003CDBA4 File Offset: 0x003CBDA4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207756, XrefRangeEnd = 207789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E00 RID: 19968
				// (get) Token: 0x06010010 RID: 65552 RVA: 0x003CDBE0 File Offset: 0x003CBDE0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010011 RID: 65553 RVA: 0x003CDC20 File Offset: 0x003CBE20
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207789, XrefRangeEnd = 207794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E01 RID: 19969
				// (get) Token: 0x06010012 RID: 65554 RVA: 0x003CDC54 File Offset: 0x003CBE54
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010013 RID: 65555 RVA: 0x00079593 File Offset: 0x00077793
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004DFD RID: 19965
				// (get) Token: 0x06010014 RID: 65556 RVA: 0x003CDC94 File Offset: 0x003CBE94
				// (set) Token: 0x06010015 RID: 65557 RVA: 0x0007959C File Offset: 0x0007779C
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004DFE RID: 19966
				// (get) Token: 0x06010016 RID: 65558 RVA: 0x003CDCBC File Offset: 0x003CBEBC
				// (set) Token: 0x06010017 RID: 65559 RVA: 0x000795B7 File Offset: 0x000777B7
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DFF RID: 19967
				// (get) Token: 0x06010018 RID: 65560 RVA: 0x003CDCEC File Offset: 0x003CBEEC
				// (set) Token: 0x06010019 RID: 65561 RVA: 0x000795D6 File Offset: 0x000777D6
				public unsafe Ambush.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Ambush.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ambush.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AC7B RID: 44155
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AC7C RID: 44156
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AC7D RID: 44157
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AC7E RID: 44158
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AC7F RID: 44159
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC80 RID: 44160
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AC81 RID: 44161
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AC82 RID: 44162
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC83 RID: 44163
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
