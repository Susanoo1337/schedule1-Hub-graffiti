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
	// Token: 0x02000554 RID: 1364
	[Serializable]
	public class MethDefinition : ProductDefinition
	{
		// Token: 0x06007C13 RID: 31763 RVA: 0x00223F84 File Offset: 0x00222184
		// Note: this type is marked as 'beforefieldinit'.
		static MethDefinition()
		{
			Il2CppClassPointerStore<MethDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "MethDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr);
			MethDefinition.NativeFieldInfoPtr_CrystalMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, "CrystalMaterial");
			MethDefinition.NativeFieldInfoPtr_TintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, "TintColor");
			MethDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, "<AppearanceSettings>k__BackingField");
			MethDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_MethAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679229);
			MethDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_MethAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679230);
			MethDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679231);
			MethDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Effect_List_1_EDrugType_MethAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679232);
			MethDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679233);
			MethDefinition.NativeMethodInfoPtr_GenerateAppearanceSettings_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679234);
			MethDefinition.NativeMethodInfoPtr_ApplyAppearanceSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679235);
			MethDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_MethAppearanceSettings_List_1_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679236);
			MethDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679237);
		}

		// Token: 0x17002668 RID: 9832
		// (get) Token: 0x06007C14 RID: 31764 RVA: 0x002240A4 File Offset: 0x002222A4
		// (set) Token: 0x06007C15 RID: 31765 RVA: 0x002240E4 File Offset: 0x002222E4
		public unsafe MethAppearanceSettings AppearanceSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_MethAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethAppearanceSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_MethAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007C16 RID: 31766 RVA: 0x00224128 File Offset: 0x00222328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236248, XrefRangeEnd = 236252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007C17 RID: 31767 RVA: 0x00224180 File Offset: 0x00222380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236252, XrefRangeEnd = 236266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(List<Effect> properties, List<EDrugType> drugTypes, MethAppearanceSettings _appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drugTypes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_appearance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Effect_List_1_EDrugType_MethAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C18 RID: 31768 RVA: 0x002241E8 File Offset: 0x002223E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236266, XrefRangeEnd = 236282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ProductData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductData>(intPtr3) : null;
		}

		// Token: 0x06007C19 RID: 31769 RVA: 0x00224234 File Offset: 0x00222434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236282, XrefRangeEnd = 236285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GenerateAppearanceSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethDefinition.NativeMethodInfoPtr_GenerateAppearanceSettings_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C1A RID: 31770 RVA: 0x00224270 File Offset: 0x00222470
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 236296, RefRangeEnd = 236299, XrefRangeStart = 236285, XrefRangeEnd = 236296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAppearanceSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr_ApplyAppearanceSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C1B RID: 31771 RVA: 0x002242A4 File Offset: 0x002224A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236375, RefRangeEnd = 236376, XrefRangeStart = 236299, XrefRangeEnd = 236375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethAppearanceSettings GetAppearanceSettings(List<Effect> properties)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_MethAppearanceSettings_List_1_Effect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethAppearanceSettings>(intPtr3) : null;
		}

		// Token: 0x06007C1C RID: 31772 RVA: 0x002242E8 File Offset: 0x002224E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236376, XrefRangeEnd = 236377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C1D RID: 31773 RVA: 0x0003B14E File Offset: 0x0003934E
		public MethDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002665 RID: 9829
		// (get) Token: 0x06007C1E RID: 31774 RVA: 0x00224324 File Offset: 0x00222524
		// (set) Token: 0x06007C1F RID: 31775 RVA: 0x0003B157 File Offset: 0x00039357
		public unsafe Material CrystalMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr_CrystalMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr_CrystalMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002666 RID: 9830
		// (get) Token: 0x06007C20 RID: 31776 RVA: 0x00224354 File Offset: 0x00222554
		// (set) Token: 0x06007C21 RID: 31777 RVA: 0x0003B176 File Offset: 0x00039376
		public unsafe Color TintColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr_TintColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr_TintColor)) = value;
			}
		}

		// Token: 0x17002667 RID: 9831
		// (get) Token: 0x06007C22 RID: 31778 RVA: 0x0022437C File Offset: 0x0022257C
		// (set) Token: 0x06007C23 RID: 31779 RVA: 0x0003B191 File Offset: 0x00039391
		public unsafe MethAppearanceSettings _AppearanceSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400549E RID: 21662
		private static readonly IntPtr NativeFieldInfoPtr_CrystalMaterial;

		// Token: 0x0400549F RID: 21663
		private static readonly IntPtr NativeFieldInfoPtr_TintColor;

		// Token: 0x040054A0 RID: 21664
		private static readonly IntPtr NativeFieldInfoPtr__AppearanceSettings_k__BackingField;

		// Token: 0x040054A1 RID: 21665
		private static readonly IntPtr NativeMethodInfoPtr_get_AppearanceSettings_Public_get_MethAppearanceSettings_0;

		// Token: 0x040054A2 RID: 21666
		private static readonly IntPtr NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_MethAppearanceSettings_0;

		// Token: 0x040054A3 RID: 21667
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040054A4 RID: 21668
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_List_1_Effect_List_1_EDrugType_MethAppearanceSettings_0;

		// Token: 0x040054A5 RID: 21669
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0;

		// Token: 0x040054A6 RID: 21670
		private static readonly IntPtr NativeMethodInfoPtr_GenerateAppearanceSettings_Public_Virtual_Void_0;

		// Token: 0x040054A7 RID: 21671
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAppearanceSettings_Private_Void_0;

		// Token: 0x040054A8 RID: 21672
		private static readonly IntPtr NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_MethAppearanceSettings_List_1_Effect_0;

		// Token: 0x040054A9 RID: 21673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BC6 RID: 3014
		[ObfuscatedName("ScheduleOne.Product.MethDefinition+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EB7B RID: 60283 RVA: 0x00392528 File Offset: 0x00390728
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr);
				MethDefinition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr, "<>9");
				MethDefinition.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr, "<>9__11_0");
				MethDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr, 100679239);
				MethDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__11_0_Internal_Int32_Effect_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr, 100679240);
			}

			// Token: 0x0600EB7C RID: 60284 RVA: 0x003925A4 File Offset: 0x003907A4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB7D RID: 60285 RVA: 0x003925E0 File Offset: 0x003907E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAppearanceSettings_b__11_0(Effect x, Effect y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__11_0_Internal_Int32_Effect_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB7E RID: 60286 RVA: 0x0006F147 File Offset: 0x0006D347
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700476D RID: 18285
			// (get) Token: 0x0600EB7F RID: 60287 RVA: 0x00392640 File Offset: 0x00390840
			// (set) Token: 0x0600EB80 RID: 60288 RVA: 0x0006F150 File Offset: 0x0006D350
			public unsafe static MethDefinition.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MethDefinition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethDefinition.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MethDefinition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700476E RID: 18286
			// (get) Token: 0x0600EB81 RID: 60289 RVA: 0x00392668 File Offset: 0x00390868
			// (set) Token: 0x0600EB82 RID: 60290 RVA: 0x0006F162 File Offset: 0x0006D362
			public unsafe static Comparison<Effect> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MethDefinition.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Effect>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MethDefinition.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009F8A RID: 40842
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009F8B RID: 40843
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04009F8C RID: 40844
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009F8D RID: 40845
			private static readonly IntPtr NativeMethodInfoPtr__GetAppearanceSettings_b__11_0_Internal_Int32_Effect_Effect_0;
		}
	}
}
