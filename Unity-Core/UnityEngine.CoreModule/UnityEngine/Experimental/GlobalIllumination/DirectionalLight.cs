using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200026A RID: 618
	[StructLayout(2)]
	public struct DirectionalLight
	{
		// Token: 0x06002AD2 RID: 10962 RVA: 0x000A6E38 File Offset: 0x000A5038
		// Note: this type is marked as 'beforefieldinit'.
		static DirectionalLight()
		{
			Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "DirectionalLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr);
			DirectionalLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "instanceID");
			DirectionalLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "shadow");
			DirectionalLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "mode");
			DirectionalLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "position");
			DirectionalLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "orientation");
			DirectionalLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "color");
			DirectionalLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "indirectColor");
			DirectionalLight.NativeFieldInfoPtr_penumbraWidthRadian = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "penumbraWidthRadian");
			DirectionalLight.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "direction");
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x00012E20 File Offset: 0x00011020
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, ref this));
		}

		// Token: 0x04002467 RID: 9319
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x04002468 RID: 9320
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x04002469 RID: 9321
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x0400246A RID: 9322
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x0400246B RID: 9323
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x0400246C RID: 9324
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400246D RID: 9325
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x0400246E RID: 9326
		private static readonly IntPtr NativeFieldInfoPtr_penumbraWidthRadian;

		// Token: 0x0400246F RID: 9327
		private static readonly IntPtr NativeFieldInfoPtr_direction;

		// Token: 0x04002470 RID: 9328
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x04002471 RID: 9329
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x04002472 RID: 9330
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x04002473 RID: 9331
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x04002474 RID: 9332
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x04002475 RID: 9333
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x04002476 RID: 9334
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x04002477 RID: 9335
		[FieldOffset(68)]
		public float penumbraWidthRadian;

		// Token: 0x04002478 RID: 9336
		[FieldOffset(72)]
		public Vector3 direction;
	}
}
