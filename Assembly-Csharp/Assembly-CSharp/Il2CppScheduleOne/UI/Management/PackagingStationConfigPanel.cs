using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007CE RID: 1998
	public class PackagingStationConfigPanel : ConfigPanel
	{
		// Token: 0x0600C359 RID: 50009 RVA: 0x0031A970 File Offset: 0x00318B70
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStationConfigPanel()
		{
			Il2CppClassPointerStore<PackagingStationConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PackagingStationConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationConfigPanel>.NativeClassPtr);
			PackagingStationConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationConfigPanel>.NativeClassPtr, "DestinationUI");
			PackagingStationConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfigPanel>.NativeClassPtr, 100688653);
			PackagingStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfigPanel>.NativeClassPtr, 100688654);
		}

		// Token: 0x0600C35A RID: 50010 RVA: 0x0031A9DC File Offset: 0x00318BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323322, XrefRangeEnd = 323357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BindInternal(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C35B RID: 50011 RVA: 0x0031AA2C File Offset: 0x00318C2C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStationConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C35C RID: 50012 RVA: 0x0005C097 File Offset: 0x0005A297
		public PackagingStationConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B47 RID: 15175
		// (get) Token: 0x0600C35D RID: 50013 RVA: 0x0031AA68 File Offset: 0x00318C68
		// (set) Token: 0x0600C35E RID: 50014 RVA: 0x0005C0A0 File Offset: 0x0005A2A0
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008568 RID: 34152
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04008569 RID: 34153
		private static readonly IntPtr NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x0400856A RID: 34154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
