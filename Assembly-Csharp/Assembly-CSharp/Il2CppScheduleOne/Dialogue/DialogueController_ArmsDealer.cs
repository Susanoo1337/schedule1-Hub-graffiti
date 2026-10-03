using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003B2 RID: 946
	public class DialogueController_ArmsDealer : DialogueController
	{
		// Token: 0x06005601 RID: 22017 RVA: 0x001A4CC8 File Offset: 0x001A2EC8
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_ArmsDealer()
		{
			Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_ArmsDealer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr);
			DialogueController_ArmsDealer.NativeFieldInfoPtr_MeleeWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "MeleeWeapons");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_RangedWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "RangedWeapons");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_Ammo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "Ammo");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_RDX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "RDX");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_Bomb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "Bomb");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_allWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "allWeapons");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_chosenWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "chosenWeapon");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_questDefeatCartel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "questDefeatCartel");
			DialogueController_ArmsDealer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100674564);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100674565);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100674566);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100674567);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_GetWeaponChoices_Private_List_1_DialogueChoiceData_List_1_WeaponOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100674568);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100674569);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100674570);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_TradeRDXForBomb_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100674571);
			DialogueController_ArmsDealer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100674572);
		}

		// Token: 0x06005602 RID: 22018 RVA: 0x001A4E4C File Offset: 0x001A304C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189770, XrefRangeEnd = 189785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005603 RID: 22019 RVA: 0x001A4E80 File Offset: 0x001A3080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189785, XrefRangeEnd = 189823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_ArmsDealer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005604 RID: 22020 RVA: 0x001A4EBC File Offset: 0x001A30BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189823, XrefRangeEnd = 189857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_ArmsDealer.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005605 RID: 22021 RVA: 0x001A4F0C File Offset: 0x001A310C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189857, XrefRangeEnd = 189878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_ArmsDealer.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			existingChoices = ((intPtr4 == 0) ? null : new List<DialogueChoiceData>(intPtr4));
		}

		// Token: 0x06005606 RID: 22022 RVA: 0x001A4F80 File Offset: 0x001A3180
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 189920, RefRangeEnd = 189923, XrefRangeStart = 189878, XrefRangeEnd = 189920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DialogueChoiceData> GetWeaponChoices(List<DialogueController_ArmsDealer.WeaponOption> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.NativeMethodInfoPtr_GetWeaponChoices_Private_List_1_DialogueChoiceData_List_1_WeaponOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceData>>(intPtr3) : null;
		}

		// Token: 0x06005607 RID: 22023 RVA: 0x001A4FD0 File Offset: 0x001A31D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189923, XrefRangeEnd = 189955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_ArmsDealer.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005608 RID: 22024 RVA: 0x001A5044 File Offset: 0x001A3244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189955, XrefRangeEnd = 189992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_ArmsDealer.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005609 RID: 22025 RVA: 0x001A50AC File Offset: 0x001A32AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189992, XrefRangeEnd = 190002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TradeRDXForBomb()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.NativeMethodInfoPtr_TradeRDXForBomb_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600560A RID: 22026 RVA: 0x001A50E0 File Offset: 0x001A32E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190002, XrefRangeEnd = 190003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_ArmsDealer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600560B RID: 22027 RVA: 0x00028AA9 File Offset: 0x00026CA9
		public DialogueController_ArmsDealer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x0600560C RID: 22028 RVA: 0x001A511C File Offset: 0x001A331C
		// (set) Token: 0x0600560D RID: 22029 RVA: 0x00028AB2 File Offset: 0x00026CB2
		public unsafe List<DialogueController_ArmsDealer.WeaponOption> MeleeWeapons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_MeleeWeapons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_ArmsDealer.WeaponOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_MeleeWeapons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x0600560E RID: 22030 RVA: 0x001A514C File Offset: 0x001A334C
		// (set) Token: 0x0600560F RID: 22031 RVA: 0x00028AD1 File Offset: 0x00026CD1
		public unsafe List<DialogueController_ArmsDealer.WeaponOption> RangedWeapons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_RangedWeapons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_ArmsDealer.WeaponOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_RangedWeapons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x06005610 RID: 22032 RVA: 0x001A517C File Offset: 0x001A337C
		// (set) Token: 0x06005611 RID: 22033 RVA: 0x00028AF0 File Offset: 0x00026CF0
		public unsafe List<DialogueController_ArmsDealer.WeaponOption> Ammo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_Ammo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_ArmsDealer.WeaponOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_Ammo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x06005612 RID: 22034 RVA: 0x001A51AC File Offset: 0x001A33AC
		// (set) Token: 0x06005613 RID: 22035 RVA: 0x00028B0F File Offset: 0x00026D0F
		public unsafe ItemDefinition RDX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_RDX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_RDX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x06005614 RID: 22036 RVA: 0x001A51DC File Offset: 0x001A33DC
		// (set) Token: 0x06005615 RID: 22037 RVA: 0x00028B2E File Offset: 0x00026D2E
		public unsafe ItemDefinition Bomb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_Bomb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_Bomb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x06005616 RID: 22038 RVA: 0x001A520C File Offset: 0x001A340C
		// (set) Token: 0x06005617 RID: 22039 RVA: 0x00028B4D File Offset: 0x00026D4D
		public unsafe List<DialogueController_ArmsDealer.WeaponOption> allWeapons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_allWeapons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_ArmsDealer.WeaponOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_allWeapons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x06005618 RID: 22040 RVA: 0x001A523C File Offset: 0x001A343C
		// (set) Token: 0x06005619 RID: 22041 RVA: 0x00028B6C File Offset: 0x00026D6C
		public unsafe DialogueController_ArmsDealer.WeaponOption chosenWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_chosenWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_ArmsDealer.WeaponOption>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_chosenWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x0600561A RID: 22042 RVA: 0x001A526C File Offset: 0x001A346C
		// (set) Token: 0x0600561B RID: 22043 RVA: 0x00028B8B File Offset: 0x00026D8B
		public unsafe Quest_DefeatCartel questDefeatCartel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_questDefeatCartel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest_DefeatCartel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_questDefeatCartel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B41 RID: 15169
		private static readonly IntPtr NativeFieldInfoPtr_MeleeWeapons;

		// Token: 0x04003B42 RID: 15170
		private static readonly IntPtr NativeFieldInfoPtr_RangedWeapons;

		// Token: 0x04003B43 RID: 15171
		private static readonly IntPtr NativeFieldInfoPtr_Ammo;

		// Token: 0x04003B44 RID: 15172
		private static readonly IntPtr NativeFieldInfoPtr_RDX;

		// Token: 0x04003B45 RID: 15173
		private static readonly IntPtr NativeFieldInfoPtr_Bomb;

		// Token: 0x04003B46 RID: 15174
		private static readonly IntPtr NativeFieldInfoPtr_allWeapons;

		// Token: 0x04003B47 RID: 15175
		private static readonly IntPtr NativeFieldInfoPtr_chosenWeapon;

		// Token: 0x04003B48 RID: 15176
		private static readonly IntPtr NativeFieldInfoPtr_questDefeatCartel;

		// Token: 0x04003B49 RID: 15177
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003B4A RID: 15178
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003B4B RID: 15179
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0;

		// Token: 0x04003B4C RID: 15180
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x04003B4D RID: 15181
		private static readonly IntPtr NativeMethodInfoPtr_GetWeaponChoices_Private_List_1_DialogueChoiceData_List_1_WeaponOption_0;

		// Token: 0x04003B4E RID: 15182
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x04003B4F RID: 15183
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x04003B50 RID: 15184
		private static readonly IntPtr NativeMethodInfoPtr_TradeRDXForBomb_Private_Void_0;

		// Token: 0x04003B51 RID: 15185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AB9 RID: 2745
		[Serializable]
		public class WeaponOption : Object
		{
			// Token: 0x0600E384 RID: 58244 RVA: 0x0037B92C File Offset: 0x00379B2C
			// Note: this type is marked as 'beforefieldinit'.
			static WeaponOption()
			{
				Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "WeaponOption");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr);
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_IsAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "IsAvailable");
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_NotAvailableReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "NotAvailableReason");
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "Item");
				DialogueController_ArmsDealer.WeaponOption.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, 100674573);
				DialogueController_ArmsDealer.WeaponOption.NativeMethodInfoPtr_get_Price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, 100674574);
				DialogueController_ArmsDealer.WeaponOption.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, 100674575);
			}

			// Token: 0x1700453A RID: 17722
			// (get) Token: 0x0600E385 RID: 58245 RVA: 0x0037B9D0 File Offset: 0x00379BD0
			public unsafe string Name
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 189760, RefRangeEnd = 189765, XrefRangeStart = 189755, XrefRangeEnd = 189760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.WeaponOption.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700453B RID: 17723
			// (get) Token: 0x0600E386 RID: 58246 RVA: 0x0037BA08 File Offset: 0x00379C08
			public unsafe float Price
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.WeaponOption.NativeMethodInfoPtr_get_Price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600E387 RID: 58247 RVA: 0x0037BA44 File Offset: 0x00379C44
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WeaponOption() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.WeaponOption.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E388 RID: 58248 RVA: 0x0006B446 File Offset: 0x00069646
			public WeaponOption(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004537 RID: 17719
			// (get) Token: 0x0600E389 RID: 58249 RVA: 0x0037BA80 File Offset: 0x00379C80
			// (set) Token: 0x0600E38A RID: 58250 RVA: 0x0006B44F File Offset: 0x0006964F
			public unsafe bool IsAvailable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_IsAvailable);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_IsAvailable)) = value;
				}
			}

			// Token: 0x17004538 RID: 17720
			// (get) Token: 0x0600E38B RID: 58251 RVA: 0x0037BAA8 File Offset: 0x00379CA8
			// (set) Token: 0x0600E38C RID: 58252 RVA: 0x0006B46A File Offset: 0x0006966A
			public unsafe string NotAvailableReason
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_NotAvailableReason);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_NotAvailableReason), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004539 RID: 17721
			// (get) Token: 0x0600E38D RID: 58253 RVA: 0x0037BAD0 File Offset: 0x00379CD0
			// (set) Token: 0x0600E38E RID: 58254 RVA: 0x0006B489 File Offset: 0x00069689
			public unsafe StorableItemDefinition Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009AAA RID: 39594
			private static readonly IntPtr NativeFieldInfoPtr_IsAvailable;

			// Token: 0x04009AAB RID: 39595
			private static readonly IntPtr NativeFieldInfoPtr_NotAvailableReason;

			// Token: 0x04009AAC RID: 39596
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04009AAD RID: 39597
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

			// Token: 0x04009AAE RID: 39598
			private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Single_0;

			// Token: 0x04009AAF RID: 39599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000ABA RID: 2746
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_ArmsDealer+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600E38F RID: 58255 RVA: 0x0037BB00 File Offset: 0x00379D00
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DialogueController_ArmsDealer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c>.NativeClassPtr);
				DialogueController_ArmsDealer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c>.NativeClassPtr, "<>9");
				DialogueController_ArmsDealer.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c>.NativeClassPtr, "<>9__10_0");
				DialogueController_ArmsDealer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c>.NativeClassPtr, 100674577);
				DialogueController_ArmsDealer.__c.NativeMethodInfoPtr__Start_b__10_0_Internal_Boolean_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c>.NativeClassPtr, 100674578);
			}

			// Token: 0x0600E390 RID: 58256 RVA: 0x0037BB7C File Offset: 0x00379D7C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E391 RID: 58257 RVA: 0x0037BBB8 File Offset: 0x00379DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189765, XrefRangeEnd = 189767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__10_0(Quest q)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(q);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c.NativeMethodInfoPtr__Start_b__10_0_Internal_Boolean_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E392 RID: 58258 RVA: 0x0006B4A8 File Offset: 0x000696A8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700453C RID: 17724
			// (get) Token: 0x0600E393 RID: 58259 RVA: 0x0037BC08 File Offset: 0x00379E08
			// (set) Token: 0x0600E394 RID: 58260 RVA: 0x0006B4B1 File Offset: 0x000696B1
			public unsafe static DialogueController_ArmsDealer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController_ArmsDealer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_ArmsDealer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController_ArmsDealer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700453D RID: 17725
			// (get) Token: 0x0600E395 RID: 58261 RVA: 0x0037BC30 File Offset: 0x00379E30
			// (set) Token: 0x0600E396 RID: 58262 RVA: 0x0006B4C3 File Offset: 0x000696C3
			public unsafe static Func<Quest, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController_ArmsDealer.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Quest, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController_ArmsDealer.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009AB0 RID: 39600
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009AB1 RID: 39601
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04009AB2 RID: 39602
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AB3 RID: 39603
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__10_0_Internal_Boolean_Quest_0;
		}

		// Token: 0x02000ABB RID: 2747
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_ArmsDealer+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x0600E397 RID: 58263 RVA: 0x0037BC58 File Offset: 0x00379E58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass11_0>.NativeClassPtr);
				DialogueController_ArmsDealer.__c__DisplayClass11_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass11_0>.NativeClassPtr, "choiceLabel");
				DialogueController_ArmsDealer.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass11_0>.NativeClassPtr, 100674579);
				DialogueController_ArmsDealer.__c__DisplayClass11_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_WeaponOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass11_0>.NativeClassPtr, 100674580);
			}

			// Token: 0x0600E398 RID: 58264 RVA: 0x0037BCC0 File Offset: 0x00379EC0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E399 RID: 58265 RVA: 0x0037BCFC File Offset: 0x00379EFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189767, XrefRangeEnd = 189770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChoiceCallback_b__0(DialogueController_ArmsDealer.WeaponOption x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c__DisplayClass11_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_WeaponOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E39A RID: 58266 RVA: 0x0006B4D5 File Offset: 0x000696D5
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700453E RID: 17726
			// (get) Token: 0x0600E39B RID: 58267 RVA: 0x0037BD4C File Offset: 0x00379F4C
			// (set) Token: 0x0600E39C RID: 58268 RVA: 0x0006B4DE File Offset: 0x000696DE
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.__c__DisplayClass11_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.__c__DisplayClass11_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009AB4 RID: 39604
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04009AB5 RID: 39605
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AB6 RID: 39606
			private static readonly IntPtr NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_WeaponOption_0;
		}

		// Token: 0x02000ABC RID: 2748
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_ArmsDealer+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x0600E39D RID: 58269 RVA: 0x0037BD74 File Offset: 0x00379F74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass14_0>.NativeClassPtr);
				DialogueController_ArmsDealer.__c__DisplayClass14_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass14_0>.NativeClassPtr, "choiceLabel");
				DialogueController_ArmsDealer.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass14_0>.NativeClassPtr, 100674581);
				DialogueController_ArmsDealer.__c__DisplayClass14_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_WeaponOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass14_0>.NativeClassPtr, 100674582);
			}

			// Token: 0x0600E39E RID: 58270 RVA: 0x0037BDDC File Offset: 0x00379FDC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E39F RID: 58271 RVA: 0x0037BE18 File Offset: 0x0037A018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckChoice_b__0(DialogueController_ArmsDealer.WeaponOption x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c__DisplayClass14_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_WeaponOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E3A0 RID: 58272 RVA: 0x0006B4FD File Offset: 0x000696FD
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700453F RID: 17727
			// (get) Token: 0x0600E3A1 RID: 58273 RVA: 0x0037BE68 File Offset: 0x0037A068
			// (set) Token: 0x0600E3A2 RID: 58274 RVA: 0x0006B506 File Offset: 0x00069706
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.__c__DisplayClass14_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.__c__DisplayClass14_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009AB7 RID: 39607
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04009AB8 RID: 39608
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AB9 RID: 39609
			private static readonly IntPtr NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_WeaponOption_0;
		}
	}
}
