using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.UI.Tooltips;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x0200077E RID: 1918
	public class DryingOperationUI : MonoBehaviour
	{
		// Token: 0x0600BAAD RID: 47789 RVA: 0x00300404 File Offset: 0x002FE604
		// Note: this type is marked as 'beforefieldinit'.
		static DryingOperationUI()
		{
			Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "DryingOperationUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr);
			DryingOperationUI.NativeFieldInfoPtr__AssignedOperation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "<AssignedOperation>k__BackingField");
			DryingOperationUI.NativeFieldInfoPtr__Alignment_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "<Alignment>k__BackingField");
			DryingOperationUI.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "Rect");
			DryingOperationUI.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "Icon");
			DryingOperationUI.NativeFieldInfoPtr_QuantityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "QuantityLabel");
			DryingOperationUI.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "Button");
			DryingOperationUI.NativeFieldInfoPtr_Tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "Tooltip");
			DryingOperationUI.NativeFieldInfoPtr__dryMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, "_dryMultiplier");
			DryingOperationUI.NativeMethodInfoPtr_get_AssignedOperation_Public_get_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100687669);
			DryingOperationUI.NativeMethodInfoPtr_set_AssignedOperation_Protected_set_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100687670);
			DryingOperationUI.NativeMethodInfoPtr_get_Alignment_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100687671);
			DryingOperationUI.NativeMethodInfoPtr_set_Alignment_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100687672);
			DryingOperationUI.NativeMethodInfoPtr_SetOperation_Public_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100687673);
			DryingOperationUI.NativeMethodInfoPtr_SetAlignment_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100687674);
			DryingOperationUI.NativeMethodInfoPtr_RefreshQuantity_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100687675);
			DryingOperationUI.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100687676);
			DryingOperationUI.NativeMethodInfoPtr_SetDryRate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100687677);
			DryingOperationUI.NativeMethodInfoPtr_UpdatePosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100687678);
			DryingOperationUI.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100687679);
			DryingOperationUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100687680);
			DryingOperationUI.NativeMethodInfoPtr__Start_b__17_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr, 100687681);
		}

		// Token: 0x1700387B RID: 14459
		// (get) Token: 0x0600BAAE RID: 47790 RVA: 0x003005D8 File Offset: 0x002FE7D8
		// (set) Token: 0x0600BAAF RID: 47791 RVA: 0x00300618 File Offset: 0x002FE818
		public unsafe DryingOperation AssignedOperation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_get_AssignedOperation_Public_get_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DryingOperation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_set_AssignedOperation_Protected_set_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700387C RID: 14460
		// (get) Token: 0x0600BAB0 RID: 47792 RVA: 0x0030065C File Offset: 0x002FE85C
		// (set) Token: 0x0600BAB1 RID: 47793 RVA: 0x0030069C File Offset: 0x002FE89C
		public unsafe RectTransform Alignment
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_get_Alignment_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_set_Alignment_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BAB2 RID: 47794 RVA: 0x003006E0 File Offset: 0x002FE8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311712, XrefRangeEnd = 311718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOperation(DryingOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_SetOperation_Public_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAB3 RID: 47795 RVA: 0x00300724 File Offset: 0x002FE924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311723, RefRangeEnd = 311724, XrefRangeStart = 311718, XrefRangeEnd = 311723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlignment(RectTransform alignment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_SetAlignment_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAB4 RID: 47796 RVA: 0x00300768 File Offset: 0x002FE968
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311729, RefRangeEnd = 311731, XrefRangeStart = 311724, XrefRangeEnd = 311729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshQuantity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_RefreshQuantity_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAB5 RID: 47797 RVA: 0x0030079C File Offset: 0x002FE99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311731, XrefRangeEnd = 311739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAB6 RID: 47798 RVA: 0x003007D0 File Offset: 0x002FE9D0
		[CallerCount(0)]
		public unsafe void SetDryRate(float dryMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dryMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_SetDryRate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAB7 RID: 47799 RVA: 0x00300810 File Offset: 0x002FEA10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 311751, RefRangeEnd = 311754, XrefRangeStart = 311739, XrefRangeEnd = 311751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_UpdatePosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAB8 RID: 47800 RVA: 0x00300844 File Offset: 0x002FEA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311754, XrefRangeEnd = 311767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BAB9 RID: 47801 RVA: 0x00300878 File Offset: 0x002FEA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311767, XrefRangeEnd = 311768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingOperationUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingOperationUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BABA RID: 47802 RVA: 0x003008B4 File Offset: 0x002FEAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__17_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperationUI.NativeMethodInfoPtr__Start_b__17_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BABB RID: 47803 RVA: 0x000570D5 File Offset: 0x000552D5
		public DryingOperationUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003873 RID: 14451
		// (get) Token: 0x0600BABC RID: 47804 RVA: 0x003008E8 File Offset: 0x002FEAE8
		// (set) Token: 0x0600BABD RID: 47805 RVA: 0x000570DE File Offset: 0x000552DE
		public unsafe DryingOperation _AssignedOperation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__AssignedOperation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__AssignedOperation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003874 RID: 14452
		// (get) Token: 0x0600BABE RID: 47806 RVA: 0x00300918 File Offset: 0x002FEB18
		// (set) Token: 0x0600BABF RID: 47807 RVA: 0x000570FD File Offset: 0x000552FD
		public unsafe RectTransform _Alignment_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__Alignment_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__Alignment_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003875 RID: 14453
		// (get) Token: 0x0600BAC0 RID: 47808 RVA: 0x00300948 File Offset: 0x002FEB48
		// (set) Token: 0x0600BAC1 RID: 47809 RVA: 0x0005711C File Offset: 0x0005531C
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003876 RID: 14454
		// (get) Token: 0x0600BAC2 RID: 47810 RVA: 0x00300978 File Offset: 0x002FEB78
		// (set) Token: 0x0600BAC3 RID: 47811 RVA: 0x0005713B File Offset: 0x0005533B
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003877 RID: 14455
		// (get) Token: 0x0600BAC4 RID: 47812 RVA: 0x003009A8 File Offset: 0x002FEBA8
		// (set) Token: 0x0600BAC5 RID: 47813 RVA: 0x0005715A File Offset: 0x0005535A
		public unsafe TextMeshProUGUI QuantityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_QuantityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_QuantityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003878 RID: 14456
		// (get) Token: 0x0600BAC6 RID: 47814 RVA: 0x003009D8 File Offset: 0x002FEBD8
		// (set) Token: 0x0600BAC7 RID: 47815 RVA: 0x00057179 File Offset: 0x00055379
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003879 RID: 14457
		// (get) Token: 0x0600BAC8 RID: 47816 RVA: 0x00300A08 File Offset: 0x002FEC08
		// (set) Token: 0x0600BAC9 RID: 47817 RVA: 0x00057198 File Offset: 0x00055398
		public unsafe Tooltip Tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Tooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr_Tooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700387A RID: 14458
		// (get) Token: 0x0600BACA RID: 47818 RVA: 0x00300A38 File Offset: 0x002FEC38
		// (set) Token: 0x0600BACB RID: 47819 RVA: 0x000571B7 File Offset: 0x000553B7
		public unsafe float _dryMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__dryMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperationUI.NativeFieldInfoPtr__dryMultiplier)) = value;
			}
		}

		// Token: 0x04007FF8 RID: 32760
		private static readonly IntPtr NativeFieldInfoPtr__AssignedOperation_k__BackingField;

		// Token: 0x04007FF9 RID: 32761
		private static readonly IntPtr NativeFieldInfoPtr__Alignment_k__BackingField;

		// Token: 0x04007FFA RID: 32762
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04007FFB RID: 32763
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04007FFC RID: 32764
		private static readonly IntPtr NativeFieldInfoPtr_QuantityLabel;

		// Token: 0x04007FFD RID: 32765
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04007FFE RID: 32766
		private static readonly IntPtr NativeFieldInfoPtr_Tooltip;

		// Token: 0x04007FFF RID: 32767
		private static readonly IntPtr NativeFieldInfoPtr__dryMultiplier;

		// Token: 0x04008000 RID: 32768
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedOperation_Public_get_DryingOperation_0;

		// Token: 0x04008001 RID: 32769
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedOperation_Protected_set_Void_DryingOperation_0;

		// Token: 0x04008002 RID: 32770
		private static readonly IntPtr NativeMethodInfoPtr_get_Alignment_Public_get_RectTransform_0;

		// Token: 0x04008003 RID: 32771
		private static readonly IntPtr NativeMethodInfoPtr_set_Alignment_Private_set_Void_RectTransform_0;

		// Token: 0x04008004 RID: 32772
		private static readonly IntPtr NativeMethodInfoPtr_SetOperation_Public_Void_DryingOperation_0;

		// Token: 0x04008005 RID: 32773
		private static readonly IntPtr NativeMethodInfoPtr_SetAlignment_Public_Void_RectTransform_0;

		// Token: 0x04008006 RID: 32774
		private static readonly IntPtr NativeMethodInfoPtr_RefreshQuantity_Public_Void_0;

		// Token: 0x04008007 RID: 32775
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04008008 RID: 32776
		private static readonly IntPtr NativeMethodInfoPtr_SetDryRate_Public_Void_Single_0;

		// Token: 0x04008009 RID: 32777
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Void_0;

		// Token: 0x0400800A RID: 32778
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x0400800B RID: 32779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400800C RID: 32780
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__17_0_Private_Void_0;
	}
}
