using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000504 RID: 1284
	public class WaterContainerVisualizer : MonoBehaviour
	{
		// Token: 0x060073AB RID: 29611 RVA: 0x00206EE0 File Offset: 0x002050E0
		// Note: this type is marked as 'beforefieldinit'.
		static WaterContainerVisualizer()
		{
			Il2CppClassPointerStore<WaterContainerVisualizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "WaterContainerVisualizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterContainerVisualizer>.NativeClassPtr);
			WaterContainerVisualizer.NativeFieldInfoPtr__waterTransformLerps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterContainerVisualizer>.NativeClassPtr, "_waterTransformLerps");
			WaterContainerVisualizer.NativeFieldInfoPtr__assignedWaterContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterContainerVisualizer>.NativeClassPtr, "_assignedWaterContainer");
			WaterContainerVisualizer.NativeMethodInfoPtr_AssignWaterContainer_Public_Void_WaterContainerInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerVisualizer>.NativeClassPtr, 100678229);
			WaterContainerVisualizer.NativeMethodInfoPtr_UnassignWaterContainer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerVisualizer>.NativeClassPtr, 100678230);
			WaterContainerVisualizer.NativeMethodInfoPtr_WaterContainerChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerVisualizer>.NativeClassPtr, 100678231);
			WaterContainerVisualizer.NativeMethodInfoPtr_SetFillLevel_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerVisualizer>.NativeClassPtr, 100678232);
			WaterContainerVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerVisualizer>.NativeClassPtr, 100678233);
		}

		// Token: 0x060073AC RID: 29612 RVA: 0x00206F9C File Offset: 0x0020519C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 227610, RefRangeEnd = 227614, XrefRangeStart = 227589, XrefRangeEnd = 227610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignWaterContainer(WaterContainerInstance waterContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(waterContainer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerVisualizer.NativeMethodInfoPtr_AssignWaterContainer_Public_Void_WaterContainerInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AD RID: 29613 RVA: 0x00206FE0 File Offset: 0x002051E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 227622, RefRangeEnd = 227626, XrefRangeStart = 227614, XrefRangeEnd = 227622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnassignWaterContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerVisualizer.NativeMethodInfoPtr_UnassignWaterContainer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AE RID: 29614 RVA: 0x00207014 File Offset: 0x00205214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227626, XrefRangeEnd = 227629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WaterContainerChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerVisualizer.NativeMethodInfoPtr_WaterContainerChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AF RID: 29615 RVA: 0x00207048 File Offset: 0x00205248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227629, XrefRangeEnd = 227631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFillLevel(float normalizedFillLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedFillLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerVisualizer.NativeMethodInfoPtr_SetFillLevel_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B0 RID: 29616 RVA: 0x00207088 File Offset: 0x00205288
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterContainerVisualizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterContainerVisualizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B1 RID: 29617 RVA: 0x000370B0 File Offset: 0x000352B0
		public WaterContainerVisualizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023AB RID: 9131
		// (get) Token: 0x060073B2 RID: 29618 RVA: 0x002070C4 File Offset: 0x002052C4
		// (set) Token: 0x060073B3 RID: 29619 RVA: 0x000370B9 File Offset: 0x000352B9
		public unsafe Il2CppReferenceArray<TransformLerp> _waterTransformLerps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerVisualizer.NativeFieldInfoPtr__waterTransformLerps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TransformLerp>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerVisualizer.NativeFieldInfoPtr__waterTransformLerps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023AC RID: 9132
		// (get) Token: 0x060073B4 RID: 29620 RVA: 0x002070F4 File Offset: 0x002052F4
		// (set) Token: 0x060073B5 RID: 29621 RVA: 0x000370D8 File Offset: 0x000352D8
		public unsafe WaterContainerInstance _assignedWaterContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerVisualizer.NativeFieldInfoPtr__assignedWaterContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterContainerInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerVisualizer.NativeFieldInfoPtr__assignedWaterContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004EE2 RID: 20194
		private static readonly IntPtr NativeFieldInfoPtr__waterTransformLerps;

		// Token: 0x04004EE3 RID: 20195
		private static readonly IntPtr NativeFieldInfoPtr__assignedWaterContainer;

		// Token: 0x04004EE4 RID: 20196
		private static readonly IntPtr NativeMethodInfoPtr_AssignWaterContainer_Public_Void_WaterContainerInstance_0;

		// Token: 0x04004EE5 RID: 20197
		private static readonly IntPtr NativeMethodInfoPtr_UnassignWaterContainer_Public_Void_0;

		// Token: 0x04004EE6 RID: 20198
		private static readonly IntPtr NativeMethodInfoPtr_WaterContainerChanged_Private_Void_0;

		// Token: 0x04004EE7 RID: 20199
		private static readonly IntPtr NativeMethodInfoPtr_SetFillLevel_Private_Void_Single_0;

		// Token: 0x04004EE8 RID: 20200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
