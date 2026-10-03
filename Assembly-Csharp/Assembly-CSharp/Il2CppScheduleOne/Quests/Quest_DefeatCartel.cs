using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppScheduleOne.Property;
using UnityEngine;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x0200014A RID: 330
	public class Quest_DefeatCartel : Quest
	{
		// Token: 0x06002177 RID: 8567 RVA: 0x000E9CA4 File Offset: 0x000E7EA4
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_DefeatCartel()
		{
			Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_DefeatCartel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr);
			Quest_DefeatCartel.NativeFieldInfoPtr_DIG_TUNNEL_COST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, "DIG_TUNNEL_COST");
			Quest_DefeatCartel.NativeFieldInfoPtr_Sam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, "Sam");
			Quest_DefeatCartel.NativeFieldInfoPtr_Manor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, "Manor");
			Quest_DefeatCartel.NativeFieldInfoPtr_DigTunnelEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, "DigTunnelEntry");
			Quest_DefeatCartel.NativeFieldInfoPtr_WaitForTunnelEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, "WaitForTunnelEntry");
			Quest_DefeatCartel.NativeFieldInfoPtr_EnquireAboutRDXEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, "EnquireAboutRDXEntry");
			Quest_DefeatCartel.NativeFieldInfoPtr_ObtainRDXEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, "ObtainRDXEntry");
			Quest_DefeatCartel.NativeFieldInfoPtr_EnquireAboutBombEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, "EnquireAboutBombEntry");
			Quest_DefeatCartel.NativeFieldInfoPtr_KillBanditEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, "KillBanditEntry");
			Quest_DefeatCartel.NativeFieldInfoPtr_Bandit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, "Bandit");
			Quest_DefeatCartel.NativeFieldInfoPtr_BanditScheduleContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, "BanditScheduleContainer");
			Quest_DefeatCartel.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, 100667645);
			Quest_DefeatCartel.NativeMethodInfoPtr_OnSleepEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, 100667646);
			Quest_DefeatCartel.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, 100667647);
			Quest_DefeatCartel.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_Void_Int32_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, 100667648);
			Quest_DefeatCartel.NativeMethodInfoPtr_PlayCountdownMusic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, 100667649);
			Quest_DefeatCartel.NativeMethodInfoPtr_Defeat_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, 100667650);
			Quest_DefeatCartel.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, 100667651);
			Quest_DefeatCartel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr, 100667652);
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x000E9E50 File Offset: 0x000E8050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110724, XrefRangeEnd = 110750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_DefeatCartel.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x000E9E8C File Offset: 0x000E808C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110750, XrefRangeEnd = 110761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSleepEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_DefeatCartel.NativeMethodInfoPtr_OnSleepEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x000E9EC0 File Offset: 0x000E80C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110761, XrefRangeEnd = 110765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_DefeatCartel.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x000E9EFC File Offset: 0x000E80FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110765, XrefRangeEnd = 110774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_DefeatCartel.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_Void_Int32_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x000E9F64 File Offset: 0x000E8164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110774, XrefRangeEnd = 110782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayCountdownMusic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_DefeatCartel.NativeMethodInfoPtr_PlayCountdownMusic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x000E9F98 File Offset: 0x000E8198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110782, XrefRangeEnd = 110787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Defeat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_DefeatCartel.NativeMethodInfoPtr_Defeat_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x000E9FCC File Offset: 0x000E81CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110787, XrefRangeEnd = 110797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetQuestState(EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_DefeatCartel.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x000EA024 File Offset: 0x000E8224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110797, XrefRangeEnd = 110801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_DefeatCartel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_DefeatCartel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_DefeatCartel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x00011D8E File Offset: 0x0000FF8E
		public Quest_DefeatCartel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06002181 RID: 8577 RVA: 0x000EA060 File Offset: 0x000E8260
		// (set) Token: 0x06002182 RID: 8578 RVA: 0x00011D97 File Offset: 0x0000FF97
		public unsafe static float DIG_TUNNEL_COST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Quest_DefeatCartel.NativeFieldInfoPtr_DIG_TUNNEL_COST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_DefeatCartel.NativeFieldInfoPtr_DIG_TUNNEL_COST, (void*)(&value));
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x000EA07C File Offset: 0x000E827C
		// (set) Token: 0x06002184 RID: 8580 RVA: 0x00011DA5 File Offset: 0x0000FFA5
		public unsafe Sam Sam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_Sam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sam>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_Sam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002185 RID: 8581 RVA: 0x000EA0AC File Offset: 0x000E82AC
		// (set) Token: 0x06002186 RID: 8582 RVA: 0x00011DC4 File Offset: 0x0000FFC4
		public unsafe Manor Manor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_Manor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Manor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_Manor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002187 RID: 8583 RVA: 0x000EA0DC File Offset: 0x000E82DC
		// (set) Token: 0x06002188 RID: 8584 RVA: 0x00011DE3 File Offset: 0x0000FFE3
		public unsafe QuestEntry DigTunnelEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_DigTunnelEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_DigTunnelEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002189 RID: 8585 RVA: 0x000EA10C File Offset: 0x000E830C
		// (set) Token: 0x0600218A RID: 8586 RVA: 0x00011E02 File Offset: 0x00010002
		public unsafe QuestEntry WaitForTunnelEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_WaitForTunnelEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_WaitForTunnelEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x0600218B RID: 8587 RVA: 0x000EA13C File Offset: 0x000E833C
		// (set) Token: 0x0600218C RID: 8588 RVA: 0x00011E21 File Offset: 0x00010021
		public unsafe QuestEntry EnquireAboutRDXEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_EnquireAboutRDXEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_EnquireAboutRDXEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x0600218D RID: 8589 RVA: 0x000EA16C File Offset: 0x000E836C
		// (set) Token: 0x0600218E RID: 8590 RVA: 0x00011E40 File Offset: 0x00010040
		public unsafe QuestEntry ObtainRDXEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_ObtainRDXEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_ObtainRDXEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x0600218F RID: 8591 RVA: 0x000EA19C File Offset: 0x000E839C
		// (set) Token: 0x06002190 RID: 8592 RVA: 0x00011E5F File Offset: 0x0001005F
		public unsafe QuestEntry EnquireAboutBombEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_EnquireAboutBombEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_EnquireAboutBombEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06002191 RID: 8593 RVA: 0x000EA1CC File Offset: 0x000E83CC
		// (set) Token: 0x06002192 RID: 8594 RVA: 0x00011E7E File Offset: 0x0001007E
		public unsafe QuestEntry KillBanditEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_KillBanditEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_KillBanditEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06002193 RID: 8595 RVA: 0x000EA1FC File Offset: 0x000E83FC
		// (set) Token: 0x06002194 RID: 8596 RVA: 0x00011E9D File Offset: 0x0001009D
		public unsafe NPC Bandit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_Bandit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_Bandit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x000EA22C File Offset: 0x000E842C
		// (set) Token: 0x06002196 RID: 8598 RVA: 0x00011EBC File Offset: 0x000100BC
		public unsafe GameObject BanditScheduleContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_BanditScheduleContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DefeatCartel.NativeFieldInfoPtr_BanditScheduleContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeFieldInfoPtr_DIG_TUNNEL_COST;

		// Token: 0x04001736 RID: 5942
		private static readonly IntPtr NativeFieldInfoPtr_Sam;

		// Token: 0x04001737 RID: 5943
		private static readonly IntPtr NativeFieldInfoPtr_Manor;

		// Token: 0x04001738 RID: 5944
		private static readonly IntPtr NativeFieldInfoPtr_DigTunnelEntry;

		// Token: 0x04001739 RID: 5945
		private static readonly IntPtr NativeFieldInfoPtr_WaitForTunnelEntry;

		// Token: 0x0400173A RID: 5946
		private static readonly IntPtr NativeFieldInfoPtr_EnquireAboutRDXEntry;

		// Token: 0x0400173B RID: 5947
		private static readonly IntPtr NativeFieldInfoPtr_ObtainRDXEntry;

		// Token: 0x0400173C RID: 5948
		private static readonly IntPtr NativeFieldInfoPtr_EnquireAboutBombEntry;

		// Token: 0x0400173D RID: 5949
		private static readonly IntPtr NativeFieldInfoPtr_KillBanditEntry;

		// Token: 0x0400173E RID: 5950
		private static readonly IntPtr NativeFieldInfoPtr_Bandit;

		// Token: 0x0400173F RID: 5951
		private static readonly IntPtr NativeFieldInfoPtr_BanditScheduleContainer;

		// Token: 0x04001740 RID: 5952
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001741 RID: 5953
		private static readonly IntPtr NativeMethodInfoPtr_OnSleepEnd_Private_Void_0;

		// Token: 0x04001742 RID: 5954
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0;

		// Token: 0x04001743 RID: 5955
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_Void_Int32_EQuestState_Boolean_0;

		// Token: 0x04001744 RID: 5956
		private static readonly IntPtr NativeMethodInfoPtr_PlayCountdownMusic_Public_Void_0;

		// Token: 0x04001745 RID: 5957
		private static readonly IntPtr NativeMethodInfoPtr_Defeat_Private_Void_0;

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
