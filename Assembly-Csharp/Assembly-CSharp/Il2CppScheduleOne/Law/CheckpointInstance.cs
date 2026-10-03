using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000304 RID: 772
	[Serializable]
	public class CheckpointInstance : Object
	{
		// Token: 0x06003D40 RID: 15680 RVA: 0x00149C90 File Offset: 0x00147E90
		// Note: this type is marked as 'beforefieldinit'.
		static CheckpointInstance()
		{
			Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "CheckpointInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr);
			CheckpointInstance.NativeFieldInfoPtr_MIN_ACTIVATION_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "MIN_ACTIVATION_DISTANCE");
			CheckpointInstance.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "Location");
			CheckpointInstance.NativeFieldInfoPtr_MinMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "MinMembers");
			CheckpointInstance.NativeFieldInfoPtr_MaxMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "MaxMembers");
			CheckpointInstance.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "StartTime");
			CheckpointInstance.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "EndTime");
			CheckpointInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "IntensityRequirement");
			CheckpointInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "OnlyIfCurfewEnabled");
			CheckpointInstance.NativeFieldInfoPtr_checkPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "checkPoint");
			CheckpointInstance.NativeFieldInfoPtr__activeCheckpoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, "<activeCheckpoint>k__BackingField");
			CheckpointInstance.NativeMethodInfoPtr_get_activeCheckpoint_Public_get_RoadCheckpoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100671128);
			CheckpointInstance.NativeMethodInfoPtr_set_activeCheckpoint_Protected_set_Void_RoadCheckpoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100671129);
			CheckpointInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100671130);
			CheckpointInstance.NativeMethodInfoPtr_EnableCheckpoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100671131);
			CheckpointInstance.NativeMethodInfoPtr_DistanceRequirementsMet_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100671132);
			CheckpointInstance.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100671133);
			CheckpointInstance.NativeMethodInfoPtr_DisableCheckpoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100671134);
			CheckpointInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr, 100671135);
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x06003D41 RID: 15681 RVA: 0x00149E28 File Offset: 0x00148028
		// (set) Token: 0x06003D42 RID: 15682 RVA: 0x00149E68 File Offset: 0x00148068
		public unsafe RoadCheckpoint activeCheckpoint
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_get_activeCheckpoint_Public_get_RoadCheckpoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_set_activeCheckpoint_Protected_set_Void_RoadCheckpoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x00149EAC File Offset: 0x001480AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152070, RefRangeEnd = 152071, XrefRangeStart = 152042, XrefRangeEnd = 152070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x00149EE0 File Offset: 0x001480E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152107, RefRangeEnd = 152108, XrefRangeStart = 152071, XrefRangeEnd = 152107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableCheckpoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_EnableCheckpoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x00149F14 File Offset: 0x00148114
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 152126, RefRangeEnd = 152128, XrefRangeStart = 152108, XrefRangeEnd = 152126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DistanceRequirementsMet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_DistanceRequirementsMet_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D46 RID: 15686 RVA: 0x00149F50 File Offset: 0x00148150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152128, XrefRangeEnd = 152135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D47 RID: 15687 RVA: 0x00149F84 File Offset: 0x00148184
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152162, RefRangeEnd = 152163, XrefRangeStart = 152135, XrefRangeEnd = 152162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableCheckpoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr_DisableCheckpoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D48 RID: 15688 RVA: 0x00149FB8 File Offset: 0x001481B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152163, XrefRangeEnd = 152164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckpointInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckpointInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x0001E805 File Offset: 0x0001CA05
		public CheckpointInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06003D4A RID: 15690 RVA: 0x00149FF4 File Offset: 0x001481F4
		// (set) Token: 0x06003D4B RID: 15691 RVA: 0x0001E80E File Offset: 0x0001CA0E
		public unsafe static float MIN_ACTIVATION_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CheckpointInstance.NativeFieldInfoPtr_MIN_ACTIVATION_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CheckpointInstance.NativeFieldInfoPtr_MIN_ACTIVATION_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x06003D4C RID: 15692 RVA: 0x0014A010 File Offset: 0x00148210
		// (set) Token: 0x06003D4D RID: 15693 RVA: 0x0001E81C File Offset: 0x0001CA1C
		public unsafe CheckpointManager.ECheckpointLocation Location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_Location);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_Location)) = value;
			}
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x06003D4E RID: 15694 RVA: 0x0014A038 File Offset: 0x00148238
		// (set) Token: 0x06003D4F RID: 15695 RVA: 0x0001E837 File Offset: 0x0001CA37
		public unsafe int MinMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_MinMembers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_MinMembers)) = value;
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x06003D50 RID: 15696 RVA: 0x0014A060 File Offset: 0x00148260
		// (set) Token: 0x06003D51 RID: 15697 RVA: 0x0001E852 File Offset: 0x0001CA52
		public unsafe int MaxMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_MaxMembers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_MaxMembers)) = value;
			}
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06003D52 RID: 15698 RVA: 0x0014A088 File Offset: 0x00148288
		// (set) Token: 0x06003D53 RID: 15699 RVA: 0x0001E86D File Offset: 0x0001CA6D
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06003D54 RID: 15700 RVA: 0x0014A0B0 File Offset: 0x001482B0
		// (set) Token: 0x06003D55 RID: 15701 RVA: 0x0001E888 File Offset: 0x0001CA88
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06003D56 RID: 15702 RVA: 0x0014A0D8 File Offset: 0x001482D8
		// (set) Token: 0x06003D57 RID: 15703 RVA: 0x0001E8A3 File Offset: 0x0001CAA3
		public unsafe int IntensityRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06003D58 RID: 15704 RVA: 0x0014A100 File Offset: 0x00148300
		// (set) Token: 0x06003D59 RID: 15705 RVA: 0x0001E8BE File Offset: 0x0001CABE
		public unsafe bool OnlyIfCurfewEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled)) = value;
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06003D5A RID: 15706 RVA: 0x0014A128 File Offset: 0x00148328
		// (set) Token: 0x06003D5B RID: 15707 RVA: 0x0001E8D9 File Offset: 0x0001CAD9
		public unsafe RoadCheckpoint checkPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_checkPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr_checkPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x06003D5C RID: 15708 RVA: 0x0014A158 File Offset: 0x00148358
		// (set) Token: 0x06003D5D RID: 15709 RVA: 0x0001E8F8 File Offset: 0x0001CAF8
		public unsafe RoadCheckpoint _activeCheckpoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr__activeCheckpoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointInstance.NativeFieldInfoPtr__activeCheckpoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002963 RID: 10595
		private static readonly IntPtr NativeFieldInfoPtr_MIN_ACTIVATION_DISTANCE;

		// Token: 0x04002964 RID: 10596
		private static readonly IntPtr NativeFieldInfoPtr_Location;

		// Token: 0x04002965 RID: 10597
		private static readonly IntPtr NativeFieldInfoPtr_MinMembers;

		// Token: 0x04002966 RID: 10598
		private static readonly IntPtr NativeFieldInfoPtr_MaxMembers;

		// Token: 0x04002967 RID: 10599
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04002968 RID: 10600
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04002969 RID: 10601
		private static readonly IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x0400296A RID: 10602
		private static readonly IntPtr NativeFieldInfoPtr_OnlyIfCurfewEnabled;

		// Token: 0x0400296B RID: 10603
		private static readonly IntPtr NativeFieldInfoPtr_checkPoint;

		// Token: 0x0400296C RID: 10604
		private static readonly IntPtr NativeFieldInfoPtr__activeCheckpoint_k__BackingField;

		// Token: 0x0400296D RID: 10605
		private static readonly IntPtr NativeMethodInfoPtr_get_activeCheckpoint_Public_get_RoadCheckpoint_0;

		// Token: 0x0400296E RID: 10606
		private static readonly IntPtr NativeMethodInfoPtr_set_activeCheckpoint_Protected_set_Void_RoadCheckpoint_0;

		// Token: 0x0400296F RID: 10607
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x04002970 RID: 10608
		private static readonly IntPtr NativeMethodInfoPtr_EnableCheckpoint_Public_Void_0;

		// Token: 0x04002971 RID: 10609
		private static readonly IntPtr NativeMethodInfoPtr_DistanceRequirementsMet_Private_Boolean_0;

		// Token: 0x04002972 RID: 10610
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04002973 RID: 10611
		private static readonly IntPtr NativeMethodInfoPtr_DisableCheckpoint_Public_Void_0;

		// Token: 0x04002974 RID: 10612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
