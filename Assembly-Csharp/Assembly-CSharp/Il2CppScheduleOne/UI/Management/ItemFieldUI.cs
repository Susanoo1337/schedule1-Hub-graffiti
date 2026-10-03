using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007D1 RID: 2001
	public class ItemFieldUI : MonoBehaviour
	{
		// Token: 0x0600C373 RID: 50035 RVA: 0x0031ADF8 File Offset: 0x00318FF8
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFieldUI()
		{
			Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ItemFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr);
			ItemFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			ItemFieldUI.NativeFieldInfoPtr_ShowNoneAsAny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "ShowNoneAsAny");
			ItemFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "FieldLabel");
			ItemFieldUI.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "IconImg");
			ItemFieldUI.NativeFieldInfoPtr_SelectionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "SelectionLabel");
			ItemFieldUI.NativeFieldInfoPtr_NoneSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "NoneSelected");
			ItemFieldUI.NativeFieldInfoPtr_MultipleSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "MultipleSelected");
			ItemFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ItemField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100688659);
			ItemFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ItemField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100688660);
			ItemFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ItemField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100688661);
			ItemFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100688662);
			ItemFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100688663);
			ItemFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100688664);
			ItemFieldUI.NativeMethodInfoPtr_OptionSelected_Private_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100688665);
			ItemFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100688666);
		}

		// Token: 0x17003B55 RID: 15189
		// (get) Token: 0x0600C374 RID: 50036 RVA: 0x0031AF54 File Offset: 0x00319154
		// (set) Token: 0x0600C375 RID: 50037 RVA: 0x0031AF94 File Offset: 0x00319194
		public unsafe List<ItemField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ItemField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ItemField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C376 RID: 50038 RVA: 0x0031AFD8 File Offset: 0x003191D8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 323495, RefRangeEnd = 323503, XrefRangeStart = 323468, XrefRangeEnd = 323495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<ItemField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ItemField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C377 RID: 50039 RVA: 0x0031B01C File Offset: 0x0031921C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323526, RefRangeEnd = 323527, XrefRangeStart = 323503, XrefRangeEnd = 323526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(ItemDefinition newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C378 RID: 50040 RVA: 0x0031B060 File Offset: 0x00319260
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323538, RefRangeEnd = 323540, XrefRangeStart = 323527, XrefRangeEnd = 323538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C379 RID: 50041 RVA: 0x0031B09C File Offset: 0x0031929C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323540, XrefRangeEnd = 323612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C37A RID: 50042 RVA: 0x0031B0D0 File Offset: 0x003192D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323612, XrefRangeEnd = 323627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionSelected(ItemSelector.Option option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_OptionSelected_Private_Void_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C37B RID: 50043 RVA: 0x0031B114 File Offset: 0x00319314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323627, XrefRangeEnd = 323635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C37C RID: 50044 RVA: 0x0005C18B File Offset: 0x0005A38B
		public ItemFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B4E RID: 15182
		// (get) Token: 0x0600C37D RID: 50045 RVA: 0x0031B150 File Offset: 0x00319350
		// (set) Token: 0x0600C37E RID: 50046 RVA: 0x0005C194 File Offset: 0x0005A394
		public unsafe List<ItemField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B4F RID: 15183
		// (get) Token: 0x0600C37F RID: 50047 RVA: 0x0031B180 File Offset: 0x00319380
		// (set) Token: 0x0600C380 RID: 50048 RVA: 0x0005C1B3 File Offset: 0x0005A3B3
		public unsafe bool ShowNoneAsAny
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_ShowNoneAsAny);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_ShowNoneAsAny)) = value;
			}
		}

		// Token: 0x17003B50 RID: 15184
		// (get) Token: 0x0600C381 RID: 50049 RVA: 0x0031B1A8 File Offset: 0x003193A8
		// (set) Token: 0x0600C382 RID: 50050 RVA: 0x0005C1CE File Offset: 0x0005A3CE
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B51 RID: 15185
		// (get) Token: 0x0600C383 RID: 50051 RVA: 0x0031B1D8 File Offset: 0x003193D8
		// (set) Token: 0x0600C384 RID: 50052 RVA: 0x0005C1ED File Offset: 0x0005A3ED
		public unsafe Image IconImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_IconImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B52 RID: 15186
		// (get) Token: 0x0600C385 RID: 50053 RVA: 0x0031B208 File Offset: 0x00319408
		// (set) Token: 0x0600C386 RID: 50054 RVA: 0x0005C20C File Offset: 0x0005A40C
		public unsafe TextMeshProUGUI SelectionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_SelectionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_SelectionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B53 RID: 15187
		// (get) Token: 0x0600C387 RID: 50055 RVA: 0x0031B238 File Offset: 0x00319438
		// (set) Token: 0x0600C388 RID: 50056 RVA: 0x0005C22B File Offset: 0x0005A42B
		public unsafe GameObject NoneSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_NoneSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_NoneSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B54 RID: 15188
		// (get) Token: 0x0600C389 RID: 50057 RVA: 0x0031B268 File Offset: 0x00319468
		// (set) Token: 0x0600C38A RID: 50058 RVA: 0x0005C24A File Offset: 0x0005A44A
		public unsafe GameObject MultipleSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_MultipleSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_MultipleSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008575 RID: 34165
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x04008576 RID: 34166
		private static readonly IntPtr NativeFieldInfoPtr_ShowNoneAsAny;

		// Token: 0x04008577 RID: 34167
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x04008578 RID: 34168
		private static readonly IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x04008579 RID: 34169
		private static readonly IntPtr NativeFieldInfoPtr_SelectionLabel;

		// Token: 0x0400857A RID: 34170
		private static readonly IntPtr NativeFieldInfoPtr_NoneSelected;

		// Token: 0x0400857B RID: 34171
		private static readonly IntPtr NativeFieldInfoPtr_MultipleSelected;

		// Token: 0x0400857C RID: 34172
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_ItemField_0;

		// Token: 0x0400857D RID: 34173
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ItemField_0;

		// Token: 0x0400857E RID: 34174
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_ItemField_0;

		// Token: 0x0400857F RID: 34175
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_ItemDefinition_0;

		// Token: 0x04008580 RID: 34176
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x04008581 RID: 34177
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04008582 RID: 34178
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Private_Void_Option_0;

		// Token: 0x04008583 RID: 34179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
