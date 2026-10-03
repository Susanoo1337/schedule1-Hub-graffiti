using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Tools;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x0200032F RID: 815
	public class WaterContainerPourable : Pourable
	{
		// Token: 0x060045A1 RID: 17825 RVA: 0x001682B4 File Offset: 0x001664B4
		// Note: this type is marked as 'beforefieldinit'.
		static WaterContainerPourable()
		{
			Il2CppClassPointerStore<WaterContainerPourable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "WaterContainerPourable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterContainerPourable>.NativeClassPtr);
			WaterContainerPourable.NativeFieldInfoPtr__visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterContainerPourable>.NativeClassPtr, "_visuals");
			WaterContainerPourable.NativeFieldInfoPtr__waterContainerItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterContainerPourable>.NativeClassPtr, "_waterContainerItem");
			WaterContainerPourable.NativeMethodInfoPtr_SetupWaterContainerPourable_Public_Void_WaterContainerInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerPourable>.NativeClassPtr, 100672265);
			WaterContainerPourable.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerPourable>.NativeClassPtr, 100672266);
			WaterContainerPourable.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerPourable>.NativeClassPtr, 100672267);
			WaterContainerPourable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerPourable>.NativeClassPtr, 100672268);
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x0016835C File Offset: 0x0016655C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164743, RefRangeEnd = 164744, XrefRangeStart = 164735, XrefRangeEnd = 164743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupWaterContainerPourable(WaterContainerInstance waterContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(waterContainer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerPourable.NativeMethodInfoPtr_SetupWaterContainerPourable_Public_Void_WaterContainerInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A3 RID: 17827 RVA: 0x001683A0 File Offset: 0x001665A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164744, XrefRangeEnd = 164750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterContainerPourable.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A4 RID: 17828 RVA: 0x001683DC File Offset: 0x001665DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164750, XrefRangeEnd = 164755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterContainerPourable.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x00168428 File Offset: 0x00166628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164755, XrefRangeEnd = 164756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterContainerPourable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterContainerPourable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerPourable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x00021F76 File Offset: 0x00020176
		public WaterContainerPourable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x060045A7 RID: 17831 RVA: 0x00168464 File Offset: 0x00166664
		// (set) Token: 0x060045A8 RID: 17832 RVA: 0x00021F7F File Offset: 0x0002017F
		public unsafe WaterContainerVisualizer _visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerPourable.NativeFieldInfoPtr__visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterContainerVisualizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerPourable.NativeFieldInfoPtr__visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x060045A9 RID: 17833 RVA: 0x00168494 File Offset: 0x00166694
		// (set) Token: 0x060045AA RID: 17834 RVA: 0x00021F9E File Offset: 0x0002019E
		public unsafe WaterContainerInstance _waterContainerItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerPourable.NativeFieldInfoPtr__waterContainerItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterContainerInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerPourable.NativeFieldInfoPtr__waterContainerItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F65 RID: 12133
		private static readonly IntPtr NativeFieldInfoPtr__visuals;

		// Token: 0x04002F66 RID: 12134
		private static readonly IntPtr NativeFieldInfoPtr__waterContainerItem;

		// Token: 0x04002F67 RID: 12135
		private static readonly IntPtr NativeMethodInfoPtr_SetupWaterContainerPourable_Public_Void_WaterContainerInstance_0;

		// Token: 0x04002F68 RID: 12136
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04002F69 RID: 12137
		private static readonly IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0;

		// Token: 0x04002F6A RID: 12138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
