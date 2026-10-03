using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Gamepad
{
	// Token: 0x020006EF RID: 1775
	[Serializable]
	public class GamepadSettings : Object
	{
		// Token: 0x0600AB1B RID: 43803 RVA: 0x002D2350 File Offset: 0x002D0550
		// Note: this type is marked as 'beforefieldinit'.
		static GamepadSettings()
		{
			Il2CppClassPointerStore<GamepadSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Gamepad", "GamepadSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadSettings>.NativeClassPtr);
			GamepadSettings.NativeFieldInfoPtr_GamepadCameraSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSettings>.NativeClassPtr, "GamepadCameraSensitivity");
			GamepadSettings.NativeFieldInfoPtr_PointerSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSettings>.NativeClassPtr, "PointerSensitivity");
			GamepadSettings.NativeFieldInfoPtr_DEFAULT_SENSITIVITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSettings>.NativeClassPtr, "DEFAULT_SENSITIVITY");
			GamepadSettings.NativeFieldInfoPtr_MIN_SENSITIVITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSettings>.NativeClassPtr, "MIN_SENSITIVITY");
			GamepadSettings.NativeFieldInfoPtr_MAX_SENSITIVITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadSettings>.NativeClassPtr, "MAX_SENSITIVITY");
			GamepadSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadSettings>.NativeClassPtr, 100685959);
		}

		// Token: 0x0600AB1C RID: 43804 RVA: 0x002D23F8 File Offset: 0x002D05F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 294849, RefRangeEnd = 294852, XrefRangeStart = 294848, XrefRangeEnd = 294849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamepadSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB1D RID: 43805 RVA: 0x0004E06F File Offset: 0x0004C26F
		public GamepadSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003330 RID: 13104
		// (get) Token: 0x0600AB1E RID: 43806 RVA: 0x002D2434 File Offset: 0x002D0634
		// (set) Token: 0x0600AB1F RID: 43807 RVA: 0x0004E078 File Offset: 0x0004C278
		public unsafe float GamepadCameraSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSettings.NativeFieldInfoPtr_GamepadCameraSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSettings.NativeFieldInfoPtr_GamepadCameraSensitivity)) = value;
			}
		}

		// Token: 0x17003331 RID: 13105
		// (get) Token: 0x0600AB20 RID: 43808 RVA: 0x002D245C File Offset: 0x002D065C
		// (set) Token: 0x0600AB21 RID: 43809 RVA: 0x0004E093 File Offset: 0x0004C293
		public unsafe float PointerSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSettings.NativeFieldInfoPtr_PointerSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadSettings.NativeFieldInfoPtr_PointerSensitivity)) = value;
			}
		}

		// Token: 0x17003332 RID: 13106
		// (get) Token: 0x0600AB22 RID: 43810 RVA: 0x002D2484 File Offset: 0x002D0684
		// (set) Token: 0x0600AB23 RID: 43811 RVA: 0x0004E0AE File Offset: 0x0004C2AE
		public unsafe static float DEFAULT_SENSITIVITY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GamepadSettings.NativeFieldInfoPtr_DEFAULT_SENSITIVITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadSettings.NativeFieldInfoPtr_DEFAULT_SENSITIVITY, (void*)(&value));
			}
		}

		// Token: 0x17003333 RID: 13107
		// (get) Token: 0x0600AB24 RID: 43812 RVA: 0x002D24A0 File Offset: 0x002D06A0
		// (set) Token: 0x0600AB25 RID: 43813 RVA: 0x0004E0BC File Offset: 0x0004C2BC
		public unsafe static float MIN_SENSITIVITY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GamepadSettings.NativeFieldInfoPtr_MIN_SENSITIVITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadSettings.NativeFieldInfoPtr_MIN_SENSITIVITY, (void*)(&value));
			}
		}

		// Token: 0x17003334 RID: 13108
		// (get) Token: 0x0600AB26 RID: 43814 RVA: 0x002D24BC File Offset: 0x002D06BC
		// (set) Token: 0x0600AB27 RID: 43815 RVA: 0x0004E0CA File Offset: 0x0004C2CA
		public unsafe static float MAX_SENSITIVITY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GamepadSettings.NativeFieldInfoPtr_MAX_SENSITIVITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GamepadSettings.NativeFieldInfoPtr_MAX_SENSITIVITY, (void*)(&value));
			}
		}

		// Token: 0x0400763C RID: 30268
		private static readonly IntPtr NativeFieldInfoPtr_GamepadCameraSensitivity;

		// Token: 0x0400763D RID: 30269
		private static readonly IntPtr NativeFieldInfoPtr_PointerSensitivity;

		// Token: 0x0400763E RID: 30270
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_SENSITIVITY;

		// Token: 0x0400763F RID: 30271
		private static readonly IntPtr NativeFieldInfoPtr_MIN_SENSITIVITY;

		// Token: 0x04007640 RID: 30272
		private static readonly IntPtr NativeFieldInfoPtr_MAX_SENSITIVITY;

		// Token: 0x04007641 RID: 30273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
