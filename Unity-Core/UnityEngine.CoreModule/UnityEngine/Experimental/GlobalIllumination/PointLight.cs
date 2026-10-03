using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200026B RID: 619
	[StructLayout(2)]
	public struct PointLight
	{
		// Token: 0x06002AD4 RID: 10964 RVA: 0x000A6F1C File Offset: 0x000A511C
		// Note: this type is marked as 'beforefieldinit'.
		static PointLight()
		{
			Il2CppClassPointerStore<PointLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "PointLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointLight>.NativeClassPtr);
			PointLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "instanceID");
			PointLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "shadow");
			PointLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "mode");
			PointLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "position");
			PointLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "orientation");
			PointLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "color");
			PointLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "indirectColor");
			PointLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "range");
			PointLight.NativeFieldInfoPtr_sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "sphereRadius");
			PointLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "falloff");
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x00012E32 File Offset: 0x00011032
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PointLight>.NativeClassPtr, ref this));
		}

		// Token: 0x04002479 RID: 9337
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x0400247A RID: 9338
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x0400247B RID: 9339
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x0400247C RID: 9340
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x0400247D RID: 9341
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x0400247E RID: 9342
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400247F RID: 9343
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x04002480 RID: 9344
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04002481 RID: 9345
		private static readonly IntPtr NativeFieldInfoPtr_sphereRadius;

		// Token: 0x04002482 RID: 9346
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x04002483 RID: 9347
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x04002484 RID: 9348
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x04002485 RID: 9349
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x04002486 RID: 9350
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x04002487 RID: 9351
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x04002488 RID: 9352
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x04002489 RID: 9353
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x0400248A RID: 9354
		[FieldOffset(68)]
		public float range;

		// Token: 0x0400248B RID: 9355
		[FieldOffset(72)]
		public float sphereRadius;

		// Token: 0x0400248C RID: 9356
		[FieldOffset(76)]
		public FalloffType falloff;
	}
}
