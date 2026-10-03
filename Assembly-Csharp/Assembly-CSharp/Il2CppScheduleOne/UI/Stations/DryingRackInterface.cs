using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x0200077F RID: 1919
	public class DryingRackInterface : StationInterface<DryingRackInterface>
	{
		// Token: 0x0600BACC RID: 47820 RVA: 0x00300A60 File Offset: 0x002FEC60
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackInterface()
		{
			Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "DryingRackInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr);
			DryingRackInterface.NativeFieldInfoPtr__Rack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, "<Rack>k__BackingField");
			DryingRackInterface.NativeFieldInfoPtr_ProgressContainerPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, "ProgressContainerPanel");
			DryingRackInterface.NativeFieldInfoPtr_InputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, "InputSlotUI");
			DryingRackInterface.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, "OutputSlotUI");
			DryingRackInterface.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, "InstructionLabel");
			DryingRackInterface.NativeFieldInfoPtr_CapacityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, "CapacityLabel");
			DryingRackInterface.NativeFieldInfoPtr_InsertButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, "InsertButton");
			DryingRackInterface.NativeFieldInfoPtr_IndicatorContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, "IndicatorContainer");
			DryingRackInterface.NativeFieldInfoPtr_IndicatorAlignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, "IndicatorAlignments");
			DryingRackInterface.NativeFieldInfoPtr_IndicatorPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, "IndicatorPrefab");
			DryingRackInterface.NativeFieldInfoPtr_operationUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, "operationUIs");
			DryingRackInterface.NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, 100687682);
			DryingRackInterface.NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, 100687683);
			DryingRackInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, 100687684);
			DryingRackInterface.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, 100687685);
			DryingRackInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, 100687686);
			DryingRackInterface.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, 100687687);
			DryingRackInterface.NativeMethodInfoPtr_UpdateDryingOperations_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, 100687688);
			DryingRackInterface.NativeMethodInfoPtr_UpdateQuantities_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, 100687689);
			DryingRackInterface.NativeMethodInfoPtr_Open_Public_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, 100687690);
			DryingRackInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, 100687691);
			DryingRackInterface.NativeMethodInfoPtr_CreateOperationUI_Private_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, 100687692);
			DryingRackInterface.NativeMethodInfoPtr_DestroyOperationUI_Private_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, 100687693);
			DryingRackInterface.NativeMethodInfoPtr_Insert_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, 100687694);
			DryingRackInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, 100687695);
		}

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x0600BACD RID: 47821 RVA: 0x00300C84 File Offset: 0x002FEE84
		// (set) Token: 0x0600BACE RID: 47822 RVA: 0x00300CC4 File Offset: 0x002FEEC4
		public unsafe DryingRack Rack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackInterface.NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackInterface.NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BACF RID: 47823 RVA: 0x00300D08 File Offset: 0x002FEF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311768, XrefRangeEnd = 311784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAD0 RID: 47824 RVA: 0x00300D44 File Offset: 0x002FEF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311784, XrefRangeEnd = 311786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackInterface.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAD1 RID: 47825 RVA: 0x00300D78 File Offset: 0x002FEF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311786, XrefRangeEnd = 311788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAD2 RID: 47826 RVA: 0x00300DB4 File Offset: 0x002FEFB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311798, RefRangeEnd = 311800, XrefRangeStart = 311788, XrefRangeEnd = 311798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackInterface.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAD3 RID: 47827 RVA: 0x00300DE8 File Offset: 0x002FEFE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 311834, RefRangeEnd = 311837, XrefRangeStart = 311800, XrefRangeEnd = 311834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDryingOperations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackInterface.NativeMethodInfoPtr_UpdateDryingOperations_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAD4 RID: 47828 RVA: 0x00300E1C File Offset: 0x002FF01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311837, XrefRangeEnd = 311855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateQuantities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackInterface.NativeMethodInfoPtr_UpdateQuantities_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAD5 RID: 47829 RVA: 0x00300E50 File Offset: 0x002FF050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311912, RefRangeEnd = 311913, XrefRangeStart = 311855, XrefRangeEnd = 311912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(DryingRack rack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackInterface.NativeMethodInfoPtr_Open_Public_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAD6 RID: 47830 RVA: 0x00300E94 File Offset: 0x002FF094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311977, RefRangeEnd = 311978, XrefRangeStart = 311913, XrefRangeEnd = 311977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAD7 RID: 47831 RVA: 0x00300EC8 File Offset: 0x002FF0C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312002, RefRangeEnd = 312003, XrefRangeStart = 311978, XrefRangeEnd = 312002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateOperationUI(DryingOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackInterface.NativeMethodInfoPtr_CreateOperationUI_Private_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAD8 RID: 47832 RVA: 0x00300F0C File Offset: 0x002FF10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312003, XrefRangeEnd = 312035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyOperationUI(DryingOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackInterface.NativeMethodInfoPtr_DestroyOperationUI_Private_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAD9 RID: 47833 RVA: 0x00300F50 File Offset: 0x002FF150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312035, XrefRangeEnd = 312038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackInterface.NativeMethodInfoPtr_Insert_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BADA RID: 47834 RVA: 0x00300F84 File Offset: 0x002FF184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312038, XrefRangeEnd = 312048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BADB RID: 47835 RVA: 0x000571D2 File Offset: 0x000553D2
		public DryingRackInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700387D RID: 14461
		// (get) Token: 0x0600BADC RID: 47836 RVA: 0x00300FC0 File Offset: 0x002FF1C0
		// (set) Token: 0x0600BADD RID: 47837 RVA: 0x000571DB File Offset: 0x000553DB
		public unsafe DryingRack _Rack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr__Rack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr__Rack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700387E RID: 14462
		// (get) Token: 0x0600BADE RID: 47838 RVA: 0x00300FF0 File Offset: 0x002FF1F0
		// (set) Token: 0x0600BADF RID: 47839 RVA: 0x000571FA File Offset: 0x000553FA
		public unsafe UIPanel ProgressContainerPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_ProgressContainerPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_ProgressContainerPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700387F RID: 14463
		// (get) Token: 0x0600BAE0 RID: 47840 RVA: 0x00301020 File Offset: 0x002FF220
		// (set) Token: 0x0600BAE1 RID: 47841 RVA: 0x00057219 File Offset: 0x00055419
		public unsafe ItemSlotUI InputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_InputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_InputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003880 RID: 14464
		// (get) Token: 0x0600BAE2 RID: 47842 RVA: 0x00301050 File Offset: 0x002FF250
		// (set) Token: 0x0600BAE3 RID: 47843 RVA: 0x00057238 File Offset: 0x00055438
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003881 RID: 14465
		// (get) Token: 0x0600BAE4 RID: 47844 RVA: 0x00301080 File Offset: 0x002FF280
		// (set) Token: 0x0600BAE5 RID: 47845 RVA: 0x00057257 File Offset: 0x00055457
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003882 RID: 14466
		// (get) Token: 0x0600BAE6 RID: 47846 RVA: 0x003010B0 File Offset: 0x002FF2B0
		// (set) Token: 0x0600BAE7 RID: 47847 RVA: 0x00057276 File Offset: 0x00055476
		public unsafe TextMeshProUGUI CapacityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_CapacityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_CapacityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x0600BAE8 RID: 47848 RVA: 0x003010E0 File Offset: 0x002FF2E0
		// (set) Token: 0x0600BAE9 RID: 47849 RVA: 0x00057295 File Offset: 0x00055495
		public unsafe Button InsertButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_InsertButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_InsertButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x0600BAEA RID: 47850 RVA: 0x00301110 File Offset: 0x002FF310
		// (set) Token: 0x0600BAEB RID: 47851 RVA: 0x000572B4 File Offset: 0x000554B4
		public unsafe RectTransform IndicatorContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_IndicatorContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_IndicatorContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003885 RID: 14469
		// (get) Token: 0x0600BAEC RID: 47852 RVA: 0x00301140 File Offset: 0x002FF340
		// (set) Token: 0x0600BAED RID: 47853 RVA: 0x000572D3 File Offset: 0x000554D3
		public unsafe Il2CppReferenceArray<RectTransform> IndicatorAlignments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_IndicatorAlignments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_IndicatorAlignments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x0600BAEE RID: 47854 RVA: 0x00301170 File Offset: 0x002FF370
		// (set) Token: 0x0600BAEF RID: 47855 RVA: 0x000572F2 File Offset: 0x000554F2
		public unsafe DryingOperationUI IndicatorPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_IndicatorPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingOperationUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_IndicatorPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x0600BAF0 RID: 47856 RVA: 0x003011A0 File Offset: 0x002FF3A0
		// (set) Token: 0x0600BAF1 RID: 47857 RVA: 0x00057311 File Offset: 0x00055511
		public unsafe List<DryingOperationUI> operationUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_operationUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DryingOperationUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.NativeFieldInfoPtr_operationUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400800D RID: 32781
		private static readonly IntPtr NativeFieldInfoPtr__Rack_k__BackingField;

		// Token: 0x0400800E RID: 32782
		private static readonly IntPtr NativeFieldInfoPtr_ProgressContainerPanel;

		// Token: 0x0400800F RID: 32783
		private static readonly IntPtr NativeFieldInfoPtr_InputSlotUI;

		// Token: 0x04008010 RID: 32784
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x04008011 RID: 32785
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x04008012 RID: 32786
		private static readonly IntPtr NativeFieldInfoPtr_CapacityLabel;

		// Token: 0x04008013 RID: 32787
		private static readonly IntPtr NativeFieldInfoPtr_InsertButton;

		// Token: 0x04008014 RID: 32788
		private static readonly IntPtr NativeFieldInfoPtr_IndicatorContainer;

		// Token: 0x04008015 RID: 32789
		private static readonly IntPtr NativeFieldInfoPtr_IndicatorAlignments;

		// Token: 0x04008016 RID: 32790
		private static readonly IntPtr NativeFieldInfoPtr_IndicatorPrefab;

		// Token: 0x04008017 RID: 32791
		private static readonly IntPtr NativeFieldInfoPtr_operationUIs;

		// Token: 0x04008018 RID: 32792
		private static readonly IntPtr NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0;

		// Token: 0x04008019 RID: 32793
		private static readonly IntPtr NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0;

		// Token: 0x0400801A RID: 32794
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400801B RID: 32795
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400801C RID: 32796
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400801D RID: 32797
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x0400801E RID: 32798
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDryingOperations_Private_Void_0;

		// Token: 0x0400801F RID: 32799
		private static readonly IntPtr NativeMethodInfoPtr_UpdateQuantities_Private_Void_0;

		// Token: 0x04008020 RID: 32800
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_DryingRack_0;

		// Token: 0x04008021 RID: 32801
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04008022 RID: 32802
		private static readonly IntPtr NativeMethodInfoPtr_CreateOperationUI_Private_Void_DryingOperation_0;

		// Token: 0x04008023 RID: 32803
		private static readonly IntPtr NativeMethodInfoPtr_DestroyOperationUI_Private_Void_DryingOperation_0;

		// Token: 0x04008024 RID: 32804
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Void_0;

		// Token: 0x04008025 RID: 32805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D0B RID: 3339
		[ObfuscatedName("ScheduleOne.UI.Stations.DryingRackInterface+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F7BA RID: 63418 RVA: 0x003B5CCC File Offset: 0x003B3ECC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<DryingRackInterface.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DryingRackInterface>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackInterface.__c__DisplayClass23_0>.NativeClassPtr);
				DryingRackInterface.__c__DisplayClass23_0.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackInterface.__c__DisplayClass23_0>.NativeClassPtr, "operation");
				DryingRackInterface.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackInterface.__c__DisplayClass23_0>.NativeClassPtr, 100687696);
				DryingRackInterface.__c__DisplayClass23_0.NativeMethodInfoPtr__DestroyOperationUI_b__0_Internal_Boolean_DryingOperationUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackInterface.__c__DisplayClass23_0>.NativeClassPtr, 100687697);
			}

			// Token: 0x0600F7BB RID: 63419 RVA: 0x003B5D34 File Offset: 0x003B3F34
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackInterface.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackInterface.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7BC RID: 63420 RVA: 0x003B5D70 File Offset: 0x003B3F70
			[CallerCount(0)]
			public unsafe bool _DestroyOperationUI_b__0(DryingOperationUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackInterface.__c__DisplayClass23_0.NativeMethodInfoPtr__DestroyOperationUI_b__0_Internal_Boolean_DryingOperationUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F7BD RID: 63421 RVA: 0x00075241 File Offset: 0x00073441
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B53 RID: 19283
			// (get) Token: 0x0600F7BE RID: 63422 RVA: 0x003B5DC0 File Offset: 0x003B3FC0
			// (set) Token: 0x0600F7BF RID: 63423 RVA: 0x0007524A File Offset: 0x0007344A
			public unsafe DryingOperation operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.__c__DisplayClass23_0.NativeFieldInfoPtr_operation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackInterface.__c__DisplayClass23_0.NativeFieldInfoPtr_operation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A77E RID: 42878
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x0400A77F RID: 42879
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A780 RID: 42880
			private static readonly IntPtr NativeMethodInfoPtr__DestroyOperationUI_b__0_Internal_Boolean_DryingOperationUI_0;
		}
	}
}
