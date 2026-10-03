using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005F5 RID: 1525
	public class InventoryPreset : ValueProviderScriptableObject<Inventory>
	{
		// Token: 0x0600956B RID: 38251 RVA: 0x00284D5C File Offset: 0x00282F5C
		// Note: this type is marked as 'beforefieldinit'.
		static InventoryPreset()
		{
			Il2CppClassPointerStore<InventoryPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "InventoryPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryPreset>.NativeClassPtr);
			InventoryPreset.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryPreset>.NativeClassPtr, "value");
			InventoryPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryPreset>.NativeClassPtr, 100682820);
			InventoryPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryPreset>.NativeClassPtr, 100682821);
		}

		// Token: 0x0600956C RID: 38252 RVA: 0x00284DC8 File Offset: 0x00282FC8
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Inventory GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InventoryPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Inventory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Inventory>(intPtr3) : null;
		}

		// Token: 0x0600956D RID: 38253 RVA: 0x00284E14 File Offset: 0x00283014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272278, XrefRangeEnd = 272281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InventoryPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600956E RID: 38254 RVA: 0x00045E98 File Offset: 0x00044098
		public InventoryPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E1D RID: 11805
		// (get) Token: 0x0600956F RID: 38255 RVA: 0x00284E50 File Offset: 0x00283050
		// (set) Token: 0x06009570 RID: 38256 RVA: 0x00045EA1 File Offset: 0x000440A1
		public unsafe Inventory value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryPreset.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Inventory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InventoryPreset.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066E0 RID: 26336
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040066E1 RID: 26337
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Inventory_0;

		// Token: 0x040066E2 RID: 26338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
