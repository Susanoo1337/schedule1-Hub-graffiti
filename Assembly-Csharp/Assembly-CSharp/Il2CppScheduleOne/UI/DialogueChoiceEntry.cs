using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200072B RID: 1835
	[Serializable]
	public class DialogueChoiceEntry : Il2CppSystem.Object
	{
		// Token: 0x0600B101 RID: 45313 RVA: 0x002E3C5C File Offset: 0x002E1E5C
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueChoiceEntry()
		{
			Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DialogueChoiceEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr);
			DialogueChoiceEntry.NativeFieldInfoPtr_GameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "GameObject");
			DialogueChoiceEntry.NativeFieldInfoPtr__Label_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "<Label>k__BackingField");
			DialogueChoiceEntry.NativeFieldInfoPtr__InputLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "<InputLabel>k__BackingField");
			DialogueChoiceEntry.NativeFieldInfoPtr__Button_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "<Button>k__BackingField");
			DialogueChoiceEntry.NativeFieldInfoPtr__NotPossibleGameObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "<NotPossibleGameObject>k__BackingField");
			DialogueChoiceEntry.NativeFieldInfoPtr__NotPossibleText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "<NotPossibleText>k__BackingField");
			DialogueChoiceEntry.NativeFieldInfoPtr__CanvasGroup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "<CanvasGroup>k__BackingField");
			DialogueChoiceEntry.NativeFieldInfoPtr__UISelectable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "<UISelectable>k__BackingField");
			DialogueChoiceEntry.NativeMethodInfoPtr_get_Label_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100686565);
			DialogueChoiceEntry.NativeMethodInfoPtr_set_Label_Private_set_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100686566);
			DialogueChoiceEntry.NativeMethodInfoPtr_get_InputLabel_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100686567);
			DialogueChoiceEntry.NativeMethodInfoPtr_set_InputLabel_Private_set_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100686568);
			DialogueChoiceEntry.NativeMethodInfoPtr_get_Button_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100686569);
			DialogueChoiceEntry.NativeMethodInfoPtr_set_Button_Private_set_Void_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100686570);
			DialogueChoiceEntry.NativeMethodInfoPtr_get_NotPossibleGameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100686571);
			DialogueChoiceEntry.NativeMethodInfoPtr_set_NotPossibleGameObject_Private_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100686572);
			DialogueChoiceEntry.NativeMethodInfoPtr_get_NotPossibleText_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100686573);
			DialogueChoiceEntry.NativeMethodInfoPtr_set_NotPossibleText_Private_set_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100686574);
			DialogueChoiceEntry.NativeMethodInfoPtr_get_CanvasGroup_Public_get_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100686575);
			DialogueChoiceEntry.NativeMethodInfoPtr_set_CanvasGroup_Private_set_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100686576);
			DialogueChoiceEntry.NativeMethodInfoPtr_get_UISelectable_Public_get_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100686577);
			DialogueChoiceEntry.NativeMethodInfoPtr_set_UISelectable_Private_set_Void_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100686578);
			DialogueChoiceEntry.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100686579);
			DialogueChoiceEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100686580);
		}

		// Token: 0x17003536 RID: 13622
		// (get) Token: 0x0600B102 RID: 45314 RVA: 0x002E3E6C File Offset: 0x002E206C
		// (set) Token: 0x0600B103 RID: 45315 RVA: 0x002E3EAC File Offset: 0x002E20AC
		public unsafe TextMeshProUGUI Label
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr_get_Label_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr_set_Label_Private_set_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003537 RID: 13623
		// (get) Token: 0x0600B104 RID: 45316 RVA: 0x002E3EF0 File Offset: 0x002E20F0
		// (set) Token: 0x0600B105 RID: 45317 RVA: 0x002E3F30 File Offset: 0x002E2130
		public unsafe TextMeshProUGUI InputLabel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr_get_InputLabel_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr_set_InputLabel_Private_set_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003538 RID: 13624
		// (get) Token: 0x0600B106 RID: 45318 RVA: 0x002E3F74 File Offset: 0x002E2174
		// (set) Token: 0x0600B107 RID: 45319 RVA: 0x002E3FB4 File Offset: 0x002E21B4
		public unsafe Button Button
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr_get_Button_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Button>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr_set_Button_Private_set_Void_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003539 RID: 13625
		// (get) Token: 0x0600B108 RID: 45320 RVA: 0x002E3FF8 File Offset: 0x002E21F8
		// (set) Token: 0x0600B109 RID: 45321 RVA: 0x002E4038 File Offset: 0x002E2238
		public unsafe GameObject NotPossibleGameObject
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr_get_NotPossibleGameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr_set_NotPossibleGameObject_Private_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700353A RID: 13626
		// (get) Token: 0x0600B10A RID: 45322 RVA: 0x002E407C File Offset: 0x002E227C
		// (set) Token: 0x0600B10B RID: 45323 RVA: 0x002E40BC File Offset: 0x002E22BC
		public unsafe TextMeshProUGUI NotPossibleText
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr_get_NotPossibleText_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr_set_NotPossibleText_Private_set_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700353B RID: 13627
		// (get) Token: 0x0600B10C RID: 45324 RVA: 0x002E4100 File Offset: 0x002E2300
		// (set) Token: 0x0600B10D RID: 45325 RVA: 0x002E4140 File Offset: 0x002E2340
		public unsafe CanvasGroup CanvasGroup
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30474, RefRangeEnd = 30475, XrefRangeStart = 30474, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr_get_CanvasGroup_Public_get_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr_set_CanvasGroup_Private_set_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700353C RID: 13628
		// (get) Token: 0x0600B10E RID: 45326 RVA: 0x002E4184 File Offset: 0x002E2384
		// (set) Token: 0x0600B10F RID: 45327 RVA: 0x002E41C4 File Offset: 0x002E23C4
		public unsafe UISelectable UISelectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr_get_UISelectable_Public_get_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr_set_UISelectable_Private_set_Void_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B110 RID: 45328 RVA: 0x002E4208 File Offset: 0x002E2408
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 300545, RefRangeEnd = 300547, XrefRangeStart = 300504, XrefRangeEnd = 300545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B111 RID: 45329 RVA: 0x002E423C File Offset: 0x002E243C
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChoiceEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B112 RID: 45330 RVA: 0x00051572 File Offset: 0x0004F772
		public DialogueChoiceEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700352E RID: 13614
		// (get) Token: 0x0600B113 RID: 45331 RVA: 0x002E4278 File Offset: 0x002E2478
		// (set) Token: 0x0600B114 RID: 45332 RVA: 0x0005157B File Offset: 0x0004F77B
		public unsafe GameObject GameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_GameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_GameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700352F RID: 13615
		// (get) Token: 0x0600B115 RID: 45333 RVA: 0x002E42A8 File Offset: 0x002E24A8
		// (set) Token: 0x0600B116 RID: 45334 RVA: 0x0005159A File Offset: 0x0004F79A
		public unsafe TextMeshProUGUI _Label_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr__Label_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr__Label_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003530 RID: 13616
		// (get) Token: 0x0600B117 RID: 45335 RVA: 0x002E42D8 File Offset: 0x002E24D8
		// (set) Token: 0x0600B118 RID: 45336 RVA: 0x000515B9 File Offset: 0x0004F7B9
		public unsafe TextMeshProUGUI _InputLabel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr__InputLabel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr__InputLabel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003531 RID: 13617
		// (get) Token: 0x0600B119 RID: 45337 RVA: 0x002E4308 File Offset: 0x002E2508
		// (set) Token: 0x0600B11A RID: 45338 RVA: 0x000515D8 File Offset: 0x0004F7D8
		public unsafe Button _Button_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr__Button_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr__Button_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003532 RID: 13618
		// (get) Token: 0x0600B11B RID: 45339 RVA: 0x002E4338 File Offset: 0x002E2538
		// (set) Token: 0x0600B11C RID: 45340 RVA: 0x000515F7 File Offset: 0x0004F7F7
		public unsafe GameObject _NotPossibleGameObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr__NotPossibleGameObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr__NotPossibleGameObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003533 RID: 13619
		// (get) Token: 0x0600B11D RID: 45341 RVA: 0x002E4368 File Offset: 0x002E2568
		// (set) Token: 0x0600B11E RID: 45342 RVA: 0x00051616 File Offset: 0x0004F816
		public unsafe TextMeshProUGUI _NotPossibleText_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr__NotPossibleText_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr__NotPossibleText_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003534 RID: 13620
		// (get) Token: 0x0600B11F RID: 45343 RVA: 0x002E4398 File Offset: 0x002E2598
		// (set) Token: 0x0600B120 RID: 45344 RVA: 0x00051635 File Offset: 0x0004F835
		public unsafe CanvasGroup _CanvasGroup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr__CanvasGroup_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr__CanvasGroup_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003535 RID: 13621
		// (get) Token: 0x0600B121 RID: 45345 RVA: 0x002E43C8 File Offset: 0x002E25C8
		// (set) Token: 0x0600B122 RID: 45346 RVA: 0x00051654 File Offset: 0x0004F854
		public unsafe UISelectable _UISelectable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr__UISelectable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr__UISelectable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040079F9 RID: 31225
		private static readonly IntPtr NativeFieldInfoPtr_GameObject;

		// Token: 0x040079FA RID: 31226
		private static readonly IntPtr NativeFieldInfoPtr__Label_k__BackingField;

		// Token: 0x040079FB RID: 31227
		private static readonly IntPtr NativeFieldInfoPtr__InputLabel_k__BackingField;

		// Token: 0x040079FC RID: 31228
		private static readonly IntPtr NativeFieldInfoPtr__Button_k__BackingField;

		// Token: 0x040079FD RID: 31229
		private static readonly IntPtr NativeFieldInfoPtr__NotPossibleGameObject_k__BackingField;

		// Token: 0x040079FE RID: 31230
		private static readonly IntPtr NativeFieldInfoPtr__NotPossibleText_k__BackingField;

		// Token: 0x040079FF RID: 31231
		private static readonly IntPtr NativeFieldInfoPtr__CanvasGroup_k__BackingField;

		// Token: 0x04007A00 RID: 31232
		private static readonly IntPtr NativeFieldInfoPtr__UISelectable_k__BackingField;

		// Token: 0x04007A01 RID: 31233
		private static readonly IntPtr NativeMethodInfoPtr_get_Label_Public_get_TextMeshProUGUI_0;

		// Token: 0x04007A02 RID: 31234
		private static readonly IntPtr NativeMethodInfoPtr_set_Label_Private_set_Void_TextMeshProUGUI_0;

		// Token: 0x04007A03 RID: 31235
		private static readonly IntPtr NativeMethodInfoPtr_get_InputLabel_Public_get_TextMeshProUGUI_0;

		// Token: 0x04007A04 RID: 31236
		private static readonly IntPtr NativeMethodInfoPtr_set_InputLabel_Private_set_Void_TextMeshProUGUI_0;

		// Token: 0x04007A05 RID: 31237
		private static readonly IntPtr NativeMethodInfoPtr_get_Button_Public_get_Button_0;

		// Token: 0x04007A06 RID: 31238
		private static readonly IntPtr NativeMethodInfoPtr_set_Button_Private_set_Void_Button_0;

		// Token: 0x04007A07 RID: 31239
		private static readonly IntPtr NativeMethodInfoPtr_get_NotPossibleGameObject_Public_get_GameObject_0;

		// Token: 0x04007A08 RID: 31240
		private static readonly IntPtr NativeMethodInfoPtr_set_NotPossibleGameObject_Private_set_Void_GameObject_0;

		// Token: 0x04007A09 RID: 31241
		private static readonly IntPtr NativeMethodInfoPtr_get_NotPossibleText_Public_get_TextMeshProUGUI_0;

		// Token: 0x04007A0A RID: 31242
		private static readonly IntPtr NativeMethodInfoPtr_set_NotPossibleText_Private_set_Void_TextMeshProUGUI_0;

		// Token: 0x04007A0B RID: 31243
		private static readonly IntPtr NativeMethodInfoPtr_get_CanvasGroup_Public_get_CanvasGroup_0;

		// Token: 0x04007A0C RID: 31244
		private static readonly IntPtr NativeMethodInfoPtr_set_CanvasGroup_Private_set_Void_CanvasGroup_0;

		// Token: 0x04007A0D RID: 31245
		private static readonly IntPtr NativeMethodInfoPtr_get_UISelectable_Public_get_UISelectable_0;

		// Token: 0x04007A0E RID: 31246
		private static readonly IntPtr NativeMethodInfoPtr_set_UISelectable_Private_set_Void_UISelectable_0;

		// Token: 0x04007A0F RID: 31247
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x04007A10 RID: 31248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
