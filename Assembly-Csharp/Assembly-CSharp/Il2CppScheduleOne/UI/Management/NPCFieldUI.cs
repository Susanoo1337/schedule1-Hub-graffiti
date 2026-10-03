using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007D2 RID: 2002
	public class NPCFieldUI : MonoBehaviour
	{
		// Token: 0x0600C38B RID: 50059 RVA: 0x0031B298 File Offset: 0x00319498
		// Note: this type is marked as 'beforefieldinit'.
		static NPCFieldUI()
		{
			Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "NPCFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr);
			NPCFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			NPCFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "FieldLabel");
			NPCFieldUI.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "IconImg");
			NPCFieldUI.NativeFieldInfoPtr_SelectionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "SelectionLabel");
			NPCFieldUI.NativeFieldInfoPtr_NoneSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "NoneSelected");
			NPCFieldUI.NativeFieldInfoPtr_MultipleSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "MultipleSelected");
			NPCFieldUI.NativeFieldInfoPtr_ClearButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "ClearButton");
			NPCFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_NPCField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100688667);
			NPCFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NPCField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100688668);
			NPCFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_NPCField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100688669);
			NPCFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100688670);
			NPCFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100688671);
			NPCFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100688672);
			NPCFieldUI.NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100688673);
			NPCFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100688674);
			NPCFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100688675);
		}

		// Token: 0x17003B5D RID: 15197
		// (get) Token: 0x0600C38C RID: 50060 RVA: 0x0031B408 File Offset: 0x00319608
		// (set) Token: 0x0600C38D RID: 50061 RVA: 0x0031B448 File Offset: 0x00319648
		public unsafe List<NPCField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_NPCField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NPCField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C38E RID: 50062 RVA: 0x0031B48C File Offset: 0x0031968C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323640, XrefRangeEnd = 323667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<NPCField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_NPCField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C38F RID: 50063 RVA: 0x0031B4D0 File Offset: 0x003196D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323716, RefRangeEnd = 323717, XrefRangeStart = 323667, XrefRangeEnd = 323716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(NPC newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C390 RID: 50064 RVA: 0x0031B514 File Offset: 0x00319714
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323728, RefRangeEnd = 323730, XrefRangeStart = 323717, XrefRangeEnd = 323728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C391 RID: 50065 RVA: 0x0031B550 File Offset: 0x00319750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323730, XrefRangeEnd = 323737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C392 RID: 50066 RVA: 0x0031B584 File Offset: 0x00319784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323759, RefRangeEnd = 323760, XrefRangeStart = 323737, XrefRangeEnd = 323759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NPCSelected(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C393 RID: 50067 RVA: 0x0031B5C8 File Offset: 0x003197C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323760, XrefRangeEnd = 323761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C394 RID: 50068 RVA: 0x0031B5FC File Offset: 0x003197FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323761, XrefRangeEnd = 323769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C395 RID: 50069 RVA: 0x0005C269 File Offset: 0x0005A469
		public NPCFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B56 RID: 15190
		// (get) Token: 0x0600C396 RID: 50070 RVA: 0x0031B638 File Offset: 0x00319838
		// (set) Token: 0x0600C397 RID: 50071 RVA: 0x0005C272 File Offset: 0x0005A472
		public unsafe List<NPCField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B57 RID: 15191
		// (get) Token: 0x0600C398 RID: 50072 RVA: 0x0031B668 File Offset: 0x00319868
		// (set) Token: 0x0600C399 RID: 50073 RVA: 0x0005C291 File Offset: 0x0005A491
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B58 RID: 15192
		// (get) Token: 0x0600C39A RID: 50074 RVA: 0x0031B698 File Offset: 0x00319898
		// (set) Token: 0x0600C39B RID: 50075 RVA: 0x0005C2B0 File Offset: 0x0005A4B0
		public unsafe Image IconImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_IconImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B59 RID: 15193
		// (get) Token: 0x0600C39C RID: 50076 RVA: 0x0031B6C8 File Offset: 0x003198C8
		// (set) Token: 0x0600C39D RID: 50077 RVA: 0x0005C2CF File Offset: 0x0005A4CF
		public unsafe TextMeshProUGUI SelectionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_SelectionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_SelectionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B5A RID: 15194
		// (get) Token: 0x0600C39E RID: 50078 RVA: 0x0031B6F8 File Offset: 0x003198F8
		// (set) Token: 0x0600C39F RID: 50079 RVA: 0x0005C2EE File Offset: 0x0005A4EE
		public unsafe GameObject NoneSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_NoneSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_NoneSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B5B RID: 15195
		// (get) Token: 0x0600C3A0 RID: 50080 RVA: 0x0031B728 File Offset: 0x00319928
		// (set) Token: 0x0600C3A1 RID: 50081 RVA: 0x0005C30D File Offset: 0x0005A50D
		public unsafe GameObject MultipleSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_MultipleSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_MultipleSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B5C RID: 15196
		// (get) Token: 0x0600C3A2 RID: 50082 RVA: 0x0031B758 File Offset: 0x00319958
		// (set) Token: 0x0600C3A3 RID: 50083 RVA: 0x0005C32C File Offset: 0x0005A52C
		public unsafe RectTransform ClearButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_ClearButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_ClearButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008584 RID: 34180
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x04008585 RID: 34181
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x04008586 RID: 34182
		private static readonly IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x04008587 RID: 34183
		private static readonly IntPtr NativeFieldInfoPtr_SelectionLabel;

		// Token: 0x04008588 RID: 34184
		private static readonly IntPtr NativeFieldInfoPtr_NoneSelected;

		// Token: 0x04008589 RID: 34185
		private static readonly IntPtr NativeFieldInfoPtr_MultipleSelected;

		// Token: 0x0400858A RID: 34186
		private static readonly IntPtr NativeFieldInfoPtr_ClearButton;

		// Token: 0x0400858B RID: 34187
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_NPCField_0;

		// Token: 0x0400858C RID: 34188
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NPCField_0;

		// Token: 0x0400858D RID: 34189
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_NPCField_0;

		// Token: 0x0400858E RID: 34190
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_NPC_0;

		// Token: 0x0400858F RID: 34191
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x04008590 RID: 34192
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04008591 RID: 34193
		private static readonly IntPtr NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0;

		// Token: 0x04008592 RID: 34194
		private static readonly IntPtr NativeMethodInfoPtr_ClearClicked_Public_Void_0;

		// Token: 0x04008593 RID: 34195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D56 RID: 3414
		[ObfuscatedName("ScheduleOne.UI.Management.NPCFieldUI+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600FA71 RID: 64113 RVA: 0x003BD884 File Offset: 0x003BBA84
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr);
				NPCFieldUI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr, "<>9");
				NPCFieldUI.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr, "<>9__11_0");
				NPCFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr, 100688677);
				NPCFieldUI.__c.NativeMethodInfoPtr__Refresh_b__11_0_Internal_Boolean_NPCField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr, 100688678);
			}

			// Token: 0x0600FA72 RID: 64114 RVA: 0x003BD900 File Offset: 0x003BBB00
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA73 RID: 64115 RVA: 0x003BD93C File Offset: 0x003BBB3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323635, XrefRangeEnd = 323640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Refresh_b__11_0(NPCField x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.__c.NativeMethodInfoPtr__Refresh_b__11_0_Internal_Boolean_NPCField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FA74 RID: 64116 RVA: 0x000767FD File Offset: 0x000749FD
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C21 RID: 19489
			// (get) Token: 0x0600FA75 RID: 64117 RVA: 0x003BD98C File Offset: 0x003BBB8C
			// (set) Token: 0x0600FA76 RID: 64118 RVA: 0x00076806 File Offset: 0x00074A06
			public unsafe static NPCFieldUI.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCFieldUI.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCFieldUI.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCFieldUI.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C22 RID: 19490
			// (get) Token: 0x0600FA77 RID: 64119 RVA: 0x003BD9B4 File Offset: 0x003BBBB4
			// (set) Token: 0x0600FA78 RID: 64120 RVA: 0x00076818 File Offset: 0x00074A18
			public unsafe static Func<NPCField, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCFieldUI.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPCField, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCFieldUI.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A90E RID: 43278
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A90F RID: 43279
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x0400A910 RID: 43280
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A911 RID: 43281
			private static readonly IntPtr NativeMethodInfoPtr__Refresh_b__11_0_Internal_Boolean_NPCField_0;
		}
	}
}
