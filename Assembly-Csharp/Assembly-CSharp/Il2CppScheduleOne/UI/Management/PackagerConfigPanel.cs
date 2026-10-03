using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007CD RID: 1997
	public class PackagerConfigPanel : ConfigPanel
	{
		// Token: 0x0600C34F RID: 49999 RVA: 0x0031A7C0 File Offset: 0x003189C0
		// Note: this type is marked as 'beforefieldinit'.
		static PackagerConfigPanel()
		{
			Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PackagerConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr);
			PackagerConfigPanel.NativeFieldInfoPtr_BedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, "BedUI");
			PackagerConfigPanel.NativeFieldInfoPtr_StationsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, "StationsUI");
			PackagerConfigPanel.NativeFieldInfoPtr_RoutesUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, "RoutesUI");
			PackagerConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, 100688651);
			PackagerConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, 100688652);
		}

		// Token: 0x0600C350 RID: 50000 RVA: 0x0031A854 File Offset: 0x00318A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323267, XrefRangeEnd = 323322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BindInternal(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagerConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C351 RID: 50001 RVA: 0x0031A8A4 File Offset: 0x00318AA4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagerConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C352 RID: 50002 RVA: 0x0005C031 File Offset: 0x0005A231
		public PackagerConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B44 RID: 15172
		// (get) Token: 0x0600C353 RID: 50003 RVA: 0x0031A8E0 File Offset: 0x00318AE0
		// (set) Token: 0x0600C354 RID: 50004 RVA: 0x0005C03A File Offset: 0x0005A23A
		public unsafe ObjectFieldUI BedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_BedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_BedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B45 RID: 15173
		// (get) Token: 0x0600C355 RID: 50005 RVA: 0x0031A910 File Offset: 0x00318B10
		// (set) Token: 0x0600C356 RID: 50006 RVA: 0x0005C059 File Offset: 0x0005A259
		public unsafe ObjectListFieldUI StationsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_StationsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_StationsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B46 RID: 15174
		// (get) Token: 0x0600C357 RID: 50007 RVA: 0x0031A940 File Offset: 0x00318B40
		// (set) Token: 0x0600C358 RID: 50008 RVA: 0x0005C078 File Offset: 0x0005A278
		public unsafe RouteListFieldUI RoutesUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_RoutesUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RouteListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_RoutesUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008563 RID: 34147
		private static readonly IntPtr NativeFieldInfoPtr_BedUI;

		// Token: 0x04008564 RID: 34148
		private static readonly IntPtr NativeFieldInfoPtr_StationsUI;

		// Token: 0x04008565 RID: 34149
		private static readonly IntPtr NativeFieldInfoPtr_RoutesUI;

		// Token: 0x04008566 RID: 34150
		private static readonly IntPtr NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04008567 RID: 34151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
