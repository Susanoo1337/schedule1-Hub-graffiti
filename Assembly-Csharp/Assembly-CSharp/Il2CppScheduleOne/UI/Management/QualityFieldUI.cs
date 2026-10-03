using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007D6 RID: 2006
	public class QualityFieldUI : MonoBehaviour
	{
		// Token: 0x0600C3FC RID: 50172 RVA: 0x0031C8E4 File Offset: 0x0031AAE4
		// Note: this type is marked as 'beforefieldinit'.
		static QualityFieldUI()
		{
			Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "QualityFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr);
			QualityFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			QualityFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, "FieldLabel");
			QualityFieldUI.NativeFieldInfoPtr_QualityButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, "QualityButtons");
			QualityFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_QualityField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100688714);
			QualityFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_QualityField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100688715);
			QualityFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_QualityField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100688716);
			QualityFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100688717);
			QualityFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100688718);
			QualityFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100688719);
			QualityFieldUI.NativeMethodInfoPtr_ChangeTargetQuality_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100688720);
			QualityFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100688721);
		}

		// Token: 0x17003B7E RID: 15230
		// (get) Token: 0x0600C3FD RID: 50173 RVA: 0x0031C9F0 File Offset: 0x0031ABF0
		// (set) Token: 0x0600C3FE RID: 50174 RVA: 0x0031CA30 File Offset: 0x0031AC30
		public unsafe List<QualityField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_QualityField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<QualityField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_QualityField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C3FF RID: 50175 RVA: 0x0031CA74 File Offset: 0x0031AC74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324457, RefRangeEnd = 324458, XrefRangeStart = 324416, XrefRangeEnd = 324457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<QualityField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_QualityField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C400 RID: 50176 RVA: 0x0031CAB8 File Offset: 0x0031ACB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324472, RefRangeEnd = 324473, XrefRangeStart = 324458, XrefRangeEnd = 324472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C401 RID: 50177 RVA: 0x0031CAF8 File Offset: 0x0031ACF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324473, XrefRangeEnd = 324480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C402 RID: 50178 RVA: 0x0031CB34 File Offset: 0x0031AD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324480, XrefRangeEnd = 324486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueChanged(EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C403 RID: 50179 RVA: 0x0031CB74 File Offset: 0x0031AD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324486, XrefRangeEnd = 324492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeTargetQuality(int amt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_ChangeTargetQuality_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C404 RID: 50180 RVA: 0x0031CBB4 File Offset: 0x0031ADB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324492, XrefRangeEnd = 324500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C405 RID: 50181 RVA: 0x0005C68C File Offset: 0x0005A88C
		public QualityFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B7B RID: 15227
		// (get) Token: 0x0600C406 RID: 50182 RVA: 0x0031CBF0 File Offset: 0x0031ADF0
		// (set) Token: 0x0600C407 RID: 50183 RVA: 0x0005C695 File Offset: 0x0005A895
		public unsafe List<QualityField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<QualityField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B7C RID: 15228
		// (get) Token: 0x0600C408 RID: 50184 RVA: 0x0031CC20 File Offset: 0x0031AE20
		// (set) Token: 0x0600C409 RID: 50185 RVA: 0x0005C6B4 File Offset: 0x0005A8B4
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B7D RID: 15229
		// (get) Token: 0x0600C40A RID: 50186 RVA: 0x0031CC50 File Offset: 0x0031AE50
		// (set) Token: 0x0600C40B RID: 50187 RVA: 0x0005C6D3 File Offset: 0x0005A8D3
		public unsafe Il2CppReferenceArray<Button> QualityButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr_QualityButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr_QualityButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040085CC RID: 34252
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x040085CD RID: 34253
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x040085CE RID: 34254
		private static readonly IntPtr NativeFieldInfoPtr_QualityButtons;

		// Token: 0x040085CF RID: 34255
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_QualityField_0;

		// Token: 0x040085D0 RID: 34256
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_QualityField_0;

		// Token: 0x040085D1 RID: 34257
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_QualityField_0;

		// Token: 0x040085D2 RID: 34258
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_EQuality_0;

		// Token: 0x040085D3 RID: 34259
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x040085D4 RID: 34260
		private static readonly IntPtr NativeMethodInfoPtr_ValueChanged_Public_Void_EQuality_0;

		// Token: 0x040085D5 RID: 34261
		private static readonly IntPtr NativeMethodInfoPtr_ChangeTargetQuality_Public_Void_Int32_0;

		// Token: 0x040085D6 RID: 34262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D59 RID: 3417
		[ObfuscatedName("ScheduleOne.UI.Management.QualityFieldUI+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FA89 RID: 64137 RVA: 0x003BDC78 File Offset: 0x003BBE78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr);
				QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr_quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr, "quality");
				QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				QualityFieldUI.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr, 100688722);
				QualityFieldUI.__c__DisplayClass6_0.NativeMethodInfoPtr__Bind_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr, 100688723);
			}

			// Token: 0x0600FA8A RID: 64138 RVA: 0x003BDCF4 File Offset: 0x003BBEF4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA8B RID: 64139 RVA: 0x003BDD30 File Offset: 0x003BBF30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324410, XrefRangeEnd = 324416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Bind_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.__c__DisplayClass6_0.NativeMethodInfoPtr__Bind_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA8C RID: 64140 RVA: 0x0007689A File Offset: 0x00074A9A
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C27 RID: 19495
			// (get) Token: 0x0600FA8D RID: 64141 RVA: 0x003BDD64 File Offset: 0x003BBF64
			// (set) Token: 0x0600FA8E RID: 64142 RVA: 0x000768A3 File Offset: 0x00074AA3
			public unsafe EQuality quality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr_quality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr_quality)) = value;
				}
			}

			// Token: 0x17004C28 RID: 19496
			// (get) Token: 0x0600FA8F RID: 64143 RVA: 0x003BDD8C File Offset: 0x003BBF8C
			// (set) Token: 0x0600FA90 RID: 64144 RVA: 0x000768BE File Offset: 0x00074ABE
			public unsafe QualityFieldUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityFieldUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A91A RID: 43290
			private static readonly IntPtr NativeFieldInfoPtr_quality;

			// Token: 0x0400A91B RID: 43291
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A91C RID: 43292
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A91D RID: 43293
			private static readonly IntPtr NativeMethodInfoPtr__Bind_b__0_Internal_Void_0;
		}
	}
}
