using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007C8 RID: 1992
	public class CleanerConfigPanel : ConfigPanel
	{
		// Token: 0x0600C321 RID: 49953 RVA: 0x00319FD8 File Offset: 0x003181D8
		// Note: this type is marked as 'beforefieldinit'.
		static CleanerConfigPanel()
		{
			Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "CleanerConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr);
			CleanerConfigPanel.NativeFieldInfoPtr_BedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr, "BedUI");
			CleanerConfigPanel.NativeFieldInfoPtr_BinsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr, "BinsUI");
			CleanerConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr, 100688641);
			CleanerConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr, 100688642);
		}

		// Token: 0x0600C322 RID: 49954 RVA: 0x0031A058 File Offset: 0x00318258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323011, XrefRangeEnd = 323056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BindInternal(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C323 RID: 49955 RVA: 0x0031A0A8 File Offset: 0x003182A8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanerConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C324 RID: 49956 RVA: 0x0005BE71 File Offset: 0x0005A071
		public CleanerConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B37 RID: 15159
		// (get) Token: 0x0600C325 RID: 49957 RVA: 0x0031A0E4 File Offset: 0x003182E4
		// (set) Token: 0x0600C326 RID: 49958 RVA: 0x0005BE7A File Offset: 0x0005A07A
		public unsafe ObjectFieldUI BedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigPanel.NativeFieldInfoPtr_BedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigPanel.NativeFieldInfoPtr_BedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B38 RID: 15160
		// (get) Token: 0x0600C327 RID: 49959 RVA: 0x0031A114 File Offset: 0x00318314
		// (set) Token: 0x0600C328 RID: 49960 RVA: 0x0005BE99 File Offset: 0x0005A099
		public unsafe ObjectListFieldUI BinsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigPanel.NativeFieldInfoPtr_BinsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigPanel.NativeFieldInfoPtr_BinsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400854C RID: 34124
		private static readonly IntPtr NativeFieldInfoPtr_BedUI;

		// Token: 0x0400854D RID: 34125
		private static readonly IntPtr NativeFieldInfoPtr_BinsUI;

		// Token: 0x0400854E RID: 34126
		private static readonly IntPtr NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x0400854F RID: 34127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
