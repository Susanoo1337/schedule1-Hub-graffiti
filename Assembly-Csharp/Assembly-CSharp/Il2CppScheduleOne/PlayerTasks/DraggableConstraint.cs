using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000176 RID: 374
	public class DraggableConstraint : MonoBehaviour
	{
		// Token: 0x060025D3 RID: 9683 RVA: 0x000F869C File Offset: 0x000F689C
		// Note: this type is marked as 'beforefieldinit'.
		static DraggableConstraint()
		{
			Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "DraggableConstraint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr);
			DraggableConstraint.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "Container");
			DraggableConstraint.NativeFieldInfoPtr_Anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "Anchor");
			DraggableConstraint.NativeFieldInfoPtr_ProportionalZClamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "ProportionalZClamp");
			DraggableConstraint.NativeFieldInfoPtr_AlignUpToContainerPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "AlignUpToContainerPlane");
			DraggableConstraint.NativeFieldInfoPtr_ClampUpDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "ClampUpDirection");
			DraggableConstraint.NativeFieldInfoPtr_UpDirectionMaxDifference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "UpDirectionMaxDifference");
			DraggableConstraint.NativeFieldInfoPtr_startLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "startLocalPos");
			DraggableConstraint.NativeFieldInfoPtr_draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "draggable");
			DraggableConstraint.NativeFieldInfoPtr_joint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, "joint");
			DraggableConstraint.NativeMethodInfoPtr_get_RelativePos_Private_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668192);
			DraggableConstraint.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668193);
			DraggableConstraint.NativeMethodInfoPtr_SetContainer_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668194);
			DraggableConstraint.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668195);
			DraggableConstraint.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668196);
			DraggableConstraint.NativeMethodInfoPtr_ProportionalClamp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668197);
			DraggableConstraint.NativeMethodInfoPtr_LockRotationX_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668198);
			DraggableConstraint.NativeMethodInfoPtr_LockRotationY_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668199);
			DraggableConstraint.NativeMethodInfoPtr_AlignToContainerPlane_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668200);
			DraggableConstraint.NativeMethodInfoPtr_ClampUpRot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668201);
			DraggableConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr, 100668202);
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x060025D4 RID: 9684 RVA: 0x000F885C File Offset: 0x000F6A5C
		public unsafe Vector3 RelativePos
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 117116, RefRangeEnd = 117119, XrefRangeStart = 117106, XrefRangeEnd = 117116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_get_RelativePos_Private_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x000F8898 File Offset: 0x000F6A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117119, XrefRangeEnd = 117151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x000F88CC File Offset: 0x000F6ACC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 117171, RefRangeEnd = 117174, XrefRangeStart = 117151, XrefRangeEnd = 117171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContainer(Transform container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_SetContainer_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x000F8910 File Offset: 0x000F6B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117174, XrefRangeEnd = 117175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableConstraint.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x000F894C File Offset: 0x000F6B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117175, XrefRangeEnd = 117206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DraggableConstraint.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x000F8988 File Offset: 0x000F6B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117206, XrefRangeEnd = 117218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProportionalClamp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_ProportionalClamp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x000F89BC File Offset: 0x000F6BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117218, XrefRangeEnd = 117228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LockRotationX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_LockRotationX_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x000F89F0 File Offset: 0x000F6BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117228, XrefRangeEnd = 117238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LockRotationY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_LockRotationY_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x000F8A24 File Offset: 0x000F6C24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117252, RefRangeEnd = 117253, XrefRangeStart = 117238, XrefRangeEnd = 117252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignToContainerPlane()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_AlignToContainerPlane_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x000F8A58 File Offset: 0x000F6C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117253, XrefRangeEnd = 117267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampUpRot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr_ClampUpRot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x000F8A8C File Offset: 0x000F6C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117267, XrefRangeEnd = 117268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DraggableConstraint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DraggableConstraint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DraggableConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x00013EB0 File Offset: 0x000120B0
		public DraggableConstraint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x000F8AC8 File Offset: 0x000F6CC8
		// (set) Token: 0x060025E1 RID: 9697 RVA: 0x00013EB9 File Offset: 0x000120B9
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x060025E2 RID: 9698 RVA: 0x000F8AF8 File Offset: 0x000F6CF8
		// (set) Token: 0x060025E3 RID: 9699 RVA: 0x00013ED8 File Offset: 0x000120D8
		public unsafe Rigidbody Anchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_Anchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_Anchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x000F8B28 File Offset: 0x000F6D28
		// (set) Token: 0x060025E5 RID: 9701 RVA: 0x00013EF7 File Offset: 0x000120F7
		public unsafe bool ProportionalZClamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_ProportionalZClamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_ProportionalZClamp)) = value;
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x060025E6 RID: 9702 RVA: 0x000F8B50 File Offset: 0x000F6D50
		// (set) Token: 0x060025E7 RID: 9703 RVA: 0x00013F12 File Offset: 0x00012112
		public unsafe bool AlignUpToContainerPlane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_AlignUpToContainerPlane);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_AlignUpToContainerPlane)) = value;
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x060025E8 RID: 9704 RVA: 0x000F8B78 File Offset: 0x000F6D78
		// (set) Token: 0x060025E9 RID: 9705 RVA: 0x00013F2D File Offset: 0x0001212D
		public unsafe bool ClampUpDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_ClampUpDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_ClampUpDirection)) = value;
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x060025EA RID: 9706 RVA: 0x000F8BA0 File Offset: 0x000F6DA0
		// (set) Token: 0x060025EB RID: 9707 RVA: 0x00013F48 File Offset: 0x00012148
		public unsafe float UpDirectionMaxDifference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_UpDirectionMaxDifference);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_UpDirectionMaxDifference)) = value;
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x060025EC RID: 9708 RVA: 0x000F8BC8 File Offset: 0x000F6DC8
		// (set) Token: 0x060025ED RID: 9709 RVA: 0x00013F63 File Offset: 0x00012163
		public unsafe Vector3 startLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_startLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_startLocalPos)) = value;
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x000F8BF0 File Offset: 0x000F6DF0
		// (set) Token: 0x060025EF RID: 9711 RVA: 0x00013F7E File Offset: 0x0001217E
		public unsafe Draggable draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x060025F0 RID: 9712 RVA: 0x000F8C20 File Offset: 0x000F6E20
		// (set) Token: 0x060025F1 RID: 9713 RVA: 0x00013F9D File Offset: 0x0001219D
		public unsafe ConfigurableJoint joint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_joint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableJoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DraggableConstraint.NativeFieldInfoPtr_joint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A1E RID: 6686
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04001A1F RID: 6687
		private static readonly IntPtr NativeFieldInfoPtr_Anchor;

		// Token: 0x04001A20 RID: 6688
		private static readonly IntPtr NativeFieldInfoPtr_ProportionalZClamp;

		// Token: 0x04001A21 RID: 6689
		private static readonly IntPtr NativeFieldInfoPtr_AlignUpToContainerPlane;

		// Token: 0x04001A22 RID: 6690
		private static readonly IntPtr NativeFieldInfoPtr_ClampUpDirection;

		// Token: 0x04001A23 RID: 6691
		private static readonly IntPtr NativeFieldInfoPtr_UpDirectionMaxDifference;

		// Token: 0x04001A24 RID: 6692
		private static readonly IntPtr NativeFieldInfoPtr_startLocalPos;

		// Token: 0x04001A25 RID: 6693
		private static readonly IntPtr NativeFieldInfoPtr_draggable;

		// Token: 0x04001A26 RID: 6694
		private static readonly IntPtr NativeFieldInfoPtr_joint;

		// Token: 0x04001A27 RID: 6695
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativePos_Private_get_Vector3_0;

		// Token: 0x04001A28 RID: 6696
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001A29 RID: 6697
		private static readonly IntPtr NativeMethodInfoPtr_SetContainer_Public_Void_Transform_0;

		// Token: 0x04001A2A RID: 6698
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001A2B RID: 6699
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001A2C RID: 6700
		private static readonly IntPtr NativeMethodInfoPtr_ProportionalClamp_Private_Void_0;

		// Token: 0x04001A2D RID: 6701
		private static readonly IntPtr NativeMethodInfoPtr_LockRotationX_Private_Void_0;

		// Token: 0x04001A2E RID: 6702
		private static readonly IntPtr NativeMethodInfoPtr_LockRotationY_Private_Void_0;

		// Token: 0x04001A2F RID: 6703
		private static readonly IntPtr NativeMethodInfoPtr_AlignToContainerPlane_Private_Void_0;

		// Token: 0x04001A30 RID: 6704
		private static readonly IntPtr NativeMethodInfoPtr_ClampUpRot_Private_Void_0;

		// Token: 0x04001A31 RID: 6705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
