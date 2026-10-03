using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007C9 RID: 1993
	public class DryingRackConfigPanel : ConfigPanel
	{
		// Token: 0x0600C329 RID: 49961 RVA: 0x0031A144 File Offset: 0x00318344
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackConfigPanel()
		{
			Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "DryingRackConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr);
			DryingRackConfigPanel.NativeFieldInfoPtr_QualityUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr, "QualityUI");
			DryingRackConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr, "DestinationUI");
			DryingRackConfigPanel.NativeFieldInfoPtr_StartThresholdUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr, "StartThresholdUI");
			DryingRackConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr, 100688643);
			DryingRackConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr, 100688644);
		}

		// Token: 0x0600C32A RID: 49962 RVA: 0x0031A1D8 File Offset: 0x003183D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323056, XrefRangeEnd = 323111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BindInternal(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackConfigPanel.NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C32B RID: 49963 RVA: 0x0031A228 File Offset: 0x00318428
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C32C RID: 49964 RVA: 0x0005BEB8 File Offset: 0x0005A0B8
		public DryingRackConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B39 RID: 15161
		// (get) Token: 0x0600C32D RID: 49965 RVA: 0x0031A264 File Offset: 0x00318464
		// (set) Token: 0x0600C32E RID: 49966 RVA: 0x0005BEC1 File Offset: 0x0005A0C1
		public unsafe QualityFieldUI QualityUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_QualityUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_QualityUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B3A RID: 15162
		// (get) Token: 0x0600C32F RID: 49967 RVA: 0x0031A294 File Offset: 0x00318494
		// (set) Token: 0x0600C330 RID: 49968 RVA: 0x0005BEE0 File Offset: 0x0005A0E0
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B3B RID: 15163
		// (get) Token: 0x0600C331 RID: 49969 RVA: 0x0031A2C4 File Offset: 0x003184C4
		// (set) Token: 0x0600C332 RID: 49970 RVA: 0x0005BEFF File Offset: 0x0005A0FF
		public unsafe NumberFieldUI StartThresholdUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_StartThresholdUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_StartThresholdUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008550 RID: 34128
		private static readonly IntPtr NativeFieldInfoPtr_QualityUI;

		// Token: 0x04008551 RID: 34129
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04008552 RID: 34130
		private static readonly IntPtr NativeFieldInfoPtr_StartThresholdUI;

		// Token: 0x04008553 RID: 34131
		private static readonly IntPtr NativeMethodInfoPtr_BindInternal_Protected_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04008554 RID: 34132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
