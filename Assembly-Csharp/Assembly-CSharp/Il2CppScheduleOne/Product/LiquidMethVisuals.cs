using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.StationFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000548 RID: 1352
	public class LiquidMethVisuals : MonoBehaviour
	{
		// Token: 0x06007BB1 RID: 31665 RVA: 0x00222A38 File Offset: 0x00220C38
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidMethVisuals()
		{
			Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "LiquidMethVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr);
			LiquidMethVisuals.NativeFieldInfoPtr_StaticLiquidMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, "StaticLiquidMesh");
			LiquidMethVisuals.NativeFieldInfoPtr_LiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, "LiquidContainer");
			LiquidMethVisuals.NativeFieldInfoPtr_PourParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, "PourParticles");
			LiquidMethVisuals.NativeMethodInfoPtr_Setup_Public_Void_LiquidMethDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, 100679184);
			LiquidMethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, 100679185);
		}

		// Token: 0x06007BB2 RID: 31666 RVA: 0x00222ACC File Offset: 0x00220CCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 235894, RefRangeEnd = 235897, XrefRangeStart = 235875, XrefRangeEnd = 235894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(LiquidMethDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMethVisuals.NativeMethodInfoPtr_Setup_Public_Void_LiquidMethDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BB3 RID: 31667 RVA: 0x00222B10 File Offset: 0x00220D10
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidMethVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BB4 RID: 31668 RVA: 0x0003AEFB File Offset: 0x000390FB
		public LiquidMethVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002650 RID: 9808
		// (get) Token: 0x06007BB5 RID: 31669 RVA: 0x00222B4C File Offset: 0x00220D4C
		// (set) Token: 0x06007BB6 RID: 31670 RVA: 0x0003AF04 File Offset: 0x00039104
		public unsafe MeshRenderer StaticLiquidMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_StaticLiquidMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_StaticLiquidMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002651 RID: 9809
		// (get) Token: 0x06007BB7 RID: 31671 RVA: 0x00222B7C File Offset: 0x00220D7C
		// (set) Token: 0x06007BB8 RID: 31672 RVA: 0x0003AF23 File Offset: 0x00039123
		public unsafe LiquidContainer LiquidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_LiquidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_LiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002652 RID: 9810
		// (get) Token: 0x06007BB9 RID: 31673 RVA: 0x00222BAC File Offset: 0x00220DAC
		// (set) Token: 0x06007BBA RID: 31674 RVA: 0x0003AF42 File Offset: 0x00039142
		public unsafe ParticleSystem PourParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_PourParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_PourParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005449 RID: 21577
		private static readonly IntPtr NativeFieldInfoPtr_StaticLiquidMesh;

		// Token: 0x0400544A RID: 21578
		private static readonly IntPtr NativeFieldInfoPtr_LiquidContainer;

		// Token: 0x0400544B RID: 21579
		private static readonly IntPtr NativeFieldInfoPtr_PourParticles;

		// Token: 0x0400544C RID: 21580
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_LiquidMethDefinition_0;

		// Token: 0x0400544D RID: 21581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
