using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000FE RID: 254
	[StructLayout(2)]
	public struct Vector3Int
	{
		// Token: 0x06001561 RID: 5473 RVA: 0x0005EFF8 File Offset: 0x0005D1F8
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3Int()
		{
			Il2CppClassPointerStore<Vector3Int>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Vector3Int");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr);
			Vector3Int.NativeFieldInfoPtr_m_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "m_X");
			Vector3Int.NativeFieldInfoPtr_m_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "m_Y");
			Vector3Int.NativeFieldInfoPtr_m_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "m_Z");
			Vector3Int.NativeFieldInfoPtr_s_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Zero");
			Vector3Int.NativeFieldInfoPtr_s_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_One");
			Vector3Int.NativeFieldInfoPtr_s_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Up");
			Vector3Int.NativeFieldInfoPtr_s_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Down");
			Vector3Int.NativeFieldInfoPtr_s_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Left");
			Vector3Int.NativeFieldInfoPtr_s_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Right");
			Vector3Int.NativeFieldInfoPtr_s_Forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Forward");
			Vector3Int.NativeFieldInfoPtr_s_Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Back");
			Vector3Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665555);
			Vector3Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665556);
			Vector3Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665557);
			Vector3Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665558);
			Vector3Int.NativeMethodInfoPtr_get_z_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665559);
			Vector3Int.NativeMethodInfoPtr_set_z_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665560);
			Vector3Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665561);
			Vector3Int.NativeMethodInfoPtr_Min_Public_Static_Vector3Int_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665562);
			Vector3Int.NativeMethodInfoPtr_Max_Public_Static_Vector3Int_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665563);
			Vector3Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665564);
			Vector3Int.NativeMethodInfoPtr_op_Addition_Public_Static_Vector3Int_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665565);
			Vector3Int.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3Int_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665566);
			Vector3Int.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3Int_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665567);
			Vector3Int.NativeMethodInfoPtr_op_Division_Public_Static_Vector3Int_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665568);
			Vector3Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665569);
			Vector3Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665570);
			Vector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665571);
			Vector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665572);
			Vector3Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665573);
			Vector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665574);
			Vector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665575);
			Vector3Int.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665576);
			Vector3Int.NativeMethodInfoPtr_get_one_Public_Static_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100665577);
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x0005F2D0 File Offset: 0x0005D4D0
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x0005F300 File Offset: 0x0005D500
		public unsafe int x
		{
			[CallerCount(261)]
			[CachedScanResults(RefRangeStart = 1218881, RefRangeEnd = 1219142, XrefRangeStart = 1218881, XrefRangeEnd = 1219142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 54922, RefRangeEnd = 54944, XrefRangeStart = 54922, XrefRangeEnd = 54944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x0005F334 File Offset: 0x0005D534
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x0005F364 File Offset: 0x0005D564
		public unsafe int y
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 1233024, RefRangeEnd = 1233045, XrefRangeStart = 1233024, XrefRangeEnd = 1233045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 54944, RefRangeEnd = 54959, XrefRangeStart = 54944, XrefRangeEnd = 54959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x0005F398 File Offset: 0x0005D598
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x0005F3C8 File Offset: 0x0005D5C8
		public unsafe int z
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 1222651, RefRangeEnd = 1222680, XrefRangeStart = 1222651, XrefRangeEnd = 1222680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_z_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29176, RefRangeEnd = 29187, XrefRangeStart = 29176, XrefRangeEnd = 29187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_set_z_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0005F3FC File Offset: 0x0005D5FC
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 54959, RefRangeEnd = 54985, XrefRangeStart = 54959, XrefRangeEnd = 54985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Int(int x, int y, int z)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x0005F44C File Offset: 0x0005D64C
		[CallerCount(0)]
		public unsafe static Vector3Int Min(Vector3Int lhs, Vector3Int rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_Min_Public_Static_Vector3Int_Vector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0005F498 File Offset: 0x0005D698
		[CallerCount(0)]
		public unsafe static Vector3Int Max(Vector3Int lhs, Vector3Int rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_Max_Public_Static_Vector3Int_Vector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0005F4E4 File Offset: 0x0005D6E4
		[CallerCount(0)]
		public unsafe static implicit operator Vector3(Vector3Int v)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0005F524 File Offset: 0x0005D724
		[CallerCount(0)]
		public unsafe static Vector3Int operator +(Vector3Int a, Vector3Int b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Addition_Public_Static_Vector3Int_Vector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0005F570 File Offset: 0x0005D770
		[CallerCount(0)]
		public unsafe static Vector3Int operator -(Vector3Int a, Vector3Int b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3Int_Vector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x0005F5BC File Offset: 0x0005D7BC
		[CallerCount(0)]
		public unsafe static Vector3Int operator *(Vector3Int a, int b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3Int_Vector3Int_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x0005F608 File Offset: 0x0005D808
		[CallerCount(0)]
		public unsafe static Vector3Int operator /(Vector3Int a, int b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Division_Public_Static_Vector3Int_Vector3Int_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x0005F654 File Offset: 0x0005D854
		[CallerCount(0)]
		public unsafe static bool operator ==(Vector3Int lhs, Vector3Int rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x0005F6A0 File Offset: 0x0005D8A0
		[CallerCount(0)]
		public unsafe static bool operator !=(Vector3Int lhs, Vector3Int rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x0005F6EC File Offset: 0x0005D8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245647, XrefRangeEnd = 1245650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x0005F730 File Offset: 0x0005D930
		[CallerCount(0)]
		public unsafe bool Equals(Vector3Int other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3Int_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x0005F770 File Offset: 0x0005D970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1245653, RefRangeEnd = 1245655, XrefRangeStart = 1245650, XrefRangeEnd = 1245653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x0005F7A0 File Offset: 0x0005D9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245655, XrefRangeEnd = 1245656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x0005F7CC File Offset: 0x0005D9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245656, XrefRangeEnd = 1245675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x0005F81C File Offset: 0x0005DA1C
		public unsafe static Vector3Int zero
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245675, XrefRangeEnd = 1245677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x0005F84C File Offset: 0x0005DA4C
		public unsafe static Vector3Int one
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245677, XrefRangeEnd = 1245679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_one_Public_Static_get_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x0000AD0F File Offset: 0x00008F0F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, ref this));
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x0005F87C File Offset: 0x0005DA7C
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x0000AD21 File Offset: 0x00008F21
		public unsafe static Vector3Int s_Zero
		{
			get
			{
				Vector3Int result;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Zero, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Zero, (void*)(&value));
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x0005F898 File Offset: 0x0005DA98
		// (set) Token: 0x0600157D RID: 5501 RVA: 0x0000AD2F File Offset: 0x00008F2F
		public unsafe static Vector3Int s_One
		{
			get
			{
				Vector3Int result;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_One, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_One, (void*)(&value));
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x0005F8B4 File Offset: 0x0005DAB4
		// (set) Token: 0x0600157F RID: 5503 RVA: 0x0000AD3D File Offset: 0x00008F3D
		public unsafe static Vector3Int s_Up
		{
			get
			{
				Vector3Int result;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Up, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Up, (void*)(&value));
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x0005F8D0 File Offset: 0x0005DAD0
		// (set) Token: 0x06001581 RID: 5505 RVA: 0x0000AD4B File Offset: 0x00008F4B
		public unsafe static Vector3Int s_Down
		{
			get
			{
				Vector3Int result;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Down, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Down, (void*)(&value));
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x0005F8EC File Offset: 0x0005DAEC
		// (set) Token: 0x06001583 RID: 5507 RVA: 0x0000AD59 File Offset: 0x00008F59
		public unsafe static Vector3Int s_Left
		{
			get
			{
				Vector3Int result;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Left, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Left, (void*)(&value));
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x0005F908 File Offset: 0x0005DB08
		// (set) Token: 0x06001585 RID: 5509 RVA: 0x0000AD67 File Offset: 0x00008F67
		public unsafe static Vector3Int s_Right
		{
			get
			{
				Vector3Int result;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Right, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Right, (void*)(&value));
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x0005F924 File Offset: 0x0005DB24
		// (set) Token: 0x06001587 RID: 5511 RVA: 0x0000AD75 File Offset: 0x00008F75
		public unsafe static Vector3Int s_Forward
		{
			get
			{
				Vector3Int result;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Forward, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Forward, (void*)(&value));
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x0005F940 File Offset: 0x0005DB40
		// (set) Token: 0x06001589 RID: 5513 RVA: 0x0000AD83 File Offset: 0x00008F83
		public unsafe static Vector3Int s_Back
		{
			get
			{
				Vector3Int result;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Back, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Back, (void*)(&value));
			}
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0000AD91 File Offset: 0x00008F91
		public void Set(int x, int y, int z)
		{
			this.m_X = x;
			this.m_Y = y;
			this.m_Z = z;
		}

		// Token: 0x17000485 RID: 1157
		public int this[int index]
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x0600158D RID: 5517 RVA: 0x0005F95C File Offset: 0x0005DB5C
		public float magnitude
		{
			get
			{
				return Mathf.Sqrt((float)(this.x * this.x + this.y * this.y + this.z * this.z));
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x0005F9A0 File Offset: 0x0005DBA0
		public int sqrMagnitude
		{
			get
			{
				return this.x * this.x + this.y * this.y + this.z * this.z;
			}
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x0005F9DC File Offset: 0x0005DBDC
		public static float Distance(Vector3Int a, Vector3Int b)
		{
			return (a - b).magnitude;
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x0005FA00 File Offset: 0x0005DC00
		public static Vector3Int Scale(Vector3Int a, Vector3Int b)
		{
			return new Vector3Int(a.x * b.x, a.y * b.y, a.z * b.z);
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x0005FA44 File Offset: 0x0005DC44
		public void Scale(Vector3Int scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
			this.z *= scale.z;
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x0005FA94 File Offset: 0x0005DC94
		public void Clamp(Vector3Int min, Vector3Int max)
		{
			this.x = Math.Max(min.x, this.x);
			this.x = Math.Min(max.x, this.x);
			this.y = Math.Max(min.y, this.y);
			this.y = Math.Min(max.y, this.y);
			this.z = Math.Max(min.z, this.z);
			this.z = Math.Min(max.z, this.z);
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x0005FB38 File Offset: 0x0005DD38
		public static explicit operator Vector2Int(Vector3Int v)
		{
			return new Vector2Int(v.x, v.y);
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x0005FB60 File Offset: 0x0005DD60
		public static Vector3Int FloorToInt(Vector3 v)
		{
			return new Vector3Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y), Mathf.FloorToInt(v.z));
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x0005FB98 File Offset: 0x0005DD98
		public static Vector3Int CeilToInt(Vector3 v)
		{
			return new Vector3Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y), Mathf.CeilToInt(v.z));
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x0005FBD0 File Offset: 0x0005DDD0
		public static Vector3Int RoundToInt(Vector3 v)
		{
			return new Vector3Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y), Mathf.RoundToInt(v.z));
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x0005FC08 File Offset: 0x0005DE08
		public static Vector3Int operator *(Vector3Int a, Vector3Int b)
		{
			return new Vector3Int(a.x * b.x, a.y * b.y, a.z * b.z);
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x0005FC4C File Offset: 0x0005DE4C
		public static Vector3Int operator -(Vector3Int a)
		{
			return new Vector3Int(-a.x, -a.y, -a.z);
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x0005FC7C File Offset: 0x0005DE7C
		public static Vector3Int operator *(int a, Vector3Int b)
		{
			return new Vector3Int(a * b.x, a * b.y, a * b.z);
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x0005FCB0 File Offset: 0x0005DEB0
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x0005FCCC File Offset: 0x0005DECC
		public static Vector3Int up
		{
			get
			{
				return Vector3Int.s_Up;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x0005FCE4 File Offset: 0x0005DEE4
		public static Vector3Int down
		{
			get
			{
				return Vector3Int.s_Down;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x0005FCFC File Offset: 0x0005DEFC
		public static Vector3Int left
		{
			get
			{
				return Vector3Int.s_Left;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x0005FD14 File Offset: 0x0005DF14
		public static Vector3Int right
		{
			get
			{
				return Vector3Int.s_Right;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x0005FD2C File Offset: 0x0005DF2C
		public static Vector3Int forward
		{
			get
			{
				return Vector3Int.s_Forward;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x0005FD44 File Offset: 0x0005DF44
		public static Vector3Int back
		{
			get
			{
				return Vector3Int.s_Back;
			}
		}

		// Token: 0x040012B3 RID: 4787
		private static readonly IntPtr NativeFieldInfoPtr_m_X;

		// Token: 0x040012B4 RID: 4788
		private static readonly IntPtr NativeFieldInfoPtr_m_Y;

		// Token: 0x040012B5 RID: 4789
		private static readonly IntPtr NativeFieldInfoPtr_m_Z;

		// Token: 0x040012B6 RID: 4790
		private static readonly IntPtr NativeFieldInfoPtr_s_Zero;

		// Token: 0x040012B7 RID: 4791
		private static readonly IntPtr NativeFieldInfoPtr_s_One;

		// Token: 0x040012B8 RID: 4792
		private static readonly IntPtr NativeFieldInfoPtr_s_Up;

		// Token: 0x040012B9 RID: 4793
		private static readonly IntPtr NativeFieldInfoPtr_s_Down;

		// Token: 0x040012BA RID: 4794
		private static readonly IntPtr NativeFieldInfoPtr_s_Left;

		// Token: 0x040012BB RID: 4795
		private static readonly IntPtr NativeFieldInfoPtr_s_Right;

		// Token: 0x040012BC RID: 4796
		private static readonly IntPtr NativeFieldInfoPtr_s_Forward;

		// Token: 0x040012BD RID: 4797
		private static readonly IntPtr NativeFieldInfoPtr_s_Back;

		// Token: 0x040012BE RID: 4798
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;

		// Token: 0x040012BF RID: 4799
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0;

		// Token: 0x040012C0 RID: 4800
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;

		// Token: 0x040012C1 RID: 4801
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0;

		// Token: 0x040012C2 RID: 4802
		private static readonly IntPtr NativeMethodInfoPtr_get_z_Public_get_Int32_0;

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeMethodInfoPtr_set_z_Public_set_Void_Int32_0;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Vector3Int_Vector3Int_Vector3Int_0;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Vector3Int_Vector3Int_Vector3Int_0;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector3Int_0;

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector3Int_Vector3Int_Vector3Int_0;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3Int_Vector3Int_Vector3Int_0;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3Int_Vector3Int_Int32_0;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector3Int_Vector3Int_Int32_0;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3Int_Vector3Int_0;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3Int_Vector3Int_0;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3Int_0;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040012D3 RID: 4819
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3Int_0;

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_Vector3Int_0;

		// Token: 0x040012D5 RID: 4821
		[FieldOffset(0)]
		public int m_X;

		// Token: 0x040012D6 RID: 4822
		[FieldOffset(4)]
		public int m_Y;

		// Token: 0x040012D7 RID: 4823
		[FieldOffset(8)]
		public int m_Z;
	}
}
