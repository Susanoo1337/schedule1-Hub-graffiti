using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Graffiti
{
	// Token: 0x02000371 RID: 881
	[Serializable]
	[StructLayout(2)]
	public struct UShort2
	{
		// Token: 0x06004B15 RID: 19221 RVA: 0x0017B004 File Offset: 0x00179204
		// Note: this type is marked as 'beforefieldinit'.
		static UShort2()
		{
			Il2CppClassPointerStore<UShort2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Graffiti", "UShort2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UShort2>.NativeClassPtr);
			UShort2.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UShort2>.NativeClassPtr, "X");
			UShort2.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UShort2>.NativeClassPtr, "Y");
			UShort2.NativeMethodInfoPtr__ctor_Public_Void_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UShort2>.NativeClassPtr, 100672925);
			UShort2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UShort2>.NativeClassPtr, 100672926);
			UShort2.NativeMethodInfoPtr_op_Addition_Public_Static_UShort2_UShort2_UShort2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UShort2>.NativeClassPtr, 100672927);
			UShort2.NativeMethodInfoPtr_op_Subtraction_Public_Static_UShort2_UShort2_UShort2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UShort2>.NativeClassPtr, 100672928);
			UShort2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_UShort2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UShort2>.NativeClassPtr, 100672929);
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x0017B0C0 File Offset: 0x001792C0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 171375, RefRangeEnd = 171384, XrefRangeStart = 171375, XrefRangeEnd = 171375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UShort2(ushort x, ushort y)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UShort2.NativeMethodInfoPtr__ctor_Public_Void_UInt16_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B17 RID: 19223 RVA: 0x0017B100 File Offset: 0x00179300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171384, XrefRangeEnd = 171392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UShort2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004B18 RID: 19224 RVA: 0x0017B12C File Offset: 0x0017932C
		[CallerCount(0)]
		public unsafe static UShort2 operator +(UShort2 a, UShort2 b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UShort2.NativeMethodInfoPtr_op_Addition_Public_Static_UShort2_UShort2_UShort2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B19 RID: 19225 RVA: 0x0017B178 File Offset: 0x00179378
		[CallerCount(0)]
		public unsafe static UShort2 operator -(UShort2 a, UShort2 b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UShort2.NativeMethodInfoPtr_op_Subtraction_Public_Static_UShort2_UShort2_UShort2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x0017B1C4 File Offset: 0x001793C4
		[CallerCount(0)]
		public unsafe static implicit operator Vector2(UShort2 uShort2)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref uShort2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UShort2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_UShort2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x00024465 File Offset: 0x00022665
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UShort2>.NativeClassPtr, ref this));
		}

		// Token: 0x04003324 RID: 13092
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x04003325 RID: 13093
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x04003326 RID: 13094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt16_UInt16_0;

		// Token: 0x04003327 RID: 13095
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003328 RID: 13096
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_UShort2_UShort2_UShort2_0;

		// Token: 0x04003329 RID: 13097
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_UShort2_UShort2_UShort2_0;

		// Token: 0x0400332A RID: 13098
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_UShort2_0;

		// Token: 0x0400332B RID: 13099
		[FieldOffset(0)]
		public ushort X;

		// Token: 0x0400332C RID: 13100
		[FieldOffset(2)]
		public ushort Y;
	}
}
