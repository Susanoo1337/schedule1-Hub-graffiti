using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007D8 RID: 2008
	public class RouteListFieldUI : MonoBehaviour
	{
		// Token: 0x0600C42C RID: 50220 RVA: 0x0031D2DC File Offset: 0x0031B4DC
		// Note: this type is marked as 'beforefieldinit'.
		static RouteListFieldUI()
		{
			Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "RouteListFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr);
			RouteListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			RouteListFieldUI.NativeFieldInfoPtr_FieldText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "FieldText");
			RouteListFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "FieldLabel");
			RouteListFieldUI.NativeFieldInfoPtr_RouteEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "RouteEntries");
			RouteListFieldUI.NativeFieldInfoPtr_MultiEditBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "MultiEditBlocker");
			RouteListFieldUI.NativeFieldInfoPtr_AddButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "AddButton");
			RouteListFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_RouteListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100688736);
			RouteListFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_RouteListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100688737);
			RouteListFieldUI.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100688738);
			RouteListFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_RouteListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100688739);
			RouteListFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_List_1_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100688740);
			RouteListFieldUI.NativeMethodInfoPtr_EntryDeleteClicked_Private_Void_RouteEntryUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100688741);
			RouteListFieldUI.NativeMethodInfoPtr_AddClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100688742);
			RouteListFieldUI.NativeMethodInfoPtr_RouteChanged_Private_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100688743);
			RouteListFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100688744);
		}

		// Token: 0x17003B8F RID: 15247
		// (get) Token: 0x0600C42D RID: 50221 RVA: 0x0031D438 File Offset: 0x0031B638
		// (set) Token: 0x0600C42E RID: 50222 RVA: 0x0031D478 File Offset: 0x0031B678
		public unsafe List<RouteListField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_RouteListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<RouteListField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_RouteListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C42F RID: 50223 RVA: 0x0031D4BC File Offset: 0x0031B6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324692, XrefRangeEnd = 324714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C430 RID: 50224 RVA: 0x0031D4F0 File Offset: 0x0031B6F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324743, RefRangeEnd = 324744, XrefRangeStart = 324714, XrefRangeEnd = 324743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<RouteListField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_RouteListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C431 RID: 50225 RVA: 0x0031D534 File Offset: 0x0031B734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324826, RefRangeEnd = 324827, XrefRangeStart = 324744, XrefRangeEnd = 324826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(List<AdvancedTransitRoute> newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_List_1_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C432 RID: 50226 RVA: 0x0031D578 File Offset: 0x0031B778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324827, XrefRangeEnd = 324833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryDeleteClicked(RouteEntryUI entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_EntryDeleteClicked_Private_Void_RouteEntryUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C433 RID: 50227 RVA: 0x0031D5BC File Offset: 0x0031B7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324833, XrefRangeEnd = 324842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_AddClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C434 RID: 50228 RVA: 0x0031D5F0 File Offset: 0x0031B7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324842, XrefRangeEnd = 324847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RouteChanged(ITransitEntity newEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEntity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_RouteChanged_Private_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C435 RID: 50229 RVA: 0x0031D634 File Offset: 0x0031B834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324847, XrefRangeEnd = 324859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteListFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C436 RID: 50230 RVA: 0x0005C80A File Offset: 0x0005AA0A
		public RouteListFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B89 RID: 15241
		// (get) Token: 0x0600C437 RID: 50231 RVA: 0x0031D670 File Offset: 0x0031B870
		// (set) Token: 0x0600C438 RID: 50232 RVA: 0x0005C813 File Offset: 0x0005AA13
		public unsafe List<RouteListField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RouteListField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B8A RID: 15242
		// (get) Token: 0x0600C439 RID: 50233 RVA: 0x0031D6A0 File Offset: 0x0031B8A0
		// (set) Token: 0x0600C43A RID: 50234 RVA: 0x0005C832 File Offset: 0x0005AA32
		public unsafe string FieldText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_FieldText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_FieldText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003B8B RID: 15243
		// (get) Token: 0x0600C43B RID: 50235 RVA: 0x0031D6C8 File Offset: 0x0031B8C8
		// (set) Token: 0x0600C43C RID: 50236 RVA: 0x0005C851 File Offset: 0x0005AA51
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B8C RID: 15244
		// (get) Token: 0x0600C43D RID: 50237 RVA: 0x0031D6F8 File Offset: 0x0031B8F8
		// (set) Token: 0x0600C43E RID: 50238 RVA: 0x0005C870 File Offset: 0x0005AA70
		public unsafe Il2CppReferenceArray<RouteEntryUI> RouteEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_RouteEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RouteEntryUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_RouteEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B8D RID: 15245
		// (get) Token: 0x0600C43F RID: 50239 RVA: 0x0031D728 File Offset: 0x0031B928
		// (set) Token: 0x0600C440 RID: 50240 RVA: 0x0005C88F File Offset: 0x0005AA8F
		public unsafe RectTransform MultiEditBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_MultiEditBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_MultiEditBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B8E RID: 15246
		// (get) Token: 0x0600C441 RID: 50241 RVA: 0x0031D758 File Offset: 0x0031B958
		// (set) Token: 0x0600C442 RID: 50242 RVA: 0x0005C8AE File Offset: 0x0005AAAE
		public unsafe Button AddButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_AddButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_AddButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040085EC RID: 34284
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x040085ED RID: 34285
		private static readonly IntPtr NativeFieldInfoPtr_FieldText;

		// Token: 0x040085EE RID: 34286
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x040085EF RID: 34287
		private static readonly IntPtr NativeFieldInfoPtr_RouteEntries;

		// Token: 0x040085F0 RID: 34288
		private static readonly IntPtr NativeFieldInfoPtr_MultiEditBlocker;

		// Token: 0x040085F1 RID: 34289
		private static readonly IntPtr NativeFieldInfoPtr_AddButton;

		// Token: 0x040085F2 RID: 34290
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_RouteListField_0;

		// Token: 0x040085F3 RID: 34291
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_RouteListField_0;

		// Token: 0x040085F4 RID: 34292
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040085F5 RID: 34293
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_RouteListField_0;

		// Token: 0x040085F6 RID: 34294
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_List_1_AdvancedTransitRoute_0;

		// Token: 0x040085F7 RID: 34295
		private static readonly IntPtr NativeMethodInfoPtr_EntryDeleteClicked_Private_Void_RouteEntryUI_0;

		// Token: 0x040085F8 RID: 34296
		private static readonly IntPtr NativeMethodInfoPtr_AddClicked_Private_Void_0;

		// Token: 0x040085F9 RID: 34297
		private static readonly IntPtr NativeMethodInfoPtr_RouteChanged_Private_Void_ITransitEntity_0;

		// Token: 0x040085FA RID: 34298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D5A RID: 3418
		[ObfuscatedName("ScheduleOne.UI.Management.RouteListFieldUI+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FA91 RID: 64145 RVA: 0x003BDDBC File Offset: 0x003BBFBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr);
				RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr, "entry");
				RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				RouteListFieldUI.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr, 100688745);
				RouteListFieldUI.__c__DisplayClass9_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr, 100688746);
			}

			// Token: 0x0600FA92 RID: 64146 RVA: 0x003BDE38 File Offset: 0x003BC038
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA93 RID: 64147 RVA: 0x003BDE74 File Offset: 0x003BC074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324658, XrefRangeEnd = 324692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.__c__DisplayClass9_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA94 RID: 64148 RVA: 0x000768DD File Offset: 0x00074ADD
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C29 RID: 19497
			// (get) Token: 0x0600FA95 RID: 64149 RVA: 0x003BDEA8 File Offset: 0x003BC0A8
			// (set) Token: 0x0600FA96 RID: 64150 RVA: 0x000768E6 File Offset: 0x00074AE6
			public unsafe RouteEntryUI entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RouteEntryUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C2A RID: 19498
			// (get) Token: 0x0600FA97 RID: 64151 RVA: 0x003BDED8 File Offset: 0x003BC0D8
			// (set) Token: 0x0600FA98 RID: 64152 RVA: 0x00076905 File Offset: 0x00074B05
			public unsafe RouteListFieldUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RouteListFieldUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A91E RID: 43294
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x0400A91F RID: 43295
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A920 RID: 43296
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A921 RID: 43297
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}
	}
}
