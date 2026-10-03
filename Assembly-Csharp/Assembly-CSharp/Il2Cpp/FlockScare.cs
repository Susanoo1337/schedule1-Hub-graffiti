using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000032 RID: 50
	public class FlockScare : MonoBehaviour
	{
		// Token: 0x0600032F RID: 815 RVA: 0x00084978 File Offset: 0x00082B78
		// Note: this type is marked as 'beforefieldinit'.
		static FlockScare()
		{
			Il2CppClassPointerStore<FlockScare>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlockScare");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlockScare>.NativeClassPtr);
			FlockScare.NativeFieldInfoPtr_landingSpotControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, "landingSpotControllers");
			FlockScare.NativeFieldInfoPtr_scareInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, "scareInterval");
			FlockScare.NativeFieldInfoPtr_distanceToScare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, "distanceToScare");
			FlockScare.NativeFieldInfoPtr_checkEveryNthLandingSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, "checkEveryNthLandingSpot");
			FlockScare.NativeFieldInfoPtr_InvokeAmounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, "InvokeAmounts");
			FlockScare.NativeFieldInfoPtr_lsc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, "lsc");
			FlockScare.NativeFieldInfoPtr_ls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, "ls");
			FlockScare.NativeFieldInfoPtr_currentController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, "currentController");
			FlockScare.NativeMethodInfoPtr_CheckProximityToLandingSpots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, 100663606);
			FlockScare.NativeMethodInfoPtr_IterateLandingSpots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, 100663607);
			FlockScare.NativeMethodInfoPtr_CheckDistanceToLandingSpot_Private_Boolean_LandingSpotController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, 100663608);
			FlockScare.NativeMethodInfoPtr_Invoker_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, 100663609);
			FlockScare.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, 100663610);
			FlockScare.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, 100663611);
			FlockScare.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockScare>.NativeClassPtr, 100663612);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00084AD4 File Offset: 0x00082CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68015, XrefRangeEnd = 68037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckProximityToLandingSpots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockScare.NativeMethodInfoPtr_CheckProximityToLandingSpots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00084B08 File Offset: 0x00082D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68037, XrefRangeEnd = 68040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateLandingSpots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockScare.NativeMethodInfoPtr_IterateLandingSpots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00084B3C File Offset: 0x00082D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68040, XrefRangeEnd = 68052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckDistanceToLandingSpot(LandingSpotController lc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockScare.NativeMethodInfoPtr_CheckDistanceToLandingSpot_Private_Boolean_LandingSpotController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00084B8C File Offset: 0x00082D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68052, XrefRangeEnd = 68055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockScare.NativeMethodInfoPtr_Invoker_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00084BC0 File Offset: 0x00082DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68055, XrefRangeEnd = 68061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockScare.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00084BF4 File Offset: 0x00082DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68061, XrefRangeEnd = 68064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockScare.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00084C28 File Offset: 0x00082E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68064, XrefRangeEnd = 68065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlockScare() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlockScare>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockScare.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00003CEA File Offset: 0x00001EEA
		public FlockScare(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00084C64 File Offset: 0x00082E64
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00003CF3 File Offset: 0x00001EF3
		public unsafe Il2CppReferenceArray<LandingSpotController> landingSpotControllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_landingSpotControllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LandingSpotController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_landingSpotControllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00084C94 File Offset: 0x00082E94
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00003D12 File Offset: 0x00001F12
		public unsafe float scareInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_scareInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_scareInterval)) = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00084CBC File Offset: 0x00082EBC
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00003D2D File Offset: 0x00001F2D
		public unsafe float distanceToScare
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_distanceToScare);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_distanceToScare)) = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00084CE4 File Offset: 0x00082EE4
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00003D48 File Offset: 0x00001F48
		public unsafe int checkEveryNthLandingSpot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_checkEveryNthLandingSpot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_checkEveryNthLandingSpot)) = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00084D0C File Offset: 0x00082F0C
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00003D63 File Offset: 0x00001F63
		public unsafe int InvokeAmounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_InvokeAmounts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_InvokeAmounts)) = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00084D34 File Offset: 0x00082F34
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00003D7E File Offset: 0x00001F7E
		public unsafe int lsc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_lsc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_lsc)) = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00084D5C File Offset: 0x00082F5C
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00003D99 File Offset: 0x00001F99
		public unsafe int ls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_ls);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_ls)) = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00084D84 File Offset: 0x00082F84
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00003DB4 File Offset: 0x00001FB4
		public unsafe LandingSpotController currentController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_currentController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandingSpotController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockScare.NativeFieldInfoPtr_currentController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeFieldInfoPtr_landingSpotControllers;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeFieldInfoPtr_scareInterval;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeFieldInfoPtr_distanceToScare;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeFieldInfoPtr_checkEveryNthLandingSpot;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeFieldInfoPtr_InvokeAmounts;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeFieldInfoPtr_lsc;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeFieldInfoPtr_ls;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeFieldInfoPtr_currentController;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_CheckProximityToLandingSpots_Private_Void_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_IterateLandingSpots_Private_Void_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_CheckDistanceToLandingSpot_Private_Boolean_LandingSpotController_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_Invoker_Private_Void_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
