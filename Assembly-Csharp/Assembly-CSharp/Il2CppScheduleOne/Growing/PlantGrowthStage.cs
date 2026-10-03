using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200051B RID: 1307
	public class PlantGrowthStage : MonoBehaviour
	{
		// Token: 0x060076CA RID: 30410 RVA: 0x002110FC File Offset: 0x0020F2FC
		// Note: this type is marked as 'beforefieldinit'.
		static PlantGrowthStage()
		{
			Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "PlantGrowthStage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr);
			PlantGrowthStage.NativeFieldInfoPtr_GrowthSites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr, "GrowthSites");
			PlantGrowthStage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr, 100678560);
		}

		// Token: 0x060076CB RID: 30411 RVA: 0x00211154 File Offset: 0x0020F354
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantGrowthStage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantGrowthStage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076CC RID: 30412 RVA: 0x00038B84 File Offset: 0x00036D84
		public PlantGrowthStage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024BD RID: 9405
		// (get) Token: 0x060076CD RID: 30413 RVA: 0x00211190 File Offset: 0x0020F390
		// (set) Token: 0x060076CE RID: 30414 RVA: 0x00038B8D File Offset: 0x00036D8D
		public unsafe Il2CppReferenceArray<Transform> GrowthSites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantGrowthStage.NativeFieldInfoPtr_GrowthSites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantGrowthStage.NativeFieldInfoPtr_GrowthSites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040050EA RID: 20714
		private static readonly IntPtr NativeFieldInfoPtr_GrowthSites;

		// Token: 0x040050EB RID: 20715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
