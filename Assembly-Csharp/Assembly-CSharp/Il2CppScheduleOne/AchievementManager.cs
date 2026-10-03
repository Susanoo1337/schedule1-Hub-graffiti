using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne
{
	// Token: 0x020000C2 RID: 194
	public static class AchievementManager : Object
	{
		// Token: 0x060011F8 RID: 4600 RVA: 0x000B7478 File Offset: 0x000B5678
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementManager()
		{
			Il2CppClassPointerStore<AchievementManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "AchievementManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr);
			AchievementManager.NativeFieldInfoPtr_achievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "achievements");
			AchievementManager.NativeFieldInfoPtr_achievementUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "achievementUnlocked");
			AchievementManager.NativeFieldInfoPtr__initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "_initialized");
			AchievementManager.NativeMethodInfoPtr_Init_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100665925);
			AchievementManager.NativeMethodInfoPtr_TryPullAchievements_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100665926);
			AchievementManager.NativeMethodInfoPtr_UnlockAchievement_Public_Static_Void_EAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100665927);
			AchievementManager.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, 100665929);
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x000B7534 File Offset: 0x000B5734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90711, XrefRangeEnd = 90747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_Init_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x000B755C File Offset: 0x000B575C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90797, RefRangeEnd = 90798, XrefRangeStart = 90747, XrefRangeEnd = 90797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryPullAchievements()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_TryPullAchievements_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x000B7584 File Offset: 0x000B5784
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 90829, RefRangeEnd = 90841, XrefRangeStart = 90798, XrefRangeEnd = 90829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnlockAchievement(AchievementManager.EAchievement achievement)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref achievement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_UnlockAchievement_Public_Static_Void_EAchievement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x000B75B8 File Offset: 0x000B57B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90841, XrefRangeEnd = 90856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0000A22B File Offset: 0x0000842B
		public AchievementManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x000B75E0 File Offset: 0x000B57E0
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x0000A234 File Offset: 0x00008434
		public unsafe static Il2CppStructArray<AchievementManager.EAchievement> achievements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AchievementManager.NativeFieldInfoPtr_achievements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AchievementManager.EAchievement>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AchievementManager.NativeFieldInfoPtr_achievements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x000B7608 File Offset: 0x000B5808
		// (set) Token: 0x06001201 RID: 4609 RVA: 0x0000A246 File Offset: 0x00008446
		public unsafe static Dictionary<AchievementManager.EAchievement, bool> achievementUnlocked
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AchievementManager.NativeFieldInfoPtr_achievementUnlocked, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AchievementManager.EAchievement, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AchievementManager.NativeFieldInfoPtr_achievementUnlocked, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x000B7630 File Offset: 0x000B5830
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x0000A258 File Offset: 0x00008458
		public unsafe static bool _initialized
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(AchievementManager.NativeFieldInfoPtr__initialized, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AchievementManager.NativeFieldInfoPtr__initialized, (void*)(&value));
			}
		}

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeFieldInfoPtr_achievements;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeFieldInfoPtr_achievementUnlocked;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeFieldInfoPtr__initialized;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_Void_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr_TryPullAchievements_Private_Static_Void_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr_UnlockAchievement_Public_Static_Void_EAchievement_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0;

		// Token: 0x0200091A RID: 2330
		[OriginalName("Assembly-CSharp.dll", "", "EAchievement")]
		public enum EAchievement
		{
			// Token: 0x0400928D RID: 37517
			COMPLETE_PROLOGUE,
			// Token: 0x0400928E RID: 37518
			RV_DESTROYED,
			// Token: 0x0400928F RID: 37519
			DEALER_RECRUITED,
			// Token: 0x04009290 RID: 37520
			MASTER_CHEF,
			// Token: 0x04009291 RID: 37521
			BUSINESSMAN,
			// Token: 0x04009292 RID: 37522
			BIGWIG,
			// Token: 0x04009293 RID: 37523
			MAGNATE,
			// Token: 0x04009294 RID: 37524
			UPSTANDING_CITIZEN,
			// Token: 0x04009295 RID: 37525
			ROLLING_IN_STYLE,
			// Token: 0x04009296 RID: 37526
			LONG_ARM_OF_THE_LAW,
			// Token: 0x04009297 RID: 37527
			INDIAN_DEALER,
			// Token: 0x04009298 RID: 37528
			URBAN_ARTIST,
			// Token: 0x04009299 RID: 37529
			FINISHING_THE_JOB
		}

		// Token: 0x0200091B RID: 2331
		[ObfuscatedName("ScheduleOne.AchievementManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600D707 RID: 55047 RVA: 0x00358890 File Offset: 0x00356A90
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AchievementManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementManager.__c>.NativeClassPtr);
				AchievementManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.__c>.NativeClassPtr, "<>9");
				AchievementManager.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementManager.__c>.NativeClassPtr, "<>9__5_1");
				AchievementManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.__c>.NativeClassPtr, 100665931);
				AchievementManager.__c.NativeMethodInfoPtr__TryPullAchievements_b__5_1_Internal_Boolean_KeyValuePair_2_EAchievement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementManager.__c>.NativeClassPtr, 100665932);
			}

			// Token: 0x0600D708 RID: 55048 RVA: 0x0035890C File Offset: 0x00356B0C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D709 RID: 55049 RVA: 0x00358948 File Offset: 0x00356B48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90710, XrefRangeEnd = 90711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryPullAchievements_b__5_1(KeyValuePair<AchievementManager.EAchievement, bool> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementManager.__c.NativeMethodInfoPtr__TryPullAchievements_b__5_1_Internal_Boolean_KeyValuePair_2_EAchievement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D70A RID: 55050 RVA: 0x000650B4 File Offset: 0x000632B4
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041AB RID: 16811
			// (get) Token: 0x0600D70B RID: 55051 RVA: 0x0035899C File Offset: 0x00356B9C
			// (set) Token: 0x0600D70C RID: 55052 RVA: 0x000650BD File Offset: 0x000632BD
			public unsafe static AchievementManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AchievementManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AchievementManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AchievementManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041AC RID: 16812
			// (get) Token: 0x0600D70D RID: 55053 RVA: 0x003589C4 File Offset: 0x00356BC4
			// (set) Token: 0x0600D70E RID: 55054 RVA: 0x000650CF File Offset: 0x000632CF
			public unsafe static Func<KeyValuePair<AchievementManager.EAchievement, bool>, bool> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AchievementManager.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<AchievementManager.EAchievement, bool>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AchievementManager.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400929A RID: 37530
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400929B RID: 37531
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x0400929C RID: 37532
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400929D RID: 37533
			private static readonly IntPtr NativeMethodInfoPtr__TryPullAchievements_b__5_1_Internal_Boolean_KeyValuePair_2_EAchievement_Boolean_0;
		}
	}
}
