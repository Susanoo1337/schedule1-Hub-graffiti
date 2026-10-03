using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020000E7 RID: 231
	public class RoadPath : Object
	{
		// Token: 0x06001626 RID: 5670 RVA: 0x000C5060 File Offset: 0x000C3260
		// Note: this type is marked as 'beforefieldinit'.
		static RoadPath()
		{
			Il2CppClassPointerStore<RoadPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "RoadPath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadPath>.NativeClassPtr);
			RoadPath.NativeFieldInfoPtr_vectorPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadPath>.NativeClassPtr, "vectorPath");
			RoadPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadPath>.NativeClassPtr, 100666420);
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x000C50B8 File Offset: 0x000C32B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95671, XrefRangeEnd = 95679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoadPath() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoadPath>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x0000C1FD File Offset: 0x0000A3FD
		public RoadPath(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x000C50F4 File Offset: 0x000C32F4
		// (set) Token: 0x0600162A RID: 5674 RVA: 0x0000C206 File Offset: 0x0000A406
		public unsafe List<PathPoint> vectorPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadPath.NativeFieldInfoPtr_vectorPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PathPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadPath.NativeFieldInfoPtr_vectorPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeFieldInfoPtr_vectorPath;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
