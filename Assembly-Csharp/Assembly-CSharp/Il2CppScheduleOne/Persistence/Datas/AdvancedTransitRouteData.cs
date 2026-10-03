using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200021C RID: 540
	[Serializable]
	public class AdvancedTransitRouteData : Object
	{
		// Token: 0x06002E72 RID: 11890 RVA: 0x00115D98 File Offset: 0x00113F98
		// Note: this type is marked as 'beforefieldinit'.
		static AdvancedTransitRouteData()
		{
			Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "AdvancedTransitRouteData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr);
			AdvancedTransitRouteData.NativeFieldInfoPtr_SourceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, "SourceGUID");
			AdvancedTransitRouteData.NativeFieldInfoPtr_DestinationGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, "DestinationGUID");
			AdvancedTransitRouteData.NativeFieldInfoPtr_FilterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, "FilterMode");
			AdvancedTransitRouteData.NativeFieldInfoPtr_FilterItemIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, "FilterItemIDs");
			AdvancedTransitRouteData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EMode_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, 100669376);
			AdvancedTransitRouteData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, 100669377);
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x00115E40 File Offset: 0x00114040
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134787, RefRangeEnd = 134788, XrefRangeStart = 134783, XrefRangeEnd = 134787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRouteData(string sourceGUID, string destinationGUID, ManagementItemFilter.EMode filtermode, List<string> filterGUIDs) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destinationGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filtermode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterGUIDs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRouteData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EMode_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x00115EC0 File Offset: 0x001140C0
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRouteData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRouteData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x0001791C File Offset: 0x00015B1C
		public AdvancedTransitRouteData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06002E76 RID: 11894 RVA: 0x00115EFC File Offset: 0x001140FC
		// (set) Token: 0x06002E77 RID: 11895 RVA: 0x00017925 File Offset: 0x00015B25
		public unsafe string SourceGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_SourceGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_SourceGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06002E78 RID: 11896 RVA: 0x00115F24 File Offset: 0x00114124
		// (set) Token: 0x06002E79 RID: 11897 RVA: 0x00017944 File Offset: 0x00015B44
		public unsafe string DestinationGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_DestinationGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_DestinationGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06002E7A RID: 11898 RVA: 0x00115F4C File Offset: 0x0011414C
		// (set) Token: 0x06002E7B RID: 11899 RVA: 0x00017963 File Offset: 0x00015B63
		public unsafe ManagementItemFilter.EMode FilterMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_FilterMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_FilterMode)) = value;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06002E7C RID: 11900 RVA: 0x00115F74 File Offset: 0x00114174
		// (set) Token: 0x06002E7D RID: 11901 RVA: 0x0001797E File Offset: 0x00015B7E
		public unsafe List<string> FilterItemIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_FilterItemIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_FilterItemIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FA7 RID: 8103
		private static readonly IntPtr NativeFieldInfoPtr_SourceGUID;

		// Token: 0x04001FA8 RID: 8104
		private static readonly IntPtr NativeFieldInfoPtr_DestinationGUID;

		// Token: 0x04001FA9 RID: 8105
		private static readonly IntPtr NativeFieldInfoPtr_FilterMode;

		// Token: 0x04001FAA RID: 8106
		private static readonly IntPtr NativeFieldInfoPtr_FilterItemIDs;

		// Token: 0x04001FAB RID: 8107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_EMode_List_1_String_0;

		// Token: 0x04001FAC RID: 8108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
