using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020007F6 RID: 2038
	public class ImportScreen : MenuScreen
	{
		// Token: 0x0600C66B RID: 50795 RVA: 0x003245EC File Offset: 0x003227EC
		// Note: this type is marked as 'beforefieldinit'.
		static ImportScreen()
		{
			Il2CppClassPointerStore<ImportScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "ImportScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr);
			ImportScreen.NativeFieldInfoPtr_MainContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "MainContainer");
			ImportScreen.NativeFieldInfoPtr_FailContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "FailContainer");
			ImportScreen.NativeFieldInfoPtr_ConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "ConfirmButton");
			ImportScreen.NativeFieldInfoPtr_OrganisationNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "OrganisationNameLabel");
			ImportScreen.NativeFieldInfoPtr_NetworthLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "NetworthLabel");
			ImportScreen.NativeFieldInfoPtr_VersionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "VersionLabel");
			ImportScreen.NativeFieldInfoPtr_WarningLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "WarningLabel");
			ImportScreen.NativeFieldInfoPtr_slotToOverwrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "slotToOverwrite");
			ImportScreen.NativeFieldInfoPtr_saveInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "saveInfo");
			ImportScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_MenuScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, 100689006);
			ImportScreen.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, 100689007);
			ImportScreen.NativeMethodInfoPtr_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, 100689008);
			ImportScreen.NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, 100689009);
			ImportScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, 100689010);
		}

		// Token: 0x0600C66C RID: 50796 RVA: 0x00324734 File Offset: 0x00322934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327750, RefRangeEnd = 327751, XrefRangeStart = 327712, XrefRangeEnd = 327750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int _slotToOverwrite, MenuScreen previousScreen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _slotToOverwrite;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(previousScreen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImportScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_MenuScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C66D RID: 50797 RVA: 0x00324784 File Offset: 0x00322984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327751, XrefRangeEnd = 327753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImportScreen.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C66E RID: 50798 RVA: 0x003247B8 File Offset: 0x003229B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327753, XrefRangeEnd = 327794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImportScreen.NativeMethodInfoPtr_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C66F RID: 50799 RVA: 0x003247EC File Offset: 0x003229EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327794, XrefRangeEnd = 327809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyFilesRecursively(string sourcePath, string targetPath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sourcePath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImportScreen.NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C670 RID: 50800 RVA: 0x00324834 File Offset: 0x00322A34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327636, RefRangeEnd = 327637, XrefRangeStart = 327636, XrefRangeEnd = 327637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImportScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImportScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C671 RID: 50801 RVA: 0x0005DA84 File Offset: 0x0005BC84
		public ImportScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C37 RID: 15415
		// (get) Token: 0x0600C672 RID: 50802 RVA: 0x00324870 File Offset: 0x00322A70
		// (set) Token: 0x0600C673 RID: 50803 RVA: 0x0005DA8D File Offset: 0x0005BC8D
		public unsafe GameObject MainContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_MainContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_MainContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C38 RID: 15416
		// (get) Token: 0x0600C674 RID: 50804 RVA: 0x003248A0 File Offset: 0x00322AA0
		// (set) Token: 0x0600C675 RID: 50805 RVA: 0x0005DAAC File Offset: 0x0005BCAC
		public unsafe GameObject FailContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_FailContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_FailContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C39 RID: 15417
		// (get) Token: 0x0600C676 RID: 50806 RVA: 0x003248D0 File Offset: 0x00322AD0
		// (set) Token: 0x0600C677 RID: 50807 RVA: 0x0005DACB File Offset: 0x0005BCCB
		public unsafe Button ConfirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_ConfirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_ConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C3A RID: 15418
		// (get) Token: 0x0600C678 RID: 50808 RVA: 0x00324900 File Offset: 0x00322B00
		// (set) Token: 0x0600C679 RID: 50809 RVA: 0x0005DAEA File Offset: 0x0005BCEA
		public unsafe TextMeshProUGUI OrganisationNameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_OrganisationNameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_OrganisationNameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C3B RID: 15419
		// (get) Token: 0x0600C67A RID: 50810 RVA: 0x00324930 File Offset: 0x00322B30
		// (set) Token: 0x0600C67B RID: 50811 RVA: 0x0005DB09 File Offset: 0x0005BD09
		public unsafe TextMeshProUGUI NetworthLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_NetworthLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_NetworthLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C3C RID: 15420
		// (get) Token: 0x0600C67C RID: 50812 RVA: 0x00324960 File Offset: 0x00322B60
		// (set) Token: 0x0600C67D RID: 50813 RVA: 0x0005DB28 File Offset: 0x0005BD28
		public unsafe TextMeshProUGUI VersionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_VersionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_VersionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C3D RID: 15421
		// (get) Token: 0x0600C67E RID: 50814 RVA: 0x00324990 File Offset: 0x00322B90
		// (set) Token: 0x0600C67F RID: 50815 RVA: 0x0005DB47 File Offset: 0x0005BD47
		public unsafe TextMeshProUGUI WarningLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_WarningLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_WarningLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C3E RID: 15422
		// (get) Token: 0x0600C680 RID: 50816 RVA: 0x003249C0 File Offset: 0x00322BC0
		// (set) Token: 0x0600C681 RID: 50817 RVA: 0x0005DB66 File Offset: 0x0005BD66
		public unsafe int slotToOverwrite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_slotToOverwrite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_slotToOverwrite)) = value;
			}
		}

		// Token: 0x17003C3F RID: 15423
		// (get) Token: 0x0600C682 RID: 50818 RVA: 0x003249E8 File Offset: 0x00322BE8
		// (set) Token: 0x0600C683 RID: 50819 RVA: 0x0005DB81 File Offset: 0x0005BD81
		public unsafe SaveInfo saveInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_saveInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_saveInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008759 RID: 34649
		private static readonly IntPtr NativeFieldInfoPtr_MainContainer;

		// Token: 0x0400875A RID: 34650
		private static readonly IntPtr NativeFieldInfoPtr_FailContainer;

		// Token: 0x0400875B RID: 34651
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmButton;

		// Token: 0x0400875C RID: 34652
		private static readonly IntPtr NativeFieldInfoPtr_OrganisationNameLabel;

		// Token: 0x0400875D RID: 34653
		private static readonly IntPtr NativeFieldInfoPtr_NetworthLabel;

		// Token: 0x0400875E RID: 34654
		private static readonly IntPtr NativeFieldInfoPtr_VersionLabel;

		// Token: 0x0400875F RID: 34655
		private static readonly IntPtr NativeFieldInfoPtr_WarningLabel;

		// Token: 0x04008760 RID: 34656
		private static readonly IntPtr NativeFieldInfoPtr_slotToOverwrite;

		// Token: 0x04008761 RID: 34657
		private static readonly IntPtr NativeFieldInfoPtr_saveInfo;

		// Token: 0x04008762 RID: 34658
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_MenuScreen_0;

		// Token: 0x04008763 RID: 34659
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x04008764 RID: 34660
		private static readonly IntPtr NativeMethodInfoPtr_Confirm_Public_Void_0;

		// Token: 0x04008765 RID: 34661
		private static readonly IntPtr NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0;

		// Token: 0x04008766 RID: 34662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
