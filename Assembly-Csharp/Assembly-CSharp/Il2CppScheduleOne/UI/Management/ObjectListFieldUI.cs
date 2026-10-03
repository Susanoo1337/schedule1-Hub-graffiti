using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007D5 RID: 2005
	public class ObjectListFieldUI : MonoBehaviour
	{
		// Token: 0x0600C3D9 RID: 50137 RVA: 0x0031C22C File Offset: 0x0031A42C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectListFieldUI()
		{
			Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ObjectListFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr);
			ObjectListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			ObjectListFieldUI.NativeFieldInfoPtr_FieldText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "FieldText");
			ObjectListFieldUI.NativeFieldInfoPtr_InstructionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "InstructionText");
			ObjectListFieldUI.NativeFieldInfoPtr_ExtendedInstructionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "ExtendedInstructionText");
			ObjectListFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "FieldLabel");
			ObjectListFieldUI.NativeFieldInfoPtr_NoneSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "NoneSelected");
			ObjectListFieldUI.NativeFieldInfoPtr_MultipleSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "MultipleSelected");
			ObjectListFieldUI.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "Entries");
			ObjectListFieldUI.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "Button");
			ObjectListFieldUI.NativeFieldInfoPtr_EditIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "EditIcon");
			ObjectListFieldUI.NativeFieldInfoPtr_NoMultiEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "NoMultiEdit");
			ObjectListFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100688701);
			ObjectListFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100688702);
			ObjectListFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100688703);
			ObjectListFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100688704);
			ObjectListFieldUI.NativeMethodInfoPtr_RemoveEntryClicked_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100688705);
			ObjectListFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100688706);
			ObjectListFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100688707);
			ObjectListFieldUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100688708);
			ObjectListFieldUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100688709);
			ObjectListFieldUI.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100688710);
			ObjectListFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100688711);
		}

		// Token: 0x17003B7A RID: 15226
		// (get) Token: 0x0600C3DA RID: 50138 RVA: 0x0031C414 File Offset: 0x0031A614
		// (set) Token: 0x0600C3DB RID: 50139 RVA: 0x0031C454 File Offset: 0x0031A654
		public unsafe List<ObjectListField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ObjectListField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C3DC RID: 50140 RVA: 0x0031C498 File Offset: 0x0031A698
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 324161, RefRangeEnd = 324165, XrefRangeStart = 324100, XrefRangeEnd = 324161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<ObjectListField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C3DD RID: 50141 RVA: 0x0031C4DC File Offset: 0x0031A6DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324255, RefRangeEnd = 324256, XrefRangeStart = 324165, XrefRangeEnd = 324255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(List<BuildableItem> newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C3DE RID: 50142 RVA: 0x0031C520 File Offset: 0x0031A720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324256, XrefRangeEnd = 324271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEntryClicked(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_RemoveEntryClicked_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C3DF RID: 50143 RVA: 0x0031C560 File Offset: 0x0031A760
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 324281, RefRangeEnd = 324285, XrefRangeStart = 324271, XrefRangeEnd = 324281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C3E0 RID: 50144 RVA: 0x0031C59C File Offset: 0x0031A79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324285, XrefRangeEnd = 324333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C3E1 RID: 50145 RVA: 0x0031C5D0 File Offset: 0x0031A7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324333, XrefRangeEnd = 324344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ObjectValid(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600C3E2 RID: 50146 RVA: 0x0031C638 File Offset: 0x0031A838
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 324368, RefRangeEnd = 324370, XrefRangeStart = 324344, XrefRangeEnd = 324368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectsSelected(List<BuildableItem> objs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C3E3 RID: 50147 RVA: 0x0031C67C File Offset: 0x0031A87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324370, XrefRangeEnd = 324391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C3E4 RID: 50148 RVA: 0x0031C6B0 File Offset: 0x0031A8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324391, XrefRangeEnd = 324410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectListFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C3E5 RID: 50149 RVA: 0x0005C52E File Offset: 0x0005A72E
		public ObjectListFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B6F RID: 15215
		// (get) Token: 0x0600C3E6 RID: 50150 RVA: 0x0031C6EC File Offset: 0x0031A8EC
		// (set) Token: 0x0600C3E7 RID: 50151 RVA: 0x0005C537 File Offset: 0x0005A737
		public unsafe List<ObjectListField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ObjectListField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B70 RID: 15216
		// (get) Token: 0x0600C3E8 RID: 50152 RVA: 0x0031C71C File Offset: 0x0031A91C
		// (set) Token: 0x0600C3E9 RID: 50153 RVA: 0x0005C556 File Offset: 0x0005A756
		public unsafe string FieldText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_FieldText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_FieldText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003B71 RID: 15217
		// (get) Token: 0x0600C3EA RID: 50154 RVA: 0x0031C744 File Offset: 0x0031A944
		// (set) Token: 0x0600C3EB RID: 50155 RVA: 0x0005C575 File Offset: 0x0005A775
		public unsafe string InstructionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_InstructionText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_InstructionText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003B72 RID: 15218
		// (get) Token: 0x0600C3EC RID: 50156 RVA: 0x0031C76C File Offset: 0x0031A96C
		// (set) Token: 0x0600C3ED RID: 50157 RVA: 0x0005C594 File Offset: 0x0005A794
		public unsafe string ExtendedInstructionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_ExtendedInstructionText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_ExtendedInstructionText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003B73 RID: 15219
		// (get) Token: 0x0600C3EE RID: 50158 RVA: 0x0031C794 File Offset: 0x0031A994
		// (set) Token: 0x0600C3EF RID: 50159 RVA: 0x0005C5B3 File Offset: 0x0005A7B3
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B74 RID: 15220
		// (get) Token: 0x0600C3F0 RID: 50160 RVA: 0x0031C7C4 File Offset: 0x0031A9C4
		// (set) Token: 0x0600C3F1 RID: 50161 RVA: 0x0005C5D2 File Offset: 0x0005A7D2
		public unsafe GameObject NoneSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_NoneSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_NoneSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B75 RID: 15221
		// (get) Token: 0x0600C3F2 RID: 50162 RVA: 0x0031C7F4 File Offset: 0x0031A9F4
		// (set) Token: 0x0600C3F3 RID: 50163 RVA: 0x0005C5F1 File Offset: 0x0005A7F1
		public unsafe GameObject MultipleSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_MultipleSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_MultipleSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B76 RID: 15222
		// (get) Token: 0x0600C3F4 RID: 50164 RVA: 0x0031C824 File Offset: 0x0031AA24
		// (set) Token: 0x0600C3F5 RID: 50165 RVA: 0x0005C610 File Offset: 0x0005A810
		public unsafe Il2CppReferenceArray<RectTransform> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B77 RID: 15223
		// (get) Token: 0x0600C3F6 RID: 50166 RVA: 0x0031C854 File Offset: 0x0031AA54
		// (set) Token: 0x0600C3F7 RID: 50167 RVA: 0x0005C62F File Offset: 0x0005A82F
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B78 RID: 15224
		// (get) Token: 0x0600C3F8 RID: 50168 RVA: 0x0031C884 File Offset: 0x0031AA84
		// (set) Token: 0x0600C3F9 RID: 50169 RVA: 0x0005C64E File Offset: 0x0005A84E
		public unsafe GameObject EditIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_EditIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_EditIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B79 RID: 15225
		// (get) Token: 0x0600C3FA RID: 50170 RVA: 0x0031C8B4 File Offset: 0x0031AAB4
		// (set) Token: 0x0600C3FB RID: 50171 RVA: 0x0005C66D File Offset: 0x0005A86D
		public unsafe GameObject NoMultiEdit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_NoMultiEdit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_NoMultiEdit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040085B6 RID: 34230
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x040085B7 RID: 34231
		private static readonly IntPtr NativeFieldInfoPtr_FieldText;

		// Token: 0x040085B8 RID: 34232
		private static readonly IntPtr NativeFieldInfoPtr_InstructionText;

		// Token: 0x040085B9 RID: 34233
		private static readonly IntPtr NativeFieldInfoPtr_ExtendedInstructionText;

		// Token: 0x040085BA RID: 34234
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x040085BB RID: 34235
		private static readonly IntPtr NativeFieldInfoPtr_NoneSelected;

		// Token: 0x040085BC RID: 34236
		private static readonly IntPtr NativeFieldInfoPtr_MultipleSelected;

		// Token: 0x040085BD RID: 34237
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x040085BE RID: 34238
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040085BF RID: 34239
		private static readonly IntPtr NativeFieldInfoPtr_EditIcon;

		// Token: 0x040085C0 RID: 34240
		private static readonly IntPtr NativeFieldInfoPtr_NoMultiEdit;

		// Token: 0x040085C1 RID: 34241
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectListField_0;

		// Token: 0x040085C2 RID: 34242
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectListField_0;

		// Token: 0x040085C3 RID: 34243
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectListField_0;

		// Token: 0x040085C4 RID: 34244
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_List_1_BuildableItem_0;

		// Token: 0x040085C5 RID: 34245
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEntryClicked_Private_Void_Int32_0;

		// Token: 0x040085C6 RID: 34246
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x040085C7 RID: 34247
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x040085C8 RID: 34248
		private static readonly IntPtr NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0;

		// Token: 0x040085C9 RID: 34249
		private static readonly IntPtr NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0;

		// Token: 0x040085CA RID: 34250
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040085CB RID: 34251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D58 RID: 3416
		[ObfuscatedName("ScheduleOne.UI.Management.ObjectListFieldUI+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FA81 RID: 64129 RVA: 0x003BDB34 File Offset: 0x003BBD34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<ObjectListFieldUI.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectListFieldUI.__c__DisplayClass14_0>.NativeClassPtr);
				ObjectListFieldUI.__c__DisplayClass14_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI.__c__DisplayClass14_0>.NativeClassPtr, "index");
				ObjectListFieldUI.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				ObjectListFieldUI.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI.__c__DisplayClass14_0>.NativeClassPtr, 100688712);
				ObjectListFieldUI.__c__DisplayClass14_0.NativeMethodInfoPtr__Bind_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI.__c__DisplayClass14_0>.NativeClassPtr, 100688713);
			}

			// Token: 0x0600FA82 RID: 64130 RVA: 0x003BDBB0 File Offset: 0x003BBDB0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectListFieldUI.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA83 RID: 64131 RVA: 0x003BDBEC File Offset: 0x003BBDEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324085, XrefRangeEnd = 324100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Bind_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.__c__DisplayClass14_0.NativeMethodInfoPtr__Bind_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA84 RID: 64132 RVA: 0x00076857 File Offset: 0x00074A57
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C25 RID: 19493
			// (get) Token: 0x0600FA85 RID: 64133 RVA: 0x003BDC20 File Offset: 0x003BBE20
			// (set) Token: 0x0600FA86 RID: 64134 RVA: 0x00076860 File Offset: 0x00074A60
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.__c__DisplayClass14_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.__c__DisplayClass14_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17004C26 RID: 19494
			// (get) Token: 0x0600FA87 RID: 64135 RVA: 0x003BDC48 File Offset: 0x003BBE48
			// (set) Token: 0x0600FA88 RID: 64136 RVA: 0x0007687B File Offset: 0x00074A7B
			public unsafe ObjectListFieldUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A916 RID: 43286
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x0400A917 RID: 43287
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A918 RID: 43288
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A919 RID: 43289
			private static readonly IntPtr NativeMethodInfoPtr__Bind_b__0_Internal_Void_0;
		}
	}
}
