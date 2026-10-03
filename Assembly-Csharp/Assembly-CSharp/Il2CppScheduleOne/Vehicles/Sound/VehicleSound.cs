using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Sound
{
	// Token: 0x020000E0 RID: 224
	public class VehicleSound : MonoBehaviour
	{
		// Token: 0x060015AB RID: 5547 RVA: 0x000C3AEC File Offset: 0x000C1CEC
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleSound()
		{
			Il2CppClassPointerStore<VehicleSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Sound", "VehicleSound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr);
			VehicleSound.NativeFieldInfoPtr_COLLISION_SOUND_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "COLLISION_SOUND_COOLDOWN");
			VehicleSound.NativeFieldInfoPtr_AUDIO_LERP_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "AUDIO_LERP_SPEED");
			VehicleSound.NativeFieldInfoPtr_MinCollisionMomentum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MinCollisionMomentum");
			VehicleSound.NativeFieldInfoPtr_MaxCollisionMomentum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MaxCollisionMomentum");
			VehicleSound.NativeFieldInfoPtr_MinCollisionVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MinCollisionVolume");
			VehicleSound.NativeFieldInfoPtr_MaxCollisionVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MaxCollisionVolume");
			VehicleSound.NativeFieldInfoPtr_MinCollisionPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MinCollisionPitch");
			VehicleSound.NativeFieldInfoPtr_MaxCollisionPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MaxCollisionPitch");
			VehicleSound.NativeFieldInfoPtr_EngineVolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineVolumeMultiplier");
			VehicleSound.NativeFieldInfoPtr_EnginePitchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EnginePitchMultiplier");
			VehicleSound.NativeFieldInfoPtr_EngineStartSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineStartSource");
			VehicleSound.NativeFieldInfoPtr_EngineIdleSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineIdleSource");
			VehicleSound.NativeFieldInfoPtr_EngineLoopSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineLoopSource");
			VehicleSound.NativeFieldInfoPtr_HandbrakeSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "HandbrakeSource");
			VehicleSound.NativeFieldInfoPtr_ImpactSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "ImpactSound");
			VehicleSound.NativeFieldInfoPtr_EngineLoopPitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineLoopPitchCurve");
			VehicleSound.NativeFieldInfoPtr_EngineLoopVolumeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineLoopVolumeCurve");
			VehicleSound.NativeFieldInfoPtr__Vehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "<Vehicle>k__BackingField");
			VehicleSound.NativeFieldInfoPtr_lastCollisionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "lastCollisionTime");
			VehicleSound.NativeFieldInfoPtr_lastCollisionMomentum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "lastCollisionMomentum");
			VehicleSound.NativeFieldInfoPtr_volumeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "volumeRoutine");
			VehicleSound.NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100666342);
			VehicleSound.NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100666343);
			VehicleSound.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100666344);
			VehicleSound.NativeMethodInfoPtr_EngineStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100666345);
			VehicleSound.NativeMethodInfoPtr_HandbrakeApplied_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100666346);
			VehicleSound.NativeMethodInfoPtr_StartUpdateVolume_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100666347);
			VehicleSound.NativeMethodInfoPtr_UpdateIdle_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100666348);
			VehicleSound.NativeMethodInfoPtr_UpdateEngineLoop_Private_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100666349);
			VehicleSound.NativeMethodInfoPtr_OnCollision_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100666350);
			VehicleSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100666351);
			VehicleSound.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100666352);
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x000C3D9C File Offset: 0x000C1F9C
		// (set) Token: 0x060015AD RID: 5549 RVA: 0x000C3DDC File Offset: 0x000C1FDC
		public unsafe LandVehicle Vehicle
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 43093, RefRangeEnd = 43137, XrefRangeStart = 43093, XrefRangeEnd = 43137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95124, XrefRangeEnd = 95125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x000C3E20 File Offset: 0x000C2020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95125, XrefRangeEnd = 95169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleSound.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x000C3E5C File Offset: 0x000C205C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95169, XrefRangeEnd = 95186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EngineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_EngineStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x000C3E90 File Offset: 0x000C2090
		[CallerCount(0)]
		public unsafe void HandbrakeApplied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_HandbrakeApplied_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000C3EC4 File Offset: 0x000C20C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95186, XrefRangeEnd = 95202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartUpdateVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_StartUpdateVolume_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x000C3EF8 File Offset: 0x000C20F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95212, RefRangeEnd = 95213, XrefRangeStart = 95202, XrefRangeEnd = 95212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIdle(bool engineRunning)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref engineRunning;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_UpdateIdle_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x000C3F38 File Offset: 0x000C2138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95225, RefRangeEnd = 95226, XrefRangeStart = 95213, XrefRangeEnd = 95225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEngineLoop(bool engineRunning, float normalizedspeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref engineRunning;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedspeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_UpdateEngineLoop_Private_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x000C3F84 File Offset: 0x000C2184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95226, XrefRangeEnd = 95246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollision(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_OnCollision_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x000C3FC8 File Offset: 0x000C21C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95246, XrefRangeEnd = 95247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x000C4004 File Offset: 0x000C2204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95247, XrefRangeEnd = 95252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0000BDEA File Offset: 0x00009FEA
		public VehicleSound(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x000C4044 File Offset: 0x000C2244
		// (set) Token: 0x060015B9 RID: 5561 RVA: 0x0000BDF3 File Offset: 0x00009FF3
		public unsafe static float COLLISION_SOUND_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleSound.NativeFieldInfoPtr_COLLISION_SOUND_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleSound.NativeFieldInfoPtr_COLLISION_SOUND_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x000C4060 File Offset: 0x000C2260
		// (set) Token: 0x060015BB RID: 5563 RVA: 0x0000BE01 File Offset: 0x0000A001
		public unsafe static float AUDIO_LERP_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleSound.NativeFieldInfoPtr_AUDIO_LERP_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleSound.NativeFieldInfoPtr_AUDIO_LERP_SPEED, (void*)(&value));
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x000C407C File Offset: 0x000C227C
		// (set) Token: 0x060015BD RID: 5565 RVA: 0x0000BE0F File Offset: 0x0000A00F
		public unsafe static float MinCollisionMomentum
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleSound.NativeFieldInfoPtr_MinCollisionMomentum, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleSound.NativeFieldInfoPtr_MinCollisionMomentum, (void*)(&value));
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x000C4098 File Offset: 0x000C2298
		// (set) Token: 0x060015BF RID: 5567 RVA: 0x0000BE1D File Offset: 0x0000A01D
		public unsafe static float MaxCollisionMomentum
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleSound.NativeFieldInfoPtr_MaxCollisionMomentum, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleSound.NativeFieldInfoPtr_MaxCollisionMomentum, (void*)(&value));
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x000C40B4 File Offset: 0x000C22B4
		// (set) Token: 0x060015C1 RID: 5569 RVA: 0x0000BE2B File Offset: 0x0000A02B
		public unsafe static float MinCollisionVolume
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleSound.NativeFieldInfoPtr_MinCollisionVolume, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleSound.NativeFieldInfoPtr_MinCollisionVolume, (void*)(&value));
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x000C40D0 File Offset: 0x000C22D0
		// (set) Token: 0x060015C3 RID: 5571 RVA: 0x0000BE39 File Offset: 0x0000A039
		public unsafe static float MaxCollisionVolume
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleSound.NativeFieldInfoPtr_MaxCollisionVolume, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleSound.NativeFieldInfoPtr_MaxCollisionVolume, (void*)(&value));
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x000C40EC File Offset: 0x000C22EC
		// (set) Token: 0x060015C5 RID: 5573 RVA: 0x0000BE47 File Offset: 0x0000A047
		public unsafe static float MinCollisionPitch
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleSound.NativeFieldInfoPtr_MinCollisionPitch, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleSound.NativeFieldInfoPtr_MinCollisionPitch, (void*)(&value));
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x000C4108 File Offset: 0x000C2308
		// (set) Token: 0x060015C7 RID: 5575 RVA: 0x0000BE55 File Offset: 0x0000A055
		public unsafe static float MaxCollisionPitch
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleSound.NativeFieldInfoPtr_MaxCollisionPitch, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleSound.NativeFieldInfoPtr_MaxCollisionPitch, (void*)(&value));
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x000C4124 File Offset: 0x000C2324
		// (set) Token: 0x060015C9 RID: 5577 RVA: 0x0000BE63 File Offset: 0x0000A063
		public unsafe float EngineVolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineVolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineVolumeMultiplier)) = value;
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x000C414C File Offset: 0x000C234C
		// (set) Token: 0x060015CB RID: 5579 RVA: 0x0000BE7E File Offset: 0x0000A07E
		public unsafe float EnginePitchMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EnginePitchMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EnginePitchMultiplier)) = value;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x000C4174 File Offset: 0x000C2374
		// (set) Token: 0x060015CD RID: 5581 RVA: 0x0000BE99 File Offset: 0x0000A099
		public unsafe AudioSourceController EngineStartSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineStartSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineStartSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x000C41A4 File Offset: 0x000C23A4
		// (set) Token: 0x060015CF RID: 5583 RVA: 0x0000BEB8 File Offset: 0x0000A0B8
		public unsafe AudioSourceController EngineIdleSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineIdleSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineIdleSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060015D0 RID: 5584 RVA: 0x000C41D4 File Offset: 0x000C23D4
		// (set) Token: 0x060015D1 RID: 5585 RVA: 0x0000BED7 File Offset: 0x0000A0D7
		public unsafe AudioSourceController EngineLoopSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x000C4204 File Offset: 0x000C2404
		// (set) Token: 0x060015D3 RID: 5587 RVA: 0x0000BEF6 File Offset: 0x0000A0F6
		public unsafe AudioSourceController HandbrakeSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_HandbrakeSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_HandbrakeSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x000C4234 File Offset: 0x000C2434
		// (set) Token: 0x060015D5 RID: 5589 RVA: 0x0000BF15 File Offset: 0x0000A115
		public unsafe AudioSourceController ImpactSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_ImpactSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_ImpactSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x000C4264 File Offset: 0x000C2464
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x0000BF34 File Offset: 0x0000A134
		public unsafe AnimationCurve EngineLoopPitchCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopPitchCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopPitchCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x000C4294 File Offset: 0x000C2494
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x0000BF53 File Offset: 0x0000A153
		public unsafe AnimationCurve EngineLoopVolumeCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopVolumeCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopVolumeCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x000C42C4 File Offset: 0x000C24C4
		// (set) Token: 0x060015DB RID: 5595 RVA: 0x0000BF72 File Offset: 0x0000A172
		public unsafe LandVehicle _Vehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr__Vehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr__Vehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x000C42F4 File Offset: 0x000C24F4
		// (set) Token: 0x060015DD RID: 5597 RVA: 0x0000BF91 File Offset: 0x0000A191
		public unsafe float lastCollisionTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_lastCollisionTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_lastCollisionTime)) = value;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x000C431C File Offset: 0x000C251C
		// (set) Token: 0x060015DF RID: 5599 RVA: 0x0000BFAC File Offset: 0x0000A1AC
		public unsafe float lastCollisionMomentum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_lastCollisionMomentum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_lastCollisionMomentum)) = value;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x000C4344 File Offset: 0x000C2544
		// (set) Token: 0x060015E1 RID: 5601 RVA: 0x0000BFC7 File Offset: 0x0000A1C7
		public unsafe Coroutine volumeRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_volumeRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_volumeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeFieldInfoPtr_COLLISION_SOUND_COOLDOWN;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeFieldInfoPtr_AUDIO_LERP_SPEED;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeFieldInfoPtr_MinCollisionMomentum;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeFieldInfoPtr_MaxCollisionMomentum;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeFieldInfoPtr_MinCollisionVolume;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeFieldInfoPtr_MaxCollisionVolume;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeFieldInfoPtr_MinCollisionPitch;

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeFieldInfoPtr_MaxCollisionPitch;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeFieldInfoPtr_EngineVolumeMultiplier;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeFieldInfoPtr_EnginePitchMultiplier;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeFieldInfoPtr_EngineStartSource;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeFieldInfoPtr_EngineIdleSource;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeFieldInfoPtr_EngineLoopSource;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeFieldInfoPtr_HandbrakeSource;

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeFieldInfoPtr_ImpactSound;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeFieldInfoPtr_EngineLoopPitchCurve;

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeFieldInfoPtr_EngineLoopVolumeCurve;

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeFieldInfoPtr__Vehicle_k__BackingField;

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeFieldInfoPtr_lastCollisionTime;

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeFieldInfoPtr_lastCollisionMomentum;

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeFieldInfoPtr_volumeRoutine;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0;

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeMethodInfoPtr_EngineStart_Private_Void_0;

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeMethodInfoPtr_HandbrakeApplied_Private_Void_0;

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeMethodInfoPtr_StartUpdateVolume_Private_Void_0;

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIdle_Private_Void_Boolean_0;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEngineLoop_Private_Void_Boolean_Single_0;

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeMethodInfoPtr_OnCollision_Private_Void_Collision_0;

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000921 RID: 2337
		[ObfuscatedName("ScheduleOne.Vehicles.Sound.VehicleSound+<<StartUpdateVolume>g__Routine|27_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D74A RID: 55114 RVA: 0x00359548 File Offset: 0x00357748
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique()
			{
				Il2CppClassPointerStore<VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "<<StartUpdateVolume>g__Routine|27_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr);
				VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, "<>1__state");
				VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, "<>2__current");
				VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, "<>4__this");
				VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100666353);
				VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100666354);
				VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100666355);
				VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100666356);
				VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100666357);
				VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100666358);
			}

			// Token: 0x0600D74B RID: 55115 RVA: 0x00359628 File Offset: 0x00357828
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D74C RID: 55116 RVA: 0x00359670 File Offset: 0x00357870
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D74D RID: 55117 RVA: 0x003596A4 File Offset: 0x003578A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95113, XrefRangeEnd = 95119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170041C2 RID: 16834
			// (get) Token: 0x0600D74E RID: 55118 RVA: 0x003596E0 File Offset: 0x003578E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D74F RID: 55119 RVA: 0x00359720 File Offset: 0x00357920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95119, XrefRangeEnd = 95124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170041C3 RID: 16835
			// (get) Token: 0x0600D750 RID: 55120 RVA: 0x00359754 File Offset: 0x00357954
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D751 RID: 55121 RVA: 0x0006526B File Offset: 0x0006346B
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041BF RID: 16831
			// (get) Token: 0x0600D752 RID: 55122 RVA: 0x00359794 File Offset: 0x00357994
			// (set) Token: 0x0600D753 RID: 55123 RVA: 0x00065274 File Offset: 0x00063474
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170041C0 RID: 16832
			// (get) Token: 0x0600D754 RID: 55124 RVA: 0x003597BC File Offset: 0x003579BC
			// (set) Token: 0x0600D755 RID: 55125 RVA: 0x0006528F File Offset: 0x0006348F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041C1 RID: 16833
			// (get) Token: 0x0600D756 RID: 55126 RVA: 0x003597EC File Offset: 0x003579EC
			// (set) Token: 0x0600D757 RID: 55127 RVA: 0x000652AE File Offset: 0x000634AE
			public unsafe VehicleSound __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleSound>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092C4 RID: 37572
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040092C5 RID: 37573
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040092C6 RID: 37574
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092C7 RID: 37575
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040092C8 RID: 37576
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092C9 RID: 37577
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040092CA RID: 37578
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040092CB RID: 37579
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092CC RID: 37580
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
