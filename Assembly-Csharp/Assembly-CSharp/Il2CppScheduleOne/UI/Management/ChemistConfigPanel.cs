using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007C6 RID: 1990
	public class ChemistConfigPanel : ConfigPanel
	{
		// Token: 0x0600C311 RID: 49937 RVA: 0x00319D00 File Offset: 0x00317F00
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistConfigPanel()
		{
			Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ChemistConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr);
			ChemistConfigPanel.NativeFieldInfoPtr_BedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr, "BedUI");
			ChemistConfigPanel.NativeFieldInfoPtr_StationsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr, "StationsUI");
			ChemistConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr, 100688637);
			ChemistConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr, 100688638);
		}

		// Token: 0x0600C312 RID: 49938 RVA: 0x00319D80 File Offset: 0x00317F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322921, XrefRangeEnd = 322966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BindInternal(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C313 RID: 49939 RVA: 0x00319DD0 File Offset: 0x00317FD0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C314 RID: 49940 RVA: 0x0005BDE3 File Offset: 0x00059FE3
		public ChemistConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B33 RID: 15155
		// (get) Token: 0x0600C315 RID: 49941 RVA: 0x00319E0C File Offset: 0x0031800C
		// (set) Token: 0x0600C316 RID: 49942 RVA: 0x0005BDEC File Offset: 0x00059FEC
		public unsafe ObjectFieldUI BedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigPanel.NativeFieldInfoPtr_BedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigPanel.NativeFieldInfoPtr_BedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B34 RID: 15156
		// (get) Token: 0x0600C317 RID: 49943 RVA: 0x00319E3C File Offset: 0x0031803C
		// (set) Token: 0x0600C318 RID: 49944 RVA: 0x0005BE0B File Offset: 0x0005A00B
		public unsafe ObjectListFieldUI StationsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigPanel.NativeFieldInfoPtr_StationsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigPanel.NativeFieldInfoPtr_StationsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008544 RID: 34116
		private static readonly IntPtr NativeFieldInfoPtr_BedUI;

		// Token: 0x04008545 RID: 34117
		private static readonly IntPtr NativeFieldInfoPtr_StationsUI;

		// Token: 0x04008546 RID: 34118
		private static readonly IntPtr NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04008547 RID: 34119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
