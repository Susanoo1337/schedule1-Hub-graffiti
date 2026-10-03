using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000231 RID: 561
	[Serializable]
	public class RouteListData : Object
	{
		// Token: 0x06002F06 RID: 12038 RVA: 0x001176C4 File Offset: 0x001158C4
		// Note: this type is marked as 'beforefieldinit'.
		static RouteListData()
		{
			Il2CppClassPointerStore<RouteListData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "RouteListData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteListData>.NativeClassPtr);
			RouteListData.NativeFieldInfoPtr_Routes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListData>.NativeClassPtr, "Routes");
			RouteListData.NativeMethodInfoPtr__ctor_Public_Void_List_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListData>.NativeClassPtr, 100669398);
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x0011771C File Offset: 0x0011591C
		[CallerCount(203)]
		[CachedScanResults(RefRangeStart = 19776, RefRangeEnd = 19979, XrefRangeStart = 19776, XrefRangeEnd = 19979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteListData(List<AdvancedTransitRouteData> routes) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteListData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(routes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListData.NativeMethodInfoPtr__ctor_Public_Void_List_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x00017EE3 File Offset: 0x000160E3
		public RouteListData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06002F09 RID: 12041 RVA: 0x00117768 File Offset: 0x00115968
		// (set) Token: 0x06002F0A RID: 12042 RVA: 0x00017EEC File Offset: 0x000160EC
		public unsafe List<AdvancedTransitRouteData> Routes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListData.NativeFieldInfoPtr_Routes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AdvancedTransitRouteData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListData.NativeFieldInfoPtr_Routes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FE7 RID: 8167
		private static readonly IntPtr NativeFieldInfoPtr_Routes;

		// Token: 0x04001FE8 RID: 8168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_AdvancedTransitRouteData_0;
	}
}
