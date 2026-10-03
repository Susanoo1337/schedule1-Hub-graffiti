using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000155 RID: 341
	public class Quest_SecuringSupplies : Quest
	{
		// Token: 0x060021ED RID: 8685 RVA: 0x000EB208 File Offset: 0x000E9408
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_SecuringSupplies()
		{
			Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_SecuringSupplies");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr);
			Quest_SecuringSupplies.NativeFieldInfoPtr_Supplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr, "Supplier");
			Quest_SecuringSupplies.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr, 100667684);
			Quest_SecuringSupplies.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr, 100667685);
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x000EB274 File Offset: 0x000E9474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111087, XrefRangeEnd = 111089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_SecuringSupplies.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x000EB2B0 File Offset: 0x000E94B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111089, XrefRangeEnd = 111093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_SecuringSupplies() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SecuringSupplies.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x00012172 File Offset: 0x00010372
		public Quest_SecuringSupplies(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x060021F1 RID: 8689 RVA: 0x000EB2EC File Offset: 0x000E94EC
		// (set) Token: 0x060021F2 RID: 8690 RVA: 0x0001217B File Offset: 0x0001037B
		public unsafe Supplier Supplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SecuringSupplies.NativeFieldInfoPtr_Supplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SecuringSupplies.NativeFieldInfoPtr_Supplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001777 RID: 6007
		private static readonly IntPtr NativeFieldInfoPtr_Supplier;

		// Token: 0x04001778 RID: 6008
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0;

		// Token: 0x04001779 RID: 6009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
