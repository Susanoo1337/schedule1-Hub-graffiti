using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000116 RID: 278
	[StructLayout(2)]
	public struct PropertyName
	{
		// Token: 0x060016C6 RID: 5830 RVA: 0x00063308 File Offset: 0x00061508
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyName()
		{
			Il2CppClassPointerStore<PropertyName>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PropertyName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyName>.NativeClassPtr);
			PropertyName.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, "id");
			PropertyName.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100665684);
			PropertyName.NativeMethodInfoPtr__ctor_Public_Void_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100665685);
			PropertyName.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100665686);
			PropertyName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PropertyName_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100665687);
			PropertyName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100665688);
			PropertyName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100665689);
			PropertyName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100665690);
			PropertyName.NativeMethodInfoPtr_op_Implicit_Public_Static_PropertyName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100665691);
			PropertyName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100665692);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00063400 File Offset: 0x00061600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1246092, RefRangeEnd = 1246093, XrefRangeStart = 1246090, XrefRangeEnd = 1246092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyName(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr__ctor_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00063438 File Offset: 0x00061638
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 54922, RefRangeEnd = 54944, XrefRangeStart = 54922, XrefRangeEnd = 54944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyName(PropertyName other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr__ctor_Public_Void_PropertyName_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x0006346C File Offset: 0x0006166C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1246093, RefRangeEnd = 1246094, XrefRangeStart = 1246093, XrefRangeEnd = 1246093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNullOrEmpty(PropertyName prop)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref prop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_PropertyName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x000634AC File Offset: 0x000616AC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1246094, RefRangeEnd = 1246100, XrefRangeStart = 1246094, XrefRangeEnd = 1246094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(PropertyName lhs, PropertyName rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PropertyName_PropertyName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x000634F8 File Offset: 0x000616F8
		[CallerCount(261)]
		[CachedScanResults(RefRangeStart = 1218881, RefRangeEnd = 1219142, XrefRangeStart = 1218881, XrefRangeEnd = 1219142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00063528 File Offset: 0x00061728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246100, XrefRangeEnd = 1246103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x0006356C File Offset: 0x0006176C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1246103, RefRangeEnd = 1246104, XrefRangeStart = 1246103, XrefRangeEnd = 1246103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(PropertyName other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PropertyName_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x000635AC File Offset: 0x000617AC
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1246068, RefRangeEnd = 1246088, XrefRangeStart = 1246068, XrefRangeEnd = 1246088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator PropertyName(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_op_Implicit_Public_Static_PropertyName_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x000635F0 File Offset: 0x000617F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246104, XrefRangeEnd = 1246110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x0000B700 File Offset: 0x00009900
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, ref this));
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x0006361C File Offset: 0x0006181C
		public static bool operator !=(PropertyName lhs, PropertyName rhs)
		{
			return lhs.id != rhs.id;
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00063640 File Offset: 0x00061840
		public static implicit operator PropertyName(int id)
		{
			return new PropertyName(id);
		}

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PropertyName_0;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_PropertyName_0;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PropertyName_PropertyName_0;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PropertyName_0;

		// Token: 0x0400137E RID: 4990
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PropertyName_String_0;

		// Token: 0x0400137F RID: 4991
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001380 RID: 4992
		[FieldOffset(0)]
		public int id;
	}
}
