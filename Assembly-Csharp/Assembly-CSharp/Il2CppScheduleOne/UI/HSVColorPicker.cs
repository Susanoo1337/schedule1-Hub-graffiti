using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200073A RID: 1850
	public class HSVColorPicker : MonoBehaviour
	{
		// Token: 0x0600B2A2 RID: 45730 RVA: 0x002E8D04 File Offset: 0x002E6F04
		// Note: this type is marked as 'beforefieldinit'.
		static HSVColorPicker()
		{
			Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "HSVColorPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr);
			HSVColorPicker.NativeFieldInfoPtr_hueSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr, "hueSlider");
			HSVColorPicker.NativeFieldInfoPtr_saturationSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr, "saturationSlider");
			HSVColorPicker.NativeFieldInfoPtr_valueSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr, "valueSlider");
			HSVColorPicker.NativeFieldInfoPtr_saturationImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr, "saturationImg");
			HSVColorPicker.NativeFieldInfoPtr_valueImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr, "valueImg");
			HSVColorPicker.NativeFieldInfoPtr_OnColorChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr, "OnColorChanged");
			HSVColorPicker.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr, 100686781);
			HSVColorPicker.NativeMethodInfoPtr_add_OnColorChanged_Public_add_Void_Action_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr, 100686782);
			HSVColorPicker.NativeMethodInfoPtr_remove_OnColorChanged_Public_rem_Void_Action_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr, 100686783);
			HSVColorPicker.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr, 100686784);
			HSVColorPicker.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr, 100686785);
			HSVColorPicker.NativeMethodInfoPtr_HueChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr, 100686786);
			HSVColorPicker.NativeMethodInfoPtr_SaturationChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr, 100686787);
			HSVColorPicker.NativeMethodInfoPtr_ValueChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr, 100686788);
			HSVColorPicker.NativeMethodInfoPtr_RefreshImages_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr, 100686789);
			HSVColorPicker.NativeMethodInfoPtr_GetOutput_Private_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr, 100686790);
			HSVColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr, 100686791);
		}

		// Token: 0x170035BD RID: 13757
		// (get) Token: 0x0600B2A3 RID: 45731 RVA: 0x002E8E88 File Offset: 0x002E7088
		public unsafe Color Color
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 302355, RefRangeEnd = 302356, XrefRangeStart = 302354, XrefRangeEnd = 302355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSVColorPicker.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B2A4 RID: 45732 RVA: 0x002E8EC4 File Offset: 0x002E70C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302361, RefRangeEnd = 302362, XrefRangeStart = 302356, XrefRangeEnd = 302361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnColorChanged(Action<Color> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSVColorPicker.NativeMethodInfoPtr_add_OnColorChanged_Public_add_Void_Action_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2A5 RID: 45733 RVA: 0x002E8F08 File Offset: 0x002E7108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302362, XrefRangeEnd = 302367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnColorChanged(Action<Color> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSVColorPicker.NativeMethodInfoPtr_remove_OnColorChanged_Public_rem_Void_Action_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2A6 RID: 45734 RVA: 0x002E8F4C File Offset: 0x002E714C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302367, XrefRangeEnd = 302391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSVColorPicker.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2A7 RID: 45735 RVA: 0x002E8F80 File Offset: 0x002E7180
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302393, RefRangeEnd = 302395, XrefRangeStart = 302391, XrefRangeEnd = 302393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSVColorPicker.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2A8 RID: 45736 RVA: 0x002E8FC0 File Offset: 0x002E71C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302395, XrefRangeEnd = 302397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSVColorPicker.NativeMethodInfoPtr_HueChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2A9 RID: 45737 RVA: 0x002E9000 File Offset: 0x002E7200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaturationChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSVColorPicker.NativeMethodInfoPtr_SaturationChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2AA RID: 45738 RVA: 0x002E9040 File Offset: 0x002E7240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSVColorPicker.NativeMethodInfoPtr_ValueChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2AB RID: 45739 RVA: 0x002E9080 File Offset: 0x002E7280
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 302400, RefRangeEnd = 302404, XrefRangeStart = 302397, XrefRangeEnd = 302400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshImages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSVColorPicker.NativeMethodInfoPtr_RefreshImages_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2AC RID: 45740 RVA: 0x002E90B4 File Offset: 0x002E72B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 302405, RefRangeEnd = 302410, XrefRangeStart = 302404, XrefRangeEnd = 302405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetOutput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSVColorPicker.NativeMethodInfoPtr_GetOutput_Private_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B2AD RID: 45741 RVA: 0x002E90F0 File Offset: 0x002E72F0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HSVColorPicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HSVColorPicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSVColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2AE RID: 45742 RVA: 0x000523A5 File Offset: 0x000505A5
		public HSVColorPicker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170035B7 RID: 13751
		// (get) Token: 0x0600B2AF RID: 45743 RVA: 0x002E912C File Offset: 0x002E732C
		// (set) Token: 0x0600B2B0 RID: 45744 RVA: 0x000523AE File Offset: 0x000505AE
		public unsafe Slider hueSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HSVColorPicker.NativeFieldInfoPtr_hueSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HSVColorPicker.NativeFieldInfoPtr_hueSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035B8 RID: 13752
		// (get) Token: 0x0600B2B1 RID: 45745 RVA: 0x002E915C File Offset: 0x002E735C
		// (set) Token: 0x0600B2B2 RID: 45746 RVA: 0x000523CD File Offset: 0x000505CD
		public unsafe Slider saturationSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HSVColorPicker.NativeFieldInfoPtr_saturationSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HSVColorPicker.NativeFieldInfoPtr_saturationSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035B9 RID: 13753
		// (get) Token: 0x0600B2B3 RID: 45747 RVA: 0x002E918C File Offset: 0x002E738C
		// (set) Token: 0x0600B2B4 RID: 45748 RVA: 0x000523EC File Offset: 0x000505EC
		public unsafe Slider valueSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HSVColorPicker.NativeFieldInfoPtr_valueSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HSVColorPicker.NativeFieldInfoPtr_valueSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035BA RID: 13754
		// (get) Token: 0x0600B2B5 RID: 45749 RVA: 0x002E91BC File Offset: 0x002E73BC
		// (set) Token: 0x0600B2B6 RID: 45750 RVA: 0x0005240B File Offset: 0x0005060B
		public unsafe Image saturationImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HSVColorPicker.NativeFieldInfoPtr_saturationImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HSVColorPicker.NativeFieldInfoPtr_saturationImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035BB RID: 13755
		// (get) Token: 0x0600B2B7 RID: 45751 RVA: 0x002E91EC File Offset: 0x002E73EC
		// (set) Token: 0x0600B2B8 RID: 45752 RVA: 0x0005242A File Offset: 0x0005062A
		public unsafe Image valueImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HSVColorPicker.NativeFieldInfoPtr_valueImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HSVColorPicker.NativeFieldInfoPtr_valueImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035BC RID: 13756
		// (get) Token: 0x0600B2B9 RID: 45753 RVA: 0x002E921C File Offset: 0x002E741C
		// (set) Token: 0x0600B2BA RID: 45754 RVA: 0x00052449 File Offset: 0x00050649
		public unsafe Action<Color> OnColorChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HSVColorPicker.NativeFieldInfoPtr_OnColorChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HSVColorPicker.NativeFieldInfoPtr_OnColorChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007B04 RID: 31492
		private static readonly IntPtr NativeFieldInfoPtr_hueSlider;

		// Token: 0x04007B05 RID: 31493
		private static readonly IntPtr NativeFieldInfoPtr_saturationSlider;

		// Token: 0x04007B06 RID: 31494
		private static readonly IntPtr NativeFieldInfoPtr_valueSlider;

		// Token: 0x04007B07 RID: 31495
		private static readonly IntPtr NativeFieldInfoPtr_saturationImg;

		// Token: 0x04007B08 RID: 31496
		private static readonly IntPtr NativeFieldInfoPtr_valueImg;

		// Token: 0x04007B09 RID: 31497
		private static readonly IntPtr NativeFieldInfoPtr_OnColorChanged;

		// Token: 0x04007B0A RID: 31498
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x04007B0B RID: 31499
		private static readonly IntPtr NativeMethodInfoPtr_add_OnColorChanged_Public_add_Void_Action_1_Color_0;

		// Token: 0x04007B0C RID: 31500
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnColorChanged_Public_rem_Void_Action_1_Color_0;

		// Token: 0x04007B0D RID: 31501
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007B0E RID: 31502
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

		// Token: 0x04007B0F RID: 31503
		private static readonly IntPtr NativeMethodInfoPtr_HueChanged_Private_Void_Single_0;

		// Token: 0x04007B10 RID: 31504
		private static readonly IntPtr NativeMethodInfoPtr_SaturationChanged_Private_Void_Single_0;

		// Token: 0x04007B11 RID: 31505
		private static readonly IntPtr NativeMethodInfoPtr_ValueChanged_Private_Void_Single_0;

		// Token: 0x04007B12 RID: 31506
		private static readonly IntPtr NativeMethodInfoPtr_RefreshImages_Private_Void_0;

		// Token: 0x04007B13 RID: 31507
		private static readonly IntPtr NativeMethodInfoPtr_GetOutput_Private_Color_0;

		// Token: 0x04007B14 RID: 31508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
