using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000702 RID: 1794
	public class PhysicsDamageable : MonoBehaviour
	{
		// Token: 0x0600AC4C RID: 44108 RVA: 0x002D5850 File Offset: 0x002D3A50
		// Note: this type is marked as 'beforefieldinit'.
		static PhysicsDamageable()
		{
			Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "PhysicsDamageable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr);
			PhysicsDamageable.NativeFieldInfoPtr_VELOCITY_HISTORY_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "VELOCITY_HISTORY_LENGTH");
			PhysicsDamageable.NativeFieldInfoPtr_Rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "Rb");
			PhysicsDamageable.NativeFieldInfoPtr_ForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "ForceMultiplier");
			PhysicsDamageable.NativeFieldInfoPtr_impactHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "impactHistory");
			PhysicsDamageable.NativeFieldInfoPtr_onImpacted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "onImpacted");
			PhysicsDamageable.NativeFieldInfoPtr__averageVelocity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "<averageVelocity>k__BackingField");
			PhysicsDamageable.NativeFieldInfoPtr_velocityHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "velocityHistory");
			PhysicsDamageable.NativeMethodInfoPtr_get_averageVelocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100686039);
			PhysicsDamageable.NativeMethodInfoPtr_set_averageVelocity_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100686040);
			PhysicsDamageable.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100686041);
			PhysicsDamageable.NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100686042);
			PhysicsDamageable.NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100686043);
			PhysicsDamageable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100686044);
			PhysicsDamageable.NativeMethodInfoPtr_ScheduleOne_Combat_IDamageable_get_gameObject_Private_Virtual_Final_New_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100686045);
		}

		// Token: 0x170033AA RID: 13226
		// (get) Token: 0x0600AC4D RID: 44109 RVA: 0x002D5998 File Offset: 0x002D3B98
		// (set) Token: 0x0600AC4E RID: 44110 RVA: 0x002D59D4 File Offset: 0x002D3BD4
		public unsafe Vector3 averageVelocity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsDamageable.NativeMethodInfoPtr_get_averageVelocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295530, RefRangeEnd = 295531, XrefRangeStart = 295530, XrefRangeEnd = 295530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsDamageable.NativeMethodInfoPtr_set_averageVelocity_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AC4F RID: 44111 RVA: 0x002D5A14 File Offset: 0x002D3C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295531, XrefRangeEnd = 295539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsDamageable.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC50 RID: 44112 RVA: 0x002D5A48 File Offset: 0x002D3C48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295539, RefRangeEnd = 295541, XrefRangeStart = 295539, XrefRangeEnd = 295539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsDamageable.NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC51 RID: 44113 RVA: 0x002D5A98 File Offset: 0x002D3C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295541, XrefRangeEnd = 295553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsDamageable.NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC52 RID: 44114 RVA: 0x002D5AE8 File Offset: 0x002D3CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295553, XrefRangeEnd = 295570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhysicsDamageable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsDamageable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170033AB RID: 13227
		// (get) Token: 0x0600AC53 RID: 44115 RVA: 0x002D5B24 File Offset: 0x002D3D24
		public unsafe virtual GameObject gameObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsDamageable.NativeMethodInfoPtr_ScheduleOne_Combat_IDamageable_get_gameObject_Private_Virtual_Final_New_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600AC54 RID: 44116 RVA: 0x0004EC24 File Offset: 0x0004CE24
		public PhysicsDamageable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170033A3 RID: 13219
		// (get) Token: 0x0600AC55 RID: 44117 RVA: 0x002D5B64 File Offset: 0x002D3D64
		// (set) Token: 0x0600AC56 RID: 44118 RVA: 0x0004EC2D File Offset: 0x0004CE2D
		public unsafe static int VELOCITY_HISTORY_LENGTH
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PhysicsDamageable.NativeFieldInfoPtr_VELOCITY_HISTORY_LENGTH, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhysicsDamageable.NativeFieldInfoPtr_VELOCITY_HISTORY_LENGTH, (void*)(&value));
			}
		}

		// Token: 0x170033A4 RID: 13220
		// (get) Token: 0x0600AC57 RID: 44119 RVA: 0x002D5B80 File Offset: 0x002D3D80
		// (set) Token: 0x0600AC58 RID: 44120 RVA: 0x0004EC3B File Offset: 0x0004CE3B
		public unsafe Rigidbody Rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_Rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_Rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033A5 RID: 13221
		// (get) Token: 0x0600AC59 RID: 44121 RVA: 0x002D5BB0 File Offset: 0x002D3DB0
		// (set) Token: 0x0600AC5A RID: 44122 RVA: 0x0004EC5A File Offset: 0x0004CE5A
		public unsafe float ForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_ForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_ForceMultiplier)) = value;
			}
		}

		// Token: 0x170033A6 RID: 13222
		// (get) Token: 0x0600AC5B RID: 44123 RVA: 0x002D5BD8 File Offset: 0x002D3DD8
		// (set) Token: 0x0600AC5C RID: 44124 RVA: 0x0004EC75 File Offset: 0x0004CE75
		public unsafe List<int> impactHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_impactHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_impactHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033A7 RID: 13223
		// (get) Token: 0x0600AC5D RID: 44125 RVA: 0x002D5C08 File Offset: 0x002D3E08
		// (set) Token: 0x0600AC5E RID: 44126 RVA: 0x0004EC94 File Offset: 0x0004CE94
		public unsafe Action<Impact> onImpacted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_onImpacted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Impact>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_onImpacted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033A8 RID: 13224
		// (get) Token: 0x0600AC5F RID: 44127 RVA: 0x002D5C38 File Offset: 0x002D3E38
		// (set) Token: 0x0600AC60 RID: 44128 RVA: 0x0004ECB3 File Offset: 0x0004CEB3
		public unsafe Vector3 _averageVelocity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr__averageVelocity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr__averageVelocity_k__BackingField)) = value;
			}
		}

		// Token: 0x170033A9 RID: 13225
		// (get) Token: 0x0600AC61 RID: 44129 RVA: 0x002D5C60 File Offset: 0x002D3E60
		// (set) Token: 0x0600AC62 RID: 44130 RVA: 0x0004ECCE File Offset: 0x0004CECE
		public unsafe List<Vector3> velocityHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_velocityHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_velocityHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007701 RID: 30465
		private static readonly IntPtr NativeFieldInfoPtr_VELOCITY_HISTORY_LENGTH;

		// Token: 0x04007702 RID: 30466
		private static readonly IntPtr NativeFieldInfoPtr_Rb;

		// Token: 0x04007703 RID: 30467
		private static readonly IntPtr NativeFieldInfoPtr_ForceMultiplier;

		// Token: 0x04007704 RID: 30468
		private static readonly IntPtr NativeFieldInfoPtr_impactHistory;

		// Token: 0x04007705 RID: 30469
		private static readonly IntPtr NativeFieldInfoPtr_onImpacted;

		// Token: 0x04007706 RID: 30470
		private static readonly IntPtr NativeFieldInfoPtr__averageVelocity_k__BackingField;

		// Token: 0x04007707 RID: 30471
		private static readonly IntPtr NativeFieldInfoPtr_velocityHistory;

		// Token: 0x04007708 RID: 30472
		private static readonly IntPtr NativeMethodInfoPtr_get_averageVelocity_Public_get_Vector3_0;

		// Token: 0x04007709 RID: 30473
		private static readonly IntPtr NativeMethodInfoPtr_set_averageVelocity_Private_set_Void_Vector3_0;

		// Token: 0x0400770A RID: 30474
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x0400770B RID: 30475
		private static readonly IntPtr NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0;

		// Token: 0x0400770C RID: 30476
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0;

		// Token: 0x0400770D RID: 30477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400770E RID: 30478
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_Combat_IDamageable_get_gameObject_Private_Virtual_Final_New_get_GameObject_0;
	}
}
