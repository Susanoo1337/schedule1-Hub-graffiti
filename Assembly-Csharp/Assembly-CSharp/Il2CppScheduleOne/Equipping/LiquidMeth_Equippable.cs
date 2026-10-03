using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x02000575 RID: 1397
	public class LiquidMeth_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06007F73 RID: 32627 RVA: 0x00231504 File Offset: 0x0022F704
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidMeth_Equippable()
		{
			Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "LiquidMeth_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr);
			LiquidMeth_Equippable.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr, "Visuals");
			LiquidMeth_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr, 100679729);
			LiquidMeth_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr, 100679730);
		}

		// Token: 0x06007F74 RID: 32628 RVA: 0x00231570 File Offset: 0x0022F770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243209, XrefRangeEnd = 243218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidMeth_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F75 RID: 32629 RVA: 0x002315C0 File Offset: 0x0022F7C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 243221, RefRangeEnd = 243226, XrefRangeStart = 243218, XrefRangeEnd = 243221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidMeth_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidMeth_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMeth_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F76 RID: 32630 RVA: 0x0003C85B File Offset: 0x0003AA5B
		public LiquidMeth_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700275B RID: 10075
		// (get) Token: 0x06007F77 RID: 32631 RVA: 0x002315FC File Offset: 0x0022F7FC
		// (set) Token: 0x06007F78 RID: 32632 RVA: 0x0003C864 File Offset: 0x0003AA64
		public unsafe LiquidMethVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_Equippable.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidMethVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_Equippable.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040056FF RID: 22271
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04005700 RID: 22272
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005701 RID: 22273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
