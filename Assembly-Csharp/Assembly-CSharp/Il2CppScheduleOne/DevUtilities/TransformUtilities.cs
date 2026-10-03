using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000408 RID: 1032
	public static class TransformUtilities : Il2CppSystem.Object
	{
		// Token: 0x06005B2A RID: 23338 RVA: 0x001B5BCC File Offset: 0x001B3DCC
		// Note: this type is marked as 'beforefieldinit'.
		static TransformUtilities()
		{
			Il2CppClassPointerStore<TransformUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "TransformUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformUtilities>.NativeClassPtr);
			TransformUtilities.NativeMethodInfoPtr_GetScenePath_Public_Static_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformUtilities>.NativeClassPtr, 100675203);
			TransformUtilities.NativeMethodInfoPtr_XZ_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformUtilities>.NativeClassPtr, 100675204);
		}

		// Token: 0x06005B2B RID: 23339 RVA: 0x001B5C24 File Offset: 0x001B3E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196746, XrefRangeEnd = 196758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetScenePath(this Transform transform)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformUtilities.NativeMethodInfoPtr_GetScenePath_Public_Static_String_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005B2C RID: 23340 RVA: 0x001B5C60 File Offset: 0x001B3E60
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 74100, RefRangeEnd = 74109, XrefRangeStart = 74100, XrefRangeEnd = 74109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 XZ(this Vector3 vector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformUtilities.NativeMethodInfoPtr_XZ_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005B2D RID: 23341 RVA: 0x0002B2AD File Offset: 0x000294AD
		public TransformUtilities(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003E80 RID: 16000
		private static readonly IntPtr NativeMethodInfoPtr_GetScenePath_Public_Static_String_Transform_0;

		// Token: 0x04003E81 RID: 16001
		private static readonly IntPtr NativeMethodInfoPtr_XZ_Public_Static_Vector2_Vector3_0;
	}
}
