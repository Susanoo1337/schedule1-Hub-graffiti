using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000159 RID: 345
	public class Quest_Warehouse : Quest
	{
		// Token: 0x06002245 RID: 8773 RVA: 0x0001243F File Offset: 0x0001063F
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_Warehouse()
		{
			Il2CppClassPointerStore<Quest_Warehouse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_Warehouse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_Warehouse>.NativeClassPtr);
			Quest_Warehouse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Warehouse>.NativeClassPtr, 100667731);
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x000EC304 File Offset: 0x000EA504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111578, XrefRangeEnd = 111582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_Warehouse() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_Warehouse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Warehouse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x00012478 File Offset: 0x00010678
		public Quest_Warehouse(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040017AF RID: 6063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
