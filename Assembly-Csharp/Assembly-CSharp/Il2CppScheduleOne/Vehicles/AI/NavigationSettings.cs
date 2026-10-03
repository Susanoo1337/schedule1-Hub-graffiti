using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020000E5 RID: 229
	public class NavigationSettings : Object
	{
		// Token: 0x0600160D RID: 5645 RVA: 0x000C4A40 File Offset: 0x000C2C40
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationSettings()
		{
			Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "NavigationSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr);
			NavigationSettings.NativeFieldInfoPtr_endAtRoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr, "endAtRoad");
			NavigationSettings.NativeFieldInfoPtr_ensureProximityToGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr, "ensureProximityToGraph");
			NavigationSettings.NativeFieldInfoPtr_teleportToGraphIfCalculationFails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr, "teleportToGraphIfCalculationFails");
			NavigationSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr, 100666374);
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x000C4AC0 File Offset: 0x000C2CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95333, XrefRangeEnd = 95334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x0000C17E File Offset: 0x0000A37E
		public NavigationSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001610 RID: 5648 RVA: 0x000C4AFC File Offset: 0x000C2CFC
		// (set) Token: 0x06001611 RID: 5649 RVA: 0x0000C187 File Offset: 0x0000A387
		public unsafe bool endAtRoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_endAtRoad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_endAtRoad)) = value;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001612 RID: 5650 RVA: 0x000C4B24 File Offset: 0x000C2D24
		// (set) Token: 0x06001613 RID: 5651 RVA: 0x0000C1A2 File Offset: 0x0000A3A2
		public unsafe bool ensureProximityToGraph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_ensureProximityToGraph);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_ensureProximityToGraph)) = value;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x000C4B4C File Offset: 0x000C2D4C
		// (set) Token: 0x06001615 RID: 5653 RVA: 0x0000C1BD File Offset: 0x0000A3BD
		public unsafe bool teleportToGraphIfCalculationFails
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_teleportToGraphIfCalculationFails);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationSettings.NativeFieldInfoPtr_teleportToGraphIfCalculationFails)) = value;
			}
		}

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeFieldInfoPtr_endAtRoad;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeFieldInfoPtr_ensureProximityToGraph;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeFieldInfoPtr_teleportToGraphIfCalculationFails;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
