using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x02000800 RID: 2048
	public class SetupScreen : MenuScreen
	{
		// Token: 0x0600C6FD RID: 50941 RVA: 0x00326184 File Offset: 0x00324384
		// Note: this type is marked as 'beforefieldinit'.
		static SetupScreen()
		{
			Il2CppClassPointerStore<SetupScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "SetupScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr);
			SetupScreen.NativeFieldInfoPtr_DEFAULT_SAVE_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "DEFAULT_SAVE_PATH");
			SetupScreen.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "InputField");
			SetupScreen.NativeFieldInfoPtr_StartButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "StartButton");
			SetupScreen.NativeFieldInfoPtr_SkipIntroContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "SkipIntroContainer");
			SetupScreen.NativeFieldInfoPtr_SkipIntroToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "SkipIntroToggle");
			SetupScreen.NativeFieldInfoPtr_NotHostWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "NotHostWarning");
			SetupScreen.NativeFieldInfoPtr_slotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "slotIndex");
			SetupScreen.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100689067);
			SetupScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100689068);
			SetupScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100689069);
			SetupScreen.NativeMethodInfoPtr_StartGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100689070);
			SetupScreen.NativeMethodInfoPtr_IsInputValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100689071);
			SetupScreen.NativeMethodInfoPtr_ClearFolderContents_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100689072);
			SetupScreen.NativeMethodInfoPtr_CopyDefaultSaveToFolder_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100689073);
			SetupScreen.NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100689074);
			SetupScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100689075);
			SetupScreen.NativeMethodInfoPtr__Start_b__7_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100689076);
		}

		// Token: 0x0600C6FE RID: 50942 RVA: 0x00326308 File Offset: 0x00324508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328468, XrefRangeEnd = 328480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetupScreen.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6FF RID: 50943 RVA: 0x00326344 File Offset: 0x00324544
		[CallerCount(0)]
		public unsafe void Initialize(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C700 RID: 50944 RVA: 0x00326384 File Offset: 0x00324584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328480, XrefRangeEnd = 328493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C701 RID: 50945 RVA: 0x003263B8 File Offset: 0x003245B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328575, RefRangeEnd = 328576, XrefRangeStart = 328493, XrefRangeEnd = 328575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_StartGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C702 RID: 50946 RVA: 0x003263EC File Offset: 0x003245EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328576, XrefRangeEnd = 328577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInputValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_IsInputValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C703 RID: 50947 RVA: 0x00326428 File Offset: 0x00324628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328577, XrefRangeEnd = 328586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFolderContents(string folderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(folderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_ClearFolderContents_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C704 RID: 50948 RVA: 0x0032646C File Offset: 0x0032466C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328611, RefRangeEnd = 328612, XrefRangeStart = 328586, XrefRangeEnd = 328611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyDefaultSaveToFolder(string folderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(folderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_CopyDefaultSaveToFolder_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C705 RID: 50949 RVA: 0x003264B0 File Offset: 0x003246B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328612, XrefRangeEnd = 328627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyFilesRecursively(string sourcePath, string targetPath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sourcePath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C706 RID: 50950 RVA: 0x003264F8 File Offset: 0x003246F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327636, RefRangeEnd = 327637, XrefRangeStart = 327636, XrefRangeEnd = 327637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetupScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C707 RID: 50951 RVA: 0x00326534 File Offset: 0x00324734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328627, XrefRangeEnd = 328628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__7_0(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr__Start_b__7_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C708 RID: 50952 RVA: 0x0005DF0E File Offset: 0x0005C10E
		public SetupScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C5F RID: 15455
		// (get) Token: 0x0600C709 RID: 50953 RVA: 0x00326578 File Offset: 0x00324778
		// (set) Token: 0x0600C70A RID: 50954 RVA: 0x0005DF17 File Offset: 0x0005C117
		public unsafe static string DEFAULT_SAVE_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SetupScreen.NativeFieldInfoPtr_DEFAULT_SAVE_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SetupScreen.NativeFieldInfoPtr_DEFAULT_SAVE_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003C60 RID: 15456
		// (get) Token: 0x0600C70B RID: 50955 RVA: 0x00326598 File Offset: 0x00324798
		// (set) Token: 0x0600C70C RID: 50956 RVA: 0x0005DF29 File Offset: 0x0005C129
		public unsafe TMP_InputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C61 RID: 15457
		// (get) Token: 0x0600C70D RID: 50957 RVA: 0x003265C8 File Offset: 0x003247C8
		// (set) Token: 0x0600C70E RID: 50958 RVA: 0x0005DF48 File Offset: 0x0005C148
		public unsafe Button StartButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_StartButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_StartButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C62 RID: 15458
		// (get) Token: 0x0600C70F RID: 50959 RVA: 0x003265F8 File Offset: 0x003247F8
		// (set) Token: 0x0600C710 RID: 50960 RVA: 0x0005DF67 File Offset: 0x0005C167
		public unsafe RectTransform SkipIntroContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_SkipIntroContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_SkipIntroContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C63 RID: 15459
		// (get) Token: 0x0600C711 RID: 50961 RVA: 0x00326628 File Offset: 0x00324828
		// (set) Token: 0x0600C712 RID: 50962 RVA: 0x0005DF86 File Offset: 0x0005C186
		public unsafe Toggle SkipIntroToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_SkipIntroToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_SkipIntroToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C64 RID: 15460
		// (get) Token: 0x0600C713 RID: 50963 RVA: 0x00326658 File Offset: 0x00324858
		// (set) Token: 0x0600C714 RID: 50964 RVA: 0x0005DFA5 File Offset: 0x0005C1A5
		public unsafe RectTransform NotHostWarning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_NotHostWarning);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_NotHostWarning), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C65 RID: 15461
		// (get) Token: 0x0600C715 RID: 50965 RVA: 0x00326688 File Offset: 0x00324888
		// (set) Token: 0x0600C716 RID: 50966 RVA: 0x0005DFC4 File Offset: 0x0005C1C4
		public unsafe int slotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_slotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_slotIndex)) = value;
			}
		}

		// Token: 0x040087B2 RID: 34738
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_SAVE_PATH;

		// Token: 0x040087B3 RID: 34739
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x040087B4 RID: 34740
		private static readonly IntPtr NativeFieldInfoPtr_StartButton;

		// Token: 0x040087B5 RID: 34741
		private static readonly IntPtr NativeFieldInfoPtr_SkipIntroContainer;

		// Token: 0x040087B6 RID: 34742
		private static readonly IntPtr NativeFieldInfoPtr_SkipIntroToggle;

		// Token: 0x040087B7 RID: 34743
		private static readonly IntPtr NativeFieldInfoPtr_NotHostWarning;

		// Token: 0x040087B8 RID: 34744
		private static readonly IntPtr NativeFieldInfoPtr_slotIndex;

		// Token: 0x040087B9 RID: 34745
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040087BA RID: 34746
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_0;

		// Token: 0x040087BB RID: 34747
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040087BC RID: 34748
		private static readonly IntPtr NativeMethodInfoPtr_StartGame_Public_Void_0;

		// Token: 0x040087BD RID: 34749
		private static readonly IntPtr NativeMethodInfoPtr_IsInputValid_Private_Boolean_0;

		// Token: 0x040087BE RID: 34750
		private static readonly IntPtr NativeMethodInfoPtr_ClearFolderContents_Private_Void_String_0;

		// Token: 0x040087BF RID: 34751
		private static readonly IntPtr NativeMethodInfoPtr_CopyDefaultSaveToFolder_Private_Void_String_0;

		// Token: 0x040087C0 RID: 34752
		private static readonly IntPtr NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0;

		// Token: 0x040087C1 RID: 34753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040087C2 RID: 34754
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__7_0_Private_Void_String_0;
	}
}
