using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSteamworks;
using Il2CppSystem;

namespace Il2CppScheduleOne
{
	// Token: 0x0200009B RID: 155
	public static class OnScreenKeyboard : Object
	{
		// Token: 0x06000D47 RID: 3399 RVA: 0x000A7B20 File Offset: 0x000A5D20
		// Note: this type is marked as 'beforefieldinit'.
		static OnScreenKeyboard()
		{
			Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "OnScreenKeyboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr);
			OnScreenKeyboard.NativeFieldInfoPtr_ExitCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr, "ExitCooldown");
			OnScreenKeyboard.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr, "<IsOpen>k__BackingField");
			OnScreenKeyboard.NativeFieldInfoPtr__TimeOnLastClose_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr, "<TimeOnLastClose>k__BackingField");
			OnScreenKeyboard.NativeFieldInfoPtr_s_charLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr, "s_charLimit");
			OnScreenKeyboard.NativeFieldInfoPtr_s_onSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr, "s_onSubmit");
			OnScreenKeyboard.NativeFieldInfoPtr_s_onCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr, "s_onCancel");
			OnScreenKeyboard.NativeFieldInfoPtr_s_onGamepadTextInputDismissed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr, "s_onGamepadTextInputDismissed");
			OnScreenKeyboard.NativeMethodInfoPtr_get_IsOpen_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr, 100664983);
			OnScreenKeyboard.NativeMethodInfoPtr_set_IsOpen_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr, 100664984);
			OnScreenKeyboard.NativeMethodInfoPtr_get_TimeOnLastClose_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr, 100664985);
			OnScreenKeyboard.NativeMethodInfoPtr_set_TimeOnLastClose_Private_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr, 100664986);
			OnScreenKeyboard.NativeMethodInfoPtr_Show_Public_Static_Void_Action_1_String_Action_String_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr, 100664987);
			OnScreenKeyboard.NativeMethodInfoPtr_Exit_Private_Static_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr, 100664988);
			OnScreenKeyboard.NativeMethodInfoPtr_Hide_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr, 100664989);
			OnScreenKeyboard.NativeMethodInfoPtr_OnGamepadTextInputDismissed_Private_Static_Void_GamepadTextInputDismissed_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr, 100664990);
			OnScreenKeyboard.NativeMethodInfoPtr_OnHide_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr, 100664991);
			OnScreenKeyboard.NativeMethodInfoPtr_IsOSKAvailable_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenKeyboard>.NativeClassPtr, 100664992);
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x000A7CA4 File Offset: 0x000A5EA4
		// (set) Token: 0x06000D49 RID: 3401 RVA: 0x000A7CD4 File Offset: 0x000A5ED4
		public unsafe static bool IsOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79648, XrefRangeEnd = 79652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenKeyboard.NativeMethodInfoPtr_get_IsOpen_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79652, XrefRangeEnd = 79656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenKeyboard.NativeMethodInfoPtr_set_IsOpen_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x000A7D08 File Offset: 0x000A5F08
		// (set) Token: 0x06000D4B RID: 3403 RVA: 0x000A7D38 File Offset: 0x000A5F38
		public unsafe static float TimeOnLastClose
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79656, XrefRangeEnd = 79660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenKeyboard.NativeMethodInfoPtr_get_TimeOnLastClose_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79660, XrefRangeEnd = 79664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenKeyboard.NativeMethodInfoPtr_set_TimeOnLastClose_Private_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x000A7D6C File Offset: 0x000A5F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79727, RefRangeEnd = 79728, XrefRangeStart = 79664, XrefRangeEnd = 79727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Show(Action<string> onSubmit, Action onCancel = null, string description = "", uint charMax = 32U, string defaultText = "")
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onSubmit);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onCancel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charMax;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenKeyboard.NativeMethodInfoPtr_Show_Public_Static_Void_Action_1_String_Action_String_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x000A7DE8 File Offset: 0x000A5FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79728, XrefRangeEnd = 79758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Exit(ExitAction exit)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenKeyboard.NativeMethodInfoPtr_Exit_Private_Static_Void_ExitAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x000A7E20 File Offset: 0x000A6020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79758, XrefRangeEnd = 79778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Hide()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenKeyboard.NativeMethodInfoPtr_Hide_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x000A7E48 File Offset: 0x000A6048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79778, XrefRangeEnd = 79793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnGamepadTextInputDismissed(GamepadTextInputDismissed_t param)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref param;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenKeyboard.NativeMethodInfoPtr_OnGamepadTextInputDismissed_Private_Static_Void_GamepadTextInputDismissed_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x000A7E7C File Offset: 0x000A607C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 79836, RefRangeEnd = 79839, XrefRangeStart = 79793, XrefRangeEnd = 79836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnHide()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenKeyboard.NativeMethodInfoPtr_OnHide_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x000A7EA4 File Offset: 0x000A60A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 79861, RefRangeEnd = 79865, XrefRangeStart = 79839, XrefRangeEnd = 79861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOSKAvailable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenKeyboard.NativeMethodInfoPtr_IsOSKAvailable_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00008142 File Offset: 0x00006342
		public OnScreenKeyboard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x000A7ED4 File Offset: 0x000A60D4
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x0000814B File Offset: 0x0000634B
		public unsafe static float ExitCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(OnScreenKeyboard.NativeFieldInfoPtr_ExitCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OnScreenKeyboard.NativeFieldInfoPtr_ExitCooldown, (void*)(&value));
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x000A7EF0 File Offset: 0x000A60F0
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x00008159 File Offset: 0x00006359
		public unsafe static bool _IsOpen_k__BackingField
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(OnScreenKeyboard.NativeFieldInfoPtr__IsOpen_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OnScreenKeyboard.NativeFieldInfoPtr__IsOpen_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x000A7F0C File Offset: 0x000A610C
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x00008167 File Offset: 0x00006367
		public unsafe static float _TimeOnLastClose_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(OnScreenKeyboard.NativeFieldInfoPtr__TimeOnLastClose_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OnScreenKeyboard.NativeFieldInfoPtr__TimeOnLastClose_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x000A7F28 File Offset: 0x000A6128
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x00008175 File Offset: 0x00006375
		public unsafe static uint s_charLimit
		{
			get
			{
				uint result;
				IL2CPP.il2cpp_field_static_get_value(OnScreenKeyboard.NativeFieldInfoPtr_s_charLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OnScreenKeyboard.NativeFieldInfoPtr_s_charLimit, (void*)(&value));
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x000A7F44 File Offset: 0x000A6144
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x00008183 File Offset: 0x00006383
		public unsafe static Action<string> s_onSubmit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OnScreenKeyboard.NativeFieldInfoPtr_s_onSubmit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OnScreenKeyboard.NativeFieldInfoPtr_s_onSubmit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x000A7F6C File Offset: 0x000A616C
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x00008195 File Offset: 0x00006395
		public unsafe static Action s_onCancel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OnScreenKeyboard.NativeFieldInfoPtr_s_onCancel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OnScreenKeyboard.NativeFieldInfoPtr_s_onCancel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x000A7F94 File Offset: 0x000A6194
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x000081A7 File Offset: 0x000063A7
		public unsafe static Callback<GamepadTextInputDismissed_t> s_onGamepadTextInputDismissed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OnScreenKeyboard.NativeFieldInfoPtr_s_onGamepadTextInputDismissed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<GamepadTextInputDismissed_t>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OnScreenKeyboard.NativeFieldInfoPtr_s_onGamepadTextInputDismissed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeFieldInfoPtr_ExitCooldown;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeFieldInfoPtr__TimeOnLastClose_k__BackingField;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeFieldInfoPtr_s_charLimit;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeFieldInfoPtr_s_onSubmit;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeFieldInfoPtr_s_onCancel;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeFieldInfoPtr_s_onGamepadTextInputDismissed;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_Static_get_Boolean_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_Static_set_Void_Boolean_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeOnLastClose_Public_Static_get_Single_0;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeOnLastClose_Private_Static_set_Void_Single_0;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Static_Void_Action_1_String_Action_String_UInt32_String_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Static_Void_ExitAction_0;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Static_Void_0;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeMethodInfoPtr_OnGamepadTextInputDismissed_Private_Static_Void_GamepadTextInputDismissed_t_0;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Private_Static_Void_0;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_IsOSKAvailable_Public_Static_Boolean_0;
	}
}
