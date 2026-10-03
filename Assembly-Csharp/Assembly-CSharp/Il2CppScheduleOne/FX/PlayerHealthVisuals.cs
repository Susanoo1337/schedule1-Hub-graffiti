using System;
using Il2CppBeautify.Universal;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x02000388 RID: 904
	public class PlayerHealthVisuals : MonoBehaviour
	{
		// Token: 0x06004FFB RID: 20475 RVA: 0x0018E904 File Offset: 0x0018CB04
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerHealthVisuals()
		{
			Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "PlayerHealthVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr);
			PlayerHealthVisuals.NativeFieldInfoPtr_PPVolumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "PPVolumes");
			PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "VignetteAlpha_MaxHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MinHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "VignetteAlpha_MinHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_OuterRingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "OuterRingCurve");
			PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "Saturation_MaxHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MinHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "Saturation_MinHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "ChromAb_MaxHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MinHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "ChromAb_MinHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "LensDirt_MaxHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MinHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "LensDirt_MinHealth");
			PlayerHealthVisuals.NativeFieldInfoPtr__beautifySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, "_beautifySettings");
			PlayerHealthVisuals.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100673696);
			PlayerHealthVisuals.NativeMethodInfoPtr_Spawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100673697);
			PlayerHealthVisuals.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100673698);
			PlayerHealthVisuals.NativeMethodInfoPtr_UpdateEffects_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100673699);
			PlayerHealthVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr, 100673700);
		}

		// Token: 0x06004FFC RID: 20476 RVA: 0x0018EA74 File Offset: 0x0018CC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178821, XrefRangeEnd = 178882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FFD RID: 20477 RVA: 0x0018EAA8 File Offset: 0x0018CCA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178882, XrefRangeEnd = 178902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Spawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr_Spawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FFE RID: 20478 RVA: 0x0018EADC File Offset: 0x0018CCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178902, XrefRangeEnd = 178909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FFF RID: 20479 RVA: 0x0018EB10 File Offset: 0x0018CD10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178915, RefRangeEnd = 178916, XrefRangeStart = 178909, XrefRangeEnd = 178915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEffects(float newHealth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newHealth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr_UpdateEffects_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005000 RID: 20480 RVA: 0x0018EB50 File Offset: 0x0018CD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178916, XrefRangeEnd = 178917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerHealthVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerHealthVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealthVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005001 RID: 20481 RVA: 0x000263C4 File Offset: 0x000245C4
		public PlayerHealthVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x06005002 RID: 20482 RVA: 0x0018EB8C File Offset: 0x0018CD8C
		// (set) Token: 0x06005003 RID: 20483 RVA: 0x000263CD File Offset: 0x000245CD
		public unsafe Il2CppReferenceArray<Volume> PPVolumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_PPVolumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Volume>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_PPVolumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x06005004 RID: 20484 RVA: 0x0018EBBC File Offset: 0x0018CDBC
		// (set) Token: 0x06005005 RID: 20485 RVA: 0x000263EC File Offset: 0x000245EC
		public unsafe float VignetteAlpha_MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MaxHealth)) = value;
			}
		}

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x06005006 RID: 20486 RVA: 0x0018EBE4 File Offset: 0x0018CDE4
		// (set) Token: 0x06005007 RID: 20487 RVA: 0x00026407 File Offset: 0x00024607
		public unsafe float VignetteAlpha_MinHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MinHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_VignetteAlpha_MinHealth)) = value;
			}
		}

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x06005008 RID: 20488 RVA: 0x0018EC0C File Offset: 0x0018CE0C
		// (set) Token: 0x06005009 RID: 20489 RVA: 0x00026422 File Offset: 0x00024622
		public unsafe AnimationCurve OuterRingCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_OuterRingCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_OuterRingCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x0600500A RID: 20490 RVA: 0x0018EC3C File Offset: 0x0018CE3C
		// (set) Token: 0x0600500B RID: 20491 RVA: 0x00026441 File Offset: 0x00024641
		public unsafe float Saturation_MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MaxHealth)) = value;
			}
		}

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x0600500C RID: 20492 RVA: 0x0018EC64 File Offset: 0x0018CE64
		// (set) Token: 0x0600500D RID: 20493 RVA: 0x0002645C File Offset: 0x0002465C
		public unsafe float Saturation_MinHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MinHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_Saturation_MinHealth)) = value;
			}
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x0600500E RID: 20494 RVA: 0x0018EC8C File Offset: 0x0018CE8C
		// (set) Token: 0x0600500F RID: 20495 RVA: 0x00026477 File Offset: 0x00024677
		public unsafe float ChromAb_MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MaxHealth)) = value;
			}
		}

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x06005010 RID: 20496 RVA: 0x0018ECB4 File Offset: 0x0018CEB4
		// (set) Token: 0x06005011 RID: 20497 RVA: 0x00026492 File Offset: 0x00024692
		public unsafe float ChromAb_MinHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MinHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_ChromAb_MinHealth)) = value;
			}
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x06005012 RID: 20498 RVA: 0x0018ECDC File Offset: 0x0018CEDC
		// (set) Token: 0x06005013 RID: 20499 RVA: 0x000264AD File Offset: 0x000246AD
		public unsafe float LensDirt_MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MaxHealth)) = value;
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x06005014 RID: 20500 RVA: 0x0018ED04 File Offset: 0x0018CF04
		// (set) Token: 0x06005015 RID: 20501 RVA: 0x000264C8 File Offset: 0x000246C8
		public unsafe float LensDirt_MinHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MinHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr_LensDirt_MinHealth)) = value;
			}
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x06005016 RID: 20502 RVA: 0x0018ED2C File Offset: 0x0018CF2C
		// (set) Token: 0x06005017 RID: 20503 RVA: 0x000264E3 File Offset: 0x000246E3
		public unsafe Il2CppReferenceArray<Beautify> _beautifySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr__beautifySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Beautify>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealthVisuals.NativeFieldInfoPtr__beautifySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040036D5 RID: 14037
		private static readonly IntPtr NativeFieldInfoPtr_PPVolumes;

		// Token: 0x040036D6 RID: 14038
		private static readonly IntPtr NativeFieldInfoPtr_VignetteAlpha_MaxHealth;

		// Token: 0x040036D7 RID: 14039
		private static readonly IntPtr NativeFieldInfoPtr_VignetteAlpha_MinHealth;

		// Token: 0x040036D8 RID: 14040
		private static readonly IntPtr NativeFieldInfoPtr_OuterRingCurve;

		// Token: 0x040036D9 RID: 14041
		private static readonly IntPtr NativeFieldInfoPtr_Saturation_MaxHealth;

		// Token: 0x040036DA RID: 14042
		private static readonly IntPtr NativeFieldInfoPtr_Saturation_MinHealth;

		// Token: 0x040036DB RID: 14043
		private static readonly IntPtr NativeFieldInfoPtr_ChromAb_MaxHealth;

		// Token: 0x040036DC RID: 14044
		private static readonly IntPtr NativeFieldInfoPtr_ChromAb_MinHealth;

		// Token: 0x040036DD RID: 14045
		private static readonly IntPtr NativeFieldInfoPtr_LensDirt_MaxHealth;

		// Token: 0x040036DE RID: 14046
		private static readonly IntPtr NativeFieldInfoPtr_LensDirt_MinHealth;

		// Token: 0x040036DF RID: 14047
		private static readonly IntPtr NativeFieldInfoPtr__beautifySettings;

		// Token: 0x040036E0 RID: 14048
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040036E1 RID: 14049
		private static readonly IntPtr NativeMethodInfoPtr_Spawned_Private_Void_0;

		// Token: 0x040036E2 RID: 14050
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040036E3 RID: 14051
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEffects_Private_Void_Single_0;

		// Token: 0x040036E4 RID: 14052
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
