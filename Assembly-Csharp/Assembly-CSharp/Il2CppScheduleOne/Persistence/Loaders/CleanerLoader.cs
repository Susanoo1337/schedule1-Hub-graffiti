using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001DC RID: 476
	public class CleanerLoader : EmployeeLoader
	{
		// Token: 0x06002CAB RID: 11435 RVA: 0x0010F7A4 File Offset: 0x0010D9A4
		// Note: this type is marked as 'beforefieldinit'.
		static CleanerLoader()
		{
			Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "CleanerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr);
			CleanerLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr, 100669101);
			CleanerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr, 100669102);
			CleanerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr, 100669103);
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x0010F810 File Offset: 0x0010DA10
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130394, XrefRangeEnd = 130401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x0010F854 File Offset: 0x0010DA54
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 130227, RefRangeEnd = 130237, XrefRangeStart = 130227, XrefRangeEnd = 130237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x0010F890 File Offset: 0x0010DA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130401, XrefRangeEnd = 130446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData saveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x00016E32 File Offset: 0x00015032
		public CleanerLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EA3 RID: 7843
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001EA4 RID: 7844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EA5 RID: 7845
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0;

		// Token: 0x020009C2 RID: 2498
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.CleanerLoader+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600DBC4 RID: 56260 RVA: 0x003662F0 File Offset: 0x003644F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CleanerLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr);
				CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_cleaner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, "cleaner");
				CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, "configData");
				CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, "data");
				CleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, 100669104);
				CleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, 100669105);
				CleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, 100669106);
			}

			// Token: 0x0600DBC5 RID: 56261 RVA: 0x00366394 File Offset: 0x00364594
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBC6 RID: 56262 RVA: 0x003663D0 File Offset: 0x003645D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130364, XrefRangeEnd = 130381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBC7 RID: 56263 RVA: 0x00366404 File Offset: 0x00364604
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130381, XrefRangeEnd = 130394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBC8 RID: 56264 RVA: 0x00067564 File Offset: 0x00065764
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004308 RID: 17160
			// (get) Token: 0x0600DBC9 RID: 56265 RVA: 0x00366438 File Offset: 0x00364638
			// (set) Token: 0x0600DBCA RID: 56266 RVA: 0x0006756D File Offset: 0x0006576D
			public unsafe Cleaner cleaner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_cleaner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_cleaner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004309 RID: 17161
			// (get) Token: 0x0600DBCB RID: 56267 RVA: 0x00366468 File Offset: 0x00364668
			// (set) Token: 0x0600DBCC RID: 56268 RVA: 0x0006758C File Offset: 0x0006578C
			public unsafe CleanerConfigurationData configData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CleanerConfigurationData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700430A RID: 17162
			// (get) Token: 0x0600DBCD RID: 56269 RVA: 0x00366498 File Offset: 0x00364698
			// (set) Token: 0x0600DBCE RID: 56270 RVA: 0x000675AB File Offset: 0x000657AB
			public unsafe CleanerData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CleanerData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400960F RID: 38415
			private static readonly IntPtr NativeFieldInfoPtr_cleaner;

			// Token: 0x04009610 RID: 38416
			private static readonly IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x04009611 RID: 38417
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04009612 RID: 38418
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009613 RID: 38419
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04009614 RID: 38420
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;
		}
	}
}
