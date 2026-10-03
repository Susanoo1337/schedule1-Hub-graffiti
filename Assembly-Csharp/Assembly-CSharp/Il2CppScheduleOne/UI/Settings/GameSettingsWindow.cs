using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x0200078D RID: 1933
	public class GameSettingsWindow : MonoBehaviour
	{
		// Token: 0x0600BBEB RID: 48107 RVA: 0x00304470 File Offset: 0x00302670
		// Note: this type is marked as 'beforefieldinit'.
		static GameSettingsWindow()
		{
			Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "GameSettingsWindow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr);
			GameSettingsWindow.NativeFieldInfoPtr_ConsoleToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, "ConsoleToggle");
			GameSettingsWindow.NativeFieldInfoPtr_RandomMixMapsToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, "RandomMixMapsToggle");
			GameSettingsWindow.NativeFieldInfoPtr_Blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, "Blocker");
			GameSettingsWindow.NativeFieldInfoPtr_uiPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, "uiPanel");
			GameSettingsWindow.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100687809);
			GameSettingsWindow.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100687810);
			GameSettingsWindow.NativeMethodInfoPtr_ApplySettings_Public_Void_GameSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100687811);
			GameSettingsWindow.NativeMethodInfoPtr_ConsoleToggled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100687812);
			GameSettingsWindow.NativeMethodInfoPtr_RandomMixMapsToggled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100687813);
			GameSettingsWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr, 100687814);
		}

		// Token: 0x0600BBEC RID: 48108 RVA: 0x00304568 File Offset: 0x00302768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313478, XrefRangeEnd = 313495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBED RID: 48109 RVA: 0x0030459C File Offset: 0x0030279C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313495, XrefRangeEnd = 313505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBEE RID: 48110 RVA: 0x003045D0 File Offset: 0x003027D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313505, XrefRangeEnd = 313508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySettings(GameSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr_ApplySettings_Public_Void_GameSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBEF RID: 48111 RVA: 0x00304614 File Offset: 0x00302814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313508, XrefRangeEnd = 313512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsoleToggled(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr_ConsoleToggled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBF0 RID: 48112 RVA: 0x00304654 File Offset: 0x00302854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313512, XrefRangeEnd = 313516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomMixMapsToggled(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr_RandomMixMapsToggled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBF1 RID: 48113 RVA: 0x00304694 File Offset: 0x00302894
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSettingsWindow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSettingsWindow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettingsWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBF2 RID: 48114 RVA: 0x00057A7D File Offset: 0x00055C7D
		public GameSettingsWindow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038CC RID: 14540
		// (get) Token: 0x0600BBF3 RID: 48115 RVA: 0x003046D0 File Offset: 0x003028D0
		// (set) Token: 0x0600BBF4 RID: 48116 RVA: 0x00057A86 File Offset: 0x00055C86
		public unsafe UIToggle ConsoleToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_ConsoleToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_ConsoleToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038CD RID: 14541
		// (get) Token: 0x0600BBF5 RID: 48117 RVA: 0x00304700 File Offset: 0x00302900
		// (set) Token: 0x0600BBF6 RID: 48118 RVA: 0x00057AA5 File Offset: 0x00055CA5
		public unsafe UIToggle RandomMixMapsToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_RandomMixMapsToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_RandomMixMapsToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038CE RID: 14542
		// (get) Token: 0x0600BBF7 RID: 48119 RVA: 0x00304730 File Offset: 0x00302930
		// (set) Token: 0x0600BBF8 RID: 48120 RVA: 0x00057AC4 File Offset: 0x00055CC4
		public unsafe GameObject Blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_Blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_Blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038CF RID: 14543
		// (get) Token: 0x0600BBF9 RID: 48121 RVA: 0x00304760 File Offset: 0x00302960
		// (set) Token: 0x0600BBFA RID: 48122 RVA: 0x00057AE3 File Offset: 0x00055CE3
		public unsafe UIPanel uiPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_uiPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettingsWindow.NativeFieldInfoPtr_uiPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040080C9 RID: 32969
		private static readonly IntPtr NativeFieldInfoPtr_ConsoleToggle;

		// Token: 0x040080CA RID: 32970
		private static readonly IntPtr NativeFieldInfoPtr_RandomMixMapsToggle;

		// Token: 0x040080CB RID: 32971
		private static readonly IntPtr NativeFieldInfoPtr_Blocker;

		// Token: 0x040080CC RID: 32972
		private static readonly IntPtr NativeFieldInfoPtr_uiPanel;

		// Token: 0x040080CD RID: 32973
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040080CE RID: 32974
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040080CF RID: 32975
		private static readonly IntPtr NativeMethodInfoPtr_ApplySettings_Public_Void_GameSettings_0;

		// Token: 0x040080D0 RID: 32976
		private static readonly IntPtr NativeMethodInfoPtr_ConsoleToggled_Private_Void_Boolean_0;

		// Token: 0x040080D1 RID: 32977
		private static readonly IntPtr NativeMethodInfoPtr_RandomMixMapsToggled_Private_Void_Boolean_0;

		// Token: 0x040080D2 RID: 32978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
