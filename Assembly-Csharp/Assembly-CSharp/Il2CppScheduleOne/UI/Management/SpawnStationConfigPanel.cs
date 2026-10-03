using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007D0 RID: 2000
	public class SpawnStationConfigPanel : ConfigPanel
	{
		// Token: 0x0600C36D RID: 50029 RVA: 0x0031ACD0 File Offset: 0x00318ED0
		// Note: this type is marked as 'beforefieldinit'.
		static SpawnStationConfigPanel()
		{
			Il2CppClassPointerStore<SpawnStationConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "SpawnStationConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnStationConfigPanel>.NativeClassPtr);
			SpawnStationConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnStationConfigPanel>.NativeClassPtr, "DestinationUI");
			SpawnStationConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnStationConfigPanel>.NativeClassPtr, 100688657);
			SpawnStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnStationConfigPanel>.NativeClassPtr, 100688658);
		}

		// Token: 0x0600C36E RID: 50030 RVA: 0x0031AD3C File Offset: 0x00318F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323432, XrefRangeEnd = 323468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BindInternal(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpawnStationConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C36F RID: 50031 RVA: 0x0031AD8C File Offset: 0x00318F8C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpawnStationConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnStationConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C370 RID: 50032 RVA: 0x0005C163 File Offset: 0x0005A363
		public SpawnStationConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B4D RID: 15181
		// (get) Token: 0x0600C371 RID: 50033 RVA: 0x0031ADC8 File Offset: 0x00318FC8
		// (set) Token: 0x0600C372 RID: 50034 RVA: 0x0005C16C File Offset: 0x0005A36C
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnStationConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnStationConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008572 RID: 34162
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04008573 RID: 34163
		private static readonly IntPtr NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04008574 RID: 34164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
