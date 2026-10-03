using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x0200077A RID: 1914
	public class BrickPressCanvas : StationInterface<BrickPressCanvas>
	{
		// Token: 0x0600BA33 RID: 47667 RVA: 0x002FECA4 File Offset: 0x002FCEA4
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressCanvas()
		{
			Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "BrickPressCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr);
			BrickPressCanvas.NativeFieldInfoPtr__Press_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "<Press>k__BackingField");
			BrickPressCanvas.NativeFieldInfoPtr_ProductSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "ProductSlotUIs");
			BrickPressCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "OutputSlotUI");
			BrickPressCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "InstructionLabel");
			BrickPressCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "BeginButton");
			BrickPressCanvas.NativeMethodInfoPtr_get_Press_Public_get_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100687611);
			BrickPressCanvas.NativeMethodInfoPtr_set_Press_Protected_set_Void_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100687612);
			BrickPressCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100687613);
			BrickPressCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100687614);
			BrickPressCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100687615);
			BrickPressCanvas.NativeMethodInfoPtr_Open_Public_Void_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100687616);
			BrickPressCanvas.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100687617);
			BrickPressCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100687618);
			BrickPressCanvas.NativeMethodInfoPtr_BeginTask_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100687619);
			BrickPressCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, 100687620);
		}

		// Token: 0x1700384F RID: 14415
		// (get) Token: 0x0600BA34 RID: 47668 RVA: 0x002FEE00 File Offset: 0x002FD000
		// (set) Token: 0x0600BA35 RID: 47669 RVA: 0x002FEE40 File Offset: 0x002FD040
		public unsafe BrickPress Press
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_get_Press_Public_get_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_set_Press_Protected_set_Void_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BA36 RID: 47670 RVA: 0x002FEE84 File Offset: 0x002FD084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310940, XrefRangeEnd = 310951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA37 RID: 47671 RVA: 0x002FEEC0 File Offset: 0x002FD0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310951, XrefRangeEnd = 310953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA38 RID: 47672 RVA: 0x002FEEFC File Offset: 0x002FD0FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 310964, RefRangeEnd = 310967, XrefRangeStart = 310953, XrefRangeEnd = 310964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA39 RID: 47673 RVA: 0x002FEF30 File Offset: 0x002FD130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310978, RefRangeEnd = 310979, XrefRangeStart = 310967, XrefRangeEnd = 310978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(BrickPress press)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_Open_Public_Void_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA3A RID: 47674 RVA: 0x002FEF74 File Offset: 0x002FD174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310986, RefRangeEnd = 310987, XrefRangeStart = 310979, XrefRangeEnd = 310986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA3B RID: 47675 RVA: 0x002FEFA8 File Offset: 0x002FD1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310987, XrefRangeEnd = 310991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA3C RID: 47676 RVA: 0x002FEFDC File Offset: 0x002FD1DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311021, RefRangeEnd = 311022, XrefRangeStart = 310991, XrefRangeEnd = 311021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginTask(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr_BeginTask_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA3D RID: 47677 RVA: 0x002FF020 File Offset: 0x002FD220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311022, XrefRangeEnd = 311025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA3E RID: 47678 RVA: 0x00056C7B File Offset: 0x00054E7B
		public BrickPressCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700384A RID: 14410
		// (get) Token: 0x0600BA3F RID: 47679 RVA: 0x002FF05C File Offset: 0x002FD25C
		// (set) Token: 0x0600BA40 RID: 47680 RVA: 0x00056C84 File Offset: 0x00054E84
		public unsafe BrickPress _Press_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr__Press_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr__Press_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700384B RID: 14411
		// (get) Token: 0x0600BA41 RID: 47681 RVA: 0x002FF08C File Offset: 0x002FD28C
		// (set) Token: 0x0600BA42 RID: 47682 RVA: 0x00056CA3 File Offset: 0x00054EA3
		public unsafe Il2CppReferenceArray<ItemSlotUI> ProductSlotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_ProductSlotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_ProductSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700384C RID: 14412
		// (get) Token: 0x0600BA43 RID: 47683 RVA: 0x002FF0BC File Offset: 0x002FD2BC
		// (set) Token: 0x0600BA44 RID: 47684 RVA: 0x00056CC2 File Offset: 0x00054EC2
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700384D RID: 14413
		// (get) Token: 0x0600BA45 RID: 47685 RVA: 0x002FF0EC File Offset: 0x002FD2EC
		// (set) Token: 0x0600BA46 RID: 47686 RVA: 0x00056CE1 File Offset: 0x00054EE1
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700384E RID: 14414
		// (get) Token: 0x0600BA47 RID: 47687 RVA: 0x002FF11C File Offset: 0x002FD31C
		// (set) Token: 0x0600BA48 RID: 47688 RVA: 0x00056D00 File Offset: 0x00054F00
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007FAA RID: 32682
		private static readonly IntPtr NativeFieldInfoPtr__Press_k__BackingField;

		// Token: 0x04007FAB RID: 32683
		private static readonly IntPtr NativeFieldInfoPtr_ProductSlotUIs;

		// Token: 0x04007FAC RID: 32684
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x04007FAD RID: 32685
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x04007FAE RID: 32686
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x04007FAF RID: 32687
		private static readonly IntPtr NativeMethodInfoPtr_get_Press_Public_get_BrickPress_0;

		// Token: 0x04007FB0 RID: 32688
		private static readonly IntPtr NativeMethodInfoPtr_set_Press_Protected_set_Void_BrickPress_0;

		// Token: 0x04007FB1 RID: 32689
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007FB2 RID: 32690
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04007FB3 RID: 32691
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x04007FB4 RID: 32692
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_BrickPress_0;

		// Token: 0x04007FB5 RID: 32693
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007FB6 RID: 32694
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x04007FB7 RID: 32695
		private static readonly IntPtr NativeMethodInfoPtr_BeginTask_Private_Void_ProductItemInstance_0;

		// Token: 0x04007FB8 RID: 32696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D04 RID: 3332
		[ObfuscatedName("ScheduleOne.UI.Stations.BrickPressCanvas+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x0600F788 RID: 63368 RVA: 0x003B5414 File Offset: 0x003B3614
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<BrickPressCanvas.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BrickPressCanvas>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressCanvas.__c__DisplayClass14_0>.NativeClassPtr);
				BrickPressCanvas.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				BrickPressCanvas.__c__DisplayClass14_0.NativeFieldInfoPtr_brickPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressCanvas.__c__DisplayClass14_0>.NativeClassPtr, "brickPress");
				BrickPressCanvas.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas.__c__DisplayClass14_0>.NativeClassPtr, 100687621);
				BrickPressCanvas.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressCanvas.__c__DisplayClass14_0>.NativeClassPtr, 100687622);
			}

			// Token: 0x0600F789 RID: 63369 RVA: 0x003B5490 File Offset: 0x003B3690
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressCanvas.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F78A RID: 63370 RVA: 0x003B54CC File Offset: 0x003B36CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310926, XrefRangeEnd = 310940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressCanvas.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F78B RID: 63371 RVA: 0x000750C7 File Offset: 0x000732C7
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B48 RID: 19272
			// (get) Token: 0x0600F78C RID: 63372 RVA: 0x003B5500 File Offset: 0x003B3700
			// (set) Token: 0x0600F78D RID: 63373 RVA: 0x000750D0 File Offset: 0x000732D0
			public unsafe BrickPressCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrickPressCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B49 RID: 19273
			// (get) Token: 0x0600F78E RID: 63374 RVA: 0x003B5530 File Offset: 0x003B3730
			// (set) Token: 0x0600F78F RID: 63375 RVA: 0x000750EF File Offset: 0x000732EF
			public unsafe BrickPress brickPress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.__c__DisplayClass14_0.NativeFieldInfoPtr_brickPress);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressCanvas.__c__DisplayClass14_0.NativeFieldInfoPtr_brickPress), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A765 RID: 42853
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A766 RID: 42854
			private static readonly IntPtr NativeFieldInfoPtr_brickPress;

			// Token: 0x0400A767 RID: 42855
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A768 RID: 42856
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
