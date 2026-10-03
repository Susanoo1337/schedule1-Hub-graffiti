using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x020000C5 RID: 197
	[StructLayout(2)]
	public struct TransformData
	{
		// Token: 0x0600120F RID: 4623 RVA: 0x000B7934 File Offset: 0x000B5B34
		// Note: this type is marked as 'beforefieldinit'.
		static TransformData()
		{
			Il2CppClassPointerStore<TransformData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "TransformData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformData>.NativeClassPtr);
			TransformData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformData>.NativeClassPtr, "Position");
			TransformData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformData>.NativeClassPtr, "Rotation");
			TransformData.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformData>.NativeClassPtr, "Scale");
			TransformData.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformData>.NativeClassPtr, 100665940);
			TransformData.NativeMethodInfoPtr_ApplyToWorldTransform_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformData>.NativeClassPtr, 100665941);
			TransformData.NativeMethodInfoPtr_ApplyToLocalTransform_Public_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformData>.NativeClassPtr, 100665942);
			TransformData.NativeMethodInfoPtr_ApplyToWorldTransform_Public_Void_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformData>.NativeClassPtr, 100665943);
			TransformData.NativeMethodInfoPtr_ApplyToLocalTransform_Public_Void_Rigidbody_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformData>.NativeClassPtr, 100665944);
			TransformData.NativeMethodInfoPtr_FromTransform_Public_Static_TransformData_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformData>.NativeClassPtr, 100665945);
			TransformData.NativeMethodInfoPtr_Lerp_Public_Static_TransformData_TransformData_TransformData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformData>.NativeClassPtr, 100665946);
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x000B7A2C File Offset: 0x000B5C2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90881, RefRangeEnd = 90883, XrefRangeStart = 90881, XrefRangeEnd = 90881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransformData(Vector3 position, Quaternion rotation, Vector3 scale)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformData.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x000B7A7C File Offset: 0x000B5C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90883, XrefRangeEnd = 90885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyToWorldTransform(Transform transform)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformData.NativeMethodInfoPtr_ApplyToWorldTransform_Public_Void_Transform_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x000B7AB4 File Offset: 0x000B5CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90885, XrefRangeEnd = 90888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyToLocalTransform(Transform transform, bool setScale = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformData.NativeMethodInfoPtr_ApplyToLocalTransform_Public_Void_Transform_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x000B7AF8 File Offset: 0x000B5CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90888, XrefRangeEnd = 90890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyToWorldTransform(Rigidbody rb)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformData.NativeMethodInfoPtr_ApplyToWorldTransform_Public_Void_Rigidbody_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x000B7B30 File Offset: 0x000B5D30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90896, RefRangeEnd = 90897, XrefRangeStart = 90890, XrefRangeEnd = 90896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyToLocalTransform(Rigidbody rb, bool setScale = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rb);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformData.NativeMethodInfoPtr_ApplyToLocalTransform_Public_Void_Rigidbody_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x000B7B74 File Offset: 0x000B5D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90897, XrefRangeEnd = 90900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TransformData FromTransform(Transform transform)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformData.NativeMethodInfoPtr_FromTransform_Public_Static_TransformData_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x000B7BB8 File Offset: 0x000B5DB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90904, RefRangeEnd = 90905, XrefRangeStart = 90900, XrefRangeEnd = 90904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TransformData Lerp(TransformData a, TransformData b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformData.NativeMethodInfoPtr_Lerp_Public_Static_TransformData_TransformData_TransformData_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x0000A278 File Offset: 0x00008478
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformData>.NativeClassPtr, ref this));
		}

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeFieldInfoPtr_Scale;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_Vector3_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToWorldTransform_Public_Void_Transform_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToLocalTransform_Public_Void_Transform_Boolean_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToWorldTransform_Public_Void_Rigidbody_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToLocalTransform_Public_Void_Rigidbody_Boolean_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_FromTransform_Public_Static_TransformData_Transform_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_TransformData_TransformData_TransformData_Single_0;

		// Token: 0x04000CAA RID: 3242
		[FieldOffset(0)]
		public Vector3 Position;

		// Token: 0x04000CAB RID: 3243
		[FieldOffset(12)]
		public Quaternion Rotation;

		// Token: 0x04000CAC RID: 3244
		[FieldOffset(28)]
		public Vector3 Scale;
	}
}
