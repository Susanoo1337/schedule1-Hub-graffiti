using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004D1 RID: 1233
	[StructLayout(2)]
	public struct ApproximateVector3
	{
		// Token: 0x06007101 RID: 28929 RVA: 0x001FEF64 File Offset: 0x001FD164
		// Note: this type is marked as 'beforefieldinit'.
		static ApproximateVector3()
		{
			Il2CppClassPointerStore<ApproximateVector3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ApproximateVector3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApproximateVector3>.NativeClassPtr);
			ApproximateVector3.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApproximateVector3>.NativeClassPtr, "X");
			ApproximateVector3.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApproximateVector3>.NativeClassPtr, "Y");
			ApproximateVector3.NativeFieldInfoPtr_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApproximateVector3>.NativeClassPtr, "Z");
			ApproximateVector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApproximateVector3>.NativeClassPtr, 100677896);
			ApproximateVector3.NativeMethodInfoPtr__ctor_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApproximateVector3>.NativeClassPtr, 100677897);
			ApproximateVector3.NativeMethodInfoPtr_ToVector3_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApproximateVector3>.NativeClassPtr, 100677898);
		}

		// Token: 0x06007102 RID: 28930 RVA: 0x001FF00C File Offset: 0x001FD20C
		[CallerCount(0)]
		public unsafe ApproximateVector3(float x, float y, float z)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApproximateVector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007103 RID: 28931 RVA: 0x001FF05C File Offset: 0x001FD25C
		[CallerCount(0)]
		public unsafe ApproximateVector3(Vector3 vector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApproximateVector3.NativeMethodInfoPtr__ctor_Public_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007104 RID: 28932 RVA: 0x001FF090 File Offset: 0x001FD290
		[CallerCount(0)]
		public unsafe Vector3 ToVector3()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApproximateVector3.NativeMethodInfoPtr_ToVector3_Public_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007105 RID: 28933 RVA: 0x00035C59 File Offset: 0x00033E59
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ApproximateVector3>.NativeClassPtr, ref this));
		}

		// Token: 0x04004D43 RID: 19779
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x04004D44 RID: 19780
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x04004D45 RID: 19781
		private static readonly IntPtr NativeFieldInfoPtr_Z;

		// Token: 0x04004D46 RID: 19782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x04004D47 RID: 19783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_0;

		// Token: 0x04004D48 RID: 19784
		private static readonly IntPtr NativeMethodInfoPtr_ToVector3_Public_Vector3_0;

		// Token: 0x04004D49 RID: 19785
		[FieldOffset(0)]
		public short X;

		// Token: 0x04004D4A RID: 19786
		[FieldOffset(2)]
		public short Y;

		// Token: 0x04004D4B RID: 19787
		[FieldOffset(4)]
		public short Z;
	}
}
