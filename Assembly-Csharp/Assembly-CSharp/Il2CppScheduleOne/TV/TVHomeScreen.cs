using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000105 RID: 261
	public class TVHomeScreen : TVApp
	{
		// Token: 0x06001950 RID: 6480 RVA: 0x000CE67C File Offset: 0x000CC87C
		// Note: this type is marked as 'beforefieldinit'.
		static TVHomeScreen()
		{
			Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "TVHomeScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr);
			TVHomeScreen.NativeFieldInfoPtr_Interface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "Interface");
			TVHomeScreen.NativeFieldInfoPtr_Apps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "Apps");
			TVHomeScreen.NativeFieldInfoPtr_AppButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "AppButtonContainer");
			TVHomeScreen.NativeFieldInfoPtr_PlayerDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "PlayerDisplays");
			TVHomeScreen.NativeFieldInfoPtr_TimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "TimeLabel");
			TVHomeScreen.NativeFieldInfoPtr_AppButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "AppButtonPrefab");
			TVHomeScreen.NativeFieldInfoPtr_skipExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "skipExit");
			TVHomeScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666674);
			TVHomeScreen.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666675);
			TVHomeScreen.NativeMethodInfoPtr_OnClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666676);
			TVHomeScreen.NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666677);
			TVHomeScreen.NativeMethodInfoPtr_UpdateTimeLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666678);
			TVHomeScreen.NativeMethodInfoPtr_AppSelected_Private_Void_TVApp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666679);
			TVHomeScreen.NativeMethodInfoPtr_PlayerChange_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666680);
			TVHomeScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, 100666681);
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x000CE7D8 File Offset: 0x000CC9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98890, XrefRangeEnd = 98948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVHomeScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x000CE814 File Offset: 0x000CCA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98948, XrefRangeEnd = 98950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVHomeScreen.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x000CE850 File Offset: 0x000CCA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98950, XrefRangeEnd = 98952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVHomeScreen.NativeMethodInfoPtr_OnClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x000CE88C File Offset: 0x000CCA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98952, XrefRangeEnd = 98953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVHomeScreen.NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x000CE8C8 File Offset: 0x000CCAC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98962, RefRangeEnd = 98964, XrefRangeStart = 98953, XrefRangeEnd = 98962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.NativeMethodInfoPtr_UpdateTimeLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x000CE8FC File Offset: 0x000CCAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98964, XrefRangeEnd = 98966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppSelected(TVApp app)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(app);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.NativeMethodInfoPtr_AppSelected_Private_Void_TVApp_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x000CE940 File Offset: 0x000CCB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98966, XrefRangeEnd = 98982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerChange(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.NativeMethodInfoPtr_PlayerChange_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x000CE984 File Offset: 0x000CCB84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 98871, RefRangeEnd = 98874, XrefRangeStart = 98871, XrefRangeEnd = 98874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TVHomeScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x0000DED9 File Offset: 0x0000C0D9
		public TVHomeScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x000CE9C0 File Offset: 0x000CCBC0
		// (set) Token: 0x0600195B RID: 6491 RVA: 0x0000DEE2 File Offset: 0x0000C0E2
		public unsafe TVInterface Interface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_Interface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_Interface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x000CE9F0 File Offset: 0x000CCBF0
		// (set) Token: 0x0600195D RID: 6493 RVA: 0x0000DF01 File Offset: 0x0000C101
		public unsafe Il2CppReferenceArray<TVApp> Apps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_Apps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TVApp>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_Apps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x000CEA20 File Offset: 0x000CCC20
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x0000DF20 File Offset: 0x0000C120
		public unsafe RectTransform AppButtonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_AppButtonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_AppButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x000CEA50 File Offset: 0x000CCC50
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x0000DF3F File Offset: 0x0000C13F
		public unsafe Il2CppReferenceArray<RectTransform> PlayerDisplays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_PlayerDisplays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_PlayerDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x000CEA80 File Offset: 0x000CCC80
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x0000DF5E File Offset: 0x0000C15E
		public unsafe TextMeshProUGUI TimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_TimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_TimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x000CEAB0 File Offset: 0x000CCCB0
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x0000DF7D File Offset: 0x0000C17D
		public unsafe GameObject AppButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_AppButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_AppButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x000CEAE0 File Offset: 0x000CCCE0
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x0000DF9C File Offset: 0x0000C19C
		public unsafe bool skipExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_skipExit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.NativeFieldInfoPtr_skipExit)) = value;
			}
		}

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeFieldInfoPtr_Interface;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeFieldInfoPtr_Apps;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeFieldInfoPtr_AppButtonContainer;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeFieldInfoPtr_PlayerDisplays;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeFieldInfoPtr_TimeLabel;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeFieldInfoPtr_AppButtonPrefab;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeFieldInfoPtr_skipExit;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Protected_Virtual_Void_0;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_Void_0;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeLabel_Private_Void_0;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr_AppSelected_Private_Void_TVApp_0;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_PlayerChange_Private_Void_Player_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000940 RID: 2368
		[ObfuscatedName("ScheduleOne.TV.TVHomeScreen+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D82F RID: 55343 RVA: 0x0035BCC4 File Offset: 0x00359EC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TVHomeScreen>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr);
				TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr_app = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr, "app");
				TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				TVHomeScreen.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr, 100666682);
				TVHomeScreen.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr, 100666683);
			}

			// Token: 0x0600D830 RID: 55344 RVA: 0x0035BD40 File Offset: 0x00359F40
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVHomeScreen.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D831 RID: 55345 RVA: 0x0035BD7C File Offset: 0x00359F7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98879, XrefRangeEnd = 98890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVHomeScreen.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D832 RID: 55346 RVA: 0x00065A59 File Offset: 0x00063C59
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004206 RID: 16902
			// (get) Token: 0x0600D833 RID: 55347 RVA: 0x0035BDB0 File Offset: 0x00359FB0
			// (set) Token: 0x0600D834 RID: 55348 RVA: 0x00065A62 File Offset: 0x00063C62
			public unsafe TVApp app
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr_app);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr_app), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004207 RID: 16903
			// (get) Token: 0x0600D835 RID: 55349 RVA: 0x0035BDE0 File Offset: 0x00359FE0
			// (set) Token: 0x0600D836 RID: 55350 RVA: 0x00065A81 File Offset: 0x00063C81
			public unsafe TVHomeScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVHomeScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVHomeScreen.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009376 RID: 37750
			private static readonly IntPtr NativeFieldInfoPtr_app;

			// Token: 0x04009377 RID: 37751
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009378 RID: 37752
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009379 RID: 37753
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}
	}
}
