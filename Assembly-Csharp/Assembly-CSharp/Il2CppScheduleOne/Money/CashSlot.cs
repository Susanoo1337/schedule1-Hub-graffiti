using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Money
{
	// Token: 0x020002AB RID: 683
	public class CashSlot : HotbarSlot
	{
		// Token: 0x060034AB RID: 13483 RVA: 0x0012A6C4 File Offset: 0x001288C4
		// Note: this type is marked as 'beforefieldinit'.
		static CashSlot()
		{
			Il2CppClassPointerStore<CashSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Money", "CashSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashSlot>.NativeClassPtr);
			CashSlot.NativeFieldInfoPtr_MAX_CASH_PER_SLOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashSlot>.NativeClassPtr, "MAX_CASH_PER_SLOT");
			CashSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashSlot>.NativeClassPtr, 100669967);
			CashSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashSlot>.NativeClassPtr, 100669968);
			CashSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashSlot>.NativeClassPtr, 100669969);
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x0012A744 File Offset: 0x00128944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140315, XrefRangeEnd = 140319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearStoredInstance(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x0012A790 File Offset: 0x00128990
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanSlotAcceptCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x0012A7D8 File Offset: 0x001289D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140320, RefRangeEnd = 140322, XrefRangeStart = 140319, XrefRangeEnd = 140320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashSlot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x0001AD16 File Offset: 0x00018F16
		public CashSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x060034B0 RID: 13488 RVA: 0x0012A814 File Offset: 0x00128A14
		// (set) Token: 0x060034B1 RID: 13489 RVA: 0x0001AD1F File Offset: 0x00018F1F
		public unsafe static float MAX_CASH_PER_SLOT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashSlot.NativeFieldInfoPtr_MAX_CASH_PER_SLOT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashSlot.NativeFieldInfoPtr_MAX_CASH_PER_SLOT, (void*)(&value));
			}
		}

		// Token: 0x04002340 RID: 9024
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CASH_PER_SLOT;

		// Token: 0x04002341 RID: 9025
		private static readonly IntPtr NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0;

		// Token: 0x04002342 RID: 9026
		private static readonly IntPtr NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0;

		// Token: 0x04002343 RID: 9027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
