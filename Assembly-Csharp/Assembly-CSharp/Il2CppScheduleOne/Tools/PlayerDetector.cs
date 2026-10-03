using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004F4 RID: 1268
	public class PlayerDetector : MonoBehaviour
	{
		// Token: 0x060072CE RID: 29390 RVA: 0x002049AC File Offset: 0x00202BAC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerDetector()
		{
			Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "PlayerDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr);
			PlayerDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "ACTIVATION_DISTANCE_SQ");
			PlayerDetector.NativeFieldInfoPtr_DetectPlayerInVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "DetectPlayerInVehicle");
			PlayerDetector.NativeFieldInfoPtr_onPlayerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "onPlayerEnter");
			PlayerDetector.NativeFieldInfoPtr_onPlayerExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "onPlayerExit");
			PlayerDetector.NativeFieldInfoPtr_onLocalPlayerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "onLocalPlayerEnter");
			PlayerDetector.NativeFieldInfoPtr_onLocalPlayerExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "onLocalPlayerExit");
			PlayerDetector.NativeFieldInfoPtr_DetectedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "DetectedPlayers");
			PlayerDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "<IgnoreNewDetections>k__BackingField");
			PlayerDetector.NativeFieldInfoPtr_ignoreExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "ignoreExit");
			PlayerDetector.NativeFieldInfoPtr_collidersEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "collidersEnabled");
			PlayerDetector.NativeFieldInfoPtr_detectionColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, "detectionColliders");
			PlayerDetector.NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678150);
			PlayerDetector.NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678151);
			PlayerDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678152);
			PlayerDetector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678153);
			PlayerDetector.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678154);
			PlayerDetector.NativeMethodInfoPtr_OnTick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678155);
			PlayerDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678156);
			PlayerDetector.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678157);
			PlayerDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678158);
			PlayerDetector.NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678159);
			PlayerDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr, 100678160);
		}

		// Token: 0x17002370 RID: 9072
		// (get) Token: 0x060072CF RID: 29391 RVA: 0x00204B94 File Offset: 0x00202D94
		// (set) Token: 0x060072D0 RID: 29392 RVA: 0x00204BD0 File Offset: 0x00202DD0
		public unsafe bool IgnoreNewDetections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060072D1 RID: 29393 RVA: 0x00204C10 File Offset: 0x00202E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226828, XrefRangeEnd = 226845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D2 RID: 29394 RVA: 0x00204C44 File Offset: 0x00202E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226845, XrefRangeEnd = 226867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D3 RID: 29395 RVA: 0x00204C78 File Offset: 0x00202E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226867, XrefRangeEnd = 226882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D4 RID: 29396 RVA: 0x00204CAC File Offset: 0x00202EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226882, XrefRangeEnd = 226898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_OnTick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D5 RID: 29397 RVA: 0x00204CE0 File Offset: 0x00202EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226898, XrefRangeEnd = 226951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D6 RID: 29398 RVA: 0x00204D24 File Offset: 0x00202F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226951, XrefRangeEnd = 226964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D7 RID: 29399 RVA: 0x00204D58 File Offset: 0x00202F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227017, RefRangeEnd = 227018, XrefRangeStart = 226964, XrefRangeEnd = 227017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D8 RID: 29400 RVA: 0x00204D9C File Offset: 0x00202F9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227025, RefRangeEnd = 227027, XrefRangeStart = 227018, XrefRangeEnd = 227025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIgnoreNewCollisions(bool ignore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D9 RID: 29401 RVA: 0x00204DDC File Offset: 0x00202FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227027, XrefRangeEnd = 227035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072DA RID: 29402 RVA: 0x00036926 File Offset: 0x00034B26
		public PlayerDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002365 RID: 9061
		// (get) Token: 0x060072DB RID: 29403 RVA: 0x00204E18 File Offset: 0x00203018
		// (set) Token: 0x060072DC RID: 29404 RVA: 0x0003692F File Offset: 0x00034B2F
		public unsafe static float ACTIVATION_DISTANCE_SQ
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ, (void*)(&value));
			}
		}

		// Token: 0x17002366 RID: 9062
		// (get) Token: 0x060072DD RID: 29405 RVA: 0x00204E34 File Offset: 0x00203034
		// (set) Token: 0x060072DE RID: 29406 RVA: 0x0003693D File Offset: 0x00034B3D
		public unsafe bool DetectPlayerInVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_DetectPlayerInVehicle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_DetectPlayerInVehicle)) = value;
			}
		}

		// Token: 0x17002367 RID: 9063
		// (get) Token: 0x060072DF RID: 29407 RVA: 0x00204E5C File Offset: 0x0020305C
		// (set) Token: 0x060072E0 RID: 29408 RVA: 0x00036958 File Offset: 0x00034B58
		public unsafe UnityEvent<Player> onPlayerEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onPlayerEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onPlayerEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002368 RID: 9064
		// (get) Token: 0x060072E1 RID: 29409 RVA: 0x00204E8C File Offset: 0x0020308C
		// (set) Token: 0x060072E2 RID: 29410 RVA: 0x00036977 File Offset: 0x00034B77
		public unsafe UnityEvent<Player> onPlayerExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onPlayerExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onPlayerExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002369 RID: 9065
		// (get) Token: 0x060072E3 RID: 29411 RVA: 0x00204EBC File Offset: 0x002030BC
		// (set) Token: 0x060072E4 RID: 29412 RVA: 0x00036996 File Offset: 0x00034B96
		public unsafe UnityEvent onLocalPlayerEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onLocalPlayerEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onLocalPlayerEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700236A RID: 9066
		// (get) Token: 0x060072E5 RID: 29413 RVA: 0x00204EEC File Offset: 0x002030EC
		// (set) Token: 0x060072E6 RID: 29414 RVA: 0x000369B5 File Offset: 0x00034BB5
		public unsafe UnityEvent onLocalPlayerExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onLocalPlayerExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_onLocalPlayerExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700236B RID: 9067
		// (get) Token: 0x060072E7 RID: 29415 RVA: 0x00204F1C File Offset: 0x0020311C
		// (set) Token: 0x060072E8 RID: 29416 RVA: 0x000369D4 File Offset: 0x00034BD4
		public unsafe List<Player> DetectedPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_DetectedPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_DetectedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700236C RID: 9068
		// (get) Token: 0x060072E9 RID: 29417 RVA: 0x00204F4C File Offset: 0x0020314C
		// (set) Token: 0x060072EA RID: 29418 RVA: 0x000369F3 File Offset: 0x00034BF3
		public unsafe bool _IgnoreNewDetections_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField)) = value;
			}
		}

		// Token: 0x1700236D RID: 9069
		// (get) Token: 0x060072EB RID: 29419 RVA: 0x00204F74 File Offset: 0x00203174
		// (set) Token: 0x060072EC RID: 29420 RVA: 0x00036A0E File Offset: 0x00034C0E
		public unsafe bool ignoreExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_ignoreExit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_ignoreExit)) = value;
			}
		}

		// Token: 0x1700236E RID: 9070
		// (get) Token: 0x060072ED RID: 29421 RVA: 0x00204F9C File Offset: 0x0020319C
		// (set) Token: 0x060072EE RID: 29422 RVA: 0x00036A29 File Offset: 0x00034C29
		public unsafe bool collidersEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_collidersEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_collidersEnabled)) = value;
			}
		}

		// Token: 0x1700236F RID: 9071
		// (get) Token: 0x060072EF RID: 29423 RVA: 0x00204FC4 File Offset: 0x002031C4
		// (set) Token: 0x060072F0 RID: 29424 RVA: 0x00036A44 File Offset: 0x00034C44
		public unsafe Il2CppReferenceArray<Collider> detectionColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_detectionColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDetector.NativeFieldInfoPtr_detectionColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E66 RID: 20070
		private static readonly IntPtr NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ;

		// Token: 0x04004E67 RID: 20071
		private static readonly IntPtr NativeFieldInfoPtr_DetectPlayerInVehicle;

		// Token: 0x04004E68 RID: 20072
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerEnter;

		// Token: 0x04004E69 RID: 20073
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerExit;

		// Token: 0x04004E6A RID: 20074
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerEnter;

		// Token: 0x04004E6B RID: 20075
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerExit;

		// Token: 0x04004E6C RID: 20076
		private static readonly IntPtr NativeFieldInfoPtr_DetectedPlayers;

		// Token: 0x04004E6D RID: 20077
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField;

		// Token: 0x04004E6E RID: 20078
		private static readonly IntPtr NativeFieldInfoPtr_ignoreExit;

		// Token: 0x04004E6F RID: 20079
		private static readonly IntPtr NativeFieldInfoPtr_collidersEnabled;

		// Token: 0x04004E70 RID: 20080
		private static readonly IntPtr NativeFieldInfoPtr_detectionColliders;

		// Token: 0x04004E71 RID: 20081
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0;

		// Token: 0x04004E72 RID: 20082
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0;

		// Token: 0x04004E73 RID: 20083
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004E74 RID: 20084
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004E75 RID: 20085
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004E76 RID: 20086
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Private_Void_0;

		// Token: 0x04004E77 RID: 20087
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x04004E78 RID: 20088
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004E79 RID: 20089
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;

		// Token: 0x04004E7A RID: 20090
		private static readonly IntPtr NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0;

		// Token: 0x04004E7B RID: 20091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
