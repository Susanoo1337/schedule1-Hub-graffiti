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
	// Token: 0x0200054A RID: 1354
	[Serializable]
	public class CocaineDefinition : ProductDefinition
	{
		// Token: 0x06007BC4 RID: 31684 RVA: 0x00222D90 File Offset: 0x00220F90
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineDefinition()
		{
			Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "CocaineDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr);
			CocaineDefinition.NativeFieldInfoPtr_RockMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, "RockMaterial");
			CocaineDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, "<AppearanceSettings>k__BackingField");
			CocaineDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_CocaineAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679189);
			CocaineDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_CocaineAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679190);
			CocaineDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679191);
			CocaineDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Effect_List_1_EDrugType_CocaineAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679192);
			CocaineDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679193);
			CocaineDefinition.NativeMethodInfoPtr_GenerateAppearanceSettings_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679194);
			CocaineDefinition.NativeMethodInfoPtr_ApplyAppearanceSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679195);
			CocaineDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_CocaineAppearanceSettings_List_1_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679196);
			CocaineDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679197);
		}

		// Token: 0x17002657 RID: 9815
		// (get) Token: 0x06007BC5 RID: 31685 RVA: 0x00222E9C File Offset: 0x0022109C
		// (set) Token: 0x06007BC6 RID: 31686 RVA: 0x00222EDC File Offset: 0x002210DC
		public unsafe CocaineAppearanceSettings AppearanceSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_CocaineAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CocaineAppearanceSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_CocaineAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007BC7 RID: 31687 RVA: 0x00222F20 File Offset: 0x00221120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235905, XrefRangeEnd = 235909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007BC8 RID: 31688 RVA: 0x00222F78 File Offset: 0x00221178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235909, XrefRangeEnd = 235923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(List<Effect> properties, List<EDrugType> drugTypes, CocaineAppearanceSettings _appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drugTypes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_appearance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Effect_List_1_EDrugType_CocaineAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BC9 RID: 31689 RVA: 0x00222FE0 File Offset: 0x002211E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235923, XrefRangeEnd = 235939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ProductData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductData>(intPtr3) : null;
		}

		// Token: 0x06007BCA RID: 31690 RVA: 0x0022302C File Offset: 0x0022122C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235939, XrefRangeEnd = 235942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GenerateAppearanceSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineDefinition.NativeMethodInfoPtr_GenerateAppearanceSettings_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BCB RID: 31691 RVA: 0x00223068 File Offset: 0x00221268
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 235953, RefRangeEnd = 235956, XrefRangeStart = 235942, XrefRangeEnd = 235953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAppearanceSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr_ApplyAppearanceSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BCC RID: 31692 RVA: 0x0022309C File Offset: 0x0022129C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236032, RefRangeEnd = 236033, XrefRangeStart = 235956, XrefRangeEnd = 236032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CocaineAppearanceSettings GetAppearanceSettings(List<Effect> properties)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_CocaineAppearanceSettings_List_1_Effect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CocaineAppearanceSettings>(intPtr3) : null;
		}

		// Token: 0x06007BCD RID: 31693 RVA: 0x002230E0 File Offset: 0x002212E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236033, XrefRangeEnd = 236034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BCE RID: 31694 RVA: 0x0003AFA0 File Offset: 0x000391A0
		public CocaineDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002655 RID: 9813
		// (get) Token: 0x06007BCF RID: 31695 RVA: 0x0022311C File Offset: 0x0022131C
		// (set) Token: 0x06007BD0 RID: 31696 RVA: 0x0003AFA9 File Offset: 0x000391A9
		public unsafe Material RockMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineDefinition.NativeFieldInfoPtr_RockMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineDefinition.NativeFieldInfoPtr_RockMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002656 RID: 9814
		// (get) Token: 0x06007BD1 RID: 31697 RVA: 0x0022314C File Offset: 0x0022134C
		// (set) Token: 0x06007BD2 RID: 31698 RVA: 0x0003AFC8 File Offset: 0x000391C8
		public unsafe CocaineAppearanceSettings _AppearanceSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CocaineAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005453 RID: 21587
		private static readonly IntPtr NativeFieldInfoPtr_RockMaterial;

		// Token: 0x04005454 RID: 21588
		private static readonly IntPtr NativeFieldInfoPtr__AppearanceSettings_k__BackingField;

		// Token: 0x04005455 RID: 21589
		private static readonly IntPtr NativeMethodInfoPtr_get_AppearanceSettings_Public_get_CocaineAppearanceSettings_0;

		// Token: 0x04005456 RID: 21590
		private static readonly IntPtr NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_CocaineAppearanceSettings_0;

		// Token: 0x04005457 RID: 21591
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005458 RID: 21592
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_List_1_Effect_List_1_EDrugType_CocaineAppearanceSettings_0;

		// Token: 0x04005459 RID: 21593
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0;

		// Token: 0x0400545A RID: 21594
		private static readonly IntPtr NativeMethodInfoPtr_GenerateAppearanceSettings_Public_Virtual_Void_0;

		// Token: 0x0400545B RID: 21595
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAppearanceSettings_Private_Void_0;

		// Token: 0x0400545C RID: 21596
		private static readonly IntPtr NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_CocaineAppearanceSettings_List_1_Effect_0;

		// Token: 0x0400545D RID: 21597
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BC5 RID: 3013
		[ObfuscatedName("ScheduleOne.Product.CocaineDefinition+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EB73 RID: 60275 RVA: 0x003923C0 File Offset: 0x003905C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr);
				CocaineDefinition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr, "<>9");
				CocaineDefinition.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr, "<>9__10_0");
				CocaineDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr, 100679199);
				CocaineDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__10_0_Internal_Int32_Effect_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr, 100679200);
			}

			// Token: 0x0600EB74 RID: 60276 RVA: 0x0039243C File Offset: 0x0039063C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB75 RID: 60277 RVA: 0x00392478 File Offset: 0x00390678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235903, XrefRangeEnd = 235905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAppearanceSettings_b__10_0(Effect x, Effect y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__10_0_Internal_Int32_Effect_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB76 RID: 60278 RVA: 0x0006F11A File Offset: 0x0006D31A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700476B RID: 18283
			// (get) Token: 0x0600EB77 RID: 60279 RVA: 0x003924D8 File Offset: 0x003906D8
			// (set) Token: 0x0600EB78 RID: 60280 RVA: 0x0006F123 File Offset: 0x0006D323
			public unsafe static CocaineDefinition.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CocaineDefinition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CocaineDefinition.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CocaineDefinition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700476C RID: 18284
			// (get) Token: 0x0600EB79 RID: 60281 RVA: 0x00392500 File Offset: 0x00390700
			// (set) Token: 0x0600EB7A RID: 60282 RVA: 0x0006F135 File Offset: 0x0006D335
			public unsafe static Comparison<Effect> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CocaineDefinition.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Effect>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CocaineDefinition.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009F86 RID: 40838
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009F87 RID: 40839
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04009F88 RID: 40840
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009F89 RID: 40841
			private static readonly IntPtr NativeMethodInfoPtr__GetAppearanceSettings_b__10_0_Internal_Int32_Effect_Effect_0;
		}
	}
}
