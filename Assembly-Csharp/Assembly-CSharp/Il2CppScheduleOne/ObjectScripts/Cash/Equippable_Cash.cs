using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.Cash
{
	// Token: 0x020005C2 RID: 1474
	public class Equippable_Cash : Equippable_Viewmodel
	{
		// Token: 0x06008F35 RID: 36661 RVA: 0x0026CD84 File Offset: 0x0026AF84
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Cash()
		{
			Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Cash", "Equippable_Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr);
			Equippable_Cash.NativeFieldInfoPtr_amountIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "amountIndex");
			Equippable_Cash.NativeFieldInfoPtr_Container_Under100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "Container_Under100");
			Equippable_Cash.NativeFieldInfoPtr_SingleNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "SingleNotes");
			Equippable_Cash.NativeFieldInfoPtr_Container_100_300 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "Container_100_300");
			Equippable_Cash.NativeFieldInfoPtr_Under300Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "Under300Stacks");
			Equippable_Cash.NativeFieldInfoPtr_Container_300Plus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "Container_300Plus");
			Equippable_Cash.NativeFieldInfoPtr_PlusStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "PlusStacks");
			Equippable_Cash.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100681865);
			Equippable_Cash.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100681866);
			Equippable_Cash.NativeMethodInfoPtr_UpdateCashVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100681867);
			Equippable_Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100681868);
		}

		// Token: 0x06008F36 RID: 36662 RVA: 0x0026CE90 File Offset: 0x0026B090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263092, XrefRangeEnd = 263102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cash.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F37 RID: 36663 RVA: 0x0026CEE0 File Offset: 0x0026B0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263102, XrefRangeEnd = 263111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cash.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F38 RID: 36664 RVA: 0x0026CF1C File Offset: 0x0026B11C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263164, RefRangeEnd = 263165, XrefRangeStart = 263111, XrefRangeEnd = 263164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCashVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cash.NativeMethodInfoPtr_UpdateCashVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F39 RID: 36665 RVA: 0x0026CF50 File Offset: 0x0026B150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F3A RID: 36666 RVA: 0x00043AAB File Offset: 0x00041CAB
		public Equippable_Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C67 RID: 11367
		// (get) Token: 0x06008F3B RID: 36667 RVA: 0x0026CF8C File Offset: 0x0026B18C
		// (set) Token: 0x06008F3C RID: 36668 RVA: 0x00043AB4 File Offset: 0x00041CB4
		public unsafe int amountIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_amountIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_amountIndex)) = value;
			}
		}

		// Token: 0x17002C68 RID: 11368
		// (get) Token: 0x06008F3D RID: 36669 RVA: 0x0026CFB4 File Offset: 0x0026B1B4
		// (set) Token: 0x06008F3E RID: 36670 RVA: 0x00043ACF File Offset: 0x00041CCF
		public unsafe Transform Container_Under100
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_Under100);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_Under100), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C69 RID: 11369
		// (get) Token: 0x06008F3F RID: 36671 RVA: 0x0026CFE4 File Offset: 0x0026B1E4
		// (set) Token: 0x06008F40 RID: 36672 RVA: 0x00043AEE File Offset: 0x00041CEE
		public unsafe List<Transform> SingleNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_SingleNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_SingleNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C6A RID: 11370
		// (get) Token: 0x06008F41 RID: 36673 RVA: 0x0026D014 File Offset: 0x0026B214
		// (set) Token: 0x06008F42 RID: 36674 RVA: 0x00043B0D File Offset: 0x00041D0D
		public unsafe Transform Container_100_300
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_100_300);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_100_300), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C6B RID: 11371
		// (get) Token: 0x06008F43 RID: 36675 RVA: 0x0026D044 File Offset: 0x0026B244
		// (set) Token: 0x06008F44 RID: 36676 RVA: 0x00043B2C File Offset: 0x00041D2C
		public unsafe List<Transform> Under300Stacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Under300Stacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Under300Stacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C6C RID: 11372
		// (get) Token: 0x06008F45 RID: 36677 RVA: 0x0026D074 File Offset: 0x0026B274
		// (set) Token: 0x06008F46 RID: 36678 RVA: 0x00043B4B File Offset: 0x00041D4B
		public unsafe Transform Container_300Plus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_300Plus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_300Plus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C6D RID: 11373
		// (get) Token: 0x06008F47 RID: 36679 RVA: 0x0026D0A4 File Offset: 0x0026B2A4
		// (set) Token: 0x06008F48 RID: 36680 RVA: 0x00043B6A File Offset: 0x00041D6A
		public unsafe List<Transform> PlusStacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_PlusStacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_PlusStacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006250 RID: 25168
		private static readonly IntPtr NativeFieldInfoPtr_amountIndex;

		// Token: 0x04006251 RID: 25169
		private static readonly IntPtr NativeFieldInfoPtr_Container_Under100;

		// Token: 0x04006252 RID: 25170
		private static readonly IntPtr NativeFieldInfoPtr_SingleNotes;

		// Token: 0x04006253 RID: 25171
		private static readonly IntPtr NativeFieldInfoPtr_Container_100_300;

		// Token: 0x04006254 RID: 25172
		private static readonly IntPtr NativeFieldInfoPtr_Under300Stacks;

		// Token: 0x04006255 RID: 25173
		private static readonly IntPtr NativeFieldInfoPtr_Container_300Plus;

		// Token: 0x04006256 RID: 25174
		private static readonly IntPtr NativeFieldInfoPtr_PlusStacks;

		// Token: 0x04006257 RID: 25175
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006258 RID: 25176
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04006259 RID: 25177
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCashVisuals_Private_Void_0;

		// Token: 0x0400625A RID: 25178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
