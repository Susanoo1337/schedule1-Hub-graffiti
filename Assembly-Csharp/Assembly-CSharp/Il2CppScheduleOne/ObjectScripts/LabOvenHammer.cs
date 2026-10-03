using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005AD RID: 1453
	public class LabOvenHammer : MonoBehaviour
	{
		// Token: 0x06008927 RID: 35111 RVA: 0x002556A4 File Offset: 0x002538A4
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenHammer()
		{
			Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabOvenHammer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr);
			LabOvenHammer.NativeFieldInfoPtr_Draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "Draggable");
			LabOvenHammer.NativeFieldInfoPtr_Constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "Constraint");
			LabOvenHammer.NativeFieldInfoPtr_Rotator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "Rotator");
			LabOvenHammer.NativeFieldInfoPtr_CoM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "CoM");
			LabOvenHammer.NativeFieldInfoPtr_ImpactPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "ImpactPoint");
			LabOvenHammer.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "VelocityCalculator");
			LabOvenHammer.NativeFieldInfoPtr_MinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "MinHeight");
			LabOvenHammer.NativeFieldInfoPtr_MaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "MaxHeight");
			LabOvenHammer.NativeFieldInfoPtr_MinAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "MinAngle");
			LabOvenHammer.NativeFieldInfoPtr_MaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "MaxAngle");
			LabOvenHammer.NativeFieldInfoPtr_onCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "onCollision");
			LabOvenHammer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, 100680974);
			LabOvenHammer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, 100680975);
			LabOvenHammer.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, 100680976);
			LabOvenHammer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, 100680977);
		}

		// Token: 0x06008928 RID: 35112 RVA: 0x00255800 File Offset: 0x00253A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255458, XrefRangeEnd = 255460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenHammer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008929 RID: 35113 RVA: 0x00255834 File Offset: 0x00253A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255460, XrefRangeEnd = 255466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenHammer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600892A RID: 35114 RVA: 0x00255868 File Offset: 0x00253A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255466, XrefRangeEnd = 255469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenHammer.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600892B RID: 35115 RVA: 0x002558AC File Offset: 0x00253AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255469, XrefRangeEnd = 255470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenHammer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenHammer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600892C RID: 35116 RVA: 0x00041064 File Offset: 0x0003F264
		public LabOvenHammer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A7F RID: 10879
		// (get) Token: 0x0600892D RID: 35117 RVA: 0x002558E8 File Offset: 0x00253AE8
		// (set) Token: 0x0600892E RID: 35118 RVA: 0x0004106D File Offset: 0x0003F26D
		public unsafe Draggable Draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A80 RID: 10880
		// (get) Token: 0x0600892F RID: 35119 RVA: 0x00255918 File Offset: 0x00253B18
		// (set) Token: 0x06008930 RID: 35120 RVA: 0x0004108C File Offset: 0x0003F28C
		public unsafe DraggableConstraint Constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A81 RID: 10881
		// (get) Token: 0x06008931 RID: 35121 RVA: 0x00255948 File Offset: 0x00253B48
		// (set) Token: 0x06008932 RID: 35122 RVA: 0x000410AB File Offset: 0x0003F2AB
		public unsafe RotateRigidbodyToTarget Rotator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Rotator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RotateRigidbodyToTarget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Rotator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A82 RID: 10882
		// (get) Token: 0x06008933 RID: 35123 RVA: 0x00255978 File Offset: 0x00253B78
		// (set) Token: 0x06008934 RID: 35124 RVA: 0x000410CA File Offset: 0x0003F2CA
		public unsafe Transform CoM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_CoM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_CoM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A83 RID: 10883
		// (get) Token: 0x06008935 RID: 35125 RVA: 0x002559A8 File Offset: 0x00253BA8
		// (set) Token: 0x06008936 RID: 35126 RVA: 0x000410E9 File Offset: 0x0003F2E9
		public unsafe Transform ImpactPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_ImpactPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_ImpactPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A84 RID: 10884
		// (get) Token: 0x06008937 RID: 35127 RVA: 0x002559D8 File Offset: 0x00253BD8
		// (set) Token: 0x06008938 RID: 35128 RVA: 0x00041108 File Offset: 0x0003F308
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_VelocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A85 RID: 10885
		// (get) Token: 0x06008939 RID: 35129 RVA: 0x00255A08 File Offset: 0x00253C08
		// (set) Token: 0x0600893A RID: 35130 RVA: 0x00041127 File Offset: 0x0003F327
		public unsafe float MinHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MinHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MinHeight)) = value;
			}
		}

		// Token: 0x17002A86 RID: 10886
		// (get) Token: 0x0600893B RID: 35131 RVA: 0x00255A30 File Offset: 0x00253C30
		// (set) Token: 0x0600893C RID: 35132 RVA: 0x00041142 File Offset: 0x0003F342
		public unsafe float MaxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MaxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MaxHeight)) = value;
			}
		}

		// Token: 0x17002A87 RID: 10887
		// (get) Token: 0x0600893D RID: 35133 RVA: 0x00255A58 File Offset: 0x00253C58
		// (set) Token: 0x0600893E RID: 35134 RVA: 0x0004115D File Offset: 0x0003F35D
		public unsafe float MinAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MinAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MinAngle)) = value;
			}
		}

		// Token: 0x17002A88 RID: 10888
		// (get) Token: 0x0600893F RID: 35135 RVA: 0x00255A80 File Offset: 0x00253C80
		// (set) Token: 0x06008940 RID: 35136 RVA: 0x00041178 File Offset: 0x0003F378
		public unsafe float MaxAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MaxAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MaxAngle)) = value;
			}
		}

		// Token: 0x17002A89 RID: 10889
		// (get) Token: 0x06008941 RID: 35137 RVA: 0x00255AA8 File Offset: 0x00253CA8
		// (set) Token: 0x06008942 RID: 35138 RVA: 0x00041193 File Offset: 0x0003F393
		public unsafe UnityEvent<Collision> onCollision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_onCollision);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collision>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_onCollision), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005DD9 RID: 24025
		private static readonly IntPtr NativeFieldInfoPtr_Draggable;

		// Token: 0x04005DDA RID: 24026
		private static readonly IntPtr NativeFieldInfoPtr_Constraint;

		// Token: 0x04005DDB RID: 24027
		private static readonly IntPtr NativeFieldInfoPtr_Rotator;

		// Token: 0x04005DDC RID: 24028
		private static readonly IntPtr NativeFieldInfoPtr_CoM;

		// Token: 0x04005DDD RID: 24029
		private static readonly IntPtr NativeFieldInfoPtr_ImpactPoint;

		// Token: 0x04005DDE RID: 24030
		private static readonly IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x04005DDF RID: 24031
		private static readonly IntPtr NativeFieldInfoPtr_MinHeight;

		// Token: 0x04005DE0 RID: 24032
		private static readonly IntPtr NativeFieldInfoPtr_MaxHeight;

		// Token: 0x04005DE1 RID: 24033
		private static readonly IntPtr NativeFieldInfoPtr_MinAngle;

		// Token: 0x04005DE2 RID: 24034
		private static readonly IntPtr NativeFieldInfoPtr_MaxAngle;

		// Token: 0x04005DE3 RID: 24035
		private static readonly IntPtr NativeFieldInfoPtr_onCollision;

		// Token: 0x04005DE4 RID: 24036
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005DE5 RID: 24037
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005DE6 RID: 24038
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x04005DE7 RID: 24039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
