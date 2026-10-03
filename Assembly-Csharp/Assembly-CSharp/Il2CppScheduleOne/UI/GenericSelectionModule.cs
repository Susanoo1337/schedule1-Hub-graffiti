using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000735 RID: 1845
	public class GenericSelectionModule : Singleton<GenericSelectionModule>
	{
		// Token: 0x0600B1EC RID: 45548 RVA: 0x002E6A9C File Offset: 0x002E4C9C
		// Note: this type is marked as 'beforefieldinit'.
		static GenericSelectionModule()
		{
			Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "GenericSelectionModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr);
			GenericSelectionModule.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "<isOpen>k__BackingField");
			GenericSelectionModule.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "canvas");
			GenericSelectionModule.NativeFieldInfoPtr_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "TitleText");
			GenericSelectionModule.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "OptionContainer");
			GenericSelectionModule.NativeFieldInfoPtr_CloseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "CloseButton");
			GenericSelectionModule.NativeFieldInfoPtr_ListOptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "ListOptionPrefab");
			GenericSelectionModule.NativeFieldInfoPtr_OptionChosen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "OptionChosen");
			GenericSelectionModule.NativeFieldInfoPtr__ChosenOptionIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "<ChosenOptionIndex>k__BackingField");
			GenericSelectionModule.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100686694);
			GenericSelectionModule.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100686695);
			GenericSelectionModule.NativeMethodInfoPtr_get_ChosenOptionIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100686696);
			GenericSelectionModule.NativeMethodInfoPtr_set_ChosenOptionIndex_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100686697);
			GenericSelectionModule.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100686698);
			GenericSelectionModule.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100686699);
			GenericSelectionModule.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100686700);
			GenericSelectionModule.NativeMethodInfoPtr_Open_Public_Void_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100686701);
			GenericSelectionModule.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100686702);
			GenericSelectionModule.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100686703);
			GenericSelectionModule.NativeMethodInfoPtr_ClearOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100686704);
			GenericSelectionModule.NativeMethodInfoPtr_ListOptionClicked_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100686705);
			GenericSelectionModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100686706);
		}

		// Token: 0x17003583 RID: 13699
		// (get) Token: 0x0600B1ED RID: 45549 RVA: 0x002E6C70 File Offset: 0x002E4E70
		// (set) Token: 0x0600B1EE RID: 45550 RVA: 0x002E6CAC File Offset: 0x002E4EAC
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003584 RID: 13700
		// (get) Token: 0x0600B1EF RID: 45551 RVA: 0x002E6CEC File Offset: 0x002E4EEC
		// (set) Token: 0x0600B1F0 RID: 45552 RVA: 0x002E6D28 File Offset: 0x002E4F28
		public unsafe int ChosenOptionIndex
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 63943, RefRangeEnd = 63949, XrefRangeStart = 63943, XrefRangeEnd = 63949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_get_ChosenOptionIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 301601, RefRangeEnd = 301611, XrefRangeStart = 301601, XrefRangeEnd = 301601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_set_ChosenOptionIndex_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B1F1 RID: 45553 RVA: 0x002E6D68 File Offset: 0x002E4F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301611, XrefRangeEnd = 301617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericSelectionModule.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F2 RID: 45554 RVA: 0x002E6DA4 File Offset: 0x002E4FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301617, XrefRangeEnd = 301630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericSelectionModule.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F3 RID: 45555 RVA: 0x002E6DE0 File Offset: 0x002E4FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301630, XrefRangeEnd = 301633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F4 RID: 45556 RVA: 0x002E6E24 File Offset: 0x002E5024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301633, XrefRangeEnd = 301673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string title, List<string> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_Open_Public_Void_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F5 RID: 45557 RVA: 0x002E6E78 File Offset: 0x002E5078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301673, XrefRangeEnd = 301676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F6 RID: 45558 RVA: 0x002E6EAC File Offset: 0x002E50AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301676, XrefRangeEnd = 301679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F7 RID: 45559 RVA: 0x002E6EE0 File Offset: 0x002E50E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 301686, RefRangeEnd = 301693, XrefRangeStart = 301679, XrefRangeEnd = 301686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_ClearOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F8 RID: 45560 RVA: 0x002E6F14 File Offset: 0x002E5114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301693, XrefRangeEnd = 301696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListOptionClicked(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_ListOptionClicked_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1F9 RID: 45561 RVA: 0x002E6F54 File Offset: 0x002E5154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301696, XrefRangeEnd = 301699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericSelectionModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B1FA RID: 45562 RVA: 0x00051D07 File Offset: 0x0004FF07
		public GenericSelectionModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700357B RID: 13691
		// (get) Token: 0x0600B1FB RID: 45563 RVA: 0x002E6F90 File Offset: 0x002E5190
		// (set) Token: 0x0600B1FC RID: 45564 RVA: 0x00051D10 File Offset: 0x0004FF10
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700357C RID: 13692
		// (get) Token: 0x0600B1FD RID: 45565 RVA: 0x002E6FB8 File Offset: 0x002E51B8
		// (set) Token: 0x0600B1FE RID: 45566 RVA: 0x00051D2B File Offset: 0x0004FF2B
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700357D RID: 13693
		// (get) Token: 0x0600B1FF RID: 45567 RVA: 0x002E6FE8 File Offset: 0x002E51E8
		// (set) Token: 0x0600B200 RID: 45568 RVA: 0x00051D4A File Offset: 0x0004FF4A
		public unsafe TextMeshProUGUI TitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_TitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700357E RID: 13694
		// (get) Token: 0x0600B201 RID: 45569 RVA: 0x002E7018 File Offset: 0x002E5218
		// (set) Token: 0x0600B202 RID: 45570 RVA: 0x00051D69 File Offset: 0x0004FF69
		public unsafe RectTransform OptionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_OptionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700357F RID: 13695
		// (get) Token: 0x0600B203 RID: 45571 RVA: 0x002E7048 File Offset: 0x002E5248
		// (set) Token: 0x0600B204 RID: 45572 RVA: 0x00051D88 File Offset: 0x0004FF88
		public unsafe Button CloseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_CloseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_CloseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003580 RID: 13696
		// (get) Token: 0x0600B205 RID: 45573 RVA: 0x002E7078 File Offset: 0x002E5278
		// (set) Token: 0x0600B206 RID: 45574 RVA: 0x00051DA7 File Offset: 0x0004FFA7
		public unsafe GameObject ListOptionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_ListOptionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_ListOptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003581 RID: 13697
		// (get) Token: 0x0600B207 RID: 45575 RVA: 0x002E70A8 File Offset: 0x002E52A8
		// (set) Token: 0x0600B208 RID: 45576 RVA: 0x00051DC6 File Offset: 0x0004FFC6
		public unsafe bool OptionChosen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_OptionChosen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_OptionChosen)) = value;
			}
		}

		// Token: 0x17003582 RID: 13698
		// (get) Token: 0x0600B209 RID: 45577 RVA: 0x002E70D0 File Offset: 0x002E52D0
		// (set) Token: 0x0600B20A RID: 45578 RVA: 0x00051DE1 File Offset: 0x0004FFE1
		public unsafe int _ChosenOptionIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr__ChosenOptionIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr__ChosenOptionIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x04007A90 RID: 31376
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04007A91 RID: 31377
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04007A92 RID: 31378
		private static readonly IntPtr NativeFieldInfoPtr_TitleText;

		// Token: 0x04007A93 RID: 31379
		private static readonly IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x04007A94 RID: 31380
		private static readonly IntPtr NativeFieldInfoPtr_CloseButton;

		// Token: 0x04007A95 RID: 31381
		private static readonly IntPtr NativeFieldInfoPtr_ListOptionPrefab;

		// Token: 0x04007A96 RID: 31382
		private static readonly IntPtr NativeFieldInfoPtr_OptionChosen;

		// Token: 0x04007A97 RID: 31383
		private static readonly IntPtr NativeFieldInfoPtr__ChosenOptionIndex_k__BackingField;

		// Token: 0x04007A98 RID: 31384
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04007A99 RID: 31385
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04007A9A RID: 31386
		private static readonly IntPtr NativeMethodInfoPtr_get_ChosenOptionIndex_Public_get_Int32_0;

		// Token: 0x04007A9B RID: 31387
		private static readonly IntPtr NativeMethodInfoPtr_set_ChosenOptionIndex_Protected_set_Void_Int32_0;

		// Token: 0x04007A9C RID: 31388
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007A9D RID: 31389
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007A9E RID: 31390
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04007A9F RID: 31391
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_List_1_String_0;

		// Token: 0x04007AA0 RID: 31392
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007AA1 RID: 31393
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x04007AA2 RID: 31394
		private static readonly IntPtr NativeMethodInfoPtr_ClearOptions_Private_Void_0;

		// Token: 0x04007AA3 RID: 31395
		private static readonly IntPtr NativeMethodInfoPtr_ListOptionClicked_Private_Void_Int32_0;

		// Token: 0x04007AA4 RID: 31396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CC8 RID: 3272
		[ObfuscatedName("ScheduleOne.UI.GenericSelectionModule+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F4CD RID: 62669 RVA: 0x003AD58C File Offset: 0x003AB78C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr);
				GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr, "index");
				GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				GenericSelectionModule.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr, 100686707);
				GenericSelectionModule.__c__DisplayClass17_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr, 100686708);
			}

			// Token: 0x0600F4CE RID: 62670 RVA: 0x003AD608 File Offset: 0x003AB808
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4CF RID: 62671 RVA: 0x003AD644 File Offset: 0x003AB844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301598, XrefRangeEnd = 301601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Open_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.__c__DisplayClass17_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4D0 RID: 62672 RVA: 0x00073AEA File Offset: 0x00071CEA
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A5B RID: 19035
			// (get) Token: 0x0600F4D1 RID: 62673 RVA: 0x003AD678 File Offset: 0x003AB878
			// (set) Token: 0x0600F4D2 RID: 62674 RVA: 0x00073AF3 File Offset: 0x00071CF3
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17004A5C RID: 19036
			// (get) Token: 0x0600F4D3 RID: 62675 RVA: 0x003AD6A0 File Offset: 0x003AB8A0
			// (set) Token: 0x0600F4D4 RID: 62676 RVA: 0x00073B0E File Offset: 0x00071D0E
			public unsafe GenericSelectionModule __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericSelectionModule>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A5B2 RID: 42418
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x0400A5B3 RID: 42419
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A5B4 RID: 42420
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A5B5 RID: 42421
			private static readonly IntPtr NativeMethodInfoPtr__Open_b__0_Internal_Void_0;
		}
	}
}
