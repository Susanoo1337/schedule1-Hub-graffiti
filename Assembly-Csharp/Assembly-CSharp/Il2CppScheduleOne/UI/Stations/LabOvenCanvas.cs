using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x02000780 RID: 1920
	public class LabOvenCanvas : StationInterface<LabOvenCanvas>
	{
		// Token: 0x0600BAF2 RID: 47858 RVA: 0x003011D0 File Offset: 0x002FF3D0
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenCanvas()
		{
			Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "LabOvenCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr);
			LabOvenCanvas.NativeFieldInfoPtr__Oven_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "<Oven>k__BackingField");
			LabOvenCanvas.NativeFieldInfoPtr_IngredientSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "IngredientSlotUI");
			LabOvenCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "OutputSlotUI");
			LabOvenCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "InstructionLabel");
			LabOvenCanvas.NativeFieldInfoPtr_ErrorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "ErrorLabel");
			LabOvenCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "BeginButton");
			LabOvenCanvas.NativeFieldInfoPtr_BeginButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "BeginButtonLabel");
			LabOvenCanvas.NativeFieldInfoPtr_ProgressContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "ProgressContainer");
			LabOvenCanvas.NativeFieldInfoPtr_IngredientIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "IngredientIcon");
			LabOvenCanvas.NativeFieldInfoPtr_ProgressImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "ProgressImg");
			LabOvenCanvas.NativeFieldInfoPtr_ProductIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "ProductIcon");
			LabOvenCanvas.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100687698);
			LabOvenCanvas.NativeMethodInfoPtr_set_Oven_Protected_set_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100687699);
			LabOvenCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100687700);
			LabOvenCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100687701);
			LabOvenCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100687702);
			LabOvenCanvas.NativeMethodInfoPtr_Open_Public_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100687703);
			LabOvenCanvas.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100687704);
			LabOvenCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100687705);
			LabOvenCanvas.NativeMethodInfoPtr_BeginTask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100687706);
			LabOvenCanvas.NativeMethodInfoPtr_CanBegin_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100687707);
			LabOvenCanvas.NativeMethodInfoPtr_DoesOvenOutputHaveSpace_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100687708);
			LabOvenCanvas.NativeMethodInfoPtr_RefreshActiveOperation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100687709);
			LabOvenCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, 100687710);
		}

		// Token: 0x17003894 RID: 14484
		// (get) Token: 0x0600BAF3 RID: 47859 RVA: 0x003013E0 File Offset: 0x002FF5E0
		// (set) Token: 0x0600BAF4 RID: 47860 RVA: 0x00301420 File Offset: 0x002FF620
		public unsafe LabOven Oven
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_set_Oven_Protected_set_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BAF5 RID: 47861 RVA: 0x00301464 File Offset: 0x002FF664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312062, XrefRangeEnd = 312073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAF6 RID: 47862 RVA: 0x003014A0 File Offset: 0x002FF6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312073, XrefRangeEnd = 312075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAF7 RID: 47863 RVA: 0x003014DC File Offset: 0x002FF6DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 312102, RefRangeEnd = 312105, XrefRangeStart = 312075, XrefRangeEnd = 312102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAF8 RID: 47864 RVA: 0x00301510 File Offset: 0x002FF710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312115, RefRangeEnd = 312116, XrefRangeStart = 312105, XrefRangeEnd = 312115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(LabOven oven)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_Open_Public_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAF9 RID: 47865 RVA: 0x00301554 File Offset: 0x002FF754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312120, RefRangeEnd = 312121, XrefRangeStart = 312116, XrefRangeEnd = 312120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAFA RID: 47866 RVA: 0x00301588 File Offset: 0x002FF788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312121, XrefRangeEnd = 312123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAFB RID: 47867 RVA: 0x003015BC File Offset: 0x002FF7BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312166, RefRangeEnd = 312168, XrefRangeStart = 312123, XrefRangeEnd = 312166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_BeginTask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAFC RID: 47868 RVA: 0x003015F0 File Offset: 0x002FF7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312168, XrefRangeEnd = 312175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_CanBegin_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600BAFD RID: 47869 RVA: 0x0030162C File Offset: 0x002FF82C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312177, RefRangeEnd = 312179, XrefRangeStart = 312175, XrefRangeEnd = 312177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesOvenOutputHaveSpace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_DoesOvenOutputHaveSpace_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600BAFE RID: 47870 RVA: 0x00301668 File Offset: 0x002FF868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312179, XrefRangeEnd = 312183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshActiveOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr_RefreshActiveOperation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAFF RID: 47871 RVA: 0x0030169C File Offset: 0x002FF89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312183, XrefRangeEnd = 312186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB00 RID: 47872 RVA: 0x00057330 File Offset: 0x00055530
		public LabOvenCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003889 RID: 14473
		// (get) Token: 0x0600BB01 RID: 47873 RVA: 0x003016D8 File Offset: 0x002FF8D8
		// (set) Token: 0x0600BB02 RID: 47874 RVA: 0x00057339 File Offset: 0x00055539
		public unsafe LabOven _Oven_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr__Oven_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr__Oven_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x0600BB03 RID: 47875 RVA: 0x00301708 File Offset: 0x002FF908
		// (set) Token: 0x0600BB04 RID: 47876 RVA: 0x00057358 File Offset: 0x00055558
		public unsafe ItemSlotUI IngredientSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_IngredientSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_IngredientSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x0600BB05 RID: 47877 RVA: 0x00301738 File Offset: 0x002FF938
		// (set) Token: 0x0600BB06 RID: 47878 RVA: 0x00057377 File Offset: 0x00055577
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x0600BB07 RID: 47879 RVA: 0x00301768 File Offset: 0x002FF968
		// (set) Token: 0x0600BB08 RID: 47880 RVA: 0x00057396 File Offset: 0x00055596
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x0600BB09 RID: 47881 RVA: 0x00301798 File Offset: 0x002FF998
		// (set) Token: 0x0600BB0A RID: 47882 RVA: 0x000573B5 File Offset: 0x000555B5
		public unsafe TextMeshProUGUI ErrorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ErrorLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ErrorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x0600BB0B RID: 47883 RVA: 0x003017C8 File Offset: 0x002FF9C8
		// (set) Token: 0x0600BB0C RID: 47884 RVA: 0x000573D4 File Offset: 0x000555D4
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700388F RID: 14479
		// (get) Token: 0x0600BB0D RID: 47885 RVA: 0x003017F8 File Offset: 0x002FF9F8
		// (set) Token: 0x0600BB0E RID: 47886 RVA: 0x000573F3 File Offset: 0x000555F3
		public unsafe TextMeshProUGUI BeginButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_BeginButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_BeginButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003890 RID: 14480
		// (get) Token: 0x0600BB0F RID: 47887 RVA: 0x00301828 File Offset: 0x002FFA28
		// (set) Token: 0x0600BB10 RID: 47888 RVA: 0x00057412 File Offset: 0x00055612
		public unsafe RectTransform ProgressContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProgressContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProgressContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003891 RID: 14481
		// (get) Token: 0x0600BB11 RID: 47889 RVA: 0x00301858 File Offset: 0x002FFA58
		// (set) Token: 0x0600BB12 RID: 47890 RVA: 0x00057431 File Offset: 0x00055631
		public unsafe Image IngredientIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_IngredientIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_IngredientIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003892 RID: 14482
		// (get) Token: 0x0600BB13 RID: 47891 RVA: 0x00301888 File Offset: 0x002FFA88
		// (set) Token: 0x0600BB14 RID: 47892 RVA: 0x00057450 File Offset: 0x00055650
		public unsafe Image ProgressImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProgressImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProgressImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003893 RID: 14483
		// (get) Token: 0x0600BB15 RID: 47893 RVA: 0x003018B8 File Offset: 0x002FFAB8
		// (set) Token: 0x0600BB16 RID: 47894 RVA: 0x0005746F File Offset: 0x0005566F
		public unsafe Image ProductIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProductIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.NativeFieldInfoPtr_ProductIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008026 RID: 32806
		private static readonly IntPtr NativeFieldInfoPtr__Oven_k__BackingField;

		// Token: 0x04008027 RID: 32807
		private static readonly IntPtr NativeFieldInfoPtr_IngredientSlotUI;

		// Token: 0x04008028 RID: 32808
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x04008029 RID: 32809
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x0400802A RID: 32810
		private static readonly IntPtr NativeFieldInfoPtr_ErrorLabel;

		// Token: 0x0400802B RID: 32811
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x0400802C RID: 32812
		private static readonly IntPtr NativeFieldInfoPtr_BeginButtonLabel;

		// Token: 0x0400802D RID: 32813
		private static readonly IntPtr NativeFieldInfoPtr_ProgressContainer;

		// Token: 0x0400802E RID: 32814
		private static readonly IntPtr NativeFieldInfoPtr_IngredientIcon;

		// Token: 0x0400802F RID: 32815
		private static readonly IntPtr NativeFieldInfoPtr_ProgressImg;

		// Token: 0x04008030 RID: 32816
		private static readonly IntPtr NativeFieldInfoPtr_ProductIcon;

		// Token: 0x04008031 RID: 32817
		private static readonly IntPtr NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0;

		// Token: 0x04008032 RID: 32818
		private static readonly IntPtr NativeMethodInfoPtr_set_Oven_Protected_set_Void_LabOven_0;

		// Token: 0x04008033 RID: 32819
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04008034 RID: 32820
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04008035 RID: 32821
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x04008036 RID: 32822
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_LabOven_0;

		// Token: 0x04008037 RID: 32823
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04008038 RID: 32824
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x04008039 RID: 32825
		private static readonly IntPtr NativeMethodInfoPtr_BeginTask_Private_Void_0;

		// Token: 0x0400803A RID: 32826
		private static readonly IntPtr NativeMethodInfoPtr_CanBegin_Public_Boolean_0;

		// Token: 0x0400803B RID: 32827
		private static readonly IntPtr NativeMethodInfoPtr_DoesOvenOutputHaveSpace_Private_Boolean_0;

		// Token: 0x0400803C RID: 32828
		private static readonly IntPtr NativeMethodInfoPtr_RefreshActiveOperation_Private_Void_0;

		// Token: 0x0400803D RID: 32829
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D0C RID: 3340
		[ObfuscatedName("ScheduleOne.UI.Stations.LabOvenCanvas+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F7C0 RID: 63424 RVA: 0x003B5DF0 File Offset: 0x003B3FF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<LabOvenCanvas.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LabOvenCanvas>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenCanvas.__c__DisplayClass20_0>.NativeClassPtr);
				LabOvenCanvas.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				LabOvenCanvas.__c__DisplayClass20_0.NativeFieldInfoPtr_oven = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenCanvas.__c__DisplayClass20_0>.NativeClassPtr, "oven");
				LabOvenCanvas.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas.__c__DisplayClass20_0>.NativeClassPtr, 100687711);
				LabOvenCanvas.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenCanvas.__c__DisplayClass20_0>.NativeClassPtr, 100687712);
			}

			// Token: 0x0600F7C1 RID: 63425 RVA: 0x003B5E6C File Offset: 0x003B406C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenCanvas.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7C2 RID: 63426 RVA: 0x003B5EA8 File Offset: 0x003B40A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312048, XrefRangeEnd = 312062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenCanvas.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7C3 RID: 63427 RVA: 0x00075269 File Offset: 0x00073469
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B54 RID: 19284
			// (get) Token: 0x0600F7C4 RID: 63428 RVA: 0x003B5EDC File Offset: 0x003B40DC
			// (set) Token: 0x0600F7C5 RID: 63429 RVA: 0x00075272 File Offset: 0x00073472
			public unsafe LabOvenCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOvenCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B55 RID: 19285
			// (get) Token: 0x0600F7C6 RID: 63430 RVA: 0x003B5F0C File Offset: 0x003B410C
			// (set) Token: 0x0600F7C7 RID: 63431 RVA: 0x00075291 File Offset: 0x00073491
			public unsafe LabOven oven
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.__c__DisplayClass20_0.NativeFieldInfoPtr_oven);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenCanvas.__c__DisplayClass20_0.NativeFieldInfoPtr_oven), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A781 RID: 42881
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A782 RID: 42882
			private static readonly IntPtr NativeFieldInfoPtr_oven;

			// Token: 0x0400A783 RID: 42883
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A784 RID: 42884
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
