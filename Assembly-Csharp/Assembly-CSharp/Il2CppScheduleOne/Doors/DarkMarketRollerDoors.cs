using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x020003A4 RID: 932
	public class DarkMarketRollerDoors : SensorRollerDoors
	{
		// Token: 0x060054E3 RID: 21731 RVA: 0x001A1408 File Offset: 0x0019F608
		// Note: this type is marked as 'beforefieldinit'.
		static DarkMarketRollerDoors()
		{
			Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "DarkMarketRollerDoors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr);
			DarkMarketRollerDoors.NativeMethodInfoPtr_CanOpen_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr, 100674442);
			DarkMarketRollerDoors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr, 100674443);
		}

		// Token: 0x060054E4 RID: 21732 RVA: 0x001A1460 File Offset: 0x0019F660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188976, XrefRangeEnd = 188980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarketRollerDoors.NativeMethodInfoPtr_CanOpen_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x001A14A8 File Offset: 0x0019F6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188980, XrefRangeEnd = 188983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DarkMarketRollerDoors() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketRollerDoors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054E6 RID: 21734 RVA: 0x00028194 File Offset: 0x00026394
		public DarkMarketRollerDoors(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003A82 RID: 14978
		private static readonly IntPtr NativeMethodInfoPtr_CanOpen_Protected_Virtual_Boolean_0;

		// Token: 0x04003A83 RID: 14979
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
