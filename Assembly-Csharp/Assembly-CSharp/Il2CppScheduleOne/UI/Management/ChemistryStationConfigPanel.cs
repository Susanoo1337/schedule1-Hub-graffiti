using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007C7 RID: 1991
	public class ChemistryStationConfigPanel : ConfigPanel
	{
		// Token: 0x0600C319 RID: 49945 RVA: 0x00319E6C File Offset: 0x0031806C
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationConfigPanel()
		{
			Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ChemistryStationConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr);
			ChemistryStationConfigPanel.NativeFieldInfoPtr_RecipeUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr, "RecipeUI");
			ChemistryStationConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr, "DestinationUI");
			ChemistryStationConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr, 100688639);
			ChemistryStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr, 100688640);
		}

		// Token: 0x0600C31A RID: 49946 RVA: 0x00319EEC File Offset: 0x003180EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322966, XrefRangeEnd = 323011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BindInternal(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C31B RID: 49947 RVA: 0x00319F3C File Offset: 0x0031813C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C31C RID: 49948 RVA: 0x0005BE2A File Offset: 0x0005A02A
		public ChemistryStationConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B35 RID: 15157
		// (get) Token: 0x0600C31D RID: 49949 RVA: 0x00319F78 File Offset: 0x00318178
		// (set) Token: 0x0600C31E RID: 49950 RVA: 0x0005BE33 File Offset: 0x0005A033
		public unsafe StationRecipeFieldUI RecipeUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigPanel.NativeFieldInfoPtr_RecipeUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigPanel.NativeFieldInfoPtr_RecipeUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B36 RID: 15158
		// (get) Token: 0x0600C31F RID: 49951 RVA: 0x00319FA8 File Offset: 0x003181A8
		// (set) Token: 0x0600C320 RID: 49952 RVA: 0x0005BE52 File Offset: 0x0005A052
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008548 RID: 34120
		private static readonly IntPtr NativeFieldInfoPtr_RecipeUI;

		// Token: 0x04008549 RID: 34121
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x0400854A RID: 34122
		private static readonly IntPtr NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x0400854B RID: 34123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
