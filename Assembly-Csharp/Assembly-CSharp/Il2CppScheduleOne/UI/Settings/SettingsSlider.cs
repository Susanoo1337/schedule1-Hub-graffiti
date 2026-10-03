using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x0200079A RID: 1946
	public class SettingsSlider : MonoBehaviour
	{
		// Token: 0x0600BC6E RID: 48238 RVA: 0x003060C0 File Offset: 0x003042C0
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsSlider()
		{
			Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "SettingsSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr);
			SettingsSlider.NativeFieldInfoPtr_ValueDisplayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "ValueDisplayTime");
			SettingsSlider.NativeFieldInfoPtr_DisplayValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "DisplayValue");
			SettingsSlider.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "slider");
			SettingsSlider.NativeFieldInfoPtr_valueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "valueLabel");
			SettingsSlider.NativeFieldInfoPtr_timeOnValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "timeOnValueChange");
			SettingsSlider.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100687885);
			SettingsSlider.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100687886);
			SettingsSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100687887);
			SettingsSlider.NativeMethodInfoPtr_SetDisplayValue_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100687888);
			SettingsSlider.NativeMethodInfoPtr_SetValueWithoutNotify_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100687889);
			SettingsSlider.NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_New_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100687890);
			SettingsSlider.NativeMethodInfoPtr_OnDragEnd_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100687891);
			SettingsSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100687892);
			SettingsSlider.NativeMethodInfoPtr__Awake_b__5_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100687893);
		}

		// Token: 0x0600BC6F RID: 48239 RVA: 0x00306208 File Offset: 0x00304408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314150, XrefRangeEnd = 314195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsSlider.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC70 RID: 48240 RVA: 0x00306244 File Offset: 0x00304444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314195, XrefRangeEnd = 314197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsSlider.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC71 RID: 48241 RVA: 0x00306280 File Offset: 0x00304480
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 314206, RefRangeEnd = 314211, XrefRangeStart = 314197, XrefRangeEnd = 314206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC72 RID: 48242 RVA: 0x003062CC File Offset: 0x003044CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314211, XrefRangeEnd = 314212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSlider.NativeMethodInfoPtr_SetDisplayValue_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC73 RID: 48243 RVA: 0x0030630C File Offset: 0x0030450C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 314213, RefRangeEnd = 314221, XrefRangeStart = 314212, XrefRangeEnd = 314213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValueWithoutNotify(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSlider.NativeMethodInfoPtr_SetValueWithoutNotify_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC74 RID: 48244 RVA: 0x0030634C File Offset: 0x0030454C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314221, XrefRangeEnd = 314222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetDisplayValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsSlider.NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_New_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600BC75 RID: 48245 RVA: 0x0030639C File Offset: 0x0030459C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDragEnd(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsSlider.NativeMethodInfoPtr_OnDragEnd_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC76 RID: 48246 RVA: 0x003063E8 File Offset: 0x003045E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 313838, RefRangeEnd = 313842, XrefRangeStart = 313838, XrefRangeEnd = 313842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC77 RID: 48247 RVA: 0x00306424 File Offset: 0x00304624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314222, XrefRangeEnd = 314223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__5_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSlider.NativeMethodInfoPtr__Awake_b__5_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC78 RID: 48248 RVA: 0x00057CDE File Offset: 0x00055EDE
		public SettingsSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038E0 RID: 14560
		// (get) Token: 0x0600BC79 RID: 48249 RVA: 0x00306468 File Offset: 0x00304668
		// (set) Token: 0x0600BC7A RID: 48250 RVA: 0x00057CE7 File Offset: 0x00055EE7
		public unsafe float ValueDisplayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_ValueDisplayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_ValueDisplayTime)) = value;
			}
		}

		// Token: 0x170038E1 RID: 14561
		// (get) Token: 0x0600BC7B RID: 48251 RVA: 0x00306490 File Offset: 0x00304690
		// (set) Token: 0x0600BC7C RID: 48252 RVA: 0x00057D02 File Offset: 0x00055F02
		public unsafe bool DisplayValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_DisplayValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_DisplayValue)) = value;
			}
		}

		// Token: 0x170038E2 RID: 14562
		// (get) Token: 0x0600BC7D RID: 48253 RVA: 0x003064B8 File Offset: 0x003046B8
		// (set) Token: 0x0600BC7E RID: 48254 RVA: 0x00057D1D File Offset: 0x00055F1D
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x0600BC7F RID: 48255 RVA: 0x003064E8 File Offset: 0x003046E8
		// (set) Token: 0x0600BC80 RID: 48256 RVA: 0x00057D3C File Offset: 0x00055F3C
		public unsafe TextMeshProUGUI valueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_valueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_valueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x0600BC81 RID: 48257 RVA: 0x00306518 File Offset: 0x00304718
		// (set) Token: 0x0600BC82 RID: 48258 RVA: 0x00057D5B File Offset: 0x00055F5B
		public unsafe float timeOnValueChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_timeOnValueChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_timeOnValueChange)) = value;
			}
		}

		// Token: 0x0400811F RID: 33055
		private static readonly IntPtr NativeFieldInfoPtr_ValueDisplayTime;

		// Token: 0x04008120 RID: 33056
		private static readonly IntPtr NativeFieldInfoPtr_DisplayValue;

		// Token: 0x04008121 RID: 33057
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x04008122 RID: 33058
		private static readonly IntPtr NativeFieldInfoPtr_valueLabel;

		// Token: 0x04008123 RID: 33059
		private static readonly IntPtr NativeFieldInfoPtr_timeOnValueChange;

		// Token: 0x04008124 RID: 33060
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04008125 RID: 33061
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04008126 RID: 33062
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04008127 RID: 33063
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayValue_Protected_Void_Single_0;

		// Token: 0x04008128 RID: 33064
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Protected_Void_Single_0;

		// Token: 0x04008129 RID: 33065
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_New_String_Single_0;

		// Token: 0x0400812A RID: 33066
		private static readonly IntPtr NativeMethodInfoPtr_OnDragEnd_Protected_Virtual_New_Void_Single_0;

		// Token: 0x0400812B RID: 33067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400812C RID: 33068
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_0_Private_Void_BaseEventData_0;
	}
}
