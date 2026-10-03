using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020000E3 RID: 227
	[Serializable]
	public class DriveFlags : Object
	{
		// Token: 0x060015E9 RID: 5609 RVA: 0x000C44F0 File Offset: 0x000C26F0
		// Note: this type is marked as 'beforefieldinit'.
		static DriveFlags()
		{
			Il2CppClassPointerStore<DriveFlags>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "DriveFlags");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr);
			DriveFlags.NativeFieldInfoPtr_OverrideSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "OverrideSpeed");
			DriveFlags.NativeFieldInfoPtr_OverriddenSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "OverriddenSpeed");
			DriveFlags.NativeFieldInfoPtr_OverriddenReverseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "OverriddenReverseSpeed");
			DriveFlags.NativeFieldInfoPtr_SpeedLimitMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "SpeedLimitMultiplier");
			DriveFlags.NativeFieldInfoPtr_IgnoreTrafficLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "IgnoreTrafficLights");
			DriveFlags.NativeFieldInfoPtr_UseRoads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "UseRoads");
			DriveFlags.NativeFieldInfoPtr_StuckDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "StuckDetection");
			DriveFlags.NativeFieldInfoPtr_ObstacleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "ObstacleMode");
			DriveFlags.NativeFieldInfoPtr_AutoBrakeAtDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "AutoBrakeAtDestination");
			DriveFlags.NativeFieldInfoPtr_TurnBasedSpeedReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, "TurnBasedSpeedReduction");
			DriveFlags.NativeMethodInfoPtr_ResetFlags_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, 100666367);
			DriveFlags.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr, 100666368);
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x000C4610 File Offset: 0x000C2810
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95290, RefRangeEnd = 95292, XrefRangeStart = 95290, XrefRangeEnd = 95290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DriveFlags.NativeMethodInfoPtr_ResetFlags_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x000C4644 File Offset: 0x000C2844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95292, XrefRangeEnd = 95293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DriveFlags() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DriveFlags>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DriveFlags.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x0000C00E File Offset: 0x0000A20E
		public DriveFlags(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x000C4680 File Offset: 0x000C2880
		// (set) Token: 0x060015EE RID: 5614 RVA: 0x0000C017 File Offset: 0x0000A217
		public unsafe bool OverrideSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverrideSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverrideSpeed)) = value;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x000C46A8 File Offset: 0x000C28A8
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x0000C032 File Offset: 0x0000A232
		public unsafe float OverriddenSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverriddenSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverriddenSpeed)) = value;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x000C46D0 File Offset: 0x000C28D0
		// (set) Token: 0x060015F2 RID: 5618 RVA: 0x0000C04D File Offset: 0x0000A24D
		public unsafe float OverriddenReverseSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverriddenReverseSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_OverriddenReverseSpeed)) = value;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x000C46F8 File Offset: 0x000C28F8
		// (set) Token: 0x060015F4 RID: 5620 RVA: 0x0000C068 File Offset: 0x0000A268
		public unsafe float SpeedLimitMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_SpeedLimitMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_SpeedLimitMultiplier)) = value;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060015F5 RID: 5621 RVA: 0x000C4720 File Offset: 0x000C2920
		// (set) Token: 0x060015F6 RID: 5622 RVA: 0x0000C083 File Offset: 0x0000A283
		public unsafe bool IgnoreTrafficLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_IgnoreTrafficLights);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_IgnoreTrafficLights)) = value;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x000C4748 File Offset: 0x000C2948
		// (set) Token: 0x060015F8 RID: 5624 RVA: 0x0000C09E File Offset: 0x0000A29E
		public unsafe bool UseRoads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_UseRoads);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_UseRoads)) = value;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x000C4770 File Offset: 0x000C2970
		// (set) Token: 0x060015FA RID: 5626 RVA: 0x0000C0B9 File Offset: 0x0000A2B9
		public unsafe bool StuckDetection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_StuckDetection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_StuckDetection)) = value;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x000C4798 File Offset: 0x000C2998
		// (set) Token: 0x060015FC RID: 5628 RVA: 0x0000C0D4 File Offset: 0x0000A2D4
		public unsafe DriveFlags.EObstacleMode ObstacleMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_ObstacleMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_ObstacleMode)) = value;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x000C47C0 File Offset: 0x000C29C0
		// (set) Token: 0x060015FE RID: 5630 RVA: 0x0000C0EF File Offset: 0x0000A2EF
		public unsafe bool AutoBrakeAtDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_AutoBrakeAtDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_AutoBrakeAtDestination)) = value;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x000C47E8 File Offset: 0x000C29E8
		// (set) Token: 0x06001600 RID: 5632 RVA: 0x0000C10A File Offset: 0x0000A30A
		public unsafe bool TurnBasedSpeedReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_TurnBasedSpeedReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DriveFlags.NativeFieldInfoPtr_TurnBasedSpeedReduction)) = value;
			}
		}

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeFieldInfoPtr_OverrideSpeed;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeFieldInfoPtr_OverriddenSpeed;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeFieldInfoPtr_OverriddenReverseSpeed;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeFieldInfoPtr_SpeedLimitMultiplier;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreTrafficLights;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeFieldInfoPtr_UseRoads;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeFieldInfoPtr_StuckDetection;

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeFieldInfoPtr_ObstacleMode;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeFieldInfoPtr_AutoBrakeAtDestination;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeFieldInfoPtr_TurnBasedSpeedReduction;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeMethodInfoPtr_ResetFlags_Public_Void_0;

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000925 RID: 2341
		[OriginalName("Assembly-CSharp.dll", "", "EObstacleMode")]
		public enum EObstacleMode
		{
			// Token: 0x040092D9 RID: 37593
			Default,
			// Token: 0x040092DA RID: 37594
			IgnoreAll,
			// Token: 0x040092DB RID: 37595
			IgnoreOnlySquishy
		}
	}
}
