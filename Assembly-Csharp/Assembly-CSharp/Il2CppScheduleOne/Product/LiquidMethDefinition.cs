using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000547 RID: 1351
	[Serializable]
	public class LiquidMethDefinition : QualityItemDefinition
	{
		// Token: 0x06007BA4 RID: 31652 RVA: 0x0022288C File Offset: 0x00220A8C
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidMethDefinition()
		{
			Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "LiquidMethDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr);
			LiquidMethDefinition.NativeFieldInfoPtr_StaticLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "StaticLiquidColor");
			LiquidMethDefinition.NativeFieldInfoPtr_LiquidVolumeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "LiquidVolumeColor");
			LiquidMethDefinition.NativeFieldInfoPtr_PourParticlesColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "PourParticlesColor");
			LiquidMethDefinition.NativeFieldInfoPtr_CookableLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "CookableLiquidColor");
			LiquidMethDefinition.NativeFieldInfoPtr_CookableSolidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, "CookableSolidColor");
			LiquidMethDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr, 100679183);
		}

		// Token: 0x06007BA5 RID: 31653 RVA: 0x00222934 File Offset: 0x00220B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235874, XrefRangeEnd = 235875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidMethDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidMethDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMethDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BA6 RID: 31654 RVA: 0x0003AE6B File Offset: 0x0003906B
		public LiquidMethDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700264B RID: 9803
		// (get) Token: 0x06007BA7 RID: 31655 RVA: 0x00222970 File Offset: 0x00220B70
		// (set) Token: 0x06007BA8 RID: 31656 RVA: 0x0003AE74 File Offset: 0x00039074
		public unsafe Color StaticLiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_StaticLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_StaticLiquidColor)) = value;
			}
		}

		// Token: 0x1700264C RID: 9804
		// (get) Token: 0x06007BA9 RID: 31657 RVA: 0x00222998 File Offset: 0x00220B98
		// (set) Token: 0x06007BAA RID: 31658 RVA: 0x0003AE8F File Offset: 0x0003908F
		public unsafe Color LiquidVolumeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_LiquidVolumeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_LiquidVolumeColor)) = value;
			}
		}

		// Token: 0x1700264D RID: 9805
		// (get) Token: 0x06007BAB RID: 31659 RVA: 0x002229C0 File Offset: 0x00220BC0
		// (set) Token: 0x06007BAC RID: 31660 RVA: 0x0003AEAA File Offset: 0x000390AA
		public unsafe Color PourParticlesColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_PourParticlesColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_PourParticlesColor)) = value;
			}
		}

		// Token: 0x1700264E RID: 9806
		// (get) Token: 0x06007BAD RID: 31661 RVA: 0x002229E8 File Offset: 0x00220BE8
		// (set) Token: 0x06007BAE RID: 31662 RVA: 0x0003AEC5 File Offset: 0x000390C5
		public unsafe Color CookableLiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_CookableLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_CookableLiquidColor)) = value;
			}
		}

		// Token: 0x1700264F RID: 9807
		// (get) Token: 0x06007BAF RID: 31663 RVA: 0x00222A10 File Offset: 0x00220C10
		// (set) Token: 0x06007BB0 RID: 31664 RVA: 0x0003AEE0 File Offset: 0x000390E0
		public unsafe Color CookableSolidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_CookableSolidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethDefinition.NativeFieldInfoPtr_CookableSolidColor)) = value;
			}
		}

		// Token: 0x04005443 RID: 21571
		private static readonly IntPtr NativeFieldInfoPtr_StaticLiquidColor;

		// Token: 0x04005444 RID: 21572
		private static readonly IntPtr NativeFieldInfoPtr_LiquidVolumeColor;

		// Token: 0x04005445 RID: 21573
		private static readonly IntPtr NativeFieldInfoPtr_PourParticlesColor;

		// Token: 0x04005446 RID: 21574
		private static readonly IntPtr NativeFieldInfoPtr_CookableLiquidColor;

		// Token: 0x04005447 RID: 21575
		private static readonly IntPtr NativeFieldInfoPtr_CookableSolidColor;

		// Token: 0x04005448 RID: 21576
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
