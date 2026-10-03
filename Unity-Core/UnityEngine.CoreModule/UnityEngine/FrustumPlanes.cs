using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F7 RID: 247
	[Serializable]
	[StructLayout(2)]
	public struct FrustumPlanes
	{
		// Token: 0x06001395 RID: 5013 RVA: 0x000572E4 File Offset: 0x000554E4
		// Note: this type is marked as 'beforefieldinit'.
		static FrustumPlanes()
		{
			Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "FrustumPlanes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr);
			FrustumPlanes.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "left");
			FrustumPlanes.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "right");
			FrustumPlanes.NativeFieldInfoPtr_bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "bottom");
			FrustumPlanes.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "top");
			FrustumPlanes.NativeFieldInfoPtr_zNear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "zNear");
			FrustumPlanes.NativeFieldInfoPtr_zFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, "zFar");
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0000A860 File Offset: 0x00008A60
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, ref this));
		}

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeFieldInfoPtr_left;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeFieldInfoPtr_right;

		// Token: 0x0400112C RID: 4396
		private static readonly IntPtr NativeFieldInfoPtr_bottom;

		// Token: 0x0400112D RID: 4397
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeFieldInfoPtr_zNear;

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeFieldInfoPtr_zFar;

		// Token: 0x04001130 RID: 4400
		[FieldOffset(0)]
		public float left;

		// Token: 0x04001131 RID: 4401
		[FieldOffset(4)]
		public float right;

		// Token: 0x04001132 RID: 4402
		[FieldOffset(8)]
		public float bottom;

		// Token: 0x04001133 RID: 4403
		[FieldOffset(12)]
		public float top;

		// Token: 0x04001134 RID: 4404
		[FieldOffset(16)]
		public float zNear;

		// Token: 0x04001135 RID: 4405
		[FieldOffset(20)]
		public float zFar;
	}
}
