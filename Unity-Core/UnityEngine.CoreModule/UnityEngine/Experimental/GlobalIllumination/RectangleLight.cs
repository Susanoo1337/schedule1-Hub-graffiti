using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200026D RID: 621
	[StructLayout(2)]
	public struct RectangleLight
	{
		// Token: 0x06002AD8 RID: 10968 RVA: 0x000A7148 File Offset: 0x000A5348
		// Note: this type is marked as 'beforefieldinit'.
		static RectangleLight()
		{
			Il2CppClassPointerStore<RectangleLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "RectangleLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr);
			RectangleLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "instanceID");
			RectangleLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "shadow");
			RectangleLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "mode");
			RectangleLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "position");
			RectangleLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "orientation");
			RectangleLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "color");
			RectangleLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "indirectColor");
			RectangleLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "range");
			RectangleLight.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "width");
			RectangleLight.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "height");
			RectangleLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "falloff");
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x00012E56 File Offset: 0x00011056
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, ref this));
		}

		// Token: 0x040024A7 RID: 9383
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x040024A8 RID: 9384
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x040024A9 RID: 9385
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040024AA RID: 9386
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040024AB RID: 9387
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x040024AC RID: 9388
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040024AD RID: 9389
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x040024AE RID: 9390
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x040024AF RID: 9391
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x040024B0 RID: 9392
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x040024B1 RID: 9393
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x040024B2 RID: 9394
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x040024B3 RID: 9395
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x040024B4 RID: 9396
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x040024B5 RID: 9397
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x040024B6 RID: 9398
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x040024B7 RID: 9399
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x040024B8 RID: 9400
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x040024B9 RID: 9401
		[FieldOffset(68)]
		public float range;

		// Token: 0x040024BA RID: 9402
		[FieldOffset(72)]
		public float width;

		// Token: 0x040024BB RID: 9403
		[FieldOffset(76)]
		public float height;

		// Token: 0x040024BC RID: 9404
		[FieldOffset(80)]
		public FalloffType falloff;
	}
}
