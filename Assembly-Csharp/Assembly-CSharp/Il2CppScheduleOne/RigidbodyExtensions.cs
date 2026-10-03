using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x020000C4 RID: 196
	public static class RigidbodyExtensions : Il2CppSystem.Object
	{
		// Token: 0x0600120A RID: 4618 RVA: 0x000B77EC File Offset: 0x000B59EC
		// Note: this type is marked as 'beforefieldinit'.
		static RigidbodyExtensions()
		{
			Il2CppClassPointerStore<RigidbodyExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "RigidbodyExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RigidbodyExtensions>.NativeClassPtr);
			RigidbodyExtensions.NativeMethodInfoPtr_GetWorldTransformData_Public_Static_TransformData_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyExtensions>.NativeClassPtr, 100665937);
			RigidbodyExtensions.NativeMethodInfoPtr_SetLocalTransformData_Public_Static_Void_Rigidbody_TransformData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyExtensions>.NativeClassPtr, 100665938);
			RigidbodyExtensions.NativeMethodInfoPtr_SetWorldTransformData_Public_Static_Void_Rigidbody_TransformData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyExtensions>.NativeClassPtr, 100665939);
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x000B7858 File Offset: 0x000B5A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90874, XrefRangeEnd = 90878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TransformData GetWorldTransformData(this Rigidbody rb)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidbodyExtensions.NativeMethodInfoPtr_GetWorldTransformData_Public_Static_TransformData_Rigidbody_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x000B789C File Offset: 0x000B5A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90878, XrefRangeEnd = 90879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLocalTransformData(this Rigidbody rb, TransformData data, bool setScale = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rb);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidbodyExtensions.NativeMethodInfoPtr_SetLocalTransformData_Public_Static_Void_Rigidbody_TransformData_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x000B78F0 File Offset: 0x000B5AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90879, XrefRangeEnd = 90881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetWorldTransformData(this Rigidbody rb, TransformData data)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rb);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidbodyExtensions.NativeMethodInfoPtr_SetWorldTransformData_Public_Static_Void_Rigidbody_TransformData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0000A26F File Offset: 0x0000846F
		public RigidbodyExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldTransformData_Public_Static_TransformData_Rigidbody_0;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalTransformData_Public_Static_Void_Rigidbody_TransformData_Boolean_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr_SetWorldTransformData_Public_Static_Void_Rigidbody_TransformData_0;
	}
}
