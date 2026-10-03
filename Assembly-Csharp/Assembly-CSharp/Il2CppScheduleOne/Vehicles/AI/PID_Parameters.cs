using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020000EE RID: 238
	[Serializable]
	[StructLayout(2)]
	public struct PID_Parameters
	{
		// Token: 0x06001671 RID: 5745 RVA: 0x000C5E9C File Offset: 0x000C409C
		// Note: this type is marked as 'beforefieldinit'.
		static PID_Parameters()
		{
			Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "PID_Parameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr);
			PID_Parameters.NativeFieldInfoPtr_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr, "P");
			PID_Parameters.NativeFieldInfoPtr_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr, "I");
			PID_Parameters.NativeFieldInfoPtr_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr, "D");
			PID_Parameters.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr, 100666439);
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x000C5F1C File Offset: 0x000C411C
		[CallerCount(0)]
		public unsafe PID_Parameters(float P, float I, float D)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref P;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref I;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref D;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PID_Parameters.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x0000C4AB File Offset: 0x0000A6AB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PID_Parameters>.NativeClassPtr, ref this));
		}

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeFieldInfoPtr_P;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeFieldInfoPtr_I;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeFieldInfoPtr_D;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x04000FB6 RID: 4022
		[FieldOffset(0)]
		public float P;

		// Token: 0x04000FB7 RID: 4023
		[FieldOffset(4)]
		public float I;

		// Token: 0x04000FB8 RID: 4024
		[FieldOffset(8)]
		public float D;
	}
}
