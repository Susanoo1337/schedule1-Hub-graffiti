using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002EB RID: 747
	public class StationRecipeField : ConfigField
	{
		// Token: 0x06003B26 RID: 15142 RVA: 0x00142268 File Offset: 0x00140468
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipeField()
		{
			Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "StationRecipeField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr);
			StationRecipeField.NativeFieldInfoPtr__SelectedRecipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, "<SelectedRecipe>k__BackingField");
			StationRecipeField.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, "Options");
			StationRecipeField.NativeFieldInfoPtr_onRecipeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, "onRecipeChanged");
			StationRecipeField.NativeMethodInfoPtr_get_SelectedRecipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100670862);
			StationRecipeField.NativeMethodInfoPtr_set_SelectedRecipe_Protected_set_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100670863);
			StationRecipeField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100670864);
			StationRecipeField.NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100670865);
			StationRecipeField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100670866);
			StationRecipeField.NativeMethodInfoPtr_GetData_Public_StationRecipeFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100670867);
			StationRecipeField.NativeMethodInfoPtr_Load_Public_Void_StationRecipeFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, 100670868);
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06003B27 RID: 15143 RVA: 0x00142360 File Offset: 0x00140560
		// (set) Token: 0x06003B28 RID: 15144 RVA: 0x001423A0 File Offset: 0x001405A0
		public unsafe StationRecipe SelectedRecipe
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_get_SelectedRecipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_set_SelectedRecipe_Protected_set_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B29 RID: 15145 RVA: 0x001423E4 File Offset: 0x001405E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149855, RefRangeEnd = 149856, XrefRangeStart = 149840, XrefRangeEnd = 149855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B2A RID: 15146 RVA: 0x00142430 File Offset: 0x00140630
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 149861, RefRangeEnd = 149864, XrefRangeStart = 149856, XrefRangeEnd = 149861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRecipe(StationRecipe recipe, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x00142480 File Offset: 0x00140680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149864, XrefRangeEnd = 149868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StationRecipeField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x001424C8 File Offset: 0x001406C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149880, RefRangeEnd = 149881, XrefRangeStart = 149868, XrefRangeEnd = 149880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_GetData_Public_StationRecipeFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldData>(intPtr3) : null;
		}

		// Token: 0x06003B2D RID: 15149 RVA: 0x00142508 File Offset: 0x00140708
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149897, RefRangeEnd = 149899, XrefRangeStart = 149881, XrefRangeEnd = 149897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(StationRecipeFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.NativeMethodInfoPtr_Load_Public_Void_StationRecipeFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x0001D9C4 File Offset: 0x0001BBC4
		public StationRecipeField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x06003B2F RID: 15151 RVA: 0x0014254C File Offset: 0x0014074C
		// (set) Token: 0x06003B30 RID: 15152 RVA: 0x0001D9CD File Offset: 0x0001BBCD
		public unsafe StationRecipe _SelectedRecipe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr__SelectedRecipe_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr__SelectedRecipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x06003B31 RID: 15153 RVA: 0x0014257C File Offset: 0x0014077C
		// (set) Token: 0x06003B32 RID: 15154 RVA: 0x0001D9EC File Offset: 0x0001BBEC
		public unsafe List<StationRecipe> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x06003B33 RID: 15155 RVA: 0x001425AC File Offset: 0x001407AC
		// (set) Token: 0x06003B34 RID: 15156 RVA: 0x0001DA0B File Offset: 0x0001BC0B
		public unsafe UnityEvent<StationRecipe> onRecipeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr_onRecipeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.NativeFieldInfoPtr_onRecipeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027E1 RID: 10209
		private static readonly IntPtr NativeFieldInfoPtr__SelectedRecipe_k__BackingField;

		// Token: 0x040027E2 RID: 10210
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x040027E3 RID: 10211
		private static readonly IntPtr NativeFieldInfoPtr_onRecipeChanged;

		// Token: 0x040027E4 RID: 10212
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedRecipe_Public_get_StationRecipe_0;

		// Token: 0x040027E5 RID: 10213
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedRecipe_Protected_set_Void_StationRecipe_0;

		// Token: 0x040027E6 RID: 10214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x040027E7 RID: 10215
		private static readonly IntPtr NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_Boolean_0;

		// Token: 0x040027E8 RID: 10216
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040027E9 RID: 10217
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_StationRecipeFieldData_0;

		// Token: 0x040027EA RID: 10218
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_StationRecipeFieldData_0;

		// Token: 0x02000A33 RID: 2611
		[ObfuscatedName("ScheduleOne.Management.StationRecipeField+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x0600DF2A RID: 57130 RVA: 0x0036F788 File Offset: 0x0036D988
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeField>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr);
				StationRecipeField.__c__DisplayClass10_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr, "data");
				StationRecipeField.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr, 100670869);
				StationRecipeField.__c__DisplayClass10_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr, 100670870);
			}

			// Token: 0x0600DF2B RID: 57131 RVA: 0x0036F7F0 File Offset: 0x0036D9F0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeField.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF2C RID: 57132 RVA: 0x0036F82C File Offset: 0x0036DA2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149837, XrefRangeEnd = 149840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Load_b__0(StationRecipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeField.__c__DisplayClass10_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DF2D RID: 57133 RVA: 0x0006917D File Offset: 0x0006737D
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F1 RID: 17393
			// (get) Token: 0x0600DF2E RID: 57134 RVA: 0x0036F87C File Offset: 0x0036DA7C
			// (set) Token: 0x0600DF2F RID: 57135 RVA: 0x00069186 File Offset: 0x00067386
			public unsafe StationRecipeFieldData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.__c__DisplayClass10_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeField.__c__DisplayClass10_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097FC RID: 38908
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040097FD RID: 38909
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097FE RID: 38910
			private static readonly IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_StationRecipe_0;
		}
	}
}
