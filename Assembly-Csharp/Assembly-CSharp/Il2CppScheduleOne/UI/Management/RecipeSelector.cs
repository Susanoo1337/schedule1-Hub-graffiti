using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007DE RID: 2014
	public class RecipeSelector : ClipboardScreen
	{
		// Token: 0x0600C4FB RID: 50427 RVA: 0x0031FC4C File Offset: 0x0031DE4C
		// Note: this type is marked as 'beforefieldinit'.
		static RecipeSelector()
		{
			Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "RecipeSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr);
			RecipeSelector.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "OptionContainer");
			RecipeSelector.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "TitleLabel");
			RecipeSelector.NativeFieldInfoPtr_OptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "OptionPrefab");
			RecipeSelector.NativeFieldInfoPtr_EmptyOptionSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "EmptyOptionSprite");
			RecipeSelector.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "lerpRoutine");
			RecipeSelector.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "options");
			RecipeSelector.NativeFieldInfoPtr_selectedOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "selectedOption");
			RecipeSelector.NativeFieldInfoPtr_optionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "optionButtons");
			RecipeSelector.NativeFieldInfoPtr_optionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "optionCallback");
			RecipeSelector.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "panel");
			RecipeSelector.NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_StationRecipe_StationRecipe_Action_1_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100688841);
			RecipeSelector.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100688842);
			RecipeSelector.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100688843);
			RecipeSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100688844);
			RecipeSelector.NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100688845);
			RecipeSelector.NativeMethodInfoPtr_DeleteOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100688846);
			RecipeSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100688847);
		}

		// Token: 0x0600C4FC RID: 50428 RVA: 0x0031FDD0 File Offset: 0x0031DFD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 326372, RefRangeEnd = 326373, XrefRangeStart = 326332, XrefRangeEnd = 326372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(string selectionTitle, List<StationRecipe> _options, StationRecipe _selectedOption = null, Action<StationRecipe> _optionCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectionTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_options);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_selectedOption);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_optionCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_StationRecipe_StationRecipe_Action_1_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4FD RID: 50429 RVA: 0x0031FE4C File Offset: 0x0031E04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326373, XrefRangeEnd = 326401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RecipeSelector.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4FE RID: 50430 RVA: 0x0031FE88 File Offset: 0x0031E088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326401, XrefRangeEnd = 326417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RecipeSelector.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4FF RID: 50431 RVA: 0x0031FEC4 File Offset: 0x0031E0C4
		[CallerCount(0)]
		public unsafe void ButtonClicked(StationRecipe option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C500 RID: 50432 RVA: 0x0031FF08 File Offset: 0x0031E108
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 326500, RefRangeEnd = 326501, XrefRangeStart = 326417, XrefRangeEnd = 326500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateOptions(List<StationRecipe> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C501 RID: 50433 RVA: 0x0031FF4C File Offset: 0x0031E14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326501, XrefRangeEnd = 326515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr_DeleteOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C502 RID: 50434 RVA: 0x0031FF80 File Offset: 0x0031E180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326515, XrefRangeEnd = 326530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RecipeSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C503 RID: 50435 RVA: 0x0005CF06 File Offset: 0x0005B106
		public RecipeSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003BCA RID: 15306
		// (get) Token: 0x0600C504 RID: 50436 RVA: 0x0031FFBC File Offset: 0x0031E1BC
		// (set) Token: 0x0600C505 RID: 50437 RVA: 0x0005CF0F File Offset: 0x0005B10F
		public unsafe RectTransform OptionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_OptionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BCB RID: 15307
		// (get) Token: 0x0600C506 RID: 50438 RVA: 0x0031FFEC File Offset: 0x0031E1EC
		// (set) Token: 0x0600C507 RID: 50439 RVA: 0x0005CF2E File Offset: 0x0005B12E
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BCC RID: 15308
		// (get) Token: 0x0600C508 RID: 50440 RVA: 0x0032001C File Offset: 0x0031E21C
		// (set) Token: 0x0600C509 RID: 50441 RVA: 0x0005CF4D File Offset: 0x0005B14D
		public unsafe GameObject OptionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_OptionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_OptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BCD RID: 15309
		// (get) Token: 0x0600C50A RID: 50442 RVA: 0x0032004C File Offset: 0x0031E24C
		// (set) Token: 0x0600C50B RID: 50443 RVA: 0x0005CF6C File Offset: 0x0005B16C
		public unsafe Sprite EmptyOptionSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_EmptyOptionSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_EmptyOptionSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BCE RID: 15310
		// (get) Token: 0x0600C50C RID: 50444 RVA: 0x0032007C File Offset: 0x0031E27C
		// (set) Token: 0x0600C50D RID: 50445 RVA: 0x0005CF8B File Offset: 0x0005B18B
		public new unsafe Coroutine lerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_lerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BCF RID: 15311
		// (get) Token: 0x0600C50E RID: 50446 RVA: 0x003200AC File Offset: 0x0031E2AC
		// (set) Token: 0x0600C50F RID: 50447 RVA: 0x0005CFAA File Offset: 0x0005B1AA
		public unsafe List<StationRecipe> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BD0 RID: 15312
		// (get) Token: 0x0600C510 RID: 50448 RVA: 0x003200DC File Offset: 0x0031E2DC
		// (set) Token: 0x0600C511 RID: 50449 RVA: 0x0005CFC9 File Offset: 0x0005B1C9
		public unsafe StationRecipe selectedOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_selectedOption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_selectedOption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BD1 RID: 15313
		// (get) Token: 0x0600C512 RID: 50450 RVA: 0x0032010C File Offset: 0x0031E30C
		// (set) Token: 0x0600C513 RID: 50451 RVA: 0x0005CFE8 File Offset: 0x0005B1E8
		public unsafe List<RectTransform> optionButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_optionButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_optionButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BD2 RID: 15314
		// (get) Token: 0x0600C514 RID: 50452 RVA: 0x0032013C File Offset: 0x0031E33C
		// (set) Token: 0x0600C515 RID: 50453 RVA: 0x0005D007 File Offset: 0x0005B207
		public unsafe Action<StationRecipe> optionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_optionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_optionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BD3 RID: 15315
		// (get) Token: 0x0600C516 RID: 50454 RVA: 0x0032016C File Offset: 0x0031E36C
		// (set) Token: 0x0600C517 RID: 50455 RVA: 0x0005D026 File Offset: 0x0005B226
		public unsafe UIContentPanel panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIContentPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008674 RID: 34420
		private static readonly IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x04008675 RID: 34421
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04008676 RID: 34422
		private static readonly IntPtr NativeFieldInfoPtr_OptionPrefab;

		// Token: 0x04008677 RID: 34423
		private static readonly IntPtr NativeFieldInfoPtr_EmptyOptionSprite;

		// Token: 0x04008678 RID: 34424
		private static readonly IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x04008679 RID: 34425
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x0400867A RID: 34426
		private static readonly IntPtr NativeFieldInfoPtr_selectedOption;

		// Token: 0x0400867B RID: 34427
		private static readonly IntPtr NativeFieldInfoPtr_optionButtons;

		// Token: 0x0400867C RID: 34428
		private static readonly IntPtr NativeFieldInfoPtr_optionCallback;

		// Token: 0x0400867D RID: 34429
		private static readonly IntPtr NativeFieldInfoPtr_panel;

		// Token: 0x0400867E RID: 34430
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_StationRecipe_StationRecipe_Action_1_StationRecipe_0;

		// Token: 0x0400867F RID: 34431
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x04008680 RID: 34432
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04008681 RID: 34433
		private static readonly IntPtr NativeMethodInfoPtr_ButtonClicked_Private_Void_StationRecipe_0;

		// Token: 0x04008682 RID: 34434
		private static readonly IntPtr NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_StationRecipe_0;

		// Token: 0x04008683 RID: 34435
		private static readonly IntPtr NativeMethodInfoPtr_DeleteOptions_Private_Void_0;

		// Token: 0x04008684 RID: 34436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D62 RID: 3426
		[ObfuscatedName("ScheduleOne.UI.Management.RecipeSelector+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600FAD9 RID: 64217 RVA: 0x003BEC0C File Offset: 0x003BCE0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr);
				RecipeSelector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr, "<>9");
				RecipeSelector.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr, "<>9__14_0");
				RecipeSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr, 100688849);
				RecipeSelector.__c.NativeMethodInfoPtr__CreateOptions_b__14_0_Internal_Int32_StationRecipe_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr, 100688850);
			}

			// Token: 0x0600FADA RID: 64218 RVA: 0x003BEC88 File Offset: 0x003BCE88
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FADB RID: 64219 RVA: 0x003BECC4 File Offset: 0x003BCEC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326330, XrefRangeEnd = 326332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CreateOptions_b__14_0(StationRecipe a, StationRecipe b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.__c.NativeMethodInfoPtr__CreateOptions_b__14_0_Internal_Int32_StationRecipe_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FADC RID: 64220 RVA: 0x00076ABE File Offset: 0x00074CBE
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C3A RID: 19514
			// (get) Token: 0x0600FADD RID: 64221 RVA: 0x003BED24 File Offset: 0x003BCF24
			// (set) Token: 0x0600FADE RID: 64222 RVA: 0x00076AC7 File Offset: 0x00074CC7
			public unsafe static RecipeSelector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RecipeSelector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RecipeSelector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RecipeSelector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C3B RID: 19515
			// (get) Token: 0x0600FADF RID: 64223 RVA: 0x003BED4C File Offset: 0x003BCF4C
			// (set) Token: 0x0600FAE0 RID: 64224 RVA: 0x00076AD9 File Offset: 0x00074CD9
			public unsafe static Comparison<StationRecipe> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RecipeSelector.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<StationRecipe>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RecipeSelector.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A947 RID: 43335
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A948 RID: 43336
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x0400A949 RID: 43337
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A94A RID: 43338
			private static readonly IntPtr NativeMethodInfoPtr__CreateOptions_b__14_0_Internal_Int32_StationRecipe_StationRecipe_0;
		}

		// Token: 0x02000D63 RID: 3427
		[ObfuscatedName("ScheduleOne.UI.Management.RecipeSelector+<>c__DisplayClass14_0")]
		public new sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FAE1 RID: 64225 RVA: 0x003BED74 File Offset: 0x003BCF74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass14_0>.NativeClassPtr);
				RecipeSelector.__c__DisplayClass14_0.NativeFieldInfoPtr_opt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass14_0>.NativeClassPtr, "opt");
				RecipeSelector.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				RecipeSelector.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass14_0>.NativeClassPtr, 100688851);
				RecipeSelector.__c__DisplayClass14_0.NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass14_0>.NativeClassPtr, 100688852);
				RecipeSelector.__c__DisplayClass14_0.NativeMethodInfoPtr__CreateOptions_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass14_0>.NativeClassPtr, 100688853);
			}

			// Token: 0x0600FAE2 RID: 64226 RVA: 0x003BEE04 File Offset: 0x003BD004
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FAE3 RID: 64227 RVA: 0x003BEE40 File Offset: 0x003BD040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateOptions_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.__c__DisplayClass14_0.NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FAE4 RID: 64228 RVA: 0x003BEE74 File Offset: 0x003BD074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateOptions_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.__c__DisplayClass14_0.NativeMethodInfoPtr__CreateOptions_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FAE5 RID: 64229 RVA: 0x00076AEB File Offset: 0x00074CEB
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C3C RID: 19516
			// (get) Token: 0x0600FAE6 RID: 64230 RVA: 0x003BEEA8 File Offset: 0x003BD0A8
			// (set) Token: 0x0600FAE7 RID: 64231 RVA: 0x00076AF4 File Offset: 0x00074CF4
			public unsafe StationRecipe opt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.__c__DisplayClass14_0.NativeFieldInfoPtr_opt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.__c__DisplayClass14_0.NativeFieldInfoPtr_opt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C3D RID: 19517
			// (get) Token: 0x0600FAE8 RID: 64232 RVA: 0x003BEED8 File Offset: 0x003BD0D8
			// (set) Token: 0x0600FAE9 RID: 64233 RVA: 0x00076B13 File Offset: 0x00074D13
			public unsafe RecipeSelector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RecipeSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A94B RID: 43339
			private static readonly IntPtr NativeFieldInfoPtr_opt;

			// Token: 0x0400A94C RID: 43340
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A94D RID: 43341
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A94E RID: 43342
			private static readonly IntPtr NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_0;

			// Token: 0x0400A94F RID: 43343
			private static readonly IntPtr NativeMethodInfoPtr__CreateOptions_b__2_Internal_Void_0;
		}
	}
}
