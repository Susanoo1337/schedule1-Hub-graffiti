using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000036 RID: 54
	public class LandingSpotController : MonoBehaviour
	{
		// Token: 0x06000374 RID: 884 RVA: 0x00085574 File Offset: 0x00083774
		// Note: this type is marked as 'beforefieldinit'.
		static LandingSpotController()
		{
			Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LandingSpotController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr);
			LandingSpotController.NativeFieldInfoPtr__randomRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_randomRotate");
			LandingSpotController.NativeFieldInfoPtr__autoCatchDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_autoCatchDelay");
			LandingSpotController.NativeFieldInfoPtr__autoDismountDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_autoDismountDelay");
			LandingSpotController.NativeFieldInfoPtr__maxBirdDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_maxBirdDistance");
			LandingSpotController.NativeFieldInfoPtr__minBirdDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_minBirdDistance");
			LandingSpotController.NativeFieldInfoPtr__takeClosest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_takeClosest");
			LandingSpotController.NativeFieldInfoPtr__flock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_flock");
			LandingSpotController.NativeFieldInfoPtr__landOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_landOnStart");
			LandingSpotController.NativeFieldInfoPtr__soarLand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_soarLand");
			LandingSpotController.NativeFieldInfoPtr__onlyBirdsAbove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_onlyBirdsAbove");
			LandingSpotController.NativeFieldInfoPtr__landingSpeedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_landingSpeedModifier");
			LandingSpotController.NativeFieldInfoPtr__landingTurnSpeedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_landingTurnSpeedModifier");
			LandingSpotController.NativeFieldInfoPtr__featherPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_featherPS");
			LandingSpotController.NativeFieldInfoPtr__thisT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_thisT");
			LandingSpotController.NativeFieldInfoPtr__activeLandingSpots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_activeLandingSpots");
			LandingSpotController.NativeFieldInfoPtr__snapLandDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_snapLandDistance");
			LandingSpotController.NativeFieldInfoPtr__landedRotateSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_landedRotateSpeed");
			LandingSpotController.NativeFieldInfoPtr__gizmoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_gizmoSize");
			LandingSpotController.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663633);
			LandingSpotController.NativeMethodInfoPtr_ScareAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663634);
			LandingSpotController.NativeMethodInfoPtr_ScareAll_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663635);
			LandingSpotController.NativeMethodInfoPtr_LandAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663636);
			LandingSpotController.NativeMethodInfoPtr_InstantLandOnStart_Public_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663637);
			LandingSpotController.NativeMethodInfoPtr_InstantLand_Public_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663638);
			LandingSpotController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663639);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00085798 File Offset: 0x00083998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68396, XrefRangeEnd = 68432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000857CC File Offset: 0x000839CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68449, RefRangeEnd = 68451, XrefRangeStart = 68432, XrefRangeEnd = 68449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScareAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_ScareAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00085800 File Offset: 0x00083A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68451, XrefRangeEnd = 68468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScareAll(float minDelay, float maxDelay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minDelay;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_ScareAll_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0008584C File Offset: 0x00083A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68468, XrefRangeEnd = 68483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LandAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_LandAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00085880 File Offset: 0x00083A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68483, XrefRangeEnd = 68488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InstantLandOnStart(float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_InstantLandOnStart_Public_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000858CC File Offset: 0x00083ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68488, XrefRangeEnd = 68493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InstantLand(float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_InstantLand_Public_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00085918 File Offset: 0x00083B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68493, XrefRangeEnd = 68494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandingSpotController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00003F4A File Offset: 0x0000214A
		public LandingSpotController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00085954 File Offset: 0x00083B54
		// (set) Token: 0x0600037E RID: 894 RVA: 0x00003F53 File Offset: 0x00002153
		public unsafe bool _randomRotate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__randomRotate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__randomRotate)) = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0008597C File Offset: 0x00083B7C
		// (set) Token: 0x06000380 RID: 896 RVA: 0x00003F6E File Offset: 0x0000216E
		public unsafe Vector2 _autoCatchDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__autoCatchDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__autoCatchDelay)) = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000381 RID: 897 RVA: 0x000859A4 File Offset: 0x00083BA4
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00003F89 File Offset: 0x00002189
		public unsafe Vector2 _autoDismountDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__autoDismountDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__autoDismountDelay)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000383 RID: 899 RVA: 0x000859CC File Offset: 0x00083BCC
		// (set) Token: 0x06000384 RID: 900 RVA: 0x00003FA4 File Offset: 0x000021A4
		public unsafe float _maxBirdDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__maxBirdDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__maxBirdDistance)) = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000385 RID: 901 RVA: 0x000859F4 File Offset: 0x00083BF4
		// (set) Token: 0x06000386 RID: 902 RVA: 0x00003FBF File Offset: 0x000021BF
		public unsafe float _minBirdDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__minBirdDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__minBirdDistance)) = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00085A1C File Offset: 0x00083C1C
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00003FDA File Offset: 0x000021DA
		public unsafe bool _takeClosest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__takeClosest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__takeClosest)) = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00085A44 File Offset: 0x00083C44
		// (set) Token: 0x0600038A RID: 906 RVA: 0x00003FF5 File Offset: 0x000021F5
		public unsafe FlockController _flock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__flock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__flock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00085A74 File Offset: 0x00083C74
		// (set) Token: 0x0600038C RID: 908 RVA: 0x00004014 File Offset: 0x00002214
		public unsafe bool _landOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landOnStart)) = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00085A9C File Offset: 0x00083C9C
		// (set) Token: 0x0600038E RID: 910 RVA: 0x0000402F File Offset: 0x0000222F
		public unsafe bool _soarLand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__soarLand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__soarLand)) = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00085AC4 File Offset: 0x00083CC4
		// (set) Token: 0x06000390 RID: 912 RVA: 0x0000404A File Offset: 0x0000224A
		public unsafe bool _onlyBirdsAbove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__onlyBirdsAbove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__onlyBirdsAbove)) = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00085AEC File Offset: 0x00083CEC
		// (set) Token: 0x06000392 RID: 914 RVA: 0x00004065 File Offset: 0x00002265
		public unsafe float _landingSpeedModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landingSpeedModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landingSpeedModifier)) = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00085B14 File Offset: 0x00083D14
		// (set) Token: 0x06000394 RID: 916 RVA: 0x00004080 File Offset: 0x00002280
		public unsafe float _landingTurnSpeedModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landingTurnSpeedModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landingTurnSpeedModifier)) = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00085B3C File Offset: 0x00083D3C
		// (set) Token: 0x06000396 RID: 918 RVA: 0x0000409B File Offset: 0x0000229B
		public unsafe Transform _featherPS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__featherPS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__featherPS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000397 RID: 919 RVA: 0x00085B6C File Offset: 0x00083D6C
		// (set) Token: 0x06000398 RID: 920 RVA: 0x000040BA File Offset: 0x000022BA
		public unsafe Transform _thisT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__thisT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__thisT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000399 RID: 921 RVA: 0x00085B9C File Offset: 0x00083D9C
		// (set) Token: 0x0600039A RID: 922 RVA: 0x000040D9 File Offset: 0x000022D9
		public unsafe int _activeLandingSpots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__activeLandingSpots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__activeLandingSpots)) = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00085BC4 File Offset: 0x00083DC4
		// (set) Token: 0x0600039C RID: 924 RVA: 0x000040F4 File Offset: 0x000022F4
		public unsafe float _snapLandDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__snapLandDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__snapLandDistance)) = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00085BEC File Offset: 0x00083DEC
		// (set) Token: 0x0600039E RID: 926 RVA: 0x0000410F File Offset: 0x0000230F
		public unsafe float _landedRotateSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landedRotateSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landedRotateSpeed)) = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00085C14 File Offset: 0x00083E14
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x0000412A File Offset: 0x0000232A
		public unsafe float _gizmoSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__gizmoSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__gizmoSize)) = value;
			}
		}

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr__randomRotate;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeFieldInfoPtr__autoCatchDelay;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeFieldInfoPtr__autoDismountDelay;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeFieldInfoPtr__maxBirdDistance;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeFieldInfoPtr__minBirdDistance;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr__takeClosest;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr__flock;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeFieldInfoPtr__landOnStart;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeFieldInfoPtr__soarLand;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeFieldInfoPtr__onlyBirdsAbove;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeFieldInfoPtr__landingSpeedModifier;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeFieldInfoPtr__landingTurnSpeedModifier;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeFieldInfoPtr__featherPS;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeFieldInfoPtr__thisT;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeFieldInfoPtr__activeLandingSpots;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeFieldInfoPtr__snapLandDistance;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeFieldInfoPtr__landedRotateSpeed;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeFieldInfoPtr__gizmoSize;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_ScareAll_Public_Void_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_ScareAll_Public_Void_Single_Single_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_LandAll_Public_Void_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_InstantLandOnStart_Public_IEnumerator_Single_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_InstantLand_Public_IEnumerator_Single_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000863 RID: 2147
		[ObfuscatedName("LandingSpotController+<InstantLand>d__23")]
		public sealed class _InstantLand_d__23 : Il2CppSystem.Object
		{
			// Token: 0x0600D064 RID: 53348 RVA: 0x003451E0 File Offset: 0x003433E0
			// Note: this type is marked as 'beforefieldinit'.
			static _InstantLand_d__23()
			{
				Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "<InstantLand>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr);
				LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, "<>1__state");
				LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, "<>2__current");
				LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, "delay");
				LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, "<>4__this");
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663640);
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663641);
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663642);
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663643);
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663644);
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663645);
			}

			// Token: 0x0600D065 RID: 53349 RVA: 0x003452D4 File Offset: 0x003434D4
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InstantLand_d__23(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D066 RID: 53350 RVA: 0x0034531C File Offset: 0x0034351C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D067 RID: 53351 RVA: 0x00345350 File Offset: 0x00343550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68372, XrefRangeEnd = 68379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F21 RID: 16161
			// (get) Token: 0x0600D068 RID: 53352 RVA: 0x0034538C File Offset: 0x0034358C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D069 RID: 53353 RVA: 0x003453CC File Offset: 0x003435CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68379, XrefRangeEnd = 68384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F22 RID: 16162
			// (get) Token: 0x0600D06A RID: 53354 RVA: 0x00345400 File Offset: 0x00343600
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D06B RID: 53355 RVA: 0x00062A78 File Offset: 0x00060C78
			public _InstantLand_d__23(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F1D RID: 16157
			// (get) Token: 0x0600D06C RID: 53356 RVA: 0x00345440 File Offset: 0x00343640
			// (set) Token: 0x0600D06D RID: 53357 RVA: 0x00062A81 File Offset: 0x00060C81
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F1E RID: 16158
			// (get) Token: 0x0600D06E RID: 53358 RVA: 0x00345468 File Offset: 0x00343668
			// (set) Token: 0x0600D06F RID: 53359 RVA: 0x00062A9C File Offset: 0x00060C9C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F1F RID: 16159
			// (get) Token: 0x0600D070 RID: 53360 RVA: 0x00345498 File Offset: 0x00343698
			// (set) Token: 0x0600D071 RID: 53361 RVA: 0x00062ABB File Offset: 0x00060CBB
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x17003F20 RID: 16160
			// (get) Token: 0x0600D072 RID: 53362 RVA: 0x003454C0 File Offset: 0x003436C0
			// (set) Token: 0x0600D073 RID: 53363 RVA: 0x00062AD6 File Offset: 0x00060CD6
			public unsafe LandingSpotController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandingSpotController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E08 RID: 36360
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008E09 RID: 36361
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008E0A RID: 36362
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x04008E0B RID: 36363
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E0C RID: 36364
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E0D RID: 36365
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E0E RID: 36366
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E0F RID: 36367
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E10 RID: 36368
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E11 RID: 36369
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000864 RID: 2148
		[ObfuscatedName("LandingSpotController+<InstantLandOnStart>d__22")]
		public sealed class _InstantLandOnStart_d__22 : Il2CppSystem.Object
		{
			// Token: 0x0600D074 RID: 53364 RVA: 0x003454F0 File Offset: 0x003436F0
			// Note: this type is marked as 'beforefieldinit'.
			static _InstantLandOnStart_d__22()
			{
				Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "<InstantLandOnStart>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr);
				LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, "<>1__state");
				LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, "<>2__current");
				LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, "delay");
				LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, "<>4__this");
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663646);
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663647);
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663648);
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663649);
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663650);
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663651);
			}

			// Token: 0x0600D075 RID: 53365 RVA: 0x003455E4 File Offset: 0x003437E4
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InstantLandOnStart_d__22(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D076 RID: 53366 RVA: 0x0034562C File Offset: 0x0034382C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D077 RID: 53367 RVA: 0x00345660 File Offset: 0x00343860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68384, XrefRangeEnd = 68391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F27 RID: 16167
			// (get) Token: 0x0600D078 RID: 53368 RVA: 0x0034569C File Offset: 0x0034389C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D079 RID: 53369 RVA: 0x003456DC File Offset: 0x003438DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68391, XrefRangeEnd = 68396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F28 RID: 16168
			// (get) Token: 0x0600D07A RID: 53370 RVA: 0x00345710 File Offset: 0x00343910
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D07B RID: 53371 RVA: 0x00062AF5 File Offset: 0x00060CF5
			public _InstantLandOnStart_d__22(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F23 RID: 16163
			// (get) Token: 0x0600D07C RID: 53372 RVA: 0x00345750 File Offset: 0x00343950
			// (set) Token: 0x0600D07D RID: 53373 RVA: 0x00062AFE File Offset: 0x00060CFE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F24 RID: 16164
			// (get) Token: 0x0600D07E RID: 53374 RVA: 0x00345778 File Offset: 0x00343978
			// (set) Token: 0x0600D07F RID: 53375 RVA: 0x00062B19 File Offset: 0x00060D19
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F25 RID: 16165
			// (get) Token: 0x0600D080 RID: 53376 RVA: 0x003457A8 File Offset: 0x003439A8
			// (set) Token: 0x0600D081 RID: 53377 RVA: 0x00062B38 File Offset: 0x00060D38
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x17003F26 RID: 16166
			// (get) Token: 0x0600D082 RID: 53378 RVA: 0x003457D0 File Offset: 0x003439D0
			// (set) Token: 0x0600D083 RID: 53379 RVA: 0x00062B53 File Offset: 0x00060D53
			public unsafe LandingSpotController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandingSpotController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E12 RID: 36370
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008E13 RID: 36371
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008E14 RID: 36372
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x04008E15 RID: 36373
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E16 RID: 36374
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E17 RID: 36375
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E18 RID: 36376
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E19 RID: 36377
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E1A RID: 36378
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E1B RID: 36379
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
