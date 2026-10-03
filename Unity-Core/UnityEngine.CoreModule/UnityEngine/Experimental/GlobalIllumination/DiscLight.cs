using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200026E RID: 622
	[StructLayout(2)]
	public struct DiscLight
	{
		// Token: 0x06002ADA RID: 10970 RVA: 0x000A7254 File Offset: 0x000A5454
		// Note: this type is marked as 'beforefieldinit'.
		static DiscLight()
		{
			Il2CppClassPointerStore<DiscLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "DiscLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscLight>.NativeClassPtr);
			DiscLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "instanceID");
			DiscLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "shadow");
			DiscLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "mode");
			DiscLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "position");
			DiscLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "orientation");
			DiscLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "color");
			DiscLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "indirectColor");
			DiscLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "range");
			DiscLight.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "radius");
			DiscLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "falloff");
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x00012E68 File Offset: 0x00011068
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, ref this));
		}

		// Token: 0x040024BD RID: 9405
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x040024BE RID: 9406
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x040024BF RID: 9407
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040024C0 RID: 9408
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040024C1 RID: 9409
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x040024C2 RID: 9410
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040024C3 RID: 9411
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x040024C4 RID: 9412
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x040024C5 RID: 9413
		private static readonly IntPtr NativeFieldInfoPtr_radius;

		// Token: 0x040024C6 RID: 9414
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x040024C7 RID: 9415
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x040024C8 RID: 9416
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x040024C9 RID: 9417
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x040024CA RID: 9418
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x040024CB RID: 9419
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x040024CC RID: 9420
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x040024CD RID: 9421
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x040024CE RID: 9422
		[FieldOffset(68)]
		public float range;

		// Token: 0x040024CF RID: 9423
		[FieldOffset(72)]
		public float radius;

		// Token: 0x040024D0 RID: 9424
		[FieldOffset(76)]
		public FalloffType falloff;
	}
}
