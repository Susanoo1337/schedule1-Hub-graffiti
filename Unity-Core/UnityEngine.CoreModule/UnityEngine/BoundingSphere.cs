using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000076 RID: 118
	[StructLayout(2)]
	public struct BoundingSphere
	{
		// Token: 0x0600052E RID: 1326 RVA: 0x000276D4 File Offset: 0x000258D4
		// Note: this type is marked as 'beforefieldinit'.
		static BoundingSphere()
		{
			Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BoundingSphere");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr);
			BoundingSphere.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr, "position");
			BoundingSphere.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr, "radius");
			BoundingSphere.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr, 100663838);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00027740 File Offset: 0x00025940
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229212, RefRangeEnd = 1229214, XrefRangeStart = 1229212, XrefRangeEnd = 1229212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoundingSphere(Vector3 pos, float rad)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rad;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundingSphere.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00004703 File Offset: 0x00002903
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr, ref this));
		}

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeFieldInfoPtr_radius;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0;

		// Token: 0x0400047F RID: 1151
		[FieldOffset(0)]
		public Vector3 position;

		// Token: 0x04000480 RID: 1152
		[FieldOffset(12)]
		public float radius;
	}
}
