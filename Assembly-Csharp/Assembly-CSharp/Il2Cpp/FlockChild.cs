using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002F RID: 47
	public class FlockChild : MonoBehaviour
	{
		// Token: 0x0600025B RID: 603 RVA: 0x00082A1C File Offset: 0x00080C1C
		// Note: this type is marked as 'beforefieldinit'.
		static FlockChild()
		{
			Il2CppClassPointerStore<FlockChild>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlockChild");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlockChild>.NativeClassPtr);
			FlockChild.NativeFieldInfoPtr__spawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_spawner");
			FlockChild.NativeFieldInfoPtr__wayPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_wayPoint");
			FlockChild.NativeFieldInfoPtr__speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_speed");
			FlockChild.NativeFieldInfoPtr__dived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_dived");
			FlockChild.NativeFieldInfoPtr__stuckCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_stuckCounter");
			FlockChild.NativeFieldInfoPtr__damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_damping");
			FlockChild.NativeFieldInfoPtr__soar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_soar");
			FlockChild.NativeFieldInfoPtr__landing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_landing");
			FlockChild.NativeFieldInfoPtr__targetSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_targetSpeed");
			FlockChild.NativeFieldInfoPtr__move = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_move");
			FlockChild.NativeFieldInfoPtr__model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_model");
			FlockChild.NativeFieldInfoPtr__modelT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_modelT");
			FlockChild.NativeFieldInfoPtr__avoidValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_avoidValue");
			FlockChild.NativeFieldInfoPtr__avoidDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_avoidDistance");
			FlockChild.NativeFieldInfoPtr__soarTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_soarTimer");
			FlockChild.NativeFieldInfoPtr__instantiated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_instantiated");
			FlockChild.NativeFieldInfoPtr__updateNextSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_updateNextSeed");
			FlockChild.NativeFieldInfoPtr__updateSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_updateSeed");
			FlockChild.NativeFieldInfoPtr__avoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_avoid");
			FlockChild.NativeFieldInfoPtr__thisT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_thisT");
			FlockChild.NativeFieldInfoPtr__landingPosOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_landingPosOffset");
			FlockChild.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663570);
			FlockChild.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663571);
			FlockChild.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663572);
			FlockChild.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663573);
			FlockChild.NativeMethodInfoPtr_FindRequiredComponents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663574);
			FlockChild.NativeMethodInfoPtr_RandomizeStartAnimationFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663575);
			FlockChild.NativeMethodInfoPtr_InitAvoidanceValues_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663576);
			FlockChild.NativeMethodInfoPtr_SetRandomScale_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663577);
			FlockChild.NativeMethodInfoPtr_SoarTimeLimit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663578);
			FlockChild.NativeMethodInfoPtr_CheckForDistanceToWaypoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663579);
			FlockChild.NativeMethodInfoPtr_RotationBasedOnWaypointOrAvoidance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663580);
			FlockChild.NativeMethodInfoPtr_Avoidance_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663581);
			FlockChild.NativeMethodInfoPtr_LimitRotationOfModel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663582);
			FlockChild.NativeMethodInfoPtr_Wander_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663583);
			FlockChild.NativeMethodInfoPtr_SetRandomMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663584);
			FlockChild.NativeMethodInfoPtr_Flap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663585);
			FlockChild.NativeMethodInfoPtr_findWaypoint_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663586);
			FlockChild.NativeMethodInfoPtr_Soar_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663587);
			FlockChild.NativeMethodInfoPtr_Dive_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663588);
			FlockChild.NativeMethodInfoPtr_animationSpeed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663589);
			FlockChild.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663590);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00082D94 File Offset: 0x00080F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67542, XrefRangeEnd = 67574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00082DC8 File Offset: 0x00080FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67574, XrefRangeEnd = 67582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00082DFC File Offset: 0x00080FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67582, XrefRangeEnd = 67583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00082E30 File Offset: 0x00081030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67583, XrefRangeEnd = 67587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00082E64 File Offset: 0x00081064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67587, XrefRangeEnd = 67606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindRequiredComponents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_FindRequiredComponents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00082E98 File Offset: 0x00081098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67629, RefRangeEnd = 67630, XrefRangeStart = 67606, XrefRangeEnd = 67629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeStartAnimationFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_RandomizeStartAnimationFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00082ECC File Offset: 0x000810CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67630, XrefRangeEnd = 67631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitAvoidanceValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_InitAvoidanceValues_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00082F00 File Offset: 0x00081100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67631, XrefRangeEnd = 67633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRandomScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_SetRandomScale_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00082F34 File Offset: 0x00081134
		[CallerCount(0)]
		public unsafe void SoarTimeLimit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_SoarTimeLimit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00082F68 File Offset: 0x00081168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67633, XrefRangeEnd = 67636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForDistanceToWaypoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_CheckForDistanceToWaypoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00082F9C File Offset: 0x0008119C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67651, RefRangeEnd = 67652, XrefRangeStart = 67636, XrefRangeEnd = 67651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotationBasedOnWaypointOrAvoidance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_RotationBasedOnWaypointOrAvoidance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00082FD0 File Offset: 0x000811D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67696, RefRangeEnd = 67697, XrefRangeStart = 67652, XrefRangeEnd = 67696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Avoidance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_Avoidance_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0008300C File Offset: 0x0008120C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67709, RefRangeEnd = 67710, XrefRangeStart = 67697, XrefRangeEnd = 67709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LimitRotationOfModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_LimitRotationOfModel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00083040 File Offset: 0x00081240
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 67715, RefRangeEnd = 67719, XrefRangeStart = 67710, XrefRangeEnd = 67715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Wander(float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_Wander_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00083080 File Offset: 0x00081280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67719, XrefRangeEnd = 67728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRandomMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_SetRandomMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000830B4 File Offset: 0x000812B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 67738, RefRangeEnd = 67740, XrefRangeStart = 67728, XrefRangeEnd = 67738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_Flap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000830E8 File Offset: 0x000812E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 67745, RefRangeEnd = 67750, XrefRangeStart = 67740, XrefRangeEnd = 67745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 findWaypoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_findWaypoint_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00083124 File Offset: 0x00081324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67750, XrefRangeEnd = 67755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Soar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_Soar_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00083158 File Offset: 0x00081358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67755, XrefRangeEnd = 67781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_Dive_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0008318C File Offset: 0x0008138C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67805, RefRangeEnd = 67806, XrefRangeStart = 67781, XrefRangeEnd = 67805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void animationSpeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_animationSpeed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000831C0 File Offset: 0x000813C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67806, XrefRangeEnd = 67807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlockChild() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlockChild>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000339D File Offset: 0x0000159D
		public FlockChild(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000272 RID: 626 RVA: 0x000831FC File Offset: 0x000813FC
		// (set) Token: 0x06000273 RID: 627 RVA: 0x000033A6 File Offset: 0x000015A6
		public unsafe FlockController _spawner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__spawner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__spawner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0008322C File Offset: 0x0008142C
		// (set) Token: 0x06000275 RID: 629 RVA: 0x000033C5 File Offset: 0x000015C5
		public unsafe Vector3 _wayPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__wayPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__wayPoint)) = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00083254 File Offset: 0x00081454
		// (set) Token: 0x06000277 RID: 631 RVA: 0x000033E0 File Offset: 0x000015E0
		public unsafe float _speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__speed)) = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0008327C File Offset: 0x0008147C
		// (set) Token: 0x06000279 RID: 633 RVA: 0x000033FB File Offset: 0x000015FB
		public unsafe bool _dived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__dived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__dived)) = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600027A RID: 634 RVA: 0x000832A4 File Offset: 0x000814A4
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00003416 File Offset: 0x00001616
		public unsafe float _stuckCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__stuckCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__stuckCounter)) = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600027C RID: 636 RVA: 0x000832CC File Offset: 0x000814CC
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00003431 File Offset: 0x00001631
		public unsafe float _damping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__damping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__damping)) = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600027E RID: 638 RVA: 0x000832F4 File Offset: 0x000814F4
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0000344C File Offset: 0x0000164C
		public unsafe bool _soar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__soar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__soar)) = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0008331C File Offset: 0x0008151C
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00003467 File Offset: 0x00001667
		public unsafe bool _landing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__landing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__landing)) = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00083344 File Offset: 0x00081544
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00003482 File Offset: 0x00001682
		public unsafe float _targetSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__targetSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__targetSpeed)) = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0008336C File Offset: 0x0008156C
		// (set) Token: 0x06000285 RID: 645 RVA: 0x0000349D File Offset: 0x0000169D
		public unsafe bool _move
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__move);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__move)) = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00083394 File Offset: 0x00081594
		// (set) Token: 0x06000287 RID: 647 RVA: 0x000034B8 File Offset: 0x000016B8
		public unsafe GameObject _model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000288 RID: 648 RVA: 0x000833C4 File Offset: 0x000815C4
		// (set) Token: 0x06000289 RID: 649 RVA: 0x000034D7 File Offset: 0x000016D7
		public unsafe Transform _modelT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__modelT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__modelT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600028A RID: 650 RVA: 0x000833F4 File Offset: 0x000815F4
		// (set) Token: 0x0600028B RID: 651 RVA: 0x000034F6 File Offset: 0x000016F6
		public unsafe float _avoidValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__avoidValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__avoidValue)) = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0008341C File Offset: 0x0008161C
		// (set) Token: 0x0600028D RID: 653 RVA: 0x00003511 File Offset: 0x00001711
		public unsafe float _avoidDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__avoidDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__avoidDistance)) = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00083444 File Offset: 0x00081644
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0000352C File Offset: 0x0000172C
		public unsafe float _soarTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__soarTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__soarTimer)) = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0008346C File Offset: 0x0008166C
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00003547 File Offset: 0x00001747
		public unsafe bool _instantiated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__instantiated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__instantiated)) = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00083494 File Offset: 0x00081694
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00003562 File Offset: 0x00001762
		public unsafe static int _updateNextSeed
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FlockChild.NativeFieldInfoPtr__updateNextSeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlockChild.NativeFieldInfoPtr__updateNextSeed, (void*)(&value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000294 RID: 660 RVA: 0x000834B0 File Offset: 0x000816B0
		// (set) Token: 0x06000295 RID: 661 RVA: 0x00003570 File Offset: 0x00001770
		public unsafe int _updateSeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__updateSeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__updateSeed)) = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000296 RID: 662 RVA: 0x000834D8 File Offset: 0x000816D8
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0000358B File Offset: 0x0000178B
		public unsafe bool _avoid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__avoid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__avoid)) = value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00083500 File Offset: 0x00081700
		// (set) Token: 0x06000299 RID: 665 RVA: 0x000035A6 File Offset: 0x000017A6
		public unsafe Transform _thisT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__thisT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__thisT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00083530 File Offset: 0x00081730
		// (set) Token: 0x0600029B RID: 667 RVA: 0x000035C5 File Offset: 0x000017C5
		public unsafe Vector3 _landingPosOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__landingPosOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__landingPosOffset)) = value;
			}
		}

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr__spawner;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr__wayPoint;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr__speed;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr__dived;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr__stuckCounter;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr__damping;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr__soar;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr__landing;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr__targetSpeed;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr__move;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeFieldInfoPtr__model;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeFieldInfoPtr__modelT;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeFieldInfoPtr__avoidValue;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr__avoidDistance;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr__soarTimer;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr__instantiated;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr__updateNextSeed;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr__updateSeed;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr__avoid;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr__thisT;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr__landingPosOffset;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_FindRequiredComponents_Public_Void_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeStartAnimationFrame_Public_Void_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_InitAvoidanceValues_Public_Void_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_SetRandomScale_Public_Void_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_SoarTimeLimit_Public_Void_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_CheckForDistanceToWaypoint_Public_Void_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_RotationBasedOnWaypointOrAvoidance_Public_Void_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_Avoidance_Public_Boolean_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_LimitRotationOfModel_Public_Void_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_Wander_Public_Void_Single_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_SetRandomMode_Public_Void_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_Flap_Public_Void_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_findWaypoint_Public_Vector3_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_Soar_Public_Void_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_Dive_Public_Void_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_animationSpeed_Public_Void_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
