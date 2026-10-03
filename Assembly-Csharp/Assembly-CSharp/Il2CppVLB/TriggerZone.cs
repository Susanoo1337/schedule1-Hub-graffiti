using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000075 RID: 117
	public class TriggerZone : MonoBehaviour
	{
		// Token: 0x06000881 RID: 2177 RVA: 0x00096608 File Offset: 0x00094808
		// Note: this type is marked as 'beforefieldinit'.
		static TriggerZone()
		{
			Il2CppClassPointerStore<TriggerZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "TriggerZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr);
			TriggerZone.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "ClassName");
			TriggerZone.NativeFieldInfoPtr_setIsTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "setIsTrigger");
			TriggerZone.NativeFieldInfoPtr_rangeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "rangeMultiplier");
			TriggerZone.NativeFieldInfoPtr_kMeshColliderNumSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "kMeshColliderNumSides");
			TriggerZone.NativeFieldInfoPtr_m_Beam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "m_Beam");
			TriggerZone.NativeFieldInfoPtr_m_DynamicOcclusionRaycasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "m_DynamicOcclusionRaycasting");
			TriggerZone.NativeFieldInfoPtr_m_PolygonCollider2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "m_PolygonCollider2D");
			TriggerZone.NativeMethodInfoPtr_get_updateRate_Private_get_TriggerZoneUpdateRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, 100664374);
			TriggerZone.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, 100664375);
			TriggerZone.NativeMethodInfoPtr_OnOcclusionProcessed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, 100664376);
			TriggerZone.NativeMethodInfoPtr_ComputeZone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, 100664377);
			TriggerZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, 100664378);
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x00096728 File Offset: 0x00094928
		public unsafe TriggerZone.TriggerZoneUpdateRate updateRate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73862, XrefRangeEnd = 73867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerZone.NativeMethodInfoPtr_get_updateRate_Private_get_TriggerZoneUpdateRate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00096764 File Offset: 0x00094964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73867, XrefRangeEnd = 73891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerZone.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00096798 File Offset: 0x00094998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73891, XrefRangeEnd = 73892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOcclusionProcessed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerZone.NativeMethodInfoPtr_OnOcclusionProcessed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000967CC File Offset: 0x000949CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73947, RefRangeEnd = 73948, XrefRangeStart = 73892, XrefRangeEnd = 73947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ComputeZone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerZone.NativeMethodInfoPtr_ComputeZone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00096800 File Offset: 0x00094A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73948, XrefRangeEnd = 73949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TriggerZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0000609E File Offset: 0x0000429E
		public TriggerZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x0009683C File Offset: 0x00094A3C
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x000060A7 File Offset: 0x000042A7
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TriggerZone.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TriggerZone.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x0009685C File Offset: 0x00094A5C
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x000060B9 File Offset: 0x000042B9
		public unsafe bool setIsTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_setIsTrigger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_setIsTrigger)) = value;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x00096884 File Offset: 0x00094A84
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x000060D4 File Offset: 0x000042D4
		public unsafe float rangeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_rangeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_rangeMultiplier)) = value;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x000968AC File Offset: 0x00094AAC
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x000060EF File Offset: 0x000042EF
		public unsafe static int kMeshColliderNumSides
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TriggerZone.NativeFieldInfoPtr_kMeshColliderNumSides, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TriggerZone.NativeFieldInfoPtr_kMeshColliderNumSides, (void*)(&value));
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x000968C8 File Offset: 0x00094AC8
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x000060FD File Offset: 0x000042FD
		public unsafe VolumetricLightBeamAbstractBase m_Beam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_Beam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamAbstractBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_Beam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x000968F8 File Offset: 0x00094AF8
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x0000611C File Offset: 0x0000431C
		public unsafe DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_DynamicOcclusionRaycasting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicOcclusionRaycasting>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_DynamicOcclusionRaycasting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00096928 File Offset: 0x00094B28
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x0000613B File Offset: 0x0000433B
		public unsafe PolygonCollider2D m_PolygonCollider2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_PolygonCollider2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_PolygonCollider2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeFieldInfoPtr_setIsTrigger;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeFieldInfoPtr_rangeMultiplier;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeFieldInfoPtr_kMeshColliderNumSides;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeFieldInfoPtr_m_Beam;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeFieldInfoPtr_m_DynamicOcclusionRaycasting;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeFieldInfoPtr_m_PolygonCollider2D;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_get_updateRate_Private_get_TriggerZoneUpdateRate_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_OnOcclusionProcessed_Private_Void_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_ComputeZone_Private_Void_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000895 RID: 2197
		[OriginalName("Assembly-CSharp.dll", "", "TriggerZoneUpdateRate")]
		public enum TriggerZoneUpdateRate
		{
			// Token: 0x04008FC1 RID: 36801
			OnEnable,
			// Token: 0x04008FC2 RID: 36802
			OnOcclusionChange
		}
	}
}
