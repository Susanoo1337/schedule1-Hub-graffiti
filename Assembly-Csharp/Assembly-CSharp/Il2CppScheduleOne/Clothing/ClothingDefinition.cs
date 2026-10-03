using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Clothing
{
	// Token: 0x02000426 RID: 1062
	[Serializable]
	public class ClothingDefinition : StorableItemDefinition
	{
		// Token: 0x06005DD3 RID: 24019 RVA: 0x001BEE50 File Offset: 0x001BD050
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingDefinition()
		{
			Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Clothing", "ClothingDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr);
			ClothingDefinition.NativeFieldInfoPtr_Slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "Slot");
			ClothingDefinition.NativeFieldInfoPtr_ApplicationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "ApplicationType");
			ClothingDefinition.NativeFieldInfoPtr_ClothingAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "ClothingAssetPath");
			ClothingDefinition.NativeFieldInfoPtr_Colorable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "Colorable");
			ClothingDefinition.NativeFieldInfoPtr_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "DefaultColor");
			ClothingDefinition.NativeFieldInfoPtr_SlotsToBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "SlotsToBlock");
			ClothingDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, 100675559);
			ClothingDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, 100675560);
		}

		// Token: 0x06005DD4 RID: 24020 RVA: 0x001BEF20 File Offset: 0x001BD120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200234, XrefRangeEnd = 200238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06005DD5 RID: 24021 RVA: 0x001BEF78 File Offset: 0x001BD178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200238, XrefRangeEnd = 200250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DD6 RID: 24022 RVA: 0x0002C728 File Offset: 0x0002A928
		public ClothingDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x06005DD7 RID: 24023 RVA: 0x001BEFB4 File Offset: 0x001BD1B4
		// (set) Token: 0x06005DD8 RID: 24024 RVA: 0x0002C731 File Offset: 0x0002A931
		public unsafe EClothingSlot Slot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_Slot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_Slot)) = value;
			}
		}

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x06005DD9 RID: 24025 RVA: 0x001BEFDC File Offset: 0x001BD1DC
		// (set) Token: 0x06005DDA RID: 24026 RVA: 0x0002C74C File Offset: 0x0002A94C
		public unsafe EClothingApplicationType ApplicationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_ApplicationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_ApplicationType)) = value;
			}
		}

		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x06005DDB RID: 24027 RVA: 0x001BF004 File Offset: 0x001BD204
		// (set) Token: 0x06005DDC RID: 24028 RVA: 0x0002C767 File Offset: 0x0002A967
		public unsafe string ClothingAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_ClothingAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_ClothingAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x06005DDD RID: 24029 RVA: 0x001BF02C File Offset: 0x001BD22C
		// (set) Token: 0x06005DDE RID: 24030 RVA: 0x0002C786 File Offset: 0x0002A986
		public unsafe bool Colorable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_Colorable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_Colorable)) = value;
			}
		}

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x06005DDF RID: 24031 RVA: 0x001BF054 File Offset: 0x001BD254
		// (set) Token: 0x06005DE0 RID: 24032 RVA: 0x0002C7A1 File Offset: 0x0002A9A1
		public unsafe EClothingColor DefaultColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_DefaultColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_DefaultColor)) = value;
			}
		}

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x06005DE1 RID: 24033 RVA: 0x001BF07C File Offset: 0x001BD27C
		// (set) Token: 0x06005DE2 RID: 24034 RVA: 0x0002C7BC File Offset: 0x0002A9BC
		public unsafe List<EClothingSlot> SlotsToBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_SlotsToBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EClothingSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_SlotsToBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400405D RID: 16477
		private static readonly IntPtr NativeFieldInfoPtr_Slot;

		// Token: 0x0400405E RID: 16478
		private static readonly IntPtr NativeFieldInfoPtr_ApplicationType;

		// Token: 0x0400405F RID: 16479
		private static readonly IntPtr NativeFieldInfoPtr_ClothingAssetPath;

		// Token: 0x04004060 RID: 16480
		private static readonly IntPtr NativeFieldInfoPtr_Colorable;

		// Token: 0x04004061 RID: 16481
		private static readonly IntPtr NativeFieldInfoPtr_DefaultColor;

		// Token: 0x04004062 RID: 16482
		private static readonly IntPtr NativeFieldInfoPtr_SlotsToBlock;

		// Token: 0x04004063 RID: 16483
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04004064 RID: 16484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
