using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200067B RID: 1659
	public class PatrolGroup : Il2CppSystem.Object
	{
		// Token: 0x0600A00B RID: 40971 RVA: 0x002AAD24 File Offset: 0x002A8F24
		// Note: this type is marked as 'beforefieldinit'.
		static PatrolGroup()
		{
			Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "PatrolGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr);
			PatrolGroup.NativeFieldInfoPtr_Members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, "Members");
			PatrolGroup.NativeFieldInfoPtr_Route = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, "Route");
			PatrolGroup.NativeFieldInfoPtr_CurrentWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, "CurrentWaypoint");
			PatrolGroup.NativeMethodInfoPtr__ctor_Public_Void_FootPatrolRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100684425);
			PatrolGroup.NativeMethodInfoPtr_GetDestination_Public_Vector3_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100684426);
			PatrolGroup.NativeMethodInfoPtr_DisbandGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100684427);
			PatrolGroup.NativeMethodInfoPtr_AdvanceGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100684428);
			PatrolGroup.NativeMethodInfoPtr_GetMemberOffset_Private_Vector3_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100684429);
			PatrolGroup.NativeMethodInfoPtr_IsGroupReadyToAdvance_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100684430);
			PatrolGroup.NativeMethodInfoPtr_IsPaused_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr, 100684431);
		}

		// Token: 0x0600A00C RID: 40972 RVA: 0x002AAE1C File Offset: 0x002A901C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282798, RefRangeEnd = 282799, XrefRangeStart = 282789, XrefRangeEnd = 282798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PatrolGroup(FootPatrolRoute route) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr__ctor_Public_Void_FootPatrolRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A00D RID: 40973 RVA: 0x002AAE68 File Offset: 0x002A9068
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 282834, RefRangeEnd = 282837, XrefRangeStart = 282799, XrefRangeEnd = 282834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetDestination(NPC member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_GetDestination_Public_Vector3_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A00E RID: 40974 RVA: 0x002AAEB8 File Offset: 0x002A90B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282862, RefRangeEnd = 282864, XrefRangeStart = 282837, XrefRangeEnd = 282862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisbandGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_DisbandGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A00F RID: 40975 RVA: 0x002AAEEC File Offset: 0x002A90EC
		[CallerCount(0)]
		public unsafe void AdvanceGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_AdvanceGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A010 RID: 40976 RVA: 0x002AAF20 File Offset: 0x002A9120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282864, XrefRangeEnd = 282875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetMemberOffset(NPC member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_GetMemberOffset_Private_Vector3_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A011 RID: 40977 RVA: 0x002AAF70 File Offset: 0x002A9170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282875, XrefRangeEnd = 282883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGroupReadyToAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_IsGroupReadyToAdvance_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A012 RID: 40978 RVA: 0x002AAFAC File Offset: 0x002A91AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282883, XrefRangeEnd = 282902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPaused()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolGroup.NativeMethodInfoPtr_IsPaused_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A013 RID: 40979 RVA: 0x000499E3 File Offset: 0x00047BE3
		public PatrolGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003067 RID: 12391
		// (get) Token: 0x0600A014 RID: 40980 RVA: 0x002AAFE8 File Offset: 0x002A91E8
		// (set) Token: 0x0600A015 RID: 40981 RVA: 0x000499EC File Offset: 0x00047BEC
		public unsafe List<NPC> Members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_Members);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_Members), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003068 RID: 12392
		// (get) Token: 0x0600A016 RID: 40982 RVA: 0x002AB018 File Offset: 0x002A9218
		// (set) Token: 0x0600A017 RID: 40983 RVA: 0x00049A0B File Offset: 0x00047C0B
		public unsafe FootPatrolRoute Route
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_Route);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootPatrolRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_Route), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003069 RID: 12393
		// (get) Token: 0x0600A018 RID: 40984 RVA: 0x002AB048 File Offset: 0x002A9248
		// (set) Token: 0x0600A019 RID: 40985 RVA: 0x00049A2A File Offset: 0x00047C2A
		public unsafe int CurrentWaypoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_CurrentWaypoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolGroup.NativeFieldInfoPtr_CurrentWaypoint)) = value;
			}
		}

		// Token: 0x04006E70 RID: 28272
		private static readonly IntPtr NativeFieldInfoPtr_Members;

		// Token: 0x04006E71 RID: 28273
		private static readonly IntPtr NativeFieldInfoPtr_Route;

		// Token: 0x04006E72 RID: 28274
		private static readonly IntPtr NativeFieldInfoPtr_CurrentWaypoint;

		// Token: 0x04006E73 RID: 28275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FootPatrolRoute_0;

		// Token: 0x04006E74 RID: 28276
		private static readonly IntPtr NativeMethodInfoPtr_GetDestination_Public_Vector3_NPC_0;

		// Token: 0x04006E75 RID: 28277
		private static readonly IntPtr NativeMethodInfoPtr_DisbandGroup_Public_Void_0;

		// Token: 0x04006E76 RID: 28278
		private static readonly IntPtr NativeMethodInfoPtr_AdvanceGroup_Public_Void_0;

		// Token: 0x04006E77 RID: 28279
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberOffset_Private_Vector3_NPC_0;

		// Token: 0x04006E78 RID: 28280
		private static readonly IntPtr NativeMethodInfoPtr_IsGroupReadyToAdvance_Public_Boolean_0;

		// Token: 0x04006E79 RID: 28281
		private static readonly IntPtr NativeMethodInfoPtr_IsPaused_Public_Boolean_0;
	}
}
