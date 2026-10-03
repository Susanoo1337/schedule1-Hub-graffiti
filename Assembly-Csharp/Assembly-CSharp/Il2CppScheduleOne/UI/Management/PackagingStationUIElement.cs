using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007ED RID: 2029
	public class PackagingStationUIElement : WorldspaceUIElement
	{
		// Token: 0x0600C5F7 RID: 50679 RVA: 0x00322EC0 File Offset: 0x003210C0
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStationUIElement()
		{
			Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PackagingStationUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr);
			PackagingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, "<AssignedStation>k__BackingField");
			PackagingStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100688943);
			PackagingStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100688944);
			PackagingStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100688945);
			PackagingStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100688946);
			PackagingStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100688947);
		}

		// Token: 0x17003C18 RID: 15384
		// (get) Token: 0x0600C5F8 RID: 50680 RVA: 0x00322F68 File Offset: 0x00321168
		// (set) Token: 0x0600C5F9 RID: 50681 RVA: 0x00322FA8 File Offset: 0x003211A8
		public unsafe PackagingStation AssignedStation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C5FA RID: 50682 RVA: 0x00322FEC File Offset: 0x003211EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327387, RefRangeEnd = 327388, XrefRangeStart = 327377, XrefRangeEnd = 327387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(PackagingStation pack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5FB RID: 50683 RVA: 0x00323030 File Offset: 0x00321230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327388, XrefRangeEnd = 327393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5FC RID: 50684 RVA: 0x0032306C File Offset: 0x0032126C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStationUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C5FD RID: 50685 RVA: 0x0005D73B File Offset: 0x0005B93B
		public PackagingStationUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C17 RID: 15383
		// (get) Token: 0x0600C5FE RID: 50686 RVA: 0x003230A8 File Offset: 0x003212A8
		// (set) Token: 0x0600C5FF RID: 50687 RVA: 0x0005D744 File Offset: 0x0005B944
		public unsafe PackagingStation _AssignedStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008711 RID: 34577
		private static readonly IntPtr NativeFieldInfoPtr__AssignedStation_k__BackingField;

		// Token: 0x04008712 RID: 34578
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedStation_Public_get_PackagingStation_0;

		// Token: 0x04008713 RID: 34579
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_PackagingStation_0;

		// Token: 0x04008714 RID: 34580
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PackagingStation_0;

		// Token: 0x04008715 RID: 34581
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04008716 RID: 34582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
