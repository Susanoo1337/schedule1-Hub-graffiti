using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Experimental
{
	// Token: 0x020006F2 RID: 1778
	public class SkateboardOverrideData : ScriptableObject
	{
		// Token: 0x0600AB7B RID: 43899 RVA: 0x002D2FE4 File Offset: 0x002D11E4
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardOverrideData()
		{
			Il2CppClassPointerStore<SkateboardOverrideData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Experimental", "SkateboardOverrideData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardOverrideData>.NativeClassPtr);
			SkateboardOverrideData.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardOverrideData>.NativeClassPtr, "Settings");
			SkateboardOverrideData.NativeFieldInfoPtr_Categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardOverrideData>.NativeClassPtr, "Categories");
			SkateboardOverrideData.NativeFieldInfoPtr_TurningFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardOverrideData>.NativeClassPtr, "TurningFlags");
			SkateboardOverrideData.NativeFieldInfoPtr_GeneralFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardOverrideData>.NativeClassPtr, "GeneralFlags");
			SkateboardOverrideData.NativeFieldInfoPtr_FrictionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardOverrideData>.NativeClassPtr, "FrictionFlags");
			SkateboardOverrideData.NativeFieldInfoPtr_JumpFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardOverrideData>.NativeClassPtr, "JumpFlags");
			SkateboardOverrideData.NativeFieldInfoPtr_HoverFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardOverrideData>.NativeClassPtr, "HoverFlags");
			SkateboardOverrideData.NativeFieldInfoPtr_PushingFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardOverrideData>.NativeClassPtr, "PushingFlags");
			SkateboardOverrideData.NativeFieldInfoPtr_AirMovementFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardOverrideData>.NativeClassPtr, "AirMovementFlags");
			SkateboardOverrideData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardOverrideData>.NativeClassPtr, 100685965);
		}

		// Token: 0x0600AB7C RID: 43900 RVA: 0x002D30DC File Offset: 0x002D12DC
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardOverrideData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardOverrideData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardOverrideData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB7D RID: 43901 RVA: 0x0004E4F5 File Offset: 0x0004C6F5
		public SkateboardOverrideData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700335B RID: 13147
		// (get) Token: 0x0600AB7E RID: 43902 RVA: 0x002D3118 File Offset: 0x002D1318
		// (set) Token: 0x0600AB7F RID: 43903 RVA: 0x0004E4FE File Offset: 0x0004C6FE
		public unsafe SkateboardSettings Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700335C RID: 13148
		// (get) Token: 0x0600AB80 RID: 43904 RVA: 0x002D3148 File Offset: 0x002D1348
		// (set) Token: 0x0600AB81 RID: 43905 RVA: 0x0004E51D File Offset: 0x0004C71D
		public unsafe SkateboardOverrideData.OverrideCategory Categories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_Categories);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_Categories)) = value;
			}
		}

		// Token: 0x1700335D RID: 13149
		// (get) Token: 0x0600AB82 RID: 43906 RVA: 0x002D3170 File Offset: 0x002D1370
		// (set) Token: 0x0600AB83 RID: 43907 RVA: 0x0004E538 File Offset: 0x0004C738
		public unsafe SkateboardOverrideData.TurningOverrides TurningFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_TurningFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_TurningFlags)) = value;
			}
		}

		// Token: 0x1700335E RID: 13150
		// (get) Token: 0x0600AB84 RID: 43908 RVA: 0x002D3198 File Offset: 0x002D1398
		// (set) Token: 0x0600AB85 RID: 43909 RVA: 0x0004E553 File Offset: 0x0004C753
		public unsafe SkateboardOverrideData.GeneralOverrides GeneralFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_GeneralFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_GeneralFlags)) = value;
			}
		}

		// Token: 0x1700335F RID: 13151
		// (get) Token: 0x0600AB86 RID: 43910 RVA: 0x002D31C0 File Offset: 0x002D13C0
		// (set) Token: 0x0600AB87 RID: 43911 RVA: 0x0004E56E File Offset: 0x0004C76E
		public unsafe SkateboardOverrideData.FrictionOverrides FrictionFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_FrictionFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_FrictionFlags)) = value;
			}
		}

		// Token: 0x17003360 RID: 13152
		// (get) Token: 0x0600AB88 RID: 43912 RVA: 0x002D31E8 File Offset: 0x002D13E8
		// (set) Token: 0x0600AB89 RID: 43913 RVA: 0x0004E589 File Offset: 0x0004C789
		public unsafe SkateboardOverrideData.JumpOverrides JumpFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_JumpFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_JumpFlags)) = value;
			}
		}

		// Token: 0x17003361 RID: 13153
		// (get) Token: 0x0600AB8A RID: 43914 RVA: 0x002D3210 File Offset: 0x002D1410
		// (set) Token: 0x0600AB8B RID: 43915 RVA: 0x0004E5A4 File Offset: 0x0004C7A4
		public unsafe SkateboardOverrideData.HoverOverrides HoverFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_HoverFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_HoverFlags)) = value;
			}
		}

		// Token: 0x17003362 RID: 13154
		// (get) Token: 0x0600AB8C RID: 43916 RVA: 0x002D3238 File Offset: 0x002D1438
		// (set) Token: 0x0600AB8D RID: 43917 RVA: 0x0004E5BF File Offset: 0x0004C7BF
		public unsafe SkateboardOverrideData.PushingOverrides PushingFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_PushingFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_PushingFlags)) = value;
			}
		}

		// Token: 0x17003363 RID: 13155
		// (get) Token: 0x0600AB8E RID: 43918 RVA: 0x002D3260 File Offset: 0x002D1460
		// (set) Token: 0x0600AB8F RID: 43919 RVA: 0x0004E5DA File Offset: 0x0004C7DA
		public unsafe SkateboardOverrideData.AirMovementOverrides AirMovementFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_AirMovementFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardOverrideData.NativeFieldInfoPtr_AirMovementFlags)) = value;
			}
		}

		// Token: 0x0400766C RID: 30316
		private static readonly IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x0400766D RID: 30317
		private static readonly IntPtr NativeFieldInfoPtr_Categories;

		// Token: 0x0400766E RID: 30318
		private static readonly IntPtr NativeFieldInfoPtr_TurningFlags;

		// Token: 0x0400766F RID: 30319
		private static readonly IntPtr NativeFieldInfoPtr_GeneralFlags;

		// Token: 0x04007670 RID: 30320
		private static readonly IntPtr NativeFieldInfoPtr_FrictionFlags;

		// Token: 0x04007671 RID: 30321
		private static readonly IntPtr NativeFieldInfoPtr_JumpFlags;

		// Token: 0x04007672 RID: 30322
		private static readonly IntPtr NativeFieldInfoPtr_HoverFlags;

		// Token: 0x04007673 RID: 30323
		private static readonly IntPtr NativeFieldInfoPtr_PushingFlags;

		// Token: 0x04007674 RID: 30324
		private static readonly IntPtr NativeFieldInfoPtr_AirMovementFlags;

		// Token: 0x04007675 RID: 30325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C9C RID: 3228
		[OriginalName("Assembly-CSharp.dll", "", "OverrideCategory")]
		[Flags]
		public enum OverrideCategory
		{
			// Token: 0x0400A474 RID: 42100
			None = 0,
			// Token: 0x0400A475 RID: 42101
			Turning = 1,
			// Token: 0x0400A476 RID: 42102
			General = 2,
			// Token: 0x0400A477 RID: 42103
			Friction = 4,
			// Token: 0x0400A478 RID: 42104
			Jump = 8,
			// Token: 0x0400A479 RID: 42105
			Hover = 16,
			// Token: 0x0400A47A RID: 42106
			Pushing = 32,
			// Token: 0x0400A47B RID: 42107
			AirMovement = 64
		}

		// Token: 0x02000C9D RID: 3229
		[OriginalName("Assembly-CSharp.dll", "", "TurningOverrides")]
		[Flags]
		public enum TurningOverrides
		{
			// Token: 0x0400A47D RID: 42109
			None = 0,
			// Token: 0x0400A47E RID: 42110
			TurnForce = 1,
			// Token: 0x0400A47F RID: 42111
			TurnChangeRate = 2,
			// Token: 0x0400A480 RID: 42112
			TurnReturnToRestRate = 4,
			// Token: 0x0400A481 RID: 42113
			TurnSpeedBoost = 8
		}

		// Token: 0x02000C9E RID: 3230
		[OriginalName("Assembly-CSharp.dll", "", "GeneralOverrides")]
		[Flags]
		public enum GeneralOverrides
		{
			// Token: 0x0400A483 RID: 42115
			None = 0,
			// Token: 0x0400A484 RID: 42116
			Gravity = 1,
			// Token: 0x0400A485 RID: 42117
			BrakeForce = 2,
			// Token: 0x0400A486 RID: 42118
			ReverseTopSpeed_Kmh = 4,
			// Token: 0x0400A487 RID: 42119
			RotationClampForce = 8
		}

		// Token: 0x02000C9F RID: 3231
		[OriginalName("Assembly-CSharp.dll", "", "FrictionOverrides")]
		[Flags]
		public enum FrictionOverrides
		{
			// Token: 0x0400A489 RID: 42121
			None = 0,
			// Token: 0x0400A48A RID: 42122
			LongitudinalFrictionMultiplier = 1,
			// Token: 0x0400A48B RID: 42123
			LateralFrictionForceMultiplier = 2
		}

		// Token: 0x02000CA0 RID: 3232
		[OriginalName("Assembly-CSharp.dll", "", "JumpOverrides")]
		[Flags]
		public enum JumpOverrides
		{
			// Token: 0x0400A48D RID: 42125
			None = 0,
			// Token: 0x0400A48E RID: 42126
			JumpForce = 1,
			// Token: 0x0400A48F RID: 42127
			JumpDuration_Min = 2,
			// Token: 0x0400A490 RID: 42128
			JumpDuration_Max = 4,
			// Token: 0x0400A491 RID: 42129
			JumpForwardBoost = 8
		}

		// Token: 0x02000CA1 RID: 3233
		[OriginalName("Assembly-CSharp.dll", "", "HoverOverrides")]
		[Flags]
		public enum HoverOverrides
		{
			// Token: 0x0400A493 RID: 42131
			None = 0,
			// Token: 0x0400A494 RID: 42132
			HoverForce = 1,
			// Token: 0x0400A495 RID: 42133
			HoverRayLength = 2,
			// Token: 0x0400A496 RID: 42134
			HoverHeight = 4,
			// Token: 0x0400A497 RID: 42135
			Hover_P = 8,
			// Token: 0x0400A498 RID: 42136
			Hover_I = 16,
			// Token: 0x0400A499 RID: 42137
			Hover_D = 32
		}

		// Token: 0x02000CA2 RID: 3234
		[OriginalName("Assembly-CSharp.dll", "", "PushingOverrides")]
		[Flags]
		public enum PushingOverrides
		{
			// Token: 0x0400A49B RID: 42139
			None = 0,
			// Token: 0x0400A49C RID: 42140
			TopSpeed_Kmh = 1,
			// Token: 0x0400A49D RID: 42141
			PushForceMultiplier = 2,
			// Token: 0x0400A49E RID: 42142
			PushForceDuration = 4,
			// Token: 0x0400A49F RID: 42143
			PushDelay = 8
		}

		// Token: 0x02000CA3 RID: 3235
		[OriginalName("Assembly-CSharp.dll", "", "AirMovementOverrides")]
		[Flags]
		public enum AirMovementOverrides
		{
			// Token: 0x0400A4A1 RID: 42145
			None = 0,
			// Token: 0x0400A4A2 RID: 42146
			AirMovementForce = 1,
			// Token: 0x0400A4A3 RID: 42147
			AirMovementJumpReductionDuration = 2
		}
	}
}
