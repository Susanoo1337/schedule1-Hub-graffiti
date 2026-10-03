using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200014F RID: 335
	public class TrackedReference : Object
	{
		// Token: 0x06001938 RID: 6456 RVA: 0x0006BA10 File Offset: 0x00069C10
		// Note: this type is marked as 'beforefieldinit'.
		static TrackedReference()
		{
			Il2CppClassPointerStore<TrackedReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TrackedReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr);
			TrackedReference.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr, "m_Ptr");
			TrackedReference.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr, 100665981);
			TrackedReference.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TrackedReference_TrackedReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr, 100665982);
			TrackedReference.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TrackedReference_TrackedReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr, 100665983);
			TrackedReference.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr, 100665984);
			TrackedReference.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr, 100665985);
			TrackedReference.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_TrackedReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr, 100665986);
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x0006BACC File Offset: 0x00069CCC
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedReference() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedReference>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedReference.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x0006BB08 File Offset: 0x00069D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260976, XrefRangeEnd = 1260977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(TrackedReference x, TrackedReference y)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedReference.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TrackedReference_TrackedReference_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x0006BB5C File Offset: 0x00069D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260977, XrefRangeEnd = 1260978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(TrackedReference x, TrackedReference y)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedReference.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TrackedReference_TrackedReference_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x0006BBB0 File Offset: 0x00069DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260978, XrefRangeEnd = 1260981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedReference.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x0006BC08 File Offset: 0x00069E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260981, XrefRangeEnd = 1260982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedReference.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x0006BC50 File Offset: 0x00069E50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1260983, RefRangeEnd = 1260984, XrefRangeStart = 1260982, XrefRangeEnd = 1260983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator bool(TrackedReference exists)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exists);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedReference.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_TrackedReference_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x0000C517 File Offset: 0x0000A717
		public TrackedReference(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x0006BC94 File Offset: 0x00069E94
		// (set) Token: 0x06001941 RID: 6465 RVA: 0x0000C520 File Offset: 0x0000A720
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedReference.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedReference.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TrackedReference_TrackedReference_0;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TrackedReference_TrackedReference_0;

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_TrackedReference_0;
	}
}
