using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000541 RID: 1345
	public class PourableAngleLimit : MonoBehaviour
	{
		// Token: 0x06007ADB RID: 31451 RVA: 0x00220404 File Offset: 0x0021E604
		// Note: this type is marked as 'beforefieldinit'.
		static PourableAngleLimit()
		{
			Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "PourableAngleLimit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr);
			PourableAngleLimit.NativeFieldInfoPtr_Pourable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "Pourable");
			PourableAngleLimit.NativeFieldInfoPtr_Constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "Constraint");
			PourableAngleLimit.NativeFieldInfoPtr_AngleAtMaxFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "AngleAtMaxFill");
			PourableAngleLimit.NativeFieldInfoPtr_AngleAtMinFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "AngleAtMinFill");
			PourableAngleLimit.NativeFieldInfoPtr_PourAngleMaxFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "PourAngleMaxFill");
			PourableAngleLimit.NativeFieldInfoPtr_PourAngleMinFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "PourAngleMinFill");
			PourableAngleLimit.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, 100679107);
			PourableAngleLimit.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, 100679108);
			PourableAngleLimit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, 100679109);
		}

		// Token: 0x06007ADC RID: 31452 RVA: 0x002204E8 File Offset: 0x0021E6E8
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableAngleLimit.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007ADD RID: 31453 RVA: 0x0022051C File Offset: 0x0021E71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235215, XrefRangeEnd = 235217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableAngleLimit.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007ADE RID: 31454 RVA: 0x00220550 File Offset: 0x0021E750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235217, XrefRangeEnd = 235218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourableAngleLimit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableAngleLimit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007ADF RID: 31455 RVA: 0x0003A6F9 File Offset: 0x000388F9
		public PourableAngleLimit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002601 RID: 9729
		// (get) Token: 0x06007AE0 RID: 31456 RVA: 0x0022058C File Offset: 0x0021E78C
		// (set) Token: 0x06007AE1 RID: 31457 RVA: 0x0003A702 File Offset: 0x00038902
		public unsafe PourableModule Pourable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_Pourable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PourableModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_Pourable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002602 RID: 9730
		// (get) Token: 0x06007AE2 RID: 31458 RVA: 0x002205BC File Offset: 0x0021E7BC
		// (set) Token: 0x06007AE3 RID: 31459 RVA: 0x0003A721 File Offset: 0x00038921
		public unsafe DraggableConstraint Constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_Constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_Constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002603 RID: 9731
		// (get) Token: 0x06007AE4 RID: 31460 RVA: 0x002205EC File Offset: 0x0021E7EC
		// (set) Token: 0x06007AE5 RID: 31461 RVA: 0x0003A740 File Offset: 0x00038940
		public unsafe float AngleAtMaxFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_AngleAtMaxFill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_AngleAtMaxFill)) = value;
			}
		}

		// Token: 0x17002604 RID: 9732
		// (get) Token: 0x06007AE6 RID: 31462 RVA: 0x00220614 File Offset: 0x0021E814
		// (set) Token: 0x06007AE7 RID: 31463 RVA: 0x0003A75B File Offset: 0x0003895B
		public unsafe float AngleAtMinFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_AngleAtMinFill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_AngleAtMinFill)) = value;
			}
		}

		// Token: 0x17002605 RID: 9733
		// (get) Token: 0x06007AE8 RID: 31464 RVA: 0x0022063C File Offset: 0x0021E83C
		// (set) Token: 0x06007AE9 RID: 31465 RVA: 0x0003A776 File Offset: 0x00038976
		public unsafe float PourAngleMaxFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_PourAngleMaxFill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_PourAngleMaxFill)) = value;
			}
		}

		// Token: 0x17002606 RID: 9734
		// (get) Token: 0x06007AEA RID: 31466 RVA: 0x00220664 File Offset: 0x0021E864
		// (set) Token: 0x06007AEB RID: 31467 RVA: 0x0003A791 File Offset: 0x00038991
		public unsafe float PourAngleMinFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_PourAngleMinFill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_PourAngleMinFill)) = value;
			}
		}

		// Token: 0x040053C7 RID: 21447
		private static readonly IntPtr NativeFieldInfoPtr_Pourable;

		// Token: 0x040053C8 RID: 21448
		private static readonly IntPtr NativeFieldInfoPtr_Constraint;

		// Token: 0x040053C9 RID: 21449
		private static readonly IntPtr NativeFieldInfoPtr_AngleAtMaxFill;

		// Token: 0x040053CA RID: 21450
		private static readonly IntPtr NativeFieldInfoPtr_AngleAtMinFill;

		// Token: 0x040053CB RID: 21451
		private static readonly IntPtr NativeFieldInfoPtr_PourAngleMaxFill;

		// Token: 0x040053CC RID: 21452
		private static readonly IntPtr NativeFieldInfoPtr_PourAngleMinFill;

		// Token: 0x040053CD RID: 21453
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040053CE RID: 21454
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x040053CF RID: 21455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
