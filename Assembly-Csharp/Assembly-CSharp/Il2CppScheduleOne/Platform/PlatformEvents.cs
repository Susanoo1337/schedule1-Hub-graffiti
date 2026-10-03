using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSteamworks;
using Il2CppSystem;

namespace Il2CppScheduleOne.Platform
{
	// Token: 0x020001A5 RID: 421
	public static class PlatformEvents : Object
	{
		// Token: 0x06002A4C RID: 10828 RVA: 0x00106B30 File Offset: 0x00104D30
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformEvents()
		{
			Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Platform", "PlatformEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr);
			PlatformEvents.NativeFieldInfoPtr_OnOverlayActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr, "OnOverlayActivated");
			PlatformEvents.NativeFieldInfoPtr_OnOverlayDeactivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr, "OnOverlayDeactivated");
			PlatformEvents.NativeFieldInfoPtr_OnGameLoseFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr, "OnGameLoseFocus");
			PlatformEvents.NativeFieldInfoPtr_OnGameGainFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr, "OnGameGainFocus");
			PlatformEvents.NativeMethodInfoPtr_add_OnOverlayActivated_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr, 100668696);
			PlatformEvents.NativeMethodInfoPtr_remove_OnOverlayActivated_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr, 100668697);
			PlatformEvents.NativeMethodInfoPtr_add_OnOverlayDeactivated_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr, 100668698);
			PlatformEvents.NativeMethodInfoPtr_remove_OnOverlayDeactivated_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr, 100668699);
			PlatformEvents.NativeMethodInfoPtr_add_OnGameLoseFocus_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr, 100668700);
			PlatformEvents.NativeMethodInfoPtr_remove_OnGameLoseFocus_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr, 100668701);
			PlatformEvents.NativeMethodInfoPtr_add_OnGameGainFocus_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr, 100668702);
			PlatformEvents.NativeMethodInfoPtr_remove_OnGameGainFocus_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr, 100668703);
			PlatformEvents.NativeMethodInfoPtr_InitFocusCallback_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr, 100668704);
			PlatformEvents.NativeMethodInfoPtr_OnApplicationFocusChanged_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr, 100668705);
			PlatformEvents.NativeMethodInfoPtr_InitOverlayCallback_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr, 100668706);
			PlatformEvents.NativeMethodInfoPtr_OverlayActivated_Private_Static_Void_GameOverlayActivated_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformEvents>.NativeClassPtr, 100668707);
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x00106CA0 File Offset: 0x00104EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124111, RefRangeEnd = 124112, XrefRangeStart = 124104, XrefRangeEnd = 124111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnOverlayActivated(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformEvents.NativeMethodInfoPtr_add_OnOverlayActivated_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x00106CD8 File Offset: 0x00104ED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124119, RefRangeEnd = 124120, XrefRangeStart = 124112, XrefRangeEnd = 124119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnOverlayActivated(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformEvents.NativeMethodInfoPtr_remove_OnOverlayActivated_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x00106D10 File Offset: 0x00104F10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124127, RefRangeEnd = 124128, XrefRangeStart = 124120, XrefRangeEnd = 124127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnOverlayDeactivated(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformEvents.NativeMethodInfoPtr_add_OnOverlayDeactivated_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x00106D48 File Offset: 0x00104F48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124135, RefRangeEnd = 124136, XrefRangeStart = 124128, XrefRangeEnd = 124135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnOverlayDeactivated(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformEvents.NativeMethodInfoPtr_remove_OnOverlayDeactivated_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x00106D80 File Offset: 0x00104F80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124143, RefRangeEnd = 124144, XrefRangeStart = 124136, XrefRangeEnd = 124143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnGameLoseFocus(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformEvents.NativeMethodInfoPtr_add_OnGameLoseFocus_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x00106DB8 File Offset: 0x00104FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124151, RefRangeEnd = 124152, XrefRangeStart = 124144, XrefRangeEnd = 124151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnGameLoseFocus(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformEvents.NativeMethodInfoPtr_remove_OnGameLoseFocus_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x00106DF0 File Offset: 0x00104FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124152, XrefRangeEnd = 124159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnGameGainFocus(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformEvents.NativeMethodInfoPtr_add_OnGameGainFocus_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x00106E28 File Offset: 0x00105028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124159, XrefRangeEnd = 124166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnGameGainFocus(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformEvents.NativeMethodInfoPtr_remove_OnGameGainFocus_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x00106E60 File Offset: 0x00105060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124166, XrefRangeEnd = 124176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitFocusCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformEvents.NativeMethodInfoPtr_InitFocusCallback_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x00106E88 File Offset: 0x00105088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124176, XrefRangeEnd = 124186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnApplicationFocusChanged(bool hasFocus)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hasFocus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformEvents.NativeMethodInfoPtr_OnApplicationFocusChanged_Private_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x00106EBC File Offset: 0x001050BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124186, XrefRangeEnd = 124208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitOverlayCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformEvents.NativeMethodInfoPtr_InitOverlayCallback_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x00106EE4 File Offset: 0x001050E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124208, XrefRangeEnd = 124222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OverlayActivated(GameOverlayActivated_t pCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pCallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformEvents.NativeMethodInfoPtr_OverlayActivated_Private_Static_Void_GameOverlayActivated_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x000161C0 File Offset: 0x000143C0
		public PlatformEvents(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x00106F18 File Offset: 0x00105118
		// (set) Token: 0x06002A5B RID: 10843 RVA: 0x000161C9 File Offset: 0x000143C9
		public unsafe static Action OnOverlayActivated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlatformEvents.NativeFieldInfoPtr_OnOverlayActivated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformEvents.NativeFieldInfoPtr_OnOverlayActivated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x00106F40 File Offset: 0x00105140
		// (set) Token: 0x06002A5D RID: 10845 RVA: 0x000161DB File Offset: 0x000143DB
		public unsafe static Action OnOverlayDeactivated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlatformEvents.NativeFieldInfoPtr_OnOverlayDeactivated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformEvents.NativeFieldInfoPtr_OnOverlayDeactivated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x00106F68 File Offset: 0x00105168
		// (set) Token: 0x06002A5F RID: 10847 RVA: 0x000161ED File Offset: 0x000143ED
		public unsafe static Action OnGameLoseFocus
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlatformEvents.NativeFieldInfoPtr_OnGameLoseFocus, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformEvents.NativeFieldInfoPtr_OnGameLoseFocus, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x00106F90 File Offset: 0x00105190
		// (set) Token: 0x06002A61 RID: 10849 RVA: 0x000161FF File Offset: 0x000143FF
		public unsafe static Action OnGameGainFocus
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlatformEvents.NativeFieldInfoPtr_OnGameGainFocus, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformEvents.NativeFieldInfoPtr_OnGameGainFocus, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D15 RID: 7445
		private static readonly IntPtr NativeFieldInfoPtr_OnOverlayActivated;

		// Token: 0x04001D16 RID: 7446
		private static readonly IntPtr NativeFieldInfoPtr_OnOverlayDeactivated;

		// Token: 0x04001D17 RID: 7447
		private static readonly IntPtr NativeFieldInfoPtr_OnGameLoseFocus;

		// Token: 0x04001D18 RID: 7448
		private static readonly IntPtr NativeFieldInfoPtr_OnGameGainFocus;

		// Token: 0x04001D19 RID: 7449
		private static readonly IntPtr NativeMethodInfoPtr_add_OnOverlayActivated_Public_Static_add_Void_Action_0;

		// Token: 0x04001D1A RID: 7450
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnOverlayActivated_Public_Static_rem_Void_Action_0;

		// Token: 0x04001D1B RID: 7451
		private static readonly IntPtr NativeMethodInfoPtr_add_OnOverlayDeactivated_Public_Static_add_Void_Action_0;

		// Token: 0x04001D1C RID: 7452
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnOverlayDeactivated_Public_Static_rem_Void_Action_0;

		// Token: 0x04001D1D RID: 7453
		private static readonly IntPtr NativeMethodInfoPtr_add_OnGameLoseFocus_Public_Static_add_Void_Action_0;

		// Token: 0x04001D1E RID: 7454
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnGameLoseFocus_Public_Static_rem_Void_Action_0;

		// Token: 0x04001D1F RID: 7455
		private static readonly IntPtr NativeMethodInfoPtr_add_OnGameGainFocus_Public_Static_add_Void_Action_0;

		// Token: 0x04001D20 RID: 7456
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnGameGainFocus_Public_Static_rem_Void_Action_0;

		// Token: 0x04001D21 RID: 7457
		private static readonly IntPtr NativeMethodInfoPtr_InitFocusCallback_Private_Static_Void_0;

		// Token: 0x04001D22 RID: 7458
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocusChanged_Private_Static_Void_Boolean_0;

		// Token: 0x04001D23 RID: 7459
		private static readonly IntPtr NativeMethodInfoPtr_InitOverlayCallback_Private_Static_Void_0;

		// Token: 0x04001D24 RID: 7460
		private static readonly IntPtr NativeMethodInfoPtr_OverlayActivated_Private_Static_Void_GameOverlayActivated_t_0;
	}
}
