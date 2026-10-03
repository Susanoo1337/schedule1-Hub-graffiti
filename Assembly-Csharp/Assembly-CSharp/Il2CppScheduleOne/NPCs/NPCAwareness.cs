using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Noise;
using Il2CppScheduleOne.NPCs.Responses;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.Vision;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020005D5 RID: 1493
	public class NPCAwareness : MonoBehaviour
	{
		// Token: 0x060091D2 RID: 37330 RVA: 0x00277C7C File Offset: 0x00275E7C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCAwareness()
		{
			Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCAwareness");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr);
			NPCAwareness.NativeFieldInfoPtr_PLAYER_AIM_DETECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "PLAYER_AIM_DETECTION_RANGE");
			NPCAwareness.NativeFieldInfoPtr_AwarenessActiveByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "AwarenessActiveByDefault");
			NPCAwareness.NativeFieldInfoPtr_VisionCone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "VisionCone");
			NPCAwareness.NativeFieldInfoPtr_Listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "Listener");
			NPCAwareness.NativeFieldInfoPtr_Responses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "Responses");
			NPCAwareness.NativeFieldInfoPtr_onNoticedGeneralCrime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedGeneralCrime");
			NPCAwareness.NativeFieldInfoPtr_onNoticedPettyCrime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedPettyCrime");
			NPCAwareness.NativeFieldInfoPtr_onNoticedDrugDealing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedDrugDealing");
			NPCAwareness.NativeFieldInfoPtr_onNoticedPlayerViolatingCurfew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedPlayerViolatingCurfew");
			NPCAwareness.NativeFieldInfoPtr_onNoticedSuspiciousPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedSuspiciousPlayer");
			NPCAwareness.NativeFieldInfoPtr_onGunshotHeard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onGunshotHeard");
			NPCAwareness.NativeFieldInfoPtr_onExplosionHeard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onExplosionHeard");
			NPCAwareness.NativeFieldInfoPtr_onHitByCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onHitByCar");
			NPCAwareness.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "npc");
			NPCAwareness.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100682302);
			NPCAwareness.NativeMethodInfoPtr_SetAwarenessActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100682303);
			NPCAwareness.NativeMethodInfoPtr_VisionEvent_Public_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100682304);
			NPCAwareness.NativeMethodInfoPtr_NoiseEvent_Public_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100682305);
			NPCAwareness.NativeMethodInfoPtr_HitByCar_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100682306);
			NPCAwareness.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100682307);
		}

		// Token: 0x060091D3 RID: 37331 RVA: 0x00277E3C File Offset: 0x0027603C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267060, XrefRangeEnd = 267104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAwareness.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091D4 RID: 37332 RVA: 0x00277E78 File Offset: 0x00276078
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 267108, RefRangeEnd = 267119, XrefRangeStart = 267104, XrefRangeEnd = 267108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAwarenessActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr_SetAwarenessActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091D5 RID: 37333 RVA: 0x00277EB8 File Offset: 0x002760B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267119, XrefRangeEnd = 267132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisionEvent(VisionEventReceipt vEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr_VisionEvent_Public_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091D6 RID: 37334 RVA: 0x00277EFC File Offset: 0x002760FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267132, XrefRangeEnd = 267145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NoiseEvent(NoiseEvent nEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr_NoiseEvent_Public_Void_NoiseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091D7 RID: 37335 RVA: 0x00277F40 File Offset: 0x00276140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267145, XrefRangeEnd = 267152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HitByCar(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr_HitByCar_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091D8 RID: 37336 RVA: 0x00277F84 File Offset: 0x00276184
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 141599, RefRangeEnd = 141615, XrefRangeStart = 141599, XrefRangeEnd = 141615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCAwareness() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091D9 RID: 37337 RVA: 0x000447CE File Offset: 0x000429CE
		public NPCAwareness(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D0F RID: 11535
		// (get) Token: 0x060091DA RID: 37338 RVA: 0x00277FC0 File Offset: 0x002761C0
		// (set) Token: 0x060091DB RID: 37339 RVA: 0x000447D7 File Offset: 0x000429D7
		public unsafe static float PLAYER_AIM_DETECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCAwareness.NativeFieldInfoPtr_PLAYER_AIM_DETECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCAwareness.NativeFieldInfoPtr_PLAYER_AIM_DETECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17002D10 RID: 11536
		// (get) Token: 0x060091DC RID: 37340 RVA: 0x00277FDC File Offset: 0x002761DC
		// (set) Token: 0x060091DD RID: 37341 RVA: 0x000447E5 File Offset: 0x000429E5
		public unsafe bool AwarenessActiveByDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_AwarenessActiveByDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_AwarenessActiveByDefault)) = value;
			}
		}

		// Token: 0x17002D11 RID: 11537
		// (get) Token: 0x060091DE RID: 37342 RVA: 0x00278004 File Offset: 0x00276204
		// (set) Token: 0x060091DF RID: 37343 RVA: 0x00044800 File Offset: 0x00042A00
		public unsafe VisionCone VisionCone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_VisionCone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_VisionCone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D12 RID: 11538
		// (get) Token: 0x060091E0 RID: 37344 RVA: 0x00278034 File Offset: 0x00276234
		// (set) Token: 0x060091E1 RID: 37345 RVA: 0x0004481F File Offset: 0x00042A1F
		public unsafe Listener Listener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_Listener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Listener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_Listener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D13 RID: 11539
		// (get) Token: 0x060091E2 RID: 37346 RVA: 0x00278064 File Offset: 0x00276264
		// (set) Token: 0x060091E3 RID: 37347 RVA: 0x0004483E File Offset: 0x00042A3E
		public unsafe NPCResponses Responses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_Responses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCResponses>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_Responses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D14 RID: 11540
		// (get) Token: 0x060091E4 RID: 37348 RVA: 0x00278094 File Offset: 0x00276294
		// (set) Token: 0x060091E5 RID: 37349 RVA: 0x0004485D File Offset: 0x00042A5D
		public unsafe UnityEvent<Player> onNoticedGeneralCrime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedGeneralCrime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedGeneralCrime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D15 RID: 11541
		// (get) Token: 0x060091E6 RID: 37350 RVA: 0x002780C4 File Offset: 0x002762C4
		// (set) Token: 0x060091E7 RID: 37351 RVA: 0x0004487C File Offset: 0x00042A7C
		public unsafe UnityEvent<Player> onNoticedPettyCrime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedPettyCrime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedPettyCrime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D16 RID: 11542
		// (get) Token: 0x060091E8 RID: 37352 RVA: 0x002780F4 File Offset: 0x002762F4
		// (set) Token: 0x060091E9 RID: 37353 RVA: 0x0004489B File Offset: 0x00042A9B
		public unsafe UnityEvent<Player> onNoticedDrugDealing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedDrugDealing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedDrugDealing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D17 RID: 11543
		// (get) Token: 0x060091EA RID: 37354 RVA: 0x00278124 File Offset: 0x00276324
		// (set) Token: 0x060091EB RID: 37355 RVA: 0x000448BA File Offset: 0x00042ABA
		public unsafe UnityEvent<Player> onNoticedPlayerViolatingCurfew
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedPlayerViolatingCurfew);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedPlayerViolatingCurfew), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D18 RID: 11544
		// (get) Token: 0x060091EC RID: 37356 RVA: 0x00278154 File Offset: 0x00276354
		// (set) Token: 0x060091ED RID: 37357 RVA: 0x000448D9 File Offset: 0x00042AD9
		public unsafe UnityEvent<Player> onNoticedSuspiciousPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedSuspiciousPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedSuspiciousPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D19 RID: 11545
		// (get) Token: 0x060091EE RID: 37358 RVA: 0x00278184 File Offset: 0x00276384
		// (set) Token: 0x060091EF RID: 37359 RVA: 0x000448F8 File Offset: 0x00042AF8
		public unsafe UnityEvent<NoiseEvent> onGunshotHeard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onGunshotHeard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<NoiseEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onGunshotHeard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D1A RID: 11546
		// (get) Token: 0x060091F0 RID: 37360 RVA: 0x002781B4 File Offset: 0x002763B4
		// (set) Token: 0x060091F1 RID: 37361 RVA: 0x00044917 File Offset: 0x00042B17
		public unsafe UnityEvent<NoiseEvent> onExplosionHeard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onExplosionHeard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<NoiseEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onExplosionHeard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D1B RID: 11547
		// (get) Token: 0x060091F2 RID: 37362 RVA: 0x002781E4 File Offset: 0x002763E4
		// (set) Token: 0x060091F3 RID: 37363 RVA: 0x00044936 File Offset: 0x00042B36
		public unsafe UnityEvent<LandVehicle> onHitByCar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onHitByCar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onHitByCar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D1C RID: 11548
		// (get) Token: 0x060091F4 RID: 37364 RVA: 0x00278214 File Offset: 0x00276414
		// (set) Token: 0x060091F5 RID: 37365 RVA: 0x00044955 File Offset: 0x00042B55
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006454 RID: 25684
		private static readonly IntPtr NativeFieldInfoPtr_PLAYER_AIM_DETECTION_RANGE;

		// Token: 0x04006455 RID: 25685
		private static readonly IntPtr NativeFieldInfoPtr_AwarenessActiveByDefault;

		// Token: 0x04006456 RID: 25686
		private static readonly IntPtr NativeFieldInfoPtr_VisionCone;

		// Token: 0x04006457 RID: 25687
		private static readonly IntPtr NativeFieldInfoPtr_Listener;

		// Token: 0x04006458 RID: 25688
		private static readonly IntPtr NativeFieldInfoPtr_Responses;

		// Token: 0x04006459 RID: 25689
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedGeneralCrime;

		// Token: 0x0400645A RID: 25690
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedPettyCrime;

		// Token: 0x0400645B RID: 25691
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedDrugDealing;

		// Token: 0x0400645C RID: 25692
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedPlayerViolatingCurfew;

		// Token: 0x0400645D RID: 25693
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedSuspiciousPlayer;

		// Token: 0x0400645E RID: 25694
		private static readonly IntPtr NativeFieldInfoPtr_onGunshotHeard;

		// Token: 0x0400645F RID: 25695
		private static readonly IntPtr NativeFieldInfoPtr_onExplosionHeard;

		// Token: 0x04006460 RID: 25696
		private static readonly IntPtr NativeFieldInfoPtr_onHitByCar;

		// Token: 0x04006461 RID: 25697
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x04006462 RID: 25698
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04006463 RID: 25699
		private static readonly IntPtr NativeMethodInfoPtr_SetAwarenessActive_Public_Void_Boolean_0;

		// Token: 0x04006464 RID: 25700
		private static readonly IntPtr NativeMethodInfoPtr_VisionEvent_Public_Void_VisionEventReceipt_0;

		// Token: 0x04006465 RID: 25701
		private static readonly IntPtr NativeMethodInfoPtr_NoiseEvent_Public_Void_NoiseEvent_0;

		// Token: 0x04006466 RID: 25702
		private static readonly IntPtr NativeMethodInfoPtr_HitByCar_Public_Void_LandVehicle_0;

		// Token: 0x04006467 RID: 25703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
