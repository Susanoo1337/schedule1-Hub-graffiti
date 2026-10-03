using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x02000293 RID: 659
	[StructLayout(2)]
	public struct ResponseBroadcast
	{
		// Token: 0x0600323A RID: 12858 RVA: 0x00019EC3 File Offset: 0x000180C3
		// Note: this type is marked as 'beforefieldinit'.
		static ResponseBroadcast()
		{
			Il2CppClassPointerStore<ResponseBroadcast>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "ResponseBroadcast");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResponseBroadcast>.NativeClassPtr);
			ResponseBroadcast.NativeFieldInfoPtr_Passed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResponseBroadcast>.NativeClassPtr, "Passed");
		}

		// Token: 0x0600323B RID: 12859 RVA: 0x00019EFC File Offset: 0x000180FC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ResponseBroadcast>.NativeClassPtr, ref this));
		}

		// Token: 0x04002169 RID: 8553
		private static readonly IntPtr NativeFieldInfoPtr_Passed;

		// Token: 0x0400216A RID: 8554
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool Passed;
	}
}
