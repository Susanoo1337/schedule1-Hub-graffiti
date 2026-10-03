using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Il2CppScheduleOne.CustomUI
{
	// Token: 0x02000844 RID: 2116
	public class UISliderTrigger : UITrigger
	{
		// Token: 0x0600CE35 RID: 52789 RVA: 0x0033CAD8 File Offset: 0x0033ACD8
		// Note: this type is marked as 'beforefieldinit'.
		static UISliderTrigger()
		{
			Il2CppClassPointerStore<UISliderTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.CustomUI", "UISliderTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISliderTrigger>.NativeClassPtr);
			UISliderTrigger.NativeFieldInfoPtr_Deadzone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISliderTrigger>.NativeClassPtr, "Deadzone");
			UISliderTrigger.NativeFieldInfoPtr__slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISliderTrigger>.NativeClassPtr, "_slider");
			UISliderTrigger.NativeFieldInfoPtr__sliderDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISliderTrigger>.NativeClassPtr, "_sliderDirection");
			UISliderTrigger.NativeFieldInfoPtr__sliderSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISliderTrigger>.NativeClassPtr, "_sliderSpeed");
			UISliderTrigger.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderTrigger>.NativeClassPtr, 100689840);
			UISliderTrigger.NativeMethodInfoPtr_DetectTriggerInput_Internal_Virtual_Void_InputActionReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderTrigger>.NativeClassPtr, 100689841);
			UISliderTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISliderTrigger>.NativeClassPtr, 100689842);
		}

		// Token: 0x0600CE36 RID: 52790 RVA: 0x0033CB94 File Offset: 0x0033AD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337238, XrefRangeEnd = 337239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISliderTrigger.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CE37 RID: 52791 RVA: 0x0033CBD0 File Offset: 0x0033ADD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337239, XrefRangeEnd = 337253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DetectTriggerInput(InputActionReference inputAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISliderTrigger.NativeMethodInfoPtr_DetectTriggerInput_Internal_Virtual_Void_InputActionReference_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CE38 RID: 52792 RVA: 0x0033CC20 File Offset: 0x0033AE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337253, XrefRangeEnd = 337254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISliderTrigger() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISliderTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISliderTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CE39 RID: 52793 RVA: 0x00061FB0 File Offset: 0x000601B0
		public UISliderTrigger(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003EB3 RID: 16051
		// (get) Token: 0x0600CE3A RID: 52794 RVA: 0x0033CC5C File Offset: 0x0033AE5C
		// (set) Token: 0x0600CE3B RID: 52795 RVA: 0x00061FB9 File Offset: 0x000601B9
		public unsafe static float Deadzone
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UISliderTrigger.NativeFieldInfoPtr_Deadzone, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UISliderTrigger.NativeFieldInfoPtr_Deadzone, (void*)(&value));
			}
		}

		// Token: 0x17003EB4 RID: 16052
		// (get) Token: 0x0600CE3C RID: 52796 RVA: 0x0033CC78 File Offset: 0x0033AE78
		// (set) Token: 0x0600CE3D RID: 52797 RVA: 0x00061FC7 File Offset: 0x000601C7
		public unsafe Slider _slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISliderTrigger.NativeFieldInfoPtr__slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISliderTrigger.NativeFieldInfoPtr__slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003EB5 RID: 16053
		// (get) Token: 0x0600CE3E RID: 52798 RVA: 0x0033CCA8 File Offset: 0x0033AEA8
		// (set) Token: 0x0600CE3F RID: 52799 RVA: 0x00061FE6 File Offset: 0x000601E6
		public unsafe UISliderTrigger.ESliderDirection _sliderDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISliderTrigger.NativeFieldInfoPtr__sliderDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISliderTrigger.NativeFieldInfoPtr__sliderDirection)) = value;
			}
		}

		// Token: 0x17003EB6 RID: 16054
		// (get) Token: 0x0600CE40 RID: 52800 RVA: 0x0033CCD0 File Offset: 0x0033AED0
		// (set) Token: 0x0600CE41 RID: 52801 RVA: 0x00062001 File Offset: 0x00060201
		public unsafe float _sliderSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISliderTrigger.NativeFieldInfoPtr__sliderSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISliderTrigger.NativeFieldInfoPtr__sliderSpeed)) = value;
			}
		}

		// Token: 0x04008C64 RID: 35940
		private static readonly IntPtr NativeFieldInfoPtr_Deadzone;

		// Token: 0x04008C65 RID: 35941
		private static readonly IntPtr NativeFieldInfoPtr__slider;

		// Token: 0x04008C66 RID: 35942
		private static readonly IntPtr NativeFieldInfoPtr__sliderDirection;

		// Token: 0x04008C67 RID: 35943
		private static readonly IntPtr NativeFieldInfoPtr__sliderSpeed;

		// Token: 0x04008C68 RID: 35944
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04008C69 RID: 35945
		private static readonly IntPtr NativeMethodInfoPtr_DetectTriggerInput_Internal_Virtual_Void_InputActionReference_0;

		// Token: 0x04008C6A RID: 35946
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D97 RID: 3479
		[OriginalName("Assembly-CSharp.dll", "", "ESliderDirection")]
		public enum ESliderDirection
		{
			// Token: 0x0400AA65 RID: 43621
			Horizontal,
			// Token: 0x0400AA66 RID: 43622
			Vertical
		}
	}
}
