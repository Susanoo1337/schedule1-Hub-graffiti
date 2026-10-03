using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI;
using Il2CppScheduleOne.UI.Compass;
using Il2CppScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000141 RID: 321
	[Serializable]
	public class QuestEntry : MonoBehaviour
	{
		// Token: 0x06002083 RID: 8323 RVA: 0x000E5AA8 File Offset: 0x000E3CA8
		// Note: this type is marked as 'beforefieldinit'.
		static QuestEntry()
		{
			Il2CppClassPointerStore<QuestEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "QuestEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr);
			QuestEntry.NativeFieldInfoPtr__ParentQuest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "<ParentQuest>k__BackingField");
			QuestEntry.NativeFieldInfoPtr_EntryTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "EntryTitle");
			QuestEntry.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "state");
			QuestEntry.NativeFieldInfoPtr_AutoComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "AutoComplete");
			QuestEntry.NativeFieldInfoPtr_AutoCompleteConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "AutoCompleteConditions");
			QuestEntry.NativeFieldInfoPtr_CompleteParentQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "CompleteParentQuest");
			QuestEntry.NativeFieldInfoPtr_EntryAddedIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "EntryAddedIn");
			QuestEntry.NativeFieldInfoPtr_AutoCreatePoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "AutoCreatePoI");
			QuestEntry.NativeFieldInfoPtr_PoILocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "PoILocation");
			QuestEntry.NativeFieldInfoPtr_AutoUpdatePoILocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "AutoUpdatePoILocation");
			QuestEntry.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "PoI");
			QuestEntry.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "onStart");
			QuestEntry.NativeFieldInfoPtr_onEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "onEnd");
			QuestEntry.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "onComplete");
			QuestEntry.NativeFieldInfoPtr_onInitialComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "onInitialComplete");
			QuestEntry.NativeFieldInfoPtr_compassElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "compassElement");
			QuestEntry.NativeFieldInfoPtr_entryUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "entryUI");
			QuestEntry.NativeFieldInfoPtr_PoIIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "PoIIcon");
			QuestEntry.NativeMethodInfoPtr_get_ParentQuest_Public_get_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667499);
			QuestEntry.NativeMethodInfoPtr_set_ParentQuest_Private_set_Void_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667500);
			QuestEntry.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667501);
			QuestEntry.NativeMethodInfoPtr_get_State_Public_get_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667502);
			QuestEntry.NativeMethodInfoPtr_get_QuestEntryIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667503);
			QuestEntry.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667504);
			QuestEntry.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667505);
			QuestEntry.NativeMethodInfoPtr_OnValidate_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667506);
			QuestEntry.NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667507);
			QuestEntry.NativeMethodInfoPtr_SetData_Public_Void_QuestEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667508);
			QuestEntry.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667509);
			QuestEntry.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667510);
			QuestEntry.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667511);
			QuestEntry.NativeMethodInfoPtr_SetState_Public_Virtual_New_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667512);
			QuestEntry.NativeMethodInfoPtr_ShouldShowPoI_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667513);
			QuestEntry.NativeMethodInfoPtr_UpdatePoI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667514);
			QuestEntry.NativeMethodInfoPtr_SetPoIColor_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667515);
			QuestEntry.NativeMethodInfoPtr_SetPoILocation_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667516);
			QuestEntry.NativeMethodInfoPtr_CreatePoI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667517);
			QuestEntry.NativeMethodInfoPtr_DestroyPoI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667518);
			QuestEntry.NativeMethodInfoPtr_CreateCompassElement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667519);
			QuestEntry.NativeMethodInfoPtr_UpdateCompassElement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667520);
			QuestEntry.NativeMethodInfoPtr_GetSaveData_Public_QuestEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667521);
			QuestEntry.NativeMethodInfoPtr_UpdateName_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667522);
			QuestEntry.NativeMethodInfoPtr_EvaluateConditions_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667523);
			QuestEntry.NativeMethodInfoPtr_SetEntryTitle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667524);
			QuestEntry.NativeMethodInfoPtr_CreateEntryUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667525);
			QuestEntry.NativeMethodInfoPtr_UpdateEntryUI_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667526);
			QuestEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667527);
			QuestEntry.NativeMethodInfoPtr__Awake_b__27_0_Private_Void_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667528);
			QuestEntry.NativeMethodInfoPtr__Awake_b__27_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667529);
			QuestEntry.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667530);
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06002084 RID: 8324 RVA: 0x000E5EC0 File Offset: 0x000E40C0
		// (set) Token: 0x06002085 RID: 8325 RVA: 0x000E5F00 File Offset: 0x000E4100
		public unsafe Quest ParentQuest
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_get_ParentQuest_Public_get_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_set_ParentQuest_Private_set_Void_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06002086 RID: 8326 RVA: 0x000E5F44 File Offset: 0x000E4144
		public unsafe string Title
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x000E5F7C File Offset: 0x000E417C
		public unsafe EQuestState State
		{
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 35494, RefRangeEnd = 35643, XrefRangeStart = 35494, XrefRangeEnd = 35643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_get_State_Public_get_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x000E5FB8 File Offset: 0x000E41B8
		public unsafe int QuestEntryIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108515, XrefRangeEnd = 108519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_get_QuestEntryIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x000E5FF4 File Offset: 0x000E41F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108519, XrefRangeEnd = 108557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x000E6030 File Offset: 0x000E4230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108557, XrefRangeEnd = 108611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x000E606C File Offset: 0x000E426C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108611, XrefRangeEnd = 108623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_OnValidate_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x000E60A0 File Offset: 0x000E42A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108623, XrefRangeEnd = 108630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x000E60DC File Offset: 0x000E42DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108630, XrefRangeEnd = 108632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(QuestEntryData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_SetData_Public_Void_QuestEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x000E6120 File Offset: 0x000E4320
		[CallerCount(0)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x000E6154 File Offset: 0x000E4354
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 108632, RefRangeEnd = 108657, XrefRangeStart = 108632, XrefRangeEnd = 108632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_Complete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x000E6188 File Offset: 0x000E4388
		[CallerCount(0)]
		public unsafe void SetActive(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x000E61C8 File Offset: 0x000E43C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108657, XrefRangeEnd = 108726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetState(EQuestState newState, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newState;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_SetState_Public_Virtual_New_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x000E6220 File Offset: 0x000E4420
		[CallerCount(0)]
		public unsafe virtual bool ShouldShowPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_ShouldShowPoI_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x000E6268 File Offset: 0x000E4468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108726, XrefRangeEnd = 108732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_UpdatePoI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x000E62A4 File Offset: 0x000E44A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108732, XrefRangeEnd = 108737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPoIColor(string componentName, string colourName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(componentName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(colourName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_SetPoIColor_Public_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x000E6304 File Offset: 0x000E4504
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108744, RefRangeEnd = 108746, XrefRangeStart = 108737, XrefRangeEnd = 108744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPoILocation(Vector3 location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_SetPoILocation_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x000E6344 File Offset: 0x000E4544
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108795, RefRangeEnd = 108797, XrefRangeStart = 108746, XrefRangeEnd = 108795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreatePoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_CreatePoI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x000E6378 File Offset: 0x000E4578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108797, XrefRangeEnd = 108806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_DestroyPoI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x000E63AC File Offset: 0x000E45AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108806, XrefRangeEnd = 108821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateCompassElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_CreateCompassElement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x000E63E0 File Offset: 0x000E45E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 108828, RefRangeEnd = 108833, XrefRangeStart = 108821, XrefRangeEnd = 108828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCompassElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_UpdateCompassElement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x000E6414 File Offset: 0x000E4614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108837, RefRangeEnd = 108838, XrefRangeStart = 108833, XrefRangeEnd = 108837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntryData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_GetSaveData_Public_QuestEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QuestEntryData>(intPtr3) : null;
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x000E6454 File Offset: 0x000E4654
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108871, RefRangeEnd = 108873, XrefRangeStart = 108838, XrefRangeEnd = 108871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_UpdateName_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x000E6488 File Offset: 0x000E4688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108873, XrefRangeEnd = 108874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateConditions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_EvaluateConditions_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x000E64BC File Offset: 0x000E46BC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 108881, RefRangeEnd = 108890, XrefRangeStart = 108874, XrefRangeEnd = 108881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEntryTitle(string newTitle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newTitle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_SetEntryTitle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x000E6500 File Offset: 0x000E4700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108890, XrefRangeEnd = 108917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CreateEntryUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_CreateEntryUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x000E653C File Offset: 0x000E473C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108917, XrefRangeEnd = 108918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateEntryUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_UpdateEntryUI_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x000E6578 File Offset: 0x000E4778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108918, XrefRangeEnd = 108943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x000E65B4 File Offset: 0x000E47B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__27_0(EQuestState <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr__Awake_b__27_0_Private_Void_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x000E65F4 File Offset: 0x000E47F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34910, RefRangeEnd = 34911, XrefRangeStart = 34910, XrefRangeEnd = 34911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__27_1(bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr__Awake_b__27_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x000E6634 File Offset: 0x000E4834
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108974, RefRangeEnd = 108975, XrefRangeStart = 108943, XrefRangeEnd = 108974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x0001180C File Offset: 0x0000FA0C
		public QuestEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x000E6668 File Offset: 0x000E4868
		// (set) Token: 0x060020A6 RID: 8358 RVA: 0x00011815 File Offset: 0x0000FA15
		public unsafe Quest _ParentQuest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr__ParentQuest_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr__ParentQuest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x000E6698 File Offset: 0x000E4898
		// (set) Token: 0x060020A8 RID: 8360 RVA: 0x00011834 File Offset: 0x0000FA34
		public unsafe string EntryTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_EntryTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_EntryTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x000E66C0 File Offset: 0x000E48C0
		// (set) Token: 0x060020AA RID: 8362 RVA: 0x00011853 File Offset: 0x0000FA53
		public unsafe EQuestState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x000E66E8 File Offset: 0x000E48E8
		// (set) Token: 0x060020AC RID: 8364 RVA: 0x0001186E File Offset: 0x0000FA6E
		public unsafe bool AutoComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoComplete)) = value;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x000E6710 File Offset: 0x000E4910
		// (set) Token: 0x060020AE RID: 8366 RVA: 0x00011889 File Offset: 0x0000FA89
		public unsafe Conditions AutoCompleteConditions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoCompleteConditions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Conditions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoCompleteConditions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x060020AF RID: 8367 RVA: 0x000E6740 File Offset: 0x000E4940
		// (set) Token: 0x060020B0 RID: 8368 RVA: 0x000118A8 File Offset: 0x0000FAA8
		public unsafe bool CompleteParentQuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_CompleteParentQuest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_CompleteParentQuest)) = value;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x000E6768 File Offset: 0x000E4968
		// (set) Token: 0x060020B2 RID: 8370 RVA: 0x000118C3 File Offset: 0x0000FAC3
		public unsafe string EntryAddedIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_EntryAddedIn);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_EntryAddedIn), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x000E6790 File Offset: 0x000E4990
		// (set) Token: 0x060020B4 RID: 8372 RVA: 0x000118E2 File Offset: 0x0000FAE2
		public unsafe bool AutoCreatePoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoCreatePoI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoCreatePoI)) = value;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x000E67B8 File Offset: 0x000E49B8
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x000118FD File Offset: 0x0000FAFD
		public unsafe Transform PoILocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_PoILocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_PoILocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x060020B7 RID: 8375 RVA: 0x000E67E8 File Offset: 0x000E49E8
		// (set) Token: 0x060020B8 RID: 8376 RVA: 0x0001191C File Offset: 0x0000FB1C
		public unsafe bool AutoUpdatePoILocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoUpdatePoILocation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoUpdatePoILocation)) = value;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x000E6810 File Offset: 0x000E4A10
		// (set) Token: 0x060020BA RID: 8378 RVA: 0x00011937 File Offset: 0x0000FB37
		public unsafe POI PoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_PoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x000E6840 File Offset: 0x000E4A40
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x00011956 File Offset: 0x0000FB56
		public unsafe UnityEvent onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x000E6870 File Offset: 0x000E4A70
		// (set) Token: 0x060020BE RID: 8382 RVA: 0x00011975 File Offset: 0x0000FB75
		public unsafe UnityEvent onEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x000E68A0 File Offset: 0x000E4AA0
		// (set) Token: 0x060020C0 RID: 8384 RVA: 0x00011994 File Offset: 0x0000FB94
		public unsafe UnityEvent onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x000E68D0 File Offset: 0x000E4AD0
		// (set) Token: 0x060020C2 RID: 8386 RVA: 0x000119B3 File Offset: 0x0000FBB3
		public unsafe UnityEvent onInitialComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onInitialComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onInitialComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x000E6900 File Offset: 0x000E4B00
		// (set) Token: 0x060020C4 RID: 8388 RVA: 0x000119D2 File Offset: 0x0000FBD2
		public unsafe CompassManager.Element compassElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_compassElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompassManager.Element>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_compassElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x000E6930 File Offset: 0x000E4B30
		// (set) Token: 0x060020C6 RID: 8390 RVA: 0x000119F1 File Offset: 0x0000FBF1
		public unsafe QuestEntryHUDUI entryUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_entryUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntryHUDUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_entryUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x000E6960 File Offset: 0x000E4B60
		// (set) Token: 0x060020C8 RID: 8392 RVA: 0x00011A10 File Offset: 0x0000FC10
		public unsafe RectTransform PoIIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_PoIIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_PoIIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001680 RID: 5760
		private static readonly IntPtr NativeFieldInfoPtr__ParentQuest_k__BackingField;

		// Token: 0x04001681 RID: 5761
		private static readonly IntPtr NativeFieldInfoPtr_EntryTitle;

		// Token: 0x04001682 RID: 5762
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001683 RID: 5763
		private static readonly IntPtr NativeFieldInfoPtr_AutoComplete;

		// Token: 0x04001684 RID: 5764
		private static readonly IntPtr NativeFieldInfoPtr_AutoCompleteConditions;

		// Token: 0x04001685 RID: 5765
		private static readonly IntPtr NativeFieldInfoPtr_CompleteParentQuest;

		// Token: 0x04001686 RID: 5766
		private static readonly IntPtr NativeFieldInfoPtr_EntryAddedIn;

		// Token: 0x04001687 RID: 5767
		private static readonly IntPtr NativeFieldInfoPtr_AutoCreatePoI;

		// Token: 0x04001688 RID: 5768
		private static readonly IntPtr NativeFieldInfoPtr_PoILocation;

		// Token: 0x04001689 RID: 5769
		private static readonly IntPtr NativeFieldInfoPtr_AutoUpdatePoILocation;

		// Token: 0x0400168A RID: 5770
		private static readonly IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x0400168B RID: 5771
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x0400168C RID: 5772
		private static readonly IntPtr NativeFieldInfoPtr_onEnd;

		// Token: 0x0400168D RID: 5773
		private static readonly IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x0400168E RID: 5774
		private static readonly IntPtr NativeFieldInfoPtr_onInitialComplete;

		// Token: 0x0400168F RID: 5775
		private static readonly IntPtr NativeFieldInfoPtr_compassElement;

		// Token: 0x04001690 RID: 5776
		private static readonly IntPtr NativeFieldInfoPtr_entryUI;

		// Token: 0x04001691 RID: 5777
		private static readonly IntPtr NativeFieldInfoPtr_PoIIcon;

		// Token: 0x04001692 RID: 5778
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentQuest_Public_get_Quest_0;

		// Token: 0x04001693 RID: 5779
		private static readonly IntPtr NativeMethodInfoPtr_set_ParentQuest_Private_set_Void_Quest_0;

		// Token: 0x04001694 RID: 5780
		private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;

		// Token: 0x04001695 RID: 5781
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_EQuestState_0;

		// Token: 0x04001696 RID: 5782
		private static readonly IntPtr NativeMethodInfoPtr_get_QuestEntryIndex_Public_get_Int32_0;

		// Token: 0x04001697 RID: 5783
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_1;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_QuestEntryData_0;

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Virtual_New_Void_EQuestState_Boolean_0;

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowPoI_Protected_Virtual_New_Boolean_0;

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePoI_Protected_Virtual_New_Void_0;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeMethodInfoPtr_SetPoIColor_Public_Virtual_New_Void_String_String_0;

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeMethodInfoPtr_SetPoILocation_Public_Void_Vector3_0;

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeMethodInfoPtr_CreatePoI_Public_Void_0;

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeMethodInfoPtr_DestroyPoI_Public_Void_0;

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeMethodInfoPtr_CreateCompassElement_Public_Void_0;

		// Token: 0x040016A7 RID: 5799
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCompassElement_Public_Void_0;

		// Token: 0x040016A8 RID: 5800
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_QuestEntryData_0;

		// Token: 0x040016A9 RID: 5801
		private static readonly IntPtr NativeMethodInfoPtr_UpdateName_Private_Void_1;

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateConditions_Private_Void_1;

		// Token: 0x040016AB RID: 5803
		private static readonly IntPtr NativeMethodInfoPtr_SetEntryTitle_Public_Void_String_0;

		// Token: 0x040016AC RID: 5804
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntryUI_Protected_Virtual_New_Void_0;

		// Token: 0x040016AD RID: 5805
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEntryUI_Public_Virtual_New_Void_0;

		// Token: 0x040016AE RID: 5806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040016AF RID: 5807
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__27_0_Private_Void_EQuestState_0;

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__27_1_Private_Void_Boolean_0;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
