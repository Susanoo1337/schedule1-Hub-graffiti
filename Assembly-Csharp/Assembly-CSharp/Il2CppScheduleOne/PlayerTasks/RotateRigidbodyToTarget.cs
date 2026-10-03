using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000179 RID: 377
	public class RotateRigidbodyToTarget : MonoBehaviour
	{
		// Token: 0x0600263D RID: 9789 RVA: 0x000F9938 File Offset: 0x000F7B38
		// Note: this type is marked as 'beforefieldinit'.
		static RotateRigidbodyToTarget()
		{
			Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "RotateRigidbodyToTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr);
			RotateRigidbodyToTarget.NativeFieldInfoPtr_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, "Rigidbody");
			RotateRigidbodyToTarget.NativeFieldInfoPtr_TargetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, "TargetRotation");
			RotateRigidbodyToTarget.NativeFieldInfoPtr_RotationForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, "RotationForce");
			RotateRigidbodyToTarget.NativeFieldInfoPtr_Bitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, "Bitch");
			RotateRigidbodyToTarget.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, 100668222);
			RotateRigidbodyToTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, 100668223);
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x000F99E0 File Offset: 0x000F7BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117417, XrefRangeEnd = 117430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateRigidbodyToTarget.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x000F9A14 File Offset: 0x000F7C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117430, XrefRangeEnd = 117431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RotateRigidbodyToTarget() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateRigidbodyToTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x000142B0 File Offset: 0x000124B0
		public RotateRigidbodyToTarget(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06002641 RID: 9793 RVA: 0x000F9A50 File Offset: 0x000F7C50
		// (set) Token: 0x06002642 RID: 9794 RVA: 0x000142B9 File Offset: 0x000124B9
		public unsafe Rigidbody Rigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_Rigidbody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_Rigidbody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06002643 RID: 9795 RVA: 0x000F9A80 File Offset: 0x000F7C80
		// (set) Token: 0x06002644 RID: 9796 RVA: 0x000142D8 File Offset: 0x000124D8
		public unsafe Vector3 TargetRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_TargetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_TargetRotation)) = value;
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06002645 RID: 9797 RVA: 0x000F9AA8 File Offset: 0x000F7CA8
		// (set) Token: 0x06002646 RID: 9798 RVA: 0x000142F3 File Offset: 0x000124F3
		public unsafe float RotationForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_RotationForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_RotationForce)) = value;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06002647 RID: 9799 RVA: 0x000F9AD0 File Offset: 0x000F7CD0
		// (set) Token: 0x06002648 RID: 9800 RVA: 0x0001430E File Offset: 0x0001250E
		public unsafe Transform Bitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_Bitch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_Bitch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeFieldInfoPtr_Rigidbody;

		// Token: 0x04001A60 RID: 6752
		private static readonly IntPtr NativeFieldInfoPtr_TargetRotation;

		// Token: 0x04001A61 RID: 6753
		private static readonly IntPtr NativeFieldInfoPtr_RotationForce;

		// Token: 0x04001A62 RID: 6754
		private static readonly IntPtr NativeFieldInfoPtr_Bitch;

		// Token: 0x04001A63 RID: 6755
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04001A64 RID: 6756
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
