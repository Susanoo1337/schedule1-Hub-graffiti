using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200040A RID: 1034
	public static class VectorExtensions : Il2CppSystem.Object
	{
		// Token: 0x06005B3B RID: 23355 RVA: 0x0002B2F9 File Offset: 0x000294F9
		// Note: this type is marked as 'beforefieldinit'.
		static VectorExtensions()
		{
			Il2CppClassPointerStore<VectorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "VectorExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VectorExtensions>.NativeClassPtr);
			VectorExtensions.NativeMethodInfoPtr_ToNormal_Public_Static_Vector2_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorExtensions>.NativeClassPtr, 100675216);
		}

		// Token: 0x06005B3C RID: 23356 RVA: 0x001B5F80 File Offset: 0x001B4180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196867, RefRangeEnd = 196868, XrefRangeStart = 196867, XrefRangeEnd = 196867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 ToNormal(this Vector2 v, bool isClockwise = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isClockwise;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorExtensions.NativeMethodInfoPtr_ToNormal_Public_Static_Vector2_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005B3D RID: 23357 RVA: 0x0002B332 File Offset: 0x00029532
		public VectorExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003E8B RID: 16011
		private static readonly IntPtr NativeMethodInfoPtr_ToNormal_Public_Static_Vector2_Vector2_Boolean_0;
	}
}
