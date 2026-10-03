using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.StationFramework;
using Il2CppScheduleOne.UI.Stations;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007D9 RID: 2009
	public class StationRecipeFieldUI : MonoBehaviour
	{
		// Token: 0x0600C443 RID: 50243 RVA: 0x0031D788 File Offset: 0x0031B988
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipeFieldUI()
		{
			Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "StationRecipeFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr);
			StationRecipeFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			StationRecipeFieldUI.NativeFieldInfoPtr_RecipeEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "RecipeEntry");
			StationRecipeFieldUI.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "None");
			StationRecipeFieldUI.NativeFieldInfoPtr_Mixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "Mixed");
			StationRecipeFieldUI.NativeFieldInfoPtr_ClearButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "ClearButton");
			StationRecipeFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_StationRecipeField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100688747);
			StationRecipeFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_StationRecipeField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100688748);
			StationRecipeFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_StationRecipeField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100688749);
			StationRecipeFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100688750);
			StationRecipeFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100688751);
			StationRecipeFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100688752);
			StationRecipeFieldUI.NativeMethodInfoPtr_OptionSelected_Private_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100688753);
			StationRecipeFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100688754);
			StationRecipeFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, 100688755);
		}

		// Token: 0x17003B95 RID: 15253
		// (get) Token: 0x0600C444 RID: 50244 RVA: 0x0031D8D0 File Offset: 0x0031BAD0
		// (set) Token: 0x0600C445 RID: 50245 RVA: 0x0031D910 File Offset: 0x0031BB10
		public unsafe List<StationRecipeField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_StationRecipeField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StationRecipeField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_StationRecipeField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C446 RID: 50246 RVA: 0x0031D954 File Offset: 0x0031BB54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324886, RefRangeEnd = 324887, XrefRangeStart = 324859, XrefRangeEnd = 324886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<StationRecipeField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_StationRecipeField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C447 RID: 50247 RVA: 0x0031D998 File Offset: 0x0031BB98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324913, RefRangeEnd = 324914, XrefRangeStart = 324887, XrefRangeEnd = 324913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(StationRecipe newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C448 RID: 50248 RVA: 0x0031D9DC File Offset: 0x0031BBDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 324925, RefRangeEnd = 324927, XrefRangeStart = 324914, XrefRangeEnd = 324925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C449 RID: 50249 RVA: 0x0031DA18 File Offset: 0x0031BC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324927, XrefRangeEnd = 324971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C44A RID: 50250 RVA: 0x0031DA4C File Offset: 0x0031BC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324971, XrefRangeEnd = 324986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionSelected(StationRecipe option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_OptionSelected_Private_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C44B RID: 50251 RVA: 0x0031DA90 File Offset: 0x0031BC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324986, XrefRangeEnd = 325001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C44C RID: 50252 RVA: 0x0031DAC4 File Offset: 0x0031BCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325001, XrefRangeEnd = 325009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C44D RID: 50253 RVA: 0x0005C8CD File Offset: 0x0005AACD
		public StationRecipeFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B90 RID: 15248
		// (get) Token: 0x0600C44E RID: 50254 RVA: 0x0031DB00 File Offset: 0x0031BD00
		// (set) Token: 0x0600C44F RID: 50255 RVA: 0x0005C8D6 File Offset: 0x0005AAD6
		public unsafe List<StationRecipeField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipeField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B91 RID: 15249
		// (get) Token: 0x0600C450 RID: 50256 RVA: 0x0031DB30 File Offset: 0x0031BD30
		// (set) Token: 0x0600C451 RID: 50257 RVA: 0x0005C8F5 File Offset: 0x0005AAF5
		public unsafe StationRecipeEntry RecipeEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_RecipeEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_RecipeEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B92 RID: 15250
		// (get) Token: 0x0600C452 RID: 50258 RVA: 0x0031DB60 File Offset: 0x0031BD60
		// (set) Token: 0x0600C453 RID: 50259 RVA: 0x0005C914 File Offset: 0x0005AB14
		public unsafe GameObject None
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_None);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_None), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B93 RID: 15251
		// (get) Token: 0x0600C454 RID: 50260 RVA: 0x0031DB90 File Offset: 0x0031BD90
		// (set) Token: 0x0600C455 RID: 50261 RVA: 0x0005C933 File Offset: 0x0005AB33
		public unsafe GameObject Mixed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_Mixed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_Mixed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B94 RID: 15252
		// (get) Token: 0x0600C456 RID: 50262 RVA: 0x0031DBC0 File Offset: 0x0031BDC0
		// (set) Token: 0x0600C457 RID: 50263 RVA: 0x0005C952 File Offset: 0x0005AB52
		public unsafe GameObject ClearButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_ClearButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldUI.NativeFieldInfoPtr_ClearButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040085FB RID: 34299
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x040085FC RID: 34300
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntry;

		// Token: 0x040085FD RID: 34301
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x040085FE RID: 34302
		private static readonly IntPtr NativeFieldInfoPtr_Mixed;

		// Token: 0x040085FF RID: 34303
		private static readonly IntPtr NativeFieldInfoPtr_ClearButton;

		// Token: 0x04008600 RID: 34304
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_StationRecipeField_0;

		// Token: 0x04008601 RID: 34305
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_StationRecipeField_0;

		// Token: 0x04008602 RID: 34306
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_StationRecipeField_0;

		// Token: 0x04008603 RID: 34307
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_StationRecipe_0;

		// Token: 0x04008604 RID: 34308
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x04008605 RID: 34309
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04008606 RID: 34310
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Private_Void_StationRecipe_0;

		// Token: 0x04008607 RID: 34311
		private static readonly IntPtr NativeMethodInfoPtr_ClearClicked_Public_Void_0;

		// Token: 0x04008608 RID: 34312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D5B RID: 3419
		[ObfuscatedName("ScheduleOne.UI.Management.StationRecipeFieldUI+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600FA99 RID: 64153 RVA: 0x003BDF08 File Offset: 0x003BC108
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeFieldUI>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr);
				StationRecipeFieldUI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr, "<>9");
				StationRecipeFieldUI.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr, "<>9__11_0");
				StationRecipeFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr, 100688757);
				StationRecipeFieldUI.__c.NativeMethodInfoPtr__Clicked_b__11_0_Internal_Boolean_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr, 100688758);
			}

			// Token: 0x0600FA9A RID: 64154 RVA: 0x003BDF84 File Offset: 0x003BC184
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeFieldUI.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA9B RID: 64155 RVA: 0x003BDFC0 File Offset: 0x003BC1C0
			[CallerCount(0)]
			public unsafe bool _Clicked_b__11_0(StationRecipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldUI.__c.NativeMethodInfoPtr__Clicked_b__11_0_Internal_Boolean_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FA9C RID: 64156 RVA: 0x00076924 File Offset: 0x00074B24
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C2B RID: 19499
			// (get) Token: 0x0600FA9D RID: 64157 RVA: 0x003BE010 File Offset: 0x003BC210
			// (set) Token: 0x0600FA9E RID: 64158 RVA: 0x0007692D File Offset: 0x00074B2D
			public unsafe static StationRecipeFieldUI.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationRecipeFieldUI.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldUI.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationRecipeFieldUI.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C2C RID: 19500
			// (get) Token: 0x0600FA9F RID: 64159 RVA: 0x003BE038 File Offset: 0x003BC238
			// (set) Token: 0x0600FAA0 RID: 64160 RVA: 0x0007693F File Offset: 0x00074B3F
			public unsafe static Func<StationRecipe, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationRecipeFieldUI.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StationRecipe, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationRecipeFieldUI.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A922 RID: 43298
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A923 RID: 43299
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x0400A924 RID: 43300
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A925 RID: 43301
			private static readonly IntPtr NativeMethodInfoPtr__Clicked_b__11_0_Internal_Boolean_StationRecipe_0;
		}
	}
}
