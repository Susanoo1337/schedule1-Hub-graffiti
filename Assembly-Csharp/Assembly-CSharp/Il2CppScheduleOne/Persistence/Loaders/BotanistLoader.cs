using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001DA RID: 474
	public class BotanistLoader : EmployeeLoader
	{
		// Token: 0x06002CA1 RID: 11425 RVA: 0x0010F52C File Offset: 0x0010D72C
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistLoader()
		{
			Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "BotanistLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr);
			BotanistLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr, 100669089);
			BotanistLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr, 100669090);
			BotanistLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr, 100669091);
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06002CA2 RID: 11426 RVA: 0x0010F598 File Offset: 0x0010D798
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130219, XrefRangeEnd = 130226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x0010F5DC File Offset: 0x0010D7DC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 130227, RefRangeEnd = 130237, XrefRangeStart = 130226, XrefRangeEnd = 130227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x0010F618 File Offset: 0x0010D818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130237, XrefRangeEnd = 130282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData saveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x00016E20 File Offset: 0x00015020
		public BotanistLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E9D RID: 7837
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001E9E RID: 7838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E9F RID: 7839
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0;

		// Token: 0x020009C0 RID: 2496
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.BotanistLoader+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600DBAE RID: 56238 RVA: 0x00365F40 File Offset: 0x00364140
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BotanistLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr);
				BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_botanist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr, "botanist");
				BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr, "configData");
				BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr, "data");
				BotanistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr, 100669092);
				BotanistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr, 100669093);
				BotanistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr, 100669094);
			}

			// Token: 0x0600DBAF RID: 56239 RVA: 0x00365FE4 File Offset: 0x003641E4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBB0 RID: 56240 RVA: 0x00366020 File Offset: 0x00364220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130188, XrefRangeEnd = 130206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBB1 RID: 56241 RVA: 0x00366054 File Offset: 0x00364254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130206, XrefRangeEnd = 130219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBB2 RID: 56242 RVA: 0x00067498 File Offset: 0x00065698
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004302 RID: 17154
			// (get) Token: 0x0600DBB3 RID: 56243 RVA: 0x00366088 File Offset: 0x00364288
			// (set) Token: 0x0600DBB4 RID: 56244 RVA: 0x000674A1 File Offset: 0x000656A1
			public unsafe Botanist botanist
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_botanist);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_botanist), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004303 RID: 17155
			// (get) Token: 0x0600DBB5 RID: 56245 RVA: 0x003660B8 File Offset: 0x003642B8
			// (set) Token: 0x0600DBB6 RID: 56246 RVA: 0x000674C0 File Offset: 0x000656C0
			public unsafe BotanistConfigurationData configData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BotanistConfigurationData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004304 RID: 17156
			// (get) Token: 0x0600DBB7 RID: 56247 RVA: 0x003660E8 File Offset: 0x003642E8
			// (set) Token: 0x0600DBB8 RID: 56248 RVA: 0x000674DF File Offset: 0x000656DF
			public unsafe BotanistData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BotanistData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009603 RID: 38403
			private static readonly IntPtr NativeFieldInfoPtr_botanist;

			// Token: 0x04009604 RID: 38404
			private static readonly IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x04009605 RID: 38405
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04009606 RID: 38406
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009607 RID: 38407
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04009608 RID: 38408
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;
		}
	}
}
