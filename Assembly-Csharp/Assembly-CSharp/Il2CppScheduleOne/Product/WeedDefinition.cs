using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Effects;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200056E RID: 1390
	[Serializable]
	public class WeedDefinition : ProductDefinition
	{
		// Token: 0x06007ED5 RID: 32469 RVA: 0x0022F6D4 File Offset: 0x0022D8D4
		// Note: this type is marked as 'beforefieldinit'.
		static WeedDefinition()
		{
			Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "WeedDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr);
			WeedDefinition.NativeFieldInfoPtr_MainMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "MainMat");
			WeedDefinition.NativeFieldInfoPtr_SecondaryMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "SecondaryMat");
			WeedDefinition.NativeFieldInfoPtr_LeafMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "LeafMat");
			WeedDefinition.NativeFieldInfoPtr_StemMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "StemMat");
			WeedDefinition.NativeFieldInfoPtr_appearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "appearance");
			WeedDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679672);
			WeedDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Effect_List_1_EDrugType_WeedAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679673);
			WeedDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679674);
			WeedDefinition.NativeMethodInfoPtr_GenerateAppearanceSettings_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679675);
			WeedDefinition.NativeMethodInfoPtr_ApplyAppearanceSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679676);
			WeedDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_WeedAppearanceSettings_List_1_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679677);
			WeedDefinition.NativeMethodInfoPtr_GetMaterial_Public_Material_EWeedAppearanceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679678);
			WeedDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679679);
		}

		// Token: 0x06007ED6 RID: 32470 RVA: 0x0022F808 File Offset: 0x0022DA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242462, XrefRangeEnd = 242466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007ED7 RID: 32471 RVA: 0x0022F860 File Offset: 0x0022DA60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242480, RefRangeEnd = 242481, XrefRangeStart = 242466, XrefRangeEnd = 242480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(List<Effect> properties, List<EDrugType> drugTypes, WeedAppearanceSettings _appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drugTypes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_appearance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Effect_List_1_EDrugType_WeedAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007ED8 RID: 32472 RVA: 0x0022F8C8 File Offset: 0x0022DAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242481, XrefRangeEnd = 242497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ProductData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductData>(intPtr3) : null;
		}

		// Token: 0x06007ED9 RID: 32473 RVA: 0x0022F914 File Offset: 0x0022DB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242497, XrefRangeEnd = 242501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GenerateAppearanceSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedDefinition.NativeMethodInfoPtr_GenerateAppearanceSettings_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EDA RID: 32474 RVA: 0x0022F950 File Offset: 0x0022DB50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 242539, RefRangeEnd = 242541, XrefRangeStart = 242501, XrefRangeEnd = 242539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAppearanceSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.NativeMethodInfoPtr_ApplyAppearanceSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EDB RID: 32475 RVA: 0x0022F984 File Offset: 0x0022DB84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242620, RefRangeEnd = 242621, XrefRangeStart = 242541, XrefRangeEnd = 242620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WeedAppearanceSettings GetAppearanceSettings(List<Effect> properties)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_WeedAppearanceSettings_List_1_Effect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeedAppearanceSettings>(intPtr3) : null;
		}

		// Token: 0x06007EDC RID: 32476 RVA: 0x0022F9C8 File Offset: 0x0022DBC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 152176, RefRangeEnd = 152179, XrefRangeStart = 152176, XrefRangeEnd = 152179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetMaterial(WeedAppearanceSettings.EWeedAppearanceType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.NativeMethodInfoPtr_GetMaterial_Public_Material_EWeedAppearanceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06007EDD RID: 32477 RVA: 0x0022FA14 File Offset: 0x0022DC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EDE RID: 32478 RVA: 0x0003C26E File Offset: 0x0003A46E
		public WeedDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002728 RID: 10024
		// (get) Token: 0x06007EDF RID: 32479 RVA: 0x0022FA50 File Offset: 0x0022DC50
		// (set) Token: 0x06007EE0 RID: 32480 RVA: 0x0003C277 File Offset: 0x0003A477
		public unsafe Material MainMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_MainMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_MainMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002729 RID: 10025
		// (get) Token: 0x06007EE1 RID: 32481 RVA: 0x0022FA80 File Offset: 0x0022DC80
		// (set) Token: 0x06007EE2 RID: 32482 RVA: 0x0003C296 File Offset: 0x0003A496
		public unsafe Material SecondaryMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_SecondaryMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_SecondaryMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700272A RID: 10026
		// (get) Token: 0x06007EE3 RID: 32483 RVA: 0x0022FAB0 File Offset: 0x0022DCB0
		// (set) Token: 0x06007EE4 RID: 32484 RVA: 0x0003C2B5 File Offset: 0x0003A4B5
		public unsafe Material LeafMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_LeafMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_LeafMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700272B RID: 10027
		// (get) Token: 0x06007EE5 RID: 32485 RVA: 0x0022FAE0 File Offset: 0x0022DCE0
		// (set) Token: 0x06007EE6 RID: 32486 RVA: 0x0003C2D4 File Offset: 0x0003A4D4
		public unsafe Material StemMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_StemMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_StemMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700272C RID: 10028
		// (get) Token: 0x06007EE7 RID: 32487 RVA: 0x0022FB10 File Offset: 0x0022DD10
		// (set) Token: 0x06007EE8 RID: 32488 RVA: 0x0003C2F3 File Offset: 0x0003A4F3
		public unsafe WeedAppearanceSettings appearance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_appearance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeedAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_appearance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400569A RID: 22170
		private static readonly IntPtr NativeFieldInfoPtr_MainMat;

		// Token: 0x0400569B RID: 22171
		private static readonly IntPtr NativeFieldInfoPtr_SecondaryMat;

		// Token: 0x0400569C RID: 22172
		private static readonly IntPtr NativeFieldInfoPtr_LeafMat;

		// Token: 0x0400569D RID: 22173
		private static readonly IntPtr NativeFieldInfoPtr_StemMat;

		// Token: 0x0400569E RID: 22174
		private static readonly IntPtr NativeFieldInfoPtr_appearance;

		// Token: 0x0400569F RID: 22175
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040056A0 RID: 22176
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_List_1_Effect_List_1_EDrugType_WeedAppearanceSettings_0;

		// Token: 0x040056A1 RID: 22177
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0;

		// Token: 0x040056A2 RID: 22178
		private static readonly IntPtr NativeMethodInfoPtr_GenerateAppearanceSettings_Public_Virtual_Void_0;

		// Token: 0x040056A3 RID: 22179
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAppearanceSettings_Private_Void_0;

		// Token: 0x040056A4 RID: 22180
		private static readonly IntPtr NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_WeedAppearanceSettings_List_1_Effect_0;

		// Token: 0x040056A5 RID: 22181
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Public_Material_EWeedAppearanceType_0;

		// Token: 0x040056A6 RID: 22182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BE5 RID: 3045
		[ObfuscatedName("ScheduleOne.Product.WeedDefinition+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EC8A RID: 60554 RVA: 0x003954A4 File Offset: 0x003936A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr);
				WeedDefinition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr, "<>9");
				WeedDefinition.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr, "<>9__10_0");
				WeedDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr, 100679681);
				WeedDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__10_0_Internal_Int32_Effect_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr, 100679682);
			}

			// Token: 0x0600EC8B RID: 60555 RVA: 0x00395520 File Offset: 0x00393720
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC8C RID: 60556 RVA: 0x0039555C File Offset: 0x0039375C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAppearanceSettings_b__10_0(Effect x, Effect y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__10_0_Internal_Int32_Effect_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EC8D RID: 60557 RVA: 0x0006F999 File Offset: 0x0006DB99
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047B7 RID: 18359
			// (get) Token: 0x0600EC8E RID: 60558 RVA: 0x003955BC File Offset: 0x003937BC
			// (set) Token: 0x0600EC8F RID: 60559 RVA: 0x0006F9A2 File Offset: 0x0006DBA2
			public unsafe static WeedDefinition.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeedDefinition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeedDefinition.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeedDefinition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047B8 RID: 18360
			// (get) Token: 0x0600EC90 RID: 60560 RVA: 0x003955E4 File Offset: 0x003937E4
			// (set) Token: 0x0600EC91 RID: 60561 RVA: 0x0006F9B4 File Offset: 0x0006DBB4
			public unsafe static Comparison<Effect> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeedDefinition.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Effect>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeedDefinition.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A023 RID: 40995
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A024 RID: 40996
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x0400A025 RID: 40997
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A026 RID: 40998
			private static readonly IntPtr NativeMethodInfoPtr__GetAppearanceSettings_b__10_0_Internal_Int32_Effect_Effect_0;
		}
	}
}
