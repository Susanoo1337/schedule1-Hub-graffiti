using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000031 RID: 49
	public class FlockController : MonoBehaviour
	{
		// Token: 0x060002BC RID: 700 RVA: 0x000839EC File Offset: 0x00081BEC
		// Note: this type is marked as 'beforefieldinit'.
		static FlockController()
		{
			Il2CppClassPointerStore<FlockController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlockController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlockController>.NativeClassPtr);
			FlockController.NativeFieldInfoPtr__childPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_childPrefab");
			FlockController.NativeFieldInfoPtr__childAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_childAmount");
			FlockController.NativeFieldInfoPtr__slowSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_slowSpawn");
			FlockController.NativeFieldInfoPtr__spawnSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_spawnSphere");
			FlockController.NativeFieldInfoPtr__spawnSphereHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_spawnSphereHeight");
			FlockController.NativeFieldInfoPtr__spawnSphereDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_spawnSphereDepth");
			FlockController.NativeFieldInfoPtr__minSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_minSpeed");
			FlockController.NativeFieldInfoPtr__maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_maxSpeed");
			FlockController.NativeFieldInfoPtr__minScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_minScale");
			FlockController.NativeFieldInfoPtr__maxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_maxScale");
			FlockController.NativeFieldInfoPtr__soarFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_soarFrequency");
			FlockController.NativeFieldInfoPtr__soarAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_soarAnimation");
			FlockController.NativeFieldInfoPtr__flapAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_flapAnimation");
			FlockController.NativeFieldInfoPtr__idleAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_idleAnimation");
			FlockController.NativeFieldInfoPtr__diveValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_diveValue");
			FlockController.NativeFieldInfoPtr__diveFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_diveFrequency");
			FlockController.NativeFieldInfoPtr__minDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_minDamping");
			FlockController.NativeFieldInfoPtr__maxDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_maxDamping");
			FlockController.NativeFieldInfoPtr__waypointDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_waypointDistance");
			FlockController.NativeFieldInfoPtr__minAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_minAnimationSpeed");
			FlockController.NativeFieldInfoPtr__maxAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_maxAnimationSpeed");
			FlockController.NativeFieldInfoPtr__randomPositionTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_randomPositionTimer");
			FlockController.NativeFieldInfoPtr__positionSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_positionSphere");
			FlockController.NativeFieldInfoPtr__positionSphereHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_positionSphereHeight");
			FlockController.NativeFieldInfoPtr__positionSphereDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_positionSphereDepth");
			FlockController.NativeFieldInfoPtr__childTriggerPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_childTriggerPos");
			FlockController.NativeFieldInfoPtr__forceChildWaypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_forceChildWaypoints");
			FlockController.NativeFieldInfoPtr__forcedRandomDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_forcedRandomDelay");
			FlockController.NativeFieldInfoPtr__flatFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_flatFly");
			FlockController.NativeFieldInfoPtr__flatSoar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_flatSoar");
			FlockController.NativeFieldInfoPtr__birdAvoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoid");
			FlockController.NativeFieldInfoPtr__birdAvoidHorizontalForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidHorizontalForce");
			FlockController.NativeFieldInfoPtr__birdAvoidDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidDown");
			FlockController.NativeFieldInfoPtr__birdAvoidUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidUp");
			FlockController.NativeFieldInfoPtr__birdAvoidVerticalForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidVerticalForce");
			FlockController.NativeFieldInfoPtr__birdAvoidDistanceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidDistanceMax");
			FlockController.NativeFieldInfoPtr__birdAvoidDistanceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidDistanceMin");
			FlockController.NativeFieldInfoPtr__soarMaxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_soarMaxTime");
			FlockController.NativeFieldInfoPtr__avoidanceMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_avoidanceMask");
			FlockController.NativeFieldInfoPtr__roamers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_roamers");
			FlockController.NativeFieldInfoPtr__posBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_posBuffer");
			FlockController.NativeFieldInfoPtr__updateDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_updateDivisor");
			FlockController.NativeFieldInfoPtr__newDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_newDelta");
			FlockController.NativeFieldInfoPtr__updateCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_updateCounter");
			FlockController.NativeFieldInfoPtr__activeChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_activeChildren");
			FlockController.NativeFieldInfoPtr__groupChildToNewTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_groupChildToNewTransform");
			FlockController.NativeFieldInfoPtr__groupTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_groupTransform");
			FlockController.NativeFieldInfoPtr__groupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_groupName");
			FlockController.NativeFieldInfoPtr__groupChildToFlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_groupChildToFlock");
			FlockController.NativeFieldInfoPtr__startPosOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_startPosOffset");
			FlockController.NativeFieldInfoPtr__thisT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_thisT");
			FlockController.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663595);
			FlockController.NativeMethodInfoPtr_AddChild_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663596);
			FlockController.NativeMethodInfoPtr_AddChildToParent_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663597);
			FlockController.NativeMethodInfoPtr_RemoveChild_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663598);
			FlockController.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663599);
			FlockController.NativeMethodInfoPtr_InstantiateGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663600);
			FlockController.NativeMethodInfoPtr_UpdateChildAmount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663601);
			FlockController.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663602);
			FlockController.NativeMethodInfoPtr_SetFlockRandomPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663603);
			FlockController.NativeMethodInfoPtr_destroyBirds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663604);
			FlockController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663605);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00083EF4 File Offset: 0x000820F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67842, XrefRangeEnd = 67849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00083F28 File Offset: 0x00082128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67886, RefRangeEnd = 67887, XrefRangeStart = 67849, XrefRangeEnd = 67886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChild(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_AddChild_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00083F68 File Offset: 0x00082168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67887, XrefRangeEnd = 67888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChildToParent(Transform obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_AddChildToParent_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00083FAC File Offset: 0x000821AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67888, XrefRangeEnd = 67900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveChild(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_RemoveChild_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00083FEC File Offset: 0x000821EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67900, XrefRangeEnd = 67916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00084020 File Offset: 0x00082220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67916, XrefRangeEnd = 67936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstantiateGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_InstantiateGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00084054 File Offset: 0x00082254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67936, XrefRangeEnd = 67949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateChildAmount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_UpdateChildAmount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00084088 File Offset: 0x00082288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67949, XrefRangeEnd = 67966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000840BC File Offset: 0x000822BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67984, RefRangeEnd = 67985, XrefRangeStart = 67966, XrefRangeEnd = 67984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFlockRandomPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_SetFlockRandomPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000840F0 File Offset: 0x000822F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67985, XrefRangeEnd = 67997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void destroyBirds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_destroyBirds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00084124 File Offset: 0x00082324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67997, XrefRangeEnd = 68015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlockController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlockController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00003760 File Offset: 0x00001960
		public FlockController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00084160 File Offset: 0x00082360
		// (set) Token: 0x060002CA RID: 714 RVA: 0x00003769 File Offset: 0x00001969
		public unsafe FlockChild _childPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockChild>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00084190 File Offset: 0x00082390
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00003788 File Offset: 0x00001988
		public unsafe int _childAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childAmount)) = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002CD RID: 717 RVA: 0x000841B8 File Offset: 0x000823B8
		// (set) Token: 0x060002CE RID: 718 RVA: 0x000037A3 File Offset: 0x000019A3
		public unsafe bool _slowSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__slowSpawn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__slowSpawn)) = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002CF RID: 719 RVA: 0x000841E0 File Offset: 0x000823E0
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x000037BE File Offset: 0x000019BE
		public unsafe float _spawnSphere
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphere);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphere)) = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00084208 File Offset: 0x00082408
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x000037D9 File Offset: 0x000019D9
		public unsafe float _spawnSphereHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphereHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphereHeight)) = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00084230 File Offset: 0x00082430
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x000037F4 File Offset: 0x000019F4
		public unsafe float _spawnSphereDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphereDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphereDepth)) = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00084258 File Offset: 0x00082458
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x0000380F File Offset: 0x00001A0F
		public unsafe float _minSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minSpeed)) = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00084280 File Offset: 0x00082480
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x0000382A File Offset: 0x00001A2A
		public unsafe float _maxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxSpeed)) = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x000842A8 File Offset: 0x000824A8
		// (set) Token: 0x060002DA RID: 730 RVA: 0x00003845 File Offset: 0x00001A45
		public unsafe float _minScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minScale)) = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002DB RID: 731 RVA: 0x000842D0 File Offset: 0x000824D0
		// (set) Token: 0x060002DC RID: 732 RVA: 0x00003860 File Offset: 0x00001A60
		public unsafe float _maxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxScale)) = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002DD RID: 733 RVA: 0x000842F8 File Offset: 0x000824F8
		// (set) Token: 0x060002DE RID: 734 RVA: 0x0000387B File Offset: 0x00001A7B
		public unsafe float _soarFrequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarFrequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarFrequency)) = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00084320 File Offset: 0x00082520
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x00003896 File Offset: 0x00001A96
		public unsafe string _soarAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarAnimation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarAnimation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00084348 File Offset: 0x00082548
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x000038B5 File Offset: 0x00001AB5
		public unsafe string _flapAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flapAnimation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flapAnimation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00084370 File Offset: 0x00082570
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x000038D4 File Offset: 0x00001AD4
		public unsafe string _idleAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__idleAnimation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__idleAnimation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00084398 File Offset: 0x00082598
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x000038F3 File Offset: 0x00001AF3
		public unsafe float _diveValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__diveValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__diveValue)) = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x000843C0 File Offset: 0x000825C0
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x0000390E File Offset: 0x00001B0E
		public unsafe float _diveFrequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__diveFrequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__diveFrequency)) = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x000843E8 File Offset: 0x000825E8
		// (set) Token: 0x060002EA RID: 746 RVA: 0x00003929 File Offset: 0x00001B29
		public unsafe float _minDamping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minDamping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minDamping)) = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00084410 File Offset: 0x00082610
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00003944 File Offset: 0x00001B44
		public unsafe float _maxDamping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxDamping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxDamping)) = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00084438 File Offset: 0x00082638
		// (set) Token: 0x060002EE RID: 750 RVA: 0x0000395F File Offset: 0x00001B5F
		public unsafe float _waypointDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__waypointDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__waypointDistance)) = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00084460 File Offset: 0x00082660
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x0000397A File Offset: 0x00001B7A
		public unsafe float _minAnimationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minAnimationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minAnimationSpeed)) = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00084488 File Offset: 0x00082688
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x00003995 File Offset: 0x00001B95
		public unsafe float _maxAnimationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxAnimationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxAnimationSpeed)) = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x000844B0 File Offset: 0x000826B0
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x000039B0 File Offset: 0x00001BB0
		public unsafe float _randomPositionTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__randomPositionTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__randomPositionTimer)) = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x000844D8 File Offset: 0x000826D8
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x000039CB File Offset: 0x00001BCB
		public unsafe float _positionSphere
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphere);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphere)) = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00084500 File Offset: 0x00082700
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x000039E6 File Offset: 0x00001BE6
		public unsafe float _positionSphereHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphereHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphereHeight)) = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00084528 File Offset: 0x00082728
		// (set) Token: 0x060002FA RID: 762 RVA: 0x00003A01 File Offset: 0x00001C01
		public unsafe float _positionSphereDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphereDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphereDepth)) = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002FB RID: 763 RVA: 0x00084550 File Offset: 0x00082750
		// (set) Token: 0x060002FC RID: 764 RVA: 0x00003A1C File Offset: 0x00001C1C
		public unsafe bool _childTriggerPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childTriggerPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childTriggerPos)) = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00084578 File Offset: 0x00082778
		// (set) Token: 0x060002FE RID: 766 RVA: 0x00003A37 File Offset: 0x00001C37
		public unsafe bool _forceChildWaypoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__forceChildWaypoints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__forceChildWaypoints)) = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002FF RID: 767 RVA: 0x000845A0 File Offset: 0x000827A0
		// (set) Token: 0x06000300 RID: 768 RVA: 0x00003A52 File Offset: 0x00001C52
		public unsafe float _forcedRandomDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__forcedRandomDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__forcedRandomDelay)) = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000301 RID: 769 RVA: 0x000845C8 File Offset: 0x000827C8
		// (set) Token: 0x06000302 RID: 770 RVA: 0x00003A6D File Offset: 0x00001C6D
		public unsafe bool _flatFly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flatFly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flatFly)) = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000303 RID: 771 RVA: 0x000845F0 File Offset: 0x000827F0
		// (set) Token: 0x06000304 RID: 772 RVA: 0x00003A88 File Offset: 0x00001C88
		public unsafe bool _flatSoar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flatSoar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flatSoar)) = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00084618 File Offset: 0x00082818
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00003AA3 File Offset: 0x00001CA3
		public unsafe bool _birdAvoid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoid)) = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00084640 File Offset: 0x00082840
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00003ABE File Offset: 0x00001CBE
		public unsafe int _birdAvoidHorizontalForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidHorizontalForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidHorizontalForce)) = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00084668 File Offset: 0x00082868
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00003AD9 File Offset: 0x00001CD9
		public unsafe bool _birdAvoidDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDown)) = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00084690 File Offset: 0x00082890
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00003AF4 File Offset: 0x00001CF4
		public unsafe bool _birdAvoidUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidUp)) = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600030D RID: 781 RVA: 0x000846B8 File Offset: 0x000828B8
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00003B0F File Offset: 0x00001D0F
		public unsafe int _birdAvoidVerticalForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidVerticalForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidVerticalForce)) = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600030F RID: 783 RVA: 0x000846E0 File Offset: 0x000828E0
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00003B2A File Offset: 0x00001D2A
		public unsafe float _birdAvoidDistanceMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDistanceMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDistanceMax)) = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00084708 File Offset: 0x00082908
		// (set) Token: 0x06000312 RID: 786 RVA: 0x00003B45 File Offset: 0x00001D45
		public unsafe float _birdAvoidDistanceMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDistanceMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDistanceMin)) = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00084730 File Offset: 0x00082930
		// (set) Token: 0x06000314 RID: 788 RVA: 0x00003B60 File Offset: 0x00001D60
		public unsafe float _soarMaxTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarMaxTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarMaxTime)) = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00084758 File Offset: 0x00082958
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00003B7B File Offset: 0x00001D7B
		public unsafe LayerMask _avoidanceMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__avoidanceMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__avoidanceMask)) = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00084780 File Offset: 0x00082980
		// (set) Token: 0x06000318 RID: 792 RVA: 0x00003B96 File Offset: 0x00001D96
		public unsafe List<FlockChild> _roamers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__roamers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FlockChild>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__roamers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000319 RID: 793 RVA: 0x000847B0 File Offset: 0x000829B0
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00003BB5 File Offset: 0x00001DB5
		public unsafe Vector3 _posBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__posBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__posBuffer)) = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600031B RID: 795 RVA: 0x000847D8 File Offset: 0x000829D8
		// (set) Token: 0x0600031C RID: 796 RVA: 0x00003BD0 File Offset: 0x00001DD0
		public unsafe int _updateDivisor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__updateDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__updateDivisor)) = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00084800 File Offset: 0x00082A00
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00003BEB File Offset: 0x00001DEB
		public unsafe float _newDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__newDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__newDelta)) = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00084828 File Offset: 0x00082A28
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00003C06 File Offset: 0x00001E06
		public unsafe int _updateCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__updateCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__updateCounter)) = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00084850 File Offset: 0x00082A50
		// (set) Token: 0x06000322 RID: 802 RVA: 0x00003C21 File Offset: 0x00001E21
		public unsafe float _activeChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__activeChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__activeChildren)) = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00084878 File Offset: 0x00082A78
		// (set) Token: 0x06000324 RID: 804 RVA: 0x00003C3C File Offset: 0x00001E3C
		public unsafe bool _groupChildToNewTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupChildToNewTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupChildToNewTransform)) = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000325 RID: 805 RVA: 0x000848A0 File Offset: 0x00082AA0
		// (set) Token: 0x06000326 RID: 806 RVA: 0x00003C57 File Offset: 0x00001E57
		public unsafe Transform _groupTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000327 RID: 807 RVA: 0x000848D0 File Offset: 0x00082AD0
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00003C76 File Offset: 0x00001E76
		public unsafe string _groupName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000329 RID: 809 RVA: 0x000848F8 File Offset: 0x00082AF8
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00003C95 File Offset: 0x00001E95
		public unsafe bool _groupChildToFlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupChildToFlock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupChildToFlock)) = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00084920 File Offset: 0x00082B20
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00003CB0 File Offset: 0x00001EB0
		public unsafe Vector3 _startPosOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__startPosOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__startPosOffset)) = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00084948 File Offset: 0x00082B48
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00003CCB File Offset: 0x00001ECB
		public unsafe Transform _thisT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__thisT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__thisT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeFieldInfoPtr__childPrefab;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeFieldInfoPtr__childAmount;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeFieldInfoPtr__slowSpawn;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeFieldInfoPtr__spawnSphere;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeFieldInfoPtr__spawnSphereHeight;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeFieldInfoPtr__spawnSphereDepth;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeFieldInfoPtr__minSpeed;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeFieldInfoPtr__maxSpeed;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeFieldInfoPtr__minScale;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeFieldInfoPtr__maxScale;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr__soarFrequency;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeFieldInfoPtr__soarAnimation;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeFieldInfoPtr__flapAnimation;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr__idleAnimation;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeFieldInfoPtr__diveValue;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr__diveFrequency;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr__minDamping;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeFieldInfoPtr__maxDamping;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeFieldInfoPtr__waypointDistance;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeFieldInfoPtr__minAnimationSpeed;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr__maxAnimationSpeed;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeFieldInfoPtr__randomPositionTimer;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeFieldInfoPtr__positionSphere;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr__positionSphereHeight;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr__positionSphereDepth;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr__childTriggerPos;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr__forceChildWaypoints;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr__forcedRandomDelay;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr__flatFly;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr__flatSoar;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoid;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidHorizontalForce;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidDown;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidUp;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidVerticalForce;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidDistanceMax;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidDistanceMin;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr__soarMaxTime;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeFieldInfoPtr__avoidanceMask;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeFieldInfoPtr__roamers;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeFieldInfoPtr__posBuffer;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeFieldInfoPtr__updateDivisor;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeFieldInfoPtr__newDelta;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeFieldInfoPtr__updateCounter;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeFieldInfoPtr__activeChildren;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr__groupChildToNewTransform;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeFieldInfoPtr__groupTransform;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr__groupName;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeFieldInfoPtr__groupChildToFlock;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeFieldInfoPtr__startPosOffset;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeFieldInfoPtr__thisT;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_AddChild_Public_Void_Int32_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_AddChildToParent_Public_Void_Transform_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChild_Public_Void_Int32_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateGroup_Public_Void_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChildAmount_Public_Void_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_SetFlockRandomPosition_Public_Void_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_destroyBirds_Public_Void_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
