using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200026C RID: 620
	[StructLayout(2)]
	public struct SpotLight
	{
		// Token: 0x06002AD6 RID: 10966 RVA: 0x000A7014 File Offset: 0x000A5214
		// Note: this type is marked as 'beforefieldinit'.
		static SpotLight()
		{
			Il2CppClassPointerStore<SpotLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "SpotLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpotLight>.NativeClassPtr);
			SpotLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "instanceID");
			SpotLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "shadow");
			SpotLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "mode");
			SpotLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "position");
			SpotLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "orientation");
			SpotLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "color");
			SpotLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "indirectColor");
			SpotLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "range");
			SpotLight.NativeFieldInfoPtr_sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "sphereRadius");
			SpotLight.NativeFieldInfoPtr_coneAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "coneAngle");
			SpotLight.NativeFieldInfoPtr_innerConeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "innerConeAngle");
			SpotLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "falloff");
			SpotLight.NativeFieldInfoPtr_angularFalloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "angularFalloff");
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x00012E44 File Offset: 0x00011044
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, ref this));
		}

		// Token: 0x0400248D RID: 9357
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x0400248E RID: 9358
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x0400248F RID: 9359
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x04002490 RID: 9360
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04002491 RID: 9361
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x04002492 RID: 9362
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04002493 RID: 9363
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x04002494 RID: 9364
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04002495 RID: 9365
		private static readonly IntPtr NativeFieldInfoPtr_sphereRadius;

		// Token: 0x04002496 RID: 9366
		private static readonly IntPtr NativeFieldInfoPtr_coneAngle;

		// Token: 0x04002497 RID: 9367
		private static readonly IntPtr NativeFieldInfoPtr_innerConeAngle;

		// Token: 0x04002498 RID: 9368
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x04002499 RID: 9369
		private static readonly IntPtr NativeFieldInfoPtr_angularFalloff;

		// Token: 0x0400249A RID: 9370
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x0400249B RID: 9371
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x0400249C RID: 9372
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x0400249D RID: 9373
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x0400249E RID: 9374
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x0400249F RID: 9375
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x040024A0 RID: 9376
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x040024A1 RID: 9377
		[FieldOffset(68)]
		public float range;

		// Token: 0x040024A2 RID: 9378
		[FieldOffset(72)]
		public float sphereRadius;

		// Token: 0x040024A3 RID: 9379
		[FieldOffset(76)]
		public float coneAngle;

		// Token: 0x040024A4 RID: 9380
		[FieldOffset(80)]
		public float innerConeAngle;

		// Token: 0x040024A5 RID: 9381
		[FieldOffset(84)]
		public FalloffType falloff;

		// Token: 0x040024A6 RID: 9382
		[FieldOffset(85)]
		public AngularFalloffType angularFalloff;
	}
}
