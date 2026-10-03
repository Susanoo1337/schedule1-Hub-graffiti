using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000153 RID: 339
	public class Quest_OnTheGrind : Quest
	{
		// Token: 0x060021E0 RID: 8672 RVA: 0x000EAF80 File Offset: 0x000E9180
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_OnTheGrind()
		{
			Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_OnTheGrind");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr);
			Quest_OnTheGrind.NativeFieldInfoPtr_CompleteDealsEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr, "CompleteDealsEntry");
			Quest_OnTheGrind.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr, 100667679);
			Quest_OnTheGrind.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr, 100667680);
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x000EAFEC File Offset: 0x000E91EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111035, XrefRangeEnd = 111053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_OnTheGrind.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x000EB028 File Offset: 0x000E9228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111053, XrefRangeEnd = 111057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_OnTheGrind() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_OnTheGrind.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x00012122 File Offset: 0x00010322
		public Quest_OnTheGrind(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x000EB064 File Offset: 0x000E9264
		// (set) Token: 0x060021E5 RID: 8677 RVA: 0x0001212B File Offset: 0x0001032B
		public unsafe QuestEntry CompleteDealsEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_OnTheGrind.NativeFieldInfoPtr_CompleteDealsEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_OnTheGrind.NativeFieldInfoPtr_CompleteDealsEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001770 RID: 6000
		private static readonly IntPtr NativeFieldInfoPtr_CompleteDealsEntry;

		// Token: 0x04001771 RID: 6001
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0;

		// Token: 0x04001772 RID: 6002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
