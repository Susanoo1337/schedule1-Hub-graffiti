using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007EC RID: 2028
	public class PackagerUIElement : WorldspaceUIElement
	{
		// Token: 0x0600C5EC RID: 50668 RVA: 0x00322C64 File Offset: 0x00320E64
		// Note: this type is marked as 'beforefieldinit'.
		static PackagerUIElement()
		{
			Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PackagerUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr);
			PackagerUIElement.NativeFieldInfoPtr_StationRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, "StationRects");
			PackagerUIElement.NativeFieldInfoPtr__AssignedPackager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, "<AssignedPackager>k__BackingField");
			PackagerUIElement.NativeMethodInfoPtr_get_AssignedPackager_Public_get_Packager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100688938);
			PackagerUIElement.NativeMethodInfoPtr_set_AssignedPackager_Protected_set_Void_Packager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100688939);
			PackagerUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Packager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100688940);
			PackagerUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100688941);
			PackagerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100688942);
		}

		// Token: 0x17003C16 RID: 15382
		// (get) Token: 0x0600C5ED RID: 50669 RVA: 0x00322D20 File Offset: 0x00320F20
		// (set) Token: 0x0600C5EE RID: 50670 RVA: 0x00322D60 File Offset: 0x00320F60
		public unsafe Packager AssignedPackager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerUIElement.NativeMethodInfoPtr_get_AssignedPackager_Public_get_Packager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerUIElement.NativeMethodInfoPtr_set_AssignedPackager_Protected_set_Void_Packager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C5EF RID: 50671 RVA: 0x00322DA4 File Offset: 0x00320FA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327352, RefRangeEnd = 327353, XrefRangeStart = 327341, XrefRangeEnd = 327352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Packager packager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(packager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Packager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5F0 RID: 50672 RVA: 0x00322DE8 File Offset: 0x00320FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327353, XrefRangeEnd = 327377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagerUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5F1 RID: 50673 RVA: 0x00322E24 File Offset: 0x00321024
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagerUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5F2 RID: 50674 RVA: 0x0005D6F4 File Offset: 0x0005B8F4
		public PackagerUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C14 RID: 15380
		// (get) Token: 0x0600C5F3 RID: 50675 RVA: 0x00322E60 File Offset: 0x00321060
		// (set) Token: 0x0600C5F4 RID: 50676 RVA: 0x0005D6FD File Offset: 0x0005B8FD
		public unsafe Il2CppReferenceArray<RectTransform> StationRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerUIElement.NativeFieldInfoPtr_StationRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerUIElement.NativeFieldInfoPtr_StationRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C15 RID: 15381
		// (get) Token: 0x0600C5F5 RID: 50677 RVA: 0x00322E90 File Offset: 0x00321090
		// (set) Token: 0x0600C5F6 RID: 50678 RVA: 0x0005D71C File Offset: 0x0005B91C
		public unsafe Packager _AssignedPackager_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerUIElement.NativeFieldInfoPtr__AssignedPackager_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerUIElement.NativeFieldInfoPtr__AssignedPackager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400870A RID: 34570
		private static readonly IntPtr NativeFieldInfoPtr_StationRects;

		// Token: 0x0400870B RID: 34571
		private static readonly IntPtr NativeFieldInfoPtr__AssignedPackager_k__BackingField;

		// Token: 0x0400870C RID: 34572
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedPackager_Public_get_Packager_0;

		// Token: 0x0400870D RID: 34573
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedPackager_Protected_set_Void_Packager_0;

		// Token: 0x0400870E RID: 34574
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Packager_0;

		// Token: 0x0400870F RID: 34575
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04008710 RID: 34576
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
