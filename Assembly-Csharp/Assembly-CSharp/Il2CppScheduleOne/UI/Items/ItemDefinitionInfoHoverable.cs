using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000826 RID: 2086
	public class ItemDefinitionInfoHoverable : MonoBehaviour
	{
		// Token: 0x0600CAC0 RID: 51904 RVA: 0x0033196C File Offset: 0x0032FB6C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemDefinitionInfoHoverable()
		{
			Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemDefinitionInfoHoverable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr);
			ItemDefinitionInfoHoverable.NativeFieldInfoPtr_AssignedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr, "AssignedItem");
			ItemDefinitionInfoHoverable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr, 100689456);
		}

		// Token: 0x0600CAC1 RID: 51905 RVA: 0x003319C4 File Offset: 0x0032FBC4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemDefinitionInfoHoverable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDefinitionInfoHoverable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemDefinitionInfoHoverable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CAC2 RID: 51906 RVA: 0x00060274 File Offset: 0x0005E474
		public ItemDefinitionInfoHoverable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D93 RID: 15763
		// (get) Token: 0x0600CAC3 RID: 51907 RVA: 0x00331A00 File Offset: 0x0032FC00
		// (set) Token: 0x0600CAC4 RID: 51908 RVA: 0x0006027D File Offset: 0x0005E47D
		public unsafe ItemDefinition AssignedItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinitionInfoHoverable.NativeFieldInfoPtr_AssignedItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinitionInfoHoverable.NativeFieldInfoPtr_AssignedItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008A0E RID: 35342
		private static readonly IntPtr NativeFieldInfoPtr_AssignedItem;

		// Token: 0x04008A0F RID: 35343
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
