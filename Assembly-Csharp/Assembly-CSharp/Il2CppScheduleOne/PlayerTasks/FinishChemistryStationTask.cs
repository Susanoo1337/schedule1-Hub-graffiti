using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000183 RID: 387
	public class FinishChemistryStationTask : Task
	{
		// Token: 0x06002757 RID: 10071 RVA: 0x00014B4E File Offset: 0x00012D4E
		// Note: this type is marked as 'beforefieldinit'.
		static FinishChemistryStationTask()
		{
			Il2CppClassPointerStore<FinishChemistryStationTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "FinishChemistryStationTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinishChemistryStationTask>.NativeClassPtr);
			FinishChemistryStationTask.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishChemistryStationTask>.NativeClassPtr, 100668344);
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x000FD1E0 File Offset: 0x000FB3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119054, XrefRangeEnd = 119055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FinishChemistryStationTask() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinishChemistryStationTask>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishChemistryStationTask.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x00014B87 File Offset: 0x00012D87
		public FinishChemistryStationTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001B19 RID: 6937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
