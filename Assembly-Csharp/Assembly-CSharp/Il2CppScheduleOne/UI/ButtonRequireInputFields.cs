using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000765 RID: 1893
	public class ButtonRequireInputFields : MonoBehaviour
	{
		// Token: 0x0600B885 RID: 47237 RVA: 0x002FA120 File Offset: 0x002F8320
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonRequireInputFields()
		{
			Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ButtonRequireInputFields");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr);
			ButtonRequireInputFields.NativeFieldInfoPtr_Inputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, "Inputs");
			ButtonRequireInputFields.NativeFieldInfoPtr_Dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, "Dropdown");
			ButtonRequireInputFields.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, "Button");
			ButtonRequireInputFields.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, 100687434);
			ButtonRequireInputFields.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, 100687435);
		}

		// Token: 0x0600B886 RID: 47238 RVA: 0x002FA1B4 File Offset: 0x002F83B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309151, XrefRangeEnd = 309178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonRequireInputFields.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B887 RID: 47239 RVA: 0x002FA1E8 File Offset: 0x002F83E8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonRequireInputFields() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonRequireInputFields.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B888 RID: 47240 RVA: 0x00055C7F File Offset: 0x00053E7F
		public ButtonRequireInputFields(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037BC RID: 14268
		// (get) Token: 0x0600B889 RID: 47241 RVA: 0x002FA224 File Offset: 0x002F8424
		// (set) Token: 0x0600B88A RID: 47242 RVA: 0x00055C88 File Offset: 0x00053E88
		public unsafe List<ButtonRequireInputFields.Input> Inputs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Inputs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ButtonRequireInputFields.Input>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Inputs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037BD RID: 14269
		// (get) Token: 0x0600B88B RID: 47243 RVA: 0x002FA254 File Offset: 0x002F8454
		// (set) Token: 0x0600B88C RID: 47244 RVA: 0x00055CA7 File Offset: 0x00053EA7
		public unsafe TMP_Dropdown Dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037BE RID: 14270
		// (get) Token: 0x0600B88D RID: 47245 RVA: 0x002FA284 File Offset: 0x002F8484
		// (set) Token: 0x0600B88E RID: 47246 RVA: 0x00055CC6 File Offset: 0x00053EC6
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007EAD RID: 32429
		private static readonly IntPtr NativeFieldInfoPtr_Inputs;

		// Token: 0x04007EAE RID: 32430
		private static readonly IntPtr NativeFieldInfoPtr_Dropdown;

		// Token: 0x04007EAF RID: 32431
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04007EB0 RID: 32432
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04007EB1 RID: 32433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CF8 RID: 3320
		[Serializable]
		public class Input : Il2CppSystem.Object
		{
			// Token: 0x0600F6FF RID: 63231 RVA: 0x003B3B20 File Offset: 0x003B1D20
			// Note: this type is marked as 'beforefieldinit'.
			static Input()
			{
				Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ButtonRequireInputFields>.NativeClassPtr, "Input");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr);
				ButtonRequireInputFields.Input.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr, "InputField");
				ButtonRequireInputFields.Input.NativeFieldInfoPtr_ErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr, "ErrorMessage");
				ButtonRequireInputFields.Input.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr, 100687436);
			}

			// Token: 0x0600F700 RID: 63232 RVA: 0x003B3B88 File Offset: 0x003B1D88
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Input() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonRequireInputFields.Input>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonRequireInputFields.Input.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F701 RID: 63233 RVA: 0x00074CAA File Offset: 0x00072EAA
			public Input(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B1E RID: 19230
			// (get) Token: 0x0600F702 RID: 63234 RVA: 0x003B3BC4 File Offset: 0x003B1DC4
			// (set) Token: 0x0600F703 RID: 63235 RVA: 0x00074CB3 File Offset: 0x00072EB3
			public unsafe TMP_InputField InputField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.Input.NativeFieldInfoPtr_InputField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.Input.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B1F RID: 19231
			// (get) Token: 0x0600F704 RID: 63236 RVA: 0x003B3BF4 File Offset: 0x003B1DF4
			// (set) Token: 0x0600F705 RID: 63237 RVA: 0x00074CD2 File Offset: 0x00072ED2
			public unsafe RectTransform ErrorMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.Input.NativeFieldInfoPtr_ErrorMessage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonRequireInputFields.Input.NativeFieldInfoPtr_ErrorMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A712 RID: 42770
			private static readonly IntPtr NativeFieldInfoPtr_InputField;

			// Token: 0x0400A713 RID: 42771
			private static readonly IntPtr NativeFieldInfoPtr_ErrorMessage;

			// Token: 0x0400A714 RID: 42772
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
