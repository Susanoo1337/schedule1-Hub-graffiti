using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000798 RID: 1944
	public class SensitivitySlider : SettingsSlider
	{
		// Token: 0x0600BC52 RID: 48210 RVA: 0x00305A90 File Offset: 0x00303C90
		// Note: this type is marked as 'beforefieldinit'.
		static SensitivitySlider()
		{
			Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "SensitivitySlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr);
			SensitivitySlider.NativeFieldInfoPtr_Multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, "Multiplier");
			SensitivitySlider.NativeFieldInfoPtr__sensitivityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, "_sensitivityType");
			SensitivitySlider.NativeMethodInfoPtr_get__sensitivity_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, 100687868);
			SensitivitySlider.NativeMethodInfoPtr_set__sensitivity_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, 100687869);
			SensitivitySlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, 100687870);
			SensitivitySlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, 100687871);
			SensitivitySlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, 100687872);
		}

		// Token: 0x170038DC RID: 14556
		// (get) Token: 0x0600BC53 RID: 48211 RVA: 0x00305B4C File Offset: 0x00303D4C
		// (set) Token: 0x0600BC54 RID: 48212 RVA: 0x00305B88 File Offset: 0x00303D88
		public unsafe float _sensitivity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313987, XrefRangeEnd = 313988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensitivitySlider.NativeMethodInfoPtr_get__sensitivity_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313988, XrefRangeEnd = 313991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensitivitySlider.NativeMethodInfoPtr_set__sensitivity_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BC55 RID: 48213 RVA: 0x00305BC8 File Offset: 0x00303DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313991, XrefRangeEnd = 314001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SensitivitySlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC56 RID: 48214 RVA: 0x00305C04 File Offset: 0x00303E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314001, XrefRangeEnd = 314018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SensitivitySlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC57 RID: 48215 RVA: 0x00305C50 File Offset: 0x00303E50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 313838, RefRangeEnd = 313842, XrefRangeStart = 313838, XrefRangeEnd = 313842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SensitivitySlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensitivitySlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC58 RID: 48216 RVA: 0x00057C46 File Offset: 0x00055E46
		public SensitivitySlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038DA RID: 14554
		// (get) Token: 0x0600BC59 RID: 48217 RVA: 0x00305C8C File Offset: 0x00303E8C
		// (set) Token: 0x0600BC5A RID: 48218 RVA: 0x00057C4F File Offset: 0x00055E4F
		public unsafe static float Multiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SensitivitySlider.NativeFieldInfoPtr_Multiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SensitivitySlider.NativeFieldInfoPtr_Multiplier, (void*)(&value));
			}
		}

		// Token: 0x170038DB RID: 14555
		// (get) Token: 0x0600BC5B RID: 48219 RVA: 0x00305CA8 File Offset: 0x00303EA8
		// (set) Token: 0x0600BC5C RID: 48220 RVA: 0x00057C5D File Offset: 0x00055E5D
		public unsafe SensitivitySlider.ESensitivityType _sensitivityType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensitivitySlider.NativeFieldInfoPtr__sensitivityType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensitivitySlider.NativeFieldInfoPtr__sensitivityType)) = value;
			}
		}

		// Token: 0x0400810C RID: 33036
		private static readonly IntPtr NativeFieldInfoPtr_Multiplier;

		// Token: 0x0400810D RID: 33037
		private static readonly IntPtr NativeFieldInfoPtr__sensitivityType;

		// Token: 0x0400810E RID: 33038
		private static readonly IntPtr NativeMethodInfoPtr_get__sensitivity_Private_get_Single_0;

		// Token: 0x0400810F RID: 33039
		private static readonly IntPtr NativeMethodInfoPtr_set__sensitivity_Private_set_Void_Single_0;

		// Token: 0x04008110 RID: 33040
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04008111 RID: 33041
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0;

		// Token: 0x04008112 RID: 33042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D12 RID: 3346
		[OriginalName("Assembly-CSharp.dll", "", "ESensitivityType")]
		public enum ESensitivityType
		{
			// Token: 0x0400A79D RID: 42909
			Mouse,
			// Token: 0x0400A79E RID: 42910
			Gamepad
		}
	}
}
