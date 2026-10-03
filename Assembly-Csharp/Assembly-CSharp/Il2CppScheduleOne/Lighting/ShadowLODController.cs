using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003D8 RID: 984
	public class ShadowLODController : MonoBehaviour
	{
		// Token: 0x0600581E RID: 22558 RVA: 0x001AC748 File Offset: 0x001AA948
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowLODController()
		{
			Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "ShadowLODController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr);
			ShadowLODController.NativeFieldInfoPtr_RefreshMovementThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr, "RefreshMovementThreshold");
			ShadowLODController.NativeFieldInfoPtr__softShadowEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr, "_softShadowEnabled");
			ShadowLODController.NativeFieldInfoPtr__lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr, "_lights");
			ShadowLODController.NativeFieldInfoPtr__softShadowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr, "_softShadowDistance");
			ShadowLODController.NativeFieldInfoPtr__hardShadowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr, "_hardShadowDistance");
			ShadowLODController.NativeFieldInfoPtr__softShadowDistanceSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr, "_softShadowDistanceSqr");
			ShadowLODController.NativeFieldInfoPtr__hardShadowDistanceSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr, "_hardShadowDistanceSqr");
			ShadowLODController.NativeFieldInfoPtr__appliedShadowsMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr, "_appliedShadowsMode");
			ShadowLODController.NativeMethodInfoPtr_Awake_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr, 100674883);
			ShadowLODController.NativeMethodInfoPtr_OnEnable_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr, 100674884);
			ShadowLODController.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr, 100674885);
			ShadowLODController.NativeMethodInfoPtr_UpdateShadows_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr, 100674886);
			ShadowLODController.NativeMethodInfoPtr_RecalculateDistances_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr, 100674887);
			ShadowLODController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr, 100674888);
			ShadowLODController.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr, 100674889);
		}

		// Token: 0x0600581F RID: 22559 RVA: 0x001AC8A4 File Offset: 0x001AAAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192897, XrefRangeEnd = 192925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLODController.NativeMethodInfoPtr_Awake_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005820 RID: 22560 RVA: 0x001AC8D8 File Offset: 0x001AAAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192925, XrefRangeEnd = 192929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLODController.NativeMethodInfoPtr_OnEnable_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005821 RID: 22561 RVA: 0x001AC90C File Offset: 0x001AAB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192929, XrefRangeEnd = 192943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLODController.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005822 RID: 22562 RVA: 0x001AC940 File Offset: 0x001AAB40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192957, RefRangeEnd = 192958, XrefRangeStart = 192943, XrefRangeEnd = 192957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShadows()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLODController.NativeMethodInfoPtr_UpdateShadows_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005823 RID: 22563 RVA: 0x001AC974 File Offset: 0x001AAB74
		[CallerCount(0)]
		public unsafe void RecalculateDistances()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLODController.NativeMethodInfoPtr_RecalculateDistances_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005824 RID: 22564 RVA: 0x001AC9A8 File Offset: 0x001AABA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192958, XrefRangeEnd = 192959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShadowLODController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowLODController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLODController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005825 RID: 22565 RVA: 0x001AC9E4 File Offset: 0x001AABE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192990, RefRangeEnd = 192991, XrefRangeStart = 192959, XrefRangeEnd = 192990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowLODController.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005826 RID: 22566 RVA: 0x00029A01 File Offset: 0x00027C01
		public ShadowLODController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x06005827 RID: 22567 RVA: 0x001ACA18 File Offset: 0x001AAC18
		// (set) Token: 0x06005828 RID: 22568 RVA: 0x00029A0A File Offset: 0x00027C0A
		public unsafe static int RefreshMovementThreshold
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShadowLODController.NativeFieldInfoPtr_RefreshMovementThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowLODController.NativeFieldInfoPtr_RefreshMovementThreshold, (void*)(&value));
			}
		}

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x06005829 RID: 22569 RVA: 0x001ACA34 File Offset: 0x001AAC34
		// (set) Token: 0x0600582A RID: 22570 RVA: 0x00029A18 File Offset: 0x00027C18
		public unsafe bool _softShadowEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLODController.NativeFieldInfoPtr__softShadowEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLODController.NativeFieldInfoPtr__softShadowEnabled)) = value;
			}
		}

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x0600582B RID: 22571 RVA: 0x001ACA5C File Offset: 0x001AAC5C
		// (set) Token: 0x0600582C RID: 22572 RVA: 0x00029A33 File Offset: 0x00027C33
		public unsafe Il2CppReferenceArray<Light> _lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLODController.NativeFieldInfoPtr__lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Light>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLODController.NativeFieldInfoPtr__lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x0600582D RID: 22573 RVA: 0x001ACA8C File Offset: 0x001AAC8C
		// (set) Token: 0x0600582E RID: 22574 RVA: 0x00029A52 File Offset: 0x00027C52
		public unsafe float _softShadowDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLODController.NativeFieldInfoPtr__softShadowDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLODController.NativeFieldInfoPtr__softShadowDistance)) = value;
			}
		}

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x0600582F RID: 22575 RVA: 0x001ACAB4 File Offset: 0x001AACB4
		// (set) Token: 0x06005830 RID: 22576 RVA: 0x00029A6D File Offset: 0x00027C6D
		public unsafe float _hardShadowDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLODController.NativeFieldInfoPtr__hardShadowDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLODController.NativeFieldInfoPtr__hardShadowDistance)) = value;
			}
		}

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x06005831 RID: 22577 RVA: 0x001ACADC File Offset: 0x001AACDC
		// (set) Token: 0x06005832 RID: 22578 RVA: 0x00029A88 File Offset: 0x00027C88
		public unsafe float _softShadowDistanceSqr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLODController.NativeFieldInfoPtr__softShadowDistanceSqr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLODController.NativeFieldInfoPtr__softShadowDistanceSqr)) = value;
			}
		}

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x06005833 RID: 22579 RVA: 0x001ACB04 File Offset: 0x001AAD04
		// (set) Token: 0x06005834 RID: 22580 RVA: 0x00029AA3 File Offset: 0x00027CA3
		public unsafe float _hardShadowDistanceSqr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLODController.NativeFieldInfoPtr__hardShadowDistanceSqr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLODController.NativeFieldInfoPtr__hardShadowDistanceSqr)) = value;
			}
		}

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x06005835 RID: 22581 RVA: 0x001ACB2C File Offset: 0x001AAD2C
		// (set) Token: 0x06005836 RID: 22582 RVA: 0x00029ABE File Offset: 0x00027CBE
		public unsafe LightShadows _appliedShadowsMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLODController.NativeFieldInfoPtr__appliedShadowsMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowLODController.NativeFieldInfoPtr__appliedShadowsMode)) = value;
			}
		}

		// Token: 0x04003CA4 RID: 15524
		private static readonly IntPtr NativeFieldInfoPtr_RefreshMovementThreshold;

		// Token: 0x04003CA5 RID: 15525
		private static readonly IntPtr NativeFieldInfoPtr__softShadowEnabled;

		// Token: 0x04003CA6 RID: 15526
		private static readonly IntPtr NativeFieldInfoPtr__lights;

		// Token: 0x04003CA7 RID: 15527
		private static readonly IntPtr NativeFieldInfoPtr__softShadowDistance;

		// Token: 0x04003CA8 RID: 15528
		private static readonly IntPtr NativeFieldInfoPtr__hardShadowDistance;

		// Token: 0x04003CA9 RID: 15529
		private static readonly IntPtr NativeFieldInfoPtr__softShadowDistanceSqr;

		// Token: 0x04003CAA RID: 15530
		private static readonly IntPtr NativeFieldInfoPtr__hardShadowDistanceSqr;

		// Token: 0x04003CAB RID: 15531
		private static readonly IntPtr NativeFieldInfoPtr__appliedShadowsMode;

		// Token: 0x04003CAC RID: 15532
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_1;

		// Token: 0x04003CAD RID: 15533
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_1;

		// Token: 0x04003CAE RID: 15534
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x04003CAF RID: 15535
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShadows_Public_Void_0;

		// Token: 0x04003CB0 RID: 15536
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateDistances_Private_Void_1;

		// Token: 0x04003CB1 RID: 15537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003CB2 RID: 15538
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
