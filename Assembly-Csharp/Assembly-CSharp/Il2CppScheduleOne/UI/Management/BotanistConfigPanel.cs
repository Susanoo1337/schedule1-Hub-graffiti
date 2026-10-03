using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007C3 RID: 1987
	public class BotanistConfigPanel : ConfigPanel
	{
		// Token: 0x0600C2FB RID: 49915 RVA: 0x00319900 File Offset: 0x00317B00
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistConfigPanel()
		{
			Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "BotanistConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr);
			BotanistConfigPanel.NativeFieldInfoPtr_BedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, "BedUI");
			BotanistConfigPanel.NativeFieldInfoPtr_SuppliesUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, "SuppliesUI");
			BotanistConfigPanel.NativeFieldInfoPtr_PotsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, "PotsUI");
			BotanistConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, 100688631);
			BotanistConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, 100688632);
		}

		// Token: 0x0600C2FC RID: 49916 RVA: 0x00319994 File Offset: 0x00317B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322799, XrefRangeEnd = 322851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BindInternal(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2FD RID: 49917 RVA: 0x003199E4 File Offset: 0x00317BE4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C2FE RID: 49918 RVA: 0x0005BD2D File Offset: 0x00059F2D
		public BotanistConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B2E RID: 15150
		// (get) Token: 0x0600C2FF RID: 49919 RVA: 0x00319A20 File Offset: 0x00317C20
		// (set) Token: 0x0600C300 RID: 49920 RVA: 0x0005BD36 File Offset: 0x00059F36
		public unsafe ObjectFieldUI BedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_BedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_BedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B2F RID: 15151
		// (get) Token: 0x0600C301 RID: 49921 RVA: 0x00319A50 File Offset: 0x00317C50
		// (set) Token: 0x0600C302 RID: 49922 RVA: 0x0005BD55 File Offset: 0x00059F55
		public unsafe ObjectFieldUI SuppliesUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_SuppliesUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_SuppliesUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B30 RID: 15152
		// (get) Token: 0x0600C303 RID: 49923 RVA: 0x00319A80 File Offset: 0x00317C80
		// (set) Token: 0x0600C304 RID: 49924 RVA: 0x0005BD74 File Offset: 0x00059F74
		public unsafe ObjectListFieldUI PotsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_PotsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_PotsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008539 RID: 34105
		private static readonly IntPtr NativeFieldInfoPtr_BedUI;

		// Token: 0x0400853A RID: 34106
		private static readonly IntPtr NativeFieldInfoPtr_SuppliesUI;

		// Token: 0x0400853B RID: 34107
		private static readonly IntPtr NativeFieldInfoPtr_PotsUI;

		// Token: 0x0400853C RID: 34108
		private static readonly IntPtr NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x0400853D RID: 34109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
