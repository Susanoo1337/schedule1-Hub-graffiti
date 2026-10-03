using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003EA RID: 1002
	public static class ColliderExtensions : Il2CppSystem.Object
	{
		// Token: 0x0600596C RID: 22892 RVA: 0x0002A654 File Offset: 0x00028854
		// Note: this type is marked as 'beforefieldinit'.
		static ColliderExtensions()
		{
			Il2CppClassPointerStore<ColliderExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "ColliderExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColliderExtensions>.NativeClassPtr);
			ColliderExtensions.NativeMethodInfoPtr_IsPointWithinCollider_Public_Static_Boolean_BoxCollider_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderExtensions>.NativeClassPtr, 100674998);
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x001AFEF8 File Offset: 0x001AE0F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 194014, RefRangeEnd = 194018, XrefRangeStart = 194008, XrefRangeEnd = 194014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPointWithinCollider(this BoxCollider collider, Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collider);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColliderExtensions.NativeMethodInfoPtr_IsPointWithinCollider_Public_Static_Boolean_BoxCollider_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x0002A68D File Offset: 0x0002888D
		public ColliderExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003D64 RID: 15716
		private static readonly IntPtr NativeMethodInfoPtr_IsPointWithinCollider_Public_Static_Boolean_BoxCollider_Vector3_0;
	}
}
