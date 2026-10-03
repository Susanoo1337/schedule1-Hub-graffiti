using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005F4 RID: 1524
	[Serializable]
	public class Inventory : Object
	{
		// Token: 0x0600954F RID: 38223 RVA: 0x002849A0 File Offset: 0x00282BA0
		// Note: this type is marked as 'beforefieldinit'.
		static Inventory()
		{
			Il2CppClassPointerStore<Inventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "Inventory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Inventory>.NativeClassPtr);
			Inventory.NativeFieldInfoPtr_InventorySlotCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "InventorySlotCount");
			Inventory.NativeFieldInfoPtr_ClearInventoryOnNewDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "ClearInventoryOnNewDay");
			Inventory.NativeFieldInfoPtr_RandomizeInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "RandomizeInventory");
			Inventory.NativeFieldInfoPtr_AllowDuplicateRandomItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "AllowDuplicateRandomItems");
			Inventory.NativeFieldInfoPtr_RandomInventoryItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "RandomInventoryItems");
			Inventory.NativeFieldInfoPtr_RandomizeCash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "RandomizeCash");
			Inventory.NativeFieldInfoPtr_MinRandomCash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "MinRandomCash");
			Inventory.NativeFieldInfoPtr_MaxRandomCash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "MaxRandomCash");
			Inventory.NativeFieldInfoPtr_StartingInventoryItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "StartingInventoryItems");
			Inventory.NativeFieldInfoPtr_CanBePickpocketed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "CanBePickpocketed");
			Inventory.NativeFieldInfoPtr_PickpocketDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "PickpocketDifficulty");
			Inventory.NativeFieldInfoPtr_DefaultCombatWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "DefaultCombatWeapon");
			Inventory.NativeMethodInfoPtr_GetCopy_Public_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100682817);
			Inventory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory>.NativeClassPtr, 100682818);
		}

		// Token: 0x06009550 RID: 38224 RVA: 0x00284AE8 File Offset: 0x00282CE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 272276, RefRangeEnd = 272277, XrefRangeStart = 272255, XrefRangeEnd = 272276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Inventory GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Inventory.NativeMethodInfoPtr_GetCopy_Public_Inventory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Inventory>(intPtr3) : null;
		}

		// Token: 0x06009551 RID: 38225 RVA: 0x00284B28 File Offset: 0x00282D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272277, XrefRangeEnd = 272278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Inventory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Inventory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Inventory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009552 RID: 38226 RVA: 0x00045D3F File Offset: 0x00043F3F
		public Inventory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E11 RID: 11793
		// (get) Token: 0x06009553 RID: 38227 RVA: 0x00284B64 File Offset: 0x00282D64
		// (set) Token: 0x06009554 RID: 38228 RVA: 0x00045D48 File Offset: 0x00043F48
		public unsafe int InventorySlotCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_InventorySlotCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_InventorySlotCount)) = value;
			}
		}

		// Token: 0x17002E12 RID: 11794
		// (get) Token: 0x06009555 RID: 38229 RVA: 0x00284B8C File Offset: 0x00282D8C
		// (set) Token: 0x06009556 RID: 38230 RVA: 0x00045D63 File Offset: 0x00043F63
		public unsafe bool ClearInventoryOnNewDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_ClearInventoryOnNewDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_ClearInventoryOnNewDay)) = value;
			}
		}

		// Token: 0x17002E13 RID: 11795
		// (get) Token: 0x06009557 RID: 38231 RVA: 0x00284BB4 File Offset: 0x00282DB4
		// (set) Token: 0x06009558 RID: 38232 RVA: 0x00045D7E File Offset: 0x00043F7E
		public unsafe bool RandomizeInventory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_RandomizeInventory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_RandomizeInventory)) = value;
			}
		}

		// Token: 0x17002E14 RID: 11796
		// (get) Token: 0x06009559 RID: 38233 RVA: 0x00284BDC File Offset: 0x00282DDC
		// (set) Token: 0x0600955A RID: 38234 RVA: 0x00045D99 File Offset: 0x00043F99
		public unsafe bool AllowDuplicateRandomItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_AllowDuplicateRandomItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_AllowDuplicateRandomItems)) = value;
			}
		}

		// Token: 0x17002E15 RID: 11797
		// (get) Token: 0x0600955B RID: 38235 RVA: 0x00284C04 File Offset: 0x00282E04
		// (set) Token: 0x0600955C RID: 38236 RVA: 0x00045DB4 File Offset: 0x00043FB4
		public unsafe Il2CppReferenceArray<Inventory.WeightedItem> RandomInventoryItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_RandomInventoryItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Inventory.WeightedItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_RandomInventoryItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E16 RID: 11798
		// (get) Token: 0x0600955D RID: 38237 RVA: 0x00284C34 File Offset: 0x00282E34
		// (set) Token: 0x0600955E RID: 38238 RVA: 0x00045DD3 File Offset: 0x00043FD3
		public unsafe bool RandomizeCash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_RandomizeCash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_RandomizeCash)) = value;
			}
		}

		// Token: 0x17002E17 RID: 11799
		// (get) Token: 0x0600955F RID: 38239 RVA: 0x00284C5C File Offset: 0x00282E5C
		// (set) Token: 0x06009560 RID: 38240 RVA: 0x00045DEE File Offset: 0x00043FEE
		public unsafe int MinRandomCash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_MinRandomCash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_MinRandomCash)) = value;
			}
		}

		// Token: 0x17002E18 RID: 11800
		// (get) Token: 0x06009561 RID: 38241 RVA: 0x00284C84 File Offset: 0x00282E84
		// (set) Token: 0x06009562 RID: 38242 RVA: 0x00045E09 File Offset: 0x00044009
		public unsafe int MaxRandomCash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_MaxRandomCash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_MaxRandomCash)) = value;
			}
		}

		// Token: 0x17002E19 RID: 11801
		// (get) Token: 0x06009563 RID: 38243 RVA: 0x00284CAC File Offset: 0x00282EAC
		// (set) Token: 0x06009564 RID: 38244 RVA: 0x00045E24 File Offset: 0x00044024
		public unsafe Il2CppReferenceArray<ItemDefinition> StartingInventoryItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_StartingInventoryItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_StartingInventoryItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E1A RID: 11802
		// (get) Token: 0x06009565 RID: 38245 RVA: 0x00284CDC File Offset: 0x00282EDC
		// (set) Token: 0x06009566 RID: 38246 RVA: 0x00045E43 File Offset: 0x00044043
		public unsafe bool CanBePickpocketed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_CanBePickpocketed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_CanBePickpocketed)) = value;
			}
		}

		// Token: 0x17002E1B RID: 11803
		// (get) Token: 0x06009567 RID: 38247 RVA: 0x00284D04 File Offset: 0x00282F04
		// (set) Token: 0x06009568 RID: 38248 RVA: 0x00045E5E File Offset: 0x0004405E
		public unsafe float PickpocketDifficulty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_PickpocketDifficulty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_PickpocketDifficulty)) = value;
			}
		}

		// Token: 0x17002E1C RID: 11804
		// (get) Token: 0x06009569 RID: 38249 RVA: 0x00284D2C File Offset: 0x00282F2C
		// (set) Token: 0x0600956A RID: 38250 RVA: 0x00045E79 File Offset: 0x00044079
		public unsafe AvatarWeapon DefaultCombatWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_DefaultCombatWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarWeapon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.NativeFieldInfoPtr_DefaultCombatWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066D2 RID: 26322
		private static readonly IntPtr NativeFieldInfoPtr_InventorySlotCount;

		// Token: 0x040066D3 RID: 26323
		private static readonly IntPtr NativeFieldInfoPtr_ClearInventoryOnNewDay;

		// Token: 0x040066D4 RID: 26324
		private static readonly IntPtr NativeFieldInfoPtr_RandomizeInventory;

		// Token: 0x040066D5 RID: 26325
		private static readonly IntPtr NativeFieldInfoPtr_AllowDuplicateRandomItems;

		// Token: 0x040066D6 RID: 26326
		private static readonly IntPtr NativeFieldInfoPtr_RandomInventoryItems;

		// Token: 0x040066D7 RID: 26327
		private static readonly IntPtr NativeFieldInfoPtr_RandomizeCash;

		// Token: 0x040066D8 RID: 26328
		private static readonly IntPtr NativeFieldInfoPtr_MinRandomCash;

		// Token: 0x040066D9 RID: 26329
		private static readonly IntPtr NativeFieldInfoPtr_MaxRandomCash;

		// Token: 0x040066DA RID: 26330
		private static readonly IntPtr NativeFieldInfoPtr_StartingInventoryItems;

		// Token: 0x040066DB RID: 26331
		private static readonly IntPtr NativeFieldInfoPtr_CanBePickpocketed;

		// Token: 0x040066DC RID: 26332
		private static readonly IntPtr NativeFieldInfoPtr_PickpocketDifficulty;

		// Token: 0x040066DD RID: 26333
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCombatWeapon;

		// Token: 0x040066DE RID: 26334
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Inventory_0;

		// Token: 0x040066DF RID: 26335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C3C RID: 3132
		[Serializable]
		public class WeightedItem : Object
		{
			// Token: 0x0600EF58 RID: 61272 RVA: 0x0039D5F0 File Offset: 0x0039B7F0
			// Note: this type is marked as 'beforefieldinit'.
			static WeightedItem()
			{
				Il2CppClassPointerStore<Inventory.WeightedItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Inventory>.NativeClassPtr, "WeightedItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Inventory.WeightedItem>.NativeClassPtr);
				Inventory.WeightedItem.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory.WeightedItem>.NativeClassPtr, "Item");
				Inventory.WeightedItem.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Inventory.WeightedItem>.NativeClassPtr, "Weight");
				Inventory.WeightedItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Inventory.WeightedItem>.NativeClassPtr, 100682819);
			}

			// Token: 0x0600EF59 RID: 61273 RVA: 0x0039D658 File Offset: 0x0039B858
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WeightedItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Inventory.WeightedItem>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Inventory.WeightedItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF5A RID: 61274 RVA: 0x00070FB2 File Offset: 0x0006F1B2
			public WeightedItem(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700488E RID: 18574
			// (get) Token: 0x0600EF5B RID: 61275 RVA: 0x0039D694 File Offset: 0x0039B894
			// (set) Token: 0x0600EF5C RID: 61276 RVA: 0x00070FBB File Offset: 0x0006F1BB
			public unsafe ItemDefinition Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.WeightedItem.NativeFieldInfoPtr_Item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.WeightedItem.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700488F RID: 18575
			// (get) Token: 0x0600EF5D RID: 61277 RVA: 0x0039D6C4 File Offset: 0x0039B8C4
			// (set) Token: 0x0600EF5E RID: 61278 RVA: 0x00070FDA File Offset: 0x0006F1DA
			public unsafe float Weight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.WeightedItem.NativeFieldInfoPtr_Weight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Inventory.WeightedItem.NativeFieldInfoPtr_Weight)) = value;
				}
			}

			// Token: 0x0400A20C RID: 41484
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x0400A20D RID: 41485
			private static readonly IntPtr NativeFieldInfoPtr_Weight;

			// Token: 0x0400A20E RID: 41486
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
