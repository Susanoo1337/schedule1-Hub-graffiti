using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Gamepad;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000175 RID: 373
	public class Draggable : Clickable
	{
		// Token: 0x0600259B RID: 9627 RVA: 0x000F7CDC File Offset: 0x000F5EDC
		// Note: this type is marked as 'beforefieldinit'.
		static Draggable()
		{
			Il2CppClassPointerStore<Draggable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "Draggable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Draggable>.NativeClassPtr);
			Draggable.NativeFieldInfoPtr_DragForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "DragForceMultiplier");
			Draggable.NativeFieldInfoPtr_DragForceOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "DragForceOrigin");
			Draggable.NativeFieldInfoPtr_RotationEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "RotationEnabled");
			Draggable.NativeFieldInfoPtr_TorqueMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "TorqueMultiplier");
			Draggable.NativeFieldInfoPtr_RotationAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "RotationAxis");
			Draggable.NativeFieldInfoPtr_DragProjectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "DragProjectionMode");
			Draggable.NativeFieldInfoPtr_CustomDragPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "CustomDragPlane");
			Draggable.NativeFieldInfoPtr_DisableGravityWhenDragged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "DisableGravityWhenDragged");
			Draggable.NativeFieldInfoPtr_NormalRBDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "NormalRBDrag");
			Draggable.NativeFieldInfoPtr_HeldRBDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "HeldRBDrag");
			Draggable.NativeFieldInfoPtr_CanBeMultiDragged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "CanBeMultiDragged");
			Draggable.NativeFieldInfoPtr__gamepadPointerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "_gamepadPointerData");
			Draggable.NativeFieldInfoPtr__Rb_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "<Rb>k__BackingField");
			Draggable.NativeFieldInfoPtr__HoveredCursor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "<HoveredCursor>k__BackingField");
			Draggable.NativeFieldInfoPtr_idleUpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "idleUpForce");
			Draggable.NativeFieldInfoPtr_LocationRestrictionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "LocationRestrictionEnabled");
			Draggable.NativeFieldInfoPtr_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "Origin");
			Draggable.NativeFieldInfoPtr_MaxDistanceFromOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "MaxDistanceFromOrigin");
			Draggable.NativeFieldInfoPtr_onTriggerExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onTriggerExit");
			Draggable.NativeFieldInfoPtr_constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "constraint");
			Draggable.NativeMethodInfoPtr_get_Rb_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668178);
			Draggable.NativeMethodInfoPtr_set_Rb_Protected_set_Void_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668179);
			Draggable.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668180);
			Draggable.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668181);
			Draggable.NativeMethodInfoPtr_get_GamepadPointerData_Public_get_GamepadPointerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668182);
			Draggable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668183);
			Draggable.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668184);
			Draggable.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668185);
			Draggable.NativeMethodInfoPtr_PostFixedUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668186);
			Draggable.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668187);
			Draggable.NativeMethodInfoPtr_OnTriggerExit_Protected_Virtual_New_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668188);
			Draggable.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668189);
			Draggable.NativeMethodInfoPtr_EndClick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668190);
			Draggable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100668191);
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x0600259C RID: 9628 RVA: 0x000F7FB4 File Offset: 0x000F61B4
		// (set) Token: 0x0600259D RID: 9629 RVA: 0x000F7FF4 File Offset: 0x000F61F4
		public unsafe Rigidbody Rb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_Rb_Public_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 38417, RefRangeEnd = 38421, XrefRangeStart = 38417, XrefRangeEnd = 38421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_set_Rb_Protected_set_Void_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x000F8038 File Offset: 0x000F6238
		// (set) Token: 0x0600259F RID: 9631 RVA: 0x000F8080 File Offset: 0x000F6280
		public unsafe override CursorManager.ECursorType HoveredCursor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x000F80CC File Offset: 0x000F62CC
		public unsafe GamepadPointerData GamepadPointerData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_GamepadPointerData_Public_get_GamepadPointerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GamepadPointerData>(intPtr3) : null;
			}
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x000F810C File Offset: 0x000F630C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117038, RefRangeEnd = 117040, XrefRangeStart = 117022, XrefRangeEnd = 117038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x000F8148 File Offset: 0x000F6348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117067, RefRangeEnd = 117069, XrefRangeStart = 117040, XrefRangeEnd = 117067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x000F8184 File Offset: 0x000F6384
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x000F81C0 File Offset: 0x000F63C0
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostFixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_PostFixedUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x000F81FC File Offset: 0x000F63FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117081, RefRangeEnd = 117083, XrefRangeStart = 117069, XrefRangeEnd = 117081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x000F8238 File Offset: 0x000F6438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117083, XrefRangeEnd = 117086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_OnTriggerExit_Protected_Virtual_New_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x000F8288 File Offset: 0x000F6488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117090, RefRangeEnd = 117091, XrefRangeStart = 117086, XrefRangeEnd = 117090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x000F82D4 File Offset: 0x000F64D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117091, XrefRangeEnd = 117097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_EndClick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x000F8310 File Offset: 0x000F6510
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 117102, RefRangeEnd = 117106, XrefRangeStart = 117097, XrefRangeEnd = 117102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Draggable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Draggable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x00013C73 File Offset: 0x00011E73
		public Draggable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x060025AB RID: 9643 RVA: 0x000F834C File Offset: 0x000F654C
		// (set) Token: 0x060025AC RID: 9644 RVA: 0x00013C7C File Offset: 0x00011E7C
		public unsafe float DragForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragForceMultiplier)) = value;
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x060025AD RID: 9645 RVA: 0x000F8374 File Offset: 0x000F6574
		// (set) Token: 0x060025AE RID: 9646 RVA: 0x00013C97 File Offset: 0x00011E97
		public unsafe Transform DragForceOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragForceOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragForceOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x060025AF RID: 9647 RVA: 0x000F83A4 File Offset: 0x000F65A4
		// (set) Token: 0x060025B0 RID: 9648 RVA: 0x00013CB6 File Offset: 0x00011EB6
		public unsafe bool RotationEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_RotationEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_RotationEnabled)) = value;
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x000F83CC File Offset: 0x000F65CC
		// (set) Token: 0x060025B2 RID: 9650 RVA: 0x00013CD1 File Offset: 0x00011ED1
		public unsafe float TorqueMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_TorqueMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_TorqueMultiplier)) = value;
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x000F83F4 File Offset: 0x000F65F4
		// (set) Token: 0x060025B4 RID: 9652 RVA: 0x00013CEC File Offset: 0x00011EEC
		public unsafe Draggable.ERotationAxis RotationAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_RotationAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_RotationAxis)) = value;
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x060025B5 RID: 9653 RVA: 0x000F841C File Offset: 0x000F661C
		// (set) Token: 0x060025B6 RID: 9654 RVA: 0x00013D07 File Offset: 0x00011F07
		public unsafe Draggable.EDragProjectionMode DragProjectionMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragProjectionMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragProjectionMode)) = value;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x000F8444 File Offset: 0x000F6644
		// (set) Token: 0x060025B8 RID: 9656 RVA: 0x00013D22 File Offset: 0x00011F22
		public unsafe Transform CustomDragPlane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_CustomDragPlane);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_CustomDragPlane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x000F8474 File Offset: 0x000F6674
		// (set) Token: 0x060025BA RID: 9658 RVA: 0x00013D41 File Offset: 0x00011F41
		public unsafe bool DisableGravityWhenDragged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DisableGravityWhenDragged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DisableGravityWhenDragged)) = value;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x000F849C File Offset: 0x000F669C
		// (set) Token: 0x060025BC RID: 9660 RVA: 0x00013D5C File Offset: 0x00011F5C
		public unsafe float NormalRBDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_NormalRBDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_NormalRBDrag)) = value;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x060025BD RID: 9661 RVA: 0x000F84C4 File Offset: 0x000F66C4
		// (set) Token: 0x060025BE RID: 9662 RVA: 0x00013D77 File Offset: 0x00011F77
		public unsafe float HeldRBDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_HeldRBDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_HeldRBDrag)) = value;
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x060025BF RID: 9663 RVA: 0x000F84EC File Offset: 0x000F66EC
		// (set) Token: 0x060025C0 RID: 9664 RVA: 0x00013D92 File Offset: 0x00011F92
		public unsafe bool CanBeMultiDragged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_CanBeMultiDragged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_CanBeMultiDragged)) = value;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x060025C1 RID: 9665 RVA: 0x000F8514 File Offset: 0x000F6714
		// (set) Token: 0x060025C2 RID: 9666 RVA: 0x00013DAD File Offset: 0x00011FAD
		public unsafe GamepadPointerData _gamepadPointerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__gamepadPointerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GamepadPointerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__gamepadPointerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x060025C3 RID: 9667 RVA: 0x000F8544 File Offset: 0x000F6744
		// (set) Token: 0x060025C4 RID: 9668 RVA: 0x00013DCC File Offset: 0x00011FCC
		public unsafe Rigidbody _Rb_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__Rb_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__Rb_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x060025C5 RID: 9669 RVA: 0x000F8574 File Offset: 0x000F6774
		// (set) Token: 0x060025C6 RID: 9670 RVA: 0x00013DEB File Offset: 0x00011FEB
		public new unsafe CursorManager.ECursorType _HoveredCursor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__HoveredCursor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__HoveredCursor_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x060025C7 RID: 9671 RVA: 0x000F859C File Offset: 0x000F679C
		// (set) Token: 0x060025C8 RID: 9672 RVA: 0x00013E06 File Offset: 0x00012006
		public unsafe float idleUpForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_idleUpForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_idleUpForce)) = value;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x060025C9 RID: 9673 RVA: 0x000F85C4 File Offset: 0x000F67C4
		// (set) Token: 0x060025CA RID: 9674 RVA: 0x00013E21 File Offset: 0x00012021
		public unsafe bool LocationRestrictionEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_LocationRestrictionEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_LocationRestrictionEnabled)) = value;
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x060025CB RID: 9675 RVA: 0x000F85EC File Offset: 0x000F67EC
		// (set) Token: 0x060025CC RID: 9676 RVA: 0x00013E3C File Offset: 0x0001203C
		public unsafe Vector3 Origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_Origin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_Origin)) = value;
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x060025CD RID: 9677 RVA: 0x000F8614 File Offset: 0x000F6814
		// (set) Token: 0x060025CE RID: 9678 RVA: 0x00013E57 File Offset: 0x00012057
		public unsafe float MaxDistanceFromOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_MaxDistanceFromOrigin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_MaxDistanceFromOrigin)) = value;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x060025CF RID: 9679 RVA: 0x000F863C File Offset: 0x000F683C
		// (set) Token: 0x060025D0 RID: 9680 RVA: 0x00013E72 File Offset: 0x00012072
		public unsafe UnityEvent<Collider> onTriggerExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onTriggerExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onTriggerExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x060025D1 RID: 9681 RVA: 0x000F866C File Offset: 0x000F686C
		// (set) Token: 0x060025D2 RID: 9682 RVA: 0x00013E91 File Offset: 0x00012091
		public unsafe DraggableConstraint constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019FC RID: 6652
		private static readonly IntPtr NativeFieldInfoPtr_DragForceMultiplier;

		// Token: 0x040019FD RID: 6653
		private static readonly IntPtr NativeFieldInfoPtr_DragForceOrigin;

		// Token: 0x040019FE RID: 6654
		private static readonly IntPtr NativeFieldInfoPtr_RotationEnabled;

		// Token: 0x040019FF RID: 6655
		private static readonly IntPtr NativeFieldInfoPtr_TorqueMultiplier;

		// Token: 0x04001A00 RID: 6656
		private static readonly IntPtr NativeFieldInfoPtr_RotationAxis;

		// Token: 0x04001A01 RID: 6657
		private static readonly IntPtr NativeFieldInfoPtr_DragProjectionMode;

		// Token: 0x04001A02 RID: 6658
		private static readonly IntPtr NativeFieldInfoPtr_CustomDragPlane;

		// Token: 0x04001A03 RID: 6659
		private static readonly IntPtr NativeFieldInfoPtr_DisableGravityWhenDragged;

		// Token: 0x04001A04 RID: 6660
		private static readonly IntPtr NativeFieldInfoPtr_NormalRBDrag;

		// Token: 0x04001A05 RID: 6661
		private static readonly IntPtr NativeFieldInfoPtr_HeldRBDrag;

		// Token: 0x04001A06 RID: 6662
		private static readonly IntPtr NativeFieldInfoPtr_CanBeMultiDragged;

		// Token: 0x04001A07 RID: 6663
		private static readonly IntPtr NativeFieldInfoPtr__gamepadPointerData;

		// Token: 0x04001A08 RID: 6664
		private static readonly IntPtr NativeFieldInfoPtr__Rb_k__BackingField;

		// Token: 0x04001A09 RID: 6665
		private static readonly IntPtr NativeFieldInfoPtr__HoveredCursor_k__BackingField;

		// Token: 0x04001A0A RID: 6666
		private static readonly IntPtr NativeFieldInfoPtr_idleUpForce;

		// Token: 0x04001A0B RID: 6667
		private static readonly IntPtr NativeFieldInfoPtr_LocationRestrictionEnabled;

		// Token: 0x04001A0C RID: 6668
		private static readonly IntPtr NativeFieldInfoPtr_Origin;

		// Token: 0x04001A0D RID: 6669
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistanceFromOrigin;

		// Token: 0x04001A0E RID: 6670
		private static readonly IntPtr NativeFieldInfoPtr_onTriggerExit;

		// Token: 0x04001A0F RID: 6671
		private static readonly IntPtr NativeFieldInfoPtr_constraint;

		// Token: 0x04001A10 RID: 6672
		private static readonly IntPtr NativeMethodInfoPtr_get_Rb_Public_get_Rigidbody_0;

		// Token: 0x04001A11 RID: 6673
		private static readonly IntPtr NativeMethodInfoPtr_set_Rb_Protected_set_Void_Rigidbody_0;

		// Token: 0x04001A12 RID: 6674
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0;

		// Token: 0x04001A13 RID: 6675
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0;

		// Token: 0x04001A14 RID: 6676
		private static readonly IntPtr NativeMethodInfoPtr_get_GamepadPointerData_Public_get_GamepadPointerData_0;

		// Token: 0x04001A15 RID: 6677
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04001A16 RID: 6678
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001A17 RID: 6679
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04001A18 RID: 6680
		private static readonly IntPtr NativeMethodInfoPtr_PostFixedUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04001A19 RID: 6681
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001A1A RID: 6682
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Protected_Virtual_New_Void_Collider_0;

		// Token: 0x04001A1B RID: 6683
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0;

		// Token: 0x04001A1C RID: 6684
		private static readonly IntPtr NativeMethodInfoPtr_EndClick_Public_Virtual_Void_0;

		// Token: 0x04001A1D RID: 6685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000985 RID: 2437
		[OriginalName("Assembly-CSharp.dll", "", "EDragProjectionMode")]
		public enum EDragProjectionMode
		{
			// Token: 0x040094E6 RID: 38118
			CameraForward,
			// Token: 0x040094E7 RID: 38119
			FlatCameraForward,
			// Token: 0x040094E8 RID: 38120
			CustomPlane
		}

		// Token: 0x02000986 RID: 2438
		[OriginalName("Assembly-CSharp.dll", "", "ERotationAxis")]
		public enum ERotationAxis
		{
			// Token: 0x040094EA RID: 38122
			FlatCameraForward,
			// Token: 0x040094EB RID: 38123
			LocalX,
			// Token: 0x040094EC RID: 38124
			LocalY,
			// Token: 0x040094ED RID: 38125
			LocalZ
		}
	}
}
