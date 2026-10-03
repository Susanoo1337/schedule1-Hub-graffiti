using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020000EA RID: 234
	public class PathPoint : MonoBehaviour
	{
		// Token: 0x06001638 RID: 5688 RVA: 0x000C52AC File Offset: 0x000C34AC
		// Note: this type is marked as 'beforefieldinit'.
		static PathPoint()
		{
			Il2CppClassPointerStore<PathPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "PathPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathPoint>.NativeClassPtr);
			PathPoint.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPoint>.NativeClassPtr, "connections");
			PathPoint.NativeFieldInfoPtr_unique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPoint>.NativeClassPtr, "unique");
			PathPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPoint>.NativeClassPtr, 100666422);
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x000C5318 File Offset: 0x000C3518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95679, XrefRangeEnd = 95687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathPoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathPoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x0000C2D4 File Offset: 0x0000A4D4
		public PathPoint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x000C5354 File Offset: 0x000C3554
		// (set) Token: 0x0600163C RID: 5692 RVA: 0x0000C2DD File Offset: 0x0000A4DD
		public unsafe List<PathPoint> connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPoint.NativeFieldInfoPtr_connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PathPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPoint.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x000C5384 File Offset: 0x000C3584
		// (set) Token: 0x0600163E RID: 5694 RVA: 0x0000C2FC File Offset: 0x0000A4FC
		public unsafe bool unique
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPoint.NativeFieldInfoPtr_unique);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPoint.NativeFieldInfoPtr_unique)) = value;
			}
		}

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeFieldInfoPtr_connections;

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeFieldInfoPtr_unique;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
