using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200026F RID: 623
	[StructLayout(2)]
	public struct Cookie
	{
		// Token: 0x06002ADC RID: 10972 RVA: 0x000A734C File Offset: 0x000A554C
		// Note: this type is marked as 'beforefieldinit'.
		static Cookie()
		{
			Il2CppClassPointerStore<Cookie>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "Cookie");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cookie>.NativeClassPtr);
			Cookie.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "instanceID");
			Cookie.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "scale");
			Cookie.NativeFieldInfoPtr_sizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "sizes");
			Cookie.NativeMethodInfoPtr_Defaults_Public_Static_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667911);
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x000A73CC File Offset: 0x000A55CC
		[CallerCount(0)]
		public unsafe static Cookie Defaults()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_Defaults_Public_Static_Cookie_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x00012E7A File Offset: 0x0001107A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Cookie>.NativeClassPtr, ref this));
		}

		// Token: 0x040024D1 RID: 9425
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x040024D2 RID: 9426
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x040024D3 RID: 9427
		private static readonly IntPtr NativeFieldInfoPtr_sizes;

		// Token: 0x040024D4 RID: 9428
		private static readonly IntPtr NativeMethodInfoPtr_Defaults_Public_Static_Cookie_0;

		// Token: 0x040024D5 RID: 9429
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x040024D6 RID: 9430
		[FieldOffset(4)]
		public float scale;

		// Token: 0x040024D7 RID: 9431
		[FieldOffset(8)]
		public Vector2 sizes;
	}
}
