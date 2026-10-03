using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200022D RID: 557
	[Serializable]
	public class PackagingStationConfigurationData : RenamableConfigurationData
	{
		// Token: 0x06002EEA RID: 12010 RVA: 0x00117200 File Offset: 0x00115400
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStationConfigurationData()
		{
			Il2CppClassPointerStore<PackagingStationConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PackagingStationConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationConfigurationData>.NativeClassPtr);
			PackagingStationConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationConfigurationData>.NativeClassPtr, "Destination");
			PackagingStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfigurationData>.NativeClassPtr, 100669394);
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x00117258 File Offset: 0x00115458
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 134800, RefRangeEnd = 134812, XrefRangeStart = 134800, XrefRangeEnd = 134812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStationConfigurationData(StringFieldData name, ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x00017DCB File Offset: 0x00015FCB
		public PackagingStationConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06002EED RID: 12013 RVA: 0x001172B8 File Offset: 0x001154B8
		// (set) Token: 0x06002EEE RID: 12014 RVA: 0x00017DD4 File Offset: 0x00015FD4
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FDB RID: 8155
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001FDC RID: 8156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ObjectFieldData_0;
	}
}
