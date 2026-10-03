using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppPathfinding;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020000E9 RID: 233
	public class PathGroup : Il2CppSystem.Object
	{
		// Token: 0x0600162D RID: 5677 RVA: 0x000C5124 File Offset: 0x000C3324
		// Note: this type is marked as 'beforefieldinit'.
		static PathGroup()
		{
			Il2CppClassPointerStore<PathGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "PathGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathGroup>.NativeClassPtr);
			PathGroup.NativeFieldInfoPtr_entryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, "entryPoint");
			PathGroup.NativeFieldInfoPtr_startToEntryPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, "startToEntryPath");
			PathGroup.NativeFieldInfoPtr_entryToExitPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, "entryToExitPath");
			PathGroup.NativeFieldInfoPtr_exitToDestinationPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, "exitToDestinationPath");
			PathGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathGroup>.NativeClassPtr, 100666421);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x000C51B8 File Offset: 0x000C33B8
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x0000C253 File Offset: 0x0000A453
		public PathGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001630 RID: 5680 RVA: 0x000C51F4 File Offset: 0x000C33F4
		// (set) Token: 0x06001631 RID: 5681 RVA: 0x0000C25C File Offset: 0x0000A45C
		public unsafe Vector3 entryPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_entryPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_entryPoint)) = value;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001632 RID: 5682 RVA: 0x000C521C File Offset: 0x000C341C
		// (set) Token: 0x06001633 RID: 5683 RVA: 0x0000C277 File Offset: 0x0000A477
		public unsafe Path startToEntryPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_startToEntryPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_startToEntryPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001634 RID: 5684 RVA: 0x000C524C File Offset: 0x000C344C
		// (set) Token: 0x06001635 RID: 5685 RVA: 0x0000C296 File Offset: 0x0000A496
		public unsafe Path entryToExitPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_entryToExitPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_entryToExitPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x000C527C File Offset: 0x000C347C
		// (set) Token: 0x06001637 RID: 5687 RVA: 0x0000C2B5 File Offset: 0x0000A4B5
		public unsafe Path exitToDestinationPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_exitToDestinationPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathGroup.NativeFieldInfoPtr_exitToDestinationPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeFieldInfoPtr_entryPoint;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeFieldInfoPtr_startToEntryPath;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeFieldInfoPtr_entryToExitPath;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeFieldInfoPtr_exitToDestinationPath;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
