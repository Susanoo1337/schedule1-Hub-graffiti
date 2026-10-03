using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppVLB;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003E1 RID: 993
	public class VolumetricLightTracker : MonoBehaviour
	{
		// Token: 0x060058C1 RID: 22721 RVA: 0x001AE218 File Offset: 0x001AC418
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricLightTracker()
		{
			Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "VolumetricLightTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr);
			VolumetricLightTracker.NativeFieldInfoPtr__Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "_Override");
			VolumetricLightTracker.NativeFieldInfoPtr__Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "_Enabled");
			VolumetricLightTracker.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "light");
			VolumetricLightTracker.NativeFieldInfoPtr_optimizedLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "optimizedLight");
			VolumetricLightTracker.NativeFieldInfoPtr_beam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "beam");
			VolumetricLightTracker.NativeFieldInfoPtr_beamHD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "beamHD");
			VolumetricLightTracker.NativeFieldInfoPtr_dust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "dust");
			VolumetricLightTracker.NativeMethodInfoPtr_get_Override_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, 100674943);
			VolumetricLightTracker.NativeMethodInfoPtr_set_Override_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, 100674944);
			VolumetricLightTracker.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, 100674945);
			VolumetricLightTracker.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, 100674946);
			VolumetricLightTracker.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, 100674947);
			VolumetricLightTracker.NativeMethodInfoPtr_AssignReferences_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, 100674948);
			VolumetricLightTracker.NativeMethodInfoPtr_UpdateEffectsState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, 100674949);
			VolumetricLightTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, 100674950);
		}

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x060058C2 RID: 22722 RVA: 0x001AE374 File Offset: 0x001AC574
		// (set) Token: 0x060058C3 RID: 22723 RVA: 0x001AE3B0 File Offset: 0x001AC5B0
		public unsafe bool Override
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightTracker.NativeMethodInfoPtr_get_Override_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193380, XrefRangeEnd = 193416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightTracker.NativeMethodInfoPtr_set_Override_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x060058C4 RID: 22724 RVA: 0x001AE3F0 File Offset: 0x001AC5F0
		// (set) Token: 0x060058C5 RID: 22725 RVA: 0x001AE42C File Offset: 0x001AC62C
		public unsafe bool Enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightTracker.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193416, XrefRangeEnd = 193417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightTracker.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x001AE46C File Offset: 0x001AC66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193417, XrefRangeEnd = 193436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightTracker.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x001AE4A0 File Offset: 0x001AC6A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193472, RefRangeEnd = 193473, XrefRangeStart = 193436, XrefRangeEnd = 193472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignReferences()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightTracker.NativeMethodInfoPtr_AssignReferences_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x001AE4D4 File Offset: 0x001AC6D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 193493, RefRangeEnd = 193496, XrefRangeStart = 193473, XrefRangeEnd = 193493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEffectsState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightTracker.NativeMethodInfoPtr_UpdateEffectsState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058C9 RID: 22729 RVA: 0x001AE508 File Offset: 0x001AC708
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricLightTracker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058CA RID: 22730 RVA: 0x00029FF6 File Offset: 0x000281F6
		public VolumetricLightTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x060058CB RID: 22731 RVA: 0x001AE544 File Offset: 0x001AC744
		// (set) Token: 0x060058CC RID: 22732 RVA: 0x00029FFF File Offset: 0x000281FF
		public unsafe bool _Override
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr__Override);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr__Override)) = value;
			}
		}

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x060058CD RID: 22733 RVA: 0x001AE56C File Offset: 0x001AC76C
		// (set) Token: 0x060058CE RID: 22734 RVA: 0x0002A01A File Offset: 0x0002821A
		public unsafe bool _Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr__Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr__Enabled)) = value;
			}
		}

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x060058CF RID: 22735 RVA: 0x001AE594 File Offset: 0x001AC794
		// (set) Token: 0x060058D0 RID: 22736 RVA: 0x0002A035 File Offset: 0x00028235
		public unsafe Light light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x060058D1 RID: 22737 RVA: 0x001AE5C4 File Offset: 0x001AC7C4
		// (set) Token: 0x060058D2 RID: 22738 RVA: 0x0002A054 File Offset: 0x00028254
		public unsafe OptimizedLight optimizedLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_optimizedLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_optimizedLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x060058D3 RID: 22739 RVA: 0x001AE5F4 File Offset: 0x001AC7F4
		// (set) Token: 0x060058D4 RID: 22740 RVA: 0x0002A073 File Offset: 0x00028273
		public unsafe VolumetricLightBeamSD beam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_beam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_beam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x060058D5 RID: 22741 RVA: 0x001AE624 File Offset: 0x001AC824
		// (set) Token: 0x060058D6 RID: 22742 RVA: 0x0002A092 File Offset: 0x00028292
		public unsafe VolumetricLightBeamHD beamHD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_beamHD);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamHD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_beamHD), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x060058D7 RID: 22743 RVA: 0x001AE654 File Offset: 0x001AC854
		// (set) Token: 0x060058D8 RID: 22744 RVA: 0x0002A0B1 File Offset: 0x000282B1
		public unsafe VolumetricDustParticles dust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_dust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricDustParticles>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_dust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D01 RID: 15617
		private static readonly IntPtr NativeFieldInfoPtr__Override;

		// Token: 0x04003D02 RID: 15618
		private static readonly IntPtr NativeFieldInfoPtr__Enabled;

		// Token: 0x04003D03 RID: 15619
		private static readonly IntPtr NativeFieldInfoPtr_light;

		// Token: 0x04003D04 RID: 15620
		private static readonly IntPtr NativeFieldInfoPtr_optimizedLight;

		// Token: 0x04003D05 RID: 15621
		private static readonly IntPtr NativeFieldInfoPtr_beam;

		// Token: 0x04003D06 RID: 15622
		private static readonly IntPtr NativeFieldInfoPtr_beamHD;

		// Token: 0x04003D07 RID: 15623
		private static readonly IntPtr NativeFieldInfoPtr_dust;

		// Token: 0x04003D08 RID: 15624
		private static readonly IntPtr NativeMethodInfoPtr_get_Override_Public_get_Boolean_0;

		// Token: 0x04003D09 RID: 15625
		private static readonly IntPtr NativeMethodInfoPtr_set_Override_Public_set_Void_Boolean_0;

		// Token: 0x04003D0A RID: 15626
		private static readonly IntPtr NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0;

		// Token: 0x04003D0B RID: 15627
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0;

		// Token: 0x04003D0C RID: 15628
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003D0D RID: 15629
		private static readonly IntPtr NativeMethodInfoPtr_AssignReferences_Private_Void_0;

		// Token: 0x04003D0E RID: 15630
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEffectsState_Private_Void_0;

		// Token: 0x04003D0F RID: 15631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
