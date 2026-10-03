using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000413 RID: 1043
	[Serializable]
	public class InputSettings : Object
	{
		// Token: 0x06005B9B RID: 23451 RVA: 0x001B704C File Offset: 0x001B524C
		// Note: this type is marked as 'beforefieldinit'.
		static InputSettings()
		{
			Il2CppClassPointerStore<InputSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "InputSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputSettings>.NativeClassPtr);
			InputSettings.NativeFieldInfoPtr_MouseSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, "MouseSensitivity");
			InputSettings.NativeFieldInfoPtr_InvertMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, "InvertMouse");
			InputSettings.NativeFieldInfoPtr_SprintMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, "SprintMode");
			InputSettings.NativeFieldInfoPtr_BindingOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, "BindingOverrides");
			InputSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, 100675253);
		}

		// Token: 0x06005B9C RID: 23452 RVA: 0x001B70E0 File Offset: 0x001B52E0
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B9D RID: 23453 RVA: 0x0002B659 File Offset: 0x00029859
		public InputSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x06005B9E RID: 23454 RVA: 0x001B711C File Offset: 0x001B531C
		// (set) Token: 0x06005B9F RID: 23455 RVA: 0x0002B662 File Offset: 0x00029862
		public unsafe float MouseSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_MouseSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_MouseSensitivity)) = value;
			}
		}

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x06005BA0 RID: 23456 RVA: 0x001B7144 File Offset: 0x001B5344
		// (set) Token: 0x06005BA1 RID: 23457 RVA: 0x0002B67D File Offset: 0x0002987D
		public unsafe bool InvertMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_InvertMouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_InvertMouse)) = value;
			}
		}

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x06005BA2 RID: 23458 RVA: 0x001B716C File Offset: 0x001B536C
		// (set) Token: 0x06005BA3 RID: 23459 RVA: 0x0002B698 File Offset: 0x00029898
		public unsafe InputSettings.EActionMode SprintMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_SprintMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_SprintMode)) = value;
			}
		}

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x06005BA4 RID: 23460 RVA: 0x001B7194 File Offset: 0x001B5394
		// (set) Token: 0x06005BA5 RID: 23461 RVA: 0x0002B6B3 File Offset: 0x000298B3
		public unsafe string BindingOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_BindingOverrides);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_BindingOverrides), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003ED1 RID: 16081
		private static readonly IntPtr NativeFieldInfoPtr_MouseSensitivity;

		// Token: 0x04003ED2 RID: 16082
		private static readonly IntPtr NativeFieldInfoPtr_InvertMouse;

		// Token: 0x04003ED3 RID: 16083
		private static readonly IntPtr NativeFieldInfoPtr_SprintMode;

		// Token: 0x04003ED4 RID: 16084
		private static readonly IntPtr NativeFieldInfoPtr_BindingOverrides;

		// Token: 0x04003ED5 RID: 16085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF9 RID: 2809
		[OriginalName("Assembly-CSharp.dll", "", "EActionMode")]
		public enum EActionMode
		{
			// Token: 0x04009BA1 RID: 39841
			Press,
			// Token: 0x04009BA2 RID: 39842
			Hold
		}
	}
}
