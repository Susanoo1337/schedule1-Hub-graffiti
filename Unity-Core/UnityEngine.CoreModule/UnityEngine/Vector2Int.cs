using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000FD RID: 253
	[StructLayout(2)]
	public struct Vector2Int
	{
		// Token: 0x06001529 RID: 5417 RVA: 0x0005E470 File Offset: 0x0005C670
		// Note: this type is marked as 'beforefieldinit'.
		static Vector2Int()
		{
			Il2CppClassPointerStore<Vector2Int>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Vector2Int");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr);
			Vector2Int.NativeFieldInfoPtr_m_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "m_X");
			Vector2Int.NativeFieldInfoPtr_m_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "m_Y");
			Vector2Int.NativeFieldInfoPtr_s_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Zero");
			Vector2Int.NativeFieldInfoPtr_s_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_One");
			Vector2Int.NativeFieldInfoPtr_s_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Up");
			Vector2Int.NativeFieldInfoPtr_s_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Down");
			Vector2Int.NativeFieldInfoPtr_s_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Left");
			Vector2Int.NativeFieldInfoPtr_s_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Right");
			Vector2Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665535);
			Vector2Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665536);
			Vector2Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665537);
			Vector2Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665538);
			Vector2Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665539);
			Vector2Int.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665540);
			Vector2Int.NativeMethodInfoPtr_Max_Public_Static_Vector2Int_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665541);
			Vector2Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665542);
			Vector2Int.NativeMethodInfoPtr_FloorToInt_Public_Static_Vector2Int_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665543);
			Vector2Int.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2Int_Vector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665544);
			Vector2Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665545);
			Vector2Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665546);
			Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665547);
			Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665548);
			Vector2Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665549);
			Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665550);
			Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665551);
			Vector2Int.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665552);
			Vector2Int.NativeMethodInfoPtr_get_one_Public_Static_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100665553);
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x0005E6BC File Offset: 0x0005C8BC
		// (set) Token: 0x0600152B RID: 5419 RVA: 0x0005E6EC File Offset: 0x0005C8EC
		public unsafe int x
		{
			[CallerCount(261)]
			[CachedScanResults(RefRangeStart = 1218881, RefRangeEnd = 1219142, XrefRangeStart = 1218881, XrefRangeEnd = 1219142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x0005E720 File Offset: 0x0005C920
		// (set) Token: 0x0600152D RID: 5421 RVA: 0x0005E750 File Offset: 0x0005C950
		public unsafe int y
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 1233024, RefRangeEnd = 1233045, XrefRangeStart = 1233024, XrefRangeEnd = 1233045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0005E784 File Offset: 0x0005C984
		[CallerCount(494)]
		[CachedScanResults(RefRangeStart = 60743, RefRangeEnd = 61237, XrefRangeStart = 60743, XrefRangeEnd = 61237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Int(int x, int y)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x0005E7C4 File Offset: 0x0005C9C4
		public unsafe float magnitude
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0005E7F4 File Offset: 0x0005C9F4
		[CallerCount(0)]
		public unsafe static Vector2Int Max(Vector2Int lhs, Vector2Int rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_Max_Public_Static_Vector2Int_Vector2Int_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0005E840 File Offset: 0x0005CA40
		[CallerCount(0)]
		public unsafe static implicit operator Vector2(Vector2Int v)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0005E880 File Offset: 0x0005CA80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1245612, RefRangeEnd = 1245614, XrefRangeStart = 1245604, XrefRangeEnd = 1245612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2Int FloorToInt(Vector2 v)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_FloorToInt_Public_Static_Vector2Int_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0005E8C0 File Offset: 0x0005CAC0
		[CallerCount(0)]
		public unsafe static Vector2Int operator *(Vector2Int a, int b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2Int_Vector2Int_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0005E90C File Offset: 0x0005CB0C
		[CallerCount(0)]
		public unsafe static bool operator ==(Vector2Int lhs, Vector2Int rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2Int_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0005E958 File Offset: 0x0005CB58
		[CallerCount(0)]
		public unsafe static bool operator !=(Vector2Int lhs, Vector2Int rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2Int_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0005E9A4 File Offset: 0x0005CBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245614, XrefRangeEnd = 1245617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0005E9E8 File Offset: 0x0005CBE8
		[CallerCount(0)]
		public unsafe bool Equals(Vector2Int other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2Int_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0005EA28 File Offset: 0x0005CC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245617, XrefRangeEnd = 1245619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x0005EA58 File Offset: 0x0005CC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245619, XrefRangeEnd = 1245627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0005EA84 File Offset: 0x0005CC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245627, XrefRangeEnd = 1245643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x0600153B RID: 5435 RVA: 0x0005EAD4 File Offset: 0x0005CCD4
		public unsafe static Vector2Int zero
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245643, XrefRangeEnd = 1245645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x0005EB04 File Offset: 0x0005CD04
		public unsafe static Vector2Int one
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245645, XrefRangeEnd = 1245647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_one_Public_Static_get_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0000AC6B File Offset: 0x00008E6B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, ref this));
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x0005EB34 File Offset: 0x0005CD34
		// (set) Token: 0x0600153F RID: 5439 RVA: 0x0000AC7D File Offset: 0x00008E7D
		public unsafe static Vector2Int s_Zero
		{
			get
			{
				Vector2Int result;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Zero, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Zero, (void*)(&value));
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x0005EB50 File Offset: 0x0005CD50
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x0000AC8B File Offset: 0x00008E8B
		public unsafe static Vector2Int s_One
		{
			get
			{
				Vector2Int result;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_One, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_One, (void*)(&value));
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x0005EB6C File Offset: 0x0005CD6C
		// (set) Token: 0x06001543 RID: 5443 RVA: 0x0000AC99 File Offset: 0x00008E99
		public unsafe static Vector2Int s_Up
		{
			get
			{
				Vector2Int result;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Up, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Up, (void*)(&value));
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x0005EB88 File Offset: 0x0005CD88
		// (set) Token: 0x06001545 RID: 5445 RVA: 0x0000ACA7 File Offset: 0x00008EA7
		public unsafe static Vector2Int s_Down
		{
			get
			{
				Vector2Int result;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Down, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Down, (void*)(&value));
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x0005EBA4 File Offset: 0x0005CDA4
		// (set) Token: 0x06001547 RID: 5447 RVA: 0x0000ACB5 File Offset: 0x00008EB5
		public unsafe static Vector2Int s_Left
		{
			get
			{
				Vector2Int result;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Left, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Left, (void*)(&value));
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x0005EBC0 File Offset: 0x0005CDC0
		// (set) Token: 0x06001549 RID: 5449 RVA: 0x0000ACC3 File Offset: 0x00008EC3
		public unsafe static Vector2Int s_Right
		{
			get
			{
				Vector2Int result;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Right, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Right, (void*)(&value));
			}
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0000ACD1 File Offset: 0x00008ED1
		public void Set(int x, int y)
		{
			this.m_X = x;
			this.m_Y = y;
		}

		// Token: 0x17000472 RID: 1138
		public int this[int index]
		{
			get
			{
				int result;
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException(String.Format("Invalid Vector2Int index addressed: {0}!", index));
					}
					result = this.y;
				}
				else
				{
					result = this.x;
				}
				return result;
			}
			set
			{
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException(String.Format("Invalid Vector2Int index addressed: {0}!", index));
					}
					this.y = value;
				}
				else
				{
					this.x = value;
				}
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x0005EC6C File Offset: 0x0005CE6C
		public int sqrMagnitude
		{
			get
			{
				return this.x * this.x + this.y * this.y;
			}
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0005EC9C File Offset: 0x0005CE9C
		public static float Distance(Vector2Int a, Vector2Int b)
		{
			float num = (float)(a.x - b.x);
			float num2 = (float)(a.y - b.y);
			return (float)Math.Sqrt((double)(num * num + num2 * num2));
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0005ECE0 File Offset: 0x0005CEE0
		public static Vector2Int Min(Vector2Int lhs, Vector2Int rhs)
		{
			return new Vector2Int(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y));
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0005ED20 File Offset: 0x0005CF20
		public static Vector2Int Scale(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x * b.x, a.y * b.y);
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x0000ACE2 File Offset: 0x00008EE2
		public void Scale(Vector2Int scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x0005ED58 File Offset: 0x0005CF58
		public void Clamp(Vector2Int min, Vector2Int max)
		{
			this.x = Math.Max(min.x, this.x);
			this.x = Math.Min(max.x, this.x);
			this.y = Math.Max(min.y, this.y);
			this.y = Math.Min(max.y, this.y);
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x0005EDCC File Offset: 0x0005CFCC
		public static explicit operator Vector3Int(Vector2Int v)
		{
			return new Vector3Int(v.x, v.y, 0);
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0005EDF4 File Offset: 0x0005CFF4
		public static Vector2Int CeilToInt(Vector2 v)
		{
			return new Vector2Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y));
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x0005EE24 File Offset: 0x0005D024
		public static Vector2Int RoundToInt(Vector2 v)
		{
			return new Vector2Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y));
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x0005EE54 File Offset: 0x0005D054
		public static Vector2Int operator -(Vector2Int v)
		{
			return new Vector2Int(-v.x, -v.y);
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x0005EE7C File Offset: 0x0005D07C
		public static Vector2Int operator +(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x + b.x, a.y + b.y);
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x0005EEB4 File Offset: 0x0005D0B4
		public static Vector2Int operator -(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x - b.x, a.y - b.y);
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0005EEEC File Offset: 0x0005D0EC
		public static Vector2Int operator *(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x * b.x, a.y * b.y);
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x0005EF24 File Offset: 0x0005D124
		public static Vector2Int operator *(int a, Vector2Int b)
		{
			return new Vector2Int(a * b.x, a * b.y);
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0005EF50 File Offset: 0x0005D150
		public static Vector2Int operator /(Vector2Int a, int b)
		{
			return new Vector2Int(a.x / b, a.y / b);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0005EF7C File Offset: 0x0005D17C
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x0600155D RID: 5469 RVA: 0x0005EF98 File Offset: 0x0005D198
		public static Vector2Int up
		{
			get
			{
				return Vector2Int.s_Up;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x0005EFB0 File Offset: 0x0005D1B0
		public static Vector2Int down
		{
			get
			{
				return Vector2Int.s_Down;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x0005EFC8 File Offset: 0x0005D1C8
		public static Vector2Int left
		{
			get
			{
				return Vector2Int.s_Left;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x0005EFE0 File Offset: 0x0005D1E0
		public static Vector2Int right
		{
			get
			{
				return Vector2Int.s_Right;
			}
		}

		// Token: 0x04001296 RID: 4758
		private static readonly IntPtr NativeFieldInfoPtr_m_X;

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeFieldInfoPtr_m_Y;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeFieldInfoPtr_s_Zero;

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeFieldInfoPtr_s_One;

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeFieldInfoPtr_s_Up;

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeFieldInfoPtr_s_Down;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeFieldInfoPtr_s_Left;

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeFieldInfoPtr_s_Right;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0;

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0;

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeMethodInfoPtr_get_magnitude_Public_get_Single_0;

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Vector2Int_Vector2Int_Vector2Int_0;

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector2Int_0;

		// Token: 0x040012A6 RID: 4774
		private static readonly IntPtr NativeMethodInfoPtr_FloorToInt_Public_Static_Vector2Int_Vector2_0;

		// Token: 0x040012A7 RID: 4775
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2Int_Vector2Int_Int32_0;

		// Token: 0x040012A8 RID: 4776
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2Int_Vector2Int_0;

		// Token: 0x040012A9 RID: 4777
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2Int_Vector2Int_0;

		// Token: 0x040012AA RID: 4778
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040012AB RID: 4779
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2Int_0;

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040012AE RID: 4782
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040012AF RID: 4783
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2Int_0;

		// Token: 0x040012B0 RID: 4784
		private static readonly IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_Vector2Int_0;

		// Token: 0x040012B1 RID: 4785
		[FieldOffset(0)]
		public int m_X;

		// Token: 0x040012B2 RID: 4786
		[FieldOffset(4)]
		public int m_Y;
	}
}
