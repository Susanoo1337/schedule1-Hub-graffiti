using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.Settings;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x02000801 RID: 2049
	public class SettingsScreen : MenuScreen
	{
		// Token: 0x0600C717 RID: 50967 RVA: 0x003266B0 File Offset: 0x003248B0
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsScreen()
		{
			Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "SettingsScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr);
			SettingsScreen.NativeFieldInfoPtr_Categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "Categories");
			SettingsScreen.NativeFieldInfoPtr_ApplyDisplayButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "ApplyDisplayButton");
			SettingsScreen.NativeFieldInfoPtr_ConfirmDisplaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "ConfirmDisplaySettings");
			SettingsScreen.NativeFieldInfoPtr_ActiveDisplaySelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "ActiveDisplaySelection");
			SettingsScreen.NativeFieldInfoPtr_HostOnlyGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "HostOnlyGameObjects");
			SettingsScreen.NativeFieldInfoPtr_Tab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "Tab");
			SettingsScreen.NativeFieldInfoPtr__initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "_initialized");
			SettingsScreen.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100689077);
			SettingsScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100689078);
			SettingsScreen.NativeMethodInfoPtr_OnOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100689079);
			SettingsScreen.NativeMethodInfoPtr_ShowCategory_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100689080);
			SettingsScreen.NativeMethodInfoPtr_ApplyDisplaySettings_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100689081);
			SettingsScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100689082);
		}

		// Token: 0x0600C718 RID: 50968 RVA: 0x003267E4 File Offset: 0x003249E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328642, XrefRangeEnd = 328660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C719 RID: 50969 RVA: 0x00326818 File Offset: 0x00324A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328660, XrefRangeEnd = 328668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C71A RID: 50970 RVA: 0x00326854 File Offset: 0x00324A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328668, XrefRangeEnd = 328672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsScreen.NativeMethodInfoPtr_OnOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C71B RID: 50971 RVA: 0x00326890 File Offset: 0x00324A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328672, XrefRangeEnd = 328675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowCategory(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr_ShowCategory_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C71C RID: 50972 RVA: 0x003268D0 File Offset: 0x00324AD0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 328703, RefRangeEnd = 328712, XrefRangeStart = 328675, XrefRangeEnd = 328703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDisplaySettings(bool showRevertMenu)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref showRevertMenu;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr_ApplyDisplaySettings_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C71D RID: 50973 RVA: 0x00326910 File Offset: 0x00324B10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327636, RefRangeEnd = 327637, XrefRangeStart = 327636, XrefRangeEnd = 327637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C71E RID: 50974 RVA: 0x0005DFDF File Offset: 0x0005C1DF
		public SettingsScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C66 RID: 15462
		// (get) Token: 0x0600C71F RID: 50975 RVA: 0x0032694C File Offset: 0x00324B4C
		// (set) Token: 0x0600C720 RID: 50976 RVA: 0x0005DFE8 File Offset: 0x0005C1E8
		public unsafe Il2CppReferenceArray<SettingsScreen.SettingsCategory> Categories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_Categories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SettingsScreen.SettingsCategory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_Categories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C67 RID: 15463
		// (get) Token: 0x0600C721 RID: 50977 RVA: 0x0032697C File Offset: 0x00324B7C
		// (set) Token: 0x0600C722 RID: 50978 RVA: 0x0005E007 File Offset: 0x0005C207
		public unsafe Button ApplyDisplayButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ApplyDisplayButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ApplyDisplayButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C68 RID: 15464
		// (get) Token: 0x0600C723 RID: 50979 RVA: 0x003269AC File Offset: 0x00324BAC
		// (set) Token: 0x0600C724 RID: 50980 RVA: 0x0005E026 File Offset: 0x0005C226
		public unsafe ConfirmDisplaySettings ConfirmDisplaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ConfirmDisplaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmDisplaySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ConfirmDisplaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C69 RID: 15465
		// (get) Token: 0x0600C725 RID: 50981 RVA: 0x003269DC File Offset: 0x00324BDC
		// (set) Token: 0x0600C726 RID: 50982 RVA: 0x0005E045 File Offset: 0x0005C245
		public unsafe GameObject ActiveDisplaySelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ActiveDisplaySelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ActiveDisplaySelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C6A RID: 15466
		// (get) Token: 0x0600C727 RID: 50983 RVA: 0x00326A0C File Offset: 0x00324C0C
		// (set) Token: 0x0600C728 RID: 50984 RVA: 0x0005E064 File Offset: 0x0005C264
		public unsafe Il2CppReferenceArray<GameObject> HostOnlyGameObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_HostOnlyGameObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_HostOnlyGameObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C6B RID: 15467
		// (get) Token: 0x0600C729 RID: 50985 RVA: 0x00326A3C File Offset: 0x00324C3C
		// (set) Token: 0x0600C72A RID: 50986 RVA: 0x0005E083 File Offset: 0x0005C283
		public unsafe UITab Tab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_Tab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UITab>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_Tab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C6C RID: 15468
		// (get) Token: 0x0600C72B RID: 50987 RVA: 0x00326A6C File Offset: 0x00324C6C
		// (set) Token: 0x0600C72C RID: 50988 RVA: 0x0005E0A2 File Offset: 0x0005C2A2
		public unsafe bool _initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr__initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr__initialized)) = value;
			}
		}

		// Token: 0x040087C3 RID: 34755
		private static readonly IntPtr NativeFieldInfoPtr_Categories;

		// Token: 0x040087C4 RID: 34756
		private static readonly IntPtr NativeFieldInfoPtr_ApplyDisplayButton;

		// Token: 0x040087C5 RID: 34757
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmDisplaySettings;

		// Token: 0x040087C6 RID: 34758
		private static readonly IntPtr NativeFieldInfoPtr_ActiveDisplaySelection;

		// Token: 0x040087C7 RID: 34759
		private static readonly IntPtr NativeFieldInfoPtr_HostOnlyGameObjects;

		// Token: 0x040087C8 RID: 34760
		private static readonly IntPtr NativeFieldInfoPtr_Tab;

		// Token: 0x040087C9 RID: 34761
		private static readonly IntPtr NativeFieldInfoPtr__initialized;

		// Token: 0x040087CA RID: 34762
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040087CB RID: 34763
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040087CC RID: 34764
		private static readonly IntPtr NativeMethodInfoPtr_OnOpen_Protected_Virtual_Void_0;

		// Token: 0x040087CD RID: 34765
		private static readonly IntPtr NativeMethodInfoPtr_ShowCategory_Public_Void_Int32_0;

		// Token: 0x040087CE RID: 34766
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDisplaySettings_Public_Void_Boolean_0;

		// Token: 0x040087CF RID: 34767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D6A RID: 3434
		[Serializable]
		public class SettingsCategory : Il2CppSystem.Object
		{
			// Token: 0x0600FB2A RID: 64298 RVA: 0x003BFAD4 File Offset: 0x003BDCD4
			// Note: this type is marked as 'beforefieldinit'.
			static SettingsCategory()
			{
				Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "SettingsCategory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr);
				SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr, "Toggle");
				SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr, "Panel");
				SettingsScreen.SettingsCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr, 100689083);
			}

			// Token: 0x0600FB2B RID: 64299 RVA: 0x003BFB3C File Offset: 0x003BDD3C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SettingsCategory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.SettingsCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FB2C RID: 64300 RVA: 0x00076D57 File Offset: 0x00074F57
			public SettingsCategory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C51 RID: 19537
			// (get) Token: 0x0600FB2D RID: 64301 RVA: 0x003BFB78 File Offset: 0x003BDD78
			// (set) Token: 0x0600FB2E RID: 64302 RVA: 0x00076D60 File Offset: 0x00074F60
			public unsafe Toggle Toggle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Toggle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C52 RID: 19538
			// (get) Token: 0x0600FB2F RID: 64303 RVA: 0x003BFBA8 File Offset: 0x003BDDA8
			// (set) Token: 0x0600FB30 RID: 64304 RVA: 0x00076D7F File Offset: 0x00074F7F
			public unsafe GameObject Panel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Panel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A973 RID: 43379
			private static readonly IntPtr NativeFieldInfoPtr_Toggle;

			// Token: 0x0400A974 RID: 43380
			private static readonly IntPtr NativeFieldInfoPtr_Panel;

			// Token: 0x0400A975 RID: 43381
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000D6B RID: 3435
		[ObfuscatedName("ScheduleOne.UI.MainMenu.SettingsScreen+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FB31 RID: 64305 RVA: 0x003BFBD8 File Offset: 0x003BDDD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0>.NativeClassPtr);
				SettingsScreen.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				SettingsScreen.__c__DisplayClass12_0.NativeFieldInfoPtr_old = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0>.NativeClassPtr, "old");
				SettingsScreen.__c__DisplayClass12_0.NativeFieldInfoPtr_unapplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0>.NativeClassPtr, "unapplied");
				SettingsScreen.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0>.NativeClassPtr, 100689084);
				SettingsScreen.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0>.NativeClassPtr, 100689085);
			}

			// Token: 0x0600FB32 RID: 64306 RVA: 0x003BFC68 File Offset: 0x003BDE68
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FB33 RID: 64307 RVA: 0x003BFCA4 File Offset: 0x003BDEA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328634, XrefRangeEnd = 328639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600FB34 RID: 64308 RVA: 0x00076D9E File Offset: 0x00074F9E
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C53 RID: 19539
			// (get) Token: 0x0600FB35 RID: 64309 RVA: 0x003BFCE4 File Offset: 0x003BDEE4
			// (set) Token: 0x0600FB36 RID: 64310 RVA: 0x00076DA7 File Offset: 0x00074FA7
			public unsafe SettingsScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C54 RID: 19540
			// (get) Token: 0x0600FB37 RID: 64311 RVA: 0x003BFD14 File Offset: 0x003BDF14
			// (set) Token: 0x0600FB38 RID: 64312 RVA: 0x00076DC6 File Offset: 0x00074FC6
			public unsafe DisplaySettings old
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass12_0.NativeFieldInfoPtr_old);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass12_0.NativeFieldInfoPtr_old)) = value;
				}
			}

			// Token: 0x17004C55 RID: 19541
			// (get) Token: 0x0600FB39 RID: 64313 RVA: 0x003BFD3C File Offset: 0x003BDF3C
			// (set) Token: 0x0600FB3A RID: 64314 RVA: 0x00076DE1 File Offset: 0x00074FE1
			public unsafe DisplaySettings unapplied
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass12_0.NativeFieldInfoPtr_unapplied);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass12_0.NativeFieldInfoPtr_unapplied)) = value;
				}
			}

			// Token: 0x0400A976 RID: 43382
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A977 RID: 43383
			private static readonly IntPtr NativeFieldInfoPtr_old;

			// Token: 0x0400A978 RID: 43384
			private static readonly IntPtr NativeFieldInfoPtr_unapplied;

			// Token: 0x0400A979 RID: 43385
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A97A RID: 43386
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E1B RID: 3611
			[ObfuscatedName("ScheduleOne.UI.MainMenu.SettingsScreen+<>c__DisplayClass12_0+<<ApplyDisplaySettings>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06010447 RID: 66631 RVA: 0x003DA44C File Offset: 0x003D864C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0>.NativeClassPtr, "<<ApplyDisplaySettings>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100689086);
					SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100689087);
					SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100689088);
					SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100689089);
					SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100689090);
					SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100689091);
				}

				// Token: 0x06010448 RID: 66632 RVA: 0x003DA52C File Offset: 0x003D872C
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010449 RID: 66633 RVA: 0x003DA574 File Offset: 0x003D8774
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601044A RID: 66634 RVA: 0x003DA5A8 File Offset: 0x003D87A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328628, XrefRangeEnd = 328629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004F9F RID: 20383
				// (get) Token: 0x0601044B RID: 66635 RVA: 0x003DA5E4 File Offset: 0x003D87E4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601044C RID: 66636 RVA: 0x003DA624 File Offset: 0x003D8824
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328629, XrefRangeEnd = 328634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004FA0 RID: 20384
				// (get) Token: 0x0601044D RID: 66637 RVA: 0x003DA658 File Offset: 0x003D8858
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601044E RID: 66638 RVA: 0x0007B860 File Offset: 0x00079A60
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004F9C RID: 20380
				// (get) Token: 0x0601044F RID: 66639 RVA: 0x003DA698 File Offset: 0x003D8898
				// (set) Token: 0x06010450 RID: 66640 RVA: 0x0007B869 File Offset: 0x00079A69
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004F9D RID: 20381
				// (get) Token: 0x06010451 RID: 66641 RVA: 0x003DA6C0 File Offset: 0x003D88C0
				// (set) Token: 0x06010452 RID: 66642 RVA: 0x0007B884 File Offset: 0x00079A84
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F9E RID: 20382
				// (get) Token: 0x06010453 RID: 66643 RVA: 0x003DA6F0 File Offset: 0x003D88F0
				// (set) Token: 0x06010454 RID: 66644 RVA: 0x0007B8A3 File Offset: 0x00079AA3
				public unsafe SettingsScreen.__c__DisplayClass12_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsScreen.__c__DisplayClass12_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AF17 RID: 44823
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AF18 RID: 44824
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AF19 RID: 44825
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AF1A RID: 44826
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AF1B RID: 44827
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AF1C RID: 44828
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AF1D RID: 44829
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AF1E RID: 44830
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AF1F RID: 44831
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D6C RID: 3436
		[ObfuscatedName("ScheduleOne.UI.MainMenu.SettingsScreen+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FB3B RID: 64315 RVA: 0x003BFD64 File Offset: 0x003BDF64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass8_0>.NativeClassPtr);
				SettingsScreen.__c__DisplayClass8_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass8_0>.NativeClassPtr, "index");
				SettingsScreen.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				SettingsScreen.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass8_0>.NativeClassPtr, 100689092);
				SettingsScreen.__c__DisplayClass8_0.NativeMethodInfoPtr__OnEnable_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass8_0>.NativeClassPtr, 100689093);
			}

			// Token: 0x0600FB3C RID: 64316 RVA: 0x003BFDE0 File Offset: 0x003BDFE0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FB3D RID: 64317 RVA: 0x003BFE1C File Offset: 0x003BE01C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328639, XrefRangeEnd = 328642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnEnable_b__0(bool on)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref on;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.__c__DisplayClass8_0.NativeMethodInfoPtr__OnEnable_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FB3E RID: 64318 RVA: 0x00076DFC File Offset: 0x00074FFC
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C56 RID: 19542
			// (get) Token: 0x0600FB3F RID: 64319 RVA: 0x003BFE5C File Offset: 0x003BE05C
			// (set) Token: 0x0600FB40 RID: 64320 RVA: 0x00076E05 File Offset: 0x00075005
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass8_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass8_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17004C57 RID: 19543
			// (get) Token: 0x0600FB41 RID: 64321 RVA: 0x003BFE84 File Offset: 0x003BE084
			// (set) Token: 0x0600FB42 RID: 64322 RVA: 0x00076E20 File Offset: 0x00075020
			public unsafe SettingsScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A97B RID: 43387
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x0400A97C RID: 43388
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A97D RID: 43389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A97E RID: 43390
			private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__0_Internal_Void_Boolean_0;
		}
	}
}
