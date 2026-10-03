using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Experimental
{
	// Token: 0x020006F1 RID: 1777
	[Serializable]
	public class SkateboardSettings : Il2CppSystem.Object
	{
		// Token: 0x0600AB2D RID: 43821 RVA: 0x002D259C File Offset: 0x002D079C
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardSettings()
		{
			Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Experimental", "SkateboardSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr);
			SkateboardSettings.NativeFieldInfoPtr_TurnForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "TurnForce");
			SkateboardSettings.NativeFieldInfoPtr_TurnChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "TurnChangeRate");
			SkateboardSettings.NativeFieldInfoPtr_TurnReturnToRestRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "TurnReturnToRestRate");
			SkateboardSettings.NativeFieldInfoPtr_TurnSpeedBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "TurnSpeedBoost");
			SkateboardSettings.NativeFieldInfoPtr_TurnForceMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "TurnForceMap");
			SkateboardSettings.NativeFieldInfoPtr_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "Gravity");
			SkateboardSettings.NativeFieldInfoPtr_BrakeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "BrakeForce");
			SkateboardSettings.NativeFieldInfoPtr_ReverseTopSpeed_Kmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "ReverseTopSpeed_Kmh");
			SkateboardSettings.NativeFieldInfoPtr_RotationClampForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "RotationClampForce");
			SkateboardSettings.NativeFieldInfoPtr_FrictionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "FrictionEnabled");
			SkateboardSettings.NativeFieldInfoPtr_LongitudinalFrictionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "LongitudinalFrictionCurve");
			SkateboardSettings.NativeFieldInfoPtr_LongitudinalFrictionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "LongitudinalFrictionMultiplier");
			SkateboardSettings.NativeFieldInfoPtr_LateralFrictionForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "LateralFrictionForceMultiplier");
			SkateboardSettings.NativeFieldInfoPtr_JumpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "JumpForce");
			SkateboardSettings.NativeFieldInfoPtr_JumpDuration_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "JumpDuration_Min");
			SkateboardSettings.NativeFieldInfoPtr_JumpDuration_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "JumpDuration_Max");
			SkateboardSettings.NativeFieldInfoPtr_FrontAxleJumpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "FrontAxleJumpCurve");
			SkateboardSettings.NativeFieldInfoPtr_RearAxleJumpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "RearAxleJumpCurve");
			SkateboardSettings.NativeFieldInfoPtr_JumpForwardForceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "JumpForwardForceCurve");
			SkateboardSettings.NativeFieldInfoPtr_JumpForwardBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "JumpForwardBoost");
			SkateboardSettings.NativeFieldInfoPtr_HoverForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "HoverForce");
			SkateboardSettings.NativeFieldInfoPtr_HoverRayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "HoverRayLength");
			SkateboardSettings.NativeFieldInfoPtr_HoverHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "HoverHeight");
			SkateboardSettings.NativeFieldInfoPtr_Hover_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "Hover_P");
			SkateboardSettings.NativeFieldInfoPtr_Hover_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "Hover_I");
			SkateboardSettings.NativeFieldInfoPtr_Hover_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "Hover_D");
			SkateboardSettings.NativeFieldInfoPtr_TopSpeed_Kmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "TopSpeed_Kmh");
			SkateboardSettings.NativeFieldInfoPtr_PushForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "PushForceMultiplier");
			SkateboardSettings.NativeFieldInfoPtr_PushForceMultiplierMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "PushForceMultiplierMap");
			SkateboardSettings.NativeFieldInfoPtr_PushForceDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "PushForceDuration");
			SkateboardSettings.NativeFieldInfoPtr_PushDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "PushDelay");
			SkateboardSettings.NativeFieldInfoPtr_PushForceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "PushForceCurve");
			SkateboardSettings.NativeFieldInfoPtr_AirMovementEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "AirMovementEnabled");
			SkateboardSettings.NativeFieldInfoPtr_AirMovementForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "AirMovementForce");
			SkateboardSettings.NativeFieldInfoPtr_AirMovementJumpReductionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "AirMovementJumpReductionDuration");
			SkateboardSettings.NativeFieldInfoPtr_AirMovementJumpReductionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, "AirMovementJumpReductionCurve");
			SkateboardSettings.NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, 100685961);
			SkateboardSettings.NativeMethodInfoPtr_Clone_Public_SkateboardSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, 100685962);
			SkateboardSettings.NativeMethodInfoPtr_Blend_Public_SkateboardSettings_SkateboardSettings_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, 100685963);
			SkateboardSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr, 100685964);
		}

		// Token: 0x1700335A RID: 13146
		// (get) Token: 0x0600AB2E RID: 43822 RVA: 0x002D28EC File Offset: 0x002D0AEC
		public unsafe float TopSpeed_Ms
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 294852, RefRangeEnd = 294854, XrefRangeStart = 294852, XrefRangeEnd = 294852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardSettings.NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600AB2F RID: 43823 RVA: 0x002D2928 File Offset: 0x002D0B28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294899, RefRangeEnd = 294901, XrefRangeStart = 294854, XrefRangeEnd = 294899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardSettings Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardSettings.NativeMethodInfoPtr_Clone_Public_SkateboardSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkateboardSettings>(intPtr3) : null;
		}

		// Token: 0x0600AB30 RID: 43824 RVA: 0x002D2968 File Offset: 0x002D0B68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294981, RefRangeEnd = 294982, XrefRangeStart = 294901, XrefRangeEnd = 294981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardSettings Blend(SkateboardSettings other, float blendFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardSettings.NativeMethodInfoPtr_Blend_Public_SkateboardSettings_SkateboardSettings_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkateboardSettings>(intPtr3) : null;
		}

		// Token: 0x0600AB31 RID: 43825 RVA: 0x002D29C8 File Offset: 0x002D0BC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294983, RefRangeEnd = 294984, XrefRangeStart = 294982, XrefRangeEnd = 294983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB32 RID: 43826 RVA: 0x0004E100 File Offset: 0x0004C300
		public SkateboardSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003336 RID: 13110
		// (get) Token: 0x0600AB33 RID: 43827 RVA: 0x002D2A04 File Offset: 0x002D0C04
		// (set) Token: 0x0600AB34 RID: 43828 RVA: 0x0004E109 File Offset: 0x0004C309
		public unsafe float TurnForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_TurnForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_TurnForce)) = value;
			}
		}

		// Token: 0x17003337 RID: 13111
		// (get) Token: 0x0600AB35 RID: 43829 RVA: 0x002D2A2C File Offset: 0x002D0C2C
		// (set) Token: 0x0600AB36 RID: 43830 RVA: 0x0004E124 File Offset: 0x0004C324
		public unsafe float TurnChangeRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_TurnChangeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_TurnChangeRate)) = value;
			}
		}

		// Token: 0x17003338 RID: 13112
		// (get) Token: 0x0600AB37 RID: 43831 RVA: 0x002D2A54 File Offset: 0x002D0C54
		// (set) Token: 0x0600AB38 RID: 43832 RVA: 0x0004E13F File Offset: 0x0004C33F
		public unsafe float TurnReturnToRestRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_TurnReturnToRestRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_TurnReturnToRestRate)) = value;
			}
		}

		// Token: 0x17003339 RID: 13113
		// (get) Token: 0x0600AB39 RID: 43833 RVA: 0x002D2A7C File Offset: 0x002D0C7C
		// (set) Token: 0x0600AB3A RID: 43834 RVA: 0x0004E15A File Offset: 0x0004C35A
		public unsafe float TurnSpeedBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_TurnSpeedBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_TurnSpeedBoost)) = value;
			}
		}

		// Token: 0x1700333A RID: 13114
		// (get) Token: 0x0600AB3B RID: 43835 RVA: 0x002D2AA4 File Offset: 0x002D0CA4
		// (set) Token: 0x0600AB3C RID: 43836 RVA: 0x0004E175 File Offset: 0x0004C375
		public unsafe AnimationCurve TurnForceMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_TurnForceMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_TurnForceMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x0600AB3D RID: 43837 RVA: 0x002D2AD4 File Offset: 0x002D0CD4
		// (set) Token: 0x0600AB3E RID: 43838 RVA: 0x0004E194 File Offset: 0x0004C394
		public unsafe float Gravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_Gravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_Gravity)) = value;
			}
		}

		// Token: 0x1700333C RID: 13116
		// (get) Token: 0x0600AB3F RID: 43839 RVA: 0x002D2AFC File Offset: 0x002D0CFC
		// (set) Token: 0x0600AB40 RID: 43840 RVA: 0x0004E1AF File Offset: 0x0004C3AF
		public unsafe float BrakeForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_BrakeForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_BrakeForce)) = value;
			}
		}

		// Token: 0x1700333D RID: 13117
		// (get) Token: 0x0600AB41 RID: 43841 RVA: 0x002D2B24 File Offset: 0x002D0D24
		// (set) Token: 0x0600AB42 RID: 43842 RVA: 0x0004E1CA File Offset: 0x0004C3CA
		public unsafe float ReverseTopSpeed_Kmh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_ReverseTopSpeed_Kmh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_ReverseTopSpeed_Kmh)) = value;
			}
		}

		// Token: 0x1700333E RID: 13118
		// (get) Token: 0x0600AB43 RID: 43843 RVA: 0x002D2B4C File Offset: 0x002D0D4C
		// (set) Token: 0x0600AB44 RID: 43844 RVA: 0x0004E1E5 File Offset: 0x0004C3E5
		public unsafe float RotationClampForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_RotationClampForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_RotationClampForce)) = value;
			}
		}

		// Token: 0x1700333F RID: 13119
		// (get) Token: 0x0600AB45 RID: 43845 RVA: 0x002D2B74 File Offset: 0x002D0D74
		// (set) Token: 0x0600AB46 RID: 43846 RVA: 0x0004E200 File Offset: 0x0004C400
		public unsafe bool FrictionEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_FrictionEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_FrictionEnabled)) = value;
			}
		}

		// Token: 0x17003340 RID: 13120
		// (get) Token: 0x0600AB47 RID: 43847 RVA: 0x002D2B9C File Offset: 0x002D0D9C
		// (set) Token: 0x0600AB48 RID: 43848 RVA: 0x0004E21B File Offset: 0x0004C41B
		public unsafe AnimationCurve LongitudinalFrictionCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_LongitudinalFrictionCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_LongitudinalFrictionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003341 RID: 13121
		// (get) Token: 0x0600AB49 RID: 43849 RVA: 0x002D2BCC File Offset: 0x002D0DCC
		// (set) Token: 0x0600AB4A RID: 43850 RVA: 0x0004E23A File Offset: 0x0004C43A
		public unsafe float LongitudinalFrictionMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_LongitudinalFrictionMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_LongitudinalFrictionMultiplier)) = value;
			}
		}

		// Token: 0x17003342 RID: 13122
		// (get) Token: 0x0600AB4B RID: 43851 RVA: 0x002D2BF4 File Offset: 0x002D0DF4
		// (set) Token: 0x0600AB4C RID: 43852 RVA: 0x0004E255 File Offset: 0x0004C455
		public unsafe float LateralFrictionForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_LateralFrictionForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_LateralFrictionForceMultiplier)) = value;
			}
		}

		// Token: 0x17003343 RID: 13123
		// (get) Token: 0x0600AB4D RID: 43853 RVA: 0x002D2C1C File Offset: 0x002D0E1C
		// (set) Token: 0x0600AB4E RID: 43854 RVA: 0x0004E270 File Offset: 0x0004C470
		public unsafe float JumpForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_JumpForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_JumpForce)) = value;
			}
		}

		// Token: 0x17003344 RID: 13124
		// (get) Token: 0x0600AB4F RID: 43855 RVA: 0x002D2C44 File Offset: 0x002D0E44
		// (set) Token: 0x0600AB50 RID: 43856 RVA: 0x0004E28B File Offset: 0x0004C48B
		public unsafe float JumpDuration_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_JumpDuration_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_JumpDuration_Min)) = value;
			}
		}

		// Token: 0x17003345 RID: 13125
		// (get) Token: 0x0600AB51 RID: 43857 RVA: 0x002D2C6C File Offset: 0x002D0E6C
		// (set) Token: 0x0600AB52 RID: 43858 RVA: 0x0004E2A6 File Offset: 0x0004C4A6
		public unsafe float JumpDuration_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_JumpDuration_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_JumpDuration_Max)) = value;
			}
		}

		// Token: 0x17003346 RID: 13126
		// (get) Token: 0x0600AB53 RID: 43859 RVA: 0x002D2C94 File Offset: 0x002D0E94
		// (set) Token: 0x0600AB54 RID: 43860 RVA: 0x0004E2C1 File Offset: 0x0004C4C1
		public unsafe AnimationCurve FrontAxleJumpCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_FrontAxleJumpCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_FrontAxleJumpCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003347 RID: 13127
		// (get) Token: 0x0600AB55 RID: 43861 RVA: 0x002D2CC4 File Offset: 0x002D0EC4
		// (set) Token: 0x0600AB56 RID: 43862 RVA: 0x0004E2E0 File Offset: 0x0004C4E0
		public unsafe AnimationCurve RearAxleJumpCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_RearAxleJumpCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_RearAxleJumpCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003348 RID: 13128
		// (get) Token: 0x0600AB57 RID: 43863 RVA: 0x002D2CF4 File Offset: 0x002D0EF4
		// (set) Token: 0x0600AB58 RID: 43864 RVA: 0x0004E2FF File Offset: 0x0004C4FF
		public unsafe AnimationCurve JumpForwardForceCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_JumpForwardForceCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_JumpForwardForceCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003349 RID: 13129
		// (get) Token: 0x0600AB59 RID: 43865 RVA: 0x002D2D24 File Offset: 0x002D0F24
		// (set) Token: 0x0600AB5A RID: 43866 RVA: 0x0004E31E File Offset: 0x0004C51E
		public unsafe float JumpForwardBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_JumpForwardBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_JumpForwardBoost)) = value;
			}
		}

		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x0600AB5B RID: 43867 RVA: 0x002D2D4C File Offset: 0x002D0F4C
		// (set) Token: 0x0600AB5C RID: 43868 RVA: 0x0004E339 File Offset: 0x0004C539
		public unsafe float HoverForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_HoverForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_HoverForce)) = value;
			}
		}

		// Token: 0x1700334B RID: 13131
		// (get) Token: 0x0600AB5D RID: 43869 RVA: 0x002D2D74 File Offset: 0x002D0F74
		// (set) Token: 0x0600AB5E RID: 43870 RVA: 0x0004E354 File Offset: 0x0004C554
		public unsafe float HoverRayLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_HoverRayLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_HoverRayLength)) = value;
			}
		}

		// Token: 0x1700334C RID: 13132
		// (get) Token: 0x0600AB5F RID: 43871 RVA: 0x002D2D9C File Offset: 0x002D0F9C
		// (set) Token: 0x0600AB60 RID: 43872 RVA: 0x0004E36F File Offset: 0x0004C56F
		public unsafe float HoverHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_HoverHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_HoverHeight)) = value;
			}
		}

		// Token: 0x1700334D RID: 13133
		// (get) Token: 0x0600AB61 RID: 43873 RVA: 0x002D2DC4 File Offset: 0x002D0FC4
		// (set) Token: 0x0600AB62 RID: 43874 RVA: 0x0004E38A File Offset: 0x0004C58A
		public unsafe float Hover_P
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_Hover_P);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_Hover_P)) = value;
			}
		}

		// Token: 0x1700334E RID: 13134
		// (get) Token: 0x0600AB63 RID: 43875 RVA: 0x002D2DEC File Offset: 0x002D0FEC
		// (set) Token: 0x0600AB64 RID: 43876 RVA: 0x0004E3A5 File Offset: 0x0004C5A5
		public unsafe float Hover_I
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_Hover_I);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_Hover_I)) = value;
			}
		}

		// Token: 0x1700334F RID: 13135
		// (get) Token: 0x0600AB65 RID: 43877 RVA: 0x002D2E14 File Offset: 0x002D1014
		// (set) Token: 0x0600AB66 RID: 43878 RVA: 0x0004E3C0 File Offset: 0x0004C5C0
		public unsafe float Hover_D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_Hover_D);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_Hover_D)) = value;
			}
		}

		// Token: 0x17003350 RID: 13136
		// (get) Token: 0x0600AB67 RID: 43879 RVA: 0x002D2E3C File Offset: 0x002D103C
		// (set) Token: 0x0600AB68 RID: 43880 RVA: 0x0004E3DB File Offset: 0x0004C5DB
		public unsafe float TopSpeed_Kmh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_TopSpeed_Kmh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_TopSpeed_Kmh)) = value;
			}
		}

		// Token: 0x17003351 RID: 13137
		// (get) Token: 0x0600AB69 RID: 43881 RVA: 0x002D2E64 File Offset: 0x002D1064
		// (set) Token: 0x0600AB6A RID: 43882 RVA: 0x0004E3F6 File Offset: 0x0004C5F6
		public unsafe float PushForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_PushForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_PushForceMultiplier)) = value;
			}
		}

		// Token: 0x17003352 RID: 13138
		// (get) Token: 0x0600AB6B RID: 43883 RVA: 0x002D2E8C File Offset: 0x002D108C
		// (set) Token: 0x0600AB6C RID: 43884 RVA: 0x0004E411 File Offset: 0x0004C611
		public unsafe AnimationCurve PushForceMultiplierMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_PushForceMultiplierMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_PushForceMultiplierMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003353 RID: 13139
		// (get) Token: 0x0600AB6D RID: 43885 RVA: 0x002D2EBC File Offset: 0x002D10BC
		// (set) Token: 0x0600AB6E RID: 43886 RVA: 0x0004E430 File Offset: 0x0004C630
		public unsafe float PushForceDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_PushForceDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_PushForceDuration)) = value;
			}
		}

		// Token: 0x17003354 RID: 13140
		// (get) Token: 0x0600AB6F RID: 43887 RVA: 0x002D2EE4 File Offset: 0x002D10E4
		// (set) Token: 0x0600AB70 RID: 43888 RVA: 0x0004E44B File Offset: 0x0004C64B
		public unsafe float PushDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_PushDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_PushDelay)) = value;
			}
		}

		// Token: 0x17003355 RID: 13141
		// (get) Token: 0x0600AB71 RID: 43889 RVA: 0x002D2F0C File Offset: 0x002D110C
		// (set) Token: 0x0600AB72 RID: 43890 RVA: 0x0004E466 File Offset: 0x0004C666
		public unsafe AnimationCurve PushForceCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_PushForceCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_PushForceCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003356 RID: 13142
		// (get) Token: 0x0600AB73 RID: 43891 RVA: 0x002D2F3C File Offset: 0x002D113C
		// (set) Token: 0x0600AB74 RID: 43892 RVA: 0x0004E485 File Offset: 0x0004C685
		public unsafe bool AirMovementEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_AirMovementEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_AirMovementEnabled)) = value;
			}
		}

		// Token: 0x17003357 RID: 13143
		// (get) Token: 0x0600AB75 RID: 43893 RVA: 0x002D2F64 File Offset: 0x002D1164
		// (set) Token: 0x0600AB76 RID: 43894 RVA: 0x0004E4A0 File Offset: 0x0004C6A0
		public unsafe float AirMovementForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_AirMovementForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_AirMovementForce)) = value;
			}
		}

		// Token: 0x17003358 RID: 13144
		// (get) Token: 0x0600AB77 RID: 43895 RVA: 0x002D2F8C File Offset: 0x002D118C
		// (set) Token: 0x0600AB78 RID: 43896 RVA: 0x0004E4BB File Offset: 0x0004C6BB
		public unsafe float AirMovementJumpReductionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_AirMovementJumpReductionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_AirMovementJumpReductionDuration)) = value;
			}
		}

		// Token: 0x17003359 RID: 13145
		// (get) Token: 0x0600AB79 RID: 43897 RVA: 0x002D2FB4 File Offset: 0x002D11B4
		// (set) Token: 0x0600AB7A RID: 43898 RVA: 0x0004E4D6 File Offset: 0x0004C6D6
		public unsafe AnimationCurve AirMovementJumpReductionCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_AirMovementJumpReductionCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardSettings.NativeFieldInfoPtr_AirMovementJumpReductionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007644 RID: 30276
		private static readonly IntPtr NativeFieldInfoPtr_TurnForce;

		// Token: 0x04007645 RID: 30277
		private static readonly IntPtr NativeFieldInfoPtr_TurnChangeRate;

		// Token: 0x04007646 RID: 30278
		private static readonly IntPtr NativeFieldInfoPtr_TurnReturnToRestRate;

		// Token: 0x04007647 RID: 30279
		private static readonly IntPtr NativeFieldInfoPtr_TurnSpeedBoost;

		// Token: 0x04007648 RID: 30280
		private static readonly IntPtr NativeFieldInfoPtr_TurnForceMap;

		// Token: 0x04007649 RID: 30281
		private static readonly IntPtr NativeFieldInfoPtr_Gravity;

		// Token: 0x0400764A RID: 30282
		private static readonly IntPtr NativeFieldInfoPtr_BrakeForce;

		// Token: 0x0400764B RID: 30283
		private static readonly IntPtr NativeFieldInfoPtr_ReverseTopSpeed_Kmh;

		// Token: 0x0400764C RID: 30284
		private static readonly IntPtr NativeFieldInfoPtr_RotationClampForce;

		// Token: 0x0400764D RID: 30285
		private static readonly IntPtr NativeFieldInfoPtr_FrictionEnabled;

		// Token: 0x0400764E RID: 30286
		private static readonly IntPtr NativeFieldInfoPtr_LongitudinalFrictionCurve;

		// Token: 0x0400764F RID: 30287
		private static readonly IntPtr NativeFieldInfoPtr_LongitudinalFrictionMultiplier;

		// Token: 0x04007650 RID: 30288
		private static readonly IntPtr NativeFieldInfoPtr_LateralFrictionForceMultiplier;

		// Token: 0x04007651 RID: 30289
		private static readonly IntPtr NativeFieldInfoPtr_JumpForce;

		// Token: 0x04007652 RID: 30290
		private static readonly IntPtr NativeFieldInfoPtr_JumpDuration_Min;

		// Token: 0x04007653 RID: 30291
		private static readonly IntPtr NativeFieldInfoPtr_JumpDuration_Max;

		// Token: 0x04007654 RID: 30292
		private static readonly IntPtr NativeFieldInfoPtr_FrontAxleJumpCurve;

		// Token: 0x04007655 RID: 30293
		private static readonly IntPtr NativeFieldInfoPtr_RearAxleJumpCurve;

		// Token: 0x04007656 RID: 30294
		private static readonly IntPtr NativeFieldInfoPtr_JumpForwardForceCurve;

		// Token: 0x04007657 RID: 30295
		private static readonly IntPtr NativeFieldInfoPtr_JumpForwardBoost;

		// Token: 0x04007658 RID: 30296
		private static readonly IntPtr NativeFieldInfoPtr_HoverForce;

		// Token: 0x04007659 RID: 30297
		private static readonly IntPtr NativeFieldInfoPtr_HoverRayLength;

		// Token: 0x0400765A RID: 30298
		private static readonly IntPtr NativeFieldInfoPtr_HoverHeight;

		// Token: 0x0400765B RID: 30299
		private static readonly IntPtr NativeFieldInfoPtr_Hover_P;

		// Token: 0x0400765C RID: 30300
		private static readonly IntPtr NativeFieldInfoPtr_Hover_I;

		// Token: 0x0400765D RID: 30301
		private static readonly IntPtr NativeFieldInfoPtr_Hover_D;

		// Token: 0x0400765E RID: 30302
		private static readonly IntPtr NativeFieldInfoPtr_TopSpeed_Kmh;

		// Token: 0x0400765F RID: 30303
		private static readonly IntPtr NativeFieldInfoPtr_PushForceMultiplier;

		// Token: 0x04007660 RID: 30304
		private static readonly IntPtr NativeFieldInfoPtr_PushForceMultiplierMap;

		// Token: 0x04007661 RID: 30305
		private static readonly IntPtr NativeFieldInfoPtr_PushForceDuration;

		// Token: 0x04007662 RID: 30306
		private static readonly IntPtr NativeFieldInfoPtr_PushDelay;

		// Token: 0x04007663 RID: 30307
		private static readonly IntPtr NativeFieldInfoPtr_PushForceCurve;

		// Token: 0x04007664 RID: 30308
		private static readonly IntPtr NativeFieldInfoPtr_AirMovementEnabled;

		// Token: 0x04007665 RID: 30309
		private static readonly IntPtr NativeFieldInfoPtr_AirMovementForce;

		// Token: 0x04007666 RID: 30310
		private static readonly IntPtr NativeFieldInfoPtr_AirMovementJumpReductionDuration;

		// Token: 0x04007667 RID: 30311
		private static readonly IntPtr NativeFieldInfoPtr_AirMovementJumpReductionCurve;

		// Token: 0x04007668 RID: 30312
		private static readonly IntPtr NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0;

		// Token: 0x04007669 RID: 30313
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_SkateboardSettings_0;

		// Token: 0x0400766A RID: 30314
		private static readonly IntPtr NativeMethodInfoPtr_Blend_Public_SkateboardSettings_SkateboardSettings_Single_0;

		// Token: 0x0400766B RID: 30315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
