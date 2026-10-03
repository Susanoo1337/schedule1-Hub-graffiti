using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x0200077B RID: 1915
	public class CauldronInterface : StationInterface<CauldronInterface>
	{
		// Token: 0x0600BA49 RID: 47689 RVA: 0x002FF14C File Offset: 0x002FD34C
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronInterface()
		{
			Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "CauldronInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr);
			CauldronInterface.NativeFieldInfoPtr__Cauldron_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr, "<Cauldron>k__BackingField");
			CauldronInterface.NativeFieldInfoPtr_IngredientSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr, "IngredientSlotUIs");
			CauldronInterface.NativeFieldInfoPtr_LiquidSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr, "LiquidSlotUI");
			CauldronInterface.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr, "OutputSlotUI");
			CauldronInterface.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr, "InstructionLabel");
			CauldronInterface.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr, "BeginButton");
			CauldronInterface.NativeMethodInfoPtr_get_Cauldron_Public_get_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr, 100687623);
			CauldronInterface.NativeMethodInfoPtr_set_Cauldron_Protected_set_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr, 100687624);
			CauldronInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr, 100687625);
			CauldronInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr, 100687626);
			CauldronInterface.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr, 100687627);
			CauldronInterface.NativeMethodInfoPtr_Open_Public_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr, 100687628);
			CauldronInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr, 100687629);
			CauldronInterface.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr, 100687630);
			CauldronInterface.NativeMethodInfoPtr_BeginTask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr, 100687631);
			CauldronInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr, 100687632);
		}

		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x0600BA4A RID: 47690 RVA: 0x002FF2BC File Offset: 0x002FD4BC
		// (set) Token: 0x0600BA4B RID: 47691 RVA: 0x002FF2FC File Offset: 0x002FD4FC
		public unsafe Cauldron Cauldron
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronInterface.NativeMethodInfoPtr_get_Cauldron_Public_get_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronInterface.NativeMethodInfoPtr_set_Cauldron_Protected_set_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BA4C RID: 47692 RVA: 0x002FF340 File Offset: 0x002FD540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311040, XrefRangeEnd = 311051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA4D RID: 47693 RVA: 0x002FF37C File Offset: 0x002FD57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311051, XrefRangeEnd = 311053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA4E RID: 47694 RVA: 0x002FF3B8 File Offset: 0x002FD5B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 311076, RefRangeEnd = 311079, XrefRangeStart = 311053, XrefRangeEnd = 311076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronInterface.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA4F RID: 47695 RVA: 0x002FF3EC File Offset: 0x002FD5EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311091, RefRangeEnd = 311092, XrefRangeStart = 311079, XrefRangeEnd = 311091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(Cauldron cauldron)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cauldron);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronInterface.NativeMethodInfoPtr_Open_Public_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA50 RID: 47696 RVA: 0x002FF430 File Offset: 0x002FD630
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 311110, RefRangeEnd = 311113, XrefRangeStart = 311092, XrefRangeEnd = 311110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA51 RID: 47697 RVA: 0x002FF464 File Offset: 0x002FD664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311136, RefRangeEnd = 311137, XrefRangeStart = 311113, XrefRangeEnd = 311136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronInterface.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA52 RID: 47698 RVA: 0x002FF498 File Offset: 0x002FD698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311137, XrefRangeEnd = 311162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronInterface.NativeMethodInfoPtr_BeginTask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA53 RID: 47699 RVA: 0x002FF4CC File Offset: 0x002FD6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311162, XrefRangeEnd = 311165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA54 RID: 47700 RVA: 0x00056D1F File Offset: 0x00054F1F
		public CauldronInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x0600BA55 RID: 47701 RVA: 0x002FF508 File Offset: 0x002FD708
		// (set) Token: 0x0600BA56 RID: 47702 RVA: 0x00056D28 File Offset: 0x00054F28
		public unsafe Cauldron _Cauldron_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronInterface.NativeFieldInfoPtr__Cauldron_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronInterface.NativeFieldInfoPtr__Cauldron_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x0600BA57 RID: 47703 RVA: 0x002FF538 File Offset: 0x002FD738
		// (set) Token: 0x0600BA58 RID: 47704 RVA: 0x00056D47 File Offset: 0x00054F47
		public unsafe List<ItemSlotUI> IngredientSlotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronInterface.NativeFieldInfoPtr_IngredientSlotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronInterface.NativeFieldInfoPtr_IngredientSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x0600BA59 RID: 47705 RVA: 0x002FF568 File Offset: 0x002FD768
		// (set) Token: 0x0600BA5A RID: 47706 RVA: 0x00056D66 File Offset: 0x00054F66
		public unsafe ItemSlotUI LiquidSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronInterface.NativeFieldInfoPtr_LiquidSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronInterface.NativeFieldInfoPtr_LiquidSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x0600BA5B RID: 47707 RVA: 0x002FF598 File Offset: 0x002FD798
		// (set) Token: 0x0600BA5C RID: 47708 RVA: 0x00056D85 File Offset: 0x00054F85
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronInterface.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronInterface.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003854 RID: 14420
		// (get) Token: 0x0600BA5D RID: 47709 RVA: 0x002FF5C8 File Offset: 0x002FD7C8
		// (set) Token: 0x0600BA5E RID: 47710 RVA: 0x00056DA4 File Offset: 0x00054FA4
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronInterface.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronInterface.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003855 RID: 14421
		// (get) Token: 0x0600BA5F RID: 47711 RVA: 0x002FF5F8 File Offset: 0x002FD7F8
		// (set) Token: 0x0600BA60 RID: 47712 RVA: 0x00056DC3 File Offset: 0x00054FC3
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronInterface.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronInterface.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007FB9 RID: 32697
		private static readonly IntPtr NativeFieldInfoPtr__Cauldron_k__BackingField;

		// Token: 0x04007FBA RID: 32698
		private static readonly IntPtr NativeFieldInfoPtr_IngredientSlotUIs;

		// Token: 0x04007FBB RID: 32699
		private static readonly IntPtr NativeFieldInfoPtr_LiquidSlotUI;

		// Token: 0x04007FBC RID: 32700
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x04007FBD RID: 32701
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x04007FBE RID: 32702
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x04007FBF RID: 32703
		private static readonly IntPtr NativeMethodInfoPtr_get_Cauldron_Public_get_Cauldron_0;

		// Token: 0x04007FC0 RID: 32704
		private static readonly IntPtr NativeMethodInfoPtr_set_Cauldron_Protected_set_Void_Cauldron_0;

		// Token: 0x04007FC1 RID: 32705
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007FC2 RID: 32706
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04007FC3 RID: 32707
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x04007FC4 RID: 32708
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_Cauldron_0;

		// Token: 0x04007FC5 RID: 32709
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007FC6 RID: 32710
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x04007FC7 RID: 32711
		private static readonly IntPtr NativeMethodInfoPtr_BeginTask_Private_Void_0;

		// Token: 0x04007FC8 RID: 32712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D05 RID: 3333
		[ObfuscatedName("ScheduleOne.UI.Stations.CauldronInterface+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x0600F790 RID: 63376 RVA: 0x003B5560 File Offset: 0x003B3760
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<CauldronInterface.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CauldronInterface>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronInterface.__c__DisplayClass15_0>.NativeClassPtr);
				CauldronInterface.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronInterface.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				CauldronInterface.__c__DisplayClass15_0.NativeFieldInfoPtr_cauldron = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronInterface.__c__DisplayClass15_0>.NativeClassPtr, "cauldron");
				CauldronInterface.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronInterface.__c__DisplayClass15_0>.NativeClassPtr, 100687633);
				CauldronInterface.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronInterface.__c__DisplayClass15_0>.NativeClassPtr, 100687634);
			}

			// Token: 0x0600F791 RID: 63377 RVA: 0x003B55DC File Offset: 0x003B37DC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronInterface.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronInterface.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F792 RID: 63378 RVA: 0x003B5618 File Offset: 0x003B3818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311025, XrefRangeEnd = 311040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronInterface.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F793 RID: 63379 RVA: 0x0007510E File Offset: 0x0007330E
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B4A RID: 19274
			// (get) Token: 0x0600F794 RID: 63380 RVA: 0x003B564C File Offset: 0x003B384C
			// (set) Token: 0x0600F795 RID: 63381 RVA: 0x00075117 File Offset: 0x00073317
			public unsafe CauldronInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronInterface.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CauldronInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronInterface.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B4B RID: 19275
			// (get) Token: 0x0600F796 RID: 63382 RVA: 0x003B567C File Offset: 0x003B387C
			// (set) Token: 0x0600F797 RID: 63383 RVA: 0x00075136 File Offset: 0x00073336
			public unsafe Cauldron cauldron
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronInterface.__c__DisplayClass15_0.NativeFieldInfoPtr_cauldron);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronInterface.__c__DisplayClass15_0.NativeFieldInfoPtr_cauldron), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A769 RID: 42857
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A76A RID: 42858
			private static readonly IntPtr NativeFieldInfoPtr_cauldron;

			// Token: 0x0400A76B RID: 42859
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A76C RID: 42860
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
