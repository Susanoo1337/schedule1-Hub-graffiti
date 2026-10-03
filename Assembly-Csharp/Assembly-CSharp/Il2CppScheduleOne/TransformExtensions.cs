using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x020000C3 RID: 195
	public static class TransformExtensions : Il2CppSystem.Object
	{
		// Token: 0x06001204 RID: 4612 RVA: 0x000B764C File Offset: 0x000B584C
		// Note: this type is marked as 'beforefieldinit'.
		static TransformExtensions()
		{
			Il2CppClassPointerStore<TransformExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "TransformExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformExtensions>.NativeClassPtr);
			TransformExtensions.NativeMethodInfoPtr_GetWorldTransformData_Public_Static_TransformData_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformExtensions>.NativeClassPtr, 100665933);
			TransformExtensions.NativeMethodInfoPtr_GetLocalTransformData_Public_Static_TransformData_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformExtensions>.NativeClassPtr, 100665934);
			TransformExtensions.NativeMethodInfoPtr_SetLocalTransformData_Public_Static_Void_Transform_TransformData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformExtensions>.NativeClassPtr, 100665935);
			TransformExtensions.NativeMethodInfoPtr_SetWorldTransformData_Public_Static_Void_Transform_TransformData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformExtensions>.NativeClassPtr, 100665936);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x000B76CC File Offset: 0x000B58CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90859, RefRangeEnd = 90861, XrefRangeStart = 90856, XrefRangeEnd = 90859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TransformData GetWorldTransformData(this Transform transform)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformExtensions.NativeMethodInfoPtr_GetWorldTransformData_Public_Static_TransformData_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x000B7710 File Offset: 0x000B5910
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90864, RefRangeEnd = 90866, XrefRangeStart = 90861, XrefRangeEnd = 90864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TransformData GetLocalTransformData(this Transform transform)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformExtensions.NativeMethodInfoPtr_GetLocalTransformData_Public_Static_TransformData_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x000B7754 File Offset: 0x000B5954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90869, RefRangeEnd = 90870, XrefRangeStart = 90866, XrefRangeEnd = 90869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLocalTransformData(this Transform transform, TransformData data, bool setScale = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformExtensions.NativeMethodInfoPtr_SetLocalTransformData_Public_Static_Void_Transform_TransformData_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x000B77A8 File Offset: 0x000B59A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90872, RefRangeEnd = 90874, XrefRangeStart = 90870, XrefRangeEnd = 90872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetWorldTransformData(this Transform transform, TransformData data)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformExtensions.NativeMethodInfoPtr_SetWorldTransformData_Public_Static_Void_Transform_TransformData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0000A266 File Offset: 0x00008466
		public TransformExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldTransformData_Public_Static_TransformData_Transform_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalTransformData_Public_Static_TransformData_Transform_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalTransformData_Public_Static_Void_Transform_TransformData_Boolean_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_SetWorldTransformData_Public_Static_Void_Transform_TransformData_0;
	}
}
