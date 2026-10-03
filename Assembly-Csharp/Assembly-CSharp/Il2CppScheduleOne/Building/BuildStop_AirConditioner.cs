using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x0200045F RID: 1119
	public class BuildStop_AirConditioner : BuildStop_Base
	{
		// Token: 0x06006545 RID: 25925 RVA: 0x001DA54C File Offset: 0x001D874C
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStop_AirConditioner()
		{
			Il2CppClassPointerStore<BuildStop_AirConditioner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStop_AirConditioner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStop_AirConditioner>.NativeClassPtr);
			BuildStop_AirConditioner.NativeMethodInfoPtr_Stop_Building_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStop_AirConditioner>.NativeClassPtr, 100676596);
			BuildStop_AirConditioner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStop_AirConditioner>.NativeClassPtr, 100676597);
		}

		// Token: 0x06006546 RID: 25926 RVA: 0x001DA5A4 File Offset: 0x001D87A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212055, XrefRangeEnd = 212061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Stop_Building()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStop_AirConditioner.NativeMethodInfoPtr_Stop_Building_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006547 RID: 25927 RVA: 0x001DA5E0 File Offset: 0x001D87E0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStop_AirConditioner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStop_AirConditioner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStop_AirConditioner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006548 RID: 25928 RVA: 0x0002FB09 File Offset: 0x0002DD09
		public BuildStop_AirConditioner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040045CB RID: 17867
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Building_Public_Virtual_Void_0;

		// Token: 0x040045CC RID: 17868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
