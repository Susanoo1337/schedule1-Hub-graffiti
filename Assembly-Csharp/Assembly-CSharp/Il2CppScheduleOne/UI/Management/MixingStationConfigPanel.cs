using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007CB RID: 1995
	public class MixingStationConfigPanel : ConfigPanel
	{
		// Token: 0x0600C339 RID: 49977 RVA: 0x0031A41C File Offset: 0x0031861C
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationConfigPanel()
		{
			Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "MixingStationConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr);
			MixingStationConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr, "DestinationUI");
			MixingStationConfigPanel.NativeFieldInfoPtr_StartThresholdUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr, "StartThresholdUI");
			MixingStationConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr, 100688647);
			MixingStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr, 100688648);
		}

		// Token: 0x0600C33A RID: 49978 RVA: 0x0031A49C File Offset: 0x0031869C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323146, XrefRangeEnd = 323191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BindInternal(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C33B RID: 49979 RVA: 0x0031A4EC File Offset: 0x003186EC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C33C RID: 49980 RVA: 0x0005BF46 File Offset: 0x0005A146
		public MixingStationConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B3D RID: 15165
		// (get) Token: 0x0600C33D RID: 49981 RVA: 0x0031A528 File Offset: 0x00318728
		// (set) Token: 0x0600C33E RID: 49982 RVA: 0x0005BF4F File Offset: 0x0005A14F
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B3E RID: 15166
		// (get) Token: 0x0600C33F RID: 49983 RVA: 0x0031A558 File Offset: 0x00318758
		// (set) Token: 0x0600C340 RID: 49984 RVA: 0x0005BF6E File Offset: 0x0005A16E
		public unsafe NumberFieldUI StartThresholdUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigPanel.NativeFieldInfoPtr_StartThresholdUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigPanel.NativeFieldInfoPtr_StartThresholdUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008558 RID: 34136
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04008559 RID: 34137
		private static readonly IntPtr NativeFieldInfoPtr_StartThresholdUI;

		// Token: 0x0400855A RID: 34138
		private static readonly IntPtr NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x0400855B RID: 34139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
