using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004E0 RID: 1248
	public class FillableWaterContainer : MonoBehaviour
	{
		// Token: 0x060071AA RID: 29098 RVA: 0x00200E48 File Offset: 0x001FF048
		// Note: this type is marked as 'beforefieldinit'.
		static FillableWaterContainer()
		{
			Il2CppClassPointerStore<FillableWaterContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "FillableWaterContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FillableWaterContainer>.NativeClassPtr);
			FillableWaterContainer.NativeFieldInfoPtr_MaxTapOpenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillableWaterContainer>.NativeClassPtr, "MaxTapOpenValue");
			FillableWaterContainer.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillableWaterContainer>.NativeClassPtr, "Visuals");
			FillableWaterContainer.NativeFieldInfoPtr_FillSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FillableWaterContainer>.NativeClassPtr, "FillSound");
			FillableWaterContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FillableWaterContainer>.NativeClassPtr, 100677982);
		}

		// Token: 0x060071AB RID: 29099 RVA: 0x00200EC8 File Offset: 0x001FF0C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 68082, RefRangeEnd = 68086, XrefRangeStart = 68082, XrefRangeEnd = 68086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FillableWaterContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FillableWaterContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FillableWaterContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071AC RID: 29100 RVA: 0x00036135 File Offset: 0x00034335
		public FillableWaterContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x060071AD RID: 29101 RVA: 0x00200F04 File Offset: 0x001FF104
		// (set) Token: 0x060071AE RID: 29102 RVA: 0x0003613E File Offset: 0x0003433E
		public unsafe float MaxTapOpenValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillableWaterContainer.NativeFieldInfoPtr_MaxTapOpenValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillableWaterContainer.NativeFieldInfoPtr_MaxTapOpenValue)) = value;
			}
		}

		// Token: 0x1700231E RID: 8990
		// (get) Token: 0x060071AF RID: 29103 RVA: 0x00200F2C File Offset: 0x001FF12C
		// (set) Token: 0x060071B0 RID: 29104 RVA: 0x00036159 File Offset: 0x00034359
		public unsafe WaterContainerVisualizer Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillableWaterContainer.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterContainerVisualizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillableWaterContainer.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700231F RID: 8991
		// (get) Token: 0x060071B1 RID: 29105 RVA: 0x00200F5C File Offset: 0x001FF15C
		// (set) Token: 0x060071B2 RID: 29106 RVA: 0x00036178 File Offset: 0x00034378
		public unsafe AudioSourceController FillSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillableWaterContainer.NativeFieldInfoPtr_FillSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FillableWaterContainer.NativeFieldInfoPtr_FillSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004DAC RID: 19884
		private static readonly IntPtr NativeFieldInfoPtr_MaxTapOpenValue;

		// Token: 0x04004DAD RID: 19885
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04004DAE RID: 19886
		private static readonly IntPtr NativeFieldInfoPtr_FillSound;

		// Token: 0x04004DAF RID: 19887
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
