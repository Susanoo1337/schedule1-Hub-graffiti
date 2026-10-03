using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001E0 RID: 480
	public class LegacyCleanerLoader : LegacyEmployeeLoader
	{
		// Token: 0x06002CC0 RID: 11456 RVA: 0x0010FD04 File Offset: 0x0010DF04
		// Note: this type is marked as 'beforefieldinit'.
		static LegacyCleanerLoader()
		{
			Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "LegacyCleanerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr);
			LegacyCleanerLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr, 100669127);
			LegacyCleanerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr, 100669128);
			LegacyCleanerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr, 100669129);
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x0010FD70 File Offset: 0x0010DF70
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130751, XrefRangeEnd = 130758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyCleanerLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x0010FDB4 File Offset: 0x0010DFB4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 130514, RefRangeEnd = 130524, XrefRangeStart = 130514, XrefRangeEnd = 130524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LegacyCleanerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyCleanerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x0010FDF0 File Offset: 0x0010DFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130758, XrefRangeEnd = 130838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyCleanerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x00016E56 File Offset: 0x00015056
		public LegacyCleanerLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EB0 RID: 7856
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001EB1 RID: 7857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EB2 RID: 7858
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x020009C9 RID: 2505
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.LegacyCleanerLoader+<>c__DisplayClass3_0")]
		public new sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600DBF9 RID: 56313 RVA: 0x00366B78 File Offset: 0x00364D78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_0>.NativeClassPtr);
				LegacyCleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_cleaner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, "cleaner");
				LegacyCleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_0>.NativeClassPtr, 100669130);
			}

			// Token: 0x0600DBFA RID: 56314 RVA: 0x00366BCC File Offset: 0x00364DCC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyCleanerLoader.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBFB RID: 56315 RVA: 0x00067736 File Offset: 0x00065936
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004315 RID: 17173
			// (get) Token: 0x0600DBFC RID: 56316 RVA: 0x00366C08 File Offset: 0x00364E08
			// (set) Token: 0x0600DBFD RID: 56317 RVA: 0x0006773F File Offset: 0x0006593F
			public unsafe Cleaner cleaner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_cleaner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_0.NativeFieldInfoPtr_cleaner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009629 RID: 38441
			private static readonly IntPtr NativeFieldInfoPtr_cleaner;

			// Token: 0x0400962A RID: 38442
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009CA RID: 2506
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.LegacyCleanerLoader+<>c__DisplayClass3_1")]
		public sealed class __c__DisplayClass3_1 : Object
		{
			// Token: 0x0600DBFE RID: 56318 RVA: 0x00366C38 File Offset: 0x00364E38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr, "<>c__DisplayClass3_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_1>.NativeClassPtr);
				LegacyCleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_1>.NativeClassPtr, "configData");
				LegacyCleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_1>.NativeClassPtr, "CS$<>8__locals1");
				LegacyCleanerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_1>.NativeClassPtr, 100669131);
				LegacyCleanerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_1>.NativeClassPtr, 100669132);
			}

			// Token: 0x0600DBFF RID: 56319 RVA: 0x00366CB4 File Offset: 0x00364EB4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyCleanerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC00 RID: 56320 RVA: 0x00366CF0 File Offset: 0x00364EF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130721, XrefRangeEnd = 130738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyCleanerLoader.__c__DisplayClass3_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC01 RID: 56321 RVA: 0x0006775E File Offset: 0x0006595E
			public __c__DisplayClass3_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004316 RID: 17174
			// (get) Token: 0x0600DC02 RID: 56322 RVA: 0x00366D24 File Offset: 0x00364F24
			// (set) Token: 0x0600DC03 RID: 56323 RVA: 0x00067767 File Offset: 0x00065967
			public unsafe CleanerConfigurationData configData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CleanerConfigurationData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_configData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004317 RID: 17175
			// (get) Token: 0x0600DC04 RID: 56324 RVA: 0x00366D54 File Offset: 0x00364F54
			// (set) Token: 0x0600DC05 RID: 56325 RVA: 0x00067786 File Offset: 0x00065986
			public unsafe LegacyCleanerLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LegacyCleanerLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400962B RID: 38443
			private static readonly IntPtr NativeFieldInfoPtr_configData;

			// Token: 0x0400962C RID: 38444
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x0400962D RID: 38445
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400962E RID: 38446
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x020009CB RID: 2507
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.LegacyCleanerLoader+<>c__DisplayClass3_2")]
		public sealed class __c__DisplayClass3_2 : Object
		{
			// Token: 0x0600DC06 RID: 56326 RVA: 0x00366D84 File Offset: 0x00364F84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_2()
			{
				Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LegacyCleanerLoader>.NativeClassPtr, "<>c__DisplayClass3_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_2>.NativeClassPtr);
				LegacyCleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_2>.NativeClassPtr, "data");
				LegacyCleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_2>.NativeClassPtr, "CS$<>8__locals2");
				LegacyCleanerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_2>.NativeClassPtr, 100669133);
				LegacyCleanerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_2>.NativeClassPtr, 100669134);
			}

			// Token: 0x0600DC07 RID: 56327 RVA: 0x00366E00 File Offset: 0x00365000
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyCleanerLoader.__c__DisplayClass3_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyCleanerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC08 RID: 56328 RVA: 0x00366E3C File Offset: 0x0036503C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130738, XrefRangeEnd = 130751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyCleanerLoader.__c__DisplayClass3_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC09 RID: 56329 RVA: 0x000677A5 File Offset: 0x000659A5
			public __c__DisplayClass3_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004318 RID: 17176
			// (get) Token: 0x0600DC0A RID: 56330 RVA: 0x00366E70 File Offset: 0x00365070
			// (set) Token: 0x0600DC0B RID: 56331 RVA: 0x000677AE File Offset: 0x000659AE
			public unsafe CleanerData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CleanerData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004319 RID: 17177
			// (get) Token: 0x0600DC0C RID: 56332 RVA: 0x00366EA0 File Offset: 0x003650A0
			// (set) Token: 0x0600DC0D RID: 56333 RVA: 0x000677CD File Offset: 0x000659CD
			public unsafe LegacyCleanerLoader.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LegacyCleanerLoader.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyCleanerLoader.__c__DisplayClass3_2.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400962F RID: 38447
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04009630 RID: 38448
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x04009631 RID: 38449
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009632 RID: 38450
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
