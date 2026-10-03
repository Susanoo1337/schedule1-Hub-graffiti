using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppScheduleOne.Property;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x0200015A RID: 346
	public class Quest_WelcomeToHylandPoint : Quest
	{
		// Token: 0x06002248 RID: 8776 RVA: 0x000EC340 File Offset: 0x000EA540
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_WelcomeToHylandPoint()
		{
			Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_WelcomeToHylandPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr);
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReturnToRVQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "ReturnToRVQuest");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReadMessagesQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "ReadMessagesQuest");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_RV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "RV");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_Nelson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "Nelson");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMaxDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "ExplosionMaxDist");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMinDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "ExplosionMinDist");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_cameraLookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "cameraLookTime");
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667732);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667733);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667734);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_BlowupRV_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667735);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_SetRVDestroyed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667736);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667737);
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x000EC474 File Offset: 0x000EA674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111582, XrefRangeEnd = 111584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x000EC4B0 File Offset: 0x000EA6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111584, XrefRangeEnd = 111593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x000EC4E4 File Offset: 0x000EA6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111593, XrefRangeEnd = 111597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetQuestState(EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x000EC53C File Offset: 0x000EA73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111597, XrefRangeEnd = 111630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlowupRV()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_BlowupRV_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x000EC570 File Offset: 0x000EA770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111630, XrefRangeEnd = 111640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRVDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_SetRVDestroyed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x000EC5A4 File Offset: 0x000EA7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111640, XrefRangeEnd = 111644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_WelcomeToHylandPoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x00012481 File Offset: 0x00010681
		public Quest_WelcomeToHylandPoint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x000EC5E0 File Offset: 0x000EA7E0
		// (set) Token: 0x06002251 RID: 8785 RVA: 0x0001248A File Offset: 0x0001068A
		public unsafe QuestEntry ReturnToRVQuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReturnToRVQuest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReturnToRVQuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x000EC610 File Offset: 0x000EA810
		// (set) Token: 0x06002253 RID: 8787 RVA: 0x000124A9 File Offset: 0x000106A9
		public unsafe QuestEntry ReadMessagesQuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReadMessagesQuest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReadMessagesQuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x000EC640 File Offset: 0x000EA840
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x000124C8 File Offset: 0x000106C8
		public unsafe RV RV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_RV);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RV>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_RV), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x000EC670 File Offset: 0x000EA870
		// (set) Token: 0x06002257 RID: 8791 RVA: 0x000124E7 File Offset: 0x000106E7
		public unsafe UncleNelson Nelson
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_Nelson);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UncleNelson>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_Nelson), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06002258 RID: 8792 RVA: 0x000EC6A0 File Offset: 0x000EA8A0
		// (set) Token: 0x06002259 RID: 8793 RVA: 0x00012506 File Offset: 0x00010706
		public unsafe float ExplosionMaxDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMaxDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMaxDist)) = value;
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x000EC6C8 File Offset: 0x000EA8C8
		// (set) Token: 0x0600225B RID: 8795 RVA: 0x00012521 File Offset: 0x00010721
		public unsafe float ExplosionMinDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMinDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMinDist)) = value;
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x0600225C RID: 8796 RVA: 0x000EC6F0 File Offset: 0x000EA8F0
		// (set) Token: 0x0600225D RID: 8797 RVA: 0x0001253C File Offset: 0x0001073C
		public unsafe float cameraLookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_cameraLookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_cameraLookTime)) = value;
			}
		}

		// Token: 0x040017B0 RID: 6064
		private static readonly IntPtr NativeFieldInfoPtr_ReturnToRVQuest;

		// Token: 0x040017B1 RID: 6065
		private static readonly IntPtr NativeFieldInfoPtr_ReadMessagesQuest;

		// Token: 0x040017B2 RID: 6066
		private static readonly IntPtr NativeFieldInfoPtr_RV;

		// Token: 0x040017B3 RID: 6067
		private static readonly IntPtr NativeFieldInfoPtr_Nelson;

		// Token: 0x040017B4 RID: 6068
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionMaxDist;

		// Token: 0x040017B5 RID: 6069
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionMinDist;

		// Token: 0x040017B6 RID: 6070
		private static readonly IntPtr NativeFieldInfoPtr_cameraLookTime;

		// Token: 0x040017B7 RID: 6071
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0;

		// Token: 0x040017B8 RID: 6072
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040017B9 RID: 6073
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0;

		// Token: 0x040017BA RID: 6074
		private static readonly IntPtr NativeMethodInfoPtr_BlowupRV_Public_Void_0;

		// Token: 0x040017BB RID: 6075
		private static readonly IntPtr NativeMethodInfoPtr_SetRVDestroyed_Public_Void_0;

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
