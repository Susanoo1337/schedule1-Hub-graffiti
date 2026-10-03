using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x0200015B RID: 347
	public class Quest_WeNeedToCook : Quest
	{
		// Token: 0x0600225E RID: 8798 RVA: 0x000EC718 File Offset: 0x000EA918
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_WeNeedToCook()
		{
			Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_WeNeedToCook");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr);
			Quest_WeNeedToCook.NativeFieldInfoPtr_PrerequisiteQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr, "PrerequisiteQuests");
			Quest_WeNeedToCook.NativeFieldInfoPtr_MethSupplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr, "MethSupplier");
			Quest_WeNeedToCook.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr, 100667738);
			Quest_WeNeedToCook.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr, 100667739);
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x000EC798 File Offset: 0x000EA998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111644, XrefRangeEnd = 111647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_WeNeedToCook.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x000EC7D4 File Offset: 0x000EA9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111647, XrefRangeEnd = 111651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_WeNeedToCook() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_WeNeedToCook>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WeNeedToCook.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x00012557 File Offset: 0x00010757
		public Quest_WeNeedToCook(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x000EC810 File Offset: 0x000EAA10
		// (set) Token: 0x06002263 RID: 8803 RVA: 0x00012560 File Offset: 0x00010760
		public unsafe Il2CppReferenceArray<Quest> PrerequisiteQuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WeNeedToCook.NativeFieldInfoPtr_PrerequisiteQuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Quest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WeNeedToCook.NativeFieldInfoPtr_PrerequisiteQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002264 RID: 8804 RVA: 0x000EC840 File Offset: 0x000EAA40
		// (set) Token: 0x06002265 RID: 8805 RVA: 0x0001257F File Offset: 0x0001077F
		public unsafe Supplier MethSupplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WeNeedToCook.NativeFieldInfoPtr_MethSupplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WeNeedToCook.NativeFieldInfoPtr_MethSupplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017BD RID: 6077
		private static readonly IntPtr NativeFieldInfoPtr_PrerequisiteQuests;

		// Token: 0x040017BE RID: 6078
		private static readonly IntPtr NativeFieldInfoPtr_MethSupplier;

		// Token: 0x040017BF RID: 6079
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0;

		// Token: 0x040017C0 RID: 6080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
