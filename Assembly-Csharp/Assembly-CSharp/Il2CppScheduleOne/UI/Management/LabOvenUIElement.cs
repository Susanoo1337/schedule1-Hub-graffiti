using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007E9 RID: 2025
	public class LabOvenUIElement : WorldspaceUIElement
	{
		// Token: 0x0600C5C7 RID: 50631 RVA: 0x003224C8 File Offset: 0x003206C8
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenUIElement()
		{
			Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "LabOvenUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr);
			LabOvenUIElement.NativeFieldInfoPtr__AssignedOven_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, "<AssignedOven>k__BackingField");
			LabOvenUIElement.NativeMethodInfoPtr_get_AssignedOven_Public_get_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100688923);
			LabOvenUIElement.NativeMethodInfoPtr_set_AssignedOven_Protected_set_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100688924);
			LabOvenUIElement.NativeMethodInfoPtr_Initialize_Public_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100688925);
			LabOvenUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100688926);
			LabOvenUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100688927);
		}

		// Token: 0x17003C0A RID: 15370
		// (get) Token: 0x0600C5C8 RID: 50632 RVA: 0x00322570 File Offset: 0x00320770
		// (set) Token: 0x0600C5C9 RID: 50633 RVA: 0x003225B0 File Offset: 0x003207B0
		public unsafe LabOven AssignedOven
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenUIElement.NativeMethodInfoPtr_get_AssignedOven_Public_get_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenUIElement.NativeMethodInfoPtr_set_AssignedOven_Protected_set_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C5CA RID: 50634 RVA: 0x003225F4 File Offset: 0x003207F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327268, RefRangeEnd = 327269, XrefRangeStart = 327258, XrefRangeEnd = 327268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(LabOven oven)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenUIElement.NativeMethodInfoPtr_Initialize_Public_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5CB RID: 50635 RVA: 0x00322638 File Offset: 0x00320838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327269, XrefRangeEnd = 327274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5CC RID: 50636 RVA: 0x00322674 File Offset: 0x00320874
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5CD RID: 50637 RVA: 0x0005D5E1 File Offset: 0x0005B7E1
		public LabOvenUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C09 RID: 15369
		// (get) Token: 0x0600C5CE RID: 50638 RVA: 0x003226B0 File Offset: 0x003208B0
		// (set) Token: 0x0600C5CF RID: 50639 RVA: 0x0005D5EA File Offset: 0x0005B7EA
		public unsafe LabOven _AssignedOven_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenUIElement.NativeFieldInfoPtr__AssignedOven_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenUIElement.NativeFieldInfoPtr__AssignedOven_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040086F3 RID: 34547
		private static readonly IntPtr NativeFieldInfoPtr__AssignedOven_k__BackingField;

		// Token: 0x040086F4 RID: 34548
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedOven_Public_get_LabOven_0;

		// Token: 0x040086F5 RID: 34549
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedOven_Protected_set_Void_LabOven_0;

		// Token: 0x040086F6 RID: 34550
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_LabOven_0;

		// Token: 0x040086F7 RID: 34551
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040086F8 RID: 34552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
