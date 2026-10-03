using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Quests;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020007A4 RID: 1956
	public class JournalApp : App<JournalApp>
	{
		// Token: 0x0600BD32 RID: 48434 RVA: 0x003086BC File Offset: 0x003068BC
		// Note: this type is marked as 'beforefieldinit'.
		static JournalApp()
		{
			Il2CppClassPointerStore<JournalApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "JournalApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalApp>.NativeClassPtr);
			JournalApp.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "EntryContainer");
			JournalApp.NativeFieldInfoPtr_NoTasksLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "NoTasksLabel");
			JournalApp.NativeFieldInfoPtr_NoDetailsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "NoDetailsLabel");
			JournalApp.NativeFieldInfoPtr_DetailsPanelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "DetailsPanelContainer");
			JournalApp.NativeFieldInfoPtr_GenericEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "GenericEntry");
			JournalApp.NativeFieldInfoPtr_GenericDetailsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "GenericDetailsPanel");
			JournalApp.NativeFieldInfoPtr_GenericQuestEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "GenericQuestEntry");
			JournalApp.NativeFieldInfoPtr_QuestHUDUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "QuestHUDUIPrefab");
			JournalApp.NativeFieldInfoPtr_QuestEntryHUDUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "QuestEntryHUDUIPrefab");
			JournalApp.NativeFieldInfoPtr_currentDetailsPanelQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "currentDetailsPanelQuest");
			JournalApp.NativeFieldInfoPtr_currentDetailsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, "currentDetailsPanel");
			JournalApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100687984);
			JournalApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100687985);
			JournalApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100687986);
			JournalApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100687987);
			JournalApp.NativeMethodInfoPtr_RefreshDetailsPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100687988);
			JournalApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100687989);
			JournalApp.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100687990);
			JournalApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalApp>.NativeClassPtr, 100687991);
		}

		// Token: 0x0600BD33 RID: 48435 RVA: 0x00308868 File Offset: 0x00306A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315383, XrefRangeEnd = 315386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD34 RID: 48436 RVA: 0x003088A4 File Offset: 0x00306AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315386, XrefRangeEnd = 315400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD35 RID: 48437 RVA: 0x003088E0 File Offset: 0x00306AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315400, XrefRangeEnd = 315410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD36 RID: 48438 RVA: 0x0030892C File Offset: 0x00306B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315410, XrefRangeEnd = 315426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD37 RID: 48439 RVA: 0x00308968 File Offset: 0x00306B68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315440, RefRangeEnd = 315441, XrefRangeStart = 315426, XrefRangeEnd = 315440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDetailsPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JournalApp.NativeMethodInfoPtr_RefreshDetailsPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD38 RID: 48440 RVA: 0x0030899C File Offset: 0x00306B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315441, XrefRangeEnd = 315457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD39 RID: 48441 RVA: 0x003089D8 File Offset: 0x00306BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315457, XrefRangeEnd = 315458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JournalApp.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD3A RID: 48442 RVA: 0x00308A14 File Offset: 0x00306C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315458, XrefRangeEnd = 315464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JournalApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JournalApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD3B RID: 48443 RVA: 0x000582FA File Offset: 0x000564FA
		public JournalApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003915 RID: 14613
		// (get) Token: 0x0600BD3C RID: 48444 RVA: 0x00308A50 File Offset: 0x00306C50
		// (set) Token: 0x0600BD3D RID: 48445 RVA: 0x00058303 File Offset: 0x00056503
		public unsafe RectTransform EntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_EntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003916 RID: 14614
		// (get) Token: 0x0600BD3E RID: 48446 RVA: 0x00308A80 File Offset: 0x00306C80
		// (set) Token: 0x0600BD3F RID: 48447 RVA: 0x00058322 File Offset: 0x00056522
		public unsafe Text NoTasksLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_NoTasksLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_NoTasksLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003917 RID: 14615
		// (get) Token: 0x0600BD40 RID: 48448 RVA: 0x00308AB0 File Offset: 0x00306CB0
		// (set) Token: 0x0600BD41 RID: 48449 RVA: 0x00058341 File Offset: 0x00056541
		public unsafe Text NoDetailsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_NoDetailsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_NoDetailsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003918 RID: 14616
		// (get) Token: 0x0600BD42 RID: 48450 RVA: 0x00308AE0 File Offset: 0x00306CE0
		// (set) Token: 0x0600BD43 RID: 48451 RVA: 0x00058360 File Offset: 0x00056560
		public unsafe RectTransform DetailsPanelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_DetailsPanelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_DetailsPanelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003919 RID: 14617
		// (get) Token: 0x0600BD44 RID: 48452 RVA: 0x00308B10 File Offset: 0x00306D10
		// (set) Token: 0x0600BD45 RID: 48453 RVA: 0x0005837F File Offset: 0x0005657F
		public unsafe GameObject GenericEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700391A RID: 14618
		// (get) Token: 0x0600BD46 RID: 48454 RVA: 0x00308B40 File Offset: 0x00306D40
		// (set) Token: 0x0600BD47 RID: 48455 RVA: 0x0005839E File Offset: 0x0005659E
		public unsafe GameObject GenericDetailsPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericDetailsPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericDetailsPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700391B RID: 14619
		// (get) Token: 0x0600BD48 RID: 48456 RVA: 0x00308B70 File Offset: 0x00306D70
		// (set) Token: 0x0600BD49 RID: 48457 RVA: 0x000583BD File Offset: 0x000565BD
		public unsafe GameObject GenericQuestEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericQuestEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_GenericQuestEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700391C RID: 14620
		// (get) Token: 0x0600BD4A RID: 48458 RVA: 0x00308BA0 File Offset: 0x00306DA0
		// (set) Token: 0x0600BD4B RID: 48459 RVA: 0x000583DC File Offset: 0x000565DC
		public unsafe QuestHUDUI QuestHUDUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_QuestHUDUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_QuestHUDUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700391D RID: 14621
		// (get) Token: 0x0600BD4C RID: 48460 RVA: 0x00308BD0 File Offset: 0x00306DD0
		// (set) Token: 0x0600BD4D RID: 48461 RVA: 0x000583FB File Offset: 0x000565FB
		public unsafe QuestEntryHUDUI QuestEntryHUDUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_QuestEntryHUDUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntryHUDUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_QuestEntryHUDUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700391E RID: 14622
		// (get) Token: 0x0600BD4E RID: 48462 RVA: 0x00308C00 File Offset: 0x00306E00
		// (set) Token: 0x0600BD4F RID: 48463 RVA: 0x0005841A File Offset: 0x0005661A
		public unsafe Quest currentDetailsPanelQuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_currentDetailsPanelQuest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_currentDetailsPanelQuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700391F RID: 14623
		// (get) Token: 0x0600BD50 RID: 48464 RVA: 0x00308C30 File Offset: 0x00306E30
		// (set) Token: 0x0600BD51 RID: 48465 RVA: 0x00058439 File Offset: 0x00056639
		public unsafe RectTransform currentDetailsPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_currentDetailsPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JournalApp.NativeFieldInfoPtr_currentDetailsPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400819B RID: 33179
		private static readonly IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x0400819C RID: 33180
		private static readonly IntPtr NativeFieldInfoPtr_NoTasksLabel;

		// Token: 0x0400819D RID: 33181
		private static readonly IntPtr NativeFieldInfoPtr_NoDetailsLabel;

		// Token: 0x0400819E RID: 33182
		private static readonly IntPtr NativeFieldInfoPtr_DetailsPanelContainer;

		// Token: 0x0400819F RID: 33183
		private static readonly IntPtr NativeFieldInfoPtr_GenericEntry;

		// Token: 0x040081A0 RID: 33184
		private static readonly IntPtr NativeFieldInfoPtr_GenericDetailsPanel;

		// Token: 0x040081A1 RID: 33185
		private static readonly IntPtr NativeFieldInfoPtr_GenericQuestEntry;

		// Token: 0x040081A2 RID: 33186
		private static readonly IntPtr NativeFieldInfoPtr_QuestHUDUIPrefab;

		// Token: 0x040081A3 RID: 33187
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryHUDUIPrefab;

		// Token: 0x040081A4 RID: 33188
		private static readonly IntPtr NativeFieldInfoPtr_currentDetailsPanelQuest;

		// Token: 0x040081A5 RID: 33189
		private static readonly IntPtr NativeFieldInfoPtr_currentDetailsPanel;

		// Token: 0x040081A6 RID: 33190
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040081A7 RID: 33191
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040081A8 RID: 33192
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x040081A9 RID: 33193
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040081AA RID: 33194
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDetailsPanel_Private_Void_0;

		// Token: 0x040081AB RID: 33195
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040081AC RID: 33196
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x040081AD RID: 33197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
