using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200050F RID: 1295
	public class VialCap : Clickable
	{
		// Token: 0x060074E2 RID: 29922 RVA: 0x0020A608 File Offset: 0x00208808
		// Note: this type is marked as 'beforefieldinit'.
		static VialCap()
		{
			Il2CppClassPointerStore<VialCap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "VialCap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VialCap>.NativeClassPtr);
			VialCap.NativeFieldInfoPtr__Removed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VialCap>.NativeClassPtr, "<Removed>k__BackingField");
			VialCap.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VialCap>.NativeClassPtr, "Collider");
			VialCap.NativeFieldInfoPtr_RigidBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VialCap>.NativeClassPtr, "RigidBody");
			VialCap.NativeMethodInfoPtr_get_Removed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678332);
			VialCap.NativeMethodInfoPtr_set_Removed_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678333);
			VialCap.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678334);
			VialCap.NativeMethodInfoPtr_Pop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678335);
			VialCap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VialCap>.NativeClassPtr, 100678336);
		}

		// Token: 0x1700241C RID: 9244
		// (get) Token: 0x060074E3 RID: 29923 RVA: 0x0020A6D8 File Offset: 0x002088D8
		// (set) Token: 0x060074E4 RID: 29924 RVA: 0x0020A714 File Offset: 0x00208914
		public unsafe bool Removed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VialCap.NativeMethodInfoPtr_get_Removed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VialCap.NativeMethodInfoPtr_set_Removed_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060074E5 RID: 29925 RVA: 0x0020A754 File Offset: 0x00208954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228558, XrefRangeEnd = 228560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VialCap.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074E6 RID: 29926 RVA: 0x0020A7A0 File Offset: 0x002089A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228586, RefRangeEnd = 228587, XrefRangeStart = 228560, XrefRangeEnd = 228586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VialCap.NativeMethodInfoPtr_Pop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074E7 RID: 29927 RVA: 0x0020A7D4 File Offset: 0x002089D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228587, XrefRangeEnd = 228588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VialCap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VialCap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VialCap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074E8 RID: 29928 RVA: 0x00037CF5 File Offset: 0x00035EF5
		public VialCap(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x060074E9 RID: 29929 RVA: 0x0020A810 File Offset: 0x00208A10
		// (set) Token: 0x060074EA RID: 29930 RVA: 0x00037CFE File Offset: 0x00035EFE
		public unsafe bool _Removed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr__Removed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr__Removed_k__BackingField)) = value;
			}
		}

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x060074EB RID: 29931 RVA: 0x0020A838 File Offset: 0x00208A38
		// (set) Token: 0x060074EC RID: 29932 RVA: 0x00037D19 File Offset: 0x00035F19
		public unsafe Collider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x060074ED RID: 29933 RVA: 0x0020A868 File Offset: 0x00208A68
		// (set) Token: 0x060074EE RID: 29934 RVA: 0x00037D38 File Offset: 0x00035F38
		public unsafe Rigidbody RigidBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr_RigidBody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VialCap.NativeFieldInfoPtr_RigidBody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004F9B RID: 20379
		private static readonly IntPtr NativeFieldInfoPtr__Removed_k__BackingField;

		// Token: 0x04004F9C RID: 20380
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04004F9D RID: 20381
		private static readonly IntPtr NativeFieldInfoPtr_RigidBody;

		// Token: 0x04004F9E RID: 20382
		private static readonly IntPtr NativeMethodInfoPtr_get_Removed_Public_get_Boolean_0;

		// Token: 0x04004F9F RID: 20383
		private static readonly IntPtr NativeMethodInfoPtr_set_Removed_Protected_set_Void_Boolean_0;

		// Token: 0x04004FA0 RID: 20384
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0;

		// Token: 0x04004FA1 RID: 20385
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_Void_0;

		// Token: 0x04004FA2 RID: 20386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
