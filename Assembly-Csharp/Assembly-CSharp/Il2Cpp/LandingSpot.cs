using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000035 RID: 53
	public class LandingSpot : MonoBehaviour
	{
		// Token: 0x0600035B RID: 859 RVA: 0x000850D0 File Offset: 0x000832D0
		// Note: this type is marked as 'beforefieldinit'.
		static LandingSpot()
		{
			Il2CppClassPointerStore<LandingSpot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LandingSpot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr);
			LandingSpot.NativeFieldInfoPtr_landingChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "landingChild");
			LandingSpot.NativeFieldInfoPtr_landing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "landing");
			LandingSpot.NativeFieldInfoPtr_lerpCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "lerpCounter");
			LandingSpot.NativeFieldInfoPtr__controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "_controller");
			LandingSpot.NativeFieldInfoPtr__idle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "_idle");
			LandingSpot.NativeFieldInfoPtr__thisT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "_thisT");
			LandingSpot.NativeFieldInfoPtr__gotcha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "_gotcha");
			LandingSpot.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663618);
			LandingSpot.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663619);
			LandingSpot.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663620);
			LandingSpot.NativeMethodInfoPtr_StraightenBird_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663621);
			LandingSpot.NativeMethodInfoPtr_RotateBird_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663622);
			LandingSpot.NativeMethodInfoPtr_GetFlockChild_Public_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663623);
			LandingSpot.NativeMethodInfoPtr_InstantLand_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663624);
			LandingSpot.NativeMethodInfoPtr_ReleaseFlockChild_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663625);
			LandingSpot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663626);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00085240 File Offset: 0x00083440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68196, XrefRangeEnd = 68212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00085274 File Offset: 0x00083474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68212, XrefRangeEnd = 68255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000852A8 File Offset: 0x000834A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68255, XrefRangeEnd = 68296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000852DC File Offset: 0x000834DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68296, XrefRangeEnd = 68299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StraightenBird()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_StraightenBird_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00085310 File Offset: 0x00083510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68314, RefRangeEnd = 68315, XrefRangeStart = 68299, XrefRangeEnd = 68314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateBird()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_RotateBird_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00085344 File Offset: 0x00083544
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 68320, RefRangeEnd = 68325, XrefRangeStart = 68315, XrefRangeEnd = 68320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetFlockChild(float minDelay, float maxDelay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minDelay;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_GetFlockChild_Public_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000853A0 File Offset: 0x000835A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68325, XrefRangeEnd = 68347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstantLand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_InstantLand_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000853D4 File Offset: 0x000835D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68347, XrefRangeEnd = 68372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseFlockChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_ReleaseFlockChild_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00085408 File Offset: 0x00083608
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandingSpot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00003E78 File Offset: 0x00002078
		public LandingSpot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00085444 File Offset: 0x00083644
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00003E81 File Offset: 0x00002081
		public unsafe FlockChild landingChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_landingChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockChild>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_landingChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00085474 File Offset: 0x00083674
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00003EA0 File Offset: 0x000020A0
		public unsafe bool landing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_landing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_landing)) = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0008549C File Offset: 0x0008369C
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00003EBB File Offset: 0x000020BB
		public unsafe int lerpCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_lerpCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_lerpCounter)) = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000854C4 File Offset: 0x000836C4
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00003ED6 File Offset: 0x000020D6
		public unsafe LandingSpotController _controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandingSpotController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600036E RID: 878 RVA: 0x000854F4 File Offset: 0x000836F4
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00003EF5 File Offset: 0x000020F5
		public unsafe bool _idle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__idle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__idle)) = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0008551C File Offset: 0x0008371C
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00003F10 File Offset: 0x00002110
		public unsafe Transform _thisT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__thisT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__thisT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0008554C File Offset: 0x0008374C
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00003F2F File Offset: 0x0000212F
		public unsafe bool _gotcha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__gotcha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__gotcha)) = value;
			}
		}

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeFieldInfoPtr_landingChild;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeFieldInfoPtr_landing;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeFieldInfoPtr_lerpCounter;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr__controller;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr__idle;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr__thisT;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr__gotcha;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_StraightenBird_Public_Void_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_RotateBird_Public_Void_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_GetFlockChild_Public_IEnumerator_Single_Single_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_InstantLand_Public_Void_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseFlockChild_Public_Void_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000862 RID: 2146
		[ObfuscatedName("LandingSpot+<GetFlockChild>d__12")]
		public sealed class _GetFlockChild_d__12 : Il2CppSystem.Object
		{
			// Token: 0x0600D052 RID: 53330 RVA: 0x00344E94 File Offset: 0x00343094
			// Note: this type is marked as 'beforefieldinit'.
			static _GetFlockChild_d__12()
			{
				Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "<GetFlockChild>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr);
				LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, "<>1__state");
				LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, "<>2__current");
				LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_minDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, "minDelay");
				LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_maxDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, "maxDelay");
				LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, "<>4__this");
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663627);
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663628);
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663629);
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663630);
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663631);
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663632);
			}

			// Token: 0x0600D053 RID: 53331 RVA: 0x00344F9C File Offset: 0x0034319C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetFlockChild_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D054 RID: 53332 RVA: 0x00344FE4 File Offset: 0x003431E4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D055 RID: 53333 RVA: 0x00345018 File Offset: 0x00343218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68157, XrefRangeEnd = 68191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F1B RID: 16155
			// (get) Token: 0x0600D056 RID: 53334 RVA: 0x00345054 File Offset: 0x00343254
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D057 RID: 53335 RVA: 0x00345094 File Offset: 0x00343294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68191, XrefRangeEnd = 68196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F1C RID: 16156
			// (get) Token: 0x0600D058 RID: 53336 RVA: 0x003450C8 File Offset: 0x003432C8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D059 RID: 53337 RVA: 0x000629E0 File Offset: 0x00060BE0
			public _GetFlockChild_d__12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F16 RID: 16150
			// (get) Token: 0x0600D05A RID: 53338 RVA: 0x00345108 File Offset: 0x00343308
			// (set) Token: 0x0600D05B RID: 53339 RVA: 0x000629E9 File Offset: 0x00060BE9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F17 RID: 16151
			// (get) Token: 0x0600D05C RID: 53340 RVA: 0x00345130 File Offset: 0x00343330
			// (set) Token: 0x0600D05D RID: 53341 RVA: 0x00062A04 File Offset: 0x00060C04
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F18 RID: 16152
			// (get) Token: 0x0600D05E RID: 53342 RVA: 0x00345160 File Offset: 0x00343360
			// (set) Token: 0x0600D05F RID: 53343 RVA: 0x00062A23 File Offset: 0x00060C23
			public unsafe float minDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_minDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_minDelay)) = value;
				}
			}

			// Token: 0x17003F19 RID: 16153
			// (get) Token: 0x0600D060 RID: 53344 RVA: 0x00345188 File Offset: 0x00343388
			// (set) Token: 0x0600D061 RID: 53345 RVA: 0x00062A3E File Offset: 0x00060C3E
			public unsafe float maxDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_maxDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_maxDelay)) = value;
				}
			}

			// Token: 0x17003F1A RID: 16154
			// (get) Token: 0x0600D062 RID: 53346 RVA: 0x003451B0 File Offset: 0x003433B0
			// (set) Token: 0x0600D063 RID: 53347 RVA: 0x00062A59 File Offset: 0x00060C59
			public unsafe LandingSpot __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandingSpot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DFD RID: 36349
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008DFE RID: 36350
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008DFF RID: 36351
			private static readonly IntPtr NativeFieldInfoPtr_minDelay;

			// Token: 0x04008E00 RID: 36352
			private static readonly IntPtr NativeFieldInfoPtr_maxDelay;

			// Token: 0x04008E01 RID: 36353
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E02 RID: 36354
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E03 RID: 36355
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E04 RID: 36356
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E05 RID: 36357
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E06 RID: 36358
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E07 RID: 36359
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
