using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200073D RID: 1853
	public class CashSlotUI : ItemSlotUI
	{
		// Token: 0x0600B35A RID: 45914 RVA: 0x00052BD1 File Offset: 0x00050DD1
		// Note: this type is marked as 'beforefieldinit'.
		static CashSlotUI()
		{
			Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CashSlotUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr);
			CashSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr, 100686833);
		}

		// Token: 0x0600B35B RID: 45915 RVA: 0x002EAD0C File Offset: 0x002E8F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302698, XrefRangeEnd = 302699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashSlotUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B35C RID: 45916 RVA: 0x00052C0A File Offset: 0x00050E0A
		public CashSlotUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04007B71 RID: 31601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
