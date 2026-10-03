using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x02000696 RID: 1686
	public class NPCActionList : Object
	{
		// Token: 0x0600A48F RID: 42127 RVA: 0x002BB664 File Offset: 0x002B9864
		// Note: this type is marked as 'beforefieldinit'.
		static NPCActionList()
		{
			Il2CppClassPointerStore<NPCActionList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCActionList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCActionList>.NativeClassPtr);
			NPCActionList.NativeFieldInfoPtr_actionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCActionList>.NativeClassPtr, "actionList");
			NPCActionList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCActionList>.NativeClassPtr, 100685096);
		}

		// Token: 0x0600A490 RID: 42128 RVA: 0x002BB6BC File Offset: 0x002B98BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288840, XrefRangeEnd = 288848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCActionList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCActionList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCActionList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A491 RID: 42129 RVA: 0x0004B40A File Offset: 0x0004960A
		public NPCActionList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700317B RID: 12667
		// (get) Token: 0x0600A492 RID: 42130 RVA: 0x002BB6F8 File Offset: 0x002B98F8
		// (set) Token: 0x0600A493 RID: 42131 RVA: 0x0004B413 File Offset: 0x00049613
		public unsafe List<NPCAction> actionList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCActionList.NativeFieldInfoPtr_actionList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCActionList.NativeFieldInfoPtr_actionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040071CA RID: 29130
		private static readonly IntPtr NativeFieldInfoPtr_actionList;

		// Token: 0x040071CB RID: 29131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
