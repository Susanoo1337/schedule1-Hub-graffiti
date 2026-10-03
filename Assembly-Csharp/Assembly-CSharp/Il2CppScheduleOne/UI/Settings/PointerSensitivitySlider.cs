using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000794 RID: 1940
	public class PointerSensitivitySlider : SettingsSlider
	{
		// Token: 0x0600BC33 RID: 48179 RVA: 0x00305398 File Offset: 0x00303598
		// Note: this type is marked as 'beforefieldinit'.
		static PointerSensitivitySlider()
		{
			Il2CppClassPointerStore<PointerSensitivitySlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "PointerSensitivitySlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerSensitivitySlider>.NativeClassPtr);
			PointerSensitivitySlider.NativeFieldInfoPtr_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerSensitivitySlider>.NativeClassPtr, "MULTIPLIER");
			PointerSensitivitySlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerSensitivitySlider>.NativeClassPtr, 100687851);
			PointerSensitivitySlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerSensitivitySlider>.NativeClassPtr, 100687852);
			PointerSensitivitySlider.NativeMethodInfoPtr_MapSensitivity_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerSensitivitySlider>.NativeClassPtr, 100687853);
			PointerSensitivitySlider.NativeMethodInfoPtr_InverseMapSensitivity_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerSensitivitySlider>.NativeClassPtr, 100687854);
			PointerSensitivitySlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerSensitivitySlider>.NativeClassPtr, 100687855);
		}

		// Token: 0x0600BC34 RID: 48180 RVA: 0x00305440 File Offset: 0x00303640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313806, XrefRangeEnd = 313815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerSensitivitySlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC35 RID: 48181 RVA: 0x0030547C File Offset: 0x0030367C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313815, XrefRangeEnd = 313836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerSensitivitySlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC36 RID: 48182 RVA: 0x003054C8 File Offset: 0x003036C8
		[CallerCount(0)]
		public unsafe float MapSensitivity(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerSensitivitySlider.NativeMethodInfoPtr_MapSensitivity_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600BC37 RID: 48183 RVA: 0x00305514 File Offset: 0x00303714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313836, XrefRangeEnd = 313837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float InverseMapSensitivity(float sensitivity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sensitivity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerSensitivitySlider.NativeMethodInfoPtr_InverseMapSensitivity_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600BC38 RID: 48184 RVA: 0x00305560 File Offset: 0x00303760
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 313838, RefRangeEnd = 313842, XrefRangeStart = 313837, XrefRangeEnd = 313838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerSensitivitySlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerSensitivitySlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerSensitivitySlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC39 RID: 48185 RVA: 0x00057BDA File Offset: 0x00055DDA
		public PointerSensitivitySlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038D7 RID: 14551
		// (get) Token: 0x0600BC3A RID: 48186 RVA: 0x0030559C File Offset: 0x0030379C
		// (set) Token: 0x0600BC3B RID: 48187 RVA: 0x00057BE3 File Offset: 0x00055DE3
		public unsafe static float MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PointerSensitivitySlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerSensitivitySlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x040080F8 RID: 33016
		private static readonly IntPtr NativeFieldInfoPtr_MULTIPLIER;

		// Token: 0x040080F9 RID: 33017
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040080FA RID: 33018
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0;

		// Token: 0x040080FB RID: 33019
		private static readonly IntPtr NativeMethodInfoPtr_MapSensitivity_Private_Single_Single_0;

		// Token: 0x040080FC RID: 33020
		private static readonly IntPtr NativeMethodInfoPtr_InverseMapSensitivity_Private_Single_Single_0;

		// Token: 0x040080FD RID: 33021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
