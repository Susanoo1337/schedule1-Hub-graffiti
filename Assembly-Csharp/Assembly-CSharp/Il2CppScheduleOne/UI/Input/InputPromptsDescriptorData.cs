using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x02000807 RID: 2055
	public class InputPromptsDescriptorData : ScriptableObject
	{
		// Token: 0x0600C7A8 RID: 51112 RVA: 0x00327DE4 File Offset: 0x00325FE4
		// Note: this type is marked as 'beforefieldinit'.
		static InputPromptsDescriptorData()
		{
			Il2CppClassPointerStore<InputPromptsDescriptorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPromptsDescriptorData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsDescriptorData>.NativeClassPtr);
			InputPromptsDescriptorData.NativeFieldInfoPtr_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsDescriptorData>.NativeClassPtr, "DisplayName");
			InputPromptsDescriptorData.NativeFieldInfoPtr_DisplayColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsDescriptorData>.NativeClassPtr, "DisplayColor");
			InputPromptsDescriptorData.NativeFieldInfoPtr_Actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsDescriptorData>.NativeClassPtr, "Actions");
			InputPromptsDescriptorData.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsDescriptorData>.NativeClassPtr, 100689120);
			InputPromptsDescriptorData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsDescriptorData>.NativeClassPtr, 100689121);
		}

		// Token: 0x0600C7A9 RID: 51113 RVA: 0x00327E78 File Offset: 0x00326078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328978, XrefRangeEnd = 329006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsDescriptorData.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7AA RID: 51114 RVA: 0x00327EAC File Offset: 0x003260AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329006, XrefRangeEnd = 329007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptsDescriptorData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsDescriptorData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsDescriptorData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7AB RID: 51115 RVA: 0x0005E5E1 File Offset: 0x0005C7E1
		public InputPromptsDescriptorData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C9A RID: 15514
		// (get) Token: 0x0600C7AC RID: 51116 RVA: 0x00327EE8 File Offset: 0x003260E8
		// (set) Token: 0x0600C7AD RID: 51117 RVA: 0x0005E5EA File Offset: 0x0005C7EA
		public unsafe string DisplayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsDescriptorData.NativeFieldInfoPtr_DisplayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsDescriptorData.NativeFieldInfoPtr_DisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003C9B RID: 15515
		// (get) Token: 0x0600C7AE RID: 51118 RVA: 0x00327F10 File Offset: 0x00326110
		// (set) Token: 0x0600C7AF RID: 51119 RVA: 0x0005E609 File Offset: 0x0005C809
		public unsafe Color DisplayColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsDescriptorData.NativeFieldInfoPtr_DisplayColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsDescriptorData.NativeFieldInfoPtr_DisplayColor)) = value;
			}
		}

		// Token: 0x17003C9C RID: 15516
		// (get) Token: 0x0600C7B0 RID: 51120 RVA: 0x00327F38 File Offset: 0x00326138
		// (set) Token: 0x0600C7B1 RID: 51121 RVA: 0x0005E624 File Offset: 0x0005C824
		public unsafe List<InputActionReference> Actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsDescriptorData.NativeFieldInfoPtr_Actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputActionReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsDescriptorData.NativeFieldInfoPtr_Actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008815 RID: 34837
		private static readonly IntPtr NativeFieldInfoPtr_DisplayName;

		// Token: 0x04008816 RID: 34838
		private static readonly IntPtr NativeFieldInfoPtr_DisplayColor;

		// Token: 0x04008817 RID: 34839
		private static readonly IntPtr NativeFieldInfoPtr_Actions;

		// Token: 0x04008818 RID: 34840
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04008819 RID: 34841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
