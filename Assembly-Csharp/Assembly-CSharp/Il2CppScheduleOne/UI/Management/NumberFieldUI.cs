using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007D3 RID: 2003
	public class NumberFieldUI : MonoBehaviour
	{
		// Token: 0x0600C3A4 RID: 50084 RVA: 0x0031B788 File Offset: 0x00319988
		// Note: this type is marked as 'beforefieldinit'.
		static NumberFieldUI()
		{
			Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "NumberFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr);
			NumberFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			NumberFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "FieldLabel");
			NumberFieldUI.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "Slider");
			NumberFieldUI.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "ValueLabel");
			NumberFieldUI.NativeFieldInfoPtr_MinValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "MinValueLabel");
			NumberFieldUI.NativeFieldInfoPtr_MaxValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "MaxValueLabel");
			NumberFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_NumberField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100688679);
			NumberFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NumberField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100688680);
			NumberFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_NumberField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100688681);
			NumberFieldUI.NativeMethodInfoPtr_IncrementValue_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100688682);
			NumberFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100688683);
			NumberFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100688684);
			NumberFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100688685);
			NumberFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100688686);
		}

		// Token: 0x17003B64 RID: 15204
		// (get) Token: 0x0600C3A5 RID: 50085 RVA: 0x0031B8D0 File Offset: 0x00319AD0
		// (set) Token: 0x0600C3A6 RID: 50086 RVA: 0x0031B910 File Offset: 0x00319B10
		public unsafe List<NumberField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_NumberField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NumberField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NumberField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C3A7 RID: 50087 RVA: 0x0031B954 File Offset: 0x00319B54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323827, RefRangeEnd = 323829, XrefRangeStart = 323769, XrefRangeEnd = 323827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<NumberField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_NumberField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C3A8 RID: 50088 RVA: 0x0031B998 File Offset: 0x00319B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323829, XrefRangeEnd = 323830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementValue(int amt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_IncrementValue_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C3A9 RID: 50089 RVA: 0x0031B9D8 File Offset: 0x00319BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323830, XrefRangeEnd = 323841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C3AA RID: 50090 RVA: 0x0031BA18 File Offset: 0x00319C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323841, XrefRangeEnd = 323848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C3AB RID: 50091 RVA: 0x0031BA54 File Offset: 0x00319C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323848, XrefRangeEnd = 323854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C3AC RID: 50092 RVA: 0x0031BA94 File Offset: 0x00319C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323854, XrefRangeEnd = 323862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C3AD RID: 50093 RVA: 0x0005C34B File Offset: 0x0005A54B
		public NumberFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B5E RID: 15198
		// (get) Token: 0x0600C3AE RID: 50094 RVA: 0x0031BAD0 File Offset: 0x00319CD0
		// (set) Token: 0x0600C3AF RID: 50095 RVA: 0x0005C354 File Offset: 0x0005A554
		public unsafe List<NumberField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NumberField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B5F RID: 15199
		// (get) Token: 0x0600C3B0 RID: 50096 RVA: 0x0031BB00 File Offset: 0x00319D00
		// (set) Token: 0x0600C3B1 RID: 50097 RVA: 0x0005C373 File Offset: 0x0005A573
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B60 RID: 15200
		// (get) Token: 0x0600C3B2 RID: 50098 RVA: 0x0031BB30 File Offset: 0x00319D30
		// (set) Token: 0x0600C3B3 RID: 50099 RVA: 0x0005C392 File Offset: 0x0005A592
		public unsafe Slider Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B61 RID: 15201
		// (get) Token: 0x0600C3B4 RID: 50100 RVA: 0x0031BB60 File Offset: 0x00319D60
		// (set) Token: 0x0600C3B5 RID: 50101 RVA: 0x0005C3B1 File Offset: 0x0005A5B1
		public unsafe TextMeshProUGUI ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B62 RID: 15202
		// (get) Token: 0x0600C3B6 RID: 50102 RVA: 0x0031BB90 File Offset: 0x00319D90
		// (set) Token: 0x0600C3B7 RID: 50103 RVA: 0x0005C3D0 File Offset: 0x0005A5D0
		public unsafe TextMeshProUGUI MinValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_MinValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_MinValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B63 RID: 15203
		// (get) Token: 0x0600C3B8 RID: 50104 RVA: 0x0031BBC0 File Offset: 0x00319DC0
		// (set) Token: 0x0600C3B9 RID: 50105 RVA: 0x0005C3EF File Offset: 0x0005A5EF
		public unsafe TextMeshProUGUI MaxValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_MaxValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_MaxValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008594 RID: 34196
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x04008595 RID: 34197
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x04008596 RID: 34198
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x04008597 RID: 34199
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x04008598 RID: 34200
		private static readonly IntPtr NativeFieldInfoPtr_MinValueLabel;

		// Token: 0x04008599 RID: 34201
		private static readonly IntPtr NativeFieldInfoPtr_MaxValueLabel;

		// Token: 0x0400859A RID: 34202
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_NumberField_0;

		// Token: 0x0400859B RID: 34203
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NumberField_0;

		// Token: 0x0400859C RID: 34204
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_NumberField_0;

		// Token: 0x0400859D RID: 34205
		private static readonly IntPtr NativeMethodInfoPtr_IncrementValue_Public_Void_Int32_0;

		// Token: 0x0400859E RID: 34206
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_Single_0;

		// Token: 0x0400859F RID: 34207
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x040085A0 RID: 34208
		private static readonly IntPtr NativeMethodInfoPtr_ValueChanged_Public_Void_Single_0;

		// Token: 0x040085A1 RID: 34209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
