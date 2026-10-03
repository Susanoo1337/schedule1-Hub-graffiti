using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200033E RID: 830
	[Serializable]
	public class SoilDefinition : StorableItemDefinition
	{
		// Token: 0x06004772 RID: 18290 RVA: 0x0016DE30 File Offset: 0x0016C030
		// Note: this type is marked as 'beforefieldinit'.
		static SoilDefinition()
		{
			Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "SoilDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr);
			SoilDefinition.NativeFieldInfoPtr_SoilQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "SoilQuality");
			SoilDefinition.NativeFieldInfoPtr_DrySoilMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "DrySoilMat");
			SoilDefinition.NativeFieldInfoPtr_WetSoilMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "WetSoilMat");
			SoilDefinition.NativeFieldInfoPtr_ParticleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "ParticleColor");
			SoilDefinition.NativeFieldInfoPtr_Uses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, "Uses");
			SoilDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr, 100672450);
		}

		// Token: 0x06004773 RID: 18291 RVA: 0x0016DED8 File Offset: 0x0016C0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166835, XrefRangeEnd = 166836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoilDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004774 RID: 18292 RVA: 0x00022E34 File Offset: 0x00021034
		public SoilDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x06004775 RID: 18293 RVA: 0x0016DF14 File Offset: 0x0016C114
		// (set) Token: 0x06004776 RID: 18294 RVA: 0x00022E3D File Offset: 0x0002103D
		public unsafe SoilDefinition.ESoilQuality SoilQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_SoilQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_SoilQuality)) = value;
			}
		}

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x06004777 RID: 18295 RVA: 0x0016DF3C File Offset: 0x0016C13C
		// (set) Token: 0x06004778 RID: 18296 RVA: 0x00022E58 File Offset: 0x00021058
		public unsafe Material DrySoilMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_DrySoilMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_DrySoilMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06004779 RID: 18297 RVA: 0x0016DF6C File Offset: 0x0016C16C
		// (set) Token: 0x0600477A RID: 18298 RVA: 0x00022E77 File Offset: 0x00021077
		public unsafe Material WetSoilMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_WetSoilMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_WetSoilMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x0600477B RID: 18299 RVA: 0x0016DF9C File Offset: 0x0016C19C
		// (set) Token: 0x0600477C RID: 18300 RVA: 0x00022E96 File Offset: 0x00021096
		public unsafe Color ParticleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_ParticleColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_ParticleColor)) = value;
			}
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x0600477D RID: 18301 RVA: 0x0016DFC4 File Offset: 0x0016C1C4
		// (set) Token: 0x0600477E RID: 18302 RVA: 0x00022EB1 File Offset: 0x000210B1
		public unsafe int Uses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_Uses);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilDefinition.NativeFieldInfoPtr_Uses)) = value;
			}
		}

		// Token: 0x04003096 RID: 12438
		private static readonly IntPtr NativeFieldInfoPtr_SoilQuality;

		// Token: 0x04003097 RID: 12439
		private static readonly IntPtr NativeFieldInfoPtr_DrySoilMat;

		// Token: 0x04003098 RID: 12440
		private static readonly IntPtr NativeFieldInfoPtr_WetSoilMat;

		// Token: 0x04003099 RID: 12441
		private static readonly IntPtr NativeFieldInfoPtr_ParticleColor;

		// Token: 0x0400309A RID: 12442
		private static readonly IntPtr NativeFieldInfoPtr_Uses;

		// Token: 0x0400309B RID: 12443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A69 RID: 2665
		[OriginalName("Assembly-CSharp.dll", "", "ESoilQuality")]
		public enum ESoilQuality
		{
			// Token: 0x0400990D RID: 39181
			Basic,
			// Token: 0x0400990E RID: 39182
			Premium
		}
	}
}
