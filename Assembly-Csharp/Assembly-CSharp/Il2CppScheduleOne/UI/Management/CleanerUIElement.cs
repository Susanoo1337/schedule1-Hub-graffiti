using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007E7 RID: 2023
	public class CleanerUIElement : WorldspaceUIElement
	{
		// Token: 0x0600C5B1 RID: 50609 RVA: 0x00322010 File Offset: 0x00320210
		// Note: this type is marked as 'beforefieldinit'.
		static CleanerUIElement()
		{
			Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "CleanerUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr);
			CleanerUIElement.NativeFieldInfoPtr_StationsIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, "StationsIcons");
			CleanerUIElement.NativeFieldInfoPtr__AssignedCleaner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, "<AssignedCleaner>k__BackingField");
			CleanerUIElement.NativeMethodInfoPtr_get_AssignedCleaner_Public_get_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100688913);
			CleanerUIElement.NativeMethodInfoPtr_set_AssignedCleaner_Protected_set_Void_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100688914);
			CleanerUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100688915);
			CleanerUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100688916);
			CleanerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100688917);
		}

		// Token: 0x17003C05 RID: 15365
		// (get) Token: 0x0600C5B2 RID: 50610 RVA: 0x003220CC File Offset: 0x003202CC
		// (set) Token: 0x0600C5B3 RID: 50611 RVA: 0x0032210C File Offset: 0x0032030C
		public unsafe Cleaner AssignedCleaner
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerUIElement.NativeMethodInfoPtr_get_AssignedCleaner_Public_get_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerUIElement.NativeMethodInfoPtr_set_AssignedCleaner_Protected_set_Void_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C5B4 RID: 50612 RVA: 0x00322150 File Offset: 0x00320350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327225, RefRangeEnd = 327226, XrefRangeStart = 327214, XrefRangeEnd = 327225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Cleaner cleaner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cleaner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5B5 RID: 50613 RVA: 0x00322194 File Offset: 0x00320394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327226, XrefRangeEnd = 327238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5B6 RID: 50614 RVA: 0x003221D0 File Offset: 0x003203D0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanerUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5B7 RID: 50615 RVA: 0x0005D553 File Offset: 0x0005B753
		public CleanerUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C03 RID: 15363
		// (get) Token: 0x0600C5B8 RID: 50616 RVA: 0x0032220C File Offset: 0x0032040C
		// (set) Token: 0x0600C5B9 RID: 50617 RVA: 0x0005D55C File Offset: 0x0005B75C
		public unsafe Il2CppReferenceArray<Image> StationsIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerUIElement.NativeFieldInfoPtr_StationsIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerUIElement.NativeFieldInfoPtr_StationsIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C04 RID: 15364
		// (get) Token: 0x0600C5BA RID: 50618 RVA: 0x0032223C File Offset: 0x0032043C
		// (set) Token: 0x0600C5BB RID: 50619 RVA: 0x0005D57B File Offset: 0x0005B77B
		public unsafe Cleaner _AssignedCleaner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerUIElement.NativeFieldInfoPtr__AssignedCleaner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerUIElement.NativeFieldInfoPtr__AssignedCleaner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040086E5 RID: 34533
		private static readonly IntPtr NativeFieldInfoPtr_StationsIcons;

		// Token: 0x040086E6 RID: 34534
		private static readonly IntPtr NativeFieldInfoPtr__AssignedCleaner_k__BackingField;

		// Token: 0x040086E7 RID: 34535
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedCleaner_Public_get_Cleaner_0;

		// Token: 0x040086E8 RID: 34536
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedCleaner_Protected_set_Void_Cleaner_0;

		// Token: 0x040086E9 RID: 34537
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Cleaner_0;

		// Token: 0x040086EA RID: 34538
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040086EB RID: 34539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
