using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.Graffiti
{
	// Token: 0x0200036D RID: 877
	public class SprayDisplay : MonoBehaviour
	{
		// Token: 0x06004A14 RID: 18964 RVA: 0x0017746C File Offset: 0x0017566C
		// Note: this type is marked as 'beforefieldinit'.
		static SprayDisplay()
		{
			Il2CppClassPointerStore<SprayDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Graffiti", "SprayDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SprayDisplay>.NativeClassPtr);
			SprayDisplay.NativeFieldInfoPtr_SpraySurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayDisplay>.NativeClassPtr, "SpraySurface");
			SprayDisplay.NativeFieldInfoPtr_Projector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayDisplay>.NativeClassPtr, "Projector");
			SprayDisplay.NativeFieldInfoPtr_cachedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayDisplay>.NativeClassPtr, "cachedMaterial");
			SprayDisplay.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayDisplay>.NativeClassPtr, 100672791);
			SprayDisplay.NativeMethodInfoPtr_Redraw_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayDisplay>.NativeClassPtr, 100672792);
			SprayDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayDisplay>.NativeClassPtr, 100672793);
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x00177514 File Offset: 0x00175714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169594, XrefRangeEnd = 169609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayDisplay.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A16 RID: 18966 RVA: 0x00177548 File Offset: 0x00175748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169609, XrefRangeEnd = 169634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Redraw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayDisplay.NativeMethodInfoPtr_Redraw_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x0017757C File Offset: 0x0017577C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SprayDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SprayDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x00023EB9 File Offset: 0x000220B9
		public SprayDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x06004A19 RID: 18969 RVA: 0x001775B8 File Offset: 0x001757B8
		// (set) Token: 0x06004A1A RID: 18970 RVA: 0x00023EC2 File Offset: 0x000220C2
		public unsafe SpraySurface SpraySurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayDisplay.NativeFieldInfoPtr_SpraySurface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpraySurface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayDisplay.NativeFieldInfoPtr_SpraySurface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x06004A1B RID: 18971 RVA: 0x001775E8 File Offset: 0x001757E8
		// (set) Token: 0x06004A1C RID: 18972 RVA: 0x00023EE1 File Offset: 0x000220E1
		public unsafe DecalProjector Projector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayDisplay.NativeFieldInfoPtr_Projector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayDisplay.NativeFieldInfoPtr_Projector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x06004A1D RID: 18973 RVA: 0x00177618 File Offset: 0x00175818
		// (set) Token: 0x06004A1E RID: 18974 RVA: 0x00023F00 File Offset: 0x00022100
		public unsafe Material cachedMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayDisplay.NativeFieldInfoPtr_cachedMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayDisplay.NativeFieldInfoPtr_cachedMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003265 RID: 12901
		private static readonly IntPtr NativeFieldInfoPtr_SpraySurface;

		// Token: 0x04003266 RID: 12902
		private static readonly IntPtr NativeFieldInfoPtr_Projector;

		// Token: 0x04003267 RID: 12903
		private static readonly IntPtr NativeFieldInfoPtr_cachedMaterial;

		// Token: 0x04003268 RID: 12904
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003269 RID: 12905
		private static readonly IntPtr NativeMethodInfoPtr_Redraw_Private_Void_0;

		// Token: 0x0400326A RID: 12906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
